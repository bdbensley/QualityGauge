<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGauge
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
        Me.LBGaugeID = New System.Windows.Forms.Label()
        Me.TBGaugeID = New System.Windows.Forms.TextBox()
        Me.BTCheckGaugeAvailable = New System.Windows.Forms.Button()
        Me.TBGaugeAvailable = New System.Windows.Forms.TextBox()
        Me.LBNGaugeType = New System.Windows.Forms.Label()
        Me.TBNGaugePurchaseDate = New System.Windows.Forms.TextBox()
        Me.LBNGaugePurchaseDate = New System.Windows.Forms.Label()
        Me.TBNComment = New System.Windows.Forms.TextBox()
        Me.LBNGaugeComment = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LSBNGaugeType = New System.Windows.Forms.ListBox()
        Me.BTSaveNewGauge = New System.Windows.Forms.Button()
        Me.TBNGaugeTypeID = New System.Windows.Forms.TextBox()
        Me.LBNGaugeTypeID = New System.Windows.Forms.Label()
        Me.BTCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBGaugeID
        '
        Me.LBGaugeID.AutoSize = True
        Me.LBGaugeID.Location = New System.Drawing.Point(14, 35)
        Me.LBGaugeID.Name = "LBGaugeID"
        Me.LBGaugeID.Size = New System.Drawing.Size(56, 13)
        Me.LBGaugeID.TabIndex = 0
        Me.LBGaugeID.Text = "Gauge ID:"
        '
        'TBGaugeID
        '
        Me.TBGaugeID.Location = New System.Drawing.Point(76, 32)
        Me.TBGaugeID.Name = "TBGaugeID"
        Me.TBGaugeID.Size = New System.Drawing.Size(100, 20)
        Me.TBGaugeID.TabIndex = 1
        '
        'BTCheckGaugeAvailable
        '
        Me.BTCheckGaugeAvailable.Location = New System.Drawing.Point(193, 30)
        Me.BTCheckGaugeAvailable.Name = "BTCheckGaugeAvailable"
        Me.BTCheckGaugeAvailable.Size = New System.Drawing.Size(119, 23)
        Me.BTCheckGaugeAvailable.TabIndex = 2
        Me.BTCheckGaugeAvailable.Text = "Check Available"
        Me.BTCheckGaugeAvailable.UseVisualStyleBackColor = True
        '
        'TBGaugeAvailable
        '
        Me.TBGaugeAvailable.CausesValidation = False
        Me.TBGaugeAvailable.Location = New System.Drawing.Point(194, 59)
        Me.TBGaugeAvailable.Name = "TBGaugeAvailable"
        Me.TBGaugeAvailable.ReadOnly = True
        Me.TBGaugeAvailable.Size = New System.Drawing.Size(119, 20)
        Me.TBGaugeAvailable.TabIndex = 3
        Me.TBGaugeAvailable.TabStop = False
        '
        'LBNGaugeType
        '
        Me.LBNGaugeType.AutoSize = True
        Me.LBNGaugeType.Location = New System.Drawing.Point(15, 118)
        Me.LBNGaugeType.Name = "LBNGaugeType"
        Me.LBNGaugeType.Size = New System.Drawing.Size(69, 13)
        Me.LBNGaugeType.TabIndex = 4
        Me.LBNGaugeType.Text = "Gauge Type:"
        '
        'TBNGaugePurchaseDate
        '
        Me.TBNGaugePurchaseDate.Location = New System.Drawing.Point(137, 190)
        Me.TBNGaugePurchaseDate.Name = "TBNGaugePurchaseDate"
        Me.TBNGaugePurchaseDate.Size = New System.Drawing.Size(175, 20)
        Me.TBNGaugePurchaseDate.TabIndex = 7
        '
        'LBNGaugePurchaseDate
        '
        Me.LBNGaugePurchaseDate.AutoSize = True
        Me.LBNGaugePurchaseDate.Location = New System.Drawing.Point(15, 193)
        Me.LBNGaugePurchaseDate.Name = "LBNGaugePurchaseDate"
        Me.LBNGaugePurchaseDate.Size = New System.Drawing.Size(116, 13)
        Me.LBNGaugePurchaseDate.TabIndex = 6
        Me.LBNGaugePurchaseDate.Text = "Gauge Purchase Date:"
        '
        'TBNComment
        '
        Me.TBNComment.Location = New System.Drawing.Point(137, 216)
        Me.TBNComment.MaxLength = 254
        Me.TBNComment.Multiline = True
        Me.TBNComment.Name = "TBNComment"
        Me.TBNComment.Size = New System.Drawing.Size(175, 57)
        Me.TBNComment.TabIndex = 9
        '
        'LBNGaugeComment
        '
        Me.LBNGaugeComment.AutoSize = True
        Me.LBNGaugeComment.Location = New System.Drawing.Point(15, 219)
        Me.LBNGaugeComment.Name = "LBNGaugeComment"
        Me.LBNGaugeComment.Size = New System.Drawing.Size(111, 13)
        Me.LBNGaugeComment.TabIndex = 8
        Me.LBNGaugeComment.Text = "Comment (254 Chars):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "The gauge type must exist before adding a new gauge!"
        '
        'LSBNGaugeType
        '
        Me.LSBNGaugeType.FormattingEnabled = True
        Me.LSBNGaugeType.Location = New System.Drawing.Point(138, 118)
        Me.LSBNGaugeType.Name = "LSBNGaugeType"
        Me.LSBNGaugeType.Size = New System.Drawing.Size(175, 56)
        Me.LSBNGaugeType.TabIndex = 11
        '
        'BTSaveNewGauge
        '
        Me.BTSaveNewGauge.Location = New System.Drawing.Point(237, 279)
        Me.BTSaveNewGauge.Name = "BTSaveNewGauge"
        Me.BTSaveNewGauge.Size = New System.Drawing.Size(75, 23)
        Me.BTSaveNewGauge.TabIndex = 12
        Me.BTSaveNewGauge.Text = "Save"
        Me.BTSaveNewGauge.UseVisualStyleBackColor = True
        '
        'TBNGaugeTypeID
        '
        Me.TBNGaugeTypeID.Location = New System.Drawing.Point(138, 88)
        Me.TBNGaugeTypeID.Name = "TBNGaugeTypeID"
        Me.TBNGaugeTypeID.Size = New System.Drawing.Size(174, 20)
        Me.TBNGaugeTypeID.TabIndex = 14
        '
        'LBNGaugeTypeID
        '
        Me.LBNGaugeTypeID.AutoSize = True
        Me.LBNGaugeTypeID.Location = New System.Drawing.Point(15, 91)
        Me.LBNGaugeTypeID.Name = "LBNGaugeTypeID"
        Me.LBNGaugeTypeID.Size = New System.Drawing.Size(83, 13)
        Me.LBNGaugeTypeID.TabIndex = 13
        Me.LBNGaugeTypeID.Text = "Gauge Type ID:"
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(18, 279)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 15
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 309)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.TBNGaugeTypeID)
        Me.Controls.Add(Me.LBNGaugeTypeID)
        Me.Controls.Add(Me.BTSaveNewGauge)
        Me.Controls.Add(Me.LSBNGaugeType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBNComment)
        Me.Controls.Add(Me.LBNGaugeComment)
        Me.Controls.Add(Me.TBNGaugePurchaseDate)
        Me.Controls.Add(Me.LBNGaugePurchaseDate)
        Me.Controls.Add(Me.LBNGaugeType)
        Me.Controls.Add(Me.TBGaugeAvailable)
        Me.Controls.Add(Me.BTCheckGaugeAvailable)
        Me.Controls.Add(Me.TBGaugeID)
        Me.Controls.Add(Me.LBGaugeID)
        Me.Name = "Form3"
        Me.Text = "New Gauge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBGaugeID As System.Windows.Forms.Label
    Friend WithEvents TBGaugeID As System.Windows.Forms.TextBox
    Friend WithEvents BTCheckGaugeAvailable As System.Windows.Forms.Button
    Friend WithEvents TBGaugeAvailable As System.Windows.Forms.TextBox
    Friend WithEvents LBNGaugeType As System.Windows.Forms.Label
    Friend WithEvents TBNGaugePurchaseDate As System.Windows.Forms.TextBox
    Friend WithEvents LBNGaugePurchaseDate As System.Windows.Forms.Label
    Friend WithEvents TBNComment As System.Windows.Forms.TextBox
    Friend WithEvents LBNGaugeComment As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LSBNGaugeType As System.Windows.Forms.ListBox
    Friend WithEvents BTSaveNewGauge As System.Windows.Forms.Button
    Friend WithEvents TBNGaugeTypeID As System.Windows.Forms.TextBox
    Friend WithEvents LBNGaugeTypeID As System.Windows.Forms.Label
    Friend WithEvents BTCancel As System.Windows.Forms.Button
End Class
