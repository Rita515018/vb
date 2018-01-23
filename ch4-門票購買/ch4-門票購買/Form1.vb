Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As Integer = Val(TextBox1.Text)
        Select Case Val(TextBox1.Text)
            Case Is = 1
                TextBox2.Text = 100
            Case 2 To 5
                TextBox2.Text = X * 100 * 0.9
            Case 6 To 10
                TextBox2.Text = X * 100 * 0.8
            Case 11 To 20
                TextBox2.Text = X * 100 * 0.7
            Case Else
                TextBox2.Text = X * 100 * 0.6
        End Select





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As Double = Val(TextBox1.Text)
        If X = 1 Then
            TextBox2.Text = 100
        ElseIf X >= 2 And X <= 5 Then
            TextBox2.Text = X * 100 * 0.9
        ElseIf X >= 6 And X <= 10 Then
            TextBox2.Text = X * 100 * 0.8
        ElseIf X >= 11 And X <= 20 Then
            TextBox2.Text = X * 100 * 0.7
        Else
            TextBox2.Text = X * 100 * 0.6
        End If





    End Sub
End Class
