Public Class jelsz
    Dim igaz As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.jelsz Then
            igaz = True
        Else : igaz = False
            MsgBox("A régi jelszó nem egyezik", MsgBoxStyle.Critical, "HIBA")

        End If
        If igaz = True Then
            My.Settings.jelsz = TextBox2.Text
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("Jelszó sikeresen megváltoztatva", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.PasswordChar = "*"
        Else : TextBox1.PasswordChar = ""
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBox2.PasswordChar = "*"
        Else : TextBox2.PasswordChar = ""
        End If
    End Sub
End Class