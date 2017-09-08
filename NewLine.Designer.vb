<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewLine
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
        Me.BTSaveNewLine = New System.Windows.Forms.Button()
        Me.LBNWorkStationDesript = New System.Windows.Forms.Label()
        Me.TBNLDeptNum = New System.Windows.Forms.TextBox()
        Me.LBNLDeptNum = New System.Windows.Forms.Label()
        Me.TBNLAvailable = New System.Windows.Forms.TextBox()
        Me.BTNLCheckAvailable = New System.Windows.Forms.Button()
        Me.TBLineDescpt = New System.Windows.Forms.TextBox()
        Me.LBLineDescpt = New System.Windows.Forms.Label()
        Me.LBLineColor = New System.Windows.Forms.Label()
        Me.LBLCcolor = New System.Windows.Forms.Label()
        Me.TBNLComment = New System.Windows.Forms.TextBox()
        Me.LSBLineColor = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTSaveNewLine
        '
        Me.BTSaveNewLine.Location = New System.Drawing.Point(257, 206)
        Me.BTSaveNewLine.Name = "BTSaveNewLine"
        Me.BTSaveNewLine.Size = New System.Drawing.Size(75, 23)
        Me.BTSaveNewLine.TabIndex = 42
        Me.BTSaveNewLine.Text = "Save"
        Me.BTSaveNewLine.UseVisualStyleBackColor = True
        '
        'LBNWorkStationDesript
        '
        Me.LBNWorkStationDesript.AutoSize = True
        Me.LBNWorkStationDesript.Location = New System.Drawing.Point(21, 146)
        Me.LBNWorkStationDesript.Name = "LBNWorkStationDesript"
        Me.LBNWorkStationDesript.Size = New System.Drawing.Size(111, 13)
        Me.LBNWorkStationDesript.TabIndex = 39
        Me.LBNWorkStationDesript.Text = "Comment (254 Chars):"
        '
        'TBNLDeptNum
        '
        Me.TBNLDeptNum.Location = New System.Drawing.Point(147, 91)
        Me.TBNLDeptNum.Name = "TBNLDeptNum"
        Me.TBNLDeptNum.Size = New System.Drawing.Size(185, 20)
        Me.TBNLDeptNum.TabIndex = 38
        '
        'LBNLDeptNum
        '
        Me.LBNLDeptNum.AutoSize = True
        Me.LBNLDeptNum.Location = New System.Drawing.Point(21, 94)
        Me.LBNLDeptNum.Name = "LBNLDeptNum"
        Me.LBNLDeptNum.Size = New System.Drawing.Size(76, 13)
        Me.LBNLDeptNum.TabIndex = 36
        Me.LBNLDeptNum.Text = "Dept. Number:"
        '
        'TBNLAvailable
        '
        Me.TBNLAvailable.CausesValidation = False
        Me.TBNLAvailable.Location = New System.Drawing.Point(213, 65)
        Me.TBNLAvailable.Name = "TBNLAvailable"
        Me.TBNLAvailable.ReadOnly = True
        Me.TBNLAvailable.Size = New System.Drawing.Size(119, 20)
        Me.TBNLAvailable.TabIndex = 35
        Me.TBNLAvailable.TabStop = False
        '
        'BTNLCheckAvailable
        '
        Me.BTNLCheckAvailable.Location = New System.Drawing.Point(213, 36)
        Me.BTNLCheckAvailable.Name = "BTNLCheckAvailable"
        Me.BTNLCheckAvailable.Size = New System.Drawing.Size(119, 23)
        Me.BTNLCheckAvailable.TabIndex = 34
        Me.BTNLCheckAvailable.Text = "Check Available"
        Me.BTNLCheckAvailable.UseVisualStyleBackColor = True
        '
        'TBLineDescpt
        '
        Me.TBLineDescpt.Location = New System.Drawing.Point(107, 38)
        Me.TBLineDescpt.Name = "TBLineDescpt"
        Me.TBLineDescpt.Size = New System.Drawing.Size(100, 20)
        Me.TBLineDescpt.TabIndex = 33
        '
        'LBLineDescpt
        '
        Me.LBLineDescpt.AutoSize = True
        Me.LBLineDescpt.Location = New System.Drawing.Point(21, 41)
        Me.LBLineDescpt.Name = "LBLineDescpt"
        Me.LBLineDescpt.Size = New System.Drawing.Size(86, 13)
        Me.LBLineDescpt.TabIndex = 32
        Me.LBLineDescpt.Text = "Line Description:"
        '
        'LBLineColor
        '
        Me.LBLineColor.AutoSize = True
        Me.LBLineColor.Location = New System.Drawing.Point(21, 120)
        Me.LBLineColor.Name = "LBLineColor"
        Me.LBLineColor.Size = New System.Drawing.Size(57, 13)
        Me.LBLineColor.TabIndex = 43
        Me.LBLineColor.Text = "Line Color:"
        '
        'LBLCcolor
        '
        Me.LBLCcolor.AutoSize = True
        Me.LBLCcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCcolor.Location = New System.Drawing.Point(128, 120)
        Me.LBLCcolor.Name = "LBLCcolor"
        Me.LBLCcolor.Size = New System.Drawing.Size(15, 15)
        Me.LBLCcolor.TabIndex = 45
        Me.LBLCcolor.Text = "  "
        '
        'TBNLComment
        '
        Me.TBNLComment.Location = New System.Drawing.Point(147, 146)
        Me.TBNLComment.Multiline = True
        Me.TBNLComment.Name = "TBNLComment"
        Me.TBNLComment.Size = New System.Drawing.Size(185, 54)
        Me.TBNLComment.TabIndex = 46
        '
        'LSBLineColor
        '
        Me.LSBLineColor.FormattingEnabled = True
        Me.LSBLineColor.Location = New System.Drawing.Point(147, 120)
        Me.LSBLineColor.Name = "LSBLineColor"
        Me.LSBLineColor.Size = New System.Drawing.Size(182, 17)
        Me.LSBLineColor.TabIndex = 47
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 249)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LSBLineColor)
        Me.Controls.Add(Me.TBNLComment)
        Me.Controls.Add(Me.LBLCcolor)
        Me.Controls.Add(Me.LBLineColor)
        Me.Controls.Add(Me.BTSaveNewLine)
        Me.Controls.Add(Me.LBNWorkStationDesript)
        Me.Controls.Add(Me.TBNLDeptNum)
        Me.Controls.Add(Me.LBNLDeptNum)
        Me.Controls.Add(Me.TBNLAvailable)
        Me.Controls.Add(Me.BTNLCheckAvailable)
        Me.Controls.Add(Me.TBLineDescpt)
        Me.Controls.Add(Me.LBLineDescpt)
        Me.Name = "Form4"
        Me.Text = "New Production Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTSaveNewLine As System.Windows.Forms.Button
    Friend WithEvents LBNWorkStationDesript As System.Windows.Forms.Label
    Friend WithEvents TBNLDeptNum As System.Windows.Forms.TextBox
    Friend WithEvents LBNLDeptNum As System.Windows.Forms.Label
    Friend WithEvents TBNLAvailable As System.Windows.Forms.TextBox
    Friend WithEvents BTNLCheckAvailable As System.Windows.Forms.Button
    Friend WithEvents TBLineDescpt As System.Windows.Forms.TextBox
    Friend WithEvents LBLineDescpt As System.Windows.Forms.Label
    Friend WithEvents LBLineColor As System.Windows.Forms.Label
    Friend WithEvents LBLCcolor As System.Windows.Forms.Label
    Friend WithEvents TBNLComment As System.Windows.Forms.TextBox
    Friend WithEvents LSBLineColor As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
