' Added just for readablity sake, the main class gets confusing to read with all the UI elements.
' MY_CONNECTION is declared in FORM_MODELDEVELOPMNENT
Namespace ModelDevelopment
    Partial Class FORM_MODELDEVELOPMENT
        Private Sub CMS_TV_MODELS_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMS_TV_MODELS.Opening
            Me.CMS_TV_MODELS_CREATEFOLDER.Enabled = False
            Me.CMS_TV_MODELS_DELETEFOLDER.Enabled = False
            Me.CMS_TV_MODELS_RENAMEFOLDER.Enabled = False
            Me.CMS_TV_MODELS_CREATEMODEL.Enabled = False
            Me.CMS_TV_MODELS_DELETEMODEL.Enabled = False
            Me.CopyToolStripMenuItem.Enabled = True
            Me.PasteToolStripMenuItem.Enabled = False
            '
            If Me.TV_MODELS.SelectedNode Is Nothing Then Return
            '
            Me.Cursor = Cursors.AppStarting
            '
            Select Case CType(Me.TV_MODELS.SelectedNode.Tag, Utils.General.NodeTypes)
                Case Utils.General.NodeTypes.Folder, Utils.General.NodeTypes.BaseFolder, Utils.General.NodeTypes.None
                    Me.CMS_TV_MODELS_CREATEMODEL.Enabled = True
                    Me.CMS_TV_MODELS_CREATEFOLDER.Enabled = True
                    If Me.TV_MODELS.SelectedNode.Level <> 0 Then
                        Me.CMS_TV_MODELS_DELETEFOLDER.Enabled = True
                        Me.CMS_TV_MODELS_RENAMEFOLDER.Enabled = True
                        '
                        Me.CMS_TV_MODELS_DELETEMODEL.Enabled = False
                    End If
                    '
                    Exit Select
                Case Utils.General.NodeTypes.Model, Utils.General.NodeTypes.Clone
                    Me.CMS_TV_MODELS_CREATEFOLDER.Enabled = False
                    Me.CMS_TV_MODELS_DELETEFOLDER.Enabled = False
                    Me.CMS_TV_MODELS_RENAMEFOLDER.Enabled = False
                    '
                    Me.CMS_TV_MODELS_CREATEMODEL.Enabled = False
                    Me.CMS_TV_MODELS_DELETEMODEL.Enabled = True
                Case Else

            End Select
            '
            If Not MY_TVMAIN_COPY Is Nothing Then Me.PasteToolStripMenuItem.Enabled = True
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_TV_MODELS_CREATEMODEL_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_CREATEMODEL.Click
            Me.Cursor = Cursors.WaitCursor
            '
            Dim NewNode As New TreeNode
            NewNode.Text = "New Model"
            NewNode.Tag = Utils.General.NodeTypes.Model
            NewNode.ImageIndex = 2
            NewNode.EnsureVisible()
            Me.TV_MODELS.SelectedNode.Nodes.Add(NewNode)
            '
            Dim MODEL_EXPLORER_ID = 0 ' StoredProcedures.ModelExplorer.AddModelNode(NewNode)
            NewNode.Name = CStr(MODEL_EXPLORER_ID)
            IsMouseDown = True  ' so the select treenode returns doing nothing.
            Me.TV_MODELS.SelectedNode = NewNode
            IsMouseDown = False
            '
            Me.TC_Main.TabPages.Add(New UserControls.UC_TABPAGE(MODEL_EXPLORER_ID, Me, Me.Connection))
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_TV_MODELS_DELETEMODEL_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_DELETEMODEL.Click
            If CType(Me.TV_MODELS.SelectedNode.Tag, Utils.NodeTypes) = Utils.General.NodeTypes.Model OrElse CType(Me.TV_MODELS.SelectedNode.Tag, Utils.NodeTypes) = Utils.NodeTypes.Clone Then
                If MessageBox.Show("Are you sure you want to delete this model?.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            Else
                Return
            End If
            '
            Me.Cursor = Cursors.WaitCursor
            'Call StoredProcedures.ModelExplorer.DeleteModel(Me.TV_MODELS.SelectedNode.Name)
            Dim SelectThisNode As TreeNode = Me.TV_MODELS.SelectedNode.Parent
            '
            Me.IsMouseDown = True
            Me.TV_MODELS.Nodes.Remove(Me.TV_MODELS.SelectedNode)
            If Not Me.TC_Main.SelectedTab Is Nothing Then Me.TC_Main.TabPages.Remove(Me.TC_Main.SelectedTab)
            Me.TV_MODELS.SelectedNode = SelectThisNode
            '
            Me.IsMouseDown = False
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_TV_MODELS_REFRESH_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_REFRESH.Click
            Me.Cursor = Cursors.WaitCursor
            Call Populate_TV_Solution()
            If Me.TC_Main.TabCount > 0 Then
                For Each TVMain_TreeNode As TreeNode In Me.TV_MODELS.Nodes
                    Dim Nodes() As TreeNode = TVMain_TreeNode.Nodes.Find(CStr(Me.TC_Main.SelectedTab.Tag), True)
                    If Nodes.Count > 0 Then
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
            '
            Dim NewNode As New TreeNode
            NewNode.Text = "New Folder"
            NewNode.Tag = Utils.General.NodeTypes.Folder
            NewNode.ImageIndex = 0
            NewNode.EnsureVisible()
            Me.TV_MODELS.SelectedNode.Nodes.Add(NewNode)
            '
            Dim MODEL_EXPLORER_ID As Long = 0 'StoredProcedures.ModelExplorer.AddNewFolderNode(NewNode)
            ' Create a new datatable row for the new node.  If we delete it or add a sub node then we have a default node
            NewNode.Name = CStr(MODEL_EXPLORER_ID)
            '
            Me.TV_MODELS.SelectedNode.ImageIndex = 1
            Me.TV_MODELS.LabelEdit = True
            '
            Me.TV_MODELS.SelectedNode = NewNode
            '
            Me.Cursor = Cursors.Default
            '
            NewNode.BeginEdit()
        End Sub
        Private Sub CMS_TV_DELETEFOLDER_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_DELETEFOLDER.Click
            If Me.TV_MODELS.SelectedNode Is Nothing Then Return
            If Me.TV_MODELS.SelectedNode.Level = 0 OrElse (CType(Me.TV_MODELS.SelectedNode.Tag, Utils.NodeTypes) = Utils.General.NodeTypes.BaseFolder) Then MessageBox.Show("This folder is as un-movable system folder!", "Unable to comply.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : Return
            If MessageBox.Show("Are you sure you want to delete this folder?  This will delete all sub folders and models.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            Me.Cursor = Cursors.WaitCursor
            '
            Call TV_SOLUTION_DeletesubNodes(Me.TV_MODELS.SelectedNode)
            '
            Dim ParentNode As TreeNode = Me.TV_MODELS.SelectedNode.Parent
            Me.TV_MODELS.Nodes.Remove(Me.TV_MODELS.SelectedNode)
            Me.TV_MODELS.SelectedNode = ParentNode
            Me.TV_MODELS.SelectedNode.Expand()
            Me.TV_MODELS.Focus()
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TV_SOLUTION_DeletesubNodes(ByVal TreeNode As TreeNode)
            For Each Node As TreeNode In TreeNode.Nodes
                If Node.Nodes.Count > 0 Then Call TV_SOLUTION_DeletesubNodes(Node)
                'Call StoredProcedures.ModelExplorer.DeleteRow(Node.Name)
            Next
            'Call StoredProcedures.ModelExplorer.DeleteRow(TreeNode.Name)
        End Sub
        Private Sub CMS_TV_RENAMEFOLDER_Click(sender As Object, e As EventArgs) Handles CMS_TV_MODELS_RENAMEFOLDER.Click
            If Me.TV_MODELS.SelectedNode Is Nothing Then Return
            If Me.TV_MODELS.SelectedNode.Level = 0 Then Return
            '
            Me.TV_MODELS.LabelEdit = True
            Me.TV_MODELS.SelectedNode.BeginEdit()
        End Sub
        Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
            Dim Node As TreeNode = Me.TV_MODELS.GetNodeAt(MY_TVMAIN_CURSOR_POSITION)
            Me.TV_MODELS.SelectedNode = Node
            If Node Is Nothing Then Return
            MY_TVMAIN_COPY = CType(Node.Clone, TreeNode)
        End Sub
        Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
            Dim Node As TreeNode = Me.TV_MODELS.GetNodeAt(MY_TVMAIN_CURSOR_POSITION)
            If Node Is Nothing Then MessageBox.Show("You can not Paste this here, hover over a node before pasting.", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : Return
            If MY_TVMAIN_COPY.Nodes.Count > 0 Then MessageBox.Show("You can not Paste a node that has child nodes!  Create the structure and clone models.", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : MY_TVMAIN_COPY = Nothing : Return
            If (CType(Node.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.Folder OrElse CType(Node.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.BaseFolder) AndAlso CType(MY_TVMAIN_COPY.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.Folder Then MessageBox.Show("You can not Paste a folder into another folder, create or move the folder instead!", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : MY_TVMAIN_COPY = Nothing : Return
            MY_TVMAIN_COPY = Nothing
        End Sub
    End Class
End Namespace