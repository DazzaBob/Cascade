Namespace ModelDevelopment.StoredProcedures
    Friend NotInheritable Class ModelExplorer : Implements IDisposable
        Private ReadOnly _Connection As Utils.Connection
        Private disposedValue As Boolean

        Private Sub New()
            Me._Connection = New Utils.Connection
        End Sub
        Friend Sub UpdateRow(ByVal TabPage As UserControls.UC_TABPAGE)
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
            Me._Connection.Execute(CMDTEXT)
            '
            ' Save the update to the log.
            Call AddNewModelLog(TabPage.Properties.ID, "Model was saved or updated.", Me._Connection)
        End Sub
        Friend Shared Sub DeleteModel(ModelExplorerID As String, Connection As Utils.Connection)
            Dim CMDTEXT As String = "DELETE FROM MODEL_EXPLORER WHERE (ID=" & ModelExplorerID & ") " & Environment.NewLine
            'CMDTEXT = String.Concat(CMDTEXT, "DELETE FROM MODEL_LOG WHERE (MODEL_EXPLORER_ID=" & ModelExplorerID & ") " & Environment.NewLine)
            'CMDTEXT += String.Concat(CMDTEXT, "DELETE FROM RACE_MODEL_INFO WHERE (MODEL_INFO_ID=" & ModelExplorerID & ")")
            Call Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Sub DeleteRow(ModelExplorerID As String, Connection As Utils.Connection)
            Dim CMDTEXT As String = "DELETE FROM MODEL_EXPLORER WHERE ID=" & ModelExplorerID
            Call Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Sub AddNewModelLog(ByVal modelId As String, ByVal log As String, ByVal Connection As Utils.Connection)
            If modelId Is Nothing Then Return
            '
            Dim CMDTEXT As String = Nothing
            CMDTEXT = "INSERT INTO MODEL_LOG (MODEL_EXPLORER_ID, OADATE, DESCRIPTION) "
            CMDTEXT = String.Concat(CMDTEXT, "VALUES (" & modelId & ", " & CStr(Now.ToOADate) & ", N'" & Replace(log, "'", "' + CHAR(39) + '") & "')")
            Connection.Execute(CMDTEXT)
            CMDTEXT = Nothing
        End Sub
#Region "       Node Methods "
        Friend Sub MoveNode(ByVal Node As TreeNode)
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET PARENT_EXPLORER_ID=" & Node.Parent.Name & ", "
            CMDTEXT = String.Concat(CMDTEXT, "LEVEL=" & CStr(Node.Level) & ", ")
            CMDTEXT = String.Concat(CMDTEXT, "[TREE_PATH]=N'" & Node.FullPath & "' ")
            CMDTEXT = String.Concat(CMDTEXT, "WHERE MODEL_EXPLORER_ID=" & Node.Name)
            Call Me._Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Function AddNewFolderNode(Node As TreeNode, Connection As Utils.Connection) As Long
            Dim CMDTEXT As String = "INSERT INTO MODEL_EXPLORER ([PARENT_ID], [LEVEL], [NODE_TYPE], [PATH], [NAME]) "
            CMDTEXT += "VALUES (" & Node.Parent.Name & ", " & Node.Level.ToString & ", " & CShort(Utils.NodeTypes.Folder).ToString & ", N'" & Node.FullPath & "', N'New Folder')"
            Call Connection.Execute(CMDTEXT)

            CMDTEXT = "SELECT TOP 1 ID FROM MODEL_EXPLORER ORDER BY ID DESC"
            Return Connection.ExecuteScalar(CMDTEXT)
        End Function
        Friend Shared Sub RenameNode(e As NodeLabelEditEventArgs, Connection As Utils.Connection)
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET [NAME]=N'" & Replace(e.Label, "'", "' + CHAR(39) + '") & "', "
            CMDTEXT += "[PATH]=N'" & e.Node.Parent.FullPath & "\" & e.Label & "' "
            CMDTEXT += "WHERE ID=" & e.Node.Name

            Call Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Function AddModelNode(Node As TreeNode, Connection As Utils.Connection) As Long
            Dim CMDTEXT As String = "INSERT INTO MODEL_EXPLORER ([PARENT_ID], [LEVEL], [NAME], [NODE_TYPE], [PATH], [VERSION], [STATUS]) "
            CMDTEXT += "VALUES (" & Node.Parent.Name & ", " & Node.Level.ToString & ", N'New Model'," & CShort(Utils.NodeTypes.Model).ToString & ", N'" & Node.FullPath & "', " & Now.ToOADate.ToString & ", 0) "
            Call Connection.Execute(CMDTEXT)

            CMDTEXT = "SELECT TOP 1 ID FROM MODEL_EXPLORER ORDER BY ID DESC"
            Return Connection.ExecuteScalar(CMDTEXT)
        End Function
        Private Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    Me._Connection.Dispose()
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
#End Region
    End Class
End Namespace
