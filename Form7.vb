Public Class Form7


    Public Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Main.Left + 10, Main.Top + 10)
        Main.form7Value = " "
        If Me.Tag = "ILLINE02" Then
            RadioButton1.Text = "Glass Line2"
            RadioButton2.Text = "Argon Line1A"
            RadioButton3.Text = "Argon Line2"
        End If
        If Me.Tag = "ILLINE03" Then
            RadioButton1.Text = "Super Spacer"
            RadioButton2.Text = "Argon Line1"
            RadioButton3.Text = "SS Argon"
        End If
        RadioButton1.Checked = True

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim boxNum As Integer = 0
        Main.form7Value = " "
        If Me.Tag = "ILLINE02" Then
            If RadioButton1.Checked = True Then
                Main.TBARDept.Text = "Glass Line2"
            ElseIf RadioButton2.Checked = True Then
                Main.TBARDept.Text = "Argon Line1a"
            Else
                Main.TBARDept.Text = "Argon Line2"
            End If

        End If
        If Me.Tag = "ILLINE03" Then
            If RadioButton1.Checked = True Then
                Main.TBARDept.Text = "Super Spacer"
            ElseIf RadioButton2.Checked = True Then
                Main.TBARDept.Text = "Argon Line1"
            Else
                Main.TBARDept.Text = "SS Argon"
            End If
        End If
        Me.Close()

    End Sub

End Class