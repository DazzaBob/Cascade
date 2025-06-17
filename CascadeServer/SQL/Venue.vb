Namespace SQL
    Friend NotInheritable Class Venue
        Private Sub New()
            ' Just so the complier doesnt create a default constructor
        End Sub
        Friend Shared Function DataTable(Connection As CascadeCommon.Utils.Connection) As Data.DataTable
            Dim CMDTEXT As String = "SELECT * FROM VENUES"
            Return Connection.GetDataTable(CMDTEXT)
        End Function
        Friend Shared Sub Add(CountryID As String, TrackType As String, Name As String, Connection As CascadeCommon.Utils.Connection)
            Dim CMDTEXT As String = "INSERT INTO VENUES (COUNTRY_ID, TRACK_TYPE, NAME) "
            CMDTEXT += "VALUES (" & CountryID & ", N'" & TrackType & "', N'" & Name & "')"

            Call Connection.Execute(CMDTEXT)
        End Sub
        Friend Shared Function VenueName(VenueID As String, Connection As CascadeCommon.Utils.Connection) As String
            Dim CMDTEXT As String = "SELECT NAME FROM VENUES WHERE VENUE_ID=" & VenueID

            Return Connection.ExecuteScalar(CMDTEXT).ToString
        End Function
    End Class
End Namespace