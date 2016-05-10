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
        Me.GrupoDP = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gen = New System.Windows.Forms.ComboBox()
        Me.dni_a_cuil = New System.Windows.Forms.Button()
        Me.cuil_switch = New System.Windows.Forms.Button()
        Me.razon = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cuil = New System.Windows.Forms.MaskedTextBox()
        Me.dni = New System.Windows.Forms.MaskedTextBox()
        Me.persona_id = New System.Windows.Forms.TextBox()
        Me.prof_id = New System.Windows.Forms.TextBox()
        Me.proveedor_id = New System.Windows.Forms.TextBox()
        Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GuardarCambios = New System.Windows.Forms.Button()
        Me.SwitchDP = New System.Windows.Forms.Button()
        Me.SwitchDO = New System.Windows.Forms.Button()
        Me.GrupoDO = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DelDomicilio = New System.Windows.Forms.Button()
        Me.AddDomicilio = New System.Windows.Forms.Button()
        Me.GrupoMC = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tele = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.SwitchMC = New System.Windows.Forms.Button()
        Me.GrupoDA = New System.Windows.Forms.Panel()
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
        Me.SwitchDA = New System.Windows.Forms.Button()
        Me.SwitchAC = New System.Windows.Forms.Button()
        Me.GrupoAC = New System.Windows.Forms.FlowLayoutPanel()
        Me.ModActas = New System.Windows.Forms.Button()
        Me.GrupoDP.SuspendLayout()
        Me.grupo_mod.SuspendLayout()
        Me.GrupoDO.SuspendLayout()
        Me.GrupoMC.SuspendLayout()
        Me.GrupoDA.SuspendLayout()
        Me.GrupoAC.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoDP
        '
        Me.GrupoDP.BackColor = System.Drawing.Color.Silver
        Me.GrupoDP.Controls.Add(Me.Label17)
        Me.GrupoDP.Controls.Add(Me.gen)
        Me.GrupoDP.Controls.Add(Me.dni_a_cuil)
        Me.GrupoDP.Controls.Add(Me.cuil_switch)
        Me.GrupoDP.Controls.Add(Me.razon)
        Me.GrupoDP.Controls.Add(Me.Label14)
        Me.GrupoDP.Controls.Add(Me.Label24)
        Me.GrupoDP.Controls.Add(Me.cuil)
        Me.GrupoDP.Controls.Add(Me.dni)
        Me.GrupoDP.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrupoDP.Location = New System.Drawing.Point(0, 30)
        Me.GrupoDP.Name = "GrupoDP"
        Me.GrupoDP.Size = New System.Drawing.Size(524, 84)
        Me.GrupoDP.TabIndex = 377
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(229, 51)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 19)
        Me.Label17.TabIndex = 229
        Me.Label17.Text = "Sexo"
        '
        'gen
        '
        Me.gen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gen.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.gen.FormattingEnabled = True
        Me.gen.Items.AddRange(New Object() {"M", "F", "N"})
        Me.gen.Location = New System.Drawing.Point(271, 46)
        Me.gen.Margin = New System.Windows.Forms.Padding(2)
        Me.gen.Name = "gen"
        Me.gen.Size = New System.Drawing.Size(36, 27)
        Me.gen.TabIndex = 226
        '
        'dni_a_cuil
        '
        Me.dni_a_cuil.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dni_a_cuil.FlatAppearance.BorderSize = 0
        Me.dni_a_cuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dni_a_cuil.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.dni_a_cuil.ForeColor = System.Drawing.Color.White
        Me.dni_a_cuil.Location = New System.Drawing.Point(316, 46)
        Me.dni_a_cuil.Margin = New System.Windows.Forms.Padding(2)
        Me.dni_a_cuil.Name = "dni_a_cuil"
        Me.dni_a_cuil.Size = New System.Drawing.Size(106, 27)
        Me.dni_a_cuil.TabIndex = 225
        Me.dni_a_cuil.Text = "Calcular CUIL"
        Me.dni_a_cuil.UseVisualStyleBackColor = False
        '
        'cuil_switch
        '
        Me.cuil_switch.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.cuil_switch.FlatAppearance.BorderSize = 0
        Me.cuil_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cuil_switch.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.cuil_switch.ForeColor = System.Drawing.Color.White
        Me.cuil_switch.Location = New System.Drawing.Point(428, 46)
        Me.cuil_switch.Margin = New System.Windows.Forms.Padding(2)
        Me.cuil_switch.Name = "cuil_switch"
        Me.cuil_switch.Size = New System.Drawing.Size(87, 27)
        Me.cuil_switch.TabIndex = 227
        Me.cuil_switch.Text = "Ver CUIL"
        Me.cuil_switch.UseVisualStyleBackColor = False
        '
        'razon
        '
        Me.razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.razon.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.razon.Location = New System.Drawing.Point(105, 9)
        Me.razon.Margin = New System.Windows.Forms.Padding(4)
        Me.razon.MaxLength = 100
        Me.razon.Name = "razon"
        Me.razon.Size = New System.Drawing.Size(411, 27)
        Me.razon.TabIndex = 224
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(27, 51)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 19)
        Me.Label14.TabIndex = 219
        Me.Label14.Text = "CUIL / DNI"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 15)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 19)
        Me.Label24.TabIndex = 218
        Me.Label24.Text = "Razón Social"
        '
        'cuil
        '
        Me.cuil.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.cuil.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuil.Location = New System.Drawing.Point(105, 46)
        Me.cuil.Margin = New System.Windows.Forms.Padding(4)
        Me.cuil.Mask = "99-99999999-9"
        Me.cuil.Name = "cuil"
        Me.cuil.Size = New System.Drawing.Size(117, 27)
        Me.cuil.TabIndex = 220
        Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'dni
        '
        Me.dni.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni.Location = New System.Drawing.Point(105, 46)
        Me.dni.Mask = "99999999"
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(117, 27)
        Me.dni.TabIndex = 228
        Me.dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'persona_id
        '
        Me.persona_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.persona_id.Location = New System.Drawing.Point(159, 7)
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
        Me.prof_id.Location = New System.Drawing.Point(190, 7)
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
        Me.proveedor_id.Location = New System.Drawing.Point(221, 7)
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
        Me.grupo_mod.Controls.Add(Me.proveedor_id)
        Me.grupo_mod.Controls.Add(Me.prof_id)
        Me.grupo_mod.Controls.Add(Me.persona_id)
        Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.grupo_mod.Location = New System.Drawing.Point(0, 481)
        Me.grupo_mod.Name = "grupo_mod"
        Me.grupo_mod.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.grupo_mod.Size = New System.Drawing.Size(524, 40)
        Me.grupo_mod.TabIndex = 395
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cancelar.Location = New System.Drawing.Point(420, 7)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(96, 26)
        Me.Cancelar.TabIndex = 345
        Me.Cancelar.Text = "CANCELAR"
        Me.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'GuardarCambios
        '
        Me.GuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GuardarCambios.FlatAppearance.BorderSize = 0
        Me.GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarCambios.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.GuardarCambios.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GuardarCambios.Location = New System.Drawing.Point(252, 7)
        Me.GuardarCambios.Name = "GuardarCambios"
        Me.GuardarCambios.Size = New System.Drawing.Size(162, 26)
        Me.GuardarCambios.TabIndex = 344
        Me.GuardarCambios.Text = "GUARDAR CAMBIOS"
        Me.GuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GuardarCambios.UseVisualStyleBackColor = False
        '
        'SwitchDP
        '
        Me.SwitchDP.BackColor = System.Drawing.Color.DimGray
        Me.SwitchDP.Dock = System.Windows.Forms.DockStyle.Top
        Me.SwitchDP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SwitchDP.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.SwitchDP.ForeColor = System.Drawing.Color.White
        Me.SwitchDP.Location = New System.Drawing.Point(0, 0)
        Me.SwitchDP.Name = "SwitchDP"
        Me.SwitchDP.Size = New System.Drawing.Size(524, 30)
        Me.SwitchDP.TabIndex = 396
        Me.SwitchDP.Text = "[-] DATOS PERSONALES"
        Me.SwitchDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SwitchDP.UseVisualStyleBackColor = False
        '
        'SwitchDO
        '
        Me.SwitchDO.BackColor = System.Drawing.Color.DimGray
        Me.SwitchDO.Dock = System.Windows.Forms.DockStyle.Top
        Me.SwitchDO.FlatAppearance.BorderSize = 0
        Me.SwitchDO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SwitchDO.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.SwitchDO.ForeColor = System.Drawing.Color.White
        Me.SwitchDO.Location = New System.Drawing.Point(0, 114)
        Me.SwitchDO.Name = "SwitchDO"
        Me.SwitchDO.Size = New System.Drawing.Size(524, 30)
        Me.SwitchDO.TabIndex = 397
        Me.SwitchDO.Text = "[-] DOMICILIO"
        Me.SwitchDO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SwitchDO.UseVisualStyleBackColor = False
        '
        'GrupoDO
        '
        Me.GrupoDO.BackColor = System.Drawing.Color.Silver
        Me.GrupoDO.Controls.Add(Me.TabControl1)
        Me.GrupoDO.Controls.Add(Me.DelDomicilio)
        Me.GrupoDO.Controls.Add(Me.AddDomicilio)
        Me.GrupoDO.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrupoDO.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.GrupoDO.Location = New System.Drawing.Point(0, 144)
        Me.GrupoDO.Name = "GrupoDO"
        Me.GrupoDO.Size = New System.Drawing.Size(524, 194)
        Me.GrupoDO.TabIndex = 403
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(519, 152)
        Me.TabControl1.TabIndex = 403
        '
        'DelDomicilio
        '
        Me.DelDomicilio.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.DelDomicilio.FlatAppearance.BorderSize = 0
        Me.DelDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelDomicilio.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.DelDomicilio.ForeColor = System.Drawing.Color.White
        Me.DelDomicilio.Location = New System.Drawing.Point(342, 160)
        Me.DelDomicilio.Margin = New System.Windows.Forms.Padding(2, 2, 5, 2)
        Me.DelDomicilio.Name = "DelDomicilio"
        Me.DelDomicilio.Size = New System.Drawing.Size(177, 27)
        Me.DelDomicilio.TabIndex = 406
        Me.DelDomicilio.Text = "Eliminar Seleccionado"
        Me.DelDomicilio.UseVisualStyleBackColor = False
        '
        'AddDomicilio
        '
        Me.AddDomicilio.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.AddDomicilio.FlatAppearance.BorderSize = 0
        Me.AddDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddDomicilio.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.AddDomicilio.ForeColor = System.Drawing.Color.White
        Me.AddDomicilio.Location = New System.Drawing.Point(251, 160)
        Me.AddDomicilio.Margin = New System.Windows.Forms.Padding(2)
        Me.AddDomicilio.Name = "AddDomicilio"
        Me.AddDomicilio.Size = New System.Drawing.Size(87, 27)
        Me.AddDomicilio.TabIndex = 405
        Me.AddDomicilio.Text = "Agregar"
        Me.AddDomicilio.UseVisualStyleBackColor = False
        '
        'GrupoMC
        '
        Me.GrupoMC.BackColor = System.Drawing.Color.Silver
        Me.GrupoMC.Controls.Add(Me.Label8)
        Me.GrupoMC.Controls.Add(Me.Label15)
        Me.GrupoMC.Controls.Add(Me.tele)
        Me.GrupoMC.Controls.Add(Me.email)
        Me.GrupoMC.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrupoMC.Location = New System.Drawing.Point(0, 368)
        Me.GrupoMC.Name = "GrupoMC"
        Me.GrupoMC.Size = New System.Drawing.Size(524, 46)
        Me.GrupoMC.TabIndex = 406
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
        'SwitchMC
        '
        Me.SwitchMC.BackColor = System.Drawing.Color.DimGray
        Me.SwitchMC.Dock = System.Windows.Forms.DockStyle.Top
        Me.SwitchMC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SwitchMC.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.SwitchMC.ForeColor = System.Drawing.Color.White
        Me.SwitchMC.Location = New System.Drawing.Point(0, 338)
        Me.SwitchMC.Name = "SwitchMC"
        Me.SwitchMC.Size = New System.Drawing.Size(524, 30)
        Me.SwitchMC.TabIndex = 407
        Me.SwitchMC.Text = "[+] MEDIOS DE CONTACTO"
        Me.SwitchMC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SwitchMC.UseVisualStyleBackColor = False
        '
        'GrupoDA
        '
        Me.GrupoDA.BackColor = System.Drawing.Color.Silver
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
        Me.GrupoDA.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrupoDA.Location = New System.Drawing.Point(0, 444)
        Me.GrupoDA.Name = "GrupoDA"
        Me.GrupoDA.Size = New System.Drawing.Size(524, 111)
        Me.GrupoDA.TabIndex = 408
        Me.GrupoDA.Visible = False
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
        'SwitchDA
        '
        Me.SwitchDA.BackColor = System.Drawing.Color.DimGray
        Me.SwitchDA.Dock = System.Windows.Forms.DockStyle.Top
        Me.SwitchDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SwitchDA.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.SwitchDA.ForeColor = System.Drawing.Color.White
        Me.SwitchDA.Location = New System.Drawing.Point(0, 414)
        Me.SwitchDA.Name = "SwitchDA"
        Me.SwitchDA.Size = New System.Drawing.Size(524, 30)
        Me.SwitchDA.TabIndex = 409
        Me.SwitchDA.Text = "[+] DATOS ADICIONALES"
        Me.SwitchDA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SwitchDA.UseVisualStyleBackColor = False
        '
        'SwitchAC
        '
        Me.SwitchAC.BackColor = System.Drawing.Color.DimGray
        Me.SwitchAC.Dock = System.Windows.Forms.DockStyle.Top
        Me.SwitchAC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SwitchAC.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.SwitchAC.ForeColor = System.Drawing.Color.White
        Me.SwitchAC.Location = New System.Drawing.Point(0, 555)
        Me.SwitchAC.Name = "SwitchAC"
        Me.SwitchAC.Size = New System.Drawing.Size(524, 30)
        Me.SwitchAC.TabIndex = 410
        Me.SwitchAC.Text = "[+] ACTAS"
        Me.SwitchAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SwitchAC.UseVisualStyleBackColor = False
        '
        'GrupoAC
        '
        Me.GrupoAC.BackColor = System.Drawing.Color.Silver
        Me.GrupoAC.Controls.Add(Me.ModActas)
        Me.GrupoAC.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrupoAC.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.GrupoAC.Location = New System.Drawing.Point(0, 585)
        Me.GrupoAC.Name = "GrupoAC"
        Me.GrupoAC.Size = New System.Drawing.Size(524, 37)
        Me.GrupoAC.TabIndex = 411
        Me.GrupoAC.Visible = False
        '
        'ModActas
        '
        Me.ModActas.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.ModActas.FlatAppearance.BorderSize = 0
        Me.ModActas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModActas.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ModActas.ForeColor = System.Drawing.Color.White
        Me.ModActas.Location = New System.Drawing.Point(384, 5)
        Me.ModActas.Margin = New System.Windows.Forms.Padding(3, 5, 8, 3)
        Me.ModActas.Name = "ModActas"
        Me.ModActas.Size = New System.Drawing.Size(132, 27)
        Me.ModActas.TabIndex = 407
        Me.ModActas.Text = "Consultar Actas"
        Me.ModActas.UseVisualStyleBackColor = False
        '
        'ModPersona
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(524, 521)
        Me.Controls.Add(Me.grupo_mod)
        Me.Controls.Add(Me.GrupoAC)
        Me.Controls.Add(Me.SwitchAC)
        Me.Controls.Add(Me.GrupoDA)
        Me.Controls.Add(Me.SwitchDA)
        Me.Controls.Add(Me.GrupoMC)
        Me.Controls.Add(Me.SwitchMC)
        Me.Controls.Add(Me.GrupoDO)
        Me.Controls.Add(Me.SwitchDO)
        Me.Controls.Add(Me.GrupoDP)
        Me.Controls.Add(Me.SwitchDP)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximumSize = New System.Drawing.Size(540, 1000)
        Me.MinimumSize = New System.Drawing.Size(540, 560)
        Me.Name = "ModPersona"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVA PERSONA"
        Me.GrupoDP.ResumeLayout(False)
        Me.GrupoDP.PerformLayout()
        Me.grupo_mod.ResumeLayout(False)
        Me.grupo_mod.PerformLayout()
        Me.GrupoDO.ResumeLayout(False)
        Me.GrupoMC.ResumeLayout(False)
        Me.GrupoMC.PerformLayout()
        Me.GrupoDA.ResumeLayout(False)
        Me.GrupoDA.PerformLayout()
        Me.GrupoAC.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrupoDP As System.Windows.Forms.Panel
    Friend WithEvents persona_id As System.Windows.Forms.TextBox
    Friend WithEvents gen As System.Windows.Forms.ComboBox
    Friend WithEvents dni_a_cuil As System.Windows.Forms.Button
    Friend WithEvents cuil_switch As System.Windows.Forms.Button
    Friend WithEvents razon As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents proveedor_id As System.Windows.Forms.TextBox
    Friend WithEvents prof_id As System.Windows.Forms.TextBox
    Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents GuardarCambios As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SwitchDP As System.Windows.Forms.Button
    Friend WithEvents SwitchDO As System.Windows.Forms.Button
    Friend WithEvents GrupoDO As FlowLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AddDomicilio As Button
    Friend WithEvents DelDomicilio As Button
    Friend WithEvents GrupoMC As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tele As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents SwitchMC As Button
    Friend WithEvents GrupoDA As Panel
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
    Friend WithEvents SwitchDA As Button
    Friend WithEvents titulo As ComboBox
    Friend WithEvents SwitchAC As Button
    Friend WithEvents GrupoAC As FlowLayoutPanel
    Friend WithEvents ModActas As Button
End Class
