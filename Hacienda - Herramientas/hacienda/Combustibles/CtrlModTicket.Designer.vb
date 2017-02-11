<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlModTicket
	Inherits System.Windows.Forms.UserControl

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
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.CtrlBusquedaCombustiblePorProveedor1 = New Sigm.CtrlCombustiblePorProveedor()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.minimo = New System.Windows.Forms.NumericUpDown()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Button23 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Panel3.SuspendLayout()
		Me.FlowLayoutPanel3.SuspendLayout()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.minimo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.FlowLayoutPanel3)
		Me.Panel3.Controls.Add(Me.Panel4)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel3.Location = New System.Drawing.Point(0, 0)
		Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(428, 248)
		Me.Panel3.TabIndex = 428
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.Silver
		Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel3.Controls.Add(Me.DateTimePicker1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label9)
		Me.FlowLayoutPanel3.Controls.Add(Me.CtrlBusquedaCombustiblePorProveedor1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel3.Controls.Add(Me.MaskedTextBox1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label11)
		Me.FlowLayoutPanel3.Controls.Add(Me.ComboBox1)
		Me.FlowLayoutPanel3.Controls.Add(Me.Button2)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel3.Controls.Add(Me.minimo)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel3.Controls.Add(Me.NumericUpDown1)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 27)
		Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(428, 221)
		Me.FlowLayoutPanel3.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(4, 2)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 2, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(88, 31)
		Me.Label2.TabIndex = 407
		Me.Label2.Text = "Fecha"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(92, 4)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(117, 27)
		Me.DateTimePicker1.TabIndex = 432
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(213, 0)
		Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(204, 28)
		Me.Label9.TabIndex = 433
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(4, 94)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(88, 31)
		Me.Label8.TabIndex = 431
		Me.Label8.Text = "Ticket Nro."
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'MaskedTextBox1
		'
		Me.MaskedTextBox1.Location = New System.Drawing.Point(92, 97)
		Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.MaskedTextBox1.Mask = "000000-000000000000"
		Me.MaskedTextBox1.Name = "MaskedTextBox1"
		Me.MaskedTextBox1.Size = New System.Drawing.Size(167, 27)
		Me.MaskedTextBox1.TabIndex = 405
		Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(263, 94)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(154, 28)
		Me.Label1.TabIndex = 406
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'CtrlBusquedaCombustiblePorProveedor1
		'
		Me.CtrlBusquedaCombustiblePorProveedor1.BackColor = System.Drawing.Color.Silver
		Me.CtrlBusquedaCombustiblePorProveedor1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CtrlBusquedaCombustiblePorProveedor1.Location = New System.Drawing.Point(0, 33)
		Me.CtrlBusquedaCombustiblePorProveedor1.Margin = New System.Windows.Forms.Padding(0)
		Me.CtrlBusquedaCombustiblePorProveedor1.Name = "CtrlBusquedaCombustiblePorProveedor1"
		Me.CtrlBusquedaCombustiblePorProveedor1.Size = New System.Drawing.Size(428, 61)
		Me.CtrlBusquedaCombustiblePorProveedor1.TabIndex = 424
		'
		'Label11
		'
		Me.Label11.Location = New System.Drawing.Point(4, 125)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(88, 31)
		Me.Label11.TabIndex = 435
		Me.Label11.Text = "Compra"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(92, 128)
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
		Me.Button2.Location = New System.Drawing.Point(392, 129)
		Me.Button2.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(26, 26)
		Me.Button2.TabIndex = 438
		Me.Button2.Text = ""
		Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(4, 186)
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
		Me.NumericUpDown1.Location = New System.Drawing.Point(92, 189)
		Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.NumericUpDown1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
		Me.NumericUpDown1.Name = "NumericUpDown1"
		Me.NumericUpDown1.Size = New System.Drawing.Size(117, 27)
		Me.NumericUpDown1.TabIndex = 429
		Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.NumericUpDown1.ThousandsSeparator = True
		Me.NumericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(4, 156)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(88, 26)
		Me.Label3.TabIndex = 425
		Me.Label3.Text = "Litros"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'minimo
		'
		Me.minimo.Location = New System.Drawing.Point(92, 159)
		Me.minimo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.minimo.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
		Me.minimo.Name = "minimo"
		Me.minimo.Size = New System.Drawing.Size(117, 27)
		Me.minimo.TabIndex = 426
		Me.minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.minimo.ThousandsSeparator = True
		Me.minimo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.Gray
		Me.Panel4.Controls.Add(Me.Label4)
		Me.Panel4.Controls.Add(Me.Button23)
		Me.Panel4.Controls.Add(Me.Button4)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(428, 27)
		Me.Panel4.TabIndex = 430
		'
		'Label4
		'
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
		Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(369, 27)
		Me.Label4.TabIndex = 435
		Me.Label4.Text = "DETALLE DE TICKET"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Button23
		'
		Me.Button23.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button23.FlatAppearance.BorderSize = 0
		Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button23.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button23.ForeColor = System.Drawing.Color.White
		Me.Button23.Location = New System.Drawing.Point(374, 0)
		Me.Button23.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button23.Name = "Button23"
		Me.Button23.Size = New System.Drawing.Size(27, 27)
		Me.Button23.TabIndex = 432
		Me.Button23.Text = ""
		Me.Button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.Button23, "Guardar Cambios")
		Me.Button23.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.White
		Me.Button4.Location = New System.Drawing.Point(401, 0)
		Me.Button4.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(27, 27)
		Me.Button4.TabIndex = 434
		Me.Button4.Text = ""
		Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.ToolTip1.SetToolTip(Me.Button4, "Cancelar")
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(213, 156)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(205, 28)
		Me.Label5.TabIndex = 439
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'CtrlModTicket
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.Panel3)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "CtrlModTicket"
		Me.Size = New System.Drawing.Size(428, 248)
		Me.Panel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.minimo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel3 As Panel
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label9 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents MaskedTextBox1 As MaskedTextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents CtrlBusquedaCombustiblePorProveedor1 As CtrlCombustiblePorProveedor
	Friend WithEvents Label11 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents NumericUpDown1 As NumericUpDown
	Friend WithEvents Label3 As Label
	Friend WithEvents minimo As NumericUpDown
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Button23 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents Label5 As Label
End Class
