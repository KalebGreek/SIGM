<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MesaEntradasMenu
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
        Me.TRATAMIENTODEDEUDASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarImpuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntimacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TasaMunicipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarCertificadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseMenu
        '
        Me.BaseMenu.AutoSize = False
        Me.BaseMenu.BackColor = System.Drawing.Color.Transparent
        Me.BaseMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaseMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BaseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TRATAMIENTODEDEUDASToolStripMenuItem})
        Me.BaseMenu.Location = New System.Drawing.Point(0, 0)
        Me.BaseMenu.Name = "BaseMenu"
        Me.BaseMenu.Size = New System.Drawing.Size(300, 27)
        Me.BaseMenu.TabIndex = 389
        Me.BaseMenu.Text = "MenuStrip1"
        '
        'TRATAMIENTODEDEUDASToolStripMenuItem
        '
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarImpuestoToolStripMenuItem, Me.GenerarCertificadoToolStripMenuItem, Me.IntimacionesToolStripMenuItem, Me.ToolStripSeparator1, Me.TasaMunicipalToolStripMenuItem, Me.ToolStripSeparator2, Me.FormulariosToolStripMenuItem})
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.Name = "TRATAMIENTODEDEUDASToolStripMenuItem"
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.Size = New System.Drawing.Size(124, 23)
        Me.TRATAMIENTODEDEUDASToolStripMenuItem.Text = "RECAUDACIÓN"
        '
        'ConsultarImpuestoToolStripMenuItem
        '
        Me.ConsultarImpuestoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ConsultarImpuestoToolStripMenuItem.Name = "ConsultarImpuestoToolStripMenuItem"
        Me.ConsultarImpuestoToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.ConsultarImpuestoToolStripMenuItem.Text = "Consultar Deuda Total"
        '
        'IntimacionesToolStripMenuItem
        '
        Me.IntimacionesToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.IntimacionesToolStripMenuItem.Name = "IntimacionesToolStripMenuItem"
        Me.IntimacionesToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.IntimacionesToolStripMenuItem.Text = "Intimaciones"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(235, 6)
        '
        'FormulariosToolStripMenuItem
        '
        Me.FormulariosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.FormulariosToolStripMenuItem.Name = "FormulariosToolStripMenuItem"
        Me.FormulariosToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.FormulariosToolStripMenuItem.Text = "Formularios"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(235, 6)
        '
        'TasaMunicipalToolStripMenuItem
        '
        Me.TasaMunicipalToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.TasaMunicipalToolStripMenuItem.Name = "TasaMunicipalToolStripMenuItem"
        Me.TasaMunicipalToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.TasaMunicipalToolStripMenuItem.Text = "Cálculo Tasa Municipal"
        '
        'GenerarCertificadoToolStripMenuItem
        '
        Me.GenerarCertificadoToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.GenerarCertificadoToolStripMenuItem.Name = "GenerarCertificadoToolStripMenuItem"
        Me.GenerarCertificadoToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.GenerarCertificadoToolStripMenuItem.Text = "Generar Libre Deuda"
        '
        'MesaEntradasMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Controls.Add(Me.BaseMenu)
        Me.Name = "MesaEntradasMenu"
        Me.Size = New System.Drawing.Size(300, 25)
        Me.BaseMenu.ResumeLayout(False)
        Me.BaseMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BaseMenu As MenuStrip
    Friend WithEvents TRATAMIENTODEDEUDASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarImpuestoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntimacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TasaMunicipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents GenerarCertificadoToolStripMenuItem As ToolStripMenuItem
End Class
