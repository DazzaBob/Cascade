Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Partial Class Score
                        Private NotInheritable Class Common
                            Private Sub New()
                                ' Just so the compiler doesnt create a default constructor
                            End Sub
                            Friend Shared ReadOnly Property RankTotal(ByVal MeetingInfo As Instance.MeetingInformation, ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal RunnersInRace As String, ByVal Row As Data.DataRow, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim NUMBER As String = CStr(Row.Item("NUMBER"))
                                    Dim ThisRankTotal As Double = RankTotal(MeetingInfo, RaceInfo, RunnersInRace, Row, DT, sDay) ' 7 Maxims in this method.
                                    '
                                    Dim My_RankTotal As Double = 0.0#
                                    My_RankTotal += GetRuns(MeetingInfo, RaceInfo, Row, sDay)   '1
                                    '
                                    My_RankTotal += GetMinFinishPosition(RunnersInRace, NUMBER, DT, sDay) '2
                                    My_RankTotal += GetAvgFinishPosition(RunnersInRace, NUMBER, DT, sDay) '3
                                    My_RankTotal += GetMaxFinishPosition(RunnersInRace, NUMBER, DT, sDay) '4
                                    '
                                    My_RankTotal += GetSpeedMin(RunnersInRace, NUMBER, DT, sDay) '5
                                    My_RankTotal += GetSpeedAvg(RunnersInRace, NUMBER, DT, sDay)  '6
                                    My_RankTotal += GetSpeedMax(RunnersInRace, NUMBER, DT, sDay)  '7
                                    '
                                    My_RankTotal += GetMinDistanceBehind(RunnersInRace, NUMBER, DT, sDay) ' 8
                                    My_RankTotal += GetAvgDistanceBehind(RunnersInRace, NUMBER, DT, sDay) ' 9
                                    My_RankTotal += GetMaxDistanceBehind(RunnersInRace, NUMBER, DT, sDay) ' 10
                                    '
                                    My_RankTotal += GetWins(RunnersInRace, NUMBER, DT, sDay) ' 11
                                    My_RankTotal += GetPlaces(RunnersInRace, NUMBER, DT, sDay) ' 12
                                    '
                                    My_RankTotal += GetTrend(RunnersInRace, NUMBER, DT, sDay) ' 13
                                    My_RankTotal += GetTrendStatus(RunnersInRace, NUMBER, DT, sDay) ' 14
                                    '
                                    Return ThisRankTotal + My_RankTotal
                                End Get
                            End Property
#Region "                           RUNS "
                            Friend Shared ReadOnly Property GetRuns(ByVal MeetingInfo As Instance.MeetingInformation, ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal Row As Data.DataRow, sDay As String) As Double
                                Get
                                    If CInt(Row.Item("RUNS")) = 0I Then Return 0.0#
                                    '
                                    Dim THIS_RUNNERSINRACE As Integer = RaceInfo.ListOfEntryInformation.Count
                                    Dim Day As Integer = 0I
                                    If sDay <> "" Then Day = CInt(Replace(sDay, "_", ""))
                                    '
                                    Select Case MeetingInfo.TYPE
                                        Case "GR", "H"
                                            Return GetGreyhoundsHarnessRuns(Day, Row, THIS_RUNNERSINRACE)
                                        Case Else
                                            Return GetGallopsRuns(Day, Row, THIS_RUNNERSINRACE)
                                    End Select
                                    '
                                    Return 0.0#
                                End Get
                            End Property
                            ''' <summary>
                            ''' CA 1502 Avoid excessive complexity, so the method was split in two.
                            ''' 
                            ''' </summary>
                            ''' <value>Day, Row, RunnersInRace</value>
                            ''' <returns>How many runs a Greyhound or harness racer has had.</returns>
                            ''' <remarks></remarks>
                            Private Shared ReadOnly Property GetGreyhoundsHarnessRuns(ByVal Day As Integer, ByVal Row As Data.DataRow, ByVal RunnersInRace As Integer) As Double
                                Get
                                    Select Case Day
                                        Case 90
                                            Select Case CInt(Row.Item("RUNS"))
                                                Case Is >= 6
                                                    Return RunnersInRace
                                                Case Else
                                                    Return 0.0#
                                            End Select
                                        Case 180
                                            Select Case CInt(Row.Item("RUNS"))
                                                Case Is >= 12
                                                    Return RunnersInRace
                                                Case Is >= 6
                                                    Return RunnersInRace / 2
                                                Case Else
                                                    Return 0.0#
                                            End Select
                                        Case 270
                                            Select Case CInt(Row.Item("RUNS"))
                                                Case Is >= 18
                                                    Return RunnersInRace
                                                Case Is >= 9
                                                    Return RunnersInRace / 2
                                                Case Is >= 5
                                                    Return RunnersInRace / 4
                                                Case Else
                                                    Return 0.0#
                                            End Select
                                        Case Else
                                            Select Case CInt(Row.Item("RUNS"))
                                                Case Is >= 24
                                                    Return RunnersInRace
                                                Case Is >= 12
                                                    Return RunnersInRace / 2
                                                Case Is >= 6
                                                    Return RunnersInRace / 4
                                                Case Else
                                                    Return 0.0#
                                            End Select
                                    End Select
                                End Get
                            End Property
                            ''' <summary>
                            ''' CA 1502 Avoid excessive complexity, so the method was split in two.
                            ''' 
                            ''' </summary>
                            ''' <value>Day, Row, RunnersInRace</value>
                            ''' <returns>How many runs a Galloper racer has had.</returns>
                            ''' <remarks></remarks>
                            Private Shared ReadOnly Property GetGallopsRuns(ByVal Day As Integer, ByVal Row As Data.DataRow, ByVal RunnersInRace As Integer) As Double
                                Get
                                    Select Case Day
                                        Case 90
                                            Select Case CInt(Row.Item("RUNS"))
                                                Case Is >= 3
                                                    Return RunnersInRace
                                                Case Else
                                                    Return 0.0#
                                            End Select
                                            Exit Select
                                        Case 180
                                            Select Case CInt(Row.Item("RUNS"))
                                                Case Is >= 6
                                                    Return RunnersInRace
                                                Case Is >= 3
                                                    Return RunnersInRace / 2
                                                Case Else
                                                    Return 0.0#
                                            End Select
                                            Exit Select
                                        Case 270
                                            Select Case CInt(Row.Item("RUNS"))
                                                Case Is >= 8
                                                    Return RunnersInRace
                                                Case Is >= 4
                                                    Return RunnersInRace / 2
                                                Case Else
                                                    Return 0.0#
                                            End Select
                                            Exit Select
                                        Case Else
                                            Select Case CInt(Row.Item("RUNS"))
                                                Case Is >= 12
                                                    Return RunnersInRace
                                                Case Is >= 6
                                                    Return RunnersInRace / 2
                                                Case Else
                                                    Return 0.0#
                                            End Select
                                    End Select
                                End Get
                            End Property
#End Region
#Region "                           FINISH POSITION "
                            Private Shared ReadOnly Property GetMinFinishPosition(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "FINISH_POSITION_MIN ASC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item(sDay & "FINISH_POSITION_MIN")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    Return 0.0#
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetAvgFinishPosition(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "FINISH_POSITION_AVG ASC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item(sDay & "FINISH_POSITION_AVG")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    Return 0.0#
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetMaxFinishPosition(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "FINISH_POSITION_MAX ASC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item(sDay & "FINISH_POSITION_MAX")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    Return 0.0#
                                End Get
                            End Property
#End Region
#Region "                           SPEED "
                            Private Shared ReadOnly Property GetSpeedMax(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "SPEED_MAX DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item(sDay & "SPEED_MAX")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                        '
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetSpeedAvg(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "SPEED_AVG DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item(sDay & "SPEED_AVG")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetSpeedMin(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "SPEED_MIN DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item(sDay & "SPEED_MIN")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
#End Region
#Region "                           DISTANCE BEHIND "
                            Private Shared ReadOnly Property GetMinDistanceBehind(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "DISTANCE_BEHIND_MIN ASC")
                                        ROW.Item("RANK1") = 0I
                                        If Not IsDBNull(ROW.Item(sDay & "DISTANCE_BEHIND_MIN")) Then
                                            If (CInt(ROW.Item(sDay & "DISTANCE_BEHIND_MIN")) > 0 OrElse (CInt(ROW.Item(sDay & "DISTANCE_BEHIND_MIN")) = 0 AndAlso CInt(ROW.Item(sDay & "RUNS")) > 0)) Then
                                                ROW.Item("RANK1") = X
                                                X -= 1
                                            End If
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetAvgDistanceBehind(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "DISTANCE_BEHIND_AVG ASC")
                                        ROW.Item("RANK1") = 0I
                                        If Not IsDBNull(ROW.Item(sDay & "DISTANCE_BEHIND_AVG")) Then
                                            If (CInt(ROW.Item(sDay & "DISTANCE_BEHIND_AVG")) > 0 OrElse (CInt(ROW.Item(sDay & "DISTANCE_BEHIND_AVG")) = 0 AndAlso CInt(ROW.Item(sDay & "RUNS")) > 0)) Then
                                                ROW.Item("RANK1") = X
                                                X -= 1
                                            End If
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetMaxDistanceBehind(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "DISTANCE_BEHIND_MAX ASC")
                                        ROW.Item("RANK1") = 0I
                                        If Not IsDBNull(ROW.Item(sDay & "DISTANCE_BEHIND_MAX")) Then
                                            If (CInt(ROW.Item(sDay & "DISTANCE_BEHIND_MAX")) > 0 OrElse (CInt(ROW.Item(sDay & "DISTANCE_BEHIND_MAX")) = 0 AndAlso CInt(ROW.Item(sDay & "RUNS")) > 0)) Then
                                                ROW.Item("RANK1") = X
                                                X -= 1
                                            End If
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
#End Region
#Region "                           WINS/PLACES "
                            Friend Shared ReadOnly Property GetWins(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "WINS DESC")
                                        ROW.Item("RANK1") = 0I
                                        If Not IsDBNull(ROW.Item(sDay & "WINS")) AndAlso CInt(ROW.Item(sDay & "WINS")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
                            Friend Shared ReadOnly Property GetPlaces(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "PLACES DESC")
                                        ROW.Item("RANK1") = 0I
                                        If Not IsDBNull(ROW.Item(sDay & "PLACES")) AndAlso CInt(ROW.Item(sDay & "PLACES")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
#End Region
#Region "                           TRENDS "
                            Private Shared ReadOnly Property GetTrend(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim X As Integer = RunnersInRace
                                    For Each ROW As Data.DataRow In DT.Select("", sDay & "TREND DESC")
                                        ROW.Item("RANK1") = X
                                        X -= 1
                                        If ROW.Item("NUMBER") = EntryNumber Then Return CDbl(ROW.Item("RANK1"))
                                    Next ROW
                                    '
                                    Return 0.0#
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetTrendStatus(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal DT As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim DR() As Data.DataRow = DT.Select("NUMBER=" & EntryNumber)
                                    Select Case CInt(DR(0).Item(sDay & "TREND_STATUS"))
                                        Case 0
                                            Return 0
                                        Case Is < 0
                                            Return -RunnersInRace
                                        Case Else
                                            Return RunnersInRace
                                    End Select
                                End Get
                            End Property
#End Region
                            Friend Shared ReadOnly Property GetBarrierRanks(ByVal RunnersInRace As Integer, ByVal EntryBarrier As String, ByVal RaceBarrierDT As Data.DataTable) As Integer
                                Get
                                    On Error Resume Next
                                    '
                                    Dim X As Integer = RunnersInRace, BarrierRankTotal As Integer = 0
                                    For Each ROW As Data.DataRow In RaceBarrierDT.Select("", "ALL_WINS DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item("ALL_WINS")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    Next ROW
                                    '
                                    Dim DR() As Data.DataRow = RaceBarrierDT.Select("BARRIER=" & EntryBarrier)
                                    BarrierRankTotal += CInt(DR(0).Item("RANK1"))
                                    '
                                    X = RunnersInRace
                                    For Each ROW As Data.DataRow In RaceBarrierDT.Select("", "ALL_PLACES DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item("ALL_PLACES")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    Next ROW
                                    DR = RaceBarrierDT.Select("BARRIER=" & EntryBarrier)
                                    BarrierRankTotal += CInt(DR(0).Item("RANK1"))
                                    '
                                    X = RunnersInRace
                                    For Each ROW As Data.DataRow In RaceBarrierDT.Select("", "90_WINS DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item("90_WINS")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    Next ROW
                                    DR = RaceBarrierDT.Select("BARRIER=" & EntryBarrier)
                                    BarrierRankTotal += CInt(DR(0).Item("RANK1"))
                                    '
                                    X = RunnersInRace
                                    For Each ROW As Data.DataRow In RaceBarrierDT.Select("", "90_PLACES DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item("90_PLACES")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    Next ROW
                                    DR = RaceBarrierDT.Select("BARRIER=" & EntryBarrier)
                                    BarrierRankTotal += CInt(DR(0).Item("RANK1"))
                                    '
                                    Return BarrierRankTotal / 4
                                End Get
                            End Property
                            Friend Shared ReadOnly Property GetJockeyRanks(ByVal RunnersInRace As Integer, ByVal Jockey As String, ByVal JockeyDT As Data.DataTable) As Integer
                                Get
                                    On Error Resume Next
                                    '
                                    Dim X As Integer = RunnersInRace, BarrierRankTotal As Integer = 0
                                    For Each ROW As Data.DataRow In JockeyDT.Select("", "ALL_WINS DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item("ALL_WINS")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    Next ROW
                                    '
                                    Dim DR() As Data.DataRow = JockeyDT.Select("NAME='" & Jockey & "'")
                                    BarrierRankTotal += CInt(DR(0).Item("RANK1"))
                                    '
                                    X = RunnersInRace
                                    For Each ROW As Data.DataRow In JockeyDT.Select("", "ALL_PLACES DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item("ALL_PLACES")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    Next ROW
                                    DR = JockeyDT.Select("NAME='" & Jockey & "'")
                                    BarrierRankTotal += CInt(DR(0).Item("RANK1"))
                                    '
                                    X = RunnersInRace
                                    For Each ROW As Data.DataRow In JockeyDT.Select("", "90_WINS DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item("90_WINS")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    Next ROW
                                    DR = JockeyDT.Select("NAME='" & Jockey & "'")
                                    BarrierRankTotal += CInt(DR(0).Item("RANK1"))
                                    '
                                    X = RunnersInRace
                                    For Each ROW As Data.DataRow In JockeyDT.Select("", "90_PLACES DESC")
                                        ROW.Item("RANK1") = 0I
                                        If CInt(ROW.Item("90_PLACES")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    Next ROW
                                    DR = JockeyDT.Select("NAME='" & Jockey & "'")
                                    BarrierRankTotal += CInt(DR(0).Item("RANK1"))
                                    '
                                    Return BarrierRankTotal / 4
                                End Get
                            End Property

                        End Class
                    End Class
                End Class
            End Class
        End Class
    End Class
End Namespace