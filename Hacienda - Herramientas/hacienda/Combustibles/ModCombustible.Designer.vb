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
		Me.ShowEditItem = New System.Windows.Forms.Button()
		Me.DelItem = New System.Windows.Forms.Button()
		Me.AddItem = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.info = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.historial = New System.Windows.Forms.DataGridView()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.seccion = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.categoria = New System.Windows.Forms.ComboBox()
		Me.vehiculo = New System.Windows.Forms.CheckBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.receptor = New System.Windows.Forms.ComboBox()
		Me.NewReceptor = New System.Windows.Forms.Button()
		Me.EditReceptor = New System.Windows.Forms.Button()
		Me.DelReceptor = New System.Windows.Forms.Button()
		Me.bs_receptor = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_categoria = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_seccion = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_historial = New System.Windows.Forms.BindingSource(Me.components)
		Me.StatusStrip1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.historial, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_seccion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ShowEditItem
		'
		Me.ShowEditItem.BackColor = System.Drawing.Color.Gray
		Me.ShowEditItem.Dock = System.Windows.Forms.DockStyle.Right
		Me.ShowEditItem.FlatAppearance.BorderSize = 0
		Me.ShowEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ShowEditItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ShowEditItem.ForeColor = System.Drawing.Color.White
		Me.ShowEditItem.Location = New System.Drawing.Point(528, 0)
		Me.ShowEditItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.ShowEditItem.Name = "ShowEditItem"
		Me.ShowEditItem.Size = New System.Drawing.Size(36, 24)
		Me.ShowEditItem.TabIndex = 438
		Me.ShowEditItem.Text = ""
		Me.ShowEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.ShowEditItem, "Editar Ticket")
		Me.ShowEditItem.UseVisualStyleBackColor = False
		'
		'DelItem
		'
		Me.DelItem.BackColor = System.Drawing.Color.Gray
		Me.DelItem.Dock = System.Windows.Forms.DockStyle.Right
		Me.DelItem.FlatAppearance.BorderSize = 0
		Me.DelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelItem.ForeColor = System.Drawing.Color.White
		Me.DelItem.Location = New System.Drawing.Point(564, 0)
		Me.DelItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.DelItem.Name = "DelItem"
		Me.DelItem.Size = New System.Drawing.Size(36, 24)
		Me.DelItem.TabIndex = 437
		Me.DelItem.Text = ""
		Me.DelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.DelItem, "Eliminar Ticket Seleccionado")
		Me.DelItem.UseVisualStyleBackColor = False
		'
		'AddItem
		'
		Me.AddItem.BackColor = System.Drawing.Color.Gray
		Me.AddItem.Dock = System.Windows.Forms.DockStyle.Right
		Me.AddItem.FlatAppearance.BorderSize = 0
		Me.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AddItem.ForeColor = System.Drawing.Color.White
		Me.AddItem.Location = New System.Drawing.Point(492, 0)
		Me.AddItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.AddItem.Name = "AddItem"
		Me.AddItem.Size = New System.Drawing.Size(36, 24)
		Me.AddItem.TabIndex = 439
		Me.AddItem.Text = ""
		Me.AddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.AddItem, "Nuevo Ticket")
		Me.AddItem.UseVisualStyleBackColor = False
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
		Me.Panel2.Location = New System.Drawing.Point(0, 100)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(600, 316)
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
		Me.historial.Size = New System.Drawing.Size(600, 292)
		Me.historial.TabIndex = 3
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.AddItem)
		Me.Panel3.Controls.Add(Me.ShowEditItem)
		Me.Panel3.Controls.Add(Me.DelItem)
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
		Me.Panel4.Size = New System.Drawing.Size(600, 100)
		Me.Panel4.TabIndex = 429
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel1.Controls.Add(Me.seccion)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.categoria)
		Me.FlowLayoutPanel1.Controls.Add(Me.vehiculo)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.receptor)
		Me.FlowLayoutPanel1.Controls.Add(Me.NewReceptor)
		Me.FlowLayoutPanel1.Controls.Add(Me.EditReceptor)
		Me.FlowLayoutPanel1.Controls.Add(Me.DelReceptor)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 5)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(486, 91)
		Me.FlowLayoutPanel1.TabIndex = 429
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label7.Location = New System.Drawing.Point(4, 0)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(73, 29)
		Me.Label7.TabIndex = 431
		Me.Label7.Text = "Seccion"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'seccion
		'
		Me.seccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.seccion.FormattingEnabled = True
		Me.seccion.Location = New System.Drawing.Point(77, 2)
		Me.seccion.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.seccion.Name = "seccion"
		Me.seccion.Size = New System.Drawing.Size(300, 27)
		Me.seccion.TabIndex = 432
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label3.Location = New System.Drawing.Point(381, 0)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(104, 28)
		Me.Label3.TabIndex = 446
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label1.Location = New System.Drawing.Point(4, 29)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 28)
		Me.Label1.TabIndex = 428
		Me.Label1.Text = "Categoria"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'categoria
		'
		Me.categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.categoria.FormattingEnabled = True
		Me.categoria.Location = New System.Drawing.Point(77, 31)
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
		Me.vehiculo.Location = New System.Drawing.Point(380, 32)
		Me.vehiculo.Name = "vehiculo"
		Me.vehiculo.Size = New System.Drawing.Size(84, 23)
		Me.vehiculo.TabIndex = 444
		Me.vehiculo.Text = "Vehiculo"
		Me.vehiculo.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label5.Location = New System.Drawing.Point(4, 58)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(73, 29)
		Me.Label5.TabIndex = 427
		Me.Label5.Text = "Receptor"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'receptor
		'
		Me.receptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.receptor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.receptor.FormattingEnabled = True
		Me.receptor.Location = New System.Drawing.Point(77, 60)
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
		Me.NewReceptor.Location = New System.Drawing.Point(377, 60)
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
		Me.EditReceptor.Location = New System.Drawing.Point(404, 60)
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
		Me.DelReceptor.Location = New System.Drawing.Point(431, 60)
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
		'bs_seccion
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
		CType(Me.bs_seccion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents info As ToolStripStatusLabel
	Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents CtrlBusquedaCombustiblePorReceptor1 As Sigm.CtrlCombustiblePorReceptor
	Friend WithEvents Button3 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents historial As DataGridView
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents ShowEditItem As Button
	Friend WithEvents DelItem As Button
	Friend WithEvents bs_categoria As BindingSource
	Friend WithEvents bs_seccion As BindingSource
	Friend WithEvents bs_receptor As BindingSource
	Friend WithEvents AddItem As Button
	Public WithEvents bs_historial As BindingSource
	Friend WithEvents Panel4 As Panel
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label7 As Label
	Friend WithEvents seccion As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents categoria As ComboBox
	Friend WithEvents vehiculo As CheckBox
	Friend WithEvents Label5 As Label
	Public WithEvents receptor As ComboBox
	Friend WithEvents NewReceptor As Button
	Friend WithEvents EditReceptor As Button
	Friend WithEvents DelReceptor As Button
End Class
