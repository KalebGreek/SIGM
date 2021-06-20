<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcTMuniPlanosEdif
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lista_edificacion = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sup_total = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.monto_linea_municipal = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.monto_presentacion_plano = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.monto_aprobacion_proyecto = New System.Windows.Forms.Label()
        Me.multa_relevamiento = New System.Windows.Forms.CheckBox()
        Me.monto_multa_relevamiento = New System.Windows.Forms.Label()
        Me.descuento_renovacion = New System.Windows.Forms.CheckBox()
        Me.monto_descuento_renovacion = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.monto_subtotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.desc_porcentaje = New System.Windows.Forms.NumericUpDown()
        Me.monto_descuento = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cuotas = New System.Windows.Forms.NumericUpDown()
        Me.monto_cuota = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.bs_zona = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_tasas = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_tasa_edificacion = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_indice_inmueble = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.lista_edificacion.SuspendLayout()
        CType(Me.monto_linea_municipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desc_porcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_zona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_tasas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_tasa_edificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_indice_inmueble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label17)
        Me.FlowLayoutPanel2.Controls.Add(Me.lista_edificacion)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.Controls.Add(Me.sup_total)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_linea_municipal)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_presentacion_plano)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label15)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_aprobacion_proyecto)
        Me.FlowLayoutPanel2.Controls.Add(Me.multa_relevamiento)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_multa_relevamiento)
        Me.FlowLayoutPanel2.Controls.Add(Me.descuento_renovacion)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_descuento_renovacion)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label28)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label33)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label32)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_subtotal)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label16)
        Me.FlowLayoutPanel2.Controls.Add(Me.desc_porcentaje)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_descuento)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label19)
        Me.FlowLayoutPanel2.Controls.Add(Me.cuotas)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto_cuota)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.total)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.MaximumSize = New System.Drawing.Size(460, 0)
        Me.FlowLayoutPanel2.MinimumSize = New System.Drawing.Size(460, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(460, 376)
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
        Me.Label9.Size = New System.Drawing.Size(479, 25)
        Me.Label9.TabIndex = 417
        Me.Label9.Text = "DETALLE DE EDIFICACIONES"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Tipo de Construcción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(309, 27)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 25)
        Me.Label17.TabIndex = 425
        Me.Label17.Text = "Superficie (M²)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lista_edificacion
        '
        Me.lista_edificacion.AutoSize = True
        Me.lista_edificacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lista_edificacion.BackColor = System.Drawing.Color.LightGray
        Me.lista_edificacion.Controls.Add(Me.Label3)
        Me.lista_edificacion.Location = New System.Drawing.Point(0, 52)
        Me.lista_edificacion.Margin = New System.Windows.Forms.Padding(0)
        Me.lista_edificacion.Name = "lista_edificacion"
        Me.lista_edificacion.Size = New System.Drawing.Size(475, 3)
        Me.lista_edificacion.TabIndex = 427
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(475, 3)
        Me.Label3.TabIndex = 415
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(0, 55)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(320, 25)
        Me.Label8.TabIndex = 393
        Me.Label8.Text = "Total Superficie"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'sup_total
        '
        Me.sup_total.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.sup_total.Location = New System.Drawing.Point(320, 55)
        Me.sup_total.Margin = New System.Windows.Forms.Padding(0)
        Me.sup_total.Name = "sup_total"
        Me.sup_total.Size = New System.Drawing.Size(101, 25)
        Me.sup_total.TabIndex = 394
        Me.sup_total.Text = "0 M²"
        Me.sup_total.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 80)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(381, 4)
        Me.Label10.TabIndex = 395
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gray
        Me.Label13.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 84)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(479, 25)
        Me.Label13.TabIndex = 396
        Me.Label13.Text = "TASAS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 25)
        Me.Label5.TabIndex = 429
        Me.Label5.Text = "Línea Municipal ($)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'monto_linea_municipal
        '
        Me.monto_linea_municipal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.monto_linea_municipal.DecimalPlaces = 2
        Me.monto_linea_municipal.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!)
        Me.monto_linea_municipal.Location = New System.Drawing.Point(193, 111)
        Me.monto_linea_municipal.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.monto_linea_municipal.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.monto_linea_municipal.Name = "monto_linea_municipal"
        Me.monto_linea_municipal.Size = New System.Drawing.Size(239, 26)
        Me.monto_linea_municipal.TabIndex = 405
        Me.monto_linea_municipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(0, 137)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(193, 25)
        Me.Label12.TabIndex = 376
        Me.Label12.Text = "Presentación de Planos"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'monto_presentacion_plano
        '
        Me.monto_presentacion_plano.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_presentacion_plano.Location = New System.Drawing.Point(193, 137)
        Me.monto_presentacion_plano.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_presentacion_plano.Name = "monto_presentacion_plano"
        Me.monto_presentacion_plano.Size = New System.Drawing.Size(229, 25)
        Me.monto_presentacion_plano.TabIndex = 422
        Me.monto_presentacion_plano.Text = "$0,00"
        Me.monto_presentacion_plano.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(0, 162)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(193, 25)
        Me.Label15.TabIndex = 421
        Me.Label15.Text = "Aprobación de Proyecto"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'monto_aprobacion_proyecto
        '
        Me.monto_aprobacion_proyecto.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_aprobacion_proyecto.Location = New System.Drawing.Point(193, 162)
        Me.monto_aprobacion_proyecto.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_aprobacion_proyecto.Name = "monto_aprobacion_proyecto"
        Me.monto_aprobacion_proyecto.Size = New System.Drawing.Size(229, 25)
        Me.monto_aprobacion_proyecto.TabIndex = 377
        Me.monto_aprobacion_proyecto.Text = "$0,00"
        Me.monto_aprobacion_proyecto.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'multa_relevamiento
        '
        Me.multa_relevamiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.multa_relevamiento.Location = New System.Drawing.Point(0, 187)
        Me.multa_relevamiento.Margin = New System.Windows.Forms.Padding(0)
        Me.multa_relevamiento.Name = "multa_relevamiento"
        Me.multa_relevamiento.Size = New System.Drawing.Size(212, 25)
        Me.multa_relevamiento.TabIndex = 431
        Me.multa_relevamiento.Text = "Multa Relevamiento"
        Me.multa_relevamiento.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.multa_relevamiento.UseVisualStyleBackColor = True
        '
        'monto_multa_relevamiento
        '
        Me.monto_multa_relevamiento.Enabled = False
        Me.monto_multa_relevamiento.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_multa_relevamiento.Location = New System.Drawing.Point(212, 187)
        Me.monto_multa_relevamiento.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_multa_relevamiento.Name = "monto_multa_relevamiento"
        Me.monto_multa_relevamiento.Size = New System.Drawing.Size(210, 25)
        Me.monto_multa_relevamiento.TabIndex = 397
        Me.monto_multa_relevamiento.Text = "$0,00"
        Me.monto_multa_relevamiento.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'descuento_renovacion
        '
        Me.descuento_renovacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.descuento_renovacion.Location = New System.Drawing.Point(0, 212)
        Me.descuento_renovacion.Margin = New System.Windows.Forms.Padding(0)
        Me.descuento_renovacion.Name = "descuento_renovacion"
        Me.descuento_renovacion.Size = New System.Drawing.Size(212, 25)
        Me.descuento_renovacion.TabIndex = 433
        Me.descuento_renovacion.Text = "Desc. Renovación"
        Me.descuento_renovacion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.descuento_renovacion.UseVisualStyleBackColor = True
        '
        'monto_descuento_renovacion
        '
        Me.monto_descuento_renovacion.Enabled = False
        Me.monto_descuento_renovacion.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_descuento_renovacion.Location = New System.Drawing.Point(212, 212)
        Me.monto_descuento_renovacion.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_descuento_renovacion.Name = "monto_descuento_renovacion"
        Me.monto_descuento_renovacion.Size = New System.Drawing.Size(210, 25)
        Me.monto_descuento_renovacion.TabIndex = 432
        Me.monto_descuento_renovacion.Text = "$0,00"
        Me.monto_descuento_renovacion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(0, 237)
        Me.Label28.Margin = New System.Windows.Forms.Padding(0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(381, 4)
        Me.Label28.TabIndex = 404
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(0, 241)
        Me.Label33.Margin = New System.Windows.Forms.Padding(0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(381, 4)
        Me.Label33.TabIndex = 411
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Gray
        Me.Label32.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(0, 245)
        Me.Label32.Margin = New System.Windows.Forms.Padding(0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(479, 25)
        Me.Label32.TabIndex = 410
        Me.Label32.Text = "FINANCIACIÓN"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(0, 270)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(193, 25)
        Me.Label21.TabIndex = 80
        Me.Label21.Text = "Subtotal"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'monto_subtotal
        '
        Me.monto_subtotal.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_subtotal.Location = New System.Drawing.Point(193, 270)
        Me.monto_subtotal.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_subtotal.Name = "monto_subtotal"
        Me.monto_subtotal.Size = New System.Drawing.Size(229, 25)
        Me.monto_subtotal.TabIndex = 367
        Me.monto_subtotal.Text = "$0,00"
        Me.monto_subtotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 295)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(458, 0)
        Me.Label11.TabIndex = 379
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(0, 295)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(193, 25)
        Me.Label16.TabIndex = 373
        Me.Label16.Text = "Descuento (%)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'desc_porcentaje
        '
        Me.desc_porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desc_porcentaje.Location = New System.Drawing.Point(193, 297)
        Me.desc_porcentaje.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.desc_porcentaje.Name = "desc_porcentaje"
        Me.desc_porcentaje.Size = New System.Drawing.Size(64, 26)
        Me.desc_porcentaje.TabIndex = 70
        Me.desc_porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'monto_descuento
        '
        Me.monto_descuento.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_descuento.Location = New System.Drawing.Point(257, 295)
        Me.monto_descuento.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_descuento.Name = "monto_descuento"
        Me.monto_descuento.Size = New System.Drawing.Size(165, 25)
        Me.monto_descuento.TabIndex = 369
        Me.monto_descuento.Text = "$0,00"
        Me.monto_descuento.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(0, 323)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(193, 25)
        Me.Label19.TabIndex = 374
        Me.Label19.Text = "Cuotas"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'cuotas
        '
        Me.cuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cuotas.Location = New System.Drawing.Point(193, 325)
        Me.cuotas.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.cuotas.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.cuotas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cuotas.Name = "cuotas"
        Me.cuotas.Size = New System.Drawing.Size(64, 26)
        Me.cuotas.TabIndex = 88
        Me.cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuotas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'monto_cuota
        '
        Me.monto_cuota.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_cuota.Location = New System.Drawing.Point(257, 323)
        Me.monto_cuota.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_cuota.Name = "monto_cuota"
        Me.monto_cuota.Size = New System.Drawing.Size(165, 25)
        Me.monto_cuota.TabIndex = 368
        Me.monto_cuota.Text = "$0,00"
        Me.monto_cuota.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(0, 351)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 25)
        Me.Label6.TabIndex = 430
        Me.Label6.Text = "TOTAL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.total.Location = New System.Drawing.Point(193, 351)
        Me.total.Margin = New System.Windows.Forms.Padding(0)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(229, 25)
        Me.total.TabIndex = 413
        Me.total.Text = "$0,00"
        Me.total.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'calcTMuniPlanosEdif
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(480, 480)
        Me.MinimumSize = New System.Drawing.Size(480, 480)
        Me.Name = "calcTMuniPlanosEdif"
        Me.Size = New System.Drawing.Size(480, 480)
        Me.Tag = ""
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.lista_edificacion.ResumeLayout(False)
        CType(Me.monto_linea_municipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desc_porcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_zona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_tasas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_tasa_edificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_indice_inmueble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents monto_aprobacion_proyecto As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents monto_descuento As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cuotas As NumericUpDown
    Friend WithEvents monto_cuota As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents monto_subtotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents sup_total As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents monto_multa_relevamiento As Label
    Friend WithEvents monto_linea_municipal As NumericUpDown
    Friend WithEvents Label28 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents total As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents monto_presentacion_plano As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents bs_zona As BindingSource
    Friend WithEvents bs_tasas As BindingSource
    Friend WithEvents Label17 As Label
    Friend WithEvents lista_edificacion As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents multa_relevamiento As CheckBox
    Friend WithEvents descuento_renovacion As CheckBox
    Friend WithEvents monto_descuento_renovacion As Label
    Friend WithEvents desc_porcentaje As NumericUpDown
    Friend WithEvents bs_tasa_edificacion As BindingSource
    Friend WithEvents bs_indice_inmueble As BindingSource
End Class
