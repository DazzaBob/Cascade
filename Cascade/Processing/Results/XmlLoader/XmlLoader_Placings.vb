Namespace Processing
    Partial Class Results
        Partial Class XmlLoader
            Private NotInheritable Class Placings : Implements IDisposable
                Private ThisXML As String = Nothing
                Private ThisListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                Friend Sub New(ByVal RACEXML As String, ByRef ListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation))
                    Me.ThisXML = RACEXML
                    Me.ThisListOfEntryInformation = ListOfEntryInformation
                End Sub
                Friend Sub [Set]()
                    If Not Me.ThisXML.Contains("<PLACINGS>") Then Return
                    '
                    Dim PLACINGSXML As String = Strings.Mid(Me.ThisXML, InStr(Me.ThisXML, "<PLACINGS>"))
                    PLACINGSXML = Replace(PLACINGSXML, "<PLACINGS>", "")
                    PLACINGSXML = Strings.Left(PLACINGSXML, InStr(PLACINGSXML, "</PLACINGS>") - 1)
                    PLACINGSXML = Replace(PLACINGSXML, "<PLACING ", "")
                    PLACINGSXML = Trim(PLACINGSXML)
                    '
                    For Each PLACING As String In Split(PLACINGSXML, "/>")
                        If Not PLACING.Contains("N") Then Continue For
                        '
                        PLACING = Strings.Mid(PLACING, InStr(PLACING, "N"))
                        Dim THIS_NUMBER As String = Nothing, THIS_DISTANCE As String = Nothing, THIS_RANK As String = Nothing
                        For Each PlacingAttribute As String In Split(PLACING, """ ")
                            PlacingAttribute = Replace(PlacingAttribute, """", "")
                            Dim KeyValue() As String = Split(PlacingAttribute, "=")
                            Select Case KeyValue(0).ToUpperInvariant
                                Case "NUMBER"
                                    THIS_NUMBER = KeyValue(1)
                                Case "DISTANCE"
                                    If IsNumeric(KeyValue(1)) Then
                                        THIS_DISTANCE = KeyValue(1)
                                    End If
                                Case "RANK"
                                    THIS_RANK = KeyValue(1)
                            End Select
                        Next PlacingAttribute
                        '
                        If THIS_RANK = "1" Then THIS_DISTANCE = "0"
                        If CShort(THIS_RANK) > 1S AndAlso (THIS_DISTANCE Is Nothing OrElse THIS_DISTANCE = "N/A") Then
                            ' Consolas THE DISTANCE.
                            THIS_DISTANCE = CStr(CDec(CInt(THIS_RANK) / 2))
                        End If
                        '
                        For Each ENTRY_INFO As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.ThisListOfEntryInformation
                            If ENTRY_INFO.NUMBER = THIS_NUMBER Then
                                ENTRY_INFO.DISTANCEBEHIND = THIS_DISTANCE
                                ENTRY_INFO.FINISHPOSITION = THIS_RANK
                                Exit For
                            End If
                        Next ENTRY_INFO
                    Next PLACING
                End Sub

#Region "IDisposable Support"
                Private disposedValue As Boolean ' To detect redundant calls

                ' IDisposable
                Friend Sub Dispose(disposing As Boolean)
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