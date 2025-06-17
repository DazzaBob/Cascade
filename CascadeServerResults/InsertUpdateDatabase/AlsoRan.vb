Partial Class InsertUpdateDatabase
    Friend Class AlsoRan : Implements IDisposable
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
        Friend Sub Insert()
            For Each AlsoRan As Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan In Me._RACEINFORMATION.ListOf_EntryInformationAlsoRan
                If AlsoRan.FinishPosition = "0" Then
                    Call CascadeCommon.SQL.ENTRY_XML.ScratchTheRunner(Me._MEETINGINFORMATION.OADate, Me._MEETINGINFORMATION.Number, Me._RACEINFORMATION.Number, AlsoRan.Number, _CONNECTION)
                    Continue For
                End If

                If Me._MEETINGINFORMATION.Type = "GR" AndAlso (AlsoRan.Number = "9" OrElse AlsoRan.Number = "10") AndAlso AlsoRan.FinishPosition = "0" Then
                    Call CascadeCommon.SQL.ENTRY_XML.ScratchTheRunner(Me._MEETINGINFORMATION.OADate, Me._MEETINGINFORMATION.Number, Me._RACEINFORMATION.Number, AlsoRan.Number, _CONNECTION)
                    Continue For
                End If

                Dim Exception As String = String.Empty
                Dim CMDTEXT As String
                CMDTEXT = "INSERT INTO RESULTS_XML_ALSORAN ([MEETING_XML_OADATE], [MEETING_XML_NUMBER], [RACE_XML_NUMBER], [NUMBER], [FINISH_POSITION], [DISTANCE_BEHIND]) "
                CMDTEXT += "VALUES (" & Me._MEETINGINFORMATION.OADate & ", " & Me._MEETINGINFORMATION.Number & ", " & Me._RACEINFORMATION.Number & ", " & AlsoRan.Number & ", "
                CMDTEXT += AlsoRan.FinishPosition & ", "
                AlsoRan.Distance = Distance(AlsoRan.Distance, AlsoRan.FinishPosition, Exception)
                CMDTEXT += AlsoRan.Distance & ") " & Environment.NewLine
                If Exception.ToUpper = "PULL" Then
                    Call CascadeCommon.SQL.ENTRY_XML.ScratchTheRunner(Me._MEETINGINFORMATION.OADate, Me._MEETINGINFORMATION.Number, Me._RACEINFORMATION.Number, AlsoRan.Number, _CONNECTION)
                    Continue For
                Else
                    Me._CONNECTION.Execute(CMDTEXT)
                End If

                CMDTEXT = "INSERT INTO RESULTS_EXTENDED ([MEETING_XML_OADATE], [MEETING_XML_NUMBER], [RACE_XML_NUMBER], [NUMBER], [FINISH_POSITION], [DISTANCE_BEHIND], [EXCEPTION]) "
                CMDTEXT += "VALUES (" & Me._MEETINGINFORMATION.OADate & ", " & Me._MEETINGINFORMATION.Number & ", " & Me._RACEINFORMATION.Number & ", " & AlsoRan.Number & ", "
                CMDTEXT += AlsoRan.FinishPosition & ", " & AlsoRan.Distance
                If Exception = String.Empty Then
                    CMDTEXT += ", NULL"
                Else
                    CMDTEXT += ", N'" & Exception & "'"
                End If
                CMDTEXT += ")"
                If Exception.ToUpper = "PULL" Then
                    Call CascadeCommon.SQL.ENTRY_XML.ScratchTheRunner(Me._MEETINGINFORMATION.OADate, Me._MEETINGINFORMATION.Number, Me._RACEINFORMATION.Number, AlsoRan.Number, _CONNECTION)
                    Continue For
                Else
                    Me._CONNECTION.Execute(CMDTEXT)
                End If

            Next AlsoRan
        End Sub

        Private Function Distance(CurrentDistance As String, FinishPosition As String, ByRef Exception As String) As String
            If Information.IsNumeric(CurrentDistance) Then Return CurrentDistance

            If CurrentDistance.ToUpper = "N/A" Then
                Exception = String.Empty
                Return AVGDistanceBehind(FinishPosition)
            End If

            If CurrentDistance.Contains("|"c) Then
                Dim sSplit() As String = Strings.Split(CurrentDistance, "|")
                Return (CDbl(sSplit(0)) + CDbl(sSplit(1))) / 2
            End If


            Exception = CurrentDistance
            Return "999"
        End Function
        Private Function AVGDistanceBehind(FinishPosition As String) As String
            Dim CMDTEXT As String
            CMDTEXT = "SELECT AVG(RESULTS_XML_ALSORAN.DISTANCE_BEHIND) AS DISTANCE_BEHIND 
                FROM RACE_XML INNER JOIN MEETING_XML ON RACE_XML.MEETING_XML_OADATE = MEETING_XML.OADATE AND RACE_XML.MEETING_XML_NUMBER = MEETING_XML.NUMBER INNER JOIN RESULTS_XML_ALSORAN ON RACE_XML.MEETING_XML_OADATE = RESULTS_XML_ALSORAN.MEETING_XML_OADATE AND RACE_XML.MEETING_XML_NUMBER = RESULTS_XML_ALSORAN.MEETING_XML_NUMBER AND RACE_XML.NUMBER = RESULTS_XML_ALSORAN.RACE_XML_NUMBER 
                WHERE (MEETING_XML.TYPE = N'" & Me._MEETINGINFORMATION.Type & "') AND (RACE_XML.LENGTH = " & Me._RACEINFORMATION.Distance & ") AND (RESULTS_XML_ALSORAN.FINISH_POSITION = " & FinishPosition & ")"

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