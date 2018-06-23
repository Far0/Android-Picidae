Public Class Form1

    ''' <summary>
    ''' Strings used in the project.
    ''' Made by FAR
    ''' Email:
    ''' </summary>
    ''' 
    Private Const Cmd As String = "cmd.exe /c"
    Private Const Platform As String = "powershell.exe Invoke-WebRequest -Uri http://dl.google.com/android/repository/platform-tools-latest-windows.zip -OutFile C:\Picidae_ADB\ADB_FASTBOOT.zip && "
    Private Const UnzipAdb As String = "powershell.exe Expand-Archive C:\Picidae_ADB\ADB_FASTBOOT.zip -DestinationPath C:\Picidae_ADB && "
    Private Const MoveAdb As String = "powershell.exe Invoke-WebRequest -Uri https://raw.githubusercontent.com/Far0/Picidae-Modules/master/move.ps1 -OutFile C:\Picidae_ADB\Move_picidae.ps1 && powershell C:\Picidae_ADB\Move_picidae.ps1 && "
    Private Const EnvPath As String = "setx Picidae_ADB C:\Picidae_ADB\ && setx PATH ""%PATH%;C:\Picidae_ADB"" && "
    Private Const CleanupAdb As String = "rmdir /s /q C:\Picidae_ADB\platform-tools && del /s /q C:\Picidae_ADB\ADB_FASTBOOT.zip,C:\Picidae_ADB\Move_picidae.ps1"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Interaction.Shell("cmd /csetx PATH ""%PATH%;C:\Picidae_ADB""", AppWinStyle.Hide)
        Dim ADB As New ProcessStartInfo()
        ADB.Verb = "runas"
        ADB.FileName = "cmd.exe" ' 
        ADB.Arguments = "/c " + "cd C:\ && " + "mkdir Picidae_ADB && " + Platform + UnzipAdb + MoveAdb + EnvPath + CleanupAdb
        Try
            Process.Start(ADB)
        Catch
            MsgBox("Y", 16, "")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://www.paypal.me/MauronofrioTool")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Interaction.Shell("cmd /ccd %APPDATA% && mkdir Picidae && adb shell getprop ro.product.model > %APPDATA%/Picidae/model", AppWinStyle.Hide, True, -1)
        If (IO.File.Exists("model")) Then
            MsgBox("moto")
        Else
            MsgBox("lul")
        End If
    End Sub
End Class