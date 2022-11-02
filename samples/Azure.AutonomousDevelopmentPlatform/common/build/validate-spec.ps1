param
(
  [Parameter(Mandatory = $true)] $OpenApiSpecFile
)

$ErrorActionPreference = 'Stop'

autorest `
  --validation `
  --openapi-type=data-plane `
  --azure-validator `
  --use=@microsoft.azure/classic-openapi-validator@latest `
  --use=@microsoft.azure/openapi-validator@latest `
  --input-file=$OpenApiSpecFile

$status = $LASTEXITCODE

if ($status -eq 0) {
  Write-Host "Validation succeeded."
}
else {
  Write-Host "Validation failed! [exit code: $status]"
}

exit $status
