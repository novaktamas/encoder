<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class szoveg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BeilesztToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MásolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TörölToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeltöltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.MaxLength = 330000
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(862, 316)
        Me.TextBox1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeilesztToolStripMenuItem, Me.MásolToolStripMenuItem, Me.MentToolStripMenuItem, Me.TörölToolStripMenuItem, Me.FeltöltToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 114)
        '
        'BeilesztToolStripMenuItem
        '
        Me.BeilesztToolStripMenuItem.Name = "BeilesztToolStripMenuItem"
        Me.BeilesztToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BeilesztToolStripMenuItem.Text = "Beilleszt"
        '
        'MásolToolStripMenuItem
        '
        Me.MásolToolStripMenuItem.Name = "MásolToolStripMenuItem"
        Me.MásolToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.MásolToolStripMenuItem.Text = "Másol"
        '
        'MentToolStripMenuItem
        '
        Me.MentToolStripMenuItem.Name = "MentToolStripMenuItem"
        Me.MentToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.MentToolStripMenuItem.Text = "Ment"
        '
        'TörölToolStripMenuItem
        '
        Me.TörölToolStripMenuItem.Name = "TörölToolStripMenuItem"
        Me.TörölToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.TörölToolStripMenuItem.Text = "Töröl"
        '
        'FeltöltToolStripMenuItem
        '
        Me.FeltöltToolStripMenuItem.Name = "FeltöltToolStripMenuItem"
        Me.FeltöltToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.FeltöltToolStripMenuItem.Text = "Feltölt"
        '
        'szoveg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 316)
        Me.Controls.Add(Me.TextBox1)
        Me.MinimizeBox = False
        Me.Name = "szoveg"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Szöveg"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BeilesztToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MásolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TörölToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeltöltToolStripMenuItem As ToolStripMenuItem
End Class
