<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisorReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisorReporte))
        Me.ReporteActual = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.top_menu = New System.Windows.Forms.MenuStrip()
        Me.FormulariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanosDeEdificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanosDeMensuraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalDeObraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InspecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LíneaMunicipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrórrogaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActividadComercialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutomotorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutomotorConDDJJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsoGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConstanciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalDeObraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LíneaMunicipalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibreDeudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarFormularioActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.FormulariosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PresentaciónToolStripMenuItem, Me.SolicitudToolStripMenuItem, Me.ConstanciaToolStripMenuItem, Me.ToolStripSeparator4, Me.CerrarFormularioActualToolStripMenuItem})
        Me.FormulariosToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.FormulariosToolStripMenuItem1.Name = "FormulariosToolStripMenuItem1"
        Me.FormulariosToolStripMenuItem1.Size = New System.Drawing.Size(98, 27)
        Me.FormulariosToolStripMenuItem1.Text = "Formularios"
        Me.FormulariosToolStripMenuItem1.Visible = False
        '
        'PresentaciónToolStripMenuItem
        '
        Me.PresentaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanosDeEdificaciónToolStripMenuItem, Me.PlanosDeMensuraToolStripMenuItem})
        Me.PresentaciónToolStripMenuItem.Name = "PresentaciónToolStripMenuItem"
        Me.PresentaciónToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.PresentaciónToolStripMenuItem.Text = "Presentación"
        '
        'PlanosDeEdificaciónToolStripMenuItem
        '
        Me.PlanosDeEdificaciónToolStripMenuItem.Name = "PlanosDeEdificaciónToolStripMenuItem"
        Me.PlanosDeEdificaciónToolStripMenuItem.Size = New System.Drawing.Size(216, 24)
        Me.PlanosDeEdificaciónToolStripMenuItem.Text = "Planos de Edificación"
        '
        'PlanosDeMensuraToolStripMenuItem
        '
        Me.PlanosDeMensuraToolStripMenuItem.Name = "PlanosDeMensuraToolStripMenuItem"
        Me.PlanosDeMensuraToolStripMenuItem.Size = New System.Drawing.Size(216, 24)
        Me.PlanosDeMensuraToolStripMenuItem.Text = "Planos de Mensura"
        '
        'SolicitudToolStripMenuItem
        '
        Me.SolicitudToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalDeObraToolStripMenuItem, Me.InspecciónToolStripMenuItem, Me.LíneaMunicipalToolStripMenuItem, Me.PrórrogaToolStripMenuItem, Me.MediciónToolStripMenuItem, Me.ToolStripSeparator1, Me.ActividadComercialToolStripMenuItem, Me.ToolStripSeparator2, Me.AutomotorToolStripMenuItem, Me.AutomotorConDDJJToolStripMenuItem, Me.ToolStripSeparator3, Me.UsoGeneralToolStripMenuItem})
        Me.SolicitudToolStripMenuItem.Name = "SolicitudToolStripMenuItem"
        Me.SolicitudToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.SolicitudToolStripMenuItem.Text = "Solicitud"
        '
        'FinalDeObraToolStripMenuItem
        '
        Me.FinalDeObraToolStripMenuItem.Name = "FinalDeObraToolStripMenuItem"
        Me.FinalDeObraToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.FinalDeObraToolStripMenuItem.Text = "Final de Obra"
        '
        'InspecciónToolStripMenuItem
        '
        Me.InspecciónToolStripMenuItem.Name = "InspecciónToolStripMenuItem"
        Me.InspecciónToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.InspecciónToolStripMenuItem.Text = "Inspección"
        '
        'LíneaMunicipalToolStripMenuItem
        '
        Me.LíneaMunicipalToolStripMenuItem.Name = "LíneaMunicipalToolStripMenuItem"
        Me.LíneaMunicipalToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.LíneaMunicipalToolStripMenuItem.Text = "Línea Municipal"
        '
        'PrórrogaToolStripMenuItem
        '
        Me.PrórrogaToolStripMenuItem.Name = "PrórrogaToolStripMenuItem"
        Me.PrórrogaToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.PrórrogaToolStripMenuItem.Text = "Prórroga"
        '
        'MediciónToolStripMenuItem
        '
        Me.MediciónToolStripMenuItem.Name = "MediciónToolStripMenuItem"
        Me.MediciónToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.MediciónToolStripMenuItem.Text = "Medición"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(216, 6)
        '
        'ActividadComercialToolStripMenuItem
        '
        Me.ActividadComercialToolStripMenuItem.Name = "ActividadComercialToolStripMenuItem"
        Me.ActividadComercialToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.ActividadComercialToolStripMenuItem.Text = "Actividad Comercial"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(216, 6)
        '
        'AutomotorToolStripMenuItem
        '
        Me.AutomotorToolStripMenuItem.Name = "AutomotorToolStripMenuItem"
        Me.AutomotorToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.AutomotorToolStripMenuItem.Text = "Automotor"
        '
        'AutomotorConDDJJToolStripMenuItem
        '
        Me.AutomotorConDDJJToolStripMenuItem.Name = "AutomotorConDDJJToolStripMenuItem"
        Me.AutomotorConDDJJToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.AutomotorConDDJJToolStripMenuItem.Text = "Automotor con DD.JJ."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(216, 6)
        '
        'UsoGeneralToolStripMenuItem
        '
        Me.UsoGeneralToolStripMenuItem.Name = "UsoGeneralToolStripMenuItem"
        Me.UsoGeneralToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.UsoGeneralToolStripMenuItem.Text = "Uso General"
        '
        'ConstanciaToolStripMenuItem
        '
        Me.ConstanciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalDeObraToolStripMenuItem1, Me.LíneaMunicipalToolStripMenuItem1, Me.ToolStripSeparator5, Me.LibreDeudaToolStripMenuItem})
        Me.ConstanciaToolStripMenuItem.Name = "ConstanciaToolStripMenuItem"
        Me.ConstanciaToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.ConstanciaToolStripMenuItem.Text = "Constancia"
        '
        'FinalDeObraToolStripMenuItem1
        '
        Me.FinalDeObraToolStripMenuItem1.Name = "FinalDeObraToolStripMenuItem1"
        Me.FinalDeObraToolStripMenuItem1.Size = New System.Drawing.Size(181, 24)
        Me.FinalDeObraToolStripMenuItem1.Text = "Final de Obra"
        '
        'LíneaMunicipalToolStripMenuItem1
        '
        Me.LíneaMunicipalToolStripMenuItem1.Name = "LíneaMunicipalToolStripMenuItem1"
        Me.LíneaMunicipalToolStripMenuItem1.Size = New System.Drawing.Size(181, 24)
        Me.LíneaMunicipalToolStripMenuItem1.Text = "Línea Municipal"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(178, 6)
        '
        'LibreDeudaToolStripMenuItem
        '
        Me.LibreDeudaToolStripMenuItem.Name = "LibreDeudaToolStripMenuItem"
        Me.LibreDeudaToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.LibreDeudaToolStripMenuItem.Text = "Libre Deuda"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(229, 6)
        '
        'CerrarFormularioActualToolStripMenuItem
        '
        Me.CerrarFormularioActualToolStripMenuItem.Name = "CerrarFormularioActualToolStripMenuItem"
        Me.CerrarFormularioActualToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.CerrarFormularioActualToolStripMenuItem.Text = "Cerrar formulario actual"
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
        'visor_reporte
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
        Me.Name = "visor_reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGM"
        Me.top_menu.ResumeLayout(False)
        Me.top_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReporteActual As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents top_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents FormulariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanosDeEdificaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanosDeMensuraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitudToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalDeObraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InspecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LíneaMunicipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrórrogaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ActividadComercialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AutomotorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutomotorConDDJJToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UsoGeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConstanciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalDeObraToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LíneaMunicipalToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents titulo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarFormularioActualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LibreDeudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
