Namespace Processing
    Partial Class Results
        Partial Class XmlLoader
            Private NotInheritable Class Scratchings : Implements IDisposable
                Private ThisXML As String = Nothing
                Private ThisListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                Friend Sub New(ByVal RACEXML As String, ByRef ListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation))
                    Me.ThisXML = RACEXML
                    Me.ThisListOfEntryInformation = ListOfEntryInformation
                End Sub
                Friend Sub [Set]()
                    If Not Me.ThisXML.Contains("<SCRATCHINGS>") Then Return
                    '
                    Dim SCRATCHINGSXML As String = Strings.Mid(Me.ThisXML, InStr(Me.ThisXML, "<SCRATCHINGS>"))
                    SCRATCHINGSXML = Replace(SCRATCHINGSXML, "<SCRATCHINGS>", "")
                    SCRATCHINGSXML = Strings.Left(SCRATCHINGSXML, InStr(SCRATCHINGSXML, "</SCRATCHINGS>") - 1)
                    SCRATCHINGSXML = Replace(SCRATCHINGSXML, "<SCRATCHINGS ", "")
                    SCRATCHINGSXML = Trim(SCRATCHINGSXML)
                    '
                    For Each SCRATCHING As String In Split(SCRATCHINGSXML, "/>")
                        If Not SCRATCHING.Contains("NUMBER") Then Continue For
                        '
                        SCRATCHING = Strings.Mid(SCRATCHING, InStr(SCRATCHING, "NUMBER"))
                        Dim NUMBER As String = Nothing
                        For Each ScratchingAttribute As String In Split(SCRATCHING, """ ")
                            ScratchingAttribute = Replace(ScratchingAttribute, """", "")
                            If ScratchingAttribute.Length <= 2 Then Continue For
                            Dim KeyValue() As String = Split(ScratchingAttribute, "=")
                            '
                            If KeyValue(0) = "NUMBER" Then NUMBER = KeyValue(1) : Exit For
                        Next ScratchingAttribute
                        '
                        If NUMBER Is Nothing Then Continue For
                        '
                        For Each ENTRY_INFO As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.ThisListOfEntryInformation
                            If ENTRY_INFO.NUMBER = NUMBER Then ENTRY_INFO.SCRATCHED = True : Exit For
                        Next
                    Next SCRATCHING
                End Sub

#Region "IDisposable Support"
                Private disposedValue As Boolean ' To detect redundant calls

                ' IDisposable
                Protected Sub Dispose(disposing As Boolean)
                    If Not Me.disposedValue Then
                        If disposing Then
                            ' TODO: dispose managed state (managed objects).
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
        End Class
    End Class
End Namespace