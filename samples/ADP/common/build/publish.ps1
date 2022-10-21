param
(
  [Parameter(Mandatory = $true)] $SourcePath,
  [Parameter(Mandatory = $true)] $OutputPath,
  [Parameter(Mandatory = $false)] $PathToAzureApiReviewRepository
)

$ErrorActionPreference = 'Stop'

Import-Module $PSScriptRoot/utils.psm1 -Force

Write-Host "CMD: Copy-Item $SourcePath $OutputPath"
Copy-Item $SourcePath $OutputPath

# Replace API version from "2022-11-30-preview" to "2022-11-30-draftcompliant"
# Note, for API review we must use valid API version suffix. (Valid values: alpha, beta, preview, privatepreview)
(Get-Content -path $OutputPath) | Foreach-Object {
  $_ -replace '2022-11-30-preview', '2022-11-30-draftcompliant' `
    -replace '2022_11_30_preview', '2022_11_30_draftcompliant' `
} | Set-Content $OutputPath

$SourceParentDirectory = Split-Path -Path $SourcePath
$SourceFileName = Split-Path -Leaf $SourcePath
$TargetOpenApiSpecFileName = "openapi.json"
$PathToExamples = "$SourceParentDirectory/examples"
$PathToReadMe = "$SourceParentDirectory/readme.md"
$PathToDataPlaneInAzureApiReviewRepository = "$PathToAzureApiReviewRepository/../../.."
$PathToCadlInAzureApiReviewRepository = "$PathToDataPlaneInAzureApiReviewRepository/cadl"

if ("$PathToAzureApiReviewRepository" -ne "") {
  if (!(Test-Path -Path $PathToCadlInAzureApiReviewRepository)) {
    Write-Host "Creating the destination location (does not exist): $PathToCadlInAzureApiReviewRepository"
    mkdir -p $PathToCadlInAzureApiReviewRepository

    # resolve absolute path
    $PathToCadlInAzureApiReviewRepository = $PathToCadlInAzureApiReviewRepository | Resolve-Path
  }

  if (!(Test-Path -Path $PathToAzureApiReviewRepository)) {
    Write-Host "Creating the destination location (does not exist): $PathToAzureApiReviewRepository"
    mkdir -p $PathToAzureApiReviewRepository
  }

  # Overwrite the examples in the folder used by AutoRest code generator
  # 1. cleanup target folder
  if (Test-Path -Path "$PathToAzureApiReviewRepository/examples") {
    Write-Host "CMD: Remove-Item $PathToAzureApiReviewRepository/examples"
    Remove-Item -Recurse -Force "$PathToAzureApiReviewRepository/examples"
  }

  mkdir -p "$PathToAzureApiReviewRepository/examples"

  $ExcludeFiles = @()
  $ExcludeFolders = @('examples\internal', 'public\classifications', 'public\measurements', 'public\sample')
  Write-Host "CMD: Copy-Item-If-Match -SourceFolder $PathToExamples -OutputFolder $PathToAzureApiReviewRepository/examples -ExcludeFolders $ExcludeFolders -ExcludeFiles $ExcludeFiles"
  Copy-Item-If-Match `
    -Force `
    -SourceFolder "$PathToExamples" `
    -OutputFolder "$PathToAzureApiReviewRepository/examples" `
    -ExcludeFolders $ExcludeFolders `
    -ExcludeFiles $ExcludeFiles

  Write-Host "CMD: Copy-Item -Recurse -Force $SourcePath $PathToAzureApiReviewRepository"
  Copy-Item -Recurse -Force $SourcePath $PathToAzureApiReviewRepository

  #rename spec
  Write-Host "CMD: Move-Item -Force $PathToAzureApiReviewRepository/$SourceFileName $PathToAzureApiReviewRepository/$TargetOpenApiSpecFileName"
  Move-Item -Force "$PathToAzureApiReviewRepository/$SourceFileName" "$PathToAzureApiReviewRepository/$TargetOpenApiSpecFileName"

  # copy cadl project
  $ExcludeFiles = @('package-lock.json')
  $ExcludeFolders = @('node_modules', 'examples\internal', 'public\classifications', 'public\measurements', 'public\sample', 'generated')
  Write-Host "CMD: Copy-Item-If-Match -SourceFolder $SourceParentDirectory/../../../../../cadl/data-plane -OutputFolder $PathToCadlInAzureApiReviewRepository -ExcludeFolders $ExcludeFolders -ExcludeFiles $ExcludeFiles"
  Copy-Item-If-Match `
    -Force `
    -SourceFolder "$SourceParentDirectory/../../../../../cadl/data-plane" `
    -OutputFolder $PathToCadlInAzureApiReviewRepository `
    -ExcludeFolders $ExcludeFolders `
    -ExcludeFiles $ExcludeFiles

  # Copy examples to data-plane folder
  Write-Host "CMD: Copy-Item -Recurse -Force $PathToCadlInAzureApiReviewRepository/examples $PathToDataPlaneInAzureApiReviewRepository"
  Copy-Item -Recurse -Force "$PathToCadlInAzureApiReviewRepository/examples" "$PathToDataPlaneInAzureApiReviewRepository"

  # copy renamed spec to output cadl directory
  Write-Host "CMD: Copy-Item -Force $PathToAzureApiReviewRepository/$SourceFileName $PathToDataPlaneInAzureApiReviewRepository/$TargetOpenApiSpecFileName"
  Copy-Item -Force "$PathToAzureApiReviewRepository/$TargetOpenApiSpecFileName" "$PathToDataPlaneInAzureApiReviewRepository/$TargetOpenApiSpecFileName"

  # copy readme.md to the root of PR repo 
  # Write-Host "CMD: Copy-Item $PathToReadMe $PathToAzureApiReviewRepository"
  # Copy-Item -Recurse -Force $PathToReadMe $PathToAzureApiReviewRepository

  # copy the updated readme.md to the data-plane root folder in PR repo
  Write-Host "CMD: Copy-Item $PathToReadMe $PathToDataPlaneInAzureApiReviewRepository"
  Copy-Item -Recurse -Force $PathToReadMe $PathToDataPlaneInAzureApiReviewRepository
}
