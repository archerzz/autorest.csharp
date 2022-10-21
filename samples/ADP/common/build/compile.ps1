param
(
  [Parameter(Mandatory = $true)] $InputCadl,
  [Parameter(Mandatory = $true)] $OutputPath,
  [Parameter(Mandatory = $false)] $Emitter = "@azure-tools/cadl-autorest",
  [Parameter(Mandatory = $false)] $TargetFileName = "openapi2.json",
  [Switch] $IsPublicApi
)

$ErrorActionPreference = 'Stop'


# Cleanup output folder
if (Test-Path -Path $OutputPath) {
  Write-Host "CMD: Remove-Item $OutputPath/"
  Remove-Item -Recurse -Force "$OutputPath/"
}

Write-Host "CMD: npx cadl compile $InputCadl --output-path=$OutputPath --emit=$Emitter"
npx cadl compile $InputCadl --output-path=$OutputPath --emit=$Emitter

if ($Emitter -eq "@cadl-lang/openapi3" -and $TargetFileName -eq "openapi2.json") {
  # set default output file name for V3 to openapi3.json 
  $TargetFileName = "openapi3.json"
}

if (Test-Path -Path $OutputPath/openapi.json ) {
  Write-Host "Renaming the generated $OutputPath/openapi.json to $OutputPath/$TargetFileName ..."
  Move-Item -Force "$OutputPath/openapi.json" "$OutputPath/$TargetFileName"

  # Copy readme.md.template to the output folder
  Write-Host "CMD: Copy-Item ./common/templates/readme.md.template $OutputPath/readme.md"
  Copy-Item ./common/templates/readme.md.template "$OutputPath/readme.md"
}
else {
  Write-Host "The 'readme.md.template' file not found at location: ./common/templates/readme.md.template"
}

# Copy examples to output folder
$PublicOrInternal = "internal"
if ($IsPublicApi) {
  $PublicOrInternal = "public"
}
$PathToExamples = "./examples/$PublicOrInternal"

if (Test-Path -Path $PathToExamples ) {
  Write-Host "CMD: Copy-Item $PathToExamples $OutputPath/examples/$PublicOrInternal"
  Copy-Item -Recurse -Force $PathToExamples "$OutputPath/examples/$PublicOrInternal"
}
else {
  Write-Host "Examples not found at location: $PathToExamples"
}

Write-Host "Done"
