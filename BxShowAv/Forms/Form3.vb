Public Class Form3
    Dim val As values

    Private Sub Group_Settings_Click(sender As Object, e As EventArgs) Handles Group_Settings.Click
        val.group1_sett = True
        Form3_Settings.Show()
    End Sub

    Private Sub Group2_Settings_Click(sender As Object, e As EventArgs) Handles Group2_Settings.Click
        val.group2_sett = True
        Form3_Settings.Show()
    End Sub

    Private Sub Group3_Settings_Click(sender As Object, e As EventArgs) Handles Group3_Settings.Click
        val.group3_sett = True
        Form3_Settings.Show()
    End Sub

    Private Sub Group4_Settings_Click(sender As Object, e As EventArgs) Handles Group4_Settings.Click
        val.group4_sett = True
        Form3_Settings.Show()
    End Sub
End Class