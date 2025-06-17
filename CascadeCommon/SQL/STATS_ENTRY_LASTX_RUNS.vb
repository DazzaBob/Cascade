Namespace SQL
    Public Class STATS_ENTRY_LASTX_RUNS
        Private Shared DeleteStatsEntryLastXRunsLockObject As New Object
        Private Shared InsertLockObject As New Object
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared Function Insert(Mode As String, L As String, OADate As String, MeetingNumber As String, RaceNumber As String, EntryNumber As String, DistanceRuns As String, DistanceDistanceBehind As String, DistanceRank As String, DistanceiRuns As String, GroupRuns As String, GroupDistanceBehind As String, GroupRank As String, GroupiRuns As String, Sequence As String, SequenceDistanceBehind As String, SequenceRank As String, SequenceiRuns As String, OADateRan As String, LastRan As String, LengthRan As String, Messages As Messages) As String
            SyncLock InsertLockObject
                Dim CMDTEXT As String
                Try
                    CMDTEXT = "INSERT INTO STATS_ENTRY_"
                    If Mode IsNot String.Empty Then
                        CMDTEXT += "VENUE_"
                    End If

                    CMDTEXT += "LAST" & L & "RUNS(MEETING_XML_OADATE, MEETING_XML_NUMBER, RACE_XML_NUMBER, NUMBER, [LASTRAN], [FINISHPOSITION], [DISTANCE], [SEQUENCE], [SEQUENCE_RANK], [SEQUENCE_RUNS], [SEQUENCE_DISTANCEBEHIND], [GROUP], [GROUP_RANK], [GROUP_RUNS], [GROUP_DISTANCEBEHIND], [LENGTH], [LENGTH_RANK], [LENGTH_RUNS], [LENGTH_DISTANCEBEHIND]) " & Environment.NewLine
                    CMDTEXT += "VALUES(" & OADate & ", " & MeetingNumber & ", " & RaceNumber & ", " & EntryNumber & ", "

                    If OADateRan = String.Empty Then CMDTEXT += "NULL, " Else CMDTEXT += OADateRan & ", "
                    If LastRan = String.Empty Then CMDTEXT += "NULL, " Else CMDTEXT += LastRan & ", "
                    If LengthRan = String.Empty Then CMDTEXT += "NULL, " Else CMDTEXT += LengthRan & ", "

                    If Sequence = String.Empty Then CMDTEXT += "NULL, " Else CMDTEXT += "N'" & Sequence & "', "
                    CMDTEXT += SequenceRank & ", "
                    If Sequence = String.Empty Then CMDTEXT += "0, " Else CMDTEXT += SequenceiRuns & ", "
                    If SequenceDistanceBehind = String.Empty Then CMDTEXT += "99, " Else CMDTEXT += SequenceDistanceBehind & ", "

                    If GroupRuns = String.Empty Then CMDTEXT += "NULL, " Else CMDTEXT += "N'" & GroupRuns & "', "
                    CMDTEXT += GroupRank & ", "
                    If GroupRuns = String.Empty Then CMDTEXT += "0, " Else CMDTEXT += GroupiRuns & ", "
                    If GroupDistanceBehind = String.Empty Then CMDTEXT += "99, " Else CMDTEXT += GroupDistanceBehind & ", "

                    If DistanceRuns = String.Empty Then CMDTEXT += "NULL, " Else CMDTEXT += "N'" & DistanceRuns & "', "
                    CMDTEXT += DistanceRank & ", "
                    If DistanceRuns = String.Empty Then CMDTEXT += "0, " Else CMDTEXT += DistanceiRuns & ", "
                    If DistanceDistanceBehind = String.Empty Then CMDTEXT += "99" Else CMDTEXT += DistanceDistanceBehind
                    CMDTEXT += ") " & Environment.NewLine
                Catch ex As Exception
                    Call Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                    CMDTEXT = String.Empty
                End Try

                Return CMDTEXT
            End SyncLock
        End Function
        Public Shared Sub Delete_StatsEntryLastXRuns(OADate As String, Connection As CascadeCommon.Utils.Connection, Messages As Messages)
            SyncLock DeleteStatsEntryLastXRunsLockObject
                Dim CMDTEXT As String = "DELETE FROM STATS_ENTRY_LAST10RUNS WHERE MEETING_XML_OADATE=" & OADate & " " & Environment.NewLine
                CMDTEXT += "DELETE FROM STATS_ENTRY_LAST3RUNS WHERE MEETING_XML_OADATE=" & OADate & " " & Environment.NewLine
                CMDTEXT += "DELETE FROM STATS_ENTRY_VENUE_LAST10RUNS WHERE MEETING_XML_OADATE=" & OADate & " " & Environment.NewLine
                CMDTEXT += "DELETE FROM STATS_ENTRY_VENUE_LAST3RUNS WHERE MEETING_XML_OADATE=" & OADate
                Try
                    Call Connection.Execute(CMDTEXT)
                Catch ex As Exception
                    Call Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                End Try
            End SyncLock
        End Sub
    End Class
End Namespace