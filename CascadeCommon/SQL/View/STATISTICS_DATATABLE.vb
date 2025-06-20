﻿Imports CascadeCommon.Utils

Namespace SQL.View
    Public Class STATISTICS
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared Function DataTable(L As String, Filter As String, Connection As Utils.Connection) As Data.DataTable
            Dim CMDTEXT As String
            L = Strings.Replace(L, "L", "LAST")
            CMDTEXT = "SELECT "
            If Filter = "TOP 1" Then CMDTEXT += "TOP 1 "

            CMDTEXT += "VENUES.COUNTRY_ID,VENUES.TRACK_TYPE, RACE_XML.VENUE_ID, VENUES.NAME AS VENUE_NAME, 
            RACE_XML.LENGTH AS RACE_XML_LENGTH, RACE_XML.CLASS, STATS_RACE_BARRIER.RANK AS BARRIER_RANK, 0 AS MODEL_EXPLORER_ID, 
            ENTRY_XML.MEETING_XML_OADATE, ENTRY_XML.MEETING_XML_NUMBER, ENTRY_XML.RACE_XML_NUMBER, ENTRY_XML.NUMBER, ENTRY_XML.NAME, ENTRY_XML.BARRIER, ENTRY_XML.SCRATCHED, RESULTS_EXTENDED.FINISH_POSITION AS FINISHPOSITION, 
            STATS_ENTRY_" & L & "RUNS.LASTRAN, STATS_ENTRY_" & L & "RUNS.DISTANCE, STATS_ENTRY_" & L & "RUNS.SEQUENCE, STATS_ENTRY_" & L & "RUNS.SEQUENCE_RUNS, STATS_ENTRY_" & L & "RUNS.SEQUENCE_DISTANCEBEHIND, STATS_ENTRY_" & L & "RUNS.SEQUENCE_RANK, STATS_ENTRY_" & L & "RUNS.[GROUP], STATS_ENTRY_" & L & "RUNS.GROUP_RUNS, STATS_ENTRY_" & L & "RUNS.GROUP_DISTANCEBEHIND, STATS_ENTRY_" & L & "RUNS.GROUP_RANK, STATS_ENTRY_" & L & "RUNS.LENGTH, STATS_ENTRY_" & L & "RUNS.LENGTH_RUNS, STATS_ENTRY_" & L & "RUNS.LENGTH_DISTANCEBEHIND, STATS_ENTRY_" & L & "RUNS.LENGTH_RANK, STATS_ENTRY_" & L & "RUNS.FINISHPOSITION AS LASTRAN_FINISHPOSITION
 
            FROM STATS_RACE_BARRIER RIGHT OUTER JOIN ENTRY_XML ON STATS_RACE_BARRIER.MEETING_XML_OADATE = ENTRY_XML.MEETING_XML_OADATE AND STATS_RACE_BARRIER.MEETING_XML_NUMBER = ENTRY_XML.MEETING_XML_NUMBER AND STATS_RACE_BARRIER.RACE_XML_NUMBER = ENTRY_XML.RACE_XML_NUMBER AND STATS_RACE_BARRIER.BARRIER = ENTRY_XML.BARRIER LEFT OUTER JOIN RACE_XML INNER JOIN MEETING_XML ON RACE_XML.MEETING_XML_OADATE = MEETING_XML.OADATE AND RACE_XML.MEETING_XML_NUMBER = MEETING_XML.NUMBER INNER JOIN VENUES ON RACE_XML.VENUE_ID = VENUES.VENUE_ID ON ENTRY_XML.MEETING_XML_OADATE = RACE_XML.MEETING_XML_OADATE AND ENTRY_XML.MEETING_XML_NUMBER = RACE_XML.MEETING_XML_NUMBER AND ENTRY_XML.RACE_XML_NUMBER = RACE_XML.NUMBER LEFT OUTER JOIN STATS_ENTRY_" & L & "RUNS ON ENTRY_XML.MEETING_XML_OADATE = STATS_ENTRY_" & L & "RUNS.MEETING_XML_OADATE AND ENTRY_XML.MEETING_XML_NUMBER = STATS_ENTRY_" & L & "RUNS.MEETING_XML_NUMBER AND ENTRY_XML.RACE_XML_NUMBER = STATS_ENTRY_" & L & "RUNS.RACE_XML_NUMBER AND ENTRY_XML.NUMBER = STATS_ENTRY_" & L & "RUNS.NUMBER LEFT OUTER JOIN RESULTS_EXTENDED ON ENTRY_XML.MEETING_XML_OADATE = RESULTS_EXTENDED.MEETING_XML_OADATE AND ENTRY_XML.MEETING_XML_NUMBER = RESULTS_EXTENDED.MEETING_XML_NUMBER AND ENTRY_XML.RACE_XML_NUMBER = RESULTS_EXTENDED.RACE_XML_NUMBER AND ENTRY_XML.NUMBER = RESULTS_EXTENDED.NUMBER "

            'WHERE (VENUES.TRACK_TYPE = N'GR') AND (ENTRY_XML.MEETING_XML_OADATE = 45121) AND (ENTRY_XML.MEETING_XML_NUMBER = 3) AND (ENTRY_XML.RACE_XML_NUMBER = 1) AND (VENUES.COUNTRY_ID = 1)
            If Filter <> "TOP 1" Then
                CMDTEXT += "WHERE " & Filter & " ORDER BY LENGTH_RANK DESC"
            End If

            Return Connection.GetDataTable(CMDTEXT)
        End Function
    End Class
End Namespace