param
(
  [Parameter(Mandatory = $true)] $InputOpenApiSpecFile,
  [Parameter(Mandatory = $true)] $OutputPath,
  [Parameter(Mandatory = $true)] $Namespace,
  [Parameter(Mandatory = $true)] $AutorestManifestFile
)

$ErrorActionPreference = 'Stop'

# The latest versions
$AutoRestVersion="3.6.2"
$AutoRestCoreVersion="3.9.2"
$AutoRestCSharpVersion="3.0.0-beta.20220923.1"
$AutoRestModelerFourVersion="4.24.3"

$AutoRestCommandArgs=@(
  "autorest@$AutoRestVersion",
  "--data-plane",
  "--version=$AutoRestCoreVersion",
  "--use=@autorest/csharp@$AutoRestCSharpVersion",
  "--use=@autorest/modelerfour@$AutoRestModelerFourVersion",
  "--skip-csproj",
  "--modelerfour.remove-empty-child-schemas",
  "--input-file=$InputOpenApiSpecFile",
  "--output-folder=$OutputPath",
  "--namespace=$Namespace",
  "$AutorestManifestFile"
  )

Write-Host "CMD: $AutoRestCommand $AutoRestCommandArgs"
& npx $AutoRestCommandArgs
