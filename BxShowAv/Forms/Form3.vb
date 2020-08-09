Public Class Form3
    Dim val As New values
    Dim From_set As New Form3_Settings

    Private Sub Group_Settings_Click(sender As Object, e As EventArgs) Handles Group_Settings.Click

        val.Group1 = True

        ' From_set.Label1.Text = "boo"
        If From_set.ShowDialog = DialogResult.OK Then
            'do ok things
        Else
            'user click cancel

        End If

        ' From_set.Dispose()



    End Sub

    Private Sub Group2_Settings_Click(sender As Object, e As EventArgs) Handles Group2_Settings.Click
        val.Group2 = True
        From_set.ShowDialog()
    End Sub

    Private Sub Group3_Settings_Click(sender As Object, e As EventArgs) Handles Group3_Settings.Click
        val.Group3 = True
        From_set.ShowDialog()
    End Sub

    Private Sub Group4_Settings_Click(sender As Object, e As EventArgs) Handles Group4_Settings.Click
        val.Group4 = True
        From_set.ShowDialog()
    End Sub
End Class