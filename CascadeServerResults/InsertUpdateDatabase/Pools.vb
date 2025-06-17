Partial Class InsertUpdateDatabase
    Friend Class Pools : Implements IDisposable
        Private disposedValue As Boolean
        Private ReadOnly _MEETINGINFORMATION As Instance.MeetingInformation
        Private ReadOnly _RACEINFORMATION As Instance.MeetingInformation.RaceInformation
        Private Sub New()
            Me.disposedValue = False
        End Sub
        Friend Sub New(MeetingInformation As Instance.MeetingInformation, RaceInformation As Instance.MeetingInformation.RaceInformation)
            Me.New
            Me._MEETINGINFORMATION = MeetingInformation
            Me._RACEINFORMATION = RaceInformation
        End Sub
        Friend Function CommandText() As String
            If _RACEINFORMATION.Status = "AB" Then Return String.Empty

            Dim CMDTEXT As String = String.Empty
            For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformationPools In Me._RACEINFORMATION.ListOf_EntryInformationPools
                If ENTRY.Name Is Nothing OrElse ENTRY.Amount Is Nothing Or ENTRY.Amount Is Nothing Then Continue For

                CMDTEXT += "INSERT INTO RESULTS_XML_POOLS ([MEETING_XML_OADATE], [MEETING_XML_NUMBER], [RACE_XML_NUMBER], [NUMBERS], [NAME], [AMOUNT], [TYPE]) "
                CMDTEXT += "VALUES (" & Me._MEETINGINFORMATION.OADate & ", " & Me._MEETINGINFORMATION.Number & ", " & Me._RACEINFORMATION.Number & ", "
                CMDTEXT += "'" & ENTRY.Number & "', '" & Replace(ENTRY.Name, "'", "") & "', " & ENTRY.Amount & ", '" & ENTRY.Type & "') " & Environment.NewLine
            Next ENTRY

            Return CMDTEXT
        End Function

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
End Class