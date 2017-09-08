Imports System.Data.OleDb
Public Class DeleteWorkstation
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim WorkStationArray(500) As String
    Dim temptext As String
    Dim defaultDate As Date = Now
    Dim QualityLineID As Integer = 0
    Dim WorkstationID As Integer = 0
    Public myConnection As OleDbConnection = New OleDbConnection

    Public dr As OleDbDataReader
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        TBDelWorkstationLineDesc.Enabled = False
        TBDelWorkstationLineNum.Enabled = False
        TBDelWorkstationDesc.Enabled = False
        BTDelWorkstation.Enabled = False
        Dim temptext As String
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
            WorkStationArray(X) = dr("WorkStation ID").ToString
            X = X + 1
        End While

        myConnection.Close()
        LSBDelWorkstationID.Items.Clear()
        Dim Y As Integer = 0
        For Y = 0 To X
            If WorkStationArray(Y) = "" Then
                On Error Resume Next
            Else
                LSBDelWorkstationID.Items.Add(WorkStationArray(Y))
            End If
        Next
        myConnection.Open()
        str = "SELECT * FROM Line"
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            If (("Line Description").ToString).ToUpper = "QUALITY" Then
                QualityLineID = dr("ID").ToString
            End If
        End While
        myConnection.Close()
        AddHandler LSBDelWorkstationID.SelectedValueChanged, AddressOf LSBDelWorkstationID_SelectedValueChanged

    End Sub



    Private Sub BTDelGauge_Click(sender As Object, e As EventArgs) Handles BTDelWorkstation.Click
        Dim icount As Integer
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile


        Dim str As String


        Try
            myConnection.Open()
            str = "UPDATE Location SET [Line ID] = " & QualityLineID & ", [WorkStation ID] = 0, [Other Location] = 'Spare' WHERE [WorkStation ID] = " & WorkstationID & ";"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd.ExecuteNonQuery
            myConnection.Close()
            MessageBox.Show(icount & " Gauges Moved to Quality Location")
            myConnection.ConnectionString = connString
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source & vbCrLf & str)
            myConnection.Close()
            Call Quality_Gauges.Main.Form1_Load(Me, e)
        End Try
        Try
            myConnection.Open()
            str = "DELETE * FROM [WorkStation] WHERE [WorkStation ID] = '" & (LSBDelWorkstationID.SelectedItem).ToString & "';"
            Dim cmd2 As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd2.ExecuteNonQuery
            myConnection.Close()
            MessageBox.Show(icount & " Workstation Deleted from Workstation")
            Call Quality_Gauges.Main.Form1_Load(Me, e)
            Me.Close()

        Catch ex As Exception

            Me.Close()
            'do nothing cause it does throw up a non existant error (timing issue)?
        End Try
    End Sub

    Private Sub BTCancel_Click(sender As Object, e As EventArgs) Handles BTCancel.Click
        Me.Close()
    End Sub


    Private Sub LSBDelWorkstationID_SelectedValueChanged(sender As Object, e As EventArgs)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM [WorkStation]"

        Dim cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            If dr("WorkStation ID") = (LSBDelWorkstationID.SelectedItem).ToString Then
                TBDelWorkstationDesc.Text = dr("WorkStation Description").ToString
                TBDelWorkstationLineNum.Text = dr("Line Number").ToString
                WorkstationID = dr("ID")
            End If
        End While
        myConnection.Close()
        myConnection.Open()
        str = "SELECT * FROM [Line] WHERE [ID] = " & TBDelWorkstationLineNum.Text & ""
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            TBDelWorkstationLineDesc.Text = dr("Line Description").ToString
        End While
        myConnection.Close()
        BTDelWorkstation.Enabled = True
    End Sub

End Class