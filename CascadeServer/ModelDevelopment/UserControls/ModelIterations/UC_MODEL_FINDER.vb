' MY_CONNECTION is passed in from FORM MODELDEVELOPMENT.
Namespace ModelDevelopment.UserControls.ModelIterations
    Friend NotInheritable Class UC_MODEL_FINDER
        Private MY_FRM_MODEL_ITERATIONS As Controls.FRM_MODEL_ITERATIONS
        Private PASSEDIN_CONNECTION As Utils.Connection
        Private _Messages As Messages
        '
        Private MY_STATUSSTRIP As Controls.UC_STATUSSTRIP

        Friend Sub New(ByRef ModelIterations As Controls.FRM_MODEL_ITERATIONS, ByVal Connection As Utils.Connection)
            InitializeComponent()
            PASSEDIN_CONNECTION = Connection
            '
            MY_STATUSSTRIP = New Controls.UC_STATUSSTRIP
            MY_STATUSSTRIP.Dock = DockStyle.Bottom
            MY_STATUSSTRIP.RenderMode = ToolStripRenderMode.Professional
            MY_STATUSSTRIP.TSSPBProgress.Style = ProgressBarStyle.Continuous
            Me.Controls.Add(MY_STATUSSTRIP)
            '
            MY_FRM_MODEL_ITERATIONS = ModelIterations
        End Sub
        Friend Sub START()
            MY_STATUSSTRIP.TSSLStatus.Text = "Compiling ..." : MY_STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            '
            ' If we cant compile the code then return
            If RuntimeCompiler.CompileCode(Nothing, Nothing, RuntimeCompiler.ModelExplorerDR(PASSEDIN_CONNECTION, CStr(MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("MODEL_EXPLORER_ID"))), PASSEDIN_CONNECTION) Is Nothing Then
                MY_STATUSSTRIP.TSSLStatus.Text = "Model contains errors, please fix the errors and try again." : MY_STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
                Return
            End If
            '
            Dim CMDTEXT As String
            Me.LBL_UPDATE.Text = "Selecting Records ... " : Me.LBL_UPDATE.Invalidate() : Application.DoEvents()
            CMDTEXT = "SELECT TYPE, COUNTRY, VENUE, LENGTH, COUNT "
            CMDTEXT += "FROM ("
            CMDTEXT += "SELECT MEETING_INFO.TYPE, MEETING_INFO.COUNTRY, RACE_INFO.VENUE, RACE_INFO.LENGTH, COUNT(RACE_INFO.NUMBER) AS COUNT "
            CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
            CMDTEXT += "WHERE (MEETING_INFO.OADATE >= " & CStr(MY_FRM_MODEL_ITERATIONS.EVALFROM.ToOADate) & " AND MEETING_INFO.OADATE <= " & CStr(MY_FRM_MODEL_ITERATIONS.EVALTO.ToOADate) & ") "
            CMDTEXT += "GROUP BY MEETING_INFO.TYPE, MEETING_INFO.COUNTRY, RACE_INFO.VENUE, RACE_INFO.LENGTH "
            CMDTEXT += "HAVING (COUNT(RACE_INFO.NUMBER) > " & MY_FRM_MODEL_ITERATIONS.RACES & ") "
            CMDTEXT += "AND  (MEETING_INFO.TYPE = N'" & MY_FRM_MODEL_ITERATIONS.TYPE & "') "
            If Not MY_FRM_MODEL_ITERATIONS Is Nothing AndAlso MY_FRM_MODEL_ITERATIONS.VENUE <> "" Then
                CMDTEXT += " AND (dbo.RACE_INFO.VENUE = N'" & MY_FRM_MODEL_ITERATIONS.VENUE & "') "
            Else
                CMDTEXT += "UNION "
                CMDTEXT += "SELECT MEETING_INFO.TYPE, MEETING_INFO.COUNTRY, RACE_INFO.VENUE, NULL AS LENGTH, COUNT(RACE_INFO.NUMBER) AS COUNT "
                CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
                CMDTEXT += "WHERE (MEETING_INFO.OADATE >= " & CStr(MY_FRM_MODEL_ITERATIONS.EVALFROM.ToOADate) & " AND MEETING_INFO.OADATE <= " & CStr(MY_FRM_MODEL_ITERATIONS.EVALTO.ToOADate) & ") "
                CMDTEXT += "GROUP BY MEETING_INFO.TYPE, MEETING_INFO.COUNTRY, RACE_INFO.VENUE "
                CMDTEXT += "HAVING (COUNT(RACE_INFO.NUMBER) > " & MY_FRM_MODEL_ITERATIONS.RACES & ") "
                CMDTEXT += "AND  (MEETING_INFO.TYPE = N'" & MY_FRM_MODEL_ITERATIONS.TYPE & "') "
                '
                CMDTEXT += "UNION "
                CMDTEXT += "SELECT MEETING_INFO.TYPE, MEETING_INFO.COUNTRY, NULL AS VENUE, NULL AS LENGTH, COUNT(RACE_INFO.NUMBER) AS COUNT "
                CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
                CMDTEXT += "WHERE (MEETING_INFO.OADATE >= " & CStr(MY_FRM_MODEL_ITERATIONS.EVALFROM.ToOADate) & " AND MEETING_INFO.OADATE <= " & CStr(MY_FRM_MODEL_ITERATIONS.EVALTO.ToOADate) & ") "
                CMDTEXT += "GROUP BY MEETING_INFO.TYPE, MEETING_INFO.COUNTRY "
                CMDTEXT += "HAVING (COUNT(RACE_INFO.NUMBER) > " & MY_FRM_MODEL_ITERATIONS.RACES & ") "
                CMDTEXT += "AND  (MEETING_INFO.TYPE = N'" & MY_FRM_MODEL_ITERATIONS.TYPE & "') "
                '
                CMDTEXT += "UNION "
                CMDTEXT += "SELECT MEETING_INFO.TYPE, MEETING_INFO.COUNTRY, NULL AS VENUE, RACE_INFO.LENGTH, COUNT(RACE_INFO.NUMBER) AS COUNT "
                CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
                CMDTEXT += "WHERE (MEETING_INFO.OADATE >= " & CStr(MY_FRM_MODEL_ITERATIONS.EVALFROM.ToOADate) & " AND MEETING_INFO.OADATE <= " & CStr(MY_FRM_MODEL_ITERATIONS.EVALTO.ToOADate) & ") "
                CMDTEXT += "GROUP BY MEETING_INFO.TYPE, MEETING_INFO.COUNTRY, RACE_INFO.LENGTH "
                CMDTEXT += "HAVING (COUNT(RACE_INFO.NUMBER) > " & MY_FRM_MODEL_ITERATIONS.RACES & ") "
                CMDTEXT += "AND  (MEETING_INFO.TYPE = N'" & MY_FRM_MODEL_ITERATIONS.TYPE & "') "
                '
                CMDTEXT += ") AS MY_TABLE "
                CMDTEXT += "ORDER BY [COUNT] DESC"
            End If
            Dim DR() As Data.DataRow = PASSEDIN_CONNECTION.GetDataTable(CMDTEXT).Select("")
            Me.LBL_UPDATE.Text = "Found " & CStr(DR.Length) & " iterations." : Application.DoEvents()
            Me.PB_ITERATIONS.Minimum = 0 : Me.PB_ITERATIONS.Maximum = DR.Count
            Me.LBL_UPDATE.Text = "Set Iterations maximum to " & CStr(DR.Count) & " iterations." : Application.DoEvents()
            '
            Me.LBL_UPDATE.Text = "Starting first iteration." : Application.DoEvents()
            For Each ROW As Data.DataRow In DR
                Me.LBL_UPDATE.Text = "Processing iteration " & CStr(Me.PB_ITERATIONS.Value + 1) : Application.DoEvents()
                Call Iteration(ROW)
                Me.PB_ITERATIONS.Value += 1
            Next
            Me.LBL_UPDATE.Text = "Finished" : Me.LBL_UPDATE.Invalidate() : Application.DoEvents()
            Me.ButFinish.Visible = True
        End Sub
        Private Sub Iteration(ByVal ITERATION_ROW As Data.DataRow)
            ' Cursor is changed in the calling method.
            '
            Dim StartDate As String = CStr(CInt(MY_FRM_MODEL_ITERATIONS.EVALFROM.ToOADate))
            Dim FinishDate As String = CStr(CInt(MY_FRM_MODEL_ITERATIONS.EVALTO.ToOADate))
            '
            MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("MEETING_COUNTRY") = ITERATION_ROW.Item("COUNTRY")
            MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("MEETING_TYPE") = ITERATION_ROW.Item("TYPE")
            MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("RACE_VENUE") = ITERATION_ROW.Item("VENUE")
            MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("RACE_LENGTH") = ITERATION_ROW.Item("LENGTH")
            '
            MY_STATUSSTRIP.TSSLStatus.Text = "Collecting Records ..." : Me.LBL_UPDATE.Invalidate() : Application.DoEvents()
            Dim This_Model_Result_DT As Data.DataTable
            '
            Using ModelRun As ModelDevelopment.ModelRun = New ModelDevelopment.ModelRun(StartDate, FinishDate, MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("MODEL_EXPLORER_ID").ToString,
            Me._Messages, MY_STATUSSTRIP.TSSLStatus, MY_STATUSSTRIP.TSSPBProgress, MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR)
                This_Model_Result_DT = ModelRun.GetResults_DT
                '
                If This_Model_Result_DT.Rows.Count <> 0 Then
                    MY_STATUSSTRIP.TSSLStatus.Text = "Preparing Results ..." : MY_STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
                    Call CreateModel(This_Model_Result_DT, ITERATION_ROW)
                End If
            End Using
            '
            MY_STATUSSTRIP.TSSLStatus.Text = "Ready" : MY_STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            '
            GC.Collect()
            ' Cursor is changed in the calling method.
        End Sub
        Private Sub CreateModel(ByVal Results_DT As Data.DataTable, ByVal Iteration_Row As Data.DataRow)
            If Results_DT.Rows.Count < CInt(MY_FRM_MODEL_ITERATIONS.RACESRETURNED) Then Return
            Dim PLACES As Decimal = CDec(Results_DT.Compute("COUNT(RESULT_POOL_PLACE)", "RESULT_POOL_PLACE > 0"))
            Dim PERCENTAGE As Decimal = (PLACES / Results_DT.Rows.Count) * 100
            If PERCENTAGE < CDec(MY_FRM_MODEL_ITERATIONS.PLACEPERCENT) Then Return
            '
            Dim this_ModelName As String = Iteration_Row.Item("TYPE").ToString & "\" & Iteration_Row.Item("COUNTRY").ToString & "\"
            If Not IsDBNull(Iteration_Row.Item("VENUE")) Then this_ModelName += Iteration_Row.Item("VENUE").ToString & "\"
            If Not IsDBNull(Iteration_Row.Item("LENGTH")) Then this_ModelName += Iteration_Row.Item("LENGTH").ToString & "\"
            this_ModelName += CStr(MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("NAME")) & " {R: " & CStr(Results_DT.Rows.Count) & ", P%: " & FormatNumber(PERCENTAGE, 2) & "}"
            '
            Dim CMDTEXT As String = "INSERT INTO MODEL_EXPLORER ([PARENT_EXPLORER_ID], [LEVEL], [TREE_NODE_TYPE], [TREE_PATH], [NAME], [MEETING_COUNTRY], [MEETING_TYPE], [RACE_VENUE], [RACE_LENGTH], [RACE_RIR_GTE], [BACKING], [VBCODE], [VERSION], [STATUS]) "
            CMDTEXT += "VALUES (-4, 2, " & CStr(1) & ", N'Evaluated', N'" & this_ModelName & "', "
            CMDTEXT += "'" & Iteration_Row.Item("COUNTRY").ToString & "', '" & Iteration_Row.Item("TYPE").ToString & "', "
            If Not IsDBNull(Iteration_Row.Item("VENUE")) Then CMDTEXT += "'" & Iteration_Row.Item("VENUE").ToString & "', " Else CMDTEXT += "NULL, "
            If Not IsDBNull(Iteration_Row.Item("LENGTH")) Then CMDTEXT += Iteration_Row.Item("LENGTH").ToString & ", " Else CMDTEXT += "NULL, "
            If Not IsDBNull(MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("RACE_RIR_GTE")) Then CMDTEXT += CStr(MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("RACE_RIR_GTE")) & ", " Else CMDTEXT += "NULL, "
            CMDTEXT += "'PLC', N'" & Replace(CStr(MY_FRM_MODEL_ITERATIONS.MODELEXPLORER_DR.Item("VBCODE")), "'", "' + CHAR(39) + '") & "', " & CStr(Now.ToOADate) & ", 0)"
            '
            PASSEDIN_CONNECTION.Execute(CMDTEXT)
        End Sub

        Private Sub ButFinish_Click(sender As Object, e As EventArgs) Handles ButFinish.Click
            MY_FRM_MODEL_ITERATIONS.Close()
        End Sub
    End Class
End Namespace