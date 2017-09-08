Imports System.Data.OleDb
Public Class DeleteLine
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim LineArray(500) As String
    Dim temptext As String
    Dim defaultDate As Date = Now
    Dim QualityLineID As Integer = 0
    Dim LineID As Integer = 0
    Dim lineColor As Color
    Public myConnection As OleDbConnection = New OleDbConnection

    Public dr As OleDbDataReader
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        TBDelLineDesc.Enabled = False
        TBDelLineComment.Enabled = False
        TBDelLineColor.Enabled = False
        BTDelLine.Enabled = False
        LBColor.BackColor = (Color.FromKnownColor(KnownColor.Control))
        Dim temptext As String
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM Line"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            LineArray(X) = dr("Department Number").ToString
            X = X + 1
        End While

        myConnection.Close()
        LSBDelLineDeptNum.Items.Clear()
        Dim Y As Integer = 0
        For Y = 0 To X
            If LineArray(Y) = "" Then
                On Error Resume Next
            Else
                LSBDelLineDeptNum.Items.Add(LineArray(Y))
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
        AddHandler LSBDelLineDeptNum.SelectedValueChanged, AddressOf LSBDelLineDeptNum_SelectedValueChanged

    End Sub



    Private Sub BTDelLine_Click(sender As Object, e As EventArgs) Handles BTDelLine.Click
        Dim icount As Integer
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile


        Dim str As String


        Try
            myConnection.Open()
            str = "UPDATE Location SET [Line ID] = " & QualityLineID & ", [WorkStation ID] = 0, [Other Location] = 'Spare' WHERE [Line ID] = " & LineID & ";"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd.ExecuteNonQuery
            myConnection.Close()
            MessageBox.Show(icount & " Gauges Moved to Quality Location")
            myConnection.ConnectionString = connString
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source & vbCrLf & str)
            myConnection.Close()
            Call Main.LSBGauge_SelectedValueChanged(Me, e)
            Call Quality_Gauges.Main.Form1_Load(Me, e)
        End Try
        Try
            myConnection.Open()
            str = "DELETE * FROM [Line] WHERE [Department Number] = '" & (LSBDelLineDeptNum.SelectedItem).ToString & "';"
            Dim cmd2 As OleDbCommand = New OleDbCommand(str, myConnection)
            icount = cmd2.ExecuteNonQuery
            myConnection.Close()
            MessageBox.Show(icount & " Line Deleted from Line Table")
            Call Main.LSBGauge_SelectedValueChanged(Me, e)
            Call Quality_Gauges.Main.Form1_Load(Me, e)
            Me.Close()

        Catch ex As Exception

            Me.Close()
            Call Main.LSBGauge_SelectedValueChanged(Me, e)
            Call Main.Form1_Load(Me, e)

            'do nothing cause it does throw up a non existant error (timing issue)?
        End Try
    End Sub

    Private Sub BTCancel_Click(sender As Object, e As EventArgs) Handles BTCancel.Click
        Me.Close()
    End Sub



    Private Sub LSBDelLineDeptNum_SelectedValueChanged(sender As Object, e As EventArgs)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "SELECT * FROM [Line]"

        Dim cmd = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        While dr.Read()
            If dr("Department Number") = (LSBDelLineDeptNum.SelectedItem).ToString Then
                TBDelLineDesc.Text = dr("Line Description").ToString
                TBDelLineColor.Text = dr("Line Color").ToString
                If dr("Line Color") Is DBNull.Value Then
                    LBColor.BackColor = (Color.FromKnownColor(KnownColor.Control))
                Else
                    LBColor.Text = dr("Line Color")
                    lineColor = Color.FromName(dr("Line Color").ToString)
                    LBColor.BackColor = lineColor
                End If

                LineID = dr("ID")
            End If
        End While
        myConnection.Close()
        BTDelLine.Enabled = True
    End Sub



End Class