' MY_CONNECTION is defined in FORM MODELDEVELOPMENT
Namespace ModelDevelopment
    Partial Class FORM_MODELDEVELOPMENT
        Private Sub Populate_TV_Objects()
            For Each Node As TreeNode In Me.TVObjects.Nodes
                Call Populate_Recursive(Node)
            Next
        End Sub
        Private Sub Populate_Recursive(ByVal TN As TreeNode)
            If TN.Nodes.Count > 0 Then
                For Each NODE As TreeNode In TN.Nodes
                    Call Populate_Recursive(NODE)
                Next
            End If
            Call Populate_TV_OBJECTS_Node(CStr(TN.Name))
        End Sub
        Private Sub Populate_TV_OBJECTS_Node(NodeName As String)
            Dim CMDTEXT As String = "SELECT TOP (1) * FROM " & NodeName
            Dim Nodes() As TreeNode = Me.TVObjects.Nodes.Find(NodeName, True)
            For Each COLUMN As Data.DataColumn In Connection.GetDataTable(CMDTEXT).Columns
                Dim Node As New TreeNode
                Node.Name = COLUMN.ColumnName
                Node.Text = COLUMN.ColumnName & " {" & COLUMN.DataType.ToString & "}"
                Node.ImageIndex = 1
                Node.SelectedImageIndex = 1
                '
                Nodes(0).Nodes.Add(Node)
            Next
            Erase Nodes : Nodes = Nothing : CMDTEXT = Nothing
        End Sub
    End Class
End Namespace