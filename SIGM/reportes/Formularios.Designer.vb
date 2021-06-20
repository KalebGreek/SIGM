<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formularios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formularios))
        Me.ReporteActual = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.top_menu = New System.Windows.Forms.MenuStrip()
        Me.FormulariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComercioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sic = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesaDeEntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nop = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sia = New System.Windows.Forms.ToolStripMenuItem()
        Me.sid = New System.Windows.Forms.ToolStripMenuItem()
        Me.sug = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObrasPrivadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConstanciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.clm = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imh = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentaciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ppe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ppm = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sed = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.sin = New System.Windows.Forms.ToolStripMenuItem()
        Me.slm = New System.Windows.Forms.ToolStripMenuItem()
        Me.smt = New System.Windows.Forms.ToolStripMenuItem()
        Me.spr = New System.Windows.Forms.ToolStripMenuItem()
        Me.titulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.top_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReporteActual
        '
        Me.ReporteActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReporteActual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReporteActual.LocalReport.ReportEmbeddedResource = "SIGM.opr_ppe_blank.rdlc"
        Me.ReporteActual.Location = New System.Drawing.Point(0, 33)
        Me.ReporteActual.Name = "ReporteActual"
        Me.ReporteActual.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReporteActual.ShowContextMenu = False
        Me.ReporteActual.ShowCredentialPrompts = False
        Me.ReporteActual.ShowParameterPrompts = False
        Me.ReporteActual.ShowProgress = False
        Me.ReporteActual.Size = New System.Drawing.Size(780, 524)
        Me.ReporteActual.TabIndex = 0
        Me.ReporteActual.Visible = False
        '
        'top_menu
        '
        Me.top_menu.AutoSize = False
        Me.top_menu.BackColor = System.Drawing.Color.LightSlateGray
        Me.top_menu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.top_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormulariosToolStripMenuItem1, Me.titulo, Me.SalirToolStripMenuItem})
        Me.top_menu.Location = New System.Drawing.Point(0, 0)
        Me.top_menu.Name = "top_menu"
        Me.top_menu.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.top_menu.Size = New System.Drawing.Size(780, 33)
        Me.top_menu.TabIndex = 1
        '
        'FormulariosToolStripMenuItem1
        '
        Me.FormulariosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComercioToolStripMenuItem, Me.MesaDeEntradaToolStripMenuItem, Me.ObrasPrivadasToolStripMenuItem, Me.ToolStripSeparator4, Me.CerrarFormToolStripMenuItem})
        Me.FormulariosToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.FormulariosToolStripMenuItem1.Name = "FormulariosToolStripMenuItem1"
        Me.FormulariosToolStripMenuItem1.Size = New System.Drawing.Size(98, 27)
        Me.FormulariosToolStripMenuItem1.Text = "Formularios"
        Me.FormulariosToolStripMenuItem1.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'CerrarFormToolStripMenuItem
        '
        Me.CerrarFormToolStripMenuItem.Name = "CerrarFormToolStripMenuItem"
        Me.CerrarFormToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.CerrarFormToolStripMenuItem.Text = "Cerrar Formulario"
        '
        'ComercioToolStripMenuItem
        '
        Me.ComercioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sic})
        Me.ComercioToolStripMenuItem.Name = "ComercioToolStripMenuItem"
        Me.ComercioToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ComercioToolStripMenuItem.Text = "Comercio"
        '
        'sic
        '
        Me.sic.Name = "sic"
        Me.sic.Size = New System.Drawing.Size(281, 24)
        Me.sic.Text = "Inscripción Actividad Comercial"
        '
        'MesaDeEntradaToolStripMenuItem
        '
        Me.MesaDeEntradaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nop, Me.InscripciónToolStripMenuItem, Me.sug})
        Me.MesaDeEntradaToolStripMenuItem.Name = "MesaDeEntradaToolStripMenuItem"
        Me.MesaDeEntradaToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.MesaDeEntradaToolStripMenuItem.Text = "Mesa de Entrada"
        '
        'nop
        '
        Me.nop.Name = "nop"
        Me.nop.Size = New System.Drawing.Size(179, 24)
        Me.nop.Text = "Nota de Pedido"
        '
        'InscripciónToolStripMenuItem
        '
        Me.InscripciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sia, Me.sid})
        Me.InscripciónToolStripMenuItem.Name = "InscripciónToolStripMenuItem"
        Me.InscripciónToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.InscripciónToolStripMenuItem.Text = "Inscripción"
        '
        'sia
        '
        Me.sia.Name = "sia"
        Me.sia.Size = New System.Drawing.Size(219, 24)
        Me.sia.Text = "Automotor"
        '
        'sid
        '
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(219, 24)
        Me.sid.Text = "Automotor con DD.JJ."
        '
        'sug
        '
        Me.sug.Name = "sug"
        Me.sug.Size = New System.Drawing.Size(179, 24)
        Me.sug.Text = "Uso General"
        '
        'ObrasPrivadasToolStripMenuItem
        '
        Me.ObrasPrivadasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConstanciaToolStripMenuItem, Me.InformeToolStripMenuItem, Me.PresentaciónToolStripMenuItem1, Me.SolicitudToolStripMenuItem})
        Me.ObrasPrivadasToolStripMenuItem.Name = "ObrasPrivadasToolStripMenuItem"
        Me.ObrasPrivadasToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.ObrasPrivadasToolStripMenuItem.Text = "Obras Privadas"
        '
        'ConstanciaToolStripMenuItem
        '
        Me.ConstanciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cfo, Me.clm})
        Me.ConstanciaToolStripMenuItem.Name = "ConstanciaToolStripMenuItem"
        Me.ConstanciaToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.ConstanciaToolStripMenuItem.Text = "Constancia"
        '
        'cfo
        '
        Me.cfo.Name = "cfo"
        Me.cfo.Size = New System.Drawing.Size(181, 24)
        Me.cfo.Text = "Final de Obra"
        '
        'clm
        '
        Me.clm.Name = "clm"
        Me.clm.Size = New System.Drawing.Size(181, 24)
        Me.clm.Text = "Línea Municipal"
        '
        'InformeToolStripMenuItem
        '
        Me.InformeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imh})
        Me.InformeToolStripMenuItem.Name = "InformeToolStripMenuItem"
        Me.InformeToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.InformeToolStripMenuItem.Text = "Informe"
        '
        'imh
        '
        Me.imh.Name = "imh"
        Me.imh.Size = New System.Drawing.Size(234, 24)
        Me.imh.Text = "Módulos Habitacionales"
        '
        'PresentaciónToolStripMenuItem1
        '
        Me.PresentaciónToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ppe, Me.ppm})
        Me.PresentaciónToolStripMenuItem1.Name = "PresentaciónToolStripMenuItem1"
        Me.PresentaciónToolStripMenuItem1.Size = New System.Drawing.Size(164, 24)
        Me.PresentaciónToolStripMenuItem1.Text = "Presentación"
        '
        'ppe
        '
        Me.ppe.Name = "ppe"
        Me.ppe.Size = New System.Drawing.Size(216, 24)
        Me.ppe.Text = "Planos de Edificación"
        '
        'ppm
        '
        Me.ppm.Name = "ppm"
        Me.ppm.Size = New System.Drawing.Size(216, 24)
        Me.ppm.Text = "Planos de Mensura"
        '
        'SolicitudToolStripMenuItem
        '
        Me.SolicitudToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sed, Me.sfo, Me.sin, Me.slm, Me.smt, Me.spr})
        Me.SolicitudToolStripMenuItem.Name = "SolicitudToolStripMenuItem"
        Me.SolicitudToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.SolicitudToolStripMenuItem.Text = "Solicitud"
        '
        'sed
        '
        Me.sed.Name = "sed"
        Me.sed.Size = New System.Drawing.Size(248, 24)
        Me.sed.Text = "Estado de Documentación"
        '
        'sfo
        '
        Me.sfo.Name = "sfo"
        Me.sfo.Size = New System.Drawing.Size(248, 24)
        Me.sfo.Text = "Final de Obra"
        '
        'sin
        '
        Me.sin.Name = "sin"
        Me.sin.Size = New System.Drawing.Size(248, 24)
        Me.sin.Text = "Inspección"
        '
        'slm
        '
        Me.slm.Name = "slm"
        Me.slm.Size = New System.Drawing.Size(248, 24)
        Me.slm.Text = "Línea Municipal"
        '
        'smt
        '
        Me.smt.Name = "smt"
        Me.smt.Size = New System.Drawing.Size(248, 24)
        Me.smt.Text = "Medición"
        '
        'spr
        '
        Me.spr.Name = "spr"
        Me.spr.Size = New System.Drawing.Size(248, 24)
        Me.spr.Text = "Prórroga"
        '
        'titulo
        '
        Me.titulo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.titulo.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.ForeColor = System.Drawing.Color.White
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(141, 27)
        Me.titulo.Text = "FORMULARIOS"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(62, 27)
        Me.SalirToolStripMenuItem.Text = "Volver"
        '
        'Formularios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(780, 557)
        Me.Controls.Add(Me.ReporteActual)
        Me.Controls.Add(Me.top_menu)
        Me.Font = New System.Drawing.Font("PF DinText Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Formularios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGM"
        Me.top_menu.ResumeLayout(False)
        Me.top_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents top_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents FormulariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents titulo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ReporteActual As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ObrasPrivadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sfo As ToolStripMenuItem
    Friend WithEvents sin As ToolStripMenuItem
    Friend WithEvents slm As ToolStripMenuItem
    Friend WithEvents spr As ToolStripMenuItem
    Friend WithEvents smt As ToolStripMenuItem
    Friend WithEvents PresentaciónToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ppe As ToolStripMenuItem
    Friend WithEvents ppm As ToolStripMenuItem
    Friend WithEvents ConstanciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cfo As ToolStripMenuItem
    Friend WithEvents clm As ToolStripMenuItem
    Friend WithEvents ComercioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sic As ToolStripMenuItem
    Friend WithEvents MesaDeEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents nop As ToolStripMenuItem
    Friend WithEvents sug As ToolStripMenuItem
    Friend WithEvents InscripciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sia As ToolStripMenuItem
    Friend WithEvents sid As ToolStripMenuItem
    Friend WithEvents sed As ToolStripMenuItem
    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents imh As ToolStripMenuItem
End Class
