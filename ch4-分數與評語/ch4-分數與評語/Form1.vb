Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim S As Integer = Val(TextBox1.Text)
        If Val(TextBox1.Text) >= 90 Then
            MsgBox("優")
        ElseIf Val(TextBox1.Text) >= 80 Then
            MsgBox("甲")
        ElseIf Val(TextBox1.Text) >= 70 Then
            MsgBox("乙")

        ElseIf Val(TextBox1.Text) >= 60 Then
            MsgBox("丙")

        Else
            MsgBox("丁")


        End If





    End Sub
End Class
