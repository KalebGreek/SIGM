<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModInmueble
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
        Me.components = New System.ComponentModel.Container()
        Me.Menu1 = New System.Windows.Forms.MenuStrip()
        Me.Partida = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.siguiente = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.opr_id = New System.Windows.Forms.Label()
        Me.catastro_id = New System.Windows.Forms.Label()
        Me.operacion = New System.Windows.Forms.Label()
        Me.grupo_mod = New System.Windows.Forms.TabControl()
        Me.tab_catastro = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lote = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.parc = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.manz = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.secc = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.circ = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.zona = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.info_exp = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.info_estado = New System.Windows.Forms.Label()
        Me.info_cuil = New System.Windows.Forms.Label()
        Me.info_titular = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.info_uso = New System.Windows.Forms.Label()
        Me.info_cuenta = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.info_barrio = New System.Windows.Forms.Label()
        Me.info_ubicacion = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tab_ubicacion = New System.Windows.Forms.TabPage()
        Me.titular_id = New System.Windows.Forms.Label()
        Me.difunto = New System.Windows.Forms.CheckBox()
        Me.mod_titular = New System.Windows.Forms.Button()
        Me.titular = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cuil = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.archivado = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uso = New System.Windows.Forms.ComboBox()
        Me.barrio = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cuenta = New System.Windows.Forms.NumericUpDown()
        Me.tab_frente = New System.Windows.Forms.TabPage()
        Me.consulta_frente = New System.Windows.Forms.DataGridView()
        Me.menu_frente = New System.Windows.Forms.Panel()
        Me.add_frente = New System.Windows.Forms.Button()
        Me.del_frente = New System.Windows.Forms.Button()
        Me.ubicacion_principal = New System.Windows.Forms.Button()
        Me.tab_sup = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.existente = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cubierto = New System.Windows.Forms.NumericUpDown()
        Me.terreno = New System.Windows.Forms.NumericUpDown()
        Me.proyecto = New System.Windows.Forms.NumericUpDown()
        Me.relevamiento = New System.Windows.Forms.NumericUpDown()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.libre = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tab_caracter = New System.Windows.Forms.TabPage()
        Me.consulta_caract = New System.Windows.Forms.DataGridView()
        Me.menu_caract = New System.Windows.Forms.Panel()
        Me.del_car = New System.Windows.Forms.Button()
        Me.add_car = New System.Windows.Forms.Button()
        Me.lista_car = New System.Windows.Forms.ComboBox()
        Me.tab_copia = New System.Windows.Forms.TabPage()
        Me.consulta_copia = New System.Windows.Forms.DataGridView()
        Me.menu_copia = New System.Windows.Forms.Panel()
        Me.del_copia = New System.Windows.Forms.Button()
        Me.add_copia = New System.Windows.Forms.Button()
        Me.tipo_copia = New System.Windows.Forms.ComboBox()
        Me.BSFrente = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSCar = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSCopia = New System.Windows.Forms.BindingSource(Me.components)
        Me.subtitulo = New System.Windows.Forms.Label()
        Me.BSCat = New System.Windows.Forms.BindingSource(Me.components)
        Me.Menu1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grupo_mod.SuspendLayout()
        Me.tab_catastro.SuspendLayout()
        CType(Me.lote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.manz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.secc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.tab_ubicacion.SuspendLayout()
        CType(Me.cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_frente.SuspendLayout()
        CType(Me.consulta_frente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_frente.SuspendLayout()
        Me.tab_sup.SuspendLayout()
        CType(Me.existente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cubierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.terreno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relevamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.libre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_caracter.SuspendLayout()
        CType(Me.consulta_caract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_caract.SuspendLayout()
        Me.tab_copia.SuspendLayout()
        CType(Me.consulta_copia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu_copia.SuspendLayout()
        CType(Me.BSFrente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCopia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu1
        '
        Me.Menu1.AutoSize = False
        Me.Menu1.BackColor = System.Drawing.Color.Gray
        Me.Menu1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.Menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Partida, Me.ToolStripMenuItem1})
        Me.Menu1.Location = New System.Drawing.Point(0, 0)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Menu1.Size = New System.Drawing.Size(538, 33)
        Me.Menu1.TabIndex = 154
        Me.Menu1.Text = "MenuStrip1"
        '
        'Partida
        '
        Me.Partida.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!)
        Me.Partida.ForeColor = System.Drawing.Color.White
        Me.Partida.Name = "Partida"
        Me.Partida.Padding = New System.Windows.Forms.Padding(0)
        Me.Partida.Size = New System.Drawing.Size(93, 29)
        Me.Partida.Text = " Partida: -"
        Me.Partida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(106, 29)
        Me.ToolStripMenuItem1.Text = "CATASTRO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.back)
        Me.Panel1.Controls.Add(Me.siguiente)
        Me.Panel1.Controls.Add(Me.cancel)
        Me.Panel1.Controls.Add(Me.opr_id)
        Me.Panel1.Controls.Add(Me.catastro_id)
        Me.Panel1.Controls.Add(Me.operacion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 364)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 36)
        Me.Panel1.TabIndex = 155
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.back.Dock = System.Windows.Forms.DockStyle.Right
        Me.back.Enabled = False
        Me.back.FlatAppearance.BorderSize = 0
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.Location = New System.Drawing.Point(206, 0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(100, 32)
        Me.back.TabIndex = 904
        Me.back.Text = "< ATRÁS"
        Me.back.UseVisualStyleBackColor = False
        '
        'siguiente
        '
        Me.siguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.siguiente.Dock = System.Windows.Forms.DockStyle.Right
        Me.siguiente.FlatAppearance.BorderSize = 0
        Me.siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.siguiente.ForeColor = System.Drawing.Color.White
        Me.siguiente.Location = New System.Drawing.Point(306, 0)
        Me.siguiente.Name = "siguiente"
        Me.siguiente.Size = New System.Drawing.Size(136, 32)
        Me.siguiente.TabIndex = 901
        Me.siguiente.Text = "MODIFICAR  >"
        Me.siguiente.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.Location = New System.Drawing.Point(442, 0)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(92, 32)
        Me.cancel.TabIndex = 902
        Me.cancel.Text = "CERRAR"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'opr_id
        '
        Me.opr_id.AutoSize = True
        Me.opr_id.BackColor = System.Drawing.Color.Lime
        Me.opr_id.Location = New System.Drawing.Point(34, 2)
        Me.opr_id.Name = "opr_id"
        Me.opr_id.Size = New System.Drawing.Size(27, 22)
        Me.opr_id.TabIndex = 922
        Me.opr_id.Text = "-1"
        Me.opr_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'catastro_id
        '
        Me.catastro_id.AutoSize = True
        Me.catastro_id.BackColor = System.Drawing.Color.DarkOrange
        Me.catastro_id.Location = New System.Drawing.Point(9, 2)
        Me.catastro_id.Name = "catastro_id"
        Me.catastro_id.Size = New System.Drawing.Size(27, 22)
        Me.catastro_id.TabIndex = 919
        Me.catastro_id.Text = "-1"
        Me.catastro_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'operacion
        '
        Me.operacion.AutoSize = True
        Me.operacion.BackColor = System.Drawing.Color.DarkGray
        Me.operacion.Location = New System.Drawing.Point(156, 2)
        Me.operacion.Name = "operacion"
        Me.operacion.Size = New System.Drawing.Size(27, 22)
        Me.operacion.TabIndex = 920
        Me.operacion.Text = "-1"
        Me.operacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grupo_mod
        '
        Me.grupo_mod.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.grupo_mod.Controls.Add(Me.tab_catastro)
        Me.grupo_mod.Controls.Add(Me.tab_ubicacion)
        Me.grupo_mod.Controls.Add(Me.tab_frente)
        Me.grupo_mod.Controls.Add(Me.tab_sup)
        Me.grupo_mod.Controls.Add(Me.tab_caracter)
        Me.grupo_mod.Controls.Add(Me.tab_copia)
        Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_mod.ItemSize = New System.Drawing.Size(59, 30)
        Me.grupo_mod.Location = New System.Drawing.Point(0, 60)
        Me.grupo_mod.Margin = New System.Windows.Forms.Padding(0)
        Me.grupo_mod.Name = "grupo_mod"
        Me.grupo_mod.SelectedIndex = 0
        Me.grupo_mod.Size = New System.Drawing.Size(538, 338)
        Me.grupo_mod.TabIndex = 353
        Me.grupo_mod.TabStop = False
        '
        'tab_catastro
        '
        Me.tab_catastro.BackColor = System.Drawing.Color.Gainsboro
        Me.tab_catastro.Controls.Add(Me.Label23)
        Me.tab_catastro.Controls.Add(Me.lote)
        Me.tab_catastro.Controls.Add(Me.Label17)
        Me.tab_catastro.Controls.Add(Me.parc)
        Me.tab_catastro.Controls.Add(Me.Label13)
        Me.tab_catastro.Controls.Add(Me.manz)
        Me.tab_catastro.Controls.Add(Me.Label12)
        Me.tab_catastro.Controls.Add(Me.secc)
        Me.tab_catastro.Controls.Add(Me.Label11)
        Me.tab_catastro.Controls.Add(Me.circ)
        Me.tab_catastro.Controls.Add(Me.Label10)
        Me.tab_catastro.Controls.Add(Me.zona)
        Me.tab_catastro.Controls.Add(Me.Label9)
        Me.tab_catastro.Controls.Add(Me.info_exp)
        Me.tab_catastro.Controls.Add(Me.Label21)
        Me.tab_catastro.Controls.Add(Me.info_estado)
        Me.tab_catastro.Controls.Add(Me.info_cuil)
        Me.tab_catastro.Controls.Add(Me.info_titular)
        Me.tab_catastro.Controls.Add(Me.Label20)
        Me.tab_catastro.Controls.Add(Me.Label14)
        Me.tab_catastro.Controls.Add(Me.Label1)
        Me.tab_catastro.Controls.Add(Me.Panel5)
        Me.tab_catastro.Location = New System.Drawing.Point(4, 4)
        Me.tab_catastro.Name = "tab_catastro"
        Me.tab_catastro.Size = New System.Drawing.Size(530, 300)
        Me.tab_catastro.TabIndex = 6
        Me.tab_catastro.Text = "Catastro"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Silver
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.Label23.Location = New System.Drawing.Point(435, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(17, 30)
        Me.Label23.TabIndex = 932
        Me.Label23.Text = "L"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lote
        '
        Me.lote.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lote.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.lote.Location = New System.Drawing.Point(437, 23)
        Me.lote.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.lote.Name = "lote"
        Me.lote.Size = New System.Drawing.Size(54, 29)
        Me.lote.TabIndex = 931
        Me.lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lote.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Silver
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.Label17.Location = New System.Drawing.Point(372, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 30)
        Me.Label17.TabIndex = 930
        Me.Label17.Text = "P"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'parc
        '
        Me.parc.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.parc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.parc.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.parc.Location = New System.Drawing.Point(374, 23)
        Me.parc.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.parc.Name = "parc"
        Me.parc.Size = New System.Drawing.Size(54, 29)
        Me.parc.TabIndex = 929
        Me.parc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.parc.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.Label13.Location = New System.Drawing.Point(308, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 30)
        Me.Label13.TabIndex = 928
        Me.Label13.Text = "M"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'manz
        '
        Me.manz.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.manz.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.manz.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.manz.Location = New System.Drawing.Point(310, 23)
        Me.manz.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.manz.Name = "manz"
        Me.manz.Size = New System.Drawing.Size(54, 29)
        Me.manz.TabIndex = 927
        Me.manz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.manz.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.Label12.Location = New System.Drawing.Point(245, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 30)
        Me.Label12.TabIndex = 926
        Me.Label12.Text = "S"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'secc
        '
        Me.secc.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.secc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.secc.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.secc.Location = New System.Drawing.Point(247, 23)
        Me.secc.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.secc.Name = "secc"
        Me.secc.Size = New System.Drawing.Size(54, 29)
        Me.secc.TabIndex = 925
        Me.secc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.secc.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.Label11.Location = New System.Drawing.Point(181, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 30)
        Me.Label11.TabIndex = 924
        Me.Label11.Text = "C"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'circ
        '
        Me.circ.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.circ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.circ.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.circ.Location = New System.Drawing.Point(184, 23)
        Me.circ.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.circ.Name = "circ"
        Me.circ.Size = New System.Drawing.Size(54, 29)
        Me.circ.TabIndex = 923
        Me.circ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.circ.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.Label10.Location = New System.Drawing.Point(132, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 30)
        Me.Label10.TabIndex = 922
        Me.Label10.Text = "Z"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'zona
        '
        Me.zona.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.zona.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.zona.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.zona.Location = New System.Drawing.Point(134, 23)
        Me.zona.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.zona.Name = "zona"
        Me.zona.Size = New System.Drawing.Size(42, 29)
        Me.zona.TabIndex = 921
        Me.zona.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.zona.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("PF DinText Pro Medium", 16.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(30, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 26)
        Me.Label9.TabIndex = 920
        Me.Label9.Text = "PARTIDA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'info_exp
        '
        Me.info_exp.AutoSize = True
        Me.info_exp.Font = New System.Drawing.Font("PF DinText Pro Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_exp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.info_exp.Location = New System.Drawing.Point(128, 254)
        Me.info_exp.Name = "info_exp"
        Me.info_exp.Size = New System.Drawing.Size(20, 24)
        Me.info_exp.TabIndex = 919
        Me.info_exp.Text = "0"
        Me.info_exp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(32, 254)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 22)
        Me.Label21.TabIndex = 918
        Me.Label21.Text = "Expediente"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'info_estado
        '
        Me.info_estado.AutoSize = True
        Me.info_estado.Font = New System.Drawing.Font("PF DinText Pro Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_estado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.info_estado.Location = New System.Drawing.Point(128, 227)
        Me.info_estado.Name = "info_estado"
        Me.info_estado.Size = New System.Drawing.Size(226, 24)
        Me.info_estado.TabIndex = 917
        Me.info_estado.Text = "SELECCIONAR INMUEBLE"
        Me.info_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'info_cuil
        '
        Me.info_cuil.AutoSize = True
        Me.info_cuil.Font = New System.Drawing.Font("PF DinText Pro Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_cuil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.info_cuil.Location = New System.Drawing.Point(129, 94)
        Me.info_cuil.Name = "info_cuil"
        Me.info_cuil.Size = New System.Drawing.Size(46, 23)
        Me.info_cuil.TabIndex = 913
        Me.info_cuil.Text = " -   -"
        Me.info_cuil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'info_titular
        '
        Me.info_titular.AutoSize = True
        Me.info_titular.Font = New System.Drawing.Font("PF DinText Pro Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_titular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.info_titular.Location = New System.Drawing.Point(129, 67)
        Me.info_titular.Name = "info_titular"
        Me.info_titular.Size = New System.Drawing.Size(23, 23)
        Me.info_titular.TabIndex = 912
        Me.info_titular.Text = " -"
        Me.info_titular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(64, 227)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 22)
        Me.Label20.TabIndex = 910
        Me.Label20.Text = "Estado"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(56, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 22)
        Me.Label14.TabIndex = 906
        Me.Label14.Text = "N° CUIL"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(66, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 905
        Me.Label1.Text = "Titular"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.info_uso)
        Me.Panel5.Controls.Add(Me.info_cuenta)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.info_barrio)
        Me.Panel5.Controls.Add(Me.info_ubicacion)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 121)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(530, 102)
        Me.Panel5.TabIndex = 911
        '
        'info_uso
        '
        Me.info_uso.AutoSize = True
        Me.info_uso.Font = New System.Drawing.Font("PF DinText Pro Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_uso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.info_uso.Location = New System.Drawing.Point(128, 51)
        Me.info_uso.Name = "info_uso"
        Me.info_uso.Size = New System.Drawing.Size(28, 23)
        Me.info_uso.TabIndex = 923
        Me.info_uso.Text = " - "
        Me.info_uso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'info_cuenta
        '
        Me.info_cuenta.AutoSize = True
        Me.info_cuenta.Font = New System.Drawing.Font("PF DinText Pro Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_cuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.info_cuenta.Location = New System.Drawing.Point(128, 75)
        Me.info_cuenta.Name = "info_cuenta"
        Me.info_cuenta.Size = New System.Drawing.Size(28, 23)
        Me.info_cuenta.TabIndex = 922
        Me.info_cuenta.Text = " - "
        Me.info_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label24.Location = New System.Drawing.Point(62, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 22)
        Me.Label24.TabIndex = 921
        Me.Label24.Text = "Cuenta"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label18.Location = New System.Drawing.Point(86, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 22)
        Me.Label18.TabIndex = 920
        Me.Label18.Text = "Uso"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label15.Location = New System.Drawing.Point(43, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 22)
        Me.Label15.TabIndex = 916
        Me.Label15.Text = "Ubicación"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'info_barrio
        '
        Me.info_barrio.AutoSize = True
        Me.info_barrio.Font = New System.Drawing.Font("PF DinText Pro Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_barrio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.info_barrio.Location = New System.Drawing.Point(128, 27)
        Me.info_barrio.Name = "info_barrio"
        Me.info_barrio.Size = New System.Drawing.Size(28, 23)
        Me.info_barrio.TabIndex = 919
        Me.info_barrio.Text = " - "
        Me.info_barrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'info_ubicacion
        '
        Me.info_ubicacion.AutoSize = True
        Me.info_ubicacion.Font = New System.Drawing.Font("PF DinText Pro Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_ubicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.info_ubicacion.Location = New System.Drawing.Point(128, 3)
        Me.info_ubicacion.Name = "info_ubicacion"
        Me.info_ubicacion.Size = New System.Drawing.Size(28, 23)
        Me.info_ubicacion.TabIndex = 918
        Me.info_ubicacion.Text = " - "
        Me.info_ubicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label16.Location = New System.Drawing.Point(68, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 22)
        Me.Label16.TabIndex = 917
        Me.Label16.Text = "Barrio"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tab_ubicacion
        '
        Me.tab_ubicacion.BackColor = System.Drawing.Color.Gainsboro
        Me.tab_ubicacion.Controls.Add(Me.titular_id)
        Me.tab_ubicacion.Controls.Add(Me.difunto)
        Me.tab_ubicacion.Controls.Add(Me.mod_titular)
        Me.tab_ubicacion.Controls.Add(Me.titular)
        Me.tab_ubicacion.Controls.Add(Me.Label26)
        Me.tab_ubicacion.Controls.Add(Me.Label37)
        Me.tab_ubicacion.Controls.Add(Me.cuil)
        Me.tab_ubicacion.Controls.Add(Me.Label8)
        Me.tab_ubicacion.Controls.Add(Me.archivado)
        Me.tab_ubicacion.Controls.Add(Me.Label2)
        Me.tab_ubicacion.Controls.Add(Me.uso)
        Me.tab_ubicacion.Controls.Add(Me.barrio)
        Me.tab_ubicacion.Controls.Add(Me.Label49)
        Me.tab_ubicacion.Controls.Add(Me.cuenta)
        Me.tab_ubicacion.Location = New System.Drawing.Point(4, 4)
        Me.tab_ubicacion.Name = "tab_ubicacion"
        Me.tab_ubicacion.Size = New System.Drawing.Size(530, 300)
        Me.tab_ubicacion.TabIndex = 1
        Me.tab_ubicacion.Text = "Detalles"
        '
        'titular_id
        '
        Me.titular_id.AutoSize = True
        Me.titular_id.BackColor = System.Drawing.Color.Aqua
        Me.titular_id.Location = New System.Drawing.Point(246, 164)
        Me.titular_id.Name = "titular_id"
        Me.titular_id.Size = New System.Drawing.Size(19, 22)
        Me.titular_id.TabIndex = 938
        Me.titular_id.Text = "0"
        Me.titular_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.titular_id.Visible = False
        '
        'difunto
        '
        Me.difunto.AutoSize = True
        Me.difunto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.difunto.Enabled = False
        Me.difunto.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.difunto.Location = New System.Drawing.Point(26, 193)
        Me.difunto.Name = "difunto"
        Me.difunto.Size = New System.Drawing.Size(83, 26)
        Me.difunto.TabIndex = 937
        Me.difunto.Text = "Difunto"
        Me.difunto.UseVisualStyleBackColor = True
        '
        'mod_titular
        '
        Me.mod_titular.BackColor = System.Drawing.Color.DimGray
        Me.mod_titular.FlatAppearance.BorderSize = 0
        Me.mod_titular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mod_titular.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.mod_titular.ForeColor = System.Drawing.Color.White
        Me.mod_titular.Location = New System.Drawing.Point(375, 126)
        Me.mod_titular.Name = "mod_titular"
        Me.mod_titular.Size = New System.Drawing.Size(110, 30)
        Me.mod_titular.TabIndex = 936
        Me.mod_titular.Text = "MODIFICAR"
        Me.mod_titular.UseVisualStyleBackColor = False
        '
        'titular
        '
        Me.titular.BackColor = System.Drawing.SystemColors.Window
        Me.titular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.titular.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.titular.Location = New System.Drawing.Point(93, 126)
        Me.titular.Name = "titular"
        Me.titular.ReadOnly = True
        Me.titular.Size = New System.Drawing.Size(276, 30)
        Me.titular.TabIndex = 934
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(32, 129)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 22)
        Me.Label26.TabIndex = 932
        Me.Label26.Text = "Titular"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(45, 164)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(46, 22)
        Me.Label37.TabIndex = 933
        Me.Label37.Text = "CUIL"
        '
        'cuil
        '
        Me.cuil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cuil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cuil.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.cuil.Location = New System.Drawing.Point(94, 164)
        Me.cuil.Mask = "99-99999999-9"
        Me.cuil.Name = "cuil"
        Me.cuil.ReadOnly = True
        Me.cuil.Size = New System.Drawing.Size(146, 23)
        Me.cuil.TabIndex = 935
        Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 27)
        Me.Label8.TabIndex = 928
        Me.Label8.Text = "Cuenta N°"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'archivado
        '
        Me.archivado.AutoSize = True
        Me.archivado.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.archivado.Location = New System.Drawing.Point(172, 13)
        Me.archivado.Name = "archivado"
        Me.archivado.Size = New System.Drawing.Size(103, 26)
        Me.archivado.TabIndex = 927
        Me.archivado.Text = "Archivado"
        Me.archivado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(53, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 22)
        Me.Label2.TabIndex = 924
        Me.Label2.Text = "Uso"
        '
        'uso
        '
        Me.uso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uso.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.uso.FormattingEnabled = True
        Me.uso.Items.AddRange(New Object() {"COMERCIAL", "INDUSTRIAL", "INFRAESTRUCTURA", "INSTITUCIONAL", "PROHIBIDO", "RESIDENCIAL", "RESIDENCIAL (SOCIAL)", "SERVICIOS VARIOS", "TURISTICO"})
        Me.uso.Location = New System.Drawing.Point(93, 87)
        Me.uso.Name = "uso"
        Me.uso.Size = New System.Drawing.Size(393, 30)
        Me.uso.TabIndex = 923
        '
        'barrio
        '
        Me.barrio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.barrio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.barrio.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.barrio.FormattingEnabled = True
        Me.barrio.Items.AddRange(New Object() {"BUEN RETIRO", "CENTRO", "CURA BROCHERO", "DEL MILAGRO", "EL ALTO RESBALOSO", "EL PUEBLITO", "EL VALLE", "LA AGUADITA", "LAS CALERAS", "LAS CHACRAS", "LOS MOLLES", "LOS POZOS", "PARQUE", "PIEDRAS ANCHAS", "SAN JAVIER", "SAN MIGUEL", "SAN NICOLAS", "SARGENTO CABRAL", "TERESA DE CALCUTA", "VIRGEN DEL CARMEN"})
        Me.barrio.Location = New System.Drawing.Point(93, 50)
        Me.barrio.Name = "barrio"
        Me.barrio.Size = New System.Drawing.Size(393, 30)
        Me.barrio.TabIndex = 220
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(35, 54)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(56, 22)
        Me.Label49.TabIndex = 243
        Me.Label49.Text = "Barrio"
        '
        'cuenta
        '
        Me.cuenta.BackColor = System.Drawing.Color.White
        Me.cuenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cuenta.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.cuenta.Location = New System.Drawing.Point(75, 14)
        Me.cuenta.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Size = New System.Drawing.Size(87, 26)
        Me.cuenta.TabIndex = 931
        Me.cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cuenta.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'tab_frente
        '
        Me.tab_frente.BackColor = System.Drawing.Color.Gainsboro
        Me.tab_frente.Controls.Add(Me.consulta_frente)
        Me.tab_frente.Controls.Add(Me.menu_frente)
        Me.tab_frente.Location = New System.Drawing.Point(4, 4)
        Me.tab_frente.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_frente.Name = "tab_frente"
        Me.tab_frente.Size = New System.Drawing.Size(530, 300)
        Me.tab_frente.TabIndex = 5
        Me.tab_frente.Text = "Frentes"
        '
        'consulta_frente
        '
        Me.consulta_frente.AllowUserToAddRows = False
        Me.consulta_frente.AllowUserToDeleteRows = False
        Me.consulta_frente.AllowUserToResizeRows = False
        Me.consulta_frente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.consulta_frente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consulta_frente.Location = New System.Drawing.Point(0, 30)
        Me.consulta_frente.Margin = New System.Windows.Forms.Padding(0)
        Me.consulta_frente.MultiSelect = False
        Me.consulta_frente.Name = "consulta_frente"
        Me.consulta_frente.ReadOnly = True
        Me.consulta_frente.RowHeadersVisible = False
        Me.consulta_frente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.consulta_frente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.consulta_frente.Size = New System.Drawing.Size(530, 270)
        Me.consulta_frente.TabIndex = 388
        '
        'menu_frente
        '
        Me.menu_frente.BackColor = System.Drawing.Color.Transparent
        Me.menu_frente.Controls.Add(Me.add_frente)
        Me.menu_frente.Controls.Add(Me.del_frente)
        Me.menu_frente.Controls.Add(Me.ubicacion_principal)
        Me.menu_frente.Dock = System.Windows.Forms.DockStyle.Top
        Me.menu_frente.Location = New System.Drawing.Point(0, 0)
        Me.menu_frente.Margin = New System.Windows.Forms.Padding(0)
        Me.menu_frente.Name = "menu_frente"
        Me.menu_frente.Size = New System.Drawing.Size(530, 30)
        Me.menu_frente.TabIndex = 389
        '
        'add_frente
        '
        Me.add_frente.BackColor = System.Drawing.Color.Transparent
        Me.add_frente.Dock = System.Windows.Forms.DockStyle.Right
        Me.add_frente.FlatAppearance.BorderSize = 0
        Me.add_frente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_frente.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.add_frente.ForeColor = System.Drawing.Color.Black
        Me.add_frente.Location = New System.Drawing.Point(137, 0)
        Me.add_frente.Name = "add_frente"
        Me.add_frente.Size = New System.Drawing.Size(100, 30)
        Me.add_frente.TabIndex = 347
        Me.add_frente.Text = "AGREGAR"
        Me.add_frente.UseVisualStyleBackColor = False
        '
        'del_frente
        '
        Me.del_frente.BackColor = System.Drawing.Color.Transparent
        Me.del_frente.Dock = System.Windows.Forms.DockStyle.Right
        Me.del_frente.FlatAppearance.BorderSize = 0
        Me.del_frente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del_frente.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.del_frente.ForeColor = System.Drawing.Color.Black
        Me.del_frente.Location = New System.Drawing.Point(237, 0)
        Me.del_frente.Name = "del_frente"
        Me.del_frente.Size = New System.Drawing.Size(100, 30)
        Me.del_frente.TabIndex = 349
        Me.del_frente.Text = "ELIMINAR"
        Me.del_frente.UseVisualStyleBackColor = False
        '
        'ubicacion_principal
        '
        Me.ubicacion_principal.BackColor = System.Drawing.Color.Transparent
        Me.ubicacion_principal.Dock = System.Windows.Forms.DockStyle.Right
        Me.ubicacion_principal.FlatAppearance.BorderSize = 0
        Me.ubicacion_principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ubicacion_principal.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.ubicacion_principal.ForeColor = System.Drawing.Color.Black
        Me.ubicacion_principal.Location = New System.Drawing.Point(337, 0)
        Me.ubicacion_principal.Name = "ubicacion_principal"
        Me.ubicacion_principal.Size = New System.Drawing.Size(193, 30)
        Me.ubicacion_principal.TabIndex = 350
        Me.ubicacion_principal.Text = "UBICACION PRINCIPAL"
        Me.ubicacion_principal.UseVisualStyleBackColor = False
        '
        'tab_sup
        '
        Me.tab_sup.BackColor = System.Drawing.Color.Gainsboro
        Me.tab_sup.Controls.Add(Me.Label27)
        Me.tab_sup.Controls.Add(Me.existente)
        Me.tab_sup.Controls.Add(Me.Label25)
        Me.tab_sup.Controls.Add(Me.Label7)
        Me.tab_sup.Controls.Add(Me.Label6)
        Me.tab_sup.Controls.Add(Me.Label5)
        Me.tab_sup.Controls.Add(Me.Label4)
        Me.tab_sup.Controls.Add(Me.Label3)
        Me.tab_sup.Controls.Add(Me.Label48)
        Me.tab_sup.Controls.Add(Me.cubierto)
        Me.tab_sup.Controls.Add(Me.terreno)
        Me.tab_sup.Controls.Add(Me.proyecto)
        Me.tab_sup.Controls.Add(Me.relevamiento)
        Me.tab_sup.Controls.Add(Me.Label41)
        Me.tab_sup.Controls.Add(Me.Label40)
        Me.tab_sup.Controls.Add(Me.Label19)
        Me.tab_sup.Controls.Add(Me.libre)
        Me.tab_sup.Controls.Add(Me.Label22)
        Me.tab_sup.Location = New System.Drawing.Point(4, 4)
        Me.tab_sup.Name = "tab_sup"
        Me.tab_sup.Size = New System.Drawing.Size(530, 300)
        Me.tab_sup.TabIndex = 3
        Me.tab_sup.Text = "Superficies"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(274, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 21)
        Me.Label27.TabIndex = 355
        Me.Label27.Text = "M²"
        '
        'existente
        '
        Me.existente.DecimalPlaces = 2
        Me.existente.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.existente.ForeColor = System.Drawing.Color.Black
        Me.existente.Location = New System.Drawing.Point(117, 8)
        Me.existente.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.existente.Name = "existente"
        Me.existente.Size = New System.Drawing.Size(155, 28)
        Me.existente.TabIndex = 354
        Me.existente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.existente.ThousandsSeparator = True
        Me.existente.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(35, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 21)
        Me.Label25.TabIndex = 353
        Me.Label25.Text = "Existente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(274, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 21)
        Me.Label7.TabIndex = 352
        Me.Label7.Text = "M²"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(274, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 21)
        Me.Label6.TabIndex = 351
        Me.Label6.Text = "M²"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(274, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 21)
        Me.Label5.TabIndex = 350
        Me.Label5.Text = "M²"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(274, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 21)
        Me.Label4.TabIndex = 349
        Me.Label4.Text = "M²"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(274, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 21)
        Me.Label3.TabIndex = 348
        Me.Label3.Text = "M²"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(40, 195)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 21)
        Me.Label48.TabIndex = 220
        Me.Label48.Text = "Cubierto"
        '
        'cubierto
        '
        Me.cubierto.DecimalPlaces = 2
        Me.cubierto.Enabled = False
        Me.cubierto.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cubierto.ForeColor = System.Drawing.Color.Black
        Me.cubierto.Location = New System.Drawing.Point(117, 193)
        Me.cubierto.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.cubierto.Name = "cubierto"
        Me.cubierto.Size = New System.Drawing.Size(155, 28)
        Me.cubierto.TabIndex = 225
        Me.cubierto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cubierto.ThousandsSeparator = True
        Me.cubierto.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'terreno
        '
        Me.terreno.DecimalPlaces = 2
        Me.terreno.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terreno.ForeColor = System.Drawing.Color.Black
        Me.terreno.Location = New System.Drawing.Point(117, 119)
        Me.terreno.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.terreno.Name = "terreno"
        Me.terreno.Size = New System.Drawing.Size(155, 28)
        Me.terreno.TabIndex = 223
        Me.terreno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.terreno.ThousandsSeparator = True
        Me.terreno.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'proyecto
        '
        Me.proyecto.DecimalPlaces = 2
        Me.proyecto.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proyecto.ForeColor = System.Drawing.Color.Black
        Me.proyecto.Location = New System.Drawing.Point(117, 45)
        Me.proyecto.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.proyecto.Name = "proyecto"
        Me.proyecto.Size = New System.Drawing.Size(155, 28)
        Me.proyecto.TabIndex = 221
        Me.proyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.proyecto.ThousandsSeparator = True
        Me.proyecto.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'relevamiento
        '
        Me.relevamiento.DecimalPlaces = 2
        Me.relevamiento.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relevamiento.ForeColor = System.Drawing.Color.Black
        Me.relevamiento.Location = New System.Drawing.Point(117, 82)
        Me.relevamiento.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.relevamiento.Name = "relevamiento"
        Me.relevamiento.Size = New System.Drawing.Size(155, 28)
        Me.relevamiento.TabIndex = 222
        Me.relevamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.relevamiento.ThousandsSeparator = True
        Me.relevamiento.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(65, 158)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(47, 21)
        Me.Label41.TabIndex = 219
        Me.Label41.Text = "Libre"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(37, 47)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(75, 21)
        Me.Label40.TabIndex = 218
        Me.Label40.Text = "Proyecto"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(48, 121)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 21)
        Me.Label19.TabIndex = 216
        Me.Label19.Text = "Terreno"
        '
        'libre
        '
        Me.libre.DecimalPlaces = 2
        Me.libre.Enabled = False
        Me.libre.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libre.ForeColor = System.Drawing.Color.Black
        Me.libre.Location = New System.Drawing.Point(117, 156)
        Me.libre.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.libre.Name = "libre"
        Me.libre.Size = New System.Drawing.Size(155, 28)
        Me.libre.TabIndex = 224
        Me.libre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.libre.ThousandsSeparator = True
        Me.libre.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(5, 84)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(107, 21)
        Me.Label22.TabIndex = 217
        Me.Label22.Text = "Relevamiento"
        '
        'tab_caracter
        '
        Me.tab_caracter.BackColor = System.Drawing.Color.Gainsboro
        Me.tab_caracter.Controls.Add(Me.consulta_caract)
        Me.tab_caracter.Controls.Add(Me.menu_caract)
        Me.tab_caracter.Location = New System.Drawing.Point(4, 4)
        Me.tab_caracter.Name = "tab_caracter"
        Me.tab_caracter.Size = New System.Drawing.Size(530, 300)
        Me.tab_caracter.TabIndex = 2
        Me.tab_caracter.Text = "Características"
        '
        'consulta_caract
        '
        Me.consulta_caract.AllowUserToAddRows = False
        Me.consulta_caract.AllowUserToDeleteRows = False
        Me.consulta_caract.AllowUserToResizeRows = False
        Me.consulta_caract.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.consulta_caract.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consulta_caract.Location = New System.Drawing.Point(0, 30)
        Me.consulta_caract.Margin = New System.Windows.Forms.Padding(2)
        Me.consulta_caract.MultiSelect = False
        Me.consulta_caract.Name = "consulta_caract"
        Me.consulta_caract.RowHeadersVisible = False
        Me.consulta_caract.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.consulta_caract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.consulta_caract.Size = New System.Drawing.Size(530, 270)
        Me.consulta_caract.TabIndex = 383
        '
        'menu_caract
        '
        Me.menu_caract.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.menu_caract.Controls.Add(Me.del_car)
        Me.menu_caract.Controls.Add(Me.add_car)
        Me.menu_caract.Controls.Add(Me.lista_car)
        Me.menu_caract.Dock = System.Windows.Forms.DockStyle.Top
        Me.menu_caract.Location = New System.Drawing.Point(0, 0)
        Me.menu_caract.Name = "menu_caract"
        Me.menu_caract.Size = New System.Drawing.Size(530, 30)
        Me.menu_caract.TabIndex = 384
        '
        'del_car
        '
        Me.del_car.BackColor = System.Drawing.Color.Gainsboro
        Me.del_car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.del_car.Dock = System.Windows.Forms.DockStyle.Left
        Me.del_car.Enabled = False
        Me.del_car.FlatAppearance.BorderSize = 0
        Me.del_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del_car.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.del_car.ForeColor = System.Drawing.Color.Black
        Me.del_car.Location = New System.Drawing.Point(430, 0)
        Me.del_car.Name = "del_car"
        Me.del_car.Size = New System.Drawing.Size(100, 30)
        Me.del_car.TabIndex = 349
        Me.del_car.Text = "ELIMINAR"
        Me.del_car.UseVisualStyleBackColor = False
        '
        'add_car
        '
        Me.add_car.BackColor = System.Drawing.Color.Gainsboro
        Me.add_car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.add_car.Dock = System.Windows.Forms.DockStyle.Left
        Me.add_car.Enabled = False
        Me.add_car.FlatAppearance.BorderSize = 0
        Me.add_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_car.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.add_car.ForeColor = System.Drawing.Color.Black
        Me.add_car.Location = New System.Drawing.Point(331, 0)
        Me.add_car.Name = "add_car"
        Me.add_car.Size = New System.Drawing.Size(99, 30)
        Me.add_car.TabIndex = 347
        Me.add_car.Text = "AGREGAR"
        Me.add_car.UseVisualStyleBackColor = False
        '
        'lista_car
        '
        Me.lista_car.Dock = System.Windows.Forms.DockStyle.Left
        Me.lista_car.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lista_car.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.lista_car.FormattingEnabled = True
        Me.lista_car.Items.AddRange(New Object() {"AGUA CORRIENTE", "LUZ", "GAS NATURAL", "TELÉFONO", "PILETA", "OTRA"})
        Me.lista_car.Location = New System.Drawing.Point(0, 0)
        Me.lista_car.Name = "lista_car"
        Me.lista_car.Size = New System.Drawing.Size(331, 28)
        Me.lista_car.TabIndex = 350
        '
        'tab_copia
        '
        Me.tab_copia.BackColor = System.Drawing.Color.Gainsboro
        Me.tab_copia.Controls.Add(Me.consulta_copia)
        Me.tab_copia.Controls.Add(Me.menu_copia)
        Me.tab_copia.Location = New System.Drawing.Point(4, 4)
        Me.tab_copia.Name = "tab_copia"
        Me.tab_copia.Size = New System.Drawing.Size(530, 300)
        Me.tab_copia.TabIndex = 4
        Me.tab_copia.Text = "Copias Digitales"
        '
        'consulta_copia
        '
        Me.consulta_copia.AllowUserToAddRows = False
        Me.consulta_copia.AllowUserToDeleteRows = False
        Me.consulta_copia.AllowUserToResizeRows = False
        Me.consulta_copia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.consulta_copia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.consulta_copia.Location = New System.Drawing.Point(0, 30)
        Me.consulta_copia.Margin = New System.Windows.Forms.Padding(2)
        Me.consulta_copia.MultiSelect = False
        Me.consulta_copia.Name = "consulta_copia"
        Me.consulta_copia.ReadOnly = True
        Me.consulta_copia.RowHeadersVisible = False
        Me.consulta_copia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.consulta_copia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.consulta_copia.Size = New System.Drawing.Size(530, 270)
        Me.consulta_copia.TabIndex = 378
        '
        'menu_copia
        '
        Me.menu_copia.BackColor = System.Drawing.Color.Gainsboro
        Me.menu_copia.Controls.Add(Me.del_copia)
        Me.menu_copia.Controls.Add(Me.add_copia)
        Me.menu_copia.Controls.Add(Me.tipo_copia)
        Me.menu_copia.Dock = System.Windows.Forms.DockStyle.Top
        Me.menu_copia.Location = New System.Drawing.Point(0, 0)
        Me.menu_copia.Name = "menu_copia"
        Me.menu_copia.Size = New System.Drawing.Size(530, 30)
        Me.menu_copia.TabIndex = 380
        '
        'del_copia
        '
        Me.del_copia.BackColor = System.Drawing.Color.Gainsboro
        Me.del_copia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.del_copia.Dock = System.Windows.Forms.DockStyle.Left
        Me.del_copia.Enabled = False
        Me.del_copia.FlatAppearance.BorderSize = 0
        Me.del_copia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del_copia.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.del_copia.ForeColor = System.Drawing.Color.Black
        Me.del_copia.Location = New System.Drawing.Point(430, 0)
        Me.del_copia.Name = "del_copia"
        Me.del_copia.Size = New System.Drawing.Size(100, 30)
        Me.del_copia.TabIndex = 351
        Me.del_copia.Text = "ELIMINAR"
        Me.del_copia.UseVisualStyleBackColor = False
        '
        'add_copia
        '
        Me.add_copia.BackColor = System.Drawing.Color.Gainsboro
        Me.add_copia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.add_copia.Dock = System.Windows.Forms.DockStyle.Left
        Me.add_copia.Enabled = False
        Me.add_copia.FlatAppearance.BorderSize = 0
        Me.add_copia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_copia.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.add_copia.ForeColor = System.Drawing.Color.Black
        Me.add_copia.Location = New System.Drawing.Point(331, 0)
        Me.add_copia.Name = "add_copia"
        Me.add_copia.Size = New System.Drawing.Size(99, 30)
        Me.add_copia.TabIndex = 350
        Me.add_copia.Text = "AGREGAR"
        Me.add_copia.UseVisualStyleBackColor = False
        '
        'tipo_copia
        '
        Me.tipo_copia.Dock = System.Windows.Forms.DockStyle.Left
        Me.tipo_copia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_copia.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.tipo_copia.FormattingEnabled = True
        Me.tipo_copia.Items.AddRange(New Object() {"DONACION DE CALLE", "DONACION DE ESPACIO MUNICIPAL", "ESCRITURA O POSESION", "FACTIBILIDAD DE LUZ", "FACTIBILIDAD DE AGUA", "PLANO COLEGIADO", "PREVIA DE CATASTRO", "PREVIA MUNICIPAL", "SOLICITUD LINEA MUNICIPAL", "SOLICITUD FINAL DE OBRA"})
        Me.tipo_copia.Location = New System.Drawing.Point(0, 0)
        Me.tipo_copia.Name = "tipo_copia"
        Me.tipo_copia.Size = New System.Drawing.Size(331, 28)
        Me.tipo_copia.TabIndex = 348
        '
        'BSCar
        '
        '
        'BSCopia
        '
        '
        'subtitulo
        '
        Me.subtitulo.BackColor = System.Drawing.Color.White
        Me.subtitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.subtitulo.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!, System.Drawing.FontStyle.Bold)
        Me.subtitulo.ForeColor = System.Drawing.Color.Gray
        Me.subtitulo.Location = New System.Drawing.Point(0, 33)
        Me.subtitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.subtitulo.Name = "subtitulo"
        Me.subtitulo.Size = New System.Drawing.Size(538, 27)
        Me.subtitulo.TabIndex = 372
        Me.subtitulo.Text = " INGRESAR N° DE PARTIDA"
        Me.subtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModInmueble
        '
        Me.AcceptButton = Me.siguiente
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton = Me.cancel
        Me.ClientSize = New System.Drawing.Size(538, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grupo_mod)
        Me.Controls.Add(Me.subtitulo)
        Me.Controls.Add(Me.Menu1)
        Me.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModInmueble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "INMUEBLE"
        Me.Menu1.ResumeLayout(False)
        Me.Menu1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grupo_mod.ResumeLayout(False)
        Me.tab_catastro.ResumeLayout(False)
        Me.tab_catastro.PerformLayout()
        CType(Me.lote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.manz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.secc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tab_ubicacion.ResumeLayout(False)
        Me.tab_ubicacion.PerformLayout()
        CType(Me.cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_frente.ResumeLayout(False)
        CType(Me.consulta_frente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_frente.ResumeLayout(False)
        Me.tab_sup.ResumeLayout(False)
        Me.tab_sup.PerformLayout()
        CType(Me.existente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cubierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.terreno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relevamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.libre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_caracter.ResumeLayout(False)
        CType(Me.consulta_caract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_caract.ResumeLayout(False)
        Me.tab_copia.ResumeLayout(False)
        CType(Me.consulta_copia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu_copia.ResumeLayout(False)
        CType(Me.BSFrente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCopia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Menu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents grupo_mod As System.Windows.Forms.TabControl
    Friend WithEvents tab_ubicacion As System.Windows.Forms.TabPage
    Friend WithEvents barrio As System.Windows.Forms.ComboBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents tab_copia As System.Windows.Forms.TabPage
    Friend WithEvents consulta_copia As System.Windows.Forms.DataGridView
    Friend WithEvents tab_caracter As System.Windows.Forms.TabPage
    Friend WithEvents tab_sup As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cubierto As System.Windows.Forms.NumericUpDown
    Friend WithEvents terreno As System.Windows.Forms.NumericUpDown
    Friend WithEvents proyecto As System.Windows.Forms.NumericUpDown
    Friend WithEvents relevamiento As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents libre As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents siguiente As System.Windows.Forms.Button
    Friend WithEvents menu_copia As System.Windows.Forms.Panel
    Friend WithEvents tipo_copia As System.Windows.Forms.ComboBox
    Friend WithEvents tab_frente As System.Windows.Forms.TabPage
    Friend WithEvents consulta_frente As System.Windows.Forms.DataGridView
    Friend WithEvents menu_frente As System.Windows.Forms.Panel
    Friend WithEvents add_frente As System.Windows.Forms.Button
    Friend WithEvents del_frente As System.Windows.Forms.Button
    Friend WithEvents consulta_caract As System.Windows.Forms.DataGridView
    Friend WithEvents menu_caract As System.Windows.Forms.Panel
    Friend WithEvents add_car As System.Windows.Forms.Button
    Friend WithEvents del_car As System.Windows.Forms.Button
    Friend WithEvents lista_car As System.Windows.Forms.ComboBox
    Friend WithEvents tab_catastro As System.Windows.Forms.TabPage
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents info_estado As System.Windows.Forms.Label
    Friend WithEvents info_cuil As System.Windows.Forms.Label
    Friend WithEvents info_titular As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents info_barrio As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents info_ubicacion As System.Windows.Forms.Label
    Friend WithEvents catastro_id As System.Windows.Forms.Label
    Friend WithEvents info_exp As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents operacion As System.Windows.Forms.Label
    Friend WithEvents opr_id As System.Windows.Forms.Label
	Friend WithEvents add_copia As System.Windows.Forms.Button
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents uso As System.Windows.Forms.ComboBox
	Friend WithEvents BSFrente As System.Windows.Forms.BindingSource
	Friend WithEvents BSCar As System.Windows.Forms.BindingSource
	Friend WithEvents BSCopia As System.Windows.Forms.BindingSource
	Friend WithEvents Partida As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents subtitulo As System.Windows.Forms.Label
	Friend WithEvents del_copia As System.Windows.Forms.Button
	Friend WithEvents archivado As System.Windows.Forms.CheckBox
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents lote As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label17 As System.Windows.Forms.Label
	Friend WithEvents parc As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents manz As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents secc As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents circ As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents zona As System.Windows.Forms.NumericUpDown
	Friend WithEvents cuenta As System.Windows.Forms.NumericUpDown
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents Label18 As System.Windows.Forms.Label
	Friend WithEvents info_uso As System.Windows.Forms.Label
	Friend WithEvents info_cuenta As System.Windows.Forms.Label
	Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Label27 As Label
	Friend WithEvents existente As NumericUpDown
	Friend WithEvents Label25 As Label
	Friend WithEvents difunto As CheckBox
	Friend WithEvents mod_titular As Button
	Friend WithEvents titular As TextBox
	Friend WithEvents Label26 As Label
	Friend WithEvents Label37 As Label
	Friend WithEvents cuil As MaskedTextBox
	Friend WithEvents titular_id As Label
	Friend WithEvents ubicacion_principal As Button
    Friend WithEvents BSCat As BindingSource
End Class
