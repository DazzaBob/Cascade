Public NotInheritable Class EntryPoint : Implements IDisposable
    Private disposedValue As Boolean
    Private ReadOnly This_OADate As String
    Private ReadOnly This_Messages As CascadeCommon.Messages
    Private ReadOnly This_Connection As CascadeCommon.Utils.Connection
    Private Sub New()
        Me.disposedValue = False
    End Sub
    Public Sub New(OADate As String, Messages As CascadeCommon.Messages, ConnectionString As String)
        Me.New

        This_OADate = OADate
        This_Messages = Messages
        This_Connection = New CascadeCommon.Utils.Connection(ConnectionString, Messages)
    End Sub
    Public Sub Start()
        Dim Broadcast As String = "*****     START CREATE STATISTICS FOR " & FormatDateTime(Date.FromOADate(CDbl(This_OADate)), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
        Call This_Messages.LogMessages(Broadcast, CascadeCommon.BroadcastTypes.Log)

        Dim This_Stopwatch As New Stopwatch
        This_Stopwatch.Start()

        Call LoadGreyHoundsBarrier()
        Call FirstX()

        This_Stopwatch.Stop()
        Broadcast = "*****     FINISHED CREATE STATISTICS FOR " & FormatDateTime(Date.FromOADate(CDbl(This_OADate)), DateFormat.LongDate) & " in: " & CascadeCommon.ElapsedTime(This_Stopwatch) & ".     *****"
        Call This_Messages.LogMessages(Broadcast, CascadeCommon.BroadcastTypes.Log)
    End Sub
    Private Sub LoadGreyHoundsBarrier()
        ' Database Connection is created in the class. Let the connection pool handle the rest.
        Using GB As New GreyhoundsBarrier.EntryPoint(This_OADate, This_Connection, This_Messages)
            GB.Start()
        End Using
    End Sub
    Private Sub FirstX()
        Using EP As New LastXRaces.EntryPoint(This_OADate, This_Messages, This_Connection)
            EP.Start()
        End Using
    End Sub
    Private Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                This_Connection.Dispose()
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