Imports System.Data.OleDb
Public Class NewGaugeType
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim GaugeTypeArray(500) As Integer
    Dim NextGaugeID As Integer = 0
    Dim defaultDate As Date = Now

    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM GaugeType"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            GaugeTypeArray(X) = dr("Gauge Type ID")
            If dr("Gauge Type ID") > NextGaugeID Then
                NextGaugeID = dr("Gauge Type ID")
            End If
            X = X + 1
        End While
        myConnection.Close()
        TBGaugeTypeID.Text = (NextGaugeID + 1).ToString

    End Sub

    Private Sub BTSaveNewWS_Click(sender As Object, e As EventArgs) Handles BTSaveNewWS.Click
        Dim icount As Integer
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO GaugeType ([Gauge Type ID], [Gauge Description], [Reorder Point]) VALUES (" + TBGaugeTypeID.Text + ", '" + TBNGaugeDescript.Text + "', " + NUDReorderPoint.Value.ToString + ")"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class