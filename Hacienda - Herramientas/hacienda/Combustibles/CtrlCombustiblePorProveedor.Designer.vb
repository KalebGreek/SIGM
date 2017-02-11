<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlCombustiblePorProveedor
	Inherits System.Windows.Forms.UserControl

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
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.ComboBox5 = New System.Windows.Forms.ComboBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
		Me.FlowLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.Silver
		Me.FlowLayoutPanel3.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel3.Controls.Add(Me.ComboBox5)
		Me.FlowLayoutPanel3.Controls.Add(Me.Button2)
		Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel3.Controls.Add(Me.MaskedTextBox2)
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(423, 65)
		Me.FlowLayoutPanel3.TabIndex = 401
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label5.Location = New System.Drawing.Point(4, 0)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(88, 33)
		Me.Label5.TabIndex = 392
		Me.Label5.Text = "Proveedor"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ComboBox5
		'
		Me.ComboBox5.FormattingEnabled = True
		Me.ComboBox5.Location = New System.Drawing.Point(92, 2)
		Me.ComboBox5.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
		Me.ComboBox5.Name = "ComboBox5"
		Me.ComboBox5.Size = New System.Drawing.Size(300, 27)
		Me.ComboBox5.TabIndex = 403
		'
		'Button2
		'
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.White
		Me.Button2.Location = New System.Drawing.Point(392, 2)
		Me.Button2.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(27, 27)
		Me.Button2.TabIndex = 412
		Me.Button2.Text = ""
		Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label6.Location = New System.Drawing.Point(4, 33)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(88, 25)
		Me.Label6.TabIndex = 395
		Me.Label6.Text = "CUIL / CUIT"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'MaskedTextBox2
		'
		Me.MaskedTextBox2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MaskedTextBox2.Location = New System.Drawing.Point(92, 33)
		Me.MaskedTextBox2.Margin = New System.Windows.Forms.Padding(0, 0, 4, 4)
		Me.MaskedTextBox2.Mask = "99-99999999-9"
		Me.MaskedTextBox2.Name = "MaskedTextBox2"
		Me.MaskedTextBox2.ReadOnly = True
		Me.MaskedTextBox2.Size = New System.Drawing.Size(117, 27)
		Me.MaskedTextBox2.TabIndex = 396
		Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.MaskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'CtrlCombustiblePorProveedor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.Controls.Add(Me.FlowLayoutPanel3)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "CtrlCombustiblePorProveedor"
		Me.Size = New System.Drawing.Size(500, 75)
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents Label5 As Label
	Friend WithEvents ComboBox5 As ComboBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents MaskedTextBox2 As MaskedTextBox
End Class
