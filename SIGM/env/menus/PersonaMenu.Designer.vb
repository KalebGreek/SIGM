<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonaMenu
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
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.NuevaPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BuscarPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BuscarActaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BaseMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'BaseMenu
		'
		Me.BaseMenu.BackColor = System.Drawing.Color.Transparent
		Me.BaseMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
		Me.BaseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
		Me.BaseMenu.Location = New System.Drawing.Point(0, 0)
		Me.BaseMenu.Name = "BaseMenu"
		Me.BaseMenu.Size = New System.Drawing.Size(300, 27)
		Me.BaseMenu.TabIndex = 389
		Me.BaseMenu.Text = "MenuStrip1"
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPersonaToolStripMenuItem, Me.BuscarPersonaToolStripMenuItem, Me.ToolStripSeparator1, Me.BuscarActaToolStripMenuItem})
		Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Padding = New System.Windows.Forms.Padding(0)
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(83, 23)
		Me.ToolStripMenuItem4.Text = "PERSONA"
		'
		'NuevaPersonaToolStripMenuItem
		'
		Me.NuevaPersonaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.NuevaPersonaToolStripMenuItem.Name = "NuevaPersonaToolStripMenuItem"
		Me.NuevaPersonaToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
		Me.NuevaPersonaToolStripMenuItem.Text = "Nueva Persona"
		'
		'BuscarPersonaToolStripMenuItem
		'
		Me.BuscarPersonaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.BuscarPersonaToolStripMenuItem.Name = "BuscarPersonaToolStripMenuItem"
		Me.BuscarPersonaToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
		Me.BuscarPersonaToolStripMenuItem.Text = "Buscar Persona"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(176, 6)
		'
		'BuscarActaToolStripMenuItem
		'
		Me.BuscarActaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.BuscarActaToolStripMenuItem.Name = "BuscarActaToolStripMenuItem"
		Me.BuscarActaToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
		Me.BuscarActaToolStripMenuItem.Text = "Buscar Acta"
		'
		'PersonaMenu
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.Controls.Add(Me.BaseMenu)
		Me.Name = "PersonaMenu"
		Me.Size = New System.Drawing.Size(300, 25)
		Me.BaseMenu.ResumeLayout(False)
		Me.BaseMenu.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BaseMenu As MenuStrip
	Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
	Friend WithEvents NuevaPersonaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BuscarPersonaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents BuscarActaToolStripMenuItem As ToolStripMenuItem
End Class
