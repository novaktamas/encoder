Public Class help
    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            TextBox1.Text = My.Resources.mentes
        ElseIf ListBox1.SelectedIndex = 1 Then
            TextBox1.Text = My.Resources.forrogom
        ElseIf ListBox1.SelectedIndex = 2 Then
            TextBox1.Text = My.Resources.megtekint
        ElseIf ListBox1.SelectedIndex = 3 Then
            TextBox1.Text = My.Resources.szoveg
        ElseIf ListBox1.SelectedIndex = 4 Then
            TextBox1.Text = My.Resources.korlatok
        ElseIf ListBox1.SelectedIndex = 5 Then
            TextBox1.Text = My.Resources.tisztitas
        ElseIf ListBox1.SelectedIndex = 6 Then
            TextBox1.Text = My.Resources.jelszo
        ElseIf ListBox1.SelectedIndex = 7 Then
            ascii.Show()
        End If
    End Sub
End Class