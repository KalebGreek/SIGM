<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModCombustibleReceptor


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
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.SaveAdd = New System.Windows.Forms.Button()
		Me.Save = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.alta = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.baja = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cuenta = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.responsable = New System.Windows.Forms.ComboBox()
		Me.AddResponsable = New System.Windows.Forms.Button()
		Me.DelResponsable = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cuil_responsable = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.categoria = New System.Windows.Forms.ComboBox()
		Me.AddCategoria = New System.Windows.Forms.Button()
		Me.DelCategoria = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.marca = New System.Windows.Forms.TextBox()
		Me.vehiculo = New System.Windows.Forms.CheckBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.dominio = New System.Windows.Forms.MaskedTextBox()
		Me.argentina = New System.Windows.Forms.RadioButton()
		Me.mercosur = New System.Windows.Forms.RadioButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.observaciones = New System.Windows.Forms.TextBox()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.cerrar = New System.Windows.Forms.Button()
		Me.bs_receptor = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_categoria = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_cuenta = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_responsable = New System.Windows.Forms.BindingSource(Me.components)
		Me.modelo = New System.Windows.Forms.NumericUpDown()
		Me.FlowLayoutPanel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.modelo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SaveAdd
		'
		Me.SaveAdd.Dock = System.Windows.Forms.DockStyle.Right
		Me.SaveAdd.FlatAppearance.BorderSize = 0
		Me.SaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SaveAdd.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SaveAdd.ForeColor = System.Drawing.Color.White
		Me.SaveAdd.Location = New System.Drawing.Point(300, 0)
		Me.SaveAdd.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.SaveAdd.Name = "SaveAdd"
		Me.SaveAdd.Size = New System.Drawing.Size(50, 27)
		Me.SaveAdd.TabIndex = 436
		Me.SaveAdd.Text = "+1"
		Me.ToolTip1.SetToolTip(Me.SaveAdd, "Guardar y Crear Nuevo Receptor")
		Me.SaveAdd.UseVisualStyleBackColor = False
		'
		'Save
		'
		Me.Save.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.Save.Dock = System.Windows.Forms.DockStyle.Right
		Me.Save.FlatAppearance.BorderSize = 0
		Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Save.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Save.ForeColor = System.Drawing.Color.White
		Me.Save.Location = New System.Drawing.Point(350, 0)
		Me.Save.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Save.Name = "Save"
		Me.Save.Size = New System.Drawing.Size(30, 27)
		Me.Save.TabIndex = 432
		Me.Save.Text = ""
		Me.ToolTip1.SetToolTip(Me.Save, "Guardar Cambios y Cerrar")
		Me.Save.UseVisualStyleBackColor = False
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.LightGray
		Me.FlowLayoutPanel3.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel3.Controls.Add(Me.alta)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel3.Controls.Add(Me.baja)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel3.Controls.Add(Me.cuenta)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label10)
		Me.FlowLayoutPanel3.Controls.Add(Me.responsable)
		Me.FlowLayoutPanel3.Controls.Add(Me.AddResponsable)
		Me.FlowLayoutPanel3.Controls.Add(Me.DelResponsable)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel3.Controls.Add(Me.cuil_responsable)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label9)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel3.Controls.Add(Me.categoria)
		Me.FlowLayoutPanel3.Controls.Add(Me.AddCategoria)
		Me.FlowLayoutPanel3.Controls.Add(Me.DelCategoria)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel3.Controls.Add(Me.marca)
		Me.FlowLayoutPanel3.Controls.Add(Me.vehiculo)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel3.Controls.Add(Me.dominio)
		Me.FlowLayoutPanel3.Controls.Add(Me.argentina)
		Me.FlowLayoutPanel3.Controls.Add(Me.mercosur)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel3.Controls.Add(Me.modelo)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label12)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label11)
		Me.FlowLayoutPanel3.Controls.Add(Me.observaciones)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 27)
		Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(412, 335)
		Me.FlowLayoutPanel3.TabIndex = 429
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(4, 0)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(110, 29)
		Me.Label8.TabIndex = 431
		Me.Label8.Text = "Alta"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'alta
		'
		Me.alta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.alta.Location = New System.Drawing.Point(114, 2)
		Me.alta.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.alta.Name = "alta"
		Me.alta.Size = New System.Drawing.Size(98, 27)
		Me.alta.TabIndex = 432
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(216, 0)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(43, 29)
		Me.Label5.TabIndex = 470
		Me.Label5.Text = "Baja"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'baja
		'
		Me.baja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.baja.Location = New System.Drawing.Point(259, 2)
		Me.baja.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.baja.Name = "baja"
		Me.baja.Size = New System.Drawing.Size(98, 27)
		Me.baja.TabIndex = 471
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label3.Location = New System.Drawing.Point(4, 29)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(110, 29)
		Me.Label3.TabIndex = 454
		Me.Label3.Text = "Cuenta"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cuenta
		'
		Me.cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cuenta.FormattingEnabled = True
		Me.cuenta.Location = New System.Drawing.Point(114, 31)
		Me.cuenta.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.cuenta.Name = "cuenta"
		Me.cuenta.Size = New System.Drawing.Size(243, 27)
		Me.cuenta.TabIndex = 437
		'
		'Label10
		'
		Me.Label10.Location = New System.Drawing.Point(4, 58)
		Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(110, 29)
		Me.Label10.TabIndex = 439
		Me.Label10.Text = "Responsable"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'responsable
		'
		Me.responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.responsable.FormattingEnabled = True
		Me.responsable.Location = New System.Drawing.Point(114, 60)
		Me.responsable.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.responsable.Name = "responsable"
		Me.responsable.Size = New System.Drawing.Size(243, 27)
		Me.responsable.TabIndex = 479
		'
		'AddResponsable
		'
		Me.AddResponsable.FlatAppearance.BorderSize = 0
		Me.AddResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddResponsable.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AddResponsable.ForeColor = System.Drawing.Color.White
		Me.AddResponsable.Location = New System.Drawing.Point(357, 60)
		Me.AddResponsable.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.AddResponsable.Name = "AddResponsable"
		Me.AddResponsable.Size = New System.Drawing.Size(27, 27)
		Me.AddResponsable.TabIndex = 480
		Me.AddResponsable.Text = ""
		Me.AddResponsable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.AddResponsable.UseVisualStyleBackColor = False
		'
		'DelResponsable
		'
		Me.DelResponsable.FlatAppearance.BorderSize = 0
		Me.DelResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelResponsable.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelResponsable.ForeColor = System.Drawing.Color.White
		Me.DelResponsable.Location = New System.Drawing.Point(384, 60)
		Me.DelResponsable.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.DelResponsable.Name = "DelResponsable"
		Me.DelResponsable.Size = New System.Drawing.Size(27, 27)
		Me.DelResponsable.TabIndex = 481
		Me.DelResponsable.Text = ""
		Me.DelResponsable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.DelResponsable.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(4, 89)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 2, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(110, 27)
		Me.Label2.TabIndex = 407
		Me.Label2.Text = "CUIT/CUIL/DNI"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cuil_responsable
		'
		Me.cuil_responsable.Enabled = False
		Me.cuil_responsable.Location = New System.Drawing.Point(114, 89)
		Me.cuil_responsable.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.cuil_responsable.MaxLength = 60
		Me.cuil_responsable.Name = "cuil_responsable"
		Me.cuil_responsable.ReadOnly = True
		Me.cuil_responsable.Size = New System.Drawing.Size(121, 27)
		Me.cuil_responsable.TabIndex = 478
		'
		'Label9
		'
		Me.Label9.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label9.Location = New System.Drawing.Point(239, 92)
		Me.Label9.Margin = New System.Windows.Forms.Padding(4, 5, 0, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(172, 21)
		Me.Label9.TabIndex = 461
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label7.Location = New System.Drawing.Point(4, 116)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(110, 29)
		Me.Label7.TabIndex = 456
		Me.Label7.Text = "Categoria"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'categoria
		'
		Me.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.categoria.FormattingEnabled = True
		Me.categoria.Location = New System.Drawing.Point(114, 118)
		Me.categoria.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.categoria.Name = "categoria"
		Me.categoria.Size = New System.Drawing.Size(243, 27)
		Me.categoria.TabIndex = 453
		'
		'AddCategoria
		'
		Me.AddCategoria.FlatAppearance.BorderSize = 0
		Me.AddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddCategoria.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AddCategoria.ForeColor = System.Drawing.Color.White
		Me.AddCategoria.Location = New System.Drawing.Point(357, 118)
		Me.AddCategoria.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.AddCategoria.Name = "AddCategoria"
		Me.AddCategoria.Size = New System.Drawing.Size(27, 27)
		Me.AddCategoria.TabIndex = 459
		Me.AddCategoria.Text = ""
		Me.AddCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.AddCategoria.UseVisualStyleBackColor = False
		'
		'DelCategoria
		'
		Me.DelCategoria.FlatAppearance.BorderSize = 0
		Me.DelCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelCategoria.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelCategoria.ForeColor = System.Drawing.Color.White
		Me.DelCategoria.Location = New System.Drawing.Point(384, 118)
		Me.DelCategoria.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.DelCategoria.Name = "DelCategoria"
		Me.DelCategoria.Size = New System.Drawing.Size(27, 27)
		Me.DelCategoria.TabIndex = 460
		Me.DelCategoria.Text = ""
		Me.DelCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.DelCategoria.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label6.Location = New System.Drawing.Point(4, 145)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(110, 29)
		Me.Label6.TabIndex = 434
		Me.Label6.Text = "Marca"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'marca
		'
		Me.marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.marca.Location = New System.Drawing.Point(114, 147)
		Me.marca.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.marca.MaxLength = 60
		Me.marca.Name = "marca"
		Me.marca.Size = New System.Drawing.Size(121, 27)
		Me.marca.TabIndex = 449
		'
		'vehiculo
		'
		Me.vehiculo.AutoSize = True
		Me.vehiculo.Checked = True
		Me.vehiculo.CheckState = System.Windows.Forms.CheckState.Checked
		Me.vehiculo.Location = New System.Drawing.Point(238, 148)
		Me.vehiculo.Name = "vehiculo"
		Me.vehiculo.Size = New System.Drawing.Size(84, 23)
		Me.vehiculo.TabIndex = 477
		Me.vehiculo.Text = "Vehiculo"
		Me.vehiculo.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(4, 174)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(110, 30)
		Me.Label4.TabIndex = 463
		Me.Label4.Text = "Dominio"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'dominio
		'
		Me.dominio.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dominio.Location = New System.Drawing.Point(114, 176)
		Me.dominio.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.dominio.Mask = "AAA 000"
		Me.dominio.Name = "dominio"
		Me.dominio.Size = New System.Drawing.Size(83, 27)
		Me.dominio.TabIndex = 464
		Me.dominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'argentina
		'
		Me.argentina.Checked = True
		Me.argentina.Location = New System.Drawing.Point(203, 174)
		Me.argentina.Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
		Me.argentina.Name = "argentina"
		Me.argentina.Size = New System.Drawing.Size(92, 30)
		Me.argentina.TabIndex = 466
		Me.argentina.TabStop = True
		Me.argentina.Text = "Argentina"
		Me.argentina.UseVisualStyleBackColor = True
		'
		'mercosur
		'
		Me.mercosur.Location = New System.Drawing.Point(297, 174)
		Me.mercosur.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.mercosur.Name = "mercosur"
		Me.mercosur.Size = New System.Drawing.Size(88, 30)
		Me.mercosur.TabIndex = 467
		Me.mercosur.Text = "Mercosur"
		Me.mercosur.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label1.Location = New System.Drawing.Point(4, 204)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(110, 28)
		Me.Label1.TabIndex = 462
		Me.Label1.Text = "Modelo"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label12
		'
		Me.Label12.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label12.Location = New System.Drawing.Point(198, 209)
		Me.Label12.Margin = New System.Windows.Forms.Padding(4, 5, 0, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(172, 21)
		Me.Label12.TabIndex = 473
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label11.Location = New System.Drawing.Point(4, 232)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(110, 28)
		Me.Label11.TabIndex = 472
		Me.Label11.Text = "Observaciones"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'observaciones
		'
		Me.observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.observaciones.Location = New System.Drawing.Point(114, 234)
		Me.observaciones.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.observaciones.MaxLength = 90
		Me.observaciones.Multiline = True
		Me.observaciones.Name = "observaciones"
		Me.observaciones.Size = New System.Drawing.Size(243, 95)
		Me.observaciones.TabIndex = 474
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Gray
		Me.Panel4.Controls.Add(Me.Label14)
		Me.Panel4.Controls.Add(Me.SaveAdd)
		Me.Panel4.Controls.Add(Me.Save)
		Me.Panel4.Controls.Add(Me.cerrar)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(412, 27)
		Me.Panel4.TabIndex = 433
		'
		'Label14
		'
		Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label14.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.ForeColor = System.Drawing.Color.White
		Me.Label14.Location = New System.Drawing.Point(0, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(300, 27)
		Me.Label14.TabIndex = 437
		Me.Label14.Text = "NUEVO RECEPTOR"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'cerrar
		'
		Me.cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.cerrar.Dock = System.Windows.Forms.DockStyle.Right
		Me.cerrar.FlatAppearance.BorderSize = 0
		Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cerrar.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cerrar.ForeColor = System.Drawing.Color.White
		Me.cerrar.Location = New System.Drawing.Point(380, 0)
		Me.cerrar.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.cerrar.Name = "cerrar"
		Me.cerrar.Size = New System.Drawing.Size(32, 27)
		Me.cerrar.TabIndex = 434
		Me.cerrar.Text = ""
		Me.cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.cerrar.UseVisualStyleBackColor = False
		'
		'bs_responsable
		'
		'
		'modelo
		'
		Me.modelo.Location = New System.Drawing.Point(114, 205)
		Me.modelo.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
		Me.modelo.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
		Me.modelo.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
		Me.modelo.Name = "modelo"
		Me.modelo.Size = New System.Drawing.Size(80, 27)
		Me.modelo.TabIndex = 482
		Me.modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.modelo.Value = New Decimal(New Integer() {1900, 0, 0, 0})
		'
		'ModCombustibleReceptor
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(412, 362)
		Me.Controls.Add(Me.FlowLayoutPanel3)
		Me.Controls.Add(Me.Panel4)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "ModCombustibleReceptor"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		Me.Panel4.ResumeLayout(False)
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.modelo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents alta As DateTimePicker
	Friend WithEvents Label8 As Label
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Save As Button
	Friend WithEvents cerrar As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents cuenta As ComboBox
	Friend WithEvents Label10 As Label
	Public WithEvents bs_receptor As BindingSource
	Friend WithEvents SaveAdd As Button
	Friend WithEvents marca As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents categoria As ComboBox
	Friend WithEvents Label9 As Label
	Friend WithEvents AddCategoria As Button
	Friend WithEvents DelCategoria As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents dominio As MaskedTextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents argentina As RadioButton
	Friend WithEvents mercosur As RadioButton
	Friend WithEvents Label5 As Label
	Friend WithEvents baja As DateTimePicker
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents observaciones As TextBox
	Friend WithEvents Label14 As Label
	Public WithEvents bs_categoria As BindingSource
	Public WithEvents bs_cuenta As BindingSource
	Friend WithEvents vehiculo As CheckBox
	Friend WithEvents cuil_responsable As TextBox
	Friend WithEvents responsable As ComboBox
	Friend WithEvents AddResponsable As Button
	Friend WithEvents DelResponsable As Button
	Public WithEvents bs_responsable As BindingSource
	Friend WithEvents modelo As NumericUpDown
End Class
