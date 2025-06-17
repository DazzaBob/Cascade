Namespace Datatables
    Friend Class Length
        Private Const SelectCommand As String = "SELECT DISTINCT VENUES.COUNTRY_ID, VENUES.TRACK_TYPE, VENUES.VENUE_ID, RACE_XML.LENGTH 
        FROM  VENUES INNER JOIN RACE_XML ON VENUES.VENUE_ID = RACE_XML.VENUE_ID 
        ORDER BY VENUES.COUNTRY_ID"
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared Function DataTable(Connection As Utils.Connection) As Data.DataTable
            Return Connection.GetDataTable(SelectCommand)
        End Function
    End Class
End Namespace