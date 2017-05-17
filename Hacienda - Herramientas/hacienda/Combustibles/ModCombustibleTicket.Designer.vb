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
		Me.Label8 = New System.Windows.Forms.Label()
		Me.ticket = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.receptor = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.responsable = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.proveedor = New System.Windows.Forms.TextBox()
		Me.SelectProveedor = New System.Windows.Forms.Button()
		Me.DetalleTicket = New System.Windows.Forms.DataGridView()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.cerrar = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.AddItemPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.et_litros_unidades = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.TipoItem = New System.Windows.Forms.ComboBox()
		Me.NewItemType = New System.Windows.Forms.Button()
		Me.DelItemType = New System.Windows.Forms.Button()
		Me.LitrosItem = New System.Windows.Forms.NumericUpDown()
		Me.MontoItem = New System.Windows.Forms.NumericUpDown()
		Me.AddNewItem = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.DelItem = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.monto_total = New System.Windows.Forms.Label()
		Me.bs_item_ticket = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_responsable = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_receptor = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_tipo_item = New System.Windows.Forms.BindingSource(Me.components)
		Me.FlowLayoutPanel3.SuspendLayout()
		CType(Me.DetalleTicket, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.AddItemPanel1.SuspendLayout()
		CType(Me.LitrosItem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MontoItem, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.bs_item_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.SaveAdd.Location = New System.Drawing.Point(354, 0)
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
		Me.Save.Location = New System.Drawing.Point(404, 0)
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
		Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.Silver
		Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel3.Controls.Add(Me.fecha)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel3.Controls.Add(Me.ticket)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label11)
		Me.FlowLayoutPanel3.Controls.Add(Me.receptor)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label10)
		Me.FlowLayoutPanel3.Controls.Add(Me.responsable)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel3.Controls.Add(Me.proveedor)
		Me.FlowLayoutPanel3.Controls.Add(Me.SelectProveedor)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 27)
		Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(466, 120)
		Me.FlowLayoutPanel3.TabIndex = 429
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label7.Location = New System.Drawing.Point(4, 0)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(104, 28)
		Me.Label7.TabIndex = 435
		Me.Label7.Text = "Fecha Emision"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'fecha
		'
		Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.fecha.Location = New System.Drawing.Point(108, 2)
		Me.fecha.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.fecha.Name = "fecha"
		Me.fecha.Size = New System.Drawing.Size(121, 27)
		Me.fecha.TabIndex = 432
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(233, 0)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(50, 29)
		Me.Label8.TabIndex = 431
		Me.Label8.Text = "Ticket"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ticket
		'
		Me.ticket.Location = New System.Drawing.Point(283, 2)
		Me.ticket.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.ticket.MaxLength = 35
		Me.ticket.Name = "ticket"
		Me.ticket.Size = New System.Drawing.Size(151, 27)
		Me.ticket.TabIndex = 445
		Me.ticket.Text = "0"
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label11.Location = New System.Drawing.Point(4, 31)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 2, 0, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(104, 27)
		Me.Label11.TabIndex = 441
		Me.Label11.Text = "Receptor"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'receptor
		'
		Me.receptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.receptor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.receptor.FormattingEnabled = True
		Me.receptor.Location = New System.Drawing.Point(108, 31)
		Me.receptor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.receptor.Name = "receptor"
		Me.receptor.Size = New System.Drawing.Size(326, 27)
		Me.receptor.TabIndex = 453
		'
		'Label10
		'
		Me.Label10.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label10.Location = New System.Drawing.Point(4, 58)
		Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(104, 29)
		Me.Label10.TabIndex = 439
		Me.Label10.Text = "Responsable"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'responsable
		'
		Me.responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.responsable.FormattingEnabled = True
		Me.responsable.Location = New System.Drawing.Point(108, 60)
		Me.responsable.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.responsable.Name = "responsable"
		Me.responsable.Size = New System.Drawing.Size(326, 27)
		Me.responsable.TabIndex = 452
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(4, 89)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 2, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 27)
		Me.Label2.TabIndex = 407
		Me.Label2.Text = "Proveedor"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'proveedor
		'
		Me.proveedor.Enabled = False
		Me.proveedor.Location = New System.Drawing.Point(108, 89)
		Me.proveedor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.proveedor.MaxLength = 35
		Me.proveedor.Name = "proveedor"
		Me.proveedor.ReadOnly = True
		Me.proveedor.Size = New System.Drawing.Size(326, 27)
		Me.proveedor.TabIndex = 450
		'
		'SelectProveedor
		'
		Me.SelectProveedor.FlatAppearance.BorderSize = 0
		Me.SelectProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SelectProveedor.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SelectProveedor.ForeColor = System.Drawing.Color.White
		Me.SelectProveedor.Location = New System.Drawing.Point(434, 89)
		Me.SelectProveedor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.SelectProveedor.Name = "SelectProveedor"
		Me.SelectProveedor.Size = New System.Drawing.Size(27, 26)
		Me.SelectProveedor.TabIndex = 438
		Me.SelectProveedor.Text = ""
		Me.SelectProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.SelectProveedor.UseVisualStyleBackColor = False
		'
		'DetalleTicket
		'
		Me.DetalleTicket.AllowUserToAddRows = False
		Me.DetalleTicket.AllowUserToDeleteRows = False
		Me.DetalleTicket.AllowUserToResizeRows = False
		Me.DetalleTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.DetalleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DetalleTicket.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DetalleTicket.Location = New System.Drawing.Point(0, 26)
		Me.DetalleTicket.Name = "DetalleTicket"
		Me.DetalleTicket.ReadOnly = True
		Me.DetalleTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DetalleTicket.RowHeadersVisible = False
		Me.DetalleTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.DetalleTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DetalleTicket.Size = New System.Drawing.Size(466, 173)
		Me.DetalleTicket.TabIndex = 432
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
		Me.Panel4.Size = New System.Drawing.Size(466, 27)
		Me.Panel4.TabIndex = 433
		'
		'Label14
		'
		Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label14.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.ForeColor = System.Drawing.Color.White
		Me.Label14.Location = New System.Drawing.Point(0, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(354, 27)
		Me.Label14.TabIndex = 438
		Me.Label14.Text = "NUEVO TICKET"
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
		Me.cerrar.Location = New System.Drawing.Point(434, 0)
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
		Me.Panel2.Controls.Add(Me.DetalleTicket)
		Me.Panel2.Controls.Add(Me.AddItemPanel1)
		Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.Panel2.Location = New System.Drawing.Point(0, 147)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(466, 241)
		Me.Panel2.TabIndex = 436
		'
		'AddItemPanel1
		'
		Me.AddItemPanel1.BackColor = System.Drawing.Color.Silver
		Me.AddItemPanel1.Controls.Add(Me.Label12)
		Me.AddItemPanel1.Controls.Add(Me.Label1)
		Me.AddItemPanel1.Controls.Add(Me.et_litros_unidades)
		Me.AddItemPanel1.Controls.Add(Me.Label13)
		Me.AddItemPanel1.Controls.Add(Me.TipoItem)
		Me.AddItemPanel1.Controls.Add(Me.NewItemType)
		Me.AddItemPanel1.Controls.Add(Me.DelItemType)
		Me.AddItemPanel1.Controls.Add(Me.LitrosItem)
		Me.AddItemPanel1.Controls.Add(Me.MontoItem)
		Me.AddItemPanel1.Controls.Add(Me.AddNewItem)
		Me.AddItemPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.AddItemPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.AddItemPanel1.Location = New System.Drawing.Point(0, 199)
		Me.AddItemPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.AddItemPanel1.Name = "AddItemPanel1"
		Me.AddItemPanel1.Size = New System.Drawing.Size(466, 42)
		Me.AddItemPanel1.TabIndex = 435
		'
		'Label12
		'
		Me.Label12.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.0!)
		Me.Label12.Location = New System.Drawing.Point(2, 0)
		Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(199, 14)
		Me.Label12.TabIndex = 446
		Me.Label12.Text = "DESCRIPCION"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(201, 0)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 10)
		Me.Label1.TabIndex = 462
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'et_litros_unidades
		'
		Me.et_litros_unidades.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.0!)
		Me.et_litros_unidades.Location = New System.Drawing.Point(249, 0)
		Me.et_litros_unidades.Margin = New System.Windows.Forms.Padding(0)
		Me.et_litros_unidades.Name = "et_litros_unidades"
		Me.et_litros_unidades.Size = New System.Drawing.Size(65, 14)
		Me.et_litros_unidades.TabIndex = 445
		Me.et_litros_unidades.Text = "UNIDADES"
		Me.et_litros_unidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label13
		'
		Me.Label13.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.0!)
		Me.Label13.Location = New System.Drawing.Point(314, 0)
		Me.Label13.Margin = New System.Windows.Forms.Padding(0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(85, 14)
		Me.Label13.TabIndex = 443
		Me.Label13.Text = "MONTO"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TipoItem
		'
		Me.TipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.TipoItem.FormattingEnabled = True
		Me.TipoItem.Location = New System.Drawing.Point(2, 14)
		Me.TipoItem.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.TipoItem.Name = "TipoItem"
		Me.TipoItem.Size = New System.Drawing.Size(199, 26)
		Me.TipoItem.TabIndex = 436
		'
		'NewItemType
		'
		Me.NewItemType.FlatAppearance.BorderSize = 0
		Me.NewItemType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.NewItemType.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NewItemType.ForeColor = System.Drawing.Color.White
		Me.NewItemType.Location = New System.Drawing.Point(201, 14)
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
		Me.DelItemType.ForeColor = System.Drawing.Color.White
		Me.DelItemType.Location = New System.Drawing.Point(224, 14)
		Me.DelItemType.Margin = New System.Windows.Forms.Padding(0)
		Me.DelItemType.Name = "DelItemType"
		Me.DelItemType.Size = New System.Drawing.Size(23, 25)
		Me.DelItemType.TabIndex = 460
		Me.DelItemType.Text = ""
		Me.DelItemType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.DelItemType.UseVisualStyleBackColor = False
		'
		'LitrosItem
		'
		Me.LitrosItem.Location = New System.Drawing.Point(247, 14)
		Me.LitrosItem.Margin = New System.Windows.Forms.Padding(0)
		Me.LitrosItem.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.LitrosItem.Name = "LitrosItem"
		Me.LitrosItem.Size = New System.Drawing.Size(66, 25)
		Me.LitrosItem.TabIndex = 426
		Me.LitrosItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.LitrosItem.ThousandsSeparator = True
		Me.LitrosItem.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'MontoItem
		'
		Me.MontoItem.DecimalPlaces = 2
		Me.MontoItem.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
		Me.MontoItem.Location = New System.Drawing.Point(313, 14)
		Me.MontoItem.Margin = New System.Windows.Forms.Padding(0)
		Me.MontoItem.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
		Me.MontoItem.Name = "MontoItem"
		Me.MontoItem.Size = New System.Drawing.Size(85, 25)
		Me.MontoItem.TabIndex = 429
		Me.MontoItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.MontoItem.ThousandsSeparator = True
		Me.MontoItem.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'AddNewItem
		'
		Me.AddNewItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.0!)
		Me.AddNewItem.Location = New System.Drawing.Point(398, 14)
		Me.AddNewItem.Margin = New System.Windows.Forms.Padding(0)
		Me.AddNewItem.Name = "AddNewItem"
		Me.AddNewItem.Size = New System.Drawing.Size(65, 26)
		Me.AddNewItem.TabIndex = 461
		Me.AddNewItem.Text = "AGREGAR"
		Me.AddNewItem.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Silver
		Me.FlowLayoutPanel1.Controls.Add(Me.DelItem)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.monto_total)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(466, 26)
		Me.FlowLayoutPanel1.TabIndex = 464
		'
		'DelItem
		'
		Me.DelItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 10.0!)
		Me.DelItem.Location = New System.Drawing.Point(0, 0)
		Me.DelItem.Margin = New System.Windows.Forms.Padding(0)
		Me.DelItem.Name = "DelItem"
		Me.DelItem.Size = New System.Drawing.Size(120, 26)
		Me.DelItem.TabIndex = 463
		Me.DelItem.Text = " ELIMINAR ITEM"
		Me.DelItem.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(123, 6)
		Me.Label5.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(45, 16)
		Me.Label5.TabIndex = 447
		Me.Label5.Text = "TOTAL"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'monto_total
		'
		Me.monto_total.AutoSize = True
		Me.monto_total.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.monto_total.Location = New System.Drawing.Point(174, 6)
		Me.monto_total.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
		Me.monto_total.Name = "monto_total"
		Me.monto_total.Padding = New System.Windows.Forms.Padding(0, 0, 8, 0)
		Me.monto_total.Size = New System.Drawing.Size(51, 16)
		Me.monto_total.TabIndex = 446
		Me.monto_total.Text = "$ 0,00"
		Me.monto_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
		Me.ClientSize = New System.Drawing.Size(466, 388)
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
		Me.AddItemPanel1.ResumeLayout(False)
		CType(Me.LitrosItem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MontoItem, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		CType(Me.bs_item_ticket, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents SelectProveedor As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents ticket As TextBox
	Public WithEvents bs_item_ticket As BindingSource
	Friend WithEvents SaveAdd As Button
	Friend WithEvents Label12 As Label
	Friend WithEvents et_litros_unidades As Label
	Friend WithEvents Label14 As Label
	Friend WithEvents NewItemType As Button
	Friend WithEvents DelItemType As Button
	Friend WithEvents responsable As ComboBox
	Friend WithEvents proveedor As TextBox
	Public WithEvents bs_responsable As BindingSource
	Public WithEvents receptor As ComboBox
	Public WithEvents bs_receptor As BindingSource
	Public WithEvents bs_tipo_item As BindingSource
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label5 As Label
	Friend WithEvents monto_total As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents AddNewItem As Button
	Friend WithEvents DelItem As Button
End Class
