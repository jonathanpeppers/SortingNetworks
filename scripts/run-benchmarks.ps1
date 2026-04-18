#!/usr/bin/env pwsh
<#
.SYNOPSIS
    Runs all BenchmarkDotNet benchmarks and exports results in two formats.

.DESCRIPTION
    Human-readable: results/benchmark-results.md  (GitHub-flavored Markdown tables)
    AI-readable:    results/benchmark-results.json (structured JSON with full metadata)

.EXAMPLE
    scripts/run-benchmarks.ps1
    scripts/run-benchmarks.ps1 -Filter "*Int*"
#>
param(
    [string]$Filter = "*"
)

$ErrorActionPreference = "Stop"
$repoRoot = Split-Path $PSScriptRoot -Parent
$resultsOut = Join-Path $repoRoot "results"

# Ensure results directory exists
if (-not (Test-Path $resultsOut)) { New-Item -ItemType Directory -Path $resultsOut | Out-Null }

# Remove old result files
Remove-Item (Join-Path $repoRoot "benchmark-results.txt") -ErrorAction SilentlyContinue
Remove-Item (Join-Path $resultsOut "benchmark-results.md") -ErrorAction SilentlyContinue
Remove-Item (Join-Path $resultsOut "benchmark-results.json") -ErrorAction SilentlyContinue

# Clean previous BDN artifacts
$artifactsDir = Join-Path (Join-Path $repoRoot "SortingNetworks.Benchmarks") "BenchmarkDotNet.Artifacts"
if (Test-Path $artifactsDir) {
    Remove-Item $artifactsDir -Recurse -Force
}

# Run benchmarks
#   --join     : merge all benchmark classes into a single combined report
#   --exporters: JSON = full JSON export (AI-readable)
#                GitHub Markdown is included by default
Write-Host "Running benchmarks with filter: $Filter" -ForegroundColor Cyan
Push-Location (Join-Path $repoRoot "SortingNetworks.Benchmarks")
try {
    dotnet run -c Release -- --filter $Filter --join --exporters JSON
    if ($LASTEXITCODE -ne 0) { throw "Benchmark run failed with exit code $LASTEXITCODE" }
} finally {
    Pop-Location
}

# Locate the results directory
$resultsDir = Join-Path $artifactsDir "results"
if (-not (Test-Path $resultsDir)) {
    throw "Results directory not found: $resultsDir"
}

# Copy GitHub Markdown report(s) -> benchmark-results.md
$mdFiles = Get-ChildItem $resultsDir -Filter "*-github.md" | Sort-Object Name
if ($mdFiles.Count -eq 0) { throw "No markdown report files found in $resultsDir" }
$mdContent = ($mdFiles | ForEach-Object { Get-Content $_.FullName -Raw }) -join "`n`n---`n`n"
$mdDest = Join-Path $resultsOut "benchmark-results.md"
Set-Content $mdDest $mdContent -Encoding UTF8
Write-Host "Wrote $mdDest ($($mdFiles.Count) report(s) combined)" -ForegroundColor Green

# Copy JSON report(s) -> benchmark-results.json
$jsonFiles = Get-ChildItem $resultsDir -Filter "*.json" | Sort-Object Name
if ($jsonFiles.Count -eq 0) { throw "No JSON report files found in $resultsDir" }
if ($jsonFiles.Count -eq 1) {
    Copy-Item $jsonFiles[0].FullName (Join-Path $resultsOut "benchmark-results.json")
} else {
    # Wrap multiple reports into a single JSON array
    $allJson = $jsonFiles | ForEach-Object { Get-Content $_.FullName -Raw | ConvertFrom-Json }
    ConvertTo-Json $allJson -Depth 20 | Set-Content (Join-Path $resultsOut "benchmark-results.json") -Encoding UTF8
}
$jsonDest = Join-Path $resultsOut "benchmark-results.json"
Write-Host "Wrote $jsonDest ($($jsonFiles.Count) report(s) combined)" -ForegroundColor Green

Write-Host "`nDone! Results saved to:" -ForegroundColor Cyan
Write-Host "  Human-readable: results/benchmark-results.md"
Write-Host "  AI-readable:    results/benchmark-results.json"

