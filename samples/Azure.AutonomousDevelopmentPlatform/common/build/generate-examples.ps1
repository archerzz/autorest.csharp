param
(
  [Parameter(Mandatory = $true)] $OpenApiSpecFile
)

$ErrorActionPreference = 'Stop'

oav generate-examples $OpenApiSpecFile

$status = $LASTEXITCODE

if ($status -eq 0) {
  Write-Host "Examples generation succeeded."
}
else {
  Write-Host "Examples generation has failed! [exit code: $status]"
}

exit $status
