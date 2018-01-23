Public Class Form1

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 1 To 1000
            If ((i Mod 3) = 2) And ((i Mod 5) = 1) And ((i Mod 7) = 4) Then
                TextBox1.Text = TextBox1.Text & i & vbNewLine

            End If

        Next


    End Sub
End Class
