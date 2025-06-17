Imports System.Data

Namespace LastXRaces
    Partial Class EntryPoint
        Friend Class Last10Races : Implements IDisposable
            Private disposedValue As Boolean
            Private ReadOnly _RunnersInRaceDT As Data.DataTable
            Private ReadOnly _Connection As CascadeCommon.Utils.Connection
            Private ReadOnly _MeetingOADate As String
            Private ReadOnly _MeetingNumber As String
            Private ReadOnly _MeetingType As String
            Private ReadOnly _RaceNumber As String
            Private ReadOnly _EntryNumber As String
            Private ReadOnly _RunnerName As String
            Private ReadOnly _Length As String
            Private ReadOnly _Mode As String
            Private ReadOnly _Messages As CascadeCommon.Messages
            Private Sub New()
                Me.disposedValue = False
            End Sub
            Friend Sub New(RIRDT As Data.DataTable, Mode As String, MeetingOADate As String, MeetingNumber As String, MeetingType As String, RaceNumber As String, EntryNumber As String, RunnerName As String, Length As String, Messages As CascadeCommon.Messages, Connection As CascadeCommon.Utils.Connection)
                Me.New
                Me._Connection = Connection
                Me._RunnersInRaceDT = RIRDT
                Me._MeetingOADate = MeetingOADate
                Me._MeetingNumber = MeetingNumber
                Me._MeetingType = MeetingType
                Me._RaceNumber = RaceNumber
                Me._EntryNumber = EntryNumber
                Me._RunnerName = RunnerName
                Me._Length = Length
                Me._Mode = Mode
                Me._Messages = Messages
            End Sub
            Friend Sub Start()
                Dim ALDistance As New ArrayList
                Dim DistanceRank As Double = 0#
                Dim DistanceDistanceBehind As Double = 0#

                Dim ALDistance3 As New ArrayList
                Dim DistanceRank3 As Double = 0#
                Dim Distance3DistanceBehind As Double = 0#

                Dim ALGroup As New ArrayList
                Dim GroupRank As Double = 0#
                Dim GroupDistanceBehind As Double = 0#

                Dim ALGroup3 As New ArrayList
                Dim GroupRank3 As Double = 0#
                Dim Group3DistanceBehind As Double = 0#

                Dim ALSequence As New ArrayList
                Dim SequenceRank As Double = 0#
                Dim SequenceDistanceBehind As Double = 0#

                Dim ALSequence3 As New ArrayList
                Dim SequenceRank3 As Double = 0#
                Dim Sequence3DistanceBehind As Double = 0#

                Dim OADateRan As String = String.Empty
                Dim LastRan As String = String.Empty
                Dim LastRanDistance As String = String.Empty

                Dim X As Integer = 1
                For Each Row As Data.DataRow In _RunnersInRaceDT.Select("NAME='" & Me._RunnerName & "'", "MEETING_XML_OADATE ASC")
                    If X > 10 Then Exit For
                    ALSequence.Add(Row)

                    If ALSequence3.Count >= 3 Then ALSequence3.RemoveAt(0)
                    ALSequence3.Add(Row)

                    If Row.Item("LENGTH") = Me._Length Then
                        If ALDistance.Count >= 5 Then ALDistance.RemoveAt(0)
                        ALDistance.Add(Row)

                        If ALDistance3.Count >= 3 Then ALDistance3.RemoveAt(0)
                        ALDistance3.Add(Row)
                    Else
                        Dim GroupLengths As ArrayList = CascadeCommon.Utils.Groups.ArrayList(Me._MeetingType, _Length)
                        If Row.Item("LENGTH") >= GroupLengths(0) AndAlso Row.Item("LENGTH") <= GroupLengths(1) Then
                            If ALGroup.Count >= 5 Then ALGroup.RemoveAt(0)
                            ALGroup.Add(Row)

                            If ALGroup3.Count >= 3 Then ALGroup3.RemoveAt(0)
                            ALGroup3.Add(Row)
                        End If
                    End If
                    OADateRan = Row.Item("MEETING_XML_OADATE").ToString
                    LastRanDistance = Row.Item("LENGTH").ToString
                    If Not Information.IsDBNull(Row.Item("FINISH_POSITION")) Then LastRan = Row.Item("FINISH_POSITION").ToString
                    X += 1
                Next Row

                Dim DistanceiRuns As Integer = 0I, Distance3iRuns As Integer = 0I
                Dim sALDistance As String = GetStringForArrayList(ALDistance, DistanceiRuns, DistanceRank, DistanceDistanceBehind)
                Dim sALDistance3 As String = GetStringForArrayList(ALDistance3, Distance3iRuns, DistanceRank3, Distance3DistanceBehind)

                Dim GroupiRuns As Integer = 0I, Group3iRuns As Integer = 0I
                Dim sALGroup As String = GetStringForArrayList(ALGroup, GroupiRuns, GroupRank, GroupDistanceBehind)
                Dim sALGroup3 As String = GetStringForArrayList(ALGroup3, Group3iRuns, GroupRank3, Group3DistanceBehind)

                Dim SequenceiRuns As Integer = 0I, Sequence3iRuns As Integer = 0I
                Dim sALSequence As String = GetStringForArrayList(ALSequence, SequenceiRuns, SequenceRank, SequenceDistanceBehind)
                Dim sALSequence3 As String = GetStringForArrayList(ALSequence3, Sequence3iRuns, SequenceRank3, Sequence3DistanceBehind)

                Dim CMDTEXT As String = String.Empty
                If _Mode Is String.Empty Then
                    CMDTEXT += CascadeCommon.SQL.STATS_ENTRY_LASTX_RUNS.Insert(String.Empty, "10", Me._MeetingOADate, Me._MeetingNumber, Me._RaceNumber, Me._EntryNumber, sALDistance, DistanceDistanceBehind, DistanceRank, DistanceiRuns, sALGroup, GroupDistanceBehind, GroupRank, GroupiRuns, sALSequence, SequenceDistanceBehind, SequenceRank, SequenceiRuns, OADateRan, LastRan, LastRanDistance, _Messages)
                    CMDTEXT += CascadeCommon.SQL.STATS_ENTRY_LASTX_RUNS.Insert(String.Empty, "3", Me._MeetingOADate, Me._MeetingNumber, Me._RaceNumber, Me._EntryNumber, sALDistance3, Distance3DistanceBehind, DistanceRank3, Distance3iRuns, sALGroup3, Group3DistanceBehind, GroupRank3, Group3iRuns, sALSequence3, Sequence3DistanceBehind, SequenceRank3, Sequence3iRuns, OADateRan, LastRan, LastRanDistance, _Messages)
                Else
                    CMDTEXT += CascadeCommon.SQL.STATS_ENTRY_LASTX_RUNS.Insert("VENUE", "10", Me._MeetingOADate, Me._MeetingNumber, Me._RaceNumber, Me._EntryNumber, sALDistance, DistanceDistanceBehind, DistanceRank, DistanceiRuns, sALGroup, GroupDistanceBehind, GroupRank, GroupiRuns, sALSequence, SequenceDistanceBehind, SequenceRank, SequenceiRuns, OADateRan, LastRan, LastRanDistance, _Messages)
                    CMDTEXT += CascadeCommon.SQL.STATS_ENTRY_LASTX_RUNS.Insert("VENUE", "3", Me._MeetingOADate, Me._MeetingNumber, Me._RaceNumber, Me._EntryNumber, sALDistance3, Distance3DistanceBehind, DistanceRank3, Distance3iRuns, sALGroup3, Group3DistanceBehind, GroupRank3, Group3iRuns, sALSequence3, Sequence3DistanceBehind, SequenceRank3, Sequence3iRuns, OADateRan, LastRan, LastRanDistance, _Messages)
                End If
                Call _Connection.Execute(CMDTEXT)
            End Sub
            Private Function GetStringForArrayList(AL As ArrayList, ByRef IRuns As Integer, ByRef Rank As Double, ByRef TotalDistanceBehind As Double) As String
                If AL.Count = 0 Then Return String.Empty

                Dim Divider As Double = 0#
                Dim ThisString As String = String.Empty
                Try
                    For Each DataRow As Data.DataRow In AL
                        If IsScratched(DataRow, Rank, ThisString) Then
                            Continue For
                        End If
                        If IsFinishPosition(DataRow, IRuns, Rank, TotalDistanceBehind, ThisString) Then
                            Continue For
                        End If

                        ThisString += "?|"
                    Next DataRow

                    If IRuns > 0I Then
                        Rank /= AL.Count
                        TotalDistanceBehind /= IRuns
                    Else
                        IRuns = 0
                    End If

                    If ThisString.Length > 0 Then ThisString = Strings.Left(ThisString, Strings.Len(ThisString) - 1)
                Catch ex As Exception
                    Call Me._Messages.LogMessages(ex.ToString, CascadeCommon.BroadcastTypes.Error)
                End Try

                Return ThisString
            End Function
            Private Function IsScratched(ByRef Datarow As Data.DataRow, ByRef Rank As Double, ByRef sString As String) As Boolean
                Try
                    If Datarow.Item("SCRATCHED") = 1 AndAlso Information.IsDBNull(Datarow.Item("EXCEPTION")) Then
                        sString += "X|"
                        Return True

                    ElseIf Datarow.Item("SCRATCHED") = 1 OrElse Not Information.IsDBNull(Datarow.Item("EXCEPTION")) Then
                        If Datarow.Item("EXCEPTION").ToString <> "PULL" Then Rank -= 12.5#
                        sString += Datarow.Item("EXCEPTION").ToString & "|"
                        Return True
                    End If

                    ' Chances are the runner is scrtached, Late scratching
                    If Information.IsDBNull(Datarow.Item("FINISH_POSITION")) AndAlso (Information.IsDBNull(Datarow.Item("DISTANCE_BEHIND")) OrElse Datarow.Item("DISTANCE_BEHIND") = "999") Then
                        sString += "X|"
                        Return True
                    End If
                Catch ex As Exception
                    Call _Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                End Try

                Return False
            End Function
            Private Function IsFinishPosition(ByRef DataRow As Data.DataRow, ByRef IRuns As Integer, ByRef Rank As Double, ByRef DistanceBehind As Double, ByRef sString As String) As Boolean
                Try
                    If Not Information.IsDBNull(DataRow.Item("FINISH_POSITION")) Then
                        If Not Information.IsDBNull(DataRow.Item("RANKED")) Then
                            Rank += CDbl(DataRow.Item("RANKED"))
                            DistanceBehind += CDbl(DataRow.Item("DISTANCE_BEHIND"))
                        End If
                        sString += DataRow.Item("FINISH_POSITION").ToString & "|"
                        IRuns += 1
                        Return True
                    Else
                        If Not Information.IsDBNull(DataRow.Item("EXCEPTION")) Then
                            Rank -= 12.5#
                            sString += DataRow.Item("EXCEPTION").ToString & "|"
                            Return True
                        End If
                    End If
                Catch Ex As Exception
                    Call _Messages.LogMessages(Ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                End Try
                Return False
            End Function
#Region "        Disposing "
            Private Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        '
                    End If

                    ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                    ' TODO: set large fields to null
                    disposedValue = True
                End If
            End Sub
            ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
            ' Protected Overrides Sub Finalize()
            '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            '     Dispose(disposing:=False)
            '     MyBase.Finalize()
            ' End Sub
            Public Sub Dispose() Implements IDisposable.Dispose
                ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
                Dispose(disposing:=True)
                GC.SuppressFinalize(Me)
            End Sub
#End Region
        End Class
    End Class
End Namespace