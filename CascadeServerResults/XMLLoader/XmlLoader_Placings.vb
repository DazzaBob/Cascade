Partial Class XmlLoader
    Friend Class Placings : Implements IDisposable
        Private disposedValue As Boolean ' To detect redundant calls

        Private ReadOnly This_XML As String = Nothing
        Private ReadOnly This_ListOf_EntryInformationPlacings As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPlacings)
        Private Sub New()
            Me.disposedValue = False
        End Sub
        Friend Sub New(RaceXML As String, ByRef ListOf_EntryInformationPlacings As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPlacings))
            Me.New
            Me.This_XML = RaceXML
            Me.This_ListOf_EntryInformationPlacings = ListOf_EntryInformationPlacings
        End Sub
        Friend Sub [Set]()
            If Not Me.This_XML.Contains("<PLACINGS>") Then Return

            Dim PLACINGSXML As String = Strings.Mid(Me.This_XML, InStr(Me.This_XML, "<PLACINGS>"))
            PLACINGSXML = Replace(PLACINGSXML, "<PLACINGS>", "")
            PLACINGSXML = Strings.Left(PLACINGSXML, InStr(PLACINGSXML, "</PLACINGS>") - 1)
            PLACINGSXML = Replace(PLACINGSXML, "<PLACING ", "")
            PLACINGSXML = Trim(PLACINGSXML)
            '
            For Each PLACING As String In Split(PLACINGSXML, "/>")
                If Not PLACING.Contains(CChar("N")) Then Continue For
                '
                PLACING = Strings.Mid(PLACING, InStr(PLACING, "N"))
                Dim THIS_NUMBER As String = String.Empty, THIS_DISTANCE As String = String.Empty
                Dim THIS_RANK As String = String.Empty
                For Each PlacingAttribute As String In Split(PLACING, """ ")
                    PlacingAttribute = Replace(PlacingAttribute, """", "")
                    Dim KeyValue() As String = Split(PlacingAttribute, "=")
                    Select Case KeyValue(0).ToUpperInvariant
                        Case "NUMBER"
                            THIS_NUMBER = KeyValue(1)
                            Exit Select
                        Case "RANK"
                            THIS_RANK = KeyValue(1)
                            Exit Select
                        Case "DISTANCE"
                            THIS_DISTANCE = If(THIS_RANK <> "1", KeyValue(1), "0")
                            Exit Select
                    End Select
                Next PlacingAttribute

                If THIS_RANK = "1" Then THIS_DISTANCE = "0"

                If THIS_DISTANCE Is String.Empty Then
                    THIS_DISTANCE = "N/A"
                End If

                Dim NewPlacing As New Instance.MeetingInformation.RaceInformation.EntryInformationPlacings(THIS_NUMBER) With
                {
                    .Distance = THIS_DISTANCE,
                    .FinishPosition = THIS_RANK
                }

                Me.This_ListOf_EntryInformationPlacings.Add(NewPlacing)
            Next PLACING
        End Sub
#Region "        IDisposable Support "
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