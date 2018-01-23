Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case LCase(TextBox1.Text)
            Case "a", "e", "o", "i", "u"
                TextBox2.Text = "母音"
            Case Else
                TextBox2.Text = "子音"


        End Select


    End Sub
End Class
