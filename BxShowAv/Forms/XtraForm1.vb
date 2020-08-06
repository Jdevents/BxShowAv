Public Class XtraForm1
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Timer1.Start()
        If Not SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = True
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SplitContainer1.Panel1Collapsed = False
        SimpleButton1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If SplitContainer1.Panel1Collapsed = False Or SimpleButton1.Visible = False Then
            SplitContainer1.Panel1Collapsed = True
            SimpleButton1.Visible = True
            SimpleButton1.BringToFront()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Panel1.Visible = True
        Panel1.Dock = DockStyle.Fill
        SimpleButton1.BringToFront()
        Timer1.Start()
        mainmn()
        closemn()

        If Panel3.Visible = True Or Panel4.Visible = True Then
            Panel3.Visible = False
            Panel4.Visible = False
        End If

    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SimpleButton1.Visible = False
        Panel2.Visible = False
        Form2.Abox = True
    End Sub

    Private Sub SplitContainer1_Panel2_Click(sender As Object, e As EventArgs) Handles SplitContainer1.Panel2.Click
        closemn()
    End Sub

    Sub mainmn()

        Timer1.Start()
        If Not SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = True
            Timer1.Stop()
        End If

        If SimpleButton1.Visible = False Then
            SimpleButton1.Visible = True
            Panel2.Dock = DockStyle.Top
            Panel2.Visible = True
            Panel2.SendToBack()
            SimpleButton1.BringToFront()
        End If
    End Sub

    Sub closemn()
        If SplitContainer1.Panel1Collapsed = False Then
            SplitContainer1.Panel1Collapsed = True
            Panel2.Visible = True
            Panel2.Dock = DockStyle.Top
            SimpleButton1.Visible = True
            SimpleButton1.BringToFront()
        End If
    End Sub
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        closemn()
    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Panel3.Visible = True
        Panel3.Dock = DockStyle.Fill
        SimpleButton1.BringToFront()
        Timer1.Start()
        mainmn()
        closemn()

        If Panel1.Visible = True Or Panel4.Visible = True Then
            Panel1.Visible = False
            Panel4.Visible = False
        End If


    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Panel4.Visible = True
        Panel4.Dock = DockStyle.Fill
        SimpleButton1.BringToFront()
        Timer1.Start()
        mainmn()
        closemn()

        If Panel3.Visible = True Or Panel1.Visible = True Then
            Panel1.Visible = False
            Panel3.Visible = False
        End If


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        closemn()
    End Sub

    Private Sub TabPane1_Click(sender As Object, e As EventArgs) Handles TabPane1.Click
        closemn()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        closemn()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        closemn()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        closemn()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        closemn()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        closemn()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        closemn()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        closemn()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        closemn()
    End Sub

    Private Sub XtraForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Abox = False
    End Sub
End Class