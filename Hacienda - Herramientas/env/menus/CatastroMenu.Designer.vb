<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CatastroMenu
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
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.BuscarInmuebleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ConsultarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BaseMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'BaseMenu
		'
		Me.BaseMenu.BackColor = System.Drawing.Color.DimGray
		Me.BaseMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
		Me.BaseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
		Me.BaseMenu.Location = New System.Drawing.Point(0, 0)
		Me.BaseMenu.Name = "BaseMenu"
		Me.BaseMenu.Size = New System.Drawing.Size(300, 27)
		Me.BaseMenu.TabIndex = 389
		Me.BaseMenu.Text = "MenuStrip1"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarInmuebleToolStripMenuItem, Me.ToolStripSeparator2, Me.ConsultarPagosToolStripMenuItem})
		Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(86, 23)
		Me.ToolStripMenuItem1.Text = "CATASTRO"
		'
		'BuscarInmuebleToolStripMenuItem
		'
		Me.BuscarInmuebleToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.BuscarInmuebleToolStripMenuItem.Name = "BuscarInmuebleToolStripMenuItem"
		Me.BuscarInmuebleToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
		Me.BuscarInmuebleToolStripMenuItem.Text = "Buscar Inmueble"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(182, 6)
		'
		'ConsultarPagosToolStripMenuItem
		'
		Me.ConsultarPagosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.ConsultarPagosToolStripMenuItem.Name = "ConsultarPagosToolStripMenuItem"
		Me.ConsultarPagosToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
		Me.ConsultarPagosToolStripMenuItem.Text = "Consultar Pagos"
		'
		'CatastroMenu
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.Controls.Add(Me.BaseMenu)
		Me.Name = "CatastroMenu"
		Me.Size = New System.Drawing.Size(300, 25)
		Me.BaseMenu.ResumeLayout(False)
		Me.BaseMenu.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BaseMenu As MenuStrip
	Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents BuscarInmuebleToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ConsultarPagosToolStripMenuItem As ToolStripMenuItem
End Class
