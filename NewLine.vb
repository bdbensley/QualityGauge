Imports System.Data.OleDb
Public Class NewLine
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim lineDescriptArray(500) As String
    Dim usedLineColors(500) As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        TBNLAvailable.Enabled = False
        TBLineDescpt.Enabled = True
        TBNLDeptNum.Enabled = False
        TBNLComment.Enabled = False
        BTSaveNewLine.Enabled = False
        TBNLAvailable.BackColor = Color.White
        TBNLAvailable.ReadOnly = True
        TBNLAvailable.ForeColor = Color.Black
        Me.LSBLineColor.DataSource = Me.GetColors()
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
            lineDescriptArray(X) = dr("Line Description").ToString
            usedLineColors(X) = dr("Line Color").ToString
            X = X + 1
        End While
        myConnection.Close()


    End Sub

    Private Sub BTNLCheckAvailable_Click(sender As Object, e As EventArgs) Handles BTNLCheckAvailable.Click
        TBNLDeptNum.Clear()
        TBNLComment.Clear()

        TBLineDescpt.Text = (TBLineDescpt.Text).ToUpper
        Dim X As Integer = 0
        Dim temptext As String

        For X = 0 To 500

            temptext = Trim(lineDescriptArray(X)).ToUpper
            If temptext = Trim(TBLineDescpt.Text) Then
                TBNLAvailable.Enabled = True
                TBNLAvailable.ForeColor = Color.Red
                TBNLAvailable.Text = "Not Available"
                TBNLDeptNum.Enabled = False
                LSBLineColor.Enabled = False
                TBNLComment.Enabled = False
                BTSaveNewLine.Enabled = False
                Exit For
            Else
                TBNLAvailable.Enabled = True
                TBNLAvailable.ForeColor = Color.Black
                TBNLAvailable.Text = "Available"
                TBNLDeptNum.Enabled = True
                LSBLineColor.Enabled = True
                TBNLComment.Enabled = True
                BTSaveNewLine.Enabled = True
            End If
        Next

    End Sub
    Private Function GetColors() As KnownColor()
        Dim knownColors As New List(Of KnownColor)
        Dim systemColorsType As Type = GetType(SystemColors)

        'Test every known colour.
        For Each kc As KnownColor In [Enum].GetValues(GetType(KnownColor))

            'Test for system colours and the transparemt colour.
            If kc <> KnownColor.Transparent AndAlso _
               systemColorsType.GetProperty(kc.ToString()) Is Nothing Then

                knownColors.Add(kc)

            End If
        Next

        Return knownColors.ToArray()
    End Function

    Private Sub LSBLineColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBLineColor.SelectedIndexChanged
        LBLCcolor.BackColor = Color.Black
        LBLCcolor.BackColor = Color.FromName(LSBLineColor.SelectedItem.ToString)

    End Sub

    Private Sub BTSaveNewLine_Click(sender As Object, e As EventArgs) Handles BTSaveNewLine.Click
        Dim icount As Integer
        TBNLDeptNum.Text = TBNLDeptNum.Text.ToUpper
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "INSERT INTO Line ([Department Number], [Line Description], [Line Color], [Line Comment]) VALUES ('" + TBNLDeptNum.Text + "', '" + TBLineDescpt.Text + "', '" + LSBLineColor.SelectedItem.ToString + "', '" + TBNLComment.Text + "')"
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