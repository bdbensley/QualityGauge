Imports System.Data.OleDb
Public Class ModifyGauge
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim gaugeIDArray(500) As String
    Dim gaugeDescArray(500) As String
    Dim temptext As String
    Dim defaultDate As Date = Now

    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub ModifyGauge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        BTModifyGauge.Enabled = False
        TBMGaugePurchaseDate.Text = defaultDate.Date
        'LSBMGaugeType.Enabled = False
        'TBMComment.Enabled = False
        TBMGaugeTypeID.Enabled = False
        TBNGaugeTypeID.Enabled = False
        'BTModifyGauge.Enabled = False
        Dim temptext As String
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
            gaugeIDArray(X) = dr("Gauge ID").ToString
            X = X + 1
        End While

        myConnection.Close()
        Array.Sort(gaugeIDArray)
        LSBMGauge.Items.Clear()
        Dim Y As Integer = 0
        For Y = 0 To X
            If gaugeIDArray(Y) = "" Then
                On Error Resume Next
            Else
                LSBMGauge.Items.Add(gaugeIDArray(Y))
            End If
        Next
        myConnection.Open()
        str = "SELECT * FROM GaugeType"
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        X = 0
        While dr.Read()
            'TBMComment.Text = dr("Gauge Description").ToString

            gaugeDescArray(X) = dr("Gauge Description").ToString
            X = X + 1
        End While

        myConnection.Close()
        'Array.Sort(gaugeDescArray) again, strange it doesn't work deletes the items in array
        LSBMGaugeType.Items.Clear()

        For Y = 0 To X

            If gaugeDescArray(Y) = "" Then
                On Error Resume Next
            Else
                LSBMGaugeType.Items.Add(gaugeDescArray(Y))
            End If
        Next


    End Sub
    Private Sub LSBMGauge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBMGauge.SelectedIndexChanged
        If LSBMGauge.SelectedIndex >= 0 And LSBMGaugeType.SelectedIndex >= 0 Then
            BTModifyGauge.Enabled = True
        End If
        myConnection.Open()
        Dim str As String
        str = "SELECT [TypeID] FROM Gauge WHERE [Gauge ID] = '" & LSBMGauge.SelectedItem & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            TBMGaugeTypeID.Text = dr("TypeID").ToString
        End While
        myConnection.Close()


    End Sub
    Private Sub LSBMGaugeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBMGaugeType.SelectedIndexChanged
        If LSBMGauge.SelectedIndex >= 0 And LSBMGaugeType.SelectedIndex >= 0 Then
            BTModifyGauge.Enabled = True
        End If
        myConnection.Open()
        Dim str As String
        str = "SELECT [Gauge Type ID] FROM GaugeType WHERE [Gauge Description] = '" & LSBMGaugeType.SelectedItem & "';"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            TBNGaugeTypeID.Text = dr("Gauge Type ID").ToString
        End While
        myConnection.Close()

    End Sub
    Private Sub BTModifyGauge_Click(sender As Object, e As EventArgs) Handles BTModifyGauge.Click
        If myConnection.State() = ConnectionState.Open Then
            myConnection.Close()
        End If
        Dim icount As Integer
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "UPDATE Gauge SET [Gauge Purchase Date] = '" & TBMGaugePurchaseDate.Text & "', [TypeID] = " & TBNGaugeTypeID.Text & ", [Comment] = '" & TBMComment.Text & "' WHERE [Gauge ID] = '" & LSBMGauge.SelectedItem & "';"
        Try
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd.ExecuteNonQuery
            MessageBox.Show(icount & " Record Saved")
            myConnection.Close()
            Me.Close()
            Call Quality_Gauges.Main.Form1_Load(Me, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source & vbCrLf & str)
            myConnection.Close()
            Main.LSBGauge.Items.Clear()
            Call Quality_Gauges.Main.Form1_Load(Me, e)
        End Try
    End Sub
    Private Sub BTCancel_Click(sender As Object, e As EventArgs) Handles BTCancel.Click
        Me.Close()
    End Sub

End Class