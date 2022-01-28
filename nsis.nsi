# define installer name
OutFile "WinAuth-Imperial-Installer.exe"
 
# set programm files 64 as install directory
InstallDir $PROGRAMFILES64\WinAuth-Imperial
 
# default section start
Section
 
# define output path
SetOutPath $INSTDIR
 
# specify file to go in output path
File "D:\Data\Dev\winauth\Net4.5\bin\Release\WinAuth-Imperial.exe"
 
# define uninstaller name
WriteUninstaller $INSTDIR\uninstaller.exe
 
# create a shortcut named "new shortcut" in the start menu programs directory
# presently, the new shortcut doesn't call anything (the second field is blank)
SetShellVarContext all
CreateShortcut "$SMPROGRAMS\WinAuth-Imperial.lnk" "$PROGRAMFILES64\WinAuth-Imperial\WinAuth-Imperial.exe"
 
# to delete shortcut, go to start menu directory and manually delete it
 
#-------
# default section end
SectionEnd
 
# create a section to define what the uninstaller does.
# the section will always be named "Uninstall"
Section "Uninstall"
 
# Always delete uninstaller first
Delete $INSTDIR\uninstaller.exe
 
# now delete installed file
Delete $INSTDIR\WinAuth-Imperial.exe
 
# Delete the directory
RMDir $INSTDIR
SectionEnd
 