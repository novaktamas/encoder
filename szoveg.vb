Public Class szoveg

    Private Sub MásolToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If TextBox1.Text > "" Then
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If
    End Sub
    Private Sub BeilesztToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox1.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub MentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MentToolStripMenuItem.Click
        Dim wrt As New System.IO.StreamWriter("C:\Users\User\Desktop\decode.txt")
        wrt.Write(TextBox1.Text)
        wrt.Close()
    End Sub

    Private Sub TörölToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TörölToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub
End Class