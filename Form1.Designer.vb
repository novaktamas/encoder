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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.KépMegtekintésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TörlésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformációToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeltöltésToolStripMenuItem, Me.MentésToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        resources.ApplyResources(Me.ContextMenuStrip2, "ContextMenuStrip2")
        '
        'FeltöltésToolStripMenuItem
        '
        Me.FeltöltésToolStripMenuItem.Name = "FeltöltésToolStripMenuItem"
        resources.ApplyResources(Me.FeltöltésToolStripMenuItem, "FeltöltésToolStripMenuItem")
        '
        'MentésToolStripMenuItem
        '
        Me.MentésToolStripMenuItem.Name = "MentésToolStripMenuItem"
        resources.ApplyResources(Me.MentésToolStripMenuItem, "MentésToolStripMenuItem")
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Cross
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FájlToolStripMenuItem, Me.NézetToolStripMenuItem, Me.TörlésToolStripMenuItem, Me.InformációToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FájlToolStripMenuItem
        '
        Me.FájlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MentésToolStripMenuItem1, Me.KépfeltöltésToolStripMenuItem})
        Me.FájlToolStripMenuItem.Name = "FájlToolStripMenuItem"
        resources.ApplyResources(Me.FájlToolStripMenuItem, "FájlToolStripMenuItem")
        '
        'MentésToolStripMenuItem1
        '
        Me.MentésToolStripMenuItem1.Name = "MentésToolStripMenuItem1"
        resources.ApplyResources(Me.MentésToolStripMenuItem1, "MentésToolStripMenuItem1")
        '
        'KépfeltöltésToolStripMenuItem
        '
        Me.KépfeltöltésToolStripMenuItem.Name = "KépfeltöltésToolStripMenuItem"
        resources.ApplyResources(Me.KépfeltöltésToolStripMenuItem, "KépfeltöltésToolStripMenuItem")
        '
        'NézetToolStripMenuItem
        '
        Me.NézetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SzövegdobozToolStripMenuItem, Me.KépMegtekintésToolStripMenuItem})
        Me.NézetToolStripMenuItem.Name = "NézetToolStripMenuItem"
        resources.ApplyResources(Me.NézetToolStripMenuItem, "NézetToolStripMenuItem")
        '
        'SzövegdobozToolStripMenuItem
        '
        Me.SzövegdobozToolStripMenuItem.Name = "SzövegdobozToolStripMenuItem"
        resources.ApplyResources(Me.SzövegdobozToolStripMenuItem, "SzövegdobozToolStripMenuItem")
        '
        'KépMegtekintésToolStripMenuItem
        '
        Me.KépMegtekintésToolStripMenuItem.Name = "KépMegtekintésToolStripMenuItem"
        resources.ApplyResources(Me.KépMegtekintésToolStripMenuItem, "KépMegtekintésToolStripMenuItem")
        '
        'TörlésToolStripMenuItem
        '
        Me.TörlésToolStripMenuItem.Name = "TörlésToolStripMenuItem"
        resources.ApplyResources(Me.TörlésToolStripMenuItem, "TörlésToolStripMenuItem")
        '
        'InformációToolStripMenuItem
        '
        Me.InformációToolStripMenuItem.Name = "InformációToolStripMenuItem"
        resources.ApplyResources(Me.InformációToolStripMenuItem, "InformációToolStripMenuItem")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip2
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents InformációToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
End Class
