' Added just for readablity sake, the main class gets confusing to read with all the UI elements.
Namespace ModelDevelopment
    Partial Class FORM_MODELDEVELOPMENT
        Private Sub TC_Main_ControlAdded(sender As Object, e As ControlEventArgs) Handles TC_Main.ControlAdded
            ' No need to change the cursor, this method is called from another method that adds a tabpage
            If Me.TC_Main.TabPages.Count > 0 Then
                Call TSB_Enable_Base_Buttons()
            Else
                Call TSB_DisableButtons()
                Me.TV_MODELS.SelectedNode = Me.TV_MODELS.Nodes(0)
            End If
            '
            If Me.TC_Main.TabCount > 1 Then
                Me.TSBNavigateBack.Enabled = True
                Me.TSBNavigateForward.Enabled = True
            Else
                Me.TSBNavigateBack.Enabled = False
                Me.TSBNavigateForward.Enabled = False
            End If
        End Sub
        Private Sub TC_Main_ControlRemoved(sender As Object, e As ControlEventArgs) Handles TC_Main.ControlRemoved
            ' No need to change the cursor, this method is called from another method that removes a tabpage
            If Me.TC_Main.TabPages.Count > 1 Then
                Call TSB_Enable_Base_Buttons()
            Else
                Call TSB_DisableButtons()
                Me.TV_MODELS.SelectedNode = Me.TV_MODELS.Nodes(0)
            End If
            '
            If Me.TC_Main.TabCount > 1 Then
                Me.TSBNavigateBack.Enabled = True
                Me.TSBNavigateForward.Enabled = True
            Else
                Me.TSBNavigateBack.Enabled = False
                Me.TSBNavigateForward.Enabled = False
            End If
        End Sub
        Private Sub TC_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TC_Main.SelectedIndexChanged
            ' Find the ModelID in the tree and select it.
            If Me.TC_Main.SelectedTab Is Nothing Then Return ' There may be no tabpages to select.
            If Me.TC_Main.SelectedTab.Tag Is Nothing Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            For Each TVMain_TreeNode As TreeNode In Me.TV_MODELS.Nodes
                Dim Nodes() As TreeNode = TVMain_TreeNode.Nodes.Find(CStr(Me.TC_Main.SelectedTab.Tag), True)
                If Nodes.Count > 0 Then
                    Me.TV_MODELS.SelectedNode = Nodes(0)
                End If
            Next TVMain_TreeNode
            '
            If CType(Me.TV_MODELS.SelectedNode.Tag, Utils.NodeTypes) = Utils.NodeTypes.Model Then
                Dim TabPage As UserControls.UC_TABPAGE = Me.TC_Main.SelectedTab
                If TabPage.RichTextBoxCode.CanUndo Then Me.TSB_Undo.Enabled = True Else Me.TSB_Undo.Enabled = False
                If TabPage.RichTextBoxCode.CanRedo Then Me.TSB_Redo.Enabled = True Else Me.TSB_Redo.Enabled = False
            End If
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TC_Main_MouseClick(sender As Object, e As MouseEventArgs) Handles TC_Main.MouseClick
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                Me.CMSTabControl_SaveThis.Visible = True
                Me.CMSTabControlDivider.Visible = True
                CMS_TC_MAIN.Show(MousePosition)
            End If
        End Sub
        Private Sub TC_Main_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TC_Main.Selecting
            IsMouseDown = True
            Dim TabPage As UserControls.UC_TABPAGE = e.TabPage
            If TabPage Is Nothing Then IsMouseDown = False : Return
            Dim TreeNode() As TreeNode = Me.TV_MODELS.Nodes.Find(TabPage.Properties.ID, True)
            If TreeNode.Count > 0 Then
                Me.TV_MODELS.SelectedNode = TreeNode(0)
            End If
            IsMouseDown = False
        End Sub
    End Class
End Namespace