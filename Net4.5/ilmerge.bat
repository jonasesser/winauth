set PP=%~1
set TP=%~2
set OP=%~3
"%PP%ilmerge.exe" /out:"%TP%WinAuth2.exe" /internalize "%TP%WinAuth.exe" "%TP%Authenticator.dll" "%TP%BouncyCastle.Crypto.dll" "%TP%zxing.dll" "%TP%zxing.presentation.dll" "%TP%MetroFramework.dll" "%TP%NLog.dll"
copy "%TP%winauth2.exe" "%OP%winauth.exe"
copy "%TP%winauth2.pdb" "%OP%winauth.pdb"