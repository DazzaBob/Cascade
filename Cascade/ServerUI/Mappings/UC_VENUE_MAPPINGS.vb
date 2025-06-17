Namespace ServerUI.Mappings
    Friend NotInheritable Class UC_VENUE_MAPPINGS
        Friend Sub New()
            InitializeComponent()
            Me.TV_MAPPINGS.Sort()
        End Sub
        Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
            Call Populate()
        End Sub
        Private Sub Populate()
            Dim CMDTEXT As String
            CMDTEXT = "SELECT DISTINCT TYPE, COUNTRY FROM MEETING_INFO"
            For Each ROW As Data.DataRow In UI.FrmServer.Connection.GetDataTable(CMDTEXT).Select("")
                Dim Nodes() As TreeNode = Me.TV_MAPPINGS.Nodes.Find(ROW.Item("TYPE").ToString, True)
                If Nodes.Count > 0 Then
                    Dim Node As New TreeNode
                    Node.Name = ROW.Item("TYPE").ToString & "|" & ROW.Item("COUNTRY").ToString
                    Node.Text = ROW.Item("COUNTRY").ToString
                    Node.Tag = "COUNTRY"
                    '
                    Nodes(0).Nodes.Add(Node)
                End If
            Next ROW
            '
            CMDTEXT = "SELECT DISTINCT MEETING_INFO.TYPE, MEETING_INFO.COUNTRY, RACE_INFO.VENUE "
            CMDTEXT = String.Concat(CMDTEXT, "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER")
            For Each ROW As Data.DataRow In UI.FrmServer.Connection.GetDataTable(CMDTEXT).Select("")
                Dim Nodes() As TreeNode = Me.TV_MAPPINGS.Nodes.Find(ROW.Item("TYPE").ToString & "|" & ROW.Item("COUNTRY").ToString, True)
                If Nodes.Count > 0 Then
                    Dim Node As New TreeNode
                    Node.Name = ROW.Item("TYPE").ToString & "|" & ROW.Item("COUNTRY").ToString & "|" & ROW.Item("VENUE").ToString
                    Node.Text = ROW.Item("VENUE").ToString
                    Node.Tag = "VENUE"
                    Node.ContextMenuStrip = Me.CMS_TV
                    '
                    Nodes(0).Nodes.Add(Node)
                End If
            Next ROW
            '
            CMDTEXT = "SELECT * FROM MAPPINGS_VENUE"
            For Each ROW As Data.DataRow In UI.FrmServer.Connection.GetDataTable(CMDTEXT).Select("")
                Dim Nodes() As TreeNode
                '
                Nodes = Me.TV_MAPPINGS.Nodes.Find(ROW.Item("TYPE").ToString & "|" & ROW.Item("COUNTRY").ToString & "|" & ROW.Item("VENUE").ToString, True)
                If Nodes.Count > 0 Then
                    For Each Node As TreeNode In Nodes
                        Me.TV_MAPPINGS.Nodes.Remove(Node)
                    Next
                End If
                '
                Nodes = Me.TV_MAPPINGS.Nodes.Find(ROW.Item("TYPE").ToString & "|" & ROW.Item("COUNTRY").ToString & "|" & ROW.Item("MAPTOVENUE").ToString, True)
                If Nodes.Count > 0 Then
                    Dim Node As New TreeNode
                    Node.Name = ROW.Item("TYPE").ToString & "|" & ROW.Item("COUNTRY").ToString & "|" & ROW.Item("VENUE").ToString
                    Node.Text = ROW.Item("VENUE").ToString
                    Node.Tag = "REMAP VENUE"
                    '
                    Nodes(0).Nodes.Add(Node)
                End If
            Next
        End Sub
        Private Sub TV_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles TV_MAPPINGS.ItemDrag
            Me.TV_MAPPINGS.DoDragDrop(e.Item, DragDropEffects.Move)
        End Sub
        Private Sub TV_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TV_MAPPINGS.DragEnter
            If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If
        End Sub
        Private Sub TV_DragOver(ByVal sender As System.Object, ByVal e As DragEventArgs) Handles TV_MAPPINGS.DragOver
            If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = True Then
                Dim pt As Point = Me.TV_MAPPINGS.PointToClient(New Point(e.X, e.Y))
                Dim targetNode As TreeNode = Me.TV_MAPPINGS.GetNodeAt(pt)
                '
                If Not (Me.TV_MAPPINGS.SelectedNode Is targetNode) Then
                    Me.TV_MAPPINGS.SelectedNode = targetNode
                    Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
                    Do Until targetNode Is Nothing
                        If targetNode Is dropNode Then
                            e.Effect = DragDropEffects.None
                            Exit Sub
                        End If
                        targetNode = targetNode.Parent
                    Loop
                End If
                e.Effect = DragDropEffects.Move
            End If
        End Sub
        Private Sub TV_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TV_MAPPINGS.DragDrop
            Me.Cursor = Cursors.WaitCursor
            If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = True Then
                '
                Dim This_Target_Drop_Node As TreeNode = Me.TV_MAPPINGS.SelectedNode
                Dim This_Move_This_Node As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
                If This_Move_This_Node.Level = 0 OrElse This_Move_This_Node.Level = 1 Then Me.Cursor = Cursors.Default : Return
                '
                If This_Move_This_Node Is This_Target_Drop_Node Then Me.Cursor = Cursors.Default : Return
                If (This_Move_This_Node.Tag.ToString = "REMAP VENUE" AndAlso This_Target_Drop_Node.Tag.ToString = "REMAP VENUE") OrElse _
                    (This_Move_This_Node.Tag.ToString = "VENUE" AndAlso This_Target_Drop_Node.Tag.ToString = "REMAP VENUE") Then
                    MessageBox.Show("You can NOT ReMap a Venue to a Venue that has already been ReMapped!", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                    Me.Cursor = Cursors.Default : Return
                End If
                '
                If (This_Move_This_Node.Tag.ToString = "VENUE" AndAlso This_Target_Drop_Node.Tag.ToString = "VENUE") OrElse _
                    (This_Move_This_Node.Tag.ToString = "REMAP VENUE" AndAlso This_Target_Drop_Node.Tag.ToString = "VENUE") Then
                    If This_Move_This_Node.Nodes.Count > 0 Then
                        For Each TN As TreeNode In This_Move_This_Node.Nodes
                            If TN.Tag.ToString = "REMAP VENUE" Then
                                MessageBox.Show("You can NOT ReMap a Venue with Mappings to another Venue!  Move the Mappings to the Venue instead.", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                                Me.Cursor = Cursors.Default : Return
                            End If
                        Next
                    End If
                    '
                    If MessageBox.Show("Are you sure you want to ReMap " & This_Move_This_Node.Text & " to " & This_Target_Drop_Node.Text & "?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Me.Cursor = Cursors.Default : Return
                    This_Move_This_Node.Remove()
                    This_Target_Drop_Node.Nodes.Add(This_Move_This_Node)
                    This_Move_This_Node.EnsureVisible()
                    This_Move_This_Node.Tag = "REMAP VENUE"
                    Me.TV_MAPPINGS.SelectedNode = This_Move_This_Node
                    Me.TV_MAPPINGS.Focus()
                    Dim VALUES() As String = Split(This_Move_This_Node.Name.ToString, "|")
                    Call CreateMapping(VALUES(0), VALUES(1), VALUES(1), This_Move_This_Node.Text, This_Target_Drop_Node.Text)
                End If
            End If
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Shared Sub CreateMapping(ByVal Type As String, ByVal Country As String, ByVal MapsToCountry As String, ByVal Venue As String, ByVal MapsToVenue As String)
            Dim CMDTEXT As String
            Call DeleteMapping(Type, Country, Venue)
            '
            CMDTEXT = "INSERT INTO MAPPINGS_VENUE (TYPE, COUNTRY, MAPTOCOUNTRY, VENUE, MAPTOVENUE) "
            CMDTEXT += "VALUES('" & Type & "', '" & Country & "', '" & MapsToCountry & "','" & Venue & "', '" & MapsToVenue & "')"
            UI.FrmServer.Connection.Execute(CMDTEXT)
        End Sub
        Private Shared Sub DeleteMapping(ByVal Type As String, ByVal Country As String, ByVal Venue As String)
            Dim CMDTEXT As String
            CMDTEXT = "DELETE FROM MAPPINGS_VENUE WHERE TYPE='" & Type & "' AND COUNTRY='" & Country & "' AND VENUE='" & Venue & "'"
            UI.FrmServer.Connection.Execute(CMDTEXT)
        End Sub
        Private Sub FindExistingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindExistingToolStripMenuItem.Click
            If Me.TV_MAPPINGS.SelectedNode.Level < 2 Then
                MessageBox.Show("No Current Venue selected!", "Unable to comply!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Exit Sub
            End If

            Dim CurrentPath() As String = Split(Me.TV_MAPPINGS.SelectedNode.Parent.Name.ToString, "|")
            Dim TypeNodes() As TreeNode = Me.TV_MAPPINGS.Nodes.Find(CurrentPath(0), True)
            If TypeNodes.Count = 0 Then Return
            '
            For Each TypeNode As TreeNode In TypeNodes
                For Each TN As TreeNode In TypeNode.Nodes
                    Dim FindAMatchingVenue As String = TN.Name.ToString & "|" & Me.TV_MAPPINGS.SelectedNode.Text
                    Dim MATCHINGVENUES() As TreeNode = TN.Nodes.Find(FindAMatchingVenue, True)
                    If MATCHINGVENUES.Count > 0 Then
                        For Each NODE As TreeNode In MATCHINGVENUES
                            If MessageBox.Show("Would you like to ReMap " & Me.TV_MAPPINGS.SelectedNode.FullPath & " to " & NODE.FullPath & "?", "A match was found.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.Yes Then
                                Dim CurrentValues() As String = Split(Me.TV_MAPPINGS.SelectedNode.FullPath, "\")
                                Dim NewValues() As String = Split(NODE.FullPath, "\")
                                Call CreateMapping(NewValues(0), CurrentValues(1), NewValues(1), Me.TV_MAPPINGS.SelectedNode.Text, NewValues(2))
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            Next
        End Sub
        Private Sub ButRUNNOW_Click(sender As Object, e As EventArgs) Handles ButRUNNOW.Click
            Me.Cursor = Cursors.WaitCursor
            Dim CMDTEXT As String = "SELECT * FROM MAPPINGS_VENUE"
            Dim COMMANDTEXT As String = ""
            For Each ROW As Data.DataRow In UI.FrmServer.Connection.GetDataTable(CMDTEXT).Select("")
                COMMANDTEXT += "UPDATE RACE_INFO SET VENUE=N'" & ROW.Item("MAPTOVENUE").ToString & "' "
                COMMANDTEXT += "WHERE VENUE=N'" & ROW.Item("VENUE").ToString & "' " & Environment.NewLine
            Next ROW
            UI.FrmServer.Connection.Execute(COMMANDTEXT)
            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace