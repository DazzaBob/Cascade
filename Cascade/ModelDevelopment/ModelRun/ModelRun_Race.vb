Namespace ModelDevelopment
    Partial Class ModelRun
        Private NotInheritable Class Race : Implements IDisposable
            Private RecordCollection As RecordCollection
            '
            Private Filter As String
            '
            Friend RI_B_DT As Data.DataTable
            Friend EI_DT As Data.DataTable
            Friend EI_D_DT As Data.DataTable, EI_D_S_DT As Data.DataTable
            Friend EI_D_T_DT As Data.DataTable, EI_D_T_S_DT As Data.DataTable
            Friend EI_G_DT As Data.DataTable, EI_G_S_DT As Data.DataTable
            Friend EI_G_T_DT As Data.DataTable, EI_G_T_S_DT As Data.DataTable
            Friend EI_O_DT As Data.DataTable, EI_O_S_DT As Data.DataTable
            Friend EI_O_T_DT As Data.DataTable, EI_O_T_S_DT As Data.DataTable
            Friend Sub New(ByRef RecordCollection As RecordCollection)
                Me.RecordCollection = RecordCollection
                '
                Me.RI_B_DT = RecordCollection.RaceInfoBarrierDT.Clone
                Me.EI_DT = RecordCollection.EntryInfoDT.Clone
                Me.EI_D_DT = RecordCollection.EntryInfoDistanceDT.Clone
                Me.EI_D_S_DT = RecordCollection.EntryInfoDistanceScoreDT.Clone
                Me.EI_D_T_DT = RecordCollection.EntryInfoDistanceTheoDT.Clone
                Me.EI_D_T_S_DT = RecordCollection.EntryInfoDistanceTheoScoreDT.Clone
                Me.EI_G_DT = RecordCollection.EntryInfoGroupDT.Clone
                Me.EI_G_S_DT = RecordCollection.EntryInfoGroupScoreDT.Clone
                Me.EI_G_T_DT = RecordCollection.EntryInfoGroupTheoDT.Clone
                Me.EI_G_T_S_DT = RecordCollection.EntryInfoGroupTheoScoreDT.Clone
                Me.EI_O_DT = RecordCollection.EntryInfoOverAllDT.Clone
                Me.EI_O_S_DT = RecordCollection.EntryInfoOverAllScoreDT.Clone
                Me.EI_O_T_DT = RecordCollection.EntryInfoOverAllTheoDT.Clone
                Me.EI_O_T_S_DT = RecordCollection.EntryInfoOverAllTheoScoreDT.Clone
            End Sub
            Friend Function SetDataTables(ByVal RaceInfoDR As Data.DataRow) As Boolean
                '
                Me.Filter = "(MEETING_INFO_OADATE=" & RaceInfoDR.Item("MEETING_INFO_OADATE").ToString & ") "
                Me.Filter = String.Concat(Me.Filter, " AND (MEETING_INFO_NUMBER=" & RaceInfoDR.Item("MEETING_INFO_NUMBER").ToString & ") ")
                Me.Filter = String.Concat(Me.Filter, " AND (RACE_INFO_NUMBER=" & RaceInfoDR.Item("NUMBER").ToString & ") ")
                '
                For Each SUB_ROW As Data.DataRow In RecordCollection.RaceInfoBarrierDT.Select(Filter) : RI_B_DT.ImportRow(SUB_ROW) : Next SUB_ROW

                If Not Me.SetEntryInfo Then Return False
                If Not Me.SetEntryInfoDistance Then Return False
                If Not Me.SetEntryInfoGroup Then Return False
                If Not Me.SetEntryInfoOverAll Then Return False
                '
                Return True
            End Function
            Private Function SetEntryInfo() As Boolean
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoDT.Select(Me.Filter) : EI_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                '
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
            End Function
            Private Function SetEntryInfoDistance() As Boolean
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoDistanceDT.Select(Me.Filter) : EI_D_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoDistanceScoreDT.Select(Me.Filter) : EI_D_S_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoDistanceTheoDT.Select(Me.Filter) : EI_D_T_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoDistanceTheoScoreDT.Select(Me.Filter) : EI_D_T_S_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                '
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
            End Function
            Private Function SetEntryInfoGroup() As Boolean
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoGroupDT.Select(Me.Filter) : EI_G_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoGroupScoreDT.Select(Me.Filter) : EI_G_S_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoGroupTheoDT.Select(Me.Filter) : EI_G_T_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoGroupTheoScoreDT.Select(Me.Filter) : EI_G_T_S_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                '
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
            End Function
            Private Function SetEntryInfoOverAll() As Boolean
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoOverAllDT.Select(Me.Filter) : EI_O_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoOverAllScoreDT.Select(Me.Filter) : EI_O_S_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoOverAllTheoDT.Select(Me.Filter) : EI_O_T_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                For Each SUB_ROW As Data.DataRow In RecordCollection.EntryInfoOverAllTheoScoreDT.Select(Me.Filter) : EI_O_T_S_DT.ImportRow(SUB_ROW) : Next SUB_ROW
                '
                Application.DoEvents()
                If ModelRun.CancelModelRun Then Return False Else Return True
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
                    If RI_B_DT IsNot Nothing Then RI_B_DT.Dispose() : RI_B_DT = Nothing
                    If EI_DT IsNot Nothing Then EI_DT.Dispose() : EI_DT = Nothing
                    If EI_D_DT IsNot Nothing Then EI_D_DT.Dispose() : EI_D_DT = Nothing
                    If EI_D_S_DT IsNot Nothing Then EI_D_S_DT.Dispose() : EI_D_S_DT = Nothing
                    If EI_D_T_DT IsNot Nothing Then EI_D_T_DT.Dispose() : EI_D_T_DT = Nothing
                    If EI_D_T_S_DT IsNot Nothing Then EI_D_T_S_DT.Dispose() : EI_D_T_S_DT = Nothing
                    If EI_G_DT IsNot Nothing Then EI_G_DT.Dispose() : EI_G_DT = Nothing
                    If EI_G_S_DT IsNot Nothing Then EI_G_S_DT.Dispose() : EI_G_S_DT = Nothing
                    If EI_G_T_DT IsNot Nothing Then EI_G_T_DT.Dispose() : EI_G_T_DT = Nothing
                    If EI_G_T_S_DT IsNot Nothing Then EI_G_T_S_DT.Dispose() : EI_G_T_S_DT = Nothing
                    If EI_O_DT IsNot Nothing Then EI_O_DT.Dispose() : EI_O_DT = Nothing
                    If EI_O_S_DT IsNot Nothing Then EI_O_S_DT.Dispose() : EI_O_S_DT = Nothing
                    If EI_O_T_DT IsNot Nothing Then EI_O_T_DT.Dispose() : EI_O_T_DT = Nothing
                    If EI_O_T_S_DT IsNot Nothing Then EI_O_T_S_DT.Dispose() : EI_O_T_S_DT = Nothing
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