Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Partial Class Base
                        Partial Class Extended
                            Partial Class Standard
                                Private NotInheritable Class Trends : Implements IDisposable
                                    Private RunnerRaceList As Data.DataTable
                                    Private Filter As String
                                    Private Theo As String = ""
                                    Friend Sub New(ByVal RunnerRaceList As Data.DataTable, ByVal Filter As String, ByVal IsTheo As Boolean)
                                        Me.RunnerRaceList = RunnerRaceList
                                        Me.Filter = Filter
                                        If IsTheo Then Me.Theo = "THEO_"
                                    End Sub
                                    Friend Function GetTrend() As String
                                        ' Order the RunnerRaceList in Ascending Order so that the oldest races are calculated first.
                                        Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Me.Filter, "MEETING_INFO_OADATE ASC")
                                        If DR.Length < 2 Then Return "-999"
                                        '
                                        Dim PreviousDistance As Single = CInt(DR(0).Item("RESULT_" & Me.Theo & "DISTANCE_BEHIND"))
                                        Dim RollingValue As Decimal = 0D
                                        '
                                        For Index As Integer = 1 To DR.Length - 1I
                                            Dim CurrentValue As Integer = CInt(DR(Index).Item("RESULT_" & Me.Theo & "DISTANCE_BEHIND"))
                                            Select Case CurrentValue
                                                Case Is = 0
                                                    RollingValue += 2
                                                Case Is < PreviousDistance
                                                    RollingValue += 1
                                                Case Else
                                                    RollingValue -= 1
                                            End Select
                                            '
                                            PreviousDistance = CurrentValue
                                        Next Index
                                        Return CStr(RollingValue)
                                    End Function
                                    Friend Shared ReadOnly Property TrendStatus(ByVal Filter As String, ByVal RunnerRaceList_DT As Data.DataTable, ByVal Theo As String) As String
                                        Get
                                            Dim DR() As Data.DataRow = RunnerRaceList_DT.Select(Filter, "MEETING_INFO_OADATE DESC")
                                            If DR.Length < 6 Then Return "0"
                                            '
                                            Dim Status As Int32 = 0
                                            '
                                            Dim Value As Short = CShort(DR(5).Item("RESULT_" & Theo & "FINISH_POSITION"))
                                            For X = 4 To 0 Step -1
                                                Select Case CShort(DR(X).Item("RESULT_" & Theo & "FINISH_POSITION"))
                                                    Case Is < Value
                                                        Status += 1 : Value = CShort(DR(X).Item("RESULT_" & Theo & "FINISH_POSITION"))
                                                        Exit Select
                                                    Case Is > Value
                                                        Status -= 1 : Value = CShort(DR(X).Item("RESULT_" & Theo & "FINISH_POSITION"))
                                                        Exit Select
                                                    Case Else
                                                        Value = CShort(DR(X).Item("RESULT_" & Theo & "FINISH_POSITION"))
                                                End Select
                                            Next X
                                            '
                                            Select Case Status
                                                Case Is > 0
                                                    TrendStatus = 1I
                                                Case Is < 0
                                                    TrendStatus = -1I
                                                Case Else
                                                    TrendStatus = 0I
                                            End Select
                                        End Get
                                    End Property

#Region "IDisposable Support"
                                    Private disposedValue As Boolean ' To detect redundant calls

                                    ' IDisposable
                                    Protected Sub Dispose(disposing As Boolean)
                                        If Not Me.disposedValue Then
                                            If disposing Then
                                                ' TODO: dispose managed state (managed objects).
                                            End If

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
            End Class
        End Class
    End Class
End Namespace