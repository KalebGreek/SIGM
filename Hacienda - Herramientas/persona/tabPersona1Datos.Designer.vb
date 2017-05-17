<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabPersona1Datos
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
		Me.razon = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dni = New System.Windows.Forms.MaskedTextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.gen = New System.Windows.Forms.ComboBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.cuil = New System.Windows.Forms.MaskedTextBox()
		Me.ErrorInfo = New System.Windows.Forms.ToolTip(Me.components)
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label24)
		Me.FlowLayoutPanel1.Controls.Add(Me.razon)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.dni)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.gen)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label14)
		Me.FlowLayoutPanel1.Controls.Add(Me.cuil)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(360, 96)
		Me.FlowLayoutPanel1.TabIndex = 379
		'
		'Label24
		'
		Me.Label24.Location = New System.Drawing.Point(0, 3)
		Me.Label24.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(58, 30)
		Me.Label24.TabIndex = 230
		Me.Label24.Text = "Razón"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'razon
		'
		Me.razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.razon.Location = New System.Drawing.Point(58, 3)
		Me.razon.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.razon.MaxLength = 100
		Me.razon.Name = "razon"
		Me.razon.Size = New System.Drawing.Size(295, 27)
		Me.razon.TabIndex = 233
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(0, 33)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(58, 27)
		Me.Label2.TabIndex = 240
		Me.Label2.Text = "DNI"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'dni
		'
		Me.dni.Location = New System.Drawing.Point(58, 33)
		Me.dni.Margin = New System.Windows.Forms.Padding(0)
		Me.dni.Mask = "99999999"
		Me.dni.Name = "dni"
		Me.dni.Size = New System.Drawing.Size(126, 27)
		Me.dni.TabIndex = 238
		Me.dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.dni.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(184, 33)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(43, 27)
		Me.Label3.TabIndex = 242
		Me.Label3.Text = "Sexo"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'gen
		'
		Me.gen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.gen.FormattingEnabled = True
		Me.gen.Items.AddRange(New Object() {"Masculino", "Femenino", "N/A"})
		Me.gen.Location = New System.Drawing.Point(227, 33)
		Me.gen.Margin = New System.Windows.Forms.Padding(0)
		Me.gen.Name = "gen"
		Me.gen.Size = New System.Drawing.Size(126, 27)
		Me.gen.TabIndex = 235
		'
		'Label14
		'
		Me.Label14.Location = New System.Drawing.Point(0, 60)
		Me.Label14.Margin = New System.Windows.Forms.Padding(0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(58, 32)
		Me.Label14.TabIndex = 231
		Me.Label14.Text = "CUIL"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cuil
		'
		Me.cuil.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		Me.cuil.Location = New System.Drawing.Point(58, 63)
		Me.cuil.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.cuil.Mask = "99-99999999-9"
		Me.cuil.Name = "cuil"
		Me.cuil.Size = New System.Drawing.Size(126, 27)
		Me.cuil.TabIndex = 232
		Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'tabPersona1Datos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "tabPersona1Datos"
		Me.Size = New System.Drawing.Size(360, 96)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label24 As Label
	Friend WithEvents razon As TextBox
	Friend WithEvents gen As ComboBox
	Friend WithEvents Label14 As Label
	Friend WithEvents cuil As MaskedTextBox
	Friend WithEvents dni As MaskedTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents ErrorInfo As ToolTip
End Class
