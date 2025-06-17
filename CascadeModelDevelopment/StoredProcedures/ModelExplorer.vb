Namespace StoredProcedures
    Friend NotInheritable Class ModelExplorer
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared Sub UpdateRow(Properties As UserControls.Models.UserControlProperties, Connection As CascadeCommon.Utils.Connection)
            Dim CMDTEXT As String = ""

            CMDTEXT += "UPDATE MODEL_EXPLORER SET "
            CMDTEXT += "[PATH]=N'" & Trim(Properties.TreePath) & "', "
            CMDTEXT += "[NAME]=N'" & Trim(Properties.Name) & "', "
            CMDTEXT += "[PARENT_ID]=" & CStr(Properties.ParentID) & ", "
            CMDTEXT += "[LEVEL]=" & Split(Properties.TreePath, "\").Length & ", "
            'If Not TabPage.Properties.MEETING_COUNTRY Is Nothing Then CMDTEXT += "[MEETING_COUNTRY]=N'" & Trim(TabPage.Properties.MEETING_COUNTRY) & "', " Else CMDTEXT += "[MEETING_COUNTRY]=NULL, "
            'If Not TabPage.Properties.MEETING_TYPE Is Nothing Then CMDTEXT += "[MEETING_TYPE]=N'" & Trim(TabPage.Properties.MEETING_TYPE) & "', " Else CMDTEXT += "[MEETING_TYPE]=NULL, "
            'If Not TabPage.Properties.LENGTH Is Nothing Then CMDTEXT += "[RACE_LENGTH]=N'" & Trim(TabPage.Properties.LENGTH) & "', " Else CMDTEXT += "[RACE_LENGTH]=NULL, "
            ''If Not TabPage.Properties.WEATHER Is Nothing Then CMDTEXT += "[RACE_WEATHER]=N'" & Trim(TabPage.Properties.WEATHER) & "', " Else CMDTEXT += "[RACE_WEATHER]=NULL, "
            'If Not TabPage.Properties.VENUE Is Nothing Then CMDTEXT += "[RACE_VENUE]=N'" & Trim(TabPage.Properties.VENUE) & "', " Else CMDTEXT += "[RACE_VENUE]=NULL, "
            'If Not TabPage.Properties.TRACK Is Nothing Then CMDTEXT += "[RACE_TRACK]=N'" & TabPage.Properties.TRACK & "', " Else CMDTEXT += "[RACE_TRACK]=NULL, "
            'If Not TabPage.Properties.RunnersInRaceGTE Is Nothing AndAlso TabPage.Properties.RunnersInRaceGTE <> "" Then CMDTEXT += "[RACE_RIR_GTE]=" & TabPage.Properties.RunnersInRaceGTE & ", " Else CMDTEXT += "[RACE_RIR_GTE]=NULL, "
            'If Not TabPage.Properties.RunnersInRaceLTE Is Nothing AndAlso TabPage.Properties.RunnersInRaceLTE <> "" Then CMDTEXT += "[RACE_RIR_LTE]=" & TabPage.Properties.RunnersInRaceLTE & ", " Else CMDTEXT += "[RACE_RIR_LTE]=NULL, "
            '
            'If Not TabPage.Properties.BACKING Is Nothing Then CMDTEXT += "[BACKING]=N'" & TabPage.Properties.BACKING & "', " Else CMDTEXT += "[BACKING]=NULL, "
            'If Properties.VBCODE IsNot Nothing Then CMDTEXT += "[VBCODE]=N'" & Replace(Properties.VBCODE, "'", "' + CHAR(39) + '") & "', " Else CMDTEXT += "[VBCODE]=NULL, "
            CMDTEXT += "[VERSION]=" & Properties.Version & ", "
            CMDTEXT += "[STATUS]=" & CInt(Properties.Status).ToString & " "
            CMDTEXT += "WHERE ID=" & Properties.ID

            Call Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Sub DeleteModel(ModelExplorerID As String, Connection As CascadeCommon.Utils.Connection)
            Dim CMDTEXT As String = "DELETE FROM MODEL_EXPLORER WHERE (ID=" & ModelExplorerID & ") " & Environment.NewLine
            'CMDTEXT = String.Concat(CMDTEXT, "DELETE FROM MODEL_LOG WHERE (MODEL_EXPLORER_ID=" & ModelExplorerID & ") " & Environment.NewLine)
            'CMDTEXT += String.Concat(CMDTEXT, "DELETE FROM RACE_MODEL_INFO WHERE (MODEL_INFO_ID=" & ModelExplorerID & ")")
            Call Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Sub DeleteRow(ModelExplorerID As String, Connection As CascadeCommon.Utils.Connection)
            Dim CMDTEXT As String = "DELETE FROM MODEL_EXPLORER WHERE ID=" & ModelExplorerID
            Call Connection.Execute(CMDTEXT)
        End Sub
#Region "       Node Methods "
        Friend Sub MoveNode(Node As TreeNode, Connection As CascadeCommon.Utils.Connection)
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET PARENT_ID=" & Node.Parent.Name & ", "
            CMDTEXT += "LEVEL=" & Node.Level.ToString & ", [PATH]=N'" & Node.FullPath & "' "
            CMDTEXT += "WHERE ID=" & Node.Name

            Call Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Function AddNewFolderNode(Node As TreeNode, Connection As CascadeCommon.Utils.Connection) As Long
            Dim CMDTEXT As String = "INSERT INTO MODEL_EXPLORER ([PARENT_ID], [LEVEL], [NODE_TYPE], [PATH], [NAME]) "
            CMDTEXT += "VALUES (" & Node.Parent.Name & ", " & Node.Level.ToString & ", " & CShort(Utils.NodeTypes.Folder).ToString & ", N'" & Node.FullPath & "', N'New Folder')"
            Call Connection.Execute(CMDTEXT)

            CMDTEXT = "SELECT TOP 1 ID FROM MODEL_EXPLORER ORDER BY ID DESC"
            Return Connection.ExecuteScalar(CMDTEXT)
        End Function
        Friend Shared Sub RenameNode(e As NodeLabelEditEventArgs, Connection As CascadeCommon.Utils.Connection)
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET [NAME]=N'" & Replace(e.Label, "'", "' + CHAR(39) + '") & "', "
            CMDTEXT += "[PATH]=N'" & e.Node.Parent.FullPath & "\" & e.Label & "' "
            CMDTEXT += "WHERE ID=" & e.Node.Name

            Call Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Function AddModelNode(Node As TreeNode, Connection As CascadeCommon.Utils.Connection) As Long
            Dim CMDTEXT As String = "INSERT INTO MODEL_EXPLORER ([PARENT_ID], [LEVEL], [NAME], [NODE_TYPE], [PATH], [VERSION], [STATUS]) "
            CMDTEXT += "VALUES (" & Node.Parent.Name & ", " & Node.Level.ToString & ", N'New Model'," & CShort(Utils.NodeTypes.Model).ToString & ", N'" & Node.FullPath & "', " & Now.ToOADate.ToString & ", 0) "
            Call Connection.Execute(CMDTEXT)

            CMDTEXT = "SELECT TOP 1 ID FROM MODEL_EXPLORER ORDER BY ID DESC"
            Return Connection.ExecuteScalar(CMDTEXT)
        End Function
#End Region
    End Class
End Namespace