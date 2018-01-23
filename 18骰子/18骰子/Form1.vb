Public Class Form1
    Dim p As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As New Random
        p = r.Next(1, 7)
        PictureBox1.Image = New Bitmap(p & ".png")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        If ((p = 1 Or p = 2 Or p = 3) And RadioButton1.Checked = True) Or ((p = 4 Or p = 5 Or p = 6) And RadioButton2.Checked = True) Then
            MsgBox("WIN")
        Else
            MsgBox("LOSE")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Timer1.Interval = HScrollBar1.Value
    End Sub
End Class
