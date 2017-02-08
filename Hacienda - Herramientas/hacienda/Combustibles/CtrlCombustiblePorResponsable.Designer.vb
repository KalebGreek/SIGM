<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlCombustiblePorResponsable
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
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComboBox4 = New System.Windows.Forms.ComboBox()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cuil = New System.Windows.Forms.MaskedTextBox()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Silver
		Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel2.Controls.Add(Me.ComboBox4)
		Me.FlowLayoutPanel2.Controls.Add(Me.Button5)
		Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel2.Controls.Add(Me.cuil)
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(500, 63)
		Me.FlowLayoutPanel2.TabIndex = 400
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label2.Location = New System.Drawing.Point(4, 0)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(88, 33)
		Me.Label2.TabIndex = 392
		Me.Label2.Text = "Reponsable"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ComboBox4
		'
		Me.ComboBox4.FormattingEnabled = True
		Me.ComboBox4.Location = New System.Drawing.Point(92, 2)
		Me.ComboBox4.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
		Me.ComboBox4.Name = "ComboBox4"
		Me.ComboBox4.Size = New System.Drawing.Size(300, 27)
		Me.ComboBox4.TabIndex = 403
		'
		'Button5
		'
		Me.Button5.FlatAppearance.BorderSize = 0
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button5.ForeColor = System.Drawing.Color.White
		Me.Button5.Location = New System.Drawing.Point(396, 4)
		Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 2)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(27, 27)
		Me.Button5.TabIndex = 412
		Me.Button5.Text = ""
		Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button5.UseVisualStyleBackColor = False
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label4.Location = New System.Drawing.Point(4, 33)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(88, 25)
		Me.Label4.TabIndex = 395
		Me.Label4.Text = "CUIL / CUIT"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cuil
		'
		Me.cuil.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cuil.Location = New System.Drawing.Point(92, 33)
		Me.cuil.Margin = New System.Windows.Forms.Padding(0, 0, 4, 4)
		Me.cuil.Mask = "99-99999999-9"
		Me.cuil.Name = "cuil"
		Me.cuil.ReadOnly = True
		Me.cuil.Size = New System.Drawing.Size(117, 27)
		Me.cuil.TabIndex = 396
		Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'CtrlCombustiblePorResponsable
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.Controls.Add(Me.FlowLayoutPanel2)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "CtrlCombustiblePorResponsable"
		Me.Size = New System.Drawing.Size(500, 75)
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents ComboBox4 As ComboBox
	Friend WithEvents Button5 As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents cuil As MaskedTextBox
End Class
