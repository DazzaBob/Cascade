Namespace ModelDevelopment.UserControls.ModelIterations
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_MODEL_ITERATIONS_STEP1
        Inherits System.Windows.Forms.UserControl

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
            Me.LBL_RACETHRESHOLD = New System.Windows.Forms.Label()
            Me.TB_RACES = New System.Windows.Forms.TextBox()
            Me.GB_THRESHOLDS = New System.Windows.Forms.GroupBox()
            Me.TB_RACESRETURNED = New System.Windows.Forms.TextBox()
            Me.LBL_RACES_RETURNED = New System.Windows.Forms.Label()
            Me.TB_PLACE_PERCENTAGE = New System.Windows.Forms.TextBox()
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD = New System.Windows.Forms.Label()
            Me.GB_EVAL_PERIOD = New System.Windows.Forms.GroupBox()
            Me.DTP_TO = New System.Windows.Forms.DateTimePicker()
            Me.DTP_FROM = New System.Windows.Forms.DateTimePicker()
            Me.LBL_EVAL_PERIOD_TO = New System.Windows.Forms.Label()
            Me.LBL_EVAL_PERIOD_FROM = New System.Windows.Forms.Label()
            Me.GB_MEETING_INFO = New System.Windows.Forms.GroupBox()
            Me.CMB_VENUE = New System.Windows.Forms.ComboBox()
            Me.CMB_TYPE = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.LBL_TYPE = New System.Windows.Forms.Label()
            Me.ButNext = New System.Windows.Forms.Button()
            Me.GB_THRESHOLDS.SuspendLayout()
            Me.GB_EVAL_PERIOD.SuspendLayout()
            Me.GB_MEETING_INFO.SuspendLayout()
            Me.SuspendLayout()
            '
            'LBL_RACETHRESHOLD
            '
            Me.LBL_RACETHRESHOLD.AutoSize = True
            Me.LBL_RACETHRESHOLD.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_RACETHRESHOLD.Location = New System.Drawing.Point(65, 15)
            Me.LBL_RACETHRESHOLD.Name = "LBL_RACETHRESHOLD"
            Me.LBL_RACETHRESHOLD.Size = New System.Drawing.Size(39, 13)
            Me.LBL_RACETHRESHOLD.TabIndex = 0
            Me.LBL_RACETHRESHOLD.Text = "RACES:"
            Me.LBL_RACETHRESHOLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TB_RACES
            '
            Me.TB_RACES.Location = New System.Drawing.Point(108, 12)
            Me.TB_RACES.MaxLength = 7
            Me.TB_RACES.Name = "TB_RACES"
            Me.TB_RACES.Size = New System.Drawing.Size(49, 21)
            Me.TB_RACES.TabIndex = 1
            Me.TB_RACES.Text = "500"
            Me.TB_RACES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'GB_THRESHOLDS
            '
            Me.GB_THRESHOLDS.Controls.Add(Me.TB_RACESRETURNED)
            Me.GB_THRESHOLDS.Controls.Add(Me.LBL_RACES_RETURNED)
            Me.GB_THRESHOLDS.Controls.Add(Me.TB_PLACE_PERCENTAGE)
            Me.GB_THRESHOLDS.Controls.Add(Me.LBL_PLACE_PERCENTAGE_THRESHOLD)
            Me.GB_THRESHOLDS.Controls.Add(Me.TB_RACES)
            Me.GB_THRESHOLDS.Controls.Add(Me.LBL_RACETHRESHOLD)
            Me.GB_THRESHOLDS.Location = New System.Drawing.Point(3, 3)
            Me.GB_THRESHOLDS.Name = "GB_THRESHOLDS"
            Me.GB_THRESHOLDS.Size = New System.Drawing.Size(163, 96)
            Me.GB_THRESHOLDS.TabIndex = 2
            Me.GB_THRESHOLDS.TabStop = False
            Me.GB_THRESHOLDS.Text = "THRESHOLDS"
            '
            'TB_RACESRETURNED
            '
            Me.TB_RACESRETURNED.Location = New System.Drawing.Point(108, 67)
            Me.TB_RACESRETURNED.MaxLength = 7
            Me.TB_RACESRETURNED.Name = "TB_RACESRETURNED"
            Me.TB_RACESRETURNED.Size = New System.Drawing.Size(49, 21)
            Me.TB_RACESRETURNED.TabIndex = 5
            Me.TB_RACESRETURNED.Text = "36"
            Me.TB_RACESRETURNED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'LBL_RACES_RETURNED
            '
            Me.LBL_RACES_RETURNED.AutoSize = True
            Me.LBL_RACES_RETURNED.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_RACES_RETURNED.Location = New System.Drawing.Point(10, 70)
            Me.LBL_RACES_RETURNED.Name = "LBL_RACES_RETURNED"
            Me.LBL_RACES_RETURNED.Size = New System.Drawing.Size(89, 13)
            Me.LBL_RACES_RETURNED.TabIndex = 4
            Me.LBL_RACES_RETURNED.Text = "RACES RETURNED:"
            Me.LBL_RACES_RETURNED.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TB_PLACE_PERCENTAGE
            '
            Me.TB_PLACE_PERCENTAGE.Location = New System.Drawing.Point(108, 39)
            Me.TB_PLACE_PERCENTAGE.MaxLength = 6
            Me.TB_PLACE_PERCENTAGE.Name = "TB_PLACE_PERCENTAGE"
            Me.TB_PLACE_PERCENTAGE.Size = New System.Drawing.Size(49, 21)
            Me.TB_PLACE_PERCENTAGE.TabIndex = 3
            Me.TB_PLACE_PERCENTAGE.Text = "80"
            Me.TB_PLACE_PERCENTAGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'LBL_PLACE_PERCENTAGE_THRESHOLD
            '
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD.AutoSize = True
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD.Location = New System.Drawing.Point(52, 42)
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD.Name = "LBL_PLACE_PERCENTAGE_THRESHOLD"
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD.Size = New System.Drawing.Size(47, 13)
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD.TabIndex = 2
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD.Text = "PLACE%:"
            Me.LBL_PLACE_PERCENTAGE_THRESHOLD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GB_EVAL_PERIOD
            '
            Me.GB_EVAL_PERIOD.Controls.Add(Me.DTP_TO)
            Me.GB_EVAL_PERIOD.Controls.Add(Me.DTP_FROM)
            Me.GB_EVAL_PERIOD.Controls.Add(Me.LBL_EVAL_PERIOD_TO)
            Me.GB_EVAL_PERIOD.Controls.Add(Me.LBL_EVAL_PERIOD_FROM)
            Me.GB_EVAL_PERIOD.Location = New System.Drawing.Point(183, 4)
            Me.GB_EVAL_PERIOD.Name = "GB_EVAL_PERIOD"
            Me.GB_EVAL_PERIOD.Size = New System.Drawing.Size(258, 71)
            Me.GB_EVAL_PERIOD.TabIndex = 3
            Me.GB_EVAL_PERIOD.TabStop = False
            Me.GB_EVAL_PERIOD.Text = "EVALUATION PERIOD"
            '
            'DTP_TO
            '
            Me.DTP_TO.Location = New System.Drawing.Point(51, 41)
            Me.DTP_TO.Name = "DTP_TO"
            Me.DTP_TO.Size = New System.Drawing.Size(200, 21)
            Me.DTP_TO.TabIndex = 4
            '
            'DTP_FROM
            '
            Me.DTP_FROM.Location = New System.Drawing.Point(51, 11)
            Me.DTP_FROM.Name = "DTP_FROM"
            Me.DTP_FROM.Size = New System.Drawing.Size(200, 21)
            Me.DTP_FROM.TabIndex = 3
            '
            'LBL_EVAL_PERIOD_TO
            '
            Me.LBL_EVAL_PERIOD_TO.AutoSize = True
            Me.LBL_EVAL_PERIOD_TO.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_EVAL_PERIOD_TO.Location = New System.Drawing.Point(22, 46)
            Me.LBL_EVAL_PERIOD_TO.Name = "LBL_EVAL_PERIOD_TO"
            Me.LBL_EVAL_PERIOD_TO.Size = New System.Drawing.Size(22, 13)
            Me.LBL_EVAL_PERIOD_TO.TabIndex = 2
            Me.LBL_EVAL_PERIOD_TO.Text = "TO:"
            Me.LBL_EVAL_PERIOD_TO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LBL_EVAL_PERIOD_FROM
            '
            Me.LBL_EVAL_PERIOD_FROM.AutoSize = True
            Me.LBL_EVAL_PERIOD_FROM.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_EVAL_PERIOD_FROM.Location = New System.Drawing.Point(6, 17)
            Me.LBL_EVAL_PERIOD_FROM.Name = "LBL_EVAL_PERIOD_FROM"
            Me.LBL_EVAL_PERIOD_FROM.Size = New System.Drawing.Size(38, 13)
            Me.LBL_EVAL_PERIOD_FROM.TabIndex = 1
            Me.LBL_EVAL_PERIOD_FROM.Text = "FROM:"
            Me.LBL_EVAL_PERIOD_FROM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'GB_MEETING_INFO
            '
            Me.GB_MEETING_INFO.Controls.Add(Me.CMB_VENUE)
            Me.GB_MEETING_INFO.Controls.Add(Me.CMB_TYPE)
            Me.GB_MEETING_INFO.Controls.Add(Me.Label3)
            Me.GB_MEETING_INFO.Controls.Add(Me.LBL_TYPE)
            Me.GB_MEETING_INFO.Location = New System.Drawing.Point(4, 106)
            Me.GB_MEETING_INFO.Name = "GB_MEETING_INFO"
            Me.GB_MEETING_INFO.Size = New System.Drawing.Size(198, 75)
            Me.GB_MEETING_INFO.TabIndex = 4
            Me.GB_MEETING_INFO.TabStop = False
            Me.GB_MEETING_INFO.Text = "MEETING INFORMATION"
            '
            'CMB_VENUE
            '
            Me.CMB_VENUE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CMB_VENUE.FormattingEnabled = True
            Me.CMB_VENUE.Location = New System.Drawing.Point(67, 44)
            Me.CMB_VENUE.Name = "CMB_VENUE"
            Me.CMB_VENUE.Size = New System.Drawing.Size(121, 21)
            Me.CMB_VENUE.TabIndex = 6
            '
            'CMB_TYPE
            '
            Me.CMB_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CMB_TYPE.FormattingEnabled = True
            Me.CMB_TYPE.Location = New System.Drawing.Point(67, 17)
            Me.CMB_TYPE.Name = "CMB_TYPE"
            Me.CMB_TYPE.Size = New System.Drawing.Size(121, 21)
            Me.CMB_TYPE.TabIndex = 4
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(20, 52)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(41, 13)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "VENUE:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LBL_TYPE
            '
            Me.LBL_TYPE.AutoSize = True
            Me.LBL_TYPE.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_TYPE.Location = New System.Drawing.Point(29, 20)
            Me.LBL_TYPE.Name = "LBL_TYPE"
            Me.LBL_TYPE.Size = New System.Drawing.Size(32, 13)
            Me.LBL_TYPE.TabIndex = 1
            Me.LBL_TYPE.Text = "TYPE:"
            Me.LBL_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'ButNext
            '
            Me.ButNext.Location = New System.Drawing.Point(366, 158)
            Me.ButNext.Name = "ButNext"
            Me.ButNext.Size = New System.Drawing.Size(75, 23)
            Me.ButNext.TabIndex = 5
            Me.ButNext.Text = "Next"
            Me.ButNext.UseVisualStyleBackColor = True
            '
            'UC_MODEL_ITERATIONS_STEP1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ButNext)
            Me.Controls.Add(Me.GB_MEETING_INFO)
            Me.Controls.Add(Me.GB_EVAL_PERIOD)
            Me.Controls.Add(Me.GB_THRESHOLDS)
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "UC_MODEL_ITERATIONS_STEP1"
            Me.Size = New System.Drawing.Size(450, 189)
            Me.GB_THRESHOLDS.ResumeLayout(False)
            Me.GB_THRESHOLDS.PerformLayout()
            Me.GB_EVAL_PERIOD.ResumeLayout(False)
            Me.GB_EVAL_PERIOD.PerformLayout()
            Me.GB_MEETING_INFO.ResumeLayout(False)
            Me.GB_MEETING_INFO.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents LBL_RACETHRESHOLD As System.Windows.Forms.Label
        Friend WithEvents TB_RACES As System.Windows.Forms.TextBox
        Friend WithEvents GB_THRESHOLDS As System.Windows.Forms.GroupBox
        Friend WithEvents TB_PLACE_PERCENTAGE As System.Windows.Forms.TextBox
        Friend WithEvents LBL_PLACE_PERCENTAGE_THRESHOLD As System.Windows.Forms.Label
        Friend WithEvents TB_RACESRETURNED As System.Windows.Forms.TextBox
        Friend WithEvents LBL_RACES_RETURNED As System.Windows.Forms.Label
        Friend WithEvents GB_EVAL_PERIOD As System.Windows.Forms.GroupBox
        Friend WithEvents DTP_TO As System.Windows.Forms.DateTimePicker
        Friend WithEvents DTP_FROM As System.Windows.Forms.DateTimePicker
        Friend WithEvents LBL_EVAL_PERIOD_TO As System.Windows.Forms.Label
        Friend WithEvents LBL_EVAL_PERIOD_FROM As System.Windows.Forms.Label
        Friend WithEvents GB_MEETING_INFO As System.Windows.Forms.GroupBox
        Friend WithEvents CMB_VENUE As System.Windows.Forms.ComboBox
        Friend WithEvents CMB_TYPE As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents LBL_TYPE As System.Windows.Forms.Label
        Friend WithEvents ButNext As System.Windows.Forms.Button

    End Class
End Namespace