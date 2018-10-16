@echo off
@echo off

cls
cls

"..\..\..\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe" -filter:"+[TestProj*]* -[TestProj.Test]*" -target:"..\..\..\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe"  -targetargs:"TestProj.Test.dll " -output:"_CodeCoverageResult.xml" -register:user

ECHO .
ECHO .
ECHO Generating report
ECHO .
ECHO .


"..\..\..\packages\ReportGenerator.3.1.2\tools\ReportGenerator.exe" "-reports:_CodeCoverageResult.xml" "-targetdir:Report"

Report\index.htm
