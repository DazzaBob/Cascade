Namespace Processing
    Partial Class Results
        Private NotInheritable Class InsertUpdateDatabase : Implements IDisposable
            Private ListOfMeetingInformation As List(Of Instance.MeetingInformation)
            Private Connection As Connection = Nothing
            Friend Sub New(ByVal ListOfMeetingInformation As List(Of Instance.MeetingInformation))
                Me.ListOfMeetingInformation = ListOfMeetingInformation
            End Sub
            Friend Sub Start()
                Dim CMDTEXT As String = Nothing
                Me.Connection = New Connection
                '
                For Each MEETING As Instance.MeetingInformation In Me.ListOfMeetingInformation
                    For Each RACE As Instance.MeetingInformation.RaceInformation In MEETING.ListOfRaceInformation
                        If RACE.STATUS Is Nothing Then Continue For
                        If RACE.STATUS.Contains("AB") Then
                            CMDTEXT = "DELETE FROM RACE_XML WHERE (MEETING_XML_OADATE=" & MEETING.OADATE & ") AND (MEETING_XML_NUMBER=" & MEETING.NUMBER & ") AND (NUMBER=" & RACE.NUMBER & ")"
                            Call Me.Connection.Execute(CMDTEXT)
                            Continue For
                        End If
                        '
                        For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation In RACE.ListOfEntryInformation
                            If ENTRY.SCRATCHED Then
                                CMDTEXT = "DELETE FROM ENTRY_INFO WHERE (MEETING_INFO_OADATE=" & MEETING.OADATE & ") AND (MEETING_INFO_NUMBER=" & CStr(MEETING.NUMBER) & ") AND (RACE_INFO_NUMBER=" & CStr(RACE.NUMBER) & ") AND (NUMBER=" & CStr(ENTRY.NUMBER) & ")"
                                Call Me.Connection.Execute(CMDTEXT)
                                Continue For
                            Else
                                Using NewBaseResults = New Base(Me.ListOfMeetingInformation, MEETING, RACE, ENTRY, Connection)
                                    Call NewBaseResults.Insert()
                                End Using
                            End If
                        Next ENTRY
                        '
                        Using PoolsResult As New PoolsResult(MEETING, RACE, Me.Connection)
                            PoolsResult.Insert()
                        End Using
                        '
                        Using Theorectical As New Theorectical(MEETING, RACE, Me.Connection)
                            Theorectical.Insert()
                        End Using
                    Next RACE
                Next MEETING
                '
                If Me.ListOfMeetingInformation.Count > 0 Then
                    For Each MEETING As Instance.MeetingInformation In Me.ListOfMeetingInformation
                        CMDTEXT = "SELECT DISTINCT MEETING_INFO_OADATE, MEETING_INFO_NUMBER, RACE_INFO_NUMBER FROM ENTRY_INFO "
                        CMDTEXT += "WHERE (RESULT_THEO_FINISH_POSITION IS NULL) AND (MEETING_INFO_OADATE < " & MEETING.OADATE & ")"
                        For Each ROW As Data.DataRow In Me.Connection.GetDataTable(CMDTEXT).Select("")
                            CMDTEXT = "DELETE FROM RACE_INFO WHERE (MEETING_INFO_OADATE=" & CStr(ROW.Item("MEETING_INFO_OADATE")) & ") AND (MEETING_INFO_NUMBER=" & CStr(ROW.Item("MEETING_INFO_NUMBER")) & ") AND (NUMBER=" & CStr(ROW.Item("RACE_INFO_NUMBER")) & ")"
                            Call Me.Connection.Execute(CMDTEXT)
                        Next ROW
                        CMDTEXT = "SELECT MEETING_INFO_OADATE, MEETING_INFO_NUMBER, RACE_INFO_NUMBER "
                        CMDTEXT += "FROM ENTRY_INFO "
                        CMDTEXT += "WHERE (RESULT_FINISH_POSITION = 1) AND (RESULT_POOL_WIN = 0) AND (MEETING_INFO_OADATE = " & MEETING.OADATE & ") "
                        CMDTEXT += "ORDER BY MEETING_INFO_OADATE DESC, RACE_INFO_NUMBER DESC"
                        For Each ROW As Data.DataRow In Me.Connection.GetDataTable(CMDTEXT).Select("")
                            CMDTEXT = "DELETE FROM RACE_INFO WHERE (MEETING_INFO_OADATE=" & CStr(ROW.Item("MEETING_INFO_OADATE")) & ") AND (MEETING_INFO_NUMBER=" & CStr(ROW.Item("MEETING_INFO_NUMBER")) & ") AND (NUMBER=" & CStr(ROW.Item("RACE_INFO_NUMBER")) & ")"
                            Call Me.Connection.Execute(CMDTEXT)
                        Next ROW
                    Next MEETING
                End If
            End Sub
#Region "       IDisposable Support"
            Private disposedValue As Boolean ' To detect redundant calls

            ' IDisposable
            Friend Sub Dispose(disposing As Boolean)
                If Not Me.disposedValue Then
                    If disposing Then
                        If Me.Connection IsNot Nothing Then Me.Connection.Dispose() : Me.Connection = Nothing
                        If Me.ListOfMeetingInformation IsNot Nothing Then
                            For Each Meeting As Instance.MeetingInformation In Me.ListOfMeetingInformation
                                Meeting.Dispose() : Meeting = Nothing
                            Next
                        End If
                        Me.ListOfMeetingInformation.Clear() : Me.ListOfMeetingInformation = Nothing
                    End If
                    ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                    ' TODO: set large fields to null.
                End If
                Me.disposedValue = True
            End Sub
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