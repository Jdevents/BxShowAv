Public Class Form3_Settings
    Dim val As Butt_settings

    Public Sub New(_val As Butt_settings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        val = _val
    End Sub

    Private Sub Form3_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If val.Group1 = True Then
                Label1.Text = "group1 = " & val.Group1.ToString
            ElseIf val.Group2 = True Then
                Label1.Text = "group2 = " & val.Group2.ToString
            ElseIf val.Group3 = True Then
                Label1.Text = "group3 = " & val.Group3.ToString
            ElseIf val.Group4 = True Then
                Label1.Text = "group4 = " & val.Group4.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form3_Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If val.Group1 = True Then
                val.Group2 = False
            ElseIf val.Group2 = True Then
                val.Group2 = False
            ElseIf val.Group3 = True Then
                val.Group3 = False
            ElseIf val.Group4 = True Then
                val.Group4 = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = DialogResult.OK
        val.Group1button1 = songpath.Text
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'val.Group1button1 = songpath.Text
        'Label1.Text = val.Group1button1
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        songpath.BackColor = Color.Green
    End Sub
End Class