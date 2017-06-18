@echo off
setlocal 

set PATH=%PATH%;C:\Program Files (x86)\WiX Toolset v3.11\bin\;

set INSTALLERDIR=%~dp0\Installer
set TARGETDIR=%~dp0\output\v45\AnyCPU\Release\bin

set SolutionDir=%~dp0
set Configuration=Release

set OutputFile="%TARGETDIR%\coapp.tools.powershell.msi"
erase %OutputFile%

echo Creating MSI

cd %TARGETDIR%

candle %INSTALLERDIR%\Product.wxs  || goto fin
light "%TARGETDIR%\product.wixobj"  -sice:ICE80 -out %OutputFile%

echo signing installer 
"C:\Program Files (x86)\Windows Kits\10\bin\x64\signtool.exe" sign /a /t http://timestamp.verisign.com/scripts/timstamp.dll %OutputFile% || goto fin

:FIN