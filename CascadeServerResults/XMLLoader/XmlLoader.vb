Friend Class XmlLoader : Implements IDisposable
    Private disposedValue As Boolean ' To detect redundant calls

    Private ThisRaceInformation As Instance.MeetingInformation.RaceInformation

    Private This_MeetingXMLDT As Data.DataTable
    Private MY_XML As String = Nothing
    Private ReadOnly OADate As String
    Private ReadOnly Connection As CascadeCommon.Utils.Connection
    Private Sub New()
        Me.disposedValue = False
    End Sub
    Public Sub New(XML As String, OADate As String, Connection As CascadeCommon.Utils.Connection)
        Me.New
        MY_XML = XML
        Me.OADate = OADate
        Me.Connection = Connection

        Using MXMLDT As New DataTables.Meeting(OADate, Connection.String)
            Me.This_MeetingXMLDT = MXMLDT.Meeting_XML_ForDay
        End Using
    End Sub
    Public Function GetListOfMeetingInformation() As List(Of Instance.MeetingInformation)
        If InStr(MY_XML, "<MEETINGS DATE=") <= 0 Then Return Nothing

        Dim thisLOMI As New List(Of Instance.MeetingInformation)
        Dim FindString As String = "<MEETINGS DATE=""" & Format(Date.FromOADate(OADate), "yyyy-MM-dd") & """>"

        Dim StartIndex As Integer = MY_XML.IndexOf(FindString) + FindString.Length + 1

        MY_XML = Mid$(MY_XML, StartIndex)
        MY_XML = Replace(MY_XML, "</MEETINGS>", "")
        Dim Meetings() As String = Split(MY_XML, "</MEETING>")
        For Each Meeting As String In Meetings
            Dim NUMBER As String, TYPE As String
            Dim RACEINFO As List(Of Instance.MeetingInformation.RaceInformation)
            Dim MeetingXML As String = Meeting

            If Meeting.Contains("<MEETING NUMBER=") Then
                MeetingXML = Strings.Mid(MeetingXML, InStr(MeetingXML, "<MEETING NUMBER=") + Len("<MEETING NUMBER=") + 1)
                NUMBER = Strings.Left(MeetingXML, InStr(MeetingXML, """") - 1)

                Dim DR() As Data.DataRow = Me.This_MeetingXMLDT.Select("NUMBER=" & NUMBER)
                If DR.Length = 0 Then Continue For

                TYPE = DR(0).Item("TYPE").ToString
            Else
                Continue For
            End If

            If MeetingXML.Contains("<RACES>") Then
                MeetingXML = Strings.Mid(MeetingXML, InStr(MeetingXML, "<RACES>") + Len("<RACES>") + 1)
                MeetingXML = Replace(MeetingXML, "</RACES>", "")
            Else
                Continue For
            End If

            If MeetingXML.Contains("<RACE NUMBER") Then
                RACEINFO = GetListOfRacInformation(MeetingXML, NUMBER, TYPE)
            Else
                Continue For
            End If
            thisLOMI.Add(New Instance.MeetingInformation(NUMBER, TYPE, OADate, RACEINFO))
        Next

        Return thisLOMI
    End Function
    Private Function GetListOfRacInformation(ByRef RacesXML As String, ByVal Number As String, [Type] As String) As List(Of Instance.MeetingInformation.RaceInformation)
        Dim ThisLORI As New List(Of Instance.MeetingInformation.RaceInformation)
        '
        RacesXML = Trim(RacesXML)
        For Each RaceXML As String In Split(RacesXML, "</RACE>")
            If RaceXML.Length < 20 Then Continue For

            'EG: <race number="1" name="PUKEKOHE PARK 2200" class="RATING 85" stake="15000.00" 
            'distance="2200" winnerstime="2:17.91" winnerstrainer="Yves Seguin, Cambridge" 
            'winnersbreeding="5 m Black Minnaloushe (USA)-Grosvenor's Court" winnersowner="R D &amp; R N Atherton, Mrs B J &amp; D J Hurrell, P M Kay, C J &amp; F">

            Dim ThisRI = New Instance.MeetingInformation.RaceInformation

            Dim RaceInfo As String = Strings.Mid(RaceXML, InStr(RaceXML, "<") + 1)
            'RaceInfo = Replace(RaceInfo, "<", "")
            RaceInfo = Trim(RaceInfo)
            Do Until Strings.Left(RaceInfo, 1) = "R"
                RaceInfo = Strings.Mid(RaceInfo, 2)
            Loop
            RaceInfo = Strings.Left(RaceInfo, InStr(RaceInfo, ">") - 1)
            '
            For Each RaceAttribute As String In Split(RaceInfo, """ ")
                If ThisRI.Status.Contains("AB") Then Exit For

                RaceAttribute = Replace(RaceAttribute, """", "")
                Dim KeyValue() As String = Split(RaceAttribute, "=")
                Select Case KeyValue(0).ToUpperInvariant
                    Case "RACE NUMBER"
                        ThisRI.Number = KeyValue(1).ToString
                        Exit Select

                    Case "STAKE"
                        Dim STAKE As String = Replace(KeyValue(1), "-", "")
                        ThisRI.Stake = STAKE.ToString
                        Exit Select

                    Case "DISTANCE"
                        ThisRI.Distance = KeyValue(1).ToString
                        Exit Select

                    Case "STATUS"
                        ThisRI.Status = KeyValue(1).ToString

                    Case "WINNERSTIME"
                        Dim Seconds As Decimal = 0D
                        If KeyValue(1).Contains(CChar(":")) Then
                            Dim MinuteCount As Integer = Strings.Left(KeyValue(1), InStr(KeyValue(1), ":") - 1)
                            Dim SecondCount As Decimal = Strings.Mid(KeyValue(1), InStr(KeyValue(1), ":") + 1)
                            MinuteCount *= 60
                            Seconds = MinuteCount + SecondCount
                            ThisRI.WinnersTime = Seconds
                        Else
                            ThisRI.WinnersTime = If(KeyValue(1).Contains("N/A"), DMOWinnersTime(Type, ThisRI.Distance, Connection), KeyValue(1))
                        End If
                        Exit Select

                    Case "WINNERSTRAINER"
                        ThisRI.WinnersTrainer = CascadeCommon.ReplaceHTML(KeyValue(1)).ToString
                        Exit Select

                    Case "WINNERSBREEDING"
                        ThisRI.WinnersBreeding = CascadeCommon.ReplaceHTML(KeyValue(1)).ToString
                        Exit Select

                    Case "WINNERSOWNER"
                        ThisRI.WinnersOwner = CascadeCommon.ReplaceHTML(KeyValue(1)).ToString
                End Select
            Next RaceAttribute

            If Not ThisRI.Status.Contains("AB") Then
                RaceXML = Strings.Mid(RaceXML, InStr(RaceXML, ">") + 1)
                RaceXML = Trim(RaceXML).ToUpperInvariant

                Using Scratchings As New Scratchings(RaceXML, ThisRI.ListOf_EntryInformationScratchings)
                    Scratchings.Set()
                End Using

                Using Placings As New Placings(RaceXML, ThisRI.ListOf_EntryInformationPlacings)
                    Call Placings.Set()
                End Using

                Using AlsoRan As New AlsoRan(RaceXML, ThisRI.ListOf_EntryInformationAlsoRan)
                    AlsoRan.Set()
                End Using

                Using Pools As New Pools(RaceXML, ThisRI.ListOf_EntryInformationPools)
                    Call Pools.Set()
                End Using

                ThisLORI.Add(ThisRI)
            End If
        Next RaceXML

        Return ThisLORI
    End Function
    Private Shared Function DMOWinnersTime([Type] As String, Distance As String, Connection As CascadeCommon.Utils.Connection) As String
        Dim WinnersTime As Object

        Dim CommandText As String
        CommandText = "SELECT AVG(RESULTS_XML_RACE.WINNERSTIME) AS WINNERSTIME 
            FROM RESULTS_XML_RACE INNER JOIN RACE_XML ON RESULTS_XML_RACE.MEETING_XML_OADATE = RACE_XML.MEETING_XML_OADATE AND RESULTS_XML_RACE.MEETING_XML_NUMBER = RACE_XML.MEETING_XML_NUMBER AND RESULTS_XML_RACE.NUMBER = RACE_XML.NUMBER INNER JOIN MEETING_XML ON RACE_XML.MEETING_XML_OADATE = MEETING_XML.OADATE AND RACE_XML.MEETING_XML_NUMBER = MEETING_XML.NUMBER 
            WHERE (MEETING_XML.TYPE = N'" & Type & "') AND (dbo.RACE_XML.LENGTH = " & Distance & ")"

        WinnersTime = Connection.ExecuteScalar(CommandText)
        If Not Information.IsDBNull(WinnersTime) Then Return WinnersTime

        Return ""
    End Function
    Private ReadOnly Property GetNumberTable(OADate As String, MeetingNumber As String, RaceNumber As String, Connection As CascadeCommon.Utils.Connection) As Data.DataTable
        Get
            Dim CMDTEXT As String = "SELECT NUMBER FROM ENTRY_XML WHERE (MEETING_XML_OADATE=" & OADate & ") AND (MEETING_XML_NUMBER=" & MeetingNumber & ") AND (RACE_XML_NUMBER=" & RaceNumber & ")"
            Return Me.Connection.GetDataTable(CMDTEXT)
        End Get
    End Property
#Region "       IDisposable Support"
    ' IDisposable
    Private Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                If ThisRaceInformation IsNot Nothing Then ThisRaceInformation.Dispose() : ThisRaceInformation = Nothing
                MY_XML = Nothing
            End If
        End If
        disposedValue = True
    End Sub
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Friend Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class