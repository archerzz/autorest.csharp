param
(
  [Parameter(Mandatory = $true)] $InputOpenApiSpecFile,
  [Parameter(Mandatory = $true)] $OutputPath,
  [Parameter(Mandatory = $true)] $Namespace,
  [Parameter(Mandatory = $true)] $AutorestManifestFile
)

$ErrorActionPreference = 'Stop'

$InputOpenApiSpecFile = $InputOpenApiSpecFile | Resolve-Path
$AutorestManifestFile = $AutorestManifestFile | Resolve-Path

# Example command:
# npx autorest@3.5.1 
# --version=3.7.2 
# --use=@autorest/csharp@3.0.0-beta.20211115.1 
# --use=@autorest/modelerfour@4.22.3 
# --input-file=C:\Users\igmakhli\source\repos\ADP\src\core\apispecs\apispec.core.dms.2022-03-01-draft.json 
# --output-folder=C:\Users\igmakhli\source\repos\ADP\src\core\clients\Clients.DataManagement.v2022_03/Generated 
# --namespace=Microsoft.Azure.Adp.Clients.DataManagement.v2022_03 
# --skip-csproj 
# --modelerfour.remove-empty-child-schemas 
# C:\Users\igmakhli\source\repos\ADP\src\core\clients\Clients.DataManagement.v2022_03/autorest.md

#Use the same versions as in official build
$AutoRestVersion="3.5.1"
$AutoRestCoreVersion="3.7.2"
$AutoRestCSharpVersion="3.0.0-beta.20211115.1"
$AutoRestModelerFourVersion="4.22.3"

$AutoRestCommandArgs=@(
  "autorest@$AutoRestVersion",
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
