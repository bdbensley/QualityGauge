<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.BTCancel = New System.Windows.Forms.Button()
        Me.TBMGaugeTypeID = New System.Windows.Forms.TextBox()
        Me.LBMGaugeTypeID = New System.Windows.Forms.Label()
        Me.BTModifyGauge = New System.Windows.Forms.Button()
        Me.LSBMGaugeType = New System.Windows.Forms.ListBox()
        Me.TBNGaugeDesc = New System.Windows.Forms.TextBox()
        Me.LBNGaugeDesc = New System.Windows.Forms.Label()
        Me.LBMGauge = New System.Windows.Forms.Label()
        Me.LBReorderPoint = New System.Windows.Forms.Label()
        Me.NUDReorderPoint = New System.Windows.Forms.NumericUpDown()
        CType(Me.NUDReorderPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(18, 206)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 44
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'TBMGaugeTypeID
        '
        Me.TBMGaugeTypeID.Enabled = False
        Me.TBMGaugeTypeID.Location = New System.Drawing.Point(102, 120)
        Me.TBMGaugeTypeID.Name = "TBMGaugeTypeID"
        Me.TBMGaugeTypeID.Size = New System.Drawing.Size(27, 20)
        Me.TBMGaugeTypeID.TabIndex = 43
        '
        'LBMGaugeTypeID
        '
        Me.LBMGaugeTypeID.AutoSize = True
        Me.LBMGaugeTypeID.Location = New System.Drawing.Point(13, 123)
        Me.LBMGaugeTypeID.Name = "LBMGaugeTypeID"
        Me.LBMGaugeTypeID.Size = New System.Drawing.Size(83, 13)
        Me.LBMGaugeTypeID.TabIndex = 42
        Me.LBMGaugeTypeID.Text = "Gauge Type ID:"
        '
        'BTModifyGauge
        '
        Me.BTModifyGauge.Location = New System.Drawing.Point(237, 206)
        Me.BTModifyGauge.Name = "BTModifyGauge"
        Me.BTModifyGauge.Size = New System.Drawing.Size(75, 23)
        Me.BTModifyGauge.TabIndex = 41
        Me.BTModifyGauge.Text = "Save"
        Me.BTModifyGauge.UseVisualStyleBackColor = True
        '
        'LSBMGaugeType
        '
        Me.LSBMGaugeType.FormattingEnabled = True
        Me.LSBMGaugeType.Location = New System.Drawing.Point(60, 12)
        Me.LSBMGaugeType.Name = "LSBMGaugeType"
        Me.LSBMGaugeType.Size = New System.Drawing.Size(175, 82)
        Me.LSBMGaugeType.TabIndex = 40
        '
        'TBNGaugeDesc
        '
        Me.TBNGaugeDesc.Location = New System.Drawing.Point(142, 146)
        Me.TBNGaugeDesc.Name = "TBNGaugeDesc"
        Me.TBNGaugeDesc.Size = New System.Drawing.Size(194, 20)
        Me.TBNGaugeDesc.TabIndex = 37
        '
        'LBNGaugeDesc
        '
        Me.LBNGaugeDesc.AutoSize = True
        Me.LBNGaugeDesc.Location = New System.Drawing.Point(13, 149)
        Me.LBNGaugeDesc.Name = "LBNGaugeDesc"
        Me.LBNGaugeDesc.Size = New System.Drawing.Size(123, 13)
        Me.LBNGaugeDesc.TabIndex = 36
        Me.LBNGaugeDesc.Text = "New Gauge Description:"
        '
        'LBMGauge
        '
        Me.LBMGauge.AutoSize = True
        Me.LBMGauge.Location = New System.Drawing.Point(12, 12)
        Me.LBMGauge.Name = "LBMGauge"
        Me.LBMGauge.Size = New System.Drawing.Size(42, 13)
        Me.LBMGauge.TabIndex = 35
        Me.LBMGauge.Text = "Gauge:"
        '
        'LBReorderPoint
        '
        Me.LBReorderPoint.AutoSize = True
        Me.LBReorderPoint.Location = New System.Drawing.Point(12, 174)
        Me.LBReorderPoint.Name = "LBReorderPoint"
        Me.LBReorderPoint.Size = New System.Drawing.Size(75, 13)
        Me.LBReorderPoint.TabIndex = 45
        Me.LBReorderPoint.Text = "Reorder Point:"
        '
        'NUDReorderPoint
        '
        Me.NUDReorderPoint.Location = New System.Drawing.Point(93, 172)
        Me.NUDReorderPoint.Name = "NUDReorderPoint"
        Me.NUDReorderPoint.Size = New System.Drawing.Size(56, 20)
        Me.NUDReorderPoint.TabIndex = 47
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 247)
        Me.Controls.Add(Me.NUDReorderPoint)
        Me.Controls.Add(Me.LBReorderPoint)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.TBMGaugeTypeID)
        Me.Controls.Add(Me.LBMGaugeTypeID)
        Me.Controls.Add(Me.BTModifyGauge)
        Me.Controls.Add(Me.LSBMGaugeType)
        Me.Controls.Add(Me.TBNGaugeDesc)
        Me.Controls.Add(Me.LBNGaugeDesc)
        Me.Controls.Add(Me.LBMGauge)
        Me.Name = "Form2"
        Me.Text = "Modify Gauge Type"
        CType(Me.NUDReorderPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTCancel As System.Windows.Forms.Button
    Friend WithEvents TBMGaugeTypeID As System.Windows.Forms.TextBox
    Friend WithEvents LBMGaugeTypeID As System.Windows.Forms.Label
    Friend WithEvents BTModifyGauge As System.Windows.Forms.Button
    Friend WithEvents LSBMGaugeType As System.Windows.Forms.ListBox
    Friend WithEvents TBNGaugeDesc As System.Windows.Forms.TextBox
    Friend WithEvents LBNGaugeDesc As System.Windows.Forms.Label
    Friend WithEvents LBMGauge As System.Windows.Forms.Label
    Friend WithEvents LBReorderPoint As System.Windows.Forms.Label
    Friend WithEvents NUDReorderPoint As System.Windows.Forms.NumericUpDown
End Class
