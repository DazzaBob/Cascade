Imports System.Windows.Forms

Namespace ModelRun
    Friend Class EntryPoint : Implements IDisposable
        Private disposedValue As Boolean

        Private This_StartDate As Integer
        Private This_FinishDate As Integer
        Friend Sub New()
            Me.disposedValue = False

        End Sub
        Friend Sub Start()
            Dim NewStopWatch As New Stopwatch
            Call NewStopWatch.Start()

            Call Messages.LogMessages("Model Run started at: " & FormatDateTime(Date.Now, DateFormat.LongDate), BroadcastTypes.Log)

            ' This will give us a datatable to populate matached models into
            Dim CollectedRowsDT As Data.DataTable = SQL.View.STATISTICS.DataTable("L10", "TOP 1", Connection).Clone

            If Not IsTesting Then
                For OADate As Integer = CInt(Common.StartOADate) To CInt(Common.FinishOADate)
                    Call Messages.LogMessages("Deleting Database Models for: " & FormatDateTime(Date.FromOADate(OADate), DateFormat.ShortDate), BroadcastTypes.Log)
                    Call SQL.RACE_MODELS.Delete(OADate.ToString, Connection)
                    Call SQL.RACE_EXTENDED.UpdateHasModel("NULL", OADate.ToString, Connection)
                Next OADate
            End If

            Dim ME_Filter As String
            If Not IsTesting Then
                Call Messages.LogMessages("Processing Live Models", BroadcastTypes.Log)
                ME_Filter = "ACTIVE=1"
            Else
                Call Messages.LogMessages("Processing Test Models", BroadcastTypes.Log)
                ME_Filter = "STATUS=1"
            End If

            For Each ModelExplorerRow As Data.DataRow In DataTables.ModelExplorer.DataTable(ME_Filter).Select("")
                For OADate As Integer = CInt(Common.StartOADate) To CInt(Common.FinishOADate)
                    Dim Filter As String = FilterForModelExplorer(ModelExplorerRow, OADate.ToString)

                    For Each MeetingRow As Data.DataRow In SQL.MEETING_XML.DISTINCT_NUMBER(Filter, Connection).Select("")
                        Common.TotalMeetings += 1

                        For Each RaceRow As Data.DataRow In SQL.RACE_XML.DISTINCT_NUMBERS(Filter, MeetingRow.Item("NUMBER").ToString, Connection).Select("")
                            Common.TotalRaces += 1

                            For Each Row As Data.DataRow In NewZealandModels(OADate.ToString, MeetingRow.Item("NUMBER").ToString, RaceRow.Item("NUMBER").ToString, Common.TotalEntries).Select("")
                                CollectedRowsDT.ImportRow(Row)
                            Next Row
                            'For Each Row As Data.DataRow In AustraliaModels(SL10, SL3, ModelExplorerRow).Select("")
                            'CollectedRowsDT.ImportRow(Row)
                            'Next Row

                        Next RaceRow
                        Application.DoEvents()
                    Next MeetingRow
                    Application.DoEvents()
                Next OADate
                Application.DoEvents()
            Next ModelExplorerRow

            If IsTesting Then
                Dim Popup As New CascadeCommon.PopUp
                Dim UCResults As New UserControls.UC_RESULTS()
                Call UCResults.Populate(CollectedRowsDT, This_StartDate, This_FinishDate)
                UCResults.Dock = DockStyle.Fill
                Popup.Text = "RANGE: BETWEEN " & Date.FromOADate(CDbl(StartOADate)).ToLongDateString & " AND " & Date.FromOADate(CDbl(FinishOADate)).ToLongDateString
                Popup.Controls.Add(UCResults)
                Popup.WindowState = FormWindowState.Maximized
                Popup.ShowDialog()
            Else
                If CollectedRowsDT.Rows.Count > 0 Then
                    For Each Row As Data.DataRow In CollectedRowsDT.Select("")
                        Call SQL.RACE_EXTENDED.InsertUpdate(Row, Connection)
                        Call SQL.RACE_MODELS.Insert(Row, Connection)
                    Next Row
                End If
            End If
            NewStopWatch.Stop()
            Call Messages.LogMessages("Model Run Complete in: " & CascadeCommon.ElapsedTime(NewStopWatch), BroadcastTypes.Log)
        End Sub
        Private Function NewZealandModels(OADate As String, MeetingNumber As String, RaceNumber As String, ByRef TotalEntries As Integer) As Data.DataTable
            Dim Filter As String = "(ENTRY_XML.MEETING_XML_OADATE=" & OADate & ") AND (ENTRY_XML.MEETING_XML_NUMBER=" & MeetingNumber & ") AND (ENTRY_XML.RACE_XML_NUMBER=" & RaceNumber & ") AND (VENUES.COUNTRY_ID=1)"
            Dim DT As Data.DataTable = SQL.View.STATISTICS.DataTable("L10", "TOP 1", Connection).Clone ' Clone requires at least 1 row returned to create the table schema.

            If IsTesting Then
                Dim ModelFilter As String = " AND (VENUES.TRACK_TYPE='GR')" ' AND (VENUES.VENUE_ID=8) AND (RACE_XML.[LENGTH]=295)"
                Using SL10DT = SQL.View.STATISTICS.DataTable("L10", Filter & ModelFilter, Connection)
                    Using SL3DT = SQL.View.STATISTICS.DataTable("L3", Filter & ModelFilter, Connection)
                        TotalEntries += SL10DT.Rows.Count

                        For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.StatisticsLXGreaterThan84(SL10DT, SL3DT).Select("")
                            DT.ImportRow(Row)
                        Next Row
                    End Using
                End Using
                Return DT
            Else
                Dim ModelFilter As String = " AND (VENUES.TRACK_TYPE='GR')"
                Using SL10DT = SQL.View.STATISTICS.DataTable("L10", Filter & ModelFilter, Connection)
                    TotalEntries += SL10DT.Rows.Count

                    For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.NewRunners(SL10DT).Select("")
                        DT.ImportRow(Row)
                    Next Row
                End Using

                Return DT
            End If


            'If ModelExplorerDR.Item("TYPE").ToString = "GR" OrElse ModelExplorerDR.Item("TYPE").ToString = "H" Then
            Try
                '        If IsTesting = False AndAlso ModelExplorerDR.Item("ACTIVE") = True Then

                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Harness.NewRunners(SL10DT).Select("")
                'DT.ImportRow(Row)
                'Next Row

                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.StatisticsLXGreaterThan80(SL10DT, SL3DT).Select("")
                'DT.ImportRow(Row)
                'Next Row
                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Harness.StatisticsLXGreaterThan80(SL10DT, SL3DT).Select("")
                'DT.ImportRow(Row)
                'Next Row

                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.TopDistanceBehind(SL10DT, SL3DT).Select("")
                'DT.ImportRow(Row)
                'Next Row
                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Harness.TopDistanceBehind(SL10DT, SL3DT).Select("")
                'DT.ImportRow(Row)
                'Next Row
                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.RankMoreThan20(SL10DT, SL3DT).Select("")
                'DT.ImportRow(Row)
                'Next Row
                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Harness.RankMoreThan20(SL10DT, SL3DT).Select("")
                'DT.ImportRow(Row)
                'Next Row
                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.Only1Two(SL10DT, SL3DT).Select("")
                'DT.ImportRow(Row)
                'Next Row
                'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.BestSequence(SL10DT, SL3DT).Select("")
                'DT.ImportRow(Row)
                'Next Row
                '               End If
                '
                '                If IsTesting = True AndAlso ModelExplorerDR.Item("STATUS") = True Then

                '                End If
            Catch Ex As Exception
                Call Messages.LogMessages(Ex.ToString, BroadcastTypes.Error)
            End Try
            '            End If

            Return DT
        End Function
        Private Function AustraliaModels(SL10DT As Data.DataTable, SL3DT As Data.DataTable, ModelExplorerDR As Data.DataRow) As Data.DataTable
            Dim DT As Data.DataTable = SQL.View.STATISTICS.DataTable("L10", "TOP 1", Connection).Clone

            If ModelExplorerDR.Item("TYPE").ToString = "GR" OrElse ModelExplorerDR.Item("TYPE").ToString = "H" Then
                Try
                    If IsTesting = False AndAlso ModelExplorerDR.Item("ACTIVE") = True Then
                        For Each Row As Data.DataRow In ModelRun.Models.Australia.Greyhounds.RankMoreThan20(SL10DT, SL3DT).Select("")
                            DT.ImportRow(Row)
                        Next Row
                        For Each Row As Data.DataRow In ModelRun.Models.Australia.Greyhounds.BestSequence(SL10DT, SL3DT).Select("")
                            DT.ImportRow(Row)
                        Next Row
                    End If
                    If IsTesting = True AndAlso ModelExplorerDR.Item("STATUS") = True Then

                        '
                        'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Harness.NewRunners(SL10DT).Select("")
                        'DT.ImportRow(Row)
                        'Next Row

                        ''For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.StatisticsLXGreaterThan80(SL10DT, SL3DT).Select("")
                        'DT.ImportRow(Row)
                        'Next Row
                        'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Harness.StatisticsLXGreaterThan80(SL10DT, SL3DT).Select("")
                        'DT.ImportRow(Row)
                        'Next Row

                        'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Greyhounds.TopDistanceBehind(SL10DT, SL3DT).Select("")
                        'DT.ImportRow(Row)
                        'Next Row
                        'For Each Row As Data.DataRow In ModelRun.Models.NewZealand.Harness.TopDistanceBehind(SL10DT, SL3DT).Select("")
                        'DT.ImportRow(Row)
                        'Next Row
                    End If

                Catch Ex As Exception
                    Call Messages.LogMessages(Ex.ToString, BroadcastTypes.Error)
                End Try
            End If

            Return DT
        End Function
        Private Function FilterForModelExplorer(ModelDataRow As Data.DataRow, OADate As String) As String
            Dim Filter As String = String.Empty

            If Not Information.IsDBNull(ModelDataRow.Item("COUNTRY_ID")) Then
                Filter += "(VENUES.COUNTRY_ID=" & ModelDataRow.Item("COUNTRY_ID").ToString & ") AND "
            End If

            If Not Information.IsDBNull(ModelDataRow.Item("TYPE")) Then
                Filter += "(VENUES.TRACK_TYPE=N'" & ModelDataRow.Item("TYPE").ToString & "') AND "
            End If
            If Not Information.IsDBNull(ModelDataRow.Item("VENUE_ID")) Then
                Filter += "(RACE_XML.VENUE_ID=" & ModelDataRow.Item("VENUE_ID").ToString & ") AND "
            End If

            If Not Information.IsDBNull(ModelDataRow.Item("LENGTH")) Then
                Filter += "(RACE_XML.LENGTH=" & ModelDataRow.Item("LENGTH").ToString & ") AND "
            End If

            Filter += "(MEETING_XML_OADATE = " & OADate & ")"

            Return Filter
        End Function
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    Me.This_StartDate = Nothing
                    Me.This_FinishDate = Nothing
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
End Namespace