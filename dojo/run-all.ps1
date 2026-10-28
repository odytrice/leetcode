param(
    [string[]]$Language = @('csharp', 'python', 'typescript', 'java', 'fsharp'),
    [switch]$Reference,
    [switch]$CheckOnly,
    [string[]]$Drill
)

$ErrorActionPreference = 'Stop'
$failed = @()
$summary = @()

foreach ($name in $Language) {
    $script = Join-Path $PSScriptRoot "$name/run-all.ps1"
    if (!(Test-Path $script)) { throw "Unknown language: $name" }
    Write-Output "`n===== $name ====="
    if ($Drill) {
        $output = @(& $script -Reference:$Reference -CheckOnly:$CheckOnly -Drill $Drill 2>&1)
    }
    else {
        $output = @(& $script -Reference:$Reference -CheckOnly:$CheckOnly 2>&1)
    }
    $code = $LASTEXITCODE
    $output | Write-Output
    $total = @($output | ForEach-Object { "$_".Trim() } | Where-Object { $_ -like 'TOTAL: *' } | Select-Object -Last 1)
    if ($total.Count -eq 1) { $summary += "$name -> $($total[0])" }
    if ($code -ne 0) { $failed += $name }
}

if ($failed.Count -gt 0) {
    Write-Output "`nFAILED LANGUAGES: $($failed -join ', ')"
    exit 1
}
Write-Output "`nAll selected languages passed."
foreach ($line in $summary) { Write-Output $line }
exit 0
