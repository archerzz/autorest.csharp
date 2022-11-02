function Copy-Item-If-Match {
  [CmdletBinding()]
  param (
    [Parameter(Mandatory = $True)] $SourceFolder,
    [Parameter(Mandatory = $True)] $OutputFolder,
    [Parameter(Mandatory = $False)] $ExcludeFiles = @(),
    [Parameter(Mandatory = $False)] $ExcludeFolders = @(),
    [switch] $Force
  )

  $SourceFolder = $SourceFolder | Resolve-Path
  $OutputFolder = $OutputFolder | Resolve-Path

  Write-Host "SourceFolder -> $SourceFolder"
  Write-Host "OutputFolder -> $OutputFolder"

  #[regex] $ExcludeFoldersRegex = '(?i)' + (($ExcludeFolders | foreach { [regex]::escape($_) }) –join "|") + ''
  [regex] $ExcludeFoldersRegex = '' + (($ExcludeFolders | foreach { [regex]::escape($_) }) –join "|") + ''

  # test
  Get-ChildItem -Path $SourceFolder -Recurse -Exclude $ExcludeFiles | `
  Where-Object { $null -eq $ExcludeFolders -or $_.FullName.Replace($SourceFolder, "") -notmatch $ExcludeFoldersRegex } |
  Write-Host

  Get-ChildItem -Path $SourceFolder -Recurse -Exclude $ExcludeFiles | `
  Where-Object { $null -eq $ExcludeFolders -or $_.FullName.Replace($SourceFolder, "") -notmatch $ExcludeFoldersRegex } | `
  Copy-Item -Destination {
    if ($_.PSIsContainer) {
      Join-Path $OutputFolder $_.Parent.FullName.Replace($SourceFolder, "")
    }
    else {
      Join-Path $OutputFolder $_.FullName.Replace($SourceFolder, "")
    }
  } -Force -Exclude $ExcludeFiles
}

Export-ModuleMember -Function Copy-Item-If-Match
