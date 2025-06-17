Namespace Processing
    Partial Class Results
        Partial Class InsertUpdateDatabase
            Private NotInheritable Class Theorectical : Implements IDisposable
                Private MeetingInformation As Instance.MeetingInformation
                Private RaceInformation As Instance.MeetingInformation.RaceInformation
                Private Connection As Connection
                Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal Connection As Connection)
                    Me.MeetingInformation = MeetingInformation
                    Me.RaceInformation = RaceInformation
                    Me.Connection = Connection
                End Sub
                Friend Sub Insert()
                    Dim CMDTEXT As String = Nothing
                    '
                    CMDTEXT = "SELECT NUMBER, RESULT_TIME, RESULT_THEO_DISTANCE_RAN, RESULT_DISTANCE_BEHIND FROM ENTRY_INFO "
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO_OADATE = " & Me.MeetingInformation.OADATE & ") AND (MEETING_INFO_NUMBER = " & Me.MeetingInformation.NUMBER & ") AND (RACE_INFO_NUMBER = " & Me.RaceInformation.NUMBER & ") ")
                    CMDTEXT = String.Concat(CMDTEXT, "ORDER BY RESULT_FINISH_POSITION")
                    Dim DR() As Data.DataRow = Me.Connection.GetDataTable(CMDTEXT).Select("")
                    If DR.Length = 0 Then Return
                    '
                    Dim COMMANDTEXT As String = Nothing
                    Dim THIS_WINNERS_TIME As Decimal = GetWinnersTime(DR(0))
                    Dim THIS_WINNERS_DISTANCE As Decimal = 0D
                    If Not IsDBNull(DR(0).Item("RESULT_THEO_DISTANCE_RAN")) Then THIS_WINNERS_DISTANCE = DR(0).Item("RESULT_THEO_DISTANCE_RAN")
                    '
                    For X As Integer = 0 To DR.Length - 1
                        Dim THIS_TIME As Decimal = 0D, THIS_MPS As Decimal = 0D, THIS_DISTANCE As Decimal = 0D
                        Dim THIS_DIFF As Decimal = 0D
                        If X = 0 Then
                            THIS_TIME = THIS_WINNERS_TIME : THIS_DISTANCE = THIS_WINNERS_DISTANCE
                            THIS_MPS = THIS_DISTANCE / THIS_WINNERS_TIME
                        Else
                            THIS_DISTANCE = CDec(DR(X).Item("RESULT_THEO_DISTANCE_RAN") - CDec(DR(X).Item("RESULT_DISTANCE_BEHIND")))
                            THIS_MPS = THIS_DISTANCE / THIS_WINNERS_TIME
                            THIS_TIME = THIS_WINNERS_DISTANCE / THIS_MPS
                        End If
                        '
                        COMMANDTEXT = String.Concat(COMMANDTEXT, "UPDATE ENTRY_INFO SET ")
                        COMMANDTEXT = String.Concat(COMMANDTEXT, "RESULT_THEO_TIME= " & CStr(THIS_TIME) & ", ")
                        COMMANDTEXT = String.Concat(COMMANDTEXT, "RESULT_THEO_SPEED=" & CStr(THIS_MPS) & " ")
                        COMMANDTEXT = String.Concat(COMMANDTEXT, "WHERE (MEETING_INFO_OADATE=" & CStr(Me.MeetingInformation.OADATE) & ") AND (MEETING_INFO_NUMBER=" & CStr(Me.MeetingInformation.NUMBER) & ") AND (RACE_INFO_NUMBER=" & CStr(Me.RaceInformation.NUMBER) & ") AND (NUMBER=" & CStr(DR(X).Item("NUMBER")) & ") " & vbCrLf)
                    Next X
                    Call Me.Connection.Execute(COMMANDTEXT)
                    '
                    ' Now we need to Calculate the Theoretical Distance behind.
                    CMDTEXT = "SELECT * FROM ENTRY_INFO "
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO_OADATE=" & Me.MeetingInformation.OADATE & ") AND (MEETING_INFO_NUMBER=" & Me.MeetingInformation.NUMBER & ") AND (RACE_INFO_NUMBER=" & Me.RaceInformation.NUMBER & ") ")
                    CMDTEXT = String.Concat(CMDTEXT, "ORDER BY RESULT_THEO_SPEED DESC")
                    '
                    COMMANDTEXT = Nothing
                    DR = Me.Connection.GetDataTable(CMDTEXT).Select("")
                    Dim THIS_DISTANCE_BEHIND As Decimal = 0D, Y As Integer = 1I
                    THIS_WINNERS_DISTANCE = CDec(DR(0).Item("RESULT_THEO_DISTANCE_RAN"))
                    For X As Integer = 0 To DR.Length - 1
                        If X >= 1 Then
                            Dim THIS_MPS As Decimal = CDec(DR(X).Item("RESULT_THEO_SPEED"))
                            Dim THIS_TIME As Decimal = CDec(DR(X).Item("RESULT_THEO_TIME"))
                            THIS_DISTANCE_BEHIND = (THIS_TIME / THIS_MPS)
                        End If
                        COMMANDTEXT = String.Concat(COMMANDTEXT, "UPDATE ENTRY_INFO SET ")
                        COMMANDTEXT = String.Concat(COMMANDTEXT, "RESULT_THEO_DISTANCE_BEHIND=" & CStr(THIS_DISTANCE_BEHIND) & ", ")
                        COMMANDTEXT = String.Concat(COMMANDTEXT, "RESULT_THEO_FINISH_POSITION=" & CStr(Y) & " ")
                        COMMANDTEXT = String.Concat(COMMANDTEXT, "WHERE (MEETING_INFO_OADATE=" & Me.MeetingInformation.OADATE & ") AND (MEETING_INFO_NUMBER=" & Me.MeetingInformation.NUMBER & ") AND (RACE_INFO_NUMBER=" & Me.RaceInformation.NUMBER & ") AND (NUMBER=" & DR(X).Item("NUMBER").ToString & ") " & vbCrLf)
                        Y += 1
                    Next X
                    Call Me.Connection.Execute(COMMANDTEXT)
                End Sub
                Private Function GetWinnersTime(ByVal DR As Data.DataRow) As Decimal
                    If Not IsDBNull(DR.Item("RESULT_TIME")) AndAlso CDec(DR.Item("RESULT_TIME")) > 0 Then
                        Return DR.Item("RESULT_TIME")
                    Else
                        Return Me.DMOWinnersTime()
                    End If
                End Function
                Private Function DMOWinnersTime() As Decimal
                    Dim CMDTEXT As String = Nothing
                    Dim TYPEID As String = Nothing
                    Dim WINNERS_TIME As Decimal = 0I
                    '
                    CMDTEXT = "SELECT TYPE FROM MEETING_INFO "
                    CMDTEXT += "WHERE (MEETING_INFO.OADATE=" & CStr(Me.MeetingInformation.OADATE) & ") AND (MEETING_INFO.NUMBER=" & CStr(Me.MeetingInformation.NUMBER) & ")"
                    TYPEID = CStr(Me.Connection.ExecuteScalar(CMDTEXT))
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_TIME),0) AS WINNERS_TIME "
                    CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER "
                    CMDTEXT += "WHERE (MEETING_INFO.TYPE=N'" & Me.MeetingInformation.TYPE & "') AND (MEETING_INFO.OADATE < " & CStr(Me.MeetingInformation.OADATE) & ") AND (RACE_INFO.[LENGTH]=" & CStr(Me.RaceInformation.RACEDISTANCE) & ")"
                    WINNERS_TIME = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If WINNERS_TIME > 0 Then Return WINNERS_TIME
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_TIME),0) AS WINNERS_TIME "
                    CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER "
                    CMDTEXT += "WHERE (MEETING_INFO.TYPE=N'" & Me.MeetingInformation.TYPE & "') AND (MEETING_INFO.OADATE < " & CStr(Me.MeetingInformation.OADATE) & ") AND (RACE_INFO.[LENGTH]=" & CStr(Me.RaceInformation.RACEDISTANCE) & ")"
                    WINNERS_TIME = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If WINNERS_TIME > 0 Then Return WINNERS_TIME
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_TIME),0) AS WINNERS_TIME "
                    CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER "
                    CMDTEXT += "WHERE (MEETING_INFO.LOOKUP_MEETING_TYPE_ID=" & TYPEID & ") AND (MEETING_INFO.OADATE < " & CStr(Me.MeetingInformation.OADATE) & ")"
                    WINNERS_TIME = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If WINNERS_TIME > 0 Then Return WINNERS_TIME
                    '
                    Dim DIVIDER As Int32 = 0
                    For Each RaceInfo As Instance.MeetingInformation.RaceInformation In Me.MeetingInformation.ListOfRaceInformation
                        If RaceInfo.WINNERSTIME > 0 Then
                            WINNERS_TIME += RaceInfo.WINNERSTIME
                            DIVIDER += 1
                        End If
                    Next RaceInfo
                    Return (WINNERS_TIME / DIVIDER)
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
End Namespace