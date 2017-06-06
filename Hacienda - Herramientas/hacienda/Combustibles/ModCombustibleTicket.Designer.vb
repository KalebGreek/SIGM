<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModCombustibleTicket


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
		Me.Label7 = New System.Windows.Forms.Label()
		Me.fecha = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.ticket = New System.Windows.Forms.TextBox()
		Me.ticket_id = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.receptor_categoria = New System.Windows.Forms.TextBox()
		Me.SelectReceptor = New System.Windows.Forms.Button()
		Me.receptor_marca_observaciones = New System.Windows.Forms.TextBox()
		Me.receptor_dominio = New System.Windows.Forms.TextBox()
		Me.receptor_modelo = New System.Windows.Forms.TextBox()
		Me.receptor_id = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.responsable = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.proveedor_razon = New System.Windows.Forms.TextBox()
		Me.SelectProveedor = New System.Windows.Forms.Button()
		Me.proveedor_cuil = New System.Windows.Forms.TextBox()
		Me.proveedor_id = New System.Windows.Forms.TextBox()
		Me.DetalleTicket = New System.Windows.Forms.DataGridView()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.titulo = New System.Windows.Forms.Label()
		Me.cerrar = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.monto_total = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.DelItem = New System.Windows.Forms.Button()
		Me.AddItemPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TipoItem = New System.Windows.Forms.ComboBox()
		Me.NewItemType = New System.Windows.Forms.Button()
		Me.DelItemType = New System.Windows.Forms.Button()
		Me.et_litros_unidades = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.LitrosItem = New System.Windows.Forms.NumericUpDown()
		Me.MontoItem = New System.Windows.Forms.NumericUpDown()
		Me.AddNewItem = New System.Windows.Forms.Button()
		Me.bs_item_ticket = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_responsable = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_tipo_item = New System.Windows.Forms.BindingSource(Me.components)
		Me.FlowLayoutPanel3.SuspendLayout()
		CType(Me.DetalleTicket, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.AddItemPanel1.SuspendLayout()
		CType(Me.LitrosItem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MontoItem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_item_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_tipo_item, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SaveAdd
		'
		Me.SaveAdd.Dock = System.Windows.Forms.DockStyle.Right
		Me.SaveAdd.FlatAppearance.BorderSize = 0
		Me.SaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SaveAdd.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SaveAdd.ForeColor = System.Drawing.Color.White
		Me.SaveAdd.Location = New System.Drawing.Point(422, 0)
		Me.SaveAdd.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.SaveAdd.Name = "SaveAdd"
		Me.SaveAdd.Size = New System.Drawing.Size(50, 27)
		Me.SaveAdd.TabIndex = 436
		Me.SaveAdd.Text = "+1"
		Me.ToolTip1.SetToolTip(Me.SaveAdd, "Guardar y Crear Nuevo Ticket")
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
		Me.Save.Location = New System.Drawing.Point(472, 0)
		Me.Save.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Save.Name = "Save"
		Me.Save.Size = New System.Drawing.Size(30, 27)
		Me.Save.TabIndex = 432
		Me.Save.Text = ""
		Me.ToolTip1.SetToolTip(Me.Save, "Guardar Cambios")
		Me.Save.UseVisualStyleBackColor = False
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.LightGray
		Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel3.Controls.Add(Me.fecha)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel3.Controls.Add(Me.ticket)
		Me.FlowLayoutPanel3.Controls.Add(Me.ticket_id)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label11)
		Me.FlowLayoutPanel3.Controls.Add(Me.receptor_categoria)
		Me.FlowLayoutPanel3.Controls.Add(Me.SelectReceptor)
		Me.FlowLayoutPanel3.Controls.Add(Me.receptor_marca_observaciones)
		Me.FlowLayoutPanel3.Controls.Add(Me.receptor_dominio)
		Me.FlowLayoutPanel3.Controls.Add(Me.receptor_modelo)
		Me.FlowLayoutPanel3.Controls.Add(Me.receptor_id)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label10)
		Me.FlowLayoutPanel3.Controls.Add(Me.responsable)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel3.Controls.Add(Me.proveedor_razon)
		Me.FlowLayoutPanel3.Controls.Add(Me.SelectProveedor)
		Me.FlowLayoutPanel3.Controls.Add(Me.proveedor_cuil)
		Me.FlowLayoutPanel3.Controls.Add(Me.proveedor_id)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 27)
		Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(244, 361)
		Me.FlowLayoutPanel3.TabIndex = 429
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label7.Location = New System.Drawing.Point(4, 4)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(71, 30)
		Me.Label7.TabIndex = 435
		Me.Label7.Text = "Emision"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'fecha
		'
		Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.fecha.Location = New System.Drawing.Point(75, 6)
		Me.fecha.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
		Me.fecha.Name = "fecha"
		Me.fecha.Size = New System.Drawing.Size(121, 27)
		Me.fecha.TabIndex = 432
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(200, 0)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 29)
		Me.Label3.TabIndex = 458
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(4, 34)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(71, 29)
		Me.Label8.TabIndex = 431
		Me.Label8.Text = "Ticket"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ticket
		'
		Me.ticket.Location = New System.Drawing.Point(75, 36)
		Me.ticket.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.ticket.MaxLength = 35
		Me.ticket.Name = "ticket"
		Me.ticket.Size = New System.Drawing.Size(121, 27)
		Me.ticket.TabIndex = 445
		Me.ticket.Text = "0"
		'
		'ticket_id
		'
		Me.ticket_id.BackColor = System.Drawing.Color.LightSalmon
		Me.ticket_id.Enabled = False
		Me.ticket_id.Location = New System.Drawing.Point(196, 34)
		Me.ticket_id.Margin = New System.Windows.Forms.Padding(0)
		Me.ticket_id.MaxLength = 35
		Me.ticket_id.Name = "ticket_id"
		Me.ticket_id.Size = New System.Drawing.Size(24, 27)
		Me.ticket_id.TabIndex = 456
		Me.ticket_id.Text = "0"
		Me.ticket_id.Visible = False
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(224, 34)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(18, 29)
		Me.Label4.TabIndex = 459
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label11
		'
		Me.Label11.Location = New System.Drawing.Point(6, 69)
		Me.Label11.Margin = New System.Windows.Forms.Padding(6, 6, 0, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(73, 19)
		Me.Label11.TabIndex = 441
		Me.Label11.Text = "Receptor"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'receptor_categoria
		'
		Me.receptor_categoria.Location = New System.Drawing.Point(2, 90)
		Me.receptor_categoria.Margin = New System.Windows.Forms.Padding(2, 2, 0, 0)
		Me.receptor_categoria.MaxLength = 35
		Me.receptor_categoria.Name = "receptor_categoria"
		Me.receptor_categoria.ReadOnly = True
		Me.receptor_categoria.Size = New System.Drawing.Size(215, 27)
		Me.receptor_categoria.TabIndex = 467
		'
		'SelectReceptor
		'
		Me.SelectReceptor.FlatAppearance.BorderSize = 0
		Me.SelectReceptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SelectReceptor.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SelectReceptor.ForeColor = System.Drawing.Color.Black
		Me.SelectReceptor.Location = New System.Drawing.Point(217, 90)
		Me.SelectReceptor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.SelectReceptor.Name = "SelectReceptor"
		Me.SelectReceptor.Size = New System.Drawing.Size(27, 27)
		Me.SelectReceptor.TabIndex = 454
		Me.SelectReceptor.Text = ""
		Me.SelectReceptor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.SelectReceptor.UseVisualStyleBackColor = False
		'
		'receptor_marca_observaciones
		'
		Me.receptor_marca_observaciones.Location = New System.Drawing.Point(2, 119)
		Me.receptor_marca_observaciones.Margin = New System.Windows.Forms.Padding(2, 2, 0, 0)
		Me.receptor_marca_observaciones.MaxLength = 35
		Me.receptor_marca_observaciones.Name = "receptor_marca_observaciones"
		Me.receptor_marca_observaciones.ReadOnly = True
		Me.receptor_marca_observaciones.Size = New System.Drawing.Size(215, 27)
		Me.receptor_marca_observaciones.TabIndex = 453
		'
		'receptor_dominio
		'
		Me.receptor_dominio.Location = New System.Drawing.Point(2, 148)
		Me.receptor_dominio.Margin = New System.Windows.Forms.Padding(2, 2, 0, 0)
		Me.receptor_dominio.MaxLength = 35
		Me.receptor_dominio.Name = "receptor_dominio"
		Me.receptor_dominio.ReadOnly = True
		Me.receptor_dominio.Size = New System.Drawing.Size(143, 27)
		Me.receptor_dominio.TabIndex = 465
		'
		'receptor_modelo
		'
		Me.receptor_modelo.Location = New System.Drawing.Point(145, 148)
		Me.receptor_modelo.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.receptor_modelo.MaxLength = 35
		Me.receptor_modelo.Name = "receptor_modelo"
		Me.receptor_modelo.ReadOnly = True
		Me.receptor_modelo.Size = New System.Drawing.Size(72, 27)
		Me.receptor_modelo.TabIndex = 464
		'
		'receptor_id
		'
		Me.receptor_id.BackColor = System.Drawing.SystemColors.HotTrack
		Me.receptor_id.Enabled = False
		Me.receptor_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.receptor_id.Location = New System.Drawing.Point(217, 146)
		Me.receptor_id.Margin = New System.Windows.Forms.Padding(0)
		Me.receptor_id.MaxLength = 35
		Me.receptor_id.Name = "receptor_id"
		Me.receptor_id.Size = New System.Drawing.Size(24, 22)
		Me.receptor_id.TabIndex = 455
		Me.receptor_id.Text = "0"
		Me.receptor_id.Visible = False
		'
		'Label10
		'
		Me.Label10.Location = New System.Drawing.Point(6, 181)
		Me.Label10.Margin = New System.Windows.Forms.Padding(6, 6, 0, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(105, 21)
		Me.Label10.TabIndex = 439
		Me.Label10.Text = "Responsable"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'responsable
		'
		Me.responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.responsable.FormattingEnabled = True
		Me.responsable.Location = New System.Drawing.Point(2, 204)
		Me.responsable.Margin = New System.Windows.Forms.Padding(2, 2, 0, 0)
		Me.responsable.Name = "responsable"
		Me.responsable.Size = New System.Drawing.Size(215, 27)
		Me.responsable.TabIndex = 452
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(6, 237)
		Me.Label2.Margin = New System.Windows.Forms.Padding(6, 6, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(97, 19)
		Me.Label2.TabIndex = 407
		Me.Label2.Text = "Proveedor"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'proveedor_razon
		'
		Me.proveedor_razon.Location = New System.Drawing.Point(2, 258)
		Me.proveedor_razon.Margin = New System.Windows.Forms.Padding(2, 2, 0, 0)
		Me.proveedor_razon.MaxLength = 35
		Me.proveedor_razon.Name = "proveedor_razon"
		Me.proveedor_razon.ReadOnly = True
		Me.proveedor_razon.Size = New System.Drawing.Size(215, 27)
		Me.proveedor_razon.TabIndex = 461
		'
		'SelectProveedor
		'
		Me.SelectProveedor.FlatAppearance.BorderSize = 0
		Me.SelectProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SelectProveedor.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SelectProveedor.ForeColor = System.Drawing.Color.Black
		Me.SelectProveedor.Location = New System.Drawing.Point(217, 258)
		Me.SelectProveedor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.SelectProveedor.Name = "SelectProveedor"
		Me.SelectProveedor.Size = New System.Drawing.Size(27, 27)
		Me.SelectProveedor.TabIndex = 460
		Me.SelectProveedor.Text = ""
		Me.SelectProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.SelectProveedor.UseVisualStyleBackColor = False
		'
		'proveedor_cuil
		'
		Me.proveedor_cuil.Location = New System.Drawing.Point(2, 287)
		Me.proveedor_cuil.Margin = New System.Windows.Forms.Padding(2, 2, 0, 0)
		Me.proveedor_cuil.MaxLength = 35
		Me.proveedor_cuil.Name = "proveedor_cuil"
		Me.proveedor_cuil.ReadOnly = True
		Me.proveedor_cuil.Size = New System.Drawing.Size(215, 27)
		Me.proveedor_cuil.TabIndex = 462
		'
		'proveedor_id
		'
		Me.proveedor_id.BackColor = System.Drawing.Color.YellowGreen
		Me.proveedor_id.Enabled = False
		Me.proveedor_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.proveedor_id.Location = New System.Drawing.Point(217, 285)
		Me.proveedor_id.Margin = New System.Windows.Forms.Padding(0)
		Me.proveedor_id.MaxLength = 35
		Me.proveedor_id.Name = "proveedor_id"
		Me.proveedor_id.Size = New System.Drawing.Size(24, 22)
		Me.proveedor_id.TabIndex = 457
		Me.proveedor_id.Text = "0"
		Me.proveedor_id.Visible = False
		'
		'DetalleTicket
		'
		Me.DetalleTicket.AllowUserToAddRows = False
		Me.DetalleTicket.AllowUserToDeleteRows = False
		Me.DetalleTicket.AllowUserToResizeRows = False
		Me.DetalleTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.DetalleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DetalleTicket.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DetalleTicket.Location = New System.Drawing.Point(0, 86)
		Me.DetalleTicket.Margin = New System.Windows.Forms.Padding(0)
		Me.DetalleTicket.Name = "DetalleTicket"
		Me.DetalleTicket.ReadOnly = True
		Me.DetalleTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DetalleTicket.RowHeadersVisible = False
		Me.DetalleTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.DetalleTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DetalleTicket.Size = New System.Drawing.Size(290, 249)
		Me.DetalleTicket.TabIndex = 432
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.DimGray
		Me.Panel4.Controls.Add(Me.titulo)
		Me.Panel4.Controls.Add(Me.SaveAdd)
		Me.Panel4.Controls.Add(Me.Save)
		Me.Panel4.Controls.Add(Me.cerrar)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(534, 27)
		Me.Panel4.TabIndex = 433
		'
		'titulo
		'
		Me.titulo.Dock = System.Windows.Forms.DockStyle.Fill
		Me.titulo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.titulo.ForeColor = System.Drawing.Color.White
		Me.titulo.Location = New System.Drawing.Point(0, 0)
		Me.titulo.Name = "titulo"
		Me.titulo.Size = New System.Drawing.Size(422, 27)
		Me.titulo.TabIndex = 438
		Me.titulo.Text = "NUEVO TICKET"
		Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'cerrar
		'
		Me.cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.cerrar.Dock = System.Windows.Forms.DockStyle.Right
		Me.cerrar.FlatAppearance.BorderSize = 0
		Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cerrar.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cerrar.ForeColor = System.Drawing.Color.White
		Me.cerrar.Location = New System.Drawing.Point(502, 0)
		Me.cerrar.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.cerrar.Name = "cerrar"
		Me.cerrar.Size = New System.Drawing.Size(32, 27)
		Me.cerrar.TabIndex = 434
		Me.cerrar.Text = ""
		Me.cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.cerrar.UseVisualStyleBackColor = False
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.Transparent
		Me.Panel2.Controls.Add(Me.DetalleTicket)
		Me.Panel2.Controls.Add(Me.Panel1)
		Me.Panel2.Controls.Add(Me.AddItemPanel1)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.Panel2.Location = New System.Drawing.Point(244, 27)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(290, 361)
		Me.Panel2.TabIndex = 436
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Transparent
		Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
		Me.Panel1.Controls.Add(Me.DelItem)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(0, 335)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(290, 26)
		Me.Panel1.TabIndex = 466
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.FlowLayoutPanel1.Controls.Add(Me.monto_total)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(196, 26)
		Me.FlowLayoutPanel1.TabIndex = 464
		'
		'monto_total
		'
		Me.monto_total.AutoSize = True
		Me.monto_total.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.monto_total.Location = New System.Drawing.Point(142, 6)
		Me.monto_total.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
		Me.monto_total.Name = "monto_total"
		Me.monto_total.Padding = New System.Windows.Forms.Padding(0, 0, 8, 0)
		Me.monto_total.Size = New System.Drawing.Size(51, 16)
		Me.monto_total.TabIndex = 446
		Me.monto_total.Text = "$ 0,00"
		Me.monto_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(91, 6)
		Me.Label5.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(45, 16)
		Me.Label5.TabIndex = 447
		Me.Label5.Text = "TOTAL"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'DelItem
		'
		Me.DelItem.BackColor = System.Drawing.Color.Transparent
		Me.DelItem.Dock = System.Windows.Forms.DockStyle.Right
		Me.DelItem.FlatAppearance.BorderSize = 0
		Me.DelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
		Me.DelItem.ForeColor = System.Drawing.Color.Black
		Me.DelItem.Location = New System.Drawing.Point(196, 0)
		Me.DelItem.Margin = New System.Windows.Forms.Padding(0)
		Me.DelItem.Name = "DelItem"
		Me.DelItem.Size = New System.Drawing.Size(94, 26)
		Me.DelItem.TabIndex = 463
		Me.DelItem.Text = " ELIMINAR"
		Me.DelItem.UseVisualStyleBackColor = False
		'
		'AddItemPanel1
		'
		Me.AddItemPanel1.BackColor = System.Drawing.Color.Transparent
		Me.AddItemPanel1.Controls.Add(Me.Label12)
		Me.AddItemPanel1.Controls.Add(Me.Label1)
		Me.AddItemPanel1.Controls.Add(Me.TipoItem)
		Me.AddItemPanel1.Controls.Add(Me.NewItemType)
		Me.AddItemPanel1.Controls.Add(Me.DelItemType)
		Me.AddItemPanel1.Controls.Add(Me.et_litros_unidades)
		Me.AddItemPanel1.Controls.Add(Me.Label13)
		Me.AddItemPanel1.Controls.Add(Me.Label6)
		Me.AddItemPanel1.Controls.Add(Me.LitrosItem)
		Me.AddItemPanel1.Controls.Add(Me.MontoItem)
		Me.AddItemPanel1.Controls.Add(Me.AddNewItem)
		Me.AddItemPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.AddItemPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.AddItemPanel1.Location = New System.Drawing.Point(0, 0)
		Me.AddItemPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.AddItemPanel1.Name = "AddItemPanel1"
		Me.AddItemPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.AddItemPanel1.Size = New System.Drawing.Size(290, 86)
		Me.AddItemPanel1.TabIndex = 435
		'
		'Label12
		'
		Me.Label12.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.Label12.Location = New System.Drawing.Point(3, 0)
		Me.Label12.Margin = New System.Windows.Forms.Padding(0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(199, 16)
		Me.Label12.TabIndex = 446
		Me.Label12.Text = "Descripcion"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(202, 0)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 10)
		Me.Label1.TabIndex = 462
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TipoItem
		'
		Me.TipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.TipoItem.FormattingEnabled = True
		Me.TipoItem.Location = New System.Drawing.Point(3, 16)
		Me.TipoItem.Margin = New System.Windows.Forms.Padding(0)
		Me.TipoItem.Name = "TipoItem"
		Me.TipoItem.Size = New System.Drawing.Size(191, 26)
		Me.TipoItem.TabIndex = 436
		'
		'NewItemType
		'
		Me.NewItemType.FlatAppearance.BorderSize = 0
		Me.NewItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.NewItemType.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NewItemType.ForeColor = System.Drawing.Color.Black
		Me.NewItemType.Location = New System.Drawing.Point(194, 16)
		Me.NewItemType.Margin = New System.Windows.Forms.Padding(0)
		Me.NewItemType.Name = "NewItemType"
		Me.NewItemType.Size = New System.Drawing.Size(23, 25)
		Me.NewItemType.TabIndex = 459
		Me.NewItemType.Text = ""
		Me.NewItemType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.NewItemType.UseVisualStyleBackColor = False
		'
		'DelItemType
		'
		Me.DelItemType.FlatAppearance.BorderSize = 0
		Me.DelItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelItemType.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelItemType.ForeColor = System.Drawing.Color.Black
		Me.DelItemType.Location = New System.Drawing.Point(217, 16)
		Me.DelItemType.Margin = New System.Windows.Forms.Padding(0)
		Me.DelItemType.Name = "DelItemType"
		Me.DelItemType.Size = New System.Drawing.Size(23, 25)
		Me.DelItemType.TabIndex = 460
		Me.DelItemType.Text = ""
		Me.DelItemType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.DelItemType.UseVisualStyleBackColor = False
		'
		'et_litros_unidades
		'
		Me.et_litros_unidades.Location = New System.Drawing.Point(3, 42)
		Me.et_litros_unidades.Margin = New System.Windows.Forms.Padding(0)
		Me.et_litros_unidades.Name = "et_litros_unidades"
		Me.et_litros_unidades.Size = New System.Drawing.Size(81, 16)
		Me.et_litros_unidades.TabIndex = 445
		Me.et_litros_unidades.Text = "Unidades"
		Me.et_litros_unidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label13
		'
		Me.Label13.Location = New System.Drawing.Point(84, 42)
		Me.Label13.Margin = New System.Windows.Forms.Padding(0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(113, 16)
		Me.Label13.TabIndex = 443
		Me.Label13.Text = "Monto"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.0!)
		Me.Label6.Location = New System.Drawing.Point(197, 42)
		Me.Label6.Margin = New System.Windows.Forms.Padding(0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(85, 14)
		Me.Label6.TabIndex = 463
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LitrosItem
		'
		Me.LitrosItem.Location = New System.Drawing.Point(3, 58)
		Me.LitrosItem.Margin = New System.Windows.Forms.Padding(0)
		Me.LitrosItem.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.LitrosItem.Name = "LitrosItem"
		Me.LitrosItem.Size = New System.Drawing.Size(82, 25)
		Me.LitrosItem.TabIndex = 426
		Me.LitrosItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.LitrosItem.ThousandsSeparator = True
		'
		'MontoItem
		'
		Me.MontoItem.DecimalPlaces = 2
		Me.MontoItem.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
		Me.MontoItem.Location = New System.Drawing.Point(85, 58)
		Me.MontoItem.Margin = New System.Windows.Forms.Padding(0)
		Me.MontoItem.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
		Me.MontoItem.Name = "MontoItem"
		Me.MontoItem.Size = New System.Drawing.Size(110, 25)
		Me.MontoItem.TabIndex = 429
		Me.MontoItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.MontoItem.ThousandsSeparator = True
		'
		'AddNewItem
		'
		Me.AddNewItem.FlatAppearance.BorderSize = 0
		Me.AddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddNewItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!)
		Me.AddNewItem.ForeColor = System.Drawing.Color.Black
		Me.AddNewItem.Location = New System.Drawing.Point(195, 58)
		Me.AddNewItem.Margin = New System.Windows.Forms.Padding(0)
		Me.AddNewItem.Name = "AddNewItem"
		Me.AddNewItem.Size = New System.Drawing.Size(94, 25)
		Me.AddNewItem.TabIndex = 461
		Me.AddNewItem.Text = " AGREGAR"
		Me.AddNewItem.UseVisualStyleBackColor = False
		'
		'bs_item_ticket
		'
		'
		'bs_tipo_item
		'
		'
		'ModCombustibleTicket
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(534, 388)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.FlowLayoutPanel3)
		Me.Controls.Add(Me.Panel4)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "ModCombustibleTicket"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		CType(Me.DetalleTicket, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.AddItemPanel1.ResumeLayout(False)
		CType(Me.LitrosItem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MontoItem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_item_ticket, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_tipo_item, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents fecha As DateTimePicker
	Friend WithEvents Label8 As Label
	Friend WithEvents DetalleTicket As DataGridView
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Save As Button
	Friend WithEvents cerrar As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents AddItemPanel1 As FlowLayoutPanel
	Friend WithEvents TipoItem As ComboBox
	Friend WithEvents LitrosItem As NumericUpDown
	Friend WithEvents MontoItem As NumericUpDown
	Friend WithEvents Label7 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents ticket As TextBox
	Public WithEvents bs_item_ticket As BindingSource
	Friend WithEvents SaveAdd As Button
	Friend WithEvents Label12 As Label
	Friend WithEvents et_litros_unidades As Label
	Friend WithEvents titulo As Label
	Friend WithEvents NewItemType As Button
	Friend WithEvents DelItemType As Button
	Friend WithEvents responsable As ComboBox
	Public WithEvents bs_responsable As BindingSource
	Public WithEvents bs_tipo_item As BindingSource
	Friend WithEvents Label1 As Label
	Friend WithEvents AddNewItem As Button
	Friend WithEvents receptor_marca_observaciones As TextBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents monto_total As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents DelItem As Button
	Friend WithEvents SelectReceptor As Button
	Friend WithEvents receptor_id As TextBox
	Friend WithEvents ticket_id As TextBox
	Friend WithEvents proveedor_id As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents proveedor_razon As TextBox
	Friend WithEvents SelectProveedor As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents proveedor_cuil As TextBox
	Friend WithEvents receptor_dominio As TextBox
	Friend WithEvents receptor_modelo As TextBox
	Friend WithEvents receptor_categoria As TextBox
End Class
