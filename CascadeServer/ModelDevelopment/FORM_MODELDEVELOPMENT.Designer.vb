﻿Namespace ModelDevelopment
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
            components = New ComponentModel.Container()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FORM_MODELDEVELOPMENT))
            Dim TreeNode1 As TreeNode = New TreeNode("RACE_INFO_BARRIER")
            Dim TreeNode2 As TreeNode = New TreeNode("ENTRY_INFO_DISTANCE_SCORE")
            Dim TreeNode3 As TreeNode = New TreeNode("ENTRY_INFO_DISTANCE_THEO_SCORE")
            Dim TreeNode4 As TreeNode = New TreeNode("ENTRY_INFO_DISTANCE_THEO", New TreeNode() {TreeNode3})
            Dim TreeNode5 As TreeNode = New TreeNode("ENTRY_INFO_DISTANCE", New TreeNode() {TreeNode2, TreeNode4})
            Dim TreeNode6 As TreeNode = New TreeNode("ENTRY_INFO_GROUP_SCORE")
            Dim TreeNode7 As TreeNode = New TreeNode("ENTRY_INFO_GROUP_THEO_SCORE")
            Dim TreeNode8 As TreeNode = New TreeNode("ENTRY_INFO_GROUP_THEO", New TreeNode() {TreeNode7})
            Dim TreeNode9 As TreeNode = New TreeNode("ENTRY_INFO_GROUP", New TreeNode() {TreeNode6, TreeNode8})
            Dim TreeNode10 As TreeNode = New TreeNode("ENTRY_INFO_OVERALL_SCORE")
            Dim TreeNode11 As TreeNode = New TreeNode("ENTRY_INFO_OVERALL_THEO_SCORE")
            Dim TreeNode12 As TreeNode = New TreeNode("ENTRY_INFO_OVERALL_THEO", New TreeNode() {TreeNode11})
            Dim TreeNode13 As TreeNode = New TreeNode("ENTRY_INFO_OVERALL", New TreeNode() {TreeNode10, TreeNode12})
            Dim TreeNode14 As TreeNode = New TreeNode("ENTRY_INFO", New TreeNode() {TreeNode5, TreeNode9, TreeNode13})
            ToolStripMenu = New ToolStrip()
            TSBNavigateBack = New ToolStripButton()
            TSBNavigateForward = New ToolStripButton()
            TSB_TSS1 = New ToolStripSeparator()
            TSB_OpenFile = New ToolStripButton()
            TSBSave = New ToolStripButton()
            TSBSaveAll = New ToolStripButton()
            TSB_TSS2 = New ToolStripSeparator()
            TSDDBClose = New ToolStripDropDownButton()
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
            TSB_SELECTMODE = New ToolStripButton()
            TSB_TSS7 = New ToolStripSeparator()
            TSB_EXPORTTOFILE = New ToolStripButton()
            TSB_IMPORT = New ToolStripButton()
            TSB_TSS8 = New ToolStripSeparator()
            TSB_SWITCHMODELOFF = New ToolStripButton()
            TSB_SWITCHMODELON = New ToolStripButton()
            TSB_TSS9 = New ToolStripSeparator()
            TSB_TESTCOMPILE = New ToolStripButton()
            TSBI_LISTLIVE = New ToolStripButton()
            TC_Main = New TabControl()
            CMS_TC_MAIN = New ContextMenuStrip(components)
            CMSTabControl_SaveThis = New ToolStripMenuItem()
            CMSTabControlDivider = New ToolStripSeparator()
            CMSTabControl_Close = New ToolStripMenuItem()
            CMSTabControlCloseAll = New ToolStripMenuItem()
            CMSTabControl_CloseAllButThis = New ToolStripMenuItem()
            IL_TV_OBJECTS = New ImageList(components)
            TextBoxSearch = New TextBox()
            CMS_TV_MODELS = New ContextMenuStrip(components)
            CMS_TV_MODELS_CREATEFOLDER = New ToolStripMenuItem()
            CMS_TV_MODELS_DELETEFOLDER = New ToolStripMenuItem()
            CMS_TV_MODELS_RENAMEFOLDER = New ToolStripMenuItem()
            ToolStripMenuItem2 = New ToolStripSeparator()
            CMS_TV_MODELS_CREATEMODEL = New ToolStripMenuItem()
            CMS_TV_MODELS_DELETEMODEL = New ToolStripMenuItem()
            ToolStripMenuItem3 = New ToolStripSeparator()
            CopyToolStripMenuItem = New ToolStripMenuItem()
            PasteToolStripMenuItem = New ToolStripMenuItem()
            ToolStripMenuItem1 = New ToolStripSeparator()
            CMS_TV_MODELS_REFRESH = New ToolStripMenuItem()
            IL_TV_MODELS = New ImageList(components)
            LblModelExplorer = New Label()
            CMS_OBJECTS = New ContextMenuStrip(components)
            TSMI_OBJECTS_COPY = New ToolStripMenuItem()
            TSB_OPENFILEDIALOG = New OpenFileDialog()
            TableLayoutPanelMain = New TableLayoutPanel()
            SplitContainerMain = New SplitContainer()
            TableLayoutPanelExplorer = New TableLayoutPanel()
            TC_SOLUTION = New TabControl()
            TP_SOLUTIONEXPLORER = New TabPage()
            TableLayoutPanelSolution = New TableLayoutPanel()
            PanelMain = New Panel()
            TV_MODELS = New TreeView()
            TP_OBJECTS = New TabPage()
            TVObjects = New TreeView()
            TableLayoutPanelSearch = New TableLayoutPanel()
            ButtonSearch = New Button()
            ToolStripMenu.SuspendLayout()
            CMS_TC_MAIN.SuspendLayout()
            CMS_TV_MODELS.SuspendLayout()
            CMS_OBJECTS.SuspendLayout()
            TableLayoutPanelMain.SuspendLayout()
            CType(SplitContainerMain, ComponentModel.ISupportInitialize).BeginInit()
            SplitContainerMain.Panel1.SuspendLayout()
            SplitContainerMain.Panel2.SuspendLayout()
            SplitContainerMain.SuspendLayout()
            TableLayoutPanelExplorer.SuspendLayout()
            TC_SOLUTION.SuspendLayout()
            TP_SOLUTIONEXPLORER.SuspendLayout()
            TableLayoutPanelSolution.SuspendLayout()
            PanelMain.SuspendLayout()
            TP_OBJECTS.SuspendLayout()
            TableLayoutPanelSearch.SuspendLayout()
            SuspendLayout()
            ' 
            ' ToolStripMenu
            ' 
            ToolStripMenu.AccessibleRole = AccessibleRole.ToolBar
            TableLayoutPanelMain.SetColumnSpan(ToolStripMenu, 2)
            ToolStripMenu.Font = New Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point)
            ToolStripMenu.ImageScalingSize = New Size(40, 40)
            ToolStripMenu.Items.AddRange(New ToolStripItem() {TSBNavigateBack, TSBNavigateForward, TSB_TSS1, TSB_OpenFile, TSBSave, TSBSaveAll, TSB_TSS2, TSDDBClose, TSB_TSS3, TSBCommentOut, TSBUncomment, TSB_TSS4, TSB_Undo, TSB_Redo, TSB_TSS5, TSDDBSTART, TSB_STOP, TSB_TSS6, TSB_SELECTMODE, TSB_TSS7, TSB_EXPORTTOFILE, TSB_IMPORT, TSB_TSS8, TSB_SWITCHMODELOFF, TSB_SWITCHMODELON, TSB_TSS9, TSB_TESTCOMPILE, TSBI_LISTLIVE})
            ToolStripMenu.Location = New Point(0, 0)
            ToolStripMenu.Name = "ToolStripMenu"
            ToolStripMenu.Padding = New Padding(0)
            ToolStripMenu.RenderMode = ToolStripRenderMode.Professional
            ToolStripMenu.Size = New Size(2270, 51)
            ToolStripMenu.TabIndex = 2
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
            ' TSBSave
            ' 
            TSBSave.DisplayStyle = ToolStripItemDisplayStyle.Image
            TSBSave.Enabled = False
            TSBSave.Image = CType(resources.GetObject("TSBSave.Image"), Image)
            TSBSave.ImageTransparentColor = Color.Magenta
            TSBSave.Name = "TSBSave"
            TSBSave.Size = New Size(58, 44)
            TSBSave.Text = "Save"
            ' 
            ' TSBSaveAll
            ' 
            TSBSaveAll.DisplayStyle = ToolStripItemDisplayStyle.Image
            TSBSaveAll.Enabled = False
            TSBSaveAll.Image = CType(resources.GetObject("TSBSaveAll.Image"), Image)
            TSBSaveAll.ImageTransparentColor = Color.Magenta
            TSBSaveAll.Name = "TSBSaveAll"
            TSBSaveAll.Size = New Size(58, 44)
            TSBSaveAll.Text = "Save All"
            ' 
            ' TSB_TSS2
            ' 
            TSB_TSS2.Name = "TSB_TSS2"
            TSB_TSS2.Size = New Size(6, 51)
            ' 
            ' TSDDBClose
            ' 
            TSDDBClose.DisplayStyle = ToolStripItemDisplayStyle.Image
            TSDDBClose.Enabled = False
            TSDDBClose.ImageTransparentColor = Color.Magenta
            TSDDBClose.Name = "TSDDBClose"
            TSDDBClose.Size = New Size(26, 44)
            TSDDBClose.Text = "Close"
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
            ' TSB_SELECTMODE
            ' 
            TSB_SELECTMODE.DisplayStyle = ToolStripItemDisplayStyle.Image
            TSB_SELECTMODE.Image = CType(resources.GetObject("TSB_SELECTMODE.Image"), Image)
            TSB_SELECTMODE.ImageTransparentColor = Color.Magenta
            TSB_SELECTMODE.Name = "TSB_SELECTMODE"
            TSB_SELECTMODE.Size = New Size(58, 44)
            TSB_SELECTMODE.Text = "Check boxes ON"
            ' 
            ' TSB_TSS7
            ' 
            TSB_TSS7.Name = "TSB_TSS7"
            TSB_TSS7.Size = New Size(6, 51)
            ' 
            ' TSB_EXPORTTOFILE
            ' 
            TSB_EXPORTTOFILE.DisplayStyle = ToolStripItemDisplayStyle.Image
            TSB_EXPORTTOFILE.Enabled = False
            TSB_EXPORTTOFILE.Image = CType(resources.GetObject("TSB_EXPORTTOFILE.Image"), Image)
            TSB_EXPORTTOFILE.ImageTransparentColor = Color.Magenta
            TSB_EXPORTTOFILE.Name = "TSB_EXPORTTOFILE"
            TSB_EXPORTTOFILE.Size = New Size(58, 44)
            TSB_EXPORTTOFILE.Text = "Export To File"
            ' 
            ' TSB_IMPORT
            ' 
            TSB_IMPORT.DisplayStyle = ToolStripItemDisplayStyle.Image
            TSB_IMPORT.Image = CType(resources.GetObject("TSB_IMPORT.Image"), Image)
            TSB_IMPORT.ImageTransparentColor = Color.Magenta
            TSB_IMPORT.Name = "TSB_IMPORT"
            TSB_IMPORT.Size = New Size(58, 44)
            TSB_IMPORT.Text = "Import File"
            ' 
            ' TSB_TSS8
            ' 
            TSB_TSS8.Name = "TSB_TSS8"
            TSB_TSS8.Size = New Size(6, 51)
            ' 
            ' TSB_SWITCHMODELOFF
            ' 
            TSB_SWITCHMODELOFF.DisplayStyle = ToolStripItemDisplayStyle.Image
            TSB_SWITCHMODELOFF.Enabled = False
            TSB_SWITCHMODELOFF.Image = CType(resources.GetObject("TSB_SWITCHMODELOFF.Image"), Image)
            TSB_SWITCHMODELOFF.ImageTransparentColor = Color.Magenta
            TSB_SWITCHMODELOFF.Name = "TSB_SWITCHMODELOFF"
            TSB_SWITCHMODELOFF.Size = New Size(58, 44)
            TSB_SWITCHMODELOFF.Text = "Turn selected models OFF"
            ' 
            ' TSB_SWITCHMODELON
            ' 
            TSB_SWITCHMODELON.DisplayStyle = ToolStripItemDisplayStyle.Image
            TSB_SWITCHMODELON.Enabled = False
            TSB_SWITCHMODELON.Image = CType(resources.GetObject("TSB_SWITCHMODELON.Image"), Image)
            TSB_SWITCHMODELON.ImageTransparentColor = Color.Magenta
            TSB_SWITCHMODELON.Name = "TSB_SWITCHMODELON"
            TSB_SWITCHMODELON.Size = New Size(58, 44)
            TSB_SWITCHMODELON.Text = "Turn selected models ON"
            ' 
            ' TSB_TSS9
            ' 
            TSB_TSS9.Name = "TSB_TSS9"
            TSB_TSS9.Size = New Size(6, 51)
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
            ' TC_Main
            ' 
            TC_Main.Appearance = TabAppearance.FlatButtons
            TC_Main.ContextMenuStrip = CMS_TC_MAIN
            TC_Main.Dock = DockStyle.Fill
            TC_Main.Location = New Point(0, 0)
            TC_Main.Margin = New Padding(0)
            TC_Main.Name = "TC_Main"
            TC_Main.Padding = New Point(0, 0)
            TC_Main.SelectedIndex = 0
            TC_Main.Size = New Size(1589, 737)
            TC_Main.TabIndex = 4
            ' 
            ' CMS_TC_MAIN
            ' 
            CMS_TC_MAIN.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
            CMS_TC_MAIN.ImageScalingSize = New Size(40, 40)
            CMS_TC_MAIN.Items.AddRange(New ToolStripItem() {CMSTabControl_SaveThis, CMSTabControlDivider, CMSTabControl_Close, CMSTabControlCloseAll, CMSTabControl_CloseAllButThis})
            CMS_TC_MAIN.Name = "CMSTabControl"
            CMS_TC_MAIN.RenderMode = ToolStripRenderMode.Professional
            CMS_TC_MAIN.Size = New Size(327, 186)
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
            ' IL_TV_OBJECTS
            ' 
            IL_TV_OBJECTS.ColorDepth = ColorDepth.Depth24Bit
            IL_TV_OBJECTS.ImageStream = CType(resources.GetObject("IL_TV_OBJECTS.ImageStream"), ImageListStreamer)
            IL_TV_OBJECTS.TransparentColor = Color.Magenta
            IL_TV_OBJECTS.Images.SetKeyName(0, "DataTable_8468_24.bmp")
            IL_TV_OBJECTS.Images.SetKeyName(1, "DataView_5947_24.bmp")
            IL_TV_OBJECTS.Images.SetKeyName(2, "search.bmp")
            ' 
            ' TextBoxSearch
            ' 
            TextBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            TextBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextBoxSearch.Dock = DockStyle.Fill
            TextBoxSearch.Location = New Point(0, 0)
            TextBoxSearch.Margin = New Padding(0)
            TextBoxSearch.Name = "TextBoxSearch"
            TextBoxSearch.Size = New Size(643, 51)
            TextBoxSearch.TabIndex = 1
            ' 
            ' CMS_TV_MODELS
            ' 
            CMS_TV_MODELS.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
            CMS_TV_MODELS.ImageScalingSize = New Size(40, 40)
            CMS_TV_MODELS.Items.AddRange(New ToolStripItem() {CMS_TV_MODELS_CREATEFOLDER, CMS_TV_MODELS_DELETEFOLDER, CMS_TV_MODELS_RENAMEFOLDER, ToolStripMenuItem2, CMS_TV_MODELS_CREATEMODEL, CMS_TV_MODELS_DELETEMODEL, ToolStripMenuItem3, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripMenuItem1, CMS_TV_MODELS_REFRESH})
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
            ' CopyToolStripMenuItem
            ' 
            CopyToolStripMenuItem.ImageTransparentColor = Color.Magenta
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
            CopyToolStripMenuItem.Size = New Size(323, 44)
            CopyToolStripMenuItem.Text = "Copy"
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
            ' IL_TV_MODELS
            ' 
            IL_TV_MODELS.ColorDepth = ColorDepth.Depth32Bit
            IL_TV_MODELS.ImageStream = CType(resources.GetObject("IL_TV_MODELS.ImageStream"), ImageListStreamer)
            IL_TV_MODELS.TransparentColor = Color.Magenta
            IL_TV_MODELS.Images.SetKeyName(0, "Folder_6222.png")
            IL_TV_MODELS.Images.SetKeyName(1, "Animation_10763.png")
            IL_TV_MODELS.Images.SetKeyName(2, "VBFile_SolutionExplorerNode_24.bmp")
            IL_TV_MODELS.Images.SetKeyName(3, "ScriptFile_452_24.bmp")
            IL_TV_MODELS.Images.SetKeyName(4, "Folder(special)_5843_16x_24.bmp")
            ' 
            ' LblModelExplorer
            ' 
            LblModelExplorer.BackColor = SystemColors.GradientActiveCaption
            LblModelExplorer.Dock = DockStyle.Fill
            LblModelExplorer.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
            LblModelExplorer.ForeColor = SystemColors.ActiveCaptionText
            LblModelExplorer.Location = New Point(0, 50)
            LblModelExplorer.Margin = New Padding(0)
            LblModelExplorer.Name = "LblModelExplorer"
            LblModelExplorer.Size = New Size(672, 50)
            LblModelExplorer.TabIndex = 999
            LblModelExplorer.Text = "Solution Explorer"
            LblModelExplorer.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' CMS_OBJECTS
            ' 
            CMS_OBJECTS.ImageScalingSize = New Size(40, 40)
            CMS_OBJECTS.Items.AddRange(New ToolStripItem() {TSMI_OBJECTS_COPY})
            CMS_OBJECTS.Name = "CMS_OBJECTS"
            CMS_OBJECTS.Size = New Size(167, 52)
            ' 
            ' TSMI_OBJECTS_COPY
            ' 
            TSMI_OBJECTS_COPY.ImageTransparentColor = Color.Magenta
            TSMI_OBJECTS_COPY.Name = "TSMI_OBJECTS_COPY"
            TSMI_OBJECTS_COPY.Size = New Size(166, 48)
            TSMI_OBJECTS_COPY.Text = "Copy"
            ' 
            ' TSB_OPENFILEDIALOG
            ' 
            TSB_OPENFILEDIALOG.FileName = "*.*"
            TSB_OPENFILEDIALOG.Filter = "All Files|*.*|XML Files|*.xml|Text Files|*.txt"
            TSB_OPENFILEDIALOG.SupportMultiDottedExtensions = True
            ' 
            ' TableLayoutPanelMain
            ' 
            TableLayoutPanelMain.ColumnCount = 2
            TableLayoutPanelMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            TableLayoutPanelMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            TableLayoutPanelMain.Controls.Add(ToolStripMenu, 0, 0)
            TableLayoutPanelMain.Controls.Add(SplitContainerMain, 0, 1)
            TableLayoutPanelMain.Dock = DockStyle.Fill
            TableLayoutPanelMain.Location = New Point(0, 0)
            TableLayoutPanelMain.Margin = New Padding(0)
            TableLayoutPanelMain.Name = "TableLayoutPanelMain"
            TableLayoutPanelMain.RowCount = 3
            TableLayoutPanelMain.RowStyles.Add(New RowStyle(SizeType.Percent, 11.9047623F))
            TableLayoutPanelMain.RowStyles.Add(New RowStyle(SizeType.Percent, 88.09524F))
            TableLayoutPanelMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 39F))
            TableLayoutPanelMain.Size = New Size(2270, 878)
            TableLayoutPanelMain.TabIndex = 4
            ' 
            ' SplitContainerMain
            ' 
            SplitContainerMain.BorderStyle = BorderStyle.FixedSingle
            TableLayoutPanelMain.SetColumnSpan(SplitContainerMain, 2)
            SplitContainerMain.Dock = DockStyle.Fill
            SplitContainerMain.Location = New Point(0, 99)
            SplitContainerMain.Margin = New Padding(0)
            SplitContainerMain.Name = "SplitContainerMain"
            ' 
            ' SplitContainerMain.Panel1
            ' 
            SplitContainerMain.Panel1.Controls.Add(TC_Main)
            ' 
            ' SplitContainerMain.Panel2
            ' 
            SplitContainerMain.Panel2.Controls.Add(TableLayoutPanelExplorer)
            SplitContainerMain.Size = New Size(2270, 739)
            SplitContainerMain.SplitterDistance = 1591
            SplitContainerMain.SplitterWidth = 5
            SplitContainerMain.TabIndex = 3
            ' 
            ' TableLayoutPanelExplorer
            ' 
            TableLayoutPanelExplorer.ColumnCount = 1
            TableLayoutPanelExplorer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
            TableLayoutPanelExplorer.Controls.Add(TC_SOLUTION, 0, 2)
            TableLayoutPanelExplorer.Controls.Add(TableLayoutPanelSearch, 0, 0)
            TableLayoutPanelExplorer.Controls.Add(LblModelExplorer, 0, 1)
            TableLayoutPanelExplorer.Dock = DockStyle.Fill
            TableLayoutPanelExplorer.Location = New Point(0, 0)
            TableLayoutPanelExplorer.Margin = New Padding(0)
            TableLayoutPanelExplorer.Name = "TableLayoutPanelExplorer"
            TableLayoutPanelExplorer.RowCount = 3
            TableLayoutPanelExplorer.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
            TableLayoutPanelExplorer.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
            TableLayoutPanelExplorer.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
            TableLayoutPanelExplorer.Size = New Size(672, 737)
            TableLayoutPanelExplorer.TabIndex = 0
            ' 
            ' TC_SOLUTION
            ' 
            TC_SOLUTION.Alignment = TabAlignment.Bottom
            TC_SOLUTION.Controls.Add(TP_SOLUTIONEXPLORER)
            TC_SOLUTION.Controls.Add(TP_OBJECTS)
            TC_SOLUTION.Dock = DockStyle.Fill
            TC_SOLUTION.Location = New Point(0, 100)
            TC_SOLUTION.Margin = New Padding(0)
            TC_SOLUTION.Name = "TC_SOLUTION"
            TC_SOLUTION.Padding = New Point(0, 0)
            TC_SOLUTION.SelectedIndex = 0
            TC_SOLUTION.Size = New Size(672, 637)
            TC_SOLUTION.TabIndex = 1001
            ' 
            ' TP_SOLUTIONEXPLORER
            ' 
            TP_SOLUTIONEXPLORER.Controls.Add(TableLayoutPanelSolution)
            TP_SOLUTIONEXPLORER.Location = New Point(10, 10)
            TP_SOLUTIONEXPLORER.Margin = New Padding(0)
            TP_SOLUTIONEXPLORER.Name = "TP_SOLUTIONEXPLORER"
            TP_SOLUTIONEXPLORER.Size = New Size(652, 561)
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
            TableLayoutPanelSolution.Size = New Size(652, 561)
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
            PanelMain.Size = New Size(652, 561)
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
            TV_MODELS.ImageIndex = 0
            TV_MODELS.ImageList = IL_TV_MODELS
            TV_MODELS.LineColor = Color.FromArgb(CByte(0), CByte(102), CByte(204))
            TV_MODELS.Location = New Point(0, 0)
            TV_MODELS.Margin = New Padding(0)
            TV_MODELS.Name = "TV_MODELS"
            TV_MODELS.SelectedImageIndex = 1
            TV_MODELS.ShowLines = False
            TV_MODELS.Size = New Size(652, 561)
            TV_MODELS.TabIndex = 3
            ' 
            ' TP_OBJECTS
            ' 
            TP_OBJECTS.Controls.Add(TVObjects)
            TP_OBJECTS.Location = New Point(10, 10)
            TP_OBJECTS.Margin = New Padding(0)
            TP_OBJECTS.Name = "TP_OBJECTS"
            TP_OBJECTS.Size = New Size(652, 565)
            TP_OBJECTS.TabIndex = 1
            TP_OBJECTS.Text = "OBJECTS"
            TP_OBJECTS.UseVisualStyleBackColor = True
            ' 
            ' TVObjects
            ' 
            TVObjects.BorderStyle = BorderStyle.None
            TVObjects.ContextMenuStrip = CMS_OBJECTS
            TVObjects.Dock = DockStyle.Fill
            TVObjects.ImageIndex = 0
            TVObjects.ImageList = IL_TV_OBJECTS
            TVObjects.Location = New Point(0, 0)
            TVObjects.Margin = New Padding(0)
            TVObjects.Name = "TVObjects"
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
            TVObjects.Nodes.AddRange(New TreeNode() {TreeNode1, TreeNode14})
            TVObjects.SelectedImageIndex = 0
            TVObjects.Size = New Size(652, 565)
            TVObjects.TabIndex = 3
            ' 
            ' TableLayoutPanelSearch
            ' 
            TableLayoutPanelSearch.ColumnCount = 2
            TableLayoutPanelSearch.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
            TableLayoutPanelSearch.ColumnStyles.Add(New ColumnStyle())
            TableLayoutPanelSearch.Controls.Add(TextBoxSearch, 0, 0)
            TableLayoutPanelSearch.Controls.Add(ButtonSearch, 1, 0)
            TableLayoutPanelSearch.Dock = DockStyle.Fill
            TableLayoutPanelSearch.Location = New Point(0, 0)
            TableLayoutPanelSearch.Margin = New Padding(0)
            TableLayoutPanelSearch.Name = "TableLayoutPanelSearch"
            TableLayoutPanelSearch.RowCount = 1
            TableLayoutPanelSearch.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
            TableLayoutPanelSearch.Size = New Size(672, 50)
            TableLayoutPanelSearch.TabIndex = 4
            ' 
            ' ButtonSearch
            ' 
            ButtonSearch.FlatStyle = FlatStyle.Flat
            ButtonSearch.ImageIndex = 2
            ButtonSearch.ImageList = IL_TV_OBJECTS
            ButtonSearch.Location = New Point(644, 1)
            ButtonSearch.Margin = New Padding(1)
            ButtonSearch.Name = "ButtonSearch"
            ButtonSearch.Size = New Size(27, 26)
            ButtonSearch.TabIndex = 3
            ButtonSearch.UseVisualStyleBackColor = True
            ' 
            ' FORM_MODELDEVELOPMENT
            ' 
            AccessibleRole = AccessibleRole.Window
            AutoScaleDimensions = New SizeF(18F, 45F)
            AutoScaleMode = AutoScaleMode.Font
            AutoSize = True
            AutoSizeMode = AutoSizeMode.GrowAndShrink
            BackColor = SystemColors.Window
            ClientSize = New Size(2270, 878)
            Controls.Add(TableLayoutPanelMain)
            DoubleBuffered = True
            Font = New Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point)
            ForeColor = SystemColors.WindowText
            Icon = CType(resources.GetObject("$this.Icon"), Icon)
            Margin = New Padding(4)
            MaximizeBox = False
            MinimizeBox = False
            Name = "FORM_MODELDEVELOPMENT"
            SizeGripStyle = SizeGripStyle.Show
            StartPosition = FormStartPosition.CenterParent
            Text = "MODEL DEVELOPMENT"
            WindowState = FormWindowState.Maximized
            ToolStripMenu.ResumeLayout(False)
            ToolStripMenu.PerformLayout()
            CMS_TC_MAIN.ResumeLayout(False)
            CMS_TV_MODELS.ResumeLayout(False)
            CMS_OBJECTS.ResumeLayout(False)
            TableLayoutPanelMain.ResumeLayout(False)
            TableLayoutPanelMain.PerformLayout()
            SplitContainerMain.Panel1.ResumeLayout(False)
            SplitContainerMain.Panel2.ResumeLayout(False)
            CType(SplitContainerMain, ComponentModel.ISupportInitialize).EndInit()
            SplitContainerMain.ResumeLayout(False)
            TableLayoutPanelExplorer.ResumeLayout(False)
            TC_SOLUTION.ResumeLayout(False)
            TP_SOLUTIONEXPLORER.ResumeLayout(False)
            TableLayoutPanelSolution.ResumeLayout(False)
            PanelMain.ResumeLayout(False)
            TP_OBJECTS.ResumeLayout(False)
            TableLayoutPanelSearch.ResumeLayout(False)
            TableLayoutPanelSearch.PerformLayout()
            ResumeLayout(False)
        End Sub
        Private WithEvents ToolStripMenu As ToolStrip
        Private WithEvents TSBNavigateBack As ToolStripButton
        Private WithEvents TSBNavigateForward As ToolStripButton
        Private WithEvents TSB_TSS1 As ToolStripSeparator
        Private WithEvents TSB_OpenFile As ToolStripButton
        Private WithEvents TSBSave As ToolStripButton
        Private WithEvents TSBSaveAll As ToolStripButton
        Private WithEvents TSB_TSS2 As ToolStripSeparator
        Private WithEvents TSDDBClose As ToolStripDropDownButton
        Private WithEvents TSB_TSS3 As ToolStripSeparator
        Private WithEvents TSBCommentOut As ToolStripButton
        Private WithEvents TSBUncomment As ToolStripButton
        Private WithEvents TSB_TSS4 As ToolStripSeparator
        Private WithEvents TSB_TSS5 As ToolStripSeparator
        Private WithEvents TSB_STOP As ToolStripButton
        Private WithEvents LblModelExplorer As Label
        Private WithEvents IL_TV_MODELS As ImageList
        Private WithEvents IL_TV_OBJECTS As ImageList
        Private WithEvents TSB_OPENFILEDIALOG As OpenFileDialog
        Private WithEvents CMS_TC_MAIN As ContextMenuStrip
        Private WithEvents CMSTabControl_SaveThis As ToolStripMenuItem
        Private WithEvents CMSTabControlDivider As ToolStripSeparator
        Private WithEvents CMSTabControl_Close As ToolStripMenuItem
        Private WithEvents CMSTabControlCloseAll As ToolStripMenuItem
        Private WithEvents CMSTabControl_CloseAllButThis As ToolStripMenuItem
        Private WithEvents CMS_TV_MODELS As ContextMenuStrip
        Private WithEvents CMS_TV_MODELS_CREATEFOLDER As ToolStripMenuItem
        Private WithEvents CMS_TV_MODELS_DELETEFOLDER As ToolStripMenuItem
        Private WithEvents CMS_TV_MODELS_RENAMEFOLDER As ToolStripMenuItem
        Private WithEvents ToolStripMenuItem2 As ToolStripSeparator
        Private WithEvents CMS_TV_MODELS_CREATEMODEL As ToolStripMenuItem
        Private WithEvents CMS_TV_MODELS_DELETEMODEL As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
        Friend WithEvents CMS_TV_MODELS_REFRESH As ToolStripMenuItem
        Friend WithEvents CMS_OBJECTS As ContextMenuStrip
        Friend WithEvents TSMI_OBJECTS_COPY As ToolStripMenuItem
        Friend WithEvents TSB_Undo As ToolStripButton
        Friend WithEvents TSB_Redo As ToolStripButton
        Friend WithEvents TSDDBSTART As ToolStripDropDownButton
        Friend WithEvents STARTToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents STARTITERATIONToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
        Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents TC_Main As TabControl
        Friend WithEvents TSB_TSS6 As ToolStripSeparator
        Private WithEvents TSB_EXPORTTOFILE As ToolStripButton
        Private WithEvents TSB_IMPORT As ToolStripButton
        Friend WithEvents TSB_TSS7 As ToolStripSeparator
        Friend WithEvents TSB_TSS8 As ToolStripSeparator
        Private WithEvents TSB_SWITCHMODELOFF As ToolStripButton
        Private WithEvents TSB_SELECTMODE As ToolStripButton
        Private WithEvents TSB_SWITCHMODELON As ToolStripButton
        Friend WithEvents TSB_TSS9 As ToolStripSeparator
        Friend WithEvents TSB_TESTCOMPILE As ToolStripButton
        Private WithEvents TSBI_LISTLIVE As ToolStripButton
        Private WithEvents TextBoxSearch As TextBox
        Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
        Private WithEvents SplitContainerMain As SplitContainer
        Friend WithEvents TableLayoutPanelExplorer As TableLayoutPanel
        Friend WithEvents TableLayoutPanelSearch As TableLayoutPanel
        Private WithEvents ButtonSearch As Button
        Private WithEvents TC_SOLUTION As TabControl
        Private WithEvents TP_SOLUTIONEXPLORER As TabPage
        Friend WithEvents TableLayoutPanelSolution As TableLayoutPanel
        Friend WithEvents PanelMain As Panel
        Friend WithEvents TV_MODELS As TreeView
        Private WithEvents TP_OBJECTS As TabPage
        Private WithEvents TVObjects As TreeView
    End Class
End Namespace