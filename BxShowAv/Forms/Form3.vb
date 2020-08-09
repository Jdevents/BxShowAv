Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json

Public Class Form3
    Dim val As New Butt_settings
    Dim songs As New List(Of String)
    Dim butt_data As String = Application.StartupPath & "\playlist_data\butt_data.json"


    Private Sub Group1_but1_Click(sender As Object, e As EventArgs) Handles Group1_but1.Click, Group1_but2.Click

        Dim but = CType(sender, DevExpress.XtraEditors.SimpleButton)

        testplayer.URL = but.Tag

        Exit Sub
    End Sub

    Private Sub Group1_but1_MouseHover(sender As Object, e As EventArgs) Handles Group1_but1.MouseHover
        songnametip()
        Songname.SetToolTip(Group1_but1, testplayer.URL)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(butt_data) = True Then
            load_butt()
        End If
    End Sub

    Private Sub songnametip()
        'Songname.ToolTipTitle = "[" & testplayer.currentMedia.name & "]"
        'Songname.UseFading = True
        'Songname.UseAnimation = True
        'Songname.ShowAlways = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        testplayer.Ctlcontrols.stop()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim mi = CType(sender, ToolStripMenuItem)
        Dim cms = CType(mi.Owner, ContextMenuStrip)
        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then
                        If but.Name = cms.SourceControl.Name Then
                            but.Text = ""
                            but.Tag = ""
                            Exit For
                        End If
                    End If
                Next
            End If
        Next
        save_butt_data()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim mi = CType(sender, ToolStripMenuItem)
        Dim cms = CType(mi.Owner, ContextMenuStrip)
        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then
                        If but.Name = cms.SourceControl.Name Then
                            'show edit form
                            Dim form As New Form3_Settings
                            form.SongNameTextEdit.Text = but.Text
                            form.songpath.Text = but.Tag
                            form.ColorPickEdit1.Color = but.BackColor
                            If form.ShowDialog = DialogResult.OK Then
                                but.BackColor = form.ColorPickEdit1.EditValue
                                but.Text = form.SongNameTextEdit.Text
                                but.Tag = form.songpath.Text
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
        Dim mi = CType(sender, ToolStripMenuItem)
        Dim cms = CType(mi.Owner, ContextMenuStrip)
        For Each c As Control In Me.Controls
            If TypeOf c Is DevExpress.XtraEditors.GroupControl Then
                For Each but As Control In c.Controls
                    If TypeOf but Is DevExpress.XtraEditors.SimpleButton Then
                        If but.Name = cms.SourceControl.Name Then
                            'show edit form
                            Dim form As New Form3_Settings
                            form.SongNameTextEdit.Text = but.Text
                            form.songpath.Text = but.Tag
                            form.ColorPickEdit1.Color = but.BackColor
                            If form.ShowDialog = DialogResult.OK Then
                                but.BackColor = form.ColorPickEdit1.EditValue
                                but.Text = form.SongNameTextEdit.Text
                                but.Tag = form.songpath.Text
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

                            If but.Name = list(a).Buttname Then
                                but.Text = list(a).Butt_text
                                but.Tag = list(a).Path
                                but.BackColor = System.Drawing.Color.FromName(list(a).Colour)

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
                        item.Colour = but.BackColor.ToString
                        item.Buttname = but.Name
                        item.Butt_text = but.Text
                        list.Add(item)

                    End If
                Next
            End If
        Next
        File.WriteAllText(butt_data, JsonConvert.SerializeObject(list))
    End Sub
End Class