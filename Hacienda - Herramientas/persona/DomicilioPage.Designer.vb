<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DomicilioPage


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
		Me.calle = New System.Windows.Forms.TextBox()
		Me.altura = New System.Windows.Forms.NumericUpDown()
		Me.piso = New System.Windows.Forms.NumericUpDown()
		Me.dpto = New System.Windows.Forms.TextBox()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.provincia = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.localidad = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.cp = New System.Windows.Forms.TextBox()
		Me.domicilio_id = New System.Windows.Forms.TextBox()
		Me.bs_provincia = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_localidad = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.altura, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.piso, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.bs_provincia, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_localidad, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'calle
		'
		Me.calle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.calle.Location = New System.Drawing.Point(89, 3)
		Me.calle.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.calle.MaxLength = 256
		Me.calle.Name = "calle"
		Me.calle.Size = New System.Drawing.Size(208, 27)
		Me.calle.TabIndex = 0
		'
		'altura
		'
		Me.altura.Location = New System.Drawing.Point(89, 33)
		Me.altura.Margin = New System.Windows.Forms.Padding(0)
		Me.altura.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
		Me.altura.Name = "altura"
		Me.altura.Size = New System.Drawing.Size(82, 27)
		Me.altura.TabIndex = 1
		Me.altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'piso
		'
		Me.piso.Location = New System.Drawing.Point(89, 63)
		Me.piso.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
		Me.piso.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
		Me.piso.Name = "piso"
		Me.piso.Size = New System.Drawing.Size(82, 27)
		Me.piso.TabIndex = 2
		Me.piso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'dpto
		'
		Me.dpto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.dpto.Location = New System.Drawing.Point(221, 63)
		Me.dpto.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.dpto.MaxLength = 4
		Me.dpto.Name = "dpto"
		Me.dpto.Size = New System.Drawing.Size(75, 27)
		Me.dpto.TabIndex = 3
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.calle)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
		Me.FlowLayoutPanel1.Controls.Add(Me.altura)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.piso)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Controls.Add(Me.dpto)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.provincia)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel1.Controls.Add(Me.localidad)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel1.Controls.Add(Me.cp)
		Me.FlowLayoutPanel1.Controls.Add(Me.domicilio_id)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(300, 185)
		Me.FlowLayoutPanel1.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(3, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(83, 33)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Calle"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(3, 33)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(83, 27)
		Me.Label9.TabIndex = 15
		Me.Label9.Text = "Altura"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(174, 33)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(108, 21)
		Me.Label3.TabIndex = 6
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(3, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(83, 27)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "Piso"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(174, 60)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(44, 27)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Dpto."
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(3, 93)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(83, 25)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Provincia"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'provincia
		'
		Me.provincia.FormattingEnabled = True
		Me.provincia.Location = New System.Drawing.Point(89, 93)
		Me.provincia.Margin = New System.Windows.Forms.Padding(0)
		Me.provincia.Name = "provincia"
		Me.provincia.Size = New System.Drawing.Size(208, 27)
		Me.provincia.TabIndex = 8
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(3, 123)
		Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(83, 25)
		Me.Label6.TabIndex = 11
		Me.Label6.Text = "Localidad"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'localidad
		'
		Me.localidad.FormattingEnabled = True
		Me.localidad.Location = New System.Drawing.Point(89, 123)
		Me.localidad.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
		Me.localidad.Name = "localidad"
		Me.localidad.Size = New System.Drawing.Size(208, 27)
		Me.localidad.TabIndex = 9
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(3, 153)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(83, 25)
		Me.Label7.TabIndex = 17
		Me.Label7.Text = "Cod. Postal"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'cp
		'
		Me.cp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.cp.Location = New System.Drawing.Point(89, 153)
		Me.cp.Margin = New System.Windows.Forms.Padding(0)
		Me.cp.MaxLength = 4
		Me.cp.Name = "cp"
		Me.cp.Size = New System.Drawing.Size(83, 27)
		Me.cp.TabIndex = 14
		'
		'domicilio_id
		'
		Me.domicilio_id.BackColor = System.Drawing.Color.Teal
		Me.domicilio_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.domicilio_id.Location = New System.Drawing.Point(175, 156)
		Me.domicilio_id.MaxLength = 128
		Me.domicilio_id.Name = "domicilio_id"
		Me.domicilio_id.ReadOnly = True
		Me.domicilio_id.Size = New System.Drawing.Size(25, 27)
		Me.domicilio_id.TabIndex = 374
		Me.domicilio_id.Text = "0"
		Me.domicilio_id.Visible = False
		'
		'bs_provincia
		'
		'
		'bs_localidad
		'
		'
		'DomicilioPage
		'
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "DomicilioPage"
		Me.Size = New System.Drawing.Size(300, 185)
		CType(Me.altura, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.piso, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		CType(Me.bs_provincia, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_localidad, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents calle As TextBox
	Friend WithEvents piso As NumericUpDown
	Friend WithEvents dpto As TextBox
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents provincia As ComboBox
	Friend WithEvents cp As TextBox
	Friend WithEvents altura As NumericUpDown
	Friend WithEvents localidad As ComboBox
	Friend WithEvents bs_provincia As BindingSource
	Friend WithEvents bs_localidad As BindingSource
	Friend WithEvents Label9 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents domicilio_id As TextBox
End Class
