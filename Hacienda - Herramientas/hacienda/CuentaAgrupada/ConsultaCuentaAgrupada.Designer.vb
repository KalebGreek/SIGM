<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCuentaAgrupada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaCuentaAgrupada))
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
        Me.grupo_ca = New System.Windows.Forms.Panel()
        Me.imp_lista_mod = New System.Windows.Forms.DataGridView()
        Me.grupo_mod_ca = New System.Windows.Forms.Panel()
        Me.mod_ca_imp_search = New System.Windows.Forms.Button()
        Me.save_ca = New System.Windows.Forms.Button()
        Me.et_mod_ca = New System.Windows.Forms.Label()
        Me.imp_sepe = New System.Windows.Forms.RadioButton()
        Me.imp_come = New System.Windows.Forms.RadioButton()
        Me.imp_cata = New System.Windows.Forms.RadioButton()
        Me.imp_auto = New System.Windows.Forms.RadioButton()
        Me.imp_agua = New System.Windows.Forms.RadioButton()
        Me.imp_baja = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.imp_alta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imp_add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.imp_razon = New System.Windows.Forms.TextBox()
        Me.grupo_con_ca = New System.Windows.Forms.Panel()
        Me.close_con_ca = New System.Windows.Forms.Button()
        Me.ca_con_preview = New System.Windows.Forms.Button()
        Me.con_pago = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.con_deuda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ca_con_print = New System.Windows.Forms.Button()
        Me.et_con_ca = New System.Windows.Forms.Label()
        Me.visor = New System.Windows.Forms.DataGridView()
        Me.grupo_buscar_ca = New System.Windows.Forms.Panel()
        Me.ca_search = New System.Windows.Forms.Button()
        Me.mod_ca = New System.Windows.Forms.Button()
        Me.con_ca = New System.Windows.Forms.Button()
        Me.et_buscar_ca = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.mod_per = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.razon = New System.Windows.Forms.TextBox()
        Me.ca_switch = New System.Windows.Forms.Button()
        Me.dni = New System.Windows.Forms.MaskedTextBox()
        Me.cuil = New System.Windows.Forms.MaskedTextBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_ca.SuspendLayout()
        CType(Me.imp_lista_mod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_mod_ca.SuspendLayout()
        Me.grupo_con_ca.SuspendLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_buscar_ca.SuspendLayout()
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 317)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 24)
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
        'grupo_ca
        '
        Me.grupo_ca.Controls.Add(Me.imp_lista_mod)
        Me.grupo_ca.Controls.Add(Me.grupo_mod_ca)
        Me.grupo_ca.Controls.Add(Me.grupo_con_ca)
        Me.grupo_ca.Dock = System.Windows.Forms.DockStyle.Right
        Me.grupo_ca.Location = New System.Drawing.Point(495, 0)
        Me.grupo_ca.Name = "grupo_ca"
        Me.grupo_ca.Size = New System.Drawing.Size(513, 317)
        Me.grupo_ca.TabIndex = 3
        '
        'imp_lista_mod
        '
        Me.imp_lista_mod.AllowUserToAddRows = False
        Me.imp_lista_mod.AllowUserToResizeRows = False
        Me.imp_lista_mod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.imp_lista_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imp_lista_mod.Location = New System.Drawing.Point(0, 138)
        Me.imp_lista_mod.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_lista_mod.Name = "imp_lista_mod"
        Me.imp_lista_mod.RowHeadersVisible = False
        Me.imp_lista_mod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.imp_lista_mod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.imp_lista_mod.Size = New System.Drawing.Size(513, 109)
        Me.imp_lista_mod.TabIndex = 134
        '
        'grupo_mod_ca
        '
        Me.grupo_mod_ca.BackColor = System.Drawing.Color.Gainsboro
        Me.grupo_mod_ca.Controls.Add(Me.mod_ca_imp_search)
        Me.grupo_mod_ca.Controls.Add(Me.save_ca)
        Me.grupo_mod_ca.Controls.Add(Me.et_mod_ca)
        Me.grupo_mod_ca.Controls.Add(Me.imp_sepe)
        Me.grupo_mod_ca.Controls.Add(Me.imp_come)
        Me.grupo_mod_ca.Controls.Add(Me.imp_cata)
        Me.grupo_mod_ca.Controls.Add(Me.imp_auto)
        Me.grupo_mod_ca.Controls.Add(Me.imp_agua)
        Me.grupo_mod_ca.Controls.Add(Me.imp_baja)
        Me.grupo_mod_ca.Controls.Add(Me.Label6)
        Me.grupo_mod_ca.Controls.Add(Me.imp_alta)
        Me.grupo_mod_ca.Controls.Add(Me.Label3)
        Me.grupo_mod_ca.Controls.Add(Me.imp_add)
        Me.grupo_mod_ca.Controls.Add(Me.Label4)
        Me.grupo_mod_ca.Controls.Add(Me.Label8)
        Me.grupo_mod_ca.Controls.Add(Me.imp_razon)
        Me.grupo_mod_ca.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_mod_ca.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo_mod_ca.Location = New System.Drawing.Point(0, 0)
        Me.grupo_mod_ca.Name = "grupo_mod_ca"
        Me.grupo_mod_ca.Size = New System.Drawing.Size(513, 138)
        Me.grupo_mod_ca.TabIndex = 131
        Me.grupo_mod_ca.Visible = False
        '
        'mod_ca_imp_search
        '
        Me.mod_ca_imp_search.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mod_ca_imp_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mod_ca_imp_search.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_ca_imp_search.Location = New System.Drawing.Point(400, 64)
        Me.mod_ca_imp_search.Margin = New System.Windows.Forms.Padding(2)
        Me.mod_ca_imp_search.Name = "mod_ca_imp_search"
        Me.mod_ca_imp_search.Size = New System.Drawing.Size(72, 24)
        Me.mod_ca_imp_search.TabIndex = 145
        Me.mod_ca_imp_search.Text = "Buscar"
        Me.mod_ca_imp_search.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mod_ca_imp_search.UseVisualStyleBackColor = False
        '
        'save_ca
        '
        Me.save_ca.BackColor = System.Drawing.Color.DarkGray
        Me.save_ca.FlatAppearance.BorderSize = 0
        Me.save_ca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_ca.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_ca.ForeColor = System.Drawing.Color.White
        Me.save_ca.Location = New System.Drawing.Point(309, -3)
        Me.save_ca.Margin = New System.Windows.Forms.Padding(0)
        Me.save_ca.Name = "save_ca"
        Me.save_ca.Size = New System.Drawing.Size(161, 25)
        Me.save_ca.TabIndex = 127
        Me.save_ca.Text = "GUARDAR CAMBIOS"
        Me.save_ca.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.save_ca.UseVisualStyleBackColor = False
        '
        'et_mod_ca
        '
        Me.et_mod_ca.BackColor = System.Drawing.Color.RosyBrown
        Me.et_mod_ca.Dock = System.Windows.Forms.DockStyle.Top
        Me.et_mod_ca.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_mod_ca.ForeColor = System.Drawing.Color.White
        Me.et_mod_ca.Location = New System.Drawing.Point(0, 0)
        Me.et_mod_ca.Name = "et_mod_ca"
        Me.et_mod_ca.Size = New System.Drawing.Size(513, 22)
        Me.et_mod_ca.TabIndex = 144
        Me.et_mod_ca.Text = " MODIFICAR CUENTA"
        '
        'imp_sepe
        '
        Me.imp_sepe.AutoSize = True
        Me.imp_sepe.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_sepe.Location = New System.Drawing.Point(406, 33)
        Me.imp_sepe.Name = "imp_sepe"
        Me.imp_sepe.Size = New System.Drawing.Size(71, 22)
        Me.imp_sepe.TabIndex = 143
        Me.imp_sepe.Text = "Sepelio"
        Me.imp_sepe.UseVisualStyleBackColor = True
        '
        'imp_come
        '
        Me.imp_come.AutoSize = True
        Me.imp_come.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_come.Location = New System.Drawing.Point(321, 33)
        Me.imp_come.Name = "imp_come"
        Me.imp_come.Size = New System.Drawing.Size(83, 22)
        Me.imp_come.TabIndex = 142
        Me.imp_come.Text = "Comercio"
        Me.imp_come.UseVisualStyleBackColor = True
        '
        'imp_cata
        '
        Me.imp_cata.AutoSize = True
        Me.imp_cata.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_cata.Location = New System.Drawing.Point(241, 33)
        Me.imp_cata.Name = "imp_cata"
        Me.imp_cata.Size = New System.Drawing.Size(78, 22)
        Me.imp_cata.TabIndex = 141
        Me.imp_cata.Text = "Catastro"
        Me.imp_cata.UseVisualStyleBackColor = True
        '
        'imp_auto
        '
        Me.imp_auto.AutoSize = True
        Me.imp_auto.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_auto.Location = New System.Drawing.Point(149, 33)
        Me.imp_auto.Name = "imp_auto"
        Me.imp_auto.Size = New System.Drawing.Size(90, 22)
        Me.imp_auto.TabIndex = 140
        Me.imp_auto.Text = "Automóvil"
        Me.imp_auto.UseVisualStyleBackColor = True
        '
        'imp_agua
        '
        Me.imp_agua.AutoSize = True
        Me.imp_agua.Checked = True
        Me.imp_agua.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_agua.Location = New System.Drawing.Point(90, 33)
        Me.imp_agua.Name = "imp_agua"
        Me.imp_agua.Size = New System.Drawing.Size(57, 22)
        Me.imp_agua.TabIndex = 139
        Me.imp_agua.TabStop = True
        Me.imp_agua.Text = "Agua"
        Me.imp_agua.UseVisualStyleBackColor = True
        '
        'imp_baja
        '
        Me.imp_baja.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_baja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.imp_baja.Location = New System.Drawing.Point(224, 99)
        Me.imp_baja.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_baja.Name = "imp_baja"
        Me.imp_baja.Size = New System.Drawing.Size(111, 25)
        Me.imp_baja.TabIndex = 138
        Me.imp_baja.Value = New Date(1899, 1, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 102)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 19)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Baja"
        '
        'imp_alta
        '
        Me.imp_alta.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_alta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.imp_alta.Location = New System.Drawing.Point(49, 99)
        Me.imp_alta.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_alta.Name = "imp_alta"
        Me.imp_alta.Size = New System.Drawing.Size(111, 25)
        Me.imp_alta.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Alta"
        '
        'imp_add
        '
        Me.imp_add.BackColor = System.Drawing.Color.LightCoral
        Me.imp_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imp_add.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_add.ForeColor = System.Drawing.Color.White
        Me.imp_add.Location = New System.Drawing.Point(350, 98)
        Me.imp_add.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_add.Name = "imp_add"
        Me.imp_add.Size = New System.Drawing.Size(130, 27)
        Me.imp_add.TabIndex = 134
        Me.imp_add.Text = "Agregar Impuesto"
        Me.imp_add.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.imp_add.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Impuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 66)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 19)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Dueño o Tenedor"
        '
        'imp_razon
        '
        Me.imp_razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.imp_razon.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imp_razon.Location = New System.Drawing.Point(132, 63)
        Me.imp_razon.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_razon.Name = "imp_razon"
        Me.imp_razon.Size = New System.Drawing.Size(262, 25)
        Me.imp_razon.TabIndex = 126
        '
        'grupo_con_ca
        '
        Me.grupo_con_ca.BackColor = System.Drawing.Color.Gainsboro
        Me.grupo_con_ca.Controls.Add(Me.close_con_ca)
        Me.grupo_con_ca.Controls.Add(Me.ca_con_preview)
        Me.grupo_con_ca.Controls.Add(Me.con_pago)
        Me.grupo_con_ca.Controls.Add(Me.Label10)
        Me.grupo_con_ca.Controls.Add(Me.con_deuda)
        Me.grupo_con_ca.Controls.Add(Me.Label11)
        Me.grupo_con_ca.Controls.Add(Me.ca_con_print)
        Me.grupo_con_ca.Controls.Add(Me.et_con_ca)
        Me.grupo_con_ca.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupo_con_ca.Location = New System.Drawing.Point(0, 247)
        Me.grupo_con_ca.Name = "grupo_con_ca"
        Me.grupo_con_ca.Size = New System.Drawing.Size(513, 70)
        Me.grupo_con_ca.TabIndex = 133
        Me.grupo_con_ca.Visible = False
        '
        'close_con_ca
        '
        Me.close_con_ca.BackColor = System.Drawing.Color.Gray
        Me.close_con_ca.BackgroundImage = CType(resources.GetObject("close_con_ca.BackgroundImage"), System.Drawing.Image)
        Me.close_con_ca.FlatAppearance.BorderSize = 0
        Me.close_con_ca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_con_ca.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_con_ca.Location = New System.Drawing.Point(490, 0)
        Me.close_con_ca.Margin = New System.Windows.Forms.Padding(2)
        Me.close_con_ca.Name = "close_con_ca"
        Me.close_con_ca.Size = New System.Drawing.Size(22, 22)
        Me.close_con_ca.TabIndex = 153
        Me.close_con_ca.UseVisualStyleBackColor = False
        '
        'ca_con_preview
        '
        Me.ca_con_preview.BackColor = System.Drawing.SystemColors.Control
        Me.ca_con_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ca_con_preview.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ca_con_preview.Location = New System.Drawing.Point(10, 33)
        Me.ca_con_preview.Margin = New System.Windows.Forms.Padding(2)
        Me.ca_con_preview.Name = "ca_con_preview"
        Me.ca_con_preview.Size = New System.Drawing.Size(109, 23)
        Me.ca_con_preview.TabIndex = 151
        Me.ca_con_preview.Text = "Vista Previa"
        Me.ca_con_preview.UseVisualStyleBackColor = False
        '
        'con_pago
        '
        Me.con_pago.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.con_pago.ForeColor = System.Drawing.Color.ForestGreen
        Me.con_pago.Location = New System.Drawing.Point(409, 34)
        Me.con_pago.Margin = New System.Windows.Forms.Padding(2)
        Me.con_pago.MaxLength = 15
        Me.con_pago.Name = "con_pago"
        Me.con_pago.ReadOnly = True
        Me.con_pago.Size = New System.Drawing.Size(95, 23)
        Me.con_pago.TabIndex = 150
        Me.con_pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(372, 38)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 15)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Pago"
        '
        'con_deuda
        '
        Me.con_deuda.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.con_deuda.ForeColor = System.Drawing.Color.Firebrick
        Me.con_deuda.Location = New System.Drawing.Point(263, 34)
        Me.con_deuda.Margin = New System.Windows.Forms.Padding(2)
        Me.con_deuda.MaxLength = 15
        Me.con_deuda.Name = "con_deuda"
        Me.con_deuda.ReadOnly = True
        Me.con_deuda.Size = New System.Drawing.Size(95, 23)
        Me.con_deuda.TabIndex = 148
        Me.con_deuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(219, 38)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 15)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Deuda"
        '
        'ca_con_print
        '
        Me.ca_con_print.BackColor = System.Drawing.SystemColors.Control
        Me.ca_con_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ca_con_print.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ca_con_print.Location = New System.Drawing.Point(127, 33)
        Me.ca_con_print.Margin = New System.Windows.Forms.Padding(2)
        Me.ca_con_print.Name = "ca_con_print"
        Me.ca_con_print.Size = New System.Drawing.Size(84, 23)
        Me.ca_con_print.TabIndex = 146
        Me.ca_con_print.Text = "Imprimir"
        Me.ca_con_print.UseVisualStyleBackColor = False
        '
        'et_con_ca
        '
        Me.et_con_ca.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.et_con_ca.Dock = System.Windows.Forms.DockStyle.Top
        Me.et_con_ca.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_con_ca.ForeColor = System.Drawing.Color.White
        Me.et_con_ca.Location = New System.Drawing.Point(0, 0)
        Me.et_con_ca.Name = "et_con_ca"
        Me.et_con_ca.Size = New System.Drawing.Size(513, 22)
        Me.et_con_ca.TabIndex = 144
        Me.et_con_ca.Text = " CONSULTAR CUENTA"
        '
        'visor
        '
        Me.visor.AllowUserToAddRows = False
        Me.visor.AllowUserToDeleteRows = False
        Me.visor.AllowUserToResizeRows = False
        Me.visor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor.Location = New System.Drawing.Point(0, 103)
        Me.visor.Name = "visor"
        Me.visor.ReadOnly = True
        Me.visor.RowHeadersVisible = False
        Me.visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.visor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visor.Size = New System.Drawing.Size(495, 214)
        Me.visor.TabIndex = 5
        '
        'grupo_buscar_ca
        '
        Me.grupo_buscar_ca.BackColor = System.Drawing.Color.Gainsboro
        Me.grupo_buscar_ca.Controls.Add(Me.ca_search)
        Me.grupo_buscar_ca.Controls.Add(Me.mod_ca)
        Me.grupo_buscar_ca.Controls.Add(Me.con_ca)
        Me.grupo_buscar_ca.Controls.Add(Me.et_buscar_ca)
        Me.grupo_buscar_ca.Controls.Add(Me.reset)
        Me.grupo_buscar_ca.Controls.Add(Me.mod_per)
        Me.grupo_buscar_ca.Controls.Add(Me.Label5)
        Me.grupo_buscar_ca.Controls.Add(Me.Label9)
        Me.grupo_buscar_ca.Controls.Add(Me.razon)
        Me.grupo_buscar_ca.Controls.Add(Me.ca_switch)
        Me.grupo_buscar_ca.Controls.Add(Me.dni)
        Me.grupo_buscar_ca.Controls.Add(Me.cuil)
        Me.grupo_buscar_ca.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_buscar_ca.Location = New System.Drawing.Point(0, 0)
        Me.grupo_buscar_ca.Name = "grupo_buscar_ca"
        Me.grupo_buscar_ca.Size = New System.Drawing.Size(495, 103)
        Me.grupo_buscar_ca.TabIndex = 133
        '
        'ca_search
        '
        Me.ca_search.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ca_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ca_search.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ca_search.Location = New System.Drawing.Point(373, 33)
        Me.ca_search.Margin = New System.Windows.Forms.Padding(2)
        Me.ca_search.Name = "ca_search"
        Me.ca_search.Size = New System.Drawing.Size(72, 24)
        Me.ca_search.TabIndex = 152
        Me.ca_search.Text = "Buscar"
        Me.ca_search.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ca_search.UseVisualStyleBackColor = False
        '
        'mod_ca
        '
        Me.mod_ca.BackColor = System.Drawing.Color.RosyBrown
        Me.mod_ca.FlatAppearance.BorderSize = 0
        Me.mod_ca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mod_ca.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_ca.ForeColor = System.Drawing.Color.White
        Me.mod_ca.Location = New System.Drawing.Point(384, -3)
        Me.mod_ca.Margin = New System.Windows.Forms.Padding(0)
        Me.mod_ca.Name = "mod_ca"
        Me.mod_ca.Size = New System.Drawing.Size(95, 25)
        Me.mod_ca.TabIndex = 151
        Me.mod_ca.Text = "MODIFICAR"
        Me.mod_ca.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mod_ca.UseVisualStyleBackColor = False
        '
        'con_ca
        '
        Me.con_ca.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.con_ca.FlatAppearance.BorderSize = 0
        Me.con_ca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.con_ca.Font = New System.Drawing.Font("PF DinText Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.con_ca.ForeColor = System.Drawing.Color.White
        Me.con_ca.Location = New System.Drawing.Point(271, -3)
        Me.con_ca.Margin = New System.Windows.Forms.Padding(0)
        Me.con_ca.Name = "con_ca"
        Me.con_ca.Size = New System.Drawing.Size(100, 25)
        Me.con_ca.TabIndex = 150
        Me.con_ca.Text = "CONSULTAR"
        Me.con_ca.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.con_ca.UseVisualStyleBackColor = False
        '
        'et_buscar_ca
        '
        Me.et_buscar_ca.BackColor = System.Drawing.Color.DarkGray
        Me.et_buscar_ca.Dock = System.Windows.Forms.DockStyle.Top
        Me.et_buscar_ca.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.et_buscar_ca.ForeColor = System.Drawing.Color.Black
        Me.et_buscar_ca.Location = New System.Drawing.Point(0, 0)
        Me.et_buscar_ca.Name = "et_buscar_ca"
        Me.et_buscar_ca.Size = New System.Drawing.Size(495, 22)
        Me.et_buscar_ca.TabIndex = 145
        Me.et_buscar_ca.Text = " BUSCAR CUENTA"
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reset.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(455, 33)
        Me.reset.Margin = New System.Windows.Forms.Padding(2)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(24, 24)
        Me.reset.TabIndex = 87
        Me.reset.Text = "X"
        Me.reset.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.reset.UseVisualStyleBackColor = False
        '
        'mod_per
        '
        Me.mod_per.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mod_per.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mod_per.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_per.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mod_per.Location = New System.Drawing.Point(333, 65)
        Me.mod_per.Margin = New System.Windows.Forms.Padding(2)
        Me.mod_per.Name = "mod_per"
        Me.mod_per.Size = New System.Drawing.Size(146, 26)
        Me.mod_per.TabIndex = 84
        Me.mod_per.Text = "Modificar Persona"
        Me.mod_per.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "DNI/CUIL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 35)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 19)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Razón"
        '
        'razon
        '
        Me.razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.razon.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.razon.Location = New System.Drawing.Point(84, 32)
        Me.razon.Margin = New System.Windows.Forms.Padding(2)
        Me.razon.Name = "razon"
        Me.razon.Size = New System.Drawing.Size(284, 25)
        Me.razon.TabIndex = 81
        '
        'ca_switch
        '
        Me.ca_switch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ca_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ca_switch.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ca_switch.Location = New System.Drawing.Point(217, 65)
        Me.ca_switch.Margin = New System.Windows.Forms.Padding(2)
        Me.ca_switch.Name = "ca_switch"
        Me.ca_switch.Size = New System.Drawing.Size(106, 26)
        Me.ca_switch.TabIndex = 88
        Me.ca_switch.Text = "Mostrar CUIL"
        Me.ca_switch.UseVisualStyleBackColor = False
        '
        'dni
        '
        Me.dni.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni.Location = New System.Drawing.Point(84, 65)
        Me.dni.Mask = "99999999"
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(125, 27)
        Me.dni.TabIndex = 89
        Me.dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cuil
        '
        Me.cuil.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuil.Location = New System.Drawing.Point(84, 65)
        Me.cuil.Margin = New System.Windows.Forms.Padding(2)
        Me.cuil.Mask = "99-99999999-9"
        Me.cuil.Name = "cuil"
        Me.cuil.ReadOnly = True
        Me.cuil.Size = New System.Drawing.Size(125, 27)
        Me.cuil.TabIndex = 85
        Me.cuil.Text = "00000000000"
        Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.cuil.Visible = False
        '
        'ConsultaCuentaAgrupada
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Sigm.My.Resources.Resources.trama41
        Me.ClientSize = New System.Drawing.Size(1008, 341)
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.grupo_buscar_ca)
        Me.Controls.Add(Me.grupo_ca)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ConsultaCuentaAgrupada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cuenta Agrupada"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_ca.ResumeLayout(False)
        CType(Me.imp_lista_mod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_mod_ca.ResumeLayout(False)
        Me.grupo_mod_ca.PerformLayout()
        Me.grupo_con_ca.ResumeLayout(False)
        Me.grupo_con_ca.PerformLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_buscar_ca.ResumeLayout(False)
        Me.grupo_buscar_ca.PerformLayout()
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
    Friend WithEvents grupo_ca As System.Windows.Forms.Panel
    Friend WithEvents grupo_con_ca As System.Windows.Forms.Panel
    Friend WithEvents ca_con_preview As System.Windows.Forms.Button
    Friend WithEvents con_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents con_deuda As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ca_con_print As System.Windows.Forms.Button
    Friend WithEvents et_con_ca As System.Windows.Forms.Label
    Friend WithEvents grupo_mod_ca As System.Windows.Forms.Panel
    Friend WithEvents save_ca As System.Windows.Forms.Button
    Friend WithEvents et_mod_ca As System.Windows.Forms.Label
    Friend WithEvents imp_sepe As System.Windows.Forms.RadioButton
    Friend WithEvents imp_come As System.Windows.Forms.RadioButton
    Friend WithEvents imp_cata As System.Windows.Forms.RadioButton
    Friend WithEvents imp_auto As System.Windows.Forms.RadioButton
    Friend WithEvents imp_agua As System.Windows.Forms.RadioButton
    Friend WithEvents imp_baja As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents imp_alta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents imp_add As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents imp_razon As System.Windows.Forms.TextBox
    Friend WithEvents visor As System.Windows.Forms.DataGridView
    Friend WithEvents close_con_ca As System.Windows.Forms.Button
    Friend WithEvents mod_ca_imp_search As System.Windows.Forms.Button
    Friend WithEvents imp_lista_mod As System.Windows.Forms.DataGridView
    Friend WithEvents grupo_buscar_ca As System.Windows.Forms.Panel
    Friend WithEvents ca_search As System.Windows.Forms.Button
    Friend WithEvents mod_ca As System.Windows.Forms.Button
    Friend WithEvents con_ca As System.Windows.Forms.Button
    Friend WithEvents et_buscar_ca As System.Windows.Forms.Label
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents mod_per As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents razon As System.Windows.Forms.TextBox
    Friend WithEvents ca_switch As System.Windows.Forms.Button
    Friend WithEvents dni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cuil As System.Windows.Forms.MaskedTextBox

End Class
