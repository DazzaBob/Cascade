' The Class gets called for every day it needs to run or just once for ALL days
Namespace ModelDevelopment
    Friend NotInheritable Class RerunModels : Implements IDisposable
        Private ReadOnly _OADate As String
        Private ReadOnly _Connection As Utils.Connection
        Private ReadOnly _Messages As Messages
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Sub New(OADate As String, Messages As Messages)
            Me._OADate = OADate
            Me._Messages = Messages
            Me._Connection = New Utils.Connection
        End Sub
        Friend Sub Start()
            If Me._OADate Is Nothing OrElse Me._OADate = "0" Then
                Call Me._Messages.LogMessages("Resetting all Models to NULL.", Utils.BroadcastTypes.Log)
                Call ResetModels(Nothing)
                '
                Call Me._Messages.LogMessages("Selecting races for model evaluation.", Utils.BroadcastTypes.Log)
                Call NOW(Nothing, Nothing)
            Else
                Call Me._Messages.LogMessages("Resetting Models for: " & FormatDateTime(Date.FromOADate(CDbl(Me._OADate)), DateFormat.LongDate) & " to NULL.", Utils.BroadcastTypes.Log)
                Call ResetModels(Me._OADate)
                '
                Call Me._Messages.LogMessages("Selecting races for: " & FormatDateTime(Date.FromOADate(CDbl(Me._OADate)), DateFormat.LongDate) & " for model evaluation.", Utils.BroadcastTypes.Log)
                Call NOW(Me._OADate, Me._OADate)
            End If
            Call Me._Messages.LogMessages("Rerun model thread finished.", Utils.BroadcastTypes.Log)
        End Sub
        Private Sub ResetModels(ByVal MEETING_INFO_OADATE As String)
            Dim CMDTEXT As String = Nothing
            If MEETING_INFO_OADATE Is Nothing OrElse MEETING_INFO_OADATE = "0" Then
                CMDTEXT = "TRUNCATE TABLE RACE_MODEL_INFO"
                Call Me._Connection.Execute(CMDTEXT)
                '
                CMDTEXT = "UPDATE RACE_INFO SET HASMODEL=NULL"
                Call Me._Connection.Execute(CMDTEXT)
            Else
                CMDTEXT = "DELETE FROM RACE_MODEL_INFO WHERE (MEETING_INFO_OADATE=" & CStr(MEETING_INFO_OADATE) & ")"
                Call Me._Connection.Execute(CMDTEXT)
                '
                CMDTEXT = "UPDATE RACE_INFO SET HASMODEL=NULL WHERE (MEETING_INFO_OADATE=" & CStr(MEETING_INFO_OADATE) & ")"
                Call Me._Connection.Execute(CMDTEXT)
            End If
        End Sub
        Private Sub NOW(STARTDATE As String, FINISHDATE As String)
            Call Me._Messages.LogMessages("Collecting Records ...", Utils.BroadcastTypes.Log)
            '
            If STARTDATE Is Nothing And FINISHDATE Is Nothing Then
                For X As Int32 = CInt(Today.ToOADate - (366 * 2)) To CInt(Today.ToOADate) Step 122
                    Using ModelRun As New ModelDevelopment.ModelRun(CStr(X), CStr(X + 122), Nothing, Me._Messages, Nothing, Nothing)
                        If ModelRun.HasErrors Then Exit For
                        Call ModelRun.GetResults_DT()
                    End Using
                    X += 1
                Next X
            Else
                Using ModelRun As New ModelDevelopment.ModelRun(STARTDATE, FINISHDATE, Nothing, Me._Messages, Nothing, Nothing)
                    If Not ModelRun.HasErrors Then
                        Call ModelRun.GetResults_DT()
                    End If
                End Using
            End If
        End Sub

#Region "    IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Private Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    Me._Connection.Dispose()
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