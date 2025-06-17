Namespace StoredProcedures
    Friend NotInheritable Class UC_MEETINGS
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared ReadOnly Property GetMeetingDataTable(ByVal startdate As String, ByVal finishdate As String, ByVal connection As Connection) As Data.DataTable
            Get
                If connection Is Nothing Then Return Nothing
                '
                Dim COMMANDTEXT As String = "SELECT DISTINCT RACE_INFO.VENUE, MEETING_INFO.* "
                COMMANDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
                COMMANDTEXT += " WHERE(MEETING_INFO.OADATE BETWEEN " & startdate & " AND " & finishdate & ") "
                COMMANDTEXT += "ORDER BY MEETING_INFO.OADATE DESC, MEETING_INFO.NUMBER ASC"
                '
                Return connection.GetDataTable(COMMANDTEXT)
            End Get
        End Property
        Public Shared ReadOnly Property GetVenueDataTable(ByVal MeetingOADate As String, ByVal MeetingNumber As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim COMMANDTEXT As String = "SELECT RACE_INFO.MEETING_INFO_OADATE, RACE_INFO.MEETING_INFO_NUMBER, RACE_INFO.NUMBER, RACE_INFO.NORM_TIME, RACE_INFO.NAME, RACE_INFO.[STATUS], MEETING_INFO.COUNTRY, MEETING_INFO.[TYPE], RACE_INFO.CLASS, RACE_INFO.[LENGTH], RACE_INFO.TRACK, RACE_INFO.WEATHER, RACE_INFO.HASMODEL, RACE_INFO.RUNNERSINRACE "
                COMMANDTEXT += "FROM RACE_INFO INNER JOIN MEETING_INFO ON RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE AND RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER "
                COMMANDTEXT += "WHERE (RACE_INFO.MEETING_INFO_OADATE=" & MeetingOADate & ") AND (RACE_INFO.MEETING_INFO_NUMBER=" & MeetingNumber & ") "
                COMMANDTEXT += "ORDER BY RACE_INFO.NORM_TIME DESC"
                '
                Return Connection.GetDataTable(COMMANDTEXT)
            End Get
        End Property
    End Class
End Namespace