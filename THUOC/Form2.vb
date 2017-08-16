Public Class Form2

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        txtusername.Focus()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        txtpassword.Focus()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Environment.Exit(0)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If (txtpassword.Text = "admin") And (txtusername.Text = "admin") Then
            Form1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub checkpassword_OnChange(sender As Object, e As EventArgs) Handles checkpassword.OnChange
        If checkpassword.Checked = False Then
            txtpassword.PasswordChar = "*"
        Else
            txtpassword.PasswordChar = ""

        End If
    End Sub

End Class