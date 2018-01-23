Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = Val(TextBox1.Text)
        Select Case x
            Case 1 To 5
                TextBox2.Text = "普遍級"
            Case 6 To 12
                TextBox2.Text = "保護級"
            Case 13 To 17
                TextBox2.Text = "輔導級"
            Case 18 To 99
                TextBox2.Text = "都可以看"
            Case Is = 0
                TextBox2.Text = "輸入錯誤"
            Case Is > 100
                TextBox2.Text = "輸入錯誤"

        End Select




    End Sub
End Class
