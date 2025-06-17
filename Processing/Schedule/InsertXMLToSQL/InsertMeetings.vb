Partial Class Schedule
    Private NotInheritable Class InsertMeetings : Implements IDisposable
        Private ListOfMeetingInformation As List(Of Instance.MeetingInformation)
        Private ReadOnly CONNECTION As Utils.Connection
        Private ReadOnly MESSAGES As Utils.Messages
        Friend Sub New(Connection As Utils.Connection, Messages As Utils.Messages)
            Me.CONNECTION = Connection
            Me.MESSAGES = Messages
        End Sub
        Friend Sub New(ByVal ListOfMeetingInformation As List(Of Instance.MeetingInformation), Connection As Utils.Connection, Messages As Utils.Messages)
            Me.ListOfMeetingInformation = ListOfMeetingInformation
            Me.CONNECTION = Connection
            Me.MESSAGES = Messages
        End Sub
        Friend Sub Begin()
            Dim CMDTEXT As String
            For Each MEETING As Instance.MeetingInformation In Me.ListOfMeetingInformation
                CMDTEXT = "INSERT INTO MEETING_XML ([OADATE], [NUMBER], [CODE], [NAME], [STATUS], [TYPE]) "

                CMDTEXT += "VALUES (" & MEETING.OADATE & ", " & MEETING.NUMBER & ", "
                CMDTEXT += "N'" & MEETING.CODE & "', "
                CMDTEXT += "N'" & MEETING.NAME & "', "
                CMDTEXT += "N'" & MEETING.STATUS & "', "
                CMDTEXT += "N'" & MEETING.TYPE & "'"
                CMDTEXT += ")"

                Call Me.CONNECTION.Execute(CMDTEXT)

                Dim Broadcast As String = "Inserted Meeting M" & MEETING.NUMBER & " - " & MEETING.NAME & " on " & FormatDateTime(Date.FromOADate(MEETING.OADATE), DateFormat.LongDate)
                Call Me.MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)
                '
                For Each RACE As Instance.MeetingInformation.RaceInformation In MEETING.ListOfRaceInformation
                    Using ThisRace As New InsertRaces(MEETING, RACE, Me.CONNECTION, Me.MESSAGES)
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