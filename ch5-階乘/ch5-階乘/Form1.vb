Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = Val(TextBox1.Text)
        Dim result As Integer = 1
        For i As Integer = 1 To n
            result = result * i
        Next
        TextBox2.Text = result

    End Sub
End Class
