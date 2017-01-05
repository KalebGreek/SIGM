<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModBeneficiario
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
		Me.Menu1 = New System.Windows.Forms.MenuStrip()
		Me.titulo = New System.Windows.Forms.ToolStripMenuItem()
		Me.cancel = New System.Windows.Forms.ToolStripMenuItem()
		Me.et_monto = New System.Windows.Forms.Label()
		Me.et_fecha = New System.Windows.Forms.Label()
		Me.fecha = New System.Windows.Forms.DateTimePicker()
		Me.cuota = New System.Windows.Forms.NumericUpDown()
		Me.monto = New System.Windows.Forms.NumericUpDown()
		Me.et_cuota = New System.Windows.Forms.Label()
		Me.Label46 = New System.Windows.Forms.Label()
		Me.desc = New System.Windows.Forms.ComboBox()
		Me.beneficiario_id = New System.Windows.Forms.Label()
		Me.bs_pago = New System.Windows.Forms.BindingSource(Me.components)
		Me.Menu1.SuspendLayout()
		CType(Me.cuota, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.monto, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_pago, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Menu1
		'
		Me.Menu1.AutoSize = False
		Me.Menu1.BackColor = System.Drawing.Color.DarkGray
		Me.Menu1.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.Menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.titulo, Me.cancel})
		Me.Menu1.Location = New System.Drawing.Point(0, 0)
		Me.Menu1.Name = "Menu1"
		Me.Menu1.Size = New System.Drawing.Size(450, 30)
		Me.Menu1.TabIndex = 156
		Me.Menu1.Text = "MenuStrip1"
		'
		'titulo
		'
		Me.titulo.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!, System.Drawing.FontStyle.Bold)
		Me.titulo.ForeColor = System.Drawing.Color.White
		Me.titulo.Name = "titulo"
		Me.titulo.Size = New System.Drawing.Size(229, 26)
		Me.titulo.Text = "> AGREGAR BENEFICIARIO"
		'
		'cancel
		'
		Me.cancel.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.cancel.ForeColor = System.Drawing.Color.White
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(60, 26)
		Me.cancel.Text = "Cerrar"
		'
		'et_monto
		'
		Me.et_monto.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.et_monto.Location = New System.Drawing.Point(0, 102)
		Me.et_monto.Name = "et_monto"
		Me.et_monto.Size = New System.Drawing.Size(140, 29)
		Me.et_monto.TabIndex = 216
		Me.et_monto.Text = "Deuda Total   $ "
		Me.et_monto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'et_fecha
		'
		Me.et_fecha.Location = New System.Drawing.Point(0, 40)
		Me.et_fecha.Name = "et_fecha"
		Me.et_fecha.Size = New System.Drawing.Size(140, 24)
		Me.et_fecha.TabIndex = 221
		Me.et_fecha.Text = "1° Vencimiento"
		Me.et_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'fecha
		'
		Me.fecha.CalendarFont = New System.Drawing.Font("PF DinDisplay Pro Light", 14.0!)
		Me.fecha.CustomFormat = "dd MMMM yyyy"
		Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.fecha.Location = New System.Drawing.Point(140, 39)
		Me.fecha.MaxDate = New Date(2100, 1, 1, 0, 0, 0, 0)
		Me.fecha.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
		Me.fecha.Name = "fecha"
		Me.fecha.Size = New System.Drawing.Size(127, 27)
		Me.fecha.TabIndex = 220
		'
		'cuota
		'
		Me.cuota.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.cuota.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.cuota.ForeColor = System.Drawing.Color.Black
		Me.cuota.Location = New System.Drawing.Point(140, 136)
		Me.cuota.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
		Me.cuota.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.cuota.Name = "cuota"
		Me.cuota.Size = New System.Drawing.Size(64, 23)
		Me.cuota.TabIndex = 219
		Me.cuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.cuota.ThousandsSeparator = True
		Me.cuota.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'monto
		'
		Me.monto.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.monto.DecimalPlaces = 2
		Me.monto.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.monto.ForeColor = System.Drawing.Color.Black
		Me.monto.Location = New System.Drawing.Point(123, 106)
		Me.monto.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
		Me.monto.Name = "monto"
		Me.monto.Size = New System.Drawing.Size(126, 23)
		Me.monto.TabIndex = 218
		Me.monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.monto.ThousandsSeparator = True
		Me.monto.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'et_cuota
		'
		Me.et_cuota.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.et_cuota.Location = New System.Drawing.Point(0, 133)
		Me.et_cuota.Name = "et_cuota"
		Me.et_cuota.Size = New System.Drawing.Size(140, 24)
		Me.et_cuota.TabIndex = 217
		Me.et_cuota.Text = "Cuotas"
		Me.et_cuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label46
		'
		Me.Label46.Location = New System.Drawing.Point(0, 73)
		Me.Label46.Name = "Label46"
		Me.Label46.Size = New System.Drawing.Size(140, 24)
		Me.Label46.TabIndex = 215
		Me.Label46.Text = "Descripción"
		Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'desc
		'
		Me.desc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.desc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.desc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.desc.FormattingEnabled = True
		Me.desc.ItemHeight = 19
		Me.desc.Items.AddRange(New Object() {"INSPECCION PREVIA", "VISACION DE PLANOS", "LINEA MUNICIPAL"})
		Me.desc.Location = New System.Drawing.Point(140, 72)
		Me.desc.Name = "desc"
		Me.desc.Size = New System.Drawing.Size(242, 27)
		Me.desc.TabIndex = 371
		'
		'beneficiario_id
		'
		Me.beneficiario_id.AutoSize = True
		Me.beneficiario_id.BackColor = System.Drawing.SystemColors.GrayText
		Me.beneficiario_id.Location = New System.Drawing.Point(365, 42)
		Me.beneficiario_id.Name = "beneficiario_id"
		Me.beneficiario_id.Size = New System.Drawing.Size(17, 19)
		Me.beneficiario_id.TabIndex = 381
		Me.beneficiario_id.Text = "0"
		Me.beneficiario_id.Visible = False
		'
		'ModBeneficiario
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(450, 390)
		Me.Controls.Add(Me.beneficiario_id)
		Me.Controls.Add(Me.et_monto)
		Me.Controls.Add(Me.et_fecha)
		Me.Controls.Add(Me.fecha)
		Me.Controls.Add(Me.cuota)
		Me.Controls.Add(Me.monto)
		Me.Controls.Add(Me.et_cuota)
		Me.Controls.Add(Me.Label46)
		Me.Controls.Add(Me.Menu1)
		Me.Controls.Add(Me.desc)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximumSize = New System.Drawing.Size(450, 390)
		Me.MinimumSize = New System.Drawing.Size(450, 390)
		Me.Name = "ModBeneficiario"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "verify_cat"
		Me.Menu1.ResumeLayout(False)
		Me.Menu1.PerformLayout()
		CType(Me.cuota, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.monto, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_pago, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Menu1 As System.Windows.Forms.MenuStrip
	Friend WithEvents titulo As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents et_monto As System.Windows.Forms.Label
	Friend WithEvents et_fecha As System.Windows.Forms.Label
	Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
	Friend WithEvents cuota As System.Windows.Forms.NumericUpDown
	Friend WithEvents monto As System.Windows.Forms.NumericUpDown
	Friend WithEvents et_cuota As System.Windows.Forms.Label
	Friend WithEvents Label46 As System.Windows.Forms.Label
	Friend WithEvents desc As System.Windows.Forms.ComboBox
	Friend WithEvents cancel As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents bs_pago As System.Windows.Forms.BindingSource
	Friend WithEvents beneficiario_id As System.Windows.Forms.Label
End Class
