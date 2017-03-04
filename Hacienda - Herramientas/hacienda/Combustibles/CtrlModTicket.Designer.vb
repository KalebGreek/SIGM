<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlModTicket


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
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.SaveAdd = New System.Windows.Forms.Button()
		Me.Save = New System.Windows.Forms.Button()
		Me.DelItem = New System.Windows.Forms.Button()
		Me.ShowAddItem = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.proveedor = New System.Windows.Forms.ComboBox()
		Me.SelectProveedor = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.fecha = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.cuil_proveedor = New System.Windows.Forms.MaskedTextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.ticket = New System.Windows.Forms.TextBox()
		Me.DetalleTicket = New System.Windows.Forms.DataGridView()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.cerrar = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.monto_total = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.AddItemPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.DescItem = New System.Windows.Forms.ComboBox()
		Me.SelectItem = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LitrosItem = New System.Windows.Forms.NumericUpDown()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.MontoItem = New System.Windows.Forms.NumericUpDown()
		Me.AddNewItem = New System.Windows.Forms.Button()
		Me.bs_proveedor = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_item_ticket = New System.Windows.Forms.BindingSource(Me.components)
		Me.Label4 = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel3.SuspendLayout()
		CType(Me.DetalleTicket, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.AddItemPanel1.SuspendLayout()
		CType(Me.LitrosItem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MontoItem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_item_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.Save.Location = New System.Drawing.Point(350, 0)
		Me.Save.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Save.Name = "Save"
		Me.Save.Size = New System.Drawing.Size(30, 27)
		Me.Save.TabIndex = 432
		Me.Save.Text = ""
		Me.ToolTip1.SetToolTip(Me.Save, "Guardar Cambios")
		Me.Save.UseVisualStyleBackColor = False
		'
		'DelItem
		'
		Me.DelItem.Dock = System.Windows.Forms.DockStyle.Right
		Me.DelItem.FlatAppearance.BorderSize = 0
		Me.DelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelItem.ForeColor = System.Drawing.Color.White
		Me.DelItem.Location = New System.Drawing.Point(376, 0)
		Me.DelItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.DelItem.Name = "DelItem"
		Me.DelItem.Size = New System.Drawing.Size(36, 24)
		Me.DelItem.TabIndex = 432
		Me.DelItem.Text = ""
		Me.DelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.DelItem, "Eliminar Item Seleccionado")
		Me.DelItem.UseVisualStyleBackColor = False
		'
		'ShowAddItem
		'
		Me.ShowAddItem.Dock = System.Windows.Forms.DockStyle.Right
		Me.ShowAddItem.FlatAppearance.BorderSize = 0
		Me.ShowAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ShowAddItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ShowAddItem.ForeColor = System.Drawing.Color.White
		Me.ShowAddItem.Location = New System.Drawing.Point(340, 0)
		Me.ShowAddItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.ShowAddItem.Name = "ShowAddItem"
		Me.ShowAddItem.Size = New System.Drawing.Size(36, 24)
		Me.ShowAddItem.TabIndex = 436
		Me.ShowAddItem.Text = ""
		Me.ShowAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.ShowAddItem, "Eliminar Item Seleccionado")
		Me.ShowAddItem.UseVisualStyleBackColor = False
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.LightGray
		Me.FlowLayoutPanel3.Controls.Add(Me.Label11)
		Me.FlowLayoutPanel3.Controls.Add(Me.TextBox2)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label10)
		Me.FlowLayoutPanel3.Controls.Add(Me.TextBox1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel3.Controls.Add(Me.proveedor)
		Me.FlowLayoutPanel3.Controls.Add(Me.SelectProveedor)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel3.Controls.Add(Me.cuil_proveedor)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel3.Controls.Add(Me.fecha)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel3.Controls.Add(Me.ticket)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 27)
		Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(412, 161)
		Me.FlowLayoutPanel3.TabIndex = 429
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label11.Location = New System.Drawing.Point(4, 5)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 5, 0, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(104, 29)
		Me.Label11.TabIndex = 441
		Me.Label11.Text = "Receptor"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox2
		'
		Me.TextBox2.Enabled = False
		Me.TextBox2.Location = New System.Drawing.Point(108, 5)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
		Me.TextBox2.MaxLength = 35
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = True
		Me.TextBox2.Size = New System.Drawing.Size(274, 27)
		Me.TextBox2.TabIndex = 450
		'
		'Label10
		'
		Me.Label10.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label10.Location = New System.Drawing.Point(4, 34)
		Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(104, 31)
		Me.Label10.TabIndex = 439
		Me.Label10.Text = "Responsable"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox1
		'
		Me.TextBox1.Enabled = False
		Me.TextBox1.Location = New System.Drawing.Point(108, 36)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.TextBox1.MaxLength = 35
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(274, 27)
		Me.TextBox1.TabIndex = 449
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label6.Location = New System.Drawing.Point(4, 65)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(104, 30)
		Me.Label6.TabIndex = 434
		Me.Label6.Text = "Proveedor"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'proveedor
		'
		Me.proveedor.FormattingEnabled = True
		Me.proveedor.Location = New System.Drawing.Point(108, 67)
		Me.proveedor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
		Me.proveedor.Name = "proveedor"
		Me.proveedor.Size = New System.Drawing.Size(274, 27)
		Me.proveedor.TabIndex = 437
		'
		'SelectProveedor
		'
		Me.SelectProveedor.FlatAppearance.BorderSize = 0
		Me.SelectProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SelectProveedor.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SelectProveedor.ForeColor = System.Drawing.Color.White
		Me.SelectProveedor.Location = New System.Drawing.Point(382, 67)
		Me.SelectProveedor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.SelectProveedor.Name = "SelectProveedor"
		Me.SelectProveedor.Size = New System.Drawing.Size(27, 27)
		Me.SelectProveedor.TabIndex = 438
		Me.SelectProveedor.Text = ""
		Me.SelectProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.SelectProveedor.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(4, 98)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 2, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 29)
		Me.Label2.TabIndex = 407
		Me.Label2.Text = "CUIT/CUIL"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'fecha
		'
		Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.fecha.Location = New System.Drawing.Point(108, 129)
		Me.fecha.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.fecha.Name = "fecha"
		Me.fecha.Size = New System.Drawing.Size(124, 27)
		Me.fecha.TabIndex = 432
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label7.Location = New System.Drawing.Point(4, 127)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(104, 28)
		Me.Label7.TabIndex = 435
		Me.Label7.Text = "Fecha Emision"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cuil_proveedor
		'
		Me.cuil_proveedor.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cuil_proveedor.Location = New System.Drawing.Point(108, 98)
		Me.cuil_proveedor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
		Me.cuil_proveedor.Mask = "99-99999999-9"
		Me.cuil_proveedor.Name = "cuil_proveedor"
		Me.cuil_proveedor.ReadOnly = True
		Me.cuil_proveedor.Size = New System.Drawing.Size(124, 27)
		Me.cuil_proveedor.TabIndex = 436
		Me.cuil_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.cuil_proveedor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(236, 127)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(50, 31)
		Me.Label8.TabIndex = 431
		Me.Label8.Text = "Ticket"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ticket
		'
		Me.ticket.Location = New System.Drawing.Point(286, 129)
		Me.ticket.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.ticket.MaxLength = 35
		Me.ticket.Name = "ticket"
		Me.ticket.Size = New System.Drawing.Size(96, 27)
		Me.ticket.TabIndex = 445
		'
		'DetalleTicket
		'
		Me.DetalleTicket.AllowUserToAddRows = False
		Me.DetalleTicket.AllowUserToDeleteRows = False
		Me.DetalleTicket.AllowUserToResizeRows = False
		Me.DetalleTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DetalleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DetalleTicket.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DetalleTicket.Location = New System.Drawing.Point(0, 0)
		Me.DetalleTicket.Name = "DetalleTicket"
		Me.DetalleTicket.ReadOnly = True
		Me.DetalleTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DetalleTicket.RowHeadersVisible = False
		Me.DetalleTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.DetalleTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DetalleTicket.Size = New System.Drawing.Size(412, 112)
		Me.DetalleTicket.TabIndex = 432
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Gray
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
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.DarkGray
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.monto_total)
		Me.Panel1.Controls.Add(Me.ShowAddItem)
		Me.Panel1.Controls.Add(Me.DelItem)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 188)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(412, 24)
		Me.Panel1.TabIndex = 435
		'
		'Label3
		'
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Location = New System.Drawing.Point(0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(233, 24)
		Me.Label3.TabIndex = 435
		Me.Label3.Text = "DETALLE"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(233, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(56, 16)
		Me.Label5.TabIndex = 445
		Me.Label5.Text = "Total ($)"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'monto_total
		'
		Me.monto_total.AutoSize = True
		Me.monto_total.Dock = System.Windows.Forms.DockStyle.Right
		Me.monto_total.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.monto_total.Location = New System.Drawing.Point(289, 0)
		Me.monto_total.Name = "monto_total"
		Me.monto_total.Padding = New System.Windows.Forms.Padding(0, 0, 8, 0)
		Me.monto_total.Size = New System.Drawing.Size(51, 16)
		Me.monto_total.TabIndex = 444
		Me.monto_total.Text = "$ 0,00"
		Me.monto_total.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.DetalleTicket)
		Me.Panel2.Controls.Add(Me.AddItemPanel1)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 212)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(412, 176)
		Me.Panel2.TabIndex = 436
		'
		'AddItemPanel1
		'
		Me.AddItemPanel1.BackColor = System.Drawing.Color.LightGray
		Me.AddItemPanel1.Controls.Add(Me.Label12)
		Me.AddItemPanel1.Controls.Add(Me.DescItem)
		Me.AddItemPanel1.Controls.Add(Me.SelectItem)
		Me.AddItemPanel1.Controls.Add(Me.Label1)
		Me.AddItemPanel1.Controls.Add(Me.LitrosItem)
		Me.AddItemPanel1.Controls.Add(Me.Label13)
		Me.AddItemPanel1.Controls.Add(Me.MontoItem)
		Me.AddItemPanel1.Controls.Add(Me.AddNewItem)
		Me.AddItemPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.AddItemPanel1.Location = New System.Drawing.Point(0, 112)
		Me.AddItemPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.AddItemPanel1.Name = "AddItemPanel1"
		Me.AddItemPanel1.Size = New System.Drawing.Size(412, 64)
		Me.AddItemPanel1.TabIndex = 435
		Me.AddItemPanel1.Visible = False
		'
		'Label12
		'
		Me.Label12.Location = New System.Drawing.Point(4, 4)
		Me.Label12.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(89, 29)
		Me.Label12.TabIndex = 446
		Me.Label12.Text = "Descripcion"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'DescItem
		'
		Me.DescItem.FormattingEnabled = True
		Me.DescItem.Location = New System.Drawing.Point(97, 4)
		Me.DescItem.Margin = New System.Windows.Forms.Padding(4, 4, 0, 0)
		Me.DescItem.Name = "DescItem"
		Me.DescItem.Size = New System.Drawing.Size(296, 27)
		Me.DescItem.TabIndex = 436
		'
		'SelectItem
		'
		Me.SelectItem.FlatAppearance.BorderSize = 0
		Me.SelectItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.SelectItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SelectItem.ForeColor = System.Drawing.Color.White
		Me.SelectItem.Location = New System.Drawing.Point(0, 39)
		Me.SelectItem.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
		Me.SelectItem.Name = "SelectItem"
		Me.SelectItem.Size = New System.Drawing.Size(26, 25)
		Me.SelectItem.TabIndex = 438
		Me.SelectItem.Text = ""
		Me.SelectItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.SelectItem.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(30, 33)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(53, 20)
		Me.Label1.TabIndex = 445
		Me.Label1.Text = "Litros"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LitrosItem
		'
		Me.LitrosItem.Location = New System.Drawing.Point(87, 33)
		Me.LitrosItem.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.LitrosItem.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
		Me.LitrosItem.Name = "LitrosItem"
		Me.LitrosItem.Size = New System.Drawing.Size(74, 27)
		Me.LitrosItem.TabIndex = 426
		Me.LitrosItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.LitrosItem.ThousandsSeparator = True
		Me.LitrosItem.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'Label13
		'
		Me.Label13.Location = New System.Drawing.Point(165, 33)
		Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(74, 20)
		Me.Label13.TabIndex = 443
		Me.Label13.Text = "Monto ($)"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'MontoItem
		'
		Me.MontoItem.DecimalPlaces = 2
		Me.MontoItem.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
		Me.MontoItem.Location = New System.Drawing.Point(243, 33)
		Me.MontoItem.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.MontoItem.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
		Me.MontoItem.Name = "MontoItem"
		Me.MontoItem.Size = New System.Drawing.Size(105, 27)
		Me.MontoItem.TabIndex = 429
		Me.MontoItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.MontoItem.ThousandsSeparator = True
		Me.MontoItem.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'AddNewItem
		'
		Me.AddNewItem.Location = New System.Drawing.Point(2, 64)
		Me.AddNewItem.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
		Me.AddNewItem.Name = "AddNewItem"
		Me.AddNewItem.Size = New System.Drawing.Size(100, 27)
		Me.AddNewItem.TabIndex = 444
		Me.AddNewItem.Text = "Agregar"
		Me.AddNewItem.UseVisualStyleBackColor = True
		'
		'bs_item_ticket
		'
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label4.Location = New System.Drawing.Point(236, 96)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(158, 28)
		Me.Label4.TabIndex = 451
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'CtrlModTicket
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(412, 388)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.FlowLayoutPanel3)
		Me.Controls.Add(Me.Panel4)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "CtrlModTicket"
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		CType(Me.DetalleTicket, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.AddItemPanel1.ResumeLayout(False)
		CType(Me.LitrosItem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MontoItem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_item_ticket, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label3 As Label
	Friend WithEvents DelItem As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents AddItemPanel1 As FlowLayoutPanel
	Friend WithEvents DescItem As ComboBox
	Friend WithEvents SelectItem As Button
	Friend WithEvents LitrosItem As NumericUpDown
	Friend WithEvents MontoItem As NumericUpDown
	Friend WithEvents Label6 As Label
	Friend WithEvents proveedor As ComboBox
	Friend WithEvents SelectProveedor As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents cuil_proveedor As MaskedTextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents ticket As TextBox
	Public WithEvents bs_proveedor As BindingSource
	Public WithEvents bs_item_ticket As BindingSource
	Friend WithEvents SaveAdd As Button
	Friend WithEvents AddNewItem As Button
	Friend WithEvents Label12 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents ShowAddItem As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents monto_total As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label4 As Label
End Class
