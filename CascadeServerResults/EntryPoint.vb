Imports CascadeCommon
Public Class EntryPoint : Implements IDisposable
    Private disposedValue As Boolean

    Private ReadOnly This_OADate As String
    Private ReadOnly This_ResultsFolder As String
    Private ReadOnly This_Messages As CascadeCommon.Messages
    Private This_ConnectionString As String
    Private Sub New()
        Me.disposedValue = False
        Me.This_OADate = String.Empty
        Me.This_ResultsFolder = String.Empty
        Me.This_Messages = Nothing
        Me.This_ConnectionString = String.Empty
    End Sub
    Public Sub New(OADate As String, ResultsFolder As String, ConnectionString As String, Messages As CascadeCommon.Messages)
        Me.New

        Me.This_OADate = OADate
        Me.This_ResultsFolder = ResultsFolder
        Me.This_Messages = Messages
        Me.This_ConnectionString = ConnectionString
    End Sub
    Friend ReadOnly Property ConnectionString As String
        Get
            Return Me.This_ConnectionString
        End Get
    End Property
    Public Sub Start()
        Dim Connection = New CascadeCommon.Utils.Connection(Me.ConnectionString, This_Messages)

        Dim Broadcast As String = "*****     START LOAD RESULTS FOR " & FormatDateTime(Date.FromOADate(Me.This_OADate), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
        If Me.This_Messages IsNot Nothing Then Call Me.This_Messages.LogMessages(Broadcast, CascadeCommon.BroadcastTypes.Log)

        Dim XML As String = CascadeCommon.ReadFile(Me.This_ResultsFolder & "\" & Me.This_OADate & "\results.xml", Broadcast)
        If XML IsNot Nothing Then
            ' Load the XML, then test to see if its nothing. ToUpperInvariant throws an execption if the XML is nothing.
            XML = XML.ToUpperInvariant
            Try
                Using XMLLoader As New XmlLoader(XML, Me.This_OADate, Connection)
                    Dim MeetingInformation As List(Of Instance.MeetingInformation)
                    MeetingInformation = XMLLoader.GetListOfMeetingInformation

                    Using InsertUpdate As New InsertUpdateDatabase(Connection)
                        Call InsertUpdate.Start(MeetingInformation)
                    End Using
                End Using
                Call Me.This_Messages.LogMessages("Race results done!", CascadeCommon.BroadcastTypes.Log)
            Catch EX As Exception
                Call Me.This_Messages.LogMessages(EX.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                Call Me.This_Messages.LogMessages("Race results done, but with errors!" & Environment.NewLine & EX.ToString, CascadeCommon.Common.BroadcastTypes.Error)
            End Try
        Else
            Call Me.This_Messages.LogMessages("There is no XML Data to process!", CascadeCommon.Common.BroadcastTypes.Error)
            XML = Nothing
        End If
        Connection.Dispose()
    End Sub
    Private Sub Dispose(disposing As Boolean)
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