Imports System.Xml
Public Class AVP
    Dim path As String
    Dim viv As String
    Dim vidpath As String
    Dim val As values
    Sub SaveXML()
        Try
            AxVideo.currentPlaylist.clear()
            AxVideo.close()
            DsVidList.WriteXml(path)
        Catch ex As Exception

        End Try
        Threading.Thread.Sleep(5)
        Me.Validate()
        DataGridView1.EndEdit()
    End Sub

    Private Sub DsVideoListGridControl_DoubleClick(sender As Object, e As EventArgs)
        Label5.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        vidpath = Label5.Text()
        AxVideo.URL = vidpath
    End Sub

    Private Sub DsVideoListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DsVideoListBindingNavigatorSaveItem.Click
        SaveXML()
    End Sub

    Private Sub AVP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(path) = True Then
            DsVidList.ReadXml(path)
        End If
    End Sub
End Class