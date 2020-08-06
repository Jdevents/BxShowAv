Imports System
Imports System.Timers
Imports Un4seen.Bass
Imports NAudio
Imports NAudio.CoreAudioApi
Imports System.Threading

Public Structure WAVEOUTCAPS
    Public wMid As Short
    Public wPid As Short
    Public vDriverVersion As Integer
End Structure

Module Winmm_Declarations
    Public Declare Function waveInGetNumDevs Lib "winmm.dll" () As Integer
    Declare Auto Function waveOutGetDevCaps Lib "winmm.dll" (ByVal uDeviceID As Integer, ByRef lpCaps As WAVEOUTCAPS, ByVal uSize As Integer) As Integer
    Declare Function mixerClose Lib "winmm.dll" (ByVal hmx As IntPtr) As Integer
End Module
Class micvm

    Private Shared timer2 As System.Timers.Timer

    Dim val As New values
    Dim Strm As Integer, leftch As Integer, rightch As Integer, temp0 As Single, temp As Single, temp2 As Single, temp3 As Single
    Dim peak As Boolean = False
    Dim peak1 As Boolean = False
    Dim logarithm As Byte = 0
    Dim logarithm1 As Byte = 0
    Dim delay As Integer = 2000
    Dim delay1 As Integer = 2000
    Dim outline1 As Single, outline2 As Single, outline3 As Single, outline As Single
    Dim top_most As Boolean = False
    Dim RetVal As Integer
    Dim de As New MMDeviceEnumerator
    Dim Device As MMDevice = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)


    Private Sub micvm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
        CheckBox1.Checked = peak
        CheckBox4.Checked = peak1
        LineOutR.PeakHold = peak1
        LineOutL.PeakHold = peak1
        LoutLR.PeakHold = peak1
        lch.PeakHold = peak
        rch.PeakHold = peak
        LineOutR.MeterScale = logarithm1
        LoutLR.MeterScale = logarithm1
        LineOutL.MeterScale = logarithm1
        lch.MeterScale = logarithm
        rch.MeterScale = logarithm
        LineOutR.Peakms = delay1
        LoutLR.Peakms = delay1
        LineOutL.Peakms = delay1
        lch.Peakms = delay
        rch.Peakms = delay
        delyms.Value = delay
        NumericUpDown1.Value = delay1
        peackholddelay()
        Label5.Visible = False
        Label33.Visible = False
        Dim i As Integer
        i = waveInGetNumDevs()
        If i > 0 Then
            'MsgBox("Sound Card Found! " & i)
        Else
            MsgBox("No sound card!")
        End If

        BassNet.Registration(val.BASSRegEmail, val.BASSRegKey)
        Bass.BASS_RecordInit(-1)
        Strm = Bass.BASS_RecordStart(44100, 2, 0, Nothing, IntPtr.Zero)
        lineouttime.Enabled = Enabled


        '     mictim.Enabled = True
    End Sub



    Private Sub peackholddelay()
        LineOutL.Peakms = NumericUpDown1.Value * 1000
        LineOutR.Peakms = NumericUpDown1.Value * 1000
        LoutLR.Peakms = NumericUpDown1.Value * 1000
        lch.Peakms = delyms.Value * 1000
        rch.Peakms = delyms.Value * 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles lineouttime.Tick

        'Dim de As New MMDeviceEnumerator
        'Dim Device As MMDevice = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        ''  Dim vol = Device.AudioMeterInformation.MasterPeakValue * 100
        ''  LineOutR.Level = Int(vol)

        ''Checks the level of what is begin played and displaying on the line out led bars
        'LineOutL.Level = CInt((Math.Round(Device.AudioMeterInformation.PeakValues(0) * 100))) 'Output Left CH
        'LineOutR.Level = CInt((Math.Round(Device.AudioMeterInformation.PeakValues(1) * 100))) 'Output Right CH
        ''getting both channles and dsiaplying them on the analog vu metere
        'LoutLR.Level = CInt((Math.Round(Device.AudioMeterInformation.PeakValues(0) * 100))) And CInt((Math.Round(Device.AudioMeterInformation.PeakValues(1) * 100))) 'Both output left and right CH

        Try


            '  Dim vol = Device.AudioMeterInformation.MasterPeakValue * 100
            '  LineOutR.Level = Int(vol)
            'Checks the level of what is begin played and displaying on the line out led bars
            LineOutL.Level = CInt((Math.Round(Device.AudioMeterInformation.PeakValues(0) * 100))) 'Output Left CH
            LineOutR.Level = CInt((Math.Round(Device.AudioMeterInformation.PeakValues(1) * 100))) 'Output Right CH
            'getting both channles and dsiaplying them on the analog vu metere
            LoutLR.Level = CInt((Math.Round(Device.AudioMeterInformation.PeakValues(0) * 100))) And CInt((Math.Round(Device.AudioMeterInformation.PeakValues(1) * 100))) 'Both output left and right CH
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            delay1 = NumericUpDown1.Value * 1000
            LineOutL.Peakms = NumericUpDown1.Value * 1000
            LineOutR.Peakms = NumericUpDown1.Value * 1000
            LoutLR.Peakms = NumericUpDown1.Value * 1000
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        top_most = CheckBox6.Checked
        Me.TopMost = CheckBox6.Checked
    End Sub

    Public Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            RetVal = Bass.BASS_ChannelGetLevel(Strm)
            rightch = Un4seen.Bass.Utils.HighWord(RetVal) / 270 'Right Mic CH
            leftch = Un4seen.Bass.Utils.LowWord(RetVal) / 270   'Left Mic CH

            If rightch <= 130 Then
                temp2 = rightch
            Else
                temp2 = 130
            End If

            If leftch <= 130 Then
                temp0 = leftch
            Else
                temp0 = 130
            End If

            Me.leftlevel()
            Me.rightlevel()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mictim_Tick(sender As Object, e As EventArgs) Handles mictim.Tick
        Try
            RetVal = Bass.BASS_ChannelGetLevel(Strm)
            rightch = Un4seen.Bass.Utils.HighWord(RetVal) / 270 'Right Mic CH
            leftch = Un4seen.Bass.Utils.LowWord(RetVal) / 270   'Left Mic CH

            If rightch <= 130 Then
                temp2 = rightch
            Else
                temp2 = 130
            End If

            If leftch <= 130 Then
                temp0 = leftch
            Else
                temp0 = 130
            End If

            Me.leftlevel()
            Me.rightlevel()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            NumericUpDown1.Enabled = True
            delyms.Enabled = True
        Else
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            NumericUpDown1.Enabled = False
            delyms.Enabled = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True And lineouttime.Enabled = True Then
            If MessageBox.Show("When Ebaling Mic level, it will be delayed because of the lineout level reader!", "Vu Meter Warnning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                mictim.Start()
            End If
        ElseIf CheckBox8.Checked = False Then
            mictim.Stop()
            lch.Level = 0
            rch.Level = 0
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        peak = CheckBox1.Checked
        lch.PeakHold = peak
        rch.PeakHold = peak
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        peak1 = CheckBox4.Checked
        LineOutR.PeakHold = peak1
        LineOutL.PeakHold = peak1
        LoutLR.PeakHold = peak1
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        delay1 = NumericUpDown1.Value
        LineOutR.Peakms = NumericUpDown1.Value
        LineOutL.Peakms = NumericUpDown1.Value
    End Sub

    Private Sub delyms_ValueChanged(sender As Object, e As EventArgs) Handles delyms.ValueChanged
        delay = delyms.Value
        lch.Peakms = delyms.Value * 1000
        rch.Peakms = delyms.Value * 1000
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            logarithm = 1
            lch.MeterScale = 1
            rch.MeterScale = 1
        Else
            logarithm = 0
            lch.MeterScale = 0
            rch.MeterScale = 0
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            logarithm1 = 1
            LineOutR.MeterScale = 1
            LineOutL.MeterScale = 1
            LoutLR.MeterScale = 1
        Else
            logarithm1 = 0
            LineOutR.MeterScale = 0
            LineOutL.MeterScale = 0
            LoutLR.MeterScale = 0
        End If
    End Sub

    Private Sub delyms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles delyms.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            delay = delyms.Value
            lch.Peakms = delyms.Value * 1000
            rch.Peakms = delyms.Value * 1000
        End If
    End Sub

    Sub leftlevel()
        'Subroutine "smooth numbers" for the left channel with subsequent output
        temp = Format(temp, "00.0")
        temp0 = Format(temp0, "00.0")
        If temp = temp0 Then
            Return
        ElseIf temp0 > temp Then
            temp = temp0
        ElseIf temp0 < temp Then
            temp = temp - 2
        Else : Return
        End If
        lch.Level = temp
    End Sub
    Sub rightlevel()
        'Subroutine "smooth numbers" for the right channel with subsequent output
        temp3 = Format(temp3, "00.0")
        temp2 = Format(temp2, "00.0")
        If temp3 = temp2 Then
            Return
        ElseIf temp2 > temp3 Then
            temp3 = temp2
        ElseIf temp2 < temp3 Then
            temp3 = temp3 - 2
        Else : Return
        End If
        rch.Level = temp3
    End Sub
End Class