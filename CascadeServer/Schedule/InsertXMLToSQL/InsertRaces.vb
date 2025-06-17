Partial Friend Class Schedule
    Partial Private Class InsertMeetings
        Private NotInheritable Class InsertRaces : Implements IDisposable
            Private ReadOnly MeetingInformation As Instance.MeetingInformation
            Private ReadOnly RaceInformation As Instance.MeetingInformation.RaceInformation
            Private ReadOnly CONNECTION As CascadeCommon.Utils.Connection
            Private ReadOnly MESSAGES As CascadeCommon.Messages
            Private _VENUEDATATABLE As Data.DataTable
            Friend Sub New(MeetingInformation As Instance.MeetingInformation, RaceInformation As Instance.MeetingInformation.RaceInformation, Connection As CascadeCommon.Utils.Connection, Messages As CascadeCommon.Messages)
                Me.MeetingInformation = MeetingInformation
                Me.RaceInformation = RaceInformation
                Me.CONNECTION = Connection
                Me.MESSAGES = Messages
                Me._VENUEDATATABLE = SQL.Venue.DataTable(Connection)
            End Sub
            Friend Sub Begin()
                Dim CMDTEXT As String = "INSERT INTO RACE_XML (MEETING_XML_OADATE, MEETING_XML_NUMBER, NUMBER, [VENUE_ID], [LENGTH], [NAME], [START_TIME], [STAKE], [STATUS], [TRACK], [WEATHER], [RUNNERSINRACE]"
                If RaceInformation.CLASS IsNot Nothing Then CMDTEXT += ", [CLASS]"
                CMDTEXT += ") "

                CMDTEXT += "VALUES (" & MeetingInformation.OADATE & ", " & MeetingInformation.NUMBER & ", " & RaceInformation.NUMBER & ", "
                CMDTEXT += GetVenueID(MeetingInformation.COUNTRY, MeetingInformation.TYPE, RaceInformation.VENUE) & ", "
                CMDTEXT += RaceInformation.LENGTH & ", "
                CMDTEXT += "N'" & Utils.ReplaceHTML(RaceInformation.NAME) & "', "
                CMDTEXT += RaceInformation.NORM_TIME & ", "
                CMDTEXT += RaceInformation.STAKE & ", "
                CMDTEXT += "N'" & RaceInformation.STATUS & "', "
                CMDTEXT += "N'" & RaceInformation.TRACK & "', "
                CMDTEXT += "N'" & RaceInformation.WEATHER & "', "

                Dim RunnersInRace As Short
                For Each Entry As Instance.MeetingInformation.RaceInformation.EntryInformation In RaceInformation.ListOfEntryInformation
                    If Entry.SCRATCHED = "0" Then RunnersInRace += 1
                Next

                CMDTEXT += RunnersInRace.ToString & ", "
                CMDTEXT += "N'" & RaceInformation.CLASS & "')"

                Call CONNECTION.Execute(CMDTEXT)
                Dim Broadcast As String = " Inserted Race R" & RaceInformation.NUMBER & " - " & RaceInformation.NAME & " for M" & MeetingInformation.NUMBER & " - " & MeetingInformation.NAME
                Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

                CMDTEXT = Nothing : Broadcast = Nothing
                Dim THIS_BROADCAST = "    Inserted Runners: "
                For Each ENTRY_INFO As Instance.MeetingInformation.RaceInformation.EntryInformation In RaceInformation.ListOfEntryInformation
                    Using Entry As New InsertEntrys(MeetingInformation, RaceInformation, ENTRY_INFO, CONNECTION)
                        Call Entry.Begin()
                    End Using
                    THIS_BROADCAST += ENTRY_INFO.NUMBER & ", "
                Next ENTRY_INFO

                THIS_BROADCAST = Strings.Left(THIS_BROADCAST, THIS_BROADCAST.Length - 2)
                Call MESSAGES.LogMessages(THIS_BROADCAST, Utils.BroadcastTypes.Log)
            End Sub
            Private Function GetVenueID(CountryID As String, TrackType As String, Name As String) As String
                Dim DR() As Data.DataRow = Me._VENUEDATATABLE.Select("COUNTRY_ID=" & CountryID & " AND TRACK_TYPE='" & TrackType & "' AND NAME = '" & Name & "'")
                If DR.Length >= 1 Then Return DR(0).Item("VENUE_ID").ToString

                Call SQL.Venue.Add(CountryID, TrackType, Name, Me.CONNECTION)
                Me._VENUEDATATABLE.Rows.Clear()
                Me._VENUEDATATABLE = SQL.Venue.DataTable(CONNECTION)

                Return Me._VENUEDATATABLE.Select("COUNTRY_ID=" & CountryID & " AND TRACK_TYPE='" & TrackType & "' AND NAME = '" & Name & "'")(0).Item("VENUE_ID").ToString
            End Function
#Region "               IDisposable Support"
            Private disposedValue As Boolean ' To detect redundant calls

            ' IDisposable
            Protected Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        Me._VENUEDATATABLE.Dispose()
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
End Class