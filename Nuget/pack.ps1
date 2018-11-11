Remove-Item '.\*.nupkg'

$nuspecs = Get-ChildItem '.\*.nuspec'

ForEach($nuspec in $nuspecs) {
    .\nuget.exe pack """$($nuspec.FullName)"""
}