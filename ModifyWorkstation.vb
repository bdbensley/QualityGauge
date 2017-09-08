Imports System.Data.OleDb
Public Class ModifyWorkstation
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim WSArray(500, 2) As String
    Dim lineArray(500) As String
    Dim temptext As String
    Dim defaultDate As Date = Now
    Dim lineID As Integer = 0

    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
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
            WSArray(X, 0) = dr("WorkStation ID").ToString
            WSArray(X, 1) = dr("Line Number").ToString
            WSArray(X, 2) = dr("WorkStation Description").ToString
            X = X + 1
        End While
        myConnection.Close()

        LSBMWorkstation.Items.Clear()
        Dim Z As Integer = 0
        For Z = 0 To X - 1
            LSBMWorkstation.Items.Add(WSArray(Z, 0))
        Next
    End Sub



    Private Sub LSBMWorkstation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBMWorkstation.SelectedIndexChanged

        For TX As Integer = 0 To 500
            If WSArray(TX, 0) = LSBMWorkstation.SelectedItem Then
                temptext = WSArray(TX, 1)
            End If
        Next
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM Line"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            lineArray(X) = dr("Line Description").ToString

            X = X + 1
        End While
        myConnection.Close()
        LSBLineDesc.Items.Clear()
        For Each obj As Object In lineArray
            If obj = "" Then
                On Error Resume Next
            Else
                LSBLineDesc.Items.Add(obj)
            End If
        Next

    End Sub

    Private Sub LSBLineDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBLineDesc.SelectedIndexChanged
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM Line"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            If dr("Line Description").ToString = LSBLineDesc.SelectedItem Then
                TBDeptNum.Text = dr("Department Number").ToString
                lineID = dr("ID")
            End If
            X = X + 1
        End While
        myConnection.Close()
        LSBLineDesc.Items.Clear()
        For Each obj As Object In lineArray
            If obj = "" Then
                On Error Resume Next
            Else
                LSBLineDesc.Items.Add(obj)
            End If
        Next
    End Sub
    Private Sub BTSaveModifiedWS_Click(sender As Object, e As EventArgs) Handles BTSaveModifiedWS.Click
        Dim icount As Integer
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile


        Dim str As String


        Try
            myConnection.Open()
            str = "UPDATE WorkStation SET [Line Number] = " & lineID & ", [WorkStation Description] = '" & TBMWSDescript.Text & "' WHERE [WorkStation ID] = '" & LSBMWorkstation.SelectedItem & "';"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd.ExecuteNonQuery
            myConnection.Close()
            MessageBox.Show(icount & " Workstation modified in Workstation table")
            myConnection.ConnectionString = connString
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source & vbCrLf & str)
            myConnection.Close()
            Call Main.LSBGauge_SelectedValueChanged(Me, e)
            Call Quality_Gauges.Main.Form1_Load(Me, e)
        End Try

        Me.Close()
        Call Main.LSBGauge_SelectedValueChanged(Me, e)
        Call Main.Form1_Load(Me, e)
    End Sub





    Private Sub BTCancel_Click(sender As Object, e As EventArgs) Handles BTCancel.Click
        Me.Close()
    End Sub



End Class