Namespace ModelDevelopment.StoredProcedures
    Friend NotInheritable Class ModelExplorer
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor.
        End Sub
        Friend Shared Sub UpdateRow(ByVal TabPage As UserControls.TabPage)
            Dim CMDTEXT As String = ""
            '
            CMDTEXT += "UPDATE MODEL_EXPLORER SET "
            CMDTEXT += "[TREE_PATH]=N'" & Trim(TabPage.Properties.TREEPATH) & "', "
            CMDTEXT += "[NAME]=N'" & Trim(TabPage.Properties.NAME) & "', "
            CMDTEXT += "[PARENT_EXPLORER_ID]=" & CStr(TabPage.Properties.PARENTID) & ", "
            CMDTEXT += "[LEVEL]=" & Split(TabPage.Properties.TREEPATH, "\").Length & ", "
            If Not TabPage.Properties.MEETING_COUNTRY Is Nothing Then CMDTEXT += "[MEETING_COUNTRY]=N'" & Trim(TabPage.Properties.MEETING_COUNTRY) & "', " Else CMDTEXT += "[MEETING_COUNTRY]=NULL, "
            If Not TabPage.Properties.MEETING_TYPE Is Nothing Then CMDTEXT += "[MEETING_TYPE]=N'" & Trim(TabPage.Properties.MEETING_TYPE) & "', " Else CMDTEXT += "[MEETING_TYPE]=NULL, "
            If Not TabPage.Properties.LENGTH Is Nothing Then CMDTEXT += "[RACE_LENGTH]=N'" & Trim(TabPage.Properties.LENGTH) & "', " Else CMDTEXT += "[RACE_LENGTH]=NULL, "
            If Not TabPage.Properties.WEATHER Is Nothing Then CMDTEXT += "[RACE_WEATHER]=N'" & Trim(TabPage.Properties.WEATHER) & "', " Else CMDTEXT += "[RACE_WEATHER]=NULL, "
            If Not TabPage.Properties.VENUE Is Nothing Then CMDTEXT += "[RACE_VENUE]=N'" & Trim(TabPage.Properties.VENUE) & "', " Else CMDTEXT += "[RACE_VENUE]=NULL, "
            If Not TabPage.Properties.TRACK Is Nothing Then CMDTEXT += "[RACE_TRACK]=N'" & TabPage.Properties.TRACK & "', " Else CMDTEXT += "[RACE_TRACK]=NULL, "
            If Not TabPage.Properties.RunnersInRaceGTE Is Nothing AndAlso TabPage.Properties.RunnersInRaceGTE <> "" Then CMDTEXT += "[RACE_RIR_GTE]=" & TabPage.Properties.RunnersInRaceGTE & ", " Else CMDTEXT += "[RACE_RIR_GTE]=NULL, "
            If Not TabPage.Properties.RunnersInRaceLTE Is Nothing AndAlso TabPage.Properties.RunnersInRaceLTE <> "" Then CMDTEXT += "[RACE_RIR_LTE]=" & TabPage.Properties.RunnersInRaceLTE & ", " Else CMDTEXT += "[RACE_RIR_LTE]=NULL, "
            '
            If Not TabPage.Properties.BACKING Is Nothing Then CMDTEXT += "[BACKING]=N'" & TabPage.Properties.BACKING & "', " Else CMDTEXT += "[BACKING]=NULL, "
            If Not TabPage.Properties.VBCODE Is Nothing Then CMDTEXT += "[VBCODE]=N'" & Replace(TabPage.Properties.VBCODE, "'", "' + CHAR(39) + '") & "', " Else CMDTEXT += "[VBCODE]=NULL, "
            CMDTEXT += "[VERSION]=" & TabPage.Properties.VERSION & ", "
            CMDTEXT += "[STATUS]=" & CStr(CInt(TabPage.Properties.STATUS)) & " "
            CMDTEXT += "WHERE MODEL_EXPLORER_ID=" & CStr(TabPage.Properties.ID)
            FORM_MODELDEVELOPMENT.Connection.Execute(CMDTEXT)
            '
            ' Save the update to the log.
            Call AddNewModelLog(TabPage.Properties.ID, "Model was saved or updated.", FORM_MODELDEVELOPMENT.Connection)
        End Sub
        Friend Shared Sub DeleteModel(ByVal ModelExplorerID As String)
            Dim CMDTEXT As String = "DELETE FROM MODEL_EXPLORER WHERE (MODEL_EXPLORER_ID=" & ModelExplorerID & ") " & Environment.NewLine
            CMDTEXT = String.Concat(CMDTEXT, "DELETE FROM MODEL_LOG WHERE (MODEL_EXPLORER_ID=" & ModelExplorerID & ") " & Environment.NewLine)
            CMDTEXT = String.Concat(CMDTEXT, "DELETE FROM RACE_MODEL_INFO WHERE (MODEL_INFO_ID=" & ModelExplorerID & ")")
            Call FORM_MODELDEVELOPMENT.Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Sub DeleteRow(ByVal ModelExplorerID As String)
            Dim CMDTEXT As String = "DELETE FROM MODEL_EXPLORER WHERE MODEL_EXPLORER_ID=" & ModelExplorerID
            Call FORM_MODELDEVELOPMENT.Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Sub AddNewModelLog(ByVal modelId As String, ByVal log As String, ByVal Connection As Connection)
            If modelId Is Nothing Then Return
            '
            Dim CMDTEXT As String = Nothing
            CMDTEXT = "INSERT INTO MODEL_LOG (MODEL_EXPLORER_ID, OADATE, DESCRIPTION) "
            CMDTEXT = String.Concat(CMDTEXT, "VALUES (" & modelId & ", " & CStr(Now.ToOADate) & ", N'" & Replace(log, "'", "' + CHAR(39) + '") & "')")
            Connection.Execute(CMDTEXT)
            CMDTEXT = Nothing
        End Sub
#Region "       Node Methods "
        Friend Shared Sub MoveNode(ByVal Node As TreeNode)
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET PARENT_EXPLORER_ID=" & Node.Parent.Name & ", "
            CMDTEXT = String.Concat(CMDTEXT, "LEVEL=" & CStr(Node.Level) & ", ")
            CMDTEXT = String.Concat(CMDTEXT, "[TREE_PATH]=N'" & Node.FullPath & "' ")
            CMDTEXT = String.Concat(CMDTEXT, "WHERE MODEL_EXPLORER_ID=" & Node.Name)
            Call FORM_MODELDEVELOPMENT.Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared ReadOnly Property AddNewFolderNode(ByVal Node As TreeNode) As Long
            Get
                Dim CMDTEXT As String = "INSERT INTO MODEL_EXPLORER ([PARENT_EXPLORER_ID], [LEVEL], [TREE_NODE_TYPE], [TREE_PATH], [NAME]) "
                CMDTEXT = String.Concat(CMDTEXT, "VALUES (" & Node.Parent.Name & ", " & CStr(Node.Level) & ", " & CStr(NodeTypes.Folder) & ", N'" & Node.FullPath & "', N'New Folder')")
                Call FORM_MODELDEVELOPMENT.Connection.Execute(CMDTEXT)
                CMDTEXT = "SELECT TOP 1 MODEL_EXPLORER_ID FROM MODEL_EXPLORER ORDER BY MODEL_EXPLORER_ID DESC"
                Return FORM_MODELDEVELOPMENT.Connection.ExecuteScalar(CMDTEXT)
            End Get
        End Property
        Friend Shared Sub RenameNode(ByVal e As NodeLabelEditEventArgs)
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET [NAME]=N'" & Replace(e.Label, "'", "' + CHAR(39) + '") & "', "
            CMDTEXT = String.Concat(CMDTEXT, "[TREE_PATH]=N'" & e.Node.Parent.FullPath & "\" & e.Label & "' ")
            CMDTEXT = String.Concat(CMDTEXT, "WHERE MODEL_EXPLORER_ID=" & e.Node.Name)
            Call FORM_MODELDEVELOPMENT.Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared ReadOnly Property AddModelNode(ByVal Node As TreeNode) As Long
            Get
                Dim CMDTEXT As String = "INSERT INTO MODEL_EXPLORER ([PARENT_EXPLORER_ID], [LEVEL], [TREE_NODE_TYPE], [TREE_PATH], [NAME], [BACKING], [VERSION], [STATUS]) "
                CMDTEXT = String.Concat(CMDTEXT, "VALUES (" & Node.Parent.Name & ", " & CStr(Node.Level) & ", " & CStr(NodeTypes.Model) & ", N'" & Node.FullPath & "', N'New Model', N'PLC', " & CStr(Now.ToOADate) & ", 0)")
                Call FORM_MODELDEVELOPMENT.Connection.Execute(CMDTEXT)
                CMDTEXT = "SELECT TOP 1 MODEL_EXPLORER_ID FROM MODEL_EXPLORER ORDER BY MODEL_EXPLORER_ID DESC"
                Return FORM_MODELDEVELOPMENT.Connection.ExecuteScalar(CMDTEXT)
            End Get
        End Property
#End Region
    End Class
End Namespace
