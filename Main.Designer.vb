<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.LBGauge = New System.Windows.Forms.Label()
        Me.TBGaugeType = New System.Windows.Forms.TextBox()
        Me.LBGaugeType = New System.Windows.Forms.Label()
        Me.LSBGauge = New System.Windows.Forms.ListBox()
        Me.LBReorderPoint = New System.Windows.Forms.Label()
        Me.TBReorderPoint = New System.Windows.Forms.TextBox()
        Me.LBCurrentQuant = New System.Windows.Forms.Label()
        Me.TBQuant = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGaugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWorkstationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGaugeTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteWorkstationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteGaugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateWorkstationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpPdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateGuaugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZPrint2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBAssignment = New System.Windows.Forms.GroupBox()
        Me.LBARComment = New System.Windows.Forms.Label()
        Me.LSBARWorkstationID = New System.Windows.Forms.ListBox()
        Me.LSBARLine = New System.Windows.Forms.ListBox()
        Me.BTAssignReassign = New System.Windows.Forms.Button()
        Me.TBAROtherLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBARWorkstationDescript = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBARDept = New System.Windows.Forms.TextBox()
        Me.LBARDept = New System.Windows.Forms.Label()
        Me.TBOtherLocation = New System.Windows.Forms.TextBox()
        Me.LBOtherLocation = New System.Windows.Forms.Label()
        Me.TBWSDescript = New System.Windows.Forms.TextBox()
        Me.LBWSDescript = New System.Windows.Forms.Label()
        Me.TBWorkstation = New System.Windows.Forms.TextBox()
        Me.LBWorkstationID = New System.Windows.Forms.Label()
        Me.LBColor = New System.Windows.Forms.Label()
        Me.TBLineColor = New System.Windows.Forms.TextBox()
        Me.BLLineColor = New System.Windows.Forms.Label()
        Me.TBLine = New System.Windows.Forms.TextBox()
        Me.LBLine = New System.Windows.Forms.Label()
        Me.TBDepartment = New System.Windows.Forms.TextBox()
        Me.LBDept = New System.Windows.Forms.Label()
        Me.TBScan = New System.Windows.Forms.TextBox()
        Me.LBScan = New System.Windows.Forms.Label()
        Me.TBScanCode = New System.Windows.Forms.TextBox()
        Me.LBLastScan = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GBAssignment.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBGauge
        '
        Me.LBGauge.AutoSize = True
        Me.LBGauge.Location = New System.Drawing.Point(12, 32)
        Me.LBGauge.Name = "LBGauge"
        Me.LBGauge.Size = New System.Drawing.Size(42, 13)
        Me.LBGauge.TabIndex = 2
        Me.LBGauge.Text = "Gauge:"
        '
        'TBGaugeType
        '
        Me.TBGaugeType.Enabled = False
        Me.TBGaugeType.Location = New System.Drawing.Point(98, 127)
        Me.TBGaugeType.Name = "TBGaugeType"
        Me.TBGaugeType.Size = New System.Drawing.Size(264, 20)
        Me.TBGaugeType.TabIndex = 3
        '
        'LBGaugeType
        '
        Me.LBGaugeType.AutoSize = True
        Me.LBGaugeType.Location = New System.Drawing.Point(12, 130)
        Me.LBGaugeType.Name = "LBGaugeType"
        Me.LBGaugeType.Size = New System.Drawing.Size(69, 13)
        Me.LBGaugeType.TabIndex = 4
        Me.LBGaugeType.Text = "Gauge Type:"
        '
        'LSBGauge
        '
        Me.LSBGauge.FormattingEnabled = True
        Me.LSBGauge.Location = New System.Drawing.Point(60, 32)
        Me.LSBGauge.Name = "LSBGauge"
        Me.LSBGauge.Size = New System.Drawing.Size(120, 82)
        Me.LSBGauge.TabIndex = 5
        '
        'LBReorderPoint
        '
        Me.LBReorderPoint.AutoSize = True
        Me.LBReorderPoint.Location = New System.Drawing.Point(368, 130)
        Me.LBReorderPoint.Name = "LBReorderPoint"
        Me.LBReorderPoint.Size = New System.Drawing.Size(75, 13)
        Me.LBReorderPoint.TabIndex = 7
        Me.LBReorderPoint.Text = "Reorder Point:"
        '
        'TBReorderPoint
        '
        Me.TBReorderPoint.Location = New System.Drawing.Point(449, 127)
        Me.TBReorderPoint.Name = "TBReorderPoint"
        Me.TBReorderPoint.Size = New System.Drawing.Size(35, 20)
        Me.TBReorderPoint.TabIndex = 8
        Me.TBReorderPoint.TabStop = False
        '
        'LBCurrentQuant
        '
        Me.LBCurrentQuant.AutoSize = True
        Me.LBCurrentQuant.Location = New System.Drawing.Point(490, 130)
        Me.LBCurrentQuant.Name = "LBCurrentQuant"
        Me.LBCurrentQuant.Size = New System.Drawing.Size(49, 13)
        Me.LBCurrentQuant.TabIndex = 9
        Me.LBCurrentQuant.Text = "Quantity:"
        '
        'TBQuant
        '
        Me.TBQuant.Enabled = False
        Me.TBQuant.Location = New System.Drawing.Point(545, 127)
        Me.TBQuant.Name = "TBQuant"
        Me.TBQuant.Size = New System.Drawing.Size(35, 20)
        Me.TBQuant.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrationToolStripMenuItem.Text = "Administration"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGaugeToolStripMenuItem, Me.NewWorkstationToolStripMenuItem, Me.NewLineToolStripMenuItem, Me.NewGaugeTypeToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'NewGaugeToolStripMenuItem
        '
        Me.NewGaugeToolStripMenuItem.Name = "NewGaugeToolStripMenuItem"
        Me.NewGaugeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NewGaugeToolStripMenuItem.Text = "New Gauge"
        '
        'NewWorkstationToolStripMenuItem
        '
        Me.NewWorkstationToolStripMenuItem.Name = "NewWorkstationToolStripMenuItem"
        Me.NewWorkstationToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NewWorkstationToolStripMenuItem.Text = "New Workstation"
        '
        'NewLineToolStripMenuItem
        '
        Me.NewLineToolStripMenuItem.Name = "NewLineToolStripMenuItem"
        Me.NewLineToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NewLineToolStripMenuItem.Text = "New Line"
        '
        'NewGaugeTypeToolStripMenuItem
        '
        Me.NewGaugeTypeToolStripMenuItem.Name = "NewGaugeTypeToolStripMenuItem"
        Me.NewGaugeTypeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NewGaugeTypeToolStripMenuItem.Text = "New Gauge Type"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteWorkstationToolStripMenuItem, Me.DeleteLineToolStripMenuItem, Me.DeleteGaugeToolStripMenuItem})
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DeleteWorkstationToolStripMenuItem
        '
        Me.DeleteWorkstationToolStripMenuItem.Name = "DeleteWorkstationToolStripMenuItem"
        Me.DeleteWorkstationToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DeleteWorkstationToolStripMenuItem.Text = "Delete Workstation"
        '
        'DeleteLineToolStripMenuItem
        '
        Me.DeleteLineToolStripMenuItem.Name = "DeleteLineToolStripMenuItem"
        Me.DeleteLineToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DeleteLineToolStripMenuItem.Text = "Delete Line"
        '
        'DeleteGaugeToolStripMenuItem
        '
        Me.DeleteGaugeToolStripMenuItem.Name = "DeleteGaugeToolStripMenuItem"
        Me.DeleteGaugeToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DeleteGaugeToolStripMenuItem.Text = "Delete Gauge"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateWorkstationToolStripMenuItem, Me.UpdateLineToolStripMenuItem, Me.UpPdateToolStripMenuItem, Me.UpdateGuaugeToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Modify"
        '
        'UpdateWorkstationToolStripMenuItem
        '
        Me.UpdateWorkstationToolStripMenuItem.Name = "UpdateWorkstationToolStripMenuItem"
        Me.UpdateWorkstationToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UpdateWorkstationToolStripMenuItem.Text = "Modify Workstation"
        '
        'UpdateLineToolStripMenuItem
        '
        Me.UpdateLineToolStripMenuItem.Name = "UpdateLineToolStripMenuItem"
        Me.UpdateLineToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UpdateLineToolStripMenuItem.Text = "Modify Line"
        '
        'UpPdateToolStripMenuItem
        '
        Me.UpPdateToolStripMenuItem.Name = "UpPdateToolStripMenuItem"
        Me.UpPdateToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UpPdateToolStripMenuItem.Text = "Modify Gauge"
        '
        'UpdateGuaugeToolStripMenuItem
        '
        Me.UpdateGuaugeToolStripMenuItem.Name = "UpdateGuaugeToolStripMenuItem"
        Me.UpdateGuaugeToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UpdateGuaugeToolStripMenuItem.Text = "Modify Gauge Type"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelsToolStripMenuItem, Me.ZPrint2ToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'LabelsToolStripMenuItem
        '
        Me.LabelsToolStripMenuItem.Name = "LabelsToolStripMenuItem"
        Me.LabelsToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.LabelsToolStripMenuItem.Text = "Labels"
        '
        'ZPrint2ToolStripMenuItem
        '
        Me.ZPrint2ToolStripMenuItem.Name = "ZPrint2ToolStripMenuItem"
        Me.ZPrint2ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ZPrint2ToolStripMenuItem.Text = "Print ZPL Labels"
        '
        'GBAssignment
        '
        Me.GBAssignment.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GBAssignment.Controls.Add(Me.LBARComment)
        Me.GBAssignment.Controls.Add(Me.LSBARWorkstationID)
        Me.GBAssignment.Controls.Add(Me.LSBARLine)
        Me.GBAssignment.Controls.Add(Me.BTAssignReassign)
        Me.GBAssignment.Controls.Add(Me.TBAROtherLocation)
        Me.GBAssignment.Controls.Add(Me.Label1)
        Me.GBAssignment.Controls.Add(Me.TBARWorkstationDescript)
        Me.GBAssignment.Controls.Add(Me.Label2)
        Me.GBAssignment.Controls.Add(Me.Label3)
        Me.GBAssignment.Controls.Add(Me.Label6)
        Me.GBAssignment.Controls.Add(Me.TBARDept)
        Me.GBAssignment.Controls.Add(Me.LBARDept)
        Me.GBAssignment.Controls.Add(Me.TBOtherLocation)
        Me.GBAssignment.Controls.Add(Me.LBOtherLocation)
        Me.GBAssignment.Controls.Add(Me.TBWSDescript)
        Me.GBAssignment.Controls.Add(Me.LBWSDescript)
        Me.GBAssignment.Controls.Add(Me.TBWorkstation)
        Me.GBAssignment.Controls.Add(Me.LBWorkstationID)
        Me.GBAssignment.Controls.Add(Me.LBColor)
        Me.GBAssignment.Controls.Add(Me.TBLineColor)
        Me.GBAssignment.Controls.Add(Me.BLLineColor)
        Me.GBAssignment.Controls.Add(Me.TBLine)
        Me.GBAssignment.Controls.Add(Me.LBLine)
        Me.GBAssignment.Controls.Add(Me.TBDepartment)
        Me.GBAssignment.Controls.Add(Me.LBDept)
        Me.GBAssignment.Location = New System.Drawing.Point(12, 156)
        Me.GBAssignment.Name = "GBAssignment"
        Me.GBAssignment.Size = New System.Drawing.Size(586, 328)
        Me.GBAssignment.TabIndex = 12
        Me.GBAssignment.TabStop = False
        Me.GBAssignment.Text = "Gauge Assignment:"
        '
        'LBARComment
        '
        Me.LBARComment.AutoSize = True
        Me.LBARComment.ForeColor = System.Drawing.Color.Red
        Me.LBARComment.Location = New System.Drawing.Point(139, 136)
        Me.LBARComment.Name = "LBARComment"
        Me.LBARComment.Size = New System.Drawing.Size(260, 13)
        Me.LBARComment.TabIndex = 29
        Me.LBARComment.Text = "Workstation ID must be 0 (zero) for ""Other Location."" "
        '
        'LSBARWorkstationID
        '
        Me.LSBARWorkstationID.FormattingEnabled = True
        Me.LSBARWorkstationID.Location = New System.Drawing.Point(93, 228)
        Me.LSBARWorkstationID.Name = "LSBARWorkstationID"
        Me.LSBARWorkstationID.Size = New System.Drawing.Size(179, 56)
        Me.LSBARWorkstationID.TabIndex = 28
        '
        'LSBARLine
        '
        Me.LSBARLine.FormattingEnabled = True
        Me.LSBARLine.Location = New System.Drawing.Point(44, 166)
        Me.LSBARLine.Name = "LSBARLine"
        Me.LSBARLine.Size = New System.Drawing.Size(135, 56)
        Me.LSBARLine.TabIndex = 27
        '
        'BTAssignReassign
        '
        Me.BTAssignReassign.Location = New System.Drawing.Point(12, 131)
        Me.BTAssignReassign.Name = "BTAssignReassign"
        Me.BTAssignReassign.Size = New System.Drawing.Size(118, 23)
        Me.BTAssignReassign.TabIndex = 26
        Me.BTAssignReassign.Text = "Assign/Reassign"
        Me.BTAssignReassign.UseVisualStyleBackColor = True
        '
        'TBAROtherLocation
        '
        Me.TBAROtherLocation.Location = New System.Drawing.Point(93, 293)
        Me.TBAROtherLocation.Name = "TBAROtherLocation"
        Me.TBAROtherLocation.Size = New System.Drawing.Size(265, 20)
        Me.TBAROtherLocation.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Other Location:"
        '
        'TBARWorkstationDescript
        '
        Me.TBARWorkstationDescript.Enabled = False
        Me.TBARWorkstationDescript.Location = New System.Drawing.Point(407, 229)
        Me.TBARWorkstationDescript.Name = "TBARWorkstationDescript"
        Me.TBARWorkstationDescript.Size = New System.Drawing.Size(170, 20)
        Me.TBARWorkstationDescript.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Workstation Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Workstation ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Line:"
        '
        'TBARDept
        '
        Me.TBARDept.Enabled = False
        Me.TBARDept.Location = New System.Drawing.Point(257, 167)
        Me.TBARDept.Name = "TBARDept"
        Me.TBARDept.Size = New System.Drawing.Size(317, 20)
        Me.TBARDept.TabIndex = 14
        '
        'LBARDept
        '
        Me.LBARDept.AutoSize = True
        Me.LBARDept.Location = New System.Drawing.Point(185, 170)
        Me.LBARDept.Name = "LBARDept"
        Me.LBARDept.Size = New System.Drawing.Size(65, 13)
        Me.LBARDept.TabIndex = 13
        Me.LBARDept.Text = "Department:"
        '
        'TBOtherLocation
        '
        Me.TBOtherLocation.Enabled = False
        Me.TBOtherLocation.Location = New System.Drawing.Point(95, 95)
        Me.TBOtherLocation.Name = "TBOtherLocation"
        Me.TBOtherLocation.Size = New System.Drawing.Size(265, 20)
        Me.TBOtherLocation.TabIndex = 12
        '
        'LBOtherLocation
        '
        Me.LBOtherLocation.AutoSize = True
        Me.LBOtherLocation.Location = New System.Drawing.Point(9, 98)
        Me.LBOtherLocation.Name = "LBOtherLocation"
        Me.LBOtherLocation.Size = New System.Drawing.Size(80, 13)
        Me.LBOtherLocation.TabIndex = 11
        Me.LBOtherLocation.Text = "Other Location:"
        '
        'TBWSDescript
        '
        Me.TBWSDescript.Enabled = False
        Me.TBWSDescript.Location = New System.Drawing.Point(136, 69)
        Me.TBWSDescript.Name = "TBWSDescript"
        Me.TBWSDescript.Size = New System.Drawing.Size(224, 20)
        Me.TBWSDescript.TabIndex = 10
        '
        'LBWSDescript
        '
        Me.LBWSDescript.AutoSize = True
        Me.LBWSDescript.Location = New System.Drawing.Point(7, 72)
        Me.LBWSDescript.Name = "LBWSDescript"
        Me.LBWSDescript.Size = New System.Drawing.Size(123, 13)
        Me.LBWSDescript.TabIndex = 9
        Me.LBWSDescript.Text = "Workstation Description:"
        '
        'TBWorkstation
        '
        Me.TBWorkstation.Enabled = False
        Me.TBWorkstation.Location = New System.Drawing.Point(95, 43)
        Me.TBWorkstation.Name = "TBWorkstation"
        Me.TBWorkstation.Size = New System.Drawing.Size(126, 20)
        Me.TBWorkstation.TabIndex = 8
        '
        'LBWorkstationID
        '
        Me.LBWorkstationID.AutoSize = True
        Me.LBWorkstationID.Location = New System.Drawing.Point(7, 46)
        Me.LBWorkstationID.Name = "LBWorkstationID"
        Me.LBWorkstationID.Size = New System.Drawing.Size(81, 13)
        Me.LBWorkstationID.TabIndex = 7
        Me.LBWorkstationID.Text = "Workstation ID:"
        '
        'LBColor
        '
        Me.LBColor.AutoSize = True
        Me.LBColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBColor.Location = New System.Drawing.Point(560, 20)
        Me.LBColor.Name = "LBColor"
        Me.LBColor.Size = New System.Drawing.Size(12, 15)
        Me.LBColor.TabIndex = 6
        Me.LBColor.Text = " "
        '
        'TBLineColor
        '
        Me.TBLineColor.Enabled = False
        Me.TBLineColor.Location = New System.Drawing.Point(444, 16)
        Me.TBLineColor.Name = "TBLineColor"
        Me.TBLineColor.Size = New System.Drawing.Size(100, 20)
        Me.TBLineColor.TabIndex = 5
        '
        'BLLineColor
        '
        Me.BLLineColor.AutoSize = True
        Me.BLLineColor.Location = New System.Drawing.Point(381, 20)
        Me.BLLineColor.Name = "BLLineColor"
        Me.BLLineColor.Size = New System.Drawing.Size(57, 13)
        Me.BLLineColor.TabIndex = 4
        Me.BLLineColor.Text = "Line Color:"
        '
        'TBLine
        '
        Me.TBLine.Enabled = False
        Me.TBLine.Location = New System.Drawing.Point(221, 16)
        Me.TBLine.Name = "TBLine"
        Me.TBLine.Size = New System.Drawing.Size(154, 20)
        Me.TBLine.TabIndex = 3
        '
        'LBLine
        '
        Me.LBLine.AutoSize = True
        Me.LBLine.Location = New System.Drawing.Point(185, 19)
        Me.LBLine.Name = "LBLine"
        Me.LBLine.Size = New System.Drawing.Size(30, 13)
        Me.LBLine.TabIndex = 2
        Me.LBLine.Text = "Line:"
        '
        'TBDepartment
        '
        Me.TBDepartment.Enabled = False
        Me.TBDepartment.Location = New System.Drawing.Point(78, 16)
        Me.TBDepartment.Name = "TBDepartment"
        Me.TBDepartment.Size = New System.Drawing.Size(100, 20)
        Me.TBDepartment.TabIndex = 1
        '
        'LBDept
        '
        Me.LBDept.AutoSize = True
        Me.LBDept.Location = New System.Drawing.Point(6, 19)
        Me.LBDept.Name = "LBDept"
        Me.LBDept.Size = New System.Drawing.Size(65, 13)
        Me.LBDept.TabIndex = 0
        Me.LBDept.Text = "Department:"
        '
        'TBScan
        '
        Me.TBScan.Location = New System.Drawing.Point(280, 29)
        Me.TBScan.Name = "TBScan"
        Me.TBScan.Size = New System.Drawing.Size(100, 20)
        Me.TBScan.TabIndex = 13
        '
        'LBScan
        '
        Me.LBScan.AutoSize = True
        Me.LBScan.Location = New System.Drawing.Point(239, 35)
        Me.LBScan.Name = "LBScan"
        Me.LBScan.Size = New System.Drawing.Size(35, 13)
        Me.LBScan.TabIndex = 14
        Me.LBScan.Text = "Scan:"
        '
        'TBScanCode
        '
        Me.TBScanCode.Enabled = False
        Me.TBScanCode.Location = New System.Drawing.Point(450, 29)
        Me.TBScanCode.Name = "TBScanCode"
        Me.TBScanCode.Size = New System.Drawing.Size(100, 20)
        Me.TBScanCode.TabIndex = 15
        '
        'LBLastScan
        '
        Me.LBLastScan.AutoSize = True
        Me.LBLastScan.Location = New System.Drawing.Point(386, 32)
        Me.LBLastScan.Name = "LBLastScan"
        Me.LBLastScan.Size = New System.Drawing.Size(58, 13)
        Me.LBLastScan.TabIndex = 16
        Me.LBLastScan.Text = "Last Scan:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 496)
        Me.Controls.Add(Me.LBLastScan)
        Me.Controls.Add(Me.TBScanCode)
        Me.Controls.Add(Me.LBScan)
        Me.Controls.Add(Me.TBScan)
        Me.Controls.Add(Me.GBAssignment)
        Me.Controls.Add(Me.TBQuant)
        Me.Controls.Add(Me.LBCurrentQuant)
        Me.Controls.Add(Me.TBReorderPoint)
        Me.Controls.Add(Me.LBReorderPoint)
        Me.Controls.Add(Me.LSBGauge)
        Me.Controls.Add(Me.LBGaugeType)
        Me.Controls.Add(Me.TBGaugeType)
        Me.Controls.Add(Me.LBGauge)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Quality Gauges"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBAssignment.ResumeLayout(False)
        Me.GBAssignment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBGauge As System.Windows.Forms.Label
    Friend WithEvents TBGaugeType As System.Windows.Forms.TextBox
    Friend WithEvents LBGaugeType As System.Windows.Forms.Label
    Friend WithEvents LSBGauge As System.Windows.Forms.ListBox
    Friend WithEvents LBReorderPoint As System.Windows.Forms.Label
    Friend WithEvents TBReorderPoint As System.Windows.Forms.TextBox
    Friend WithEvents LBCurrentQuant As System.Windows.Forms.Label
    Friend WithEvents TBQuant As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GBAssignment As System.Windows.Forms.GroupBox
    Friend WithEvents TBDepartment As System.Windows.Forms.TextBox
    Friend WithEvents LBDept As System.Windows.Forms.Label
    Friend WithEvents LBColor As System.Windows.Forms.Label
    Friend WithEvents TBLineColor As System.Windows.Forms.TextBox
    Friend WithEvents BLLineColor As System.Windows.Forms.Label
    Friend WithEvents TBLine As System.Windows.Forms.TextBox
    Friend WithEvents LBLine As System.Windows.Forms.Label
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGaugeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWorkstationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGaugeTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBWorkstation As System.Windows.Forms.TextBox
    Friend WithEvents LBWorkstationID As System.Windows.Forms.Label
    Friend WithEvents TBWSDescript As System.Windows.Forms.TextBox
    Friend WithEvents LBWSDescript As System.Windows.Forms.Label
    Friend WithEvents TBOtherLocation As System.Windows.Forms.TextBox
    Friend WithEvents LBOtherLocation As System.Windows.Forms.Label
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TBScan As System.Windows.Forms.TextBox
    Friend WithEvents LBScan As System.Windows.Forms.Label
    Friend WithEvents TBScanCode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTAssignReassign As System.Windows.Forms.Button
    Friend WithEvents TBAROtherLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBARWorkstationDescript As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBARDept As System.Windows.Forms.TextBox
    Friend WithEvents LBARDept As System.Windows.Forms.Label
    Friend WithEvents LBARComment As System.Windows.Forms.Label
    Friend WithEvents LSBARWorkstationID As System.Windows.Forms.ListBox
    Friend WithEvents LSBARLine As System.Windows.Forms.ListBox
    Friend WithEvents LBLastScan As System.Windows.Forms.Label
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteWorkstationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteGaugeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateWorkstationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpPdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateGuaugeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZPrint2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
