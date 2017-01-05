<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabDatosPersonales
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
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.razon = New System.Windows.Forms.TextBox()
		Me.persona_id = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dni = New System.Windows.Forms.MaskedTextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.gen = New System.Windows.Forms.ComboBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.cuil = New System.Windows.Forms.MaskedTextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.dni_a_cuil = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label24)
		Me.FlowLayoutPanel1.Controls.Add(Me.razon)
		Me.FlowLayoutPanel1.Controls.Add(Me.persona_id)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.dni)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label17)
		Me.FlowLayoutPanel1.Controls.Add(Me.gen)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label14)
		Me.FlowLayoutPanel1.Controls.Add(Me.cuil)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.dni_a_cuil)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(425, 100)
		Me.FlowLayoutPanel1.TabIndex = 379
		'
		'Label24
		'
		Me.Label24.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label24.Location = New System.Drawing.Point(3, 3)
		Me.Label24.Margin = New System.Windows.Forms.Padding(0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(82, 29)
		Me.Label24.TabIndex = 230
		Me.Label24.Text = "Razón Social"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'razon
		'
		Me.razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.razon.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.razon.Location = New System.Drawing.Point(85, 6)
		Me.razon.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.razon.MaxLength = 100
		Me.razon.Name = "razon"
		Me.razon.Size = New System.Drawing.Size(302, 23)
		Me.razon.TabIndex = 233
		'
		'persona_id
		'
		Me.persona_id.BackColor = System.Drawing.Color.Gainsboro
		Me.persona_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.persona_id.Location = New System.Drawing.Point(390, 6)
		Me.persona_id.MaxLength = 100
		Me.persona_id.Name = "persona_id"
		Me.persona_id.Size = New System.Drawing.Size(29, 23)
		Me.persona_id.TabIndex = 242
		Me.persona_id.Visible = False
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(3, 32)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(82, 23)
		Me.Label2.TabIndex = 240
		Me.Label2.Text = "DNI"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'dni
		'
		Me.dni.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dni.Location = New System.Drawing.Point(85, 32)
		Me.dni.Margin = New System.Windows.Forms.Padding(0)
		Me.dni.Mask = "99999999"
		Me.dni.Name = "dni"
		Me.dni.Size = New System.Drawing.Size(126, 23)
		Me.dni.TabIndex = 238
		Me.dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.dni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'Label17
		'
		Me.Label17.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(211, 32)
		Me.Label17.Margin = New System.Windows.Forms.Padding(0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(50, 23)
		Me.Label17.TabIndex = 237
		Me.Label17.Text = "Sexo"
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'gen
		'
		Me.gen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.gen.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gen.FormattingEnabled = True
		Me.gen.Items.AddRange(New Object() {"Masculino", "Femenino", "Otro / No Aplica"})
		Me.gen.Location = New System.Drawing.Point(261, 32)
		Me.gen.Margin = New System.Windows.Forms.Padding(0)
		Me.gen.Name = "gen"
		Me.gen.Size = New System.Drawing.Size(126, 23)
		Me.gen.TabIndex = 235
		'
		'Label14
		'
		Me.Label14.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Location = New System.Drawing.Point(3, 55)
		Me.Label14.Margin = New System.Windows.Forms.Padding(0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(82, 33)
		Me.Label14.TabIndex = 231
		Me.Label14.Text = "CUIL"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cuil
		'
		Me.cuil.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		Me.cuil.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cuil.Location = New System.Drawing.Point(85, 58)
		Me.cuil.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.cuil.Mask = "99-99999999-9"
		Me.cuil.Name = "cuil"
		Me.cuil.ReadOnly = True
		Me.cuil.Size = New System.Drawing.Size(126, 23)
		Me.cuil.TabIndex = 232
		Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(211, 55)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(50, 33)
		Me.Label1.TabIndex = 241
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'dni_a_cuil
		'
		Me.dni_a_cuil.BackColor = System.Drawing.Color.Gray
		Me.dni_a_cuil.FlatAppearance.BorderSize = 0
		Me.dni_a_cuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.dni_a_cuil.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dni_a_cuil.ForeColor = System.Drawing.Color.White
		Me.dni_a_cuil.Location = New System.Drawing.Point(261, 58)
		Me.dni_a_cuil.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.dni_a_cuil.Name = "dni_a_cuil"
		Me.dni_a_cuil.Size = New System.Drawing.Size(126, 23)
		Me.dni_a_cuil.TabIndex = 234
		Me.dni_a_cuil.Text = "Calcular CUIL"
		Me.dni_a_cuil.UseVisualStyleBackColor = False
		'
		'tabDatosPersonales
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "tabDatosPersonales"
		Me.Size = New System.Drawing.Size(425, 100)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label24 As Label
	Friend WithEvents razon As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents gen As ComboBox
	Friend WithEvents dni_a_cuil As Button
	Friend WithEvents Label14 As Label
	Friend WithEvents cuil As MaskedTextBox
	Friend WithEvents dni As MaskedTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents persona_id As TextBox
End Class
