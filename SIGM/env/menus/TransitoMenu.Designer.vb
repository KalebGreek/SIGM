<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransitoMenu
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
        Me.BaseMenu = New System.Windows.Forms.MenuStrip()
        Me.topHaciendaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaMultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseMenu
        '
        Me.BaseMenu.AutoSize = False
        Me.BaseMenu.BackColor = System.Drawing.Color.Transparent
        Me.BaseMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.topHaciendaMenu})
        Me.BaseMenu.Location = New System.Drawing.Point(0, 0)
        Me.BaseMenu.Name = "BaseMenu"
        Me.BaseMenu.Size = New System.Drawing.Size(300, 27)
        Me.BaseMenu.TabIndex = 389
        Me.BaseMenu.Text = "MenuStrip1"
        '
        'topHaciendaMenu
        '
        Me.topHaciendaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaMultaToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.topHaciendaMenu.ForeColor = System.Drawing.Color.White
        Me.topHaciendaMenu.Name = "topHaciendaMenu"
        Me.topHaciendaMenu.Padding = New System.Windows.Forms.Padding(0)
        Me.topHaciendaMenu.Size = New System.Drawing.Size(70, 23)
        Me.topHaciendaMenu.Text = "MULTAS"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.BuscarToolStripMenuItem.Text = "Buscar.."
        '
        'NuevaMultaToolStripMenuItem
        '
        Me.NuevaMultaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.NuevaMultaToolStripMenuItem.Name = "NuevaMultaToolStripMenuItem"
        Me.NuevaMultaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.NuevaMultaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.NuevaMultaToolStripMenuItem.Text = "Nueva.."
        '
        'TransitoMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.BaseMenu)
        Me.Name = "TransitoMenu"
        Me.Size = New System.Drawing.Size(300, 25)
        Me.BaseMenu.ResumeLayout(False)
        Me.BaseMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BaseMenu As MenuStrip
	Friend WithEvents topHaciendaMenu As ToolStripMenuItem
	Friend WithEvents NuevaMultaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
End Class
