Namespace LastXRaces
    Partial Class EntryPoint
        Friend Class ProcessMeeting : Implements IDisposable
            Private disposedValue As Boolean
            Private ReadOnly This_MeetingDR As Data.DataRow
            Private This_Connection As CascadeCommon.Utils.Connection
            Private ReadOnly This_ConnectionString As String
            Private ReadOnly This_Messages As CascadeCommon.Messages
            Private Sub New()
                Me.disposedValue = False
                Me.This_MeetingDR = Nothing
                Me.This_Connection = Nothing
                Me.This_ConnectionString = String.Empty
                Me.This_Messages = Nothing
            End Sub
            Friend Sub New(MeetingDR As Data.DataRow, ConnectionString As String, Messages As CascadeCommon.Messages)
                Me.New
                Me.This_MeetingDR = MeetingDR
                Me.This_ConnectionString = ConnectionString
                Me.This_Messages = Messages
            End Sub
            Friend Sub Start()
                This_Connection = New CascadeCommon.Utils.Connection(This_ConnectionString, This_Messages)

                For Each Row As Data.DataRow In New DataTables(This_Messages).Race(This_MeetingDR.Item("OADATE").ToString, This_MeetingDR.Item("NUMBER").ToString, This_Connection).Select("")
                    Call RacesForRunners.RunnersForRace(This_MeetingDR.Item("OADATE").ToString, This_MeetingDR.Item("NUMBER").ToString, Row.Item("NUMBER").ToString, Me.This_Messages, This_Connection)
                Next Row

                This_Connection.Dispose()
            End Sub
            Protected Overridable Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        If This_Connection IsNot Nothing Then This_Connection.Dispose()
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