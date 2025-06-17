Namespace DisplayRace
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_MODELS
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                    If Not MY_POPUP Is Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
                    If Not MY_MODELS_METADATA Is Nothing Then MY_MODELS_METADATA.Dispose() : MY_MODELS_METADATA = Nothing
                    If Not MY_CONNECTION Is Nothing Then MY_CONNECTION.Dispose() : MY_CONNECTION = Nothing
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.DGV = New System.Windows.Forms.DataGridView()
            Me.DGV_DETAIL = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.DGV_NUMBEROFRACES = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_BET_WIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_BET_PLACE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DVG_WINPERCENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLACEPERCENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLWIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLPLACE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLWINPERCENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLPLACEPERCENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DGV
            '
            Me.DGV.AllowUserToAddRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV.BackgroundColor = System.Drawing.SystemColors.Window
            Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_DETAIL, Me.DGV_NUMBEROFRACES, Me.DGV_BET_WIN, Me.DGV_BET_PLACE, Me.DVG_WINPERCENT, Me.DGV_PLACEPERCENT, Me.DGV_PLWIN, Me.DGV_PLPLACE, Me.DGV_PLWINPERCENT, Me.DGV_PLPLACEPERCENT})
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV.DefaultCellStyle = DataGridViewCellStyle13
            Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV.Location = New System.Drawing.Point(0, 0)
            Me.DGV.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV.Name = "DGV"
            Me.DGV.ReadOnly = True
            Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle15
            Me.DGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Window
            Me.DGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV.RowTemplate.Height = 24
            Me.DGV.RowTemplate.ReadOnly = True
            Me.DGV.Size = New System.Drawing.Size(620, 295)
            Me.DGV.TabIndex = 1023
            '
            'DGV_DETAIL
            '
            Me.DGV_DETAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_DETAIL.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_DETAIL.HeaderText = "NAME"
            Me.DGV_DETAIL.Name = "DGV_DETAIL"
            Me.DGV_DETAIL.ReadOnly = True
            Me.DGV_DETAIL.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_DETAIL.ToolTipText = "RUNNER NAME"
            '
            'DGV_NUMBEROFRACES
            '
            Me.DGV_NUMBEROFRACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_NUMBEROFRACES.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_NUMBEROFRACES.HeaderText = "#"
            Me.DGV_NUMBEROFRACES.Name = "DGV_NUMBEROFRACES"
            Me.DGV_NUMBEROFRACES.ReadOnly = True
            Me.DGV_NUMBEROFRACES.ToolTipText = "NUMBER OF RACES"
            Me.DGV_NUMBEROFRACES.Width = 37
            '
            'DGV_BET_WIN
            '
            Me.DGV_BET_WIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.Format = "C2"
            Me.DGV_BET_WIN.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_BET_WIN.HeaderText = "B-WIN"
            Me.DGV_BET_WIN.Name = "DGV_BET_WIN"
            Me.DGV_BET_WIN.ReadOnly = True
            Me.DGV_BET_WIN.ToolTipText = "BET WIN"
            Me.DGV_BET_WIN.Width = 61
            '
            'DGV_BET_PLACE
            '
            Me.DGV_BET_PLACE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.Format = "C2"
            Me.DGV_BET_PLACE.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_BET_PLACE.HeaderText = "B-PLACE"
            Me.DGV_BET_PLACE.Name = "DGV_BET_PLACE"
            Me.DGV_BET_PLACE.ReadOnly = True
            Me.DGV_BET_PLACE.ToolTipText = "BET PLACE"
            Me.DGV_BET_PLACE.Width = 69
            '
            'DVG_WINPERCENT
            '
            Me.DVG_WINPERCENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle7.Format = "N2"
            Me.DVG_WINPERCENT.DefaultCellStyle = DataGridViewCellStyle7
            Me.DVG_WINPERCENT.HeaderText = "WIN%"
            Me.DVG_WINPERCENT.Name = "DVG_WINPERCENT"
            Me.DVG_WINPERCENT.ReadOnly = True
            Me.DVG_WINPERCENT.Width = 60
            '
            'DGV_PLACEPERCENT
            '
            Me.DGV_PLACEPERCENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle8.Format = "N2"
            Me.DGV_PLACEPERCENT.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_PLACEPERCENT.HeaderText = "PLACE%"
            Me.DGV_PLACEPERCENT.Name = "DGV_PLACEPERCENT"
            Me.DGV_PLACEPERCENT.ReadOnly = True
            Me.DGV_PLACEPERCENT.Width = 68
            '
            'DGV_PLWIN
            '
            Me.DGV_PLWIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.Format = "N2"
            Me.DGV_PLWIN.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_PLWIN.HeaderText = "P/L (WIN)"
            Me.DGV_PLWIN.Name = "DGV_PLWIN"
            Me.DGV_PLWIN.ReadOnly = True
            Me.DGV_PLWIN.Width = 74
            '
            'DGV_PLPLACE
            '
            Me.DGV_PLPLACE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle10.Format = "N2"
            Me.DGV_PLPLACE.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_PLPLACE.HeaderText = "P/L (PLC)"
            Me.DGV_PLPLACE.Name = "DGV_PLPLACE"
            Me.DGV_PLPLACE.ReadOnly = True
            Me.DGV_PLPLACE.Width = 71
            '
            'DGV_PLWINPERCENT
            '
            Me.DGV_PLWINPERCENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle11.Format = "N2"
            Me.DGV_PLWINPERCENT.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_PLWINPERCENT.HeaderText = "P/L (WIN%)"
            Me.DGV_PLWINPERCENT.Name = "DGV_PLWINPERCENT"
            Me.DGV_PLWINPERCENT.ReadOnly = True
            Me.DGV_PLWINPERCENT.Width = 82
            '
            'DGV_PLPLACEPERCENT
            '
            Me.DGV_PLPLACEPERCENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle12.Format = "N2"
            Me.DGV_PLPLACEPERCENT.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_PLPLACEPERCENT.HeaderText = "P/L (PLC%)"
            Me.DGV_PLPLACEPERCENT.Name = "DGV_PLPLACEPERCENT"
            Me.DGV_PLPLACEPERCENT.ReadOnly = True
            Me.DGV_PLPLACEPERCENT.Width = 79
            '
            'UC_MODELS
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.DGV)
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Name = "UC_MODELS"
            Me.Size = New System.Drawing.Size(620, 295)
            CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DGV As System.Windows.Forms.DataGridView
        Friend WithEvents DGV_DETAIL As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents DGV_NUMBEROFRACES As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_BET_WIN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_BET_PLACE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DVG_WINPERCENT As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLACEPERCENT As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLWIN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLPLACE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLWINPERCENT As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLPLACEPERCENT As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace