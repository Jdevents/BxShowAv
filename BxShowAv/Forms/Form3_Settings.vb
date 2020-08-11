Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls

Public Class Form3_Settings
    Dim val As butt_list
    Dim placeholder As String
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = DialogResult.OK
        AxNameGet.Ctlcontrols.stop()
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.DialogResult = DialogResult.Cancel
        AxNameGet.Ctlcontrols.stop()
        Me.Close()
    End Sub

    Private Sub songpath_EditValueChanged(sender As Object, e As EventArgs) Handles songpath.EditValueChanged

        If songpath.Text = "" Then
            SongNameTextEdit.Text = SongNameTextEdit.Text
            placeholder = songpath.Text
            SimpleButton4.Enabled = False
        Else
            SongNameTextEdit.Text = SongNameTextEdit.Text
            placeholder = songpath.Text
            AxNameGet.URL = placeholder
            AxNameGet.Ctlcontrols.stop()
        End If

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click


        If AxNameGet.URL = Nothing Then
            AxNameGet.URL = placeholder
            AxNameGet.Ctlcontrols.play()
            AxNameGet.settings.volume = 100
        Else
            AxNameGet.Ctlcontrols.play()
            AxNameGet.settings.volume = 100
        End If

        If AxNameGet.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxNameGet.Ctlcontrols.stop()
            AxNameGet.settings.volume = 0
        ElseIf AxNameGet.playState = WMPLib.WMPPlayState.wmppsStopped Then
            AxNameGet.URL = placeholder
            AxNameGet.Ctlcontrols.play()
            AxNameGet.settings.volume = 100
        End If

    End Sub

    Private Sub namegetplayer_CurrentItemChange(sender As Object, e As AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent) Handles AxNameGet.CurrentItemChange
        '    SongNameTextEdit.Text = AxNameGet.currentMedia.name.ToString
        If val.Butt_text IsNot SongNameTextEdit.Text Then
            SongNameTextEdit.Text = AxNameGet.currentMedia.name.ToString
        Else
            Label5.Text = "True"
            Label5.ForeColor = Color.Green
            SimpleButton4.Enabled = True
            SimpleButton4.Enabled = True
        End If


    End Sub
    Private Sub Form3_Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        AxNameGet.settings.volume = 0
        If placeholder = Nothing Then
            Label5.Text = "False"
            Label5.ForeColor = Color.Red
            SimpleButton4.Enabled = False
            SimpleButton3.Enabled = False
        Else
            Label5.Text = "True"
            Label5.ForeColor = Color.Green
            SimpleButton4.Enabled = True
            SimpleButton3.Enabled = True
        End If

        If songpath.Text = "" Then

        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        SongNameTextEdit.Text = AxNameGet.currentMedia.name.ToString
    End Sub
End Class