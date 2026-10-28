param(
    [switch]$Reference,
    [switch]$CheckOnly
)

$ErrorActionPreference = 'Stop'
$html = Get-Content (Join-Path $PSScriptRoot '../../index.html') -Raw
$pattern = '<a href="https://leetcode.com/problems/([^/]+)/">([^<]+)(?:</a>)?\s*<span class="lc">#(\d+)</span>'
$linked = [regex]::Matches($html, $pattern) | ForEach-Object { [int]$_.Groups[3].Value } | Sort-Object -Unique
$drills = Get-ChildItem $PSScriptRoot -Directory | Where-Object { Test-Path (Join-Path $_.FullName 'PROBLEM.md') }
$ids = @()
foreach ($drill in $drills) {
    if ($drill.Name -notmatch '^(\d{3,})-') { throw "Invalid drill folder: $($drill.Name)" }
    $id = [int]$Matches[1]
    if ($drill.Name.Split('-')[0] -cne $id.ToString('D3')) { throw "Incorrect padding: $($drill.Name)" }
    $ids += $id
    foreach ($file in @('PROBLEM.md', 'Solution.cs', 'ReferenceSolution.cs', 'Program.cs')) {
        if (!(Test-Path (Join-Path $drill.FullName $file))) { throw "Missing $file in $($drill.Name)" }
    }
    if (@(Get-ChildItem $drill.FullName -Filter *.csproj).Count -ne 1) { throw "Expected one project in $($drill.Name)" }
}
if (@($ids | Sort-Object -Unique).Count -ne $ids.Count) { throw 'Duplicate LeetCode numbers' }
$difference = Compare-Object @($linked) @($ids | Sort-Object)
if ($difference) { throw "Cheat-sheet coverage mismatch: $($difference | Out-String)" }
Write-Output "Coverage: $($drills.Count)/$($linked.Count) linked problems have complete drills."
if ($CheckOnly) { exit 0 }

$failed = @()
$passedTests = 0
$totalTests = 0
foreach ($drill in ($drills | Sort-Object { [int]$_.Name.Split('-')[0] })) {
    Write-Output "`nDRILL: $($drill.Name)"
    $project = (Get-ChildItem $drill.FullName -Filter *.csproj).FullName
    $arguments = @('run', '--project', $project)
    if ($Reference) { $arguments += @('--', '--reference') }
    $output = @(& dotnet @arguments)
    $code = $LASTEXITCODE
    $output | Write-Output
    $summaries = @($output | Select-String '^([0-9]+)/([0-9]+) passed\.$')
    if ($code -ne 0 -or $summaries.Count -ne 1) { $failed += $drill.Name }
    if ($summaries.Count -eq 1) {
        $passedTests += [int]$summaries[0].Matches[0].Groups[1].Value
        $totalTests += [int]$summaries[0].Matches[0].Groups[2].Value
    }
}
Write-Output "`nTOTAL: $($drills.Count - $failed.Count)/$($drills.Count) drills passed; $passedTests/$totalTests tests passed."
if ($failed.Count -gt 0) { Write-Output "Failed drills: $($failed -join ', ')"; exit 1 }
exit 0
