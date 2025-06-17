Namespace Processing
    Partial Class Results
        Partial Class InsertUpdateDatabase
            Private NotInheritable Class [Base] : Implements IDisposable
                Private ListOfMeetingInformation As List(Of Instance.MeetingInformation)
                Private MeetingInformation As Instance.MeetingInformation
                Private RaceInformation As Instance.MeetingInformation.RaceInformation
                Private EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation
                Private Connection As Connection
                Friend Sub New(ByVal ListOfMeetingInformation As List(Of Instance.MeetingInformation), ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation, ByVal Connection As Connection)
                    Me.ListOfMeetingInformation = ListOfMeetingInformation
                    Me.MeetingInformation = MeetingInformation
                    Me.RaceInformation = RaceInformation
                    Me.EntryInformation = EntryInformation
                    Me.Connection = Connection
                End Sub
                Friend Sub Insert()
                    Dim CMDTEXT As String = ""
                    Dim DISTANCE As Decimal = 0D, MPS As Decimal = 0D, SPEED As Decimal = 0D, ACTUAL_TIME As Decimal = 0D
                    '
                    Call SetWinnersTime() : Call SetDistanceBehind()
                    '
                    Select Case Me.EntryInformation.FINISHPOSITION
                        Case 0
                            If Me.EntryInformation.DISTANCEBEHIND = 0 Then Me.EntryInformation.FINISHPOSITION = 1
                        Case 1
                            ACTUAL_TIME = Me.RaceInformation.WINNERSTIME ' Actual Time
                            If ACTUAL_TIME = 0D Then ACTUAL_TIME = DMOWinnersTime()
                            DISTANCE = CDec(Me.RaceInformation.RACEDISTANCE)
                            MPS = DISTANCE / ACTUAL_TIME
                            Exit Select
                        Case Else
                            DISTANCE = CDec(Me.RaceInformation.RACEDISTANCE) - Me.EntryInformation.DISTANCEBEHIND
                            If Me.RaceInformation.WINNERSTIME > 0 Then MPS = DISTANCE / Me.RaceInformation.WINNERSTIME
                            If MPS > 0 Then ACTUAL_TIME = CDec(Me.RaceInformation.RACEDISTANCE) / MPS
                    End Select
                    CMDTEXT = "UPDATE ENTRY_INFO SET "
                    CMDTEXT = String.Concat(CMDTEXT, "RESULT_TIME=" & CStr(ACTUAL_TIME) & ", ") ' Actual Time
                    CMDTEXT = String.Concat(CMDTEXT, "RESULT_FINISH_POSITION=" & Me.EntryInformation.FINISHPOSITION & ", ")
                    CMDTEXT = String.Concat(CMDTEXT, "RESULT_DISTANCE_BEHIND=" & CStr(Me.EntryInformation.DISTANCEBEHIND) & ", ") ' Actual Distance Behind
                    CMDTEXT = String.Concat(CMDTEXT, "RESULT_SPEED=" & CStr(MPS) & ", ") ' Actual Speed
                    CMDTEXT = String.Concat(CMDTEXT, "RESULT_POOL_WIN=" & CStr(Me.EntryInformation.PAIDWIN) & ", ") ' Win Pool
                    CMDTEXT = String.Concat(CMDTEXT, "RESULT_POOL_PLACE=" & CStr(Me.EntryInformation.PAIDPLACE) & " ") ' Place Pool
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO_OADATE=" & Me.MeetingInformation.OADATE & ") AND (MEETING_INFO_NUMBER=" & Me.MeetingInformation.NUMBER) & ") AND (RACE_INFO_NUMBER=" & Me.RaceInformation.NUMBER & ") AND (NUMBER=" & Me.EntryInformation.NUMBER & ") " & vbCrLf
                    '
                    Call Me.Connection.Execute(CMDTEXT)
                End Sub
#Region "               WINNERS TIME "
                ''' <summary>
                ''' Set the winners time.
                ''' </summary>
                ''' <remarks>If the winners time is 0 then the TAB didnt provide a finish time for the race.  D.M.O the race(Get a value for the distance, venue etc)</remarks>
                Private Sub SetWinnersTime()
                    If Me.RaceInformation.WINNERSTIME = 0D Then Me.RaceInformation.WINNERSTIME = DMOWinnersTime()
                    If Me.RaceInformation.WINNERSTIME = 0D Then
                        For Each M_I As Instance.MeetingInformation In Me.ListOfMeetingInformation
                            If M_I.TYPE = Me.MeetingInformation.TYPE Then
                                Dim DIVIDER As Int32 = 0
                                For Each R_I As Instance.MeetingInformation.RaceInformation In M_I.ListOfRaceInformation
                                    If R_I.WINNERSTIME > 0 Then
                                        Me.RaceInformation.WINNERSTIME += R_I.WINNERSTIME
                                        DIVIDER += 1
                                    End If
                                Next R_I
                                Me.RaceInformation.WINNERSTIME /= DIVIDER
                            End If
                        Next M_I
                    End If
                End Sub
                Private Function DMOWinnersTime() As Decimal
                    Dim CMDTEXT As String = Nothing
                    Dim COUNTRY As String = Nothing
                    Dim WINNERS_TIME As Decimal = 0I
                    '
                    CMDTEXT = "SELECT MEETING_INFO.COUNTRY FROM MEETING_INFO "
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO.OADATE=" & Me.MeetingInformation.OADATE & ") AND (MEETING_INFO.NUMBER=" & Me.MeetingInformation.NUMBER & ")")
                    COUNTRY = CStr(Me.Connection.ExecuteScalar(CMDTEXT))
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_TIME),0) AS WINNERS_TIME "
                    CMDTEXT = String.Concat(CMDTEXT, "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER ")
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO.[TYPE]=N'" & Me.MeetingInformation.TYPE & "') AND (MEETING_INFO.COUNTRY=N'" & COUNTRY & "') AND (MEETING_INFO.OADATE < " & Me.MeetingInformation.OADATE & ") AND (RACE_INFO.[LENGTH]=" & Me.RaceInformation.RACEDISTANCE & ")")
                    WINNERS_TIME = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If WINNERS_TIME > 0 Then Return WINNERS_TIME
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_TIME),0) AS WINNERS_TIME "
                    CMDTEXT = String.Concat(CMDTEXT, "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER ")
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO.[TYPE]=N'" & Me.MeetingInformation.TYPE & "') AND (MEETING_INFO.OADATE < " & Me.MeetingInformation.OADATE & ") AND (RACE_INFO.[LENGTH]=" & Me.RaceInformation.RACEDISTANCE & ")")
                    WINNERS_TIME = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If WINNERS_TIME > 0 Then Return WINNERS_TIME
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_TIME),0) AS WINNERS_TIME "
                    CMDTEXT = String.Concat(CMDTEXT, "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER ")
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO.[TYPE]=N'" & Me.MeetingInformation.TYPE & "') AND (MEETING_INFO.OADATE < " & Me.MeetingInformation.OADATE & ")")
                    WINNERS_TIME = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If WINNERS_TIME > 0 Then
                        Return WINNERS_TIME
                    Else
                        Return 0D
                    End If
                End Function
