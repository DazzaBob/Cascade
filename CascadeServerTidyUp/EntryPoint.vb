Public Class EntryPoint : Implements IDisposable
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
    Public Sub New(OADate As String, Messages As CascadeCommon.Messages, ConnectionString As String)
        Me.New
        Me.This_OADate = OADate
        Me.This_Messages = Messages
        Me.This_Connection = New CascadeCommon.Utils.Connection(ConnectionString, Messages)
    End Sub
    Public Sub BeginTidyUp()
        Using t As New Tidyup(Me.This_OADate, Me.This_Messages, Me.This_Connection)
            t.Start()
        End Using
    End Sub
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                If Me.This_Connection IsNot Nothing Then Me.This_Connection.Dispose()
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
