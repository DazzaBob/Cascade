' Added just for readablity sake, the main class gets confusing to read with all the UI elements.
' MY_CONNECTION is defined in FORM MODELDEVELOPMENT
Namespace ModelDevelopment
    Partial Class FORM_MODELDEVELOPMENT
        Private MY_TV_MODELS_AFTERCHECK_EVENT As Boolean = True
        Private Sub TV_MODELS_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TV_MODELS.AfterCheck
            If Not MY_TV_MODELS_AFTERCHECK_EVENT Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            MY_TV_MODELS_AFTERCHECK_EVENT = False
            For Each Node As TreeNode In e.Node.Nodes
                Call TV_MODELS_AfterCheck_CheckSubNodes(Node, e.Node.Checked)
            Next Node
            Me.Cursor = Cursors.Default
            MY_TV_MODELS_AFTERCHECK_EVENT = True
        End Sub
        Private Sub TV_MODELS_AfterCheck_CheckSubNodes(ByVal TN As TreeNode, ByVal Checked As Boolean)
            For Each Node As TreeNode In TN.Nodes
                If Node.Nodes.Count > 0 Then Call TV_MODELS_AfterCheck_CheckSubNodes(Node, Checked)
                Node.Checked = Checked
            Next
            TN.Checked = Checked
        End Sub
        Private Sub TV_MODELS_KeyUp(sender As Object, e As KeyEventArgs) Handles TV_MODELS.KeyUp
            Select Case e.KeyCode
                Case Keys.Delete
                    Dim TN As TreeNode = Me.TV_MODELS.SelectedNode
                    Select Case DirectCast(TN.Tag, Utils.NodeTypes)
                        Case Utils.General.NodeTypes.Folder
                            Call CMS_TV_DELETEFOLDER_Click(sender, e)
                            Return
                        Case Utils.General.NodeTypes.BaseFolder
                            MessageBox.Show("This folder is as un-movable system folder!", "Unable to comply.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                            Return
                        Case Utils.General.NodeTypes.Model, Utils.General.NodeTypes.Clone
                            If TN.Nodes.Count > 0 Then
                                MessageBox.Show("This Model has Child/Clone nodes attached to it, delete the Child/Clone Nodes first.", "Unable to comply.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                                Return
                            Else
                                Call CMS_TV_MODELS_DELETEMODEL_Click(sender, e)
                                Me.TV_MODELS.Focus()
                                Return
                            End If
                            Exit Select
                        Case Else
                            MessageBox.Show("This node is unknown, contact the administrator", "Unknown Node Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                    End Select
            End Select
        End Sub
        Private Sub TV_MODELS_MouseMove(sender As Object, e As MouseEventArgs) Handles TV_MODELS.MouseMove
            MY_TVMAIN_CURSOR_POSITION = e.Location
        End Sub
        Private Sub TVMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TV_MODELS.MouseUp
            IsMouseDown = False
        End Sub
        Private Sub TVMain_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles TV_MODELS.ItemDrag
            Dim This_Move_This_Node As TreeNode = CType(e.Item, TreeNode)
            If This_Move_This_Node.Level = 0 Then
                MessageBox.Show("You can not move this NODE!", "Unable to comply", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Return
            End If
            '
            Me.TV_MODELS.DoDragDrop(e.Item, DragDropEffects.Move)
        End Sub
        Private Sub TVMain_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TV_MODELS.DragEnter
            If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        End Sub
        Private Sub TVMain_DragOver(ByVal sender As System.Object, ByVal e As DragEventArgs) Handles TV_MODELS.DragOver
            ' The data present is a treenode, so figure out what kind of node it is first.
            ' If the Node being moved is the same node as target node then short ciruit the method.
            If Not e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then Return
            '
            Dim pt As Point = Me.TV_MODELS.PointToClient(New Point(e.X, e.Y))
            Dim This_TargetNode As TreeNode = Me.TV_MODELS.GetNodeAt(pt)
            Dim This_DropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            '
            If This_TargetNode Is Nothing Then
                e.Effect = DragDropEffects.None
                Return
            Else
                Me.TV_MODELS.SelectedNode = This_TargetNode : This_TargetNode.EnsureVisible()
            End If

            If This_DropNode Is Nothing Then e.Effect = DragDropEffects.None : Return
            If This_TargetNode Is This_DropNode Then e.Effect = DragDropEffects.None : Return
            '

            e.Effect = DragDropEffects.Move
        End Sub
        Private Sub TVMain_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TV_MODELS.DragDrop
            IsMouseDown = False
            If Not e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then Return
            '
            Dim pt As Point = Me.TV_MODELS.PointToClient(New Point(e.X, e.Y))
            Dim This_Target_Drop_Node As TreeNode = Me.TV_MODELS.GetNodeAt(pt)
            Dim This_Move_This_Node As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            '
            If This_Target_Drop_Node Is Nothing Then e.Effect = DragDropEffects.None : Return
            If This_Move_This_Node Is Nothing Then e.Effect = DragDropEffects.None : Return
            If This_Move_This_Node.Level = 0 Then e.Effect = DragDropEffects.None : Return
            If CType(This_Target_Drop_Node.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.Model Then e.Effect = DragDropEffects.None : Return
            If CType(This_Move_This_Node.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.BaseFolder Then e.Effect = DragDropEffects.None : Return
            If This_Move_This_Node Is This_Target_Drop_Node Then e.Effect = DragDropEffects.None : Return
            '
            Me.Cursor = Cursors.WaitCursor
            If (CType(This_Move_This_Node.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.Folder) Then
                ' Move a folder
                If This_Move_This_Node Is This_Target_Drop_Node Then Me.Cursor = Cursors.Default : Return
                '
                This_Move_This_Node.Remove()
                This_Target_Drop_Node.Nodes.Add(This_Move_This_Node)
                This_Move_This_Node.EnsureVisible()
                Me.TV_MODELS.SelectedNode = This_Move_This_Node
                '
                Call Me.TVMain_MoveAllNodes(Me.TV_MODELS.SelectedNode)
            ElseIf (CType(This_Move_This_Node.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.Model) AndAlso (CType(This_Target_Drop_Node.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.Folder OrElse CType(This_Target_Drop_Node.Tag, Utils.General.NodeTypes) = Utils.General.NodeTypes.BaseFolder) Then
                ' Move a model to a folder
                Call MoveModelTreeNode(This_Target_Drop_Node, This_Move_This_Node)
            End If
            '
            Call TVMain_AfterSelect(Me.TV_MODELS, New TreeViewEventArgs(Me.TV_MODELS.SelectedNode))
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TVMain_MoveAllNodes(ByVal TN As TreeNode)
            For Each Node As TreeNode In TN.Nodes
                If Node.Nodes.Count > 0 Then Call TVMain_MoveAllNodes(TN)
                'Call StoredProcedures.ModelExplorer.MoveNode(Node)
            Next
            'Call StoredProcedures.ModelExplorer.MoveNode(TN)
        End Sub
        Private Sub TVMain_MouseDown(sender As Object, e As MouseEventArgs) Handles TV_MODELS.MouseDown
            IsMouseDown = True
        End Sub
        Private Sub MoveModelTreeNode(ByRef TargetNode As TreeNode, ByRef CurrentNode As TreeNode)
            If Me.TC_Main.TabCount > 0 Then
                For Each TP As UserControls.UC_TABPAGE In Me.TC_Main.TabPages
                    If TP.Tag = Nothing Then Continue For
                    If TP.Tag.ToString = CurrentNode.Name Then
                        TP.Properties.PARENTID = CLng(TargetNode.Name)
                        TP.Properties.TREEPATH = TargetNode.FullPath
                        '
                        'Call StoredProcedures.ModelExplorer.UpdateRow(TP)
                    End If
                Next
                '
                IsMouseDown = True
                CurrentNode.Remove()
                TargetNode.Nodes.Add(CurrentNode)
                CurrentNode.EnsureVisible()
                '
                Me.TV_MODELS.SelectedNode = CurrentNode
                IsMouseDown = False
            Else
                CurrentNode.Remove()
                TargetNode.Nodes.Add(CurrentNode)
                'Call StoredProcedures.ModelExplorer.MoveNode(CurrentNode)
            End If
        End Sub
        Private Sub TVMain_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TV_MODELS.AfterLabelEdit
            If e.CancelEdit Then Return
            Me.Cursor = Cursors.WaitCursor
            '
            Select Case CType(e.Node.Tag, Utils.General.NodeTypes)
                Case Utils.General.NodeTypes.Folder
                    'Call StoredProcedures.ModelExplorer.RenameNode(e)
                    Exit Select
            End Select

            Me.TV_MODELS.LabelEdit = False
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TVMain_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_MODELS.AfterSelect
            If IsMouseDown Then
                Return
            End If

            '
            Me.Cursor = Cursors.WaitCursor
            '
            Select Case CType(Me.TV_MODELS.SelectedNode.Tag, Utils.NodeTypes)
                Case Utils.General.NodeTypes.Model, Utils.General.NodeTypes.Clone
                    If Not TVMain_AfterSelect_Select_Model_TabPage(e) Then
                        Call TV_Main_AfterSelect_FindCreateModelTabPage(e)
                    End If
                    Exit Select
                Case Utils.General.NodeTypes.Folder, Utils.General.NodeTypes.BaseFolder
                    Exit Select
            End Select
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Function TVMain_AfterSelect_Select_Model_TabPage(e As TreeViewEventArgs) As Boolean
            TVMain_AfterSelect_Select_Model_TabPage = False
            If TC_Main.TabCount = 0 Then Return False
            '
            For Each TabPage As UserControls.UC_TABPAGE In Me.TC_Main.TabPages
                If CStr(TabPage.Tag) = CStr(e.Node.Name) Then
                    Me.TC_Main.SelectedTab = TabPage : TVMain_AfterSelect_Select_Model_TabPage = True
                    TabPage.Properties.TREEPATH = Me.TV_MODELS.SelectedNode.Parent.FullPath
                    TabPage.Save()
                    Exit For
                End If
            Next TabPage
        End Function
        Private Sub TV_Main_AfterSelect_FindCreateModelTabPage(e As TreeViewEventArgs)
            Dim PageFound As Boolean = False
            IsMouseDown = True
            For Each TabPage As UserControls.UC_TABPAGE In Me.TC_Main.TabPages
                If TabPage.Properties.ID = e.Node.Name Then PageFound = True : Exit For
            Next
            If Not PageFound Then
                Me.TC_Main.TabPages.Add(New UserControls.UC_TABPAGE(CStr(e.Node.Name), Me, Me.Connection))
                Me.TC_Main.SelectedTab = Me.TC_Main.TabPages(Me.TC_Main.TabPages.Count - 1)
            Else
                For Each TabPage As UserControls.UC_TABPAGE In Me.TC_Main.TabPages
                    If TabPage.Properties.ID = e.Node.Name Then Me.TC_Main.SelectedTab = TabPage : Exit For
                Next
            End If
            IsMouseDown = False
        End Sub
    End Class
End Namespace