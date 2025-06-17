Imports CascadeCommon.Utils

Namespace GreyhoundsBarrier
    Partial Class EntryPoint
        Friend Class SQL : Implements IDisposable
            Private Shared DeleteStatsRaceBarrierLockObject As New Object
            Private disposedValue As Boolean
            Private ReadOnly This_Messages As CascadeCommon.Messages
            Private Sub New()
                Me.disposedValue = False
                Me.This_Messages = Nothing
            End Sub
            Friend Sub New(Messages As CascadeCommon.Messages)
                Me.New
                Me.This_Messages = Messages
            End Sub
            Friend Shared Sub Delete_StatsRaceBarrier(OADate As String, Messages As CascadeCommon.Messages, Connection As CascadeCommon.Utils.Connection)
                SyncLock DeleteStatsRaceBarrierLockObject
                    Try
                        Dim CMDTEXT As String = "DELETE FROM STATS_RACE_BARRIER WHERE MEETING_XML_OADATE=" & OADate
                        Call Connection.Execute(CMDTEXT)
                    Catch ex As Exception
                        Call Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                    End Try
                End SyncLock
            End Sub
            Friend Function Insert(OADate As String, MeetingNumber As String, RaceNumber As String, Barrier As String, Rank As String) As String
                Dim CMDTEXT As String = String.Empty
                Try
                    CMDTEXT = "INSERT INTO STATS_RACE_BARRIER ([MEETING_XML_OADATE], [MEETING_XML_NUMBER], [RACE_XML_NUMBER], [BARRIER], [RANK]) "
                    CMDTEXT += "VALUES (" & OADate & ", " & MeetingNumber & ", " & RaceNumber & ", " & Barrier & ", "
                    If Rank = String.Empty Then Rank = "0"
                    CMDTEXT += Rank & ") " & Environment.NewLine
                Catch ex As Exception
                    Call Me.This_Messages.LogMessages(ex.ToString, CascadeCommon.BroadcastTypes.Error)
                End Try

                Return CMDTEXT
            End Function
            Protected Overridable Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        ' TODO: dispose managed state (managed objects)
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
        End Class
    End Class
End Namespace