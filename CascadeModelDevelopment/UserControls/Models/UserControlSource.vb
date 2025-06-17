Imports System.ComponentModel

Namespace UserControls.Models
    Friend Class UserControlSource
        Private _FrmMain As FrmMain
        Private _UserControlProperties As UserControlProperties
#Region "        Constructor "
        Private Sub New()
            InitializeComponent()
        End Sub
        Friend Sub New(UserControlProperties As UserControlProperties)
            Me.New()
            Me._UserControlProperties = UserControlProperties
        End Sub
        Private Sub UserControlSource_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.RichTextBoxLineNumbers.Font = Me.RichTextBoxSource.Font
            Me.RichTextBoxSource.Select()
            Me.RichTextBoxLineNumbers.Invalidate()
            AddLineNumbers()

            Me.RichTextBoxSource.Text = Me._UserControlProperties.SourceCode
        End Sub
#End Region
        Friend WriteOnly Property FrmMain As FrmMain
            Set(value As FrmMain)
                Me._FrmMain = value
            End Set
        End Property
        Private Sub UserControlSource_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
            AddLineNumbers()
        End Sub
        Private Sub RichTextBoxSourceCode_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxSource.TextChanged
            If Me._UserControlProperties IsNot Nothing Then
                Me._UserControlProperties.SourceCode = Me.RichTextBoxSource.Text
                Me._UserControlProperties.RequiresSave = True
                Me._UserControlProperties.Compiled = False
            End If

            If Me._FrmMain IsNot Nothing Then
                _FrmMain.TSSLBLStatus.Text = "Compile Required" : _FrmMain.StatusStripActions.Invalidate() : Application.DoEvents()
            End If

            Call AddLineNumbers()

            'If Me.RichTextBoxCode.CanUndo Then MY_MAINFORM.TSB_Undo.Enabled = True Else MY_MAINFORM.TSB_Undo.Enabled = False
            'If Me.RichTextBoxCode.CanRedo Then MY_MAINFORM.TSB_Redo.Enabled = True Else MY_MAINFORM.TSB_Redo.Enabled = False
        End Sub
#Region "        Context Menu - Copy and Paste "
        Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
            Me.RichTextBoxSource.Copy()
        End Sub
        Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
            Me.RichTextBoxSource.Paste()
        End Sub
        Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
            Me.RichTextBoxSource.Cut()
        End Sub
        Private Sub ContextMenuStripRichTextBoxSourceCode_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStripRichTextBoxSourceCode.Opening
            Dim Formats() As String = Clipboard.GetDataObject.GetFormats
            If Formats.Contains("System.String") OrElse Formats.Contains("UnicodeText") OrElse Formats.Contains("Text") OrElse Formats.Contains("Rich Text Format") Then
                Me.PasteToolStripMenuItem.Enabled = True
            Else
                Me.PasteToolStripMenuItem.Enabled = False
            End If
            If Me.RichTextBoxSource.SelectedText.Length > 0 Then
                Me.CopyToolStripMenuItem.Enabled = True
                Me.CutToolStripMenuItem.Enabled = True
            Else
                Me.CopyToolStripMenuItem.Enabled = False
                Me.CutToolStripMenuItem.Enabled = False
            End If
        End Sub
#End Region
#Region "        Line Numbering - RichTextBox "
        Private ReadOnly Property RichTextBoxWidth As Single
            Get
                Select Case Me.RichTextBoxLineNumbers.Lines.Length
                    Case <= 99
                        Return 75 + Me.RichTextBoxLineNumbers.Font.Size
                        Exit Select
                    Case <= 999
                        Return 95 + Me.RichTextBoxLineNumbers.Font.Size
                        Exit Select
                    Case Else
                        Return 105 + Me.RichTextBoxLineNumbers.Font.Size
                End Select
            End Get
        End Property
        Friend Sub AddLineNumbers()
            Dim MaxLineCount As Integer = Me.RichTextBoxSource.Lines.Length + 1
            If MaxLineCount <= 5 Then MaxLineCount = 5

            Me.RichTextBoxLineNumbers.SuspendLayout()
            Me.RichTextBoxLineNumbers.Text = String.Empty
            Me.RichTextBoxLineNumbers.SelectionAlignment = HorizontalAlignment.Center
            Me.RichTextBoxLineNumbers.Width = CInt(RichTextBoxWidth)

            For X As Integer = 1 To MaxLineCount
                Me.RichTextBoxLineNumbers.Text += X.ToString & Environment.NewLine
            Next X

            Me.RichTextBoxLineNumbers.ResumeLayout()
            Me.RichTextBoxLineNumbers.Invalidate()
        End Sub
        Private Sub RichTextBoxSource_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBoxSource.SelectionChanged
            Call AddLineNumbers()
        End Sub
        Private Sub RichTextBoxSource_VScroll(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBoxSource.VScroll
            Call AddLineNumbers()
        End Sub
        Private Sub RichTextBoxSource_Resize(sender As Object, e As EventArgs) Handles RichTextBoxSource.Resize
            Call AddLineNumbers()
        End Sub
        Private Sub RichTextBoxSource_FontChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBoxSource.FontChanged
            Me.RichTextBoxLineNumbers.Font = Me.RichTextBoxSource.Font
            Me.RichTextBoxSource.Select()
            Call AddLineNumbers()
        End Sub
        Private Sub LineNumberTextBox_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles RichTextBoxLineNumbers.MouseDown
            Me.RichTextBoxSource.Select()
            Me.RichTextBoxLineNumbers.DeselectAll()
        End Sub
#End Region
    End Class
End Namespace