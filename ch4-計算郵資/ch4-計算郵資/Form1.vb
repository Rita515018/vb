Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double = TextBox1.Text
        If x <= 5 Then
            TextBox2.Text = 50
        ElseIf x <= 10 Then
            TextBox2.Text = 50 + (x - 5) * 5
        ElseIf x <= 15 Then
            TextBox2.Text = 50 + 5 * 5 + (x - 10) * 10
        ElseIf x <= 20 Then
            TextBox2.Text = 50 + 5 * 5 + 5 * 10 + (x - 15) * 20
        Else
            TextBox2.Text = ("無法運送")

        End If


    End Sub
End Class
