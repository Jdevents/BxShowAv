Imports NAudio
Imports NAudio.CoreAudioApi
Public Class values
    Public vidFormat As String = "mp4|*.mp4|m4a|*.m4a|m4v|*.m4v|mkv|*.mkv|WMV|*.wmv|wma|*.wma|FLV|*.flv|AVI|*.avi|QuickTime|*.mov|QuickTime|*.qt"

    Public BASSRegEmail As String = "icyztv@gmail.com"
    Public BASSRegKey As String = "2X2921716152222"
    Public RchVal As String = 0
    Public de As New MMDeviceEnumerator
    Public Device As MMDevice = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
    Public group1_sett As Boolean = False
    Public group2_sett As Boolean = False
    Public group3_sett As Boolean = False
    Public group4_sett As Boolean = False
    Public Sub tester()
        MsgBox("This is a test MsgBox", MsgBoxStyle.Information, "Test MsgBox")
    End Sub
End Class
