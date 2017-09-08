Imports System.Data.OleDb
Public Class DeleteGauge
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim gaugeArray(500) As String
    Dim gaugeTypeArray(500, 1) As String

    Dim temptext As String
    Dim defaultDate As Date = Now

    Public myConnection As OleDbConnection = New OleDbConnection

    Public dr As OleDbDataReader

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        TBDelGaugePurchaseDate.Enabled = False
        TBDelGaugeTypeID.Enabled = False
        TBDelComment.Enabled = False
        TBDelGaugeType.Enabled = False
        BTDelGauge.Enabled = False
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT [Gauge ID] FROM Gauge"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        Array.Clear(gaugeArray, 0, gaugeArray.Length)
        While dr.Read()
            If dr("Gauge ID").ToString <> "" Then
                gaugeArray(X) = dr("Gauge ID").ToString
                X = X + 1
            End If
        End While
        Array.Sort(gaugeArray)
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
        LSBDelGaugeID.Items.Clear()
        Dim Y As Integer = 0
        For Y = 0 To 500
            If gaugeArray(Y) = "" Then
                'On Error Resume Next
            Else
                LSBDelGaugeID.Items.Add(gaugeArray(Y))
            End If
        Next
        AddHandler LSBDelGaugeID.SelectedValueChanged, AddressOf LSBDelGaugeID_SelectedValueChanged


    End Sub



    Private Sub BTDelGauge_Click(sender As Object, e As EventArgs) Handles BTDelGauge.Click
        Dim icount As Integer
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile


        Dim str As String


        Try
            myConnection.Open()
            str = "DELETE * FROM [Location] WHERE [Gauge ID] = '" & (LSBDelGaugeID.SelectedItem).ToString & "';"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd.ExecuteNonQuery
            myConnection.Close()
            MessageBox.Show(icount & " Gauge Deleted from Location")
            myConnection.ConnectionString = connString
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source & vbCrLf & str)
            myConnection.Close()
            Call Quality_Gauges.Main.Form1_Load(Me, e)
        End Try
        Try
            myConnection.Open()
            str = "DELETE * FROM [Gauge] WHERE [Gauge ID] = '" & (LSBDelGaugeID.SelectedItem).ToString & "';"
            Dim cmd2 As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd2.ExecuteNonQuery
            myConnection.Close()
            MessageBox.Show(icount & " Gauge Deleted from Gauge")
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

    Private Sub LSBDelGaugeID_SelectedValueChanged(sender As Object, e As EventArgs)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM [Gauge]"

        Dim cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            If dr("Gauge ID") = (LSBDelGaugeID.SelectedItem).ToString Then
                TBDelGaugeTypeID.Text = dr("TypeID").ToString
                TBDelGaugePurchaseDate.Text = dr("Gauge Purchase Date").ToString
                TBDelComment.Text = dr("Comment").ToString
            End If
        End While
        myConnection.Close()
        myConnection.Open()
        str = "SELECT * FROM [GaugeType] WHERE [Gauge Type ID] = " & TBDelGaugeTypeID.Text & ""
        cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            TBDelGaugeType.Text = dr("Gauge Description").ToString
        End While
        myConnection.Close()
        BTDelGauge.Enabled = True
    End Sub

End Class