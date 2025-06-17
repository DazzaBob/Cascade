Public Class EntryPoint : Implements IDisposable
    Private disposedValue As Boolean
    Private Sub New()
        Me.disposedValue = False
    End Sub
    Public Sub New(ConnectionString As String, Messages As Messages, IsTesting As Boolean, OADate As String)
        Me.New
        Common.Connection = New Utils.Connection(ConnectionString, Messages)
        Common.Messages = Messages
        Common.IsTesting = IsTesting
        Common.MeetingOADate = OADate
    End Sub
    Public Sub New(ConnectionString As String, Messages As Messages, IsTesting As Boolean, StartDate As String, FinishDate As String)
        Me.New
        Common.Connection = New Utils.Connection(ConnectionString, Messages)
        Common.Messages = Messages
        Common.IsTesting = IsTesting
        Common.StartOADate = StartDate
        Common.FinishOADate = FinishDate
    End Sub
    Public Sub Start()
        Me.disposedValue = False

        Try
            Using NewMR As New ModelRun.EntryPoint()
                Call NewMR.Start()
            End Using
        Catch ex As Exception
            Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
        End Try
    End Sub

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                Connection.Dispose()
                Common.StartOADate = Nothing
                Common.FinishOADate = Nothing
                Common.MeetingOADate = Nothing
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
