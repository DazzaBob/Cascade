Namespace Utils
    Friend NotInheritable Class Tidyup : Implements IDisposable
        Private ReadOnly _OADATE As String
        Private ReadOnly _MESSAGES As Messages
        Private ReadOnly _CONNECTION As Connection
        Private disposedValue As Boolean
        Private Sub New()
            Me._OADATE = String.Empty
            Me._MESSAGES = Nothing
            Me._CONNECTION = Nothing
        End Sub
        Friend Sub New(OADate As String, Messages As Messages, Connection As Utils.Connection)
            Me.New()
            Me._OADATE = OADate
            Me._MESSAGES = Messages
            Me._CONNECTION = Connection
        End Sub
        Friend Sub Start()
            Dim Broadcast As String = "*****     START TIDY UP " & FormatDateTime(Date.FromOADate(_OADATE), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
            Call _MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)
            Call Utils.LogThreadDetails(Threading.Thread.CurrentThread, _MESSAGES)

            Call DeleteScratchedFromAlsoRan()
            Call DeleteUnknownDistancebehind()
            Call DeleteOverEightScratchedGreyhounds()

            Broadcast = "*****     TIDY UP COMPLETE " & FormatDateTime(Date.FromOADate(_OADATE), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
            Call _MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)
        End Sub
        Private Sub DeleteScratchedFromAlsoRan()
            Dim CMDTEXT As String = String.Empty
            Dim CommandText As String = "SELECT MEETING_XML_OADATE, MEETING_XML_NUMBER, RACE_XML_NUMBER, NUMBER FROM ENTRY_XML WHERE (SCRATCHED = 1) AND (MEETING_XML_OADATE = " & _OADATE & ")"

            For Each DR As Data.DataRow In _CONNECTION.GetDataTable(CommandText).Select("")
                CMDTEXT += "DELETE FROM RESULTS_XML_ALSORAN WHERE (MEETING_XML_OADATE=" & DR.Item(0).ToString & ") AND (MEETING_XML_NUMBER=" & DR.Item(1).ToString & ") AND (RACE_XML_NUMBER=" & DR.Item(2).ToString & ") AND (NUMBER=" & DR.Item(3).ToString & ") " & Environment.NewLine
            Next DR
            If CMDTEXT IsNot String.Empty Then Call _CONNECTION.Execute(CMDTEXT)
        End Sub
        Private Sub DeleteUnknownDistancebehind()
            Dim CMDTEXT As String = String.Empty
            Dim CommandText As String = "SELECT MEETING_XML_OADATE, MEETING_XML_NUMBER, RACE_XML_NUMBER, NUMBER FROM RESULTS_XML_ALSORAN 
            WHERE (DISTANCE_BEHIND = 999) AND (EXCEPTION IS NULL) AND (MEETING_XML_OADATE = " & _OADATE & ") " & Environment.NewLine

            For Each DR As Data.DataRow In _CONNECTION.GetDataTable(CommandText).Select("")
                CMDTEXT += "DELETE FROM RESULTS_XML_ALSORAN WHERE (MEETING_XML_OADATE=" & DR.Item(0).ToString & ") AND (MEETING_XML_NUMBER=" & DR.Item(1).ToString & ") AND (RACE_XML_NUMBER=" & DR.Item(2).ToString & ") AND (NUMBER=" & DR.Item(3).ToString & ") " & Environment.NewLine
            Next DR
            If CMDTEXT IsNot String.Empty Then Call _CONNECTION.Execute(CMDTEXT)
        End Sub
        Private Sub DeleteOverEightScratchedGreyhounds()
            Dim CMDTEXT As String = String.Empty
            Dim CommandText As String = "SELECT ENTRY_XML.MEETING_XML_OADATE, ENTRY_XML.MEETING_XML_NUMBER, ENTRY_XML.RACE_XML_NUMBER, ENTRY_XML.NUMBER  
            FROM MEETING_XML INNER JOIN RACE_XML ON MEETING_XML.OADATE = RACE_XML.MEETING_XML_OADATE AND MEETING_XML.NUMBER = RACE_XML.MEETING_XML_NUMBER INNER JOIN ENTRY_XML ON RACE_XML.MEETING_XML_OADATE = ENTRY_XML.MEETING_XML_OADATE AND RACE_XML.MEETING_XML_NUMBER = ENTRY_XML.MEETING_XML_NUMBER AND RACE_XML.NUMBER = ENTRY_XML.RACE_XML_NUMBER 
            WHERE (MEETING_XML.TYPE = N'GR') AND (ENTRY_XML.BARRIER > 8) AND (ENTRY_XML.SCRATCHED = 1)"
            For Each DR As Data.DataRow In _CONNECTION.GetDataTable(CommandText).Select("")
                CMDTEXT += "DELETE FROM ENTRY_XML WHERE (MEETING_XML_OADATE=" & DR.Item(0).ToString & ") AND (MEETING_XML_NUMBER=" & DR.Item(1).ToString & ") AND (RACE_XML_NUMBER=" & DR.Item(2).ToString & ") AND (NUMBER=" & DR.Item(3).ToString & ") " & Environment.NewLine
            Next
            If CMDTEXT IsNot String.Empty Then Call _CONNECTION.Execute(CMDTEXT)
        End Sub
        Private Sub DeleteSTATS_withnoEntry()
            Dim CMDTEXT As String = "DELETE FROM STATS_ENTRY_LASTFIVE "
            CMDTEXT += "SELECT STATS_ENTRY_LASTFIVE.MEETING_XML_OADATE, STATS_ENTRY_LASTFIVE.MEETING_XML_NUMBER, STATS_ENTRY_LASTFIVE.RACE_XML_NUMBER, STATS_ENTRY_LASTFIVE.NUMBER
                        FROM  ENTRY_XML RIGHT OUTER JOIN STATS_ENTRY_LASTFIVE ON ENTRY_XML.NUMBER = STATS_ENTRY_LASTFIVE.NUMBER AND ENTRY_XML.RACE_XML_NUMBER = STATS_ENTRY_LASTFIVE.RACE_XML_NUMBER AND ENTRY_XML.MEETING_XML_NUMBER = STATS_ENTRY_LASTFIVE.MEETING_XML_NUMBER AND ENTRY_XML.MEETING_XML_OADATE = STATS_ENTRY_LASTFIVE.MEETING_XML_OADATE "
            CMDTEXT += "WHERE (ENTRY_XML.MEETING_XML_OADATE IS NULL) AND (STATS_ENTRY_LASTFIVE.MEETING_XML_OADATE < " & Me._OADATE & ")"

            Call Me._CONNECTION.Execute(CMDTEXT)
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
End Namespace