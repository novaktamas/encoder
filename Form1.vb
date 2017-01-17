﻿Imports System.ComponentModel

Public Class Form1

    Dim x As Integer = -1
    Dim y As Integer = 0
    Dim bmp As New Drawing.Bitmap(500, 220)
    Dim grp As Graphics = Graphics.FromImage(bmp)

    Dim RGB(0 To 2) As Integer

    Dim clr As Color
    Dim igaz As Boolean = True


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        szoveg.Show()
        szoveg.Focus()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kod()
    End Sub

    Private Sub FeltöltésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeltöltésToolStripMenuItem.Click
        feltolt()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        bmp = PictureBox1.Image
    End Sub

    Private Sub MentésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MentésToolStripMenuItem.Click
        ment()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vissza()
    End Sub

    Private Sub MentésToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MentésToolStripMenuItem1.Click
        ment()
    End Sub
    Private Sub SzövegdobozToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SzövegdobozToolStripMenuItem.Click
        szoveg.Show()
        szoveg.Focus()
    End Sub
    Private Sub KépMegtekintésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KépMegtekintésToolStripMenuItem.Click
        megnyit.Show()
        megnyit.Focus()

    End Sub

    Private Sub TörlésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TörlésToolStripMenuItem.Click
        grp = Graphics.FromImage(bmp)
        grp.Clear(Nothing)
        PictureBox1.Image = bmp
    End Sub
    Private Sub KépfeltöltésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KépfeltöltésToolStripMenuItem.Click
        feltolt()

    End Sub
    Private Sub vissza()
                
        igaz = True
        x = 0
        y = 0
        While igaz = True
            Dim minta As Color
            minta = bmp.GetPixel(x, y)
            Dim Characters As String = minta.R 'red
            Dim ByteArray(Characters.Length - 1) As Byte
            For Index As Integer = 0 To 0
                ByteArray(Index) = Convert.ToByte(Characters.Substring(0, Characters.Length), 10)
            Next
            szoveg.TextBox1.AppendText(System.Text.ASCIIEncoding.ASCII.GetString(ByteArray))
            Dim Characters2 As String = minta.G 'green
            Dim ByteArray2(Characters2.Length - 1) As Byte
            For Index As Integer = 0 To 0
                ByteArray2(Index) = Convert.ToByte(Characters2.Substring(0, Characters2.Length), 10)
            Next
            szoveg.TextBox1.AppendText(System.Text.ASCIIEncoding.ASCII.GetString(ByteArray2))
            If minta.R = Nothing Then
                igaz = False
            End If
            Dim Characters3 As String = minta.B 'blue
            Dim ByteArray3(Characters3.Length - 1) As Byte
            For Index As Integer = 0 To 0
                ByteArray3(Index) = Convert.ToByte(Characters3.Substring(0, Characters3.Length), 10)
            Next
            szoveg.TextBox1.AppendText(System.Text.ASCIIEncoding.ASCII.GetString(ByteArray3))
            x = x + 1
            If x = 500 Then
                x = 0
                y = y + 1
            End If
        End While
        MsgBox("Sikeres visszatöltés")
        grp = Graphics.FromImage(bmp)
        grp.Clear(Nothing)
        PictureBox1.Image = bmp
    End Sub
    Private Sub kod()
        grp.Clear(Nothing)
        PictureBox1.Image = bmp

        Dim valtoz As Integer = 0

        x = 0
        y = 0

        For Each Character As Byte In System.Text.ASCIIEncoding.ASCII.GetBytes(szoveg.TextBox1.Text)

            RGB(valtoz) = Convert.ToString(Character, 10) ' 

            valtoz += 1
            If valtoz > 2 Then
                clr = Color.FromArgb(RGB(0), RGB(1), RGB(2))
                bmp.SetPixel(x, y, clr)
                PictureBox1.Image = bmp
                valtoz = 0
                x += 1
                If x = 500 Then
                    If y = 220 Then
                        y = -1
                        zaras()
                    End If
                    y += 1
                    x = 0
                End If
                RGB(0) = 0
                RGB(1) = 0
                RGB(2) = 0
            End If
        Next
        clr = Color.FromArgb(RGB(0), RGB(1), RGB(2))
        bmp.SetPixel(x, y, clr)
        PictureBox1.Image = bmp

        MsgBox("Lekódolva")
        szoveg.TextBox1.Clear()
    End Sub

    Private Sub zaras()
        MsgBox("Túl nagy a fájl, ha nagyobb méretű fájlt akarsz lekódolni, kérem forduljon a program kibocsátójához")

        MsgBox("A most készített kép HIBÁS", MsgBoxStyle.Information, "HIBA")
    End Sub


    Public Sub feltolt()
        OpenFileDialog1.Filter = "BMP! |*.bmp"
        OpenFileDialog1.Title = "code"
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub ment()
        PictureBox1.Image.Save("C:\Users\User\Desktop\code.bmp")
        MsgBox("Mentve")
    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Belepes.Close()
        szoveg.Close()
        megnyit.Close()
    End Sub
End Class
