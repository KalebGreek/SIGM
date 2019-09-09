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
        Me.CargarPadrónContribMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronAgua = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronCatastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronCementerio = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronComercio = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadronVivienda = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarDesdeMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoraAgua = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoraAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoraCatastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoraCementerio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoraComercio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoraVivienda = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarAgendaDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaAgua = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaCatastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaCementerio = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaComercio = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeudaVivienda = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculosToolStripMenuItem, Me.CopiarToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(484, 29)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CalculosToolStripMenuItem
        '
        Me.CalculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarPadrónContribMuniciToolStripMenuItem, Me.CargarDesdeMuniciToolStripMenuItem, Me.GenerarAgendaDePagosToolStripMenuItem})
        Me.CalculosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CalculosToolStripMenuItem.Name = "CalculosToolStripMenuItem"
        Me.CalculosToolStripMenuItem.Size = New System.Drawing.Size(61, 25)
        Me.CalculosToolStripMenuItem.Text = "Menu"
        '
        'CargarPadrónContribMuniciToolStripMenuItem
        '
        Me.CargarPadrónContribMuniciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PadronAgua, Me.PadronAuto, Me.PadronCatastro, Me.PadronCementerio, Me.PadronComercio, Me.PadronVivienda})
        Me.CargarPadrónContribMuniciToolStripMenuItem.Name = "CargarPadrónContribMuniciToolStripMenuItem"
        Me.CargarPadrónContribMuniciToolStripMenuItem.Size = New System.Drawing.Size(266, 26)
        Me.CargarPadrónContribMuniciToolStripMenuItem.Text = "Padrón de Contribuyentes"
        '
        'PadronAgua
        '
        Me.PadronAgua.Name = "PadronAgua"
        Me.PadronAgua.Size = New System.Drawing.Size(186, 26)
        Me.PadronAgua.Text = "Agua"
        '
        'PadronAuto
        '
        Me.PadronAuto.Name = "PadronAuto"
        Me.PadronAuto.Size = New System.Drawing.Size(186, 26)
        Me.PadronAuto.Text = "Automotor"
        '
        'PadronCatastro
        '
        Me.PadronCatastro.Name = "PadronCatastro"
        Me.PadronCatastro.Size = New System.Drawing.Size(186, 26)
        Me.PadronCatastro.Text = "Catastro"
        '
        'PadronCementerio
        '
        Me.PadronCementerio.Name = "PadronCementerio"
        Me.PadronCementerio.Size = New System.Drawing.Size(186, 26)
        Me.PadronCementerio.Text = "Cementerio"
        '
        'PadronComercio
        '
        Me.PadronComercio.Name = "PadronComercio"
        Me.PadronComercio.Size = New System.Drawing.Size(186, 26)
        Me.PadronComercio.Text = "Comercio"
        '
        'PadronVivienda
        '
        Me.PadronVivienda.Name = "PadronVivienda"
        Me.PadronVivienda.Size = New System.Drawing.Size(186, 26)
        Me.PadronVivienda.Text = "Plan Viviendas"
        '
        'CargarDesdeMuniciToolStripMenuItem
        '
        Me.CargarDesdeMuniciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoraAgua, Me.MoraAuto, Me.MoraCatastro, Me.MoraCementerio, Me.MoraComercio, Me.MoraVivienda})
        Me.CargarDesdeMuniciToolStripMenuItem.Name = "CargarDesdeMuniciToolStripMenuItem"
        Me.CargarDesdeMuniciToolStripMenuItem.Size = New System.Drawing.Size(266, 26)
        Me.CargarDesdeMuniciToolStripMenuItem.Text = "Deudas con Mora"
        '
        'MoraAgua
        '
        Me.MoraAgua.Name = "MoraAgua"
        Me.MoraAgua.Size = New System.Drawing.Size(186, 26)
        Me.MoraAgua.Text = "Agua"
        '
        'MoraAuto
        '
        Me.MoraAuto.Name = "MoraAuto"
        Me.MoraAuto.Size = New System.Drawing.Size(186, 26)
        Me.MoraAuto.Text = "Automotor"
        '
        'MoraCatastro
        '
        Me.MoraCatastro.Name = "MoraCatastro"
        Me.MoraCatastro.Size = New System.Drawing.Size(186, 26)
        Me.MoraCatastro.Text = "Catastro"
        '
        'MoraCementerio
        '
        Me.MoraCementerio.Name = "MoraCementerio"
        Me.MoraCementerio.Size = New System.Drawing.Size(186, 26)
        Me.MoraCementerio.Text = "Cementerio"
        '
        'MoraComercio
        '
        Me.MoraComercio.Name = "MoraComercio"
        Me.MoraComercio.Size = New System.Drawing.Size(186, 26)
        Me.MoraComercio.Text = "Comercio"
        '
        'MoraVivienda
        '
        Me.MoraVivienda.Name = "MoraVivienda"
        Me.MoraVivienda.Size = New System.Drawing.Size(186, 26)
        Me.MoraVivienda.Text = "Plan Viviendas"
        '
        'GenerarAgendaDePagosToolStripMenuItem
        '
        Me.GenerarAgendaDePagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeudaAgua, Me.DeudaAuto, Me.DeudaCatastro, Me.DeudaCementerio, Me.DeudaComercio, Me.DeudaVivienda})
        Me.GenerarAgendaDePagosToolStripMenuItem.Name = "GenerarAgendaDePagosToolStripMenuItem"
        Me.GenerarAgendaDePagosToolStripMenuItem.Size = New System.Drawing.Size(266, 26)
        Me.GenerarAgendaDePagosToolStripMenuItem.Text = "Agenda de Pagos"
        '
        'DeudaAgua
        '
        Me.DeudaAgua.Name = "DeudaAgua"
        Me.DeudaAgua.Size = New System.Drawing.Size(186, 26)
        Me.DeudaAgua.Text = "Agua"
        '
        'DeudaAuto
        '
        Me.DeudaAuto.Name = "DeudaAuto"
        Me.DeudaAuto.Size = New System.Drawing.Size(186, 26)
        Me.DeudaAuto.Text = "Automotor"
        '
        'DeudaCatastro
        '
        Me.DeudaCatastro.Name = "DeudaCatastro"
        Me.DeudaCatastro.Size = New System.Drawing.Size(186, 26)
        Me.DeudaCatastro.Text = "Catastro"
        '
        'DeudaCementerio
        '
        Me.DeudaCementerio.Name = "DeudaCementerio"
        Me.DeudaCementerio.Size = New System.Drawing.Size(186, 26)
        Me.DeudaCementerio.Text = "Cementerio"
        '
        'DeudaComercio
        '
        Me.DeudaComercio.Name = "DeudaComercio"
        Me.DeudaComercio.Size = New System.Drawing.Size(186, 26)
        Me.DeudaComercio.Text = "Comercio"
        '
        'DeudaVivienda
        '
        Me.DeudaVivienda.Name = "DeudaVivienda"
        Me.DeudaVivienda.Size = New System.Drawing.Size(186, 26)
        Me.DeudaVivienda.Text = "Plan Viviendas"
        '
        'CopiarToolStripMenuItem1
        '
        Me.CopiarToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.CopiarToolStripMenuItem1.Name = "CopiarToolStripMenuItem1"
        Me.CopiarToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.CopiarToolStripMenuItem1.Size = New System.Drawing.Size(101, 25)
        Me.CopiarToolStripMenuItem1.Text = "Copiar (F1)"
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.AllowUserToResizeRows = False
        Me.DataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataView.Location = New System.Drawing.Point(0, 0)
        Me.DataView.Name = "DataView"
        Me.DataView.RowHeadersVisible = False
        Me.DataView.RowHeadersWidth = 51
        Me.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataView.Size = New System.Drawing.Size(484, 404)
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 404)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(484, 28)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'info
        '
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(12, 23)
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
    Friend WithEvents MoraAgua As ToolStripMenuItem
    Friend WithEvents MoraAuto As ToolStripMenuItem
    Friend WithEvents MoraCatastro As ToolStripMenuItem
    Friend WithEvents MoraCementerio As ToolStripMenuItem
    Friend WithEvents MoraComercio As ToolStripMenuItem
    Friend WithEvents MoraVivienda As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents info As ToolStripStatusLabel
    Friend WithEvents progreso As ToolStripProgressBar
    Friend WithEvents CargarPadrónContribMuniciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PadronAgua As ToolStripMenuItem
    Friend WithEvents PadronAuto As ToolStripMenuItem
    Friend WithEvents PadronCatastro As ToolStripMenuItem
    Friend WithEvents PadronCementerio As ToolStripMenuItem
    Friend WithEvents PadronComercio As ToolStripMenuItem
    Friend WithEvents PadronVivienda As ToolStripMenuItem
    Friend WithEvents GenerarAgendaDePagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeudaAgua As ToolStripMenuItem
    Friend WithEvents DeudaAuto As ToolStripMenuItem
    Friend WithEvents DeudaCatastro As ToolStripMenuItem
    Friend WithEvents DeudaCementerio As ToolStripMenuItem
    Friend WithEvents DeudaComercio As ToolStripMenuItem
    Friend WithEvents DeudaVivienda As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem1 As ToolStripMenuItem
End Class
