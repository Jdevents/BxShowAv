Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls

Public Class Form3_Settings
    Dim val As butt_list
    Public Songname As String
    Public Path As String
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = DialogResult.OK
        NameGet.Ctlcontrols.stop()
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.DialogResult = DialogResult.Cancel
        NameGet.Ctlcontrols.stop()
        Me.Close()
    End Sub

    Private Sub songpath_EditValueChanged(sender As Object, e As EventArgs) Handles songpath.EditValueChanged

        If songpath.Text = Path Then
            If Path = "" Then
                Try
                    songpath.Text = Path
                Catch ex As Exception

                End Try
            End If
        Else
            Try
                NameGet.URL = songpath.Text
                NameGet.settings.autoStart = False
                SongNameTextEdit.Text = NameGet.currentMedia.name
                songpath_lbl.Text = songpath.Text
                Label5.Text = "True"
                Label5.ForeColor = Color.Green
                SimpleButton4.Enabled = True
            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub namegetplayer_CurrentItemChange(sender As Object, e As AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent) Handles NameGet.CurrentItemChange
        If val.Butt_text IsNot SongNameTextEdit.Text Then
            SongNameTextEdit.Text = NameGet.currentMedia.name
        Else
            Label5.Text = "True"
            Label5.ForeColor = Color.Green
            SimpleButton4.Enabled = True
            SongNameTextEdit.Text = NameGet.currentMedia.name
        End If
    End Sub
    Private Sub Form3_Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameGet.settings.autoStart = False
        SongNameTextEdit.Text = Songname
        songpath.Text = Path
        songpath_lbl.Text = NameGet.URL.ToString
        Try
            NameGet.URL = val.Path
        Catch ex As Exception
            'do nothing
        End Try

        If Path = Nothing Then
            Label5.Text = "No Audio Loaded"
            Label5.ForeColor = Color.Red
            SimpleButton4.Enabled = False
        Else
            Label5.Text = "Audio Loaded"
            Label5.ForeColor = Color.Green
            SimpleButton4.Enabled = True
        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        SongNameTextEdit.Text = NameGet.currentMedia.name
    End Sub

    Private Sub Form3_Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If NameGet.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            NameGet.Ctlcontrols.stop()
            NameGet.settings.volume = 0
        End If
    End Sub

    Private Sub NameGet_OpenStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_OpenStateChangeEvent) Handles NameGet.OpenStateChange
        If NameGet.openState = WMPLib.WMPOpenState.wmposMediaOpen Then
            TrackBar1.Maximum = CInt(NameGet.currentMedia.duration)
            Songtime.Start()
        End If
    End Sub

    Private Sub Songtime_Tick(sender As Object, e As EventArgs) Handles Songtime.Tick
        Try
            TrackBar1.Value = CInt(Me.NameGet.Ctlcontrols.currentPosition)
            GroupControl1.Text = "Song Time: " & NameGet.Ctlcontrols.currentPositionString & "/" & NameGet.currentMedia.durationString
            Songtot.Text = NameGet.Ctlcontrols.currentPositionString & "/" & NameGet.currentMedia.durationString
        Catch ex As Exception
            'This is need because it gets the shits if you close the video
            'so it just resets the text-box text to nothing
            Songtot.Text = "00:00/00:00"
        End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        NameGet.Ctlcontrols.pause()
        NameGet.Ctlcontrols.currentPosition = CDbl(TrackBar1.Value)
        System.Threading.Thread.Sleep(3)
        NameGet.Ctlcontrols.play()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        NameGet.settings.volume = 100
        NameGet.Ctlcontrols.play()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        NameGet.Ctlcontrols.pause()
    End Sub
End Class