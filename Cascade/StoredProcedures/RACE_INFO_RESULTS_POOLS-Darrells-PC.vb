Namespace StoredProcedures
    Friend NotInheritable Class RACE_INFO_RESULTS_POOLS
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared ReadOnly Property GetDataTable(ByVal MeetingInfoOADate As String, ByVal MeetingInfoNumber As String, ByVal RaceInfoNumber As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim CMDTEXT As String = "SELECT * FROM RACE_INFO_RESULTS_POOLS "
                CMDTEXT += "WHERE (MEETING_INFO_OADATE=" & MeetingInfoOADate & ") AND (MEETING_INFO_NUMBER=" & MeetingInfoNumber & ") AND (RACE_INFO_NUMBER=" & RaceInfoNumber & ")"
                '
                Return Connection.GetDataTable(CMDTEXT)
            End Get
        End Property
    End Class
End Namespace