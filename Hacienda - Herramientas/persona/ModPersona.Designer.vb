<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.persona_id = New System.Windows.Forms.TextBox()
		Me.prof_id = New System.Windows.Forms.TextBox()
		Me.proveedor_id = New System.Windows.Forms.TextBox()
		Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
		Me.Cancelar = New System.Windows.Forms.Button()
		Me.GuardarCambios = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.MainTabControl = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabDatosPersonales1 = New Sigm.tabDatosPersonales()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.GrupoDO = New System.Windows.Forms.FlowLayoutPanel()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.DelDomicilio = New System.Windows.Forms.Button()
		Me.AddDomicilio = New System.Windows.Forms.Button()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.GrupoMC = New System.Windows.Forms.Panel()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.tele = New System.Windows.Forms.TextBox()
		Me.email = New System.Windows.Forms.TextBox()
		Me.TabPage4 = New System.Windows.Forms.TabPage()
		Me.GrupoDA = New System.Windows.Forms.Panel()
		Me.ModActas = New System.Windows.Forms.Button()
		Me.titulo = New System.Windows.Forms.ComboBox()
		Me.et_resp = New System.Windows.Forms.Label()
		Me.et_defu = New System.Windows.Forms.Label()
		Me.responsable = New System.Windows.Forms.ComboBox()
		Me.esProveedor = New System.Windows.Forms.CheckBox()
		Me.esProfesional = New System.Windows.Forms.CheckBox()
		Me.et_matr = New System.Windows.Forms.Label()
		Me.cargar_defu = New System.Windows.Forms.Button()
		Me.matr = New System.Windows.Forms.TextBox()
		Me.ruta_defuncion = New System.Windows.Forms.TextBox()
		Me.esDifunto = New System.Windows.Forms.CheckBox()
		Me.grupo_mod.SuspendLayout()
		Me.MainTabControl.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.GrupoDO.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		Me.GrupoMC.SuspendLayout()
		Me.TabPage4.SuspendLayout()
		Me.GrupoDA.SuspendLayout()
		Me.SuspendLayout()
		'
		'persona_id
		'
		Me.persona_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.persona_id.Location = New System.Drawing.Point(149, 3)
		Me.persona_id.MaxLength = 128
		Me.persona_id.Name = "persona_id"
		Me.persona_id.ReadOnly = True
		Me.persona_id.Size = New System.Drawing.Size(25, 27)
		Me.persona_id.TabIndex = 373
		Me.persona_id.Text = "0"
		'
		'prof_id
		'
		Me.prof_id.BackColor = System.Drawing.Color.DodgerBlue
		Me.prof_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.prof_id.Location = New System.Drawing.Point(180, 3)
		Me.prof_id.MaxLength = 128
		Me.prof_id.Name = "prof_id"
		Me.prof_id.ReadOnly = True
		Me.prof_id.Size = New System.Drawing.Size(25, 27)
		Me.prof_id.TabIndex = 393
		Me.prof_id.Text = "0"
		'
		'proveedor_id
		'
		Me.proveedor_id.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.proveedor_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.proveedor_id.Location = New System.Drawing.Point(211, 3)
		Me.proveedor_id.MaxLength = 128
		Me.proveedor_id.Name = "proveedor_id"
		Me.proveedor_id.ReadOnly = True
		Me.proveedor_id.Size = New System.Drawing.Size(25, 27)
		Me.proveedor_id.TabIndex = 395
		Me.proveedor_id.Text = "0"
		'
		'grupo_mod
		'
		Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
		Me.grupo_mod.Controls.Add(Me.Cancelar)
		Me.grupo_mod.Controls.Add(Me.GuardarCambios)
		Me.grupo_mod.Controls.Add(Me.Button1)
		Me.grupo_mod.Controls.Add(Me.proveedor_id)
		Me.grupo_mod.Controls.Add(Me.prof_id)
		Me.grupo_mod.Controls.Add(Me.persona_id)
		Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.grupo_mod.Location = New System.Drawing.Point(0, 225)
		Me.grupo_mod.Margin = New System.Windows.Forms.Padding(0)
		Me.grupo_mod.Name = "grupo_mod"
		Me.grupo_mod.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.grupo_mod.Size = New System.Drawing.Size(540, 30)
		Me.grupo_mod.TabIndex = 395
		'
		'Cancelar
		'
		Me.Cancelar.AutoSize = True
		Me.Cancelar.FlatAppearance.BorderSize = 0
		Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Cancelar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.Cancelar.Location = New System.Drawing.Point(439, 0)
		Me.Cancelar.Margin = New System.Windows.Forms.Padding(0)
		Me.Cancelar.Name = "Cancelar"
		Me.Cancelar.Size = New System.Drawing.Size(96, 29)
		Me.Cancelar.TabIndex = 345
		Me.Cancelar.Text = "CANCELAR"
		Me.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Cancelar.UseVisualStyleBackColor = False
		'
		'GuardarCambios
		'
		Me.GuardarCambios.AutoSize = True
		Me.GuardarCambios.FlatAppearance.BorderSize = 0
		Me.GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GuardarCambios.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.GuardarCambios.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.GuardarCambios.Location = New System.Drawing.Point(335, 0)
		Me.GuardarCambios.Margin = New System.Windows.Forms.Padding(0)
		Me.GuardarCambios.Name = "GuardarCambios"
		Me.GuardarCambios.Size = New System.Drawing.Size(104, 29)
		Me.GuardarCambios.TabIndex = 344
		Me.GuardarCambios.Text = "SIGUIENTE >"
		Me.GuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.GuardarCambios.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.AutoSize = True
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.Button1.Location = New System.Drawing.Point(239, 0)
		Me.Button1.Margin = New System.Windows.Forms.Padding(0)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(96, 29)
		Me.Button1.TabIndex = 396
		Me.Button1.Text = "< ATRAS"
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button1.UseVisualStyleBackColor = False
		'
		'MainTabControl
		'
		Me.MainTabControl.Controls.Add(Me.TabPage1)
		Me.MainTabControl.Controls.Add(Me.TabPage2)
		Me.MainTabControl.Controls.Add(Me.TabPage3)
		Me.MainTabControl.Controls.Add(Me.TabPage4)
		Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
		Me.MainTabControl.Name = "MainTabControl"
		Me.MainTabControl.SelectedIndex = 0
		Me.MainTabControl.Size = New System.Drawing.Size(540, 225)
		Me.MainTabControl.TabIndex = 412
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.TabDatosPersonales1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 28)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(532, 193)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "TabPage1"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'TabDatosPersonales1
		'
		Me.TabDatosPersonales1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.TabDatosPersonales1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabDatosPersonales1.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabDatosPersonales1.Location = New System.Drawing.Point(3, 3)
		Me.TabDatosPersonales1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabDatosPersonales1.Name = "TabDatosPersonales1"
		Me.TabDatosPersonales1.Size = New System.Drawing.Size(526, 187)
		Me.TabDatosPersonales1.TabIndex = 0
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.GrupoDO)
		Me.TabPage2.Location = New System.Drawing.Point(4, 28)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(532, 193)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "TabPage2"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'GrupoDO
		'
		Me.GrupoDO.BackColor = System.Drawing.SystemColors.ControlDark
		Me.GrupoDO.Controls.Add(Me.TabControl1)
		Me.GrupoDO.Controls.Add(Me.DelDomicilio)
		Me.GrupoDO.Controls.Add(Me.AddDomicilio)
		Me.GrupoDO.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GrupoDO.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.GrupoDO.Location = New System.Drawing.Point(3, 3)
		Me.GrupoDO.Name = "GrupoDO"
		Me.GrupoDO.Size = New System.Drawing.Size(526, 187)
		Me.GrupoDO.TabIndex = 404
		'
		'TabControl1
		'
		Me.TabControl1.Location = New System.Drawing.Point(4, 3)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(519, 152)
		Me.TabControl1.TabIndex = 403
		'
		'DelDomicilio
		'
		Me.DelDomicilio.FlatAppearance.BorderSize = 0
		Me.DelDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelDomicilio.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.DelDomicilio.ForeColor = System.Drawing.Color.White
		Me.DelDomicilio.Location = New System.Drawing.Point(344, 160)
		Me.DelDomicilio.Margin = New System.Windows.Forms.Padding(2, 2, 5, 2)
		Me.DelDomicilio.Name = "DelDomicilio"
		Me.DelDomicilio.Size = New System.Drawing.Size(177, 27)
		Me.DelDomicilio.TabIndex = 406
		Me.DelDomicilio.Text = "Eliminar Seleccionado"
		Me.DelDomicilio.UseVisualStyleBackColor = False
		'
		'AddDomicilio
		'
		Me.AddDomicilio.FlatAppearance.BorderSize = 0
		Me.AddDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddDomicilio.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.AddDomicilio.ForeColor = System.Drawing.Color.White
		Me.AddDomicilio.Location = New System.Drawing.Point(253, 160)
		Me.AddDomicilio.Margin = New System.Windows.Forms.Padding(2)
		Me.AddDomicilio.Name = "AddDomicilio"
		Me.AddDomicilio.Size = New System.Drawing.Size(87, 27)
		Me.AddDomicilio.TabIndex = 405
		Me.AddDomicilio.Text = "Agregar"
		Me.AddDomicilio.UseVisualStyleBackColor = False
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.GrupoMC)
		Me.TabPage3.Location = New System.Drawing.Point(4, 28)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(532, 193)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "TabPage3"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'GrupoMC
		'
		Me.GrupoMC.BackColor = System.Drawing.Color.Silver
		Me.GrupoMC.Controls.Add(Me.Label8)
		Me.GrupoMC.Controls.Add(Me.Label15)
		Me.GrupoMC.Controls.Add(Me.tele)
		Me.GrupoMC.Controls.Add(Me.email)
		Me.GrupoMC.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GrupoMC.Location = New System.Drawing.Point(3, 3)
		Me.GrupoMC.Name = "GrupoMC"
		Me.GrupoMC.Size = New System.Drawing.Size(526, 187)
		Me.GrupoMC.TabIndex = 407
		Me.GrupoMC.Visible = False
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(24, 12)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(65, 19)
		Me.Label8.TabIndex = 227
		Me.Label8.Text = "Teléfono"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(259, 12)
		Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(51, 19)
		Me.Label15.TabIndex = 206
		Me.Label15.Text = "E-Mail"
		'
		'tele
		'
		Me.tele.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tele.Location = New System.Drawing.Point(92, 8)
		Me.tele.Margin = New System.Windows.Forms.Padding(4)
		Me.tele.MaxLength = 64
		Me.tele.Name = "tele"
		Me.tele.Size = New System.Drawing.Size(159, 27)
		Me.tele.TabIndex = 208
		'
		'email
		'
		Me.email.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.email.Location = New System.Drawing.Point(313, 8)
		Me.email.Margin = New System.Windows.Forms.Padding(4)
		Me.email.MaxLength = 64
		Me.email.Name = "email"
		Me.email.Size = New System.Drawing.Size(202, 27)
		Me.email.TabIndex = 207
		'
		'TabPage4
		'
		Me.TabPage4.Controls.Add(Me.GrupoDA)
		Me.TabPage4.Location = New System.Drawing.Point(4, 28)
		Me.TabPage4.Name = "TabPage4"
		Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage4.Size = New System.Drawing.Size(532, 193)
		Me.TabPage4.TabIndex = 3
		Me.TabPage4.Text = "TabPage4"
		Me.TabPage4.UseVisualStyleBackColor = True
		'
		'GrupoDA
		'
		Me.GrupoDA.BackColor = System.Drawing.Color.Silver
		Me.GrupoDA.Controls.Add(Me.ModActas)
		Me.GrupoDA.Controls.Add(Me.titulo)
		Me.GrupoDA.Controls.Add(Me.et_resp)
		Me.GrupoDA.Controls.Add(Me.et_defu)
		Me.GrupoDA.Controls.Add(Me.responsable)
		Me.GrupoDA.Controls.Add(Me.esProveedor)
		Me.GrupoDA.Controls.Add(Me.esProfesional)
		Me.GrupoDA.Controls.Add(Me.et_matr)
		Me.GrupoDA.Controls.Add(Me.cargar_defu)
		Me.GrupoDA.Controls.Add(Me.matr)
		Me.GrupoDA.Controls.Add(Me.ruta_defuncion)
		Me.GrupoDA.Controls.Add(Me.esDifunto)
		Me.GrupoDA.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GrupoDA.Location = New System.Drawing.Point(3, 3)
		Me.GrupoDA.Name = "GrupoDA"
		Me.GrupoDA.Size = New System.Drawing.Size(526, 187)
		Me.GrupoDA.TabIndex = 409
		Me.GrupoDA.Visible = False
		'
		'ModActas
		'
		Me.ModActas.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.ModActas.FlatAppearance.BorderSize = 0
		Me.ModActas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ModActas.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.ModActas.ForeColor = System.Drawing.Color.White
		Me.ModActas.Location = New System.Drawing.Point(6, 108)
		Me.ModActas.Margin = New System.Windows.Forms.Padding(3, 5, 8, 3)
		Me.ModActas.Name = "ModActas"
		Me.ModActas.Size = New System.Drawing.Size(132, 27)
		Me.ModActas.TabIndex = 408
		Me.ModActas.Text = "Consultar Actas"
		Me.ModActas.UseVisualStyleBackColor = False
		'
		'titulo
		'
		Me.titulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.titulo.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.titulo.FormattingEnabled = True
		Me.titulo.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado, Ley Nº 19.640", "IVA Resp. Insc., Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
		Me.titulo.Location = New System.Drawing.Point(115, 42)
		Me.titulo.Name = "titulo"
		Me.titulo.Size = New System.Drawing.Size(201, 27)
		Me.titulo.TabIndex = 399
		Me.titulo.Visible = False
		'
		'et_resp
		'
		Me.et_resp.AutoSize = True
		Me.et_resp.BackColor = System.Drawing.Color.Transparent
		Me.et_resp.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_resp.Location = New System.Drawing.Point(110, 78)
		Me.et_resp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.et_resp.Name = "et_resp"
		Me.et_resp.Size = New System.Drawing.Size(119, 19)
		Me.et_resp.TabIndex = 398
		Me.et_resp.Text = "Responsable IVA"
		Me.et_resp.Visible = False
		'
		'et_defu
		'
		Me.et_defu.AutoSize = True
		Me.et_defu.BackColor = System.Drawing.Color.Transparent
		Me.et_defu.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_defu.Location = New System.Drawing.Point(110, 14)
		Me.et_defu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.et_defu.Name = "et_defu"
		Me.et_defu.Size = New System.Drawing.Size(110, 19)
		Me.et_defu.TabIndex = 397
		Me.et_defu.Text = "Certificado Def."
		Me.et_defu.Visible = False
		'
		'responsable
		'
		Me.responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.responsable.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.responsable.FormattingEnabled = True
		Me.responsable.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado, Ley Nº 19.640", "IVA Resp. Insc., Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
		Me.responsable.Location = New System.Drawing.Point(230, 75)
		Me.responsable.Name = "responsable"
		Me.responsable.Size = New System.Drawing.Size(250, 27)
		Me.responsable.TabIndex = 396
		Me.responsable.Visible = False
		'
		'esProveedor
		'
		Me.esProveedor.AutoSize = True
		Me.esProveedor.BackColor = System.Drawing.Color.Transparent
		Me.esProveedor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.esProveedor.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.esProveedor.Location = New System.Drawing.Point(14, 76)
		Me.esProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.esProveedor.Name = "esProveedor"
		Me.esProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.esProveedor.Size = New System.Drawing.Size(94, 23)
		Me.esProveedor.TabIndex = 394
		Me.esProveedor.Text = "Proveedor"
		Me.esProveedor.UseVisualStyleBackColor = False
		'
		'esProfesional
		'
		Me.esProfesional.AutoSize = True
		Me.esProfesional.BackColor = System.Drawing.Color.Transparent
		Me.esProfesional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.esProfesional.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.esProfesional.Location = New System.Drawing.Point(6, 44)
		Me.esProfesional.Margin = New System.Windows.Forms.Padding(4)
		Me.esProfesional.Name = "esProfesional"
		Me.esProfesional.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.esProfesional.Size = New System.Drawing.Size(102, 23)
		Me.esProfesional.TabIndex = 389
		Me.esProfesional.Text = "Profesional"
		Me.esProfesional.UseVisualStyleBackColor = False
		'
		'et_matr
		'
		Me.et_matr.AutoSize = True
		Me.et_matr.BackColor = System.Drawing.Color.Transparent
		Me.et_matr.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_matr.Location = New System.Drawing.Point(321, 46)
		Me.et_matr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.et_matr.Name = "et_matr"
		Me.et_matr.Size = New System.Drawing.Size(70, 19)
		Me.et_matr.TabIndex = 388
		Me.et_matr.Text = "Matrícula"
		Me.et_matr.Visible = False
		'
		'cargar_defu
		'
		Me.cargar_defu.BackColor = System.Drawing.Color.Transparent
		Me.cargar_defu.BackgroundImage = Global.Sigm.My.Resources.Resources.abrir
		Me.cargar_defu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.cargar_defu.FlatAppearance.BorderSize = 0
		Me.cargar_defu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cargar_defu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cargar_defu.ForeColor = System.Drawing.Color.White
		Me.cargar_defu.Location = New System.Drawing.Point(486, 10)
		Me.cargar_defu.Margin = New System.Windows.Forms.Padding(0)
		Me.cargar_defu.Name = "cargar_defu"
		Me.cargar_defu.Size = New System.Drawing.Size(29, 29)
		Me.cargar_defu.TabIndex = 391
		Me.cargar_defu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cargar_defu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.cargar_defu.UseVisualStyleBackColor = False
		Me.cargar_defu.Visible = False
		'
		'matr
		'
		Me.matr.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.matr.Location = New System.Drawing.Point(393, 42)
		Me.matr.Margin = New System.Windows.Forms.Padding(4)
		Me.matr.MaxLength = 64
		Me.matr.Name = "matr"
		Me.matr.Size = New System.Drawing.Size(122, 27)
		Me.matr.TabIndex = 387
		Me.matr.Visible = False
		'
		'ruta_defuncion
		'
		Me.ruta_defuncion.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
		Me.ruta_defuncion.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ruta_defuncion.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.ruta_defuncion.Location = New System.Drawing.Point(230, 10)
		Me.ruta_defuncion.MaxLength = 512
		Me.ruta_defuncion.Name = "ruta_defuncion"
		Me.ruta_defuncion.ReadOnly = True
		Me.ruta_defuncion.Size = New System.Drawing.Size(250, 27)
		Me.ruta_defuncion.TabIndex = 390
		Me.ruta_defuncion.Visible = False
		'
		'esDifunto
		'
		Me.esDifunto.AutoSize = True
		Me.esDifunto.BackColor = System.Drawing.Color.Transparent
		Me.esDifunto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.esDifunto.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.esDifunto.Location = New System.Drawing.Point(28, 12)
		Me.esDifunto.Margin = New System.Windows.Forms.Padding(4)
		Me.esDifunto.Name = "esDifunto"
		Me.esDifunto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.esDifunto.Size = New System.Drawing.Size(80, 23)
		Me.esDifunto.TabIndex = 386
		Me.esDifunto.Text = " Difunto"
		Me.esDifunto.UseVisualStyleBackColor = False
		'
		'ModPersona
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.ClientSize = New System.Drawing.Size(540, 255)
		Me.Controls.Add(Me.MainTabControl)
		Me.Controls.Add(Me.grupo_mod)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(250, 250)
		Me.Name = "ModPersona"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NUEVA PERSONA"
		Me.grupo_mod.ResumeLayout(False)
		Me.grupo_mod.PerformLayout()
		Me.MainTabControl.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.GrupoDO.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		Me.GrupoMC.ResumeLayout(False)
		Me.GrupoMC.PerformLayout()
		Me.TabPage4.ResumeLayout(False)
		Me.GrupoDA.ResumeLayout(False)
		Me.GrupoDA.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents persona_id As System.Windows.Forms.TextBox
	Friend WithEvents proveedor_id As System.Windows.Forms.TextBox
	Friend WithEvents prof_id As System.Windows.Forms.TextBox
	Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents Cancelar As System.Windows.Forms.Button
	Friend WithEvents GuardarCambios As System.Windows.Forms.Button
	Friend WithEvents MainTabControl As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabDatosPersonales1 As tabDatosPersonales
	Friend WithEvents Button1 As Button
	Friend WithEvents GrupoDO As FlowLayoutPanel
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents DelDomicilio As Button
	Friend WithEvents AddDomicilio As Button
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents GrupoMC As Panel
	Friend WithEvents Label8 As Label
	Friend WithEvents Label15 As Label
	Friend WithEvents tele As TextBox
	Friend WithEvents email As TextBox
	Friend WithEvents TabPage4 As TabPage
	Friend WithEvents GrupoDA As Panel
	Friend WithEvents ModActas As Button
	Friend WithEvents titulo As ComboBox
	Friend WithEvents et_resp As Label
	Friend WithEvents et_defu As Label
	Friend WithEvents responsable As ComboBox
	Friend WithEvents esProveedor As CheckBox
	Friend WithEvents esProfesional As CheckBox
	Friend WithEvents et_matr As Label
	Friend WithEvents cargar_defu As Button
	Friend WithEvents matr As TextBox
	Friend WithEvents ruta_defuncion As TextBox
	Friend WithEvents esDifunto As CheckBox
End Class
