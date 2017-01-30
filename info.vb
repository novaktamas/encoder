Public Class info
    Private Sub info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Left < 270 Then
            PictureBox1.Left += 5
        Else : Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Left > 5 Then
            PictureBox1.Left -= 5
        Else : Timer2.Stop()
            Timer1.Start()
        End If
    End Sub
End Class