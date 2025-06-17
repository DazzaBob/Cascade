<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            Me.OpenFileDial.Dispose()
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
        components = New ComponentModel.Container()
        Dim TreeNode15 As TreeNode = New TreeNode("RACE_INFO_BARRIER")
        Dim TreeNode16 As TreeNode = New TreeNode("ENTRY_INFO_DISTANCE_SCORE")
        Dim TreeNode17 As TreeNode = New TreeNode("ENTRY_INFO_DISTANCE_THEO_SCORE")
        Dim TreeNode18 As TreeNode = New TreeNode("ENTRY_INFO_DISTANCE_THEO", New TreeNode() {TreeNode17})
        Dim TreeNode19 As TreeNode = New TreeNode("ENTRY_INFO_DISTANCE", New TreeNode() {TreeNode16, TreeNode18})
        Dim TreeNode20 As TreeNode = New TreeNode("ENTRY_INFO_GROUP_SCORE")
        Dim TreeNode21 As TreeNode = New TreeNode("ENTRY_INFO_GROUP_THEO_SCORE")
        Dim TreeNode22 As TreeNode = New TreeNode("ENTRY_INFO_GROUP_THEO", New TreeNode() {TreeNode21})
        Dim TreeNode23 As TreeNode = New TreeNode("ENTRY_INFO_GROUP", New TreeNode() {TreeNode20, TreeNode22})
        Dim TreeNode24 As TreeNode = New TreeNode("ENTRY_INFO_OVERALL_SCORE")
        Dim TreeNode25 As TreeNode = New TreeNode("ENTRY_INFO_OVERALL_THEO_SCORE")
        Dim TreeNode26 As TreeNode = New TreeNode("ENTRY_INFO_OVERALL_THEO", New TreeNode() {TreeNode25})
        Dim TreeNode27 As TreeNode = New TreeNode("ENTRY_INFO_OVERALL", New TreeNode() {TreeNode24, TreeNode26})
        Dim TreeNode28 As TreeNode = New TreeNode("ENTRY_INFO", New TreeNode() {TreeNode19, TreeNode23, TreeNode27})
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmMain))
        StatusStripActions = New StatusStrip()
        TSSLBLStatus = New ToolStripStatusLabel()
        SplitContainerMain = New SplitContainer()
        TabControlMain = New TabControl()
        CMS_TabControlMain = New ContextMenuStrip(components)
        CMSTabControl_SaveThis = New ToolStripMenuItem()
        CMSTabControlDivider = New ToolStripSeparator()
        CMSTabControl_Close = New ToolStripMenuItem()
        CMSTabControlCloseAll = New ToolStripMenuItem()
        CMSTabControl_CloseAllButThis = New ToolStripMenuItem()
        TC_SOLUTION = New TabControl()
        TP_SOLUTIONEXPLORER = New TabPage()
        TableLayoutPanelSolution = New TableLayoutPanel()
        PanelMain = New Panel()
        TV_MODELS = New TreeView()
        CMS_TV_MODELS = New ContextMenuStrip(components)
        CMS_TV_MODELS_CREATEFOLDER = New ToolStripMenuItem()
        CMS_TV_MODELS_DELETEFOLDER = New ToolStripMenuItem()
        CMS_TV_MODELS_RENAMEFOLDER = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        CMS_TV_MODELS_CREATEMODEL = New ToolStripMenuItem()
        CMS_TV_MODELS_DELETEMODEL = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripSeparator()
        CMS_TV_MODELS_CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        CMS_TV_MODELS_REFRESH = New ToolStripMenuItem()
        TP_OBJECTS = New TabPage()
        TVObjects = New TreeView()
        ToolStripMenu = New ToolStrip()
        TSBNavigateBack = New ToolStripButton()
        TSBNavigateForward = New ToolStripButton()
        TSB_TSS1 = New ToolStripSeparator()
        TSB_OpenFile = New ToolStripButton()
        TSB_TSS2 = New ToolStripSeparator()
        TSB_TSS3 = New ToolStripSeparator()
        TSBCommentOut = New ToolStripButton()
        TSBUncomment = New ToolStripButton()
        TSB_TSS4 = New ToolStripSeparator()
        TSB_Undo = New ToolStripButton()
        TSB_Redo = New ToolStripButton()
        TSB_TSS5 = New ToolStripSeparator()
        TSDDBSTART = New ToolStripDropDownButton()
        STARTToolStripMenuItem = New ToolStripMenuItem()
        STARTITERATIONToolStripMenuItem = New ToolStripMenuItem()
        TSB_STOP = New ToolStripButton()
        TSB_TSS6 = New ToolStripSeparator()
        TSB_TSS7 = New ToolStripSeparator()
        TSB_TESTCOMPILE = New ToolStripButton()
        TSBI_LISTLIVE = New ToolStripButton()
        StatusStripActions.SuspendLayout()
        CType(SplitContainerMain, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerMain.Panel1.SuspendLayout()
        SplitContainerMain.Panel2.SuspendLayout()
        SplitContainerMain.SuspendLayout()
        CMS_TabControlMain.SuspendLayout()
        TC_SOLUTION.SuspendLayout()
        TP_SOLUTIONEXPLORER.SuspendLayout()
        TableLayoutPanelSolution.SuspendLayout()
        PanelMain.SuspendLayout()
        CMS_TV_MODELS.SuspendLayout()
        TP_OBJECTS.SuspendLayout()
        ToolStripMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStripActions
        ' 
        StatusStripActions.BackColor = SystemColors.Control
        StatusStripActions.ImageScalingSize = New Size(40, 40)
        StatusStripActions.Items.AddRange(New ToolStripItem() {TSSLBLStatus})
        StatusStripActions.Location = New Point(0, 746)
        StatusStripActions.Name = "StatusStripActions"
        StatusStripActions.Size = New Size(2213, 54)
        StatusStripActions.TabIndex = 1
        StatusStripActions.Text = "Status Strip Actions"
        ' 
        ' TSSLBLStatus
        ' 
        TSSLBLStatus.ForeColor = SystemColors.ControlText
        TSSLBLStatus.Name = "TSSLBLStatus"
        TSSLBLStatus.Size = New Size(99, 41)
        TSSLBLStatus.Text = "Ready"
        ' 
        ' SplitContainerMain
        ' 
        SplitContainerMain.Dock = DockStyle.Fill
        SplitContainerMain.Location = New Point(0, 0)
        SplitContainerMain.Name = "SplitContainerMain"
        ' 
        ' SplitContainerMain.Panel1
        ' 
        SplitContainerMain.Panel1.Controls.Add(TabControlMain)
        ' 
        ' SplitContainerMain.Panel2
        ' 
        SplitContainerMain.Panel2.Controls.Add(TC_SOLUTION)
        SplitContainerMain.Size = New Size(2213, 746)
        SplitContainerMain.SplitterDistance = 1599
        SplitContainerMain.TabIndex = 2
        ' 
        ' TabControlMain
        ' 
        TabControlMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControlMain.Appearance = TabAppearance.FlatButtons
        TabControlMain.ContextMenuStrip = CMS_TabControlMain
        TabControlMain.Location = New Point(0, 51)
        TabControlMain.Margin = New Padding(0)
        TabControlMain.Name = "TabControlMain"
        TabControlMain.Padding = New Point(0, 0)
        TabControlMain.SelectedIndex = 0
        TabControlMain.Size = New Size(1599, 695)
        TabControlMain.TabIndex = 5
        ' 
        ' CMS_TabControlMain
        ' 
        CMS_TabControlMain.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CMS_TabControlMain.ImageScalingSize = New Size(40, 40)
        CMS_TabControlMain.Items.AddRange(New ToolStripItem() {CMSTabControl_SaveThis, CMSTabControlDivider, CMSTabControl_Close, CMSTabControlCloseAll, CMSTabControl_CloseAllButThis})
        CMS_TabControlMain.Name = "CMSTabControl"
        CMS_TabControlMain.RenderMode = ToolStripRenderMode.Professional
        CMS_TabControlMain.Size = New Size(327, 186)
        ' 
        ' CMSTabControl_SaveThis
        ' 
        CMSTabControl_SaveThis.ImageTransparentColor = Color.Magenta
        CMSTabControl_SaveThis.Name = "CMSTabControl_SaveThis"
        CMSTabControl_SaveThis.ShortcutKeys = Keys.Control Or Keys.S
        CMSTabControl_SaveThis.ShowShortcutKeys = False
        CMSTabControl_SaveThis.Size = New Size(326, 44)
        CMSTabControl_SaveThis.Text = "Save *This*"
        ' 
        ' CMSTabControlDivider
        ' 
        CMSTabControlDivider.Name = "CMSTabControlDivider"
        CMSTabControlDivider.Size = New Size(323, 6)
        ' 
        ' CMSTabControl_Close
        ' 
        CMSTabControl_Close.Name = "CMSTabControl_Close"
        CMSTabControl_Close.ShortcutKeys = Keys.Control Or Keys.F4
        CMSTabControl_Close.ShowShortcutKeys = False
        CMSTabControl_Close.Size = New Size(326, 44)
        CMSTabControl_Close.Text = "&Close *this*"
        ' 
        ' CMSTabControlCloseAll
        ' 
        CMSTabControlCloseAll.Name = "CMSTabControlCloseAll"
        CMSTabControlCloseAll.Size = New Size(326, 44)
        CMSTabControlCloseAll.Text = "Close all"
        ' 
        ' CMSTabControl_CloseAllButThis
        ' 
        CMSTabControl_CloseAllButThis.Name = "CMSTabControl_CloseAllButThis"
        CMSTabControl_CloseAllButThis.Size = New Size(326, 44)
        CMSTabControl_CloseAllButThis.Text = "Close all but *this*"
        ' 
        ' TC_SOLUTION
        ' 
        TC_SOLUTION.Alignment = TabAlignment.Bottom
        TC_SOLUTION.Controls.Add(TP_SOLUTIONEXPLORER)
        TC_SOLUTION.Controls.Add(TP_OBJECTS)
        TC_SOLUTION.Dock = DockStyle.Fill
        TC_SOLUTION.Location = New Point(0, 0)
        TC_SOLUTION.Margin = New Padding(0)
        TC_SOLUTION.Name = "TC_SOLUTION"
        TC_SOLUTION.Padding = New Point(0, 0)
        TC_SOLUTION.SelectedIndex = 0
        TC_SOLUTION.Size = New Size(610, 746)
        TC_SOLUTION.TabIndex = 1002
        ' 
        ' TP_SOLUTIONEXPLORER
        ' 
        TP_SOLUTIONEXPLORER.Controls.Add(TableLayoutPanelSolution)
        TP_SOLUTIONEXPLORER.Location = New Point(10, 10)
        TP_SOLUTIONEXPLORER.Margin = New Padding(0)
        TP_SOLUTIONEXPLORER.Name = "TP_SOLUTIONEXPLORER"
        TP_SOLUTIONEXPLORER.Size = New Size(590, 670)
        TP_SOLUTIONEXPLORER.TabIndex = 0
        TP_SOLUTIONEXPLORER.Text = "SOLUTION"
        TP_SOLUTIONEXPLORER.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanelSolution
        ' 
        TableLayoutPanelSolution.ColumnCount = 2
        TableLayoutPanelSolution.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanelSolution.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 30F))
        TableLayoutPanelSolution.Controls.Add(PanelMain, 0, 0)
        TableLayoutPanelSolution.Dock = DockStyle.Fill
        TableLayoutPanelSolution.Location = New Point(0, 0)
        TableLayoutPanelSolution.Margin = New Padding(0)
        TableLayoutPanelSolution.Name = "TableLayoutPanelSolution"
        TableLayoutPanelSolution.RowCount = 1
        TableLayoutPanelSolution.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanelSolution.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanelSolution.Size = New Size(590, 670)
        TableLayoutPanelSolution.TabIndex = 3
        ' 
        ' PanelMain
        ' 
        TableLayoutPanelSolution.SetColumnSpan(PanelMain, 2)
        PanelMain.Controls.Add(TV_MODELS)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 0)
        PanelMain.Margin = New Padding(0)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(590, 670)
        PanelMain.TabIndex = 2
        ' 
        ' TV_MODELS
        ' 
        TV_MODELS.AllowDrop = True
        TV_MODELS.BackColor = SystemColors.Window
        TV_MODELS.BorderStyle = BorderStyle.None
        TV_MODELS.ContextMenuStrip = CMS_TV_MODELS
        TV_MODELS.Dock = DockStyle.Fill
        TV_MODELS.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TV_MODELS.FullRowSelect = True
        TV_MODELS.HideSelection = False
        TV_MODELS.LineColor = Color.FromArgb(CByte(0), CByte(102), CByte(204))
        TV_MODELS.Location = New Point(0, 0)
        TV_MODELS.Margin = New Padding(0)
        TV_MODELS.Name = "TV_MODELS"
        TV_MODELS.ShowLines = False
        TV_MODELS.Size = New Size(590, 670)
        TV_MODELS.TabIndex = 3
        ' 
        ' CMS_TV_MODELS
        ' 
        CMS_TV_MODELS.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CMS_TV_MODELS.ImageScalingSize = New Size(40, 40)
        CMS_TV_MODELS.Items.AddRange(New ToolStripItem() {CMS_TV_MODELS_CREATEFOLDER, CMS_TV_MODELS_DELETEFOLDER, CMS_TV_MODELS_RENAMEFOLDER, ToolStripMenuItem2, CMS_TV_MODELS_CREATEMODEL, CMS_TV_MODELS_DELETEMODEL, ToolStripMenuItem3, CMS_TV_MODELS_CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripMenuItem1, CMS_TV_MODELS_REFRESH})
        CMS_TV_MODELS.Name = "CMSTreeView"
        CMS_TV_MODELS.RenderMode = ToolStripRenderMode.Professional
        CMS_TV_MODELS.Size = New Size(324, 374)
        ' 
        ' CMS_TV_MODELS_CREATEFOLDER
        ' 
        CMS_TV_MODELS_CREATEFOLDER.ImageTransparentColor = Color.Magenta
        CMS_TV_MODELS_CREATEFOLDER.Name = "CMS_TV_MODELS_CREATEFOLDER"
        CMS_TV_MODELS_CREATEFOLDER.Size = New Size(323, 44)
        CMS_TV_MODELS_CREATEFOLDER.Text = "Create New Folder"
        ' 
        ' CMS_TV_MODELS_DELETEFOLDER
        ' 
        CMS_TV_MODELS_DELETEFOLDER.Name = "CMS_TV_MODELS_DELETEFOLDER"
        CMS_TV_MODELS_DELETEFOLDER.Size = New Size(323, 44)
        CMS_TV_MODELS_DELETEFOLDER.Text = "Delete Folder"
        ' 
        ' CMS_TV_MODELS_RENAMEFOLDER
        ' 
        CMS_TV_MODELS_RENAMEFOLDER.ImageTransparentColor = Color.Magenta
        CMS_TV_MODELS_RENAMEFOLDER.Name = "CMS_TV_MODELS_RENAMEFOLDER"
        CMS_TV_MODELS_RENAMEFOLDER.Size = New Size(323, 44)
        CMS_TV_MODELS_RENAMEFOLDER.Text = "Rename Folder"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(320, 6)
        ' 
        ' CMS_TV_MODELS_CREATEMODEL
        ' 
        CMS_TV_MODELS_CREATEMODEL.ImageTransparentColor = Color.Magenta
        CMS_TV_MODELS_CREATEMODEL.Name = "CMS_TV_MODELS_CREATEMODEL"
        CMS_TV_MODELS_CREATEMODEL.Size = New Size(323, 44)
        CMS_TV_MODELS_CREATEMODEL.Text = "Create New Model"
        ' 
        ' CMS_TV_MODELS_DELETEMODEL
        ' 
        CMS_TV_MODELS_DELETEMODEL.Name = "CMS_TV_MODELS_DELETEMODEL"
        CMS_TV_MODELS_DELETEMODEL.Size = New Size(323, 44)
        CMS_TV_MODELS_DELETEMODEL.Text = "Delete Model"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(320, 6)
        ' 
        ' CMS_TV_MODELS_CopyToolStripMenuItem
        ' 
        CMS_TV_MODELS_CopyToolStripMenuItem.ImageTransparentColor = Color.Magenta
        CMS_TV_MODELS_CopyToolStripMenuItem.Name = "CMS_TV_MODELS_CopyToolStripMenuItem"
        CMS_TV_MODELS_CopyToolStripMenuItem.Size = New Size(323, 44)
        CMS_TV_MODELS_CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(323, 44)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(320, 6)
        ' 
        ' CMS_TV_MODELS_REFRESH
        ' 
        CMS_TV_MODELS_REFRESH.Name = "CMS_TV_MODELS_REFRESH"
        CMS_TV_MODELS_REFRESH.Size = New Size(323, 44)
        CMS_TV_MODELS_REFRESH.Text = "Refresh"
        ' 
        ' TP_OBJECTS
        ' 
        TP_OBJECTS.Controls.Add(TVObjects)
        TP_OBJECTS.Location = New Point(10, 10)
        TP_OBJECTS.Margin = New Padding(0)
        TP_OBJECTS.Name = "TP_OBJECTS"
        TP_OBJECTS.Size = New Size(590, 674)
        TP_OBJECTS.TabIndex = 1
        TP_OBJECTS.Text = "OBJECTS"
        TP_OBJECTS.UseVisualStyleBackColor = True
        ' 
        ' TVObjects
        ' 
        TVObjects.BorderStyle = BorderStyle.None
        TVObjects.Dock = DockStyle.Fill
        TVObjects.Location = New Point(0, 0)
        TVObjects.Margin = New Padding(0)
        TVObjects.Name = "TVObjects"
        TreeNode15.Name = "RACE_INFO_BARRIER"
        TreeNode15.Tag = "RACE_INFO_BARRIER"
        TreeNode15.Text = "RACE_INFO_BARRIER"
        TreeNode16.Name = "ENTRY_INFO_DISTANCE_SCORE"
        TreeNode16.Tag = "ENTRY_INFO_DISTANCE_SCORE"
        TreeNode16.Text = "ENTRY_INFO_DISTANCE_SCORE"
        TreeNode17.Name = "ENTRY_INFO_DISTANCE_THEO_SCORE"
        TreeNode17.Tag = "ENTRY_INFO_DISTANCE_THEO_SCORE"
        TreeNode17.Text = "ENTRY_INFO_DISTANCE_THEO_SCORE"
        TreeNode18.Name = "ENTRY_INFO_DISTANCE_THEO"
        TreeNode18.Tag = "ENTRY_INFO_DISTANCE_THEO"
        TreeNode18.Text = "ENTRY_INFO_DISTANCE_THEO"
        TreeNode19.ImageIndex = 0
        TreeNode19.Name = "ENTRY_INFO_DISTANCE"
        TreeNode19.Tag = "ENTRY_INFO_DISTANCE"
        TreeNode19.Text = "ENTRY_INFO_DISTANCE"
        TreeNode20.Name = "ENTRY_INFO_GROUP_SCORE"
        TreeNode20.Tag = "ENTRY_INFO_GROUP_SCORE"
        TreeNode20.Text = "ENTRY_INFO_GROUP_SCORE"
        TreeNode21.Name = "ENTRY_INFO_GROUP_THEO_SCORE"
        TreeNode21.Tag = "ENTRY_INFO_GROUP_THEO_SCORE"
        TreeNode21.Text = "ENTRY_INFO_GROUP_THEO_SCORE"
        TreeNode22.Name = "ENTRY_INFO_GROUP_THEO"
        TreeNode22.Tag = "ENTRY_INFO_GROUP_THEO"
        TreeNode22.Text = "ENTRY_INFO_GROUP_THEO"
        TreeNode23.Name = "ENTRY_INFO_GROUP"
        TreeNode23.Tag = "ENTRY_INFO_GROUP"
        TreeNode23.Text = "ENTRY_INFO_GROUP"
        TreeNode24.Name = "ENTRY_INFO_OVERALL_SCORE"
        TreeNode24.Tag = "ENTRY_INFO_OVERALL_SCORE"
        TreeNode24.Text = "ENTRY_INFO_OVERALL_SCORE"
        TreeNode25.Name = "ENTRY_INFO_OVERALL_THEO_SCORE"
        TreeNode25.Tag = "ENTRY_INFO_OVERALL_THEO_SCORE"
        TreeNode25.Text = "ENTRY_INFO_OVERALL_THEO_SCORE"
        TreeNode26.Name = "ENTRY_INFO_OVERALL_THEO"
        TreeNode26.Tag = "ENTRY_INFO_OVERALL_THEO"
        TreeNode26.Text = "ENTRY_INFO_OVERALL_THEO"
        TreeNode27.ImageIndex = 0
        TreeNode27.Name = "ENTRY_INFO_OVERALL"
        TreeNode27.Tag = "ENTRY_INFO_OVERALL"
        TreeNode27.Text = "ENTRY_INFO_OVERALL"
        TreeNode28.ImageIndex = 0
        TreeNode28.Name = "ENTRY_INFO"
        TreeNode28.Tag = "ENTRY_INFO"
        TreeNode28.Text = "ENTRY_INFO"
        TVObjects.Nodes.AddRange(New TreeNode() {TreeNode15, TreeNode28})
        TVObjects.Size = New Size(590, 674)
        TVObjects.TabIndex = 3
        ' 
        ' ToolStripMenu
        ' 
        ToolStripMenu.AccessibleRole = AccessibleRole.ToolBar
        ToolStripMenu.Font = New Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenu.ImageScalingSize = New Size(40, 40)
        ToolStripMenu.Items.AddRange(New ToolStripItem() {TSBNavigateBack, TSBNavigateForward, TSB_TSS1, TSB_OpenFile, TSB_TSS2, TSB_TSS3, TSBCommentOut, TSBUncomment, TSB_TSS4, TSB_Undo, TSB_Redo, TSB_TSS5, TSDDBSTART, TSB_STOP, TSB_TSS6, TSB_TSS7, TSB_TESTCOMPILE, TSBI_LISTLIVE})
        ToolStripMenu.Location = New Point(0, 0)
        ToolStripMenu.Name = "ToolStripMenu"
        ToolStripMenu.Padding = New Padding(0)
        ToolStripMenu.RenderMode = ToolStripRenderMode.Professional
        ToolStripMenu.Size = New Size(2213, 51)
        ToolStripMenu.TabIndex = 3
        ' 
        ' TSBNavigateBack
        ' 
        TSBNavigateBack.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSBNavigateBack.Enabled = False
        TSBNavigateBack.Image = CType(resources.GetObject("TSBNavigateBack.Image"), Image)
        TSBNavigateBack.ImageTransparentColor = Color.Magenta
        TSBNavigateBack.Name = "TSBNavigateBack"
        TSBNavigateBack.Size = New Size(58, 44)
        TSBNavigateBack.Text = "Navigate Back"
        ' 
        ' TSBNavigateForward
        ' 
        TSBNavigateForward.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSBNavigateForward.Enabled = False
        TSBNavigateForward.Image = CType(resources.GetObject("TSBNavigateForward.Image"), Image)
        TSBNavigateForward.ImageTransparentColor = Color.Magenta
        TSBNavigateForward.Name = "TSBNavigateForward"
        TSBNavigateForward.Size = New Size(58, 44)
        TSBNavigateForward.Text = "Navigate Forward"
        ' 
        ' TSB_TSS1
        ' 
        TSB_TSS1.Name = "TSB_TSS1"
        TSB_TSS1.Size = New Size(6, 51)
        ' 
        ' TSB_OpenFile
        ' 
        TSB_OpenFile.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSB_OpenFile.Image = CType(resources.GetObject("TSB_OpenFile.Image"), Image)
        TSB_OpenFile.ImageTransparentColor = Color.Magenta
        TSB_OpenFile.Name = "TSB_OpenFile"
        TSB_OpenFile.Size = New Size(58, 44)
        TSB_OpenFile.Text = "Open File"
        ' 
        ' TSB_TSS2
        ' 
        TSB_TSS2.Name = "TSB_TSS2"
        TSB_TSS2.Size = New Size(6, 51)
        ' 
        ' TSB_TSS3
        ' 
        TSB_TSS3.Name = "TSB_TSS3"
        TSB_TSS3.Size = New Size(6, 51)
        ' 
        ' TSBCommentOut
        ' 
        TSBCommentOut.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSBCommentOut.Enabled = False
        TSBCommentOut.Image = CType(resources.GetObject("TSBCommentOut.Image"), Image)
        TSBCommentOut.ImageTransparentColor = Color.Magenta
        TSBCommentOut.Name = "TSBCommentOut"
        TSBCommentOut.Size = New Size(58, 44)
        TSBCommentOut.Text = "Comment out selected lines."
        ' 
        ' TSBUncomment
        ' 
        TSBUncomment.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSBUncomment.Enabled = False
        TSBUncomment.Image = CType(resources.GetObject("TSBUncomment.Image"), Image)
        TSBUncomment.ImageTransparentColor = Color.Magenta
        TSBUncomment.Name = "TSBUncomment"
        TSBUncomment.Size = New Size(58, 44)
        TSBUncomment.Text = "Uncomment selected lines"
        ' 
        ' TSB_TSS4
        ' 
        TSB_TSS4.Name = "TSB_TSS4"
        TSB_TSS4.Size = New Size(6, 51)
        ' 
        ' TSB_Undo
        ' 
        TSB_Undo.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSB_Undo.Enabled = False
        TSB_Undo.Image = CType(resources.GetObject("TSB_Undo.Image"), Image)
        TSB_Undo.ImageTransparentColor = Color.Black
        TSB_Undo.Name = "TSB_Undo"
        TSB_Undo.Size = New Size(58, 44)
        TSB_Undo.Text = "Undo (Ctrl + Z)"
        TSB_Undo.TextDirection = ToolStripTextDirection.Horizontal
        ' 
        ' TSB_Redo
        ' 
        TSB_Redo.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSB_Redo.Enabled = False
        TSB_Redo.Image = CType(resources.GetObject("TSB_Redo.Image"), Image)
        TSB_Redo.ImageTransparentColor = Color.Black
        TSB_Redo.Name = "TSB_Redo"
        TSB_Redo.Size = New Size(58, 44)
        TSB_Redo.Text = "Redo (Ctrl + Y)"
        ' 
        ' TSB_TSS5
        ' 
        TSB_TSS5.Name = "TSB_TSS5"
        TSB_TSS5.Size = New Size(6, 51)
        ' 
        ' TSDDBSTART
        ' 
        TSDDBSTART.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSDDBSTART.DropDownItems.AddRange(New ToolStripItem() {STARTToolStripMenuItem, STARTITERATIONToolStripMenuItem})
        TSDDBSTART.Image = CType(resources.GetObject("TSDDBSTART.Image"), Image)
        TSDDBSTART.ImageAlign = ContentAlignment.MiddleLeft
        TSDDBSTART.ImageTransparentColor = Color.Black
        TSDDBSTART.Name = "TSDDBSTART"
        TSDDBSTART.Size = New Size(66, 44)
        TSDDBSTART.Text = "START"
        TSDDBSTART.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' STARTToolStripMenuItem
        ' 
        STARTToolStripMenuItem.Image = CType(resources.GetObject("STARTToolStripMenuItem.Image"), Image)
        STARTToolStripMenuItem.ImageTransparentColor = Color.Black
        STARTToolStripMenuItem.Name = "STARTToolStripMenuItem"
        STARTToolStripMenuItem.Size = New Size(474, 54)
        STARTToolStripMenuItem.Text = "START"
        ' 
        ' STARTITERATIONToolStripMenuItem
        ' 
        STARTITERATIONToolStripMenuItem.ImageTransparentColor = Color.Black
        STARTITERATIONToolStripMenuItem.Name = "STARTITERATIONToolStripMenuItem"
        STARTITERATIONToolStripMenuItem.Size = New Size(474, 54)
        STARTITERATIONToolStripMenuItem.Text = "START - ITERATION"
        ' 
        ' TSB_STOP
        ' 
        TSB_STOP.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSB_STOP.Enabled = False
        TSB_STOP.Image = CType(resources.GetObject("TSB_STOP.Image"), Image)
        TSB_STOP.ImageTransparentColor = Color.Magenta
        TSB_STOP.Name = "TSB_STOP"
        TSB_STOP.Size = New Size(58, 44)
        TSB_STOP.ToolTipText = "Stop"
        ' 
        ' TSB_TSS6
        ' 
        TSB_TSS6.Name = "TSB_TSS6"
        TSB_TSS6.Size = New Size(6, 51)
        ' 
        ' TSB_TSS7
        ' 
        TSB_TSS7.Name = "TSB_TSS7"
        TSB_TSS7.Size = New Size(6, 51)
        ' 
        ' TSB_TESTCOMPILE
        ' 
        TSB_TESTCOMPILE.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSB_TESTCOMPILE.Image = CType(resources.GetObject("TSB_TESTCOMPILE.Image"), Image)
        TSB_TESTCOMPILE.ImageTransparentColor = Color.Black
        TSB_TESTCOMPILE.Name = "TSB_TESTCOMPILE"
        TSB_TESTCOMPILE.Size = New Size(58, 44)
        TSB_TESTCOMPILE.Text = "TEST COMPILE"
        ' 
        ' TSBI_LISTLIVE
        ' 
        TSBI_LISTLIVE.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSBI_LISTLIVE.Image = CType(resources.GetObject("TSBI_LISTLIVE.Image"), Image)
        TSBI_LISTLIVE.ImageTransparentColor = Color.Magenta
        TSBI_LISTLIVE.Name = "TSBI_LISTLIVE"
        TSBI_LISTLIVE.Size = New Size(58, 44)
        TSBI_LISTLIVE.Text = "LIST LIVE MODELS"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(18F, 45F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.Window
        ClientSize = New Size(2213, 800)
        Controls.Add(ToolStripMenu)
        Controls.Add(SplitContainerMain)
        Controls.Add(StatusStripActions)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = SystemColors.WindowText
        Name = "FrmMain"
        Text = "Model Development"
        StatusStripActions.ResumeLayout(False)
        StatusStripActions.PerformLayout()
        SplitContainerMain.Panel1.ResumeLayout(False)
        SplitContainerMain.Panel2.ResumeLayout(False)
        CType(SplitContainerMain, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerMain.ResumeLayout(False)
        CMS_TabControlMain.ResumeLayout(False)
        TC_SOLUTION.ResumeLayout(False)
        TP_SOLUTIONEXPLORER.ResumeLayout(False)
        TableLayoutPanelSolution.ResumeLayout(False)
        PanelMain.ResumeLayout(False)
        CMS_TV_MODELS.ResumeLayout(False)
        TP_OBJECTS.ResumeLayout(False)
        ToolStripMenu.ResumeLayout(False)
        ToolStripMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StatusStripActions As StatusStrip
    Friend WithEvents TSSLBLStatus As ToolStripStatusLabel
    Friend WithEvents SplitContainerMain As SplitContainer
    Private WithEvents TC_SOLUTION As TabControl
    Private WithEvents TP_SOLUTIONEXPLORER As TabPage
    Friend WithEvents TableLayoutPanelSolution As TableLayoutPanel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents TV_MODELS As TreeView
    Private WithEvents TP_OBJECTS As TabPage
    Private WithEvents TVObjects As TreeView
    Friend WithEvents TabControlMain As TabControl
    Private WithEvents CMS_TV_MODELS As ContextMenuStrip
    Private WithEvents CMS_TV_MODELS_CREATEFOLDER As ToolStripMenuItem
    Private WithEvents CMS_TV_MODELS_DELETEFOLDER As ToolStripMenuItem
    Private WithEvents CMS_TV_MODELS_RENAMEFOLDER As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Private WithEvents CMS_TV_MODELS_CREATEMODEL As ToolStripMenuItem
    Private WithEvents CMS_TV_MODELS_DELETEMODEL As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents CMS_TV_MODELS_CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CMS_TV_MODELS_REFRESH As ToolStripMenuItem
    Private WithEvents CMSTabControl_SaveThis As ToolStripMenuItem
    Private WithEvents CMSTabControlDivider As ToolStripSeparator
    Private WithEvents CMSTabControl_Close As ToolStripMenuItem
    Private WithEvents CMSTabControlCloseAll As ToolStripMenuItem
    Private WithEvents CMSTabControl_CloseAllButThis As ToolStripMenuItem
    Private WithEvents ToolStripMenu As ToolStrip
    Private WithEvents TSBNavigateBack As ToolStripButton
    Private WithEvents TSBNavigateForward As ToolStripButton
    Private WithEvents TSB_TSS1 As ToolStripSeparator
    Private WithEvents TSB_OpenFile As ToolStripButton
    Private WithEvents TSB_TSS2 As ToolStripSeparator
    Private WithEvents TSB_TSS3 As ToolStripSeparator
    Private WithEvents TSBCommentOut As ToolStripButton
    Private WithEvents TSBUncomment As ToolStripButton
    Private WithEvents TSB_TSS4 As ToolStripSeparator
    Friend WithEvents TSB_Undo As ToolStripButton
    Friend WithEvents TSB_Redo As ToolStripButton
    Private WithEvents TSB_TSS5 As ToolStripSeparator
    Friend WithEvents TSDDBSTART As ToolStripDropDownButton
    Friend WithEvents STARTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STARTITERATIONToolStripMenuItem As ToolStripMenuItem
    Private WithEvents TSB_STOP As ToolStripButton
    Friend WithEvents TSB_TSS6 As ToolStripSeparator
    Friend WithEvents TSB_TSS7 As ToolStripSeparator
    Friend WithEvents TSB_TESTCOMPILE As ToolStripButton
    Private WithEvents TSBI_LISTLIVE As ToolStripButton
    Friend WithEvents CMS_TabControlMain As ContextMenuStrip
End Class
