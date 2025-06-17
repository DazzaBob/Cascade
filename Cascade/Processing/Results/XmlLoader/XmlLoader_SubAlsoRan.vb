Namespace Processing
    Partial Class Results
        Partial Class XmlLoader
            Private NotInheritable Class AlsoRan : Implements IDisposable
                Private ThisXML As String = Nothing
                Private ThisListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                Friend Sub New(ByVal RACEXML As String, ByRef ListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation))
                    Me.ThisXML = RACEXML
                    Me.ThisListOfEntryInformation = ListOfEntryInformation
                End Sub
                Friend Sub [Set]()
                    If Not Me.ThisXML.Contains("<ALSO_RAN>") Then Return
                    If Not Me.ThisXML.Contains("<RUNNERS>") Then Return
                    '
                    Dim ALSO_RANXML As String = Strings.Mid(Me.ThisXML, InStr(Me.ThisXML, "<ALSO_RAN>"))
                    ALSO_RANXML = Strings.Left(ALSO_RANXML, InStr(ALSO_RANXML, "</ALSO_RAN>") - 1)
                    ALSO_RANXML = Replace(ALSO_RANXML, "<ALSO_RAN>", "")
                    ALSO_RANXML = Strings.Mid(Me.ThisXML, InStr(Me.ThisXML, "<RUNNERS>"))
                    ALSO_RANXML = Strings.Left(ALSO_RANXML, InStr(ALSO_RANXML, "</RUNNERS>") - 1)
                    ALSO_RANXML = Replace(ALSO_RANXML, "<RUNNERS>", "")
                    ALSO_RANXML = Trim(ALSO_RANXML)
                    '
                    For Each ALSO_RAN As String In Split(ALSO_RANXML, "/>")
                        If Not ALSO_RAN.Contains("NUMBER") Then Continue For
                        '
                        ALSO_RAN = Strings.Mid(ALSO_RAN, InStr(ALSO_RAN, "NUMBER"))
                        If ALSO_RAN.Length < 2 Then Continue For
                        '
                        Dim NUMBER As String = Nothing, DISTANCE As String = Nothing, FINISHPOSITION As String = Nothing
                        For Each Also_RanAttribute As String In Split(ALSO_RAN, """ ")
                            Also_RanAttribute = Replace(Also_RanAttribute, """", "")
                            Dim KeyValue() As String = Split(Also_RanAttribute, "=")
                            Select Case KeyValue(0)
                                Case "NUMBER"
                                    NUMBER = KeyValue(1)
                                Case "DISTANCE"
                                    DISTANCE = KeyValue(1)
                                Case "FINISH_POSITION"
                                    FINISHPOSITION = KeyValue(1)
                            End Select
                        Next Also_RanAttribute
                        '
                        If (FINISHPOSITION Is Nothing) OrElse (FINISHPOSITION = "0") Then FINISHPOSITION = "9"
                        '
                        If (DISTANCE Is Nothing) OrElse (Not IsNumeric(DISTANCE)) Then
                            DISTANCE = CStr(CDec(CInt(FINISHPOSITION) / 1.3))
                        End If
                        '
                        For Each ENTRY_INFO As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.ThisListOfEntryInformation
                            If ENTRY_INFO.NUMBER = NUMBER Then
                                If Not ENTRY_INFO.SCRATCHED Then
                                    ENTRY_INFO.DISTANCEBEHIND = DISTANCE
                                    ENTRY_INFO.FINISHPOSITION = FINISHPOSITION
                                    Exit For
                                End If
                            End If
                        Next ENTRY_INFO
                    Next ALSO_RAN
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