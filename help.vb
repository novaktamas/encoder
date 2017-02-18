Public Class help
    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            TextBox1.Text = My.Resources.mentes
            LinkLabel1.Visible = False
        ElseIf ListBox1.SelectedIndex = 2 Then
            TextBox1.Text = "A fül szerkesztés alatt"
            LinkLabel1.Visible = False
        ElseIf ListBox1.SelectedIndex = 1 Then
            TextBox1.Text = My.Resources.megtekint
            LinkLabel1.Visible = False
        ElseIf ListBox1.SelectedIndex = 3 Then
            LinkLabel1.Visible = False
            TextBox1.Text = My.Resources.szoveg
        ElseIf ListBox1.SelectedIndex = 4 Then
            LinkLabel1.Visible = False
            TextBox1.Text = My.Resources.korlatok
        ElseIf ListBox1.SelectedIndex = 5 Then
            LinkLabel1.Visible = False
            TextBox1.Text = My.Resources.tisztitas
        ElseIf ListBox1.SelectedIndex = 6 Then
            LinkLabel1.Visible = False
            TextBox1.Text = My.Resources.jelszo
            LinkLabel1.Visible = True
            LinkLabel1.Text = "Csere"
        ElseIf ListBox1.SelectedIndex = 7 Then
            ascii.Show()
            LinkLabel1.Visible = False
        ElseIf ListBox1.SelectedIndex = 8 Then
            TextBox1.Text = My.Settings.log

            LinkLabel1.Visible = True
            LinkLabel1.Text = "Reset"

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LinkLabel1.Text = "Reset" Then
            My.Settings.logm = My.Settings.logm & My.Settings.log
            My.Settings.log = ""
            TextBox1.Text = My.Settings.log
        Else jelsz.Show()
        End If


    End Sub
End Class