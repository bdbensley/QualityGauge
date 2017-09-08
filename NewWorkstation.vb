Imports System.Data.OleDb
Public Class NewWorkstation
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim WSArray(500) As String
    Dim lineArray(500, 2) As String
    Dim temptext As String
    Dim defaultDate As Date = Now

    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        TBWSAvailable.Enabled = False
        LSBNWSLineDesc.Enabled = False
        TBLineID.Enabled = False
        TBNWSLineNum.Enabled = False
        TBNWSDescript.Enabled = False
        BTSaveNewWS.Enabled = False
        TBWSAvailable.BackColor = Color.White
        TBWSAvailable.ReadOnly = True
        TBWSAvailable.ForeColor = Color.Black
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM WorkStation"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            WSArray(X) = dr("WorkStation ID").ToString
            X = X + 1
        End While
        myConnection.Close()


    End Sub

    Private Sub BTCheckGaugeAvailable_Click(sender As Object, e As EventArgs) Handles BTWSCheckAvailable.Click
        TBWSAvailable.Clear()
        TBNWSDescript.Clear()
        LSBNWSLineDesc.ClearSelected()

        Dim X As Integer = 0

        For X = 0 To 500

            temptext = Trim(WSArray(X)).ToUpper
            If temptext = Trim(TBWorkStationID.Text) Then
                TBWSAvailable.Enabled = True
                TBWSAvailable.ForeColor = Color.Red
                TBWSAvailable.Text = "Not Available"
                LSBNWSLineDesc.Enabled = False
                TBNWSDescript.Enabled = False
                BTSaveNewWS.Enabled = False

                TBWorkStationID.Select()
                Exit For
            Else
                TBWSAvailable.Enabled = True
                TBWSAvailable.ForeColor = Color.Black
                TBWSAvailable.Text = "Available"
                LSBNWSLineDesc.Enabled = True
                TBNWSDescript.Enabled = True
                BTSaveNewWS.Enabled = True
            End If
        Next
        LSBNWSLineDesc.Items.Clear()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM Line"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim Y As Integer = 0
        While dr.Read()
            lineArray(Y, 0) = dr("ID").ToString
            lineArray(Y, 1) = dr("Department Number").ToString
            lineArray(Y, 2) = dr("Line Description").ToString
            Y = Y + 1
        End While
        myConnection.Close()
        LSBNWSLineDesc.Items.Clear()
        Dim Z As Integer = 0
        For Z = 0 To X
            If lineArray(Z, 1) = "" Then
                On Error Resume Next
            Else
                LSBNWSLineDesc.Items.Add(lineArray(Z, 2))
            End If
        Next

    End Sub


    Private Sub LSBNWSLineDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBNWSLineDesc.SelectedIndexChanged
        Dim Y As Integer = 0
        Dim argonLineCheck As Integer = 0
        For Y = 0 To 500

            If lineArray(Y, 2) = "" Then
                On Error Resume Next
            ElseIf lineArray(Y, 2) = LSBNWSLineDesc.Text Then
                TBLineID.Text = lineArray(Y, 0)
                TBNWSLineNum.Text = lineArray(Y, 1)
            End If

        Next
    End Sub


    Private Sub BTSaveNewWS_Click(sender As Object, e As EventArgs) Handles BTSaveNewWS.Click
        Dim icount As Integer
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO WorkStation ([WorkStation ID], [Line Number], [WorkStation Description]) VALUES ('" + TBWorkStationID.Text + "', " + TBLineID.Text + ", '" + TBNWSDescript.Text + "')"
        Try
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd.ExecuteNonQuery
            MessageBox.Show(icount & " Record Saved")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source & vbCrLf & str)
            myConnection.Close()
        End Try
    End Sub




    Private Sub BTCancel_Click(sender As Object, e As EventArgs) Handles BTCancel.Click
        Me.Close()
    End Sub
End Class