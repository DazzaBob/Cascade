Namespace ModelDevelopment
    Friend NotInheritable Class IMPORTMODELS : Implements IDisposable
        Private MY_DT As Data.DataTable
        Private MY_CONNECTION As Connection
        Friend Sub New(ByVal DT As Data.DataTable, ByVal Connection As Connection)
            MY_DT = DT
            MY_CONNECTION = Connection
        End Sub
        Friend Sub Execute()
            For Each ROW As Data.DataRow In MY_DT.Select("")
                If CInt(ROW.Item("TREE_NODE_TYPE")) <> 2 Then Continue For
                Dim CMDTEXT As String
                CMDTEXT = "INSERT INTO MODEL_EXPLORER (PARENT_EXPLORER_ID, LEVEL, TREE_NODE_TYPE, TREE_PATH, NAME, MEETING_COUNTRY, MEETING_TYPE, MEETING_CODE, RACE_LENGTH, RACE_TRACK, RACE_VENUE, RACE_WEATHER, BACKING, VBCODE, VERSION, STATUS, NOTES) "
                CMDTEXT += "VALUES (-6, 1, 2, 'Imported', '" & Replace(CStr(ROW.Item("NAME")), "'", "' + CHAR(39) + '") & "',"
                If Not IsDBNull(ROW.Item("MEETING_COUNTRY")) Then CMDTEXT += "'" & CStr(ROW.Item("MEETING_COUNTRY")) & "', " Else CMDTEXT += "NULL, "
                If Not IsDBNull(ROW.Item("MEETING_TYPE")) Then CMDTEXT += "'" & CStr(ROW.Item("MEETING_TYPE")) & "', " Else CMDTEXT += "NULL, "
                If Not IsDBNull(ROW.Item("MEETING_CODE")) Then CMDTEXT += "'" & CStr(ROW.Item("MEETING_CODE")) & "', " Else CMDTEXT += "NULL, "
                If Not IsDBNull(ROW.Item("RACE_LENGTH")) Then CMDTEXT += CStr(ROW.Item("RACE_LENGTH")) & ", " Else CMDTEXT += "NULL, "
                If Not IsDBNull(ROW.Item("RACE_TRACK")) Then CMDTEXT += "'" & CStr(ROW.Item("RACE_TRACK")) & "', " Else CMDTEXT += "NULL, "
                If Not IsDBNull(ROW.Item("RACE_VENUE")) Then CMDTEXT += "'" & CStr(ROW.Item("RACE_VENUE")) & "', " Else CMDTEXT += "NULL, "
                If Not IsDBNull(ROW.Item("RACE_WEATHER")) Then CMDTEXT += "'" & CStr(ROW.Item("RACE_WEATHER")) & "', " Else CMDTEXT += "NULL, "
                If Not IsDBNull(ROW.Item("BACKING")) Then CMDTEXT += "'" & CStr(ROW.Item("BACKING")) & "', " Else CMDTEXT += "NULL, "
                If Not IsDBNull(ROW.Item("VBCODE")) Then CMDTEXT += "'" & Replace(CStr(ROW.Item("VBCODE")), "'", "' + CHAR(39) + '") & "', " Else CMDTEXT += "NULL, "
                CMDTEXT += CStr(Now.ToOADate) & ", "
                CMDTEXT += "0, "
                If Not IsDBNull(ROW.Item("NOTES")) Then CMDTEXT += "'" & Replace(CStr(ROW.Item("NOTES")), "'", "' + CHAR(39) + '") & "') " Else CMDTEXT += "NULL) "
                '
                Call MY_CONNECTION.Execute(CMDTEXT)
            Next ROW
        End Sub
#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Friend Sub Dispose(disposing As Boolean)
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