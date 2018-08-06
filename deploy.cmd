@echo off

set SolutionDir=%~dp0
set ArtifactsDir=%SolutionDir%artifacts

dotnet pack -v n -c Release -o %ArtifactsDir% || EXIT /B 1