Namespace ModelDevelopment
    Friend NotInheritable Class EXPORTMODELS : Implements IDisposable
        Private MY_TV As System.Windows.Forms.TreeView
        Private MY_CONNECTION As Utils.Connection
        '
        ' These need to be disposed in this class
        Private MY_IN_MODEL_EXPLORER_ID As String
        Private WithEvents MY_SAVEAS As SaveFileDialog
        Private Sub New()
            MY_SAVEAS = New SaveFileDialog
            MY_SAVEAS.AddExtension = True
            MY_SAVEAS.AutoUpgradeEnabled = True
            MY_SAVEAS.DefaultExt = ".xml"
            MY_SAVEAS.FileName = Format(Now, "yyyyMMddhhmmss")
            MY_SAVEAS.Filter = "*.xml|XML File"
            MY_SAVEAS.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            MY_SAVEAS.Title = "Export checked models to file."
        End Sub
        Friend Sub New(ByVal TV As System.Windows.Forms.TreeView, ByVal Connection As Utils.Connection)
            Me.New()
            '
            MY_TV = TV
            MY_CONNECTION = Connection
        End Sub
        Friend Sub Execute()
            For Each Node As System.Windows.Forms.TreeNode In MY_TV.Nodes
                Call CheckSubNodes(Node)
            Next Node
            '
            If (Not MY_IN_MODEL_EXPLORER_ID Is Nothing) AndAlso (MY_IN_MODEL_EXPLORER_ID.Length > 0) Then
                MY_IN_MODEL_EXPLORER_ID = Strings.Left(MY_IN_MODEL_EXPLORER_ID, MY_IN_MODEL_EXPLORER_ID.Length - 1)
            Else
                Return
            End If
            '
            MY_SAVEAS.ShowDialog()
        End Sub
        Private Sub MY_SAVEAS_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MY_SAVEAS.FileOk
            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER WHERE (MODEL_EXPLORER_ID IN(" & MY_IN_MODEL_EXPLORER_ID & "))"
            Using DT As Data.DataTable = MY_CONNECTION.GetDataTable(CMDTEXT)
                DT.TableName = "MODEL_EXPLORER_EXPORT"
                DT.WriteXml(MY_SAVEAS.FileName, XmlWriteMode.WriteSchema, True)
            End Using
        End Sub
        Private Sub CheckSubNodes(ByVal TN As System.Windows.Forms.TreeNode)
            For Each Node As System.Windows.Forms.TreeNode In TN.Nodes
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
                    If Not MY_SAVEAS Is Nothing Then MY_SAVEAS.Dispose() : MY_SAVEAS = Nothing
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