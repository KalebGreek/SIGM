<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlBusquedaCombustiblePorTicket
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
		Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.minimo = New System.Windows.Forms.NumericUpDown()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.maximo = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel4.SuspendLayout()
		CType(Me.minimo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.maximo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel4
		'
		Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.Silver
		Me.FlowLayoutPanel4.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel4.Controls.Add(Me.MaskedTextBox1)
		Me.FlowLayoutPanel4.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel4.Controls.Add(Me.Label10)
		Me.FlowLayoutPanel4.Controls.Add(Me.RadioButton3)
		Me.FlowLayoutPanel4.Controls.Add(Me.RadioButton1)
		Me.FlowLayoutPanel4.Controls.Add(Me.RadioButton2)
		Me.FlowLayoutPanel4.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel4.Controls.Add(Me.Label13)
		Me.FlowLayoutPanel4.Controls.Add(Me.minimo)
		Me.FlowLayoutPanel4.Controls.Add(Me.Label11)
		Me.FlowLayoutPanel4.Controls.Add(Me.maximo)
		Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
		Me.FlowLayoutPanel4.Size = New System.Drawing.Size(389, 80)
		Me.FlowLayoutPanel4.TabIndex = 400
		'
		'Label8
		'
		Me.Label8.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label8.Location = New System.Drawing.Point(5, 0)
		Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(85, 24)
		Me.Label8.TabIndex = 392
		Me.Label8.Text = "Ticket Nro.:"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'MaskedTextBox1
		'
		Me.MaskedTextBox1.Location = New System.Drawing.Point(90, 0)
		Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(0, 0, 4, 0)
		Me.MaskedTextBox1.Mask = "000000-000000000000"
		Me.MaskedTextBox1.Name = "MaskedTextBox1"
		Me.MaskedTextBox1.Size = New System.Drawing.Size(167, 27)
		Me.MaskedTextBox1.TabIndex = 404
		Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label10
		'
		Me.Label10.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label10.Location = New System.Drawing.Point(5, 27)
		Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(85, 23)
		Me.Label10.TabIndex = 397
		Me.Label10.Text = "Monto:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Checked = True
		Me.RadioButton3.Location = New System.Drawing.Point(90, 27)
		Me.RadioButton3.Margin = New System.Windows.Forms.Padding(0)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(68, 23)
		Me.RadioButton3.TabIndex = 403
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "Rango"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(158, 27)
		Me.RadioButton1.Margin = New System.Windows.Forms.Padding(0)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(95, 23)
		Me.RadioButton1.TabIndex = 401
		Me.RadioButton1.Text = "Menor que"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(253, 27)
		Me.RadioButton2.Margin = New System.Windows.Forms.Padding(0)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(94, 23)
		Me.RadioButton2.TabIndex = 402
		Me.RadioButton2.Text = "Mayor que"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label1.Location = New System.Drawing.Point(5, 50)
		Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(85, 23)
		Me.Label1.TabIndex = 416
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label13
		'
		Me.Label13.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label13.Location = New System.Drawing.Point(95, 50)
		Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(48, 23)
		Me.Label13.TabIndex = 406
		Me.Label13.Text = "desde"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'minimo
		'
		Me.minimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.minimo.DecimalPlaces = 2
		Me.minimo.Location = New System.Drawing.Point(143, 50)
		Me.minimo.Margin = New System.Windows.Forms.Padding(0)
		Me.minimo.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
		Me.minimo.Name = "minimo"
		Me.minimo.Size = New System.Drawing.Size(94, 27)
		Me.minimo.TabIndex = 398
		Me.minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.minimo.ThousandsSeparator = True
		Me.minimo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.minimo.Value = New Decimal(New Integer() {999999, 0, 0, 0})
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label11.Location = New System.Drawing.Point(242, 50)
		Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(46, 23)
		Me.Label11.TabIndex = 400
		Me.Label11.Text = "hasta"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'maximo
		'
		Me.maximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.maximo.DecimalPlaces = 2
		Me.maximo.Location = New System.Drawing.Point(288, 50)
		Me.maximo.Margin = New System.Windows.Forms.Padding(0)
		Me.maximo.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
		Me.maximo.Name = "maximo"
		Me.maximo.Size = New System.Drawing.Size(94, 27)
		Me.maximo.TabIndex = 399
		Me.maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.maximo.ThousandsSeparator = True
		Me.maximo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.Label2.Location = New System.Drawing.Point(266, 0)
		Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(115, 23)
		Me.Label2.TabIndex = 417
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'CtrlBusquedaCombustiblePorTicket
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Silver
		Me.Controls.Add(Me.FlowLayoutPanel4)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "CtrlBusquedaCombustiblePorTicket"
		Me.Size = New System.Drawing.Size(500, 80)
		Me.FlowLayoutPanel4.ResumeLayout(False)
		Me.FlowLayoutPanel4.PerformLayout()
		CType(Me.minimo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.maximo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
	Friend WithEvents Label8 As Label
	Friend WithEvents MaskedTextBox1 As MaskedTextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents Label13 As Label
	Friend WithEvents minimo As NumericUpDown
	Friend WithEvents Label11 As Label
	Friend WithEvents maximo As NumericUpDown
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
