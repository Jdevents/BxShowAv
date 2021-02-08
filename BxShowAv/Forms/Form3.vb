Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json

Public Class Form3
    Dim val As New Butt_settings
    Dim songs As New List(Of String)
    Dim butt_data As String = Application.StartupPath & "\playlist_data\butt_data.json"

#Region "Group Button's"
    Private Sub Group1_but1_Click(sender As Object, e As EventArgs) Handles Group1_but1.Click, Group1_but2.Click, Group1_but3.Click, Group1_but4.Click, Group1_but5.Click, Group1_but6.Click, Group1_but7.Click, Group1_but8.Click, Group1_but9.Click, Group1_but10.Click, Group1_but11.Click, Group1_but12.Click, Group1_but13.Click, Group1_but14.Click, Group1_but15.Click, Group1_but16.Click, Group1_but17.Click, Group1_but18.Click, Group1_but19.Click, Group1_but20.Click, Group1_but21.Click, Group1_but22.Click, Group1_but23.Click, Group1_but24.Click
        Dim but = CType(sender, DevExpress.XtraEditors.SimpleButton)
        AudioPlayer.URL = but.Tag
    End Sub

    Private Sub Group2_but1_Click(sender As Object, e As EventArgs) Handles Group2_but1.Click, Group2_but2.Click, Group2_but3.Click, Group2_but4.Click, Group2_but5.Click, Group2_but6.Click, Group2_but7.Click, Group2_but8.Click, Group2_but9.Click, Group2_but10.Click, Group2_but25.Click, Group2_but12.Click, Group2_but13.Click, Group2_but14.Click, Group2_but15.Click, Group2_but16.Click, Group2_but17.Click, Group2_but18.Click, Group2_but19.Click, Group2_but20.Click, Group2_but21.Click, Group2_but22.Click, Group2_but23.Click, Group2_but24.Click
        Dim but = CType(sender, DevExpress.XtraEditors.SimpleButton)
        AudioPlayer.URL = but.Tag
    End Sub

    Private Sub Group3_but1_Click(sender As Object, e As EventArgs) Handles Group3_but1.Click, Group3_but2.Click, Group3_but3.Click, Group3_but4.Click, Group3_but5.Click, Group3_but6.Click, Group3_but7.Click, Group3_but8.Click, Group3_but9.Click, Group3_but10.Click, Group3_but11.Click, Group3_but12.Click, Group3_but13.Click, Group3_but14.Click, Group3_but15.Click, Group3_but16.Click, Group3_but17.Click, Group3_but25.Click, Group3_but19.Click, Group3_but20.Click, Group3_but21.Click, Group3_but22.Click, Group3_but23.Click, Group3_but24.Click
        Dim but = CType(sender, DevExpress.XtraEditors.SimpleButton)
        AudioPlayer.URL = but.Tag
    End Sub

    Private Sub Group4_but1_Click(sender As Object, e As EventArgs) Handles Group4_but1.Click, Group4_but2.Click, Group4_but3.Click, Group4_but4.Click, Group4_but5.Click, Group4_but6.Click, Group4_but7.Click, Group4_but8.Click, Group4_but9.Click, Group4_but10.Click, Group4_but11.Click, Group4_but12.Click, Group4_but13.Click, Group4_but14.Click, Group4_but15.Click, Group4_but16.Click, Group4_but17.Click, Group4_but18.Click, Group4_but19.Click, Group4_but20.Click, Group4_but21.Click, Group4_but22.Click, Group4_but23.Click, Group4_but24.Click
        Dim but = CType(sender, DevExpress.XtraEditors.SimpleButton)
        AudioPlayer.URL = but.Tag
    End Sub
#End Region

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(butt_data) = True Then
            load_butt()
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        AudioPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        AudioPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'Clear Selected Button
        Dim mi = CType(sender, ToolStripMenuItem)
        Dim cms = CType(mi.Owner, ContextMenuStrip)
        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then
                        If but.Name = cms.SourceControl.Name Then

                            Dim but1 As DevExpress.XtraEditors.SimpleButton
                            but1 = CType(but, DevExpress.XtraEditors.SimpleButton)

                            but.Text = ""
                            but.Tag = ""
                            but1.ToolTipTitle = ""
                            but1.ToolTip = ""
                            Exit For
                        End If
                    End If
                Next
            End If
        Next
        save_butt_data()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        'Edit Button
        Dim mi = CType(sender, ToolStripMenuItem)
        Dim cms = CType(mi.Owner, ContextMenuStrip)
        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then
                        If but.Name = cms.SourceControl.Name Then
                            'show edit form

                            Dim but1 As DevExpress.XtraEditors.SimpleButton
                            but1 = CType(but, DevExpress.XtraEditors.SimpleButton)

                            Dim form As New Form3_Settings
                            form.Songname = but.Text
                            form.songpath.Text = but.Tag
                            form.Path = but.Tag
                            form.NameGet.URL = but.Tag
                            If form.ShowDialog = DialogResult.OK Then
                                but.Text = form.SongNameTextEdit.Text
                                but.Tag = form.songpath.Text
                                but1.ToolTipTitle = but.Text
                                but1.ToolTip = but.Tag
                                Call save_butt_data()
                            End If
                            Exit For
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'Add New Data To Selected Button
        Dim mi = CType(sender, ToolStripMenuItem)
        Dim cms = CType(mi.Owner, ContextMenuStrip)

        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then
                        If but.Name = cms.SourceControl.Name Then


                            Dim but1 As DevExpress.XtraEditors.SimpleButton
                            but1 = CType(but, DevExpress.XtraEditors.SimpleButton)

                            Dim form As New Form3_Settings
                            form.SongNameTextEdit.Text = but.Text
                            form.songpath.Text = but.Tag
                            If form.ShowDialog = DialogResult.OK Then
                                but.Text = form.SongNameTextEdit.Text
                                but.Tag = form.songpath.Text
                                but1.ToolTipTitle = but.Text
                                but1.ToolTip = but.Tag
                                Call save_butt_data()
                            End If
                            Exit For
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub load_butt()
        Dim json As String = File.ReadAllText(butt_data)
        Dim list As List(Of butt_list) = JsonConvert.DeserializeObject(Of List(Of butt_list))(json)
        For a As Integer = 0 To list.Count - 1
            For Each c As Control In Me.Controls
                If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                    For Each but As Control In c.Controls
                        If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then
                            Dim but1 As DevExpress.XtraEditors.SimpleButton
                            but1 = CType(but, DevExpress.XtraEditors.SimpleButton)


                            If but.Name = list(a).Buttname Then
                                but.Text = list(a).Butt_text
                                but.Tag = list(a).Path
                                but.BackColor = System.Drawing.Color.FromName(list(a).Colour)
                                but1.ToolTipTitle = but.Text
                                but1.ToolTip = but.Tag

                                Exit For
                            End If
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Sub save_butt_data()
        Dim list As New List(Of butt_list)
        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then
                        Dim item As New butt_list
                        item.Path = but.Tag
                        item.Colour = but.ForeColor.ToString
                        item.Buttname = but.Name
                        item.Butt_text = but.Text
                        list.Add(item)
                    End If
                Next
            End If
        Next
        File.WriteAllText(butt_data, JsonConvert.SerializeObject(list))
    End Sub
