<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class micvm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(micvm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lineouttime = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lch = New VU_MeterLibrary.VuMeter()
        Me.rch = New VU_MeterLibrary.VuMeter()
        Me.delyms = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.LineOutR = New VU_MeterLibrary.VuMeter()
        Me.LineOutL = New VU_MeterLibrary.VuMeter()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl4 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LoutLR = New VU_MeterLibrary.VuMeter()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mictim = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        CType(Me.delyms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(368, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(326, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "L"
        '
        'lineouttime
        '
        Me.lineouttime.Interval = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox1.Location = New System.Drawing.Point(12, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "Peak Hold"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'lch
        '
        Me.lch.AnalogMeter = False
        Me.lch.BackColor = System.Drawing.Color.Transparent
        Me.lch.DialBackground = System.Drawing.Color.White
        Me.lch.DialTextNegative = System.Drawing.Color.Red
        Me.lch.DialTextPositive = System.Drawing.Color.Black
        Me.lch.DialTextZero = System.Drawing.Color.DarkGreen
        Me.lch.Led1ColorOff = System.Drawing.Color.DarkGreen
        Me.lch.Led1ColorOn = System.Drawing.Color.LimeGreen
        Me.lch.Led1Count = 24
        Me.lch.Led2ColorOff = System.Drawing.Color.Olive
        Me.lch.Led2ColorOn = System.Drawing.Color.Yellow
        Me.lch.Led2Count = 6
        Me.lch.Led3ColorOff = System.Drawing.Color.Maroon
        Me.lch.Led3ColorOn = System.Drawing.Color.Red
        Me.lch.Led3Count = 5
        Me.lch.LedSize = New System.Drawing.Size(10, 8)
        Me.lch.LedSpace = 3
        Me.lch.Level = 0
        Me.lch.LevelMax = 130
        Me.lch.Location = New System.Drawing.Point(324, 49)
        Me.lch.MeterScale = VU_MeterLibrary.MeterScale.Log10
        Me.lch.Name = "lch"
        Me.lch.NeedleColor = System.Drawing.Color.Black
        Me.lch.PeakHold = False
        Me.lch.Peakms = 1000
        Me.lch.PeakNeedleColor = System.Drawing.Color.Red
        Me.lch.ShowDialOnly = False
        Me.lch.ShowLedPeak = False
        Me.lch.ShowTextInDial = True
        Me.lch.Size = New System.Drawing.Size(16, 388)
        Me.lch.TabIndex = 0
        Me.lch.TextInDial = New String() {"-40", "-20", "-10", "-5", "0", "+6"}
        Me.lch.UseLedLight = False
        Me.lch.VerticalBar = True
        Me.lch.VuText = "VU"
        '
        'rch
        '
        Me.rch.AnalogMeter = False
        Me.rch.BackColor = System.Drawing.Color.Transparent
        Me.rch.DialBackground = System.Drawing.Color.White
        Me.rch.DialTextNegative = System.Drawing.Color.Red
        Me.rch.DialTextPositive = System.Drawing.Color.Black
        Me.rch.DialTextZero = System.Drawing.Color.DarkGreen
        Me.rch.Led1ColorOff = System.Drawing.Color.DarkGreen
        Me.rch.Led1ColorOn = System.Drawing.Color.LimeGreen
        Me.rch.Led1Count = 24
        Me.rch.Led2ColorOff = System.Drawing.Color.Olive
        Me.rch.Led2ColorOn = System.Drawing.Color.Yellow
        Me.rch.Led2Count = 6
        Me.rch.Led3ColorOff = System.Drawing.Color.Maroon
        Me.rch.Led3ColorOn = System.Drawing.Color.Red
        Me.rch.Led3Count = 5
        Me.rch.LedSize = New System.Drawing.Size(10, 8)
        Me.rch.LedSpace = 3
        Me.rch.Level = 0
        Me.rch.LevelMax = 130
        Me.rch.Location = New System.Drawing.Point(368, 49)
        Me.rch.MeterScale = VU_MeterLibrary.MeterScale.Log10
        Me.rch.Name = "rch"
        Me.rch.NeedleColor = System.Drawing.Color.Black
        Me.rch.PeakHold = False
        Me.rch.Peakms = 1000
        Me.rch.PeakNeedleColor = System.Drawing.Color.Red
        Me.rch.ShowDialOnly = False
        Me.rch.ShowLedPeak = False
        Me.rch.ShowTextInDial = True
        Me.rch.Size = New System.Drawing.Size(16, 388)
        Me.rch.TabIndex = 30
        Me.rch.TextInDial = New String() {"-40", "-20", "-10", "-5", "0", "+6"}
        Me.rch.UseLedLight = False
        Me.rch.VerticalBar = True
        Me.rch.VuText = "VU"
        '
        'delyms
        '
        Me.delyms.BackColor = System.Drawing.SystemColors.Window
        Me.delyms.Enabled = False
        Me.delyms.ForeColor = System.Drawing.Color.Black
        Me.delyms.Location = New System.Drawing.Point(13, 43)
        Me.delyms.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.delyms.Name = "delyms"
        Me.delyms.Size = New System.Drawing.Size(58, 21)
        Me.delyms.TabIndex = 7
        Me.delyms.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(9, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "-25    20      10          7             5           3      1        0       +1  " &
    "         +3     "
        Me.Label1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(346, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "db"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(78, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "s"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox2.Location = New System.Drawing.Point(14, 70)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(148, 17)
        Me.CheckBox2.TabIndex = 46
        Me.CheckBox2.Text = "Logarithmic Scale (Log10)"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Lime
        Me.Label16.Location = New System.Drawing.Point(322, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Mic Level"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Lime
        Me.Label17.Location = New System.Drawing.Point(12, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 13)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Microphone Level Settings:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Lime
        Me.Label18.Location = New System.Drawing.Point(210, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 13)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Line Out Level"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Lime
        Me.Label19.Location = New System.Drawing.Point(248, 82)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 13)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "+1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Lime
        Me.Label20.Location = New System.Drawing.Point(244, 368)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(25, 13)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "-20"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Lime
        Me.Label21.Location = New System.Drawing.Point(243, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "db"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label22.ForeColor = System.Drawing.Color.Lime
        Me.Label22.Location = New System.Drawing.Point(265, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(16, 13)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "R"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Lime
        Me.Label24.Location = New System.Drawing.Point(244, 280)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 13)
        Me.Label24.TabIndex = 57
        Me.Label24.Text = "-10"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Lime
        Me.Label25.Location = New System.Drawing.Point(252, 215)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(18, 13)
        Me.Label25.TabIndex = 59
        Me.Label25.Text = "-5"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Lime
        Me.Label28.Location = New System.Drawing.Point(244, 412)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(25, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "-40"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label29.ForeColor = System.Drawing.Color.Lime
        Me.Label29.Location = New System.Drawing.Point(223, 30)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 13)
        Me.Label29.TabIndex = 50
        Me.Label29.Text = "L"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Lime
        Me.Label30.Location = New System.Drawing.Point(255, 138)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(14, 13)
        Me.Label30.TabIndex = 61
        Me.Label30.Text = "0"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox3.Location = New System.Drawing.Point(14, 168)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(148, 17)
        Me.CheckBox3.TabIndex = 68
        Me.CheckBox3.Text = "Logarithmic Scale (Log10)"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Lime
        Me.Label32.Location = New System.Drawing.Point(12, 107)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(144, 13)
        Me.Label32.TabIndex = 69
        Me.Label32.Text = "Line Out Level Settings:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.Window
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.Black
        Me.NumericUpDown1.Location = New System.Drawing.Point(13, 141)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(58, 21)
        Me.NumericUpDown1.TabIndex = 65
        Me.NumericUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox4.Location = New System.Drawing.Point(12, 123)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox4.TabIndex = 66
        Me.CheckBox4.Text = "Peak Hold"
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Lime
        Me.Label33.Location = New System.Drawing.Point(78, 143)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 13)
        Me.Label33.TabIndex = 67
        Me.Label33.Text = "s"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox5.Location = New System.Drawing.Point(-60, 170)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox5.TabIndex = 72
        Me.CheckBox5.Text = "Log10"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'LineOutR
        '
        Me.LineOutR.AnalogMeter = False
        Me.LineOutR.BackColor = System.Drawing.Color.Transparent
        Me.LineOutR.DialBackground = System.Drawing.Color.White
        Me.LineOutR.DialTextNegative = System.Drawing.Color.Red
        Me.LineOutR.DialTextPositive = System.Drawing.Color.Black
        Me.LineOutR.DialTextZero = System.Drawing.Color.DarkGreen
        Me.LineOutR.Led1ColorOff = System.Drawing.Color.DarkGreen
        Me.LineOutR.Led1ColorOn = System.Drawing.Color.LimeGreen
        Me.LineOutR.Led1Count = 24
        Me.LineOutR.Led2ColorOff = System.Drawing.Color.Olive
        Me.LineOutR.Led2ColorOn = System.Drawing.Color.Yellow
        Me.LineOutR.Led2Count = 6
        Me.LineOutR.Led3ColorOff = System.Drawing.Color.Maroon
        Me.LineOutR.Led3ColorOn = System.Drawing.Color.Red
        Me.LineOutR.Led3Count = 5
        Me.LineOutR.LedSize = New System.Drawing.Size(10, 8)
        Me.LineOutR.LedSpace = 3
        Me.LineOutR.Level = 0
        Me.LineOutR.LevelMax = 119
        Me.LineOutR.Location = New System.Drawing.Point(270, 48)
        Me.LineOutR.MeterScale = VU_MeterLibrary.MeterScale.Log10
        Me.LineOutR.Name = "LineOutR"
        Me.LineOutR.NeedleColor = System.Drawing.Color.Black
        Me.LineOutR.PeakHold = False
        Me.LineOutR.Peakms = 1000
        Me.LineOutR.PeakNeedleColor = System.Drawing.Color.Red
        Me.LineOutR.ShowDialOnly = False
        Me.LineOutR.ShowLedPeak = False
        Me.LineOutR.ShowTextInDial = True
        Me.LineOutR.Size = New System.Drawing.Size(16, 388)
        Me.LineOutR.TabIndex = 71
        Me.LineOutR.TextInDial = New String() {"-40", "-20", "-10", "-5", "0", "+6"}
        Me.LineOutR.UseLedLight = False
        Me.LineOutR.VerticalBar = True
        Me.LineOutR.VuText = "VU"
        '
        'LineOutL
        '
        Me.LineOutL.AnalogMeter = False
        Me.LineOutL.BackColor = System.Drawing.Color.Transparent
        Me.LineOutL.DialBackground = System.Drawing.Color.White
        Me.LineOutL.DialTextNegative = System.Drawing.Color.Red
        Me.LineOutL.DialTextPositive = System.Drawing.Color.Black
        Me.LineOutL.DialTextZero = System.Drawing.Color.DarkGreen
        Me.LineOutL.Led1ColorOff = System.Drawing.Color.DarkGreen
        Me.LineOutL.Led1ColorOn = System.Drawing.Color.LimeGreen
        Me.LineOutL.Led1Count = 24
        Me.LineOutL.Led2ColorOff = System.Drawing.Color.Olive
        Me.LineOutL.Led2ColorOn = System.Drawing.Color.Yellow
        Me.LineOutL.Led2Count = 6
        Me.LineOutL.Led3ColorOff = System.Drawing.Color.Maroon
        Me.LineOutL.Led3ColorOn = System.Drawing.Color.Red
        Me.LineOutL.Led3Count = 5
        Me.LineOutL.LedSize = New System.Drawing.Size(10, 8)
        Me.LineOutL.LedSpace = 3
        Me.LineOutL.Level = 0
        Me.LineOutL.LevelMax = 119
        Me.LineOutL.Location = New System.Drawing.Point(226, 48)
        Me.LineOutL.MeterScale = VU_MeterLibrary.MeterScale.Log10
        Me.LineOutL.Name = "LineOutL"
        Me.LineOutL.NeedleColor = System.Drawing.Color.Black
        Me.LineOutL.PeakHold = False
        Me.LineOutL.Peakms = 1000
        Me.LineOutL.PeakNeedleColor = System.Drawing.Color.Red
        Me.LineOutL.ShowDialOnly = False
        Me.LineOutL.ShowLedPeak = False
        Me.LineOutL.ShowTextInDial = True
        Me.LineOutL.Size = New System.Drawing.Size(16, 388)
        Me.LineOutL.TabIndex = 70
        Me.LineOutL.TextInDial = New String() {"-40", "-20", "-10", "-5", "0", "+6"}
        Me.LineOutL.UseLedLight = False
        Me.LineOutL.VerticalBar = True
        Me.LineOutL.VuText = "VU"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(266, -2)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(84, 474)
        Me.SeparatorControl1.TabIndex = 73
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorControl2.Location = New System.Drawing.Point(-12, 83)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(214, 23)
        Me.SeparatorControl2.TabIndex = 74
        '
        'SeparatorControl4
        '
        Me.SeparatorControl4.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorControl4.Location = New System.Drawing.Point(-12, 186)
        Me.SeparatorControl4.Name = "SeparatorControl4"
        Me.SeparatorControl4.Size = New System.Drawing.Size(214, 23)
        Me.SeparatorControl4.TabIndex = 76
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.AllowDrop = True
        Me.SeparatorControl3.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl3.Location = New System.Drawing.Point(150, -2)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Size = New System.Drawing.Size(84, 474)
        Me.SeparatorControl3.TabIndex = 77
        '
        'LoutLR
        '
        Me.LoutLR.AnalogMeter = True
        Me.LoutLR.BackColor = System.Drawing.Color.White
        Me.LoutLR.DialBackground = System.Drawing.Color.White
        Me.LoutLR.DialTextNegative = System.Drawing.Color.Red
        Me.LoutLR.DialTextPositive = System.Drawing.Color.Black
        Me.LoutLR.DialTextZero = System.Drawing.Color.DarkGreen
        Me.LoutLR.Led1ColorOff = System.Drawing.Color.DarkGreen
        Me.LoutLR.Led1ColorOn = System.Drawing.Color.LimeGreen
        Me.LoutLR.Led1Count = 25
        Me.LoutLR.Led2ColorOff = System.Drawing.Color.Olive
        Me.LoutLR.Led2ColorOn = System.Drawing.Color.Yellow
        Me.LoutLR.Led2Count = 6
        Me.LoutLR.Led3ColorOff = System.Drawing.Color.Maroon
        Me.LoutLR.Led3ColorOn = System.Drawing.Color.Red
        Me.LoutLR.Led3Count = 4
        Me.LoutLR.LedSize = New System.Drawing.Size(10, 8)
        Me.LoutLR.LedSpace = 3
        Me.LoutLR.Level = 0
        Me.LoutLR.LevelMax = 119
        Me.LoutLR.Location = New System.Drawing.Point(11, 274)
        Me.LoutLR.MeterScale = VU_MeterLibrary.MeterScale.Log10
        Me.LoutLR.Name = "LoutLR"
        Me.LoutLR.NeedleColor = System.Drawing.Color.Black
        Me.LoutLR.PeakHold = False
        Me.LoutLR.Peakms = 1000
        Me.LoutLR.PeakNeedleColor = System.Drawing.Color.Red
        Me.LoutLR.ShowDialOnly = True
        Me.LoutLR.ShowLedPeak = False
        Me.LoutLR.ShowTextInDial = True
        Me.LoutLR.Size = New System.Drawing.Size(174, 139)
        Me.LoutLR.TabIndex = 78
        Me.LoutLR.TextInDial = New String() {"-40", "-20", "-10", "-5", "0", "+3"}
        Me.LoutLR.UseLedLight = True
        Me.LoutLR.VerticalBar = True
        Me.LoutLR.VuText = "VU"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Lime
        Me.Label34.Location = New System.Drawing.Point(39, 224)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(126, 13)
        Me.Label34.TabIndex = 79
        Me.Label34.Text = "Line Out Left && Right"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Lime
        Me.Label35.Location = New System.Drawing.Point(249, 50)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(21, 13)
        Me.Label35.TabIndex = 80
        Me.Label35.Text = "+3"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox6.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox6.Location = New System.Drawing.Point(11, 436)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox6.TabIndex = 81
        Me.CheckBox6.Text = "Always On Top"
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(347, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "+3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(346, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "+1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(342, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "-20"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(343, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "-10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(350, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "-5"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(342, 412)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "-40"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Location = New System.Drawing.Point(353, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 13)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "0"
        '
        'mictim
        '
        Me.mictim.Interval = 1
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox7.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox7.Location = New System.Drawing.Point(11, 412)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox7.TabIndex = 92
        Me.CheckBox7.Text = "Change Settings"
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox8.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox8.Location = New System.Drawing.Point(13, 389)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(153, 17)
        Me.CheckBox8.TabIndex = 93
        Me.CheckBox8.Text = "Start/Stop Mic Level Meter"
        Me.CheckBox8.UseVisualStyleBackColor = False
        '
        'micvm
        '
        Me.Appearance.BackColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = CType(resources.GetObject("$this.BackgroundImageStore"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(406, 462)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.LoutLR)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.LineOutR)
        Me.Controls.Add(Me.LineOutL)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.delyms)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(Me.SeparatorControl4)
        Me.Controls.Add(Me.SeparatorControl3)
        Me.IconOptions.Icon = CType(resources.GetObject("micvm.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(422, 501)
        Me.MinimumSize = New System.Drawing.Size(406, 492)
        Me.Name = "micvm"
        Me.Text = "Vu Meters"
        CType(Me.delyms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lineouttime As Timer
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lch As VU_MeterLibrary.VuMeter
    Friend WithEvents rch As VU_MeterLibrary.VuMeter
    Friend WithEvents delyms As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label32 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label33 As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents LineOutR As VU_MeterLibrary.VuMeter
    Friend WithEvents LineOutL As VU_MeterLibrary.VuMeter
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl4 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LoutLR As VU_MeterLibrary.VuMeter
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents mictim As Timer
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckBox8 As CheckBox
End Class
