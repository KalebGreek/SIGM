<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabMultas1Boleta
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
		Me.ErrorInfo = New System.Windows.Forms.ToolTip(Me.components)
		Me.observaciones = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.ubicacion = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.pago = New System.Windows.Forms.CheckBox()
		Me.fecha_pago = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.fecha_boleta = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.inspector = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.articulo = New System.Windows.Forms.ComboBox()
		Me.DetalleArticulo = New System.Windows.Forms.TextBox()
		Me.bs_articulo = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_inspector = New System.Windows.Forms.BindingSource(Me.components)
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.bs_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_inspector, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'observaciones
		'
		Me.observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.observaciones.Location = New System.Drawing.Point(3, 202)
		Me.observaciones.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.observaciones.MaxLength = 110
		Me.observaciones.Multiline = True
		Me.observaciones.Name = "observaciones"
		Me.observaciones.Size = New System.Drawing.Size(346, 64)
		Me.observaciones.TabIndex = 242
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(105, 184)
		Me.Label8.Margin = New System.Windows.Forms.Padding(0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(246, 18)
		Me.Label8.TabIndex = 244
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(0, 184)
		Me.Label6.Margin = New System.Windows.Forms.Padding(0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(105, 18)
		Me.Label6.TabIndex = 241
		Me.Label6.Text = "Observaciones"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ubicacion
		'
		Me.ubicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.ubicacion.Location = New System.Drawing.Point(3, 117)
		Me.ubicacion.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.ubicacion.MaxLength = 110
		Me.ubicacion.Multiline = True
		Me.ubicacion.Name = "ubicacion"
		Me.ubicacion.Size = New System.Drawing.Size(346, 64)
		Me.ubicacion.TabIndex = 237
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(105, 99)
		Me.Label7.Margin = New System.Windows.Forms.Padding(0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(246, 18)
		Me.Label7.TabIndex = 243
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(0, 99)
		Me.Label4.Margin = New System.Windows.Forms.Padding(0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(105, 18)
		Me.Label4.TabIndex = 236
		Me.Label4.Text = "Ubicación"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'pago
		'
		Me.pago.AutoSize = True
		Me.pago.Location = New System.Drawing.Point(201, 275)
		Me.pago.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
		Me.pago.Name = "pago"
		Me.pago.Size = New System.Drawing.Size(77, 23)
		Me.pago.TabIndex = 240
		Me.pago.Text = "Pagada"
		Me.pago.UseVisualStyleBackColor = True
		'
		'fecha_pago
		'
		Me.fecha_pago.CustomFormat = "dd/MM/yyyy"
		Me.fecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.fecha_pago.Location = New System.Drawing.Point(100, 272)
		Me.fecha_pago.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
		Me.fecha_pago.Name = "fecha_pago"
		Me.fecha_pago.Size = New System.Drawing.Size(95, 27)
		Me.fecha_pago.TabIndex = 239
		Me.fecha_pago.Value = New Date(2019, 1, 20, 20, 56, 56, 0)
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(0, 272)
		Me.Label5.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(97, 25)
		Me.Label5.TabIndex = 238
		Me.Label5.Text = "Fecha Pago"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(281, 3)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(70, 30)
		Me.Label3.TabIndex = 235
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'fecha_boleta
		'
		Me.fecha_boleta.CustomFormat = "dd/MM/yyyy HH:mm:ss"
		Me.fecha_boleta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.fecha_boleta.Location = New System.Drawing.Point(100, 3)
		Me.fecha_boleta.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
		Me.fecha_boleta.Name = "fecha_boleta"
		Me.fecha_boleta.Size = New System.Drawing.Size(178, 27)
		Me.fecha_boleta.TabIndex = 234
		Me.fecha_boleta.Value = New Date(2019, 1, 20, 20, 57, 2, 0)
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(0, 3)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(97, 25)
		Me.Label2.TabIndex = 233
		Me.Label2.Text = "Fecha y Hora"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.fecha_boleta)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
		Me.FlowLayoutPanel1.Controls.Add(Me.inspector)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.articulo)
		Me.FlowLayoutPanel1.Controls.Add(Me.DetalleArticulo)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel1.Controls.Add(Me.ubicacion)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel1.Controls.Add(Me.observaciones)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.fecha_pago)
		Me.FlowLayoutPanel1.Controls.Add(Me.pago)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(360, 316)
		Me.FlowLayoutPanel1.TabIndex = 379
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(0, 36)
		Me.Label9.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(97, 25)
		Me.Label9.TabIndex = 248
		Me.Label9.Text = "Inspector"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'inspector
		'
		Me.inspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.inspector.FormattingEnabled = True
		Me.inspector.Location = New System.Drawing.Point(100, 36)
		Me.inspector.Name = "inspector"
		Me.inspector.Size = New System.Drawing.Size(249, 27)
		Me.inspector.TabIndex = 249
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(0, 69)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(97, 25)
		Me.Label1.TabIndex = 246
		Me.Label1.Text = "Artículo N°"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'articulo
		'
		Me.articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.articulo.FormattingEnabled = True
		Me.articulo.Location = New System.Drawing.Point(100, 69)
		Me.articulo.Name = "articulo"
		Me.articulo.Size = New System.Drawing.Size(57, 27)
		Me.articulo.TabIndex = 245
		'
		'DetalleArticulo
		'
		Me.DetalleArticulo.Location = New System.Drawing.Point(163, 69)
		Me.DetalleArticulo.Name = "DetalleArticulo"
		Me.DetalleArticulo.ReadOnly = True
		Me.DetalleArticulo.Size = New System.Drawing.Size(186, 27)
		Me.DetalleArticulo.TabIndex = 247
		'
		'bs_articulo
		'
		'
		'tabMultas1Boleta
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "tabMultas1Boleta"
		Me.Size = New System.Drawing.Size(360, 316)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		CType(Me.bs_articulo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_inspector, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ErrorInfo As ToolTip
	Friend WithEvents observaciones As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents ubicacion As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents pago As CheckBox
	Friend WithEvents fecha_pago As DateTimePicker
	Friend WithEvents Label5 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents fecha_boleta As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents articulo As ComboBox
	Friend WithEvents DetalleArticulo As TextBox
	Friend WithEvents bs_articulo As BindingSource
	Friend WithEvents Label9 As Label
	Friend WithEvents inspector As ComboBox
	Friend WithEvents bs_inspector As BindingSource
End Class
