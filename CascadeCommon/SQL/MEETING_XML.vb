Imports CascadeCommon.Utils

Namespace SQL
    Public Class MEETING_XML
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared Function DISTINCT_NUMBER(Filter As String, Connection As Utils.Connection) As Data.DataTable
            Dim CMDTEXT As String = "SELECT DISTINCT MEETING_XML.NUMBER "
            CMDTEXT += "FROM MEETING_XML INNER JOIN RACE_XML ON MEETING_XML.OADATE = RACE_XML.MEETING_XML_OADATE AND MEETING_XML.NUMBER = RACE_XML.MEETING_XML_NUMBER INNER JOIN VENUES ON RACE_XML.VENUE_ID = VENUES.VENUE_ID "
            CMDTEXT += "WHERE " & Filter

            Return Connection.GetDataTable(CMDTEXT)
        End Function
    End Class
End Namespace