Partial Friend Class Schedule
    Private NotInheritable Class InsertMeetings : Implements IDisposable
        Private ReadOnly ListOfMeetingInformation As List(Of Instance.MeetingInformation)
        Private ReadOnly CONNECTION As CascadeCommon.Utils.Connection
        Private ReadOnly MESSAGES As CascadeCommon.Messages
        Private _VENUEDATATABLE As Data.DataTable
        Private Sub New()
            ' Just so the complier doesnt create a default constructor
        End Sub
        Friend Sub New(Connection As CascadeCommon.Utils.Connection, Messages As CascadeCommon.Messages)
            Me.New
            Me.CONNECTION = Connection
            Me.MESSAGES = Messages
            Me._VENUEDATATABLE = SQL.Venue.DataTable(Connection)
        End Sub
        Friend Sub New(ByVal ListOfMeetingInformation As List(Of Instance.MeetingInformation), Connection As CascadeCommon.Utils.Connection, Messages As CascadeCommon.Messages)
            Me.New(Connection, Messages)
            Me.ListOfMeetingInformation = ListOfMeetingInformation
        End Sub
        Friend Sub Begin()
            Dim CMDTEXT As String
            For Each MEETING As Instance.MeetingInformation In ListOfMeetingInformation
                MEETING.COUNTRY = GetCountryID(MEETING.COUNTRY)

                CMDTEXT = "INSERT INTO MEETING_XML ([OADATE], [NUMBER], [COUNTRY_ID], [CODE], [NAME], [STATUS], [TYPE]) "

                CMDTEXT += "VALUES (" & MEETING.OADATE & ", " & MEETING.NUMBER & ", " & MEETING.COUNTRY & ", "
                CMDTEXT += "N'" & MEETING.CODE & "', "
                CMDTEXT += "N'" & MEETING.NAME & "', "
                CMDTEXT += "N'" & MEETING.STATUS & "', "
                CMDTEXT += "N'" & MEETING.TYPE & "'"
                CMDTEXT += ")"

                Call CONNECTION.Execute(CMDTEXT)

                Dim Broadcast As String = "Inserted Meeting M" & MEETING.NUMBER & " - " & MEETING.NAME & " on " & FormatDateTime(Date.FromOADate(MEETING.OADATE), DateFormat.LongDate)
                Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)
                '
                For Each RACE As Instance.MeetingInformation.RaceInformation In MEETING.ListOfRaceInformation
                    Using ThisRace As New InsertRaces(MEETING, RACE, CONNECTION, MESSAGES)
                        ThisRace.Begin()
                    End Using
                Next RACE
            Next MEETING
        End Sub
        Private Function GetCountryID(CountryCode As String) As String
            Dim CommandText As String = "SELECT [COUNTRY_ID] FROM COUNTRIES WHERE CODE=N'" & CountryCode & "'"
            Return CONNECTION.ExecuteScalar(CommandText).ToString
        End Function
#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    If _VENUEDATATABLE IsNot Nothing Then _VENUEDATATABLE.Dispose()
                End If
                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            disposedValue = True
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