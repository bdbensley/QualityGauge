<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteLine
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
        Me.LBDelGauge = New System.Windows.Forms.Label()
        Me.TBDelLineColor = New System.Windows.Forms.TextBox()
        Me.LSBDelLineDeptNum = New System.Windows.Forms.ListBox()
        Me.BTCancel = New System.Windows.Forms.Button()
        Me.TBDelLineDesc = New System.Windows.Forms.TextBox()
        Me.LBDelLineDesc = New System.Windows.Forms.Label()
        Me.BTDelLine = New System.Windows.Forms.Button()
        Me.TBDelLineComment = New System.Windows.Forms.TextBox()
        Me.LBDelLineComment = New System.Windows.Forms.Label()
        Me.LBDelLineColor = New System.Windows.Forms.Label()
        Me.LBDelGaugeID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBColor = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LBDelGauge
        '
        Me.LBDelGauge.AutoSize = True
        Me.LBDelGauge.Location = New System.Drawing.Point(211, 12)
        Me.LBDelGauge.Name = "LBDelGauge"
        Me.LBDelGauge.Size = New System.Drawing.Size(0, 13)
        Me.LBDelGauge.TabIndex = 45
        '
        'TBDelLineColor
        '
        Me.TBDelLineColor.Location = New System.Drawing.Point(139, 127)
        Me.TBDelLineColor.Name = "TBDelLineColor"
        Me.TBDelLineColor.Size = New System.Drawing.Size(143, 20)
        Me.TBDelLineColor.TabIndex = 44
        '
        'LSBDelLineDeptNum
        '
        Me.LSBDelLineDeptNum.FormattingEnabled = True
        Me.LSBDelLineDeptNum.Location = New System.Drawing.Point(125, 12)
        Me.LSBDelLineDeptNum.Name = "LSBDelLineDeptNum"
        Me.LSBDelLineDeptNum.Size = New System.Drawing.Size(120, 82)
        Me.LSBDelLineDeptNum.TabIndex = 43
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(19, 216)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 42
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'TBDelLineDesc
        '
        Me.TBDelLineDesc.Location = New System.Drawing.Point(140, 100)
        Me.TBDelLineDesc.Name = "TBDelLineDesc"
        Me.TBDelLineDesc.Size = New System.Drawing.Size(174, 20)
        Me.TBDelLineDesc.TabIndex = 41
        '
        'LBDelLineDesc
        '
        Me.LBDelLineDesc.AutoSize = True
        Me.LBDelLineDesc.Location = New System.Drawing.Point(16, 103)
        Me.LBDelLineDesc.Name = "LBDelLineDesc"
        Me.LBDelLineDesc.Size = New System.Drawing.Size(86, 13)
        Me.LBDelLineDesc.TabIndex = 40
        Me.LBDelLineDesc.Text = "Line Description:"
        '
        'BTDelLine
        '
        Me.BTDelLine.Location = New System.Drawing.Point(225, 216)
        Me.BTDelLine.Name = "BTDelLine"
        Me.BTDelLine.Size = New System.Drawing.Size(89, 23)
        Me.BTDelLine.TabIndex = 39
        Me.BTDelLine.Text = "Delete Line"
        Me.BTDelLine.UseVisualStyleBackColor = True
        '
        'TBDelLineComment
        '
        Me.TBDelLineComment.Location = New System.Drawing.Point(139, 153)
        Me.TBDelLineComment.MaxLength = 254
        Me.TBDelLineComment.Multiline = True
        Me.TBDelLineComment.Name = "TBDelLineComment"
        Me.TBDelLineComment.Size = New System.Drawing.Size(175, 57)
        Me.TBDelLineComment.TabIndex = 38
        '
        'LBDelLineComment
        '
        Me.LBDelLineComment.AutoSize = True
        Me.LBDelLineComment.Location = New System.Drawing.Point(17, 156)
        Me.LBDelLineComment.Name = "LBDelLineComment"
        Me.LBDelLineComment.Size = New System.Drawing.Size(111, 13)
        Me.LBDelLineComment.TabIndex = 37
        Me.LBDelLineComment.Text = "Comment (254 Chars):"
        '
        'LBDelLineColor
        '
        Me.LBDelLineColor.AutoSize = True
        Me.LBDelLineColor.Location = New System.Drawing.Point(16, 130)
        Me.LBDelLineColor.Name = "LBDelLineColor"
        Me.LBDelLineColor.Size = New System.Drawing.Size(57, 13)
        Me.LBDelLineColor.TabIndex = 34
        Me.LBDelLineColor.Text = "Line Color:"
        '
        'LBDelGaugeID
        '
        Me.LBDelGaugeID.AutoSize = True
        Me.LBDelGaugeID.Location = New System.Drawing.Point(14, 14)
        Me.LBDelGaugeID.Name = "LBDelGaugeID"
        Me.LBDelGaugeID.Size = New System.Drawing.Size(105, 13)
        Me.LBDelGaugeID.TabIndex = 33
        Me.LBDelGaugeID.Text = "Department Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(251, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Deleting line will"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(251, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "reassign gauges,"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(251, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "if any, to Quality"
        '
        'LBColor
        '
        Me.LBColor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LBColor.FormattingEnabled = True
        Me.LBColor.Location = New System.Drawing.Point(298, 127)
        Me.LBColor.Name = "LBColor"
        Me.LBColor.Size = New System.Drawing.Size(16, 17)
        Me.LBColor.TabIndex = 50
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 255)
        Me.Controls.Add(Me.LBColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBDelGauge)
        Me.Controls.Add(Me.TBDelLineColor)
        Me.Controls.Add(Me.LSBDelLineDeptNum)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.TBDelLineDesc)
        Me.Controls.Add(Me.LBDelLineDesc)
        Me.Controls.Add(Me.BTDelLine)
        Me.Controls.Add(Me.TBDelLineComment)
        Me.Controls.Add(Me.LBDelLineComment)
        Me.Controls.Add(Me.LBDelLineColor)
        Me.Controls.Add(Me.LBDelGaugeID)
        Me.Name = "Form10"
        Me.Text = "Delete Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBDelGauge As System.Windows.Forms.Label
    Friend WithEvents TBDelLineColor As System.Windows.Forms.TextBox
    Friend WithEvents LSBDelLineDeptNum As System.Windows.Forms.ListBox
    Friend WithEvents BTCancel As System.Windows.Forms.Button
    Friend WithEvents TBDelLineDesc As System.Windows.Forms.TextBox
    Friend WithEvents LBDelLineDesc As System.Windows.Forms.Label
    Friend WithEvents BTDelLine As System.Windows.Forms.Button
    Friend WithEvents TBDelLineComment As System.Windows.Forms.TextBox
    Friend WithEvents LBDelLineComment As System.Windows.Forms.Label
    Friend WithEvents LBDelLineColor As System.Windows.Forms.Label
    Friend WithEvents LBDelGaugeID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBColor As System.Windows.Forms.ListBox
End Class
