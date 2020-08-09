<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_Settings
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.ColorPickEdit1 = New DevExpress.XtraEditors.ColorPickEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AxNameGet = New AxWMPLib.AxWindowsMediaPlayer()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.songpath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxNameGet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Song &Path:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 100)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Apply"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(93, 100)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Exit"
        '
        'songpath
        '
        Me.BehaviorManager1.SetBehaviors(Me.songpath, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.OpenFileBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.OpenFileBehaviorSourceForButtonEdit), True, DevExpress.Utils.Behaviors.Common.FileIconSize.Small, Nothing, Nothing, DevExpress.Utils.Behaviors.Common.CompletionMode.FilesAndDirectories, Nothing, "mp3|*.mp3|wav|*.wav", DevExpress.Utils.CommonDialogs.FileBrowserStyle.Skinnable), DevExpress.Utils.Behaviors.Behavior)})
        Me.songpath.EditValue = ""
        Me.songpath.Location = New System.Drawing.Point(112, 25)
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
        Me.SongNameTextEdit.Location = New System.Drawing.Point(136, 57)
        Me.SongNameTextEdit.Name = "SongNameTextEdit"
        Me.SongNameTextEdit.Size = New System.Drawing.Size(333, 27)
        Me.SongNameTextEdit.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Button &Name:"
        '
        'ColorPickEdit1
        '
        Me.ColorPickEdit1.EditValue = System.Drawing.Color.Empty
        Me.ColorPickEdit1.Location = New System.Drawing.Point(316, 98)
        Me.ColorPickEdit1.Name = "ColorPickEdit1"
        Me.ColorPickEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorPickEdit1.Properties.Appearance.Options.UseFont = True
        Me.ColorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black
        Me.ColorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorPickEdit1.Size = New System.Drawing.Size(182, 26)
        Me.ColorPickEdit1.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Button &Color:"
        '
        'AxNameGet
        '
        Me.AxNameGet.Enabled = True
        Me.AxNameGet.Location = New System.Drawing.Point(576, 101)
        Me.AxNameGet.Name = "AxNameGet"
        Me.AxNameGet.OcxState = CType(resources.GetObject("AxNameGet.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxNameGet.Size = New System.Drawing.Size(75, 23)
        Me.AxNameGet.TabIndex = 33
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(475, 59)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(81, 23)
        Me.SimpleButton3.TabIndex = 34
        Me.SimpleButton3.Text = "Test Audio"
        '
        'Form3_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 136)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.AxNameGet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ColorPickEdit1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SongNameTextEdit)
        Me.Controls.Add(Me.songpath)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label1)
        Me.IconOptions.Image = CType(resources.GetObject("Form3_Settings.IconOptions.Image"), System.Drawing.Image)
        Me.Name = "Form3_Settings"
        Me.Text = "Add / Edit Sound Path"
        CType(Me.songpath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxNameGet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ColorPickEdit1 As DevExpress.XtraEditors.ColorPickEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents AxNameGet As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
