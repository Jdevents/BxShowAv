<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVP
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
        Dim VidIDLabel As System.Windows.Forms.Label
        Dim VidNameLabel As System.Windows.Forms.Label
        Dim VidPathLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVP))
        Me.AVPlayer = New BxShowAv.AVPlayer()
        Me.DsVideoListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVideoListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DsVideoListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AvPlayer1 = New BxShowAv.AVPlayer()
        Me.DsVideoListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AxVideo = New AxWMPLib.AxWindowsMediaPlayer()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.VidPathButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.DsVidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVidList = New BxShowAv.dsVidList()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VidIDLabel1 = New System.Windows.Forms.Label()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.VidNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.VidIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VidNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VidPathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        VidIDLabel = New System.Windows.Forms.Label()
        VidNameLabel = New System.Windows.Forms.Label()
        VidPathLabel = New System.Windows.Forms.Label()
        CType(Me.AVPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVideoListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVideoListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DsVideoListBindingNavigator.SuspendLayout()
        CType(Me.AvPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVideoListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VidPathButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVidList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VidNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VidIDLabel
        '
        VidIDLabel.AutoSize = True
        VidIDLabel.Location = New System.Drawing.Point(12, 34)
        VidIDLabel.Name = "VidIDLabel"
        VidIDLabel.Size = New System.Drawing.Size(39, 13)
        VidIDLabel.TabIndex = 91
        VidIDLabel.Text = "Vid ID:"
        '
        'VidNameLabel
        '
        VidNameLabel.AutoSize = True
        VidNameLabel.Location = New System.Drawing.Point(12, 76)
        VidNameLabel.Name = "VidNameLabel"
        VidNameLabel.Size = New System.Drawing.Size(55, 13)
        VidNameLabel.TabIndex = 93
        VidNameLabel.Text = "Vid Name:"
        '
        'VidPathLabel
        '
        VidPathLabel.AutoSize = True
        VidPathLabel.Location = New System.Drawing.Point(12, 125)
        VidPathLabel.Name = "VidPathLabel"
        VidPathLabel.Size = New System.Drawing.Size(50, 13)
        VidPathLabel.TabIndex = 94
        VidPathLabel.Text = "Vid Path:"
        '
        'AVPlayer
        '
        Me.AVPlayer.DataSetName = "AVPlayer"
        Me.AVPlayer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsVideoListBindingSource
        '
        Me.DsVideoListBindingSource.DataMember = "dsVideoList"
        Me.DsVideoListBindingSource.DataSource = Me.AVPlayer
        '
        'DsVideoListBindingNavigator
        '
        Me.DsVideoListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DsVideoListBindingNavigator.BindingSource = Me.DsVideoListBindingSource
        Me.DsVideoListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DsVideoListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DsVideoListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DsVideoListBindingNavigatorSaveItem})
        Me.DsVideoListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DsVideoListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DsVideoListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DsVideoListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DsVideoListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DsVideoListBindingNavigator.Name = "DsVideoListBindingNavigator"
        Me.DsVideoListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DsVideoListBindingNavigator.Size = New System.Drawing.Size(1147, 25)
        Me.DsVideoListBindingNavigator.TabIndex = 0
        Me.DsVideoListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DsVideoListBindingNavigatorSaveItem
        '
        Me.DsVideoListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DsVideoListBindingNavigatorSaveItem.Image = CType(resources.GetObject("DsVideoListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DsVideoListBindingNavigatorSaveItem.Name = "DsVideoListBindingNavigatorSaveItem"
        Me.DsVideoListBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DsVideoListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AvPlayer1
        '
        Me.AvPlayer1.DataSetName = "AVPlayer"
        Me.AvPlayer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsVideoListBindingSource1
        '
        Me.DsVideoListBindingSource1.DataMember = "dsVideoList"
        Me.DsVideoListBindingSource1.DataSource = Me.AvPlayer1
        '
        'AxVideo
        '
        Me.AxVideo.Enabled = True
        Me.AxVideo.Location = New System.Drawing.Point(711, 166)
        Me.AxVideo.Name = "AxVideo"
        Me.AxVideo.OcxState = CType(resources.GetObject("AxVideo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideo.Size = New System.Drawing.Size(416, 251)
        Me.AxVideo.TabIndex = 88
        Me.AxVideo.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(726, 527)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Synced song Path:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(822, 528)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Song Path"
        '
        'VidPathButtonEdit
        '
        Me.BehaviorManager1.SetBehaviors(Me.VidPathButtonEdit, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.OpenFileBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.OpenFileBehaviorSourceForButtonEdit), True, DevExpress.Utils.Behaviors.Common.FileIconSize.Small, Nothing, Nothing, DevExpress.Utils.Behaviors.Common.CompletionMode.Files, "mp4|*.mp4|m4a|*.m4a|m4v|*.m4v|mkv|*.mkv|WMV|*.wmv|wma|*.wma|FLV|*.flv|AVI|*.avi|Q" &
                    "uickTime|*.mov|QuickTime|*.qt", "mp4|*.mp4|m4a|*.m4a|m4v|*.m4v|mkv|*.mkv|WMV|*.wmv|wma|*.wma|FLV|*.flv|AVI|*.avi|Q" &
                    "uickTime|*.mov|QuickTime|*.qt", DevExpress.Utils.CommonDialogs.FileBrowserStyle.[Default]), DevExpress.Utils.Behaviors.Behavior)})
        Me.VidPathButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsVidBindingSource, "VidPath", True))
        Me.VidPathButtonEdit.Location = New System.Drawing.Point(73, 122)
        Me.VidPathButtonEdit.Name = "VidPathButtonEdit"
        Me.VidPathButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.VidPathButtonEdit.Properties.ReadOnly = True
        Me.VidPathButtonEdit.Size = New System.Drawing.Size(283, 20)
        Me.VidPathButtonEdit.TabIndex = 95
        '
        'DsVidBindingSource
        '
        Me.DsVidBindingSource.DataMember = "dsVid"
        Me.DsVidBindingSource.DataSource = Me.DsVidList
        '
        'DsVidList
        '
        Me.DsVidList.DataSetName = "dsVidList"
        Me.DsVidList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VidIDDataGridViewTextBoxColumn, Me.VidNameDataGridViewTextBoxColumn, Me.VidPathDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DsVidBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(595, 398)
        Me.DataGridView1.TabIndex = 91
        '
        'VidIDLabel1
        '
        Me.VidIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsVidBindingSource, "VidID", True))
        Me.VidIDLabel1.Location = New System.Drawing.Point(57, 34)
        Me.VidIDLabel1.Name = "VidIDLabel1"
        Me.VidIDLabel1.Size = New System.Drawing.Size(40, 13)
        Me.VidIDLabel1.TabIndex = 92
        Me.VidIDLabel1.Text = "Label1"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(0, 50)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(365, 23)
        Me.SeparatorControl1.TabIndex = 93
        '
        'VidNameTextEdit
        '
        Me.VidNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsVidBindingSource, "VidName", True))
        Me.VidNameTextEdit.Location = New System.Drawing.Point(73, 73)
        Me.VidNameTextEdit.Name = "VidNameTextEdit"
        Me.VidNameTextEdit.Size = New System.Drawing.Size(283, 20)
        Me.VidNameTextEdit.TabIndex = 94
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Location = New System.Drawing.Point(0, 99)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(365, 23)
        Me.SeparatorControl2.TabIndex = 96
        '
        'VidIDDataGridViewTextBoxColumn
        '
        Me.VidIDDataGridViewTextBoxColumn.DataPropertyName = "VidID"
        Me.VidIDDataGridViewTextBoxColumn.HeaderText = "VidID"
        Me.VidIDDataGridViewTextBoxColumn.Name = "VidIDDataGridViewTextBoxColumn"
        '
        'VidNameDataGridViewTextBoxColumn
        '
        Me.VidNameDataGridViewTextBoxColumn.DataPropertyName = "VidName"
        Me.VidNameDataGridViewTextBoxColumn.HeaderText = "VidName"
        Me.VidNameDataGridViewTextBoxColumn.Name = "VidNameDataGridViewTextBoxColumn"
        '
        'VidPathDataGridViewTextBoxColumn
        '
        Me.VidPathDataGridViewTextBoxColumn.DataPropertyName = "VidPath"
        Me.VidPathDataGridViewTextBoxColumn.HeaderText = "VidPath"
        Me.VidPathDataGridViewTextBoxColumn.Name = "VidPathDataGridViewTextBoxColumn"
        '
        'AVP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 599)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(VidPathLabel)
        Me.Controls.Add(Me.VidPathButtonEdit)
        Me.Controls.Add(VidNameLabel)
        Me.Controls.Add(Me.VidNameTextEdit)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(VidIDLabel)
        Me.Controls.Add(Me.VidIDLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AxVideo)
        Me.Controls.Add(Me.DsVideoListBindingNavigator)
        Me.Name = "AVP"
        Me.Text = "AVP"
        CType(Me.AVPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVideoListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVideoListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DsVideoListBindingNavigator.ResumeLayout(False)
        Me.DsVideoListBindingNavigator.PerformLayout()
        CType(Me.AvPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVideoListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VidPathButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVidList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VidNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AVPlayer As AVPlayer
    Friend WithEvents DsVideoListBindingSource As BindingSource
    Friend WithEvents DsVideoListBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DsVideoListBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AvPlayer1 As AVPlayer
    Friend WithEvents DsVideoListBindingSource1 As BindingSource
    Friend WithEvents AxVideo As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsVidBindingSource As BindingSource
    Friend WithEvents DsVidList As dsVidList
    Friend WithEvents VidIDLabel1 As Label
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents VidNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VidPathButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents VidIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VidNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VidPathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
