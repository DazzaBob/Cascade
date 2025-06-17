Partial Class InsertUpdateDatabase
    Friend Class Placings : Implements IDisposable
        Private disposedValue As Boolean

        Private ReadOnly _MEETINGINFORMATION As Instance.MeetingInformation
        Private ReadOnly _RACEINFORMATION As Instance.MeetingInformation.RaceInformation
        Private ReadOnly _CONNECTION As CascadeCommon.Utils.Connection
        Private Sub New()
            Me.disposedValue = False
        End Sub
        Friend Sub New(MeetingInformation As Instance.MeetingInformation, RaceInformation As Instance.MeetingInformation.RaceInformation, Connection As CascadeCommon.Utils.Connection)
            Me.New
            Me._MEETINGINFORMATION = MeetingInformation
            Me._RACEINFORMATION = RaceInformation
            Me._CONNECTION = Connection
        End Sub
        Friend Sub CommandText()
            For X As Integer = 0 To _RACEINFORMATION.ListOf_EntryInformationPlacings.Count - 1
                Dim Placing As Instance.MeetingInformation.RaceInformation.EntryInformationPlacings = _RACEINFORMATION.ListOf_EntryInformationPlacings(X)

                If Placing.FinishPosition Is String.Empty AndAlso Placing.Distance Is String.Empty Then Continue For
                If Placing.FinishPosition = "1" Then Placing.Distance = "0"

                If Placing.Distance.Contains(CChar("|")) Then ' Its probably a dead heat.
                    Placing.Distance = Strings.Left(Placing.Distance, Placing.Distance.IndexOf("|"))
                    If CInt(Placing.FinishPosition) = 2I Then
                        Placing.FinishPosition = (CInt(Placing.FinishPosition) - 1).ToString
                        Placing.Distance = "0"
                    ElseIf CInt(Placing.FinishPosition) = 3I Then
                        Placing.FinishPosition = (CInt(Placing.FinishPosition) - 1).ToString
                    End If
                End If

                If Not IsNumeric(Placing.Distance) Then
                    Placing.Distance = DMODistanceBehind(Placing.FinishPosition)
                End If

                Dim CMDTEXT As String = "INSERT INTO RESULTS_XML_PLACINGS ([MEETING_XML_OADATE], [MEETING_XML_NUMBER], [RACE_XML_NUMBER], [NUMBER], [FINISH_POSITION], [DISTANCE_BEHIND]) "
                CMDTEXT += "VALUES (" & Me._MEETINGINFORMATION.OADate & ", " & Me._MEETINGINFORMATION.Number & ", " & Me._RACEINFORMATION.Number & ", " & Placing.Number & ", "
                CMDTEXT += Placing.FinishPosition & ", " & Placing.Distance & ") " & Environment.NewLine

                CMDTEXT += "INSERT INTO RESULTS_EXTENDED ([MEETING_XML_OADATE], [MEETING_XML_NUMBER], [RACE_XML_NUMBER], [NUMBER], [FINISH_POSITION], [DISTANCE_BEHIND]) "
                CMDTEXT += "VALUES (" & Me._MEETINGINFORMATION.OADate & ", " & Me._MEETINGINFORMATION.Number & ", " & Me._RACEINFORMATION.Number & ", " & Placing.Number & ", "
                CMDTEXT += Placing.FinishPosition & ", " & Placing.Distance & ")"

                Me._CONNECTION.Execute(CMDTEXT)
            Next X
        End Sub
        Private Function DMODistanceBehind(FinishPosition As String) As String
            Dim CMDTEXT As String
            CMDTEXT = "SELECT AVG(RESULTS_XML_PLACINGS.DISTANCE_BEHIND) AS DISTANCE_BEHIND 
                FROM RACE_XML INNER JOIN MEETING_XML ON RACE_XML.MEETING_XML_OADATE = MEETING_XML.OADATE AND RACE_XML.MEETING_XML_NUMBER = MEETING_XML.NUMBER INNER JOIN RESULTS_XML_PLACINGS ON RACE_XML.MEETING_XML_OADATE = RESULTS_XML_PLACINGS.MEETING_XML_OADATE AND RACE_XML.MEETING_XML_NUMBER = RESULTS_XML_PLACINGS.MEETING_XML_NUMBER AND RACE_XML.NUMBER = RESULTS_XML_PLACINGS.RACE_XML_NUMBER 
                WHERE (MEETING_XML.TYPE = N'" & Me._MEETINGINFORMATION.Type & "') AND (RACE_XML.LENGTH = " & Me._RACEINFORMATION.Distance & ") AND (RESULTS_XML_PLACINGS.FINISH_POSITION = " & FinishPosition & ")"

            Dim DB As Object = Me._CONNECTION.ExecuteScalar(CMDTEXT)
            If Not Information.IsDBNull(DB) AndAlso DB IsNot Nothing Then Return DB.ToString

            Return "999"
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