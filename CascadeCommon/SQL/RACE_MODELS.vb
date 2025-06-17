Namespace SQL
    Public Class RACE_MODELS
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared Sub Insert(DataRow As Data.DataRow, Connection As Utils.Connection)
            Dim CMDTEXT As String

            CMDTEXT = "SELECT MEETING_XML_OADATE FROM RACE_MODELS WHERE (MEETING_XML_OADATE=" & DataRow.Item("MEETING_XML_OADATE").ToString & ") AND (MEETING_XML_NUMBER=" & DataRow.Item("MEETING_XML_NUMBER").ToString & ") AND (RACE_XML_NUMBER=" & DataRow.Item("RACE_XML_NUMBER").ToString & ") AND (MODEL_ID=" & DataRow.Item("MODEL_EXPLORER_ID").ToString & ") AND (NUMBER=" & DataRow.Item("NUMBER").ToString & ")"
            If Connection.GetDataTable(CMDTEXT).Rows.Count = 0 Then
                CMDTEXT = "INSERT INTO RACE_MODELS ([MEETING_XML_OADATE], [MEETING_XML_NUMBER], [RACE_XML_NUMBER], [MODEL_ID], [NUMBER]) "
                CMDTEXT += "VALUES (" & DataRow.Item("MEETING_XML_OADATE").ToString & ", " & DataRow.Item("MEETING_XML_NUMBER").ToString & ", " & DataRow.Item("RACE_XML_NUMBER").ToString & ", " & DataRow.Item("MODEL_EXPLORER_ID").ToString & ", " & DataRow.Item("NUMBER").ToString & ")"
                Connection.Execute(CMDTEXT)
            End If
        End Sub
        Public Shared Sub Delete(MeetingOADate As String, Connection As Utils.Connection)
            Dim CMDTEXT As String = "DELETE FROM RACE_MODELS WHERE MEETING_XML_OADATE=" & MeetingOADate
            Connection.Execute(CMDTEXT)
        End Sub
    End Class
End Namespace