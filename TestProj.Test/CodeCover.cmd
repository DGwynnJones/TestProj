﻿@ECHO OFF
@ECHO OFF
CLS


"C:\Users\dgwynnjones\source\repos\TestProj\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe" -filter:"+[TestProj.Business]* +[TestProj.EFCodeFirst]* -[TestProj.Test]*" -target:"C:\Users\dgwynnjones\source\repos\TestProj\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe" -targetargs:"TestProj.Test.dll" -output:"_CodeCoverageResult.xml" -register:user

"C:\Users\dgwynnjones\source\repos\TestProj\packages\ReportGenerator.4.0.4\tools\net47\ReportGenerator.exe" "-reports:_CodeCoverageResult.xml" "-targetdir:Report"

Report\index.htm

ECHO.
ECHO Script generated at: 21/11/2018 10:20:09 AM
ECHO Package root: C:\Users\dgwynnjones\source\repos\TestProj
ECHO.
ECHO.
