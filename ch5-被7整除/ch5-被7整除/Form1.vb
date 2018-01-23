Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = Val(TextBox2.Text)
        Dim sum As Integer = 0
        For i As Integer = 1 To n
            If (i Mod 7 = 0) Then
                sum = sum + i
            End If

        Next
        TextBox1.Text = sum

    End Sub
End Class
