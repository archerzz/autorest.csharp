param
(
  [Parameter(Mandatory = $true)] $InputCadl,
  [Parameter(Mandatory = $true)] $OutputPath,
  [Parameter(Mandatory = $true)] $OutputFile,
  [Parameter(Mandatory = $false)] $Emitter = "@azure-tools/cadl-autorest",
  [Switch] $IsPublicApi
)

$ErrorActionPreference = 'Stop'

$PublicOrInternal = "internal"
if ($IsPublicApi) {
  $PublicOrInternal = "public"
}
$PathToExamples = "./examples/$PublicOrInternal"

# Cleanup output folder
if (Test-Path -Path $OutputPath) {
  Write-Host "CMD: Remove-Item $OutputPath/"
  Remove-Item -Recurse -Force "$OutputPath/"
}

$FullPathToOutputFile = Join-Path $OutputPath $OutputFile
$OutputPath = Split-Path -Path $FullPathToOutputFile
$OutputFile = Split-Path -Leaf $FullPathToOutputFile

Write-Host "CMD: npx cadl compile $InputCadl `
--output-path=$OutputPath `
--option @azure-tools/cadl-autorest.output-file=$OutputFile `
--option @azure-tools/cadl-autorest.examples-directory=$PathToExamples `
--option "@azure-tools/cadl-autorest.omit-unreachable-types=true" `
--emit=$Emitter"

npx cadl compile $InputCadl `
  --output-path=$OutputPath `
  --option "@azure-tools/cadl-autorest.output-file=$OutputFile" `
  --option "@azure-tools/cadl-autorest.examples-directory=$PathToExamples" `
  --option "@azure-tools/cadl-autorest.omit-unreachable-types=true" `
  --emit=$Emitter
# Note, there is an optional trace argument that could be useful for debugging the JavaScript code of a library
#  --trace *
  

Write-Host "Done"
