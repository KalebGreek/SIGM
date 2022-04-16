<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calcTMuniMensura
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.con_escritura = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.con_derechos = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.zona_inmueble = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.total_lotes = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.factibilidad_agua = New System.Windows.Forms.CheckBox()
        Me.monto_factibilidad_agua = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.monto_mano_obra = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.monto_cruce_calle = New System.Windows.Forms.NumericUpDown()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.multa_relevamiento = New System.Windows.Forms.CheckBox()
        Me.monto_multa_relevamiento = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.monto_subtotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.desc_porcentaje = New System.Windows.Forms.NumericUpDown()
        Me.monto_descuento = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cuotas = New System.Windows.Forms.NumericUpDown()
        Me.monto_cuota = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.bs_zona = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_tasa_mensura = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.total_lotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monto_mano_obra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monto_cruce_calle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desc_porcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_zona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_tasa_mensura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.Controls.Add(Me.con_escritura)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel2.Controls.Add(Me.con_derechos)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel2.Controls.Add(Me.zona_inmueble)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Controls.Add(Me.total_lotes)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label15)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label26)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label17)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel2.Controls.Add(Me.factibilidad_agua)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_factibilidad_agua)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label22)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_mano_obra)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label24)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_cruce_calle)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label33)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel2.Controls.Add(Me.multa_relevamiento)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_multa_relevamiento)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label35)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label32)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_subtotal)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label16)
        Me.FlowLayoutPanel2.Controls.Add(Me.desc_porcentaje)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_descuento)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label19)
        Me.FlowLayoutPanel2.Controls.Add(Me.cuotas)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_cuota)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.total)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(480, 480)
        Me.FlowLayoutPanel2.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(480, 25)
        Me.Label9.TabIndex = 417
        Me.Label9.Text = "URBANIZACIÓN"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(0, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 25)
        Me.Label7.TabIndex = 447
        Me.Label7.Text = "Tipo de Loteo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'con_escritura
        '
        Me.con_escritura.Checked = True
        Me.con_escritura.Location = New System.Drawing.Point(218, 28)
        Me.con_escritura.Margin = New System.Windows.Forms.Padding(5, 3, 0, 0)
        Me.con_escritura.Name = "con_escritura"
        Me.con_escritura.Size = New System.Drawing.Size(231, 25)
        Me.con_escritura.TabIndex = 445
        Me.con_escritura.TabStop = True
        Me.con_escritura.Text = "Con escritura"
        Me.con_escritura.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(0, 55)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(213, 25)
        Me.Label12.TabIndex = 448
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'con_derechos
        '
        Me.con_derechos.Location = New System.Drawing.Point(218, 53)
        Me.con_derechos.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.con_derechos.Name = "con_derechos"
        Me.con_derechos.Size = New System.Drawing.Size(230, 25)
        Me.con_derechos.TabIndex = 446
        Me.con_derechos.Text = "Con derechos posesorios"
        Me.con_derechos.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(0, 82)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(213, 25)
        Me.Label14.TabIndex = 418
        Me.Label14.Text = "Zona de Inmueble"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'zona_inmueble
        '
        Me.zona_inmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.zona_inmueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zona_inmueble.FormattingEnabled = True
        Me.zona_inmueble.Location = New System.Drawing.Point(213, 82)
        Me.zona_inmueble.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.zona_inmueble.Name = "zona_inmueble"
        Me.zona_inmueble.Size = New System.Drawing.Size(239, 30)
        Me.zona_inmueble.TabIndex = 378
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 25)
        Me.Label4.TabIndex = 443
        Me.Label4.Text = "N° de Lotes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'total_lotes
        '
        Me.total_lotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.total_lotes.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!)
        Me.total_lotes.Location = New System.Drawing.Point(213, 114)
        Me.total_lotes.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.total_lotes.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.total_lotes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.total_lotes.Name = "total_lotes"
        Me.total_lotes.Size = New System.Drawing.Size(239, 26)
        Me.total_lotes.TabIndex = 444
        Me.total_lotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.total_lotes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 140)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(381, 4)
        Me.Label15.TabIndex = 449
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(0, 144)
        Me.Label26.Margin = New System.Windows.Forms.Padding(0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(480, 3)
        Me.Label26.TabIndex = 457
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Gray
        Me.Label17.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 147)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(480, 25)
        Me.Label17.TabIndex = 450
        Me.Label17.Text = "AGUA CORRIENTE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 172)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(480, 3)
        Me.Label10.TabIndex = 395
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 175)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(458, 0)
        Me.Label11.TabIndex = 379
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'factibilidad_agua
        '
        Me.factibilidad_agua.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.factibilidad_agua.Location = New System.Drawing.Point(0, 175)
        Me.factibilidad_agua.Margin = New System.Windows.Forms.Padding(0)
        Me.factibilidad_agua.Name = "factibilidad_agua"
        Me.factibilidad_agua.Size = New System.Drawing.Size(233, 25)
        Me.factibilidad_agua.TabIndex = 458
        Me.factibilidad_agua.Text = "Factibilidad del Servicio"
        Me.factibilidad_agua.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.factibilidad_agua.UseVisualStyleBackColor = True
        '
        'monto_factibilidad_agua
        '
        Me.monto_factibilidad_agua.Enabled = False
        Me.monto_factibilidad_agua.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_factibilidad_agua.Location = New System.Drawing.Point(233, 175)
        Me.monto_factibilidad_agua.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_factibilidad_agua.Name = "monto_factibilidad_agua"
        Me.monto_factibilidad_agua.Size = New System.Drawing.Size(209, 25)
        Me.monto_factibilidad_agua.TabIndex = 452
        Me.monto_factibilidad_agua.Text = "$0,00"
        Me.monto_factibilidad_agua.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label22
        '
        Me.Label22.Enabled = False
        Me.Label22.Location = New System.Drawing.Point(0, 200)
        Me.Label22.Margin = New System.Windows.Forms.Padding(0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(213, 25)
        Me.Label22.TabIndex = 453
        Me.Label22.Text = "Mano de Obra ($)"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'monto_mano_obra
        '
        Me.monto_mano_obra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.monto_mano_obra.DecimalPlaces = 2
        Me.monto_mano_obra.Enabled = False
        Me.monto_mano_obra.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!)
        Me.monto_mano_obra.Location = New System.Drawing.Point(213, 202)
        Me.monto_mano_obra.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.monto_mano_obra.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.monto_mano_obra.Name = "monto_mano_obra"
        Me.monto_mano_obra.Size = New System.Drawing.Size(239, 26)
        Me.monto_mano_obra.TabIndex = 459
        Me.monto_mano_obra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Enabled = False
        Me.Label24.Location = New System.Drawing.Point(0, 228)
        Me.Label24.Margin = New System.Windows.Forms.Padding(0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(213, 25)
        Me.Label24.TabIndex = 455
        Me.Label24.Text = "Cruce de Calle ($)"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'monto_cruce_calle
        '
        Me.monto_cruce_calle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.monto_cruce_calle.DecimalPlaces = 2
        Me.monto_cruce_calle.Enabled = False
        Me.monto_cruce_calle.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!)
        Me.monto_cruce_calle.Location = New System.Drawing.Point(213, 230)
        Me.monto_cruce_calle.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.monto_cruce_calle.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.monto_cruce_calle.Name = "monto_cruce_calle"
        Me.monto_cruce_calle.Size = New System.Drawing.Size(239, 26)
        Me.monto_cruce_calle.TabIndex = 460
        Me.monto_cruce_calle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(0, 256)
        Me.Label33.Margin = New System.Windows.Forms.Padding(0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(480, 3)
        Me.Label33.TabIndex = 411
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gray
        Me.Label13.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 259)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(480, 25)
        Me.Label13.TabIndex = 396
        Me.Label13.Text = "TASAS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'multa_relevamiento
        '
        Me.multa_relevamiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.multa_relevamiento.Location = New System.Drawing.Point(0, 284)
        Me.multa_relevamiento.Margin = New System.Windows.Forms.Padding(0)
        Me.multa_relevamiento.Name = "multa_relevamiento"
        Me.multa_relevamiento.Size = New System.Drawing.Size(233, 25)
        Me.multa_relevamiento.TabIndex = 442
        Me.multa_relevamiento.Text = "Multa Relevamiento"
        Me.multa_relevamiento.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.multa_relevamiento.UseVisualStyleBackColor = True
        '
        'monto_multa_relevamiento
        '
        Me.monto_multa_relevamiento.Enabled = False
        Me.monto_multa_relevamiento.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_multa_relevamiento.Location = New System.Drawing.Point(233, 284)
        Me.monto_multa_relevamiento.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_multa_relevamiento.Name = "monto_multa_relevamiento"
        Me.monto_multa_relevamiento.Size = New System.Drawing.Size(209, 25)
        Me.monto_multa_relevamiento.TabIndex = 397
        Me.monto_multa_relevamiento.Text = "$0,00"
        Me.monto_multa_relevamiento.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(0, 309)
        Me.Label35.Margin = New System.Windows.Forms.Padding(0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(480, 3)
        Me.Label35.TabIndex = 414
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Gray
        Me.Label32.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(0, 312)
        Me.Label32.Margin = New System.Windows.Forms.Padding(0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(479, 25)
        Me.Label32.TabIndex = 441
        Me.Label32.Text = "FINANCIACIÓN"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(0, 337)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(213, 25)
        Me.Label21.TabIndex = 432
        Me.Label21.Text = "Subtotal"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'monto_subtotal
        '
        Me.monto_subtotal.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_subtotal.Location = New System.Drawing.Point(213, 337)
        Me.monto_subtotal.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_subtotal.Name = "monto_subtotal"
        Me.monto_subtotal.Size = New System.Drawing.Size(229, 25)
        Me.monto_subtotal.TabIndex = 434
        Me.monto_subtotal.Text = "$0,00"
        Me.monto_subtotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(0, 362)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(213, 25)
        Me.Label16.TabIndex = 437
        Me.Label16.Text = "Descuento (%)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'desc_porcentaje
        '
        Me.desc_porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desc_porcentaje.Location = New System.Drawing.Point(213, 364)
        Me.desc_porcentaje.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.desc_porcentaje.Name = "desc_porcentaje"
        Me.desc_porcentaje.Size = New System.Drawing.Size(64, 26)
        Me.desc_porcentaje.TabIndex = 431
        Me.desc_porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'monto_descuento
        '
        Me.monto_descuento.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_descuento.Location = New System.Drawing.Point(277, 362)
        Me.monto_descuento.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_descuento.Name = "monto_descuento"
        Me.monto_descuento.Size = New System.Drawing.Size(165, 25)
        Me.monto_descuento.TabIndex = 436
        Me.monto_descuento.Text = "$0,00"
        Me.monto_descuento.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(0, 390)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(213, 25)
        Me.Label19.TabIndex = 438
        Me.Label19.Text = "Cuotas"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'cuotas
        '
        Me.cuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cuotas.Location = New System.Drawing.Point(213, 392)
        Me.cuotas.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.cuotas.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.cuotas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cuotas.Name = "cuotas"
        Me.cuotas.Size = New System.Drawing.Size(64, 26)
        Me.cuotas.TabIndex = 433
        Me.cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuotas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'monto_cuota
        '
        Me.monto_cuota.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_cuota.Location = New System.Drawing.Point(277, 390)
        Me.monto_cuota.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_cuota.Name = "monto_cuota"
        Me.monto_cuota.Size = New System.Drawing.Size(165, 25)
        Me.monto_cuota.TabIndex = 435
        Me.monto_cuota.Text = "$0,00"
        Me.monto_cuota.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(0, 418)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 25)
        Me.Label1.TabIndex = 440
        Me.Label1.Text = "TOTAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.total.Location = New System.Drawing.Point(213, 418)
        Me.total.Margin = New System.Windows.Forms.Padding(0)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(229, 25)
        Me.total.TabIndex = 439
        Me.total.Text = "$0,00"
        Me.total.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'calcTMuniMensura
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(900, 480)
        Me.MinimumSize = New System.Drawing.Size(900, 480)
        Me.Name = "calcTMuniMensura"
        Me.Size = New System.Drawing.Size(900, 480)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.total_lotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monto_mano_obra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monto_cruce_calle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desc_porcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_zona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_tasa_mensura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents zona_inmueble As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents monto_multa_relevamiento As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents bs_zona As BindingSource
    Friend WithEvents bs_tasa_mensura As BindingSource
    Friend WithEvents Label21 As Label
    Friend WithEvents monto_subtotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents desc_porcentaje As NumericUpDown
    Friend WithEvents monto_descuento As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cuotas As NumericUpDown
    Friend WithEvents monto_cuota As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents total As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents multa_relevamiento As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents con_escritura As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents con_derechos As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents total_lotes As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents monto_factibilidad_agua As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents factibilidad_agua As CheckBox
    Friend WithEvents monto_mano_obra As NumericUpDown
    Friend WithEvents monto_cruce_calle As NumericUpDown
End Class
