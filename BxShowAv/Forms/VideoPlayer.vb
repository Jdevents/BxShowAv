Public Class VideoPlayer
    Private Sub VideoPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Vplayer = True
        AxWindowsMediaPlayer1.uiMode = "none"
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            AxWindowsMediaPlayer1.fullScreen = False
            Me.Close()
        End If
    End Sub

    Private Sub VideoPlayer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.AxWindowsMediaPlayer1.currentPlaylist.clear()
        Form2.Vplayer = False
        Form2.VpCloseCheck = True
        AxWindowsMediaPlayer1.currentPlaylist.clear()
        AxWindowsMediaPlayer1.close()
        Form2.TrVidBar.Maximum = 100
        Form2.TrVidBar.Value = 0
        Form2.sbExFullScreen.Enabled = False
        Form2.sbFullScreen.Enabled = False
    End Sub
End Class