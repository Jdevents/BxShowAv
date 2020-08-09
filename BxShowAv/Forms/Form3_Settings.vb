Public Class Form3_Settings
    Dim val As Butt_settings

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form3_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxNameGet.URL = ""
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub songpath_EditValueChanged(sender As Object, e As EventArgs) Handles songpath.EditValueChanged
        SongNameTextEdit.Text = SongNameTextEdit.Text
        AxNameGet.URL = songpath.Text
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        AxNameGet.Ctlcontrols.play()
    End Sub

    Private Sub namegetplayer_CurrentItemChange(sender As Object, e As AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent) Handles AxNameGet.CurrentItemChange
        SongNameTextEdit.Text = AxNameGet.currentMedia.ToString
    End Sub
End Class