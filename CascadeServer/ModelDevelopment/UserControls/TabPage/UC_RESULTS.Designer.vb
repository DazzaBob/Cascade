Namespace ModelDevelopment.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_RESULTS
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If Not MY_POPUP Is Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
                If Not MY_DISPLAYRACE Is Nothing Then MY_DISPLAYRACE.Dispose() : MY_DISPLAYRACE = Nothing
                If Not MY_UI_MODEL_TOTALS Is Nothing Then MY_UI_MODEL_TOTALS.Dispose() : MY_UI_MODEL_TOTALS = Nothing
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
            components = New ComponentModel.Container()
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DGV_RESULTS_CMS = New ContextMenuStrip(components)
            DGV_RESULTS_CMS_CopyToolStripMenuItem = New ToolStripMenuItem()
            DGV_RESULTS = New DataGridView()
            DGV_DATE = New DataGridViewTextBoxColumn()
            DGV_NUMBER = New DataGridViewTextBoxColumn()
            DGV_BARRIER = New DataGridViewTextBoxColumn()
            DGV_NAME = New DataGridViewLinkColumn()
            DGV_CLASS = New DataGridViewTextBoxColumn()
            DGV_MEETINGNAME = New DataGridViewTextBoxColumn()
            DGV_RACELENGTH = New DataGridViewTextBoxColumn()
            DGV_VENUE = New DataGridViewTextBoxColumn()
            DGV_WEATHER = New DataGridViewTextBoxColumn()
            DGV_TRACK = New DataGridViewTextBoxColumn()
            DGV_FINISHPOSITION = New DataGridViewTextBoxColumn()
            DGV_WINS = New DataGridViewTextBoxColumn()
            DGV_PLACES = New DataGridViewTextBoxColumn()
            LBL_RANGE_HEADER = New Label()
            Panel1 = New Panel()
            DGV_RESULTS_CMS.SuspendLayout()
            CType(DGV_RESULTS, ComponentModel.ISupportInitialize).BeginInit()
            Panel1.SuspendLayout()
            SuspendLayout()
            ' 
            ' DGV_RESULTS_CMS
            ' 
            DGV_RESULTS_CMS.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_RESULTS_CMS.ImageScalingSize = New Size(40, 40)
            DGV_RESULTS_CMS.Items.AddRange(New ToolStripItem() {DGV_RESULTS_CMS_CopyToolStripMenuItem})
            DGV_RESULTS_CMS.Name = "DGVCMS"
            DGV_RESULTS_CMS.RenderMode = ToolStripRenderMode.Professional
            DGV_RESULTS_CMS.Size = New Size(162, 50)
            ' 
            ' DGV_RESULTS_CMS_CopyToolStripMenuItem
            ' 
            DGV_RESULTS_CMS_CopyToolStripMenuItem.ImageTransparentColor = Color.Magenta
            DGV_RESULTS_CMS_CopyToolStripMenuItem.Name = "DGV_RESULTS_CMS_CopyToolStripMenuItem"
            DGV_RESULTS_CMS_CopyToolStripMenuItem.Size = New Size(161, 46)
            DGV_RESULTS_CMS_CopyToolStripMenuItem.Text = "&Copy"
            ' 
            ' DGV_RESULTS
            ' 
            DGV_RESULTS.AllowUserToAddRows = False
            DataGridViewCellStyle1.BackColor = SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DGV_RESULTS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DGV_RESULTS.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            DGV_RESULTS.BackgroundColor = SystemColors.Window
            DGV_RESULTS.BorderStyle = BorderStyle.None
            DGV_RESULTS.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            DGV_RESULTS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = SystemColors.Control
            DataGridViewCellStyle2.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DGV_RESULTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DGV_RESULTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DGV_RESULTS.Columns.AddRange(New DataGridViewColumn() {DGV_DATE, DGV_NUMBER, DGV_BARRIER, DGV_NAME, DGV_CLASS, DGV_MEETINGNAME, DGV_RACELENGTH, DGV_VENUE, DGV_WEATHER, DGV_TRACK, DGV_FINISHPOSITION, DGV_WINS, DGV_PLACES})
            DGV_RESULTS.ContextMenuStrip = DGV_RESULTS_CMS
            DGV_RESULTS.EditMode = DataGridViewEditMode.EditProgrammatically
            DGV_RESULTS.GridColor = SystemColors.ControlDarkDark
            DGV_RESULTS.Location = New Point(0, 84)
            DGV_RESULTS.Margin = New Padding(0)
            DGV_RESULTS.Name = "DGV_RESULTS"
            DGV_RESULTS.ReadOnly = True
            DGV_RESULTS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.BackColor = SystemColors.Control
            DataGridViewCellStyle16.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle16.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = DataGridViewTriState.True
            DGV_RESULTS.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
            DGV_RESULTS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle17.BackColor = SystemColors.Window
            DataGridViewCellStyle17.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle17.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText
            DGV_RESULTS.RowsDefaultCellStyle = DataGridViewCellStyle17
            DGV_RESULTS.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Window
            DGV_RESULTS.RowTemplate.DefaultCellStyle.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_RESULTS.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText
            DGV_RESULTS.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
            DGV_RESULTS.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText
            DGV_RESULTS.RowTemplate.Height = 24
            DGV_RESULTS.RowTemplate.ReadOnly = True
            DGV_RESULTS.Size = New Size(2030, 579)
            DGV_RESULTS.TabIndex = 1060
            ' 
            ' DGV_DATE
            ' 
            DGV_DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = SystemColors.Window
            DataGridViewCellStyle3.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.Format = "d"
            DataGridViewCellStyle3.NullValue = Nothing
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
            DGV_DATE.DefaultCellStyle = DataGridViewCellStyle3
            DGV_DATE.HeaderText = "DATE"
            DGV_DATE.MinimumWidth = 12
            DGV_DATE.Name = "DGV_DATE"
            DGV_DATE.ReadOnly = True
            DGV_DATE.ToolTipText = "DATE"
            DGV_DATE.Width = 128
            ' 
            ' DGV_NUMBER
            ' 
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle4.Format = "N0"
            DataGridViewCellStyle4.NullValue = "0"
            DGV_NUMBER.DefaultCellStyle = DataGridViewCellStyle4
            DGV_NUMBER.HeaderText = "#"
            DGV_NUMBER.MinimumWidth = 12
            DGV_NUMBER.Name = "DGV_NUMBER"
            DGV_NUMBER.ReadOnly = True
            DGV_NUMBER.ToolTipText = "NUMBER"
            DGV_NUMBER.Width = 25
            ' 
            ' DGV_BARRIER
            ' 
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.Format = "N0"
            DataGridViewCellStyle5.NullValue = "0"
            DGV_BARRIER.DefaultCellStyle = DataGridViewCellStyle5
            DGV_BARRIER.HeaderText = "B"
            DGV_BARRIER.MinimumWidth = 12
            DGV_BARRIER.Name = "DGV_BARRIER"
            DGV_BARRIER.ReadOnly = True
            DGV_BARRIER.ToolTipText = "BARRIER"
            DGV_BARRIER.Width = 25
            ' 
            ' DGV_NAME
            ' 
            DGV_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_NAME.DefaultCellStyle = DataGridViewCellStyle6
            DGV_NAME.DividerWidth = 1
            DGV_NAME.HeaderText = "NAME"
            DGV_NAME.MinimumWidth = 12
            DGV_NAME.Name = "DGV_NAME"
            DGV_NAME.ReadOnly = True
            DGV_NAME.Resizable = DataGridViewTriState.True
            DGV_NAME.ToolTipText = "RUNNER NAME"
            DGV_NAME.Width = 94
            ' 
            ' DGV_CLASS
            ' 
            DGV_CLASS.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle7.Format = "N0"
            DataGridViewCellStyle7.NullValue = "999"
            DGV_CLASS.DefaultCellStyle = DataGridViewCellStyle7
            DGV_CLASS.HeaderText = "CL"
            DGV_CLASS.MinimumWidth = 12
            DGV_CLASS.Name = "DGV_CLASS"
            DGV_CLASS.ReadOnly = True
            DGV_CLASS.Width = 96
            ' 
            ' DGV_MEETINGNAME
            ' 
            DGV_MEETINGNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle8.BackColor = SystemColors.Window
            DataGridViewCellStyle8.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
            DGV_MEETINGNAME.DefaultCellStyle = DataGridViewCellStyle8
            DGV_MEETINGNAME.HeaderText = "M-N"
            DGV_MEETINGNAME.MinimumWidth = 12
            DGV_MEETINGNAME.Name = "DGV_MEETINGNAME"
            DGV_MEETINGNAME.ReadOnly = True
            DGV_MEETINGNAME.ToolTipText = "MEETING NAME"
            DGV_MEETINGNAME.Width = 120
            ' 
            ' DGV_RACELENGTH
            ' 
            DGV_RACELENGTH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle9.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle9.Format = "N0"
            DataGridViewCellStyle9.NullValue = "0"
            DGV_RACELENGTH.DefaultCellStyle = DataGridViewCellStyle9
            DGV_RACELENGTH.HeaderText = "L"
            DGV_RACELENGTH.MinimumWidth = 12
            DGV_RACELENGTH.Name = "DGV_RACELENGTH"
            DGV_RACELENGTH.ReadOnly = True
            DGV_RACELENGTH.ToolTipText = "LENGTH"
            DGV_RACELENGTH.Width = 81
            ' 
            ' DGV_VENUE
            ' 
            DGV_VENUE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_VENUE.DefaultCellStyle = DataGridViewCellStyle10
            DGV_VENUE.HeaderText = "VENUE"
            DGV_VENUE.MinimumWidth = 12
            DGV_VENUE.Name = "DGV_VENUE"
            DGV_VENUE.ReadOnly = True
            DGV_VENUE.ToolTipText = "VENUE"
            ' 
            ' DGV_WEATHER
            ' 
            DGV_WEATHER.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle11.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_WEATHER.DefaultCellStyle = DataGridViewCellStyle11
            DGV_WEATHER.HeaderText = "W"
            DGV_WEATHER.MinimumWidth = 12
            DGV_WEATHER.Name = "DGV_WEATHER"
            DGV_WEATHER.ReadOnly = True
            DGV_WEATHER.ToolTipText = "WEATHER"
            DGV_WEATHER.Width = 94
            ' 
            ' DGV_TRACK
            ' 
            DGV_TRACK.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_TRACK.DefaultCellStyle = DataGridViewCellStyle12
            DGV_TRACK.DividerWidth = 1
            DGV_TRACK.HeaderText = "T"
            DGV_TRACK.MinimumWidth = 12
            DGV_TRACK.Name = "DGV_TRACK"
            DGV_TRACK.ReadOnly = True
            DGV_TRACK.ToolTipText = "TRACK"
            DGV_TRACK.Width = 84
            ' 
            ' DGV_FINISHPOSITION
            ' 
            DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle13.Format = "N0"
            DataGridViewCellStyle13.NullValue = "0"
            DGV_FINISHPOSITION.DefaultCellStyle = DataGridViewCellStyle13
            DGV_FINISHPOSITION.HeaderText = "F-P"
            DGV_FINISHPOSITION.MinimumWidth = 12
            DGV_FINISHPOSITION.Name = "DGV_FINISHPOSITION"
            DGV_FINISHPOSITION.ReadOnly = True
            DGV_FINISHPOSITION.ToolTipText = "FINISH POSITION"
            DGV_FINISHPOSITION.Width = 25
            ' 
            ' DGV_WINS
            ' 
            DGV_WINS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle14.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle14.Format = "C2"
            DataGridViewCellStyle14.NullValue = "0.00"
            DGV_WINS.DefaultCellStyle = DataGridViewCellStyle14
            DGV_WINS.HeaderText = "P-W"
            DGV_WINS.MinimumWidth = 12
            DGV_WINS.Name = "DGV_WINS"
            DGV_WINS.ReadOnly = True
            DGV_WINS.ToolTipText = "PAID WINS"
            DGV_WINS.Width = 116
            ' 
            ' DGV_PLACES
            ' 
            DGV_PLACES.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle15.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle15.Format = "C2"
            DataGridViewCellStyle15.NullValue = "0.00"
            DGV_PLACES.DefaultCellStyle = DataGridViewCellStyle15
            DGV_PLACES.HeaderText = "P-P"
            DGV_PLACES.MinimumWidth = 12
            DGV_PLACES.Name = "DGV_PLACES"
            DGV_PLACES.ReadOnly = True
            DGV_PLACES.ToolTipText = "PAID PLACES"
            DGV_PLACES.Width = 105
            ' 
            ' LBL_RANGE_HEADER
            ' 
            LBL_RANGE_HEADER.BackColor = SystemColors.GradientActiveCaption
            LBL_RANGE_HEADER.Dock = DockStyle.Top
            LBL_RANGE_HEADER.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_RANGE_HEADER.ForeColor = SystemColors.ActiveCaptionText
            LBL_RANGE_HEADER.Location = New Point(0, 0)
            LBL_RANGE_HEADER.Margin = New Padding(0)
            LBL_RANGE_HEADER.Name = "LBL_RANGE_HEADER"
            LBL_RANGE_HEADER.Size = New Size(2030, 19)
            LBL_RANGE_HEADER.TabIndex = 0
            LBL_RANGE_HEADER.Text = "RANGE:"
            LBL_RANGE_HEADER.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' Panel1
            ' 
            Panel1.Controls.Add(LBL_RANGE_HEADER)
            Panel1.Dock = DockStyle.Top
            Panel1.Location = New Point(0, 0)
            Panel1.Margin = New Padding(0)
            Panel1.Name = "Panel1"
            Panel1.Size = New Size(2030, 84)
            Panel1.TabIndex = 1061
            ' 
            ' UC_RESULTS
            ' 
            AutoScaleDimensions = New SizeF(14F, 33F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = SystemColors.Window
            Controls.Add(Panel1)
            Controls.Add(DGV_RESULTS)
            DoubleBuffered = True
            Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            ForeColor = SystemColors.WindowText
            Margin = New Padding(0)
            Name = "UC_RESULTS"
            Size = New Size(2030, 672)
            DGV_RESULTS_CMS.ResumeLayout(False)
            CType(DGV_RESULTS, ComponentModel.ISupportInitialize).EndInit()
            Panel1.ResumeLayout(False)
            ResumeLayout(False)
        End Sub
        Private WithEvents DGV_RESULTS_CMS As ContextMenuStrip
        Private WithEvents DGV_RESULTS_CMS_CopyToolStripMenuItem As ToolStripMenuItem
        Private WithEvents DGV_RESULTS As DataGridView
        Private WithEvents Panel1 As Panel
        Private WithEvents LBL_RANGE_HEADER As Label
        Friend WithEvents DGV_DATE As DataGridViewTextBoxColumn
        Friend WithEvents DGV_NUMBER As DataGridViewTextBoxColumn
        Friend WithEvents DGV_BARRIER As DataGridViewTextBoxColumn
        Friend WithEvents DGV_NAME As DataGridViewLinkColumn
        Friend WithEvents DGV_CLASS As DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGNAME As DataGridViewTextBoxColumn
        Friend WithEvents DGV_RACELENGTH As DataGridViewTextBoxColumn
        Friend WithEvents DGV_VENUE As DataGridViewTextBoxColumn
        Friend WithEvents DGV_WEATHER As DataGridViewTextBoxColumn
        Friend WithEvents DGV_TRACK As DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISHPOSITION As DataGridViewTextBoxColumn
        Friend WithEvents DGV_WINS As DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLACES As DataGridViewTextBoxColumn
    End Class
End Namespace