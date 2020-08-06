Imports System.IO
Imports System.Xml
Public Class Playlist_View
    Public PLVX As String
    Public OPas As Boolean = False
    Private Sub Playlist_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = PLVX
        OPas = True
        Dim xmlFile As XmlReader
        Dim ds As New DataSet
        Try
            xmlFile = XmlReader.Create(PLVX, New XmlReaderSettings())
            ds.ReadXml(xmlFile)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("28g", MsgBoxStyle.Exclamation, "Error")
            'MsgBox("No Selected Playlist To Be View!", MsgBoxStyle.Critical, "Error")
            'MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub
End Class