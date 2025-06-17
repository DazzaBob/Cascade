Namespace DisplayRace
    Friend NotInheritable Class UC_MODELS
        Private MY_MEETING_OADATE As String
        Private MY_MEETING_NUMBER As String
        Private MY_RACE_NUMBER As String
        '
        Private MY_MODELS_METADATA As UC_MODELS_METADATA
        Private MY_POPUP As UserControls.PopUp
        Private MY_CONNECTION As Connection
        Friend Sub New(ByVal Connection As Connection)
            InitializeComponent()
            '
            MY_CONNECTION = Connection
        End Sub
        Friend Sub Populate(ByVal MEETING_OADATE As String, ByVal MEETING_NUMBER As String, ByVal RACE_NUMBER As String)
            MY_MEETING_OADATE = MEETING_OADATE
            MY_MEETING_NUMBER = MEETING_NUMBER
            MY_RACE_NUMBER = RACE_NUMBER
            '
            Me.Cursor = Cursors.WaitCursor
            '
            Me.DGV.Rows.Clear()
            '
            For Each ENTRY_ROW As Data.DataRow In StoredProcedures.RACE_MODEL_INFO.GetDataTable(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER, MY_CONNECTION).Select("")
                Using DGVRow As DataGridViewRow = New DataGridViewRow
                    DGVRow.CreateCells(Me.DGV)
                    '
                    DGVRow.Cells(Me.DGV_DETAIL.Index).Value = ENTRY_ROW.Item("DETAIL").ToString
                    DGVRow.Cells(Me.DGV_DETAIL.Index).Tag = ENTRY_ROW.Item("MODEL_INFO_ID")
                    '
                    Using DT As Data.DataTable = GetDataTable(CStr(ENTRY_ROW.Item("MODEL_INFO_ID")), MY_MEETING_OADATE)
                        Dim COUNT As Int32 = CInt(DT.Rows.Count)
                        DGVRow.Cells(Me.DGV_NUMBEROFRACES.Index).Value = COUNT
                        If COUNT > 0I Then
                            Dim WINS As Decimal = CDec(DT.Compute("COUNT(RESULT_POOL_WIN)", "RESULT_POOL_WIN > 0"))
                            Dim PLACES As Decimal = CDec(DT.Compute("COUNT(RESULT_POOL_PLACE)", "RESULT_POOL_PLACE > 0"))
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
            Next ENTRY_ROW
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private ReadOnly Property GetDataTable(ByVal ModelExplorerID As String, ByVal MeetingInfoOADate As String) As Data.DataTable
            Get
                Dim COMMANDTEXT As String = "SELECT ENTRY_INFO.RESULT_POOL_WIN, ENTRY_INFO.RESULT_POOL_PLACE "
                COMMANDTEXT = String.Concat(COMMANDTEXT, "FROM RACE_MODEL_INFO INNER JOIN ENTRY_INFO ON RACE_MODEL_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_MODEL_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER AND RACE_MODEL_INFO.RACE_INFO_NUMBER = ENTRY_INFO.RACE_INFO_NUMBER AND RACE_MODEL_INFO.ENTRY_INFO_NUMBER = ENTRY_INFO.NUMBER ")
                COMMANDTEXT = String.Concat(COMMANDTEXT, "WHERE (RACE_MODEL_INFO.MODEL_INFO_ID = " & ModelExplorerID & ") AND (RACE_MODEL_INFO.MEETING_INFO_OADATE < " & MeetingInfoOADate & " AND RACE_MODEL_INFO.MEETING_INFO_OADATE >= " & CStr(CInt(MeetingInfoOADate) - 365) & ")")
                Return MY_CONNECTION.GetDataTable(COMMANDTEXT)
            End Get
        End Property
        Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
            Select Case e.ColumnIndex
                Case Me.DGV_DETAIL.Index
                    MY_MODELS_METADATA = New UC_MODELS_METADATA(CStr(Me.DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Tag), MY_CONNECTION)
                    MY_MODELS_METADATA.Dock = DockStyle.Fill
                    '
                    MY_POPUP = New UserControls.PopUp
                    MY_POPUP.Text = "MODEL META DATA"
                    MY_POPUP.Size = New Size(800, 600)
                    MY_POPUP.WindowState = FormWindowState.Maximized
                    MY_POPUP.Controls.Add(MY_MODELS_METADATA)
                    '
                    MY_POPUP.Show(Me)
            End Select
        End Sub
    End Class
End Namespace