Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double = Val(TextBox1.Text)
        If x <= 500000 Then
            TextBox2.Text = x * 0.05
        ElseIf x <= 1000000 Then
            TextBox2.Text = 500000 * 0.05 + (x - 500000) * 0.1
        ElseIf x <= 2000000 Then
            TextBox2.Text = 500000 * 0.05 + 500000 * 0.1 + (x - 1000000) * 0.2
        ElseIf x <= 4000000 Then
            TextBox2.Text = 500000 * 0.05 + 500000 * 0.1 + 1000000 * 0.2 + (x - 2000000) * 0.3
        Else
            TextBox2.Text = 500000 * 0.05 + 500000 * 0.1 + 1000000 * 0.2 + 2000000 * 0.3 + (x - 4000000) * 0.4
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Double = Val(TextBox1.Text)
        Select Case x
            Case Is <= 500000
                TextBox2.Text = x * 0.05
            Case Is <= 1000000
                TextBox2.Text = 500000 * 0.05 + (x - 500000) * 0.1
            Case Is <= 2000000
                TextBox2.Text = 500000 * 0.05 + 500000 * 0.1 + (x - 1000000) * 0.2
            Case Is <= 4000000
                TextBox2.Text = 500000 * 0.05 + 500000 * 0.1 + 1000000 * 0.2 + (x - 2000000) * 0.3
            Case Else
                TextBox2.Text = 500000 * 0.05 + 500000 * 0.1 + 1000000 * 0.2 + 2000000 * 0.3 + (x - 4000000) * 0.4
        End Select
    End Sub
End Class
