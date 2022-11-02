param
(
  [Parameter(Mandatory = $true)] $SourcePath,
  [Parameter(Mandatory = $true)] $OutputPath,
  [Parameter(Mandatory = $false)] $PathToAzureApiReviewRepository,
  [Parameter(Mandatory = $false)] $ApiVersionType = 'preview',
  [Parameter(Mandatory = $false)] $ApiVersion = '2022-11-30'
)

$ErrorActionPreference = 'Stop'

Import-Module $PSScriptRoot/utils.psm1 -Force

# Legacy - publish the generated OpenApi spec for code generation from backend
Write-Host "CMD: Copy-Item $SourcePath $OutputPath"
Copy-Item $SourcePath $OutputPath

# Replace API version from "2022-11-30-preview" to "2022-11-30-draftcompliant"
# Note, for API review we must use valid API version suffix. (Valid values: alpha, beta, preview, privatepreview)
(Get-Content -path $OutputPath) | Foreach-Object {
  $_ -replace "$ApiVersion-$ApiVersionType", "$ApiVersion-draftcompliant" `
    -replace "$ApiVersion_$ApiVersionType", "$ApiVersion_draftcompliant" `
} | Set-Content $OutputPath


$SourceParentDirectory = Split-Path -Path $SourcePath | Resolve-Path
$PathToDataPlaneInAzureApiReviewRepository = "$PathToAzureApiReviewRepository/../.."
$PathToCadlInAzureApiReviewRepository = "$PathToDataPlaneInAzureApiReviewRepository/cadl"

# Publish OpenApi spec and Examples
# 1. cleanup output folder (OpenAPi spec and examples)
if (Test-Path -Path $PathToAzureApiReviewRepository) {
  Write-Host "CMD: Remove-Item $PathToAzureApiReviewRepository"
  Remove-Item -Recurse -Force $PathToAzureApiReviewRepository
}

# 2. cleanup CADL project folder
if (Test-Path -Path $PathToCadlInAzureApiReviewRepository) {
  Write-Host "CMD: Remove-Item $PathToCadlInAzureApiReviewRepository"
  Remove-Item -Recurse -Force $PathToCadlInAzureApiReviewRepository
}

if (!(Test-Path -Path $PathToAzureApiReviewRepository)) {
  Write-Host "Creating the destination location (does not exist): $PathToAzureApiReviewRepository"
  mkdir -p $PathToAzureApiReviewRepository
}

if (!(Test-Path -Path $PathToCadlInAzureApiReviewRepository)) {
  Write-Host "Creating the destination location (does not exist): $PathToCadlInAzureApiReviewRepository"
  mkdir -p $PathToCadlInAzureApiReviewRepository
}

# resolve absolute path
$PathToCadlInAzureApiReviewRepository = $PathToCadlInAzureApiReviewRepository | Resolve-Path
$PathToDataPlaneInAzureApiReviewRepository = $PathToDataPlaneInAzureApiReviewRepository | Resolve-Path

Write-Host "CMD: Copy-Item -Recurse -Force $SourceParentDirectory $PathToAzureApiReviewRepository"
Copy-Item -Recurse -Force $SourceParentDirectory $PathToAzureApiReviewRepository

# copy cadl project
$ExcludeFiles = @('package-lock.json')
$ExcludeFolders = @('node_modules', 'generated')
$PathToCadlProjectSource = "$SourceParentDirectory/../../../../../.."  | Resolve-Path
Write-Host "CMD: Copy-Item-If-Match -SourceFolder $PathToCadlProjectSource -OutputFolder $PathToCadlInAzureApiReviewRepository -ExcludeFolders $ExcludeFolders -ExcludeFiles $ExcludeFiles"
Copy-Item-If-Match `
  -Force `
  -SourceFolder $PathToCadlProjectSource `
  -OutputFolder $PathToCadlInAzureApiReviewRepository `
  -ExcludeFolders $ExcludeFolders `
  -ExcludeFiles $ExcludeFiles

if (Test-Path -Path ./common/templates/readme.md.template ) {
  # Copy readme.md.template to the output folder
  Write-Host "CMD: Copy-Item ./common/templates/readme.md.template $PathToDataPlaneInAzureApiReviewRepository/readme.md"
  Copy-Item ./common/templates/readme.md.template "$PathToDataPlaneInAzureApiReviewRepository/readme.md"
}
else {
  Write-Host "The 'readme.md.template' file not found at location: ./common/templates/readme.md.template"
}


