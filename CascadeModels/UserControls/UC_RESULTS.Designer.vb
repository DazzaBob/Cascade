Imports System.Drawing
Namespace UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UC_RESULTS
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If Not MY_POPUP Is Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            DGV_RESULTS_CMS = New System.Windows.Forms.ContextMenuStrip(components)
            DGV_RESULTS_CMS_CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            DGV_RESULTS = New System.Windows.Forms.DataGridView()
            Panel1 = New System.Windows.Forms.Panel()
            DGV_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_BARRIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            DGV_CLASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_MEETINGNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_RACELENGTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_VENUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_WEATHER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_TRACK = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_FINISHPOSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_WINS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_PLACES = New System.Windows.Forms.DataGridViewTextBoxColumn()
            DGV_RESULTS_CMS.SuspendLayout()
            CType(DGV_RESULTS, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' DGV_RESULTS_CMS
            ' 
            DGV_RESULTS_CMS.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_RESULTS_CMS.ImageScalingSize = New Size(40, 40)
            DGV_RESULTS_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {DGV_RESULTS_CMS_CopyToolStripMenuItem})
            DGV_RESULTS_CMS.Name = "DGVCMS"
            DGV_RESULTS_CMS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
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
            DGV_RESULTS.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            DGV_RESULTS.BackgroundColor = SystemColors.Window
            DGV_RESULTS.BorderStyle = System.Windows.Forms.BorderStyle.None
            DGV_RESULTS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            DGV_RESULTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = SystemColors.Control
            DataGridViewCellStyle2.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True
            DGV_RESULTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DGV_RESULTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DGV_RESULTS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DGV_DATE, DGV_NUMBER, DGV_BARRIER, DGV_NAME, DGV_CLASS, DGV_MEETINGNAME, DGV_RACELENGTH, DGV_VENUE, DGV_WEATHER, DGV_TRACK, DGV_FINISHPOSITION, DGV_WINS, DGV_PLACES})
            DGV_RESULTS.ContextMenuStrip = DGV_RESULTS_CMS
            DGV_RESULTS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            DGV_RESULTS.GridColor = SystemColors.ControlDarkDark
            DGV_RESULTS.Location = New Point(0, 272)
            DGV_RESULTS.Margin = New System.Windows.Forms.Padding(0)
            DGV_RESULTS.Name = "DGV_RESULTS"
            DGV_RESULTS.ReadOnly = True
            DGV_RESULTS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.BackColor = SystemColors.Control
            DataGridViewCellStyle16.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle16.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True
            DGV_RESULTS.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
            DGV_RESULTS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
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
            DGV_RESULTS.Size = New Size(2030, 549)
            DGV_RESULTS.TabIndex = 1060
            ' 
            ' Panel1
            ' 
            Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Panel1.Location = New Point(0, 0)
            Panel1.Margin = New System.Windows.Forms.Padding(0)
            Panel1.Name = "Panel1"
            Panel1.Size = New Size(2030, 272)
            Panel1.TabIndex = 1061
            ' 
            ' DGV_DATE
            ' 
            DGV_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
            DGV_NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle4.Format = "N0"
            DataGridViewCellStyle4.NullValue = "0"
            DGV_NUMBER.DefaultCellStyle = DataGridViewCellStyle4
            DGV_NUMBER.HeaderText = "#"
            DGV_NUMBER.MinimumWidth = 12
            DGV_NUMBER.Name = "DGV_NUMBER"
            DGV_NUMBER.ReadOnly = True
            DGV_NUMBER.ToolTipText = "NUMBER"
            DGV_NUMBER.Width = 83
            ' 
            ' DGV_BARRIER
            ' 
            DGV_BARRIER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.Format = "N0"
            DataGridViewCellStyle5.NullValue = "0"
            DGV_BARRIER.DefaultCellStyle = DataGridViewCellStyle5
            DGV_BARRIER.HeaderText = "B"
            DGV_BARRIER.MinimumWidth = 12
            DGV_BARRIER.Name = "DGV_BARRIER"
            DGV_BARRIER.ReadOnly = True
            DGV_BARRIER.ToolTipText = "BARRIER"
            DGV_BARRIER.Width = 84
            ' 
            ' DGV_NAME
            ' 
            DGV_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_NAME.DefaultCellStyle = DataGridViewCellStyle6
            DGV_NAME.DividerWidth = 1
            DGV_NAME.HeaderText = "NAME"
            DGV_NAME.MinimumWidth = 12
            DGV_NAME.Name = "DGV_NAME"
            DGV_NAME.ReadOnly = True
            DGV_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True
            DGV_NAME.ToolTipText = "RUNNER NAME"
            DGV_NAME.Width = 94
            ' 
            ' DGV_CLASS
            ' 
            DGV_CLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
            DGV_MEETINGNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
            DGV_RACELENGTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
            DGV_VENUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
            DGV_WEATHER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
            DGV_TRACK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
            DGV_FINISHPOSITION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle13.Format = "N0"
            DataGridViewCellStyle13.NullValue = "0"
            DGV_FINISHPOSITION.DefaultCellStyle = DataGridViewCellStyle13
            DGV_FINISHPOSITION.HeaderText = "F-P"
            DGV_FINISHPOSITION.MinimumWidth = 12
            DGV_FINISHPOSITION.Name = "DGV_FINISHPOSITION"
            DGV_FINISHPOSITION.ReadOnly = True
            DGV_FINISHPOSITION.ToolTipText = "FINISH POSITION"
            DGV_FINISHPOSITION.Width = 105
            ' 
            ' DGV_WINS
            ' 
            DGV_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
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
            DGV_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
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
            ' UC_RESULTS
            ' 
            AutoScaleDimensions = New SizeF(14F, 33F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = SystemColors.Window
            Controls.Add(Panel1)
            Controls.Add(DGV_RESULTS)
            DoubleBuffered = True
            Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            ForeColor = SystemColors.WindowText
            Margin = New System.Windows.Forms.Padding(0)
            Name = "UC_RESULTS"
            Size = New Size(2030, 830)
            DGV_RESULTS_CMS.ResumeLayout(False)
            CType(DGV_RESULTS, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub
        Private WithEvents DGV_RESULTS_CMS As System.Windows.Forms.ContextMenuStrip
        Private WithEvents DGV_RESULTS_CMS_CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents DGV_RESULTS As System.Windows.Forms.DataGridView
        Private WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents DGV_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_BARRIER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_NAME As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents DGV_CLASS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGNAME As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_RACELENGTH As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_VENUE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WEATHER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_TRACK As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISHPOSITION As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WINS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLACES As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace