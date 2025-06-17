' The Class gets called for every day it needs to run or just once for ALL days
Namespace ModelDevelopment
    Friend NotInheritable Class RerunModels : Implements IDisposable
        Private MY_OADATE As String
        Private MY_CONNECTION As Connection
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Sub New(ByVal OADate As String, ByVal Connection As Connection)
            MY_OADATE = OADate
            MY_CONNECTION = Connection
        End Sub
        Friend Sub NOW()
            Dim OADate As String = MY_OADATE
            If OADate Is Nothing OrElse OADate = "0" Then
                Call ServerUI.Messages.LogMessages("Resetting all Models to NULL.", Cascade.BroadcastTypes.Log)
                Call ResetModels(Nothing)
                '
                Call ServerUI.Messages.LogMessages("Selecting races for model evaluation.", Cascade.BroadcastTypes.Log)
                Call NOW(Nothing, Nothing)
            Else
                Call ServerUI.Messages.LogMessages("Resetting Models for: " & FormatDateTime(Date.FromOADate(CDbl(OADate)), DateFormat.LongDate) & " to NULL.", Cascade.BroadcastTypes.Log)
                Call ResetModels(OADate)
                '
                Call ServerUI.Messages.LogMessages("Selecting races for: " & FormatDateTime(Date.FromOADate(CDbl(OADate)), DateFormat.LongDate) & " for model evaluation.", Cascade.BroadcastTypes.Log)
                Call NOW(OADate, OADate)
            End If
            Call ServerUI.Messages.LogMessages("Rerun model thread finished.", Cascade.BroadcastTypes.Log)
        End Sub
        Private Sub ResetModels(ByVal MEETING_INFO_OADATE As String)
            Dim CMDTEXT As String = Nothing
            If MEETING_INFO_OADATE Is Nothing OrElse MEETING_INFO_OADATE = "0" Then
                CMDTEXT = "TRUNCATE TABLE RACE_MODEL_INFO"
                Call MY_CONNECTION.Execute(CMDTEXT)
                '
                CMDTEXT = "UPDATE RACE_INFO SET HASMODEL=NULL"
                Call MY_CONNECTION.Execute(CMDTEXT)
            Else
                CMDTEXT = "DELETE FROM RACE_MODEL_INFO WHERE (MEETING_INFO_OADATE=" & CStr(MEETING_INFO_OADATE) & ")"
                Call MY_CONNECTION.Execute(CMDTEXT)
                '
                CMDTEXT = "UPDATE RACE_INFO SET HASMODEL=NULL WHERE (MEETING_INFO_OADATE=" & CStr(MEETING_INFO_OADATE) & ")"
                Call MY_CONNECTION.Execute(CMDTEXT)
            End If
        End Sub
        Private Sub NOW(STARTDATE As String, FINISHDATE As String)
            Call ServerUI.Messages.LogMessages("Collecting Records ...", Cascade.BroadcastTypes.Log)
            '
            If STARTDATE Is Nothing And FINISHDATE Is Nothing Then
                For X As Int32 = CInt(Today.ToOADate - (366 * 2)) To CInt(Today.ToOADate) Step 122
                    Using ModelRun As Cascade.ModelDevelopment.ModelRun = New Cascade.ModelDevelopment.ModelRun(CStr(X), CStr(X + 122), Nothing, MY_CONNECTION, Nothing, Nothing)
                        If ModelRun.HasErrors Then Exit For
                        Call ModelRun.GetResults_DT()
                    End Using
                    X += 1
                Next X
            Else
                Using ModelRun As Cascade.ModelDevelopment.ModelRun = New Cascade.ModelDevelopment.ModelRun(STARTDATE, FINISHDATE, Nothing, MY_CONNECTION, Nothing, Nothing)
                    If Not ModelRun.HasErrors Then
                        Call ModelRun.GetResults_DT()
                    End If
                End Using
            End If
        End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Private Sub Dispose(disposing As Boolean)
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
End Namespace