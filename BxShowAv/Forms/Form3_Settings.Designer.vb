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
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.songpath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameGet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SimpleButton1.Location = New System.Drawing.Point(14, 87)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Apply"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(95, 87)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
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
        Me.songpath.Size = New System.Drawing.Size(542, 26)
        Me.songpath.TabIndex = 4
        '
        'SongNameTextEdit
        '
        Me.SongNameTextEdit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SongNameTextEdit.Location = New System.Drawing.Point(138, 44)
        Me.SongNameTextEdit.Name = "SongNameTextEdit"
        Me.SongNameTextEdit.Size = New System.Drawing.Size(518, 27)
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
        Me.NameGet.Location = New System.Drawing.Point(573, 87)
        Me.NameGet.Name = "NameGet"
        Me.NameGet.OcxState = CType(resources.GetObject("NameGet.OcxState"), System.Windows.Forms.AxHost.State)
        Me.NameGet.Size = New System.Drawing.Size(95, 24)
        Me.NameGet.TabIndex = 33
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(314, 88)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(81, 23)
        Me.SimpleButton3.TabIndex = 34
        Me.SimpleButton3.Text = "Test Audio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Audio Loaded:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "False"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(176, 87)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(132, 23)
        Me.SimpleButton4.TabIndex = 37
        Me.SimpleButton4.Text = "Set Name To Original"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SimpleButton2
        Me.ClientSize = New System.Drawing.Size(668, 114)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.NameGet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SongNameTextEdit)
        Me.Controls.Add(Me.songpath)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label1)
        Me.IconOptions.Image = CType(resources.GetObject("Form3_Settings.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3_Settings"
        Me.Text = "Add / Edit Sound Path"
        CType(Me.songpath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameGet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As Button
End Class
