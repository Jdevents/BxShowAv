<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3_Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.songpath = New DevExpress.XtraEditors.ButtonEdit()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.SongNameTextEdit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameGet = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.songpath_lbl = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Songtot = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.Songtime = New System.Windows.Forms.Timer(Me.components)
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.songpath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameGet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Song &Path:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(14, 102)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(60, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Apply"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(80, 102)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(60, 23)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Exit"
        '
        'songpath
        '
        Me.BehaviorManager1.SetBehaviors(Me.songpath, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.OpenFileBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.OpenFileBehaviorSourceForButtonEdit), True, DevExpress.Utils.Behaviors.Common.FileIconSize.Small, Nothing, Nothing, DevExpress.Utils.Behaviors.Common.CompletionMode.FilesAndDirectories, Nothing, "mp3|*.mp3|wav|*.wav", DevExpress.Utils.CommonDialogs.FileBrowserStyle.Skinnable), DevExpress.Utils.Behaviors.Behavior)})
        Me.songpath.EditValue = ""
        Me.songpath.Location = New System.Drawing.Point(114, 12)
        Me.songpath.Name = "songpath"
        Me.songpath.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songpath.Properties.Appearance.Options.UseFont = True
        Me.songpath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.songpath.Properties.ReadOnly = True
        Me.songpath.Size = New System.Drawing.Size(768, 26)
        Me.songpath.TabIndex = 4
        '
        'SongNameTextEdit
        '
        Me.SongNameTextEdit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SongNameTextEdit.Location = New System.Drawing.Point(138, 44)
        Me.SongNameTextEdit.Name = "SongNameTextEdit"
        Me.SongNameTextEdit.Size = New System.Drawing.Size(744, 27)
        Me.SongNameTextEdit.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Button &Name:"
        '
        'NameGet
        '
        Me.NameGet.Enabled = True
        Me.NameGet.Location = New System.Drawing.Point(146, 99)
        Me.NameGet.Name = "NameGet"
        Me.NameGet.OcxState = CType(resources.GetObject("NameGet.OcxState"), System.Windows.Forms.AxHost.State)
        Me.NameGet.Size = New System.Drawing.Size(95, 24)
        Me.NameGet.TabIndex = 33
        Me.NameGet.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Audio Loaded:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "False"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(74, 129)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(132, 23)
        Me.SimpleButton4.TabIndex = 37
        Me.SimpleButton4.Text = "Set Name To Original"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Audio Path:"
        '
        'songpath_lbl
        '
        Me.songpath_lbl.AutoSize = True
        Me.songpath_lbl.Location = New System.Drawing.Point(91, 160)
        Me.songpath_lbl.Name = "songpath_lbl"
        Me.songpath_lbl.Size = New System.Drawing.Size(44, 13)
        Me.songpath_lbl.TabIndex = 40
        Me.songpath_lbl.Text = "Nothing"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Songtot)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.TrackBar1)
        Me.GroupControl1.Controls.Add(Me.SeparatorControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(212, 77)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(670, 80)
        Me.GroupControl1.TabIndex = 41
        '
        'Songtot
        '
        Me.Songtot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Songtot.AutoSize = True
        Me.Songtot.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Songtot.Location = New System.Drawing.Point(577, 52)
        Me.Songtot.Name = "Songtot"
        Me.Songtot.Size = New System.Drawing.Size(88, 18)
        Me.Songtot.TabIndex = 45
        Me.Songtot.Text = "00:00/00:00"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(577, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Song Time:"
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Location = New System.Drawing.Point(5, 30)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(548, 45)
        Me.TrackBar1.TabIndex = 42
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineColor = System.Drawing.Color.Black
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(559, 27)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(19, 50)
        Me.SeparatorControl1.TabIndex = 44
        '
        'Songtime
        '
        '
        'SimpleButton5
        '
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(14, 129)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(24, 23)
        Me.SimpleButton5.TabIndex = 42
        '
        'SimpleButton7
        '
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(44, 129)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(24, 23)
        Me.SimpleButton7.TabIndex = 44
        '
        'Form3_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SimpleButton2
        Me.ClientSize = New System.Drawing.Size(894, 178)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.songpath_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NameGet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SongNameTextEdit)
        Me.Controls.Add(Me.songpath)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label1)
        Me.IconOptions.Image = CType(resources.GetObject("Form3_Settings.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(894, 208)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(894, 208)
        Me.Name = "Form3_Settings"
        Me.Text = "Add / Edit Sound Path"
        CType(Me.songpath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameGet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents songpath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents SongNameTextEdit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameGet As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents songpath_lbl As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Songtime As Timer
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents Songtot As Label
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
End Class
