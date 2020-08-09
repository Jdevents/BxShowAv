Public Class Form3
    Dim val As New Butt_settings
    Dim songs As List(Of Strings)


    Dim test As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        For a As Integer = 0 To 95

            songs.Add(val.b)
            a = +1

        Next

    End Sub

    Private Sub Group_Settings_Click(sender As Object, e As EventArgs) Handles Group_Settings.Click
        val.Group1 = True
        Dim From_set As New Form3_Settings(val)





        For a As Integer = 0 To songs.Count - 1

            MsgBox(songs(a))

        Next

        If From_set.ShowDialog = DialogResult.OK Then
            'do ok things
            test = val.Group1button1

        Else
            'user click cancel

        End If

        ' From_set.Dispose()

    End Sub

    Private Sub Group2_Settings_Click(sender As Object, e As EventArgs) Handles Group2_Settings.Click
        Dim From_set As New Form3_Settings(val)
        val.Group2 = True
        From_set.ShowDialog()
    End Sub

    Private Sub Group3_Settings_Click(sender As Object, e As EventArgs) Handles Group3_Settings.Click
        Dim From_set As New Form3_Settings(val)
        val.Group3 = True
        From_set.ShowDialog()
    End Sub

    Private Sub Group4_Settings_Click(sender As Object, e As EventArgs) Handles Group4_Settings.Click
        Dim From_set As New Form3_Settings(val)
        val.Group4 = True
        From_set.ShowDialog()
    End Sub

    Private Sub Group1_but1_Click(sender As Object, e As EventArgs) Handles Group1_but1.Click
        MsgBox(val.Group1button1)
        testplayer.Ctlcontrols.play()
        testplayer.settings.volume = 100
    End Sub

    Private Sub Group1_but1_MouseHover(sender As Object, e As EventArgs) Handles Group1_but1.MouseHover
        songnametip()
        Songname.SetToolTip(Group1_but1, val.Group1button1)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        testplayer.URL = val.Group1button1
        testplayer.settings.autoStart = False
        testplayer.Ctlcontrols.stop()
        Group1_but1.Text = testplayer.currentMedia.name
    End Sub

    Private Sub songnametip()
        Songname.ToolTipTitle = "[" & testplayer.currentMedia.name & "]"
        Songname.UseFading = True
        Songname.UseAnimation = True
        Songname.ShowAlways = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        testplayer.Ctlcontrols.stop()
    End Sub
End Class