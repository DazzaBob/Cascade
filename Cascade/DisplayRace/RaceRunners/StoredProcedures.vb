Namespace DisplayRace.RaceRunners
    Friend NotInheritable Class StoredProcedures
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared ReadOnly Property JoinedDataTable(ByVal OADate As String, ByVal MeetingNumber As String, ByVal RaceNumber As String, ByVal Section As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim CMDTEXT As String = Nothing
                CMDTEXT = String.Concat(CMDTEXT, "SELECT MEETING_INFO.TYPE AS MEETING_INFO_TYPE, ENTRY_INFO.BARRIER, ENTRY_INFO.NAME, ENTRY_INFO.JOCKEY_NAME, ENTRY_INFO.SCRATCHED, ENTRY_INFO.CLASS, ENTRY_INFO_" & Section & ".*, ENTRY_INFO.RESULT_THEO_DISTANCE_RAN AS DTR, ")
                CMDTEXT = String.Concat(CMDTEXT, "ENTRY_INFO_" & Section & "_SCORE.RANK, ENTRY_INFO_" & Section & "_SCORE.RANK_PERCENT, ENTRY_INFO_" & Section & "_SCORE.RANK_DIFFERENCE, ENTRY_INFO_" & Section & "_SCORE.[90_RANK], ENTRY_INFO_" & Section & "_SCORE.[90_RANK_PERCENT], ENTRY_INFO_" & Section & "_SCORE.[90_RANK_DIFFERENCE], ENTRY_INFO_" & Section & "_SCORE.[180_RANK], ENTRY_INFO_" & Section & "_SCORE.[180_RANK_PERCENT], ENTRY_INFO_" & Section & "_SCORE.[180_RANK_DIFFERENCE], ENTRY_INFO_" & Section & "_SCORE.[270_RANK], ENTRY_INFO_" & Section & "_SCORE.[270_RANK_PERCENT], ENTRY_INFO_" & Section & "_SCORE.[270_RANK_DIFFERENCE]")
                '
                CMDTEXT = String.Concat(CMDTEXT, " FROM RACE_INFO LEFT OUTER JOIN ENTRY_INFO RIGHT OUTER JOIN ENTRY_INFO_" & Section & "_SCORE RIGHT OUTER JOIN ENTRY_INFO_" & Section & " ON ENTRY_INFO_" & Section & "_SCORE.MEETING_INFO_OADATE = ENTRY_INFO_" & Section & ".MEETING_INFO_OADATE AND ENTRY_INFO_" & Section & "_SCORE.MEETING_INFO_NUMBER = ENTRY_INFO_" & Section & ".MEETING_INFO_NUMBER AND ENTRY_INFO_" & Section & "_SCORE.RACE_INFO_NUMBER = ENTRY_INFO_" & Section & ".RACE_INFO_NUMBER AND")
                CMDTEXT = String.Concat(CMDTEXT, " ENTRY_INFO_" & Section & "_SCORE.NUMBER = ENTRY_INFO_" & Section & ".NUMBER ON ENTRY_INFO.MEETING_INFO_OADATE = ENTRY_INFO_" & Section & ".MEETING_INFO_OADATE AND ENTRY_INFO.MEETING_INFO_NUMBER = ENTRY_INFO_" & Section & ".MEETING_INFO_NUMBER AND ENTRY_INFO.RACE_INFO_NUMBER = ENTRY_INFO_" & Section & ".RACE_INFO_NUMBER AND ENTRY_INFO.NUMBER = ENTRY_INFO_" & Section & ".NUMBER ON RACE_INFO.MEETING_INFO_OADATE = ENTRY_INFO.MEETING_INFO_OADATE AND")
                CMDTEXT = String.Concat(CMDTEXT, " RACE_INFO.MEETING_INFO_NUMBER = ENTRY_INFO.MEETING_INFO_NUMBER AND RACE_INFO.NUMBER = ENTRY_INFO.RACE_INFO_NUMBER RIGHT OUTER JOIN MEETING_INFO ON RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER AND RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE")
                '
                CMDTEXT = String.Concat(CMDTEXT, " WHERE (ENTRY_INFO.MEETING_INFO_OADATE = " & OADate & ") AND (ENTRY_INFO.MEETING_INFO_NUMBER = " & MeetingNumber & ") AND (ENTRY_INFO.RACE_INFO_NUMBER = " & RaceNumber & ") ORDER BY ENTRY_INFO_" & Section & ".NUMBER")
                '
                Return Connection.GetDataTable(CMDTEXT)
            End Get
        End Property

    End Class
End Namespace