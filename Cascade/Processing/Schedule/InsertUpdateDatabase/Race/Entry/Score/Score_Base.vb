Namespace ServerUI.Processing.Schedule
    Partial Class EntryPoint
        Partial Class Meeting
            Partial Class Race
                Partial Class Entry
                    Partial Class Score
                        Private NotInheritable Class Base
                            Private Sub New()
                                ' Just so the compiler doesnt create a default constructor
                            End Sub
                            Friend Shared ReadOnly Property RankTotal(ByVal RunnersInRace As String, ByVal NUMBER As String, ByVal Row As Data.DataRow, ByVal SectionDataTable As Data.DataTable) As Double
                                Get
                                    Dim ThisRankTotal As Double = 0.0#
                                    '
                                    Call SetLastRan(RunnersInRace, NUMBER, SectionDataTable, ThisRankTotal) ' 1
                                    Call SetLastSpeed(RunnersInRace, NUMBER, SectionDataTable, ThisRankTotal) ' 2
                                    Call SetLastDistanceBehind(RunnersInRace, NUMBER, SectionDataTable, ThisRankTotal) ' 3
                                    '
                                    Call SetLastPreviousRan(RunnersInRace, NUMBER, SectionDataTable, ThisRankTotal)  '4
                                    Call SetLastPreviousSpeed(RunnersInRace, NUMBER, SectionDataTable, ThisRankTotal) ' 5
                                    Call SetLastPreviousDistanceBehind(RunnersInRace, NUMBER, SectionDataTable, ThisRankTotal) ' 6
                                    '
                                    Call SetLastDSLR(RunnersInRace, Row, ThisRankTotal) ' 7
                                    '
                                    Return ThisRankTotal
                                End Get
                            End Property
                            Private Shared Sub SetLastRan(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal SectionDataTable As Data.DataTable, ByRef RankTotal As Double)
                                Dim X As Integer = RunnersInRace
                                For Each ROW As Data.DataRow In SectionDataTable.Select("", "LAST_RAN ASC")
                                    ROW.Item("RANK1") = 0I
                                    If Not IsDBNull(ROW.Item("LAST_RAN")) AndAlso CInt(ROW.Item("LAST_RAN")) > 0 Then
                                        ROW.Item("RANK1") = X
                                        X -= 1
                                    End If
                                    '
                                    If CInt(ROW.Item("NUMBER")) = EntryNumber Then RankTotal += CDbl(ROW.Item("RANK1")) : Exit For
                                Next ROW
                            End Sub
                            Private Shared Sub SetLastSpeed(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal SectionDataTable As Data.DataTable, ByRef RankTotal As Double)
                                Dim X As Integer = RunnersInRace
                                For Each ROW As Data.DataRow In SectionDataTable.Select("", "LAST_SPEED DESC")
                                    ROW.Item("RANK1") = 0I
                                    If Not IsDBNull(ROW.Item("LAST_SPEED")) AndAlso CInt(ROW.Item("LAST_SPEED")) > 0 Then
                                        ROW.Item("RANK1") = X
                                        X -= 1
                                    End If
                                    '
                                    If CInt(ROW.Item("NUMBER")) = EntryNumber Then RankTotal += CDbl(ROW.Item("RANK1")) : Exit For
                                Next ROW
                            End Sub
                            Private Shared Sub SetLastDistanceBehind(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal SectionDataTable As Data.DataTable, ByRef RankTotal As Double)
                                Dim X As Integer = RunnersInRace
                                For Each ROW As Data.DataRow In SectionDataTable.Select("", "LAST_DISTANCE_BEHIND ASC")
                                    ROW.Item("RANK1") = 0I
                                    If Not IsDBNull(ROW.Item("LAST_DISTANCE_BEHIND")) Then
                                        If CInt(ROW.Item("RUNS")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    End If
                                    '
                                    If CInt(ROW.Item("NUMBER")) = EntryNumber Then RankTotal += CDbl(ROW.Item("RANK1")) : Exit For
                                Next ROW
                            End Sub
                            Private Shared Sub SetLastPreviousRan(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal SectionDataTable As Data.DataTable, ByRef RankTotal As Double)
                                Dim X As Integer = RunnersInRace
                                For Each ROW As Data.DataRow In SectionDataTable.Select("", "LAST_PREVIOUS_RAN ASC")
                                    ROW.Item("RANK1") = 0I
                                    If Not IsDBNull(ROW.Item("LAST_PREVIOUS_RAN")) AndAlso CInt(ROW.Item("LAST_PREVIOUS_RAN")) > 0 Then
                                        ROW.Item("RANK1") = X
                                        X -= 1
                                    End If
                                    '
                                    If CInt(ROW.Item("NUMBER")) = EntryNumber Then RankTotal += CDbl(ROW.Item("RANK1")) : Exit For
                                Next ROW
                            End Sub
                            Private Shared Sub SetLastPreviousSpeed(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal SectionDataTable As Data.DataTable, ByRef RankTotal As Double)
                                Dim X As Integer = RunnersInRace
                                For Each ROW As Data.DataRow In SectionDataTable.Select("", "LAST_PREVIOUS_SPEED DESC")
                                    ROW.Item("RANK1") = 0I
                                    If Not IsDBNull(ROW.Item("LAST_PREVIOUS_SPEED")) AndAlso CInt(ROW.Item("LAST_PREVIOUS_SPEED")) > 0 Then
                                        ROW.Item("RANK1") = X
                                        X -= 1
                                    End If
                                    '
                                    If CInt(ROW.Item("NUMBER")) = EntryNumber Then RankTotal += CDbl(ROW.Item("RANK1")) : Exit For
                                Next ROW
                            End Sub
                            Private Shared Sub SetLastPreviousDistanceBehind(ByVal RunnersInRace As Integer, ByVal EntryNumber As String, ByVal SectionDataTable As Data.DataTable, ByRef RankTotal As Double)
                                Dim X As Integer = RunnersInRace
                                For Each ROW As Data.DataRow In SectionDataTable.Select("", "LAST_PREVIOUS_DISTANCE_BEHIND ASC")
                                    ROW.Item("RANK1") = 0I
                                    If Not IsDBNull(ROW.Item("LAST_PREVIOUS_DISTANCE_BEHIND")) Then
                                        If CInt(ROW.Item("RUNS")) > 0 Then
                                            ROW.Item("RANK1") = X
                                            X -= 1
                                        End If
                                    End If
                                    '
                                    If CInt(ROW.Item("NUMBER")) = EntryNumber Then RankTotal += CDbl(ROW.Item("RANK1")) : Exit For
                                Next ROW
                            End Sub
                            Private Shared Sub SetLastDSLR(ByVal RunnersInRace As Integer, ByVal Row As Data.DataRow, ByRef RankTotal As Double)
                                If IsDBNull(Row.Item("LAST_DSLR")) Then RankTotal += 0I : Exit Sub
                                '
                                Select Case CInt(Row.Item("LAST_DSLR"))
                                    Case Is <= 30
                                        RankTotal += RunnersInRace
                                        Exit Select
                                    Case Is <= 60
                                        RankTotal += RunnersInRace / 1.5
                                        Exit Select
                                    Case Is <= 90
                                        RankTotal += RunnersInRace / 2
                                        Exit Select
                                    Case Is <= 120
                                        RankTotal += RunnersInRace / 4
                                        Exit Select
                                    Case Is <= 182
                                        RankTotal += RunnersInRace / 6
                                        Exit Select
                                    Case Else
                                        RankTotal += 0I
                                        Exit Select
                                End Select
                            End Sub
                        End Class
                    End Class
                End Class
            End Class
        End Class
    End Class
End Namespace