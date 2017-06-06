<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModNotaPedido
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
		Me.nota_pedido_id = New System.Windows.Forms.TextBox()
		Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
		Me.cancel = New System.Windows.Forms.Button()
		Me.save = New System.Windows.Forms.Button()
		Me.nextPage = New System.Windows.Forms.Button()
		Me.lastPage = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.buscar_proveedor = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.buscar_empleado = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.buscar_autoridad = New System.Windows.Forms.Button()
		Me.detalle = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.grupo_mod.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'nota_pedido_id
		'
		Me.nota_pedido_id.BackColor = System.Drawing.Color.Gold
		Me.nota_pedido_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.nota_pedido_id.Location = New System.Drawing.Point(298, 3)
		Me.nota_pedido_id.MaxLength = 128
		Me.nota_pedido_id.Name = "nota_pedido_id"
		Me.nota_pedido_id.ReadOnly = True
		Me.nota_pedido_id.Size = New System.Drawing.Size(25, 27)
		Me.nota_pedido_id.TabIndex = 373
		Me.nota_pedido_id.Text = "0"
		Me.nota_pedido_id.Visible = False
		'
		'grupo_mod
		'
		Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
		Me.grupo_mod.Controls.Add(Me.nota_pedido_id)
		Me.grupo_mod.Controls.Add(Me.cancel)
		Me.grupo_mod.Controls.Add(Me.save)
		Me.grupo_mod.Controls.Add(Me.nextPage)
		Me.grupo_mod.Controls.Add(Me.lastPage)
		Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.grupo_mod.Location = New System.Drawing.Point(0, 347)
		Me.grupo_mod.Margin = New System.Windows.Forms.Padding(0)
		Me.grupo_mod.Name = "grupo_mod"
		Me.grupo_mod.Size = New System.Drawing.Size(326, 28)
		Me.grupo_mod.TabIndex = 395
		'
		'cancel
		'
		Me.cancel.FlatAppearance.BorderSize = 0
		Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancel.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cancel.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.cancel.Location = New System.Drawing.Point(266, 0)
		Me.cancel.Margin = New System.Windows.Forms.Padding(0)
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(29, 29)
		Me.cancel.TabIndex = 398
		Me.cancel.Text = ""
		Me.cancel.UseVisualStyleBackColor = True
		'
		'save
		'
		Me.save.FlatAppearance.BorderSize = 0
		Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.save.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.save.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.save.Location = New System.Drawing.Point(237, 0)
		Me.save.Margin = New System.Windows.Forms.Padding(0)
		Me.save.Name = "save"
		Me.save.Size = New System.Drawing.Size(29, 29)
		Me.save.TabIndex = 397
		Me.save.Text = ""
		Me.save.UseVisualStyleBackColor = True
		'
		'nextPage
		'
		Me.nextPage.FlatAppearance.BorderSize = 0
		Me.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.nextPage.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nextPage.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.nextPage.Location = New System.Drawing.Point(208, 0)
		Me.nextPage.Margin = New System.Windows.Forms.Padding(0)
		Me.nextPage.Name = "nextPage"
		Me.nextPage.Size = New System.Drawing.Size(29, 29)
		Me.nextPage.TabIndex = 399
		Me.nextPage.Text = ""
		Me.nextPage.UseVisualStyleBackColor = True
		Me.nextPage.Visible = False
		'
		'lastPage
		'
		Me.lastPage.Enabled = False
		Me.lastPage.FlatAppearance.BorderSize = 0
		Me.lastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lastPage.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lastPage.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lastPage.Location = New System.Drawing.Point(179, 0)
		Me.lastPage.Margin = New System.Windows.Forms.Padding(0)
		Me.lastPage.Name = "lastPage"
		Me.lastPage.Size = New System.Drawing.Size(29, 29)
		Me.lastPage.TabIndex = 400
		Me.lastPage.Text = ""
		Me.lastPage.UseVisualStyleBackColor = True
		Me.lastPage.Visible = False
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.DateTimePicker1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel1.Controls.Add(Me.TextBox2)
		Me.FlowLayoutPanel1.Controls.Add(Me.buscar_proveedor)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.TextBox5)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.TextBox3)
		Me.FlowLayoutPanel1.Controls.Add(Me.buscar_empleado)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Controls.Add(Me.TextBox4)
		Me.FlowLayoutPanel1.Controls.Add(Me.buscar_autoridad)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.detalle)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(326, 347)
		Me.FlowLayoutPanel1.TabIndex = 414
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(0, 0)
		Me.Label7.Margin = New System.Windows.Forms.Padding(0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(80, 31)
		Me.Label7.TabIndex = 404
		Me.Label7.Text = "Nota N°"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.Color.White
		Me.TextBox1.Location = New System.Drawing.Point(80, 2)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(65, 27)
		Me.TextBox1.TabIndex = 405
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(145, 0)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(49, 31)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Fecha"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(194, 2)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(102, 27)
		Me.DateTimePicker1.TabIndex = 2
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(0, 31)
		Me.Label6.Margin = New System.Windows.Forms.Padding(0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(80, 29)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Proveedor"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox2
		'
		Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TextBox2.Location = New System.Drawing.Point(80, 31)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(0)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = True
		Me.TextBox2.Size = New System.Drawing.Size(216, 27)
		Me.TextBox2.TabIndex = 10
		'
		'buscar_proveedor
		'
		Me.buscar_proveedor.BackColor = System.Drawing.Color.Transparent
		Me.buscar_proveedor.FlatAppearance.BorderSize = 0
		Me.buscar_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buscar_proveedor.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.buscar_proveedor.ForeColor = System.Drawing.Color.Black
		Me.buscar_proveedor.Location = New System.Drawing.Point(296, 31)
		Me.buscar_proveedor.Margin = New System.Windows.Forms.Padding(0)
		Me.buscar_proveedor.Name = "buscar_proveedor"
		Me.buscar_proveedor.Size = New System.Drawing.Size(25, 29)
		Me.buscar_proveedor.TabIndex = 399
		Me.buscar_proveedor.Text = ""
		Me.buscar_proveedor.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(0, 89)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 29)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Pedido por"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox3
		'
		Me.TextBox3.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TextBox3.Location = New System.Drawing.Point(80, 89)
		Me.TextBox3.Margin = New System.Windows.Forms.Padding(0)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.ReadOnly = True
		Me.TextBox3.Size = New System.Drawing.Size(216, 27)
		Me.TextBox3.TabIndex = 400
		'
		'buscar_empleado
		'
		Me.buscar_empleado.BackColor = System.Drawing.Color.Transparent
		Me.buscar_empleado.FlatAppearance.BorderSize = 0
		Me.buscar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buscar_empleado.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.buscar_empleado.ForeColor = System.Drawing.Color.Black
		Me.buscar_empleado.Location = New System.Drawing.Point(296, 89)
		Me.buscar_empleado.Margin = New System.Windows.Forms.Padding(0)
		Me.buscar_empleado.Name = "buscar_empleado"
		Me.buscar_empleado.Size = New System.Drawing.Size(25, 29)
		Me.buscar_empleado.TabIndex = 401
		Me.buscar_empleado.Text = ""
		Me.buscar_empleado.UseVisualStyleBackColor = False
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(0, 118)
		Me.Label4.Margin = New System.Windows.Forms.Padding(0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(80, 29)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Autoriza"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox4
		'
		Me.TextBox4.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TextBox4.Location = New System.Drawing.Point(80, 118)
		Me.TextBox4.Margin = New System.Windows.Forms.Padding(0)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.ReadOnly = True
		Me.TextBox4.Size = New System.Drawing.Size(216, 27)
		Me.TextBox4.TabIndex = 402
		'
		'buscar_autoridad
		'
		Me.buscar_autoridad.BackColor = System.Drawing.Color.Transparent
		Me.buscar_autoridad.FlatAppearance.BorderSize = 0
		Me.buscar_autoridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buscar_autoridad.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.buscar_autoridad.ForeColor = System.Drawing.Color.Black
		Me.buscar_autoridad.Location = New System.Drawing.Point(296, 118)
		Me.buscar_autoridad.Margin = New System.Windows.Forms.Padding(0)
		Me.buscar_autoridad.Name = "buscar_autoridad"
		Me.buscar_autoridad.Size = New System.Drawing.Size(25, 29)
		Me.buscar_autoridad.TabIndex = 403
		Me.buscar_autoridad.Text = ""
		Me.buscar_autoridad.UseVisualStyleBackColor = False
		'
		'detalle
		'
		Me.detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.detalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.detalle.Location = New System.Drawing.Point(80, 148)
		Me.detalle.Margin = New System.Windows.Forms.Padding(0, 1, 0, 3)
		Me.detalle.MaxLength = 290
		Me.detalle.Multiline = True
		Me.detalle.Name = "detalle"
		Me.detalle.Size = New System.Drawing.Size(240, 194)
		Me.detalle.TabIndex = 7
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(0, 147)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(80, 29)
		Me.Label3.TabIndex = 406
		Me.Label3.Text = "Detalle"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(0, 60)
		Me.Label5.Margin = New System.Windows.Forms.Padding(0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(80, 29)
		Me.Label5.TabIndex = 407
		Me.Label5.Text = "Destino"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(80, 60)
		Me.TextBox5.Margin = New System.Windows.Forms.Padding(0)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(216, 27)
		Me.TextBox5.TabIndex = 408
		'
		'ModNotaPedido
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(326, 375)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.grupo_mod)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(250, 250)
		Me.Name = "ModNotaPedido"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Nueva Nota de Pedido                                                 "
		Me.grupo_mod.ResumeLayout(False)
		Me.grupo_mod.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents nota_pedido_id As System.Windows.Forms.TextBox
	Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents cancel As Button
	Friend WithEvents save As Button
	Friend WithEvents nextPage As Button
	Friend WithEvents lastPage As Button
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents detalle As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents buscar_proveedor As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents buscar_empleado As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents buscar_autoridad As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBox5 As TextBox
End Class
