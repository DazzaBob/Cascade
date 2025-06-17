Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Private NotInheritable Class Barrier : Implements IDisposable
                    Private MeetingInformation As Instance.MeetingInformation
                    Private RaceInformation As Instance.MeetingInformation.RaceInformation
                    Private Connection As Connection
                    Private DT As Data.DataTable = Nothing
                    Private BarriersInRace As String = Nothing
                    Private BarrierCount As Short = 0S
                    Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal Connection As Connection)
                        Me.MeetingInformation = MeetingInformation
                        Me.RaceInformation = RaceInformation
                        Me.Connection = Connection
                        '
                        For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.RaceInformation.ListOfEntryInformation
                            If ENTRY.SCRATCHED = "1" Then Continue For
                            Me.BarriersInRace += ENTRY.BARRIER & ", "
                            Me.BarrierCount += 1
                        Next
                        If Me.BarriersInRace.Length > 0 Then Me.BarriersInRace = Strings.Left(Me.BarriersInRace, Me.BarriersInRace.Length - 2)
                        '
                        Me.DT = Me.GetDataTable
                    End Sub
                    Friend Sub Begin()
                        Dim CMDTEXT As String = Nothing
                        '
                        For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.RaceInformation.ListOfEntryInformation
                            If ENTRY.SCRATCHED = "1" Then Continue For
                            Dim INSERT As String = "INSERT INTO RACE_INFO_BARRIER ([MEETING_INFO_OADATE], [MEETING_INFO_NUMBER], [RACE_INFO_NUMBER], [BARRIER]"
                            Dim VALUES As String = "VALUES (" & Me.MeetingInformation.OADATE & ", " & Me.MeetingInformation.NUMBER & ", " & Me.RaceInformation.NUMBER & ", " & ENTRY.BARRIER
                            Dim RANK As Decimal = 0D
                            Call SetInsertValues(ENTRY, "ALL", INSERT, VALUES)
                            Call SetInsertValues(ENTRY, "90", INSERT, VALUES)
                            Call SetInsertValues(ENTRY, "180", INSERT, VALUES)
                            Call SetInsertValues(ENTRY, "270", INSERT, VALUES)
                            INSERT += ") " : VALUES += ") " & vbCrLf
                            '
                            CMDTEXT += INSERT & VALUES
                        Next ENTRY
                        '
                        Call Connection.Execute(CMDTEXT)
                        Dim Broadcast As String = " Inserted Barrier Information for M" & Me.MeetingInformation.NUMBER & "R" & Me.RaceInformation.NUMBER
                        Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                    End Sub
                    Private Sub SetInsertValues(ByVal ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation, ByVal DAY As String, ByRef INSERT As String, ByRef VALUES As String)
                        Dim DTFilter As String = "BARRIER=" & ENTRY.BARRIER & Me.GetDayFilter(DAY)
                        If (DT.Select(DTFilter).Length - 1) < 1 Then Return
                        '
                        Dim RUNS As Long = DT.Select(DTFilter).Length - 1
                        Dim WIN_COUNT As Double = 0.0#, PLACE_COUNT As Double = 0.0#
                        WIN_COUNT = CDbl(DT.Compute("COUNT(BARRIER)", "(RESULT_FINISH_POSITION =  1) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(DAY)))
                        PLACE_COUNT = CDbl(DT.Compute("COUNT(BARRIER)", "(RESULT_FINISH_POSITION =  1 OR RESULT_FINISH_POSITION =  2 OR RESULT_FINISH_POSITION =  3) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(DAY)))
                        '
                        Dim SPEED_MIN As String = "0", SPEED_AVG As String = "0", SPEED_MAX As String = "0"
                        Dim FINISHPOSITION_MIN As String = "0", FINISHPOSITION_AVG As String = "0", FINISHPOSITION_MAX As String = "0"
                        Dim DISTANCEBEHIND_MIN As String = "0", DISTANCEBEHIND_AVG As String = "0", DISTANCEBEHIND_MAX As String = "0"
                        '
                        Call SetSpeed(SPEED_MIN, SPEED_AVG, SPEED_MAX, ENTRY, DAY)
                        Call SetFinishPosition(FINISHPOSITION_MIN, FINISHPOSITION_AVG, FINISHPOSITION_MAX, ENTRY, DAY)
                        Call SetDistanceBehind(DISTANCEBEHIND_MIN, DISTANCEBEHIND_AVG, DISTANCEBEHIND_MAX, ENTRY, DAY)
                        '
                        Dim WIN_PERCENT As Double = 0.0#, PLACE_PERCENT As Double = 0.0#
                        WIN_PERCENT = CDbl(WIN_COUNT / RUNS) * 100
                        PLACE_PERCENT = (CDbl(PLACE_COUNT / RUNS) * 100) / 3
                        '
                        INSERT += ", [" & DAY & "_RUNS]" : VALUES += ", " & CStr(RUNS)
                        INSERT += ", [" & DAY & "_WINS]" : VALUES += ", " & CStr(WIN_PERCENT)
                        INSERT += ", [" & DAY & "_PLACES]" : VALUES += ", " & CStr(PLACE_PERCENT)
                        '
                        INSERT += ", [" & DAY & "_SPEED_AVG]" : VALUES += ", " & SPEED_AVG
                        INSERT += ", [" & DAY & "_SPEED_MIN]" : VALUES += ", " & SPEED_MIN
                        INSERT += ", [" & DAY & "_SPEED_MAX]" : VALUES += ", " & SPEED_MAX
                        '
                        INSERT += ", [" & DAY & "_DISTANCE_BEHIND_AVG]" : VALUES += ", " & DISTANCEBEHIND_AVG
                        INSERT += ", [" & DAY & "_DISTANCE_BEHIND_MIN]" : VALUES += ", " & DISTANCEBEHIND_MIN
                        INSERT += ", [" & DAY & "_DISTANCE_BEHIND_MAX]" : VALUES += ", " & DISTANCEBEHIND_MAX
                        '
                        INSERT += ", [" & DAY & "_FINISH_POSITION_AVG]" : VALUES += ", " & FINISHPOSITION_AVG
                        INSERT += ", [" & DAY & "_FINISH_POSITION_MIN]" : VALUES += ", " & FINISHPOSITION_MIN
                        INSERT += ", [" & DAY & "_FINISH_POSITION_MAX]" : VALUES += ", " & FINISHPOSITION_MAX
                        INSERT += ", [" & DAY & "_RANK]" : VALUES += ", " & GetRank(ENTRY, DAY)
                    End Sub
                    Private Sub SetSpeed(ByRef Min As String, ByRef Avg As String, ByRef Max As String, ByVal ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation, ByVal Day As String)
                        On Error Resume Next
                        '
                        Min = Me.DT.Compute("MIN(RESULT_SPEED)", "(RESULT_SPEED > 0) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                        Avg = Me.DT.Compute("AVG(RESULT_SPEED)", "(RESULT_SPEED > 0) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                        Max = Me.DT.Compute("MAX(RESULT_SPEED)", "(RESULT_SPEED > 0) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                    End Sub
                    Private Sub SetFinishPosition(ByRef Min As String, ByRef Avg As String, ByRef Max As String, ByVal ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation, ByVal Day As String)
                        On Error Resume Next
                        '
                        Min = Me.DT.Compute("MIN(RESULT_FINISH_POSITION)", "(RESULT_FINISH_POSITION >  0) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                        Avg = Me.DT.Compute("AVG(RESULT_FINISH_POSITION)", "(RESULT_FINISH_POSITION >  0) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                        Max = Me.DT.Compute("MAX(RESULT_FINISH_POSITION)", "(RESULT_FINISH_POSITION >  0) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                    End Sub
                    Private Sub SetDistanceBehind(ByRef Min As String, ByRef Avg As String, ByRef Max As String, ByVal ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation, ByVal Day As String)
                        On Error Resume Next
                        '
                        Min = Me.DT.Compute("MIN(RESULT_DISTANCE_BEHIND)", "RESULT_FINISH_POSITION >  1 AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                        Avg = Me.DT.Compute("AVG(RESULT_DISTANCE_BEHIND)", "RESULT_FINISH_POSITION > 0 AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                        Max = Me.DT.Compute("MAX(RESULT_DISTANCE_BEHIND)", "RESULT_FINISH_POSITION >  0 AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day))
                    End Sub
                    Private Function GetRank(ByVal ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation, ByVal Day As String) As String
                        Dim RUNS As Long = DT.Select("BARRIER=" & ENTRY.BARRIER & GetDayFilter(Day)).Length - 1
                        If RUNS = 0 Then Return "0"
                        '
                        Dim RANKPERCENT As Single = 0.0!
                        Dim WIN_COUNT As Single = 0.0!, PLACE_COUNT As Single = 0.0!
                        WIN_COUNT = CSng(DT.Compute("COUNT(BARRIER)", "(RESULT_FINISH_POSITION =  1) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day)))
                        PLACE_COUNT = CSng(DT.Compute("COUNT(BARRIER)", "(RESULT_FINISH_POSITION =  1 OR RESULT_FINISH_POSITION =  2 OR RESULT_FINISH_POSITION =  3) AND (BARRIER=" & ENTRY.BARRIER & ")" & GetDayFilter(Day)))
                        RANKPERCENT += CDec((WIN_COUNT / RUNS) * 100) * 2
                        RANKPERCENT += CDec((PLACE_COUNT / RUNS) * 100) / 3
                        RANKPERCENT /= 2
                        Return CStr(RANKPERCENT)
                    End Function
                    Function GetDataTable() As Data.DataTable
                        Dim CMDTEXT As String = "SELECT RACE_INFO.MEETING_INFO_OADATE AS OADATE, ENTRY_INFO.BARRIER, ISNULL(ENTRY_INFO.RESULT_POOL_WIN, 0) AS RESULT_POOL_WIN, ISNULL(ENTRY_INFO.RESULT_POOL_PLACE, 0) AS RESULT_POOL_PLACE, ISNULL(ENTRY_INFO.RESULT_SPEED,0) AS RESULT_SPEED,  ISNULL(ENTRY_INFO.RESULT_DISTANCE_BEHIND,0) AS RESULT_DISTANCE_BEHIND, ISNULL(ENTRY_INFO.RESULT_FINISH_POSITION,0) AS RESULT_FINISH_POSITION "
                        CMDTEXT += "FROM RACE_INFO INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER AND RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER "
                        CMDTEXT += "WHERE (RACE_INFO.LENGTH=" & Me.RaceInformation.LENGTH & ") AND (RACE_INFO.VENUE = N'" & Me.RaceInformation.VENUE & "') AND (RACE_INFO.WEATHER = N'" & Me.RaceInformation.WEATHER & "') AND (RACE_INFO.TRACK = N'" & Me.RaceInformation.TRACK & "') AND (ENTRY_INFO.BARRIER IN(" & Me.BarriersInRace & ")) AND "
                        CMDTEXT += "(RACE_INFO.RUNNERSINRACE=" & Me.BarrierCount & ") AND "
                        CMDTEXT += "(RACE_INFO.MEETING_INFO_OADATE >= " & CStr(CInt(Me.MeetingInformation.OADATE) - 365) & " AND RACE_INFO.MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ") "
                        CMDTEXT += " ORDER BY RACE_INFO.MEETING_INFO_OADATE ASC"
                        '
                        Return Me.Connection.GetDataTable(CMDTEXT)
                    End Function
                    Private Function GetDayFilter(ByVal Day As String) As String
                        If Day = "ALL" Then Return ""
                        Return " AND (OADATE >= " & CStr(CInt(Me.MeetingInformation.OADATE) - CInt(Day) + 1) & " AND OADATE < " & Me.MeetingInformation.OADATE & ")"
                    End Function
#Region "                   IDisposable Support"
                    Private disposedValue As Boolean ' To detect redundant calls

                    ' IDisposable
                    Protected Sub Dispose(disposing As Boolean)
                        If Not Me.disposedValue Then
                            If disposing Then
                                ' TODO: dispose managed state (managed objects).
                            End If
                            If Me.DT IsNot Nothing Then DT.Dispose() : DT = Nothing
                            If Me.BarriersInRace IsNot Nothing Then Me.BarriersInRace = Nothing
                            Me.BarrierCount = Nothing
                            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                            ' TODO: set large fields to null.
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
                    Public Sub Dispose() Implements IDisposable.Dispose
                        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
                        Dispose(True)
                        GC.SuppressFinalize(Me)
                    End Sub
#End Region
                End Class
            End Class
        End Class
    End Class
End Namespace