<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyWorkstation
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
        Me.LBWorkStationID = New System.Windows.Forms.Label()
        Me.LBMWSDeptNum = New System.Windows.Forms.Label()
        Me.BTCancel = New System.Windows.Forms.Button()
        Me.LBMWorkStationDesript = New System.Windows.Forms.Label()
        Me.TBMWSDescript = New System.Windows.Forms.TextBox()
        Me.LSBMWorkstation = New System.Windows.Forms.ListBox()
        Me.BTSaveModifiedWS = New System.Windows.Forms.Button()
        Me.LSBLineDesc = New System.Windows.Forms.ListBox()
        Me.TBDeptNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBWorkStationID
        '
        Me.LBWorkStationID.AutoSize = True
        Me.LBWorkStationID.Location = New System.Drawing.Point(13, 18)
        Me.LBWorkStationID.Name = "LBWorkStationID"
        Me.LBWorkStationID.Size = New System.Drawing.Size(81, 13)
        Me.LBWorkStationID.TabIndex = 33
        Me.LBWorkStationID.Text = "Workstation ID:"
        '
        'LBMWSDeptNum
        '
        Me.LBMWSDeptNum.AutoSize = True
        Me.LBMWSDeptNum.Location = New System.Drawing.Point(13, 106)
        Me.LBMWSDeptNum.Name = "LBMWSDeptNum"
        Me.LBMWSDeptNum.Size = New System.Drawing.Size(76, 13)
        Me.LBMWSDeptNum.TabIndex = 37
        Me.LBMWSDeptNum.Text = "Dept. Number:"
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(7, 293)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 47
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'LBMWorkStationDesript
        '
        Me.LBMWorkStationDesript.AutoSize = True
        Me.LBMWorkStationDesript.Location = New System.Drawing.Point(13, 233)
        Me.LBMWorkStationDesript.Name = "LBMWorkStationDesript"
        Me.LBMWorkStationDesript.Size = New System.Drawing.Size(120, 13)
        Me.LBMWorkStationDesript.TabIndex = 40
        Me.LBMWorkStationDesript.Text = "Description (254 Chars):"
        '
        'TBMWSDescript
        '
        Me.TBMWSDescript.Location = New System.Drawing.Point(139, 230)
        Me.TBMWSDescript.MaxLength = 254
        Me.TBMWSDescript.Multiline = True
        Me.TBMWSDescript.Name = "TBMWSDescript"
        Me.TBMWSDescript.Size = New System.Drawing.Size(185, 57)
        Me.TBMWSDescript.TabIndex = 41
        '
        'LSBMWorkstation
        '
        Me.LSBMWorkstation.FormattingEnabled = True
        Me.LSBMWorkstation.Location = New System.Drawing.Point(97, 12)
        Me.LSBMWorkstation.Name = "LSBMWorkstation"
        Me.LSBMWorkstation.Size = New System.Drawing.Size(185, 82)
        Me.LSBMWorkstation.TabIndex = 42
        '
        'BTSaveModifiedWS
        '
        Me.BTSaveModifiedWS.Location = New System.Drawing.Point(249, 293)
        Me.BTSaveModifiedWS.Name = "BTSaveModifiedWS"
        Me.BTSaveModifiedWS.Size = New System.Drawing.Size(75, 23)
        Me.BTSaveModifiedWS.TabIndex = 43
        Me.BTSaveModifiedWS.Text = "Save"
        Me.BTSaveModifiedWS.UseVisualStyleBackColor = True
        '
        'LSBLineDesc
        '
        Me.LSBLineDesc.FormattingEnabled = True
        Me.LSBLineDesc.Location = New System.Drawing.Point(105, 129)
        Me.LSBLineDesc.Name = "LSBLineDesc"
        Me.LSBLineDesc.Size = New System.Drawing.Size(120, 95)
        Me.LSBLineDesc.TabIndex = 48
        '
        'TBDeptNum
        '
        Me.TBDeptNum.Location = New System.Drawing.Point(97, 103)
        Me.TBDeptNum.Name = "TBDeptNum"
        Me.TBDeptNum.Size = New System.Drawing.Size(100, 20)
        Me.TBDeptNum.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Line Description:"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 330)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBDeptNum)
        Me.Controls.Add(Me.LSBLineDesc)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.BTSaveModifiedWS)
        Me.Controls.Add(Me.LSBMWorkstation)
        Me.Controls.Add(Me.TBMWSDescript)
        Me.Controls.Add(Me.LBMWorkStationDesript)
        Me.Controls.Add(Me.LBMWSDeptNum)
        Me.Controls.Add(Me.LBWorkStationID)
        Me.Name = "Form11"
        Me.Text = "Modify Workstation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBWorkStationID As System.Windows.Forms.Label
    Friend WithEvents LBMWSDeptNum As System.Windows.Forms.Label
    Friend WithEvents BTCancel As System.Windows.Forms.Button
    Friend WithEvents LBMWorkStationDesript As System.Windows.Forms.Label
    Friend WithEvents TBMWSDescript As System.Windows.Forms.TextBox
    Friend WithEvents LSBMWorkstation As System.Windows.Forms.ListBox
    Friend WithEvents BTSaveModifiedWS As System.Windows.Forms.Button
    Friend WithEvents LSBLineDesc As System.Windows.Forms.ListBox
    Friend WithEvents TBDeptNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
