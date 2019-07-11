<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConvertirSIRO
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConvertirSIRO))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CalculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarIDÚnicoMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CargarDesdeMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaAgua = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaCatastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaCementerio = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaComercio = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaViviendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargarPadrónContribMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronAgua = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronCatastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronCementerio = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronComercio = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronViviendas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip2.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculosToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(484, 29)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CalculosToolStripMenuItem
        '
        Me.CalculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarIDÚnicoMuniciToolStripMenuItem, Me.ToolStripSeparator2, Me.CargarPadrónContribMuniciToolStripMenuItem, Me.CargarDesdeMuniciToolStripMenuItem, Me.ToolStripSeparator1})
        Me.CalculosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CalculosToolStripMenuItem.Name = "CalculosToolStripMenuItem"
        Me.CalculosToolStripMenuItem.Size = New System.Drawing.Size(75, 25)
        Me.CalculosToolStripMenuItem.Text = "Menu"
        '
        'GenerarIDÚnicoMuniciToolStripMenuItem
        '
        Me.GenerarIDÚnicoMuniciToolStripMenuItem.Name = "GenerarIDÚnicoMuniciToolStripMenuItem"
        Me.GenerarIDÚnicoMuniciToolStripMenuItem.Size = New System.Drawing.Size(357, 30)
        Me.GenerarIDÚnicoMuniciToolStripMenuItem.Text = "Generar ID de pago"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(354, 6)
        '
        'CargarDesdeMuniciToolStripMenuItem
        '
        Me.CargarDesdeMuniciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeudaAgua, Me.DeudaAuto, Me.DeudaCatastro, Me.DeudaCementerio, Me.DeudaComercio, Me.DeudaViviendas})
        Me.CargarDesdeMuniciToolStripMenuItem.Name = "CargarDesdeMuniciToolStripMenuItem"
        Me.CargarDesdeMuniciToolStripMenuItem.Size = New System.Drawing.Size(357, 30)
        Me.CargarDesdeMuniciToolStripMenuItem.Text = "Cargar deudas Munici"
        '
        'DeudaAgua
        '
        Me.DeudaAgua.Name = "DeudaAgua"
        Me.DeudaAgua.Size = New System.Drawing.Size(230, 30)
        Me.DeudaAgua.Text = "Agua"
        '
        'DeudaAuto
        '
        Me.DeudaAuto.Name = "DeudaAuto"
        Me.DeudaAuto.Size = New System.Drawing.Size(230, 30)
        Me.DeudaAuto.Text = "Automotor"
        '
        'DeudaCatastro
        '
        Me.DeudaCatastro.Name = "DeudaCatastro"
        Me.DeudaCatastro.Size = New System.Drawing.Size(230, 30)
        Me.DeudaCatastro.Text = "Catastro"
        '
        'DeudaCementerio
        '
        Me.DeudaCementerio.Name = "DeudaCementerio"
        Me.DeudaCementerio.Size = New System.Drawing.Size(230, 30)
        Me.DeudaCementerio.Text = "Cementerio"
        '
        'DeudaComercio
        '
        Me.DeudaComercio.Name = "DeudaComercio"
        Me.DeudaComercio.Size = New System.Drawing.Size(230, 30)
        Me.DeudaComercio.Text = "Comercio"
        '
        'DeudaViviendas
        '
        Me.DeudaViviendas.Name = "DeudaViviendas"
        Me.DeudaViviendas.Size = New System.Drawing.Size(230, 30)
        Me.DeudaViviendas.Text = "Plan Viviendas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(354, 6)
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.AllowUserToResizeRows = False
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataView.Location = New System.Drawing.Point(0, 0)
        Me.DataView.Name = "DataView"
        Me.DataView.RowHeadersVisible = False
        Me.DataView.RowHeadersWidth = 51
        Me.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataView.Size = New System.Drawing.Size(484, 402)
        Me.DataView.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataView)
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 432)
        Me.Panel2.TabIndex = 30
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.info, Me.progreso})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 402)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(484, 30)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'info
        '
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(14, 24)
        Me.info.Text = "."
        '
        'progreso
        '
        Me.progreso.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.progreso.Maximum = 1
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(200, 22)
        Me.progreso.Step = 1
        Me.progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progreso.Value = 1
        '
        'CargarPadrónContribMuniciToolStripMenuItem
        '
        Me.CargarPadrónContribMuniciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PadronAgua, Me.PadronAuto, Me.PadronCatastro, Me.PadronCementerio, Me.PadronComercio, Me.PadronViviendas})
        Me.CargarPadrónContribMuniciToolStripMenuItem.Name = "CargarPadrónContribMuniciToolStripMenuItem"
        Me.CargarPadrónContribMuniciToolStripMenuItem.Size = New System.Drawing.Size(357, 30)
        Me.CargarPadrónContribMuniciToolStripMenuItem.Text = "Cargar padrón contrib. Munici"
        '
        'PadronAgua
        '
        Me.PadronAgua.Name = "PadronAgua"
        Me.PadronAgua.Size = New System.Drawing.Size(230, 30)
        Me.PadronAgua.Text = "Agua"
        '
        'PadronAuto
        '
        Me.PadronAuto.Name = "PadronAuto"
        Me.PadronAuto.Size = New System.Drawing.Size(230, 30)
        Me.PadronAuto.Text = "Automotor"
        '
        'PadronCatastro
        '
        Me.PadronCatastro.Name = "PadronCatastro"
        Me.PadronCatastro.Size = New System.Drawing.Size(230, 30)
        Me.PadronCatastro.Text = "Catastro"
        '
        'PadronCementerio
        '
        Me.PadronCementerio.Name = "PadronCementerio"
        Me.PadronCementerio.Size = New System.Drawing.Size(230, 30)
        Me.PadronCementerio.Text = "Cementerio"
        '
        'PadronComercio
        '
        Me.PadronComercio.Name = "PadronComercio"
        Me.PadronComercio.Size = New System.Drawing.Size(230, 30)
        Me.PadronComercio.Text = "Comercio"
        '
        'PadronViviendas
        '
        Me.PadronViviendas.Name = "PadronViviendas"
        Me.PadronViviendas.Size = New System.Drawing.Size(230, 30)
        Me.PadronViviendas.Text = "Plan Viviendas"
        '
        'ConvertirSIRO
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "ConvertirSIRO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Conversor SIRO"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CalculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents bs As BindingSource
    Friend WithEvents CargarDesdeMuniciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DeudaAgua As ToolStripMenuItem
    Friend WithEvents DeudaAuto As ToolStripMenuItem
    Friend WithEvents DeudaCatastro As ToolStripMenuItem
    Friend WithEvents DeudaCementerio As ToolStripMenuItem
    Friend WithEvents DeudaComercio As ToolStripMenuItem
    Friend WithEvents DeudaViviendas As ToolStripMenuItem
    Friend WithEvents GenerarIDÚnicoMuniciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents info As ToolStripStatusLabel
    Friend WithEvents progreso As ToolStripProgressBar
    Friend WithEvents CargarPadrónContribMuniciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PadronAgua As ToolStripMenuItem
    Friend WithEvents PadronAuto As ToolStripMenuItem
    Friend WithEvents PadronCatastro As ToolStripMenuItem
    Friend WithEvents PadronCementerio As ToolStripMenuItem
    Friend WithEvents PadronComercio As ToolStripMenuItem
    Friend WithEvents PadronViviendas As ToolStripMenuItem
End Class
