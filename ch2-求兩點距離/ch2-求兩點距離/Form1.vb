Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X1 As Integer = Val(TextBox1.Text)
        Dim X2 As Integer = Val(TextBox2.Text)
        Dim Y1 As Integer = Val(TextBox3.Text)
        Dim Y2 As Integer = Val(TextBox4.Text)
        TextBox5.Text = ((X1 - X2) ^ 2 + (Y1 - Y2) ^ 2) ^ 0.5
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
