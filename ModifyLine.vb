Imports System.Data.OleDb
Public Class ModifyLine
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim lineDescriptArray(500) As String

    Dim lineColor As String = ""
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
      
        Me.LSBMLineColor.DataSource = Me.GetColors()
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

            X = X + 1
        End While
        myConnection.Close()
        LSBMLineDesc.Items.Clear()
        Dim Z As Integer = 0
        For Z = 0 To X
            If lineDescriptArray(Z) = "" Then
                On Error Resume Next
            Else
                LSBMLineDesc.Items.Add(lineDescriptArray(Z))
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



    Private Sub BTModifyLine_Click(sender As Object, e As EventArgs) Handles BTModifyLine.Click
        Dim icount As Integer
        If TBMNLineDesc.Text <> "" Then
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
            dataFile = "S:\QUALITY\Quality Gauge Program\GaugeDatabase.accdb" ' Change it to your Access Database location
            connString = provider & dataFile
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim str As String
            str = "UPDATE Line SET  [Line Description] = '" & TBMNLineDesc.Text & _
                 "', [Line Color] = '" & LSBMLineColor.SelectedItem.ToString & _
                 "', [Line Comment] = '" & TBMLComment.Text & "' WHERE [Line Description] = '" & LSBMLineDesc.SelectedItem & "';"
            'str = "INSERT INTO Line ([Department Number], [Line Description], [Line Color], [Line Comment]) VALUES ('" + TBNLDeptNum.Text + "', '" + TBLineDescpt.Text + "', '" + LSBLineColor.SelectedItem.ToString + "', '" + TBNLComment.Text + "')"
            Try
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                icount = cmd.ExecuteNonQuery
                MessageBox.Show(icount & " Record Modified")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message & " - " & ex.Source & vbCrLf & str)
                myConnection.Close()
            End Try
        End If
    End Sub

  
    Private Sub LSBMLineDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBMLineDesc.SelectedIndexChanged
        myConnection.Open()
        Dim index As Integer
        Dim str As String
        Dim tempDeptNum As String = ""
        str = "SELECT * FROM Line"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim X As Integer = 0
        While dr.Read()
            If dr("Line Description").ToString = LSBMLineDesc.SelectedItem Then
                TBMNLineDesc.Text = LSBMLineDesc.SelectedItem
                TBMLineDeptNum.Text = dr("Department Number").ToString
                TBMLComment.Text = dr("Line Comment").ToString
                lineColor = dr("Line Color").ToString
            End If
            X = X + 1
        End While
        myConnection.Close()
        index = LSBMLineColor.FindString(lineColor)
        If index <> -1 Then
            LSBMLineColor.SetSelected(index, True)
        End If
        TBMNLineDesc.Text = LSBMLineDesc.SelectedItem
    End Sub


    Private Sub LSBMLineColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSBMLineColor.SelectedIndexChanged
        LBMLCcolor.BackColor = Color.Black
        LBMLCcolor.BackColor = Color.FromName(LSBMLineColor.SelectedItem.ToString)
    End Sub

    Private Sub BTCancel_Click(sender As Object, e As EventArgs) Handles BTCancel.Click
        Me.Close()
    End Sub
End Class