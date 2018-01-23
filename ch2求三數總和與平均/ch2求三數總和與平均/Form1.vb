

Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim 第一次段考 As Integer = Val(TextBox1.Text)
        Dim 第二次段考 As Integer = Val(TextBox2.Text)
        Dim 期末考 As Integer = Val(TextBox3.Text)
        TextBox4.Text = Val(第一次段考 + 第二次段考 + 期末考)
        TextBox5.Text = Val(第一次段考 + 第二次段考 + 期末考) / 3

        If Val(TextBox5.Text) >= 60 Then

            MsgBox("很好，請繼續保持")
            TextBox5.ForeColor = Color.AliceBlue
        End If
        If Val(TextBox5.Text) < 60 Then
            TextBox5.ForeColor = Color.AliceBlue
            MsgBox("請加油")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class