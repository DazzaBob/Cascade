Partial Class XmlLoader
    Friend Class Scratchings : Implements IDisposable
        Private disposedValue As Boolean ' To detect redundant calls

        Private ReadOnly This_XML As String = Nothing
        Private ReadOnly This_ListOf_EntryInformationScratchings As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationScratchings)
        Private Sub New()
            Me.disposedValue = False
        End Sub
        Friend Sub New(RaceXML As String, ByRef ListOf_EntryInformationScratchings As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationScratchings))
            Me.New
            Me.This_XML = RaceXML
            This_ListOf_EntryInformationScratchings = ListOf_EntryInformationScratchings
        End Sub
        Friend Sub [Set]()
            If Not Me.This_XML.Contains("<SCRATCHINGS>") Then Return

            Dim SCRATCHINGSXML As String = Strings.Mid(This_XML, InStr(This_XML, "<SCRATCHINGS>"))
            SCRATCHINGSXML = Replace(SCRATCHINGSXML, "<SCRATCHINGS>", "")
            SCRATCHINGSXML = Strings.Left(SCRATCHINGSXML, InStr(SCRATCHINGSXML, "</SCRATCHINGS>") - 1)
            SCRATCHINGSXML = Replace(SCRATCHINGSXML, "<SCRATCHINGS ", "")
            SCRATCHINGSXML = Trim(SCRATCHINGSXML)

            For Each SCRATCHING As String In Split(SCRATCHINGSXML, "/>")
                If Not SCRATCHING.Contains("NUMBER") Then Continue For

                SCRATCHING = Strings.Mid(SCRATCHING, InStr(SCRATCHING, "NUMBER"))
                Dim NUMBER As String = Nothing
                For Each ScratchingAttribute As String In Split(SCRATCHING, """ ")
                    ScratchingAttribute = Replace(ScratchingAttribute, """", "")
                    If ScratchingAttribute.Length <= 2 Then Continue For
                    Dim KeyValue() As String = Split(ScratchingAttribute, "=")

                    If KeyValue(0) = "NUMBER" Then NUMBER = KeyValue(1) : Exit For
                Next ScratchingAttribute

                If NUMBER Is Nothing Then Continue For

                Dim NewScratching As New Instance.MeetingInformation.RaceInformation.EntryInformationScratchings(NUMBER)
                This_ListOf_EntryInformationScratchings.Add(NewScratching)

            Next SCRATCHING
        End Sub
#Region "       IDisposable Support "
        ' IDisposable
        Protected Sub Dispose(disposing As Boolean)
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