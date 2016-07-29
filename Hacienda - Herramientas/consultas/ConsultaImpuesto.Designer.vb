<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaImpuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaImpuesto))
        Me.basura1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.basura2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.info2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bs_consulta = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_historial = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_cuentas = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_persona = New System.Windows.Forms.BindingSource(Me.components)
        Me.consulta_printdocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.bs_contrib = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_mod_contrib = New System.Windows.Forms.BindingSource(Me.components)
        Me.grupo_imp = New System.Windows.Forms.Panel()
        Me.et_con_imp = New System.Windows.Forms.Label()
        Me.f3_clave = New System.Windows.Forms.TextBox()
        Me.f3_campo = New System.Windows.Forms.ComboBox()
        Me.mostrar_f3 = New System.Windows.Forms.CheckBox()
        Me.imp_search = New System.Windows.Forms.Button()
        Me.mostrar_f1 = New System.Windows.Forms.CheckBox()
        Me.f1_impuesto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.f1b_maximo = New System.Windows.Forms.NumericUpDown()
        Me.et_desde = New System.Windows.Forms.Label()
        Me.et_hasta = New System.Windows.Forms.Label()
        Me.f1b_deuda_total = New System.Windows.Forms.ComboBox()
        Me.f1_deudor = New System.Windows.Forms.ComboBox()
        Me.mostrar_f1b = New System.Windows.Forms.CheckBox()
        Me.f1b_minimo = New System.Windows.Forms.NumericUpDown()
        Me.f2_año_maximo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.f2_año_minimo = New System.Windows.Forms.NumericUpDown()
        Me.grupo_cuotas = New System.Windows.Forms.GroupBox()
        Me.f2_cuotas_todo = New System.Windows.Forms.RadioButton()
        Me.f2_cuota6 = New System.Windows.Forms.RadioButton()
        Me.f2_cuota5 = New System.Windows.Forms.RadioButton()
        Me.f2_cuota4 = New System.Windows.Forms.RadioButton()
        Me.f2_cuota2 = New System.Windows.Forms.RadioButton()
        Me.f2_cuota1 = New System.Windows.Forms.RadioButton()
        Me.vence6 = New System.Windows.Forms.TextBox()
        Me.vence5 = New System.Windows.Forms.TextBox()
        Me.vence2 = New System.Windows.Forms.TextBox()
        Me.vence4 = New System.Windows.Forms.TextBox()
        Me.vence1 = New System.Windows.Forms.TextBox()
        Me.f2_cuota3 = New System.Windows.Forms.RadioButton()
        Me.vence3 = New System.Windows.Forms.TextBox()
        Me.mostrar_f2 = New System.Windows.Forms.CheckBox()
        Me.visor = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_imp.SuspendLayout()
        CType(Me.f1b_maximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f1b_minimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f2_año_maximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f2_año_minimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_cuotas.SuspendLayout()
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
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'bs_contrib
        '
        '
        'grupo_imp
        '
        Me.grupo_imp.BackColor = System.Drawing.Color.Gainsboro
        Me.grupo_imp.Controls.Add(Me.et_con_imp)
        Me.grupo_imp.Controls.Add(Me.f3_clave)
        Me.grupo_imp.Controls.Add(Me.f3_campo)
        Me.grupo_imp.Controls.Add(Me.mostrar_f3)
        Me.grupo_imp.Controls.Add(Me.imp_search)
        Me.grupo_imp.Controls.Add(Me.mostrar_f1)
        Me.grupo_imp.Controls.Add(Me.f1_impuesto)
        Me.grupo_imp.Controls.Add(Me.Label2)
        Me.grupo_imp.Controls.Add(Me.f1b_maximo)
        Me.grupo_imp.Controls.Add(Me.et_desde)
        Me.grupo_imp.Controls.Add(Me.et_hasta)
        Me.grupo_imp.Controls.Add(Me.f1b_deuda_total)
        Me.grupo_imp.Controls.Add(Me.f1_deudor)
        Me.grupo_imp.Controls.Add(Me.mostrar_f1b)
        Me.grupo_imp.Controls.Add(Me.f1b_minimo)
        Me.grupo_imp.Controls.Add(Me.f2_año_maximo)
        Me.grupo_imp.Controls.Add(Me.Label1)
        Me.grupo_imp.Controls.Add(Me.f2_año_minimo)
        Me.grupo_imp.Controls.Add(Me.grupo_cuotas)
        Me.grupo_imp.Controls.Add(Me.mostrar_f2)
        Me.grupo_imp.Dock = System.Windows.Forms.DockStyle.Right
        Me.grupo_imp.Location = New System.Drawing.Point(395, 0)
        Me.grupo_imp.Name = "grupo_imp"
        Me.grupo_imp.Size = New System.Drawing.Size(289, 587)
        Me.grupo_imp.TabIndex = 4
        '
        'et_con_imp
        '
        Me.et_con_imp.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.et_con_imp.Dock = System.Windows.Forms.DockStyle.Top
        Me.et_con_imp.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_con_imp.ForeColor = System.Drawing.Color.White
        Me.et_con_imp.Location = New System.Drawing.Point(0, 0)
        Me.et_con_imp.Name = "et_con_imp"
        Me.et_con_imp.Size = New System.Drawing.Size(289, 22)
        Me.et_con_imp.TabIndex = 146
        Me.et_con_imp.Text = " FILTROS"
        '
        'f3_clave
        '
        Me.f3_clave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.f3_clave.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f3_clave.Location = New System.Drawing.Point(14, 514)
        Me.f3_clave.Name = "f3_clave"
        Me.f3_clave.Size = New System.Drawing.Size(259, 27)
        Me.f3_clave.TabIndex = 89
        '
        'f3_campo
        '
        Me.f3_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f3_campo.Enabled = False
        Me.f3_campo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.f3_campo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f3_campo.FormattingEnabled = True
        Me.f3_campo.Location = New System.Drawing.Point(114, 482)
        Me.f3_campo.Margin = New System.Windows.Forms.Padding(2)
        Me.f3_campo.Name = "f3_campo"
        Me.f3_campo.Size = New System.Drawing.Size(159, 27)
        Me.f3_campo.TabIndex = 88
        '
        'mostrar_f3
        '
        Me.mostrar_f3.AutoSize = True
        Me.mostrar_f3.BackColor = System.Drawing.Color.Transparent
        Me.mostrar_f3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_f3.Location = New System.Drawing.Point(14, 484)
        Me.mostrar_f3.Margin = New System.Windows.Forms.Padding(2)
        Me.mostrar_f3.Name = "mostrar_f3"
        Me.mostrar_f3.Size = New System.Drawing.Size(94, 23)
        Me.mostrar_f3.TabIndex = 87
        Me.mostrar_f3.Text = "Filtrar por"
        Me.mostrar_f3.UseVisualStyleBackColor = False
        '
        'imp_search
        '
        Me.imp_search.BackColor = System.Drawing.SystemColors.Control
        Me.imp_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.imp_search.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_search.Location = New System.Drawing.Point(123, 552)
        Me.imp_search.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_search.Name = "imp_search"
        Me.imp_search.Size = New System.Drawing.Size(150, 26)
        Me.imp_search.TabIndex = 72
        Me.imp_search.Text = "Crear consulta"
        Me.imp_search.UseVisualStyleBackColor = False
        '
        'mostrar_f1
        '
        Me.mostrar_f1.AutoSize = True
        Me.mostrar_f1.BackColor = System.Drawing.Color.Transparent
        Me.mostrar_f1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_f1.Location = New System.Drawing.Point(14, 32)
        Me.mostrar_f1.Margin = New System.Windows.Forms.Padding(2)
        Me.mostrar_f1.Name = "mostrar_f1"
        Me.mostrar_f1.Size = New System.Drawing.Size(78, 23)
        Me.mostrar_f1.TabIndex = 86
        Me.mostrar_f1.Text = "Mostrar"
        Me.mostrar_f1.UseVisualStyleBackColor = False
        '
        'f1_impuesto
        '
        Me.f1_impuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f1_impuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.f1_impuesto.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1_impuesto.FormattingEnabled = True
        Me.f1_impuesto.Items.AddRange(New Object() {"AGUA", "AUTOMOVIL", "CATASTRO", "COMERCIO", "SEPELIO"})
        Me.f1_impuesto.Location = New System.Drawing.Point(96, 62)
        Me.f1_impuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.f1_impuesto.Name = "f1_impuesto"
        Me.f1_impuesto.Size = New System.Drawing.Size(144, 27)
        Me.f1_impuesto.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 19)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "de"
        '
        'f1b_maximo
        '
        Me.f1b_maximo.DecimalPlaces = 2
        Me.f1b_maximo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1b_maximo.Location = New System.Drawing.Point(156, 172)
        Me.f1b_maximo.Margin = New System.Windows.Forms.Padding(1)
        Me.f1b_maximo.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.f1b_maximo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.f1b_maximo.Name = "f1b_maximo"
        Me.f1b_maximo.Size = New System.Drawing.Size(120, 27)
        Me.f1b_maximo.TabIndex = 84
        Me.f1b_maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.f1b_maximo.ThousandsSeparator = True
        Me.f1b_maximo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.f1b_maximo.Visible = False
        '
        'et_desde
        '
        Me.et_desde.AutoSize = True
        Me.et_desde.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_desde.Location = New System.Drawing.Point(105, 145)
        Me.et_desde.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.et_desde.Name = "et_desde"
        Me.et_desde.Size = New System.Drawing.Size(48, 19)
        Me.et_desde.TabIndex = 83
        Me.et_desde.Text = "desde"
        Me.et_desde.Visible = False
        '
        'et_hasta
        '
        Me.et_hasta.AutoSize = True
        Me.et_hasta.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_hasta.Location = New System.Drawing.Point(107, 176)
        Me.et_hasta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.et_hasta.Name = "et_hasta"
        Me.et_hasta.Size = New System.Drawing.Size(46, 19)
        Me.et_hasta.TabIndex = 79
        Me.et_hasta.Text = "hasta"
        Me.et_hasta.Visible = False
        '
        'f1b_deuda_total
        '
        Me.f1b_deuda_total.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f1b_deuda_total.Enabled = False
        Me.f1b_deuda_total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.f1b_deuda_total.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1b_deuda_total.FormattingEnabled = True
        Me.f1b_deuda_total.Items.AddRange(New Object() {"MAS DE", "MENOS DE", "RANGO"})
        Me.f1b_deuda_total.Location = New System.Drawing.Point(156, 106)
        Me.f1b_deuda_total.Margin = New System.Windows.Forms.Padding(2)
        Me.f1b_deuda_total.Name = "f1b_deuda_total"
        Me.f1b_deuda_total.Size = New System.Drawing.Size(120, 27)
        Me.f1b_deuda_total.TabIndex = 80
        '
        'f1_deudor
        '
        Me.f1_deudor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f1_deudor.Enabled = False
        Me.f1_deudor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.f1_deudor.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1_deudor.ForeColor = System.Drawing.Color.Red
        Me.f1_deudor.FormattingEnabled = True
        Me.f1_deudor.Items.AddRange(New Object() {"DEUDORES", "SIN DEUDA"})
        Me.f1_deudor.Location = New System.Drawing.Point(96, 30)
        Me.f1_deudor.Margin = New System.Windows.Forms.Padding(2)
        Me.f1_deudor.Name = "f1_deudor"
        Me.f1_deudor.Size = New System.Drawing.Size(144, 27)
        Me.f1_deudor.TabIndex = 77
        '
        'mostrar_f1b
        '
        Me.mostrar_f1b.AutoSize = True
        Me.mostrar_f1b.BackColor = System.Drawing.Color.Transparent
        Me.mostrar_f1b.Enabled = False
        Me.mostrar_f1b.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_f1b.Location = New System.Drawing.Point(14, 108)
        Me.mostrar_f1b.Margin = New System.Windows.Forms.Padding(2)
        Me.mostrar_f1b.Name = "mostrar_f1b"
        Me.mostrar_f1b.Size = New System.Drawing.Size(143, 23)
        Me.mostrar_f1b.TabIndex = 82
        Me.mostrar_f1b.Text = "Como deuda total"
        Me.mostrar_f1b.UseVisualStyleBackColor = False
        '
        'f1b_minimo
        '
        Me.f1b_minimo.DecimalPlaces = 2
        Me.f1b_minimo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1b_minimo.Location = New System.Drawing.Point(156, 142)
        Me.f1b_minimo.Margin = New System.Windows.Forms.Padding(1)
        Me.f1b_minimo.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.f1b_minimo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.f1b_minimo.Name = "f1b_minimo"
        Me.f1b_minimo.Size = New System.Drawing.Size(120, 27)
        Me.f1b_minimo.TabIndex = 78
        Me.f1b_minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.f1b_minimo.ThousandsSeparator = True
        Me.f1b_minimo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.f1b_minimo.Visible = False
        '
        'f2_año_maximo
        '
        Me.f2_año_maximo.Enabled = False
        Me.f2_año_maximo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_año_maximo.Location = New System.Drawing.Point(204, 216)
        Me.f2_año_maximo.Margin = New System.Windows.Forms.Padding(1)
        Me.f2_año_maximo.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.f2_año_maximo.Minimum = New Decimal(New Integer() {2001, 0, 0, 0})
        Me.f2_año_maximo.Name = "f2_año_maximo"
        Me.f2_año_maximo.ReadOnly = True
        Me.f2_año_maximo.Size = New System.Drawing.Size(70, 27)
        Me.f2_año_maximo.TabIndex = 75
        Me.f2_año_maximo.Value = New Decimal(New Integer() {2001, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 218)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "hasta"
        '
        'f2_año_minimo
        '
        Me.f2_año_minimo.Enabled = False
        Me.f2_año_minimo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_año_minimo.Location = New System.Drawing.Point(81, 216)
        Me.f2_año_minimo.Margin = New System.Windows.Forms.Padding(1)
        Me.f2_año_minimo.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.f2_año_minimo.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.f2_año_minimo.Name = "f2_año_minimo"
        Me.f2_año_minimo.ReadOnly = True
        Me.f2_año_minimo.Size = New System.Drawing.Size(65, 27)
        Me.f2_año_minimo.TabIndex = 69
        Me.f2_año_minimo.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'grupo_cuotas
        '
        Me.grupo_cuotas.BackColor = System.Drawing.Color.Gainsboro
        Me.grupo_cuotas.Controls.Add(Me.f2_cuotas_todo)
        Me.grupo_cuotas.Controls.Add(Me.f2_cuota6)
        Me.grupo_cuotas.Controls.Add(Me.f2_cuota5)
        Me.grupo_cuotas.Controls.Add(Me.f2_cuota4)
        Me.grupo_cuotas.Controls.Add(Me.f2_cuota2)
        Me.grupo_cuotas.Controls.Add(Me.f2_cuota1)
        Me.grupo_cuotas.Controls.Add(Me.vence6)
        Me.grupo_cuotas.Controls.Add(Me.vence5)
        Me.grupo_cuotas.Controls.Add(Me.vence2)
        Me.grupo_cuotas.Controls.Add(Me.vence4)
        Me.grupo_cuotas.Controls.Add(Me.vence1)
        Me.grupo_cuotas.Controls.Add(Me.f2_cuota3)
        Me.grupo_cuotas.Controls.Add(Me.vence3)
        Me.grupo_cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grupo_cuotas.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo_cuotas.Location = New System.Drawing.Point(34, 247)
        Me.grupo_cuotas.Margin = New System.Windows.Forms.Padding(2)
        Me.grupo_cuotas.Name = "grupo_cuotas"
        Me.grupo_cuotas.Padding = New System.Windows.Forms.Padding(2)
        Me.grupo_cuotas.Size = New System.Drawing.Size(237, 233)
        Me.grupo_cuotas.TabIndex = 70
        Me.grupo_cuotas.TabStop = False
        Me.grupo_cuotas.Text = "Cuotas"
        Me.grupo_cuotas.Visible = False
        '
        'f2_cuotas_todo
        '
        Me.f2_cuotas_todo.AutoSize = True
        Me.f2_cuotas_todo.Checked = True
        Me.f2_cuotas_todo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_cuotas_todo.Location = New System.Drawing.Point(12, 199)
        Me.f2_cuotas_todo.Margin = New System.Windows.Forms.Padding(2)
        Me.f2_cuotas_todo.Name = "f2_cuotas_todo"
        Me.f2_cuotas_todo.Size = New System.Drawing.Size(136, 23)
        Me.f2_cuotas_todo.TabIndex = 18
        Me.f2_cuotas_todo.TabStop = True
        Me.f2_cuotas_todo.Text = "Todas las cuotas"
        Me.f2_cuotas_todo.UseVisualStyleBackColor = True
        '
        'f2_cuota6
        '
        Me.f2_cuota6.AutoSize = True
        Me.f2_cuota6.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_cuota6.Location = New System.Drawing.Point(12, 170)
        Me.f2_cuota6.Margin = New System.Windows.Forms.Padding(2)
        Me.f2_cuota6.Name = "f2_cuota6"
        Me.f2_cuota6.Size = New System.Drawing.Size(77, 23)
        Me.f2_cuota6.TabIndex = 17
        Me.f2_cuota6.Text = "Cuota 6"
        Me.f2_cuota6.UseVisualStyleBackColor = True
        '
        'f2_cuota5
        '
        Me.f2_cuota5.AutoSize = True
        Me.f2_cuota5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_cuota5.Location = New System.Drawing.Point(12, 141)
        Me.f2_cuota5.Margin = New System.Windows.Forms.Padding(2)
        Me.f2_cuota5.Name = "f2_cuota5"
        Me.f2_cuota5.Size = New System.Drawing.Size(77, 23)
        Me.f2_cuota5.TabIndex = 16
        Me.f2_cuota5.Text = "Cuota 5"
        Me.f2_cuota5.UseVisualStyleBackColor = True
        '
        'f2_cuota4
        '
        Me.f2_cuota4.AutoSize = True
        Me.f2_cuota4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_cuota4.Location = New System.Drawing.Point(12, 112)
        Me.f2_cuota4.Margin = New System.Windows.Forms.Padding(2)
        Me.f2_cuota4.Name = "f2_cuota4"
        Me.f2_cuota4.Size = New System.Drawing.Size(76, 23)
        Me.f2_cuota4.TabIndex = 15
        Me.f2_cuota4.Text = "Cuota 4"
        Me.f2_cuota4.UseVisualStyleBackColor = True
        '
        'f2_cuota2
        '
        Me.f2_cuota2.AutoSize = True
        Me.f2_cuota2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_cuota2.Location = New System.Drawing.Point(12, 54)
        Me.f2_cuota2.Margin = New System.Windows.Forms.Padding(2)
        Me.f2_cuota2.Name = "f2_cuota2"
        Me.f2_cuota2.Size = New System.Drawing.Size(77, 23)
        Me.f2_cuota2.TabIndex = 13
        Me.f2_cuota2.Text = "Cuota 2"
        Me.f2_cuota2.UseVisualStyleBackColor = True
        '
        'f2_cuota1
        '
        Me.f2_cuota1.AutoSize = True
        Me.f2_cuota1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_cuota1.Location = New System.Drawing.Point(12, 25)
        Me.f2_cuota1.Margin = New System.Windows.Forms.Padding(2)
        Me.f2_cuota1.Name = "f2_cuota1"
        Me.f2_cuota1.Size = New System.Drawing.Size(77, 23)
        Me.f2_cuota1.TabIndex = 12
        Me.f2_cuota1.Text = "Cuota 1"
        Me.f2_cuota1.UseVisualStyleBackColor = True
        '
        'vence6
        '
        Me.vence6.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence6.Location = New System.Drawing.Point(96, 169)
        Me.vence6.Margin = New System.Windows.Forms.Padding(2)
        Me.vence6.Name = "vence6"
        Me.vence6.ReadOnly = True
        Me.vence6.Size = New System.Drawing.Size(110, 27)
        Me.vence6.TabIndex = 11
        '
        'vence5
        '
        Me.vence5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence5.Location = New System.Drawing.Point(96, 140)
        Me.vence5.Margin = New System.Windows.Forms.Padding(2)
        Me.vence5.Name = "vence5"
        Me.vence5.ReadOnly = True
        Me.vence5.Size = New System.Drawing.Size(110, 27)
        Me.vence5.TabIndex = 9
        '
        'vence2
        '
        Me.vence2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence2.Location = New System.Drawing.Point(96, 53)
        Me.vence2.Margin = New System.Windows.Forms.Padding(2)
        Me.vence2.Name = "vence2"
        Me.vence2.ReadOnly = True
        Me.vence2.Size = New System.Drawing.Size(110, 27)
        Me.vence2.TabIndex = 8
        '
        'vence4
        '
        Me.vence4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence4.Location = New System.Drawing.Point(96, 111)
        Me.vence4.Margin = New System.Windows.Forms.Padding(2)
        Me.vence4.Name = "vence4"
        Me.vence4.ReadOnly = True
        Me.vence4.Size = New System.Drawing.Size(110, 27)
        Me.vence4.TabIndex = 7
        '
        'vence1
        '
        Me.vence1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence1.Location = New System.Drawing.Point(96, 24)
        Me.vence1.Margin = New System.Windows.Forms.Padding(2)
        Me.vence1.Name = "vence1"
        Me.vence1.ReadOnly = True
        Me.vence1.Size = New System.Drawing.Size(110, 27)
        Me.vence1.TabIndex = 6
        '
        'f2_cuota3
        '
        Me.f2_cuota3.AutoSize = True
        Me.f2_cuota3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_cuota3.Location = New System.Drawing.Point(12, 83)
        Me.f2_cuota3.Margin = New System.Windows.Forms.Padding(2)
        Me.f2_cuota3.Name = "f2_cuota3"
        Me.f2_cuota3.Size = New System.Drawing.Size(77, 23)
        Me.f2_cuota3.TabIndex = 14
        Me.f2_cuota3.Text = "Cuota 3"
        Me.f2_cuota3.UseVisualStyleBackColor = True
        '
        'vence3
        '
        Me.vence3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence3.Location = New System.Drawing.Point(96, 82)
        Me.vence3.Margin = New System.Windows.Forms.Padding(2)
        Me.vence3.Name = "vence3"
        Me.vence3.ReadOnly = True
        Me.vence3.Size = New System.Drawing.Size(110, 27)
        Me.vence3.TabIndex = 10
        '
        'mostrar_f2
        '
        Me.mostrar_f2.AutoSize = True
        Me.mostrar_f2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_f2.Location = New System.Drawing.Point(14, 217)
        Me.mostrar_f2.Margin = New System.Windows.Forms.Padding(2)
        Me.mostrar_f2.Name = "mostrar_f2"
        Me.mostrar_f2.Size = New System.Drawing.Size(68, 23)
        Me.mostrar_f2.TabIndex = 73
        Me.mostrar_f2.Text = "Desde"
        Me.mostrar_f2.UseVisualStyleBackColor = True
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
        Me.visor.Size = New System.Drawing.Size(395, 587)
        Me.visor.TabIndex = 5
        '
        'ConsultaImpuesto
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
        Me.Name = "ConsultaImpuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Impuesto"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_imp.ResumeLayout(False)
        Me.grupo_imp.PerformLayout()
        CType(Me.f1b_maximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f1b_minimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f2_año_maximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f2_año_minimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_cuotas.ResumeLayout(False)
        Me.grupo_cuotas.PerformLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents basura1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents basura2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bs_cuentas As System.Windows.Forms.BindingSource
    Friend WithEvents bs_historial As System.Windows.Forms.BindingSource
    Friend WithEvents bs_consulta As System.Windows.Forms.BindingSource
    Friend WithEvents bs_persona As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents info2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents consulta_printdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents bs_contrib As System.Windows.Forms.BindingSource
    Friend WithEvents bs_mod_contrib As System.Windows.Forms.BindingSource
    Friend WithEvents grupo_imp As System.Windows.Forms.Panel
    Friend WithEvents f3_clave As System.Windows.Forms.TextBox
    Friend WithEvents f3_campo As System.Windows.Forms.ComboBox
    Friend WithEvents mostrar_f3 As System.Windows.Forms.CheckBox
    Friend WithEvents imp_search As System.Windows.Forms.Button
    Friend WithEvents mostrar_f1 As System.Windows.Forms.CheckBox
    Friend WithEvents f1_impuesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents f1b_maximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents et_desde As System.Windows.Forms.Label
    Friend WithEvents et_hasta As System.Windows.Forms.Label
    Friend WithEvents f1b_deuda_total As System.Windows.Forms.ComboBox
    Friend WithEvents f1_deudor As System.Windows.Forms.ComboBox
    Friend WithEvents mostrar_f1b As System.Windows.Forms.CheckBox
    Friend WithEvents f1b_minimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents f2_año_maximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents f2_año_minimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents grupo_cuotas As System.Windows.Forms.GroupBox
    Friend WithEvents f2_cuotas_todo As System.Windows.Forms.RadioButton
    Friend WithEvents f2_cuota6 As System.Windows.Forms.RadioButton
    Friend WithEvents f2_cuota5 As System.Windows.Forms.RadioButton
    Friend WithEvents f2_cuota4 As System.Windows.Forms.RadioButton
    Friend WithEvents f2_cuota2 As System.Windows.Forms.RadioButton
    Friend WithEvents f2_cuota1 As System.Windows.Forms.RadioButton
    Friend WithEvents vence6 As System.Windows.Forms.TextBox
    Friend WithEvents vence5 As System.Windows.Forms.TextBox
    Friend WithEvents vence2 As System.Windows.Forms.TextBox
    Friend WithEvents vence4 As System.Windows.Forms.TextBox
    Friend WithEvents vence1 As System.Windows.Forms.TextBox
    Friend WithEvents f2_cuota3 As System.Windows.Forms.RadioButton
    Friend WithEvents vence3 As System.Windows.Forms.TextBox
    Friend WithEvents mostrar_f2 As System.Windows.Forms.CheckBox
    Friend WithEvents visor As System.Windows.Forms.DataGridView
    Friend WithEvents et_con_imp As System.Windows.Forms.Label

End Class
