Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmServer
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If MY_POPUP IsNot Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
                If Connection IsNot Nothing Then Connection.Dispose() : Connection = Nothing
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServer))
            Me.TC_MAIN = New System.Windows.Forms.TabControl()
            Me.TP_Messages = New System.Windows.Forms.TabPage()
            Me.DGV_MESSAGES = New System.Windows.Forms.DataGridView()
            Me.DGV_MESSAGES_DATETIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_MESSAGES_IMAGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_MESSAGES_THREAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_MESSAGES_MESSAGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CMS_MESSAGES = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CMS_MESSAGES_CLEARLIST = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.CMS_MESSAGES_REFERSH = New System.Windows.Forms.ToolStripMenuItem()
            Me.TP_Joblist = New System.Windows.Forms.TabPage()
            Me.DGV_JOBLIST = New System.Windows.Forms.DataGridView()
            Me.DGV_JOBLIST_JOBID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_JOBLIST_DATETIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_JOBLIST_REQUEST = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_JOBLIST_PARAMETERS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CMS_JOBLIST = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CMS_JOBLIST_DELETE = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMS_JOBLIST_CLEAR = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.CMS_JOBLIST_REFRESH = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMain = New System.Windows.Forms.ToolStrip()
            Me.TSB_PROCESS_JOBS = New System.Windows.Forms.ToolStripButton()
            Me.TSDDB_SCHEDULE = New System.Windows.Forms.ToolStripDropDownButton()
            Me.TSMI_ScheduleLoadToday = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_ScheduleLoadYesterday = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_LoadYesterdaysResultsForce = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_ScheduleSeperator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSMI_ScheduleLoadAll = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_ScheduleLoadMissingDays = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_ScheduleLoadSpecificRange = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_ScheduleSeperator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSMI_ScheduleDownloadOnly = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSDDB_MODELS = New System.Windows.Forms.ToolStripDropDownButton()
            Me.TSMI_ModelRunAllRaces = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_ModelRunSpecificRange = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSDDB_TOOLS = New System.Windows.Forms.ToolStripDropDownButton()
            Me.TSMI_ToolsRebuildIndexes = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_ToolsMappings = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_ToolsEraseAllData = New System.Windows.Forms.ToolStripMenuItem()
            Me.StatusStripMain = New System.Windows.Forms.StatusStrip()
            Me.TSSLMain = New System.Windows.Forms.ToolStripStatusLabel()
            Me.TSPBMain = New System.Windows.Forms.ToolStripProgressBar()
            Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
            Me.TC_MAIN.SuspendLayout()
            Me.TP_Messages.SuspendLayout()
            CType(Me.DGV_MESSAGES, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMS_MESSAGES.SuspendLayout()
            Me.TP_Joblist.SuspendLayout()
            CType(Me.DGV_JOBLIST, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMS_JOBLIST.SuspendLayout()
            Me.TSMain.SuspendLayout()
            Me.StatusStripMain.SuspendLayout()
            CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TC_MAIN
            '
            Me.TC_MAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TC_MAIN.Controls.Add(Me.TP_Messages)
            Me.TC_MAIN.Controls.Add(Me.TP_Joblist)
            Me.TC_MAIN.Location = New System.Drawing.Point(0, 35)
            Me.TC_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_MAIN.Name = "TC_MAIN"
            Me.TC_MAIN.Padding = New System.Drawing.Point(0, 0)
            Me.TC_MAIN.SelectedIndex = 0
            Me.TC_MAIN.Size = New System.Drawing.Size(1098, 717)
            Me.TC_MAIN.TabIndex = 4
            '
            'TP_Messages
            '
            Me.TP_Messages.Controls.Add(Me.DGV_MESSAGES)
            Me.TP_Messages.Location = New System.Drawing.Point(4, 38)
            Me.TP_Messages.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_Messages.Name = "TP_Messages"
            Me.TP_Messages.Size = New System.Drawing.Size(1090, 675)
            Me.TP_Messages.TabIndex = 0
            Me.TP_Messages.Text = "Messages"
            Me.TP_Messages.UseVisualStyleBackColor = True
            '
            'DGV_MESSAGES
            '
            Me.DGV_MESSAGES.AllowUserToAddRows = False
            Me.DGV_MESSAGES.AllowUserToDeleteRows = False
            Me.DGV_MESSAGES.BackgroundColor = System.Drawing.Color.Black
            Me.DGV_MESSAGES.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV_MESSAGES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MESSAGES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_MESSAGES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_MESSAGES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_MESSAGES_DATETIME, Me.DGV_MESSAGES_IMAGE, Me.DGV_MESSAGES_THREAD, Me.DGV_MESSAGES_MESSAGE})
            Me.DGV_MESSAGES.ContextMenuStrip = Me.CMS_MESSAGES
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_MESSAGES.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_MESSAGES.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_MESSAGES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_MESSAGES.GridColor = System.Drawing.Color.Black
            Me.DGV_MESSAGES.Location = New System.Drawing.Point(0, 0)
            Me.DGV_MESSAGES.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_MESSAGES.Name = "DGV_MESSAGES"
            Me.DGV_MESSAGES.ReadOnly = True
            Me.DGV_MESSAGES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MESSAGES.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_MESSAGES.RowHeadersVisible = False
            Me.DGV_MESSAGES.RowHeadersWidth = 62
            DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.DGV_MESSAGES.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_MESSAGES.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
            Me.DGV_MESSAGES.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MESSAGES.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
            Me.DGV_MESSAGES.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
            Me.DGV_MESSAGES.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
            Me.DGV_MESSAGES.RowTemplate.Height = 32
            Me.DGV_MESSAGES.Size = New System.Drawing.Size(1090, 675)
            Me.DGV_MESSAGES.TabIndex = 2
            '
            'DGV_MESSAGES_DATETIME
            '
            Me.DGV_MESSAGES_DATETIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MESSAGES_DATETIME.DefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_MESSAGES_DATETIME.HeaderText = "DATE TIME"
            Me.DGV_MESSAGES_DATETIME.MinimumWidth = 8
            Me.DGV_MESSAGES_DATETIME.Name = "DGV_MESSAGES_DATETIME"
            Me.DGV_MESSAGES_DATETIME.ReadOnly = True
            Me.DGV_MESSAGES_DATETIME.Width = 156
            '
            'DGV_MESSAGES_IMAGE
            '
            Me.DGV_MESSAGES_IMAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MESSAGES_IMAGE.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_MESSAGES_IMAGE.HeaderText = "STATUS"
            Me.DGV_MESSAGES_IMAGE.MinimumWidth = 30
            Me.DGV_MESSAGES_IMAGE.Name = "DGV_MESSAGES_IMAGE"
            Me.DGV_MESSAGES_IMAGE.ReadOnly = True
            Me.DGV_MESSAGES_IMAGE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MESSAGES_IMAGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DGV_MESSAGES_IMAGE.ToolTipText = "Status"
            Me.DGV_MESSAGES_IMAGE.Width = 90
            '
            'DGV_MESSAGES_THREAD
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MESSAGES_THREAD.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_MESSAGES_THREAD.HeaderText = "THREAD"
            Me.DGV_MESSAGES_THREAD.MinimumWidth = 8
            Me.DGV_MESSAGES_THREAD.Name = "DGV_MESSAGES_THREAD"
            Me.DGV_MESSAGES_THREAD.ReadOnly = True
            Me.DGV_MESSAGES_THREAD.Width = 45
            '
            'DGV_MESSAGES_MESSAGE
            '
            Me.DGV_MESSAGES_MESSAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MESSAGES_MESSAGE.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_MESSAGES_MESSAGE.HeaderText = "MESSAGE"
            Me.DGV_MESSAGES_MESSAGE.MinimumWidth = 8
            Me.DGV_MESSAGES_MESSAGE.Name = "DGV_MESSAGES_MESSAGE"
            Me.DGV_MESSAGES_MESSAGE.ReadOnly = True
            Me.DGV_MESSAGES_MESSAGE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MESSAGES_MESSAGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'CMS_MESSAGES
            '
            Me.CMS_MESSAGES.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_MESSAGES.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.CMS_MESSAGES.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_MESSAGES_CLEARLIST, Me.ToolStripMenuItem1, Me.CMS_MESSAGES_REFERSH})
            Me.CMS_MESSAGES.Name = "CMSLV"
            Me.CMS_MESSAGES.ShowImageMargin = False
            Me.CMS_MESSAGES.Size = New System.Drawing.Size(123, 66)
            '
            'CMS_MESSAGES_CLEARLIST
            '
            Me.CMS_MESSAGES_CLEARLIST.Name = "CMS_MESSAGES_CLEARLIST"
            Me.CMS_MESSAGES_CLEARLIST.Size = New System.Drawing.Size(122, 28)
            Me.CMS_MESSAGES_CLEARLIST.Text = "Clear List"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(119, 6)
            '
            'CMS_MESSAGES_REFERSH
            '
            Me.CMS_MESSAGES_REFERSH.Name = "CMS_MESSAGES_REFERSH"
            Me.CMS_MESSAGES_REFERSH.Size = New System.Drawing.Size(122, 28)
            Me.CMS_MESSAGES_REFERSH.Text = "Refresh"
            '
            'TP_Joblist
            '
            Me.TP_Joblist.Controls.Add(Me.DGV_JOBLIST)
            Me.TP_Joblist.Location = New System.Drawing.Point(4, 38)
            Me.TP_Joblist.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_Joblist.Name = "TP_Joblist"
            Me.TP_Joblist.Size = New System.Drawing.Size(1090, 675)
            Me.TP_Joblist.TabIndex = 1
            Me.TP_Joblist.Text = "Job List"
            Me.TP_Joblist.UseVisualStyleBackColor = True
            '
            'DGV_JOBLIST
            '
            Me.DGV_JOBLIST.AllowUserToAddRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
            Me.DGV_JOBLIST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_JOBLIST.BackgroundColor = System.Drawing.Color.Black
            Me.DGV_JOBLIST.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV_JOBLIST.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Me.DGV_JOBLIST.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_JOBLIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_JOBLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_JOBLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_JOBLIST_JOBID, Me.DGV_JOBLIST_DATETIME, Me.DGV_JOBLIST_REQUEST, Me.DGV_JOBLIST_PARAMETERS})
            Me.DGV_JOBLIST.ContextMenuStrip = Me.CMS_JOBLIST
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_JOBLIST.DefaultCellStyle = DataGridViewCellStyle15
            Me.DGV_JOBLIST.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_JOBLIST.GridColor = System.Drawing.Color.Black
            Me.DGV_JOBLIST.Location = New System.Drawing.Point(0, 0)
            Me.DGV_JOBLIST.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_JOBLIST.Name = "DGV_JOBLIST"
            Me.DGV_JOBLIST.ReadOnly = True
            Me.DGV_JOBLIST.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_JOBLIST.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
            Me.DGV_JOBLIST.RowHeadersWidth = 62
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle17.BackColor = System.Drawing.Color.Black
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black
            Me.DGV_JOBLIST.RowsDefaultCellStyle = DataGridViewCellStyle17
            Me.DGV_JOBLIST.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DGV_JOBLIST.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
            Me.DGV_JOBLIST.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_JOBLIST.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
            Me.DGV_JOBLIST.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
            Me.DGV_JOBLIST.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
            Me.DGV_JOBLIST.Size = New System.Drawing.Size(1090, 675)
            Me.DGV_JOBLIST.TabIndex = 9
            '
            'DGV_JOBLIST_JOBID
            '
            Me.DGV_JOBLIST_JOBID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_JOBLIST_JOBID.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_JOBLIST_JOBID.HeaderText = "JOB ID"
            Me.DGV_JOBLIST_JOBID.MinimumWidth = 8
            Me.DGV_JOBLIST_JOBID.Name = "DGV_JOBLIST_JOBID"
            Me.DGV_JOBLIST_JOBID.ReadOnly = True
            Me.DGV_JOBLIST_JOBID.Width = 112
            '
            'DGV_JOBLIST_DATETIME
            '
            Me.DGV_JOBLIST_DATETIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.Format = "G"
            DataGridViewCellStyle12.NullValue = Nothing
            Me.DGV_JOBLIST_DATETIME.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_JOBLIST_DATETIME.HeaderText = "DATE TIME"
            Me.DGV_JOBLIST_DATETIME.MinimumWidth = 8
            Me.DGV_JOBLIST_DATETIME.Name = "DGV_JOBLIST_DATETIME"
            Me.DGV_JOBLIST_DATETIME.ReadOnly = True
            Me.DGV_JOBLIST_DATETIME.Width = 156
            '
            'DGV_JOBLIST_REQUEST
            '
            Me.DGV_JOBLIST_REQUEST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_JOBLIST_REQUEST.DefaultCellStyle = DataGridViewCellStyle13
            Me.DGV_JOBLIST_REQUEST.HeaderText = "REQUEST"
            Me.DGV_JOBLIST_REQUEST.MinimumWidth = 8
            Me.DGV_JOBLIST_REQUEST.Name = "DGV_JOBLIST_REQUEST"
            Me.DGV_JOBLIST_REQUEST.ReadOnly = True
            Me.DGV_JOBLIST_REQUEST.Width = 140
            '
            'DGV_JOBLIST_PARAMETERS
            '
            Me.DGV_JOBLIST_PARAMETERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_JOBLIST_PARAMETERS.DefaultCellStyle = DataGridViewCellStyle14
            Me.DGV_JOBLIST_PARAMETERS.HeaderText = "PARAMETERS"
            Me.DGV_JOBLIST_PARAMETERS.MinimumWidth = 8
            Me.DGV_JOBLIST_PARAMETERS.Name = "DGV_JOBLIST_PARAMETERS"
            Me.DGV_JOBLIST_PARAMETERS.ReadOnly = True
            '
            'CMS_JOBLIST
            '
            Me.CMS_JOBLIST.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_JOBLIST.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.CMS_JOBLIST.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_JOBLIST_DELETE, Me.CMS_JOBLIST_CLEAR, Me.ToolStripSeparator1, Me.CMS_JOBLIST_REFRESH})
            Me.CMS_JOBLIST.Name = "CMSGridView"
            Me.CMS_JOBLIST.Size = New System.Drawing.Size(241, 151)
            '
            'CMS_JOBLIST_DELETE
            '
            Me.CMS_JOBLIST_DELETE.Name = "CMS_JOBLIST_DELETE"
            Me.CMS_JOBLIST_DELETE.Size = New System.Drawing.Size(240, 36)
            Me.CMS_JOBLIST_DELETE.Text = "Delete Job(s)"
            '
            'CMS_JOBLIST_CLEAR
            '
            Me.CMS_JOBLIST_CLEAR.Name = "CMS_JOBLIST_CLEAR"
            Me.CMS_JOBLIST_CLEAR.Size = New System.Drawing.Size(240, 36)
            Me.CMS_JOBLIST_CLEAR.Text = "Clear Queue"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
            '
            'CMS_JOBLIST_REFRESH
            '
            Me.CMS_JOBLIST_REFRESH.Name = "CMS_JOBLIST_REFRESH"
            Me.CMS_JOBLIST_REFRESH.Size = New System.Drawing.Size(240, 36)
            Me.CMS_JOBLIST_REFRESH.Text = "Refresh"
            '
            'TSMain
            '
            Me.TSMain.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TSMain.GripMargin = New System.Windows.Forms.Padding(0)
            Me.TSMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.TSMain.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.TSMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_PROCESS_JOBS, Me.TSDDB_SCHEDULE, Me.TSDDB_MODELS, Me.TSDDB_TOOLS})
            Me.TSMain.Location = New System.Drawing.Point(0, 0)
            Me.TSMain.Name = "TSMain"
            Me.TSMain.Padding = New System.Windows.Forms.Padding(0)
            Me.TSMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.TSMain.Size = New System.Drawing.Size(1098, 38)
            Me.TSMain.TabIndex = 1
            Me.TSMain.TabStop = True
            '
            'TSB_PROCESS_JOBS
            '
            Me.TSB_PROCESS_JOBS.Image = CType(resources.GetObject("TSB_PROCESS_JOBS.Image"), System.Drawing.Image)
            Me.TSB_PROCESS_JOBS.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSB_PROCESS_JOBS.Name = "TSB_PROCESS_JOBS"
            Me.TSB_PROCESS_JOBS.Size = New System.Drawing.Size(162, 33)
            Me.TSB_PROCESS_JOBS.Text = "Process Jobs"
            '
            'TSDDB_SCHEDULE
            '
            Me.TSDDB_SCHEDULE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_ScheduleLoadToday, Me.TSMI_ScheduleLoadYesterday, Me.TSMI_LoadYesterdaysResultsForce, Me.TSMI_ScheduleSeperator1, Me.TSMI_ScheduleLoadAll, Me.TSMI_ScheduleLoadMissingDays, Me.TSMI_ScheduleLoadSpecificRange, Me.TSMI_ScheduleSeperator2, Me.TSMI_ScheduleDownloadOnly})
            Me.TSDDB_SCHEDULE.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSDDB_SCHEDULE.Name = "TSDDB_SCHEDULE"
            Me.TSDDB_SCHEDULE.Size = New System.Drawing.Size(121, 33)
            Me.TSDDB_SCHEDULE.Text = "Schedule"
            '
            'TSMI_ScheduleLoadToday
            '
            Me.TSMI_ScheduleLoadToday.Name = "TSMI_ScheduleLoadToday"
            Me.TSMI_ScheduleLoadToday.Size = New System.Drawing.Size(421, 38)
            Me.TSMI_ScheduleLoadToday.Text = "Load Today"
            '
            'TSMI_ScheduleLoadYesterday
            '
            Me.TSMI_ScheduleLoadYesterday.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_ScheduleLoadYesterday.Name = "TSMI_ScheduleLoadYesterday"
            Me.TSMI_ScheduleLoadYesterday.Size = New System.Drawing.Size(421, 38)
            Me.TSMI_ScheduleLoadYesterday.Text = "Load Yesterdays Results"
            '
            'TSMI_LoadYesterdaysResultsForce
            '
            Me.TSMI_LoadYesterdaysResultsForce.Name = "TSMI_LoadYesterdaysResultsForce"
            Me.TSMI_LoadYesterdaysResultsForce.Size = New System.Drawing.Size(421, 38)
            Me.TSMI_LoadYesterdaysResultsForce.Text = "Load Yesterdays Results (Force)"
            '
            'TSMI_ScheduleSeperator1
            '
            Me.TSMI_ScheduleSeperator1.Name = "TSMI_ScheduleSeperator1"
            Me.TSMI_ScheduleSeperator1.Size = New System.Drawing.Size(418, 6)
            '
            'TSMI_ScheduleLoadAll
            '
            Me.TSMI_ScheduleLoadAll.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_ScheduleLoadAll.Name = "TSMI_ScheduleLoadAll"
            Me.TSMI_ScheduleLoadAll.Size = New System.Drawing.Size(421, 38)
            Me.TSMI_ScheduleLoadAll.Text = "Load All"
            '
            'TSMI_ScheduleLoadMissingDays
            '
            Me.TSMI_ScheduleLoadMissingDays.Name = "TSMI_ScheduleLoadMissingDays"
            Me.TSMI_ScheduleLoadMissingDays.Size = New System.Drawing.Size(421, 38)
            Me.TSMI_ScheduleLoadMissingDays.Text = "Load Missing Days"
            '
            'TSMI_ScheduleLoadSpecificRange
            '
            Me.TSMI_ScheduleLoadSpecificRange.Name = "TSMI_ScheduleLoadSpecificRange"
            Me.TSMI_ScheduleLoadSpecificRange.Size = New System.Drawing.Size(421, 38)
            Me.TSMI_ScheduleLoadSpecificRange.Text = "Load Specific Range"
            '
            'TSMI_ScheduleSeperator2
            '
            Me.TSMI_ScheduleSeperator2.Name = "TSMI_ScheduleSeperator2"
            Me.TSMI_ScheduleSeperator2.Size = New System.Drawing.Size(418, 6)
            '
            'TSMI_ScheduleDownloadOnly
            '
            Me.TSMI_ScheduleDownloadOnly.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_ScheduleDownloadOnly.Name = "TSMI_ScheduleDownloadOnly"
            Me.TSMI_ScheduleDownloadOnly.Size = New System.Drawing.Size(421, 38)
            Me.TSMI_ScheduleDownloadOnly.Text = "Download Only"
            '
            'TSDDB_MODELS
            '
            Me.TSDDB_MODELS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_ModelRunAllRaces, Me.TSMI_ModelRunSpecificRange})
            Me.TSDDB_MODELS.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSDDB_MODELS.Name = "TSDDB_MODELS"
            Me.TSDDB_MODELS.Size = New System.Drawing.Size(140, 33)
            Me.TSDDB_MODELS.Text = "Model Run"
            '
            'TSMI_ModelRunAllRaces
            '
            Me.TSMI_ModelRunAllRaces.Name = "TSMI_ModelRunAllRaces"
            Me.TSMI_ModelRunAllRaces.Size = New System.Drawing.Size(257, 38)
            Me.TSMI_ModelRunAllRaces.Text = "All Races"
            '
            'TSMI_ModelRunSpecificRange
            '
            Me.TSMI_ModelRunSpecificRange.Name = "TSMI_ModelRunSpecificRange"
            Me.TSMI_ModelRunSpecificRange.Size = New System.Drawing.Size(257, 38)
            Me.TSMI_ModelRunSpecificRange.Text = "Specific Range"
            '
            'TSDDB_TOOLS
            '
            Me.TSDDB_TOOLS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_ToolsRebuildIndexes, Me.TSMI_ToolsMappings, Me.TSMI_ToolsEraseAllData})
            Me.TSDDB_TOOLS.ImageTransparentColor = System.Drawing.Color.White
            Me.TSDDB_TOOLS.Name = "TSDDB_TOOLS"
            Me.TSDDB_TOOLS.Size = New System.Drawing.Size(82, 33)
            Me.TSDDB_TOOLS.Text = "Tools"
            '
            'TSMI_ToolsRebuildIndexes
            '
            Me.TSMI_ToolsRebuildIndexes.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_ToolsRebuildIndexes.Name = "TSMI_ToolsRebuildIndexes"
            Me.TSMI_ToolsRebuildIndexes.Size = New System.Drawing.Size(271, 38)
            Me.TSMI_ToolsRebuildIndexes.Text = "Rebuild Indexes"
            '
            'TSMI_ToolsMappings
            '
            Me.TSMI_ToolsMappings.Name = "TSMI_ToolsMappings"
            Me.TSMI_ToolsMappings.Size = New System.Drawing.Size(271, 38)
            Me.TSMI_ToolsMappings.Text = "Mappings"
            '
            'TSMI_ToolsEraseAllData
            '
            Me.TSMI_ToolsEraseAllData.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_ToolsEraseAllData.Name = "TSMI_ToolsEraseAllData"
            Me.TSMI_ToolsEraseAllData.Size = New System.Drawing.Size(271, 38)
            Me.TSMI_ToolsEraseAllData.Text = "Erase All Data"
            '
            'StatusStripMain
            '
            Me.StatusStripMain.AllowMerge = False
            Me.StatusStripMain.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StatusStripMain.GripMargin = New System.Windows.Forms.Padding(0)
            Me.StatusStripMain.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.StatusStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLMain, Me.TSPBMain})
            Me.StatusStripMain.Location = New System.Drawing.Point(0, 752)
            Me.StatusStripMain.Name = "StatusStripMain"
            Me.StatusStripMain.Padding = New System.Windows.Forms.Padding(1, 0, 17, 0)
            Me.StatusStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.StatusStripMain.Size = New System.Drawing.Size(1098, 30)
            Me.StatusStripMain.SizingGrip = False
            Me.StatusStripMain.TabIndex = 6
            '
            'TSSLMain
            '
            Me.TSSLMain.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
            Me.TSSLMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.TSSLMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.TSSLMain.Margin = New System.Windows.Forms.Padding(0)
            Me.TSSLMain.Name = "TSSLMain"
            Me.TSSLMain.Size = New System.Drawing.Size(940, 30)
            Me.TSSLMain.Spring = True
            Me.TSSLMain.Text = "Ready"
            Me.TSSLMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TSPBMain
            '
            Me.TSPBMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
            Me.TSPBMain.Margin = New System.Windows.Forms.Padding(0)
            Me.TSPBMain.Name = "TSPBMain"
            Me.TSPBMain.Size = New System.Drawing.Size(140, 30)
            Me.TSPBMain.Style = System.Windows.Forms.ProgressBarStyle.Continuous
            '
            'FileSystemWatcher1
            '
            Me.FileSystemWatcher1.EnableRaisingEvents = True
            Me.FileSystemWatcher1.SynchronizingObject = Me
            '
            'FrmServer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 29.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(1098, 782)
            Me.Controls.Add(Me.StatusStripMain)
            Me.Controls.Add(Me.TSMain)
            Me.Controls.Add(Me.TC_MAIN)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "FrmServer"
            Me.Opacity = 0.9R
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "SERVER UI"
            Me.TC_MAIN.ResumeLayout(False)
            Me.TP_Messages.ResumeLayout(False)
            CType(Me.DGV_MESSAGES, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMS_MESSAGES.ResumeLayout(False)
            Me.TP_Joblist.ResumeLayout(False)
            CType(Me.DGV_JOBLIST, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMS_JOBLIST.ResumeLayout(False)
            Me.TSMain.ResumeLayout(False)
            Me.TSMain.PerformLayout()
            Me.StatusStripMain.ResumeLayout(False)
            Me.StatusStripMain.PerformLayout()
            CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents TC_MAIN As System.Windows.Forms.TabControl
        Private WithEvents TP_Messages As System.Windows.Forms.TabPage
        Private WithEvents TP_Joblist As System.Windows.Forms.TabPage
        Private WithEvents TSMain As System.Windows.Forms.ToolStrip
        Private WithEvents TSDDB_SCHEDULE As System.Windows.Forms.ToolStripDropDownButton
        Friend WithEvents TSMI_ScheduleLoadAll As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSMI_ScheduleLoadMissingDays As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSMI_ScheduleLoadSpecificRange As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSMI_ScheduleSeperator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents TSMI_ScheduleDownloadOnly As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSMI_ScheduleSeperator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents TSMI_ScheduleLoadToday As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSMI_ScheduleLoadYesterday As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TSDDB_MODELS As System.Windows.Forms.ToolStripDropDownButton
        Friend WithEvents TSMI_ModelRunAllRaces As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSMI_ModelRunSpecificRange As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TSDDB_TOOLS As System.Windows.Forms.ToolStripDropDownButton
        Friend WithEvents TSMI_ToolsRebuildIndexes As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSMI_ToolsMappings As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSMI_ToolsEraseAllData As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents DGV_MESSAGES As System.Windows.Forms.DataGridView
        Private WithEvents CMS_MESSAGES As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CMS_MESSAGES_CLEARLIST As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents CMS_MESSAGES_REFERSH As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TSB_PROCESS_JOBS As System.Windows.Forms.ToolStripButton
        Private WithEvents DGV_JOBLIST As System.Windows.Forms.DataGridView
        Private WithEvents CMS_JOBLIST As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents CMS_JOBLIST_DELETE As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CMS_JOBLIST_CLEAR As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents CMS_JOBLIST_REFRESH As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents StatusStripMain As System.Windows.Forms.StatusStrip
        Friend WithEvents TSSLMain As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents TSPBMain As System.Windows.Forms.ToolStripProgressBar
        Friend WithEvents TSMI_LoadYesterdaysResultsForce As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
        Friend WithEvents DGV_MESSAGES_DATETIME As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MESSAGES_IMAGE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MESSAGES_THREAD As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MESSAGES_MESSAGE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_JOBLIST_JOBID As DataGridViewTextBoxColumn
        Friend WithEvents DGV_JOBLIST_DATETIME As DataGridViewTextBoxColumn
        Friend WithEvents DGV_JOBLIST_REQUEST As DataGridViewTextBoxColumn
        Friend WithEvents DGV_JOBLIST_PARAMETERS As DataGridViewTextBoxColumn
    End Class
End Namespace
