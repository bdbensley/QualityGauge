<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintLabels
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
        Me.BTPrintAll = New System.Windows.Forms.Button()
        Me.RTBLabels = New System.Windows.Forms.RichTextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'BTPrintAll
        '
        Me.BTPrintAll.Location = New System.Drawing.Point(12, 12)
        Me.BTPrintAll.Name = "BTPrintAll"
        Me.BTPrintAll.Size = New System.Drawing.Size(75, 23)
        Me.BTPrintAll.TabIndex = 0
        Me.BTPrintAll.Text = "Print All"
        Me.BTPrintAll.UseVisualStyleBackColor = True
        '
        'RTBLabels
        '
        Me.RTBLabels.Location = New System.Drawing.Point(13, 42)
        Me.RTBLabels.Name = "RTBLabels"
        Me.RTBLabels.Size = New System.Drawing.Size(840, 579)
        Me.RTBLabels.TabIndex = 1
        Me.RTBLabels.Text = ""
        '
        'PrintDocument1
        '
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 633)
        Me.Controls.Add(Me.RTBLabels)
        Me.Controls.Add(Me.BTPrintAll)
        Me.Name = "Form6"
        Me.Text = "Print Labels"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTPrintAll As System.Windows.Forms.Button
    Friend WithEvents RTBLabels As System.Windows.Forms.RichTextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
