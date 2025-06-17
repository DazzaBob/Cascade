Namespace Processing
    Partial Class Results
        Private NotInheritable Class XmlLoader : Implements IDisposable
            Private ThisRaceInformation As Instance.MeetingInformation.RaceInformation
            '
            Private MY_XML As String = Nothing
            Private MY_OADATE As Int32 = 0
            Friend Sub New(ByVal XML As String, ByVal OADate As Int32)
                MY_XML = XML
                MY_OADATE = OADate
            End Sub
            Friend Function GetListOfMeetingInformation() As List(Of Instance.MeetingInformation)
                If InStr(MY_XML, "<meetings date=") <= 0 Then Return Nothing
                '
                Dim thisLOMI As List(Of Instance.MeetingInformation) = New List(Of Instance.MeetingInformation)
                '
                MY_XML = Mid$(MY_XML, InStr(MY_XML, "<meetings date=""" & Format(Date.FromOADate(MY_OADATE), "yyyy-MM-dd") & """>") + 1)
                MY_XML = Replace(MY_XML, "</meetings>", "")
                Dim Meetings() As String = Split(MY_XML, "</meeting>")
                For Each Meeting As String In Meetings
                    Dim NUMBER As String, OADATE As String, TYPE As String
                    Dim RACEINFO As List(Of Instance.MeetingInformation.RaceInformation)
                    ' EG: <meeting number="9">
                    Dim MeetingXML As String = Meeting
                    '
                    If Meeting.Contains("<meeting number=") Then
                        MeetingXML = Strings.Mid(MeetingXML, InStr(MeetingXML, "<meeting number=") + Len("<meeting number=") + 1)
                        NUMBER = Strings.Left(MeetingXML, InStr(MeetingXML, """") - 1)
                        OADATE = MY_OADATE
                        If Not Cascade.StoredProcedures.MEETING_INFO.MeetingExists(NUMBER, OADATE, ServerUI.FrmServer.Connection) Then Continue For
                        '
                        TYPE = Trim(Cascade.StoredProcedures.MEETING_INFO.GetMeetingType(NUMBER, OADATE, ServerUI.FrmServer.Connection))
                        Select Case TYPE
                            Case "GR"
                                If Not My.Settings.LoadGreyhounds Then Continue For
                            Case "H"
                                If Not My.Settings.LoadHarness Then Continue For
                            Case "G"
                                If Not My.Settings.LoadGallops Then Continue For
                            Case Else
                                Continue For
                        End Select
                    Else
                        Continue For
                    End If
                    '
                    If MeetingXML.Contains("<races>") Then
                        MeetingXML = Strings.Mid(MeetingXML, InStr(MeetingXML, "<races>") + Len("<races>") + 1)
                        MeetingXML = Replace(MeetingXML, "</races>", "")
                    Else
                        Continue For
                    End If
                    If MeetingXML.Contains("<race number") Then
                        RACEINFO = GetListOfRacInformation(MeetingXML, NUMBER)
                    Else
                        Continue For
                    End If
                    thisLOMI.Add(New Instance.MeetingInformation(NUMBER, TYPE, OADATE, RACEINFO))
                Next
                '
                Return thisLOMI
            End Function
            Private Function GetListOfRacInformation(ByRef RacesXML As String, ByVal Number As String) As List(Of Instance.MeetingInformation.RaceInformation)
                Dim ThisLORI As List(Of Instance.MeetingInformation.RaceInformation) = New List(Of Instance.MeetingInformation.RaceInformation)
                '
                RacesXML = Trim(RacesXML)
                For Each RaceXML As String In Split(RacesXML, "</race>")
                    If RaceXML.Length < 20 Then Continue For
                    Dim ThisRI As Instance.MeetingInformation.RaceInformation = New Instance.MeetingInformation.RaceInformation
                    'EG: <race number="1" name="PUKEKOHE PARK 2200" class="RATING 85" stake="15000.00" 
                    'distance="2200" winnerstime="2:17.91" winnerstrainer="Yves Seguin, Cambridge" 
                    'winnersbreeding="5 m Black Minnaloushe (USA)-Grosvenor's Court" winnersowner="R D &amp; R N Atherton, Mrs B J &amp; D J Hurrell, P M Kay, C J &amp; F">
                    Dim RaceInfo As String = Strings.Mid(RaceXML, InStr(RaceXML, "<") + 1)
                    'RaceInfo = Replace(RaceInfo, "<", "")
                    RaceInfo = Trim(RaceInfo)
                    Do Until Strings.Left(RaceInfo, 1) = "r"
                        RaceInfo = Strings.Mid(RaceInfo, 2)
                    Loop
                    RaceInfo = Strings.Left(RaceInfo, InStr(RaceInfo, ">") - 1)
                    '
                    For Each RaceAttribute As String In Split(RaceInfo, """ ")
                        RaceAttribute = Replace(RaceAttribute, """", "")
                        Dim KeyValue() As String = Split(RaceAttribute, "=")
                        Select Case KeyValue(0).ToUpperInvariant
                            Case "RACE NUMBER"
                                ThisRI.NUMBER = CShort(KeyValue(1))
                                Exit Select
                            Case "STAKE"
                                Dim STAKE As String = Replace(KeyValue(1), "-", "")
                                ThisRI.STAKE = CDec(STAKE)
                                Exit Select
                            Case "DISTANCE"
                                ThisRI.RACEDISTANCE = CInt(KeyValue(1))
                                Exit Select
                            Case "WINNERSTIME"
                                Dim Seconds As Decimal = 0D
                                If KeyValue(1).Contains(":") Then
                                    Dim MinuteCount As Int32 = CInt(Strings.Left(KeyValue(1), InStr(KeyValue(1), ":") - 1))
                                    Dim SecondCount As Decimal = CDec(Strings.Mid(KeyValue(1), InStr(KeyValue(1), ":") + 1))
                                    MinuteCount *= 60
                                    Seconds = MinuteCount + SecondCount
                                    ThisRI.WINNERSTIME = Seconds
                                Else
                                    If KeyValue(1).Contains("n/a") Then
                                        ThisRI.WINNERSTIME = 0
                                    Else
                                        ThisRI.WINNERSTIME = CDec(KeyValue(1))
                                    End If
                                End If
                                Exit Select
                            Case "STATUS"
                                ThisRI.STATUS = KeyValue(1).ToUpperInvariant
                        End Select
                    Next RaceAttribute
                    RaceXML = Strings.Mid(RaceXML, InStr(RaceXML, ">") + 1)
                    RaceXML = Trim(RaceXML).ToUpperInvariant
                    '
                    ThisRI.ListOfEntryInformation = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                    For Each ROW As Data.DataRow In GetNumberTable(MY_OADATE, Number, ThisRI.NUMBER).Select("")
                        ThisRI.ListOfEntryInformation.Add(New Instance.MeetingInformation.RaceInformation.EntryInformation(CStr(ROW.Item("NUMBER"))))
                    Next ROW
                    '
                    Using Placings As New Placings(RaceXML, ThisRI.ListOfEntryInformation)
                        Call Placings.Set()
                    End Using
                    Using Scratchings As New Scratchings(RaceXML, ThisRI.ListOfEntryInformation)
                        Scratchings.Set()
                    End Using
                    Using AlsoRan As New AlsoRan(RacesXML, ThisRI.ListOfEntryInformation)
                        AlsoRan.Set()
                    End Using
                    Using Results As New Results(RaceXML, ThisRI.ListOfEntryInformation)
                        Results.Set()
                    End Using
                    Using Results As New Results(RaceXML, ThisRI.ListOfEntryInformation)
                        Call Results.Set()
                    End Using
                    Using Pools As New Pools(RaceXML, ThisRI.ListOfEntryInformationPools)
                        Call Pools.Set()
                    End Using
                    '
                    ThisLORI.Add(ThisRI)
                Next RaceXML
                '
                Return ThisLORI
            End Function
            Private Shared ReadOnly Property GetNumberTable(ByVal OADate As String, ByVal MeetingNumber As String, ByVal RaceNumber As String) As Data.DataTable
                Get
                    Dim CMDTEXT As String = "SELECT NUMBER FROM ENTRY_INFO WHERE (MEETING_INFO_OADATE=" & OADate & ") AND (MEETING_INFO_NUMBER=" & MeetingNumber & ") AND (RACE_INFO_NUMBER=" & RaceNumber & ")"
                    Return ServerUI.FrmServer.Connection.GetDataTable(CMDTEXT)
                End Get
            End Property
#Region "       IDisposable Support"
            Private disposedValue As Boolean ' To detect redundant calls

            ' IDisposable
            Friend Sub Dispose(disposing As Boolean)
                If Not Me.disposedValue Then
                    If disposing Then
                        If ThisRaceInformation IsNot Nothing Then ThisRaceInformation.Dispose() : ThisRaceInformation = Nothing
                        MY_OADATE = Nothing
                        MY_XML = Nothing
                    End If
                End If
                Me.disposedValue = True
            End Sub
            ' This code added by Visual Basic to correctly implement the disposable pattern.
            Friend Sub Dispose() Implements IDisposable.Dispose
                ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
                Dispose(True)
                GC.SuppressFinalize(Me)
            End Sub
#End Region
        End Class
    End Class
End Namespace