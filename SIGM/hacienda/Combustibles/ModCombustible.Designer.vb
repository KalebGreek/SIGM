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
		Me.EditTicket = New System.Windows.Forms.Button()
		Me.DelTicket = New System.Windows.Forms.Button()
		Me.AddTicket = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.info = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.historial = New System.Windows.Forms.DataGridView()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FiltroCuenta = New System.Windows.Forms.CheckBox()
		Me.cuenta = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.FiltroCategoria = New System.Windows.Forms.CheckBox()
		Me.categoria = New System.Windows.Forms.ComboBox()
		Me.vehiculo = New System.Windows.Forms.CheckBox()
		Me.FiltroReceptor = New System.Windows.Forms.CheckBox()
		Me.receptor = New System.Windows.Forms.ComboBox()
		Me.NewReceptor = New System.Windows.Forms.Button()
		Me.EditReceptor = New System.Windows.Forms.Button()
		Me.DelReceptor = New System.Windows.Forms.Button()
		Me.bs_receptor = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_categoria = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_cuenta = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_historial = New System.Windows.Forms.BindingSource(Me.components)
		Me.StatusStrip1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.historial, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'EditTicket
		'
		Me.EditTicket.BackColor = System.Drawing.Color.Gray
		Me.EditTicket.Dock = System.Windows.Forms.DockStyle.Right
		Me.EditTicket.FlatAppearance.BorderSize = 0
		Me.EditTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.EditTicket.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EditTicket.ForeColor = System.Drawing.Color.White
		Me.EditTicket.Location = New System.Drawing.Point(528, 0)
		Me.EditTicket.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.EditTicket.Name = "EditTicket"
		Me.EditTicket.Size = New System.Drawing.Size(36, 24)
		Me.EditTicket.TabIndex = 438
		Me.EditTicket.Text = ""
		Me.EditTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.EditTicket, "Editar Ticket")
		Me.EditTicket.UseVisualStyleBackColor = False
		'
		'DelTicket
		'
		Me.DelTicket.BackColor = System.Drawing.Color.Gray
		Me.DelTicket.Dock = System.Windows.Forms.DockStyle.Right
		Me.DelTicket.FlatAppearance.BorderSize = 0
		Me.DelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelTicket.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelTicket.ForeColor = System.Drawing.Color.White
		Me.DelTicket.Location = New System.Drawing.Point(564, 0)
		Me.DelTicket.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.DelTicket.Name = "DelTicket"
		Me.DelTicket.Size = New System.Drawing.Size(36, 24)
		Me.DelTicket.TabIndex = 437
		Me.DelTicket.Text = ""
		Me.DelTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.DelTicket, "Eliminar Ticket Seleccionado")
		Me.DelTicket.UseVisualStyleBackColor = False
		'
		'AddTicket
		'
		Me.AddTicket.BackColor = System.Drawing.Color.Gray
		Me.AddTicket.Dock = System.Windows.Forms.DockStyle.Right
		Me.AddTicket.FlatAppearance.BorderSize = 0
		Me.AddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddTicket.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AddTicket.ForeColor = System.Drawing.Color.White
		Me.AddTicket.Location = New System.Drawing.Point(492, 0)
		Me.AddTicket.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.AddTicket.Name = "AddTicket"
		Me.AddTicket.Size = New System.Drawing.Size(36, 24)
		Me.AddTicket.TabIndex = 439
		Me.AddTicket.Text = ""
		Me.AddTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.AddTicket, "Nuevo Ticket")
		Me.AddTicket.UseVisualStyleBackColor = False
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.info})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 416)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(600, 24)
		Me.StatusStrip1.TabIndex = 399
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(548, 19)
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
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.historial)
		Me.Panel2.Controls.Add(Me.Panel3)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 99)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(600, 317)
		Me.Panel2.TabIndex = 426
		'
		'historial
		'
		Me.historial.AllowUserToAddRows = False
		Me.historial.AllowUserToDeleteRows = False
		Me.historial.AllowUserToResizeRows = False
		Me.historial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.historial.Dock = System.Windows.Forms.DockStyle.Fill
		Me.historial.Location = New System.Drawing.Point(0, 24)
		Me.historial.Margin = New System.Windows.Forms.Padding(0)
		Me.historial.Name = "historial"
		Me.historial.ReadOnly = True
		Me.historial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.historial.RowHeadersVisible = False
		Me.historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.historial.Size = New System.Drawing.Size(600, 293)
		Me.historial.TabIndex = 3
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.AddTicket)
		Me.Panel3.Controls.Add(Me.EditTicket)
		Me.Panel3.Controls.Add(Me.DelTicket)
		Me.Panel3.Controls.Add(Me.Label4)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel3.Location = New System.Drawing.Point(0, 0)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(600, 24)
		Me.Panel3.TabIndex = 5
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Gray
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(600, 24)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "TICKETS"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Panel4
		'
		Me.Panel4.Controls.Add(Me.FlowLayoutPanel1)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(600, 99)
		Me.Panel4.TabIndex = 429
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.FiltroCuenta)
		Me.FlowLayoutPanel1.Controls.Add(Me.cuenta)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.FiltroCategoria)
		Me.FlowLayoutPanel1.Controls.Add(Me.categoria)
		Me.FlowLayoutPanel1.Controls.Add(Me.vehiculo)
		Me.FlowLayoutPanel1.Controls.Add(Me.FiltroReceptor)
		Me.FlowLayoutPanel1.Controls.Add(Me.receptor)
		Me.FlowLayoutPanel1.Controls.Add(Me.NewReceptor)
		Me.FlowLayoutPanel1.Controls.Add(Me.EditReceptor)
		Me.FlowLayoutPanel1.Controls.Add(Me.DelReceptor)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 5)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(495, 92)
		Me.FlowLayoutPanel1.TabIndex = 429
		'
		'FiltroCuenta
		'
		Me.FiltroCuenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.FiltroCuenta.Location = New System.Drawing.Point(3, 3)
		Me.FiltroCuenta.Name = "FiltroCuenta"
		Me.FiltroCuenta.Size = New System.Drawing.Size(99, 23)
		Me.FiltroCuenta.TabIndex = 447
		Me.FiltroCuenta.Text = "Cuenta"
		Me.FiltroCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.FiltroCuenta.UseVisualStyleBackColor = True
		'
		'cuenta
		'
		Me.cuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cuenta.Enabled = False
		Me.cuenta.FormattingEnabled = True
		Me.cuenta.Location = New System.Drawing.Point(105, 2)
		Me.cuenta.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.cuenta.Name = "cuenta"
		Me.cuenta.Size = New System.Drawing.Size(300, 27)
		Me.cuenta.TabIndex = 432
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label3.Location = New System.Drawing.Point(409, 0)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(73, 28)
		Me.Label3.TabIndex = 446
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'FiltroCategoria
		'
		Me.FiltroCategoria.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.FiltroCategoria.Location = New System.Drawing.Point(3, 32)
		Me.FiltroCategoria.Name = "FiltroCategoria"
		Me.FiltroCategoria.Size = New System.Drawing.Size(99, 23)
		Me.FiltroCategoria.TabIndex = 448
		Me.FiltroCategoria.Text = "Categoria"
		Me.FiltroCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.FiltroCategoria.UseVisualStyleBackColor = True
		'
		'categoria
		'
		Me.categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.categoria.Enabled = False
		Me.categoria.FormattingEnabled = True
		Me.categoria.Location = New System.Drawing.Point(105, 31)
		Me.categoria.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.categoria.Name = "categoria"
		Me.categoria.Size = New System.Drawing.Size(300, 27)
		Me.categoria.TabIndex = 429
		'
		'vehiculo
		'
		Me.vehiculo.AutoSize = True
		Me.vehiculo.Checked = True
		Me.vehiculo.CheckState = System.Windows.Forms.CheckState.Checked
		Me.vehiculo.Enabled = False
		Me.vehiculo.Location = New System.Drawing.Point(408, 32)
		Me.vehiculo.Name = "vehiculo"
		Me.vehiculo.Size = New System.Drawing.Size(84, 23)
		Me.vehiculo.TabIndex = 444
		Me.vehiculo.Text = "Vehiculo"
		Me.vehiculo.UseVisualStyleBackColor = True
		'
		'FiltroReceptor
		'
		Me.FiltroReceptor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.FiltroReceptor.Checked = True
		Me.FiltroReceptor.CheckState = System.Windows.Forms.CheckState.Checked
		Me.FiltroReceptor.Location = New System.Drawing.Point(3, 61)
		Me.FiltroReceptor.Name = "FiltroReceptor"
		Me.FiltroReceptor.Size = New System.Drawing.Size(99, 23)
		Me.FiltroReceptor.TabIndex = 449
		Me.FiltroReceptor.Text = "Receptor"
		Me.FiltroReceptor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.FiltroReceptor.UseVisualStyleBackColor = True
		'
		'receptor
		'
		Me.receptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.receptor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.receptor.FormattingEnabled = True
		Me.receptor.Location = New System.Drawing.Point(105, 60)
		Me.receptor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.receptor.Name = "receptor"
		Me.receptor.Size = New System.Drawing.Size(300, 27)
		Me.receptor.TabIndex = 434
		'
		'NewReceptor
		'
		Me.NewReceptor.FlatAppearance.BorderSize = 0
		Me.NewReceptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.NewReceptor.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NewReceptor.ForeColor = System.Drawing.Color.White
		Me.NewReceptor.Location = New System.Drawing.Point(405, 60)
		Me.NewReceptor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.NewReceptor.Name = "NewReceptor"
		Me.NewReceptor.Size = New System.Drawing.Size(27, 27)
		Me.NewReceptor.TabIndex = 441
		Me.NewReceptor.Text = ""
		Me.NewReceptor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.NewReceptor.UseVisualStyleBackColor = False
		'
		'EditReceptor
		'
		Me.EditReceptor.FlatAppearance.BorderSize = 0
		Me.EditReceptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.EditReceptor.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EditReceptor.ForeColor = System.Drawing.Color.White
		Me.EditReceptor.Location = New System.Drawing.Point(432, 60)
		Me.EditReceptor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.EditReceptor.Name = "EditReceptor"
		Me.EditReceptor.Size = New System.Drawing.Size(27, 27)
		Me.EditReceptor.TabIndex = 442
		Me.EditReceptor.Text = ""
		Me.EditReceptor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.EditReceptor.UseVisualStyleBackColor = False
		'
		'DelReceptor
		'
		Me.DelReceptor.FlatAppearance.BorderSize = 0
		Me.DelReceptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelReceptor.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelReceptor.ForeColor = System.Drawing.Color.White
		Me.DelReceptor.Location = New System.Drawing.Point(459, 60)
		Me.DelReceptor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.DelReceptor.Name = "DelReceptor"
		Me.DelReceptor.Size = New System.Drawing.Size(27, 27)
		Me.DelReceptor.TabIndex = 443
		Me.DelReceptor.Text = ""
		Me.DelReceptor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.DelReceptor.UseVisualStyleBackColor = False
		'
		'bs_receptor
		'
		'
		'bs_categoria
		'
		'
		'bs_cuenta
		'
		'
		'bs_historial
		'
		'
		'ModCombustible
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(600, 440)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(520, 310)
		Me.Name = "ModCombustible"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Tickets de Combustible"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		CType(Me.historial, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel4.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents info As ToolStripStatusLabel
	Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Button3 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents historial As DataGridView
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents EditTicket As Button
	Friend WithEvents DelTicket As Button
	Friend WithEvents bs_categoria As BindingSource
	Friend WithEvents bs_cuenta As BindingSource
	Friend WithEvents bs_receptor As BindingSource
	Friend WithEvents AddTicket As Button
	Public WithEvents bs_historial As BindingSource
	Friend WithEvents Panel4 As Panel
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents cuenta As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents categoria As ComboBox
	Friend WithEvents vehiculo As CheckBox
	Public WithEvents receptor As ComboBox
	Friend WithEvents NewReceptor As Button
	Friend WithEvents EditReceptor As Button
	Friend WithEvents DelReceptor As Button
	Friend WithEvents FiltroCuenta As CheckBox
	Friend WithEvents FiltroCategoria As CheckBox
	Friend WithEvents FiltroReceptor As CheckBox
End Class
