<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStripMain = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ProcessingToolStripMenuItem = New ToolStripMenuItem()
        TodayToolStripMenuItem = New ToolStripMenuItem()
        YesterdayToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem10 = New ToolStripSeparator()
        SpecificRangeToolStripMenuItem1 = New ToolStripMenuItem()
        DownloadXMLOnlyToolStripMenuItem = New ToolStripMenuItem()
        XMLToDatabaseToolStripMenuItem = New ToolStripMenuItem()
        CreateStatisticsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        XMLToCBCreateStatsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        ModelRunToolStripMenuItem = New ToolStripMenuItem()
        TestToolStripMenuItem = New ToolStripMenuItem()
        LiveToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        RebuildIndexesToolStripMenuItem1 = New ToolStripMenuItem()
        VenueMappingsToolStripMenuItem = New ToolStripMenuItem()
        TabControlMain = New TabControl()
        TPMessages = New TabPage()
        RTBMessages = New RichTextBox()
        TPJobs = New TabPage()
        DGV_Jobs = New DataGridView()
        DGV_ID = New DataGridViewTextBoxColumn()
        DGV_DATETIME = New DataGridViewTextBoxColumn()
        DGV_REQUEST = New DataGridViewTextBoxColumn()
        DGV_PARAMETERS = New DataGridViewTextBoxColumn()
        ContextMenuStripJobs = New ContextMenuStrip(components)
        DeleteJobsToolStripMenuItem = New ToolStripMenuItem()
        TruncateJobsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripSeparator()
        RefreshToolStripMenuItem = New ToolStripMenuItem()
        MenuStripMain.SuspendLayout()
        TabControlMain.SuspendLayout()
        TPMessages.SuspendLayout()
        TPJobs.SuspendLayout()
        CType(DGV_Jobs, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStripJobs.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStripMain
        ' 
        MenuStripMain.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStripMain.ImageScalingSize = New Size(24, 24)
        MenuStripMain.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ProcessingToolStripMenuItem, ToolsToolStripMenuItem})
        MenuStripMain.Location = New Point(0, 0)
        MenuStripMain.Name = "MenuStripMain"
        MenuStripMain.Size = New Size(2046, 57)
        MenuStripMain.TabIndex = 0
        MenuStripMain.Text = "Main Menu Strip"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem1, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(102, 53)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(248, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(251, 58)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' ProcessingToolStripMenuItem
        ' 
        ProcessingToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TodayToolStripMenuItem, YesterdayToolStripMenuItem1, ToolStripMenuItem10, SpecificRangeToolStripMenuItem1})
        ProcessingToolStripMenuItem.Name = "ProcessingToolStripMenuItem"
        ProcessingToolStripMenuItem.Size = New Size(219, 53)
        ProcessingToolStripMenuItem.Text = "&Processing"
        ' 
        ' TodayToolStripMenuItem
        ' 
        TodayToolStripMenuItem.Name = "TodayToolStripMenuItem"
        TodayToolStripMenuItem.Size = New Size(425, 58)
        TodayToolStripMenuItem.Text = "Today"
        ' 
        ' YesterdayToolStripMenuItem1
        ' 
        YesterdayToolStripMenuItem1.Name = "YesterdayToolStripMenuItem1"
        YesterdayToolStripMenuItem1.Size = New Size(425, 58)
        YesterdayToolStripMenuItem1.Text = "Yesterday"
        ' 
        ' ToolStripMenuItem10
        ' 
        ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        ToolStripMenuItem10.Size = New Size(422, 6)
        ' 
        ' SpecificRangeToolStripMenuItem1
        ' 
        SpecificRangeToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {DownloadXMLOnlyToolStripMenuItem, XMLToDatabaseToolStripMenuItem, CreateStatisticsToolStripMenuItem, ToolStripMenuItem2, XMLToCBCreateStatsToolStripMenuItem, ToolStripMenuItem3, ModelRunToolStripMenuItem})
        SpecificRangeToolStripMenuItem1.Name = "SpecificRangeToolStripMenuItem1"
        SpecificRangeToolStripMenuItem1.Size = New Size(425, 58)
        SpecificRangeToolStripMenuItem1.Text = "Specific Range"
        ' 
        ' DownloadXMLOnlyToolStripMenuItem
        ' 
        DownloadXMLOnlyToolStripMenuItem.Name = "DownloadXMLOnlyToolStripMenuItem"
        DownloadXMLOnlyToolStripMenuItem.Size = New Size(572, 58)
        DownloadXMLOnlyToolStripMenuItem.Text = "Download XML"
        ' 
        ' XMLToDatabaseToolStripMenuItem
        ' 
        XMLToDatabaseToolStripMenuItem.Name = "XMLToDatabaseToolStripMenuItem"
        XMLToDatabaseToolStripMenuItem.Size = New Size(572, 58)
        XMLToDatabaseToolStripMenuItem.Text = "XML To Database"
        ' 
        ' CreateStatisticsToolStripMenuItem
        ' 
        CreateStatisticsToolStripMenuItem.Name = "CreateStatisticsToolStripMenuItem"
        CreateStatisticsToolStripMenuItem.Size = New Size(572, 58)
        CreateStatisticsToolStripMenuItem.Text = "Create Statistics"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(569, 6)
        ' 
        ' XMLToCBCreateStatsToolStripMenuItem
        ' 
        XMLToCBCreateStatsToolStripMenuItem.Name = "XMLToCBCreateStatsToolStripMenuItem"
        XMLToCBCreateStatsToolStripMenuItem.Size = New Size(572, 58)
        XMLToCBCreateStatsToolStripMenuItem.Text = "XML to DB/Create Stats"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(569, 6)
        ' 
        ' ModelRunToolStripMenuItem
        ' 
        ModelRunToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TestToolStripMenuItem, LiveToolStripMenuItem})
        ModelRunToolStripMenuItem.Name = "ModelRunToolStripMenuItem"
        ModelRunToolStripMenuItem.Size = New Size(572, 58)
        ModelRunToolStripMenuItem.Text = "Model Run"
        ' 
        ' TestToolStripMenuItem
        ' 
        TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        TestToolStripMenuItem.Size = New Size(257, 58)
        TestToolStripMenuItem.Text = "Test"
        ' 
        ' LiveToolStripMenuItem
        ' 
        LiveToolStripMenuItem.Name = "LiveToolStripMenuItem"
        LiveToolStripMenuItem.Size = New Size(257, 58)
        LiveToolStripMenuItem.Text = "Live"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RebuildIndexesToolStripMenuItem1, VenueMappingsToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(129, 53)
        ToolsToolStripMenuItem.Text = "&Tools"
        ' 
        ' RebuildIndexesToolStripMenuItem1
        ' 
        RebuildIndexesToolStripMenuItem1.Name = "RebuildIndexesToolStripMenuItem1"
        RebuildIndexesToolStripMenuItem1.Size = New Size(464, 58)
        RebuildIndexesToolStripMenuItem1.Text = "Rebuild Indexes"
        ' 
        ' VenueMappingsToolStripMenuItem
        ' 
        VenueMappingsToolStripMenuItem.Name = "VenueMappingsToolStripMenuItem"
        VenueMappingsToolStripMenuItem.Size = New Size(464, 58)
        VenueMappingsToolStripMenuItem.Text = "Venue Mappings"
        ' 
        ' TabControlMain
        ' 
        TabControlMain.Controls.Add(TPMessages)
        TabControlMain.Controls.Add(TPJobs)
        TabControlMain.Dock = DockStyle.Fill
        TabControlMain.Location = New Point(0, 57)
        TabControlMain.Name = "TabControlMain"
        TabControlMain.SelectedIndex = 0
        TabControlMain.Size = New Size(2046, 770)
        TabControlMain.TabIndex = 1
        ' 
        ' TPMessages
        ' 
        TPMessages.Controls.Add(RTBMessages)
        TPMessages.Location = New Point(10, 66)
        TPMessages.Name = "TPMessages"
        TPMessages.Padding = New Padding(3)
        TPMessages.Size = New Size(2026, 694)
        TPMessages.TabIndex = 0
        TPMessages.Text = "Messages"
        TPMessages.UseVisualStyleBackColor = True
        ' 
        ' RTBMessages
        ' 
        RTBMessages.BorderStyle = BorderStyle.None
        RTBMessages.Dock = DockStyle.Fill
        RTBMessages.Location = New Point(3, 3)
        RTBMessages.Name = "RTBMessages"
        RTBMessages.Size = New Size(2020, 688)
        RTBMessages.TabIndex = 0
        RTBMessages.Text = ""
        ' 
        ' TPJobs
        ' 
        TPJobs.Controls.Add(DGV_Jobs)
        TPJobs.Location = New Point(10, 58)
        TPJobs.Name = "TPJobs"
        TPJobs.Padding = New Padding(3)
        TPJobs.Size = New Size(2026, 702)
        TPJobs.TabIndex = 1
        TPJobs.Text = "Jobs"
        TPJobs.UseVisualStyleBackColor = True
        ' 
        ' DGV_Jobs
        ' 
        DGV_Jobs.AllowUserToAddRows = False
        DGV_Jobs.AllowUserToDeleteRows = False
        DGV_Jobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Jobs.Columns.AddRange(New DataGridViewColumn() {DGV_ID, DGV_DATETIME, DGV_REQUEST, DGV_PARAMETERS})
        DGV_Jobs.ContextMenuStrip = ContextMenuStripJobs
        DGV_Jobs.Dock = DockStyle.Fill
        DGV_Jobs.EditMode = DataGridViewEditMode.EditProgrammatically
        DGV_Jobs.Location = New Point(3, 3)
        DGV_Jobs.Name = "DGV_Jobs"
        DGV_Jobs.ReadOnly = True
        DGV_Jobs.RowHeadersWidth = 62
        DGV_Jobs.RowTemplate.Height = 33
        DGV_Jobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_Jobs.Size = New Size(2020, 696)
        DGV_Jobs.TabIndex = 0
        ' 
        ' DGV_ID
        ' 
        DGV_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        DGV_ID.DefaultCellStyle = DataGridViewCellStyle1
        DGV_ID.HeaderText = "ID"
        DGV_ID.MinimumWidth = 8
        DGV_ID.Name = "DGV_ID"
        DGV_ID.ReadOnly = True
        DGV_ID.Width = 111
        ' 
        ' DGV_DATETIME
        ' 
        DGV_DATETIME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Format = "g"
        DataGridViewCellStyle2.NullValue = Nothing
        DGV_DATETIME.DefaultCellStyle = DataGridViewCellStyle2
        DGV_DATETIME.HeaderText = "DATE-TIME"
        DGV_DATETIME.MinimumWidth = 8
        DGV_DATETIME.Name = "DGV_DATETIME"
        DGV_DATETIME.ReadOnly = True
        DGV_DATETIME.Width = 255
        ' 
        ' DGV_REQUEST
        ' 
        DGV_REQUEST.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV_REQUEST.DefaultCellStyle = DataGridViewCellStyle3
        DGV_REQUEST.HeaderText = "REQUEST"
        DGV_REQUEST.MinimumWidth = 8
        DGV_REQUEST.Name = "DGV_REQUEST"
        DGV_REQUEST.ReadOnly = True
        DGV_REQUEST.Width = 228
        ' 
        ' DGV_PARAMETERS
        ' 
        DGV_PARAMETERS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGV_PARAMETERS.DefaultCellStyle = DataGridViewCellStyle4
        DGV_PARAMETERS.HeaderText = "PARAMETERS"
        DGV_PARAMETERS.MinimumWidth = 8
        DGV_PARAMETERS.Name = "DGV_PARAMETERS"
        DGV_PARAMETERS.ReadOnly = True
        ' 
        ' ContextMenuStripJobs
        ' 
        ContextMenuStripJobs.Font = New Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point)
        ContextMenuStripJobs.ImageScalingSize = New Size(24, 24)
        ContextMenuStripJobs.Items.AddRange(New ToolStripItem() {DeleteJobsToolStripMenuItem, TruncateJobsToolStripMenuItem, ToolStripMenuItem4, RefreshToolStripMenuItem})
        ContextMenuStripJobs.Name = "ContextMenuStripJobs"
        ContextMenuStripJobs.Size = New Size(239, 130)
        ' 
        ' DeleteJobsToolStripMenuItem
        ' 
        DeleteJobsToolStripMenuItem.Name = "DeleteJobsToolStripMenuItem"
        DeleteJobsToolStripMenuItem.Size = New Size(238, 40)
        DeleteJobsToolStripMenuItem.Text = "Delete Job(s)"
        ' 
        ' TruncateJobsToolStripMenuItem
        ' 
        TruncateJobsToolStripMenuItem.Name = "TruncateJobsToolStripMenuItem"
        TruncateJobsToolStripMenuItem.Size = New Size(238, 40)
        TruncateJobsToolStripMenuItem.Text = "Truncate Jobs"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(235, 6)
        ' 
        ' RefreshToolStripMenuItem
        ' 
        RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        RefreshToolStripMenuItem.Size = New Size(238, 40)
        RefreshToolStripMenuItem.Text = "Refresh"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(240F, 240F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = SystemColors.Window
        ClientSize = New Size(2046, 827)
        Controls.Add(TabControlMain)
        Controls.Add(MenuStripMain)
        DoubleBuffered = True
        Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MainMenuStrip = MenuStripMain
        Margin = New Padding(4, 3, 4, 3)
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cascade Server"
        WindowState = FormWindowState.Maximized
        MenuStripMain.ResumeLayout(False)
        MenuStripMain.PerformLayout()
        TabControlMain.ResumeLayout(False)
        TPMessages.ResumeLayout(False)
        TPJobs.ResumeLayout(False)
        CType(DGV_Jobs, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStripJobs.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents MenuStripMain As MenuStrip
    Private WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Private WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents LoadAllToolStripMenuItem As ToolStripMenuItem
    Private WithEvents LoadSpecificRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents RebuildIndexesToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents VenueMappingsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents TabControlMain As TabControl
    Private WithEvents TPMessages As TabPage
    Private WithEvents TPJobs As TabPage
    Private WithEvents RTBMessages As RichTextBox
    Friend WithEvents DGV_Jobs As DataGridView
    Friend WithEvents DGV_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_DATETIME As DataGridViewTextBoxColumn
    Friend WithEvents DGV_REQUEST As DataGridViewTextBoxColumn
    Friend WithEvents DGV_PARAMETERS As DataGridViewTextBoxColumn
    Private WithEvents ContextMenuStripJobs As ContextMenuStrip
    Friend WithEvents DeleteJobsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TruncateJobsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcessingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YesterdayToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripSeparator
    Friend WithEvents SpecificRangeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DownloadXMLOnlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XMLToDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateStatisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents XMLToCBCreateStatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ModelRunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiveToolStripMenuItem As ToolStripMenuItem
End Class
