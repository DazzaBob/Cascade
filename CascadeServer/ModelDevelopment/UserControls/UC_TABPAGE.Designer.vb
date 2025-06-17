Namespace ModelDevelopment.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_TABPAGE
        Inherits System.Windows.Forms.TabPage

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_TABPAGE))
            Me.RichTextBoxCode = New System.Windows.Forms.RichTextBox()
            Me.TC_OUTPUT = New System.Windows.Forms.TabControl()
            Me.TC_OUTPUT_TP_SOURCE = New System.Windows.Forms.TabPage()
            Me.TC_OUTPUT_TP_ERRORS = New System.Windows.Forms.TabPage()
            Me.ListViewErrorList = New System.Windows.Forms.ListView()
            Me.colIcon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colErrCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colLine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.colColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.TC_OUTPUT_TP_RESULTS = New System.Windows.Forms.TabPage()
            Me.TC_OUTPUT_TP_PROPERTIES = New System.Windows.Forms.TabPage()
            Me.PROPERTIESGRID = New System.Windows.Forms.PropertyGrid()
            Me.TC_OUTPUT_TP_LOGS = New System.Windows.Forms.TabPage()
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG = New System.Windows.Forms.TextBox()
            Me.TC_OUTPUT_TP_NOTES = New System.Windows.Forms.TabPage()
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES = New System.Windows.Forms.TextBox()
            Me.imgList = New System.Windows.Forms.ImageList(Me.components)
            Me.DGV_RESULTS_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMS_RICHTEXTBOX = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CMS_RICHTEXTBOX_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMS_RICHTEXTBOX_CUT = New System.Windows.Forms.ToolStripMenuItem()
            Me.CMS_RICHTEXTBOX_SEPERATOR = New System.Windows.Forms.ToolStripSeparator()
            Me.CMS_RICHTEXTBOX_PASTE = New System.Windows.Forms.ToolStripMenuItem()
            Me.TC_OUTPUT.SuspendLayout()
            Me.TC_OUTPUT_TP_ERRORS.SuspendLayout()
            Me.TC_OUTPUT_TP_PROPERTIES.SuspendLayout()
            Me.TC_OUTPUT_TP_LOGS.SuspendLayout()
            Me.TC_OUTPUT_TP_NOTES.SuspendLayout()
            Me.DGV_RESULTS_CMS.SuspendLayout()
            Me.CMS_RICHTEXTBOX.SuspendLayout()
            Me.SuspendLayout()
            '
            'RichTextBoxCode
            '
            Me.RichTextBoxCode.AcceptsTab = True
            Me.RichTextBoxCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RichTextBoxCode.BackColor = System.Drawing.Color.White
            Me.RichTextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.RichTextBoxCode.ContextMenuStrip = Me.CMS_RICHTEXTBOX
            Me.RichTextBoxCode.EnableAutoDragDrop = True
            Me.RichTextBoxCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RichTextBoxCode.ForeColor = System.Drawing.Color.Black
            Me.RichTextBoxCode.Location = New System.Drawing.Point(36, 0)
            Me.RichTextBoxCode.Margin = New System.Windows.Forms.Padding(0)
            Me.RichTextBoxCode.Name = "RichTextBoxCode"
            Me.RichTextBoxCode.Size = New System.Drawing.Size(812, 348)
            Me.RichTextBoxCode.TabIndex = 0
            Me.RichTextBoxCode.Text = ""
            '
            'TC_OUTPUT
            '
            Me.TC_OUTPUT.Alignment = System.Windows.Forms.TabAlignment.Bottom
            Me.TC_OUTPUT.Controls.Add(Me.TC_OUTPUT_TP_SOURCE)
            Me.TC_OUTPUT.Controls.Add(Me.TC_OUTPUT_TP_ERRORS)
            Me.TC_OUTPUT.Controls.Add(Me.TC_OUTPUT_TP_RESULTS)
            Me.TC_OUTPUT.Controls.Add(Me.TC_OUTPUT_TP_PROPERTIES)
            Me.TC_OUTPUT.Controls.Add(Me.TC_OUTPUT_TP_LOGS)
            Me.TC_OUTPUT.Controls.Add(Me.TC_OUTPUT_TP_NOTES)
            Me.TC_OUTPUT.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_OUTPUT.Location = New System.Drawing.Point(0, 0)
            Me.TC_OUTPUT.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_OUTPUT.Name = "TC_OUTPUT"
            Me.TC_OUTPUT.Padding = New System.Drawing.Point(0, 0)
            Me.TC_OUTPUT.SelectedIndex = 0
            Me.TC_OUTPUT.Size = New System.Drawing.Size(858, 374)
            Me.TC_OUTPUT.TabIndex = 37
            '
            'TC_OUTPUT_TP_SOURCE
            '
            Me.TC_OUTPUT_TP_SOURCE.Location = New System.Drawing.Point(4, 4)
            Me.TC_OUTPUT_TP_SOURCE.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.TC_OUTPUT_TP_SOURCE.Name = "TC_OUTPUT_TP_SOURCE"
            Me.TC_OUTPUT_TP_SOURCE.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.TC_OUTPUT_TP_SOURCE.Size = New System.Drawing.Size(850, 348)
            Me.TC_OUTPUT_TP_SOURCE.TabIndex = 2
            Me.TC_OUTPUT_TP_SOURCE.Text = "SOURCE"
            Me.TC_OUTPUT_TP_SOURCE.ToolTipText = "View source code."
            Me.TC_OUTPUT_TP_SOURCE.UseVisualStyleBackColor = True
            '
            'TC_OUTPUT_TP_ERRORS
            '
            Me.TC_OUTPUT_TP_ERRORS.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.TC_OUTPUT_TP_ERRORS.Controls.Add(Me.ListViewErrorList)
            Me.TC_OUTPUT_TP_ERRORS.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TC_OUTPUT_TP_ERRORS.Location = New System.Drawing.Point(4, 4)
            Me.TC_OUTPUT_TP_ERRORS.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_OUTPUT_TP_ERRORS.Name = "TC_OUTPUT_TP_ERRORS"
            Me.TC_OUTPUT_TP_ERRORS.Size = New System.Drawing.Size(850, 348)
            Me.TC_OUTPUT_TP_ERRORS.TabIndex = 0
            Me.TC_OUTPUT_TP_ERRORS.Text = "ERRORS"
            '
            'ListViewErrorList
            '
            Me.ListViewErrorList.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.ListViewErrorList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colIcon, Me.colNo, Me.colDescription, Me.colErrCode, Me.colLine, Me.colColumn})
            Me.ListViewErrorList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ListViewErrorList.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ListViewErrorList.FullRowSelect = True
            Me.ListViewErrorList.GridLines = True
            Me.ListViewErrorList.Location = New System.Drawing.Point(0, 0)
            Me.ListViewErrorList.Margin = New System.Windows.Forms.Padding(0)
            Me.ListViewErrorList.MultiSelect = False
            Me.ListViewErrorList.Name = "ListViewErrorList"
            Me.ListViewErrorList.ShowGroups = False
            Me.ListViewErrorList.Size = New System.Drawing.Size(850, 348)
            Me.ListViewErrorList.TabIndex = 2
            Me.ListViewErrorList.UseCompatibleStateImageBehavior = False
            Me.ListViewErrorList.View = System.Windows.Forms.View.Details
            '
            'colIcon
            '
            Me.colIcon.Text = ""
            Me.colIcon.Width = 30
            '
            'colNo
            '
            Me.colNo.Text = ""
            Me.colNo.Width = 30
            '
            'colDescription
            '
            Me.colDescription.Text = "Description"
            Me.colDescription.Width = 451
            '
            'colErrCode
            '
            Me.colErrCode.Text = "Error Code"
            Me.colErrCode.Width = 96
            '
            'colLine
            '
            Me.colLine.Text = "Line"
            Me.colLine.Width = 71
            '
            'colColumn
            '
            Me.colColumn.Text = "Column"
            Me.colColumn.Width = 71
            '
            'TC_OUTPUT_TP_RESULTS
            '
            Me.TC_OUTPUT_TP_RESULTS.Location = New System.Drawing.Point(4, 4)
            Me.TC_OUTPUT_TP_RESULTS.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_OUTPUT_TP_RESULTS.Name = "TC_OUTPUT_TP_RESULTS"
            Me.TC_OUTPUT_TP_RESULTS.Size = New System.Drawing.Size(850, 348)
            Me.TC_OUTPUT_TP_RESULTS.TabIndex = 1
            Me.TC_OUTPUT_TP_RESULTS.Text = "RESULTS"
            Me.TC_OUTPUT_TP_RESULTS.ToolTipText = "View Results"
            Me.TC_OUTPUT_TP_RESULTS.UseVisualStyleBackColor = True
            '
            'TC_OUTPUT_TP_PROPERTIES
            '
            Me.TC_OUTPUT_TP_PROPERTIES.Controls.Add(Me.PROPERTIESGRID)
            Me.TC_OUTPUT_TP_PROPERTIES.Location = New System.Drawing.Point(4, 4)
            Me.TC_OUTPUT_TP_PROPERTIES.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_OUTPUT_TP_PROPERTIES.Name = "TC_OUTPUT_TP_PROPERTIES"
            Me.TC_OUTPUT_TP_PROPERTIES.Size = New System.Drawing.Size(850, 348)
            Me.TC_OUTPUT_TP_PROPERTIES.TabIndex = 3
            Me.TC_OUTPUT_TP_PROPERTIES.Text = "PROPERTIES"
            Me.TC_OUTPUT_TP_PROPERTIES.UseVisualStyleBackColor = True
            '
            'PROPERTIESGRID
            '
            Me.PROPERTIESGRID.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PROPERTIESGRID.Location = New System.Drawing.Point(0, 0)
            Me.PROPERTIESGRID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.PROPERTIESGRID.Name = "PROPERTIESGRID"
            Me.PROPERTIESGRID.Size = New System.Drawing.Size(850, 348)
            Me.PROPERTIESGRID.TabIndex = 1
            '
            'TC_OUTPUT_TP_LOGS
            '
            Me.TC_OUTPUT_TP_LOGS.Controls.Add(Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG)
            Me.TC_OUTPUT_TP_LOGS.Location = New System.Drawing.Point(4, 4)
            Me.TC_OUTPUT_TP_LOGS.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_OUTPUT_TP_LOGS.Name = "TC_OUTPUT_TP_LOGS"
            Me.TC_OUTPUT_TP_LOGS.Size = New System.Drawing.Size(850, 348)
            Me.TC_OUTPUT_TP_LOGS.TabIndex = 4
            Me.TC_OUTPUT_TP_LOGS.Text = "LOGS"
            Me.TC_OUTPUT_TP_LOGS.UseVisualStyleBackColor = True
            '
            'TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG
            '
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.Location = New System.Drawing.Point(0, 0)
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.Multiline = True
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.Name = "TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG"
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.ReadOnly = True
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.Size = New System.Drawing.Size(850, 348)
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.TabIndex = 1
            Me.TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG.TabStop = False
            '
            'TC_OUTPUT_TP_NOTES
            '
            Me.TC_OUTPUT_TP_NOTES.Controls.Add(Me.TC_OUTPUT_TP_NOTES_TB_NOTES)
            Me.TC_OUTPUT_TP_NOTES.Location = New System.Drawing.Point(4, 4)
            Me.TC_OUTPUT_TP_NOTES.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_OUTPUT_TP_NOTES.Name = "TC_OUTPUT_TP_NOTES"
            Me.TC_OUTPUT_TP_NOTES.Size = New System.Drawing.Size(850, 348)
            Me.TC_OUTPUT_TP_NOTES.TabIndex = 5
            Me.TC_OUTPUT_TP_NOTES.Text = "NOTES"
            Me.TC_OUTPUT_TP_NOTES.UseVisualStyleBackColor = True
            '
            'TC_OUTPUT_TP_NOTES_TB_NOTES
            '
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.AcceptsReturn = True
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.Location = New System.Drawing.Point(0, 0)
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.Multiline = True
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.Name = "TC_OUTPUT_TP_NOTES_TB_NOTES"
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.Size = New System.Drawing.Size(850, 348)
            Me.TC_OUTPUT_TP_NOTES_TB_NOTES.TabIndex = 1
            '
            'imgList
            '
            Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgList.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imgList.Images.SetKeyName(0, "ErrorList.bmp")
            Me.imgList.Images.SetKeyName(1, "Output.bmp")
            Me.imgList.Images.SetKeyName(2, "Warning.bmp")
            Me.imgList.Images.SetKeyName(3, "Error.bmp")
            '
            'DGV_RESULTS_CMS
            '
            Me.DGV_RESULTS_CMS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RESULTS_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DGV_RESULTS_CMS_CopyToolStripMenuItem})
            Me.DGV_RESULTS_CMS.Name = "DGVCMS"
            Me.DGV_RESULTS_CMS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.DGV_RESULTS_CMS.ShowImageMargin = False
            Me.DGV_RESULTS_CMS.Size = New System.Drawing.Size(77, 26)
            '
            'DGV_RESULTS_CMS_CopyToolStripMenuItem
            '
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.Name = "DGV_RESULTS_CMS_CopyToolStripMenuItem"
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.Text = "&Copy"
            '
            'CMS_RICHTEXTBOX
            '
            Me.CMS_RICHTEXTBOX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_RICHTEXTBOX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_RICHTEXTBOX_COPY, Me.CMS_RICHTEXTBOX_CUT, Me.CMS_RICHTEXTBOX_SEPERATOR, Me.CMS_RICHTEXTBOX_PASTE})
            Me.CMS_RICHTEXTBOX.Name = "CMS_TextBoxCode"
            Me.CMS_RICHTEXTBOX.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.CMS_RICHTEXTBOX.Size = New System.Drawing.Size(105, 76)
            '
            'CMS_RICHTEXTBOX_COPY
            '
            Me.CMS_RICHTEXTBOX_COPY.ImageTransparentColor = System.Drawing.Color.Black
            Me.CMS_RICHTEXTBOX_COPY.Name = "CMS_RICHTEXTBOX_COPY"
            Me.CMS_RICHTEXTBOX_COPY.Size = New System.Drawing.Size(104, 22)
            Me.CMS_RICHTEXTBOX_COPY.Text = "Copy"
            '
            'CMS_RICHTEXTBOX_CUT
            '
            Me.CMS_RICHTEXTBOX_CUT.ImageTransparentColor = System.Drawing.Color.Black
            Me.CMS_RICHTEXTBOX_CUT.Name = "CMS_RICHTEXTBOX_CUT"
            Me.CMS_RICHTEXTBOX_CUT.Size = New System.Drawing.Size(104, 22)
            Me.CMS_RICHTEXTBOX_CUT.Text = "Cut"
            '
            'CMS_RICHTEXTBOX_SEPERATOR
            '
            Me.CMS_RICHTEXTBOX_SEPERATOR.Name = "CMS_RICHTEXTBOX_SEPERATOR"
            Me.CMS_RICHTEXTBOX_SEPERATOR.Size = New System.Drawing.Size(101, 6)
            '
            'CMS_RICHTEXTBOX_PASTE
            '
            Me.CMS_RICHTEXTBOX_PASTE.ImageTransparentColor = System.Drawing.Color.Black
            Me.CMS_RICHTEXTBOX_PASTE.Name = "CMS_RICHTEXTBOX_PASTE"
            Me.CMS_RICHTEXTBOX_PASTE.Size = New System.Drawing.Size(104, 22)
            Me.CMS_RICHTEXTBOX_PASTE.Text = "Paste"
            '
            'TabPage
            '
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TC_OUTPUT.ResumeLayout(False)
            Me.TC_OUTPUT_TP_ERRORS.ResumeLayout(False)
            Me.TC_OUTPUT_TP_PROPERTIES.ResumeLayout(False)
            Me.TC_OUTPUT_TP_LOGS.ResumeLayout(False)
            Me.TC_OUTPUT_TP_LOGS.PerformLayout()
            Me.TC_OUTPUT_TP_NOTES.ResumeLayout(False)
            Me.TC_OUTPUT_TP_NOTES.PerformLayout()
            Me.DGV_RESULTS_CMS.ResumeLayout(False)
            Me.CMS_RICHTEXTBOX.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents RichTextBoxCode As System.Windows.Forms.RichTextBox
        Private WithEvents TC_OUTPUT_TP_SOURCE As System.Windows.Forms.TabPage
        Private WithEvents colIcon As System.Windows.Forms.ColumnHeader
        Private WithEvents colNo As System.Windows.Forms.ColumnHeader
        Private WithEvents colDescription As System.Windows.Forms.ColumnHeader
        Private WithEvents colErrCode As System.Windows.Forms.ColumnHeader
        Private WithEvents colLine As System.Windows.Forms.ColumnHeader
        Private WithEvents colColumn As System.Windows.Forms.ColumnHeader
        Private WithEvents TC_OUTPUT_TP_PROPERTIES As System.Windows.Forms.TabPage
        Friend WithEvents PROPERTIESGRID As System.Windows.Forms.PropertyGrid
        Private WithEvents TC_OUTPUT_TP_LOGS As System.Windows.Forms.TabPage
        Private WithEvents TC_OUTPUT_TP_LOGS_TB_LOG_TP_LOG As System.Windows.Forms.TextBox
        Private WithEvents TC_OUTPUT_TP_NOTES As System.Windows.Forms.TabPage
        Private WithEvents imgList As System.Windows.Forms.ImageList
        Private WithEvents DGV_RESULTS_CMS As System.Windows.Forms.ContextMenuStrip
        Private WithEvents DGV_RESULTS_CMS_CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMS_RICHTEXTBOX As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CMS_RICHTEXTBOX_COPY As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMS_RICHTEXTBOX_CUT As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMS_RICHTEXTBOX_SEPERATOR As System.Windows.Forms.ToolStripSeparator
        Private WithEvents CMS_RICHTEXTBOX_PASTE As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TC_OUTPUT_TP_NOTES_TB_NOTES As System.Windows.Forms.TextBox
        Friend WithEvents TC_OUTPUT As System.Windows.Forms.TabControl
        Friend WithEvents TC_OUTPUT_TP_RESULTS As System.Windows.Forms.TabPage
        Private WithEvents TC_OUTPUT_TP_ERRORS As System.Windows.Forms.TabPage
        Friend WithEvents ListViewErrorList As System.Windows.Forms.ListView

    End Class
End Namespace