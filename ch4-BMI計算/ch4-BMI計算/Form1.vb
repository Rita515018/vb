Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text) ^ 2
        If TextBox3.Text < 18 Then
            TextBox4.Text = "體重過輕"
        ElseIf TextBox3.Text < 24 Then
            TextBox4.Text = "體重正常"
        ElseIf TextBox3.Text < 27 Then
            TextBox4.Text = "體重過重"
        Else
            TextBox4.Text = "體重肥胖"

        End If

    End Sub
End Class
