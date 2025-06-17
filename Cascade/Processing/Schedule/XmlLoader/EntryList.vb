Namespace Processing
    Partial Class Schedule
        Partial Class XmlLoader
            Partial Class RaceList
                Private NotInheritable Class EntryList
                    Private MY_XML As String = Nothing
                    Friend Sub New(ByVal Xml As String)
                        MY_XML = Xml
                    End Sub
                    Friend Function GetListOfEntryInformation() As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                        '<!ELEMENT entry (barrier?, jockey?, jockey_allowance?, jockey_weight?, name, number, scratched)>
                        Dim This_EntryList = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                        '
                        MY_XML = Strings.Mid(MY_XML, InStr(MY_XML, "<ENTRIES>"))
                        MY_XML = Replace(MY_XML, "<ENTRIES>", "")
                        MY_XML = Replace(MY_XML, "</ENTRIES>", "")
                        MY_XML = Trim(MY_XML)
                        '
                        For Each sEntry As String In Split(MY_XML, "</ENTRY>")
                            Dim Barrier As String = Nothing
                            Dim Jockey As String = Nothing, JockeyAllowance As String = Nothing, JockeyWeight As String = Nothing
                            Dim Name As String = Nothing, Number As String = "0", Scratched As String = "1"
                            '
                            sEntry = Replace(sEntry, "<ENTRY>", "")
                            sEntry = Replace(sEntry, "</ENTRY>", "")
                            If Not sEntry.Contains("<NUMBER>") Then Continue For
                            '
                            Call SetBarrier(Barrier, sEntry)
                            Call SetJockey(Jockey, sEntry) : SetJockeyAllowance(JockeyAllowance, sEntry) : SetJockeyWeight(JockeyWeight, sEntry)
                            Call SetName(Name, sEntry) : SetNumber(Number, sEntry)
                            Call SetScratched(Scratched, sEntry)
                            If Scratched <> "0" OrElse Number = "0" Then Continue For
                            '
                            This_EntryList.Add(New Instance.MeetingInformation.RaceInformation.EntryInformation(Barrier, Jockey, JockeyAllowance, JockeyWeight, Name, Number, Scratched))
                        Next
                        '
                        Return This_EntryList
                    End Function
                    Private Shared Sub SetBarrier(ByRef Barrier As String, ByVal Xml As String)
                        If Xml.Contains("<BARRIER>") Then
                            Dim ThisBarrier As String
                            Xml = Strings.Mid(Xml, InStr(Xml, "<BARRIER>") + Len("<BARRIER>"))
                            ThisBarrier = Strings.Left(Xml, InStr(Xml, "<") - 1)
                            If IsNumeric(ThisBarrier) Then
                                Barrier = ThisBarrier
                                If Barrier Is Nothing Then Barrier = "0" Else Barrier = ThisBarrier
                            Else
                                ' The Barrier is set to the NUMBER, which is further down the method
                                If ThisBarrier.ToUpperInvariant = "FR" Then
                                    Barrier = "1"
                                Else
                                    If ThisBarrier.Contains("M") Then
                                        Barrier = Replace(ThisBarrier, "M", "")
                                    ElseIf ThisBarrier.Contains("U") Then
                                        Barrier = Replace(ThisBarrier, "U", "")
                                    End If
                                End If
                            End If
                        End If
                        If Barrier Is Nothing Then Call SetNumber(Barrier, Xml)
                    End Sub
                    Private Shared Sub SetName(ByRef Name As String, ByVal Xml As String)
                        If Xml.Contains("<NAME>") Then
                            Xml = Strings.Mid(Xml, InStr(Xml, "<NAME>") + Len("<NAME>"))
                            Name = Replace(Strings.Left(Xml, InStr(Xml, "<") - 1), "'", "")
                            Name = Replace(Name, "'", "")
                        End If
                    End Sub
                    Private Shared Sub SetNumber(ByRef Number As String, ByVal Xml As String)
                        If Xml.Contains("<NUMBER>") Then
                            Xml = Strings.Mid(Xml, InStr(Xml, "<NUMBER>") + Len("<NUMBER>"))
                            Number = Strings.Left(Xml, InStr(Xml, "<") - 1)
                        End If
                    End Sub
                    Private Shared Sub SetScratched(ByRef Scratched As String, ByVal Xml As String)
                        If Xml.Contains("<SCRATCHED>") Then
                            Xml = Strings.Mid(Xml, InStr(Xml, "<SCRATCHED>") + Len("<SCRATCHED>"))
                            Scratched = Strings.Left(Xml, InStr(Xml, "<") - 1)
                        End If
                    End Sub
#Region "               JOCKEY "
                    Private Shared Sub SetJockey(ByRef Jockey As String, ByVal Xml As String)
                        If Xml.Contains("<JOCKEY>") Then
                            Xml = Strings.Mid(Xml, InStr(Xml, "<JOCKEY>") + Len("<JOCKEY>"))
                            Jockey = Replace(Strings.Left(Xml, InStr(Xml, "<") - 1), "'", "")
                        End If
                    End Sub
                    Private Shared Sub SetJockeyAllowance(ByRef JockeyAllowance As String, ByVal Xml As String)
                        If Xml.Contains("<JOCKEY_ALLOWANCE>") Then
                            Xml = Strings.Mid(Xml, InStr(Xml, "<JOCKEY_ALLOWANCE>") + Len("<JOCKEY_ALLOWANCE>"))
                            JockeyAllowance = Replace(Strings.Left(Xml, InStr(Xml, "<") - 1), "(", "")
                            JockeyAllowance = Replace(JockeyAllowance, ")", "")
                        End If
                    End Sub
                    Private Shared Sub SetJockeyWeight(ByRef JockeyWeight As String, ByVal Xml As String)
                        If Xml.Contains("<JOCKEY_WEIGHT>") Then
                            Xml = Strings.Mid(Xml, InStr(Xml, "<JOCKEY_WEIGHT>") + Len("<JOCKEY_WEIGHT>"))
                            JockeyWeight = CDec(Replace(Strings.Left(Xml, InStr(Xml, "<") - 1), "U", ""))
                        End If
                    End Sub
#End Region
                End Class
            End Class
        End Class
    End Class
End Namespace