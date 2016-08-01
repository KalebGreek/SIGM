<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModExpediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModExpediente))
        Me.FormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaPreviaMunicipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newppe = New System.Windows.Forms.ToolStripMenuItem()
        Me.opendialog = New System.Windows.Forms.OpenFileDialog()
        Me.info0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.info1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.info2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grupo_exp = New System.Windows.Forms.TabControl()
        Me.tab_persona = New System.Windows.Forms.TabPage()
        Me.page_pers = New System.Windows.Forms.Panel()
        Me.consulta_resp = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.del_resp = New System.Windows.Forms.Button()
        Me.add_resp = New System.Windows.Forms.Button()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.titulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.mod_prof = New System.Windows.Forms.Button()
        Me.razon = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cuil = New System.Windows.Forms.MaskedTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.matricula = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tab_inmueble = New System.Windows.Forms.TabPage()
        Me.page_inmueble = New System.Windows.Forms.Panel()
        Me.consulta_inmueble = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.del_inmueble = New System.Windows.Forms.Button()
        Me.mod_inmueble = New System.Windows.Forms.Button()
        Me.add_inmueble = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.info_estado = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.info_cuil = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.info_titular = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.info_cuenta = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.info_uso = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.info_barrio = New System.Windows.Forms.Label()
        Me.info_ubicacion = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tab_expediente = New System.Windows.Forms.TabPage()
        Me.grupoExp = New System.Windows.Forms.Panel()
        Me.observaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.visado = New System.Windows.Forms.CheckBox()
        Me.fin_obra = New System.Windows.Forms.DateTimePicker()
        Me.tarea2 = New System.Windows.Forms.ComboBox()
        Me.tarea = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.ver_fin_obra = New System.Windows.Forms.Button()
        Me.cargar_fin_obra = New System.Windows.Forms.Button()
        Me.recibe = New System.Windows.Forms.ComboBox()
        Me.inicio_obra = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.check_fin_obra = New System.Windows.Forms.CheckBox()
        Me.et_fin_obra = New System.Windows.Forms.Label()
        Me.ruta_fin_obra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.top_menu = New System.Windows.Forms.MenuStrip()
        Me.PERSONASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INMUEBLESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.save = New System.Windows.Forms.ToolStripMenuItem()
        Me.print = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaratulaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiaDeExpedienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarDeudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.wrapper = New System.Windows.Forms.Panel()
        Me.bs_resp = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_catastro = New System.Windows.Forms.BindingSource(Me.components)
        Me.estado = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.expediente = New System.Windows.Forms.ToolStripStatusLabel()
        Me.temporal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.espacio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.user_id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.prof_id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.responsable_id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Help = New System.Windows.Forms.ToolTip(Me.components)
        Me.grupo_exp.SuspendLayout()
        Me.tab_persona.SuspendLayout()
        Me.page_pers.SuspendLayout()
        CType(Me.consulta_resp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.tab_inmueble.SuspendLayout()
        Me.page_inmueble.SuspendLayout()
        CType(Me.consulta_inmueble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tab_expediente.SuspendLayout()
        Me.grupoExp.SuspendLayout()
        Me.top_menu.SuspendLayout()
        Me.wrapper.SuspendLayout()
        CType(Me.bs_resp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_catastro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.estado.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormulariosToolStripMenuItem
        '
        Me.FormulariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPreviaMunicipalToolStripMenuItem, Me.newppe})
        Me.FormulariosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.FormulariosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FormulariosToolStripMenuItem.Name = "FormulariosToolStripMenuItem"
        Me.FormulariosToolStripMenuItem.Size = New System.Drawing.Size(131, 27)
        Me.FormulariosToolStripMenuItem.Text = "FORMULARIOS"
        '
        'NuevaPreviaMunicipalToolStripMenuItem
        '
        Me.NuevaPreviaMunicipalToolStripMenuItem.Name = "NuevaPreviaMunicipalToolStripMenuItem"
        Me.NuevaPreviaMunicipalToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.NuevaPreviaMunicipalToolStripMenuItem.Text = "Nueva Previa Municipal"
        '
        'newppe
        '
        Me.newppe.Name = "newppe"
        Me.newppe.Size = New System.Drawing.Size(249, 26)
        Me.newppe.Text = "Nuevo Formulario P.P.E."
        '
        'opendialog
        '
        Me.opendialog.FileName = "opendialog"
        '
        'info0
        '
        Me.info0.BackColor = System.Drawing.Color.Transparent
        Me.info0.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info0.Name = "info0"
        Me.info0.Size = New System.Drawing.Size(96, 19)
        Me.info0.Text = " Información:"
        '
        'info1
        '
        Me.info1.BackColor = System.Drawing.Color.Transparent
        Me.info1.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(18, 19)
        Me.info1.Text = "1"
        '
        'info2
        '
        Me.info2.BackColor = System.Drawing.Color.Transparent
        Me.info2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(17, 19)
        Me.info2.Text = "2"
        '
        'grupo_exp
        '
        Me.grupo_exp.Controls.Add(Me.tab_persona)
        Me.grupo_exp.Controls.Add(Me.tab_inmueble)
        Me.grupo_exp.Controls.Add(Me.tab_expediente)
        Me.grupo_exp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupo_exp.ItemSize = New System.Drawing.Size(1, 1)
        Me.grupo_exp.Location = New System.Drawing.Point(0, 25)
        Me.grupo_exp.Margin = New System.Windows.Forms.Padding(0)
        Me.grupo_exp.Name = "grupo_exp"
        Me.grupo_exp.Padding = New System.Drawing.Point(0, 0)
        Me.grupo_exp.SelectedIndex = 0
        Me.grupo_exp.Size = New System.Drawing.Size(609, 337)
        Me.grupo_exp.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.grupo_exp.TabIndex = 379
        Me.grupo_exp.TabStop = False
        '
        'tab_persona
        '
        Me.tab_persona.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tab_persona.Controls.Add(Me.page_pers)
        Me.tab_persona.Location = New System.Drawing.Point(4, 5)
        Me.tab_persona.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_persona.Name = "tab_persona"
        Me.tab_persona.Size = New System.Drawing.Size(601, 328)
        Me.tab_persona.TabIndex = 0
        Me.tab_persona.Text = "Personas"
        '
        'page_pers
        '
        Me.page_pers.BackColor = System.Drawing.Color.Gainsboro
        Me.page_pers.Controls.Add(Me.consulta_resp)
        Me.page_pers.Controls.Add(Me.Panel4)
        Me.page_pers.Controls.Add(Me.Label55)
        Me.page_pers.Controls.Add(Me.Panel3)
        Me.page_pers.Controls.Add(Me.Label29)
        Me.page_pers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.page_pers.Location = New System.Drawing.Point(0, 0)
        Me.page_pers.Name = "page_pers"
        Me.page_pers.Size = New System.Drawing.Size(601, 328)
        Me.page_pers.TabIndex = 148
        '
        'consulta_resp
        '
        Me.consulta_resp.AllowUserToAddRows = False
        Me.consulta_resp.AllowUserToDeleteRows = False
        Me.consulta_resp.AllowUserToResizeRows = False
        Me.consulta_resp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consulta_resp.Location = New System.Drawing.Point(0, 25)
        Me.consulta_resp.MultiSelect = False
        Me.consulta_resp.Name = "consulta_resp"
        Me.consulta_resp.ReadOnly = True
        Me.consulta_resp.RowHeadersVisible = False
        Me.consulta_resp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.consulta_resp.Size = New System.Drawing.Size(501, 174)
        Me.consulta_resp.TabIndex = 337
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.del_resp)
        Me.Panel4.Controls.Add(Me.add_resp)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(501, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 174)
        Me.Panel4.TabIndex = 344
        '
        'del_resp
        '
        Me.del_resp.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.del_resp.Dock = System.Windows.Forms.DockStyle.Top
        Me.del_resp.FlatAppearance.BorderSize = 0
        Me.del_resp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del_resp.ForeColor = System.Drawing.Color.White
        Me.del_resp.Location = New System.Drawing.Point(0, 29)
        Me.del_resp.Name = "del_resp"
        Me.del_resp.Size = New System.Drawing.Size(100, 29)
        Me.del_resp.TabIndex = 347
        Me.del_resp.Text = "ELIMINAR"
        Me.del_resp.UseVisualStyleBackColor = False
        '
        'add_resp
        '
        Me.add_resp.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.add_resp.Dock = System.Windows.Forms.DockStyle.Top
        Me.add_resp.FlatAppearance.BorderSize = 0
        Me.add_resp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_resp.ForeColor = System.Drawing.Color.White
        Me.add_resp.Location = New System.Drawing.Point(0, 0)
        Me.add_resp.Name = "add_resp"
        Me.add_resp.Size = New System.Drawing.Size(100, 29)
        Me.add_resp.TabIndex = 346
        Me.add_resp.Text = "AGREGAR"
        Me.add_resp.UseVisualStyleBackColor = False
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label55.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Firebrick
        Me.Label55.Location = New System.Drawing.Point(0, 199)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(601, 24)
        Me.Label55.TabIndex = 330
        Me.Label55.Text = "PROFESIONAL A CARGO"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.titulo)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.razon)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.cuil)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.matricula)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 223)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(601, 105)
        Me.Panel3.TabIndex = 342
        '
        'titulo
        '
        Me.titulo.BackColor = System.Drawing.SystemColors.Window
        Me.titulo.Location = New System.Drawing.Point(80, 35)
        Me.titulo.Name = "titulo"
        Me.titulo.ReadOnly = True
        Me.titulo.Size = New System.Drawing.Size(330, 27)
        Me.titulo.TabIndex = 351
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 350
        Me.Label4.Text = "Profesion"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.mod_prof)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(427, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(174, 105)
        Me.Panel6.TabIndex = 349
        '
        'mod_prof
        '
        Me.mod_prof.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.mod_prof.Dock = System.Windows.Forms.DockStyle.Top
        Me.mod_prof.FlatAppearance.BorderSize = 0
        Me.mod_prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mod_prof.ForeColor = System.Drawing.Color.White
        Me.mod_prof.Location = New System.Drawing.Point(0, 0)
        Me.mod_prof.Name = "mod_prof"
        Me.mod_prof.Size = New System.Drawing.Size(174, 29)
        Me.mod_prof.TabIndex = 348
        Me.mod_prof.Text = "MODIFICAR"
        Me.mod_prof.UseVisualStyleBackColor = False
        '
        'razon
        '
        Me.razon.BackColor = System.Drawing.SystemColors.Window
        Me.razon.Location = New System.Drawing.Point(80, 1)
        Me.razon.Name = "razon"
        Me.razon.ReadOnly = True
        Me.razon.Size = New System.Drawing.Size(330, 27)
        Me.razon.TabIndex = 345
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(36, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 19)
        Me.Label14.TabIndex = 344
        Me.Label14.Text = "CUIL"
        '
        'cuil
        '
        Me.cuil.BackColor = System.Drawing.SystemColors.Window
        Me.cuil.Location = New System.Drawing.Point(80, 69)
        Me.cuil.Mask = "99-99999999-9"
        Me.cuil.Name = "cuil"
        Me.cuil.ReadOnly = True
        Me.cuil.Size = New System.Drawing.Size(138, 27)
        Me.cuil.TabIndex = 346
        Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(29, 5)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 19)
        Me.Label24.TabIndex = 343
        Me.Label24.Text = "Razón"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(237, 75)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 19)
        Me.Label23.TabIndex = 342
        Me.Label23.Text = "Matrícula"
        '
        'matricula
        '
        Me.matricula.BackColor = System.Drawing.SystemColors.Window
        Me.matricula.Location = New System.Drawing.Point(309, 71)
        Me.matricula.MaxLength = 128
        Me.matricula.Name = "matricula"
        Me.matricula.ReadOnly = True
        Me.matricula.Size = New System.Drawing.Size(101, 27)
        Me.matricula.TabIndex = 347
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label29.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Firebrick
        Me.Label29.Location = New System.Drawing.Point(0, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(601, 25)
        Me.Label29.TabIndex = 345
        Me.Label29.Text = "RESPONSABLE/S"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tab_inmueble
        '
        Me.tab_inmueble.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tab_inmueble.Controls.Add(Me.page_inmueble)
        Me.tab_inmueble.Location = New System.Drawing.Point(4, 5)
        Me.tab_inmueble.Name = "tab_inmueble"
        Me.tab_inmueble.Size = New System.Drawing.Size(601, 328)
        Me.tab_inmueble.TabIndex = 1
        Me.tab_inmueble.Text = "Inmuebles"
        '
        'page_inmueble
        '
        Me.page_inmueble.BackColor = System.Drawing.Color.Gainsboro
        Me.page_inmueble.Controls.Add(Me.consulta_inmueble)
        Me.page_inmueble.Controls.Add(Me.Panel7)
        Me.page_inmueble.Controls.Add(Me.Panel8)
        Me.page_inmueble.Controls.Add(Me.Panel5)
        Me.page_inmueble.Controls.Add(Me.Label2)
        Me.page_inmueble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.page_inmueble.Location = New System.Drawing.Point(0, 0)
        Me.page_inmueble.Name = "page_inmueble"
        Me.page_inmueble.Size = New System.Drawing.Size(601, 328)
        Me.page_inmueble.TabIndex = 150
        '
        'consulta_inmueble
        '
        Me.consulta_inmueble.AllowUserToAddRows = False
        Me.consulta_inmueble.AllowUserToDeleteRows = False
        Me.consulta_inmueble.AllowUserToResizeRows = False
        Me.consulta_inmueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.consulta_inmueble.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consulta_inmueble.Location = New System.Drawing.Point(0, 25)
        Me.consulta_inmueble.MultiSelect = False
        Me.consulta_inmueble.Name = "consulta_inmueble"
        Me.consulta_inmueble.ReadOnly = True
        Me.consulta_inmueble.RowHeadersVisible = False
        Me.consulta_inmueble.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.consulta_inmueble.Size = New System.Drawing.Size(501, 157)
        Me.consulta_inmueble.TabIndex = 338
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.del_inmueble)
        Me.Panel7.Controls.Add(Me.mod_inmueble)
        Me.Panel7.Controls.Add(Me.add_inmueble)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(501, 25)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(100, 157)
        Me.Panel7.TabIndex = 930
        '
        'del_inmueble
        '
        Me.del_inmueble.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.del_inmueble.Dock = System.Windows.Forms.DockStyle.Top
        Me.del_inmueble.FlatAppearance.BorderSize = 0
        Me.del_inmueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del_inmueble.ForeColor = System.Drawing.Color.White
        Me.del_inmueble.Location = New System.Drawing.Point(0, 58)
        Me.del_inmueble.Name = "del_inmueble"
        Me.del_inmueble.Size = New System.Drawing.Size(100, 29)
        Me.del_inmueble.TabIndex = 348
        Me.del_inmueble.Text = "ELIMINAR"
        Me.del_inmueble.UseVisualStyleBackColor = False
        '
        'mod_inmueble
        '
        Me.mod_inmueble.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.mod_inmueble.Dock = System.Windows.Forms.DockStyle.Top
        Me.mod_inmueble.FlatAppearance.BorderSize = 0
        Me.mod_inmueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mod_inmueble.ForeColor = System.Drawing.Color.White
        Me.mod_inmueble.Location = New System.Drawing.Point(0, 29)
        Me.mod_inmueble.Name = "mod_inmueble"
        Me.mod_inmueble.Size = New System.Drawing.Size(100, 29)
        Me.mod_inmueble.TabIndex = 347
        Me.mod_inmueble.Text = "MODIFICAR"
        Me.mod_inmueble.UseVisualStyleBackColor = False
        '
        'add_inmueble
        '
        Me.add_inmueble.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.add_inmueble.Dock = System.Windows.Forms.DockStyle.Top
        Me.add_inmueble.FlatAppearance.BorderSize = 0
        Me.add_inmueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_inmueble.ForeColor = System.Drawing.Color.White
        Me.add_inmueble.Location = New System.Drawing.Point(0, 0)
        Me.add_inmueble.Name = "add_inmueble"
        Me.add_inmueble.Size = New System.Drawing.Size(100, 29)
        Me.add_inmueble.TabIndex = 346
        Me.add_inmueble.Text = "AGREGAR"
        Me.add_inmueble.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.info_estado)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.info_cuil)
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Controls.Add(Me.info_titular)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 182)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(601, 73)
        Me.Panel8.TabIndex = 931
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(33, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 19)
        Me.Label9.TabIndex = 919
        Me.Label9.Text = "Titular"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(26, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 920
        Me.Label8.Text = "N° CUIL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'info_estado
        '
        Me.info_estado.AutoSize = True
        Me.info_estado.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.info_estado.Location = New System.Drawing.Point(371, 51)
        Me.info_estado.Name = "info_estado"
        Me.info_estado.Size = New System.Drawing.Size(15, 19)
        Me.info_estado.TabIndex = 929
        Me.info_estado.Text = "-"
        Me.info_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(310, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 921
        Me.Label7.Text = "Estado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'info_cuil
        '
        Me.info_cuil.AutoSize = True
        Me.info_cuil.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.info_cuil.Location = New System.Drawing.Point(97, 51)
        Me.info_cuil.Name = "info_cuil"
        Me.info_cuil.Size = New System.Drawing.Size(15, 19)
        Me.info_cuil.TabIndex = 926
        Me.info_cuil.Text = "-"
        Me.info_cuil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Firebrick
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(601, 21)
        Me.Label17.TabIndex = 924
        Me.Label17.Text = "DETALLE DE INMUEBLE"
        '
        'info_titular
        '
        Me.info_titular.AutoSize = True
        Me.info_titular.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.info_titular.Location = New System.Drawing.Point(97, 26)
        Me.info_titular.Name = "info_titular"
        Me.info_titular.Size = New System.Drawing.Size(15, 19)
        Me.info_titular.TabIndex = 925
        Me.info_titular.Text = "-"
        Me.info_titular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel5.Controls.Add(Me.info_cuenta)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.info_uso)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.info_barrio)
        Me.Panel5.Controls.Add(Me.info_ubicacion)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 255)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(601, 73)
        Me.Panel5.TabIndex = 933
        '
        'info_cuenta
        '
        Me.info_cuenta.AutoSize = True
        Me.info_cuenta.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_cuenta.Location = New System.Drawing.Point(371, 52)
        Me.info_cuenta.Name = "info_cuenta"
        Me.info_cuenta.Size = New System.Drawing.Size(15, 19)
        Me.info_cuenta.TabIndex = 932
        Me.info_cuenta.Text = "-"
        Me.info_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(310, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 19)
        Me.Label21.TabIndex = 931
        Me.Label21.Text = "Cuenta"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'info_uso
        '
        Me.info_uso.AutoSize = True
        Me.info_uso.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_uso.Location = New System.Drawing.Point(97, 52)
        Me.info_uso.Name = "info_uso"
        Me.info_uso.Size = New System.Drawing.Size(15, 19)
        Me.info_uso.TabIndex = 930
        Me.info_uso.Text = "-"
        Me.info_uso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(52, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 19)
        Me.Label18.TabIndex = 929
        Me.Label18.Text = "Uso"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'info_barrio
        '
        Me.info_barrio.AutoSize = True
        Me.info_barrio.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_barrio.Location = New System.Drawing.Point(97, 29)
        Me.info_barrio.Name = "info_barrio"
        Me.info_barrio.Size = New System.Drawing.Size(15, 19)
        Me.info_barrio.TabIndex = 928
        Me.info_barrio.Text = "-"
        Me.info_barrio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'info_ubicacion
        '
        Me.info_ubicacion.AutoSize = True
        Me.info_ubicacion.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_ubicacion.Location = New System.Drawing.Point(97, 6)
        Me.info_ubicacion.Name = "info_ubicacion"
        Me.info_ubicacion.Size = New System.Drawing.Size(15, 19)
        Me.info_ubicacion.TabIndex = 927
        Me.info_ubicacion.Text = "-"
        Me.info_ubicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 19)
        Me.Label10.TabIndex = 916
        Me.Label10.Text = "Ubicación"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(37, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 19)
        Me.Label16.TabIndex = 917
        Me.Label16.Text = "Barrio"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(601, 25)
        Me.Label2.TabIndex = 932
        Me.Label2.Text = "INMUEBLE/S AFECTADO/S"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tab_expediente
        '
        Me.tab_expediente.Controls.Add(Me.grupoExp)
        Me.tab_expediente.Location = New System.Drawing.Point(4, 5)
        Me.tab_expediente.Name = "tab_expediente"
        Me.tab_expediente.Size = New System.Drawing.Size(601, 328)
        Me.tab_expediente.TabIndex = 2
        Me.tab_expediente.Text = "Expediente"
        Me.tab_expediente.UseVisualStyleBackColor = True
        '
        'grupoExp
        '
        Me.grupoExp.BackColor = System.Drawing.Color.Gainsboro
        Me.grupoExp.Controls.Add(Me.observaciones)
        Me.grupoExp.Controls.Add(Me.Label1)
        Me.grupoExp.Controls.Add(Me.visado)
        Me.grupoExp.Controls.Add(Me.fin_obra)
        Me.grupoExp.Controls.Add(Me.tarea2)
        Me.grupoExp.Controls.Add(Me.tarea)
        Me.grupoExp.Controls.Add(Me.Label39)
        Me.grupoExp.Controls.Add(Me.ver_fin_obra)
        Me.grupoExp.Controls.Add(Me.cargar_fin_obra)
        Me.grupoExp.Controls.Add(Me.recibe)
        Me.grupoExp.Controls.Add(Me.inicio_obra)
        Me.grupoExp.Controls.Add(Me.Label34)
        Me.grupoExp.Controls.Add(Me.Label33)
        Me.grupoExp.Controls.Add(Me.check_fin_obra)
        Me.grupoExp.Controls.Add(Me.et_fin_obra)
        Me.grupoExp.Controls.Add(Me.ruta_fin_obra)
        Me.grupoExp.Controls.Add(Me.Label3)
        Me.grupoExp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupoExp.ForeColor = System.Drawing.Color.Black
        Me.grupoExp.Location = New System.Drawing.Point(0, 0)
        Me.grupoExp.Name = "grupoExp"
        Me.grupoExp.Size = New System.Drawing.Size(601, 328)
        Me.grupoExp.TabIndex = 147
        '
        'observaciones
        '
        Me.observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.observaciones.Location = New System.Drawing.Point(135, 134)
        Me.observaciones.MaxLength = 200
        Me.observaciones.Multiline = True
        Me.observaciones.Name = "observaciones"
        Me.observaciones.Size = New System.Drawing.Size(428, 83)
        Me.observaciones.TabIndex = 404
        Me.Help.SetToolTip(Me.observaciones, "Maximo 200 caracteres.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 403
        Me.Label1.Text = "Observaciones"
        '
        'visado
        '
        Me.visado.AutoSize = True
        Me.visado.BackColor = System.Drawing.Color.Transparent
        Me.visado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.visado.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visado.ForeColor = System.Drawing.Color.Black
        Me.visado.Location = New System.Drawing.Point(77, 230)
        Me.visado.Name = "visado"
        Me.visado.Size = New System.Drawing.Size(72, 23)
        Me.visado.TabIndex = 399
        Me.visado.Text = "Visado"
        Me.visado.UseVisualStyleBackColor = False
        '
        'fin_obra
        '
        Me.fin_obra.CustomFormat = "dd MMMM yyyy"
        Me.fin_obra.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin_obra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fin_obra.Location = New System.Drawing.Point(267, 228)
        Me.fin_obra.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.fin_obra.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.fin_obra.Name = "fin_obra"
        Me.fin_obra.Size = New System.Drawing.Size(132, 27)
        Me.fin_obra.TabIndex = 398
        Me.fin_obra.Visible = False
        '
        'tarea2
        '
        Me.tarea2.BackColor = System.Drawing.SystemColors.Window
        Me.tarea2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tarea2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarea2.FormattingEnabled = True
        Me.tarea2.Items.AddRange(New Object() {"SIMPLE", "LOTEO", "POSESIÓN", "SUBDIVISIÓN SIMPLE", "UNIÓN", "UNIÓN Y LOTEO", "UNIÓN Y SUBDIVISIÓN"})
        Me.tarea2.Location = New System.Drawing.Point(320, 59)
        Me.tarea2.Name = "tarea2"
        Me.tarea2.Size = New System.Drawing.Size(224, 27)
        Me.tarea2.TabIndex = 391
        Me.tarea2.Visible = False
        '
        'tarea
        '
        Me.tarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tarea.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarea.FormattingEnabled = True
        Me.tarea.Items.AddRange(New Object() {"MENSURA", "PROYECTO", "RELEVAMIENTO"})
        Me.tarea.Location = New System.Drawing.Point(135, 59)
        Me.tarea.Name = "tarea"
        Me.tarea.Size = New System.Drawing.Size(177, 27)
        Me.tarea.TabIndex = 390
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(87, 63)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(45, 19)
        Me.Label39.TabIndex = 389
        Me.Label39.Text = "Tarea"
        '
        'ver_fin_obra
        '
        Me.ver_fin_obra.BackColor = System.Drawing.Color.Transparent
        Me.ver_fin_obra.BackgroundImage = Global.Sigm.My.Resources.Resources.print
        Me.ver_fin_obra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ver_fin_obra.FlatAppearance.BorderSize = 0
        Me.ver_fin_obra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ver_fin_obra.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ver_fin_obra.ForeColor = System.Drawing.Color.White
        Me.ver_fin_obra.Location = New System.Drawing.Point(512, 263)
        Me.ver_fin_obra.Margin = New System.Windows.Forms.Padding(0)
        Me.ver_fin_obra.Name = "ver_fin_obra"
        Me.ver_fin_obra.Size = New System.Drawing.Size(32, 32)
        Me.ver_fin_obra.TabIndex = 402
        Me.ver_fin_obra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ver_fin_obra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ver_fin_obra.UseVisualStyleBackColor = False
        Me.ver_fin_obra.Visible = False
        '
        'cargar_fin_obra
        '
        Me.cargar_fin_obra.BackColor = System.Drawing.Color.Transparent
        Me.cargar_fin_obra.BackgroundImage = Global.Sigm.My.Resources.Resources.abrir
        Me.cargar_fin_obra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cargar_fin_obra.FlatAppearance.BorderSize = 0
        Me.cargar_fin_obra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cargar_fin_obra.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargar_fin_obra.ForeColor = System.Drawing.Color.Transparent
        Me.cargar_fin_obra.Location = New System.Drawing.Point(473, 263)
        Me.cargar_fin_obra.Margin = New System.Windows.Forms.Padding(0)
        Me.cargar_fin_obra.Name = "cargar_fin_obra"
        Me.cargar_fin_obra.Size = New System.Drawing.Size(32, 32)
        Me.cargar_fin_obra.TabIndex = 401
        Me.cargar_fin_obra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cargar_fin_obra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cargar_fin_obra.UseVisualStyleBackColor = False
        Me.cargar_fin_obra.Visible = False
        '
        'recibe
        '
        Me.recibe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.recibe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.recibe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.recibe.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recibe.FormattingEnabled = True
        Me.recibe.Items.AddRange(New Object() {"JORGE PEREYRA", "ROCIO ESCUDERO"})
        Me.recibe.Location = New System.Drawing.Point(135, 96)
        Me.recibe.Name = "recibe"
        Me.recibe.Size = New System.Drawing.Size(177, 27)
        Me.recibe.TabIndex = 393
        '
        'inicio_obra
        '
        Me.inicio_obra.CustomFormat = "dd MMMM yyyy"
        Me.inicio_obra.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicio_obra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inicio_obra.Location = New System.Drawing.Point(135, 22)
        Me.inicio_obra.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
        Me.inicio_obra.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.inicio_obra.Name = "inicio_obra"
        Me.inicio_obra.Size = New System.Drawing.Size(132, 27)
        Me.inicio_obra.TabIndex = 392
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(42, 100)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(90, 19)
        Me.Label34.TabIndex = 381
        Me.Label34.Text = "Recibido por"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(11, 26)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(121, 19)
        Me.Label33.TabIndex = 365
        Me.Label33.Text = "Fecha de Ingreso"
        '
        'check_fin_obra
        '
        Me.check_fin_obra.AutoSize = True
        Me.check_fin_obra.BackColor = System.Drawing.Color.Transparent
        Me.check_fin_obra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.check_fin_obra.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_fin_obra.ForeColor = System.Drawing.Color.Black
        Me.check_fin_obra.Location = New System.Drawing.Point(157, 230)
        Me.check_fin_obra.Name = "check_fin_obra"
        Me.check_fin_obra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.check_fin_obra.Size = New System.Drawing.Size(103, 23)
        Me.check_fin_obra.TabIndex = 397
        Me.check_fin_obra.Text = "Fin de Obra"
        Me.check_fin_obra.UseVisualStyleBackColor = False
        Me.check_fin_obra.Visible = False
        '
        'et_fin_obra
        '
        Me.et_fin_obra.AutoSize = True
        Me.et_fin_obra.BackColor = System.Drawing.Color.Transparent
        Me.et_fin_obra.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_fin_obra.ForeColor = System.Drawing.Color.Black
        Me.et_fin_obra.Location = New System.Drawing.Point(54, 270)
        Me.et_fin_obra.Name = "et_fin_obra"
        Me.et_fin_obra.Size = New System.Drawing.Size(78, 19)
        Me.et_fin_obra.TabIndex = 380
        Me.et_fin_obra.Text = "Certificado"
        Me.et_fin_obra.Visible = False
        '
        'ruta_fin_obra
        '
        Me.ruta_fin_obra.BackColor = System.Drawing.SystemColors.Info
        Me.ruta_fin_obra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ruta_fin_obra.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.ruta_fin_obra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ruta_fin_obra.Enabled = False
        Me.ruta_fin_obra.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ruta_fin_obra.Location = New System.Drawing.Point(135, 266)
        Me.ruta_fin_obra.MaxLength = 512
        Me.ruta_fin_obra.Name = "ruta_fin_obra"
        Me.ruta_fin_obra.ReadOnly = True
        Me.ruta_fin_obra.Size = New System.Drawing.Size(328, 27)
        Me.ruta_fin_obra.TabIndex = 400
        Me.ruta_fin_obra.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(601, 25)
        Me.Label3.TabIndex = 388
        Me.Label3.Text = "DETALLES DE EXPEDIENTE"
        '
        'top_menu
        '
        Me.top_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.top_menu.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERSONASToolStripMenuItem, Me.INMUEBLESToolStripMenuItem, Me.ARCHIVOToolStripMenuItem, Me.save, Me.print, Me.PagosToolStripMenuItem})
        Me.top_menu.Location = New System.Drawing.Point(0, 0)
        Me.top_menu.Name = "top_menu"
        Me.top_menu.Padding = New System.Windows.Forms.Padding(0)
        Me.top_menu.Size = New System.Drawing.Size(609, 25)
        Me.top_menu.TabIndex = 380
        '
        'PERSONASToolStripMenuItem
        '
        Me.PERSONASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PERSONASToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.PERSONASToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PERSONASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PERSONASToolStripMenuItem.Name = "PERSONASToolStripMenuItem"
        Me.PERSONASToolStripMenuItem.Size = New System.Drawing.Size(104, 25)
        Me.PERSONASToolStripMenuItem.Text = "PERSONAS"
        '
        'INMUEBLESToolStripMenuItem
        '
        Me.INMUEBLESToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.INMUEBLESToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.INMUEBLESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.INMUEBLESToolStripMenuItem.Name = "INMUEBLESToolStripMenuItem"
        Me.INMUEBLESToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.INMUEBLESToolStripMenuItem.Size = New System.Drawing.Size(103, 25)
        Me.INMUEBLESToolStripMenuItem.Text = "INMUEBLES"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.ARCHIVOToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ARCHIVOToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ARCHIVOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(109, 25)
        Me.ARCHIVOToolStripMenuItem.Text = "EXPEDIENTE"
        '
        'save
        '
        Me.save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.save.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.save.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(94, 25)
        Me.save.Text = "GUARDAR"
        '
        'print
        '
        Me.print.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.print.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.print.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaratulaToolStripMenuItem, Me.CopiaDeExpedienteToolStripMenuItem})
        Me.print.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.print.ForeColor = System.Drawing.Color.White
        Me.print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(93, 25)
        Me.print.Text = "IMPRIMIR"
        '
        'CaratulaToolStripMenuItem
        '
        Me.CaratulaToolStripMenuItem.Name = "CaratulaToolStripMenuItem"
        Me.CaratulaToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.CaratulaToolStripMenuItem.Text = "Caratula"
        '
        'CopiaDeExpedienteToolStripMenuItem
        '
        Me.CopiaDeExpedienteToolStripMenuItem.Name = "CopiaDeExpedienteToolStripMenuItem"
        Me.CopiaDeExpedienteToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.CopiaDeExpedienteToolStripMenuItem.Text = "Resumen de Expediente"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDeudaToolStripMenuItem, Me.AgregarPagoToolStripMenuItem})
        Me.PagosToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.PagosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PagosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.PagosToolStripMenuItem.Text = "PAGOS"
        '
        'AgregarDeudaToolStripMenuItem
        '
        Me.AgregarDeudaToolStripMenuItem.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
        Me.AgregarDeudaToolStripMenuItem.Name = "AgregarDeudaToolStripMenuItem"
        Me.AgregarDeudaToolStripMenuItem.Size = New System.Drawing.Size(193, 28)
        Me.AgregarDeudaToolStripMenuItem.Text = "Agregar Deuda"
        '
        'AgregarPagoToolStripMenuItem
        '
        Me.AgregarPagoToolStripMenuItem.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
        Me.AgregarPagoToolStripMenuItem.Name = "AgregarPagoToolStripMenuItem"
        Me.AgregarPagoToolStripMenuItem.Size = New System.Drawing.Size(193, 28)
        Me.AgregarPagoToolStripMenuItem.Text = "Agregar Pago"
        '
        'wrapper
        '
        Me.wrapper.BackColor = System.Drawing.Color.Gainsboro
        Me.wrapper.Controls.Add(Me.grupo_exp)
        Me.wrapper.Controls.Add(Me.top_menu)
        Me.wrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wrapper.Location = New System.Drawing.Point(0, 0)
        Me.wrapper.Name = "wrapper"
        Me.wrapper.Size = New System.Drawing.Size(609, 362)
        Me.wrapper.TabIndex = 379
        '
        'bs_catastro
        '
        '
        'estado
        '
        Me.estado.BackColor = System.Drawing.Color.Silver
        Me.estado.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.expediente, Me.temporal, Me.espacio, Me.user_id, Me.id, Me.prof_id, Me.responsable_id})
        Me.estado.Location = New System.Drawing.Point(0, 362)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(609, 24)
        Me.estado.SizingGrip = False
        Me.estado.TabIndex = 383
        Me.estado.Text = "estado"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ActiveLinkColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel4.LinkColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(103, 19)
        Me.ToolStripStatusLabel4.Text = "Expediente N°"
        Me.ToolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripStatusLabel4.VisitedLinkColor = System.Drawing.Color.Black
        '
        'expediente
        '
        Me.expediente.ActiveLinkColor = System.Drawing.Color.Black
        Me.expediente.BackColor = System.Drawing.Color.Transparent
        Me.expediente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.expediente.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expediente.LinkColor = System.Drawing.Color.Black
        Me.expediente.Name = "expediente"
        Me.expediente.Size = New System.Drawing.Size(18, 19)
        Me.expediente.Text = "0"
        Me.expediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.expediente.VisitedLinkColor = System.Drawing.Color.Black
        '
        'temporal
        '
        Me.temporal.ActiveLinkColor = System.Drawing.Color.Black
        Me.temporal.BackColor = System.Drawing.Color.Transparent
        Me.temporal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.temporal.ForeColor = System.Drawing.Color.Crimson
        Me.temporal.LinkColor = System.Drawing.Color.Black
        Me.temporal.Name = "temporal"
        Me.temporal.Size = New System.Drawing.Size(68, 19)
        Me.temporal.Text = "Temporal"
        Me.temporal.Visible = False
        Me.temporal.VisitedLinkColor = System.Drawing.Color.Black
        '
        'espacio
        '
        Me.espacio.Name = "espacio"
        Me.espacio.Size = New System.Drawing.Size(405, 19)
        Me.espacio.Spring = True
        Me.espacio.Text = " "
        '
        'user_id
        '
        Me.user_id.ActiveLinkColor = System.Drawing.Color.Black
        Me.user_id.BackColor = System.Drawing.Color.Transparent
        Me.user_id.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.user_id.LinkColor = System.Drawing.Color.Black
        Me.user_id.Name = "user_id"
        Me.user_id.Size = New System.Drawing.Size(17, 19)
        Me.user_id.Text = "0"
        Me.user_id.VisitedLinkColor = System.Drawing.Color.Black
        '
        'id
        '
        Me.id.ActiveLinkColor = System.Drawing.Color.Black
        Me.id.BackColor = System.Drawing.Color.Transparent
        Me.id.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.id.LinkColor = System.Drawing.Color.Black
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(17, 19)
        Me.id.Text = "0"
        Me.id.VisitedLinkColor = System.Drawing.Color.Black
        '
        'prof_id
        '
        Me.prof_id.ActiveLinkColor = System.Drawing.Color.Black
        Me.prof_id.BackColor = System.Drawing.Color.Transparent
        Me.prof_id.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.prof_id.LinkColor = System.Drawing.Color.Black
        Me.prof_id.Name = "prof_id"
        Me.prof_id.Size = New System.Drawing.Size(17, 19)
        Me.prof_id.Text = "0"
        Me.prof_id.VisitedLinkColor = System.Drawing.Color.Black
        '
        'responsable_id
        '
        Me.responsable_id.ActiveLinkColor = System.Drawing.Color.Black
        Me.responsable_id.BackColor = System.Drawing.Color.Transparent
        Me.responsable_id.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.responsable_id.LinkColor = System.Drawing.Color.Black
        Me.responsable_id.Name = "responsable_id"
        Me.responsable_id.Size = New System.Drawing.Size(17, 19)
        Me.responsable_id.Text = "0"
        Me.responsable_id.VisitedLinkColor = System.Drawing.Color.Black
        '
        'ModExpediente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(609, 386)
        Me.Controls.Add(Me.wrapper)
        Me.Controls.Add(Me.estado)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.top_menu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(625, 425)
        Me.Name = "ModExpediente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Expediente"
        Me.grupo_exp.ResumeLayout(False)
        Me.tab_persona.ResumeLayout(False)
        Me.page_pers.ResumeLayout(False)
        CType(Me.consulta_resp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.tab_inmueble.ResumeLayout(False)
        Me.page_inmueble.ResumeLayout(False)
        CType(Me.consulta_inmueble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tab_expediente.ResumeLayout(False)
        Me.grupoExp.ResumeLayout(False)
        Me.grupoExp.PerformLayout()
        Me.top_menu.ResumeLayout(False)
        Me.top_menu.PerformLayout()
        Me.wrapper.ResumeLayout(False)
        Me.wrapper.PerformLayout()
        CType(Me.bs_resp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_catastro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.estado.ResumeLayout(False)
        Me.estado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opendialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FormulariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newppe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents info1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents info2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents info0 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NuevaPreviaMunicipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grupo_exp As System.Windows.Forms.TabControl
    Friend WithEvents tab_persona As System.Windows.Forms.TabPage
    Friend WithEvents page_pers As System.Windows.Forms.Panel
    Friend WithEvents consulta_resp As System.Windows.Forms.DataGridView
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents tab_inmueble As System.Windows.Forms.TabPage
    Friend WithEvents page_inmueble As System.Windows.Forms.Panel
    Friend WithEvents tab_expediente As System.Windows.Forms.TabPage
    Friend WithEvents grupoExp As System.Windows.Forms.Panel
    Friend WithEvents tarea2 As System.Windows.Forms.ComboBox
    Friend WithEvents tarea As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ver_fin_obra As System.Windows.Forms.Button
    Friend WithEvents cargar_fin_obra As System.Windows.Forms.Button
    Friend WithEvents recibe As System.Windows.Forms.ComboBox
    Friend WithEvents inicio_obra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents check_fin_obra As System.Windows.Forms.CheckBox
    Friend WithEvents et_fin_obra As System.Windows.Forms.Label
    Friend WithEvents ruta_fin_obra As System.Windows.Forms.TextBox
    Friend WithEvents top_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents PERSONASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INMUEBLESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wrapper As System.Windows.Forms.Panel
    Friend WithEvents consulta_inmueble As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bs_resp As System.Windows.Forms.BindingSource
    Friend WithEvents bs_catastro As System.Windows.Forms.BindingSource
    Friend WithEvents info_estado As System.Windows.Forms.Label
    Friend WithEvents info_cuil As System.Windows.Forms.Label
    Friend WithEvents info_titular As System.Windows.Forms.Label
    Friend WithEvents fin_obra As System.Windows.Forms.DateTimePicker
    Friend WithEvents visado As System.Windows.Forms.CheckBox
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarDeudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarPagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents razon As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents matricula As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents del_resp As System.Windows.Forms.Button
    Friend WithEvents add_resp As System.Windows.Forms.Button
    Friend WithEvents estado As System.Windows.Forms.StatusStrip
    Friend WithEvents user_id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents expediente As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents temporal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents espacio As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents mod_prof As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents mod_inmueble As System.Windows.Forms.Button
    Friend WithEvents add_inmueble As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents info_cuenta As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents info_uso As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents info_barrio As System.Windows.Forms.Label
    Friend WithEvents info_ubicacion As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents prof_id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents responsable_id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CaratulaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiaDeExpedienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents del_inmueble As Button
    Friend WithEvents titulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents observaciones As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Help As ToolTip
End Class
