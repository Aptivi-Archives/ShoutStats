@echo off

for /f "tokens=* USEBACKQ" %%f in (`type version`) do set version=%%f
set releaseconfig=%1
if "%releaseconfig%" == "" set releaseconfig=Release

:packbin
echo Packing binary...
"%ProgramFiles%\WinRAR\rar.exe" a -ep1 -r -m5 %temp%/%version%-bin.rar "..\ShoutStats.Core\bin\%releaseconfig%\netstandard2.0\"
"%ProgramFiles%\WinRAR\rar.exe" a -ep1 -r -m5 %temp%/%version%-demo.rar "..\ShoutStats.Console\bin\%releaseconfig%\net6.0\"
"%ProgramFiles%\WinRAR\rar.exe" a -ep1 -r -m5 %temp%/%version%-demoui.rar "..\ShoutStats.UI\bin\%releaseconfig%\net6.0\"
if %errorlevel% == 0 goto :complete
echo There was an error trying to pack binary (%errorlevel%).
goto :finished

:complete
move %temp%\%version%-bin.rar
move %temp%\%version%-demo.rar
move %temp%\%version%-demoui.rar

echo Pack successful.
:finished
