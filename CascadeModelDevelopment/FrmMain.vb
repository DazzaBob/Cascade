Imports System.ComponentModel
Imports CascadeModelDevelopment.ModelDevelopment
Imports CascadeModelDevelopment.Utils

Public Class FrmMain
    Private _Connection As CascadeCommon.Utils.Connection
    Private _SelectedTreeNode As TreeNode
    Friend _IsMouseDown As Boolean
    Private _CursorPosition As Point
    Private WithEvents OpenFileDial As OpenFileDialog
    Public Sub New()
        InitializeComponent()
        Me.OpenFileDial = New OpenFileDialog
        Me.OpenFileDial.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        Me.TV_MODELS.ImageList = TreeViewModels.ImageList

        Me._Connection = New CascadeCommon.Utils.Connection(My.Settings.ConnectionString)
        Me._SelectedTreeNode = Nothing
        Me._IsMouseDown = False

    End Sub

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call TreeViewModels.Populate(Me.TV_MODELS, Me._Connection)
    End Sub
    Private Sub TVMODELS_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_MODELS.AfterSelect
        Call TreeViewModels.TV_MODELS_AfterSelect(e, Me)
    End Sub
    Private Sub TVMODELS_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TV_MODELS.AfterLabelEdit
        If e.CancelEdit Then Return

        Me.Cursor = Cursors.AppStarting
        Call TreeViewModels.TVMODELS_AfterLabelEdit(e, Me._Connection)
        Me.TV_MODELS.LabelEdit = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub TVMODELS_MouseDown(sender As Object, e As MouseEventArgs) Handles TV_MODELS.MouseDown
        Me._IsMouseDown = True
    End Sub
    Private Sub TVMODELS_MouseMove(sender As Object, e As MouseEventArgs) Handles TV_MODELS.MouseMove
        Me._CursorPosition = e.Location
    End Sub
    Private Sub TVMODELS_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TV_MODELS.MouseUp
        Me._IsMouseDown = False
    End Sub
    Private Sub TVMODELS_KeyUp(sender As Object, e As KeyEventArgs) Handles TV_MODELS.KeyUp
        Call TreeViewModels.TV_MODELS_KeyUp(sender, e, Me, Me.TV_MODELS.SelectedNode)
    End Sub
