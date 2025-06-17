Imports System.Data

Namespace SQL
    Public Class RACE_EXTENDED
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared Sub InsertUpdate(DataRow As Data.DataRow, Connection As Utils.Connection)
            Dim CMDTEXT As String = "SELECT HASMODEL FROM RACE_EXTENDED WHERE MEETING_XML_OADATE=" & DataRow.Item("MEETING_XML_OADATE").ToString & " AND MEETING_XML_NUMBER=" & DataRow.Item("MEETING_XML_NUMBER").ToString & " AND NUMBER=" & DataRow.Item("RACE_XML_NUMBER").ToString
            If Connection.GetDataTable(CMDTEXT).Select("").Length = 0 Then
                CMDTEXT = "INSERT INTO RACE_EXTENDED (MEETING_XML_OADATE, MEETING_XML_NUMBER, NUMBER, HASMODEL) 
                 VALUES (" & DataRow.Item("MEETING_XML_OADATE").ToString & ", " & DataRow.Item("MEETING_XML_NUMBER").ToString & ", " & DataRow.Item("RACE_XML_NUMBER").ToString & ", 1)"
            Else
                Call UpdateHasModel("1", DataRow.Item("MEETING_XML_OADATE").ToString, DataRow.Item("MEETING_XML_NUMBER").ToString, DataRow.Item("RACE_XML_NUMBER").ToString, Connection)
            End If

            Call Connection.Execute(CMDTEXT)
        End Sub
        Public Shared Sub UpdateHasModel(HasModel As String, MeetingOADate As String, MeetingNumber As String, RaceNumber As String, Connection As Utils.Connection)
            Dim CMDTEXT As String = "UPDATE RACE_EXTENDED SET HASMODEL=" & HasModel & " WHERE MEETING_XML_OADATE=" & MeetingOADate & " AND MEETING_XML_NUMBER=" & MeetingNumber & " AND NUMBER=" & RaceNumber
            Call Connection.Execute(CMDTEXT)
        End Sub
        Public Shared Sub UpdateHasModel(HasModel As String, MeetingOADate As String, Connection As Utils.Connection)
            Dim CMDTEXT As String = "UPDATE RACE_EXTENDED SET HASMODEL=" & HasModel & " WHERE MEETING_XML_OADATE=" & MeetingOADate
            Call Connection.Execute(CMDTEXT)
        End Sub
    End Class
End Namespace
