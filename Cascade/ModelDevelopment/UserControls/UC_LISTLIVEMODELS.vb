Namespace ModelDevelopment.Controls
    Friend Class UC_LISTLIVEMODELS
        Private FORM_MODELDEVELOPMENT As FORM_MODELDEVELOPMENT
        Friend Sub New(ByRef FormModelDevelopment As FORM_MODELDEVELOPMENT)
            InitializeComponent()
            Me.FORM_MODELDEVELOPMENT = FormModelDevelopment
        End Sub
        Friend Sub Populate()
            Me.Cursor = Cursors.WaitCursor
            '
            Me.DGV.Rows.Clear()
            '
            Dim X As Int32 = 1
            For Each MODEL_DR As Data.DataRow In Cascade.StoredProcedures.RACE_MODEL_INFO.GetLiveModels(FORM_MODELDEVELOPMENT.Connection).Select("")
                Using DGVRow As DataGridViewRow = New DataGridViewRow
                    DGVRow.CreateCells(Me.DGV)
                    DGVRow.HeaderCell.Value = CStr(X) : X += 1
                    DGVRow.Cells(Me.DGV_DETAIL.Index).Value = CStr(MODEL_DR.Item("TREE_PATH")) & " - " & CStr(MODEL_DR.Item("NAME").ToString)
                    DGVRow.Cells(Me.DGV_DETAIL.Index).Tag = CStr(MODEL_DR.Item("MODEL_EXPLORER_ID"))
                    DGVRow.Cells(Me.DGV_MODELID.Index).Value = CInt(MODEL_DR.Item("MODEL_EXPLORER_ID"))
                    '
                    Using DT As Data.DataTable = GetDataTable(CStr(MODEL_DR.Item("MODEL_EXPLORER_ID")), CStr(Date.Today.ToOADate - 1))
                        DGVRow.Cells(Me.DGV_NUMBEROFRACES.Index).Value = CInt(DT.Rows.Count)
                        '
                        Dim COUNT As Int32 = CInt(DT.Rows.Count)
                        If COUNT > 0I Then
                            Dim WINS As Decimal = CDec(DT.Compute("COUNT(RESULT_POOL_WIN)", "RESULT_POOL_WIN > 0"))
                            Dim PLACES As Decimal = CDec(DT.Compute("COUNT(RESULT_POOL_PLACE)", "(RESULT_POOL_PLACE > 0)"))
                            Dim WINPL As Decimal = CDec(DT.Compute("SUM(RESULT_POOL_WIN)", "")) - COUNT
                            Dim PLACEPL As Decimal = CDec(DT.Compute("SUM(RESULT_POOL_PLACE)", "")) - COUNT
                            '
                            DGVRow.Cells(Me.DVG_WINPERCENT.Index).Value = (WINS / COUNT) * 100
                            DGVRow.Cells(Me.DGV_PLACEPERCENT.Index).Value = (PLACES / COUNT) * 100
                            DGVRow.Cells(Me.DGV_PLWIN.Index).Value = WINPL
                            DGVRow.Cells(Me.DGV_PLPLACE.Index).Value = PLACEPL
                            DGVRow.Cells(Me.DGV_PLWINPERCENT.Index).Value = (WINPL / COUNT) * 100
                            DGVRow.Cells(Me.DGV_PLPLACEPERCENT.Index).Value = (PLACEPL / COUNT) * 100
                            '
                            Dim WINBETVALUE As Decimal
                            If WINS > 0 Then
                                WINBETVALUE = 100 - ((WINS / COUNT) * 100)
                                WINBETVALUE /= ((WINS / COUNT) * 100)
                                WINBETVALUE += 1
                            End If
                            DGVRow.Cells(Me.DGV_BET_WIN.Index).Value = Math.Round(WINBETVALUE, 2, MidpointRounding.AwayFromZero)
                            '
                            Dim PLACEBETVALUE As Decimal
                            If PLACES > 0 Then
                                PLACEBETVALUE = 100 - ((PLACES / COUNT) * 100)
                                PLACEBETVALUE /= ((PLACES / COUNT) * 100)
                                PLACEBETVALUE += 1
                            End If
                            DGVRow.Cells(Me.DGV_BET_PLACE.Index).Value = Math.Round(PLACEBETVALUE, 2, MidpointRounding.AwayFromZero)
                        Else
                            DGVRow.Cells(Me.DGV_BET_WIN.Index).Value = 0D
                            DGVRow.Cells(Me.DGV_BET_PLACE.Index).Value = 0D
                            DGVRow.Cells(Me.DVG_WINPERCENT.Index).Value = 0D
                            DGVRow.Cells(Me.DGV_PLACEPERCENT.Index).Value = 0D
                            DGVRow.Cells(Me.DGV_PLWIN.Index).Value = 0D
                            DGVRow.Cells(Me.DGV_PLPLACE.Index).Value = 0D
                            DGVRow.Cells(Me.DGV_PLWINPERCENT.Index).Value = 0D
                            DGVRow.Cells(Me.DGV_PLPLACEPERCENT.Index).Value = 0D
                        End If
                    End Using
                    '
                    DGV.Rows.Add(DGVRow)
                End Using
            Next MODEL_DR
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Shared ReadOnly Property GetDataTable(ByVal ModelExplorerID As String, ByVal MeetingInfoOADate As String) As Data.DataTable
            Get
                Dim COMMANDTEXT As String = "SELECT ENTRY_INFO.RESULT_POOL_WIN, ENTRY_INFO.RESULT_POOL_PLACE "
                COMMANDTEXT = String.Concat(COMMANDTEXT, "FROM RACE_MODEL_INFO INNER JOIN ENTRY_INFO ON RACE_MODEL_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_MODEL_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER AND RACE_MODEL_INFO.RACE_INFO_NUMBER = ENTRY_INFO.RACE_INFO_NUMBER AND RACE_MODEL_INFO.ENTRY_INFO_NUMBER = ENTRY_INFO.NUMBER ")
                COMMANDTEXT = String.Concat(COMMANDTEXT, "WHERE (RACE_MODEL_INFO.MODEL_INFO_ID = " & ModelExplorerID & ") AND (RACE_MODEL_INFO.MEETING_INFO_OADATE < " & MeetingInfoOADate & " AND RACE_MODEL_INFO.MEETING_INFO_OADATE >= " & CStr(CInt(MeetingInfoOADate) - 365) & ")")
                Return FORM_MODELDEVELOPMENT.Connection.GetDataTable(COMMANDTEXT)
            End Get
        End Property
        Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
            '
            Select Case e.ColumnIndex
                Case Me.DGV_DETAIL.Index
                    Me.Cursor = Cursors.WaitCursor
                    Dim Node() As TreeNode = FORM_MODELDEVELOPMENT.TV_MODELS.Nodes.Find(Me.DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Tag, True)
                    If Node.Count > 0 Then
                        FORM_MODELDEVELOPMENT.TV_MODELS.SelectedNode = Node(0)
                        FORM_MODELDEVELOPMENT.TV_MODELS.SelectedNode.EnsureVisible()
                    End If
                    Me.Cursor = Cursors.Default
            End Select
        End Sub
    End Class
End Namespace