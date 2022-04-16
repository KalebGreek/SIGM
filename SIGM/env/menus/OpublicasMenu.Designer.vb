<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpublicasMenu
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
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaNotaDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarNotaDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.AsistenciaToolStripMenuItem, Me.BuscarEmpleadoToolStripMenuItem, Me.ContratoToolStripMenuItem, Me.ToolStripSeparator7, Me.ProveedoresToolStripMenuItem, Me.BuscarProveedorToolStripMenuItem, Me.NotaDePedidoToolStripMenuItem})
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(140, 23)
        Me.ToolStripMenuItem4.Text = "OBRAS PUBLICAS"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Enabled = False
        Me.EmpleadosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AsistenciaToolStripMenuItem
        '
        Me.AsistenciaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem"
        Me.AsistenciaToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.AsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'BuscarEmpleadoToolStripMenuItem
        '
        Me.BuscarEmpleadoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarEmpleadoToolStripMenuItem.Name = "BuscarEmpleadoToolStripMenuItem"
        Me.BuscarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.BuscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado"
        '
        'ContratoToolStripMenuItem
        '
        Me.ContratoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ContratoToolStripMenuItem.Name = "ContratoToolStripMenuItem"
        Me.ContratoToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.ContratoToolStripMenuItem.Text = "Contratos"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(189, 6)
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Enabled = False
        Me.ProveedoresToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'BuscarProveedorToolStripMenuItem
        '
        Me.BuscarProveedorToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarProveedorToolStripMenuItem.Name = "BuscarProveedorToolStripMenuItem"
        Me.BuscarProveedorToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.BuscarProveedorToolStripMenuItem.Text = "Buscar Proveedor"
        '
        'NotaDePedidoToolStripMenuItem
        '
        Me.NotaDePedidoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaNotaDePedidoToolStripMenuItem, Me.BuscarNotaDePedidoToolStripMenuItem})
        Me.NotaDePedidoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.NotaDePedidoToolStripMenuItem.Name = "NotaDePedidoToolStripMenuItem"
        Me.NotaDePedidoToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.NotaDePedidoToolStripMenuItem.Text = "Nota de Pedido"
        '
        'NuevaNotaDePedidoToolStripMenuItem
        '
        Me.NuevaNotaDePedidoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.NuevaNotaDePedidoToolStripMenuItem.Name = "NuevaNotaDePedidoToolStripMenuItem"
        Me.NuevaNotaDePedidoToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.NuevaNotaDePedidoToolStripMenuItem.Text = "Nueva.."
        '
        'BuscarNotaDePedidoToolStripMenuItem
        '
        Me.BuscarNotaDePedidoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarNotaDePedidoToolStripMenuItem.Name = "BuscarNotaDePedidoToolStripMenuItem"
        Me.BuscarNotaDePedidoToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.BuscarNotaDePedidoToolStripMenuItem.Text = "Buscar.."
        '
        'OpublicasMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.BaseMenu)
        Me.Name = "OpublicasMenu"
        Me.Size = New System.Drawing.Size(300, 25)
        Me.BaseMenu.ResumeLayout(False)
        Me.BaseMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BaseMenu As MenuStrip
	Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
	Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AsistenciaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BuscarEmpleadoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ContratoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
	Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BuscarProveedorToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NotaDePedidoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NuevaNotaDePedidoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BuscarNotaDePedidoToolStripMenuItem As ToolStripMenuItem
End Class
