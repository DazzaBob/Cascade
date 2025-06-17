' MY_CONNECTION is defined in FORM MODELDEVELOPMENT
Namespace ModelDevelopment
    Partial Class FORM_MODELDEVELOPMENT
        Private Sub Populate_TV_Solution()
            Me.TV_MODELS.Sort()
            Me.TV_MODELS.Nodes.Clear()
            Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Greyhounds")
            Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("New Zealand")
            Dim TreeNode130 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Master Models")
            '
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Evaluated")
            Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Imported")
            Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gallops")
            Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Harness")

            Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Test")
            '
            TreeNode100.Name = "-1"
            TreeNode100.NodeFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNode100.Text = "Greyhounds"
            TreeNode100.ToolTipText = "Greyhound Models"
            TreeNode100.Tag = NodeTypes.BaseFolder
            TreeNode100.ImageIndex = 4
            '
            TreeNode110.Name = "-11"
            TreeNode110.NodeFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNode110.Text = "New Zealand"
            TreeNode110.ToolTipText = "New Zealand Models"
            TreeNode110.Tag = NodeTypes.BaseFolder
            TreeNode110.ImageIndex = 4
            '
            TreeNode130.Name = "-13"
            TreeNode130.NodeFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNode130.Text = "Master Models"
            TreeNode130.ToolTipText = "Master Models"
            TreeNode130.Tag = NodeTypes.BaseFolder
            TreeNode130.ImageIndex = 4
            '
            TreeNode100.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode110, TreeNode130})
            '
            TreeNode10.Name = "-4"
            TreeNode10.NodeFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNode10.Text = "Evaluated"
            TreeNode10.ToolTipText = "Evaluated Models"
            TreeNode10.Tag = NodeTypes.BaseFolder
            TreeNode10.ImageIndex = 4
            '
            TreeNode20.Name = "-6"
            TreeNode20.NodeFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNode20.Text = "Imported"
            TreeNode20.ToolTipText = "Imported Models"
            TreeNode20.Tag = NodeTypes.BaseFolder
            TreeNode20.ImageIndex = 4
            '
            TreeNode30.Name = "-2"
            TreeNode30.NodeFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNode30.Text = "Gallops"
            TreeNode30.ToolTipText = "Gallops Models"
            TreeNode30.Tag = NodeTypes.BaseFolder
            TreeNode30.ImageIndex = 4
            '
            TreeNode40.Name = "-3"
            TreeNode40.NodeFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNode40.Text = "Harness"
            TreeNode40.ToolTipText = "Harness Models"
            TreeNode40.Tag = NodeTypes.BaseFolder
            TreeNode40.ImageIndex = 4
            '
            TreeNode50.Name = "-5"
            TreeNode50.NodeFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNode50.Text = "Test"
            TreeNode50.ToolTipText = "Test Models"
            TreeNode50.Tag = NodeTypes.BaseFolder
            TreeNode50.ImageIndex = 4
            '
            Me.TV_MODELS.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode100, TreeNode10, TreeNode20, TreeNode30, TreeNode40, TreeNode50})
            '
            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER ORDER BY LEVEL ASC, PARENT_EXPLORER_ID ASC, MODEL_EXPLORER_ID ASC"
            For Each ROW As Data.DataRow In Connection.GetDataTable(CMDTEXT).Select("")
                Dim Nodes() As TreeNode = Me.TV_MODELS.Nodes.Find(ROW.Item("PARENT_EXPLORER_ID").ToString, True)
                If Nodes.Count > 0 Then
                    Dim SubNodes() As TreeNode = Nodes(0).Nodes.Find(ROW.Item("PARENT_EXPLORER_ID").ToString, True)
                    Dim Node As New TreeNode
                    Node.Name = Trim(ROW.Item("MODEL_EXPLORER_ID").ToString)
                    Node.Text = Trim(ROW.Item("NAME").ToString)
                    Node.Tag = CType(ROW.Item("TREE_NODE_TYPE"), NodeTypes)
                    Select Case CType(ROW.Item("TREE_NODE_TYPE"), NodeTypes)
                        Case NodeTypes.Folder
                            Node.ImageIndex = 0
                        Case NodeTypes.Model
                            Node.ImageIndex = 2
                        Case NodeTypes.Clone
                            Node.ImageIndex = 3
                        Case Else
                    End Select
                    If SubNodes.Count > 0 Then
                        SubNodes(0).Nodes.Add(Node)
                    Else
                        Nodes(0).Nodes.Add(Node)
                    End If
                End If
            Next ROW
            '
            Me.TV_MODELS.SelectedNode = Me.TV_MODELS.Nodes(0)
        End Sub
    End Class
End Namespace