Namespace Processing
    Friend NotInheritable Class Results : Implements IDisposable
        Private MY_OADATE As String
        Friend Sub New(ByVal [date] As String)
            MY_OADATE = [date]
        End Sub
        Friend Sub Start()
            Dim Broadcast As String = "Download the results for " & FormatDateTime(Date.FromOADate(CDbl(MY_OADATE)), DateFormat.LongDate) & " in a MTA background thread, wait for thread to finish."
            Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)

            Call LogThreadDetails(Threading.Thread.CurrentThread)
            '
            Dim This_ResultsXML As String = Nothing
            Using XMLCache As XmlCache = New XmlCache("results", MY_OADATE)
                This_ResultsXML = XMLCache.GetXml
            End Using
            '
            If Not This_ResultsXML Is Nothing Then
                Broadcast = "Beginning to load race results " & Format(Date.FromOADate(CDbl(MY_OADATE)), "yyyy-MM-dd").ToString & " into database.... "
                Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                Try
                    Using ResultsLoader As XmlLoader = New XmlLoader(This_ResultsXML, CInt(MY_OADATE))
                        Using IUD As New InsertUpdateDatabase(ResultsLoader.GetListOfMeetingInformation)
                            Call IUD.Start()
                        End Using
                    End Using
                    Call ServerUI.Messages.LogMessages("Race results done!", Cascade.BroadcastTypes.Log)
                Catch EX As Exception
                    Call ServerUI.Messages.LogMessages("Race results done, but with errors!" & vbCrLf & EX.ToString, Cascade.BroadcastTypes.Error)
                End Try
            End If
        End Sub
#Region "   IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Friend Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    '
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub
        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
End Namespace