Imports System.ComponentModel

Public Class Belepes

    Dim jelsz As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        belep()
    End Sub
    Private Sub belep()

        If TextBox1.Text = My.Settings.jelsz Then
            jelsz = True
        Else : jelsz = False
            MsgBox("HIBA", MsgBoxStyle.Critical, "HIBA")
            TextBox1.Clear()
            MsgBox("Figyelj, nem tudom ki vagy vagy mit akarsz ,de jelszó hiányában nem szívesen látlak! ", MsgBoxStyle.Critical, "Hibajelentés")
        End If

        If jelsz = True Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            belep()
        End If
    End Sub

    Private Sub Belepes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class