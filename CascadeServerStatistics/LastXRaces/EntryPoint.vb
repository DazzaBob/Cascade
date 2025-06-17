Imports System.Threading

Namespace LastXRaces
    Friend Class EntryPoint : Implements IDisposable
        Private disposedValue As Boolean

        Private ReadOnly This_OADate As String
        Private ReadOnly This_Messages As CascadeCommon.Messages
        Private ReadOnly This_Connection As CascadeCommon.Utils.Connection
        Private Sub New()
            Me.disposedValue = False
        End Sub
        Friend Sub New(OADate As String, Messages As CascadeCommon.Messages, Connection As CascadeCommon.Utils.Connection)
            Me.This_OADate = OADate
            Me.This_Messages = Messages
            Me.This_Connection = Connection
        End Sub
        Friend Sub Start()
            Call CascadeCommon.SQL.STATS_ENTRY_LASTX_RUNS.Delete_StatsEntryLastXRuns(This_OADate, This_Connection, This_Messages)

            Call NotifyCounts()
            Dim DR() As Data.DataRow = New DataTables(This_Messages).Meeting(This_OADate, This_Connection).Select("")
            If DR.Length > 0 Then
                For X As Integer = 0 To DR.Length - 1
                    Dim NewStopwatch As New Stopwatch
                    NewStopwatch.Start()

                    Call Me.This_Messages.LogMessages("Loading Entry STATistics for M" & DR(X).Item("NUMBER").ToString & "(" & DR(X).Item("NAME").ToString & ") on " & FormatDateTime(Date.FromOADate(Me.This_OADate), DateFormat.LongDate) & ".", CascadeCommon.BroadcastTypes.Log)
                    Try
                        Dim ProcessMeeting As New ProcessMeeting(DR(X), This_Connection.ToString, This_Messages)
                        Dim NewThread As New Threading.Thread(AddressOf ProcessMeeting.Start)
                        NewThread.IsBackground = True
                        NewThread.Start()
                        NewThread.Join()
                    Catch ex As Exception
                        Call Me.This_Messages.LogMessages(ex.ToString, CascadeCommon.BroadcastTypes.Error)
                    End Try
                    NewStopwatch.Stop()
                    Call Me.This_Messages.LogMessages("M" & DR(X).Item("NUMBER").ToString & " processed in: " & CascadeCommon.ElapsedTime(NewStopwatch) & ". ", CascadeCommon.BroadcastTypes.Log)
                Next X
            End If
        End Sub
        Private Sub NotifyCounts()
            Dim CommandText As String = "EXEC STATS_COUNTS_BASIC @OADATE=" & Me.This_OADate
            Dim DR() As Data.DataRow = Me.This_Connection.GetDataTable(CommandText).Select("")

            If DR.Length > 0 Then
                Call Me.This_Messages.LogMessages("There are " & DR(0).Item("COUNTOF_MEETINGS").ToString & " meetings, " & DR(0).Item("COUNTOF_RACES").ToString & " races and " & FormatNumber(DR(0).Item("COUNTOF_ENTRY"), 0) & " entries for " & FormatDateTime(Date.FromOADate(Me.This_OADate), DateFormat.LongDate) & ".", CascadeCommon.BroadcastTypes.Log)
            End If
        End Sub
#Region "       Disposing "
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
End Namespace