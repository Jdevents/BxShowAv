Public Class Form3_Settings
    Dim val As values
    Private Sub Form3_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If val.group1_sett = True Then
                Label1.Text = "group1 = " & val.group1_sett.ToString
            ElseIf val.group2_sett = True Then
                Label1.Text = "group2 = " & val.group2_sett.ToString
            ElseIf val.group3_sett = True Then
                Label1.Text = "group3 = " & val.group3_sett.ToString
            ElseIf val.group4_sett = True Then
                Label1.Text = "group4 = " & val.group4_sett.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form3_Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If val.group1_sett = True Then
                val.group1_sett = False
            ElseIf val.group2_sett = True Then
                val.group2_sett = False
            ElseIf val.group3_sett = True Then
                val.group3_sett = False
            ElseIf val.group4_sett = True Then
                val.group4_sett = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class