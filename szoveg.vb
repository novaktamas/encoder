Public Class szoveg

    Private Sub MásolToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BeilesztToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MentToolStripMenuItem.Click
        Dim wrt As New System.IO.StreamWriter("C:\Users\User\Desktop\decode.txt")
        wrt.Write(TextBox1.Text)
        wrt.Close()
        MsgBox("Mentve")
    End Sub

    Private Sub TörölToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TörölToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private Sub szoveg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FeltöltToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeltöltToolStripMenuItem.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "szoveg | *.txt"


        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim wrt As New System.IO.StreamReader(opf.FileName)
            TextBox1.Text = wrt.ReadToEnd()
            wrt.Close()
        End If

    End Sub

    Private Sub BeilesztToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BeilesztToolStripMenuItem.Click
        TextBox1.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub MásolToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MásolToolStripMenuItem.Click
        If TextBox1.Text > "" Then
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If
    End Sub
End Class