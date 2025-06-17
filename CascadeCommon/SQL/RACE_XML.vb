Imports CascadeCommon.Utils

Namespace SQL
    Public Class RACE_XML
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared Function DISTINCT_NUMBERS(Filter As String, MeetingNumber As String, Connection As Utils.Connection) As Data.DataTable
            Dim CMDTEXT As String = "SELECT DISTINCT RACE_XML.NUMBER "
            CMDTEXT += "FROM MEETING_XML INNER JOIN RACE_XML ON MEETING_XML.OADATE = RACE_XML.MEETING_XML_OADATE AND MEETING_XML.NUMBER = RACE_XML.MEETING_XML_NUMBER INNER JOIN VENUES ON RACE_XML.VENUE_ID = VENUES.VENUE_ID "
            CMDTEXT += "WHERE " & Filter & " AND (MEETING_XML.NUMBER = " & MeetingNumber & ")"

            Return Connection.GetDataTable(CMDTEXT)
        End Function

    End Class
End Namespace