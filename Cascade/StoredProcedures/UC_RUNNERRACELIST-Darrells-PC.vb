Namespace StoredProcedures
    Friend NotInheritable Class UC_RUNNERRACELIST
        Private Const MY_SELECT As String = "SELECT ENTRY_INFO.*, MEETING_INFO.COUNTRY, MEETING_INFO.TYPE, RACE_INFO.NUMBER AS RACE_INFO_NUMBER, RACE_INFO.LENGTH, RACE_INFO.VENUE, RACE_INFO.WEATHER, RACE_INFO.TRACK, RACE_INFO.HASMODEL "
        Private Const MY_FROM As String = "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER AND RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER "
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared ReadOnly Property GetDataTable(ByVal Filter As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim CMDTEXT As String = MY_SELECT & MY_FROM
                CMDTEXT += "WHERE " & Filter
                '
                Return Connection.GetDataTable(CMDTEXT)
            End Get
        End Property
        Friend Shared ReadOnly Property GetDataRow(ByVal MeetingInfoOADate As String, ByVal MeetingInfoNumber As String, ByVal RaceInfoNumber As String, ByVal EntryInfoNumber As String, ByVal Connection As Connection) As Data.DataRow
            Get
                Dim CMDTEXT As String = "SELECT ENTRY_INFO.*, MEETING_INFO.CODE, MEETING_INFO.COUNTRY, MEETING_INFO.TYPE, RACE_INFO.NUMBER AS RACE_INFO_NUMBER, RACE_INFO.LENGTH, RACE_INFO.VENUE, RACE_INFO.WEATHER, RACE_INFO.TRACK, RACE_INFO.HASMODEL "
                CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER INNER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER AND RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER "
                CMDTEXT += "WHERE (MEETING_INFO.OADATE=" & MeetingInfoOADate & ") AND (MEETING_INFO.NUMBER=" & MeetingInfoNumber & ") AND (RACE_INFO.NUMBER=" & RaceInfoNumber & ") AND (ENTRY_INFO.NUMBER=" & EntryInfoNumber & ")"
                '
                Dim DR() As Data.DataRow
                DR = Connection.GetDataTable(CMDTEXT).Select("")
                '
                If DR.Length > 0 Then
                    Return DR(0)
                Else
                    Return Nothing
                End If
            End Get
        End Property
    End Class
End Namespace