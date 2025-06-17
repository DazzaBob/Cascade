Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Private NotInheritable Class GreyhoundsDTR : Implements IDisposable
                        Private Const DEFAULT_SPEED As Decimal = 16.73D ' This is a default guess for a greyhound MPS
                        Private Const DEFAULT_DISTANCEBEHIND As Decimal = 6.68D ' This is a default guess for greyhounds DB
                        Private BARRIER_DT As Data.DataTable
                        '
                        Private MeetingInformation As Instance.MeetingInformation
                        Private RaceInformation As Instance.MeetingInformation.RaceInformation
                        Private EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation
                        Private Connection As Connection
                        Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation, ByVal Connection As Connection)
                            Me.MeetingInformation = MeetingInformation
                            Me.RaceInformation = RaceInformation
                            Me.EntryInformation = EntryInformation
                            Me.Connection = Connection
                            '
                            Dim CMDTEXT As String = "SELECT * FROM RACE_INFO_BARRIER "
                            CMDTEXT += "WHERE (MEETING_INFO_OADATE=" & Me.MeetingInformation.OADATE & ") AND "
                            CMDTEXT += "(MEETING_INFO_NUMBER=" & Me.MeetingInformation.NUMBER & ") AND "
                            CMDTEXT += "(RACE_INFO_NUMBER=" & Me.RaceInformation.NUMBER & ")"
                            Me.BARRIER_DT = Me.Connection.GetDataTable(CMDTEXT)
                        End Sub
                        ''' <summary>
                        ''' Calculated using the RANK Value.
                        ''' </summary>
                        ''' <returns></returns>
                        ''' <remarks></remarks>
                        Friend Function GetGreyhoundsPenalty() As Single
                            Dim ThisRANK As Int16 = 1 ' Even the best barrier has a disadvantage.
                            Dim ThisPercentage As Single = 0
                            Dim MaxDistanceBehind As Single = Me.BARRIER_DT.Compute("MAX(ALL_DISTANCE_BEHIND_MAX)", "")
                            For Each ROW As Data.DataRow In Me.BARRIER_DT.Select("", "[90_RANK] DESC")
                                If Me.EntryInformation.BARRIER = CStr(ROW.Item("BARRIER")) Then Exit For
                                ThisRANK += 1
                            Next ROW
                            ThisPercentage = (ThisRANK / (RaceInformation.ListOfEntryInformation.Count))
                            Dim THIS_PENALTY As Single = MaxDistanceBehind - (ThisPercentage * MaxDistanceBehind)
                            '
                            Return THIS_PENALTY
                        End Function
#Region "                       IDisposable Support"
                        Private disposedValue As Boolean ' To detect redundant calls

                        ' IDisposable
                        Protected Sub Dispose(disposing As Boolean)
                            If Not Me.disposedValue Then
                                If disposing Then
                                    ' TODO: dispose managed state (managed objects).
                                End If
                                If Me.BARRIER_DT IsNot Nothing Then Me.BARRIER_DT.Dispose() : Me.BARRIER_DT = Nothing
                                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                                ' TODO: set large fields to null.
                            End If
                            Me.disposedValue = True
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
            End Class
        End Class
    End Class
End Namespace