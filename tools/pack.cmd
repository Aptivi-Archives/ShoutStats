@echo off

for /f "tokens=* USEBACKQ" %%f in (`type version`) do set version=%%f
set releaseconfig=%1
if "%releaseconfig%" == "" set releaseconfig=Release

:packbin
echo Packing binary...
"%ProgramFiles%\7-Zip\7z.exe" a -tzip %temp%/%version%-bin.zip "..\ShoutStats.Core\bin\%releaseconfig%\netstandard2.0\*"
"%ProgramFiles%\7-Zip\7z.exe" a -tzip %temp%/%version%-demo.zip "..\ShoutStats.Console\bin\%releaseconfig%\net8.0\*"
"%ProgramFiles%\7-Zip\7z.exe" a -tzip %temp%/%version%-demoui.zip "..\ShoutStats.UI\bin\%releaseconfig%\net8.0\*"
if %errorlevel% == 0 goto :complete
echo There was an error trying to pack binary (%errorlevel%).
goto :finished

:complete
move %temp%\%version%-bin.zip
move %temp%\%version%-demo.zip
move %temp%\%version%-demoui.zip

echo Pack successful.
:finished
