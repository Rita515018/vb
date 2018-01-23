Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = Val(TextBox1.Text)
        Dim b As Integer = Val(TextBox2.Text)
        Dim c As Integer = Val(TextBox3.Text)
        Dim s As Integer = (a + b + c) / 2
        Dim x As Integer = Val(TextBox5.Text)
        If a + b > c And b + c > a And c + a > b Then
            TextBox4.Text = "可構成三角形"

            TextBox5.Text = (s * (s - a) * (s - b) * (s - c)) ^ 0.5

        Else
            TextBox4.Text = "不可構成三角形"
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown


       
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
      

    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = 13 Then
            Dim a As Integer = Val(TextBox1.Text)
            Dim b As Integer = Val(TextBox2.Text)
            Dim c As Integer = Val(TextBox3.Text)
            Dim s As Integer = (a + b + c) / 2
            Dim x As Integer = Val(TextBox5.Text)
            If a + b > c And b + c > a And c + a > b Then
                TextBox4.Text = "可構成三角形"

                TextBox5.Text = (s * (s - a) * (s - b) * (s - c)) ^ 0.5

            Else
                TextBox4.Text = "不可構成三角形"
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
