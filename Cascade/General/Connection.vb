' Leave class as NotInheritable; so we can use as a standard class, it might also be on another thread.
Friend NotInheritable Class Connection : Implements IDisposable
    Private MY_CONNECTION As SqlClient.SqlConnection
    Friend Sub New()
        MY_CONNECTION = New SqlClient.SqlConnection(My.Settings.ConnectionString)
        MY_CONNECTION.Open()
    End Sub
    Friend Function GetDataTable(ByVal commandtext As String) As DataTable
        If commandtext Is Nothing OrElse commandtext = "" Then Return New Data.DataTable
        If MY_CONNECTION Is Nothing Then Return New Data.DataTable
        If MY_CONNECTION.State <> ConnectionState.Open Then MY_CONNECTION.Open()
        '
        Using My_GetDataTable = New Data.DataTable
            My_GetDataTable.Locale = Globalization.CultureInfo.InvariantCulture
            Using SQLDataAdapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
                Try
                    Using Command As New SqlClient.SqlCommand
                        With Command
                            .CommandText = commandtext
                            .CommandTimeout = 0
                            .Connection = MY_CONNECTION
                        End With
                        SQLDataAdapter.SelectCommand = Command
                        SQLDataAdapter.Fill(My_GetDataTable)
                    End Using
                Catch EX As Exception
                    Dim Log As String = "Errror:" & EX.ToString & Environment.NewLine
                    Log = String.Concat(Log, "ConnectionString: " & MY_CONNECTION.ConnectionString & Environment.NewLine)
                    Log = String.Concat(Log, "CommandText: " & commandtext & Environment.NewLine)
                    Call ServerUI.Messages.LogMessages(Log, Cascade.BroadcastTypes.Error)
                End Try
            End Using
            '
            GetDataTable = My_GetDataTable
        End Using
    End Function
    Friend Function Execute(ByVal commandtext As String) As Boolean
        If commandtext Is Nothing OrElse commandtext = "" Then Return False
        If MY_CONNECTION Is Nothing Then Return False
        ' The threaded method creates its own connection on a seperate thread. so check this instance has an open connection.
        If MY_CONNECTION.State <> ConnectionState.Open Then MY_CONNECTION.Open()
        Execute = False
        Try
            Using Command As New SqlClient.SqlCommand
                With Command
                    .CommandText = commandtext
                    .CommandTimeout = 0
                    .Connection = MY_CONNECTION
                    .ExecuteNonQuery()
                End With
                Execute = True
            End Using
        Catch EX As Exception
            Dim Log As String = "Errror:" & EX.ToString & Environment.NewLine
            Log = String.Concat(Log, "ConnectionString: " & MY_CONNECTION.ConnectionString & Environment.NewLine)
            Log = String.Concat(Log, "CommandText: " & commandtext & Environment.NewLine)
            Call ServerUI.Messages.LogMessages(Log, BroadcastTypes.Error)
        End Try
        '
        Windows.Forms.Application.DoEvents()
    End Function
    Friend Function ExecuteScalar(ByVal commandtext As String) As Object
        If commandtext Is Nothing OrElse commandtext = "" Then Return Nothing
        ExecuteScalar = Nothing
        Try
            Using DW As SqlClient.SqlCommand = New SqlClient.SqlCommand(commandtext, MY_CONNECTION)
                If MY_CONNECTION.State <> ConnectionState.Open Then MY_CONNECTION.Open()
                DW.CommandTimeout = 0
                ExecuteScalar = DW.ExecuteScalar()
            End Using
        Catch EX As Exception
            Dim Log As String = "Errror:" & EX.ToString & Environment.NewLine
            Log = String.Concat(Log, "ConnectionString: " & MY_CONNECTION.ConnectionString & Environment.NewLine)
            Log = String.Concat(Log, "CommandText: " & commandtext & Environment.NewLine)
            Call ServerUI.Messages.LogMessages(Log, BroadcastTypes.Error)
        End Try
    End Function
#Region "       IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls
    ' IDisposable
    Friend Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                '
            End If
            If Not MY_CONNECTION Is Nothing Then MY_CONNECTION.Dispose() : MY_CONNECTION = Nothing
        End If
        Me.disposedValue = True
    End Sub
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class