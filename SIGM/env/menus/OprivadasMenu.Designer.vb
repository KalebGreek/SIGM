<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OprivadasMenu
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
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.NuevoExpedienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BuscarExpedienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.FormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.BuscarProfesionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CalculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BaseMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'BaseMenu
		'
		Me.BaseMenu.BackColor = System.Drawing.Color.Transparent
		Me.BaseMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
		Me.BaseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
		Me.BaseMenu.Location = New System.Drawing.Point(0, 0)
		Me.BaseMenu.Name = "BaseMenu"
		Me.BaseMenu.Size = New System.Drawing.Size(300, 27)
		Me.BaseMenu.TabIndex = 389
		Me.BaseMenu.Text = "MenuStrip1"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.NuevoExpedienteToolStripMenuItem, Me.BuscarExpedienteToolStripMenuItem, Me.ToolStripSeparator5, Me.FormulariosToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem4, Me.BuscarProfesionalToolStripMenuItem, Me.CalculosToolStripMenuItem})
		Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(0)
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(142, 23)
		Me.ToolStripMenuItem2.Text = "OBRAS PRIVADAS"
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Enabled = False
		Me.ToolStripMenuItem3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(200, 24)
		Me.ToolStripMenuItem3.Text = "Expedientes"
		'
		'NuevoExpedienteToolStripMenuItem
		'
		Me.NuevoExpedienteToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.NuevoExpedienteToolStripMenuItem.Name = "NuevoExpedienteToolStripMenuItem"
		Me.NuevoExpedienteToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
		Me.NuevoExpedienteToolStripMenuItem.Text = "Nuevo Expediente"
		'
		'BuscarExpedienteToolStripMenuItem
		'
		Me.BuscarExpedienteToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.BuscarExpedienteToolStripMenuItem.Name = "BuscarExpedienteToolStripMenuItem"
		Me.BuscarExpedienteToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
		Me.BuscarExpedienteToolStripMenuItem.Text = "Buscar Expediente"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(197, 6)
		'
		'FormulariosToolStripMenuItem
		'
		Me.FormulariosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormulariosToolStripMenuItem.Name = "FormulariosToolStripMenuItem"
		Me.FormulariosToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
		Me.FormulariosToolStripMenuItem.Text = "Formularios"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(197, 6)
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.Enabled = False
		Me.ToolStripMenuItem4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(200, 24)
		Me.ToolStripMenuItem4.Text = "Herramientas"
		'
		'BuscarProfesionalToolStripMenuItem
		'
		Me.BuscarProfesionalToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.BuscarProfesionalToolStripMenuItem.Name = "BuscarProfesionalToolStripMenuItem"
		Me.BuscarProfesionalToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
		Me.BuscarProfesionalToolStripMenuItem.Text = "Buscar Profesional"
		'
		'CalculosToolStripMenuItem
		'
		Me.CalculosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.CalculosToolStripMenuItem.Name = "CalculosToolStripMenuItem"
		Me.CalculosToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
		Me.CalculosToolStripMenuItem.Text = "Calculadora"
		'
		'OprivadasMenu
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.Controls.Add(Me.BaseMenu)
		Me.Name = "OprivadasMenu"
		Me.Size = New System.Drawing.Size(300, 25)
		Me.BaseMenu.ResumeLayout(False)
		Me.BaseMenu.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BaseMenu As MenuStrip
	Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
	Friend WithEvents NuevoExpedienteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BuscarExpedienteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
	Friend WithEvents FormulariosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
	Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
	Friend WithEvents BuscarProfesionalToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CalculosToolStripMenuItem As ToolStripMenuItem
End Class
