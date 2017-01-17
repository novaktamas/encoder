<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FeltöltésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MentésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FájlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MentésToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KépfeltöltésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NézetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SzövegdobozToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TörlésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KépMegtekintésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.PictureBox1.Location = New System.Drawing.Point(81, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeltöltésToolStripMenuItem, Me.MentésToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(119, 48)
        '
        'FeltöltésToolStripMenuItem
        '
        Me.FeltöltésToolStripMenuItem.Name = "FeltöltésToolStripMenuItem"
        Me.FeltöltésToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.FeltöltésToolStripMenuItem.Text = "Feltöltés"
        '
        'MentésToolStripMenuItem
        '
        Me.MentésToolStripMenuItem.Name = "MentésToolStripMenuItem"
        Me.MentésToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.MentésToolStripMenuItem.Text = "Mentés"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 258)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "kódolás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(588, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 258)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "dekódolás"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FájlToolStripMenuItem, Me.NézetToolStripMenuItem, Me.TörlésToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(75, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FájlToolStripMenuItem
        '
        Me.FájlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MentésToolStripMenuItem1, Me.KépfeltöltésToolStripMenuItem})
        Me.FájlToolStripMenuItem.Name = "FájlToolStripMenuItem"
        Me.FájlToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FájlToolStripMenuItem.Text = "Fájl"
        '
        'MentésToolStripMenuItem1
        '
        Me.MentésToolStripMenuItem1.Name = "MentésToolStripMenuItem1"
        Me.MentésToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.MentésToolStripMenuItem1.Text = "Mentés"
        '
        'KépfeltöltésToolStripMenuItem
        '
        Me.KépfeltöltésToolStripMenuItem.Name = "KépfeltöltésToolStripMenuItem"
        Me.KépfeltöltésToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.KépfeltöltésToolStripMenuItem.Text = "Képfeltöltés"
        '
        'NézetToolStripMenuItem
        '
        Me.NézetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SzövegdobozToolStripMenuItem, Me.KépMegtekintésToolStripMenuItem})
        Me.NézetToolStripMenuItem.Name = "NézetToolStripMenuItem"
        Me.NézetToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.NézetToolStripMenuItem.Text = "Nézet"
        '
        'SzövegdobozToolStripMenuItem
        '
        Me.SzövegdobozToolStripMenuItem.Name = "SzövegdobozToolStripMenuItem"
        Me.SzövegdobozToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SzövegdobozToolStripMenuItem.Text = "szövegdoboz"
        '
        'TörlésToolStripMenuItem
        '
        Me.TörlésToolStripMenuItem.Name = "TörlésToolStripMenuItem"
        Me.TörlésToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TörlésToolStripMenuItem.Text = "Törlés"
        '
        'KépMegtekintésToolStripMenuItem
        '
        Me.KépMegtekintésToolStripMenuItem.Name = "KépMegtekintésToolStripMenuItem"
        Me.KépMegtekintésToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.KépMegtekintésToolStripMenuItem.Text = "Kép megtekintés"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 258)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "coder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents FeltöltésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MentésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FájlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MentésToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NézetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SzövegdobozToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TörlésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KépfeltöltésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KépMegtekintésToolStripMenuItem As ToolStripMenuItem
End Class
