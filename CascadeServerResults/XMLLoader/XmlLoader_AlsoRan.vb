Partial Class XmlLoader
    Friend Class AlsoRan : Implements IDisposable
        Private disposedValue As Boolean ' To detect redundant calls

        Private ReadOnly This_XML As String = Nothing
        Private ReadOnly This_ListOf_EntryInformationAlsoRan As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan)
        Private Sub New()
            Me.disposedValue = False
        End Sub
        Friend Sub New(RaceXML As String, ByRef ListOf_EntryInformationAlsoRan As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan))
            Me.New
            Me.This_XML = RaceXML
            Me.This_ListOf_EntryInformationAlsoRan = ListOf_EntryInformationAlsoRan
        End Sub
        Friend Sub [Set]()
            If Not Me.This_XML.Contains("<ALSO_RAN>") Then Return
            If Not Me.This_XML.Contains("<RUNNERS>") Then Return

            Dim ALSO_RANXML As String = Strings.Mid(Me.This_XML, InStr(Me.This_XML, "<ALSO_RAN>"))
            ALSO_RANXML = Strings.Left(ALSO_RANXML, InStr(ALSO_RANXML, "</ALSO_RAN>") - 1)
            Dim unused As String = Replace(ALSO_RANXML, "<ALSO_RAN>", "")
            ALSO_RANXML = Strings.Mid(Me.This_XML, InStr(Me.This_XML, "<RUNNERS>"))
            ALSO_RANXML = Strings.Left(ALSO_RANXML, InStr(ALSO_RANXML, "</RUNNERS>") - 1)
            ALSO_RANXML = Replace(ALSO_RANXML, "<RUNNERS>", "")
            ALSO_RANXML = Trim(ALSO_RANXML)

            For Each ALSO_RAN As String In Split(ALSO_RANXML, "/>")
                If Not ALSO_RAN.Contains("NUMBER") Then Continue For

                ALSO_RAN = Strings.Mid(ALSO_RAN, InStr(ALSO_RAN, "NUMBER"))
                If ALSO_RAN.Length < 2 Then Continue For

                Dim NUMBER As String = String.Empty, DISTANCE As String = String.Empty, FINISHPOSITION As String = String.Empty
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

                Dim NewAlsoRan As New Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan(NUMBER) With
                    {
                    .Distance = DISTANCE,
                    .FinishPosition = FINISHPOSITION
                    }

                This_ListOf_EntryInformationAlsoRan.Add(NewAlsoRan)
            Next ALSO_RAN
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