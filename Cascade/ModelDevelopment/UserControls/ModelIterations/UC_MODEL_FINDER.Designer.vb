Namespace ModelDevelopment.UserControls.ModelIterations
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_MODEL_FINDER
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                    If Not MY_STATUSSTRIP Is Nothing Then MY_STATUSSTRIP.Dispose() : MY_STATUSSTRIP = Nothing
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
            Me.LBL_PROCESSING = New System.Windows.Forms.Label()
            Me.PB_ITERATIONS = New System.Windows.Forms.ProgressBar()
            Me.LBL_ITERATION_PROGRESS = New System.Windows.Forms.Label()
            Me.ButFinish = New System.Windows.Forms.Button()
            Me.LBL_UPDATE = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'LBL_PROCESSING
            '
            Me.LBL_PROCESSING.AutoSize = True
            Me.LBL_PROCESSING.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_PROCESSING.Location = New System.Drawing.Point(47, 9)
            Me.LBL_PROCESSING.Name = "LBL_PROCESSING"
            Me.LBL_PROCESSING.Size = New System.Drawing.Size(59, 13)
            Me.LBL_PROCESSING.TabIndex = 0
            Me.LBL_PROCESSING.Text = "Processing:"
            '
            'PB_ITERATIONS
            '
            Me.PB_ITERATIONS.Location = New System.Drawing.Point(120, 42)
            Me.PB_ITERATIONS.Name = "PB_ITERATIONS"
            Me.PB_ITERATIONS.Size = New System.Drawing.Size(200, 23)
            Me.PB_ITERATIONS.Step = 1
            Me.PB_ITERATIONS.Style = System.Windows.Forms.ProgressBarStyle.Continuous
            Me.PB_ITERATIONS.TabIndex = 1
            '
            'LBL_ITERATION_PROGRESS
            '
            Me.LBL_ITERATION_PROGRESS.AutoSize = True
            Me.LBL_ITERATION_PROGRESS.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_ITERATION_PROGRESS.Location = New System.Drawing.Point(17, 52)
            Me.LBL_ITERATION_PROGRESS.Name = "LBL_ITERATION_PROGRESS"
            Me.LBL_ITERATION_PROGRESS.Size = New System.Drawing.Size(91, 13)
            Me.LBL_ITERATION_PROGRESS.TabIndex = 2
            Me.LBL_ITERATION_PROGRESS.Text = "Iteration Progress:"
            '
            'ButFinish
            '
            Me.ButFinish.Location = New System.Drawing.Point(242, 71)
            Me.ButFinish.Name = "ButFinish"
            Me.ButFinish.Size = New System.Drawing.Size(75, 23)
            Me.ButFinish.TabIndex = 5
            Me.ButFinish.Text = "Finish"
            Me.ButFinish.UseVisualStyleBackColor = True
            Me.ButFinish.Visible = False
            '
            'LBL_UPDATE
            '
            Me.LBL_UPDATE.Location = New System.Drawing.Point(117, 9)
            Me.LBL_UPDATE.Name = "LBL_UPDATE"
            Me.LBL_UPDATE.Size = New System.Drawing.Size(200, 17)
            Me.LBL_UPDATE.TabIndex = 6
            Me.LBL_UPDATE.Text = "Finding Records"
            '
            'UC_MODEL_FINDER
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LBL_UPDATE)
            Me.Controls.Add(Me.ButFinish)
            Me.Controls.Add(Me.LBL_ITERATION_PROGRESS)
            Me.Controls.Add(Me.PB_ITERATIONS)
            Me.Controls.Add(Me.LBL_PROCESSING)
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "UC_MODEL_FINDER"
            Me.Size = New System.Drawing.Size(320, 123)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LBL_PROCESSING As System.Windows.Forms.Label
        Friend WithEvents PB_ITERATIONS As System.Windows.Forms.ProgressBar
        Friend WithEvents LBL_ITERATION_PROGRESS As System.Windows.Forms.Label
        Friend WithEvents ButFinish As System.Windows.Forms.Button
        Friend WithEvents LBL_UPDATE As System.Windows.Forms.Label

    End Class
End Namespace