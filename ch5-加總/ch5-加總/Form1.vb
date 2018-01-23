Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer = 0
        For r = Val(TextBox1.Text) To Val(TextBox2.Text) Step Val(TextBox3.Text)
            sum = sum + r
        Next
        TextBox4.Text = sum
    End Sub
End Class
