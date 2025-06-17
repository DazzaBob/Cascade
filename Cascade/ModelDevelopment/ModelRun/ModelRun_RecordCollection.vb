Namespace ModelDevelopment
    Partial Class ModelRun
        Private NotInheritable Class RecordCollection : Implements IDisposable
            Private TSS_Label As ToolStripLabel = Nothing
            Private Connection As Connection = Nothing
            Private Where As String = Nothing
            '
            Friend RaceInfoDT As Data.DataTable, RaceInfoBarrierDT As Data.DataTable
            Friend EntryInfoDT As Data.DataTable
            '
            Friend EntryInfoDistanceDT As Data.DataTable, EntryInfoDistanceScoreDT As Data.DataTable
            Friend EntryInfoDistanceTheoDT As Data.DataTable, EntryInfoDistanceTheoScoreDT As Data.DataTable
            '
            Friend EntryInfoGroupDT As Data.DataTable, EntryInfoGroupScoreDT As Data.DataTable
            Friend EntryInfoGroupTheoDT As Data.DataTable, EntryInfoGroupTheoScoreDT As Data.DataTable
            '
            Friend EntryInfoOverAllDT As Data.DataTable, EntryInfoOverAllScoreDT As Data.DataTable
            Friend EntryInfoOverAllTheoDT As Data.DataTable, EntryInfoOverAllTheoScoreDT As Data.DataTable
            Friend Sub New(ByVal Where As String, ByVal Connection As Connection, ByRef TSSLabel As ToolStripLabel)
                Me.TSS_Label = TSSLabel
                Me.Connection = Connection
                Me.Where = Where
            End Sub
            Friend Function SetDataTables() As Boolean
                If Not SetRaceInfo() Then Return False
                If Not SetEntryInfo() Then Return False
                If Not SetEntryInfoDistance() Then Return False
                If Not SetEntryInfoGroup() Then Return False
                If Not SetEntryInfoOverAll() Then Return False
                '
                Return True
            End Function
            Private Function SetRaceInfo() As Boolean
                If Not Me.TSS_Label Is Nothing Then Me.TSS_Label.Text = "Collecting Race Information Records..." : Application.DoEvents()
                '
                Me.RaceInfoDT = Cascade.StoredProcedures.RACE_INFO.GetModelRunDataTable(Me.Where, Me.Connection)
                Me.RaceInfoBarrierDT = Cascade.StoredProcedures.RACE_INFO_BARRIER.GetModelRunDataTable(Me.Where, Me.Connection)
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
            End Function
            Private Function SetEntryInfo() As Boolean
                If Not Me.TSS_Label Is Nothing Then Me.TSS_Label.Text = "Collecting Entry Information Records..." : Application.DoEvents()
                '
                Me.EntryInfoDT = Me.GetDataTable(Me.Where, "ENTRY_INFO")
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
            End Function
            Private Function SetEntryInfoDistance() As Boolean
                If Not Me.TSS_Label Is Nothing Then Me.TSS_Label.Text = "Collecting Entry Distance Information Records..." : Application.DoEvents()
                '
                Me.EntryInfoDistanceDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_DISTANCE")
                Me.EntryInfoDistanceScoreDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_DISTANCE_SCORE")
                Me.EntryInfoDistanceTheoDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_DISTANCE_THEO")
                Me.EntryInfoDistanceTheoScoreDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_DISTANCE_THEO_SCORE")
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
            End Function
            Private Function SetEntryInfoGroup() As Boolean
                If Not Me.TSS_Label Is Nothing Then Me.TSS_Label.Text = "Collecting Entry Group Information Records..." : Application.DoEvents()
                '
                Me.EntryInfoGroupDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_GROUP")
                Me.EntryInfoGroupScoreDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_GROUP_SCORE")
                Me.EntryInfoGroupTheoDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_GROUP_THEO")
                Me.EntryInfoGroupTheoScoreDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_GROUP_THEO_SCORE")
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
            End Function
            Private Function SetEntryInfoOverAll() As Boolean
                If Not Me.TSS_Label Is Nothing Then Me.TSS_Label.Text = "Collecting Entry OverAll Information Records..." : Application.DoEvents()
                '
                Me.EntryInfoOverAllDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_OVERALL")
                Me.EntryInfoOverAllScoreDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_OVERALL_SCORE")
                Me.EntryInfoOverAllTheoDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_OVERALL_THEO")
                Me.EntryInfoOverAllTheoScoreDT = Me.GetDataTable(Me.Where, "ENTRY_INFO_OVERALL_THEO_SCORE")
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
            End Function
            Private Function GetDataTable(ByVal Filter As String, ByVal Table As String) As Data.DataTable
                Dim CMDTEXT As String = "SELECT MEETING_INFO.COUNTRY, MEETING_INFO.TYPE, RACE_INFO.LENGTH, RACE_INFO.WEATHER, RACE_INFO.VENUE, RACE_INFO.TRACK, RACE_INFO.RUNNERSINRACE,"
                CMDTEXT = String.Concat(CMDTEXT, " " & Table & ".*")
                CMDTEXT = String.Concat(CMDTEXT, " FROM " & Table & " INNER JOIN")
                CMDTEXT = String.Concat(CMDTEXT, " RACE_INFO ON " & Table & ".MEETING_INFO_OADATE = RACE_INFO.MEETING_INFO_OADATE AND")
                CMDTEXT = String.Concat(CMDTEXT, " " & Table & ".MEETING_INFO_NUMBER = RACE_INFO.MEETING_INFO_NUMBER AND " & Table & ".RACE_INFO_NUMBER = RACE_INFO.NUMBER INNER JOIN")
                CMDTEXT = String.Concat(CMDTEXT, " MEETING_INFO ON RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE AND RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER")
                CMDTEXT = String.Concat(CMDTEXT, " " & Filter)
                '
                Return Connection.GetDataTable(CMDTEXT)
            End Function
