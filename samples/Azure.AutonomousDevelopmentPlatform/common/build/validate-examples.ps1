param
(
  [Parameter(Mandatory = $true)] $OpenApiSpecFile
)

$ErrorActionPreference = 'Stop'

oav validate-example $OpenApiSpecFile

$status = $LASTEXITCODE

if ($status -eq 0) {
  Write-Host "Examples validation succeeded."
}
else {
  Write-Host "Examples validation has failed! [exit code: $status]"
}

exit $status
