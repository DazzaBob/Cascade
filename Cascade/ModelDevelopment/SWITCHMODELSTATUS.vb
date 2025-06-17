Namespace ModelDevelopment
    Friend NotInheritable Class SWITCHMODELSTATUS : Implements IDisposable
        Private MY_TV As Windows.Forms.TreeView
        Private MY_CONNECTION As Connection
        Private MY_STATUS As Boolean
        '
        ' These need to be disposed in this class
        Private MY_IN_MODEL_EXPLORER_ID As String
        Friend Sub New(ByVal TV As Windows.Forms.TreeView, ByVal Status As Boolean, ByVal Connection As Connection)
            MY_TV = TV
            MY_CONNECTION = Connection
            MY_STATUS = Status
        End Sub
        Friend Sub Execute()
            For Each Node As Windows.Forms.TreeNode In MY_TV.Nodes
                Call CheckSubNodes(Node)
            Next Node
            '
            If (Not MY_IN_MODEL_EXPLORER_ID Is Nothing) AndAlso (MY_IN_MODEL_EXPLORER_ID.Length > 0) Then
                MY_IN_MODEL_EXPLORER_ID = Strings.Left(MY_IN_MODEL_EXPLORER_ID, MY_IN_MODEL_EXPLORER_ID.Length - 1)
            Else
                Return
            End If
            '
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET STATUS = "
            If MY_STATUS Then CMDTEXT += "1" Else CMDTEXT += "0"
            CMDTEXT += " WHERE (MODEL_EXPLORER_ID IN(" & MY_IN_MODEL_EXPLORER_ID & "))"
            '
            MY_CONNECTION.Execute(CMDTEXT)
        End Sub
        Private Sub CheckSubNodes(ByVal TN As Windows.Forms.TreeNode)
            For Each Node As Windows.Forms.TreeNode In TN.Nodes
                If Node.Nodes.Count > 0 Then Call CheckSubNodes(Node)
                If Node.Checked Then MY_IN_MODEL_EXPLORER_ID += Node.Name & ","
            Next
        End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Friend Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    MY_IN_MODEL_EXPLORER_ID = Nothing
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