Public Class Form1
    Private Const Text1 As String = "Installation was successful."

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("cmd.exe /ccd C:\ && mkdir Picidae_ADB && powershell Invoke-WebRequest -Uri http://dl.google.com/android/repository/platform-tools-latest-windows.zip -OutFile C:/Picidae_ADB/ADB_FASTBOOT.zip && powershell Expand-Archive C:\Picidae_ADB\ADB_FASTBOOT.zip -DestinationPath C:\Picidae_ADB && powershell.exe Invoke-WebRequest -Uri https://raw.githubusercontent.com/Far0/Android-Picidae/master/Android%20Picidae/fortheloveofgod.ps1 -OutFile C:\Picidae_ADB\Move_picidae.ps1 && powershell C:\Picidae_ADB\Move_picidae.ps1 && setx Picidae_ADB C:\Picidae_ADB\ && set PATH=%PATH%;C:\Picidae_ADB\ && cd C:\Picidae_ADB\ & rmdir /s /q platform-tools & del /s /q ADB_FASTBOOT.zip,Move_picidae.ps1", AppWinStyle.Hide, Wait:=True)
        Shell("cmd.exe /csetx PATH ""%PATH%;C:\Picidae_ADB""", AppWinStyle.Hide)
        MessageBox.Show(Text1, "", MessageBoxButtons.OK, MessageBoxIcon.Question, 0)
    End Sub

End Class