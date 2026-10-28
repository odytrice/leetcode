param(
    [switch]$Reference,
    [switch]$CheckOnly,
    [string[]]$Drill
)

$ErrorActionPreference = 'Stop'
$html = Get-Content (Join-Path $PSScriptRoot '../../index.html') -Raw
$pattern = '<a href="https://leetcode.com/problems/([^/]+)/">([^<]+)(?:</a>)?\s*<span class="lc">#(\d+)</span>'
$linked = [regex]::Matches($html, $pattern) | ForEach-Object { [int]$_.Groups[3].Value } | Sort-Object -Unique
$drills = Get-ChildItem $PSScriptRoot -Directory | Where-Object { Test-Path (Join-Path $_.FullName 'PROBLEM.md') }
$ids = @()
foreach ($folder in $drills) {
    if ($folder.Name -notmatch '^(\d{3,})-') { throw "Invalid drill folder: $($folder.Name)" }
    $id = [int]$Matches[1]
    if ($folder.Name.Split('-')[0] -cne $id.ToString('D3')) { throw "Incorrect padding: $($folder.Name)" }
    $ids += $id
    foreach ($file in @('PROBLEM.md', 'Main.java', 'ReferenceSolution.java')) {
        if (!(Test-Path (Join-Path $folder.FullName $file))) { throw "Missing $file in $($folder.Name)" }
    }
    $practice = @(Get-ChildItem $folder.FullName -Filter *.java | Where-Object { $_.Name -notin @('Main.java', 'ReferenceSolution.java', 'Node.java', 'GraphNode.java', 'RandomNode.java') })
    if ($practice.Count -ne 1) { throw "Expected one practice class in $($folder.Name)" }
}
if (@($ids | Sort-Object -Unique).Count -ne $ids.Count) { throw 'Duplicate LeetCode numbers' }
if ($Drill) {
    $drills = @($drills | Where-Object { $Drill -contains $_.Name })
}
else {
    $difference = Compare-Object @($linked) @($ids | Sort-Object)
    if ($difference) { throw "Cheat-sheet coverage mismatch: $($difference | Out-String)" }
    Write-Output "Coverage: $($drills.Count)/$($linked.Count) linked problems have complete drills."
}
if ($CheckOnly) { exit 0 }
if ($drills.Count -eq 0) { throw 'No drills matched.' }

$failed = @()
$passedTests = 0
$totalTests = 0
foreach ($item in ($drills | Sort-Object { [int]$_.Name.Split('-')[0] })) {
    Write-Output "`nDRILL: $($item.Name)"
    & javac -d (Join-Path $item.FullName 'build') -sourcepath "$PSScriptRoot;$($item.FullName)" (Join-Path $item.FullName 'Main.java') 2>&1 | Write-Output
    if ($LASTEXITCODE -ne 0) { $failed += $item.Name; continue }
    $arguments = @('-cp', (Join-Path $item.FullName 'build'), 'Main')
    if ($Reference) { $arguments += '--reference' }
    $output = @(& java @arguments 2>&1)
    $code = $LASTEXITCODE
    $output | Write-Output
    $summaries = @($output | Select-String '^([0-9]+)/([0-9]+) passed\.$')
    if ($code -ne 0 -or $summaries.Count -ne 1) { $failed += $item.Name }
    if ($summaries.Count -eq 1) {
        $passedTests += [int]$summaries[0].Matches[0].Groups[1].Value
        $totalTests += [int]$summaries[0].Matches[0].Groups[2].Value
    }
}
Write-Output "`nTOTAL: $($drills.Count - $failed.Count)/$($drills.Count) drills passed; $passedTests/$totalTests tests passed."
if ($failed.Count -gt 0) { Write-Output "Failed drills: $($failed -join ', ')"; exit 1 }
exit 0
