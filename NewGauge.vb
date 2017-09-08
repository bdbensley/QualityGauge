Imports System.Data.OleDb
Public Class NewGauge
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim gaugeArray(500) As String
    Dim gaugeTypeArray(500, 1) As String

    Dim temptext As String
    Dim defaultDate As Date = Now

    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        TBNGaugePurchaseDate.Enabled = False
        LSBNGaugeType.Enabled = False
        TBNComment.Enabled = False
        TBGaugeAvailable.Enabled = False
        TBNGaugeTypeID.Enabled = False
        BTSaveNewGauge.Enabled = False
        TBGaugeAvailable.BackColor = Color.White
        TBGaugeAvailable.ReadOnly = True
        TBGaugeAvailable.ForeColor = Color.Black
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
            gaugeArray(X) = dr("Gauge ID").ToString
            X = X + 1
        End While
        str = "SELECT * FROM GaugeType"
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        X = 0
        While dr.Read()
            gaugeTypeArray(X, 0) = dr("Gauge Type ID").ToString
            gaugeTypeArray(X, 1) = dr("Gauge Description").ToString
            X = X + 1
        End While
        myConnection.Close()
        LSBNGaugeType.Items.Clear()
        Dim Y As Integer = 0
        For Y = 0 To X
            If gaugeTypeArray(Y, 1) = "" Then
                On Error Resume Next
            Else
                LSBNGaugeType.Items.Add(gaugeTypeArray(Y, 1))
            End If
        Next



    End Sub

    Private Sub BTCheckGaugeAvailable_Click(sender As Object, e As EventArgs) Handles BTCheckGaugeAvailable.Click
        TBGaugeAvailable.Clear()
        TBNGaugePurchaseDate.Clear()
        TBNComment.Clear()
        TBGaugeID.Text = TBGaugeID.Text.ToUpper
        TBNGaugePurchaseDate.Text = (defaultDate.ToShortDateString)
        For Each obj As Object In gaugeArray
            temptext = Trim(CType(obj, String)).ToUpper
            If temptext = Trim(TBGaugeID.Text) Then
                TBGaugeAvailable.Enabled = True
                TBGaugeAvailable.ForeColor = Color.Red
                TBGaugeAvailable.Text = "Not Available"
                TBNGaugePurchaseDate.Enabled = False
                LSBNGaugeType.Enabled = False
                TBNComment.Enabled = False
                BTSaveNewGauge.Enabled = False
                TBGaugeID.Select()
                Exit For
            Else
                TBGaugeAvailable.Enabled = True
                TBGaugeAvailable.ForeColor = Color.Black
                TBGaugeAvailable.Text = "Available"
                TBNGaugePurchaseDate.Enabled = True
                LSBNGaugeType.Enabled = True
                TBNComment.Enabled = True
                BTSaveNewGauge.Enabled = True
            End If
        Next
    End Sub


    Private Sub LSBNGaugeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBNGaugeType.SelectedIndexChanged
        Dim Y As Integer = 0
        Dim X As Integer = 0
        For Y = 0 To 500
            If gaugeTypeArray(Y, 1) = "" Then
                On Error Resume Next
            ElseIf gaugeTypeArray(Y, 1) = LSBNGaugeType.SelectedItem Then
                TBNGaugeTypeID.Text = gaugeTypeArray(Y, 0).ToString
            End If
        Next
    End Sub


    Private Sub BTSaveNewGauge_Click(sender As Object, e As EventArgs) Handles BTSaveNewGauge.Click
        Dim icount As Integer
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO Gauge ([Gauge ID], [Gauge Purchase Date], [TypeID], [Comment]) VALUES ('" + TBGaugeID.Text + "', '" + TBNGaugePurchaseDate.Text + "', " + TBNGaugeTypeID.Text + ", '" + TBNComment.Text + "')"
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