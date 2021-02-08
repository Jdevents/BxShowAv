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

        If Path = Nothing Then
            'do nothing
        ElseIf songpath.Text = Path Then
            If SongNameTextEdit.Text = Songname Then

                NameGet.URL = songpath.Text
                NameGet.Ctlcontrols.stop()
                SongNameTextEdit.Text = NameGet.currentMedia.name
                Label5.Text = "True"
                Label5.ForeColor = Color.Green
                SimpleButton4.Enabled = True
                SimpleButton3.Enabled = True

            Else

                NameGet.URL = songpath.Text
                NameGet.Ctlcontrols.stop()
                Label5.Text = "True"
                Label5.ForeColor = Color.Green
                SimpleButton4.Enabled = True
                SimpleButton3.Enabled = True

            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        NameGet.settings.volume = 100
        NameGet.URL = songpath.Text

        If NameGet.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            NameGet.Ctlcontrols.stop()
            NameGet.settings.volume = 0
        ElseIf NameGet.playState = WMPLib.WMPPlayState.wmppsStopped Then
            NameGet.URL = songpath.Text
            NameGet.Ctlcontrols.play()
            NameGet.settings.volume = 100
        End If

    End Sub

    Private Sub namegetplayer_CurrentItemChange(sender As Object, e As AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent) Handles NameGet.CurrentItemChange
        If val.Butt_text IsNot SongNameTextEdit.Text Then
            SongNameTextEdit.Text = NameGet.currentMedia.name
        Else
            Label5.Text = "True"
            Label5.ForeColor = Color.Green
            SimpleButton4.Enabled = True
            SimpleButton3.Enabled = True
            SongNameTextEdit.Text = NameGet.currentMedia.name
        End If
    End Sub
    Private Sub Form3_Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameGet.settings.autoStart = False
        SongNameTextEdit.Text = Songname
        Try
            NameGet.URL = val.Path
        Catch ex As Exception
            'do nothing
        End Try

        If Path = Nothing Then
            Label5.Text = "No Audio Loaded"
            Label5.ForeColor = Color.Red
            SimpleButton4.Enabled = False
            SimpleButton3.Enabled = False
        Else
            Label5.Text = "Audio Loaded"
            Label5.ForeColor = Color.Green
            SimpleButton4.Enabled = True
            SimpleButton3.Enabled = True
        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        SongNameTextEdit.Text = NameGet.currentMedia.name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(NameGet.URL.ToString)
    End Sub

    Private Sub Form3_Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If NameGet.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            NameGet.Ctlcontrols.stop()
            NameGet.settings.volume = 0
        End If
    End Sub
End Class