Partial Class FrmMain
    Friend Class TreeViewModels : Implements IDisposable
        Private disposedValue As Boolean
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared Function ImageList() As ImageList
            Using MyIL As New ImageList
                MyIL.ImageSize = New Size(40, 40)
                MyIL.ColorDepth = ColorDepth.Depth32Bit

                For Each File As String In IO.Directory.GetFiles(Application.StartupPath & "\images")
                    MyIL.Images.Add(Image.FromFile(File), Color.Fuchsia)
                Next File

                Return MyIL
            End Using
        End Function
        Friend Shared Sub Populate(ByRef TreeViewModels As TreeView, Connection As CascadeCommon.Utils.Connection)
            Call TreeViewModels.Sort()
            Call TreeViewModels.Nodes.Clear()

            Dim TN() As TreeNode
            Call AddSubNode(TreeViewModels, Nothing, "New Zealand", "-1", "New Zealand Models", Utils.NodeTypes.BaseFolder, 0, FontStyle.Bold)
            TN = TreeViewModels.Nodes.Find("-1", True)

            Call AddSubNode(TreeViewModels, TN(0), "Greyhounds", "-11", "Greyhounds Models", Utils.NodeTypes.BaseFolder, 3, FontStyle.Bold)
            Call AddSubNode(TreeViewModels, TN(0), "Harness", "-12", "Harness Models", Utils.NodeTypes.BaseFolder, 4, FontStyle.Bold)
            Call AddSubNode(TreeViewModels, TN(0), "Gallops", "-13", "Gallops Models", Utils.NodeTypes.BaseFolder, 2, FontStyle.Bold)

            Call AddSubNode(TreeViewModels, Nothing, "Australia", "-997", "Australia Models", Utils.NodeTypes.BaseFolder, 1, FontStyle.Bold)
            TN = TreeViewModels.Nodes.Find("-997", True)

            Call AddSubNode(TreeViewModels, TN(0), "Greyhounds", "-9971", "Greyhounds Models", Utils.NodeTypes.BaseFolder, 3, FontStyle.Bold)
            Call AddSubNode(TreeViewModels, TN(0), "Harness", "-9972", "Harness Models", Utils.NodeTypes.BaseFolder, 4, FontStyle.Bold)
            Call AddSubNode(TreeViewModels, TN(0), "Gallops", "-9973", "Gallops Models", Utils.NodeTypes.BaseFolder, 2, FontStyle.Bold)

            Call AddSubNode(TreeViewModels, Nothing, "Master Models", "-999", "Master Models", Utils.NodeTypes.BaseFolder, 8, FontStyle.Bold)
            Call AddSubNode(TreeViewModels, Nothing, "Evaluated", "-998", "Evaluated Models", Utils.NodeTypes.BaseFolder, 7, FontStyle.Bold)
            Call AddSubNode(TreeViewModels, Nothing, "Test", "-996", "Test", Utils.NodeTypes.BaseFolder, 5, FontStyle.Bold)

            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER ORDER BY PARENT_ID ASC, ID ASC"

            Using DT As Data.DataTable = Connection.GetDataTable(CMDTEXT)
                For Each ROW As Data.DataRow In DT.Select("")
                    Dim Nodes() As TreeNode = TreeViewModels.Nodes.Find(ROW.Item("PARENT_ID").ToString, True)
                    If Nodes.Length > 0 Then
                        Dim SubNodes() As TreeNode = Nodes(0).Nodes.Find(ROW.Item("PARENT_ID").ToString, True)
                        Dim Node As New TreeNode
                        Node.Name = Trim(ROW.Item("ID").ToString)
                        Node.Text = Trim(ROW.Item("NAME").ToString)
                        Node.Tag = CType(ROW.Item("NODE_TYPE"), Utils.NodeTypes)
                        Select Case CType(ROW.Item("NODE_TYPE"), Utils.NodeTypes)
                            Case Utils.NodeTypes.Folder
                                Node.ImageIndex = 10
                            Case Utils.NodeTypes.Model
                                Node.ImageIndex = 9
                            Case Utils.NodeTypes.Clone
                                Node.ImageIndex = 9
                            Case Else
                        End Select
                        If SubNodes.Length > 0 Then
                            SubNodes(0).Nodes.Add(Node)
                        Else
                            Nodes(0).Nodes.Add(Node)
                        End If
                    End If
                Next ROW
            End Using

            'TreeViewModels.SelectedNode = TreeViewModels.Nodes(0)
        End Sub
        Private Shared Sub AddSubNode(ByRef TreeViewModels As TreeView, ByRef TN As TreeNode, Text As String, Name As String, ToolTip As String, Tag As Utils.NodeTypes, ImageIndex As Integer, FontStyle As FontStyle)
            Dim NewTN = New TreeNode
            If FontStyle = FontStyle.Bold Then
                NewTN.NodeFont = New System.Drawing.Font(TreeViewModels.Font.FontFamily, TreeViewModels.Font.Size, System.Drawing.FontStyle.Bold)
            End If
            NewTN.Name = Name
            NewTN.Text = Text
            NewTN.ToolTipText = ToolTip
            NewTN.Tag = Utils.NodeTypes.BaseFolder
            If ImageIndex >= 0 Then
                NewTN.ImageIndex = ImageIndex
            Else
                NewTN.ImageIndex = Nothing
            End If
            If TN IsNot Nothing Then
                TN.Nodes.Add(NewTN)
            Else
                TreeViewModels.Nodes.Add(NewTN)
            End If
        End Sub
        Friend Shared Sub TV_MODELS_AfterSelect(TVEventArgs As TreeViewEventArgs, ByRef FrmMain As FrmMain)
            TVEventArgs.Node.SelectedImageIndex = TVEventArgs.Node.ImageIndex

            If FrmMain._IsMouseDown Then Return

            FrmMain.Cursor = Cursors.WaitCursor

            If FrmMain.TV_MODELS.SelectedNode.Tag = Utils.NodeTypes.Model OrElse FrmMain.TV_MODELS.SelectedNode.Tag = Utils.NodeTypes.Clone Then
                If Not TVMODELS_AfterSelect_Select_Model_TabPage(TVEventArgs, FrmMain) Then
                    Call TVMODELS_AfterSelect_FindCreateModelTabPage(TVEventArgs, FrmMain)
                End If
            End If

            FrmMain.Cursor = Cursors.Default
        End Sub
        Private Shared Function TVMODELS_AfterSelect_Select_Model_TabPage(e As TreeViewEventArgs, ByRef FrmMain As FrmMain) As Boolean
            If FrmMain.TabControlMain.TabCount = 0 Then Return False

            For Each TabPage As UserControls.UserControlTabPage In FrmMain.TabControlMain.TabPages
                If TabPage.UserControlModel.UCProperties.ID = e.Node.Name Then
                    FrmMain.TabControlMain.SelectedTab = TabPage
                    Return True
                    Exit For
                End If
            Next TabPage

            Return False
        End Function
        Private Shared Sub TVMODELS_AfterSelect_FindCreateModelTabPage(e As TreeViewEventArgs, ByRef FrmMain As FrmMain)
            Dim PageFound As Boolean = False
            FrmMain._IsMouseDown = True
            For Each TabPage As UserControls.UserControlTabPage In FrmMain.TabControlMain.TabPages
                If TabPage.UserControlModel.UCProperties.ID = e.Node.Name Then PageFound = True : Exit For
            Next TabPage

            If Not PageFound Then
                FrmMain.TabControlMain.TabPages.Add(New UserControls.UserControlTabPage(e.Node.Name, FrmMain))
                FrmMain.TabControlMain.SelectedTab = FrmMain.TabControlMain.TabPages(FrmMain.TabControlMain.TabPages.Count - 1)
            Else
                For Each TabPage As UserControls.UserControlTabPage In FrmMain.TabControlMain.TabPages
                    If TabPage.Text = e.Node.Name Then FrmMain.TabControlMain.SelectedTab = TabPage : Exit For
                Next
            End If
            FrmMain._IsMouseDown = False
        End Sub
        Friend Shared Sub TVMODELS_AfterLabelEdit(e As NodeLabelEditEventArgs, Connection As CascadeCommon.Utils.Connection)
            Select Case e.Node.Tag
                Case Utils.NodeTypes.Folder
                    Call StoredProcedures.ModelExplorer.RenameNode(e, Connection)
                    Exit Select
            End Select
        End Sub
        Friend Shared Sub TV_MODELS_KeyUp(sender As Object, e As KeyEventArgs, FrmMain As FrmMain, SelectedNode As TreeNode)
            Select Case e.KeyCode
                Case Keys.Delete
                    Select Case SelectedNode.Tag
                        Case Utils.NodeTypes.Folder
                            Call FrmMain.CMS_TV_DELETEFOLDER_Click(sender, e)
                            Return
                        Case Utils.NodeTypes.BaseFolder
                            MessageBox.Show("This folder is as un-movable system folder!", "Unable to comply.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                            Return
                        Case Utils.NodeTypes.Model, Utils.NodeTypes.Clone
                            If SelectedNode.Nodes.Count > 0 Then
                                MessageBox.Show("This Model has Child/Clone nodes attached to it, delete the Child/Clone Nodes first.", "Unable to comply.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                                Return
                            Else
                                Call FrmMain.CMS_TV_MODELS_DELETEMODEL_Click(sender, e)
                                FrmMain.TV_MODELS.Focus()
                                Return
                            End If
                            Exit Select
                        Case Else
                            MessageBox.Show("This node is unknown, contact the administrator", "Unknown Node Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                    End Select
            End Select
        End Sub
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    '
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                ' TODO: set large fields to null
                disposedValue = True
            End If
        End Sub

        ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
        ' Protected Overrides Sub Finalize()
        '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        '     Dispose(disposing:=False)
        '     MyBase.Finalize()
        ' End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Class
