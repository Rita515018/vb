Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((TextBox1.Text = "Rita") And (TextBox2.Text = "123")) Then
            MsgBox("登入成功")
        Else
            MsgBox("登入失敗")
        End If

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = 13 Then

            If ((TextBox1.Text = "Rita") And (TextBox2.Text = "123")) Then
                MsgBox("登入成功")
            Else
                MsgBox("登入失敗")
            End If
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
