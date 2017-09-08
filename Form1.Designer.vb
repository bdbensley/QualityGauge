<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyGauge
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
        Me.TBMComment = New System.Windows.Forms.TextBox()
        Me.LBMGaugeComment = New System.Windows.Forms.Label()
        Me.TBMGaugePurchaseDate = New System.Windows.Forms.TextBox()
        Me.LBMGaugePurchaseDate = New System.Windows.Forms.Label()
        Me.LBMGaugeType = New System.Windows.Forms.Label()
        Me.LBMGaugeID = New System.Windows.Forms.Label()
        Me.LSBMGauge = New System.Windows.Forms.ListBox()
        Me.TBNGaugeTypeID = New System.Windows.Forms.TextBox()
        Me.LBNGaugeTypeID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(14, 311)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 30
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'TBMGaugeTypeID
        '
        Me.TBMGaugeTypeID.Location = New System.Drawing.Point(100, 120)
        Me.TBMGaugeTypeID.Name = "TBMGaugeTypeID"
        Me.TBMGaugeTypeID.Size = New System.Drawing.Size(27, 20)
        Me.TBMGaugeTypeID.TabIndex = 29
        '
        'LBMGaugeTypeID
        '
        Me.LBMGaugeTypeID.AutoSize = True
        Me.LBMGaugeTypeID.Location = New System.Drawing.Point(11, 123)
        Me.LBMGaugeTypeID.Name = "LBMGaugeTypeID"
        Me.LBMGaugeTypeID.Size = New System.Drawing.Size(83, 13)
        Me.LBMGaugeTypeID.TabIndex = 28
        Me.LBMGaugeTypeID.Text = "Gauge Type ID:"
        '
        'BTModifyGauge
        '
        Me.BTModifyGauge.Location = New System.Drawing.Point(233, 311)
        Me.BTModifyGauge.Name = "BTModifyGauge"
        Me.BTModifyGauge.Size = New System.Drawing.Size(75, 23)
        Me.BTModifyGauge.TabIndex = 27
        Me.BTModifyGauge.Text = "Save"
        Me.BTModifyGauge.UseVisualStyleBackColor = True
        '
        'LSBMGaugeType
        '
        Me.LSBMGaugeType.FormattingEnabled = True
        Me.LSBMGaugeType.Location = New System.Drawing.Point(134, 150)
        Me.LSBMGaugeType.Name = "LSBMGaugeType"
        Me.LSBMGaugeType.Size = New System.Drawing.Size(175, 56)
        Me.LSBMGaugeType.TabIndex = 26
        '
        'TBMComment
        '
        Me.TBMComment.Location = New System.Drawing.Point(133, 248)
        Me.TBMComment.MaxLength = 254
        Me.TBMComment.Multiline = True
        Me.TBMComment.Name = "TBMComment"
        Me.TBMComment.Size = New System.Drawing.Size(175, 57)
        Me.TBMComment.TabIndex = 24
        '
        'LBMGaugeComment
        '
        Me.LBMGaugeComment.AutoSize = True
        Me.LBMGaugeComment.Location = New System.Drawing.Point(11, 251)
        Me.LBMGaugeComment.Name = "LBMGaugeComment"
        Me.LBMGaugeComment.Size = New System.Drawing.Size(111, 13)
        Me.LBMGaugeComment.TabIndex = 23
        Me.LBMGaugeComment.Text = "Comment (254 Chars):"
        '
        'TBMGaugePurchaseDate
        '
        Me.TBMGaugePurchaseDate.Location = New System.Drawing.Point(133, 222)
        Me.TBMGaugePurchaseDate.Name = "TBMGaugePurchaseDate"
        Me.TBMGaugePurchaseDate.Size = New System.Drawing.Size(175, 20)
        Me.TBMGaugePurchaseDate.TabIndex = 22
        '
        'LBMGaugePurchaseDate
        '
        Me.LBMGaugePurchaseDate.AutoSize = True
        Me.LBMGaugePurchaseDate.Location = New System.Drawing.Point(11, 225)
        Me.LBMGaugePurchaseDate.Name = "LBMGaugePurchaseDate"
        Me.LBMGaugePurchaseDate.Size = New System.Drawing.Size(116, 13)
        Me.LBMGaugePurchaseDate.TabIndex = 21
        Me.LBMGaugePurchaseDate.Text = "Gauge Purchase Date:"
        '
        'LBMGaugeType
        '
        Me.LBMGaugeType.AutoSize = True
        Me.LBMGaugeType.Location = New System.Drawing.Point(11, 150)
        Me.LBMGaugeType.Name = "LBMGaugeType"
        Me.LBMGaugeType.Size = New System.Drawing.Size(69, 13)
        Me.LBMGaugeType.TabIndex = 20
        Me.LBMGaugeType.Text = "Gauge Type:"
        '
        'LBMGaugeID
        '
        Me.LBMGaugeID.AutoSize = True
        Me.LBMGaugeID.Location = New System.Drawing.Point(10, 14)
        Me.LBMGaugeID.Name = "LBMGaugeID"
        Me.LBMGaugeID.Size = New System.Drawing.Size(56, 13)
        Me.LBMGaugeID.TabIndex = 16
        Me.LBMGaugeID.Text = "Gauge ID:"
        '
        'LSBMGauge
        '
        Me.LSBMGauge.FormattingEnabled = True
        Me.LSBMGauge.Location = New System.Drawing.Point(72, 12)
        Me.LSBMGauge.Name = "LSBMGauge"
        Me.LSBMGauge.Size = New System.Drawing.Size(120, 95)
        Me.LSBMGauge.TabIndex = 31
        '
        'TBNGaugeTypeID
        '
        Me.TBNGaugeTypeID.Location = New System.Drawing.Point(264, 120)
        Me.TBNGaugeTypeID.Name = "TBNGaugeTypeID"
        Me.TBNGaugeTypeID.Size = New System.Drawing.Size(27, 20)
        Me.TBNGaugeTypeID.TabIndex = 33
        '
        'LBNGaugeTypeID
        '
        Me.LBNGaugeTypeID.AutoSize = True
        Me.LBNGaugeTypeID.Location = New System.Drawing.Point(150, 123)
        Me.LBNGaugeTypeID.Name = "LBNGaugeTypeID"
        Me.LBNGaugeTypeID.Size = New System.Drawing.Size(108, 13)
        Me.LBNGaugeTypeID.TabIndex = 32
        Me.LBNGaugeTypeID.Text = "New Gauge Type ID:"
        '
        'ModifyGauge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 343)
        Me.Controls.Add(Me.TBNGaugeTypeID)
        Me.Controls.Add(Me.LBNGaugeTypeID)
        Me.Controls.Add(Me.LSBMGauge)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.TBMGaugeTypeID)
        Me.Controls.Add(Me.LBMGaugeTypeID)
        Me.Controls.Add(Me.BTModifyGauge)
        Me.Controls.Add(Me.LSBMGaugeType)
        Me.Controls.Add(Me.TBMComment)
        Me.Controls.Add(Me.LBMGaugeComment)
        Me.Controls.Add(Me.TBMGaugePurchaseDate)
        Me.Controls.Add(Me.LBMGaugePurchaseDate)
        Me.Controls.Add(Me.LBMGaugeType)
        Me.Controls.Add(Me.LBMGaugeID)
        Me.Name = "ModifyGauge"
        Me.Text = "Modify Gauge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTCancel As System.Windows.Forms.Button
    Friend WithEvents TBMGaugeTypeID As System.Windows.Forms.TextBox
    Friend WithEvents LBMGaugeTypeID As System.Windows.Forms.Label
    Friend WithEvents BTModifyGauge As System.Windows.Forms.Button
    Friend WithEvents LSBMGaugeType As System.Windows.Forms.ListBox
    Friend WithEvents TBMComment As System.Windows.Forms.TextBox
    Friend WithEvents LBMGaugeComment As System.Windows.Forms.Label
    Friend WithEvents TBMGaugePurchaseDate As System.Windows.Forms.TextBox
    Friend WithEvents LBMGaugePurchaseDate As System.Windows.Forms.Label
    Friend WithEvents LBMGaugeType As System.Windows.Forms.Label
    Friend WithEvents LBMGaugeID As System.Windows.Forms.Label
    Friend WithEvents LSBMGauge As System.Windows.Forms.ListBox
    Friend WithEvents TBNGaugeTypeID As System.Windows.Forms.TextBox
    Friend WithEvents LBNGaugeTypeID As System.Windows.Forms.Label
End Class
