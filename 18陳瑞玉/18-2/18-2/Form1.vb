Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double = Val(TextBox1.Text)
        If x <= 5 Then
            TextBox2.Text = 70 + x * 30
        ElseIf x <= 10 Then
            TextBox2.Text = 70 + 5 * 30 + (x - 5) * 25
        ElseIf x <= 20 Then
            TextBox2.Text = 70 + 5 * 30 + 5 * 25 + (x - 10) * 20
        Else
            TextBox2.Text = "無法運送"



            End If



    End Sub
End Class
