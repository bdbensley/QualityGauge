Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class Form4
    Dim strPrinterPN As String
    Dim ScanCode As String
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim gaugeArray(500) As String

    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Public form7Value As String

    Public Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler ListBox1.SelectedValueChanged, AddressOf ListBox1_SelectedValueChanged
        Dim strPrinter$
        Dim objWMIService As Object
        Dim objPrinters As Object
        Dim objPrinter As Object
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
            'If X = 10 Then  *add this to limit print.
            'Exit While
            'End If
        End While
        'Array.Sort(gaugeArray) causes the printing to not print.
        Dim pkInstalledPrinters As String
        ' Find all printers installed
        X = 0
        For Each pkInstalledPrinters In _
            PrinterSettings.InstalledPrinters
            ListBox1.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters

        ' Set the combo to the first printer in the list
        'RadioButton1.SelectedIndex = -1

        objWMIService = GetObject("winmgmts:\\.\root\cimv2")
        objPrinters = objWMIService.ExecQuery("Select * From Win32_Printer")

        For Each objPrinter In objPrinters
            strPrinter = objPrinter.Name
            strPrinterPN = objPrinter.portname
            If strPrinter = ListBox1.SelectedItem Then
                TextBox1.Text = strPrinterPN$
            End If
            'cbo.AddItem strPrinter & " (" & strPrinterPN & ")"
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ipAddress As String = TextBox1.Text
        Dim port As Integer = 9100
        Dim ZPLString As String = _
        "^XA" & _
        "^FO50,50^B3N,N,100,Y,N^FDIL002^FS" & _
        "^XZ"

        ' note the text between the ^FD and the ^FS is the barcode information
        For Each item In gaugeArray
            If item <> "" Then
                ZPLString = _
                "^XA" & _
                "LH20,20" & _
                 "^FO50,30^AD^FD" & _
            item & _
            "^FS" & _
                "^FO50,50^B3N,N,100,Y,N^FD" & _
            item & _
            "^FS" & _
            "^XZ"

                'TextBox1.Text = ZPLString
                '        Application.DoEvents()
                'Threading.Thread.Sleep(1000)

                Try
                    'Open Connection
                    Dim client As New System.Net.Sockets.TcpClient
                    client.Connect(ipAddress, port)

                    'Write ZPL String to Connection
                    Dim writer As New System.IO.StreamWriter(client.GetStream())
                    writer.Write(ZPLString)
                    writer.Flush()

                    'Close(Connection)
                    writer.Close()
                    client.Close()

                Catch ex As Exception

                    'Catch Exception Here

                End Try
            End If

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub





    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs)
        Dim strPrinter$

        Dim objWMIService As Object
        Dim objPrinters As Object
        Dim objPrinter As Object
        'Dim ItemChecked As Integer
        objWMIService = GetObject("winmgmts:\\.\root\cimv2")
        objPrinters = objWMIService.ExecQuery("Select * From Win32_Printer")

        For Each objPrinter In objPrinters
            strPrinter = objPrinter.Name
            strPrinterPN = objPrinter.portname
            If strPrinter = ListBox1.SelectedItem Then
                TextBox1.Text = strPrinterPN$
            End If
            'cbo.AddItem strPrinter & " (" & strPrinterPN & ")"
        Next
        'ItemChecked = RadioButton1.SelectedIndex
        'For Each ItemChecked In CheckedListBox1.SelectedItems
        ' CheckedListBox1.SelectedIndex = -1
        ' Next

        'CheckedListBox1.SetItemChecked(ItemChecked, True)
    End Sub

End Class