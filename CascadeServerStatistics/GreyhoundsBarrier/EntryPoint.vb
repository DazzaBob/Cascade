Imports System.Threading

Namespace GreyhoundsBarrier
    Friend Class EntryPoint : Implements IDisposable
        Private disposedValue As Boolean
        Private ReadOnly This_OADate As String
        Private ReadOnly This_Messages As CascadeCommon.Messages
        Private ReadOnly This_Connection As CascadeCommon.Utils.Connection
        Private Sub New()
            Me.disposedValue = False

            Me.This_OADate = String.Empty
            Me.This_Messages = Nothing
            Me.This_Connection = Nothing
        End Sub
        Friend Sub New(OADate As String, Connection As CascadeCommon.Utils.Connection, Messages As CascadeCommon.Messages)
            Me.New

            Me.This_OADate = OADate
            Me.This_Messages = Messages
            Me.This_Connection = Connection
        End Sub
        Friend Sub Start()
            Dim This_Stopwatch As New Stopwatch
            This_Stopwatch.Start()

            Call SQL.Delete_StatsRaceBarrier(This_OADate, This_Messages, This_Connection)
            Using MeetingDT As Data.DataTable = New DataTables(This_Messages).Meeting(This_OADate, This_Connection)

                If MeetingDT.Rows.Count > 0 Then
                    Call BeginMultiThreading(MeetingDT)
                    This_Stopwatch.Stop()
                    Call Me.This_Messages.LogMessages("Created barrier STATistics for " & FormatDateTime(Date.FromOADate(Me.This_OADate), DateFormat.ShortDate) & " in: " & CascadeCommon.ElapsedTime(This_Stopwatch) & ".", CascadeCommon.BroadcastTypes.Log)
                Else
                    This_Stopwatch.Stop()
                    Call Me.This_Messages.LogMessages("There are no Greyhounds races for " & FormatDateTime(Date.FromOADate(Me.This_OADate), DateFormat.ShortDate) & ".", CascadeCommon.BroadcastTypes.Log)
                End If
            End Using
        End Sub
        Private Sub BeginMultiThreading(MeetingDT As Data.DataTable)
            Try
                Dim ALThreads As New ArrayList
                For Each Row As Data.DataRow In MeetingDT.Select("")
                    Dim cPM As New ProcessMeeting(Row, This_Connection.String, This_Messages)
                    Dim NewThread As New Thread(AddressOf cPM.Start) With {
                .IsBackground = True
            }
                    ALThreads.Add(NewThread)
                Next Row
                For Each ALThread As Thread In ALThreads
                    ALThread.Start()
                Next
                For Each ALThread As Thread In ALThreads
                    ALThread.Join()
                Next
            Catch ex As Exception
                Call This_Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
            End Try
        End Sub
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
    End Class
End Namespace