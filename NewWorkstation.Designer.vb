<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewWorkstation
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
        Me.BTSaveNewWS = New System.Windows.Forms.Button()
        Me.LSBNWSLineDesc = New System.Windows.Forms.ListBox()
        Me.TBNWSDescript = New System.Windows.Forms.TextBox()
        Me.LBNWorkStationDesript = New System.Windows.Forms.Label()
        Me.TBNWSLineNum = New System.Windows.Forms.TextBox()
        Me.LBNWSLineDescript = New System.Windows.Forms.Label()
        Me.LBNWSLineNum = New System.Windows.Forms.Label()
        Me.TBWSAvailable = New System.Windows.Forms.TextBox()
        Me.BTWSCheckAvailable = New System.Windows.Forms.Button()
        Me.TBWorkStationID = New System.Windows.Forms.TextBox()
        Me.LBWorkStationID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBLineID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTSaveNewWS
        '
        Me.BTSaveNewWS.Location = New System.Drawing.Point(254, 303)
        Me.BTSaveNewWS.Name = "BTSaveNewWS"
        Me.BTSaveNewWS.Size = New System.Drawing.Size(75, 23)
        Me.BTSaveNewWS.TabIndex = 26
        Me.BTSaveNewWS.Text = "Save"
        Me.BTSaveNewWS.UseVisualStyleBackColor = True
        '
        'LSBNWSLineDesc
        '
        Me.LSBNWSLineDesc.FormattingEnabled = True
        Me.LSBNWSLineDesc.Location = New System.Drawing.Point(144, 148)
        Me.LSBNWSLineDesc.Name = "LSBNWSLineDesc"
        Me.LSBNWSLineDesc.Size = New System.Drawing.Size(185, 82)
        Me.LSBNWSLineDesc.TabIndex = 25
        '
        'TBNWSDescript
        '
        Me.TBNWSDescript.Location = New System.Drawing.Point(144, 240)
        Me.TBNWSDescript.MaxLength = 254
        Me.TBNWSDescript.Multiline = True
        Me.TBNWSDescript.Name = "TBNWSDescript"
        Me.TBNWSDescript.Size = New System.Drawing.Size(185, 57)
        Me.TBNWSDescript.TabIndex = 23
        '
        'LBNWorkStationDesript
        '
        Me.LBNWorkStationDesript.AutoSize = True
        Me.LBNWorkStationDesript.Location = New System.Drawing.Point(18, 243)
        Me.LBNWorkStationDesript.Name = "LBNWorkStationDesript"
        Me.LBNWorkStationDesript.Size = New System.Drawing.Size(120, 13)
        Me.LBNWorkStationDesript.TabIndex = 22
        Me.LBNWorkStationDesript.Text = "Description (254 Chars):"
        '
        'TBNWSLineNum
        '
        Me.TBNWSLineNum.Location = New System.Drawing.Point(144, 122)
        Me.TBNWSLineNum.Name = "TBNWSLineNum"
        Me.TBNWSLineNum.Size = New System.Drawing.Size(185, 20)
        Me.TBNWSLineNum.TabIndex = 21
        '
        'LBNWSLineDescript
        '
        Me.LBNWSLineDescript.AutoSize = True
        Me.LBNWSLineDescript.Location = New System.Drawing.Point(18, 152)
        Me.LBNWSLineDescript.Name = "LBNWSLineDescript"
        Me.LBNWSLineDescript.Size = New System.Drawing.Size(86, 13)
        Me.LBNWSLineDescript.TabIndex = 20
        Me.LBNWSLineDescript.Text = "Line Description:"
        '
        'LBNWSLineNum
        '
        Me.LBNWSLineNum.AutoSize = True
        Me.LBNWSLineNum.Location = New System.Drawing.Point(18, 125)
        Me.LBNWSLineNum.Name = "LBNWSLineNum"
        Me.LBNWSLineNum.Size = New System.Drawing.Size(70, 13)
        Me.LBNWSLineNum.TabIndex = 19
        Me.LBNWSLineNum.Text = "Line Number:"
        '
        'TBWSAvailable
        '
        Me.TBWSAvailable.CausesValidation = False
        Me.TBWSAvailable.Location = New System.Drawing.Point(210, 61)
        Me.TBWSAvailable.Name = "TBWSAvailable"
        Me.TBWSAvailable.ReadOnly = True
        Me.TBWSAvailable.Size = New System.Drawing.Size(119, 20)
        Me.TBWSAvailable.TabIndex = 18
        Me.TBWSAvailable.TabStop = False
        '
        'BTWSCheckAvailable
        '
        Me.BTWSCheckAvailable.Location = New System.Drawing.Point(210, 32)
        Me.BTWSCheckAvailable.Name = "BTWSCheckAvailable"
        Me.BTWSCheckAvailable.Size = New System.Drawing.Size(119, 23)
        Me.BTWSCheckAvailable.TabIndex = 17
        Me.BTWSCheckAvailable.Text = "Check Available"
        Me.BTWSCheckAvailable.UseVisualStyleBackColor = True
        '
        'TBWorkStationID
        '
        Me.TBWorkStationID.Location = New System.Drawing.Point(104, 34)
        Me.TBWorkStationID.Name = "TBWorkStationID"
        Me.TBWorkStationID.Size = New System.Drawing.Size(100, 20)
        Me.TBWorkStationID.TabIndex = 16
        '
        'LBWorkStationID
        '
        Me.LBWorkStationID.AutoSize = True
        Me.LBWorkStationID.Location = New System.Drawing.Point(18, 37)
        Me.LBWorkStationID.Name = "LBWorkStationID"
        Me.LBWorkStationID.Size = New System.Drawing.Size(78, 13)
        Me.LBWorkStationID.TabIndex = 15
        Me.LBWorkStationID.Text = "WorkstationID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "The Line Number must exist before adding a new Workstation to it!"
        '
        'TBLineID
        '
        Me.TBLineID.Location = New System.Drawing.Point(144, 93)
        Me.TBLineID.Name = "TBLineID"
        Me.TBLineID.Size = New System.Drawing.Size(185, 20)
        Me.TBLineID.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Line ID:"
        '
        'BTCancel
        '
        Me.BTCancel.Location = New System.Drawing.Point(12, 303)
        Me.BTCancel.Name = "BTCancel"
        Me.BTCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTCancel.TabIndex = 32
        Me.BTCancel.Text = "Cancel"
        Me.BTCancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 349)
        Me.Controls.Add(Me.BTCancel)
        Me.Controls.Add(Me.TBLineID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTSaveNewWS)
        Me.Controls.Add(Me.LSBNWSLineDesc)
        Me.Controls.Add(Me.TBNWSDescript)
        Me.Controls.Add(Me.LBNWorkStationDesript)
        Me.Controls.Add(Me.TBNWSLineNum)
        Me.Controls.Add(Me.LBNWSLineDescript)
        Me.Controls.Add(Me.LBNWSLineNum)
        Me.Controls.Add(Me.TBWSAvailable)
        Me.Controls.Add(Me.BTWSCheckAvailable)
        Me.Controls.Add(Me.TBWorkStationID)
        Me.Controls.Add(Me.LBWorkStationID)
        Me.Name = "Form2"
        Me.Text = "New Workstation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTSaveNewWS As System.Windows.Forms.Button
    Friend WithEvents LSBNWSLineDesc As System.Windows.Forms.ListBox
    Friend WithEvents TBNWSDescript As System.Windows.Forms.TextBox
    Friend WithEvents LBNWorkStationDesript As System.Windows.Forms.Label
    Friend WithEvents TBNWSLineNum As System.Windows.Forms.TextBox
    Friend WithEvents LBNWSLineDescript As System.Windows.Forms.Label
    Friend WithEvents LBNWSLineNum As System.Windows.Forms.Label
    Friend WithEvents TBWSAvailable As System.Windows.Forms.TextBox
    Friend WithEvents BTWSCheckAvailable As System.Windows.Forms.Button
    Friend WithEvents TBWorkStationID As System.Windows.Forms.TextBox
    Friend WithEvents LBWorkStationID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBLineID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTCancel As System.Windows.Forms.Button
End Class
