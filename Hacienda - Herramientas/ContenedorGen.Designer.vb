﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorGen))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.user_id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BaseMenu = New System.Windows.Forms.MenuStrip()
        Me.CatastroMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarInmuebleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GobiernoMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaOrdenanzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarOrdenanzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HaciendaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HaciendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarImpuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCuentaAgrupadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasEspecialesStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculoAnualDeImpuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibreDeudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarCertificadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OprivadasMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarExpedienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProfesionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPublicasMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.NuevoContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarActaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComercioMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.BaseMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.progreso, Me.user_id})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 414)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(990, 23)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 386
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(959, 18)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'progreso
        '
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(150, 17)
        Me.progreso.Step = 1
        Me.progreso.Visible = False
        '
        'user_id
        '
        Me.user_id.BackColor = System.Drawing.Color.Transparent
        Me.user_id.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.user_id.Name = "user_id"
        Me.user_id.Size = New System.Drawing.Size(16, 18)
        Me.user_id.Text = "0"
        '
        'BaseMenu
        '
        Me.BaseMenu.BackColor = System.Drawing.Color.DimGray
        Me.BaseMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BaseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatastroMenu, Me.GobiernoMenu, Me.HaciendaMenu, Me.OprivadasMenu, Me.OPublicasMenu, Me.PersonaMenu, Me.ComercioMenu, Me.SalirToolStripMenuItem})
        Me.BaseMenu.Location = New System.Drawing.Point(0, 0)
        Me.BaseMenu.Name = "BaseMenu"
        Me.BaseMenu.Size = New System.Drawing.Size(990, 27)
        Me.BaseMenu.TabIndex = 388
        Me.BaseMenu.Text = "MenuStrip1"
        '
        'CatastroMenu
        '
        Me.CatastroMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarInmuebleToolStripMenuItem, Me.ToolStripSeparator2, Me.ConsultarPagosToolStripMenuItem})
        Me.CatastroMenu.ForeColor = System.Drawing.Color.White
        Me.CatastroMenu.Name = "CatastroMenu"
        Me.CatastroMenu.Size = New System.Drawing.Size(108, 27)
        Me.CatastroMenu.Text = "CATASTRO"
        Me.CatastroMenu.Visible = False
        '
        'BuscarInmuebleToolStripMenuItem
        '
        Me.BuscarInmuebleToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarInmuebleToolStripMenuItem.Name = "BuscarInmuebleToolStripMenuItem"
        Me.BuscarInmuebleToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.BuscarInmuebleToolStripMenuItem.Text = "Buscar Inmueble"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'ConsultarPagosToolStripMenuItem
        '
        Me.ConsultarPagosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultarPagosToolStripMenuItem.Name = "ConsultarPagosToolStripMenuItem"
        Me.ConsultarPagosToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.ConsultarPagosToolStripMenuItem.Text = "Consultar Pagos"
        '
        'GobiernoMenu
        '
        Me.GobiernoMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaOrdenanzaToolStripMenuItem, Me.BuscarOrdenanzaToolStripMenuItem})
        Me.GobiernoMenu.ForeColor = System.Drawing.Color.White
        Me.GobiernoMenu.Name = "GobiernoMenu"
        Me.GobiernoMenu.Size = New System.Drawing.Size(107, 27)
        Me.GobiernoMenu.Text = "GOBIERNO"
        Me.GobiernoMenu.Visible = False
        '
        'NuevaOrdenanzaToolStripMenuItem
        '
        Me.NuevaOrdenanzaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.NuevaOrdenanzaToolStripMenuItem.Name = "NuevaOrdenanzaToolStripMenuItem"
        Me.NuevaOrdenanzaToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.NuevaOrdenanzaToolStripMenuItem.Text = "Nueva Ordenanza"
        '
        'BuscarOrdenanzaToolStripMenuItem
        '
        Me.BuscarOrdenanzaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarOrdenanzaToolStripMenuItem.Name = "BuscarOrdenanzaToolStripMenuItem"
        Me.BuscarOrdenanzaToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.BuscarOrdenanzaToolStripMenuItem.Text = "Buscar Ordenanza"
        '
        'HaciendaMenu
        '
        Me.HaciendaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HaciendaToolStripMenuItem, Me.ConsultarImpuestoToolStripMenuItem, Me.ConsultarCuentaAgrupadaToolStripMenuItem, Me.ConsultaDeMovimientosToolStripMenuItem, Me.ConsultasEspecialesStripMenuItem, Me.ToolStripSeparator3, Me.ToolStripMenuItem1, Me.CalculoAnualDeImpuestosToolStripMenuItem, Me.LibreDeudaToolStripMenuItem})
        Me.HaciendaMenu.ForeColor = System.Drawing.Color.White
        Me.HaciendaMenu.Name = "HaciendaMenu"
        Me.HaciendaMenu.Size = New System.Drawing.Size(109, 27)
        Me.HaciendaMenu.Text = "HACIENDA"
        Me.HaciendaMenu.Visible = False
        '
        'HaciendaToolStripMenuItem
        '
        Me.HaciendaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.HaciendaToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.HaciendaToolStripMenuItem.Name = "HaciendaToolStripMenuItem"
        Me.HaciendaToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.HaciendaToolStripMenuItem.Text = "Consultas"
        '
        'ConsultarImpuestoToolStripMenuItem
        '
        Me.ConsultarImpuestoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultarImpuestoToolStripMenuItem.Name = "ConsultarImpuestoToolStripMenuItem"
        Me.ConsultarImpuestoToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.ConsultarImpuestoToolStripMenuItem.Text = "Impuestos y Deuda Total"
        '
        'ConsultarCuentaAgrupadaToolStripMenuItem
        '
        Me.ConsultarCuentaAgrupadaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultarCuentaAgrupadaToolStripMenuItem.Name = "ConsultarCuentaAgrupadaToolStripMenuItem"
        Me.ConsultarCuentaAgrupadaToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.ConsultarCuentaAgrupadaToolStripMenuItem.Text = "Cuenta Agrupada"
        '
        'ConsultaDeMovimientosToolStripMenuItem
        '
        Me.ConsultaDeMovimientosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultaDeMovimientosToolStripMenuItem.Name = "ConsultaDeMovimientosToolStripMenuItem"
        Me.ConsultaDeMovimientosToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.ConsultaDeMovimientosToolStripMenuItem.Text = "Movimientos por Cuenta"
        '
        'ConsultasEspecialesStripMenuItem
        '
        Me.ConsultasEspecialesStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultasEspecialesStripMenuItem.Name = "ConsultasEspecialesStripMenuItem"
        Me.ConsultasEspecialesStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.ConsultasEspecialesStripMenuItem.Text = "Consultas Especiales"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(256, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.DimGray
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(259, 24)
        Me.ToolStripMenuItem1.Text = "Herramientas"
        '
        'CalculoAnualDeImpuestosToolStripMenuItem
        '
        Me.CalculoAnualDeImpuestosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.CalculoAnualDeImpuestosToolStripMenuItem.Name = "CalculoAnualDeImpuestosToolStripMenuItem"
        Me.CalculoAnualDeImpuestosToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.CalculoAnualDeImpuestosToolStripMenuItem.Text = "Calculo Anual de Impuestos"
        '
        'LibreDeudaToolStripMenuItem
        '
        Me.LibreDeudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarCertificadoToolStripMenuItem})
        Me.LibreDeudaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibreDeudaToolStripMenuItem.Name = "LibreDeudaToolStripMenuItem"
        Me.LibreDeudaToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.LibreDeudaToolStripMenuItem.Text = "Libre Deuda"
        '
        'GenerarCertificadoToolStripMenuItem
        '
        Me.GenerarCertificadoToolStripMenuItem.Name = "GenerarCertificadoToolStripMenuItem"
        Me.GenerarCertificadoToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.GenerarCertificadoToolStripMenuItem.Text = "Generar Certificado"
        '
        'OprivadasMenu
        '
        Me.OprivadasMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarExpedienteToolStripMenuItem, Me.BuscarProfesionalToolStripMenuItem})
        Me.OprivadasMenu.ForeColor = System.Drawing.Color.White
        Me.OprivadasMenu.Name = "OprivadasMenu"
        Me.OprivadasMenu.Size = New System.Drawing.Size(167, 27)
        Me.OprivadasMenu.Text = "OBRAS PRIVADAS"
        Me.OprivadasMenu.Visible = False
        '
        'BuscarExpedienteToolStripMenuItem
        '
        Me.BuscarExpedienteToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarExpedienteToolStripMenuItem.Name = "BuscarExpedienteToolStripMenuItem"
        Me.BuscarExpedienteToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.BuscarExpedienteToolStripMenuItem.Text = "Buscar Expediente"
        '
        'BuscarProfesionalToolStripMenuItem
        '
        Me.BuscarProfesionalToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarProfesionalToolStripMenuItem.Name = "BuscarProfesionalToolStripMenuItem"
        Me.BuscarProfesionalToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.BuscarProfesionalToolStripMenuItem.Text = "Buscar Profesional"
        '
        'OPublicasMenu
        '
        Me.OPublicasMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsistenciaToolStripMenuItem, Me.BuscarEmpleadoToolStripMenuItem, Me.ToolStripSeparator7, Me.NuevoContratoToolStripMenuItem, Me.BuscarContratoToolStripMenuItem})
        Me.OPublicasMenu.ForeColor = System.Drawing.Color.White
        Me.OPublicasMenu.Name = "OPublicasMenu"
        Me.OPublicasMenu.Size = New System.Drawing.Size(167, 27)
        Me.OPublicasMenu.Text = "OBRAS PUBLICAS"
        Me.OPublicasMenu.Visible = False
        '
        'AsistenciaToolStripMenuItem
        '
        Me.AsistenciaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem"
        Me.AsistenciaToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.AsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'BuscarEmpleadoToolStripMenuItem
        '
        Me.BuscarEmpleadoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarEmpleadoToolStripMenuItem.Name = "BuscarEmpleadoToolStripMenuItem"
        Me.BuscarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.BuscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(188, 6)
        '
        'NuevoContratoToolStripMenuItem
        '
        Me.NuevoContratoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.NuevoContratoToolStripMenuItem.Name = "NuevoContratoToolStripMenuItem"
        Me.NuevoContratoToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.NuevoContratoToolStripMenuItem.Text = "Nuevo Contrato"
        '
        'BuscarContratoToolStripMenuItem
        '
        Me.BuscarContratoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarContratoToolStripMenuItem.Name = "BuscarContratoToolStripMenuItem"
        Me.BuscarContratoToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.BuscarContratoToolStripMenuItem.Text = "Buscar Contrato"
        '
        'PersonaMenu
        '
        Me.PersonaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPersonaToolStripMenuItem, Me.BuscarPersonaToolStripMenuItem, Me.ToolStripSeparator1, Me.BuscarActaToolStripMenuItem})
        Me.PersonaMenu.ForeColor = System.Drawing.Color.White
        Me.PersonaMenu.Name = "PersonaMenu"
        Me.PersonaMenu.Size = New System.Drawing.Size(101, 27)
        Me.PersonaMenu.Text = "PERSONA"
        Me.PersonaMenu.Visible = False
        '
        'NuevaPersonaToolStripMenuItem
        '
        Me.NuevaPersonaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.NuevaPersonaToolStripMenuItem.Name = "NuevaPersonaToolStripMenuItem"
        Me.NuevaPersonaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.NuevaPersonaToolStripMenuItem.Text = "Nueva Persona"
        '
        'BuscarPersonaToolStripMenuItem
        '
        Me.BuscarPersonaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarPersonaToolStripMenuItem.Name = "BuscarPersonaToolStripMenuItem"
        Me.BuscarPersonaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.BuscarPersonaToolStripMenuItem.Text = "Buscar Persona"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'BuscarActaToolStripMenuItem
        '
        Me.BuscarActaToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarActaToolStripMenuItem.Name = "BuscarActaToolStripMenuItem"
        Me.BuscarActaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.BuscarActaToolStripMenuItem.Text = "Buscar Acta"
        '
        'ComercioMenu
        '
        Me.ComercioMenu.ForeColor = System.Drawing.Color.White
        Me.ComercioMenu.Name = "ComercioMenu"
        Me.ComercioMenu.Size = New System.Drawing.Size(108, 27)
        Me.ComercioMenu.Text = "COMERCIO"
        Me.ComercioMenu.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(51, 23)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ContenedorGen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(990, 437)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BaseMenu)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(625, 425)
        Me.Name = "ContenedorGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.BaseMenu.ResumeLayout(False)
        Me.BaseMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents user_id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BaseMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents OPublicasMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GobiernoMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HaciendaMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HaciendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OprivadasMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonaMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatastroMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents AsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents NuevoContratoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarContratoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarExpedienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarProfesionalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaOrdenanzaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarOrdenanzaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarImpuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCuentaAgrupadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CalculoAnualDeImpuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BuscarActaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarInmuebleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibreDeudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarCertificadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComercioMenu As ToolStripMenuItem
    Friend WithEvents ConsultasEspecialesStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeMovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
