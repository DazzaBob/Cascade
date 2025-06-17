Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Private NotInheritable Class Score : Implements IDisposable
                        Private MeetingInformation As Instance.MeetingInformation
                        Private RaceInformation As Instance.MeetingInformation.RaceInformation
                        Private Connection As Connection
                        Private BarrierJockeyDT As Data.DataTable
                        Private CommandText As String
                        Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal Connection As Connection, ByVal BarrierJockeyDT As Data.DataTable, ByRef CommandText As String)
                            Me.MeetingInformation = MeetingInformation
                            Me.RaceInformation = RaceInformation
                            Me.Connection = Connection
                            Me.BarrierJockeyDT = BarrierJockeyDT
                            Me.CommandText = CommandText
                        End Sub
                        Friend Function GetCommandText() As String
                            Dim CMDTEXT As String = Nothing
                            Dim INSERT As String = Nothing, VALUES As String = Nothing
                            '
                            For Each Section As String In New String() {"DISTANCE", "DISTANCE_THEO", "GROUP", "GROUP_THEO", "OVERALL", "OVERALL_THEO"}
                                For Each ROW As Data.DataRow In GetDataTable(Section).Select("")
                                    INSERT = "INSERT INTO ENTRY_INFO_" & Section & "_SCORE ([MEETING_INFO_OADATE], [MEETING_INFO_NUMBER], [RACE_INFO_NUMBER], [NUMBER]"
                                    VALUES = " VALUES (" & Me.MeetingInformation.OADATE & ", " & Me.MeetingInformation.NUMBER & ", " & Me.MeetingInformation.NUMBER & ", " & CStr(ROW.Item("NUMBER"))
                                    For Each Day As String In New String() {"", "90_", "180_", "270_"}
                                        Call GetValuesForInsert(INSERT, VALUES, ROW, Day)
                                    Next Day
                                    INSERT = String.Concat(INSERT, ") ") : VALUES = String.Concat(VALUES, ") " & Environment.NewLine)
                                    CMDTEXT = String.Concat(CMDTEXT, INSERT & VALUES)
                                Next ROW
                            Next Section
                            Return CMDTEXT
                        End Function
                        Private Sub GetValuesForInsert(ByRef INSERT As String, ByRef VALUES As String, ROW As Data.DataRow, ByVal Day As String)
                            INSERT += ", [" & Day & "RANK]" : VALUES = String.Concat(VALUES, ", " & CStr(ROW.Item(Day & "RANKTOTAL")))
                            INSERT += ", [" & Day & "RANK_PERCENT]" : VALUES = String.Concat(VALUES, ", " & CStr(ROW.Item(Day & "RANKPERCENT")))
                            INSERT += ", [" & Day & "RANK_DIFFERENCE]" : VALUES = String.Concat(VALUES, ", " & CStr(ROW.Item(Day & "RANKDIFFERENCE")))
                        End Sub
                        Friend Function GetDataTable(ByVal Section As String) As Data.DataTable
                            Dim THIS_SECTION_DATATABLE As Data.DataTable = SectionDataTable(Section)
                            Dim RunnersInRace As Int32, MaxScore As Double = 0.0#
                            RunnersInRace = THIS_SECTION_DATATABLE.Rows.Count
                            '
                            For Each ROW As Data.DataRow In THIS_SECTION_DATATABLE.Select("")
                                For Each Day As String In New String() {"", "90_", "180_", "270_"}
                                    Dim Criteria As Int32 = 22I
                                    MaxScore = Criteria * RunnersInRace
                                    ROW.Item(Day & "RANKTOTAL") = 0.0#
                                    ROW.Item(Day & "RANKPERCENT") = 0.0#
                                    ROW.Item(Day & "RANKDIFFERENCE") = 0.0#
                                    ROW.AcceptChanges()
                                    '
                                    ' There are 14 maxims in this method + 7 from a sub method = 21 maxims
                                    Dim RANKTOTAL As Double = Common.RankTotal(Me.MeetingInformation, Me.RaceInformation, RunnersInRace, ROW, THIS_SECTION_DATATABLE, Day)
                                    '
                                    If Section.Contains("DISTANCE") Then
                                        ' there are 18 maxims the this method, so add 18 to the criteria.
                                        Criteria += 18 : MaxScore = Criteria * RunnersInRace
                                        RANKTOTAL += Favourites.RankTotal(Me.MeetingInformation, Me.RaceInformation, ROW, THIS_SECTION_DATATABLE, Day)
                                    End If
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        RANKTOTAL += Common.GetBarrierRanks(RunnersInRace, CStr(ROW.Item("NUMBER")), Me.BarrierJockeyDT) '22
                                    Else
                                        RANKTOTAL += Common.GetJockeyRanks(RunnersInRace, CStr(ROW.Item("JOCKEY_NAME")), Me.BarrierJockeyDT) '22
                                    End If
                                    ROW.Item(Day & "RANKTOTAL") = 100 / MaxScore * RANKTOTAL
                                    ROW.AcceptChanges()
                                    '
                                Next Day
                            Next ROW
                            THIS_SECTION_DATATABLE.AcceptChanges()
                            '
                            For Each Day As String In New String() {"", "90_", "180_", "270_"}
                                Call SetRankPercent(THIS_SECTION_DATATABLE, Day)
                                Call SetRankDifference(THIS_SECTION_DATATABLE, Day)
                            Next Day
                            THIS_SECTION_DATATABLE.AcceptChanges()
                            '
                            Return THIS_SECTION_DATATABLE
                        End Function
                        Private Sub SetRankPercent(ByRef SectionDataTable As Data.DataTable, ByVal Day As String)
                            If SectionDataTable Is Nothing Then Return
                            If SectionDataTable.Rows.Count = 0 Then Return
                            '
                            Dim RankTotalPoints As Decimal = 0D
                            For Each ROW As Data.DataRow In SectionDataTable.Select("", Day & "RANKTOTAL DESC")
                                RankTotalPoints += CDec(ROW.Item(Day & "RANKTOTAL"))
                            Next
                            '
                            For Each ROW As Data.DataRow In SectionDataTable.Select("", Day & "RANKTOTAL DESC")
                                If RankTotalPoints <> 0 Then
                                    Dim RANKTOTAL As Double = CDbl(ROW.Item(Day & "RANKTOTAL"))
                                    ROW.Item(Day & "RANKPERCENT") = CDec((100 / RankTotalPoints) * RANKTOTAL)
                                End If
                            Next ROW
                        End Sub
                        Private Sub SetRankDifference(ByRef SectionDataTable As Data.DataTable, ByVal Day As String)
                            If SectionDataTable Is Nothing Then Return
                            If SectionDataTable.Rows.Count = 0 Then Return
                            '
                            Dim DR() As Data.DataRow = SectionDataTable.Select("", Day & "RANKTOTAL DESC")
                            Dim FirstRank As Decimal = CDec(DR(0).Item(Day & "RANKTOTAL"))
                            For Each ROW As Data.DataRow In SectionDataTable.Select("", Day & "RANKTOTAL DESC")
                                ROW.Item(Day & "RANKDIFFERENCE") = CDec(0D)
                                If FirstRank = 0 Then Continue For
                                ROW.Item(Day & "RANKDIFFERENCE") = Math.Round((100 / FirstRank) * CDec(ROW.Item(Day & "RANKTOTAL")), 8)
                            Next ROW
                        End Sub
                        Private Function SectionDataTable(ByVal Section As String) As Data.DataTable
                            Dim ThisDT As Data.DataTable = Nothing
                            Dim CMDTEXT As String = "SELECT MEETING_INFO.TYPE AS MEETING_INFO_TYPE, ENTRY_INFO.BARRIER, ENTRY_INFO.NAME, ENTRY_INFO.JOCKEY_NAME, ENTRY_INFO.SCRATCHED, ENTRY_INFO.CLASS, ENTRY_INFO_" & Section & ".*, ENTRY_INFO.RESULT_THEO_DISTANCE_RAN AS DTR "
                            CMDTEXT += "FROM ENTRY_INFO RIGHT OUTER JOIN RACE_INFO ON ENTRY_INFO.MEETING_INFO_OADATE = RACE_INFO.MEETING_INFO_OADATE AND ENTRY_INFO.MEETING_INFO_NUMBER = RACE_INFO.MEETING_INFO_NUMBER AND ENTRY_INFO.RACE_INFO_NUMBER = RACE_INFO.NUMBER LEFT OUTER JOIN ENTRY_INFO_" & Section & " ON ENTRY_INFO.MEETING_INFO_OADATE = ENTRY_INFO_" & Section & ".MEETING_INFO_OADATE AND ENTRY_INFO.MEETING_INFO_NUMBER = ENTRY_INFO_" & Section & ".MEETING_INFO_NUMBER AND "
                            CMDTEXT += "ENTRY_INFO.RACE_INFO_NUMBER = ENTRY_INFO_" & Section & ".RACE_INFO_NUMBER AND ENTRY_INFO.NUMBER = ENTRY_INFO_" & Section & ".NUMBER RIGHT OUTER JOIN MEETING_INFO ON RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER AND RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE "
                            CMDTEXT += "WHERE (ENTRY_INFO.MEETING_INFO_OADATE = " & Me.MeetingInformation.OADATE & ") AND (ENTRY_INFO.MEETING_INFO_NUMBER = " & Me.MeetingInformation.NUMBER & ") AND (ENTRY_INFO.RACE_INFO_NUMBER = " & Me.RaceInformation.NUMBER & ") "
                            CMDTEXT += "ORDER BY ENTRY_INFO_" & Section & ".NUMBER"
                            ThisDT = Me.Connection.GetDataTable(CMDTEXT)
                            '
                            ThisDT.Columns.Add(New DataColumn("RANK1", GetType(Double)))
                            '
                            ThisDT.Columns.Add(New DataColumn("RANKTOTAL", GetType(Double)))
                            ThisDT.Columns.Add(New DataColumn("RANKPERCENT", GetType(Double)))
                            ThisDT.Columns.Add(New DataColumn("RANKDIFFERENCE", GetType(Double)))
                            '
                            ThisDT.Columns.Add(New DataColumn("90_RANKTOTAL", GetType(Double)))
                            ThisDT.Columns.Add(New DataColumn("90_RANKPERCENT", GetType(Double)))
                            ThisDT.Columns.Add(New DataColumn("90_RANKDIFFERENCE", GetType(Double)))
                            '
                            ThisDT.Columns.Add(New DataColumn("180_RANKTOTAL", GetType(Double)))
                            ThisDT.Columns.Add(New DataColumn("180_RANKPERCENT", GetType(Double)))
                            ThisDT.Columns.Add(New DataColumn("180_RANKDIFFERENCE", GetType(Double)))
                            '
                            ThisDT.Columns.Add(New DataColumn("270_RANKTOTAL", GetType(Double)))
                            ThisDT.Columns.Add(New DataColumn("270_RANKPERCENT", GetType(Double)))
                            ThisDT.Columns.Add(New DataColumn("270_RANKDIFFERENCE", GetType(Double)))
                            '
                            ThisDT.AcceptChanges()
                            '
                            Return ThisDT
                        End Function

#Region "IDisposable Support"
                        Private disposedValue As Boolean ' To detect redundant calls

                        ' IDisposable
                        Protected Sub Dispose(disposing As Boolean)
                            If Not Me.disposedValue Then
                                If disposing Then
                                    ' TODO: dispose managed state (managed objects).
                                End If

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
    End Class
End Namespace