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
        Me.BSConsulta = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSHistorial = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSCuentas = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSPersona = New System.Windows.Forms.BindingSource(Me.components)
        Me.consulta_printdocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.F4ValorClave = New System.Windows.Forms.TextBox()
        Me.F4CampoClave = New System.Windows.Forms.ComboBox()
        Me.F4Mostrar = New System.Windows.Forms.CheckBox()
        Me.EjecutarConsultaDeuda = New System.Windows.Forms.Button()
        Me.F2Maximo = New System.Windows.Forms.NumericUpDown()
        Me.et_hasta = New System.Windows.Forms.Label()
        Me.F2DeudaTotal = New System.Windows.Forms.ComboBox()
        Me.F2Mostrar = New System.Windows.Forms.CheckBox()
        Me.F2Minimo = New System.Windows.Forms.NumericUpDown()
        Me.F3AñoMaximo = New System.Windows.Forms.NumericUpDown()
        Me.F3AñoMinimo = New System.Windows.Forms.NumericUpDown()
        Me.F3Mostrar = New System.Windows.Forms.CheckBox()
        Me.VisorConsulta = New System.Windows.Forms.DataGridView()
        Me.FiltroConsulta = New System.Windows.Forms.FlowLayoutPanel()
        Me.EtGrupoFiltroConsulta = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.F1Servicio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.F1Deudor = New System.Windows.Forms.RadioButton()
        Me.F1SinDeuda = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.F1Vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.F1Interes = New System.Windows.Forms.NumericUpDown()
        Me.grupo_deuda_total = New System.Windows.Forms.FlowLayoutPanel()
        Me.F2ImporteMora = New System.Windows.Forms.RadioButton()
        Me.F2Importe = New System.Windows.Forms.RadioButton()
        Me.F2Mora = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtrlVenc1 = New Sigm.CtrlVenceImpuesto()
        Me.ImprimirConsultaDeuda = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BSConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F2Maximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F2Minimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F3AñoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F3AñoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisorConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FiltroConsulta.SuspendLayout()
        CType(Me.F1Interes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_deuda_total.SuspendLayout()
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 606)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(721, 24)
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
        'BSConsulta
        '
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'F4ValorClave
        '
        Me.F4ValorClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.F4ValorClave.Enabled = False
        Me.F4ValorClave.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F4ValorClave.Location = New System.Drawing.Point(2, 518)
        Me.F4ValorClave.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.F4ValorClave.Name = "F4ValorClave"
        Me.F4ValorClave.Size = New System.Drawing.Size(271, 27)
        Me.F4ValorClave.TabIndex = 89
        '
        'F4CampoClave
        '
        Me.F4CampoClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.F4CampoClave.Enabled = False
        Me.F4CampoClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.F4CampoClave.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F4CampoClave.FormattingEnabled = True
        Me.F4CampoClave.Location = New System.Drawing.Point(101, 489)
        Me.F4CampoClave.Margin = New System.Windows.Forms.Padding(0)
        Me.F4CampoClave.Name = "F4CampoClave"
        Me.F4CampoClave.Size = New System.Drawing.Size(171, 27)
        Me.F4CampoClave.TabIndex = 88
        '
        'F4Mostrar
        '
        Me.F4Mostrar.BackColor = System.Drawing.Color.Transparent
        Me.F4Mostrar.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F4Mostrar.Location = New System.Drawing.Point(2, 491)
        Me.F4Mostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.F4Mostrar.Name = "F4Mostrar"
        Me.F4Mostrar.Size = New System.Drawing.Size(97, 25)
        Me.F4Mostrar.TabIndex = 87
        Me.F4Mostrar.Text = "Filtrar por"
        Me.F4Mostrar.UseVisualStyleBackColor = False
        '
        'EjecutarConsultaDeuda
        '
        Me.EjecutarConsultaDeuda.BackColor = System.Drawing.SystemColors.Control
        Me.EjecutarConsultaDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EjecutarConsultaDeuda.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EjecutarConsultaDeuda.Location = New System.Drawing.Point(2, 547)
        Me.EjecutarConsultaDeuda.Margin = New System.Windows.Forms.Padding(2)
        Me.EjecutarConsultaDeuda.Name = "EjecutarConsultaDeuda"
        Me.EjecutarConsultaDeuda.Size = New System.Drawing.Size(140, 28)
        Me.EjecutarConsultaDeuda.TabIndex = 72
        Me.EjecutarConsultaDeuda.Text = "Consulta (F3)"
        Me.EjecutarConsultaDeuda.UseVisualStyleBackColor = False
        '
        'F2Maximo
        '
        Me.F2Maximo.DecimalPlaces = 2
        Me.F2Maximo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2Maximo.Location = New System.Drawing.Point(188, 23)
        Me.F2Maximo.Margin = New System.Windows.Forms.Padding(0)
        Me.F2Maximo.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.F2Maximo.Name = "F2Maximo"
        Me.F2Maximo.Size = New System.Drawing.Size(86, 27)
        Me.F2Maximo.TabIndex = 84
        Me.F2Maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.F2Maximo.ThousandsSeparator = True
        Me.F2Maximo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'et_hasta
        '
        Me.et_hasta.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_hasta.Location = New System.Drawing.Point(172, 23)
        Me.et_hasta.Margin = New System.Windows.Forms.Padding(0)
        Me.et_hasta.Name = "et_hasta"
        Me.et_hasta.Size = New System.Drawing.Size(16, 27)
        Me.et_hasta.TabIndex = 79
        Me.et_hasta.Text = "-"
        Me.et_hasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'F2DeudaTotal
        '
        Me.F2DeudaTotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.F2DeudaTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.F2DeudaTotal.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2DeudaTotal.FormattingEnabled = True
        Me.F2DeudaTotal.Items.AddRange(New Object() {"MAS DE", "MENOS DE", "RANGO"})
        Me.F2DeudaTotal.Location = New System.Drawing.Point(2, 23)
        Me.F2DeudaTotal.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.F2DeudaTotal.Name = "F2DeudaTotal"
        Me.F2DeudaTotal.Size = New System.Drawing.Size(84, 27)
        Me.F2DeudaTotal.TabIndex = 80
        '
        'F2Mostrar
        '
        Me.F2Mostrar.BackColor = System.Drawing.Color.Transparent
        Me.F2Mostrar.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2Mostrar.Location = New System.Drawing.Point(2, 139)
        Me.F2Mostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.F2Mostrar.Name = "F2Mostrar"
        Me.F2Mostrar.Size = New System.Drawing.Size(271, 23)
        Me.F2Mostrar.TabIndex = 82
        Me.F2Mostrar.Text = "Deuda Agrupada"
        Me.F2Mostrar.UseVisualStyleBackColor = False
        '
        'F2Minimo
        '
        Me.F2Minimo.DecimalPlaces = 2
        Me.F2Minimo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2Minimo.Location = New System.Drawing.Point(88, 23)
        Me.F2Minimo.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.F2Minimo.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.F2Minimo.Name = "F2Minimo"
        Me.F2Minimo.Size = New System.Drawing.Size(84, 27)
        Me.F2Minimo.TabIndex = 78
        Me.F2Minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.F2Minimo.ThousandsSeparator = True
        Me.F2Minimo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'F3AñoMaximo
        '
        Me.F3AñoMaximo.Enabled = False
        Me.F3AñoMaximo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F3AñoMaximo.Location = New System.Drawing.Point(211, 218)
        Me.F3AñoMaximo.Margin = New System.Windows.Forms.Padding(0)
        Me.F3AñoMaximo.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.F3AñoMaximo.Minimum = New Decimal(New Integer() {2001, 0, 0, 0})
        Me.F3AñoMaximo.Name = "F3AñoMaximo"
        Me.F3AñoMaximo.ReadOnly = True
        Me.F3AñoMaximo.Size = New System.Drawing.Size(63, 27)
        Me.F3AñoMaximo.TabIndex = 75
        Me.F3AñoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.F3AñoMaximo.Value = New Decimal(New Integer() {2001, 0, 0, 0})
        '
        'F3AñoMinimo
        '
        Me.F3AñoMinimo.Enabled = False
        Me.F3AñoMinimo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F3AñoMinimo.Location = New System.Drawing.Point(101, 218)
        Me.F3AñoMinimo.Margin = New System.Windows.Forms.Padding(0)
        Me.F3AñoMinimo.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.F3AñoMinimo.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.F3AñoMinimo.Name = "F3AñoMinimo"
        Me.F3AñoMinimo.ReadOnly = True
        Me.F3AñoMinimo.Size = New System.Drawing.Size(63, 27)
        Me.F3AñoMinimo.TabIndex = 69
        Me.F3AñoMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.F3AñoMinimo.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'F3Mostrar
        '
        Me.F3Mostrar.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F3Mostrar.Location = New System.Drawing.Point(2, 220)
        Me.F3Mostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.F3Mostrar.Name = "F3Mostrar"
        Me.F3Mostrar.Size = New System.Drawing.Size(97, 25)
        Me.F3Mostrar.TabIndex = 73
        Me.F3Mostrar.Text = "Periodo"
        Me.F3Mostrar.UseVisualStyleBackColor = True
        '
        'VisorConsulta
        '
        Me.VisorConsulta.AllowUserToAddRows = False
        Me.VisorConsulta.AllowUserToDeleteRows = False
        Me.VisorConsulta.AllowUserToResizeRows = False
        Me.VisorConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VisorConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorConsulta.Location = New System.Drawing.Point(0, 0)
        Me.VisorConsulta.Name = "VisorConsulta"
        Me.VisorConsulta.ReadOnly = True
        Me.VisorConsulta.RowHeadersVisible = False
        Me.VisorConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.VisorConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VisorConsulta.Size = New System.Drawing.Size(443, 606)
        Me.VisorConsulta.TabIndex = 5
        '
        'FiltroConsulta
        '
        Me.FiltroConsulta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FiltroConsulta.Controls.Add(Me.EtGrupoFiltroConsulta)
        Me.FiltroConsulta.Controls.Add(Me.Label3)
        Me.FiltroConsulta.Controls.Add(Me.F1Servicio)
        Me.FiltroConsulta.Controls.Add(Me.Label5)
        Me.FiltroConsulta.Controls.Add(Me.F1Deudor)
        Me.FiltroConsulta.Controls.Add(Me.F1SinDeuda)
        Me.FiltroConsulta.Controls.Add(Me.Label4)
        Me.FiltroConsulta.Controls.Add(Me.F1Vencimiento)
        Me.FiltroConsulta.Controls.Add(Me.Label2)
        Me.FiltroConsulta.Controls.Add(Me.F1Interes)
        Me.FiltroConsulta.Controls.Add(Me.F2Mostrar)
        Me.FiltroConsulta.Controls.Add(Me.grupo_deuda_total)
        Me.FiltroConsulta.Controls.Add(Me.F3Mostrar)
        Me.FiltroConsulta.Controls.Add(Me.F3AñoMinimo)
        Me.FiltroConsulta.Controls.Add(Me.Label1)
        Me.FiltroConsulta.Controls.Add(Me.F3AñoMaximo)
        Me.FiltroConsulta.Controls.Add(Me.CtrlVenc1)
        Me.FiltroConsulta.Controls.Add(Me.F4Mostrar)
        Me.FiltroConsulta.Controls.Add(Me.F4CampoClave)
        Me.FiltroConsulta.Controls.Add(Me.F4ValorClave)
        Me.FiltroConsulta.Controls.Add(Me.EjecutarConsultaDeuda)
        Me.FiltroConsulta.Controls.Add(Me.ImprimirConsultaDeuda)
        Me.FiltroConsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.FiltroConsulta.Location = New System.Drawing.Point(443, 0)
        Me.FiltroConsulta.Name = "FiltroConsulta"
        Me.FiltroConsulta.Size = New System.Drawing.Size(278, 606)
        Me.FiltroConsulta.TabIndex = 6
        '
        'EtGrupoFiltroConsulta
        '
        Me.EtGrupoFiltroConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EtGrupoFiltroConsulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.EtGrupoFiltroConsulta.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtGrupoFiltroConsulta.ForeColor = System.Drawing.Color.White
        Me.EtGrupoFiltroConsulta.Location = New System.Drawing.Point(0, 0)
        Me.EtGrupoFiltroConsulta.Margin = New System.Windows.Forms.Padding(0)
        Me.EtGrupoFiltroConsulta.Name = "EtGrupoFiltroConsulta"
        Me.EtGrupoFiltroConsulta.Size = New System.Drawing.Size(289, 22)
        Me.EtGrupoFiltroConsulta.TabIndex = 148
        Me.EtGrupoFiltroConsulta.Text = " FILTROS"
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
        'F1Servicio
        '
        Me.F1Servicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.F1Servicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.F1Servicio.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1Servicio.FormattingEnabled = True
        Me.F1Servicio.Items.AddRange(New Object() {"AGUAS", "AUTOMOVIL", "CATASTRO", "COMERCIO", "SEPELIO", "BARRIOS"})
        Me.F1Servicio.Location = New System.Drawing.Point(67, 30)
        Me.F1Servicio.Margin = New System.Windows.Forms.Padding(2, 8, 2, 2)
        Me.F1Servicio.Name = "F1Servicio"
        Me.F1Servicio.Size = New System.Drawing.Size(206, 27)
        Me.F1Servicio.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 23)
        Me.Label5.TabIndex = 164
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'F1Deudor
        '
        Me.F1Deudor.AutoSize = True
        Me.F1Deudor.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1Deudor.ForeColor = System.Drawing.Color.Red
        Me.F1Deudor.Location = New System.Drawing.Point(68, 59)
        Me.F1Deudor.Margin = New System.Windows.Forms.Padding(0)
        Me.F1Deudor.Name = "F1Deudor"
        Me.F1Deudor.Size = New System.Drawing.Size(74, 23)
        Me.F1Deudor.TabIndex = 150
        Me.F1Deudor.Text = "Deudor"
        Me.F1Deudor.UseVisualStyleBackColor = True
        '
        'F1SinDeuda
        '
        Me.F1SinDeuda.AutoSize = True
        Me.F1SinDeuda.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1SinDeuda.ForeColor = System.Drawing.Color.Green
        Me.F1SinDeuda.Location = New System.Drawing.Point(142, 59)
        Me.F1SinDeuda.Margin = New System.Windows.Forms.Padding(0)
        Me.F1SinDeuda.Name = "F1SinDeuda"
        Me.F1SinDeuda.Size = New System.Drawing.Size(100, 23)
        Me.F1SinDeuda.TabIndex = 151
        Me.F1SinDeuda.Text = "Sin deudas"
        Me.F1SinDeuda.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 25)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Vencimiento tope"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'F1Vencimiento
        '
        Me.F1Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.F1Vencimiento.Location = New System.Drawing.Point(148, 82)
        Me.F1Vencimiento.Margin = New System.Windows.Forms.Padding(0)
        Me.F1Vencimiento.Name = "F1Vencimiento"
        Me.F1Vencimiento.Size = New System.Drawing.Size(125, 27)
        Me.F1Vencimiento.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 23)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Interes diario (%)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'F1Interes
        '
        Me.F1Interes.DecimalPlaces = 4
        Me.F1Interes.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1Interes.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.F1Interes.Location = New System.Drawing.Point(148, 110)
        Me.F1Interes.Margin = New System.Windows.Forms.Padding(0)
        Me.F1Interes.Minimum = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.F1Interes.Name = "F1Interes"
        Me.F1Interes.Size = New System.Drawing.Size(125, 27)
        Me.F1Interes.TabIndex = 159
        Me.F1Interes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.F1Interes.ThousandsSeparator = True
        Me.F1Interes.Value = New Decimal(New Integer() {1315, 0, 0, 262144})
        '
        'grupo_deuda_total
        '
        Me.grupo_deuda_total.Controls.Add(Me.F2ImporteMora)
        Me.grupo_deuda_total.Controls.Add(Me.F2Importe)
        Me.grupo_deuda_total.Controls.Add(Me.F2Mora)
        Me.grupo_deuda_total.Controls.Add(Me.F2DeudaTotal)
        Me.grupo_deuda_total.Controls.Add(Me.F2Minimo)
        Me.grupo_deuda_total.Controls.Add(Me.et_hasta)
        Me.grupo_deuda_total.Controls.Add(Me.F2Maximo)
        Me.grupo_deuda_total.Enabled = False
        Me.grupo_deuda_total.Location = New System.Drawing.Point(0, 164)
        Me.grupo_deuda_total.Margin = New System.Windows.Forms.Padding(0)
        Me.grupo_deuda_total.Name = "grupo_deuda_total"
        Me.grupo_deuda_total.Size = New System.Drawing.Size(278, 54)
        Me.grupo_deuda_total.TabIndex = 152
        Me.grupo_deuda_total.Visible = False
        '
        'F2ImporteMora
        '
        Me.F2ImporteMora.Checked = True
        Me.F2ImporteMora.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2ImporteMora.Location = New System.Drawing.Point(0, 0)
        Me.F2ImporteMora.Margin = New System.Windows.Forms.Padding(0)
        Me.F2ImporteMora.Name = "F2ImporteMora"
        Me.F2ImporteMora.Size = New System.Drawing.Size(130, 23)
        Me.F2ImporteMora.TabIndex = 157
        Me.F2ImporteMora.TabStop = True
        Me.F2ImporteMora.Text = "Importe + Mora"
        Me.F2ImporteMora.UseVisualStyleBackColor = True
        '
        'F2Importe
        '
        Me.F2Importe.AutoSize = True
        Me.F2Importe.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2Importe.Location = New System.Drawing.Point(130, 0)
        Me.F2Importe.Margin = New System.Windows.Forms.Padding(0)
        Me.F2Importe.Name = "F2Importe"
        Me.F2Importe.Size = New System.Drawing.Size(80, 23)
        Me.F2Importe.TabIndex = 155
        Me.F2Importe.Text = "Importe"
        Me.F2Importe.UseVisualStyleBackColor = True
        '
        'F2Mora
        '
        Me.F2Mora.AutoSize = True
        Me.F2Mora.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2Mora.Location = New System.Drawing.Point(210, 0)
        Me.F2Mora.Margin = New System.Windows.Forms.Padding(0)
        Me.F2Mora.Name = "F2Mora"
        Me.F2Mora.Size = New System.Drawing.Size(60, 23)
        Me.F2Mora.TabIndex = 156
        Me.F2Mora.Text = "Mora"
        Me.F2Mora.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 218)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "hasta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CtrlVenc1
        '
        Me.CtrlVenc1.BackColor = System.Drawing.SystemColors.Control
        Me.CtrlVenc1.Enabled = False
        Me.CtrlVenc1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.CtrlVenc1.Location = New System.Drawing.Point(0, 247)
        Me.CtrlVenc1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.CtrlVenc1.Name = "CtrlVenc1"
        Me.CtrlVenc1.Size = New System.Drawing.Size(275, 237)
        Me.CtrlVenc1.TabIndex = 147
        Me.CtrlVenc1.Visible = False
        '
        'ImprimirConsultaDeuda
        '
        Me.ImprimirConsultaDeuda.BackColor = System.Drawing.SystemColors.Control
        Me.ImprimirConsultaDeuda.Enabled = False
        Me.ImprimirConsultaDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImprimirConsultaDeuda.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirConsultaDeuda.Location = New System.Drawing.Point(146, 547)
        Me.ImprimirConsultaDeuda.Margin = New System.Windows.Forms.Padding(2)
        Me.ImprimirConsultaDeuda.Name = "ImprimirConsultaDeuda"
        Me.ImprimirConsultaDeuda.Size = New System.Drawing.Size(127, 28)
        Me.ImprimirConsultaDeuda.TabIndex = 163
        Me.ImprimirConsultaDeuda.Text = "Imprimir (F4)"
        Me.ImprimirConsultaDeuda.UseVisualStyleBackColor = False
        '
        'ConsultaImpuesto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(721, 630)
        Me.Controls.Add(Me.VisorConsulta)
        Me.Controls.Add(Me.FiltroConsulta)
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
        CType(Me.BSConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F2Maximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F2Minimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F3AñoMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F3AñoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisorConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FiltroConsulta.ResumeLayout(False)
        Me.FiltroConsulta.PerformLayout()
        CType(Me.F1Interes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_deuda_total.ResumeLayout(False)
        Me.grupo_deuda_total.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents basura1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents basura2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BSCuentas As System.Windows.Forms.BindingSource
    Friend WithEvents BSHistorial As System.Windows.Forms.BindingSource
	Friend WithEvents BSPersona As System.Windows.Forms.BindingSource
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents info As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents info2 As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar
	Friend WithEvents consulta_printdocument As System.Drawing.Printing.PrintDocument
	Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
	Friend WithEvents F4ValorClave As System.Windows.Forms.TextBox
	Friend WithEvents F4CampoClave As System.Windows.Forms.ComboBox
	Friend WithEvents F4Mostrar As System.Windows.Forms.CheckBox
	Friend WithEvents EjecutarConsultaDeuda As System.Windows.Forms.Button
	Friend WithEvents F2Maximo As System.Windows.Forms.NumericUpDown
	Friend WithEvents et_hasta As System.Windows.Forms.Label
	Friend WithEvents F2DeudaTotal As System.Windows.Forms.ComboBox
	Friend WithEvents F2Mostrar As System.Windows.Forms.CheckBox
	Friend WithEvents F2Minimo As System.Windows.Forms.NumericUpDown
	Friend WithEvents F3AñoMaximo As System.Windows.Forms.NumericUpDown
	Friend WithEvents F3AñoMinimo As System.Windows.Forms.NumericUpDown
	Friend WithEvents F3Mostrar As System.Windows.Forms.CheckBox
	Friend WithEvents VisorConsulta As System.Windows.Forms.DataGridView
	Friend WithEvents CtrlVenc1 As CtrlVenceImpuesto
	Friend WithEvents FiltroConsulta As FlowLayoutPanel
	Friend WithEvents EtGrupoFiltroConsulta As Label
	Friend WithEvents F1Servicio As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents F1Deudor As RadioButton
	Friend WithEvents F1SinDeuda As RadioButton
	Friend WithEvents grupo_deuda_total As FlowLayoutPanel
	Friend WithEvents F2Importe As RadioButton
	Friend WithEvents F2Mora As RadioButton
	Friend WithEvents F2ImporteMora As RadioButton
	Friend WithEvents Label2 As Label
	Friend WithEvents F1Interes As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents F1Vencimiento As DateTimePicker
	Public WithEvents BSConsulta As BindingSource
	Friend WithEvents ImprimirConsultaDeuda As Button
	Friend WithEvents Label5 As Label
End Class
