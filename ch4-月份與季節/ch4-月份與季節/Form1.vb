Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case TextBox1.text
            Case 1 To 3
                TextBox2.Text = "春季"
            Case 4 To 6
                TextBox2.Text = "夏季 "
            Case 7 To 9
                TextBox2.Text = "秋季"
            Case 10 To 12
                TextBox2.Text = "冬季"
        End Select
    End Sub
End Class
