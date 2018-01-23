Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Integer = Val(TextBox1.Text)
        Const PI As Double = 3.1415926
        TextBox2.Text = 2 * r * PI
        TextBox3.Text = r ^ 2 * PI
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim r As Integer = Val(TextBox1.Text)
        Const PI As Double = 3.1415926
        TextBox2.Text = 2 * r * PI
        TextBox3.Text = r ^ 2 * PI
    End Sub
End Class