#Region "    CMS TV MODELS "
    Private Sub CMS_TV_MODELS_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMS_TV_MODELS.Opening
        Me.CMS_TV_MODELS_CREATEFOLDER.Enabled = False
        Me.CMS_TV_MODELS_DELETEFOLDER.Enabled = False
        Me.CMS_TV_MODELS_RENAMEFOLDER.Enabled = False
        Me.CMS_TV_MODELS_CREATEMODEL.Enabled = False
        Me.CMS_TV_MODELS_DELETEMODEL.Enabled = False
        Me.CMS_TV_MODELS_CopyToolStripMenuItem.Enabled = True
        Me.PasteToolStripMenuItem.Enabled = False

        If Me.TV_MODELS.SelectedNode Is Nothing Then Return

        Me.Cursor = Cursors.AppStarting

        Select Case Me.TV_MODELS.SelectedNode.Tag
            Case Utils.NodeTypes.Folder, Utils.NodeTypes.BaseFolder, Utils.NodeTypes.None
                Me.CMS_TV_MODELS_CREATEMODEL.Enabled = True
                Me.CMS_TV_MODELS_CREATEFOLDER.Enabled = True
                If Me.TV_MODELS.SelectedNode.Level <> 0 Then
                    Me.CMS_TV_MODELS_DELETEFOLDER.Enabled = True
                    Me.CMS_TV_MODELS_RENAMEFOLDER.Enabled = True

                    Me.CMS_TV_MODELS_DELETEMODEL.Enabled = False
                End If

                Exit Select
            Case Utils.NodeTypes.Model, Utils.NodeTypes.Clone
                Me.CMS_TV_MODELS_CREATEFOLDER.Enabled = False
                Me.CMS_TV_MODELS_DELETEFOLDER.Enabled = False
                Me.CMS_TV_MODELS_RENAMEFOLDER.Enabled = False

                Me.CMS_TV_MODELS_CREATEMODEL.Enabled = False
                Me.CMS_TV_MODELS_DELETEMODEL.Enabled = True
            Case Else

        End Select

        If Me._SelectedTreeNode IsNot Nothing Then Me.PasteToolStripMenuItem.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CMS_TV_MODELS_CREATEMODEL_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_CREATEMODEL.Click
        Me.Cursor = Cursors.WaitCursor

        Dim NewNode As New TreeNode With {
            .Text = "New Model",
            .Tag = Utils.NodeTypes.Model,
            .ImageIndex = 9
        }
        NewNode.EnsureVisible()
        Me.TV_MODELS.SelectedNode.Nodes.Add(NewNode)

        Dim MODEL_EXPLORER_ID = StoredProcedures.ModelExplorer.AddModelNode(NewNode, Me._Connection)
        NewNode.Name = MODEL_EXPLORER_ID.ToString
        Me._IsMouseDown = True  ' so the select treenode returns doing nothing.
        Me.TV_MODELS.SelectedNode = NewNode
        Me._IsMouseDown = False

        Me.TabControlMain.TabPages.Add(New UserControls.UserControlTabPage(MODEL_EXPLORER_ID, Me))
        'Me.TabControlMain.TabPages.Add(New UserControls.UC__TABPAGES(MODEL_EXPLORER_ID, Me, Me._Connection))

        Me.Cursor = Cursors.Default
    End Sub
    Friend Sub CMS_TV_MODELS_DELETEMODEL_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_DELETEMODEL.Click
        If Me.TV_MODELS.SelectedNode.Tag = Utils.NodeTypes.Model OrElse Me.TV_MODELS.SelectedNode.Tag = Utils.NodeTypes.Clone Then
            If MessageBox.Show("Are you sure you want to delete this model?.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
        Else
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Call StoredProcedures.ModelExplorer.DeleteModel(Me.TV_MODELS.SelectedNode.Name, Me._Connection)
        Dim SelectThisNode As TreeNode = Me.TV_MODELS.SelectedNode.Parent

        Me._IsMouseDown = True
        Me.TV_MODELS.Nodes.Remove(Me.TV_MODELS.SelectedNode)
        If Me.TabControlMain.SelectedTab IsNot Nothing Then Me.TabControlMain.TabPages.Remove(Me.TabControlMain.SelectedTab)
        Me.TV_MODELS.SelectedNode = SelectThisNode

        Me._IsMouseDown = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CMS_TV_MODELS_REFRESH_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_REFRESH.Click
        Me.Cursor = Cursors.WaitCursor

        Call TreeViewModels.Populate(Me.TV_MODELS, Me._Connection)

        If Me.TabControlMain.TabCount > 0 Then
            For Each TVMain_TreeNode As TreeNode In Me.TV_MODELS.Nodes
                Dim Nodes() As TreeNode = TVMain_TreeNode.Nodes.Find(Me.TabControlMain.SelectedTab.Tag.ToString, True)
                If Nodes.Length > 0 Then
                    Me.TV_MODELS.SelectedNode = Nodes(0)
                    Me.TV_MODELS.SelectedNode.EnsureVisible()
                End If
            Next TVMain_TreeNode
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CMS_TV_CREATEFOLDER_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_CREATEFOLDER.Click
        If Me.TV_MODELS.SelectedNode Is Nothing Then Return
        Me.Cursor = Cursors.WaitCursor

        Dim NewNode As New TreeNode With {
            .Text = "New Folder",
            .Tag = Utils.NodeTypes.Folder,
            .ImageIndex = 10
        }
        NewNode.EnsureVisible()
        Me.TV_MODELS.SelectedNode.Nodes.Add(NewNode)

        Dim MODEL_EXPLORER_ID As Long = StoredProcedures.ModelExplorer.AddNewFolderNode(NewNode, Me._Connection)
        ' Create a new datatable row for the new node.  If we delete it or add a sub node then we have a default node
        NewNode.Name = MODEL_EXPLORER_ID.ToString

        Me.TV_MODELS.SelectedNode.ImageIndex = 1
        Me.TV_MODELS.LabelEdit = True
        Me.TV_MODELS.SelectedNode = NewNode

        Me.Cursor = Cursors.Default

        NewNode.BeginEdit()
    End Sub
    Friend Sub CMS_TV_DELETEFOLDER_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_DELETEFOLDER.Click
        If Me.TV_MODELS.SelectedNode Is Nothing Then Return
        If Me.TV_MODELS.SelectedNode.Level = 0 OrElse (Me.TV_MODELS.SelectedNode.Tag = Utils.NodeTypes.BaseFolder) Then MessageBox.Show("This folder is as un-movable system folder!", "Unable to comply.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : Return
        If MessageBox.Show("Are you sure you want to delete this folder?  This will delete all sub folders and models.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
        Me.Cursor = Cursors.WaitCursor

        Call TV_SOLUTION_DeletesubNodes(Me.TV_MODELS.SelectedNode)

        Dim ParentNode As TreeNode = Me.TV_MODELS.SelectedNode.Parent
        Me.TV_MODELS.Nodes.Remove(Me.TV_MODELS.SelectedNode)
        Me.TV_MODELS.SelectedNode = ParentNode
        Me.TV_MODELS.SelectedNode.Expand()
        Me.TV_MODELS.Focus()

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub TV_SOLUTION_DeletesubNodes(TreeNode As TreeNode)
        For Each Node As TreeNode In TreeNode.Nodes
            If Node.Nodes.Count > 0 Then Call TV_SOLUTION_DeletesubNodes(Node)
            Call StoredProcedures.ModelExplorer.DeleteRow(Node.Name, Me._Connection)
        Next

        Call StoredProcedures.ModelExplorer.DeleteRow(TreeNode.Name, Me._Connection)
    End Sub
    Private Sub CMS_TV_RENAMEFOLDER_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_RENAMEFOLDER.Click
        If Me.TV_MODELS.SelectedNode Is Nothing Then Return
        If Me.TV_MODELS.SelectedNode.Level = 0 Then Return
        '
        Me.TV_MODELS.LabelEdit = True
        Me.TV_MODELS.SelectedNode.BeginEdit()
    End Sub
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Node As TreeNode = Me.TV_MODELS.GetNodeAt(Me._CursorPosition)
        Me.TV_MODELS.SelectedNode = Node
        If Node Is Nothing Then Return

        Me._SelectedTreeNode = Node.Clone
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Dim Node As TreeNode = Me.TV_MODELS.GetNodeAt(Me._CursorPosition)
        If Node Is Nothing Then MessageBox.Show("You can not Paste this here, hover over a node before pasting.", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : Return
        If Me._SelectedTreeNode.Nodes.Count > 0 Then
            MessageBox.Show("You can not Paste a node that has child nodes!  Create the structure and clone models.", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            Me._SelectedTreeNode = Nothing
            Return
        End If
        If (Node.Tag = Utils.NodeTypes.Folder OrElse Node.Tag = Utils.NodeTypes.BaseFolder) AndAlso (Me._SelectedTreeNode.Tag = Utils.NodeTypes.Folder) Then
            MessageBox.Show("You can not Paste a folder into another folder, create or move the folder instead!", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            Me._SelectedTreeNode = Nothing
            Return
        End If
        Me._SelectedTreeNode = Nothing
    End Sub
#End Region
#Region "    CMS TabControl "
    Private Sub CMS_TabControlMain_Opening(sender As Object, e As CancelEventArgs) Handles CMS_TabControlMain.Opening
        If Me.TabControlMain.TabPages.Count = 0 Then e.Cancel = True : Return
        If e.Cancel Then Return

        If Me.TabControlMain.SelectedTab Is Nothing Then e.Cancel = True : Return
        Me.CMSTabControl_SaveThis.Text = "Save " & Me.TabControlMain.SelectedTab.Text
        Me.CMSTabControl_CloseAllButThis.Text = "Close all but " & Me.TabControlMain.SelectedTab.Text
        Me.CMSTabControl_Close.Text = "Close " & Me.TabControlMain.SelectedTab.Text
    End Sub

    Private Sub CMSTabControl_Close_Click(sender As Object, e As EventArgs) Handles CMSTabControl_Close.Click
        Me.Cursor = Cursors.WaitCursor
        If Me.TabControlMain.SelectedTab IsNot Nothing Then
            Using TP As UserControls.UserControlTabPage = Me.TabControlMain.SelectedTab
                For Each CNTRL As Control In TP.Controls
                    Try
                        CNTRL.Dispose()
                    Catch ex As Exception

                    End Try
                Next CNTRL
                Me.TabControlMain.TabPages.Remove(TP)
            End Using
            Try
                Me.TabControlMain.SelectedTab.Dispose()
            Catch ex As Exception

            End Try
        End If

        If Me.TabControlMain.TabPages.Count > 0 Then Me.TabControlMain.SelectedTab = Me.TabControlMain.TabPages(0)

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CMSTabControlCloseAll_Click(sender As Object, e As EventArgs) Handles CMSTabControlCloseAll.Click
        Me.Cursor = Cursors.WaitCursor

        If Me.TabControlMain.TabPages.Count > 0 Then
            For Each TP As UserControls.UserControlTabPage In Me.TabControlMain.TabPages
                For Each CNTRL As Control In TP.Controls
                    Try
                        CNTRL.Dispose()
                    Catch ex As Exception

                    End Try
                Next CNTRL
                Me.TabControlMain.TabPages.Remove(TP)
                TP.Dispose()
            Next
        End If
        Me.TV_MODELS.SelectedNode = Me.TV_MODELS.Nodes(0)

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CMSTabControl_CloseAllButThis_Click(sender As Object, e As EventArgs) Handles CMSTabControl_CloseAllButThis.Click
        Me.Cursor = Cursors.WaitCursor

        For Each TP As UserControls.UserControlTabPage In Me.TabControlMain.TabPages
            If TP Is Me.TabControlMain.SelectedTab Then Continue For
            For Each CNTRL As Control In TP.Controls
                CNTRL.Dispose()
            Next CNTRL
            Me.TabControlMain.TabPages.Remove(TP)
            TP.Dispose()
        Next

        Me.Cursor = Cursors.Default
    End Sub
#End Region
    Private Sub TSBNavigateBack_Click(sender As Object, e As EventArgs) Handles TSBNavigateBack.Click
        If Me.TabControlMain.SelectedIndex = 0 Then Return Else Me.TabControlMain.SelectedIndex -= 1
    End Sub
    Private Sub TSBNavigateForward_Click(sender As Object, e As EventArgs) Handles TSBNavigateForward.Click
        If Me.TabControlMain.SelectedIndex = Me.TabControlMain.TabCount - 1 Then Return Else Me.TabControlMain.SelectedIndex += 1
    End Sub
    Private Sub STARTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STARTToolStripMenuItem.Click
        Call ToolStripMenuClass.STARTToolStripMenuItem_Click(Me)
    End Sub
    Private Sub TSBCommentOut_Click(sender As Object, e As EventArgs) Handles TSBCommentOut.Click
        Call ToolStripMenuClass.TSBCommentOut_Click(Me)
    End Sub
    Private Sub TSBUncomment_Click(sender As Object, e As EventArgs) Handles TSBUncomment.Click
        Call ToolStripMenuClass.TSBUncomment_Click(Me)
    End Sub
    Private Sub TSB_Undo_Click(sender As Object, e As EventArgs) Handles TSB_Undo.Click
        Dim TP As UserControls.UserControlTabPage = Me.TabControlMain.SelectedTab
        Call TP.UserControlModel.UCSource.RichTextBoxSource.Undo()
    End Sub
    Private Sub TSB_Redo_Click(sender As Object, e As EventArgs) Handles TSB_Redo.Click
        Dim TP As UserControls.UserControlTabPage = Me.TabControlMain.SelectedTab
        Call TP.UserControlModel.UCSource.RichTextBoxSource.Redo()
    End Sub
    Private Sub TSB_OpenFile_Click(sender As Object, e As EventArgs) Handles TSB_OpenFile.Click
        Call Me.OpenFileDial.ShowDialog(Me)
    End Sub
    Private Sub TSB_OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDial.FileOk
        If e.Cancel Then Return
        Me.Cursor = Cursors.WaitCursor
        Shell(Me.OpenFileDial.FileName, AppWinStyle.NormalFocus, False)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub TSB_TESTCOMPILE_Click(sender As Object, e As EventArgs) Handles TSB_TESTCOMPILE.Click
        Call ToolStripMenuClass.TSB_TESTCOMPILE_Click(Me, Me._Connection)
    End Sub
End Class