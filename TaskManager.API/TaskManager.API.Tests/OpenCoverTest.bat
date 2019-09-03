..\packages\OpenCover.4.7.922\tools\OpenCover.Console.exe -target:RunTestCases.bat -register:user -filter:+[TaskManager]* 
..\packages\ReportGenerator.4.2.17\tools\net47\ReportGenerator.exe -reports:result.xml -targetdir:coverage 
pause