Namespace Processing
    Partial Class Results
        Partial Class XmlLoader
            Private NotInheritable Class Results : Implements IDisposable
                Private ThisXML As String = Nothing
                Private ThisListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                Friend Sub New(ByVal RACEXML As String, ByRef ListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation))
                    Me.ThisXML = RACEXML
                    Me.ThisListOfEntryInformation = ListOfEntryInformation
                End Sub
                Friend Sub [Set]()
                    If Not Me.ThisXML.Contains("<POOLS>") Then Return
                    '
                    Dim POOLSXML As String = Strings.Mid(Me.ThisXML, InStr(Me.ThisXML, "<POOLS>"))
                    POOLSXML = Replace(POOLSXML, "<POOLS>", "")
                    POOLSXML = Strings.Left(POOLSXML, InStr(POOLSXML, "</POOLS>") - 1)
                    POOLSXML = Replace(POOLSXML, "<POOL ", "")
                    POOLSXML = Trim(POOLSXML)
                    '
                    For Each POOL As String In Split(POOLSXML, "/>")
                        If Not POOL.Contains("TYPE") Then Continue For
                        '
                        POOL = Strings.Mid(POOL, InStr(POOL, "TYPE"))
                        If POOL.Length < 2 Then Continue For
                        '
                        Dim NUMBER As String = Nothing, AMOUNT As String = Nothing, TYPE As String = Nothing
                        For Each PoolAttribute As String In Split(POOL, """ ")
                            PoolAttribute = Replace(PoolAttribute, """", "")
                            Dim KeyValue() As String = Split(PoolAttribute, "=")
                            Select Case KeyValue(0).ToUpperInvariant
                                Case "NUMBER"
                                    NUMBER = KeyValue(1)
                                    Exit Select
                                Case "AMOUNT"
                                    AMOUNT = KeyValue(1)
                                    Exit Select
                                Case "TYPE"
                                    TYPE = KeyValue(1)
                            End Select
                        Next PoolAttribute
                        '
                        For Each ENTRY_INFO As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.ThisListOfEntryInformation
                            If ENTRY_INFO.NUMBER = NUMBER Then
                                ' ENTRY_INFO Results.
                                Select Case TYPE
                                    Case "WIN"
                                        ENTRY_INFO.PAIDWIN = AMOUNT
                                    Case "PLC"
                                        ENTRY_INFO.PAIDPLACE = AMOUNT
                                End Select
                                Exit For
                            End If
                        Next ENTRY_INFO
                    Next POOL
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