Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(TextBox1.Text) Mod 2 = 0) Then
            TextBox2.Text = TextBox1.Text & "為偶數"
        Else
            TextBox2.Text = TextBox1.Text & "為竒數"
        End If

    End Sub
End Class
