Partial Class XmlLoader
    Friend Class Pools : Implements IDisposable
        Private ReadOnly ThisXML As String = Nothing
        Private ReadOnly This_ListOf_EntryInformationPools As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPools)
        Friend Sub New(RACEXML As String, ByRef ListOf_EntryInformationPools As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPools))
            ThisXML = RACEXML
            This_ListOf_EntryInformationPools = ListOf_EntryInformationPools
        End Sub
        Friend Sub [Set]()
            If Not ThisXML.Contains("<POOLS>") Then Return

            Dim POOLSXML As String = Strings.Mid(ThisXML, InStr(ThisXML, "<POOLS>"))
            POOLSXML = Replace(POOLSXML, "<POOLS>", "")
            POOLSXML = Strings.Left(POOLSXML, InStr(POOLSXML, "</POOLS>") - 1)
            POOLSXML = Replace(POOLSXML, "<POOL ", "")
            POOLSXML = Trim(POOLSXML)

            For Each POOL As String In Split(POOLSXML, "/>")
                If Not POOL.Contains("TYPE") Then Continue For

                POOL = Strings.Mid(POOL, InStr(POOL, "TYPE"))
                If POOL.Length < 2 Then Continue For

                Dim THIS_NUMBER As String = Nothing, THIS_NAME As String = Nothing, THIS_AMOUNT As String = Nothing, THIS_TYPE As String = Nothing
                For Each PoolAttribute As String In Split(POOL, """ ")
                    PoolAttribute = Replace(PoolAttribute, """", "")
                    Dim KeyValue() As String = Split(PoolAttribute, "=")
                    Select Case KeyValue(0).ToUpperInvariant
                        Case "NUMBER"
                            THIS_NUMBER = Replace(KeyValue(1), ":", ",")
                            Exit Select
                        Case "NAME"
                            THIS_NAME = KeyValue(1)
                            Exit Select
                        Case "AMOUNT"
                            THIS_AMOUNT = KeyValue(1)
                            Exit Select
                        Case "TYPE"
                            If KeyValue(1) = "PLC" OrElse KeyValue(1) = "WIN" OrElse KeyValue(1) = "QLA" OrElse KeyValue(1) = "TFA" OrElse KeyValue(1) = "FT4" Then
                                THIS_TYPE = KeyValue(1)
                            Else
                                Exit For
                            End If
                    End Select
                Next PoolAttribute

                If THIS_TYPE Is Nothing Then Continue For

                Dim NewPool As New Instance.MeetingInformation.RaceInformation.EntryInformationPools(THIS_NUMBER) With
                    {.Name = THIS_NAME,
                     .Amount = THIS_AMOUNT,
                     .Type = THIS_TYPE
                    }
                This_ListOf_EntryInformationPools.Add(NewPool)
            Next POOL
        End Sub
#Region "               IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Friend Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            disposedValue = True
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