Friend NotInheritable Class Tidyup : Implements IDisposable
    Private ReadOnly This_OADate As String
    Private ReadOnly This_Messages As CascadeCommon.Messages
    Private ReadOnly This_Connection As CascadeCommon.Utils.Connection
    Private disposedValue As Boolean
    Private Sub New()
        Me.disposedValue = False
        Me.This_OADate = String.Empty
        Me.This_Messages = Nothing
        Me.This_Connection = Nothing
    End Sub
    Friend Sub New(OADate As String, Messages As CascadeCommon.Messages, Connection As CascadeCommon.Utils.Connection)
        Me.New()
        Me.This_OADate = OADate
        Me.This_Messages = Messages
        Me.This_Connection = Connection
    End Sub
    Friend Sub Start()
        Dim Broadcast As String = "*****     START TIDY UP " & FormatDateTime(Date.FromOADate(Me.This_OADate), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
        Call This_Messages.LogMessages(Broadcast, CascadeCommon.Common.BroadcastTypes.Log)

        Call DeleteScratchedFromAlsoRan()
        Call DeleteOverEightScratchedGreyhounds()

        Broadcast = "*****     TIDY UP COMPLETE " & FormatDateTime(Date.FromOADate(Me.This_OADate), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
        Call Me.This_Messages.LogMessages(Broadcast, CascadeCommon.Common.BroadcastTypes.Log)
    End Sub
    Private Sub DeleteScratchedFromAlsoRan()
        Dim CMDTEXT As String = String.Empty
        Dim CommandText As String = "SELECT MEETING_XML_OADATE, MEETING_XML_NUMBER, RACE_XML_NUMBER, NUMBER FROM ENTRY_XML WHERE (SCRATCHED = 1) AND (MEETING_XML_OADATE = " & Me.This_OADate & ")"

        For Each DR As Data.DataRow In Me.This_Connection.GetDataTable(CommandText).Select("")
            CMDTEXT += "DELETE FROM RESULTS_XML_ALSORAN WHERE (MEETING_XML_OADATE=" & DR.Item(0).ToString & ") AND (MEETING_XML_NUMBER=" & DR.Item(1).ToString & ") AND (RACE_XML_NUMBER=" & DR.Item(2).ToString & ") AND (NUMBER=" & DR.Item(3).ToString & ") " & Environment.NewLine
        Next DR
        If CMDTEXT IsNot String.Empty Then Call Me.This_Connection.Execute(CMDTEXT)
    End Sub
    Private Sub DeleteOverEightScratchedGreyhounds()
        Dim CMDTEXT As String = String.Empty
        Dim CommandText As String = "SELECT ENTRY_XML.MEETING_XML_OADATE, ENTRY_XML.MEETING_XML_NUMBER, ENTRY_XML.RACE_XML_NUMBER, ENTRY_XML.NUMBER  
            FROM MEETING_XML INNER JOIN RACE_XML ON MEETING_XML.OADATE = RACE_XML.MEETING_XML_OADATE AND MEETING_XML.NUMBER = RACE_XML.MEETING_XML_NUMBER INNER JOIN ENTRY_XML ON RACE_XML.MEETING_XML_OADATE = ENTRY_XML.MEETING_XML_OADATE AND RACE_XML.MEETING_XML_NUMBER = ENTRY_XML.MEETING_XML_NUMBER AND RACE_XML.NUMBER = ENTRY_XML.RACE_XML_NUMBER 
            WHERE (MEETING_XML.TYPE = N'GR') AND (ENTRY_XML.BARRIER > 8) AND (ENTRY_XML.SCRATCHED = 1)"
        For Each DR As Data.DataRow In Me.This_Connection.GetDataTable(CommandText).Select("")
            CMDTEXT += "DELETE FROM ENTRY_XML WHERE (MEETING_XML_OADATE=" & DR.Item(0).ToString & ") AND (MEETING_XML_NUMBER=" & DR.Item(1).ToString & ") AND (RACE_XML_NUMBER=" & DR.Item(2).ToString & ") AND (NUMBER=" & DR.Item(3).ToString & ") " & Environment.NewLine
        Next
        If CMDTEXT IsNot String.Empty Then Call Me.This_Connection.Execute(CMDTEXT)
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