#Region "Clear groups"
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If Clear_all_panel.Visible = False Then
            Clear_all_panel.Visible = True
        ElseIf Clear_all_panel.Visible = True Then
            Clear_all_panel.Visible = False
        End If

        If AudioPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AudioPlayer.Ctlcontrols.stop()
        End If

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If MsgBox("Clear Group 1?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        For Each c As Control In Me.Controls
            If c Is Group1 Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then

                        Dim but1 As DevExpress.XtraEditors.SimpleButton
                        but1 = CType(but, DevExpress.XtraEditors.SimpleButton)

                        but.Text = ""
                        but.Tag = ""
                        but1.ToolTip = ""
                        but1.ToolTipTitle = ""

                    End If
                Next
            End If
        Next
        save_butt_data()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        If MsgBox("Clear All?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then

                        Dim but1 As DevExpress.XtraEditors.SimpleButton
                        but1 = CType(but, DevExpress.XtraEditors.SimpleButton)

                        but.Text = ""
                        but.Tag = ""
                        but1.ToolTip = ""
                        but1.ToolTipTitle = ""

                    End If
                Next
            End If
        Next
        save_butt_data()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If MsgBox("Clear Group 2?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        For Each c As Control In Me.Controls
            If c Is Group2 Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then

                        Dim but1 As DevExpress.XtraEditors.SimpleButton
                        but1 = CType(but, DevExpress.XtraEditors.SimpleButton)

                        but.Text = ""
                        but.Tag = ""
                        but1.ToolTip = ""
                        but1.ToolTipTitle = ""

                    End If
                Next
            End If
        Next
        save_butt_data()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If MsgBox("Clear Group 3?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        For Each c As Control In Me.Controls
            If c Is Group3 Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then

                        Dim but1 As DevExpress.XtraEditors.SimpleButton
                        but1 = CType(but, DevExpress.XtraEditors.SimpleButton)

                        but.Text = ""
                        but.Tag = ""
                        but1.ToolTip = ""
                        but1.ToolTipTitle = ""

                    End If
                Next
            End If
        Next
        save_butt_data()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        If MsgBox("Clear Group 4?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        For Each c As Control In Me.Controls
            If c Is Group4 Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then

                        Dim but1 As DevExpress.XtraEditors.SimpleButton
                        but1 = CType(but, DevExpress.XtraEditors.SimpleButton)

                        but.Text = ""
                        but.Tag = ""
                        but1.ToolTip = ""
                        but1.ToolTipTitle = ""

                    End If
                Next
            End If
        Next
        save_butt_data()
    End Sub
#End Region
#Region "Close Clear panel"
    Private Sub Form3_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If Clear_all_panel.Visible = True Then
            Clear_all_panel.Visible = False
        End If
    End Sub

    Private Sub Group3_MouseClick(sender As Object, e As MouseEventArgs) Handles Group3.MouseClick
        If Clear_all_panel.Visible = True Then
            Clear_all_panel.Visible = False
        End If
    End Sub

    Private Sub Gourp1_MouseClick(sender As Object, e As MouseEventArgs) Handles Group1.MouseClick
        If Clear_all_panel.Visible = True Then
            Clear_all_panel.Visible = False
        End If
    End Sub

    Private Sub Group2_MouseClick(sender As Object, e As MouseEventArgs) Handles Group2.MouseClick
        If Clear_all_panel.Visible = True Then
            Clear_all_panel.Visible = False
        End If
    End Sub

    Private Sub Group4_MouseClick(sender As Object, e As MouseEventArgs) Handles Group4.MouseClick
        If Clear_all_panel.Visible = True Then
            Clear_all_panel.Visible = False
        End If
    End Sub
#End Region
End Class