#Region "IDisposable Support"
            Private disposedValue As Boolean ' To detect redundant calls

            ' IDisposable
            Private Sub Dispose(disposing As Boolean)
                If Not Me.disposedValue Then
                    If disposing Then
                        ' TODO: dispose managed state (managed objects).
                    End If
                    '
                    If Not RaceInfoDT Is Nothing Then RaceInfoDT.Dispose() : RaceInfoDT = Nothing
                    If Not RaceInfoBarrierDT Is Nothing Then RaceInfoBarrierDT.Dispose() : RaceInfoBarrierDT = Nothing
                    '
                    If Not EntryInfoDT Is Nothing Then EntryInfoDT.Dispose() : EntryInfoDT = Nothing
                    '
                    If Not EntryInfoDistanceDT Is Nothing Then EntryInfoDistanceDT.Dispose() : EntryInfoDistanceDT = Nothing
                    If Not EntryInfoDistanceScoreDT Is Nothing Then EntryInfoDistanceScoreDT.Dispose() : EntryInfoDistanceScoreDT = Nothing
                    '
                    If Not EntryInfoDistanceTheoDT Is Nothing Then EntryInfoDistanceTheoDT.Dispose() : EntryInfoDistanceTheoDT = Nothing
                    If Not EntryInfoDistanceTheoScoreDT Is Nothing Then EntryInfoDistanceTheoScoreDT.Dispose() : EntryInfoDistanceTheoScoreDT = Nothing
                    '
                    If Not EntryInfoGroupDT Is Nothing Then EntryInfoGroupDT.Dispose() : EntryInfoGroupDT = Nothing
                    If Not EntryInfoGroupScoreDT Is Nothing Then EntryInfoGroupScoreDT.Dispose() : EntryInfoGroupScoreDT = Nothing
                    '
                    If Not EntryInfoGroupTheoDT Is Nothing Then EntryInfoGroupTheoDT.Dispose() : EntryInfoGroupTheoDT = Nothing
                    If Not EntryInfoGroupTheoScoreDT Is Nothing Then EntryInfoGroupTheoScoreDT.Dispose() : EntryInfoGroupTheoScoreDT = Nothing
                    '
                    If Not EntryInfoOverAllDT Is Nothing Then EntryInfoOverAllDT.Dispose() : EntryInfoOverAllDT = Nothing
                    If Not EntryInfoOverAllScoreDT Is Nothing Then EntryInfoOverAllScoreDT.Dispose() : EntryInfoOverAllScoreDT = Nothing
                    '
                    If Not EntryInfoOverAllTheoDT Is Nothing Then EntryInfoOverAllTheoDT.Dispose() : EntryInfoOverAllTheoDT = Nothing
                    If Not EntryInfoOverAllTheoScoreDT Is Nothing Then EntryInfoOverAllTheoScoreDT.Dispose() : EntryInfoOverAllTheoScoreDT = Nothing
                End If
                Me.disposedValue = True
            End Sub

            ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
            'Protected Overrides Sub Finalize()
            '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
            '    Dispose(False)
            '    MyBase.Finalize()
            'End Sub

            ' This code added by Visual Basic to correctly implement the disposable pattern.
            Friend Sub Dispose() Implements IDisposable.Dispose
                ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
                Dispose(True)
                GC.SuppressFinalize(Me)
            End Sub
#End Region

        End Class
    End Class
End Namespace