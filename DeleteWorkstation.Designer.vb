<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteWorkstation
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
        Me.TBDelWorkstationLineNum = New System.Windows.Forms.TextBox()
        Me.LSBDelWorkstationID = New System.Windows.Forms.ListBox()
        Me.BTCancel = New System.Windows.Forms.Button()
        Me.TBDelWorkstationDesc = New System.Windows.Forms.TextBox()
        Me.LBDelWorkstationLineNum = New System.Windows.Forms.Label()
        Me.BTDelWorkstation = New System.Windows.Forms.Button()
        Me.TBDelWorkstationLineDesc = New System.Windows.Forms.TextBox()
        Me.LBDelWrokstationDesc = New System.Windows.Forms.Label()
        Me.LBDelWorkstationLineDesc = New System.Windows.Forms.Label()
        Me.LBDelWorkstationID = New System.Windows.Forms.Label()
        Me.LBARComment = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBDelWorkstationLineNum
        '
        Me.TBDelWorkstationLineNum.Location = New System.Drawing.Point(139, 127)
        Me.TBDelWorkstationLineNum.Name = "TBDelWorkstationLineNum"
        Me.TBDelWorkstationLineNum.Size = New System.Drawing.Size(174, 20)
        Me.TBDelWorkstationLineNum.TabIndex = 44
        '
        'LSBDelWorkstationID
        '
        Me.LSBDelWorkstationID.FormattingEnabled = True
        Me.LSBDelWorkstationID.Location = New System.Drawing.Point(100, 12)
        Me.LSBDelWorkstationID.Name = "LSBDelWorkstationID"
        Me.LSBDelWorkstationID.Size = New System.Drawing.Size(120, 82)
        Me.LSBDelWorkstationID.TabIndex = 43
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(19, 182)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 42
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'TBDelWorkstationDesc
        '
        Me.TBDelWorkstationDesc.Location = New System.Drawing.Point(139, 100)
        Me.TBDelWorkstationDesc.Name = "TBDelWorkstationDesc"
        Me.TBDelWorkstationDesc.Size = New System.Drawing.Size(174, 20)
        Me.TBDelWorkstationDesc.TabIndex = 41
        '
        'LBDelWorkstationLineNum
        '
        Me.LBDelWorkstationLineNum.AutoSize = True
        Me.LBDelWorkstationLineNum.Location = New System.Drawing.Point(15, 130)
        Me.LBDelWorkstationLineNum.Name = "LBDelWorkstationLineNum"
        Me.LBDelWorkstationLineNum.Size = New System.Drawing.Size(70, 13)
        Me.LBDelWorkstationLineNum.TabIndex = 40
        Me.LBDelWorkstationLineNum.Text = "Line Number:"
        '
        'BTDelWorkstation
        '
        Me.BTDelWorkstation.Location = New System.Drawing.Point(194, 182)
        Me.BTDelWorkstation.Name = "BTDelWorkstation"
        Me.BTDelWorkstation.Size = New System.Drawing.Size(120, 23)
        Me.BTDelWorkstation.TabIndex = 39
        Me.BTDelWorkstation.Text = "Delete Workstation"
        Me.BTDelWorkstation.UseVisualStyleBackColor = True
        '
        'TBDelWorkstationLineDesc
        '
        Me.TBDelWorkstationLineDesc.Location = New System.Drawing.Point(139, 156)
        Me.TBDelWorkstationLineDesc.Name = "TBDelWorkstationLineDesc"
        Me.TBDelWorkstationLineDesc.Size = New System.Drawing.Size(175, 20)
        Me.TBDelWorkstationLineDesc.TabIndex = 36
        '
        'LBDelWrokstationDesc
        '
        Me.LBDelWrokstationDesc.AutoSize = True
        Me.LBDelWrokstationDesc.Location = New System.Drawing.Point(16, 103)
        Me.LBDelWrokstationDesc.Name = "LBDelWrokstationDesc"
        Me.LBDelWrokstationDesc.Size = New System.Drawing.Size(123, 13)
        Me.LBDelWrokstationDesc.TabIndex = 35
        Me.LBDelWrokstationDesc.Text = "Workstation Description:"
        '
        'LBDelWorkstationLineDesc
        '
        Me.LBDelWorkstationLineDesc.AutoSize = True
        Me.LBDelWorkstationLineDesc.Location = New System.Drawing.Point(16, 159)
        Me.LBDelWorkstationLineDesc.Name = "LBDelWorkstationLineDesc"
        Me.LBDelWorkstationLineDesc.Size = New System.Drawing.Size(86, 13)
        Me.LBDelWorkstationLineDesc.TabIndex = 34
        Me.LBDelWorkstationLineDesc.Text = "Line Description:"
        '
        'LBDelWorkstationID
        '
        Me.LBDelWorkstationID.AutoSize = True
        Me.LBDelWorkstationID.Location = New System.Drawing.Point(13, 14)
        Me.LBDelWorkstationID.Name = "LBDelWorkstationID"
        Me.LBDelWorkstationID.Size = New System.Drawing.Size(81, 13)
        Me.LBDelWorkstationID.TabIndex = 33
        Me.LBDelWorkstationID.Text = "Workstation ID:"
        '
        'LBARComment
        '
        Me.LBARComment.AutoSize = True
        Me.LBARComment.ForeColor = System.Drawing.Color.Red
        Me.LBARComment.Location = New System.Drawing.Point(237, 14)
        Me.LBARComment.Name = "LBARComment"
        Me.LBARComment.Size = New System.Drawing.Size(132, 13)
        Me.LBARComment.TabIndex = 45
        Me.LBARComment.Text = "Deleting a Workstation will"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(237, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "reassign gauge to Quality."
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 222)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBARComment)
        Me.Controls.Add(Me.TBDelWorkstationLineNum)
        Me.Controls.Add(Me.LSBDelWorkstationID)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.TBDelWorkstationDesc)
        Me.Controls.Add(Me.LBDelWorkstationLineNum)
        Me.Controls.Add(Me.BTDelWorkstation)
        Me.Controls.Add(Me.TBDelWorkstationLineDesc)
        Me.Controls.Add(Me.LBDelWrokstationDesc)
        Me.Controls.Add(Me.LBDelWorkstationLineDesc)
        Me.Controls.Add(Me.LBDelWorkstationID)
        Me.Name = "Form9"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Delete Workstation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBDelWorkstationLineNum As System.Windows.Forms.TextBox
    Friend WithEvents LSBDelWorkstationID As System.Windows.Forms.ListBox
    Friend WithEvents BTCancel As System.Windows.Forms.Button
    Friend WithEvents TBDelWorkstationDesc As System.Windows.Forms.TextBox
    Friend WithEvents LBDelWorkstationLineNum As System.Windows.Forms.Label
    Friend WithEvents BTDelWorkstation As System.Windows.Forms.Button
    Friend WithEvents TBDelWorkstationLineDesc As System.Windows.Forms.TextBox
    Friend WithEvents LBDelWrokstationDesc As System.Windows.Forms.Label
    Friend WithEvents LBDelWorkstationLineDesc As System.Windows.Forms.Label
    Friend WithEvents LBDelWorkstationID As System.Windows.Forms.Label
    Friend WithEvents LBARComment As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
