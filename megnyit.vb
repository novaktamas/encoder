Public Class megnyit

    Dim bmp As New Bitmap(500, 220)
    Dim masolat As New Bitmap(500, 220)
    Dim grp As Graphics = Graphics.FromImage(bmp)
    Dim x, y As Integer
    Dim negyzx, negyzy As Integer
    Dim szn As Color
    Dim igaz As Boolean = True
    Dim csuszkax, csuszkay As Integer


    Private Sub FeltöltToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeltöltToolStripMenuItem.Click
        OpenFileDialog1.Filter = "BMP! | *.bmp"
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        masolat = Image.FromFile(OpenFileDialog1.FileName)
        PictureBox1.Image = masolat
        RadioButton2.Select()


    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        pixel()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        pixel()
    End Sub

    Private Sub megnyit_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        OpenFileDialog1.Filter = "BMP! | *.bmp"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        HScrollBar1.Enabled = False
        VScrollBar1.Enabled = False

        PictureBox1.Image = masolat
    End Sub

    Public Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        HScrollBar1.Enabled = True
        VScrollBar1.Enabled = True
        pixel()
        If RadioButton1.Checked Then
            MsgBox("10x-es nagyítás, 1 pixel 10-nek felel meg", MsgBoxStyle.Information)
        End If

    End Sub
    Public Sub pixel()
        Dim grp As Graphics = Graphics.FromImage(bmp)
        grp.Clear(Nothing)
        PictureBox1.Image = bmp
        x = 0
        y = 0
        csuszkax = HScrollBar1.Value
        csuszkay = VScrollBar1.Value
        For kezdy As Integer = 0 To 21
            x = 0
            csuszkax = HScrollBar1.Value
            For kezd As Integer = 0 To 49
                negyzx = x * 10
                negyzy = y * 10
                szn = masolat.GetPixel(csuszkax, csuszkay)
                Dim br As New SolidBrush(szn)
                grp.FillRectangle(br, negyzx, negyzy, 10, 10)

                PictureBox1.Image = bmp
                x += 1
                csuszkax += 1
            Next
            y += 1
            csuszkay += 1
        Next

    End Sub
End Class