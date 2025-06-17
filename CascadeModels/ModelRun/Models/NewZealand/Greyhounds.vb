Namespace ModelRun.Models.NewZealand
    Friend Class Greyhounds
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Protected Friend Shared Function NewRunners(StatisticsL10DT As Data.DataTable) As Data.DataTable
            If StatisticsL10DT.Rows.Count = 0 OrElse StatisticsL10DT.Rows.Count < 8 Then Return New Data.DataTable
            If StatisticsL10DT.Select("").Length - StatisticsL10DT.Select("SCRATCHED=1").Length <= 7 Then Return New Data.DataTable

            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("LENGTH_RUNS IS NULL")
                If DR.Length = 1 Then 'OrElse DR.Length = 2 Then
                    Dim DT As Data.DataTable = StatisticsL10DT.Clone
                    Dim DR1() As Data.DataRow = StatisticsL10DT.Select("", "BARRIER_RANK DESC")

                    For X = 0 To DR.Length - 1
                        If DR(X).Item("SCRATCHED") = 0 Then
                            DR(X).Item("MODEL_EXPLORER_ID") = 4
                            DR(X).Item("TRACK_TYPE") = DR1(0).Item("TRACK_TYPE")
                            DT.ImportRow(DR(X))
                        End If
                    Next X
                    If DT.Rows.Count > 0 Then Return DT
                End If
            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
        Protected Friend Shared Function StatisticsLXGreaterThan84(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Dim RunnersAL As New ArrayList
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("LENGTH_RANK >= 84", "LENGTH_RANK DESC")
                If DR.Length > 0 Then
                    For X As Integer = 0 To DR.Length - 1
                        If DR(X).Item("LENGTH_RUNS") >= 2 AndAlso DR(X).Item("SCRATCHED") = 0 AndAlso DR(X).Item("LASTRAN_FINISHPOSITION") <= 4 Then
                            DR(X).Item("MODEL_EXPLORER_ID") = 5
                            RunnersAL.Add(DR(X).Item("NUMBER"))
                        End If
                    Next X
                End If

                DR = StatisticsL3DT.Select("LENGTH_RANK >= 84", "LENGTH_RANK DESC")
                If DR.Length > 0 Then
                    For X As Integer = 0 To DR.Length - 1
                        If DR(X).Item("SCRATCHED") = 0 AndAlso DR(X).Item("LENGTH_RUNS") >= 2 AndAlso DR(X).Item("LASTRAN_FINISHPOSITION") <= 4 Then
                            If Not RunnersAL.Contains(DR(X).Item("NUMBER")) Then
                                DR(X).Item("MODEL_EXPLORER_ID") = 5
                                RunnersAL.Add(DR(X).Item("NUMBER"))
                            End If
                        End If
                    Next X
                End If

                If RunnersAL.Count > 0 Then
                    For Each Runner As String In RunnersAL
                        DR = StatisticsL3DT.Select("NUMBER=" & Runner.ToString)
                        DT.ImportRow(DR(0))
                    Next Runner
                    Return DT
                End If

            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
        Protected Friend Shared Function TopDistanceBehind(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim Y As Integer = 0
                Dim DR() As Data.DataRow = StatisticsL3DT.Select("", "LENGTH_DISTANCEBEHIND ASC")
                If Information.IsDBNull(DR(0).Item("LENGTH_RUNS")) Then Y = 1
                If DR(Y).Item("SCRATCHED") = 1 Then Y += 1
                For X As Integer = Y To 1
                    If DR(Y).Item("SCRATCHED") = 0 Then
                        If DR(X).Item("FINISHPOSITION") <= 4 Then
                            DR(X).Item("MODEL_EXPLORER_ID") = 6
                            DT.ImportRow(DR(X))
                        End If
                    End If
                Next
                If DT.Rows.Count > 0 Then
                    Return DT
                End If
            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
        Protected Friend Shared Function RankMoreThan20(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim RunnersAL As New ArrayList
            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("(SCRATCHED=0) AND (LENGTH_RANK <> 100) AND (LENGTH_RUNS >1)", "LENGTH_RANK DESC")
                If DR(0).Item("LENGTH_RANK") - DR(1).Item("LENGTH_RANK") < 20 Then Return New Data.DataTable
                DR(0).Item("MODEL_EXPLORER_ID") = 10
                RunnersAL.Add(DR(0).Item("NUMBER").ToString)

                If RunnersAL.Count > 0 Then
                    For Each Number As String In RunnersAL
                        DT.ImportRow(StatisticsL3DT.Select("NUMBER=" & Number)(0))
                    Next Number
                End If

                If DT.Rows.Count > 0 Then
                    Return DT
                End If
            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
        Protected Friend Shared Function Only1Two(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim RunnersAL As New ArrayList
            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("FINISHPOSITION=1")
                If DR.Length > 0 Then Return New Data.DataTable

                DR = StatisticsL10DT.Select("FINISHPOSITION=2")
                If DR.Length = 0 OrElse DR.Length > 1 Then Return New Data.DataTable
                If DR(0).Item("LENGTH_RANK") > 60 AndAlso DR(0).Item("LENGTH_RANK") <> 100 Then
                    DR(0).Item("MODEL_EXPLORER_ID") = 10
                    RunnersAL.Add(DR(0).Item("NUMBER").ToString)
                End If

                If RunnersAL.Count > 0 Then
                    For Each Number As String In RunnersAL
                        DT.ImportRow(StatisticsL3DT.Select("NUMBER=" & Number)(0))
                    Next Number
                End If

                If DT.Rows.Count > 0 Then
                    Return DT
                End If
            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
        Protected Friend Shared Function BestSequence(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If StatisticsL10DT.Select("").Length - StatisticsL10DT.Select("SCRATCHED=1").Length <= 7 Then Return New Data.DataTable

            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Dim RunnersAL As New ArrayList
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("", "SEQUENCE_RANK DESC")
                If DR(0).Item("FINISHPOSITION") > 4 Then Return New Data.DataTable
                RunnersAL.Add(DR(0).Item("NUMBER"))

                If RunnersAL.Count > 0 Then
                    For Each Runner As String In RunnersAL
                        If Runner = 0 Then Continue For
                        DR = StatisticsL3DT.Select("NUMBER=" & Runner.ToString)
                        DT.ImportRow(DR(0))
                    Next Runner
                    Return DT
                End If

            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function

    End Class
End Namespace