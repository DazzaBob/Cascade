﻿Namespace StoredProcedures
    Friend NotInheritable Class UC_MODELLEDRACES
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared ReadOnly Property GetDataTable(ByVal FromOADate As String, ByVal ToOADate As String, ByVal MeetingType As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim COMMANDTEXT As String = "SELECT TOP (100) PERCENT RACE_INFO.MEETING_INFO_OADATE, RACE_INFO.MEETING_INFO_NUMBER, RACE_INFO.NUMBER AS RACE_INFO_NUMBER, ENTRY_INFO.NUMBER AS ENTRY_INFO_NUMBER, RACE_INFO.NORM_TIME, RACE_INFO.NAME, RACE_INFO.STATUS, RACE_INFO.CLASS, RACE_INFO.VENUE, MEETING_INFO.COUNTRY, MEETING_INFO.TYPE, RACE_INFO.LENGTH, RACE_INFO.TRACK, RACE_INFO.WEATHER, ENTRY_INFO.RESULT_POOL_WIN - 1 AS PAIDWIN, ENTRY_INFO.RESULT_POOL_PLACE - 1 AS PAIDPLACE "
                COMMANDTEXT += "FROM RACE_INFO LEFT OUTER JOIN MEETING_INFO ON RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE AND RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER RIGHT OUTER JOIN ENTRY_INFO ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER AND RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER RIGHT OUTER JOIN RACE_MODEL_INFO ON ENTRY_INFO.MEETING_INFO_OADATE = RACE_MODEL_INFO.MEETING_INFO_OADATE AND ENTRY_INFO.MEETING_INFO_NUMBER = RACE_MODEL_INFO.MEETING_INFO_NUMBER AND ENTRY_INFO.RACE_INFO_NUMBER = RACE_MODEL_INFO.RACE_INFO_NUMBER And ENTRY_INFO.NUMBER = RACE_MODEL_INFO.ENTRY_INFO_NUMBER "
                COMMANDTEXT += "WHERE (RACE_INFO.HASMODEL = 1) "
                COMMANDTEXT += "GROUP BY RACE_INFO.MEETING_INFO_OADATE, RACE_INFO.MEETING_INFO_NUMBER, RACE_INFO.NUMBER, ENTRY_INFO.NUMBER, RACE_INFO.NORM_TIME, RACE_INFO.NAME, RACE_INFO.STATUS, RACE_INFO.CLASS, RACE_INFO.VENUE, MEETING_INFO.COUNTRY, MEETING_INFO.TYPE, RACE_INFO.LENGTH, RACE_INFO.TRACK, RACE_INFO.WEATHER, ENTRY_INFO.RESULT_POOL_WIN - 1, ENTRY_INFO.RESULT_POOL_PLACE - 1 "
                COMMANDTEXT += "HAVING (RACE_INFO.NORM_TIME BETWEEN " & FromOADate & " AND " & ToOADate & ") AND (MEETING_INFO.TYPE = N'" & MeetingType & "')"
                COMMANDTEXT += "ORDER BY RACE_INFO.NORM_TIME DESC"
                '
                Return Connection.GetDataTable(COMMANDTEXT)
            End Get
        End Property
    End Class
End Namespace