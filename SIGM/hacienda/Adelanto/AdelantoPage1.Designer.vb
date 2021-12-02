<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdelantoPage1
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
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.et_act = New System.Windows.Forms.Label()
		Me.razon = New System.Windows.Forms.TextBox()
		Me.buscarPersona = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cuil = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.fecha = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.monto = New System.Windows.Forms.NumericUpDown()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.monto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.et_act)
		Me.FlowLayoutPanel1.Controls.Add(Me.razon)
		Me.FlowLayoutPanel1.Controls.Add(Me.buscarPersona)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.cuil)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.fecha)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Controls.Add(Me.monto)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(318, 300)
		Me.FlowLayoutPanel1.TabIndex = 0
		'
		'et_act
		'
		Me.et_act.BackColor = System.Drawing.Color.Transparent
		Me.et_act.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_act.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.et_act.Location = New System.Drawing.Point(3, 3)
		Me.et_act.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
		Me.et_act.Name = "et_act"
		Me.et_act.Size = New System.Drawing.Size(370, 20)
		Me.et_act.TabIndex = 417
		Me.et_act.Text = "Apellido y Nombre"
		Me.et_act.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'razon
		'
		Me.razon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.razon.Location = New System.Drawing.Point(3, 26)
		Me.razon.Name = "razon"
		Me.razon.Size = New System.Drawing.Size(275, 27)
		Me.razon.TabIndex = 10
		'
		'buscarPersona
		'
		Me.buscarPersona.BackColor = System.Drawing.Color.Transparent
		Me.buscarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.buscarPersona.FlatAppearance.BorderSize = 0
		Me.buscarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buscarPersona.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.buscarPersona.Location = New System.Drawing.Point(284, 26)
		Me.buscarPersona.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
		Me.buscarPersona.Name = "buscarPersona"
		Me.buscarPersona.Size = New System.Drawing.Size(27, 27)
		Me.buscarPersona.TabIndex = 15
		Me.buscarPersona.Text = ""
		Me.buscarPersona.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.buscarPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.buscarPersona.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(6, 62)
		Me.Label1.Margin = New System.Windows.Forms.Padding(6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 20)
		Me.Label1.TabIndex = 419
		Me.Label1.Text = "CUIL/DNI"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cuil
		'
		Me.cuil.Location = New System.Drawing.Point(88, 59)
		Me.cuil.Name = "cuil"
		Me.cuil.Size = New System.Drawing.Size(123, 27)
		Me.cuil.TabIndex = 20
		Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(217, 59)
		Me.Label3.Margin = New System.Windows.Forms.Padding(3)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(76, 20)
		Me.Label3.TabIndex = 423
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(6, 95)
		Me.Label2.Margin = New System.Windows.Forms.Padding(6)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(73, 20)
		Me.Label2.TabIndex = 422
		Me.Label2.Text = "Fecha"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'fecha
		'
		Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.fecha.Location = New System.Drawing.Point(88, 92)
		Me.fecha.MaxDate = New Date(2018, 11, 19, 0, 0, 0, 0)
		Me.fecha.Name = "fecha"
		Me.fecha.Size = New System.Drawing.Size(123, 27)
		Me.fecha.TabIndex = 30
		Me.fecha.Value = New Date(2018, 11, 19, 0, 0, 0, 0)
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label5.Location = New System.Drawing.Point(217, 92)
		Me.Label5.Margin = New System.Windows.Forms.Padding(3)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(76, 20)
		Me.Label5.TabIndex = 428
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(6, 128)
		Me.Label4.Margin = New System.Windows.Forms.Padding(6)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 20)
		Me.Label4.TabIndex = 425
		Me.Label4.Text = "Monto ($)"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'monto
		'
		Me.monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.monto.DecimalPlaces = 2
		Me.monto.Location = New System.Drawing.Point(88, 125)
		Me.monto.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
		Me.monto.Name = "monto"
		Me.monto.Size = New System.Drawing.Size(123, 27)
		Me.monto.TabIndex = 40
		Me.monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.monto.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'adelanto_page1
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "adelanto_page1"
		Me.Size = New System.Drawing.Size(318, 300)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		CType(Me.monto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents et_act As Label
	Friend WithEvents razon As TextBox
	Friend WithEvents buscarPersona As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents cuil As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents fecha As DateTimePicker
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents monto As NumericUpDown
End Class
