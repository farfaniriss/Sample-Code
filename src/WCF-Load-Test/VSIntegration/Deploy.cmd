rem This was intended to be a PowerShell script used during development to deploy the VS integration bits. In
rem order to be able to use a PowerShell script the following command must have been entered by as administrator:
rem 
rem 	set-executionpolicy remotesigned
rem 	
rem 	or
rem 	
rem 	set-executionpolicy unrestricted
rem
rem Note that the WinZip command line extensions also need to be installed	

"%ProgramFiles%\Microsoft SDKs\Windows\v6.0a\Bin\gacutil" -i bin\debug\Microsoft.WcfUnit.VSIntegration.dll
"%ProgramFiles%\Microsoft SDKs\Windows\v6.0a\Bin\gacutil"  -i bin\debug\Microsoft.WcfUnit.Library.dll

rem copy wcfunit.zip "%ProgramFiles(x86)%\Microsoft Visual Studio 8\Common7\IDE\ItemTemplates\CSharp\1033"
rem "%ProgramFiles(x86)%\Microsoft Visual Studio 8\Common7\IDE\devenv.exe" /installvstemplates
rem "%ProgramFiles(x86)%\Microsoft Visual Studio 8\Common7\IDE\devenv.exe" /setup

copy wcfunit.zip "%ProgramFiles(x86)%\Microsoft Visual Studio 9.0\Common7\IDE\ItemTemplates\CSharp\1033"
"%ProgramFiles(x86)%\Microsoft Visual Studio 9.0\Common7\IDE\devenv.exe" /installvstemplates
"%ProgramFiles(x86)%\Microsoft Visual Studio 9.0\Common7\IDE\devenv.exe" /setup

rem copy wcfunit2010.zip "%ProgramFiles(x86)%\Microsoft Visual Studio 10.0\Common7\IDE\ItemTemplates\CSharp\1033"
rem "%ProgramFiles(x86)%\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe" /installvstemplates
rem "%ProgramFiles(x86)%\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe" /setup
