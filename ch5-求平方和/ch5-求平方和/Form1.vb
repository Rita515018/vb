Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = Val(TextBox1.Text)
        Dim sum As Integer = 0
        For i As Integer = 1 To n
            sum = sum + i ^ 2
        Next
        TextBox2.Text = sum



    End Sub
End Class
