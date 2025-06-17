Namespace ModelDevelopment
    Partial Class FrmModelDevelopment
        Private Class TreeViewModels : Implements IDisposable
            Private disposedValue As Boolean
            Private ReadOnly _TreeViewModels As TreeView
            Private ReadOnly _Connection As Utils.Connection
            Friend Sub New()
                Me.disposedValue = False
            End Sub
            Friend Sub New(ByRef TVModels As TreeView)
                Me._TreeViewModels = TVModels
            End Sub
            Friend Sub New(ByRef TVModels As TreeView, Connection As Utils.Connection)
                Me._TreeViewModels = TVModels
                Me._Connection = Connection
            End Sub
            Friend Sub Populate()
                Me._TreeViewModels.Sort()
                Me._TreeViewModels.Nodes.Clear()

                Dim TN() As TreeNode
                Call AddSubNode(Nothing, "New Zealand", "1", "New Zealand Models", Utils.General.NodeTypes.BaseFolder, 0, FontStyle.Bold)
                TN = Me._TreeViewModels.Nodes.Find("1", True)

                Call AddSubNode(TN(0), "Greyhounds", "1-GR", "Greyhounds Models", Utils.General.NodeTypes.BaseFolder, 3, FontStyle.Bold)
                Call AddSubNode(TN(0), "Harness", "1-H", "Harness Models", Utils.General.NodeTypes.BaseFolder, 4, FontStyle.Bold)
                Call AddSubNode(TN(0), "Gallops", "1-G", "Gallops Models", Utils.General.NodeTypes.BaseFolder, 2, FontStyle.Bold)

                Call AddSubNode(Nothing, "Austrailia", "3", "Austrailia Models", Utils.General.NodeTypes.BaseFolder, 1, FontStyle.Bold)
                TN = Me._TreeViewModels.Nodes.Find("3", True)

                Call AddSubNode(TN(0), "Greyhounds", "3-GR", "Greyhounds Models", Utils.General.NodeTypes.BaseFolder, 3, FontStyle.Bold)
                Call AddSubNode(TN(0), "Harness", "3-H", "Harness Models", Utils.General.NodeTypes.BaseFolder, 4, FontStyle.Bold)
                Call AddSubNode(TN(0), "Gallops", "3-G", "Gallops Models", Utils.General.NodeTypes.BaseFolder, 2, FontStyle.Bold)

                Call AddSubNode(Nothing, "Master Models", "999", "Master Models", Utils.General.NodeTypes.BaseFolder, 8, FontStyle.Bold)
                Call AddSubNode(Nothing, "Evaluated", "998", "Evaluated Models", Utils.General.NodeTypes.BaseFolder, 7, FontStyle.Bold)
                Call AddSubNode(Nothing, "Imported", "997", "Imported Models", Utils.General.NodeTypes.BaseFolder, 6, FontStyle.Bold)
                Call AddSubNode(Nothing, "Test", "996", "Test", Utils.General.NodeTypes.BaseFolder, 5, FontStyle.Bold)

                Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER ORDER BY PARENT_ID ASC, ID ASC"
                For Each ROW As Data.DataRow In Me._Connection.GetDataTable(CMDTEXT).Select("")
                    Dim Nodes() As TreeNode = Me._TreeViewModels.Nodes.Find(ROW.Item("PARENT_ID").ToString, True)
                    If Nodes.Length > 0 Then
                        Dim SubNodes() As TreeNode = Nodes(0).Nodes.Find(ROW.Item("PARENT_ID").ToString, True)
                        Dim Node As New TreeNode
                        Node.Name = Trim(ROW.Item("ID").ToString)
                        Node.Text = Trim(ROW.Item("NAME").ToString)
                        Node.Tag = CType(ROW.Item("NODE_TYPE"), Utils.NodeTypes)
                        Select Case CType(ROW.Item("NODE_TYPE"), Utils.NodeTypes)
                            Case Utils.General.NodeTypes.Folder
                                Node.ImageIndex = 10
                            Case Utils.General.NodeTypes.Model
                                Node.ImageIndex = 9
                            Case Utils.General.NodeTypes.Clone
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

                Me._TreeViewModels.SelectedNode = Me._TreeViewModels.Nodes(0)
            End Sub
            Private Sub AddSubNode(ByRef TN As TreeNode, Text As String, Name As String, ToolTip As String, Tag As Utils.NodeTypes, ImageIndex As Integer, FontStyle As FontStyle)
                Dim NewTN As New System.Windows.Forms.TreeNode(Text)
                NewTN.Name = Name
                If FontStyle = FontStyle.Bold Then
                    NewTN.NodeFont = New System.Drawing.Font(Me._TreeViewModels.Font.FontFamily, Me._TreeViewModels.Font.Size, System.Drawing.FontStyle.Bold)
                End If
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
                    Me._TreeViewModels.Nodes.Add(NewTN)
                End If
            End Sub
            Friend Shared Sub TV_MODELS_AfterSelect(ByRef TVEventArgs As TreeViewEventArgs)
                TVEventArgs.Node.SelectedImageIndex = TVEventArgs.Node.ImageIndex
            End Sub
            Friend Shared Sub TVMain_AfterLabelEdit(e As NodeLabelEditEventArgs, Connection As Utils.Connection)
                Select Case e.Node.Tag
                    Case Utils.General.NodeTypes.Folder
                        Call StoredProcedures.ModelExplorer.RenameNode(e, Connection)
                        Exit Select
                End Select
            End Sub
            Protected Overridable Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        ' TODO: dispose managed state (managed objects)
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
End Namespace