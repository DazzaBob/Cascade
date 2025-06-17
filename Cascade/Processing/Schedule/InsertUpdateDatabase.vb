Namespace Processing
    Partial Class Schedule
        Private NotInheritable Class InsertUpdateDatabase : Implements IDisposable
            Private ListOfMeetingInformation As List(Of Instance.MeetingInformation)
            Private Connection As Connection
            Friend Sub New(ByVal ListOfMeetingInformation As List(Of Instance.MeetingInformation))
                Me.ListOfMeetingInformation = ListOfMeetingInformation
                Me.Connection = New Connection
            End Sub
            Friend Sub Begin()
                Dim CMDTEXT As String = Nothing
                For Each MEETING As Instance.MeetingInformation In Me.ListOfMeetingInformation
                    CMDTEXT = "INSERT INTO MEETING_INFO ([OADATE], [NUMBER], [BETSLIP_TYPE], [CODE], [COUNTRY], [NAME], [NZ], [STATUS], [TYPE]"
                    If Not MEETING.PENETROMETER Is Nothing Then CMDTEXT += ", [PENETROMETER]"
                    If Not MEETING.TRACK_DIR Is Nothing Then CMDTEXT += ", [TRACK_DIR]"
                    CMDTEXT += ") "
                    '
                    CMDTEXT += "VALUES (" & MEETING.OADATE & ", " & MEETING.NUMBER & ", "
                    CMDTEXT += "N'" & MEETING.BETSLIP_TYPE & "', "
                    CMDTEXT += "N'" & MEETING.CODE & "', "
                    CMDTEXT += "N'" & MEETING.COUNTRY & "', "
                    CMDTEXT += "N'" & MEETING.NAME & "', "
                    CMDTEXT += CStr(MEETING.NZ) & ", "
                    CMDTEXT += "N'" & MEETING.STATUS & "', "
                    CMDTEXT += "N'" & MEETING.TYPE & "'"
                    If Not MEETING.PENETROMETER Is Nothing Then CMDTEXT += ", N'" & MEETING.PENETROMETER & "'"
                    If Not MEETING.TRACK_DIR Is Nothing Then CMDTEXT += ", N'" & MEETING.TRACK_DIR & "'"
                    CMDTEXT += ")"
                    '
                    Call Me.Connection.Execute(CMDTEXT)
                    Dim Broadcast As String = "Inserted Meeting M" & MEETING.NUMBER & " - " & MEETING.NAME & " on " & FormatDateTime(Date.FromOADate(MEETING.OADATE), DateFormat.LongDate)
                    Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                    '
                    For Each RACE As Instance.MeetingInformation.RaceInformation In MEETING.ListOfRaceInformation
                        Using ThisRace As New Race(MEETING, RACE, Me.Connection)
                            ThisRace.Begin()
                        End Using
                    Next RACE
                Next MEETING
            End Sub

#Region "IDisposable Support"
            Private disposedValue As Boolean ' To detect redundant calls

            ' IDisposable
            Protected Sub Dispose(disposing As Boolean)
                If Not Me.disposedValue Then
                    If disposing Then
                        ' TODO: dispose managed state (managed objects).
                    End If
                    If Connection IsNot Nothing Then Connection.Dispose() : Connection = Nothing
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
End Namespace