#End Region
#Region "               DISTANCE BEHIND "
                ''' <summary>
                ''' Set the Distance Behind.
                ''' </summary>
                ''' <remarks>Distance Behind in the TAB XML file is measured in lengths, not metres. so convert to metres</remarks>
                Private Sub SetDistanceBehind()
                    If Me.EntryInformation.FINISHPOSITION <> 1 AndAlso Me.EntryInformation.DISTANCEBEHIND = 0 Then
                        Me.EntryInformation.DISTANCEBEHIND = DMOEntryDistanceBehind()
                    End If
                    If Me.MeetingInformation.TYPE <> "GR" Then
                        Me.EntryInformation.DISTANCEBEHIND = Me.EntryInformation.DISTANCEBEHIND * 6D
                    Else
                        Me.EntryInformation.DISTANCEBEHIND = Me.EntryInformation.DISTANCEBEHIND * 2D
                    End If
                End Sub
                Private Function DMOEntryDistanceBehind() As Decimal
                    Dim CMDTEXT As String = Nothing
                    Dim COUNTRY As String = Nothing
                    Dim DISTANCE_BEHIND As Decimal = 0I
                    If Me.EntryInformation.FINISHPOSITION = 0 Then Me.EntryInformation.FINISHPOSITION = Me.EntryInformation.NUMBER
                    '
                    CMDTEXT = "SELECT MEETING_INFO.COUNTRY FROM MEETING_INFO "
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO.OADATE=" & Me.MeetingInformation.OADATE & ") AND (MEETING_INFO.NUMBER=" & Me.MeetingInformation.NUMBER & ")")
                    COUNTRY = CStr(Me.Connection.ExecuteScalar(CMDTEXT))
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_DISTANCE_BEHIND),0) AS DISTANCE_BEHIND "
                    CMDTEXT = String.Concat(CMDTEXT, "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER ")
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO.[TYPE]=N'" & Me.MeetingInformation.TYPE & "') AND (ENTRY_INFO.RESULT_FINISH_POSITION=" & Me.EntryInformation.NUMBER & ") AND (MEETING_INFO.COUNTRY=N'" & COUNTRY & "') AND (MEETING_INFO.OADATE < " & Me.MeetingInformation.OADATE & ") AND (RACE_INFO.[LENGTH]=" & Me.RaceInformation.RACEDISTANCE & ")")
                    DISTANCE_BEHIND = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If DISTANCE_BEHIND > 0 Then Return DISTANCE_BEHIND
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_DISTANCE_BEHIND),0) AS DISTANCE_BEHIND "
                    CMDTEXT = String.Concat(CMDTEXT, "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER ")
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO.[TYPE]=N'" & Me.MeetingInformation.TYPE & "') AND (ENTRY_INFO.RESULT_FINISH_POSITION=" & Me.EntryInformation.FINISHPOSITION & ") AND (MEETING_INFO.OADATE < " & Me.MeetingInformation.OADATE & ") AND (RACE_INFO.[LENGTH]=" & Me.RaceInformation.RACEDISTANCE & ")")
                    DISTANCE_BEHIND = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If DISTANCE_BEHIND > 0 Then Return DISTANCE_BEHIND
                    '
                    CMDTEXT = "SELECT ISNULL(AVG(ENTRY_INFO.RESULT_DISTANCE_BEHIND),0) AS DISTANCE_BEHIND "
                    CMDTEXT = String.Concat(CMDTEXT, "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER And RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER ")
                    CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO.[TYPE]=N'" & Me.MeetingInformation.TYPE & "') AND (ENTRY_INFO.RESULT_FINISH_POSITION=" & Me.EntryInformation.FINISHPOSITION & ") AND (MEETING_INFO.OADATE < " & Me.MeetingInformation.OADATE & ")")
                    DISTANCE_BEHIND = CDec(Me.Connection.ExecuteScalar(CMDTEXT))
                    If DISTANCE_BEHIND > 0 Then Return DISTANCE_BEHIND Else Return 0D
                End Function
#End Region
#Region "               IDisposable Support"
                Private disposedValue As Boolean ' To detect redundant calls

                ' IDisposable
                Friend Sub Dispose(disposing As Boolean)
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