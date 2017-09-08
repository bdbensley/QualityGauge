<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyLine
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
        Me.LSBMLineColor = New System.Windows.Forms.ListBox()
        Me.TBMLComment = New System.Windows.Forms.TextBox()
        Me.LBMLCcolor = New System.Windows.Forms.Label()
        Me.LBMLineColor = New System.Windows.Forms.Label()
        Me.BTModifyLine = New System.Windows.Forms.Button()
        Me.LBMLineComment = New System.Windows.Forms.Label()
        Me.LBMLDeptNum = New System.Windows.Forms.Label()
        Me.LBMLineDesc = New System.Windows.Forms.Label()
        Me.TBMNLineDesc = New System.Windows.Forms.TextBox()
        Me.LBMNLineDesc = New System.Windows.Forms.Label()
        Me.LSBMLineDesc = New System.Windows.Forms.ListBox()
        Me.TBMLineDeptNum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(20, 250)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 61
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'LSBMLineColor
        '
        Me.LSBMLineColor.FormattingEnabled = True
        Me.LSBMLineColor.Location = New System.Drawing.Point(143, 165)
        Me.LSBMLineColor.Name = "LSBMLineColor"
        Me.LSBMLineColor.Size = New System.Drawing.Size(182, 17)
        Me.LSBMLineColor.TabIndex = 60
        '
        'TBMLComment
        '
        Me.TBMLComment.Location = New System.Drawing.Point(143, 191)
        Me.TBMLComment.Multiline = True
        Me.TBMLComment.Name = "TBMLComment"
        Me.TBMLComment.Size = New System.Drawing.Size(185, 54)
        Me.TBMLComment.TabIndex = 59
        '
        'LBMLCcolor
        '
        Me.LBMLCcolor.AutoSize = True
        Me.LBMLCcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBMLCcolor.Location = New System.Drawing.Point(124, 165)
        Me.LBMLCcolor.Name = "LBMLCcolor"
        Me.LBMLCcolor.Size = New System.Drawing.Size(15, 15)
        Me.LBMLCcolor.TabIndex = 58
        Me.LBMLCcolor.Text = "  "
        '
        'LBMLineColor
        '
        Me.LBMLineColor.AutoSize = True
        Me.LBMLineColor.Location = New System.Drawing.Point(17, 165)
        Me.LBMLineColor.Name = "LBMLineColor"
        Me.LBMLineColor.Size = New System.Drawing.Size(57, 13)
        Me.LBMLineColor.TabIndex = 57
        Me.LBMLineColor.Text = "Line Color:"
        '
        'BTModifyLine
        '
        Me.BTModifyLine.Location = New System.Drawing.Point(253, 251)
        Me.BTModifyLine.Name = "BTModifyLine"
        Me.BTModifyLine.Size = New System.Drawing.Size(75, 23)
        Me.BTModifyLine.TabIndex = 56
        Me.BTModifyLine.Text = "Save"
        Me.BTModifyLine.UseVisualStyleBackColor = True
        '
        'LBMLineComment
        '
        Me.LBMLineComment.AutoSize = True
        Me.LBMLineComment.Location = New System.Drawing.Point(17, 191)
        Me.LBMLineComment.Name = "LBMLineComment"
        Me.LBMLineComment.Size = New System.Drawing.Size(111, 13)
        Me.LBMLineComment.TabIndex = 55
        Me.LBMLineComment.Text = "Comment (254 Chars):"
        '
        'LBMLDeptNum
        '
        Me.LBMLDeptNum.AutoSize = True
        Me.LBMLDeptNum.Location = New System.Drawing.Point(17, 147)
        Me.LBMLDeptNum.Name = "LBMLDeptNum"
        Me.LBMLDeptNum.Size = New System.Drawing.Size(76, 13)
        Me.LBMLDeptNum.TabIndex = 53
        Me.LBMLDeptNum.Text = "Dept. Number:"
        '
        'LBMLineDesc
        '
        Me.LBMLineDesc.AutoSize = True
        Me.LBMLineDesc.Location = New System.Drawing.Point(15, 12)
        Me.LBMLineDesc.Name = "LBMLineDesc"
        Me.LBMLineDesc.Size = New System.Drawing.Size(86, 13)
        Me.LBMLineDesc.TabIndex = 49
        Me.LBMLineDesc.Text = "Line Description:"
        '
        'TBMNLineDesc
        '
        Me.TBMNLineDesc.Location = New System.Drawing.Point(107, 118)
        Me.TBMNLineDesc.Name = "TBMNLineDesc"
        Me.TBMNLineDesc.Size = New System.Drawing.Size(218, 20)
        Me.TBMNLineDesc.TabIndex = 63
        '
        'LBMNLineDesc
        '
        Me.LBMNLineDesc.AutoSize = True
        Me.LBMNLineDesc.Location = New System.Drawing.Point(17, 121)
        Me.LBMNLineDesc.Name = "LBMNLineDesc"
        Me.LBMNLineDesc.Size = New System.Drawing.Size(88, 13)
        Me.LBMNLineDesc.TabIndex = 62
        Me.LBMNLineDesc.Text = "New Description:"
        '
        'LSBMLineDesc
        '
        Me.LSBMLineDesc.FormattingEnabled = True
        Me.LSBMLineDesc.Location = New System.Drawing.Point(107, 12)
        Me.LSBMLineDesc.Name = "LSBMLineDesc"
        Me.LSBMLineDesc.Size = New System.Drawing.Size(218, 95)
        Me.LSBMLineDesc.TabIndex = 64
        '
        'TBMLineDeptNum
        '
        Me.TBMLineDeptNum.Enabled = False
        Me.TBMLineDeptNum.Location = New System.Drawing.Point(107, 139)
        Me.TBMLineDeptNum.Name = "TBMLineDeptNum"
        Me.TBMLineDeptNum.Size = New System.Drawing.Size(100, 20)
        Me.TBMLineDeptNum.TabIndex = 65
        '
        'ModifyLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 287)
        Me.Controls.Add(Me.TBMLineDeptNum)
        Me.Controls.Add(Me.LSBMLineDesc)
        Me.Controls.Add(Me.TBMNLineDesc)
        Me.Controls.Add(Me.LBMNLineDesc)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.LSBMLineColor)
        Me.Controls.Add(Me.TBMLComment)
        Me.Controls.Add(Me.LBMLCcolor)
        Me.Controls.Add(Me.LBMLineColor)
        Me.Controls.Add(Me.BTModifyLine)
        Me.Controls.Add(Me.LBMLineComment)
        Me.Controls.Add(Me.LBMLDeptNum)
        Me.Controls.Add(Me.LBMLineDesc)
        Me.Name = "ModifyLine"
        Me.Text = "Modify Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTCancel As System.Windows.Forms.Button
    Friend WithEvents LSBMLineColor As System.Windows.Forms.ListBox
    Friend WithEvents TBMLComment As System.Windows.Forms.TextBox
    Friend WithEvents LBMLCcolor As System.Windows.Forms.Label
    Friend WithEvents LBMLineColor As System.Windows.Forms.Label
    Friend WithEvents BTModifyLine As System.Windows.Forms.Button
    Friend WithEvents LBMLineComment As System.Windows.Forms.Label
    Friend WithEvents LBMLDeptNum As System.Windows.Forms.Label
    Friend WithEvents LBMLineDesc As System.Windows.Forms.Label
    Friend WithEvents TBMNLineDesc As System.Windows.Forms.TextBox
    Friend WithEvents LBMNLineDesc As System.Windows.Forms.Label
    Friend WithEvents LSBMLineDesc As System.Windows.Forms.ListBox
    Friend WithEvents TBMLineDeptNum As System.Windows.Forms.TextBox
End Class
