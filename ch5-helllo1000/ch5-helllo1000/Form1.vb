Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For r = 1 To 1000
            Select Case r Mod 3
                Case 0
                    MsgBox("helllo")
                Case 1
                    MsgBox("你一直按不累嗎?")
                Case 2
                    MsgBox("好無聊" & 10 - r & "次")
            End Select




        Next
    End Sub
End Class
