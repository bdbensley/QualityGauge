Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class PrintLabels
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim GaugeArray(500) As String

    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
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
            GaugeArray(X) = dr("Gauge ID")
            RTBLabels.SelectionFont = New Font("C39P24DmTt", 20)
            RTBLabels.SelectionColor = System.Drawing.Color.Black
            'RTBLabels.AppendText("*Q" & GaugeArray(X) & "G*" & vbCrLf)
            RTBLabels.SelectionFont = New Font("CALIBRI", 12)
            'RTBLabels.AppendText("*Q" & GaugeArray(X) & "G*" & vbCrLf & vbCrLf)
            X = X + 1
        End While
        myConnection.Close()


    End Sub
    Private Sub BTPrintAll_Click(sender As Object, e As EventArgs) Handles BTPrintAll.Click
        PrintDocument1.PrinterSettings.Copies = 1


        PrintDocument1.Print()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

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
            GaugeArray(X) = dr("Gauge ID")
            e.Graphics.DrawString(("*Q" & GaugeArray(X) & "G*"), New Font("C39P24DmTt", 20), Brushes.Black, 100, ((X * 50) + 50))
            e.Graphics.DrawString(("*Q" & GaugeArray(X) & "G*"), New Font("BROCBRT0", 12), Brushes.Black, 100, ((X * 50) + 75))
            X = X + 1
        End While
        myConnection.Close()



    End Sub
End Class