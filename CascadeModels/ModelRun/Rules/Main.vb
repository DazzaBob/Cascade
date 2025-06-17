Namespace ModelRun.Rules
    Friend Module Main
        Friend Function IsEnoughRunners(StatisticsL10DT As Data.DataTable) As Boolean
            If StatisticsL10DT.Rows.Count = 0 Then Return False
            If StatisticsL10DT.Rows.Count < 8 Then Return False

            If StatisticsL10DT.Select("LENGTH_RUNS IS NULL").Length > 1 Then Return False
            If StatisticsL10DT.Select("LENGTH_RUNS < 3").Length > 0 Then Return False

            If StatisticsL10DT.Select("").Length - StatisticsL10DT.Select("SCRATCHED=1").Length <= 7 Then Return False
            Return True
        End Function
    End Module
End Namespace