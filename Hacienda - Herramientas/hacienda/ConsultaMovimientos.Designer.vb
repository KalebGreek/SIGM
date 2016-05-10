<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaMovimientos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaMovimientos))
        Me.basura1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.basura2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.info2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bs_consulta = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_cuenta = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_persona = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_contrib = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_mod_contrib = New System.Windows.Forms.BindingSource(Me.components)
        Me.grupo_imp = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ActivarFiltro = New System.Windows.Forms.CheckBox()
        Me.Keyword = New System.Windows.Forms.TextBox()
        Me.SeleccionFiltro = New System.Windows.Forms.ComboBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SeleccionCuenta = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Egresos = New System.Windows.Forms.RadioButton()
        Me.Ingresos = New System.Windows.Forms.RadioButton()
        Me.et_con_imp = New System.Windows.Forms.Label()
        Me.visor = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_imp.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'basura1
        '
        Me.basura1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basura1.Name = "basura1"
        Me.basura1.Size = New System.Drawing.Size(94, 17)
        '
        'basura2
        '
        Me.basura2.ActiveLinkColor = System.Drawing.Color.Black
        Me.basura2.LinkColor = System.Drawing.Color.Black
        Me.basura2.Name = "basura2"
        Me.basura2.Size = New System.Drawing.Size(132, 17)
        Me.basura2.Text = "SELECT * FROM agucue"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progreso, Me.info, Me.info2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 587)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'progreso
        '
        Me.progreso.Maximum = 20
        Me.progreso.Name = "progreso"
        Me.progreso.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.progreso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.progreso.Size = New System.Drawing.Size(150, 18)
        Me.progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'info
        '
        Me.info.BackColor = System.Drawing.SystemColors.Control
        Me.info.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(15, 19)
        Me.info.Text = "-"
        '
        'info2
        '
        Me.info2.BackColor = System.Drawing.SystemColors.Control
        Me.info2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info2.ForeColor = System.Drawing.Color.DimGray
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(15, 19)
        Me.info2.Text = "-"
        Me.info2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bs_consulta
        '
        '
        'grupo_imp
        '
        Me.grupo_imp.BackColor = System.Drawing.Color.Gainsboro
        Me.grupo_imp.Controls.Add(Me.Panel3)
        Me.grupo_imp.Controls.Add(Me.Panel1)
        Me.grupo_imp.Controls.Add(Me.Panel2)
        Me.grupo_imp.Controls.Add(Me.et_con_imp)
        Me.grupo_imp.Dock = System.Windows.Forms.DockStyle.Right
        Me.grupo_imp.Location = New System.Drawing.Point(403, 0)
        Me.grupo_imp.Name = "grupo_imp"
        Me.grupo_imp.Size = New System.Drawing.Size(281, 587)
        Me.grupo_imp.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ActivarFiltro)
        Me.Panel3.Controls.Add(Me.Keyword)
        Me.Panel3.Controls.Add(Me.SeleccionFiltro)
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 385)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(281, 202)
        Me.Panel3.TabIndex = 152
        '
        'ActivarFiltro
        '
        Me.ActivarFiltro.AutoSize = True
        Me.ActivarFiltro.BackColor = System.Drawing.Color.Transparent
        Me.ActivarFiltro.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivarFiltro.Location = New System.Drawing.Point(5, 2)
        Me.ActivarFiltro.Margin = New System.Windows.Forms.Padding(2)
        Me.ActivarFiltro.Name = "ActivarFiltro"
        Me.ActivarFiltro.Size = New System.Drawing.Size(94, 23)
        Me.ActivarFiltro.TabIndex = 97
        Me.ActivarFiltro.Text = "Filtrar por"
        Me.ActivarFiltro.UseVisualStyleBackColor = False
        '
        'Keyword
        '
        Me.Keyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Keyword.Enabled = False
        Me.Keyword.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keyword.Location = New System.Drawing.Point(2, 61)
        Me.Keyword.Name = "Keyword"
        Me.Keyword.Size = New System.Drawing.Size(277, 27)
        Me.Keyword.TabIndex = 96
        '
        'SeleccionFiltro
        '
        Me.SeleccionFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeleccionFiltro.Enabled = False
        Me.SeleccionFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeleccionFiltro.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionFiltro.FormattingEnabled = True
        Me.SeleccionFiltro.Items.AddRange(New Object() {"RAZON", "CUIL"})
        Me.SeleccionFiltro.Location = New System.Drawing.Point(2, 29)
        Me.SeleccionFiltro.Margin = New System.Windows.Forms.Padding(2)
        Me.SeleccionFiltro.Name = "SeleccionFiltro"
        Me.SeleccionFiltro.Size = New System.Drawing.Size(277, 27)
        Me.SeleccionFiltro.TabIndex = 95
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.SystemColors.Control
        Me.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(147, 93)
        Me.Search.Margin = New System.Windows.Forms.Padding(2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(127, 26)
        Me.Search.TabIndex = 94
        Me.Search.Text = "Crear consulta"
        Me.Search.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SeleccionCuenta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 534)
        Me.Panel1.TabIndex = 150
        '
        'SeleccionCuenta
        '
        Me.SeleccionCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeleccionCuenta.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
        Me.SeleccionCuenta.FormattingEnabled = True
        Me.SeleccionCuenta.ItemHeight = 18
        Me.SeleccionCuenta.Location = New System.Drawing.Point(0, 22)
        Me.SeleccionCuenta.Name = "SeleccionCuenta"
        Me.SeleccionCuenta.Size = New System.Drawing.Size(281, 512)
        Me.SeleccionCuenta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 22)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = " Seleccionar Cuenta"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Egresos)
        Me.Panel2.Controls.Add(Me.Ingresos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 31)
        Me.Panel2.TabIndex = 151
        '
        'Egresos
        '
        Me.Egresos.AutoSize = True
        Me.Egresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Egresos.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
        Me.Egresos.Location = New System.Drawing.Point(89, 0)
        Me.Egresos.Name = "Egresos"
        Me.Egresos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Egresos.Size = New System.Drawing.Size(192, 31)
        Me.Egresos.TabIndex = 3
        Me.Egresos.Text = "Egresos"
        Me.Egresos.UseVisualStyleBackColor = True
        '
        'Ingresos
        '
        Me.Ingresos.AutoSize = True
        Me.Ingresos.Checked = True
        Me.Ingresos.Dock = System.Windows.Forms.DockStyle.Left
        Me.Ingresos.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
        Me.Ingresos.Location = New System.Drawing.Point(0, 0)
        Me.Ingresos.Name = "Ingresos"
        Me.Ingresos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Ingresos.Size = New System.Drawing.Size(89, 31)
        Me.Ingresos.TabIndex = 2
        Me.Ingresos.TabStop = True
        Me.Ingresos.Text = "Ingresos"
        Me.Ingresos.UseVisualStyleBackColor = True
        '
        'et_con_imp
        '
        Me.et_con_imp.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.et_con_imp.Dock = System.Windows.Forms.DockStyle.Top
        Me.et_con_imp.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_con_imp.ForeColor = System.Drawing.Color.White
        Me.et_con_imp.Location = New System.Drawing.Point(0, 0)
        Me.et_con_imp.Name = "et_con_imp"
        Me.et_con_imp.Size = New System.Drawing.Size(281, 22)
        Me.et_con_imp.TabIndex = 146
        Me.et_con_imp.Text = " FILTROS"
        '
        'visor
        '
        Me.visor.AllowUserToAddRows = False
        Me.visor.AllowUserToDeleteRows = False
        Me.visor.AllowUserToResizeRows = False
        Me.visor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor.Location = New System.Drawing.Point(0, 0)
        Me.visor.Name = "visor"
        Me.visor.ReadOnly = True
        Me.visor.RowHeadersVisible = False
        Me.visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.visor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visor.Size = New System.Drawing.Size(403, 587)
        Me.visor.TabIndex = 5
        '
        'ConsultaMovimientos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Sigm.My.Resources.Resources.trama41
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.grupo_imp)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(700, 650)
        Me.Name = "ConsultaMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Movimientos"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_imp.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents basura1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents basura2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bs_cuenta As System.Windows.Forms.BindingSource
    Friend WithEvents bs_consulta As System.Windows.Forms.BindingSource
    Friend WithEvents bs_persona As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents info2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents bs_contrib As System.Windows.Forms.BindingSource
    Friend WithEvents bs_mod_contrib As System.Windows.Forms.BindingSource
    Friend WithEvents grupo_imp As System.Windows.Forms.Panel
    Friend WithEvents visor As System.Windows.Forms.DataGridView
    Friend WithEvents et_con_imp As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SeleccionCuenta As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Egresos As System.Windows.Forms.RadioButton
    Friend WithEvents Ingresos As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ActivarFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents Keyword As System.Windows.Forms.TextBox
    Friend WithEvents SeleccionFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Search As System.Windows.Forms.Button

End Class
