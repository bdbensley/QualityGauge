
Option Explicit On
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections

Public Class Main

    Dim ScanCode As String
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim gaugeArray(500) As String
    Dim lineArray(500) As String
    Dim workstationArray(500) As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Public form7Value As String

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call CalcGaugeQuant()  'seems to work now
        BTAssignReassign.Enabled = False
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM Gauge"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            gaugeArray(X) = dr("Gauge ID").ToString
            X = X + 1
        End While
        Array.Sort(gaugeArray)
        LSBGauge.Items.Clear()
        For Each obj As Object In gaugeArray
            If obj = "" Then
                On Error Resume Next
            Else
                LSBGauge.Items.Add(obj)
            End If
        Next


        TBScan.Select()

        AddHandler LSBARLine.SelectedValueChanged, AddressOf LSARLine_SelectedValueChanged
        AddHandler LSBARWorkstationID.SelectedValueChanged, AddressOf LSBARWorkstationID_SelectedValueChanged
        'AddHandler LSBARWorkstationID.SelectedValueChanged, AddressOf LSBARWorkstationID_SelectedValueChanged
        AddHandler LSBGauge.SelectedValueChanged, AddressOf LSBGauge_SelectedValueChanged
    End Sub

    Public Sub LSBGauge_SelectedValueChanged(sender As Object, e As EventArgs)
        'don't know why but had to add this to close an open connection
        If myConnection.State() = ConnectionState.Open Then
            myConnection.Close()
        End If
        'end of unexplained open connection state.
        BTAssignReassign.Enabled = False
        myConnection.Open()
        TBGaugeType.Clear()
        TBReorderPoint.Clear()
        TBLine.Clear()
        TBLineColor.Clear()
        TBQuant.Clear()
        TBDepartment.Clear()
        TBOtherLocation.Clear()
        TBWorkstation.Clear()
        TBWSDescript.Clear()
        TBARDept.Clear()
        TBAROtherLocation.Clear()
        LBColor.BackColor = (Color.FromKnownColor(KnownColor.ActiveBorder))
        Dim gaugeType As Integer
        Dim reorderPoint As Integer
        Dim currentQuant As Integer
        Dim lineID As Integer
        Dim gaugeID As String
        Dim workStationID As Integer
        Dim otherLocation As String
        Dim lineColor As Color
        'AddHandler LSBARLine.SelectedValueChanged, AddressOf LSARLine_SelectedValueChanged ****** WRONG LOCATION CAUSED MULTIPLE RUNS
        'AddHandler LSBARWorkstationID.SelectedValueChanged, AddressOf LSBARWorkstationID_SelectedValueChanged
        Dim selectString As String = "SELECT * FROM Gauge"
        ' this line passes in the SQL statement and the OleDbConnection object.
        Dim cmd As OleDbCommand = New OleDbCommand(selectString, myConnection)
        'Send the CommandText to the connection, and then build an OleDbDataReader.
        dr = cmd.ExecuteReader
        'get anything scanned in

        gaugeID = LSBGauge.SelectedItem
        While dr.Read()
            If dr("Gauge ID").ToString = gaugeID Then
                gaugeType = dr("TypeID")
            End If
        End While
        'Close the reader and the related connection.
        myConnection.Close()

        myConnection.Open()
        selectString = "SELECT * FROM GaugeType"
        ' this line passes in the SQL statement and the OleDbConnection object.
        cmd = New OleDbCommand(selectString, myConnection)
        'Send the CommandText to the connection, and then build an OleDbDataReader.
        dr = cmd.ExecuteReader
        While dr.Read()
            If dr("Gauge Type ID").ToString = gaugeType Then
                TBGaugeType.Text = dr("Gauge Description").ToString
                reorderPoint = dr("Reorder Point")
                currentQuant = dr("Quantity")
                If reorderPoint >= currentQuant Then
                    TBReorderPoint.ForeColor = Color.Red
                Else
                    TBReorderPoint.ForeColor = Color.Black
                End If
                TBReorderPoint.Text = reorderPoint.ToString

                TBQuant.Text = currentQuant.ToString

            End If

        End While
        'Close the reader and the related connection.
        myConnection.Close()
        myConnection.Open()
        selectString = "SELECT * FROM Location"
        ' this line passes in the SQL statement and the OleDbConnection object.
        cmd = New OleDbCommand(selectString, myConnection)
        'Send the CommandText to the connection, and then build an OleDbDataReader. 
        dr = cmd.ExecuteReader

        While dr.Read()
            If dr("Gauge ID").ToString = gaugeID Then
                lineID = dr("Line ID")
                workStationID = dr("WorkStation ID")
                If Not IsDBNull(dr("Other Location")) Then
                    TBOtherLocation.Text = dr("Other Location")
                    otherLocation = dr("Other Location")

                End If
                If lineID > 0 Then
                    TBDepartment.Text = lineID.ToString
                    selectString = "SELECT * FROM Line"
                    ' this line passes in the SQL statement and the OleDbConnection object.
                    cmd = New OleDbCommand(selectString, myConnection)
                    'Send the CommandText to the connection, and then build an OleDbDataReader.
                    dr = cmd.ExecuteReader
                    While dr.Read()
                        If dr("ID") = lineID Then
                            TBDepartment.Text = dr("Department Number").ToString
                            TBLine.Text = dr("Line Description")
                            If dr("Line Color") Is DBNull.Value Then

                            Else
                                TBLineColor.Text = dr("Line Color")
                            End If
                            lineColor = Color.FromName(dr("Line Color").ToString)
                            LBColor.BackColor = lineColor
                        End If
                    End While
                End If
                If workStationID > 0 Then
                    selectString = "SELECT * FROM WorkStation"
                    ' this line passes in the SQL statement and the OleDbConnection object.
                    cmd = New OleDbCommand(selectString, myConnection)
                    'Send the CommandText to the connection, and then build an OleDbDataReader.
                    dr = cmd.ExecuteReader
                    While dr.Read()
                        If dr("ID") = workStationID Then
                            TBWorkstation.Text = dr("WorkStation ID")
                            If Not IsDBNull(dr("WorkStation Description")) Then
                                TBWSDescript.Text = dr("WorkStation Description")
                            End If
                        End If
                    End While
                End If
            End If

        End While

        myConnection.Close()

        'following loads the array for department lines and the list box for selection
        myConnection.Open()
        Dim counter As Integer
        For counter = 0 To (lineArray.Length - 1)
            lineArray(counter) = ""
        Next counter
        Dim str As String
        str = "SELECT * FROM Line"
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            lineArray(X) = dr("Department Number").ToString
            X = X + 1
        End While
        myConnection.Close()
        Array.Sort(lineArray)
        LSBARLine.Items.Clear()
        For Each obj As Object In lineArray
            If obj = "" Then
                On Error Resume Next
            Else
                LSBARLine.Items.Add(obj)
            End If
        Next
        'end of loading the department lines list box array

        'following loads the array for workstations and the list box for selection
        myConnection.Open()
        str = "SELECT * FROM Workstation"
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        workstationArray(0) = "0"
        X = 1
        While dr.Read()
            workstationArray(X) = dr("WorkStation ID").ToString
            X = X + 1
        End While
        myConnection.Close()
        'Array.Sort(workstationArray) won't work. duplicates values in array.
        LSBARWorkstationID.Items.Clear()
        For Each obj As Object In workstationArray
            If obj = "" Then
                On Error Resume Next
            Else
                LSBARWorkstationID.Items.Add(obj)
            End If
        Next
        'end of loading the workstations list box array
        'Throw New NotImplementedException
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NewGaugeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewGaugeToolStripMenuItem.Click
        NewGauge.Show()
    End Sub

    Private Sub NewWorkstationToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewWorkstationToolStripMenuItem.Click
        NewWorkstation.Show()
    End Sub

    Private Sub NewLineToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewLineToolStripMenuItem.Click
        NewLine.Show()
    End Sub

    Private Sub NewGaugeTypeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewGaugeTypeToolStripMenuItem.Click
        NewGaugeType.Show()
    End Sub


    Private Sub LabelsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabelsToolStripMenuItem.Click
        PrintLabels.Show()
    End Sub

    Public Sub LSARLine_SelectedValueChanged(sender As Object, e As EventArgs)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        BTAssignReassign.Enabled = True
        TBARDept.Enabled = False
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        GC.Collect() ' garbage collect
        myConnection.Open()

        Dim str As String
        str = "SELECT [Department Number], [Line Description] from Line"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        'cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            If dr("Department Number").ToString = (LSBARLine.SelectedItem).ToString Then
                'TBARDept.Enabled = True
                TBARDept.Text = dr("Line Description").ToString
                'TBARDept.Enabled = False
            End If
        End While
        'MessageBox.Show("after dr.read") debugging check
        Me.Cursor = System.Windows.Forms.Cursors.Default
        myConnection.Close()
        GC.Collect() ' garbage collect
        If Me.LSBARWorkstationID.SelectedIndex >= 0 Then
            LSBARWorkstationID.SetSelected(LSBARWorkstationID.SelectedIndex, True)
        Else
            LSBARWorkstationID.SetSelected(0, True)
            If LSBARLine.SelectedItem.ToString = "2001" Then
                TBAROtherLocation.Text = "Spare"
            End If
        End If

        If (LSBARLine.SelectedItem).ToString = "ILLINE02" Then

            Form7.Tag = "ILLINE02"
            Form7.Show()

        End If
        If (LSBARLine.SelectedItem).ToString = "ILLINE03" Then

            Form7.Tag = "ILLINE03"
            Form7.Show()

        End If

    End Sub
    Private Sub CalcGaugeQuant()
        Dim gaugeArray(500, 2)
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim tempValue = 0
        If myConnection.State() = ConnectionState.Open Then
            myConnection.Close()
        End If
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM GaugeType"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            tempValue = dr("Gauge Type ID")
            If tempValue.ToString > "0" Then
                gaugeArray(x, 0) = tempValue
            Else
                gaugeArray(x, 0) = 0
            End If
            x = x + 1
        End While
        myConnection.Close()
        myConnection.Open()
        str = "SELECT * FROM Gauge"
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            tempValue = dr("TypeID")
            For y = 0 To 500
                If gaugeArray(y, 0) = tempValue Then
                    gaugeArray(y, 1) = gaugeArray(y, 1) + 1
                End If
            Next
        End While
        myConnection.Close()

        myConnection.Open()
        cmd = New OleDbCommand(str, myConnection)
        For y = 0 To 500
            If gaugeArray(y, 0) = 0 Then
                Exit For
            ElseIf gaugeArray(y, 1) < 1 Then
                'do nothing
            Else
                str = "UPDATE GaugeType SET [Quantity] = " & gaugeArray(y, 1) & " WHERE [Gauge Type ID] = " & gaugeArray(y, 0) & ";"
                'MessageBox.Show(str)
                cmd = New OleDbCommand(str, myConnection)
                cmd.ExecuteNonQuery()
            End If
        Next
        myConnection.Close()
    End Sub

    Private Sub LSBARWorkstationID_SelectedValueChanged(sender As Object, e As EventArgs)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM WorkStation"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            If dr("WorkStation ID").ToString = (LSBARWorkstationID.SelectedItem).ToString Then
                TBARWorkstationDescript.Enabled = True
                TBARWorkstationDescript.Text = dr("WorkStation Description").ToString
                TBARWorkstationDescript.Enabled = False
            End If
        End While
        myConnection.Close()

        If LSBARWorkstationID.Text = "0" Then
            TBARWorkstationDescript.Text = ""
            TBAROtherLocation.Text = ""
        End If

    End Sub
    Private Sub TBAssignReassign_Click(sender As Object, e As EventArgs) Handles BTAssignReassign.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        Dim gaugeExists As Boolean = False
        myConnection.ConnectionString = connString
        'first check if the item is already assigned and then update
        Dim str As String
        str = "SELECT * FROM Location"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        'checking if gauge exists in location, if so set gaugeExists to true else false
        myConnection.Open()
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        gaugeExists = False
        While dr.Read()
            If dr("Gauge ID") = Trim(LSBGauge.SelectedItem) Then
                gaugeExists = True

            End If
        End While
        myConnection.Close()
        'end of gaugeExists test
        GC.Collect()
        Dim wsIDint As Integer = 0
        Dim lIDint As Integer = 0
        Dim olStr As String = ""

        myConnection.Open()
        str = "SELECT * FROM Line"
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            If dr("Department Number").ToString = (LSBARLine.SelectedItem).ToString And dr("Line Description") = Trim(TBARDept.Text) Then

                lIDint = dr("ID")
            End If
        End While
        myConnection.Close()
        If (LSBARWorkstationID.SelectedItem) <> "0" Then
            myConnection.Open()
            str = "SELECT * FROM WorkStation"
            cmd = New OleDbCommand(str, myConnection)
            dr = cmd.ExecuteReader
            While dr.Read()
                If dr("WorkStation ID").ToString = (LSBARWorkstationID.SelectedItem).ToString Then
                    wsIDint = dr("ID")
                End If
            End While
            myConnection.Close()
        End If
        GC.Collect()

        If Trim(TBAROtherLocation.Text) > "" Then
            olStr = Trim(TBAROtherLocation.Text)
        End If
        myConnection.Open()
        If gaugeExists = True Then
            If olStr = "" Then
                str = "UPDATE Location SET [Line ID] = '" & lIDint & "', [WorkStation ID] = '" & wsIDint & "', [Other Location] = '' WHERE [Gauge ID] ='" & Trim(LSBGauge.SelectedItem) & "';"
            Else
                str = "UPDATE Location SET [Line ID] = '" & lIDint & "', [WorkStation ID] = '" & wsIDint & "', [Other Location] = '" & olStr & " ' WHERE [Gauge ID] ='" & Trim(LSBGauge.SelectedItem) & "';"
            End If

            cmd = New OleDbCommand(str, myConnection)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Gauge Updated.")
        End If
        'second if it is not assigned then assign it
        If gaugeExists = False Then
            str = "INSERT INTO [Location] ([Gauge ID], [Line ID] , [WorkStation ID], [Other Location]) VALUES ('" & Trim(LSBGauge.SelectedItem) & "'," & lIDint & ", " & wsIDint & ", '" & olStr & "');"
            cmd = New OleDbCommand(str, myConnection)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Gauge Assigned.")
        End If
        myConnection.Close()
        GC.Collect()
        Call LSBGauge_SelectedValueChanged(Me, e)

    End Sub

    Private Sub TBScan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBScan.KeyPress
        If e.KeyChar = Chr(13) Then
            ScanCode = TBScan.Text
            If ScanCode <> "" Then
                'ScanCode = ScanCode.Remove(0, 1)
                'ScanCode = ScanCode.Remove(ScanCode.Length - 1)
                TBScanCode.Text = ScanCode
                Dim index As Integer = LSBGauge.FindString(ScanCode)
                ' If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
                If index = -1 Then
                    MessageBox.Show("Item is not available in Gauge ListBox")
                Else
                    LSBGauge.SetSelected(index, True)
                End If
                'end of get anything scanned in
            End If
            TBScan.Text = ""
            Exit Sub
        End If
    End Sub


    Private Sub DeleteWorkstationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteWorkstationToolStripMenuItem.Click
        DeleteWorkstation.Show()
    End Sub

    Private Sub DeleteGaugeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteGaugeToolStripMenuItem.Click
        DeleteGauge.Show()
    End Sub

    Private Sub DeleteLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteLineToolStripMenuItem.Click
        DeleteLine.Show()
    End Sub

    Private Sub UpdateWorkstationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateWorkstationToolStripMenuItem.Click
        ModifyWorkstation.Show()
    End Sub

    Private Sub UpdateLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateLineToolStripMenuItem.Click
        ModifyLine.Show()
    End Sub

    Private Sub UpPdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpPdateToolStripMenuItem.Click
        ModifyGauge.Show()
    End Sub

    Private Sub UpdateGuaugeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateGuaugeToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ZPrint2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZPrint2ToolStripMenuItem.Click
        Form4.Show()
    End Sub
End Class
