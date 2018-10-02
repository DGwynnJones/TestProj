rem @echo off
rem @echo off

cls
cls

REM  "..\..\..\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe" -target:"..\..\..\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe" -filter:"+[TestProj.Business.ClassUnderTest.*]* -[TestProj.Test.*]*" -targetargs:"TestProj.Test.dll " -output:"_CodeCoverageResult.xml" -register:user
"..\..\..\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe" -filter:"+[TestProj*]*" -target:"..\..\..\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe"  -targetargs:"TestProj.Test.dll " -output:"_CodeCoverageResult.xml" -register:user


rem -filter:"+[ProjToTest]ProjToTest*" -excludebyattribute:"System.CodeDom.Compiler.GeneratedCodeAttribute" -register:user -output:"_CodeCoverageResult.xml"
rem --where:"cat != blah"

ECHO .
ECHO .
ECHO Generating report
ECHO .
ECHO .


"..\..\..\packages\ReportGenerator.3.1.2\tools\ReportGenerator.exe" "-reports:_CodeCoverageResult.xml" "-targetdir:Report"

Report\index.htm
