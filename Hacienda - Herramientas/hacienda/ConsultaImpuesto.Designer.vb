<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaImpuesto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.f3_clave = New System.Windows.Forms.TextBox()
        Me.f3_campo = New System.Windows.Forms.ComboBox()
        Me.mostrar_f3 = New System.Windows.Forms.CheckBox()
        Me.imp_search = New System.Windows.Forms.Button()
        Me.f1b_maximo = New System.Windows.Forms.NumericUpDown()
        Me.et_hasta = New System.Windows.Forms.Label()
        Me.f1b_deuda_total = New System.Windows.Forms.ComboBox()
        Me.mostrar_f1b = New System.Windows.Forms.CheckBox()
        Me.f1b_minimo = New System.Windows.Forms.NumericUpDown()
        Me.f2_año_maximo = New System.Windows.Forms.NumericUpDown()
        Me.f2_año_minimo = New System.Windows.Forms.NumericUpDown()
        Me.mostrar_f2 = New System.Windows.Forms.CheckBox()
        Me.visor = New System.Windows.Forms.DataGridView()
        Me.grupo_imp = New System.Windows.Forms.FlowLayoutPanel()
        Me.et_con_imp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.f1_impuesto = New System.Windows.Forms.ComboBox()
        Me.f1_Deudor = New System.Windows.Forms.RadioButton()
        Me.f1_SinDeuda = New System.Windows.Forms.RadioButton()
        Me.grupo_deuda_total = New System.Windows.Forms.FlowLayoutPanel()
        Me.f1b_importe_mora = New System.Windows.Forms.RadioButton()
        Me.f1b_importe = New System.Windows.Forms.RadioButton()
        Me.f1b_mora = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.interes = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.CtrlVenc1 = New Sigm.CtrlVenceImpuesto()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f1b_maximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f1b_minimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f2_año_maximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f2_año_minimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_imp.SuspendLayout()
        Me.grupo_deuda_total.SuspendLayout()
        CType(Me.interes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 581)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(884, 24)
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
        'f3_clave
        '
        Me.f3_clave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.f3_clave.Enabled = False
        Me.f3_clave.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f3_clave.Location = New System.Drawing.Point(3, 539)
        Me.f3_clave.Name = "f3_clave"
        Me.f3_clave.Size = New System.Drawing.Size(273, 27)
        Me.f3_clave.TabIndex = 89
        '
        'f3_campo
        '
        Me.f3_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f3_campo.Enabled = False
        Me.f3_campo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.f3_campo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f3_campo.FormattingEnabled = True
        Me.f3_campo.Location = New System.Drawing.Point(100, 507)
        Me.f3_campo.Margin = New System.Windows.Forms.Padding(2)
        Me.f3_campo.Name = "f3_campo"
        Me.f3_campo.Size = New System.Drawing.Size(175, 27)
        Me.f3_campo.TabIndex = 88
        '
        'mostrar_f3
        '
        Me.mostrar_f3.BackColor = System.Drawing.Color.Transparent
        Me.mostrar_f3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_f3.Location = New System.Drawing.Point(2, 507)
        Me.mostrar_f3.Margin = New System.Windows.Forms.Padding(2)
        Me.mostrar_f3.Name = "mostrar_f3"
        Me.mostrar_f3.Size = New System.Drawing.Size(94, 27)
        Me.mostrar_f3.TabIndex = 87
        Me.mostrar_f3.Text = "Filtrar por"
        Me.mostrar_f3.UseVisualStyleBackColor = False
        '
        'imp_search
        '
        Me.imp_search.BackColor = System.Drawing.SystemColors.Control
        Me.imp_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.imp_search.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_search.Location = New System.Drawing.Point(2, 571)
        Me.imp_search.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_search.Name = "imp_search"
        Me.imp_search.Size = New System.Drawing.Size(274, 26)
        Me.imp_search.TabIndex = 72
        Me.imp_search.Text = "Crear consulta (F3)"
        Me.imp_search.UseVisualStyleBackColor = False
        '
        'f1b_maximo
        '
        Me.f1b_maximo.DecimalPlaces = 2
        Me.f1b_maximo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1b_maximo.Location = New System.Drawing.Point(191, 26)
        Me.f1b_maximo.Margin = New System.Windows.Forms.Padding(1)
        Me.f1b_maximo.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.f1b_maximo.Name = "f1b_maximo"
        Me.f1b_maximo.Size = New System.Drawing.Size(85, 27)
        Me.f1b_maximo.TabIndex = 84
        Me.f1b_maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.f1b_maximo.ThousandsSeparator = True
        Me.f1b_maximo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'et_hasta
        '
        Me.et_hasta.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_hasta.Location = New System.Drawing.Point(171, 25)
        Me.et_hasta.Margin = New System.Windows.Forms.Padding(0)
        Me.et_hasta.Name = "et_hasta"
        Me.et_hasta.Size = New System.Drawing.Size(19, 27)
        Me.et_hasta.TabIndex = 79
        Me.et_hasta.Text = "-"
        Me.et_hasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'f1b_deuda_total
        '
        Me.f1b_deuda_total.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f1b_deuda_total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.f1b_deuda_total.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1b_deuda_total.FormattingEnabled = True
        Me.f1b_deuda_total.Items.AddRange(New Object() {"MAS DE", "MENOS DE", "RANGO"})
        Me.f1b_deuda_total.Location = New System.Drawing.Point(4, 26)
        Me.f1b_deuda_total.Margin = New System.Windows.Forms.Padding(4, 1, 2, 2)
        Me.f1b_deuda_total.Name = "f1b_deuda_total"
        Me.f1b_deuda_total.Size = New System.Drawing.Size(78, 27)
        Me.f1b_deuda_total.TabIndex = 80
        '
        'mostrar_f1b
        '
        Me.mostrar_f1b.BackColor = System.Drawing.Color.Transparent
        Me.mostrar_f1b.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_f1b.Location = New System.Drawing.Point(2, 144)
        Me.mostrar_f1b.Margin = New System.Windows.Forms.Padding(2)
        Me.mostrar_f1b.Name = "mostrar_f1b"
        Me.mostrar_f1b.Size = New System.Drawing.Size(271, 22)
        Me.mostrar_f1b.TabIndex = 82
        Me.mostrar_f1b.Text = "Deuda Agrupada"
        Me.mostrar_f1b.UseVisualStyleBackColor = False
        '
        'f1b_minimo
        '
        Me.f1b_minimo.DecimalPlaces = 2
        Me.f1b_minimo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1b_minimo.Location = New System.Drawing.Point(85, 26)
        Me.f1b_minimo.Margin = New System.Windows.Forms.Padding(1)
        Me.f1b_minimo.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.f1b_minimo.Name = "f1b_minimo"
        Me.f1b_minimo.Size = New System.Drawing.Size(85, 27)
        Me.f1b_minimo.TabIndex = 78
        Me.f1b_minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.f1b_minimo.ThousandsSeparator = True
        Me.f1b_minimo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'f2_año_maximo
        '
        Me.f2_año_maximo.Enabled = False
        Me.f2_año_maximo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_año_maximo.Location = New System.Drawing.Point(193, 234)
        Me.f2_año_maximo.Margin = New System.Windows.Forms.Padding(1, 10, 1, 1)
        Me.f2_año_maximo.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.f2_año_maximo.Minimum = New Decimal(New Integer() {2001, 0, 0, 0})
        Me.f2_año_maximo.Name = "f2_año_maximo"
        Me.f2_año_maximo.ReadOnly = True
        Me.f2_año_maximo.Size = New System.Drawing.Size(57, 27)
        Me.f2_año_maximo.TabIndex = 75
        Me.f2_año_maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.f2_año_maximo.Value = New Decimal(New Integer() {2001, 0, 0, 0})
        '
        'f2_año_minimo
        '
        Me.f2_año_minimo.Enabled = False
        Me.f2_año_minimo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2_año_minimo.Location = New System.Drawing.Point(83, 234)
        Me.f2_año_minimo.Margin = New System.Windows.Forms.Padding(1, 10, 1, 1)
        Me.f2_año_minimo.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.f2_año_minimo.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.f2_año_minimo.Name = "f2_año_minimo"
        Me.f2_año_minimo.ReadOnly = True
        Me.f2_año_minimo.Size = New System.Drawing.Size(57, 27)
        Me.f2_año_minimo.TabIndex = 69
        Me.f2_año_minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.f2_año_minimo.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'mostrar_f2
        '
        Me.mostrar_f2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar_f2.Location = New System.Drawing.Point(2, 234)
        Me.mostrar_f2.Margin = New System.Windows.Forms.Padding(2, 10, 2, 2)
        Me.mostrar_f2.Name = "mostrar_f2"
        Me.mostrar_f2.Size = New System.Drawing.Size(78, 25)
        Me.mostrar_f2.TabIndex = 73
        Me.mostrar_f2.Text = "Periodo"
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
        Me.visor.Size = New System.Drawing.Size(606, 581)
        Me.visor.TabIndex = 5
        '
        'grupo_imp
        '
        Me.grupo_imp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grupo_imp.Controls.Add(Me.et_con_imp)
        Me.grupo_imp.Controls.Add(Me.Label3)
        Me.grupo_imp.Controls.Add(Me.f1_impuesto)
        Me.grupo_imp.Controls.Add(Me.f1_Deudor)
        Me.grupo_imp.Controls.Add(Me.f1_SinDeuda)
        Me.grupo_imp.Controls.Add(Me.Label4)
        Me.grupo_imp.Controls.Add(Me.fecha)
        Me.grupo_imp.Controls.Add(Me.Label2)
        Me.grupo_imp.Controls.Add(Me.interes)
        Me.grupo_imp.Controls.Add(Me.mostrar_f1b)
        Me.grupo_imp.Controls.Add(Me.grupo_deuda_total)
        Me.grupo_imp.Controls.Add(Me.mostrar_f2)
        Me.grupo_imp.Controls.Add(Me.f2_año_minimo)
        Me.grupo_imp.Controls.Add(Me.Label1)
        Me.grupo_imp.Controls.Add(Me.f2_año_maximo)
        Me.grupo_imp.Controls.Add(Me.CtrlVenc1)
        Me.grupo_imp.Controls.Add(Me.mostrar_f3)
        Me.grupo_imp.Controls.Add(Me.f3_campo)
        Me.grupo_imp.Controls.Add(Me.f3_clave)
        Me.grupo_imp.Controls.Add(Me.imp_search)
        Me.grupo_imp.Dock = System.Windows.Forms.DockStyle.Right
        Me.grupo_imp.Location = New System.Drawing.Point(606, 0)
        Me.grupo_imp.Name = "grupo_imp"
        Me.grupo_imp.Size = New System.Drawing.Size(278, 581)
        Me.grupo_imp.TabIndex = 6
        '
        'et_con_imp
        '
        Me.et_con_imp.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.et_con_imp.Dock = System.Windows.Forms.DockStyle.Top
        Me.et_con_imp.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_con_imp.ForeColor = System.Drawing.Color.White
        Me.et_con_imp.Location = New System.Drawing.Point(0, 0)
        Me.et_con_imp.Margin = New System.Windows.Forms.Padding(0)
        Me.et_con_imp.Name = "et_con_imp"
        Me.et_con_imp.Size = New System.Drawing.Size(289, 22)
        Me.et_con_imp.TabIndex = 148
        Me.et_con_imp.Text = " FILTROS"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 27)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Servicio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'f1_impuesto
        '
        Me.f1_impuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.f1_impuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.f1_impuesto.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1_impuesto.FormattingEnabled = True
        Me.f1_impuesto.Items.AddRange(New Object() {"AGUAS", "AUTOMOVIL", "CATASTRO", "COMERCIO", "SEPELIO"})
        Me.f1_impuesto.Location = New System.Drawing.Point(67, 30)
        Me.f1_impuesto.Margin = New System.Windows.Forms.Padding(2, 8, 2, 2)
        Me.f1_impuesto.Name = "f1_impuesto"
        Me.f1_impuesto.Size = New System.Drawing.Size(206, 27)
        Me.f1_impuesto.TabIndex = 88
        '
        'f1_Deudor
        '
        Me.f1_Deudor.AutoSize = True
        Me.f1_Deudor.ForeColor = System.Drawing.Color.Red
        Me.f1_Deudor.Location = New System.Drawing.Point(70, 59)
        Me.f1_Deudor.Margin = New System.Windows.Forms.Padding(70, 0, 3, 0)
        Me.f1_Deudor.Name = "f1_Deudor"
        Me.f1_Deudor.Size = New System.Drawing.Size(73, 23)
        Me.f1_Deudor.TabIndex = 150
        Me.f1_Deudor.Text = "Deudor"
        Me.f1_Deudor.UseVisualStyleBackColor = True
        '
        'f1_SinDeuda
        '
        Me.f1_SinDeuda.AutoSize = True
        Me.f1_SinDeuda.ForeColor = System.Drawing.Color.Green
        Me.f1_SinDeuda.Location = New System.Drawing.Point(149, 59)
        Me.f1_SinDeuda.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.f1_SinDeuda.Name = "f1_SinDeuda"
        Me.f1_SinDeuda.Size = New System.Drawing.Size(99, 23)
        Me.f1_SinDeuda.TabIndex = 151
        Me.f1_SinDeuda.Text = "Sin deudas"
        Me.f1_SinDeuda.UseVisualStyleBackColor = True
        '
        'grupo_deuda_total
        '
        Me.grupo_deuda_total.Controls.Add(Me.f1b_importe_mora)
        Me.grupo_deuda_total.Controls.Add(Me.f1b_importe)
        Me.grupo_deuda_total.Controls.Add(Me.f1b_mora)
        Me.grupo_deuda_total.Controls.Add(Me.f1b_deuda_total)
        Me.grupo_deuda_total.Controls.Add(Me.f1b_minimo)
        Me.grupo_deuda_total.Controls.Add(Me.et_hasta)
        Me.grupo_deuda_total.Controls.Add(Me.f1b_maximo)
        Me.grupo_deuda_total.Enabled = False
        Me.grupo_deuda_total.Location = New System.Drawing.Point(0, 168)
        Me.grupo_deuda_total.Margin = New System.Windows.Forms.Padding(0)
        Me.grupo_deuda_total.Name = "grupo_deuda_total"
        Me.grupo_deuda_total.Size = New System.Drawing.Size(278, 56)
        Me.grupo_deuda_total.TabIndex = 152
        '
        'f1b_importe_mora
        '
        Me.f1b_importe_mora.Checked = True
        Me.f1b_importe_mora.Location = New System.Drawing.Point(3, 1)
        Me.f1b_importe_mora.Margin = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.f1b_importe_mora.Name = "f1b_importe_mora"
        Me.f1b_importe_mora.Size = New System.Drawing.Size(126, 23)
        Me.f1b_importe_mora.TabIndex = 157
        Me.f1b_importe_mora.TabStop = True
        Me.f1b_importe_mora.Text = "Importe + Mora"
        Me.f1b_importe_mora.UseVisualStyleBackColor = True
        '
        'f1b_importe
        '
        Me.f1b_importe.AutoSize = True
        Me.f1b_importe.Location = New System.Drawing.Point(132, 1)
        Me.f1b_importe.Margin = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.f1b_importe.Name = "f1b_importe"
        Me.f1b_importe.Size = New System.Drawing.Size(77, 23)
        Me.f1b_importe.TabIndex = 155
        Me.f1b_importe.Text = "Importe"
        Me.f1b_importe.UseVisualStyleBackColor = True
        '
        'f1b_mora
        '
        Me.f1b_mora.AutoSize = True
        Me.f1b_mora.Location = New System.Drawing.Point(212, 1)
        Me.f1b_mora.Margin = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.f1b_mora.Name = "f1b_mora"
        Me.f1b_mora.Size = New System.Drawing.Size(59, 23)
        Me.f1b_mora.TabIndex = 156
        Me.f1b_mora.Text = "Mora"
        Me.f1b_mora.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 27)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Tasa de interes (%)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'interes
        '
        Me.interes.DecimalPlaces = 2
        Me.interes.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.interes.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.interes.Location = New System.Drawing.Point(197, 114)
        Me.interes.Margin = New System.Windows.Forms.Padding(1)
        Me.interes.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.interes.Name = "interes"
        Me.interes.Size = New System.Drawing.Size(74, 27)
        Me.interes.TabIndex = 159
        Me.interes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.interes.ThousandsSeparator = True
        Me.interes.Value = New Decimal(New Integer() {70, 0, 0, 131072})
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 10, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 25)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "hasta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 27)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Vencimiento tope"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(146, 83)
        Me.fecha.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(125, 27)
        Me.fecha.TabIndex = 162
        '
        'CtrlVenc1
        '
        Me.CtrlVenc1.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlVenc1.Enabled = False
        Me.CtrlVenc1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.CtrlVenc1.Location = New System.Drawing.Point(10, 262)
        Me.CtrlVenc1.Margin = New System.Windows.Forms.Padding(10, 0, 3, 3)
        Me.CtrlVenc1.Name = "CtrlVenc1"
        Me.CtrlVenc1.Size = New System.Drawing.Size(258, 240)
        Me.CtrlVenc1.TabIndex = 147
        '
        'ConsultaImpuesto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Sigm.My.Resources.Resources.trama41
        Me.ClientSize = New System.Drawing.Size(884, 605)
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.grupo_imp)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(700, 620)
        Me.Name = "ConsultaImpuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Impuesto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f1b_maximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f1b_minimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f2_año_maximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f2_año_minimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_imp.ResumeLayout(False)
        Me.grupo_imp.PerformLayout()
        Me.grupo_deuda_total.ResumeLayout(False)
        Me.grupo_deuda_total.PerformLayout()
        CType(Me.interes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents f3_clave As System.Windows.Forms.TextBox
    Friend WithEvents f3_campo As System.Windows.Forms.ComboBox
    Friend WithEvents mostrar_f3 As System.Windows.Forms.CheckBox
    Friend WithEvents imp_search As System.Windows.Forms.Button
    Friend WithEvents f1b_maximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents et_hasta As System.Windows.Forms.Label
    Friend WithEvents f1b_deuda_total As System.Windows.Forms.ComboBox
    Friend WithEvents mostrar_f1b As System.Windows.Forms.CheckBox
    Friend WithEvents f1b_minimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents f2_año_maximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents f2_año_minimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents mostrar_f2 As System.Windows.Forms.CheckBox
    Friend WithEvents visor As System.Windows.Forms.DataGridView
    Friend WithEvents CtrlVenc1 As CtrlVenceImpuesto
    Friend WithEvents grupo_imp As FlowLayoutPanel
    Friend WithEvents et_con_imp As Label
    Friend WithEvents f1_impuesto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents f1_Deudor As RadioButton
    Friend WithEvents f1_SinDeuda As RadioButton
    Friend WithEvents grupo_deuda_total As FlowLayoutPanel
    Friend WithEvents f1b_importe As RadioButton
    Friend WithEvents f1b_mora As RadioButton
    Friend WithEvents f1b_importe_mora As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents interes As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents fecha As DateTimePicker
End Class
