Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Private NotInheritable Class Jockey : Implements IDisposable
                    Private MeetingInformation As Instance.MeetingInformation
                    Private RaceInformation As Instance.MeetingInformation.RaceInformation
                    Private Connection As Connection
                    Private DT As Data.DataTable = Nothing
                    Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal Connection As Connection)
                        Me.MeetingInformation = MeetingInformation
                        Me.RaceInformation = RaceInformation
                        Me.Connection = Connection
                    End Sub
                    Friend Sub Begin()
                        Dim CMDTEXT As String = Nothing
                        For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.RaceInformation.ListOfEntryInformation
                            If ENTRY.SCRATCHED = "1" Then Continue For
                            Dim INSERT As String = "INSERT INTO RACE_INFO_JOCKEY ([MEETING_INFO_OADATE], [MEETING_INFO_NUMBER], [RACE_INFO_NUMBER], [NUMBER], [NAME]"
                            Dim VALUES As String = "VALUES (" & Me.MeetingInformation.OADATE & ", " & Me.MeetingInformation.NUMBER & ", " & Me.RaceInformation.NUMBER & ", " & ENTRY.NUMBER & ", '" & Replace(ENTRY.JOCKEY, "'", "' + CHAR(39) + '") & "'"
                            '
                            Call SetInsertValues("90", ENTRY, INSERT, VALUES)
                            Call SetInsertValues("180", ENTRY, INSERT, VALUES)
                            Call SetInsertValues("270", ENTRY, INSERT, VALUES)
                            Call SetInsertValues("ALL", ENTRY, INSERT, VALUES)
                            INSERT += ") " : VALUES += ") " & vbCrLf
                            '
                            CMDTEXT = INSERT & VALUES
                        Next ENTRY
                        '
                        Call Me.Connection.Execute(CMDTEXT)
                        Dim Broadcast As String = " Inserted Jockey Information for M" & Me.MeetingInformation.NUMBER & "R" & Me.RaceInformation.NUMBER
                        Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                    End Sub
                    Private Sub SetInsertValues(ByVal DAY As String, ByVal Entry As Instance.MeetingInformation.RaceInformation.EntryInformation, ByRef INSERT As String, ByRef VALUES As String)
                        Dim CMDTEXT As String = "SELECT ENTRY_INFO.JOCKEY_NAME, ENTRY_INFO.RESULT_POOL_WIN, ENTRY_INFO.RESULT_POOL_PLACE, ENTRY_INFO.RESULT_DISTANCE_BEHIND, ENTRY_INFO.RESULT_FINISH_POSITION "
                        CMDTEXT += "FROM RACE_INFO INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER AND RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER INNER JOIN MEETING_INFO ON RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE AND RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER "
                        CMDTEXT += "WHERE (MEETING_INFO.TYPE='" & Me.MeetingInformation.TYPE & "') AND (ENTRY_INFO.JOCKEY_NAME=N'" & Replace(Entry.JOCKEY, "'", "' + CHAR(39) + '") & "') AND "
                        Select Case DAY
                            Case "90", "180", "270"
                                CMDTEXT += "(RACE_INFO.MEETING_INFO_OADATE >= " & CStr(CInt(Me.MeetingInformation.OADATE) - (DAY + 1)) & " AND RACE_INFO.MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                Exit Select
                            Case Else
                                CMDTEXT += "(RACE_INFO.MEETING_INFO_OADATE >= " & CStr(CInt(Me.MeetingInformation.OADATE) - (365 + 1)) & " AND RACE_INFO.MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                        End Select
                        CMDTEXT += " ORDER BY RACE_INFO.MEETING_INFO_OADATE ASC"
                        '
                        Me.DT = Me.Connection.GetDataTable(CMDTEXT)
                        If DT.Rows.Count > 1 Then
                            Dim This_Runs As Long = DT.Rows.Count, This_Wins As Double = 0.0#, This_Places As Double = 0.0#
                            Dim This_FPA As String = "0", This_ADB As String = "0"
                            '
                            Call SetWinsPlaces(This_Wins, This_Places, This_Runs)
                            Call SetFPAADB(This_FPA, This_ADB)
                            '
                            INSERT += ", [" & DAY & "_RUNS]" : VALUES += ", " & CStr(This_Runs)
                            INSERT += ", [" & DAY & "_WINS]" : VALUES += ", " & CStr(This_Wins)
                            INSERT += ", [" & DAY & "_PLACES]" : VALUES += ", " & CStr(This_Places)
                            INSERT += ", [" & DAY & "_DISTANCE_BEHIND]" : VALUES += ", " & CStr(This_ADB)
                            INSERT += ", [" & DAY & "_FINISH_POSITION]" : VALUES += ", " & CStr(This_FPA)
                        End If
                    End Sub
                    Private Sub SetWinsPlaces(ByRef Wins As Double, ByRef Places As Double, ByVal Runs As Integer)
                        On Error Resume Next
                        Dim This_Wins As Double = CDbl(Me.DT.Compute("COUNT(JOCKEY_NAME)", "(RESULT_FINISH_POSITION =  1)"))
                        Dim This_Places As Double = CDbl(Me.DT.Compute("COUNT(JOCKEY_NAME)", "(RESULT_FINISH_POSITION =  1 OR RESULT_FINISH_POSITION =  2 OR RESULT_FINISH_POSITION =  3)"))
                        '
                        If Runs > 0 Then
                            Wins = CDbl(This_Wins / Runs) * 100
                            Places = CDbl(This_Places / Runs) * 100
                        End If
                    End Sub
                    Private Sub SetFPAADB(ByRef FinishPositionAverage As String, ByRef DistanceBehindAverage As String)
                        On Error Resume Next
                        FinishPositionAverage = CStr(Me.DT.Compute("AVG(RESULT_FINISH_POSITION)", "(RESULT_FINISH_POSITION >  0)"))
                        DistanceBehindAverage = CStr(Me.DT.Compute("AVG(RESULT_DISTANCE_BEHIND)", "RESULT_FINISH_POSITION >  0"))
                    End Sub
#Region "                   IDisposable Support"
                    Private disposedValue As Boolean ' To detect redundant calls

                    ' IDisposable
                    Protected Sub Dispose(disposing As Boolean)
                        If Not Me.disposedValue Then
                            If disposing Then
                                ' TODO: dispose managed state (managed objects).
                            End If
                            If Me.DT IsNot Nothing Then Me.DT.Dispose() : Me.DT = Nothing
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