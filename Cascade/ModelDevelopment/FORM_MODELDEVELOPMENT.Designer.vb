Namespace ModelDevelopment
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FORM_MODELDEVELOPMENT
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If Connection IsNot Nothing Then Connection.Dispose() : Connection = Nothing
                If MY_POPUP IsNot Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
                If MODELLIST IsNot Nothing Then MODELLIST.Dispose() : MODELLIST = Nothing
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_MODELDEVELOPMENT))
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RACE_INFO_BARRIER")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_DISTANCE_SCORE")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_DISTANCE_THEO_SCORE")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_DISTANCE_THEO", New System.Windows.Forms.TreeNode() {TreeNode3})
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_DISTANCE", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4})
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_GROUP_SCORE")
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_GROUP_THEO_SCORE")
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_GROUP_THEO", New System.Windows.Forms.TreeNode() {TreeNode7})
            Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_GROUP", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode8})
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_OVERALL_SCORE")
            Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_OVERALL_THEO_SCORE")
            Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_OVERALL_THEO", New System.Windows.Forms.TreeNode() {TreeNode11})
            Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO_OVERALL", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode12})
            Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ENTRY_INFO", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode9, TreeNode13})
            Me.TSM_Main = New System.Windows.Forms.ToolStrip()
            Me.TSBNavigateBack = New System.Windows.Forms.ToolStripButton()
            Me.TSBNavigateForward = New System.Windows.Forms.ToolStripButton()
            Me.TSB_TSS1 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSB_OpenFile = New System.Windows.Forms.ToolStripButton()
            Me.TSBSave = New System.Windows.Forms.ToolStripButton()
            Me.TSBSaveAll = New System.Windows.Forms.ToolStripButton()
            Me.TSB_TSS2 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSDDBClose = New System.Windows.Forms.ToolStripDropDownButton()
            Me.TSB_TSS3 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSBCommentOut = New System.Windows.Forms.ToolStripButton()
            Me.TSBUncomment = New System.Windows.Forms.ToolStripButton()
            Me.TSB_TSS4 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSB_Undo = New System.Windows.Forms.ToolStripButton()
            Me.TSB_Redo = New System.Windows.Forms.ToolStripButton()
            Me.TSB_TSS5 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSDDBSTART = New System.Windows.Forms.ToolStripDropDownButton()
            Me.STARTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.STARTITERATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSB_STOP = New System.Windows.Forms.ToolStripButton()
            Me.TSB_TSS6 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSB_SELECTMODE = New System.Windows.Forms.ToolStripButton()
            Me.TSB_TSS7 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSB_EXPORTTOFILE = New System.Windows.Forms.ToolStripButton()
            Me.TSB_IMPORT = New System.Windows.Forms.ToolStripButton()
            Me.TSB_TSS8 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSB_SWITCHMODELOFF = New System.Windows.Forms.ToolStripButton()
            Me.TSB_SWITCHMODELON = New System.Windows.Forms.ToolStripButton()
            Me.TSB_TSS9 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSB_TESTCOMPILE = New System.Windows.Forms.ToolStripButton()
            Me.TSBI_LISTLIVE = New System.Windows.Forms.ToolStripButton()
            Me.SC_MAIN = New System.Windows.Forms.SplitContainer()
            Me.TC_Main = New System.Windows.Forms.TabControl()
            Me.CMS_TC_MAIN = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CMSTabControl_SaveThis = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMSTabControlDivider = New System.Windows.Forms.ToolStripSeparator()
            Me.CMSTabControl_Close = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMSTabControlCloseAll = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMSTabControl_CloseAllButThis = New System.Windows.Forms.ToolStripMenuItem()
            Me.TC_SOLUTION = New System.Windows.Forms.TabControl()
            Me.TP_SOLUTIONEXPLORER = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanelSolution = New System.Windows.Forms.TableLayoutPanel()
            Me.ButtonSearch = New System.Windows.Forms.Button()
            Me.IL_TV_OBJECTS = New System.Windows.Forms.ImageList(Me.components)
            Me.TextBoxSearch = New System.Windows.Forms.TextBox()
            Me.PanelMain = New System.Windows.Forms.Panel()
            Me.TV_MODELS = New System.Windows.Forms.TreeView()
            Me.CMS_TV_MODELS = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CMS_TV_MODELS_CREATEFOLDER = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMS_TV_MODELS_DELETEFOLDER = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMS_TV_MODELS_RENAMEFOLDER = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
            Me.CMS_TV_MODELS_CREATEMODEL = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMS_TV_MODELS_DELETEMODEL = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
            Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.CMS_TV_MODELS_REFRESH = New System.Windows.Forms.ToolStripMenuItem()
            Me.IL_TV_MODELS = New System.Windows.Forms.ImageList(Me.components)
            Me.LblModelExplorer = New System.Windows.Forms.Label()
            Me.TP_OBJECTS = New System.Windows.Forms.TabPage()
            Me.TVObjects = New System.Windows.Forms.TreeView()
            Me.CMS_OBJECTS = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.TSMI_OBJECTS_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSB_OPENFILEDIALOG = New System.Windows.Forms.OpenFileDialog()
            Me.TSM_Main.SuspendLayout()
            CType(Me.SC_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SC_MAIN.Panel1.SuspendLayout()
            Me.SC_MAIN.Panel2.SuspendLayout()
            Me.SC_MAIN.SuspendLayout()
            Me.CMS_TC_MAIN.SuspendLayout()
            Me.TC_SOLUTION.SuspendLayout()
            Me.TP_SOLUTIONEXPLORER.SuspendLayout()
            Me.TableLayoutPanelSolution.SuspendLayout()
            Me.PanelMain.SuspendLayout()
            Me.CMS_TV_MODELS.SuspendLayout()
            Me.TP_OBJECTS.SuspendLayout()
            Me.CMS_OBJECTS.SuspendLayout()
            Me.SuspendLayout()
            '
            'TSM_Main
            '
            Me.TSM_Main.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
            Me.TSM_Main.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TSM_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBNavigateBack, Me.TSBNavigateForward, Me.TSB_TSS1, Me.TSB_OpenFile, Me.TSBSave, Me.TSBSaveAll, Me.TSB_TSS2, Me.TSDDBClose, Me.TSB_TSS3, Me.TSBCommentOut, Me.TSBUncomment, Me.TSB_TSS4, Me.TSB_Undo, Me.TSB_Redo, Me.TSB_TSS5, Me.TSDDBSTART, Me.TSB_STOP, Me.TSB_TSS6, Me.TSB_SELECTMODE, Me.TSB_TSS7, Me.TSB_EXPORTTOFILE, Me.TSB_IMPORT, Me.TSB_TSS8, Me.TSB_SWITCHMODELOFF, Me.TSB_SWITCHMODELON, Me.TSB_TSS9, Me.TSB_TESTCOMPILE, Me.TSBI_LISTLIVE})
            Me.TSM_Main.Location = New System.Drawing.Point(0, 0)
            Me.TSM_Main.Name = "TSM_Main"
            Me.TSM_Main.Padding = New System.Windows.Forms.Padding(0)
            Me.TSM_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.TSM_Main.Size = New System.Drawing.Size(777, 25)
            Me.TSM_Main.TabIndex = 2
            Me.TSM_Main.Text = "ToolStrip1"
            '
            'TSBNavigateBack
            '
            Me.TSBNavigateBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSBNavigateBack.Enabled = False
            Me.TSBNavigateBack.Image = CType(resources.GetObject("TSBNavigateBack.Image"), System.Drawing.Image)
            Me.TSBNavigateBack.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSBNavigateBack.Name = "TSBNavigateBack"
            Me.TSBNavigateBack.Size = New System.Drawing.Size(23, 22)
            Me.TSBNavigateBack.Text = "Navigate Back"
            '
            'TSBNavigateForward
            '
            Me.TSBNavigateForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSBNavigateForward.Enabled = False
            Me.TSBNavigateForward.Image = CType(resources.GetObject("TSBNavigateForward.Image"), System.Drawing.Image)
            Me.TSBNavigateForward.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSBNavigateForward.Name = "TSBNavigateForward"
            Me.TSBNavigateForward.Size = New System.Drawing.Size(23, 22)
            Me.TSBNavigateForward.Text = "Navigate Forward"
            '
            'TSB_TSS1
            '
            Me.TSB_TSS1.Name = "TSB_TSS1"
            Me.TSB_TSS1.Size = New System.Drawing.Size(6, 25)
            '
            'TSB_OpenFile
            '
            Me.TSB_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_OpenFile.Image = CType(resources.GetObject("TSB_OpenFile.Image"), System.Drawing.Image)
            Me.TSB_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSB_OpenFile.Name = "TSB_OpenFile"
            Me.TSB_OpenFile.Size = New System.Drawing.Size(23, 22)
            Me.TSB_OpenFile.Text = "Open File"
            '
            'TSBSave
            '
            Me.TSBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSBSave.Enabled = False
            Me.TSBSave.Image = CType(resources.GetObject("TSBSave.Image"), System.Drawing.Image)
            Me.TSBSave.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSBSave.Name = "TSBSave"
            Me.TSBSave.Size = New System.Drawing.Size(23, 22)
            Me.TSBSave.Text = "Save"
            '
            'TSBSaveAll
            '
            Me.TSBSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSBSaveAll.Enabled = False
            Me.TSBSaveAll.Image = CType(resources.GetObject("TSBSaveAll.Image"), System.Drawing.Image)
            Me.TSBSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSBSaveAll.Name = "TSBSaveAll"
            Me.TSBSaveAll.Size = New System.Drawing.Size(23, 22)
            Me.TSBSaveAll.Text = "Save All"
            '
            'TSB_TSS2
            '
            Me.TSB_TSS2.Name = "TSB_TSS2"
            Me.TSB_TSS2.Size = New System.Drawing.Size(6, 25)
            '
            'TSDDBClose
            '
            Me.TSDDBClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSDDBClose.Enabled = False
            Me.TSDDBClose.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSDDBClose.Name = "TSDDBClose"
            Me.TSDDBClose.Size = New System.Drawing.Size(13, 22)
            Me.TSDDBClose.Text = "Close"
            '
            'TSB_TSS3
            '
            Me.TSB_TSS3.Name = "TSB_TSS3"
            Me.TSB_TSS3.Size = New System.Drawing.Size(6, 25)
            '
            'TSBCommentOut
            '
            Me.TSBCommentOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSBCommentOut.Enabled = False
            Me.TSBCommentOut.Image = CType(resources.GetObject("TSBCommentOut.Image"), System.Drawing.Image)
            Me.TSBCommentOut.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSBCommentOut.Name = "TSBCommentOut"
            Me.TSBCommentOut.Size = New System.Drawing.Size(23, 22)
            Me.TSBCommentOut.Text = "Comment out selected lines."
            '
            'TSBUncomment
            '
            Me.TSBUncomment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSBUncomment.Enabled = False
            Me.TSBUncomment.Image = CType(resources.GetObject("TSBUncomment.Image"), System.Drawing.Image)
            Me.TSBUncomment.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSBUncomment.Name = "TSBUncomment"
            Me.TSBUncomment.Size = New System.Drawing.Size(23, 22)
            Me.TSBUncomment.Text = "Uncomment selected lines"
            '
            'TSB_TSS4
            '
            Me.TSB_TSS4.Name = "TSB_TSS4"
            Me.TSB_TSS4.Size = New System.Drawing.Size(6, 25)
            '
            'TSB_Undo
            '
            Me.TSB_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_Undo.Enabled = False
            Me.TSB_Undo.Image = CType(resources.GetObject("TSB_Undo.Image"), System.Drawing.Image)
            Me.TSB_Undo.ImageTransparentColor = System.Drawing.Color.Black
            Me.TSB_Undo.Name = "TSB_Undo"
            Me.TSB_Undo.Size = New System.Drawing.Size(23, 22)
            Me.TSB_Undo.Text = "Undo (Ctrl + Z)"
            Me.TSB_Undo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
            '
            'TSB_Redo
            '
            Me.TSB_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_Redo.Enabled = False
            Me.TSB_Redo.Image = CType(resources.GetObject("TSB_Redo.Image"), System.Drawing.Image)
            Me.TSB_Redo.ImageTransparentColor = System.Drawing.Color.Black
            Me.TSB_Redo.Name = "TSB_Redo"
            Me.TSB_Redo.Size = New System.Drawing.Size(23, 22)
            Me.TSB_Redo.Text = "Redo (Ctrl + Y)"
            '
            'TSB_TSS5
            '
            Me.TSB_TSS5.Name = "TSB_TSS5"
            Me.TSB_TSS5.Size = New System.Drawing.Size(6, 25)
            '
            'TSDDBSTART
            '
            Me.TSDDBSTART.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSDDBSTART.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STARTToolStripMenuItem, Me.STARTITERATIONToolStripMenuItem})
            Me.TSDDBSTART.Image = CType(resources.GetObject("TSDDBSTART.Image"), System.Drawing.Image)
            Me.TSDDBSTART.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.TSDDBSTART.ImageTransparentColor = System.Drawing.Color.Black
            Me.TSDDBSTART.Name = "TSDDBSTART"
            Me.TSDDBSTART.Size = New System.Drawing.Size(29, 22)
            Me.TSDDBSTART.Text = "START"
            Me.TSDDBSTART.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'STARTToolStripMenuItem
            '
            Me.STARTToolStripMenuItem.Image = CType(resources.GetObject("STARTToolStripMenuItem.Image"), System.Drawing.Image)
            Me.STARTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
            Me.STARTToolStripMenuItem.Name = "STARTToolStripMenuItem"
            Me.STARTToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
            Me.STARTToolStripMenuItem.Text = "START"
            '
            'STARTITERATIONToolStripMenuItem
            '
            Me.STARTITERATIONToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
            Me.STARTITERATIONToolStripMenuItem.Name = "STARTITERATIONToolStripMenuItem"
            Me.STARTITERATIONToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
            Me.STARTITERATIONToolStripMenuItem.Text = "START - ITERATION"
            '
            'TSB_STOP
            '
            Me.TSB_STOP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_STOP.Enabled = False
            Me.TSB_STOP.Image = CType(resources.GetObject("TSB_STOP.Image"), System.Drawing.Image)
            Me.TSB_STOP.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSB_STOP.Name = "TSB_STOP"
            Me.TSB_STOP.Size = New System.Drawing.Size(23, 22)
            Me.TSB_STOP.ToolTipText = "Stop"
            '
            'TSB_TSS6
            '
            Me.TSB_TSS6.Name = "TSB_TSS6"
            Me.TSB_TSS6.Size = New System.Drawing.Size(6, 25)
            '
            'TSB_SELECTMODE
            '
            Me.TSB_SELECTMODE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_SELECTMODE.Image = CType(resources.GetObject("TSB_SELECTMODE.Image"), System.Drawing.Image)
            Me.TSB_SELECTMODE.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSB_SELECTMODE.Name = "TSB_SELECTMODE"
            Me.TSB_SELECTMODE.Size = New System.Drawing.Size(23, 22)
            Me.TSB_SELECTMODE.Text = "Check boxes ON"
            '
            'TSB_TSS7
            '
            Me.TSB_TSS7.Name = "TSB_TSS7"
            Me.TSB_TSS7.Size = New System.Drawing.Size(6, 25)
            '
            'TSB_EXPORTTOFILE
            '
            Me.TSB_EXPORTTOFILE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_EXPORTTOFILE.Enabled = False
            Me.TSB_EXPORTTOFILE.Image = CType(resources.GetObject("TSB_EXPORTTOFILE.Image"), System.Drawing.Image)
            Me.TSB_EXPORTTOFILE.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSB_EXPORTTOFILE.Name = "TSB_EXPORTTOFILE"
            Me.TSB_EXPORTTOFILE.Size = New System.Drawing.Size(23, 22)
            Me.TSB_EXPORTTOFILE.Text = "Export To File"
            '
            'TSB_IMPORT
            '
            Me.TSB_IMPORT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_IMPORT.Image = CType(resources.GetObject("TSB_IMPORT.Image"), System.Drawing.Image)
            Me.TSB_IMPORT.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSB_IMPORT.Name = "TSB_IMPORT"
            Me.TSB_IMPORT.Size = New System.Drawing.Size(23, 22)
            Me.TSB_IMPORT.Text = "Import File"
            '
            'TSB_TSS8
            '
            Me.TSB_TSS8.Name = "TSB_TSS8"
            Me.TSB_TSS8.Size = New System.Drawing.Size(6, 25)
            '
            'TSB_SWITCHMODELOFF
            '
            Me.TSB_SWITCHMODELOFF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_SWITCHMODELOFF.Enabled = False
            Me.TSB_SWITCHMODELOFF.Image = CType(resources.GetObject("TSB_SWITCHMODELOFF.Image"), System.Drawing.Image)
            Me.TSB_SWITCHMODELOFF.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSB_SWITCHMODELOFF.Name = "TSB_SWITCHMODELOFF"
            Me.TSB_SWITCHMODELOFF.Size = New System.Drawing.Size(23, 22)
            Me.TSB_SWITCHMODELOFF.Text = "Turn selected models OFF"
            '
            'TSB_SWITCHMODELON
            '
            Me.TSB_SWITCHMODELON.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_SWITCHMODELON.Enabled = False
            Me.TSB_SWITCHMODELON.Image = CType(resources.GetObject("TSB_SWITCHMODELON.Image"), System.Drawing.Image)
            Me.TSB_SWITCHMODELON.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSB_SWITCHMODELON.Name = "TSB_SWITCHMODELON"
            Me.TSB_SWITCHMODELON.Size = New System.Drawing.Size(23, 22)
            Me.TSB_SWITCHMODELON.Text = "Turn selected models ON"
            '
            'TSB_TSS9
            '
            Me.TSB_TSS9.Name = "TSB_TSS9"
            Me.TSB_TSS9.Size = New System.Drawing.Size(6, 25)
            '
            'TSB_TESTCOMPILE
            '
            Me.TSB_TESTCOMPILE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSB_TESTCOMPILE.Image = CType(resources.GetObject("TSB_TESTCOMPILE.Image"), System.Drawing.Image)
            Me.TSB_TESTCOMPILE.ImageTransparentColor = System.Drawing.Color.Black
            Me.TSB_TESTCOMPILE.Name = "TSB_TESTCOMPILE"
            Me.TSB_TESTCOMPILE.Size = New System.Drawing.Size(23, 22)
            Me.TSB_TESTCOMPILE.Text = "TEST COMPILE"
            '
            'TSBI_LISTLIVE
            '
            Me.TSBI_LISTLIVE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.TSBI_LISTLIVE.Image = CType(resources.GetObject("TSBI_LISTLIVE.Image"), System.Drawing.Image)
            Me.TSBI_LISTLIVE.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSBI_LISTLIVE.Name = "TSBI_LISTLIVE"
            Me.TSBI_LISTLIVE.Size = New System.Drawing.Size(23, 22)
            Me.TSBI_LISTLIVE.Text = "LIST LIVE MODELS"
            '
            'SC_MAIN
            '
            Me.SC_MAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SC_MAIN.BackColor = System.Drawing.Color.Transparent
            Me.SC_MAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.SC_MAIN.Location = New System.Drawing.Point(0, 25)
            Me.SC_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.SC_MAIN.Name = "SC_MAIN"
            '
            'SC_MAIN.Panel1
            '
            Me.SC_MAIN.Panel1.Controls.Add(Me.TC_Main)
            '
            'SC_MAIN.Panel2
            '
            Me.SC_MAIN.Panel2.AutoScrollMargin = New System.Drawing.Size(5, 5)
            Me.SC_MAIN.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.SC_MAIN.Panel2.Controls.Add(Me.TC_SOLUTION)
            Me.SC_MAIN.Size = New System.Drawing.Size(777, 399)
            Me.SC_MAIN.SplitterDistance = 552
            Me.SC_MAIN.TabIndex = 3
            '
            'TC_Main
            '
            Me.TC_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
            Me.TC_Main.ContextMenuStrip = Me.CMS_TC_MAIN
            Me.TC_Main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_Main.Location = New System.Drawing.Point(0, 0)
            Me.TC_Main.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_Main.Name = "TC_Main"
            Me.TC_Main.Padding = New System.Drawing.Point(0, 0)
            Me.TC_Main.SelectedIndex = 0
            Me.TC_Main.Size = New System.Drawing.Size(550, 397)
            Me.TC_Main.TabIndex = 4
            '
            'CMS_TC_MAIN
            '
            Me.CMS_TC_MAIN.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_TC_MAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMSTabControl_SaveThis, Me.CMSTabControlDivider, Me.CMSTabControl_Close, Me.CMSTabControlCloseAll, Me.CMSTabControl_CloseAllButThis})
            Me.CMS_TC_MAIN.Name = "CMSTabControl"
            Me.CMS_TC_MAIN.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.CMS_TC_MAIN.Size = New System.Drawing.Size(180, 98)
            '
            'CMSTabControl_SaveThis
            '
            Me.CMSTabControl_SaveThis.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CMSTabControl_SaveThis.Name = "CMSTabControl_SaveThis"
            Me.CMSTabControl_SaveThis.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
            Me.CMSTabControl_SaveThis.ShowShortcutKeys = False
            Me.CMSTabControl_SaveThis.Size = New System.Drawing.Size(179, 22)
            Me.CMSTabControl_SaveThis.Text = "Save *This*"
            '
            'CMSTabControlDivider
            '
            Me.CMSTabControlDivider.Name = "CMSTabControlDivider"
            Me.CMSTabControlDivider.Size = New System.Drawing.Size(176, 6)
            '
            'CMSTabControl_Close
            '
            Me.CMSTabControl_Close.Name = "CMSTabControl_Close"
            Me.CMSTabControl_Close.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
            Me.CMSTabControl_Close.ShowShortcutKeys = False
            Me.CMSTabControl_Close.Size = New System.Drawing.Size(179, 22)
            Me.CMSTabControl_Close.Text = "&Close *this*"
            '
            'CMSTabControlCloseAll
            '
            Me.CMSTabControlCloseAll.Name = "CMSTabControlCloseAll"
            Me.CMSTabControlCloseAll.Size = New System.Drawing.Size(179, 22)
            Me.CMSTabControlCloseAll.Text = "Close all"
            '
            'CMSTabControl_CloseAllButThis
            '
            Me.CMSTabControl_CloseAllButThis.Name = "CMSTabControl_CloseAllButThis"
            Me.CMSTabControl_CloseAllButThis.Size = New System.Drawing.Size(179, 22)
            Me.CMSTabControl_CloseAllButThis.Text = "Close all but *this*"
            '
            'TC_SOLUTION
            '
            Me.TC_SOLUTION.Alignment = System.Windows.Forms.TabAlignment.Bottom
            Me.TC_SOLUTION.Controls.Add(Me.TP_SOLUTIONEXPLORER)
            Me.TC_SOLUTION.Controls.Add(Me.TP_OBJECTS)
            Me.TC_SOLUTION.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_SOLUTION.Location = New System.Drawing.Point(0, 0)
            Me.TC_SOLUTION.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_SOLUTION.Name = "TC_SOLUTION"
            Me.TC_SOLUTION.Padding = New System.Drawing.Point(0, 0)
            Me.TC_SOLUTION.SelectedIndex = 0
            Me.TC_SOLUTION.Size = New System.Drawing.Size(219, 397)
            Me.TC_SOLUTION.TabIndex = 0
            '
            'TP_SOLUTIONEXPLORER
            '
            Me.TP_SOLUTIONEXPLORER.Controls.Add(Me.TableLayoutPanelSolution)
            Me.TP_SOLUTIONEXPLORER.Location = New System.Drawing.Point(4, 4)
            Me.TP_SOLUTIONEXPLORER.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_SOLUTIONEXPLORER.Name = "TP_SOLUTIONEXPLORER"
            Me.TP_SOLUTIONEXPLORER.Size = New System.Drawing.Size(211, 371)
            Me.TP_SOLUTIONEXPLORER.TabIndex = 0
            Me.TP_SOLUTIONEXPLORER.Text = "SOLUTION"
            Me.TP_SOLUTIONEXPLORER.UseVisualStyleBackColor = True
            '
            'TableLayoutPanelSolution
            '
            Me.TableLayoutPanelSolution.ColumnCount = 2
            Me.TableLayoutPanelSolution.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanelSolution.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
            Me.TableLayoutPanelSolution.Controls.Add(Me.ButtonSearch, 1, 0)
            Me.TableLayoutPanelSolution.Controls.Add(Me.TextBoxSearch, 0, 0)
            Me.TableLayoutPanelSolution.Controls.Add(Me.PanelMain, 0, 1)
            Me.TableLayoutPanelSolution.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanelSolution.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanelSolution.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanelSolution.Name = "TableLayoutPanelSolution"
            Me.TableLayoutPanelSolution.RowCount = 2
            Me.TableLayoutPanelSolution.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
            Me.TableLayoutPanelSolution.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanelSolution.Size = New System.Drawing.Size(211, 371)
            Me.TableLayoutPanelSolution.TabIndex = 3
            '
            'ButtonSearch
            '
            Me.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ButtonSearch.ImageIndex = 2
            Me.ButtonSearch.ImageList = Me.IL_TV_OBJECTS
            Me.ButtonSearch.Location = New System.Drawing.Point(189, 1)
            Me.ButtonSearch.Margin = New System.Windows.Forms.Padding(1)
            Me.ButtonSearch.Name = "ButtonSearch"
            Me.ButtonSearch.Size = New System.Drawing.Size(21, 19)
            Me.ButtonSearch.TabIndex = 2
            Me.ButtonSearch.UseVisualStyleBackColor = True
            '
            'IL_TV_OBJECTS
            '
            Me.IL_TV_OBJECTS.ImageStream = CType(resources.GetObject("IL_TV_OBJECTS.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.IL_TV_OBJECTS.TransparentColor = System.Drawing.Color.Magenta
            Me.IL_TV_OBJECTS.Images.SetKeyName(0, "DataTable_8468_24.bmp")
            Me.IL_TV_OBJECTS.Images.SetKeyName(1, "DataView_5947_24.bmp")
            Me.IL_TV_OBJECTS.Images.SetKeyName(2, "search.bmp")
            '
            'TextBoxSearch
            '
            Me.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
            Me.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TextBoxSearch.Location = New System.Drawing.Point(0, 0)
            Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(0)
            Me.TextBoxSearch.Name = "TextBoxSearch"
            Me.TextBoxSearch.Size = New System.Drawing.Size(188, 21)
            Me.TextBoxSearch.TabIndex = 1
            '
            'PanelMain
            '
            Me.TableLayoutPanelSolution.SetColumnSpan(Me.PanelMain, 2)
            Me.PanelMain.Controls.Add(Me.TV_MODELS)
            Me.PanelMain.Controls.Add(Me.LblModelExplorer)
            Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelMain.Location = New System.Drawing.Point(0, 21)
            Me.PanelMain.Margin = New System.Windows.Forms.Padding(0)
            Me.PanelMain.Name = "PanelMain"
            Me.PanelMain.Size = New System.Drawing.Size(211, 350)
            Me.PanelMain.TabIndex = 2
            '
            'TV_MODELS
            '
            Me.TV_MODELS.AllowDrop = True
            Me.TV_MODELS.BackColor = System.Drawing.SystemColors.Window
            Me.TV_MODELS.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TV_MODELS.ContextMenuStrip = Me.CMS_TV_MODELS
            Me.TV_MODELS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TV_MODELS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TV_MODELS.FullRowSelect = True
            Me.TV_MODELS.HideSelection = False
            Me.TV_MODELS.ImageIndex = 0
            Me.TV_MODELS.ImageList = Me.IL_TV_MODELS
            Me.TV_MODELS.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.TV_MODELS.Location = New System.Drawing.Point(0, 22)
            Me.TV_MODELS.Margin = New System.Windows.Forms.Padding(0)
            Me.TV_MODELS.Name = "TV_MODELS"
            Me.TV_MODELS.SelectedImageIndex = 1
            Me.TV_MODELS.ShowLines = False
            Me.TV_MODELS.Size = New System.Drawing.Size(211, 328)
            Me.TV_MODELS.TabIndex = 3
            '
            'CMS_TV_MODELS
            '
            Me.CMS_TV_MODELS.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_TV_MODELS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_TV_MODELS_CREATEFOLDER, Me.CMS_TV_MODELS_DELETEFOLDER, Me.CMS_TV_MODELS_RENAMEFOLDER, Me.ToolStripMenuItem2, Me.CMS_TV_MODELS_CREATEMODEL, Me.CMS_TV_MODELS_DELETEMODEL, Me.ToolStripMenuItem3, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripMenuItem1, Me.CMS_TV_MODELS_REFRESH})
            Me.CMS_TV_MODELS.Name = "CMSTreeView"
            Me.CMS_TV_MODELS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.CMS_TV_MODELS.Size = New System.Drawing.Size(175, 198)
            '
            'CMS_TV_MODELS_CREATEFOLDER
            '
            Me.CMS_TV_MODELS_CREATEFOLDER.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CMS_TV_MODELS_CREATEFOLDER.Name = "CMS_TV_MODELS_CREATEFOLDER"
            Me.CMS_TV_MODELS_CREATEFOLDER.Size = New System.Drawing.Size(174, 22)
            Me.CMS_TV_MODELS_CREATEFOLDER.Text = "Create New Folder"
            '
            'CMS_TV_MODELS_DELETEFOLDER
            '
            Me.CMS_TV_MODELS_DELETEFOLDER.Name = "CMS_TV_MODELS_DELETEFOLDER"
            Me.CMS_TV_MODELS_DELETEFOLDER.Size = New System.Drawing.Size(174, 22)
            Me.CMS_TV_MODELS_DELETEFOLDER.Text = "Delete Folder"
            '
            'CMS_TV_MODELS_RENAMEFOLDER
            '
            Me.CMS_TV_MODELS_RENAMEFOLDER.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CMS_TV_MODELS_RENAMEFOLDER.Name = "CMS_TV_MODELS_RENAMEFOLDER"
            Me.CMS_TV_MODELS_RENAMEFOLDER.Size = New System.Drawing.Size(174, 22)
            Me.CMS_TV_MODELS_RENAMEFOLDER.Text = "Rename Folder"
            '
            'ToolStripMenuItem2
            '
            Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
            Me.ToolStripMenuItem2.Size = New System.Drawing.Size(171, 6)
            '
            'CMS_TV_MODELS_CREATEMODEL
            '
            Me.CMS_TV_MODELS_CREATEMODEL.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CMS_TV_MODELS_CREATEMODEL.Name = "CMS_TV_MODELS_CREATEMODEL"
            Me.CMS_TV_MODELS_CREATEMODEL.Size = New System.Drawing.Size(174, 22)
            Me.CMS_TV_MODELS_CREATEMODEL.Text = "Create New Model"
            '
            'CMS_TV_MODELS_DELETEMODEL
            '
            Me.CMS_TV_MODELS_DELETEMODEL.Name = "CMS_TV_MODELS_DELETEMODEL"
            Me.CMS_TV_MODELS_DELETEMODEL.Size = New System.Drawing.Size(174, 22)
            Me.CMS_TV_MODELS_DELETEMODEL.Text = "Delete Model"
            '
            'ToolStripMenuItem3
            '
            Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
            Me.ToolStripMenuItem3.Size = New System.Drawing.Size(171, 6)
            '
            'CopyToolStripMenuItem
            '
            Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
            Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
            Me.CopyToolStripMenuItem.Text = "Copy"
            '
            'PasteToolStripMenuItem
            '
            Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
            Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
            Me.PasteToolStripMenuItem.Text = "Paste"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(171, 6)
            '
            'CMS_TV_MODELS_REFRESH
            '
            Me.CMS_TV_MODELS_REFRESH.Name = "CMS_TV_MODELS_REFRESH"
            Me.CMS_TV_MODELS_REFRESH.Size = New System.Drawing.Size(174, 22)
            Me.CMS_TV_MODELS_REFRESH.Text = "Refresh"
            '
            'IL_TV_MODELS
            '
            Me.IL_TV_MODELS.ImageStream = CType(resources.GetObject("IL_TV_MODELS.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.IL_TV_MODELS.TransparentColor = System.Drawing.Color.Magenta
            Me.IL_TV_MODELS.Images.SetKeyName(0, "Folder_6222.png")
            Me.IL_TV_MODELS.Images.SetKeyName(1, "Animation_10763.png")
            Me.IL_TV_MODELS.Images.SetKeyName(2, "VBFile_SolutionExplorerNode_24.bmp")
            Me.IL_TV_MODELS.Images.SetKeyName(3, "ScriptFile_452_24.bmp")
            Me.IL_TV_MODELS.Images.SetKeyName(4, "Folder(special)_5843_16x_24.bmp")
            '
            'LblModelExplorer
            '
            Me.LblModelExplorer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LblModelExplorer.Dock = System.Windows.Forms.DockStyle.Top
            Me.LblModelExplorer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblModelExplorer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.LblModelExplorer.Location = New System.Drawing.Point(0, 0)
            Me.LblModelExplorer.Margin = New System.Windows.Forms.Padding(0)
            Me.LblModelExplorer.Name = "LblModelExplorer"
            Me.LblModelExplorer.Size = New System.Drawing.Size(211, 22)
            Me.LblModelExplorer.TabIndex = 999
            Me.LblModelExplorer.Text = "Solution Explorer"
            Me.LblModelExplorer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TP_OBJECTS
            '
            Me.TP_OBJECTS.Controls.Add(Me.TVObjects)
            Me.TP_OBJECTS.Location = New System.Drawing.Point(4, 4)
            Me.TP_OBJECTS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_OBJECTS.Name = "TP_OBJECTS"
            Me.TP_OBJECTS.Size = New System.Drawing.Size(211, 371)
            Me.TP_OBJECTS.TabIndex = 1
            Me.TP_OBJECTS.Text = "OBJECTS"
            Me.TP_OBJECTS.UseVisualStyleBackColor = True
            '
            'TVObjects
            '
            Me.TVObjects.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TVObjects.ContextMenuStrip = Me.CMS_OBJECTS
            Me.TVObjects.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TVObjects.ImageIndex = 0
            Me.TVObjects.ImageList = Me.IL_TV_OBJECTS
            Me.TVObjects.Location = New System.Drawing.Point(0, 0)
            Me.TVObjects.Margin = New System.Windows.Forms.Padding(0)
            Me.TVObjects.Name = "TVObjects"
            TreeNode1.Name = "RACE_INFO_BARRIER"
            TreeNode1.Tag = "RACE_INFO_BARRIER"
            TreeNode1.Text = "RACE_INFO_BARRIER"
            TreeNode2.Name = "ENTRY_INFO_DISTANCE_SCORE"
            TreeNode2.Tag = "ENTRY_INFO_DISTANCE_SCORE"
            TreeNode2.Text = "ENTRY_INFO_DISTANCE_SCORE"
            TreeNode3.Name = "ENTRY_INFO_DISTANCE_THEO_SCORE"
            TreeNode3.Tag = "ENTRY_INFO_DISTANCE_THEO_SCORE"
            TreeNode3.Text = "ENTRY_INFO_DISTANCE_THEO_SCORE"
            TreeNode4.Name = "ENTRY_INFO_DISTANCE_THEO"
            TreeNode4.Tag = "ENTRY_INFO_DISTANCE_THEO"
            TreeNode4.Text = "ENTRY_INFO_DISTANCE_THEO"
            TreeNode5.ImageIndex = 0
            TreeNode5.Name = "ENTRY_INFO_DISTANCE"
            TreeNode5.Tag = "ENTRY_INFO_DISTANCE"
            TreeNode5.Text = "ENTRY_INFO_DISTANCE"
            TreeNode6.Name = "ENTRY_INFO_GROUP_SCORE"
            TreeNode6.Tag = "ENTRY_INFO_GROUP_SCORE"
            TreeNode6.Text = "ENTRY_INFO_GROUP_SCORE"
            TreeNode7.Name = "ENTRY_INFO_GROUP_THEO_SCORE"
            TreeNode7.Tag = "ENTRY_INFO_GROUP_THEO_SCORE"
            TreeNode7.Text = "ENTRY_INFO_GROUP_THEO_SCORE"
            TreeNode8.Name = "ENTRY_INFO_GROUP_THEO"
            TreeNode8.Tag = "ENTRY_INFO_GROUP_THEO"
            TreeNode8.Text = "ENTRY_INFO_GROUP_THEO"
            TreeNode9.Name = "ENTRY_INFO_GROUP"
            TreeNode9.Tag = "ENTRY_INFO_GROUP"
            TreeNode9.Text = "ENTRY_INFO_GROUP"
            TreeNode10.Name = "ENTRY_INFO_OVERALL_SCORE"
            TreeNode10.Tag = "ENTRY_INFO_OVERALL_SCORE"
            TreeNode10.Text = "ENTRY_INFO_OVERALL_SCORE"
            TreeNode11.Name = "ENTRY_INFO_OVERALL_THEO_SCORE"
            TreeNode11.Tag = "ENTRY_INFO_OVERALL_THEO_SCORE"
            TreeNode11.Text = "ENTRY_INFO_OVERALL_THEO_SCORE"
            TreeNode12.Name = "ENTRY_INFO_OVERALL_THEO"
            TreeNode12.Tag = "ENTRY_INFO_OVERALL_THEO"
            TreeNode12.Text = "ENTRY_INFO_OVERALL_THEO"
            TreeNode13.ImageIndex = 0
            TreeNode13.Name = "ENTRY_INFO_OVERALL"
            TreeNode13.Tag = "ENTRY_INFO_OVERALL"
            TreeNode13.Text = "ENTRY_INFO_OVERALL"
            TreeNode14.ImageIndex = 0
            TreeNode14.Name = "ENTRY_INFO"
            TreeNode14.Tag = "ENTRY_INFO"
            TreeNode14.Text = "ENTRY_INFO"
            Me.TVObjects.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode14})
            Me.TVObjects.SelectedImageIndex = 0
            Me.TVObjects.Size = New System.Drawing.Size(211, 371)
            Me.TVObjects.TabIndex = 3
            '
            'CMS_OBJECTS
            '
            Me.CMS_OBJECTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_OBJECTS_COPY})
            Me.CMS_OBJECTS.Name = "CMS_OBJECTS"
            Me.CMS_OBJECTS.Size = New System.Drawing.Size(103, 26)
            '
            'TSMI_OBJECTS_COPY
            '
            Me.TSMI_OBJECTS_COPY.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_OBJECTS_COPY.Name = "TSMI_OBJECTS_COPY"
            Me.TSMI_OBJECTS_COPY.Size = New System.Drawing.Size(102, 22)
            Me.TSMI_OBJECTS_COPY.Text = "Copy"
            '
            'TSB_OPENFILEDIALOG
            '
            Me.TSB_OPENFILEDIALOG.FileName = "*.*"
            Me.TSB_OPENFILEDIALOG.Filter = "All Files|*.*|XML Files|*.xml|Text Files|*.txt"
            Me.TSB_OPENFILEDIALOG.SupportMultiDottedExtensions = True
            '
            'FORM_MODELDEVELOPMENT
            '
            Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.ClientSize = New System.Drawing.Size(777, 446)
            Me.Controls.Add(Me.SC_MAIN)
            Me.Controls.Add(Me.TSM_Main)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FORM_MODELDEVELOPMENT"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "MODEL DEVELOPMENT"
            Me.TSM_Main.ResumeLayout(False)
            Me.TSM_Main.PerformLayout()
            Me.SC_MAIN.Panel1.ResumeLayout(False)
            Me.SC_MAIN.Panel2.ResumeLayout(False)
            CType(Me.SC_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SC_MAIN.ResumeLayout(False)
            Me.CMS_TC_MAIN.ResumeLayout(False)
            Me.TC_SOLUTION.ResumeLayout(False)
            Me.TP_SOLUTIONEXPLORER.ResumeLayout(False)
            Me.TableLayoutPanelSolution.ResumeLayout(False)
            Me.TableLayoutPanelSolution.PerformLayout()
            Me.PanelMain.ResumeLayout(False)
            Me.CMS_TV_MODELS.ResumeLayout(False)
            Me.TP_OBJECTS.ResumeLayout(False)
            Me.CMS_OBJECTS.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents TSM_Main As System.Windows.Forms.ToolStrip
        Private WithEvents TSBNavigateBack As System.Windows.Forms.ToolStripButton
        Private WithEvents TSBNavigateForward As System.Windows.Forms.ToolStripButton
        Private WithEvents TSB_TSS1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSB_OpenFile As System.Windows.Forms.ToolStripButton
        Private WithEvents TSBSave As System.Windows.Forms.ToolStripButton
        Private WithEvents TSBSaveAll As System.Windows.Forms.ToolStripButton
        Private WithEvents TSB_TSS2 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSDDBClose As System.Windows.Forms.ToolStripDropDownButton
        Private WithEvents TSB_TSS3 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSBCommentOut As System.Windows.Forms.ToolStripButton
        Private WithEvents TSBUncomment As System.Windows.Forms.ToolStripButton
        Private WithEvents TSB_TSS4 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSB_TSS5 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSB_STOP As System.Windows.Forms.ToolStripButton
        Private WithEvents SC_MAIN As System.Windows.Forms.SplitContainer
        Private WithEvents LblModelExplorer As System.Windows.Forms.Label
        Private WithEvents TC_SOLUTION As System.Windows.Forms.TabControl
        Private WithEvents TP_SOLUTIONEXPLORER As System.Windows.Forms.TabPage
        Private WithEvents TP_OBJECTS As System.Windows.Forms.TabPage
        Private WithEvents TVObjects As System.Windows.Forms.TreeView
        Private WithEvents IL_TV_MODELS As System.Windows.Forms.ImageList
        Private WithEvents IL_TV_OBJECTS As System.Windows.Forms.ImageList
        Private WithEvents TSB_OPENFILEDIALOG As System.Windows.Forms.OpenFileDialog
        Private WithEvents CMS_TC_MAIN As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CMSTabControl_SaveThis As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMSTabControlDivider As System.Windows.Forms.ToolStripSeparator
        Private WithEvents CMSTabControl_Close As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMSTabControlCloseAll As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMSTabControl_CloseAllButThis As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMS_TV_MODELS As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CMS_TV_MODELS_CREATEFOLDER As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMS_TV_MODELS_DELETEFOLDER As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMS_TV_MODELS_RENAMEFOLDER As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents CMS_TV_MODELS_CREATEMODEL As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMS_TV_MODELS_DELETEMODEL As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents CMS_TV_MODELS_REFRESH As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CMS_OBJECTS As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents TSMI_OBJECTS_COPY As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TSB_Undo As System.Windows.Forms.ToolStripButton
        Friend WithEvents TSB_Redo As System.Windows.Forms.ToolStripButton
        Friend WithEvents TSDDBSTART As System.Windows.Forms.ToolStripDropDownButton
        Friend WithEvents STARTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents STARTITERATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TC_Main As System.Windows.Forms.TabControl
        Friend WithEvents TSB_TSS6 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSB_EXPORTTOFILE As System.Windows.Forms.ToolStripButton
        Private WithEvents TSB_IMPORT As System.Windows.Forms.ToolStripButton
        Friend WithEvents TSB_TSS7 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents TSB_TSS8 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSB_SWITCHMODELOFF As System.Windows.Forms.ToolStripButton
        Private WithEvents TSB_SELECTMODE As System.Windows.Forms.ToolStripButton
        Private WithEvents TSB_SWITCHMODELON As System.Windows.Forms.ToolStripButton
        Friend WithEvents TSB_TSS9 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents TSB_TESTCOMPILE As System.Windows.Forms.ToolStripButton
        Private WithEvents TSBI_LISTLIVE As System.Windows.Forms.ToolStripButton
        Friend WithEvents TableLayoutPanelSolution As System.Windows.Forms.TableLayoutPanel
        Private WithEvents ButtonSearch As System.Windows.Forms.Button
        Friend WithEvents PanelMain As System.Windows.Forms.Panel
        Friend WithEvents TV_MODELS As System.Windows.Forms.TreeView
        Private WithEvents TextBoxSearch As System.Windows.Forms.TextBox

    End Class
End Namespace