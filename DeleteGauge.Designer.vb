<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteGauge
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
        Me.TBDelGaugeTypeID = New System.Windows.Forms.TextBox()
        Me.LBDelGaugeTypeID = New System.Windows.Forms.Label()
        Me.BTDelGauge = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBDelComment = New System.Windows.Forms.TextBox()
        Me.LBDelGaugeComment = New System.Windows.Forms.Label()
        Me.TBDelGaugePurchaseDate = New System.Windows.Forms.TextBox()
        Me.LBDelGaugePurchaseDate = New System.Windows.Forms.Label()
        Me.LBDelGaugeType = New System.Windows.Forms.Label()
        Me.LBDelGaugeID = New System.Windows.Forms.Label()
        Me.BTCancel = New System.Windows.Forms.Button()
        Me.LSBDelGaugeID = New System.Windows.Forms.ListBox()
        Me.TBDelGaugeType = New System.Windows.Forms.TextBox()
        Me.LBDelGauge = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBDelGaugeTypeID
        '
        Me.TBDelGaugeTypeID.Location = New System.Drawing.Point(138, 100)
        Me.TBDelGaugeTypeID.Name = "TBDelGaugeTypeID"
        Me.TBDelGaugeTypeID.Size = New System.Drawing.Size(174, 20)
        Me.TBDelGaugeTypeID.TabIndex = 28
        '
        'LBDelGaugeTypeID
        '
        Me.LBDelGaugeTypeID.AutoSize = True
        Me.LBDelGaugeTypeID.Location = New System.Drawing.Point(15, 103)
        Me.LBDelGaugeTypeID.Name = "LBDelGaugeTypeID"
        Me.LBDelGaugeTypeID.Size = New System.Drawing.Size(83, 13)
        Me.LBDelGaugeTypeID.TabIndex = 27
        Me.LBDelGaugeTypeID.Text = "Gauge Type ID:"
        '
        'BTDelGauge
        '
        Me.BTDelGauge.Location = New System.Drawing.Point(224, 245)
        Me.BTDelGauge.Name = "BTDelGauge"
        Me.BTDelGauge.Size = New System.Drawing.Size(89, 23)
        Me.BTDelGauge.TabIndex = 26
        Me.BTDelGauge.Text = "Delete Gauge"
        Me.BTDelGauge.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(3, -15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "The gauge type must exist before adding a new gauge!"
        '
        'TBDelComment
        '
        Me.TBDelComment.Location = New System.Drawing.Point(138, 182)
        Me.TBDelComment.MaxLength = 254
        Me.TBDelComment.Multiline = True
        Me.TBDelComment.Name = "TBDelComment"
        Me.TBDelComment.Size = New System.Drawing.Size(175, 57)
        Me.TBDelComment.TabIndex = 23
        '
        'LBDelGaugeComment
        '
        Me.LBDelGaugeComment.AutoSize = True
        Me.LBDelGaugeComment.Location = New System.Drawing.Point(16, 185)
        Me.LBDelGaugeComment.Name = "LBDelGaugeComment"
        Me.LBDelGaugeComment.Size = New System.Drawing.Size(111, 13)
        Me.LBDelGaugeComment.TabIndex = 22
        Me.LBDelGaugeComment.Text = "Comment (254 Chars):"
        '
        'TBDelGaugePurchaseDate
        '
        Me.TBDelGaugePurchaseDate.Location = New System.Drawing.Point(138, 156)
        Me.TBDelGaugePurchaseDate.Name = "TBDelGaugePurchaseDate"
        Me.TBDelGaugePurchaseDate.Size = New System.Drawing.Size(175, 20)
        Me.TBDelGaugePurchaseDate.TabIndex = 21
        '
        'LBDelGaugePurchaseDate
        '
        Me.LBDelGaugePurchaseDate.AutoSize = True
        Me.LBDelGaugePurchaseDate.Location = New System.Drawing.Point(16, 159)
        Me.LBDelGaugePurchaseDate.Name = "LBDelGaugePurchaseDate"
        Me.LBDelGaugePurchaseDate.Size = New System.Drawing.Size(116, 13)
        Me.LBDelGaugePurchaseDate.TabIndex = 20
        Me.LBDelGaugePurchaseDate.Text = "Gauge Purchase Date:"
        '
        'LBDelGaugeType
        '
        Me.LBDelGaugeType.AutoSize = True
        Me.LBDelGaugeType.Location = New System.Drawing.Point(15, 130)
        Me.LBDelGaugeType.Name = "LBDelGaugeType"
        Me.LBDelGaugeType.Size = New System.Drawing.Size(69, 13)
        Me.LBDelGaugeType.TabIndex = 19
        Me.LBDelGaugeType.Text = "Gauge Type:"
        '
        'LBDelGaugeID
        '
        Me.LBDelGaugeID.AutoSize = True
        Me.LBDelGaugeID.Location = New System.Drawing.Point(13, 14)
        Me.LBDelGaugeID.Name = "LBDelGaugeID"
        Me.LBDelGaugeID.Size = New System.Drawing.Size(56, 13)
        Me.LBDelGaugeID.TabIndex = 15
        Me.LBDelGaugeID.Text = "Gauge ID:"
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(18, 245)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 29
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'LSBDelGaugeID
        '
        Me.LSBDelGaugeID.FormattingEnabled = True
        Me.LSBDelGaugeID.Location = New System.Drawing.Point(75, 12)
        Me.LSBDelGaugeID.Name = "LSBDelGaugeID"
        Me.LSBDelGaugeID.Size = New System.Drawing.Size(120, 82)
        Me.LSBDelGaugeID.TabIndex = 30
        '
        'TBDelGaugeType
        '
        Me.TBDelGaugeType.Location = New System.Drawing.Point(138, 127)
        Me.TBDelGaugeType.Name = "TBDelGaugeType"
        Me.TBDelGaugeType.Size = New System.Drawing.Size(174, 20)
        Me.TBDelGaugeType.TabIndex = 31
        '
        'LBDelGauge
        '
        Me.LBDelGauge.AutoSize = True
        Me.LBDelGauge.Location = New System.Drawing.Point(210, 12)
        Me.LBDelGauge.Name = "LBDelGauge"
        Me.LBDelGauge.Size = New System.Drawing.Size(0, 13)
        Me.LBDelGauge.TabIndex = 32
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 279)
        Me.Controls.Add(Me.LBDelGauge)
        Me.Controls.Add(Me.TBDelGaugeType)
        Me.Controls.Add(Me.LSBDelGaugeID)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.TBDelGaugeTypeID)
        Me.Controls.Add(Me.LBDelGaugeTypeID)
        Me.Controls.Add(Me.BTDelGauge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBDelComment)
        Me.Controls.Add(Me.LBDelGaugeComment)
        Me.Controls.Add(Me.TBDelGaugePurchaseDate)
        Me.Controls.Add(Me.LBDelGaugePurchaseDate)
        Me.Controls.Add(Me.LBDelGaugeType)
        Me.Controls.Add(Me.LBDelGaugeID)
        Me.Name = "Form8"
        Me.Text = "Delete Gauge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBDelGaugeTypeID As System.Windows.Forms.TextBox
    Friend WithEvents LBDelGaugeTypeID As System.Windows.Forms.Label
    Friend WithEvents BTDelGauge As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBDelComment As System.Windows.Forms.TextBox
    Friend WithEvents LBDelGaugeComment As System.Windows.Forms.Label
    Friend WithEvents TBDelGaugePurchaseDate As System.Windows.Forms.TextBox
    Friend WithEvents LBDelGaugePurchaseDate As System.Windows.Forms.Label
    Friend WithEvents LBDelGaugeType As System.Windows.Forms.Label
    Friend WithEvents LBDelGaugeID As System.Windows.Forms.Label
    Friend WithEvents BTCancel As System.Windows.Forms.Button
    Friend WithEvents LSBDelGaugeID As System.Windows.Forms.ListBox
    Friend WithEvents TBDelGaugeType As System.Windows.Forms.TextBox
    Friend WithEvents LBDelGauge As System.Windows.Forms.Label
End Class
