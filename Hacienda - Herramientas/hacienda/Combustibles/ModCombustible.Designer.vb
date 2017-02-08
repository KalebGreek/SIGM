<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModCombustible
	Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Button21 = New System.Windows.Forms.Button()
		Me.Button22 = New System.Windows.Forms.Button()
		Me.Button23 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.info = New System.Windows.Forms.ToolStripStatusLabel()
		Me.responsable_id = New System.Windows.Forms.ToolStripStatusLabel()
		Me.recipiente_id = New System.Windows.Forms.ToolStripStatusLabel()
		Me.bs_seccion = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_categoria = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_receptor = New System.Windows.Forms.BindingSource(Me.components)
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.CtrlBusquedaCombustiblePorReceptor1 = New Sigm.CtrlCombustiblePorReceptor()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.CtrlBusquedaCombustiblePorProveedor1 = New Sigm.CtrlCombustiblePorProveedor()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.minimo = New System.Windows.Forms.NumericUpDown()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.bs_ticket = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_responsable = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_proveedor = New System.Windows.Forms.BindingSource(Me.components)
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.bs_tipo_combustible = New System.Windows.Forms.BindingSource(Me.components)
		Me.Button2 = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.StatusStrip1.SuspendLayout()
		CType(Me.bs_seccion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel5.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.FlowLayoutPanel3.SuspendLayout()
		CType(Me.minimo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		CType(Me.bs_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_tipo_combustible, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button21
		'
		Me.Button21.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button21.FlatAppearance.BorderSize = 0
		Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button21.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button21.ForeColor = System.Drawing.Color.White
		Me.Button21.Location = New System.Drawing.Point(318, 0)
		Me.Button21.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button21.Name = "Button21"
		Me.Button21.Size = New System.Drawing.Size(27, 27)
		Me.Button21.TabIndex = 430
		Me.Button21.Text = ""
		Me.Button21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.Button21, "Nuevo")
		Me.Button21.UseVisualStyleBackColor = False
		'
		'Button22
		'
		Me.Button22.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button22.FlatAppearance.BorderSize = 0
		Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button22.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button22.ForeColor = System.Drawing.Color.White
		Me.Button22.Location = New System.Drawing.Point(345, 0)
		Me.Button22.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button22.Name = "Button22"
		Me.Button22.Size = New System.Drawing.Size(27, 27)
		Me.Button22.TabIndex = 431
		Me.Button22.Text = ""
		Me.Button22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.Button22, "Editar")
		Me.Button22.UseVisualStyleBackColor = False
		'
		'Button23
		'
		Me.Button23.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button23.FlatAppearance.BorderSize = 0
		Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button23.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button23.ForeColor = System.Drawing.Color.White
		Me.Button23.Location = New System.Drawing.Point(372, 0)
		Me.Button23.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button23.Name = "Button23"
		Me.Button23.Size = New System.Drawing.Size(27, 27)
		Me.Button23.TabIndex = 432
		Me.Button23.Text = ""
		Me.Button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.Button23, "Guardar")
		Me.Button23.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.White
		Me.Button4.Location = New System.Drawing.Point(399, 0)
		Me.Button4.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(27, 27)
		Me.Button4.TabIndex = 434
		Me.Button4.Text = ""
		Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.Button4, "Eliminar")
		Me.Button4.UseVisualStyleBackColor = False
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.info, Me.responsable_id, Me.recipiente_id})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 476)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(600, 24)
		Me.StatusStrip1.TabIndex = 399
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(514, 19)
		Me.ToolStripStatusLabel1.Spring = True
		Me.ToolStripStatusLabel1.Text = "   "
		'
		'info
		'
		Me.info.BackColor = System.Drawing.SystemColors.Control
		Me.info.Name = "info"
		Me.info.Size = New System.Drawing.Size(37, 19)
		Me.info.Text = "Info."
		'
		'responsable_id
		'
		Me.responsable_id.BackColor = System.Drawing.SystemColors.Control
		Me.responsable_id.Name = "responsable_id"
		Me.responsable_id.Size = New System.Drawing.Size(17, 19)
		Me.responsable_id.Text = "0"
		'
		'recipiente_id
		'
		Me.recipiente_id.BackColor = System.Drawing.SystemColors.Control
		Me.recipiente_id.Name = "recipiente_id"
		Me.recipiente_id.Size = New System.Drawing.Size(17, 19)
		Me.recipiente_id.Text = "0"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.DarkGray
		Me.Panel1.Controls.Add(Me.Button3)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(600, 32)
		Me.Panel1.TabIndex = 422
		'
		'Button3
		'
		Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.Color.White
		Me.Button3.Location = New System.Drawing.Point(0, 0)
		Me.Button3.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(524, 32)
		Me.Button3.TabIndex = 423
		Me.Button3.Text = "[TITULO]"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(524, 0)
		Me.Button1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(76, 32)
		Me.Button1.TabIndex = 422
		Me.Button1.Text = "CERRAR"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button1.UseVisualStyleBackColor = False
		'
		'CtrlBusquedaCombustiblePorReceptor1
		'
		Me.CtrlBusquedaCombustiblePorReceptor1.BackColor = System.Drawing.Color.Silver
		Me.CtrlBusquedaCombustiblePorReceptor1.Dock = System.Windows.Forms.DockStyle.Top
		Me.CtrlBusquedaCombustiblePorReceptor1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CtrlBusquedaCombustiblePorReceptor1.Location = New System.Drawing.Point(0, 32)
		Me.CtrlBusquedaCombustiblePorReceptor1.Margin = New System.Windows.Forms.Padding(0)
		Me.CtrlBusquedaCombustiblePorReceptor1.Name = "CtrlBusquedaCombustiblePorReceptor1"
		Me.CtrlBusquedaCombustiblePorReceptor1.Size = New System.Drawing.Size(600, 90)
		Me.CtrlBusquedaCombustiblePorReceptor1.TabIndex = 424
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.Panel5)
		Me.Panel2.Controls.Add(Me.Panel3)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel2.Location = New System.Drawing.Point(0, 196)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(600, 280)
		Me.Panel2.TabIndex = 426
		'
		'Panel5
		'
		Me.Panel5.Controls.Add(Me.DataGridView1)
		Me.Panel5.Controls.Add(Me.Label4)
		Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel5.Location = New System.Drawing.Point(0, 0)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(174, 280)
		Me.Panel5.TabIndex = 428
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToResizeRows = False
		Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(0, 27)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(174, 253)
		Me.DataGridView1.TabIndex = 1
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Gray
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(174, 27)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "TICKETS"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.FlowLayoutPanel3)
		Me.Panel3.Controls.Add(Me.Panel4)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel3.Location = New System.Drawing.Point(174, 0)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(426, 280)
		Me.Panel3.TabIndex = 427
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel3.Controls.Add(Me.DateTimePicker1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label9)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel3.Controls.Add(Me.MaskedTextBox1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel3.Controls.Add(Me.CtrlBusquedaCombustiblePorProveedor1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label11)
		Me.FlowLayoutPanel3.Controls.Add(Me.ComboBox1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Button2)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel3.Controls.Add(Me.NumericUpDown1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel3.Controls.Add(Me.minimo)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 27)
		Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(426, 253)
		Me.FlowLayoutPanel3.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(263, 58)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(154, 28)
		Me.Label1.TabIndex = 406
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'MaskedTextBox1
		'
		Me.MaskedTextBox1.Location = New System.Drawing.Point(92, 58)
		Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(0)
		Me.MaskedTextBox1.Mask = "000000-000000000000"
		Me.MaskedTextBox1.Name = "MaskedTextBox1"
		Me.MaskedTextBox1.Size = New System.Drawing.Size(167, 27)
		Me.MaskedTextBox1.TabIndex = 405
		Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(4, 24)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(88, 34)
		Me.Label2.TabIndex = 407
		Me.Label2.Text = "Fecha"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'CtrlBusquedaCombustiblePorProveedor1
		'
		Me.CtrlBusquedaCombustiblePorProveedor1.BackColor = System.Drawing.Color.Silver
		Me.CtrlBusquedaCombustiblePorProveedor1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CtrlBusquedaCombustiblePorProveedor1.Location = New System.Drawing.Point(0, 86)
		Me.CtrlBusquedaCombustiblePorProveedor1.Margin = New System.Windows.Forms.Padding(0)
		Me.CtrlBusquedaCombustiblePorProveedor1.Name = "CtrlBusquedaCombustiblePorProveedor1"
		Me.CtrlBusquedaCombustiblePorProveedor1.Size = New System.Drawing.Size(420, 61)
		Me.CtrlBusquedaCombustiblePorProveedor1.TabIndex = 424
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(213, 177)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(71, 26)
		Me.Label3.TabIndex = 425
		Me.Label3.Text = "Litros"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'minimo
		'
		Me.minimo.Location = New System.Drawing.Point(284, 180)
		Me.minimo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.minimo.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
		Me.minimo.Name = "minimo"
		Me.minimo.Size = New System.Drawing.Size(108, 27)
		Me.minimo.TabIndex = 426
		Me.minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.minimo.ThousandsSeparator = True
		Me.minimo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Gray
		Me.Panel4.Controls.Add(Me.Button21)
		Me.Panel4.Controls.Add(Me.Button22)
		Me.Panel4.Controls.Add(Me.Button23)
		Me.Panel4.Controls.Add(Me.Button4)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(426, 27)
		Me.Panel4.TabIndex = 430
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(4, 4)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(416, 20)
		Me.Label5.TabIndex = 427
		Me.Label5.Text = "DETALLE DE TICKET"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(4, 177)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(88, 26)
		Me.Label6.TabIndex = 428
		Me.Label6.Text = "Monto ($)"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'NumericUpDown1
		'
		Me.NumericUpDown1.DecimalPlaces = 2
		Me.NumericUpDown1.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
		Me.NumericUpDown1.Location = New System.Drawing.Point(92, 180)
		Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.NumericUpDown1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
		Me.NumericUpDown1.Name = "NumericUpDown1"
		Me.NumericUpDown1.Size = New System.Drawing.Size(117, 27)
		Me.NumericUpDown1.TabIndex = 429
		Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.NumericUpDown1.ThousandsSeparator = True
		Me.NumericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(4, 58)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(88, 27)
		Me.Label8.TabIndex = 431
		Me.Label8.Text = "Ticket Nro."
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(92, 28)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(117, 27)
		Me.DateTimePicker1.TabIndex = 432
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(213, 24)
		Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(204, 28)
		Me.Label9.TabIndex = 433
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label11
		'
		Me.Label11.Location = New System.Drawing.Point(4, 147)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(88, 28)
		Me.Label11.TabIndex = 435
		Me.Label11.Text = "Compra"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(92, 150)
		Me.ComboBox1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(300, 27)
		Me.ComboBox1.TabIndex = 436
		'
		'Button2
		'
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.Location = New System.Drawing.Point(392, 147)
		Me.Button2.Margin = New System.Windows.Forms.Padding(0)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(27, 27)
		Me.Button2.TabIndex = 438
		Me.Button2.Text = ""
		Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button2.UseVisualStyleBackColor = False
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 122)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(600, 74)
		Me.FlowLayoutPanel1.TabIndex = 428
		'
		'ModCombustible
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(600, 500)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.CtrlBusquedaCombustiblePorReceptor1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Panel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MinimumSize = New System.Drawing.Size(520, 310)
		Me.Name = "ModCombustible"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.bs_seccion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		CType(Me.minimo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		CType(Me.bs_ticket, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_tipo_combustible, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents recipiente_id As ToolStripStatusLabel
	Friend WithEvents responsable_id As ToolStripStatusLabel
	Friend WithEvents info As ToolStripStatusLabel
	Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents CtrlBusquedaCombustiblePorReceptor1 As Sigm.CtrlCombustiblePorReceptor
	Friend WithEvents Button3 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Panel3 As Panel
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Button21 As Button
	Friend WithEvents Button22 As Button
	Friend WithEvents Button23 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents MaskedTextBox1 As MaskedTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents CtrlBusquedaCombustiblePorProveedor1 As CtrlCombustiblePorProveedor
	Friend WithEvents Label3 As Label
	Friend WithEvents Panel5 As Panel
	Friend WithEvents minimo As NumericUpDown
	Friend WithEvents Label4 As Label
	Public WithEvents bs_ticket As BindingSource
	Public WithEvents bs_responsable As BindingSource
	Public WithEvents bs_proveedor As BindingSource
	Public WithEvents bs_seccion As BindingSource
	Public WithEvents bs_categoria As BindingSource
	Public WithEvents bs_receptor As BindingSource
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents NumericUpDown1 As NumericUpDown
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents bs_tipo_combustible As BindingSource
	Friend WithEvents Button2 As Button
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
