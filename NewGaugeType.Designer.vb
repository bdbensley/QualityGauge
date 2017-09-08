<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGaugeType
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
        Me.TBNGaugeDescript = New System.Windows.Forms.TextBox()
        Me.LBNGaugeDescript = New System.Windows.Forms.Label()
        Me.BTSaveNewWS = New System.Windows.Forms.Button()
        Me.LBNGaugeReorderPoint = New System.Windows.Forms.Label()
        Me.TBGaugeTypeID = New System.Windows.Forms.TextBox()
        Me.LBNGaugeTypeID = New System.Windows.Forms.Label()
        Me.NUDReorderPoint = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.NUDReorderPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBNGaugeDescript
        '
        Me.TBNGaugeDescript.Location = New System.Drawing.Point(144, 93)
        Me.TBNGaugeDescript.Name = "TBNGaugeDescript"
        Me.TBNGaugeDescript.Size = New System.Drawing.Size(185, 20)
        Me.TBNGaugeDescript.TabIndex = 45
        '
        'LBNGaugeDescript
        '
        Me.LBNGaugeDescript.AutoSize = True
        Me.LBNGaugeDescript.Location = New System.Drawing.Point(18, 97)
        Me.LBNGaugeDescript.Name = "LBNGaugeDescript"
        Me.LBNGaugeDescript.Size = New System.Drawing.Size(98, 13)
        Me.LBNGaugeDescript.TabIndex = 44
        Me.LBNGaugeDescript.Text = "Gauge Description:"
        '
        'BTSaveNewWS
        '
        Me.BTSaveNewWS.Location = New System.Drawing.Point(254, 149)
        Me.BTSaveNewWS.Name = "BTSaveNewWS"
        Me.BTSaveNewWS.Size = New System.Drawing.Size(75, 23)
        Me.BTSaveNewWS.TabIndex = 42
        Me.BTSaveNewWS.Text = "Save"
        Me.BTSaveNewWS.UseVisualStyleBackColor = True
        '
        'LBNGaugeReorderPoint
        '
        Me.LBNGaugeReorderPoint.AutoSize = True
        Me.LBNGaugeReorderPoint.Location = New System.Drawing.Point(18, 126)
        Me.LBNGaugeReorderPoint.Name = "LBNGaugeReorderPoint"
        Me.LBNGaugeReorderPoint.Size = New System.Drawing.Size(91, 13)
        Me.LBNGaugeReorderPoint.TabIndex = 36
        Me.LBNGaugeReorderPoint.Text = "Reorder Point (#):"
        '
        'TBGaugeTypeID
        '
        Me.TBGaugeTypeID.Location = New System.Drawing.Point(104, 35)
        Me.TBGaugeTypeID.Name = "TBGaugeTypeID"
        Me.TBGaugeTypeID.Size = New System.Drawing.Size(100, 20)
        Me.TBGaugeTypeID.TabIndex = 33
        '
        'LBNGaugeTypeID
        '
        Me.LBNGaugeTypeID.AutoSize = True
        Me.LBNGaugeTypeID.Location = New System.Drawing.Point(18, 38)
        Me.LBNGaugeTypeID.Name = "LBNGaugeTypeID"
        Me.LBNGaugeTypeID.Size = New System.Drawing.Size(83, 13)
        Me.LBNGaugeTypeID.TabIndex = 32
        Me.LBNGaugeTypeID.Text = "Guage Type ID:"
        '
        'NUDReorderPoint
        '
        Me.NUDReorderPoint.Location = New System.Drawing.Point(144, 123)
        Me.NUDReorderPoint.Name = "NUDReorderPoint"
        Me.NUDReorderPoint.Size = New System.Drawing.Size(185, 20)
        Me.NUDReorderPoint.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 187)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NUDReorderPoint)
        Me.Controls.Add(Me.TBNGaugeDescript)
        Me.Controls.Add(Me.LBNGaugeDescript)
        Me.Controls.Add(Me.BTSaveNewWS)
        Me.Controls.Add(Me.LBNGaugeReorderPoint)
        Me.Controls.Add(Me.TBGaugeTypeID)
        Me.Controls.Add(Me.LBNGaugeTypeID)
        Me.Name = "Form5"
        Me.Text = "New Gauge Type"
        CType(Me.NUDReorderPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBNGaugeDescript As System.Windows.Forms.TextBox
    Friend WithEvents LBNGaugeDescript As System.Windows.Forms.Label
    Friend WithEvents BTSaveNewWS As System.Windows.Forms.Button
    Friend WithEvents LBNGaugeReorderPoint As System.Windows.Forms.Label
    Friend WithEvents TBGaugeTypeID As System.Windows.Forms.TextBox
    Friend WithEvents LBNGaugeTypeID As System.Windows.Forms.Label
    Friend WithEvents NUDReorderPoint As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
