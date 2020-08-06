Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.DirectX.DirectSound
Imports System.Threading
Imports System.Collections.Specialized
Imports NAudio
Imports NAudio.CoreAudioApi
Imports System.Security.Principal
Imports Microsoft.VisualBasic.Devices
Imports NAudio.Wave
Imports WMPLib
Imports System.ComponentModel

Public Class Form2
    Private myXmlFilePath = myXmlFilePath
    Dim sound As String
    Dim TrkBar1 As Integer = 0
    Public Svol As Integer = 0
    Dim xmlPlaylist1, xmlPlaylist2, xmlPlaylist3, xmlPlaylist4 As String
    Private volume As Double
    Private volumelast As Double
    Private change As Double
    Private de As New MMDeviceEnumerator
    Private t As Threading.Thread
    Private booStopListening As Boolean
    Private booOnOff As Boolean
    Dim complevel As String
    Public Vplayer As Boolean = False
    Public Abox As Boolean = False
    Public VpCloseCheck As Boolean = False
    Dim val As New values

    'Dim waveout As New WaveOut
    Dim Rus As Boolean = False
    Dim songPlay As Boolean = True
    Dim path As String = Application.StartupPath & "\playlist_data\MainSongData.xml"
    Dim pathPL1 As String = Application.StartupPath & "\playlist_data\Playlist1Data.xml"
    Dim pathPL2 As String = Application.StartupPath & "\playlist_data\Playlist2Data.xml"
    Dim pathPL3 As String = Application.StartupPath & "\playlist_data\Playlist3Data.xml"
    Dim pathPL4 As String = Application.StartupPath & "\playlist_data\Playlist4Data.xml"
    Private PL1, PL2, PL3, PL4, MPL As Boolean
    <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Sub MusicStop()
        'Stops all music audio from playing
        AxPlayerAudio.Ctlcontrols.stop()
    End Sub
    Sub PLAYMUSIC(file)
        'First it sets the sound string to what ever the SonPath text bot is
        'Then it tries to play that file
        'Set the SongPathName label to what the sound string is set to
        sound = SongPathButtonEdit.Text()
        AxPlayerAudio.URL = sound
        AxPlayerAudio.settings.volume = 100
        lblSongName.Text = AxPlayerAudio.currentMedia.name
        Try
            AxPlayerAudio.Ctlcontrols.play()
        Catch ex As Exception
            MsgBox("2jx", MsgBoxStyle.Critical, "Error")
            ' MsgBox(ex.Message)
        End Try
        lblSongPathName.Text = sound
        songPlay = False
        sbPlaylist1.Enabled = False
        sbPlaylist2.Enabled = False
        sbPlaylist3.Enabled = False
        sbPlaylist4.Enabled = False
        sbPlaylist5.Enabled = False
        sbLoadPlaylist.Enabled = False
        SimpleButton6.Enabled = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxPlayerAudio.settings.volume = 100
        Control.CheckForIllegalCrossThreadCalls = False
        'Ya you can see what happens when the form first loads
        RadioButton1.Checked = True
        OpenFileDialog1.Filter = val.vidFormat

        DaComp()
        lblSongName.Text = ""
        SimpleButton13.Enabled = False
        AxWindowsMediaPlayer1.uiMode = "none"
        CheckEdit2.Enabled = False
        sbPause.Enabled = False
        sbPlay.Enabled = False
        sbStop.Enabled = False
        lblVidname.Text = ""
        sbFullScreen.Enabled = False
        sbExFullScreen.Enabled = False
        CheckEdit1.Enabled = False
        lblCompLevelStat.Text = "-8dB"
        sbPlaylist1.Enabled = False
        myXmlFilePath = path
        If My.Computer.FileSystem.FileExists(path) = True Then
            DsSongList.ReadXml(myXmlFilePath)
        End If
        Label5.Text = ""
        lblSongPathName.Text = ""
        If Label5.Text = "" Then
            sbPlayMusic.Enabled = False
        Else
            sbPlayMusic.Enabled = True
        End If
        lblstatus.Text = ""
        Timer1.Start()
        GetVol()
        LableVolStat.Text = GetVol() & "%"
        TrackBar1.Value = GetVol()
        NumericUpDown1.Value = 1
        lbCurrentPlaylist.Text = myXmlFilePath
        PL1 = False
        PL2 = False
        PL3 = False
        PL4 = False
        MPL = True
    End Sub

    Private Sub DtSongsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DtSongsBindingNavigatorSaveItem.Click
        'Saves the opened XML file when the save button is pushed
        saveXML()
        'AxPlayerAudio.currentPlaylist.clear()
        'AxNameGet.currentPlaylist.clear()
        'AxNameGet.URL = ""
        'Thread.Sleep(1)
        'Validate()
        'DtSongsBindingSource.EndEdit()
        'Try
        '    lblstatus.Text = ""
        '    DsSongList.WriteXml(lbCurrentPlaylist.Text)
        '    lblstatus.Text = "Saved"
        'Catch ex As Exception
        '    '  MsgBox(ex.Message)
        '    MsgBox("c73", MsgBoxStyle.Critical, "Error")
        '    lblstatus.Text = "Could not save"
        'End Try
    End Sub
    Private Sub DtSongsDataGridView_Click(sender As Object, e As EventArgs) Handles DtSongsDataGridView.Click
        'If the user clicks on a song it Syncs that song up
        Label5.Text = DtSongsDataGridView.CurrentRow.Cells(2).Value.ToString()
        sbPlayMusic.Enabled = True

        If CheckEdit3.Checked = True Then
            songPlay = True
        End If
        sound = Label5.Text()
    End Sub


    Private Sub sbPlayMusic_Click(sender As Object, e As EventArgs) Handles sbPlayMusic.Click
        If songPlay = False Then
            If Rus = True Then
                AxPlayerAudio.Ctlcontrols.play()
                Rus = False

            ElseIf Rus = False Then
                songtimetotlabe.Text = ""
                PLAYMUSIC(sound)
            End If
        ElseIf songPlay = True Then
            PLAYMUSIC(sound)
            songtimetotlabe.Text = ""
            songPlay = False
        End If
    End Sub

    Private Sub sbSyncMusic_Click(sender As Object, e As EventArgs) Handles sbSyncMusic.Click
        'It syncs up the next song
        sound = SongPathButtonEdit.Text
        Label5.Text = sound
        sbPlayMusic.Enabled = True
    End Sub

    Private Sub sbStopMusic_Click(sender As Object, e As EventArgs) Handles sbStopMusic.Click
        'Called the MusicStop sub
        MusicStop()
        sbPlaylist1.Enabled = True
        sbPlaylist2.Enabled = True
        sbPlaylist3.Enabled = True
        sbPlaylist4.Enabled = True
        sbPlaylist5.Enabled = True
        sbLoadPlaylist.Enabled = True
        SimpleButton6.Enabled = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Clear most of the labels
        lblstatus.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Displays the current time
        lbTime.Text = TimeOfDay()

        'every 100ms it is checking to see if the video player is open or not if is not open it clears it ready for the
        'next video
        If VpCloseCheck = True Then
            AxWindowsMediaPlayer1.currentPlaylist.clear()
            sbPlay.Enabled = False
            sbPause.Enabled = False
            sbStop.Enabled = False
            SimpleButton13.Enabled = False
            VpCloseCheck = False
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'Finding the converter for mp3 to wav
        Try
            Shell("Converter\Convert.exe")
        Catch ex As Exception
            MsgBox("m0vv", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SongPathButtonEdit_EditValueChanged(sender As Object, e As EventArgs) Handles SongPathButtonEdit.EditValueChanged
        'Ya not sure why i did this but it works so don't touch it
        SongNameTextEdit.Text = SongNameTextEdit.Text
        AxNameGet.URL = SongPathButtonEdit.Text
    End Sub

    Private Sub DtSongsDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles DtSongsDataGridView.DoubleClick

        'When you double click on a song within the data grid it calls for what cell has just been doubled clicked on
        'if the sbPlayMusic button isn't already enabled it then enables it
        'set the Synced song label to the song just double clicked
        'then it calls for the Mp3WavPlayer Sub

        Label5.Text = DtSongsDataGridView.CurrentRow.Cells(2).Value.ToString()
        sbPlayMusic.Enabled = True
        sound = Label5.Text()
        PLAYMUSIC(sound)

    End Sub

    'Public ssvol As Integer = Svol
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'this is the volume control unit
        'First it get the value of the trackBar
        'the if the Scol string is less(<) then 0 it sets the Svol as 0
        'but if it is > then 100 it sets the Svol value to 100
        'the volume label is then set to the GetVol Sub
        'it then calls for the SetVol sub

        Svol = TrackBar1.Value
        If Svol < 0 Then
            Svol = 0
        ElseIf Svol > 100 Then
            Svol = 100
        End If
        LableVolStat.Text = GetVol() & "%"
        SetVol()

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        'First it defines De, Device, and vol to get and set the right property for the device capture
        'the progress-bar's value is begin set to what the vol is

        Dim de As New MMDeviceEnumerator
        Dim Device As MMDevice = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Dim vol = Device.AudioMeterInformation.MasterPeakValue * 100

        ProgressBar1.Value = Int(vol)

    End Sub



    'FUNCTION SET VOLUME
    'This is setting the selected volume level
    Private Function SetVol()
        Dim DevEnum As New MMDeviceEnumerator
        Dim dev As MMDevice = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Try
            dev.AudioEndpointVolume.MasterVolumeLevelScalar = Svol / 100.0F
        Catch ex As Exception
            MsgBox("u0", MsgBoxStyle.Exclamation, "Error")
        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    'FUNCTION GET VOLUME
    'This is getting the current volume level
    Private Function GetVol() As Integer
        Dim MasterMin As Integer = 0
        Dim Vol As Integer = 0
        Dim DevEnum As New MMDeviceEnumerator
        Dim dev As MMDevice = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Try
            With dev.AudioEndpointVolume
                Vol = CInt(.MasterVolumeLevelScalar * 100)
                If Vol < MasterMin Then
                    Vol = MasterMin / 100
                End If
            End With
            Return Vol
        Catch ex As Exception
            MsgBox("m5k", MsgBoxStyle.Critical, "Error")
        End Try
#Disable Warning BC42353 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42353 ' Function doesn't return a value on all code paths

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'This is the button to mute the sound although it doesn't really do it.
        'The volume is set to 0 and with enough quit space you can just hear it.
        TrackBar1.Value = 0
        Svol = TrackBar1.Value
        If Svol < 0 Then
            Svol = 0
        End If
        LableVolStat.Text = "Muted"
        SetVol()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        'This is the button to set the volume to 100%
        TrackBar1.Value = 100
        Svol = TrackBar1.Value
        If Svol = 100 Then
            Svol = 100
        End If
        LableVolStat.Text = "100%"
        SetVol()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        'This is the button to set the volume to 50%
        TrackBar1.Value = 50
        Svol = TrackBar1.Value
        If Svol < 100 Then
            Svol = 50
        End If
        LableVolStat.Text = "50%"
        SetVol()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        'This is for the set duration on how long you want the vu meter/progress-bar to take before it moves again
        If NumericUpDown1.Value = 0 Then
            NumericUpDown1.Value = 1
            MessageBox.Show("Can't got below or to 0", "ERROR")
        Else
            Timer2.Interval = NumericUpDown1.Value
        End If
    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        'Checking if the user hits the enter key and if they did set the current value of the 
        'NumericUpDown1 value to the timer2 interval.
        If e.KeyChar = ChrW(Keys.Enter) Then
            Timer2.Interval = NumericUpDown1.Value
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'When the form is closing a lot has to happen.
        'The Pcheck sub is called to make sure the Play-list viewer is closed by checking a boolean
        'the waveout.Dispose get ride/ends the waveout. So if you were playing an mp3 file
        'it stops it without generating a loud pop noise
        'Then it validate's the form itself
        'ends the editing to the XML files and to the Data-grid
        'It then goes into a try statement to catch any errors that may show up
        'After that it checks if the Video player is open
        'If the video player is closed then it calls the saveXML sub
        'Something in regrades to the about form

        saveXML()

        DtSongsBindingSource.EndEdit()
        Pcheck()
        AxPlayerAudio.Dispose()
        'Threading.Thread.Sleep(1)
        'Me.Validate()
        'Try
        '    lblstatus.Text = ""
        '    DsSongList.WriteXml(lbCurrentPlaylist.Text)
        '    lblstatus.Text = "Saved"
        'Catch ex As Exception
        '    'MsgBox(ex.Message)
        '    MsgBox("c73", MsgBoxStyle.Critical, "Error")
        '    MsgBox("Could not save", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        'End Try
        If Vplayer = True Then
            VideoPlayer.Close()
        ElseIf Vplayer = False Then
            saveXML()
        End If

        If Abox = True Then
            XtraForm1.Close()
        ElseIf Abox = False Then
            saveXML()
        End If
        de.Dispose()
    End Sub

    Private Sub sbPlaylist1_Click(sender As Object, e As EventArgs) Handles sbPlaylist1.Click
        'This is the same for a bit!:
        'First it checks if the Play-list viewer is opened
        'Sets the Playlist Path in this case the myXmlFilePath
        'disables the button
        'enables the other buttons if not already done
        'This is the same from here
        Pcheck()
        myXmlFilePath = "MainSongData.xml"
        sbPlaylist1.Enabled = False
        lblSelectedPlaylist.Text = myXmlFilePath
        sbPlaylist2.Enabled = True
        sbPlaylist3.Enabled = True
        sbPlaylist4.Enabled = True
        sbPlaylist5.Enabled = True
        PL1 = False
        PL2 = False
        PL3 = False
        PL4 = False
        MPL = True
    End Sub

    Private Sub sbPlaylist3_Click(sender As Object, e As EventArgs) Handles sbPlaylist3.Click
        Pcheck()
        xmlPlaylist2 = "Playlist2Data.xml"
        sbPlaylist1.Enabled = True
        lblSelectedPlaylist.Text = xmlPlaylist2
        sbPlaylist2.Enabled = True
        sbPlaylist3.Enabled = False
        sbPlaylist4.Enabled = True
        sbPlaylist5.Enabled = True
        PL1 = False
        PL2 = True
        PL3 = False
        PL4 = False
        MPL = False
    End Sub

    Private Sub sbPlaylist4_Click(sender As Object, e As EventArgs) Handles sbPlaylist4.Click
        Pcheck()
        xmlPlaylist3 = "Playlist3Data.xml"
        sbPlaylist1.Enabled = True
        lblSelectedPlaylist.Text = xmlPlaylist3
        sbPlaylist2.Enabled = True
        sbPlaylist3.Enabled = True
        sbPlaylist4.Enabled = False
        sbPlaylist5.Enabled = True
        PL1 = False
        PL2 = False
        PL3 = True
        PL4 = False
        MPL = False
    End Sub

    Private Sub sbPlaylist5_Click(sender As Object, e As EventArgs) Handles sbPlaylist5.Click
        Pcheck()
        xmlPlaylist4 = "Playlist4Data.xml"
        sbPlaylist1.Enabled = True
        lblSelectedPlaylist.Text = xmlPlaylist4
        sbPlaylist2.Enabled = True
        sbPlaylist3.Enabled = True
        sbPlaylist4.Enabled = True
        sbPlaylist5.Enabled = False
        PL1 = False
        PL2 = False
        PL3 = False
        PL4 = True
        MPL = False
    End Sub

    Private Sub sbPlaylist2_Click(sender As Object, e As EventArgs) Handles sbPlaylist2.Click
        Pcheck()
        xmlPlaylist1 = "Playlist1Data.xml"
        sbPlaylist1.Enabled = True
        lblSelectedPlaylist.Text = xmlPlaylist1
        sbPlaylist2.Enabled = False
        sbPlaylist3.Enabled = True
        sbPlaylist4.Enabled = True
        sbPlaylist5.Enabled = True
        PL1 = True
        PL2 = False
        PL3 = False
        PL4 = True
        MPL = False
        'To here
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        'This is checking to see if the current selected playlist is the same as the already leaded playlist
        If lblSelectedPlaylist.Text = lbCurrentPlaylist.Text Then
            MsgBox("Playlist Already Loaded", MsgBoxStyle.Information, "Playlist Viewer")
        Else
            'If it finds that it is not the same then it sets the string in the form Playlist_view and changes one of it's
            'String's (PLVX) to the selected playlist. Gives it about 100ms before opening and displaying the Playlist
            'Viewer form with the selected playlist showing
            Playlist_View.PLVX = lblSelectedPlaylist.Text
            Threading.Thread.Sleep(100)
            Playlist_View.Show()
        End If
    End Sub
    Private Sub sbLoadPlaylist_Click(sender As Object, e As EventArgs) Handles sbLoadPlaylist.Click
        'First it clears the DsSongList data-grid
        'sets the labels
        DsSongList.Clear()
        lbCurrentPlaylist.Text = lblSelectedPlaylist.Text
        'Most of it is the same
        Try
            'It checks to see if the selectedPlaylisy label's text is = to the required XML file.
            'If the selected text is = to the required XML file name then it sets the DsSongList data-grid to
            'Display the contents of the XML file path.

            If MPL = True Then
                DsSongList.Clear()
                Thread.Sleep(2)
                DsSongList.ReadXml(path)
            End If

            If PL1 = True Then
                DsSongList.Clear()
                Thread.Sleep(2)
                DsSongList.ReadXml(pathPL1)
            End If

            If PL2 = True Then
                DsSongList.Clear()
                Thread.Sleep(2)
                DsSongList.ReadXml(pathPL2)
            End If

            If PL3 = True Then
                DsSongList.Clear()
                Thread.Sleep(2)
                DsSongList.ReadXml(pathPL3)
            End If

            If PL4 = True Then
                DsSongList.Clear()
                Thread.Sleep(2)
                DsSongList.ReadXml(pathPL4)
            End If

        Catch ex As Exception
            MsgBox("5ro", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub Compres_Tick(sender As Object, e As EventArgs) Handles Compres.Tick
        'Fist it checks to see if the track-bar's value = 99 or 60(if it was to be set at 100 or 60 then you begin to run into
        'Problems later on) then it checks to see if the progress-bar is >= the complevel.
        If TrackBar1.Value = 99 Or 60 And ProgressBar1.Value >= complevel Then
            'checks to see if the track-bar is <= 50. 
            'If it is then it shows the picture-box
            If TrackBar1.Value <= 50 Then
                PictureBox1.Visible = True
            Else
                'Checks if th Svol is < 100.
                'if it is set the Vol to 50
                'set the volLabel to 50%
                'then calls the SetVol sub
                If Svol < 100 Then
                    Svol = 50
                End If
                LableVolStat.Text = "50%"
                SetVol()
            End If
        End If

        If TrackBar1.Value = 100 Then
            TrackBar1.Value = 100
            Svol = TrackBar1.Value
            If Svol = 100 Then
                Svol = 99
            End If
        End If

        If TrackBar1.Value = 100 And ProgressBar1.Value >= complevel Then
            If Svol < 100 Then
                Svol = 50
            End If
            LableVolStat.Text = "50%"
            SetVol()
        End If

        'Checks to see if the Progress bar is either >= or < the complevel.
        If ProgressBar1.Value >= complevel Then
            'If the progress-bar value is >= to the complevel then it show the picture box
            PictureBox1.Visible = True
        End If
        If ProgressBar1.Value < complevel Then
            'If the progress-bar vale is < then the complevel then it hides the picture box
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub sbAcComp_Click(sender As Object, e As EventArgs) Handles sbAcComp.Click
        'Calls the Acomp sub
        Acomp()
    End Sub
    Sub DaComp()
        'This sub is for deactivating/truing off the compressor all together
        'First it stops the Compress timer
        'Changes the label
        'enables the Acomp button and disables the Dacomp button
        'hides the Group-control box
        'Hides the current set compressor level
        Compres.Stop()
        lblCompAD.Text = "&Deactivated"
        sbAcComp.Enabled = True
        sbDAcomp.Enabled = False
        PictureBox1.Visible = False
        GroupControl5.Visible = False
        lblCompLevelStat.Visible = False
    End Sub
    Sub Acomp()
        'This sub is for activating/truing on the compressor
        'First it starts the Compress timer
        'Changes the label
        'disables the Acomp button and enables the Dacomp button
        'shows the Group-control box
        'shows the current set compressor level
        Compres.Start()
        lblCompAD.Text = "&Activated"
        sbAcComp.Enabled = False
        sbDAcomp.Enabled = True
        GroupControl5.Visible = True
        lblCompLevelStat.Visible = True
    End Sub
    Private Sub sbDAcomp_Click(sender As Object, e As EventArgs) Handles sbDAcomp.Click
        'Calls the DaComp sub
        DaComp()
    End Sub
    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        'sets the radio-button to true
        'changes the label to the selected compression level.
        'the same from here
        RadioButton1.Checked = True
        lblCompLevelStat.Text = "-8dB"
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        RadioButton2.Checked = True
        lblCompLevelStat.Text = "-4dB"
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        RadioButton3.Checked = True
        lblCompLevelStat.Text = "0dB"

    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        RadioButton4.Checked = True
        lblCompLevelStat.Text = "4dB"
    End Sub

    Private Sub SimpleButton12_Click(sender As Object, e As EventArgs) Handles SimpleButton12.Click
        RadioButton5.Checked = True
        lblCompLevelStat.Text = "8dB"
        'To here
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'First it stops the compressor timer
        'Then it Sets the complevel to the requested level
        'waits for 3ms
        'starts the compressor timer again
        'This is the same from here
        Compres.Stop()
        complevel = 40
        Threading.Thread.Sleep(3)
        Compres.Start()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Compres.Stop()
        complevel = 62
        Threading.Thread.Sleep(3)
        Compres.Start()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Compres.Stop()
        complevel = 84
        Threading.Thread.Sleep(3)
        Compres.Start()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Compres.Stop()
        complevel = 109
        Threading.Thread.Sleep(3)
        Compres.Start()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Compres.Stop()
        complevel = 133
        Threading.Thread.Sleep(3)
        Compres.Start()
        'To here
    End Sub

    Private Sub sbVideoBrows_Click(sender As Object, e As EventArgs) Handles sbVideoBrows.Click
        'Checks to see if the open-file-dialog has a result of ok
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            'Sets both the VideoPLayer form's AxWindowsMediaPlayer1 url to the file selected by the open-file-dialog
            'does the same for this form's AxWindowsMediaPlayer1 url
            'Stops this form's AxWindowsMediaPlayer1, then it sets it to mute so you don't get a double sound going on
            'sets the Video name label to the file selected
            'stops the VideoPlayer AxWindowsMediaPlayer1
            'Enables some buttons and check boxes
            'Shows the VideoPlayer form
            VideoPlayer.AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName            '
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.settings.mute = True
            lblVidname.Text = AxWindowsMediaPlayer1.currentMedia.name
            VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.stop()
            sbPlay.Enabled = True
            CheckEdit1.Enabled = True
            SimpleButton13.Enabled = True
            sbFullScreen.Enabled = True
            CheckEdit2.Enabled = True
            VideoPlayer.Show()
            'Checks to see if the user wants to play music over the video and not have the videos audio playing at the same time
            If CheckEdit2.Checked = True Then
                VideoPlayer.AxWindowsMediaPlayer1.settings.mute = True
            End If

        End If
    End Sub

    Private Sub sbFullScreen_Click(sender As Object, e As EventArgs) Handles sbFullScreen.Click
        'First it checks to see if the VideoPlayer's AxWindowsMediaPlayer1 is playing something
        'If there is something playing in the VideoPlayer form's AxWindowsMediaPlayer1 then it changes it to go full screen
        'Disables this button and enables the Exit Full Screen button
        If VideoPlayer.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            VideoPlayer.AxWindowsMediaPlayer1.fullScreen = True
            sbFullScreen.Enabled = False
            sbExFullScreen.Enabled = True
        End If
    End Sub

    Private Sub sbExFullScreen_Click(sender As Object, e As EventArgs) Handles sbExFullScreen.Click
        'First it checks to see if the VideoPlayer's AxWindowsMediaPlayer1 is playing something and to check if it is in full
        'screen or not
        'If there is something playing in the VideoPlayer form's AxWindowsMediaPlayer1 and it is in full screen
        'then it changes it to exit the full screen
        'Disables this button and enables the Full Screen button
        If VideoPlayer.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying And sbFullScreen.Enabled = False Then
            VideoPlayer.AxWindowsMediaPlayer1.fullScreen = False
            sbFullScreen.Enabled = True
            sbExFullScreen.Enabled = False
        End If
    End Sub

    Private Sub sbPlay_Click(sender As Object, e As EventArgs) Handles sbPlay.Click
        'Checks if the users has checked the check button
        'This check button is for muting the music when playing a video
        'Calls the MusicStop Sub
        'tells both this form's and the VideoPlayer form's AxWindowsMediaPlayer1 to play
        'Enables the Pause and Stop button, then it disables this button and the check-edit

        'if it finds that the Check box was not checked then it does everything the same as if it was true just doesn't mute
        'the music
        If CheckEdit1.Checked = True Then
            MusicStop()
            VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.play()
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            sbPause.Enabled = True
            sbPlay.Enabled = False
            sbStop.Enabled = True
            CheckEdit1.Enabled = False
            VideoPlayer.TopMost = True
        ElseIf CheckEdit1.Checked = False Then
            VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.play()
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            sbPause.Enabled = True
            sbPlay.Enabled = False
            sbStop.Enabled = True
            CheckEdit1.Enabled = False
            VideoPlayer.TopMost = True
        End If
    End Sub

    Private Sub sbPause_Click(sender As Object, e As EventArgs) Handles sbPause.Click
        'Pauses both AxWindowsMediaPlayer1
        'Disables this button and enables the Play button along with the check-edit
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.pause()
        sbPause.Enabled = False
        sbPlay.Enabled = True
        CheckEdit1.Enabled = True
    End Sub

    Private Sub sbStop_Click(sender As Object, e As EventArgs) Handles sbStop.Click
        'Stop's both AxWindowsMediaPlayer1
        'Disables this button and enables the Play button along with the check-edit and the Pause button
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.stop()
        sbPause.Enabled = False
        sbPlay.Enabled = True
        sbStop.Enabled = False
        CheckEdit1.Enabled = True
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        'shows the About Form
        XtraForm1.Show()
    End Sub


    Private Sub SimpleButton13_Click(sender As Object, e As EventArgs) Handles SimpleButton13.Click
        'This button is for closing the VideoPlayer
        'Checks if the Vplayer boolean is set to true
        'If it is set to true then it does the following
        'First stops the timer3
        'changes the Text-boxes text
        'Sets the Video track-bar's max to 100 and the mini to 0
        'Clears both of the AxWindowsMediaPlayer1 current playlist and stops both of the AxWindowsMediaPlayer1
        'The VideoPlayer form is then Closed
        'Most of the video players controls buttons are then disabled
        If Vplayer = True Then
            Timer3.Stop()
            txtTimetot.Text = ""
            txtTimeVideo.Text = ""
            TrVidBar.Maximum = 100
            TrVidBar.Value = 0
            VideoPlayer.AxWindowsMediaPlayer1.currentPlaylist.clear()
            VideoPlayer.AxWindowsMediaPlayer1.close()
            VideoPlayer.Close()
            AxWindowsMediaPlayer1.currentPlaylist.clear()
            sbPlay.Enabled = False
            sbPause.Enabled = False
            sbStop.Enabled = False
            sbExFullScreen.Enabled = False
            sbFullScreen.Enabled = False
            SimpleButton13.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'This timer is for setting the track bar value to the AxWindowsMediaPlayer1 current potion of the video begin played
        'Sets the text boxes text to the right information need for the user to see what is happening
        TrVidBar.Value = CInt(Me.AxWindowsMediaPlayer1.Ctlcontrols.currentPosition)
        txtTimeVideo.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString

        Try
            txtTimetot.Text = AxWindowsMediaPlayer1.currentMedia.durationString
        Catch ex As Exception
            'This is need because it gets the shits if you close the video
            'so it just resets the text-box text to nothing
            txtTimetot.Text = ""
        End Try


    End Sub

    Private Sub AxWindowsMediaPlayer1_OpenStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_OpenStateChangeEvent) Handles AxWindowsMediaPlayer1.OpenStateChange
        'Sets the Videos track-bar max to the selected video time length
        'then it starts the timer
        If AxWindowsMediaPlayer1.openState = WMPLib.WMPOpenState.wmposMediaOpen Then
            TrVidBar.Maximum = CInt(AxWindowsMediaPlayer1.currentMedia.duration)
            Timer3.Start()
        End If

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            lblVidname.Text = ""
            sbPlay.Enabled = False
            sbPause.Enabled = False
            sbStop.Enabled = False
            sbExFullScreen.Enabled = False
            sbFullScreen.Enabled = False
            SimpleButton13.Enabled = False
            VideoPlayer.Close()
        End If

    End Sub

    Private Sub TrVidBar_Scroll(sender As Object, e As EventArgs) Handles TrVidBar.Scroll
        'This is for going foreword or backwards when a video is playing
        'Fist is Pauses both of the AxWindowsMediaPlayer1
        'resets this form's AxWindowsMediaPlayer1 to mute
        'sets the AxWindowsMediaPlayer1 potion to the Track-bar value
        'Waits 300ms
        'Then Play's both of the AxWindowsMediaPlayer1 to the selected time
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        AxWindowsMediaPlayer1.settings.mute = True
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = CDbl(TrVidBar.Value)
        VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.pause()
        VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = CDbl(TrVidBar.Value)
        System.Threading.Thread.Sleep(3)
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        'Checks it see if the user wants to mute the video audio
        If CheckEdit2.Checked = True Then
            VideoPlayer.AxWindowsMediaPlayer1.settings.mute = True
        ElseIf CheckEdit2.Checked = False Then
            VideoPlayer.AxWindowsMediaPlayer1.settings.mute = False
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_ClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles AxWindowsMediaPlayer1.ClickEvent
        'Checks if the Vplayer boolean is true
        'if it is true it pauses the VideoPlayer AxWindowsMediaPlayer1
        'and enables the Play button and disables the Pause button
        If Vplayer = True Then
            If AxWindowsMediaPlayer1.fullScreen = False Then
                VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.play()
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                sbFullScreen.Enabled = True
                sbExFullScreen.Enabled = False
            ElseIf AxWindowsMediaPlayer1.fullScreen = True Then
                VideoPlayer.AxWindowsMediaPlayer1.Ctlcontrols.pause()
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                sbPause.Enabled = False
                sbPlay.Enabled = True
                sbFullScreen.Enabled = True
                sbExFullScreen.Enabled = False
            End If
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_DoubleClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_DoubleClickEvent) Handles AxWindowsMediaPlayer1.DoubleClickEvent
        'If the Vplayer is true then it
        'Pauses the VideoPlayer's AxWindowsMediaPlayer1 and closes full screen
        If Vplayer = True Then
            VideoPlayer.AxWindowsMediaPlayer1.fullScreen = False
            AxWindowsMediaPlayer1.fullScreen = False
            If VideoPlayer.AxWindowsMediaPlayer1.fullScreen = False Then
                sbFullScreen.Enabled = True
                sbExFullScreen.Enabled = False
            End If

        End If
    End Sub

    Private Sub sbPauseMusic_Click(sender As Object, e As EventArgs) Handles sbPauseMusic.Click
        AxPlayerAudio.Ctlcontrols.pause()
        Rus = True
        sbPlaylist1.Enabled = True
        sbPlaylist2.Enabled = True
        sbPlaylist3.Enabled = True
        sbPlaylist4.Enabled = True
        sbPlaylist5.Enabled = True
        sbLoadPlaylist.Enabled = True
        SimpleButton6.Enabled = True
    End Sub

    Private Sub AudioTrcTimer_Tick(sender As Object, e As EventArgs) Handles AudioTrcTimer.Tick
        Try
            TrcSong.Value = CInt(Me.AxPlayerAudio.Ctlcontrols.currentPosition)
            songtimecurlabe.Text = AxPlayerAudio.Ctlcontrols.currentPositionString
            songtimetotlabe.Text = AxPlayerAudio.currentMedia.durationString
        Catch ex As Exception
            'This is need because it gets the shits if you close the video
            'so it just resets the text-box text to nothing
            songtimetotlabe.Text = ""
        End Try

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            sbPlaylist1.Enabled = True
            sbPlaylist2.Enabled = True
            sbPlaylist3.Enabled = True
            sbPlaylist4.Enabled = True
            sbPlaylist5.Enabled = True
            sbLoadPlaylist.Enabled = True
            SimpleButton6.Enabled = True
        End If


    End Sub

    Private Sub AxPlayerAudio_OpenStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_OpenStateChangeEvent) Handles AxPlayerAudio.OpenStateChange
        'Sets the Videos track-bar max to the selected video time length
        'then it starts the timer
        If AxPlayerAudio.openState = WMPLib.WMPOpenState.wmposMediaOpen Then
            TrcSong.Maximum = CInt(AxPlayerAudio.currentMedia.duration)
            AudioTrcTimer.Start()

        End If

    End Sub

    Private Sub TrcSong_Scroll(sender As Object, e As EventArgs) Handles TrcSong.Scroll
        'This is for going foreword or backwards when a video is playing
        'Fist is Pauses both of the AxWindowsMediaPlayer1
        'resets this form's AxWindowsMediaPlayer1 to mute
        'sets the AxWindowsMediaPlayer1 potion to the Track-bar value
        'Waits 300ms
        'Then Play's both of the AxWindowsMediaPlayer1 to the selected time
        AxPlayerAudio.Ctlcontrols.pause()
        AxPlayerAudio.Ctlcontrols.currentPosition = CDbl(TrcSong.Value)
        System.Threading.Thread.Sleep(3)
        AxPlayerAudio.Ctlcontrols.play()
    End Sub

    Private Sub CheckEdit4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit4.CheckedChanged
        If CheckEdit4.Checked = True Then
            AxPlayerAudio.settings.setMode("loop", True)
        ElseIf CheckEdit4.Checked = False Then
            AxPlayerAudio.settings.setMode("loop", False)
        End If
    End Sub
    Private Sub AxNameGet_CurrentItemChange(sender As Object, e As AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent) Handles AxNameGet.CurrentItemChange
        SongNameTextEdit.Text = AxNameGet.currentMedia.name
    End Sub

    Private Sub SimpleButton14_Click(sender As Object, e As EventArgs) Handles SimpleButton14.Click
        'This is for the lowers in and out affected
        'First it checks to see if the AxPlayerAudio is set to mute or not
        'If it is set to mute then it calls for the BackgroundWorker 2 and if it is not set to true
        'then it calls for BackgroundWorker 1
        If AxPlayerAudio.settings.mute = True Then
            BackgroundWorker1.RunWorkerAsync()
        ElseIf AxPlayerAudio.settings.mute = False Then
            BackgroundWorker2.RunWorkerAsync()
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Sets the Sleep-time string to the NumUpDown and multiples it by 100
        'The it checks if AxPlayerAudio volume is set to 0 or 5
        'if it is then it unmates the AxPlayer and increases the volume by 5 until it hits 100
        'When fading back in to audio I found that it is better to get the value of Sleep-time and + it by 4
        Dim Sleeptime As String
        Sleeptime = FaidTime.Value * 100
        PgFaid.Visible = True
        lblFaidProgress.Visible = True
        If AxPlayerAudio.settings.volume = 0 Or 5 Then
            AxPlayerAudio.settings.mute = False
            AxPlayerAudio.settings.volume = 5
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 10
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 15
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 20
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 25
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 30
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 35
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 40
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 45
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 50
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 55
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 60
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 65
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 70
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 75
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 80
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 85
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 90
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 95
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime + 4)
            AxPlayerAudio.settings.volume = 100
            BackgroundWorker1.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Threading.Thread.Sleep(1)
            PgFaid.Visible = False
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        'The it checks if AxPlayerAudio volume is set to 100 
        'if it is then it unmates the AxPlayer and decreases the volume by 5 until it hits 0
        'once it hits 0 it then mutes the AxPlayerAudio
        Dim Sleeptime As String
        Sleeptime = FaidTime.Value * 100
        PgFaid.Visible = True
        lblFaidProgress.Visible = True
        If AxPlayerAudio.settings.volume = 100 Then
            AxPlayerAudio.settings.volume = 95
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 90
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 85
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 80
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 75
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 70
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 65
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 60
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 55
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 50
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 45
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 40
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 35
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 30
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 25
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 20
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 15
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 10
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.volume = 5
            BackgroundWorker2.ReportProgress(AxPlayerAudio.settings.volume.ToString)
            Thread.Sleep(Sleeptime)
            AxPlayerAudio.settings.mute = True
            PgFaid.Visible = False
        End If
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        PgFaid.Value = e.ProgressPercentage
    End Sub
    Private Sub SimpleButton15_Click(sender As Object, e As EventArgs) Handles SimpleButton15.Click
        micvm.Show()
    End Sub

    Private Sub SimpleButton16_Click(sender As Object, e As EventArgs) Handles SimpleButton16.Click
        AVP.Show()
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        PgFaid.Value = e.ProgressPercentage
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        lblFaidProgress.Visible = False
    End Sub
    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        lblFaidProgress.Visible = False
    End Sub
    Private Sub FaidTime_ValueChanged(sender As Object, e As EventArgs) Handles FaidTime.ValueChanged
        'Can't go below 0 because it would just be a mute then
        If FaidTime.Value = 0 Then
            FaidTime.Value = 1
            MsgBox("Can't go below or to 0", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'Every 1ms it calls for the GetVol sub
        'it then keeps cheeking if GetVol sub and setting the Volume text
        'If the track bar is changed it's value is then set to the GetVol Sub

        GetVol()
        LableVolStat.Text = GetVol() & "%"
        TrackBar1.Value = GetVol()
    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    ScanSoundCards()
    'End Sub
    'Private Sub ScanSoundCards()

    '    ComboBox1.Items.Clear()

    '    For i As Integer = 0 To NAudio.Wave.WaveIn.DeviceCount - 1
    '        ComboBox1.Items.Add(NAudio.Wave.WaveIn.GetCapabilities(i).ProductName)
    '    Next

    '    If ComboBox1.Items.Count > 0 Then
    '        ComboBox1.SelectedIndex = 0
    '    Else
    '        MessageBox.Show("ERROR: no recording devices available")
    '    End If
    'End Sub

    Sub saveXML()
        'This sub is for Saving the Selected/opened XML file within the DsSongList DataGrid
        'Fist it closes the Playlist Viewer if it is not already closed
        'Waits 5ms then it validates the form
        'ends the editing for the DsSongBidingSource(XML File)
        'Calls a try Statement
        'Sets the Label States to nothing
        'It then tries to write to the opened/CurrentPlaylist
        Dim LBLSTat As String = "Saved!"
        Try
            AxPlayerAudio.currentPlaylist.clear()
            AxNameGet.currentPlaylist.clear()
            AxNameGet.close()
            AxPlayerAudio.close()
        Catch ex As Exception

        End Try
        Threading.Thread.Sleep(5)
        Me.Validate()
        DtSongsBindingSource.EndEdit()

        Try
            If MPL = True Then
                DsSongList.WriteXml(path)
                Thread.Sleep(2)
                '   MsgBox(path)
                lblstatus.Text = LBLSTat
            End If

            If PL1 = True Then
                DsSongList.WriteXml(pathPL1)
                Thread.Sleep(2)
                ' MsgBox(pathPL1)
                lblstatus.Text = LBLSTat
            End If

            If PL2 = True Then
                DsSongList.WriteXml(pathPL2)
                Thread.Sleep(2)
                '  MsgBox(pathPL2)
                lblstatus.Text = LBLSTat
            End If

            If PL3 = True Then
                DsSongList.WriteXml(pathPL3)
                Thread.Sleep(2)
                ' MsgBox(pathPL3)
                lblstatus.Text = LBLSTat
            End If

            If PL4 = True Then
                DsSongList.WriteXml(pathPL4)
                Thread.Sleep(2)
                ' MsgBox(pathPL4)
                lblstatus.Text = LBLSTat
            End If

        Catch ex As Exception
            MsgBox("c73", MsgBoxStyle.Critical, "Error")
            MsgBox("Could not save", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        End Try

        'Try
        '    Dim txtXMLFilePath As String = lbCurrentPlaylist.Text
        '    lblstatus.Text = ""
        '    DsSongList.WriteXml(txtXMLFilePath)
        '    MessageBox.Show("XML data saved to " + txtXMLFilePath)
        'Catch ex As Exception
        '    MsgBox("c73", MsgBoxStyle.Critical, "Error")
        '    MsgBox("Could not save", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        'End Try
    End Sub
    Sub Pcheck()
        'Checks to see if the Playlsit_View boolean OPas is true
        'if it is then closes
        'But if it returns as false then call the SaveXML sub
        If Playlist_View.OPas = True Then
            Playlist_View.Close()
        ElseIf Playlist_View.OPas = False Then
            saveXML()
        End If
    End Sub
End Class