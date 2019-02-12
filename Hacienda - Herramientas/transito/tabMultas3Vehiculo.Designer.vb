<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabMultas3Vehiculo
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
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.vehiculo_marca = New System.Windows.Forms.ComboBox()
		Me.vehiculo_id = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.vehiculo_tipo = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.patente = New System.Windows.Forms.MaskedTextBox()
		Me.mercosur = New System.Windows.Forms.CheckBox()
		Me.ErrorInfo = New System.Windows.Forms.ToolTip(Me.components)
		Me.bs_marca = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_tipo = New System.Windows.Forms.BindingSource(Me.components)
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.bs_marca, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label24)
		Me.FlowLayoutPanel1.Controls.Add(Me.vehiculo_marca)
		Me.FlowLayoutPanel1.Controls.Add(Me.vehiculo_id)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.vehiculo_tipo)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.patente)
		Me.FlowLayoutPanel1.Controls.Add(Me.mercosur)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(267, 105)
		Me.FlowLayoutPanel1.TabIndex = 379
		'
		'Label24
		'
		Me.Label24.Location = New System.Drawing.Point(0, 3)
		Me.Label24.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(69, 24)
		Me.Label24.TabIndex = 230
		Me.Label24.Text = "Marca"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'vehiculo_marca
		'
		Me.vehiculo_marca.FormattingEnabled = True
		Me.vehiculo_marca.Location = New System.Drawing.Point(72, 3)
		Me.vehiculo_marca.Name = "vehiculo_marca"
		Me.vehiculo_marca.Size = New System.Drawing.Size(161, 27)
		Me.vehiculo_marca.TabIndex = 246
		'
		'vehiculo_id
		'
		Me.vehiculo_id.BackColor = System.Drawing.Color.OrangeRed
		Me.vehiculo_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.vehiculo_id.Location = New System.Drawing.Point(236, 4)
		Me.vehiculo_id.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.vehiculo_id.MaxLength = 100
		Me.vehiculo_id.Name = "vehiculo_id"
		Me.vehiculo_id.Size = New System.Drawing.Size(25, 27)
		Me.vehiculo_id.TabIndex = 422
		Me.vehiculo_id.Text = "0"
		Me.vehiculo_id.Visible = False
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(0, 36)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(69, 24)
		Me.Label2.TabIndex = 247
		Me.Label2.Text = "Tipo"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'vehiculo_tipo
		'
		Me.vehiculo_tipo.FormattingEnabled = True
		Me.vehiculo_tipo.Location = New System.Drawing.Point(72, 36)
		Me.vehiculo_tipo.Name = "vehiculo_tipo"
		Me.vehiculo_tipo.Size = New System.Drawing.Size(161, 27)
		Me.vehiculo_tipo.TabIndex = 251
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(0, 69)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(69, 24)
		Me.Label1.TabIndex = 234
		Me.Label1.Text = "Patente"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'patente
		'
		Me.patente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		Me.patente.Location = New System.Drawing.Point(72, 69)
		Me.patente.Mask = "AA 999 AA"
		Me.patente.Name = "patente"
		Me.patente.Size = New System.Drawing.Size(96, 27)
		Me.patente.TabIndex = 232
		Me.patente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.patente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
		'
		'mercosur
		'
		Me.mercosur.AutoSize = True
		Me.mercosur.Checked = True
		Me.mercosur.CheckState = System.Windows.Forms.CheckState.Checked
		Me.mercosur.Location = New System.Drawing.Point(174, 72)
		Me.mercosur.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
		Me.mercosur.Name = "mercosur"
		Me.mercosur.Size = New System.Drawing.Size(87, 23)
		Me.mercosur.TabIndex = 253
		Me.mercosur.Text = "Mercosur"
		Me.mercosur.UseVisualStyleBackColor = True
		'
		'tabMultas3Vehiculo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "tabMultas3Vehiculo"
		Me.Size = New System.Drawing.Size(267, 105)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		CType(Me.bs_marca, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_tipo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label24 As Label
	Friend WithEvents ErrorInfo As ToolTip
	Friend WithEvents Label1 As Label
	Friend WithEvents patente As MaskedTextBox
	Friend WithEvents vehiculo_marca As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents vehiculo_tipo As ComboBox
	Friend WithEvents mercosur As CheckBox
	Friend WithEvents bs_marca As BindingSource
	Friend WithEvents bs_tipo As BindingSource
	Friend WithEvents vehiculo_id As TextBox
End Class
