Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) >= 2000 Then
            TextBox2.Text = Val(TextBox1.Text) * 0.9
        Else
            TextBox2.Text = Val(TextBox1.Text)
            MsgBox("還差" & 2000 - Val(TextBox1.Text) & "元就可以打九折")
        End If
        
    End Sub
End Class
