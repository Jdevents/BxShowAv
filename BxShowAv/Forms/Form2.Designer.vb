<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SongIDLabel As System.Windows.Forms.Label
        Dim SongNameLabel As System.Windows.Forms.Label
        Dim SongPathLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DsSongList = New BxShowAv.dsSongList()
        Me.DtSongsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtSongsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DtSongsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SongIDLabel1 = New System.Windows.Forms.Label()
        Me.SongNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SongPathButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.DtSongsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSongPathName = New System.Windows.Forms.Label()
        Me.lblSongPath = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.sbPlayMusic = New DevExpress.XtraEditors.SimpleButton()
        Me.sbSyncMusic = New DevExpress.XtraEditors.SimpleButton()
        Me.sbStopMusic = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LableVolStat = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.sbLoadPlaylist = New DevExpress.XtraEditors.SimpleButton()
        Me.sbPlaylist1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.sbPlaylist5 = New DevExpress.XtraEditors.SimpleButton()
        Me.sbPlaylist4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.sbPlaylist3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sbPlaylist2 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbCurrentPlaylist = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblSelectedPlaylist = New System.Windows.Forms.Label()
        Me.Compres = New System.Windows.Forms.Timer(Me.components)
        Me.lblCompStat = New System.Windows.Forms.Label()
        Me.lblCompAD = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.lblCompLevelStat = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.sbDAcomp = New DevExpress.XtraEditors.SimpleButton()
        Me.sbAcComp = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton16 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblVidname = New System.Windows.Forms.Label()
        Me.TrVidBar = New System.Windows.Forms.TrackBar()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTimetot = New System.Windows.Forms.TextBox()
        Me.txtTimeVideo = New System.Windows.Forms.TextBox()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.sbStop = New DevExpress.XtraEditors.SimpleButton()
        Me.sbPause = New DevExpress.XtraEditors.SimpleButton()
        Me.sbPlay = New DevExpress.XtraEditors.SimpleButton()
        Me.sbExFullScreen = New DevExpress.XtraEditors.SimpleButton()
        Me.sbFullScreen = New DevExpress.XtraEditors.SimpleButton()
        Me.sbVideoBrows = New DevExpress.XtraEditors.SimpleButton()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton15 = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.sbPauseMusic = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblSongName = New System.Windows.Forms.Label()
        Me.TrcSong = New System.Windows.Forms.TrackBar()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.AudioTrcTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.FaidTime = New System.Windows.Forms.NumericUpDown()
        Me.SimpleButton14 = New DevExpress.XtraEditors.SimpleButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.PgFaid = New System.Windows.Forms.ProgressBar()
        Me.lblFaidProgress = New System.Windows.Forms.Label()
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.AxNameGet = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxPlayerAudio = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.songtimecurlabe = New System.Windows.Forms.Label()
        Me.songtimetotlabe = New System.Windows.Forms.Label()
        SongIDLabel = New System.Windows.Forms.Label()
        SongNameLabel = New System.Windows.Forms.Label()
        SongPathLabel = New System.Windows.Forms.Label()
        CType(Me.DsSongList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtSongsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtSongsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DtSongsBindingNavigator.SuspendLayout()
        CType(Me.SongNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SongPathButtonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtSongsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrVidBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrcSong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaidTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxNameGet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxPlayerAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SongIDLabel
        '
        SongIDLabel.AutoSize = True
        SongIDLabel.Location = New System.Drawing.Point(12, 36)
        SongIDLabel.Name = "SongIDLabel"
        SongIDLabel.Size = New System.Drawing.Size(49, 13)
        SongIDLabel.TabIndex = 1
        SongIDLabel.Text = "Song ID:"
        '
        'SongNameLabel
        '
        SongNameLabel.AutoSize = True
        SongNameLabel.Location = New System.Drawing.Point(12, 62)
        SongNameLabel.Name = "SongNameLabel"
        SongNameLabel.Size = New System.Drawing.Size(65, 13)
        SongNameLabel.TabIndex = 3
        SongNameLabel.Text = "Song Name:"
        '
        'SongPathLabel
        '
        SongPathLabel.AutoSize = True
        SongPathLabel.Location = New System.Drawing.Point(12, 88)
        SongPathLabel.Name = "SongPathLabel"
        SongPathLabel.Size = New System.Drawing.Size(60, 13)
        SongPathLabel.TabIndex = 5
        SongPathLabel.Text = "Song Path:"
        '
        'DsSongList
        '
        Me.DsSongList.DataSetName = "dsSongList"
        Me.DsSongList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtSongsBindingSource
        '
        Me.DtSongsBindingSource.DataMember = "dtSongs"
        Me.DtSongsBindingSource.DataSource = Me.DsSongList
        '
        'DtSongsBindingNavigator
        '
        Me.DtSongsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DtSongsBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.DtSongsBindingNavigator.BindingSource = Me.DtSongsBindingSource
        Me.DtSongsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DtSongsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DtSongsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DtSongsBindingNavigatorSaveItem})
        Me.DtSongsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DtSongsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DtSongsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DtSongsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DtSongsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DtSongsBindingNavigator.Name = "DtSongsBindingNavigator"
        Me.DtSongsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DtSongsBindingNavigator.Size = New System.Drawing.Size(1748, 25)
        Me.DtSongsBindingNavigator.TabIndex = 0
        Me.DtSongsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'DtSongsBindingNavigatorSaveItem
        '
        Me.DtSongsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DtSongsBindingNavigatorSaveItem.Image = CType(resources.GetObject("DtSongsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DtSongsBindingNavigatorSaveItem.Name = "DtSongsBindingNavigatorSaveItem"
        Me.DtSongsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DtSongsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SongIDLabel1
        '
        Me.SongIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtSongsBindingSource, "SongID", True))
        Me.SongIDLabel1.Location = New System.Drawing.Point(83, 36)
        Me.SongIDLabel1.Name = "SongIDLabel1"
        Me.SongIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SongIDLabel1.TabIndex = 2
        Me.SongIDLabel1.Text = "Label1"
        '
        'SongNameTextEdit
        '
        Me.SongNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DtSongsBindingSource, "SongName", True))
        Me.SongNameTextEdit.Location = New System.Drawing.Point(83, 59)
        Me.SongNameTextEdit.Name = "SongNameTextEdit"
        Me.SongNameTextEdit.Size = New System.Drawing.Size(460, 20)
        Me.SongNameTextEdit.TabIndex = 4
        '
        'SongPathButtonEdit
        '
        Me.SongPathButtonEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DtSongsBindingSource, "SongPath", True))
        Me.SongPathButtonEdit.Location = New System.Drawing.Point(83, 85)
        Me.SongPathButtonEdit.Name = "SongPathButtonEdit"
        '
        '
        '
        Me.SongPathButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SongPathButtonEdit.Properties.ReadOnly = True
        Me.SongPathButtonEdit.Size = New System.Drawing.Size(460, 20)
        Me.SongPathButtonEdit.TabIndex = 6
        '
        'DtSongsDataGridView
        '
        Me.DtSongsDataGridView.AllowUserToDeleteRows = False
        Me.DtSongsDataGridView.AutoGenerateColumns = False
        Me.DtSongsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtSongsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DtSongsDataGridView.DataSource = Me.DtSongsBindingSource
        Me.DtSongsDataGridView.Location = New System.Drawing.Point(0, 174)
        Me.DtSongsDataGridView.Name = "DtSongsDataGridView"
        Me.DtSongsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtSongsDataGridView.Size = New System.Drawing.Size(1748, 392)
        Me.DtSongsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SongID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SongID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SongName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SongName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SongPath"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SongPath"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 800
        '
        'lblSongPathName
        '
        Me.lblSongPathName.AutoSize = True
        Me.lblSongPathName.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongPathName.Location = New System.Drawing.Point(112, 71)
        Me.lblSongPathName.Name = "lblSongPathName"
        Me.lblSongPathName.Size = New System.Drawing.Size(603, 19)
        Me.lblSongPathName.TabIndex = 29
        Me.lblSongPathName.Text = "D:\icyzt\Music\Converted\Nightcore - POPSTARS (Switching Vocals) (League of Legen" &
    "ds).wav"
        '
        'lblSongPath
        '
        Me.lblSongPath.AutoSize = True
        Me.lblSongPath.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongPath.Location = New System.Drawing.Point(5, 65)
        Me.lblSongPath.Name = "lblSongPath"
        Me.lblSongPath.Size = New System.Drawing.Size(105, 27)
        Me.lblSongPath.TabIndex = 28
        Me.lblSongPath.Text = "Song Path:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Song Path"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Synced song Path:"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Red
        Me.lblstatus.Location = New System.Drawing.Point(12, 113)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(42, 17)
        Me.lblstatus.TabIndex = 33
        Me.lblstatus.Text = "Saved"
        '
        'sbPlayMusic
        '
        Me.sbPlayMusic.ImageOptions.Image = CType(resources.GetObject("sbPlayMusic.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPlayMusic.Location = New System.Drawing.Point(5, 30)
        Me.sbPlayMusic.Name = "sbPlayMusic"
        Me.sbPlayMusic.Size = New System.Drawing.Size(85, 37)
        Me.sbPlayMusic.TabIndex = 34
        Me.sbPlayMusic.Text = "Play"
        '
        'sbSyncMusic
        '
        Me.sbSyncMusic.ImageOptions.Image = CType(resources.GetObject("sbSyncMusic.ImageOptions.Image"), System.Drawing.Image)
        Me.sbSyncMusic.Location = New System.Drawing.Point(102, 116)
        Me.sbSyncMusic.Name = "sbSyncMusic"
        Me.sbSyncMusic.Size = New System.Drawing.Size(101, 37)
        Me.sbSyncMusic.TabIndex = 35
        Me.sbSyncMusic.Text = "Sync Path"
        '
        'sbStopMusic
        '
        Me.sbStopMusic.ImageOptions.Image = CType(resources.GetObject("sbStopMusic.ImageOptions.Image"), System.Drawing.Image)
        Me.sbStopMusic.Location = New System.Drawing.Point(5, 116)
        Me.sbStopMusic.Name = "sbStopMusic"
        Me.sbStopMusic.Size = New System.Drawing.Size(85, 37)
        Me.sbStopMusic.TabIndex = 36
        Me.sbStopMusic.Text = "Stop"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1637, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(101, 21)
        Me.SimpleButton1.TabIndex = 37
        Me.SimpleButton1.Text = "Clear Lables"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SimpleButton7)
        Me.Panel1.Controls.Add(Me.SimpleButton2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 987)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1748, 38)
        Me.Panel1.TabIndex = 38
        '
        'SimpleButton7
        '
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(1427, 9)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(62, 21)
        Me.SimpleButton7.TabIndex = 39
        Me.SimpleButton7.Text = "About"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1495, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(136, 21)
        Me.SimpleButton2.TabIndex = 38
        Me.SimpleButton2.Text = "Convert MP3 > WAV"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Time:"
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.Location = New System.Drawing.Point(55, 152)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(105, 19)
        Me.lbTime.TabIndex = 40
        Me.lbTime.Text = "00:00:00 AM"
        '
        'Timer1
        '
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TrackBar1.Location = New System.Drawing.Point(5, 31)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 280)
        Me.TrackBar1.TabIndex = 50
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.LableVolStat)
        Me.GroupControl1.Controls.Add(Me.TrackBar1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 30)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(128, 316)
        Me.GroupControl1.TabIndex = 51
        Me.GroupControl1.Text = "Volume Control"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(58, 259)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(65, 23)
        Me.SimpleButton5.TabIndex = 55
        Me.SimpleButton5.Text = "50%"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(58, 230)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(65, 23)
        Me.SimpleButton4.TabIndex = 54
        Me.SimpleButton4.Text = "100%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Level:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(58, 288)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(65, 23)
        Me.SimpleButton3.TabIndex = 52
        Me.SimpleButton3.Text = "Mute"
        '
        'LableVolStat
        '
        Me.LableVolStat.AutoSize = True
        Me.LableVolStat.Location = New System.Drawing.Point(87, 31)
        Me.LableVolStat.Name = "LableVolStat"
        Me.LableVolStat.Size = New System.Drawing.Size(36, 13)
        Me.LableVolStat.TabIndex = 51
        Me.LableVolStat.Text = "100%"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "-12dB"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "-8dB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "-4dB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "4dB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "8dB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "0dB"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Yellow
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(167, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 14)
        Me.Panel4.TabIndex = 57
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(247, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(40, 14)
        Me.Panel3.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(7, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 14)
        Me.Panel2.TabIndex = 56
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 46)
        Me.ProgressBar1.Maximum = 150
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(280, 23)
        Me.ProgressBar1.TabIndex = 65
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Label11)
        Me.GroupControl2.Controls.Add(Me.NumericUpDown1)
        Me.GroupControl2.Controls.Add(Me.Panel4)
        Me.GroupControl2.Controls.Add(Me.ProgressBar1)
        Me.GroupControl2.Controls.Add(Me.Panel2)
        Me.GroupControl2.Controls.Add(Me.Label9)
        Me.GroupControl2.Controls.Add(Me.Panel3)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Location = New System.Drawing.Point(146, 232)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(292, 109)
        Me.GroupControl2.TabIndex = 66
        Me.GroupControl2.Text = "Sound Level"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Sound Level Check Times"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(139, 83)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(36, 21)
        Me.NumericUpDown1.TabIndex = 66
        '
        'sbLoadPlaylist
        '
        Me.sbLoadPlaylist.ImageOptions.Image = CType(resources.GetObject("sbLoadPlaylist.ImageOptions.Image"), System.Drawing.Image)
        Me.sbLoadPlaylist.Location = New System.Drawing.Point(5, 111)
        Me.sbLoadPlaylist.Name = "sbLoadPlaylist"
        Me.sbLoadPlaylist.Size = New System.Drawing.Size(115, 59)
        Me.sbLoadPlaylist.TabIndex = 67
        Me.sbLoadPlaylist.Text = "Load Playlist"
        '
        'sbPlaylist1
        '
        Me.sbPlaylist1.ImageOptions.Image = CType(resources.GetObject("sbPlaylist1.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPlaylist1.Location = New System.Drawing.Point(5, 32)
        Me.sbPlaylist1.Name = "sbPlaylist1"
        Me.sbPlaylist1.Size = New System.Drawing.Size(151, 32)
        Me.sbPlaylist1.TabIndex = 68
        Me.sbPlaylist1.Text = "&Main Playlist"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.sbPlaylist5)
        Me.GroupControl3.Controls.Add(Me.sbPlaylist4)
        Me.GroupControl3.Controls.Add(Me.SimpleButton6)
        Me.GroupControl3.Controls.Add(Me.sbPlaylist3)
        Me.GroupControl3.Controls.Add(Me.sbPlaylist2)
        Me.GroupControl3.Controls.Add(Me.sbPlaylist1)
        Me.GroupControl3.Controls.Add(Me.lbCurrentPlaylist)
        Me.GroupControl3.Controls.Add(Me.Label12)
        Me.GroupControl3.Controls.Add(Me.Label14)
        Me.GroupControl3.Controls.Add(Me.sbLoadPlaylist)
        Me.GroupControl3.Controls.Add(Me.lblSelectedPlaylist)
        Me.GroupControl3.Location = New System.Drawing.Point(1236, 630)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(478, 177)
        Me.GroupControl3.TabIndex = 69
        Me.GroupControl3.Text = "Playlist"
        '
        'sbPlaylist5
        '
        Me.sbPlaylist5.ImageOptions.Image = CType(resources.GetObject("sbPlaylist5.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPlaylist5.Location = New System.Drawing.Point(162, 70)
        Me.sbPlaylist5.Name = "sbPlaylist5"
        Me.sbPlaylist5.Size = New System.Drawing.Size(151, 32)
        Me.sbPlaylist5.TabIndex = 72
        Me.sbPlaylist5.Text = "&Playlist 4"
        '
        'sbPlaylist4
        '
        Me.sbPlaylist4.ImageOptions.Image = CType(resources.GetObject("sbPlaylist4.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPlaylist4.Location = New System.Drawing.Point(5, 70)
        Me.sbPlaylist4.Name = "sbPlaylist4"
        Me.sbPlaylist4.Size = New System.Drawing.Size(151, 32)
        Me.sbPlaylist4.TabIndex = 71
        Me.sbPlaylist4.Text = "&Playlist 3"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(316, 70)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(148, 32)
        Me.SimpleButton6.TabIndex = 73
        Me.SimpleButton6.Text = "&Preview Selected Playlist"
        '
        'sbPlaylist3
        '
        Me.sbPlaylist3.ImageOptions.Image = CType(resources.GetObject("sbPlaylist3.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPlaylist3.Location = New System.Drawing.Point(316, 32)
        Me.sbPlaylist3.Name = "sbPlaylist3"
        Me.sbPlaylist3.Size = New System.Drawing.Size(148, 32)
        Me.sbPlaylist3.TabIndex = 70
        Me.sbPlaylist3.Text = "&Playlist 2"
        '
        'sbPlaylist2
        '
        Me.sbPlaylist2.ImageOptions.Image = CType(resources.GetObject("sbPlaylist2.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPlaylist2.Location = New System.Drawing.Point(162, 32)
        Me.sbPlaylist2.Name = "sbPlaylist2"
        Me.sbPlaylist2.Size = New System.Drawing.Size(151, 32)
        Me.sbPlaylist2.TabIndex = 69
        Me.sbPlaylist2.Text = "&Playlist 1"
        '
        'lbCurrentPlaylist
        '
        Me.lbCurrentPlaylist.AutoSize = True
        Me.lbCurrentPlaylist.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCurrentPlaylist.Location = New System.Drawing.Point(283, 108)
        Me.lbCurrentPlaylist.Name = "lbCurrentPlaylist"
        Me.lbCurrentPlaylist.Size = New System.Drawing.Size(178, 27)
        Me.lbCurrentPlaylist.TabIndex = 71
        Me.lbCurrentPlaylist.Text = "MainSongData.xml"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(126, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 27)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Current Playlist:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(126, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 27)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Selected Playlist:"
        '
        'lblSelectedPlaylist
        '
        Me.lblSelectedPlaylist.AutoSize = True
        Me.lblSelectedPlaylist.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedPlaylist.Location = New System.Drawing.Point(286, 141)
        Me.lblSelectedPlaylist.Name = "lblSelectedPlaylist"
        Me.lblSelectedPlaylist.Size = New System.Drawing.Size(178, 27)
        Me.lblSelectedPlaylist.TabIndex = 73
        Me.lblSelectedPlaylist.Text = "MainSongData.xml"
        '
        'Compres
        '
        '
        'lblCompStat
        '
        Me.lblCompStat.AutoSize = True
        Me.lblCompStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompStat.Location = New System.Drawing.Point(10, 32)
        Me.lblCompStat.Name = "lblCompStat"
        Me.lblCompStat.Size = New System.Drawing.Size(122, 16)
        Me.lblCompStat.TabIndex = 74
        Me.lblCompStat.Text = "&Compressor Status:"
        '
        'lblCompAD
        '
        Me.lblCompAD.AutoSize = True
        Me.lblCompAD.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompAD.Location = New System.Drawing.Point(9, 51)
        Me.lblCompAD.Name = "lblCompAD"
        Me.lblCompAD.Size = New System.Drawing.Size(90, 19)
        Me.lblCompAD.TabIndex = 75
        Me.lblCompAD.Text = "Deactivated"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(117, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.lblCompLevelStat)
        Me.GroupControl4.Controls.Add(Me.Label13)
        Me.GroupControl4.Controls.Add(Me.GroupControl5)
        Me.GroupControl4.Controls.Add(Me.sbDAcomp)
        Me.GroupControl4.Controls.Add(Me.sbAcComp)
        Me.GroupControl4.Controls.Add(Me.lblCompStat)
        Me.GroupControl4.Controls.Add(Me.lblCompAD)
        Me.GroupControl4.Controls.Add(Me.PictureBox1)
        Me.GroupControl4.Location = New System.Drawing.Point(146, 42)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(374, 176)
        Me.GroupControl4.TabIndex = 77
        Me.GroupControl4.Text = "Compressor"
        '
        'lblCompLevelStat
        '
        Me.lblCompLevelStat.AutoSize = True
        Me.lblCompLevelStat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompLevelStat.Location = New System.Drawing.Point(134, 132)
        Me.lblCompLevelStat.Name = "lblCompLevelStat"
        Me.lblCompLevelStat.Size = New System.Drawing.Size(38, 18)
        Me.lblCompLevelStat.TabIndex = 85
        Me.lblCompLevelStat.Text = "-8dB"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 18)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "&Compressor Level:"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.SimpleButton12)
        Me.GroupControl5.Controls.Add(Me.SimpleButton8)
        Me.GroupControl5.Controls.Add(Me.SimpleButton10)
        Me.GroupControl5.Controls.Add(Me.SimpleButton11)
        Me.GroupControl5.Controls.Add(Me.SimpleButton9)
        Me.GroupControl5.Location = New System.Drawing.Point(206, 32)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(160, 133)
        Me.GroupControl5.TabIndex = 83
        Me.GroupControl5.Text = "Compressor Level"
        '
        'SimpleButton12
        '
        Me.SimpleButton12.ImageOptions.Image = CType(resources.GetObject("SimpleButton12.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton12.Location = New System.Drawing.Point(85, 65)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(68, 23)
        Me.SimpleButton12.TabIndex = 82
        Me.SimpleButton12.Text = "8dB"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.ImageOptions.Image = CType(resources.GetObject("SimpleButton8.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(7, 36)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(68, 23)
        Me.SimpleButton8.TabIndex = 78
        Me.SimpleButton8.Text = "-8dB"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.ImageOptions.Image = CType(resources.GetObject("SimpleButton10.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton10.Location = New System.Drawing.Point(7, 94)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(68, 23)
        Me.SimpleButton10.TabIndex = 80
        Me.SimpleButton10.Text = "0dB"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.ImageOptions.Image = CType(resources.GetObject("SimpleButton11.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton11.Location = New System.Drawing.Point(85, 36)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(68, 23)
        Me.SimpleButton11.TabIndex = 81
        Me.SimpleButton11.Text = "4dB"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.ImageOptions.Image = CType(resources.GetObject("SimpleButton9.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(7, 64)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(68, 23)
        Me.SimpleButton9.TabIndex = 79
        Me.SimpleButton9.Text = "-4dB"
        '
        'sbDAcomp
        '
        Me.sbDAcomp.ImageOptions.Image = CType(resources.GetObject("sbDAcomp.ImageOptions.Image"), System.Drawing.Image)
        Me.sbDAcomp.Location = New System.Drawing.Point(10, 105)
        Me.sbDAcomp.Name = "sbDAcomp"
        Me.sbDAcomp.Size = New System.Drawing.Size(143, 23)
        Me.sbDAcomp.TabIndex = 77
        Me.sbDAcomp.Text = "&Deactivate Compressor"
        '
        'sbAcComp
        '
        Me.sbAcComp.ImageOptions.Image = CType(resources.GetObject("sbAcComp.ImageOptions.Image"), System.Drawing.Image)
        Me.sbAcComp.Location = New System.Drawing.Point(10, 76)
        Me.sbAcComp.Name = "sbAcComp"
        Me.sbAcComp.Size = New System.Drawing.Size(143, 23)
        Me.sbAcComp.TabIndex = 73
        Me.sbAcComp.Text = "&Activate Compressor"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(699, 572)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(35, 17)
        Me.RadioButton1.TabIndex = 78
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "-8"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(699, 589)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(35, 17)
        Me.RadioButton2.TabIndex = 79
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "-4"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(738, 589)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton3.TabIndex = 80
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "0"
        Me.RadioButton3.UseVisualStyleBackColor = True
        Me.RadioButton3.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(775, 572)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton4.TabIndex = 81
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(738, 572)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton5.TabIndex = 82
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "8"
        Me.RadioButton5.UseVisualStyleBackColor = True
        Me.RadioButton5.Visible = False
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.SimpleButton16)
        Me.GroupControl6.Controls.Add(Me.Label18)
        Me.GroupControl6.Controls.Add(Me.CheckEdit2)
        Me.GroupControl6.Controls.Add(Me.Label17)
        Me.GroupControl6.Controls.Add(Me.lblVidname)
        Me.GroupControl6.Controls.Add(Me.TrVidBar)
        Me.GroupControl6.Controls.Add(Me.Label16)
        Me.GroupControl6.Controls.Add(Me.Label15)
        Me.GroupControl6.Controls.Add(Me.txtTimetot)
        Me.GroupControl6.Controls.Add(Me.txtTimeVideo)
        Me.GroupControl6.Controls.Add(Me.SimpleButton13)
        Me.GroupControl6.Controls.Add(Me.CheckEdit1)
        Me.GroupControl6.Controls.Add(Me.sbStop)
        Me.GroupControl6.Controls.Add(Me.sbPause)
        Me.GroupControl6.Controls.Add(Me.sbPlay)
        Me.GroupControl6.Controls.Add(Me.sbExFullScreen)
        Me.GroupControl6.Controls.Add(Me.sbFullScreen)
        Me.GroupControl6.Controls.Add(Me.sbVideoBrows)
        Me.GroupControl6.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.GroupControl6.Location = New System.Drawing.Point(7, 572)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(686, 409)
        Me.GroupControl6.TabIndex = 87
        Me.GroupControl6.Text = "Video Control"
        '
        'SimpleButton16
        '
        Me.SimpleButton16.ImageOptions.Image = CType(resources.GetObject("SimpleButton16.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton16.Location = New System.Drawing.Point(441, 220)
        Me.SimpleButton16.Name = "SimpleButton16"
        Me.SimpleButton16.Size = New System.Drawing.Size(229, 23)
        Me.SimpleButton16.TabIndex = 105
        Me.SimpleButton16.Text = "Advanced Video Player"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 19)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "Video Preview:"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(440, 136)
        Me.CheckEdit2.Name = "CheckEdit2"
        '
        '
        '
        Me.CheckEdit2.Properties.Caption = "Mute Video Audio"
        Me.CheckEdit2.Size = New System.Drawing.Size(114, 20)
        Me.CheckEdit2.TabIndex = 103
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 19)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Video Name:"
        '
        'lblVidname
        '
        Me.lblVidname.AutoSize = True
        Me.lblVidname.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidname.Location = New System.Drawing.Point(48, 54)
        Me.lblVidname.Name = "lblVidname"
        Me.lblVidname.Size = New System.Drawing.Size(95, 19)
        Me.lblVidname.TabIndex = 101
        Me.lblVidname.Text = "Video Name"
        '
        'TrVidBar
        '
        Me.TrVidBar.BackColor = System.Drawing.Color.DimGray
        Me.TrVidBar.Location = New System.Drawing.Point(8, 357)
        Me.TrVidBar.Name = "TrVidBar"
        Me.TrVidBar.Size = New System.Drawing.Size(673, 45)
        Me.TrVidBar.TabIndex = 15
        Me.TrVidBar.TickFrequency = 5
        Me.TrVidBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(437, 282)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 19)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Total Video Time:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(437, 327)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 19)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "Video Time At:"
        '
        'txtTimetot
        '
        Me.txtTimetot.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimetot.Location = New System.Drawing.Point(580, 279)
        Me.txtTimetot.Name = "txtTimetot"
        Me.txtTimetot.ReadOnly = True
        Me.txtTimetot.Size = New System.Drawing.Size(100, 27)
        Me.txtTimetot.TabIndex = 97
        '
        'txtTimeVideo
        '
        Me.txtTimeVideo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeVideo.Location = New System.Drawing.Point(580, 324)
        Me.txtTimeVideo.Name = "txtTimeVideo"
        Me.txtTimeVideo.ReadOnly = True
        Me.txtTimeVideo.Size = New System.Drawing.Size(100, 27)
        Me.txtTimeVideo.TabIndex = 96
        '
        'SimpleButton13
        '
        Me.SimpleButton13.ImageOptions.Image = CType(resources.GetObject("SimpleButton13.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton13.Location = New System.Drawing.Point(549, 192)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(121, 23)
        Me.SimpleButton13.TabIndex = 95
        Me.SimpleButton13.Text = "Close Video Player"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(440, 113)
        Me.CheckEdit1.Name = "CheckEdit1"
        '
        '
        '
        Me.CheckEdit1.Properties.Caption = "Stop Music When Playing Video"
        Me.CheckEdit1.Size = New System.Drawing.Size(171, 20)
        Me.CheckEdit1.TabIndex = 94
        '
        'sbStop
        '
        Me.sbStop.ImageOptions.Image = CType(resources.GetObject("sbStop.ImageOptions.Image"), System.Drawing.Image)
        Me.sbStop.Location = New System.Drawing.Point(580, 89)
        Me.sbStop.Name = "sbStop"
        Me.sbStop.Size = New System.Drawing.Size(66, 23)
        Me.sbStop.TabIndex = 93
        Me.sbStop.Text = "Stop"
        '
        'sbPause
        '
        Me.sbPause.ImageOptions.Image = CType(resources.GetObject("sbPause.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPause.Location = New System.Drawing.Point(510, 89)
        Me.sbPause.Name = "sbPause"
        Me.sbPause.Size = New System.Drawing.Size(64, 23)
        Me.sbPause.TabIndex = 92
        Me.sbPause.Text = "Pause"
        '
        'sbPlay
        '
        Me.sbPlay.ImageOptions.Image = CType(resources.GetObject("sbPlay.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPlay.Location = New System.Drawing.Point(440, 89)
        Me.sbPlay.Name = "sbPlay"
        Me.sbPlay.Size = New System.Drawing.Size(64, 23)
        Me.sbPlay.TabIndex = 91
        Me.sbPlay.Text = "Play"
        '
        'sbExFullScreen
        '
        Me.sbExFullScreen.ImageOptions.Image = CType(resources.GetObject("sbExFullScreen.ImageOptions.Image"), System.Drawing.Image)
        Me.sbExFullScreen.Location = New System.Drawing.Point(441, 191)
        Me.sbExFullScreen.Name = "sbExFullScreen"
        Me.sbExFullScreen.Size = New System.Drawing.Size(102, 23)
        Me.sbExFullScreen.TabIndex = 90
        Me.sbExFullScreen.Text = "Close Fullscreen"
        '
        'sbFullScreen
        '
        Me.sbFullScreen.ImageOptions.Image = CType(resources.GetObject("sbFullScreen.ImageOptions.Image"), System.Drawing.Image)
        Me.sbFullScreen.Location = New System.Drawing.Point(542, 162)
        Me.sbFullScreen.Name = "sbFullScreen"
        Me.sbFullScreen.TabIndex = 89
        Me.sbFullScreen.Text = "Fullscreen"
        '
        'sbVideoBrows
        '
        Me.sbVideoBrows.ImageOptions.Image = CType(resources.GetObject("sbVideoBrows.ImageOptions.Image"), System.Drawing.Image)
        Me.sbVideoBrows.Location = New System.Drawing.Point(441, 163)
        Me.sbVideoBrows.Name = "sbVideoBrows"
        Me.sbVideoBrows.Size = New System.Drawing.Size(95, 23)
        Me.sbVideoBrows.TabIndex = 88
        Me.sbVideoBrows.Text = "Brows Video"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(7, 100)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(416, 251)
        Me.AxWindowsMediaPlayer1.TabIndex = 87
        Me.AxWindowsMediaPlayer1.UseWaitCursor = True
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.SimpleButton15)
        Me.GroupControl7.Controls.Add(Me.GroupControl2)
        Me.GroupControl7.Controls.Add(Me.GroupControl1)
        Me.GroupControl7.Controls.Add(Me.GroupControl4)
        Me.GroupControl7.Location = New System.Drawing.Point(699, 630)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(531, 351)
        Me.GroupControl7.TabIndex = 88
        Me.GroupControl7.Text = "Sound Control"
        '
        'SimpleButton15
        '
        Me.SimpleButton15.ImageOptions.Image = CType(resources.GetObject("SimpleButton15.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton15.Location = New System.Drawing.Point(441, 258)
        Me.SimpleButton15.Name = "SimpleButton15"
        Me.SimpleButton15.Size = New System.Drawing.Size(87, 46)
        Me.SimpleButton15.TabIndex = 83
        Me.SimpleButton15.Text = "Advance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sound Levels"
        '
        'Timer3
        '
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 1
        '
        'sbPauseMusic
        '
        Me.sbPauseMusic.ImageOptions.Image = CType(resources.GetObject("sbPauseMusic.ImageOptions.Image"), System.Drawing.Image)
        Me.sbPauseMusic.Location = New System.Drawing.Point(5, 73)
        Me.sbPauseMusic.Name = "sbPauseMusic"
        Me.sbPauseMusic.Size = New System.Drawing.Size(85, 37)
        Me.sbPauseMusic.TabIndex = 95
        Me.sbPauseMusic.Text = "Pause"
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(95, 27)
        Me.CheckEdit3.Name = "CheckEdit3"
        '
        '
        '
        Me.CheckEdit3.Properties.Caption = "Play Synced Song"
        Me.CheckEdit3.Size = New System.Drawing.Size(112, 20)
        Me.CheckEdit3.TabIndex = 96
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.Label21)
        Me.GroupControl8.Controls.Add(Me.lblSongName)
        Me.GroupControl8.Controls.Add(Me.TrcSong)
        Me.GroupControl8.Controls.Add(Me.Label20)
        Me.GroupControl8.Controls.Add(Me.Label19)
        Me.GroupControl8.Controls.Add(Me.lblSongPath)
        Me.GroupControl8.Controls.Add(Me.lblSongPathName)
        Me.GroupControl8.Location = New System.Drawing.Point(780, 6)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(947, 162)
        Me.GroupControl8.TabIndex = 97
        Me.GroupControl8.Text = "Song Info"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 27)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = "Song Name:"
        '
        'lblSongName
        '
        Me.lblSongName.AutoSize = True
        Me.lblSongName.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongName.Location = New System.Drawing.Point(121, 36)
        Me.lblSongName.Name = "lblSongName"
        Me.lblSongName.Size = New System.Drawing.Size(436, 20)
        Me.lblSongName.TabIndex = 100
        Me.lblSongName.Text = "Nightcore - POPSTARS (Switching Vocals) (League of Legends)"
        '
        'TrcSong
        '
        Me.TrcSong.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TrcSong.Location = New System.Drawing.Point(318, 104)
        Me.TrcSong.Name = "TrcSong"
        Me.TrcSong.Size = New System.Drawing.Size(617, 45)
        Me.TrcSong.TabIndex = 15
        Me.TrcSong.TickFrequency = 5
        Me.TrcSong.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(159, 27)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Song Total Time:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(183, 27)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Song Current Time:"
        '
        'AudioTrcTimer
        '
        Me.AudioTrcTimer.Enabled = True
        Me.AudioTrcTimer.Interval = 1
        '
        'CheckEdit4
        '
        Me.CheckEdit4.Location = New System.Drawing.Point(96, 47)
        Me.CheckEdit4.Name = "CheckEdit4"
        '
        '
        '
        Me.CheckEdit4.Properties.Caption = "Repeat Song"
        Me.CheckEdit4.Size = New System.Drawing.Size(87, 20)
        Me.CheckEdit4.TabIndex = 98
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.sbStopMusic)
        Me.GroupControl9.Controls.Add(Me.sbPlayMusic)
        Me.GroupControl9.Controls.Add(Me.CheckEdit4)
        Me.GroupControl9.Controls.Add(Me.sbPauseMusic)
        Me.GroupControl9.Controls.Add(Me.CheckEdit3)
        Me.GroupControl9.Controls.Add(Me.sbSyncMusic)
        Me.GroupControl9.Location = New System.Drawing.Point(566, 6)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(208, 162)
        Me.GroupControl9.TabIndex = 101
        Me.GroupControl9.Text = "Song Control"
        '
        'FaidTime
        '
        Me.FaidTime.Location = New System.Drawing.Point(5, 82)
        Me.FaidTime.Name = "FaidTime"
        Me.FaidTime.Size = New System.Drawing.Size(115, 21)
        Me.FaidTime.TabIndex = 102
        Me.FaidTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SimpleButton14
        '
        Me.SimpleButton14.ImageOptions.Image = CType(resources.GetObject("SimpleButton14.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton14.Location = New System.Drawing.Point(5, 30)
        Me.SimpleButton14.Name = "SimpleButton14"
        Me.SimpleButton14.Size = New System.Drawing.Size(115, 47)
        Me.SimpleButton14.TabIndex = 99
        Me.SimpleButton14.Text = "Fade In/Out"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        '
        'PgFaid
        '
        Me.PgFaid.Location = New System.Drawing.Point(131, 63)
        Me.PgFaid.Name = "PgFaid"
        Me.PgFaid.Size = New System.Drawing.Size(196, 23)
        Me.PgFaid.TabIndex = 102
        Me.PgFaid.Visible = False
        '
        'lblFaidProgress
        '
        Me.lblFaidProgress.AutoSize = True
        Me.lblFaidProgress.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaidProgress.Location = New System.Drawing.Point(132, 42)
        Me.lblFaidProgress.Name = "lblFaidProgress"
        Me.lblFaidProgress.Size = New System.Drawing.Size(155, 18)
        Me.lblFaidProgress.TabIndex = 103
        Me.lblFaidProgress.Text = "Fade In/Out Progress:"
        Me.lblFaidProgress.Visible = False
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Me.Label22)
        Me.GroupControl10.Controls.Add(Me.FaidTime)
        Me.GroupControl10.Controls.Add(Me.lblFaidProgress)
        Me.GroupControl10.Controls.Add(Me.PgFaid)
        Me.GroupControl10.Controls.Add(Me.SimpleButton14)
        Me.GroupControl10.Location = New System.Drawing.Point(1236, 813)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(349, 168)
        Me.GroupControl10.TabIndex = 104
        Me.GroupControl10.Text = "Fade In/Out"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 106)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(263, 60)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "When Selecting A time you want to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dubble that selected time. For example" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10sec" &
    " = 20sec"
        '
        'AxNameGet
        '
        Me.AxNameGet.Enabled = True
        Me.AxNameGet.Location = New System.Drawing.Point(247, 110)
        Me.AxNameGet.Name = "AxNameGet"
        Me.AxNameGet.OcxState = CType(resources.GetObject("AxNameGet.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxNameGet.Size = New System.Drawing.Size(75, 62)
        Me.AxNameGet.TabIndex = 100
        Me.AxNameGet.Visible = False
        '
        'AxPlayerAudio
        '
        Me.AxPlayerAudio.Enabled = True
        Me.AxPlayerAudio.Location = New System.Drawing.Point(166, 110)
        Me.AxPlayerAudio.Name = "AxPlayerAudio"
        Me.AxPlayerAudio.OcxState = CType(resources.GetObject("AxPlayerAudio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxPlayerAudio.Size = New System.Drawing.Size(75, 62)
        Me.AxPlayerAudio.TabIndex = 94
        Me.AxPlayerAudio.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'songtimecurlabe
        '
        Me.songtimecurlabe.AutoSize = True
        Me.songtimecurlabe.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songtimecurlabe.Location = New System.Drawing.Point(979, 101)
        Me.songtimecurlabe.Name = "songtimecurlabe"
        Me.songtimecurlabe.Size = New System.Drawing.Size(106, 27)
        Me.songtimecurlabe.TabIndex = 106
        Me.songtimecurlabe.Text = "00:00:00"
        '
        'songtimetotlabe
        '
        Me.songtimetotlabe.AutoSize = True
        Me.songtimetotlabe.Font = New System.Drawing.Font("Tempus Sans ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songtimetotlabe.Location = New System.Drawing.Point(979, 135)
        Me.songtimetotlabe.Name = "songtimetotlabe"
        Me.songtimetotlabe.Size = New System.Drawing.Size(106, 27)
        Me.songtimetotlabe.TabIndex = 107
        Me.songtimetotlabe.Text = "00:00:00"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1748, 1029)
        Me.Controls.Add(Me.songtimetotlabe)
        Me.Controls.Add(Me.songtimecurlabe)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupControl10)
        Me.Controls.Add(Me.GroupControl9)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.AxNameGet)
        Me.Controls.Add(Me.GroupControl8)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.AxPlayerAudio)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.GroupControl7)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.GroupControl6)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DtSongsDataGridView)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(SongIDLabel)
        Me.Controls.Add(Me.SongIDLabel1)
        Me.Controls.Add(SongNameLabel)
        Me.Controls.Add(Me.SongNameTextEdit)
        Me.Controls.Add(SongPathLabel)
        Me.Controls.Add(Me.SongPathButtonEdit)
        Me.Controls.Add(Me.DtSongsBindingNavigator)
        Me.IconOptions.Icon = CType(resources.GetObject("Form2.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1508, 1059)
        Me.Name = "Form2"
        Me.Text = "Player"
        CType(Me.DsSongList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtSongsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtSongsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DtSongsBindingNavigator.ResumeLayout(False)
        Me.DtSongsBindingNavigator.PerformLayout()
        CType(Me.SongNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SongPathButtonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtSongsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrVidBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrcSong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaidTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxNameGet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxPlayerAudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsSongList As dsSongList
    Friend WithEvents DtSongsBindingSource As BindingSource
    Friend WithEvents DtSongsBindingNavigator As BindingNavigator
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
    Friend WithEvents DtSongsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SongIDLabel1 As Label
    Friend WithEvents SongNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SongPathButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents DtSongsDataGridView As DataGridView
    Friend WithEvents lblSongPathName As Label
    Friend WithEvents lblSongPath As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblstatus As Label
    Friend WithEvents sbPlayMusic As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbSyncMusic As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbStopMusic As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LableVolStat As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label10 As Label
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents sbLoadPlaylist As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbPlaylist1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label12 As Label
    Friend WithEvents lbCurrentPlaylist As Label
    Friend WithEvents sbPlaylist5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbPlaylist4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbPlaylist3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbPlaylist2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSelectedPlaylist As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Compres As Timer
    Friend WithEvents lblCompStat As Label
    Friend WithEvents lblCompAD As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sbDAcomp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbAcComp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCompLevelStat As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents sbExFullScreen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbFullScreen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbVideoBrows As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbPause As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbPlay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer3 As Timer
    Friend WithEvents txtTimetot As TextBox
    Friend WithEvents txtTimeVideo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TrVidBar As TrackBar
    Friend WithEvents lblVidname As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label18 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents AxPlayerAudio As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents sbPauseMusic As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TrcSong As TrackBar
    Friend WithEvents AudioTrcTimer As Timer
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label21 As Label
    Friend WithEvents lblSongName As Label
    Friend WithEvents AxNameGet As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FaidTime As NumericUpDown
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PgFaid As ProgressBar
    Friend WithEvents lblFaidProgress As Label
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label22 As Label
    Friend WithEvents SimpleButton15 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton16 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents songtimecurlabe As Label
    Friend WithEvents songtimetotlabe As Label
End Class
