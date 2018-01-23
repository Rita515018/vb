Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double = TextBox1.Text

        If x <= 10 Then
            TextBox2.Text = x * 7.35
        ElseIf x <= 30 Then
            TextBox2.Text = 10 * 7.35 + (x - 10) * 9.45
        ElseIf x <= 50 Then
            TextBox2.Text = 10 * 7.35 + 20 * 9.45 + (x - 30) * 11.55
        Else
            TextBox2.Text = 10 * 7.35 + 20 * 9.45 + 20 * 11.55 + (x - 50) * 12.075

        End If

    End Sub
End Class
