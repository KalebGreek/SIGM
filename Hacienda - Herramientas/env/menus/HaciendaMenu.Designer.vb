<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HaciendaMenu
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
        Me.ConsultaDeMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasEspecialesStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolidarIngresosYEgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdelantosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CombustibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConversorSIROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIJCORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CalculoAnualDeImpuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRATAMIENTODEDEUDASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarImpuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibreDeudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarCertificadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntimacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseMenu
        '
        Me.BaseMenu.AutoSize = False
        Me.BaseMenu.BackColor = System.Drawing.Color.Transparent
        Me.BaseMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaseMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BaseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.topHaciendaMenu, Me.TRATAMIENTODEDEUDASToolStripMenuItem})
        Me.BaseMenu.Location = New System.Drawing.Point(0, 0)
        Me.BaseMenu.Name = "BaseMenu"
        Me.BaseMenu.Size = New System.Drawing.Size(300, 27)
        Me.BaseMenu.TabIndex = 389
        Me.BaseMenu.Text = "MenuStrip1"
        '
        'topHaciendaMenu
        '
        Me.topHaciendaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDeMovimientosToolStripMenuItem, Me.ConsultasEspecialesStripMenuItem, Me.ConsolidarIngresosYEgresosToolStripMenuItem, Me.ToolStripSeparator6, Me.AdelantosToolStripMenuItem, Me.CombustibleToolStripMenuItem, Me.ToolStripSeparator1, Me.ConversorSIROToolStripMenuItem, Me.SIJCORToolStripMenuItem, Me.ToolStripSeparator3, Me.CalculoAnualDeImpuestosToolStripMenuItem})
        Me.topHaciendaMenu.ForeColor = System.Drawing.Color.White
        Me.topHaciendaMenu.Name = "topHaciendaMenu"
        Me.topHaciendaMenu.Padding = New System.Windows.Forms.Padding(0)
        Me.topHaciendaMenu.Size = New System.Drawing.Size(87, 23)
        Me.topHaciendaMenu.Text = "HACIENDA"
        '
        'ConsultaDeMovimientosToolStripMenuItem
        '
        Me.ConsultaDeMovimientosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultaDeMovimientosToolStripMenuItem.Name = "ConsultaDeMovimientosToolStripMenuItem"
        Me.ConsultaDeMovimientosToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.ConsultaDeMovimientosToolStripMenuItem.Text = "Movimientos por Cuenta"
        '
        'ConsultasEspecialesStripMenuItem
        '
        Me.ConsultasEspecialesStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultasEspecialesStripMenuItem.Name = "ConsultasEspecialesStripMenuItem"
        Me.ConsultasEspecialesStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.ConsultasEspecialesStripMenuItem.Text = "Consultas Especiales"
        '
        'ConsolidarIngresosYEgresosToolStripMenuItem
        '
        Me.ConsolidarIngresosYEgresosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsolidarIngresosYEgresosToolStripMenuItem.Name = "ConsolidarIngresosYEgresosToolStripMenuItem"
        Me.ConsolidarIngresosYEgresosToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.ConsolidarIngresosYEgresosToolStripMenuItem.Text = "Consolidar Ingresos y Egresos"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(269, 6)
        '
        'AdelantosToolStripMenuItem
        '
        Me.AdelantosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.AdelantosToolStripMenuItem.Name = "AdelantosToolStripMenuItem"
        Me.AdelantosToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.AdelantosToolStripMenuItem.Text = "Adelantos"
        '
        'CombustibleToolStripMenuItem
        '
        Me.CombustibleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketsToolStripMenuItem})
        Me.CombustibleToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.CombustibleToolStripMenuItem.Name = "CombustibleToolStripMenuItem"
        Me.CombustibleToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.CombustibleToolStripMenuItem.Text = "Combustible"
        '
        'TicketsToolStripMenuItem
        '
        Me.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem"
        Me.TicketsToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.TicketsToolStripMenuItem.Text = "Tickets"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(269, 6)
        '
        'ConversorSIROToolStripMenuItem
        '
        Me.ConversorSIROToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConversorSIROToolStripMenuItem.Name = "ConversorSIROToolStripMenuItem"
        Me.ConversorSIROToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.ConversorSIROToolStripMenuItem.Text = "Conversor SIRO"
        '
        'SIJCORToolStripMenuItem
        '
        Me.SIJCORToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.SIJCORToolStripMenuItem.Name = "SIJCORToolStripMenuItem"
        Me.SIJCORToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.SIJCORToolStripMenuItem.Text = "SIJCOR"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(269, 6)
        '
        'CalculoAnualDeImpuestosToolStripMenuItem
        '
        Me.CalculoAnualDeImpuestosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.CalculoAnualDeImpuestosToolStripMenuItem.Name = "CalculoAnualDeImpuestosToolStripMenuItem"
        Me.CalculoAnualDeImpuestosToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.CalculoAnualDeImpuestosToolStripMenuItem.Text = "Generar Deuda Anual"
        '
        'TRATAMIENTODEDEUDASToolStripMenuItem
        '
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarImpuestoToolStripMenuItem, Me.LibreDeudaToolStripMenuItem, Me.IntimacionesToolStripMenuItem})
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.Name = "TRATAMIENTODEDEUDASToolStripMenuItem"
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.Size = New System.Drawing.Size(124, 23)
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.Text = "RECAUDACIÓN"
        '
        'ConsultarImpuestoToolStripMenuItem
        '
        Me.ConsultarImpuestoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultarImpuestoToolStripMenuItem.Name = "ConsultarImpuestoToolStripMenuItem"
        Me.ConsultarImpuestoToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.ConsultarImpuestoToolStripMenuItem.Text = "Impuestos y Deuda Total"
        '
        'LibreDeudaToolStripMenuItem
        '
        Me.LibreDeudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarCertificadoToolStripMenuItem})
        Me.LibreDeudaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibreDeudaToolStripMenuItem.Name = "LibreDeudaToolStripMenuItem"
        Me.LibreDeudaToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.LibreDeudaToolStripMenuItem.Text = "Libre Deuda"
        '
        'GenerarCertificadoToolStripMenuItem
        '
        Me.GenerarCertificadoToolStripMenuItem.Name = "GenerarCertificadoToolStripMenuItem"
        Me.GenerarCertificadoToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.GenerarCertificadoToolStripMenuItem.Text = "Generar Certificado"
        '
        'IntimacionesToolStripMenuItem
        '
        Me.IntimacionesToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.IntimacionesToolStripMenuItem.Name = "IntimacionesToolStripMenuItem"
        Me.IntimacionesToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.IntimacionesToolStripMenuItem.Text = "Intimaciones"
        '
        'HaciendaMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Controls.Add(Me.BaseMenu)
        Me.Name = "HaciendaMenu"
        Me.Size = New System.Drawing.Size(300, 25)
        Me.BaseMenu.ResumeLayout(False)
        Me.BaseMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BaseMenu As MenuStrip
	Friend WithEvents topHaciendaMenu As ToolStripMenuItem
    Friend WithEvents CalculoAnualDeImpuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AdelantosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CombustibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIJCORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ConsultaDeMovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasEspecialesStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsolidarIngresosYEgresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConversorSIROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TRATAMIENTODEDEUDASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarImpuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibreDeudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarCertificadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntimacionesToolStripMenuItem As ToolStripMenuItem
End Class
