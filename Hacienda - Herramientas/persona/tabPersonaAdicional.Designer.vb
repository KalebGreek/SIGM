<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabPersonaAdicional
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
		Me.proveedor_id = New System.Windows.Forms.TextBox()
		Me.prof_id = New System.Windows.Forms.TextBox()
		Me.titulo = New System.Windows.Forms.ComboBox()
		Me.et_resp = New System.Windows.Forms.Label()
		Me.et_defu = New System.Windows.Forms.Label()
		Me.responsable = New System.Windows.Forms.ComboBox()
		Me.esProveedor = New System.Windows.Forms.CheckBox()
		Me.esProfesional = New System.Windows.Forms.CheckBox()
		Me.et_matr = New System.Windows.Forms.Label()
		Me.cargar_defu = New System.Windows.Forms.Button()
		Me.matr = New System.Windows.Forms.TextBox()
		Me.ruta_defuncion = New System.Windows.Forms.TextBox()
		Me.esDifunto = New System.Windows.Forms.CheckBox()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.esProfesional)
		Me.FlowLayoutPanel1.Controls.Add(Me.titulo)
		Me.FlowLayoutPanel1.Controls.Add(Me.et_matr)
		Me.FlowLayoutPanel1.Controls.Add(Me.matr)
		Me.FlowLayoutPanel1.Controls.Add(Me.prof_id)
		Me.FlowLayoutPanel1.Controls.Add(Me.esProveedor)
		Me.FlowLayoutPanel1.Controls.Add(Me.et_resp)
		Me.FlowLayoutPanel1.Controls.Add(Me.responsable)
		Me.FlowLayoutPanel1.Controls.Add(Me.proveedor_id)
		Me.FlowLayoutPanel1.Controls.Add(Me.esDifunto)
		Me.FlowLayoutPanel1.Controls.Add(Me.et_defu)
		Me.FlowLayoutPanel1.Controls.Add(Me.ruta_defuncion)
		Me.FlowLayoutPanel1.Controls.Add(Me.cargar_defu)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(507, 145)
		Me.FlowLayoutPanel1.TabIndex = 379
		'
		'proveedor_id
		'
		Me.proveedor_id.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.proveedor_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.proveedor_id.Location = New System.Drawing.Point(430, 43)
		Me.proveedor_id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.proveedor_id.MaxLength = 128
		Me.proveedor_id.Name = "proveedor_id"
		Me.proveedor_id.ReadOnly = True
		Me.proveedor_id.Size = New System.Drawing.Size(28, 27)
		Me.proveedor_id.TabIndex = 397
		Me.proveedor_id.Text = "0"
		'
		'prof_id
		'
		Me.prof_id.BackColor = System.Drawing.Color.DodgerBlue
		Me.prof_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.prof_id.Location = New System.Drawing.Point(457, 8)
		Me.prof_id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.prof_id.MaxLength = 128
		Me.prof_id.Name = "prof_id"
		Me.prof_id.ReadOnly = True
		Me.prof_id.Size = New System.Drawing.Size(28, 27)
		Me.prof_id.TabIndex = 396
		Me.prof_id.Text = "0"
		'
		'titulo
		'
		Me.titulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.titulo.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.titulo.FormattingEnabled = True
		Me.titulo.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado, Ley Nº 19.640", "IVA Resp. Insc., Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
		Me.titulo.Location = New System.Drawing.Point(111, 4)
		Me.titulo.Margin = New System.Windows.Forms.Padding(0)
		Me.titulo.Name = "titulo"
		Me.titulo.Size = New System.Drawing.Size(163, 27)
		Me.titulo.TabIndex = 410
		Me.titulo.Visible = False
		'
		'et_resp
		'
		Me.et_resp.AutoSize = True
		Me.et_resp.BackColor = System.Drawing.Color.Transparent
		Me.et_resp.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_resp.Location = New System.Drawing.Point(115, 39)
		Me.et_resp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.et_resp.Name = "et_resp"
		Me.et_resp.Size = New System.Drawing.Size(72, 19)
		Me.et_resp.TabIndex = 409
		Me.et_resp.Text = "Resp. IVA"
		Me.et_resp.Visible = False
		'
		'et_defu
		'
		Me.et_defu.AutoSize = True
		Me.et_defu.BackColor = System.Drawing.Color.Transparent
		Me.et_defu.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_defu.Location = New System.Drawing.Point(111, 74)
		Me.et_defu.Margin = New System.Windows.Forms.Padding(0)
		Me.et_defu.Name = "et_defu"
		Me.et_defu.Size = New System.Drawing.Size(110, 19)
		Me.et_defu.TabIndex = 408
		Me.et_defu.Text = "Certificado Def."
		Me.et_defu.Visible = False
		'
		'responsable
		'
		Me.responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.responsable.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.responsable.FormattingEnabled = True
		Me.responsable.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado, Ley Nº 19.640", "IVA Resp. Insc., Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
		Me.responsable.Location = New System.Drawing.Point(194, 42)
		Me.responsable.Name = "responsable"
		Me.responsable.Size = New System.Drawing.Size(230, 27)
		Me.responsable.TabIndex = 407
		Me.responsable.Visible = False
		'
		'esProveedor
		'
		Me.esProveedor.BackColor = System.Drawing.Color.Transparent
		Me.esProveedor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.esProveedor.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.esProveedor.Location = New System.Drawing.Point(3, 39)
		Me.esProveedor.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
		Me.esProveedor.Name = "esProveedor"
		Me.esProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.esProveedor.Size = New System.Drawing.Size(102, 23)
		Me.esProveedor.TabIndex = 406
		Me.esProveedor.Text = "Proveedor"
		Me.esProveedor.UseVisualStyleBackColor = False
		'
		'esProfesional
		'
		Me.esProfesional.BackColor = System.Drawing.Color.Transparent
		Me.esProfesional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.esProfesional.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.esProfesional.Location = New System.Drawing.Point(3, 4)
		Me.esProfesional.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
		Me.esProfesional.Name = "esProfesional"
		Me.esProfesional.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.esProfesional.Size = New System.Drawing.Size(102, 23)
		Me.esProfesional.TabIndex = 403
		Me.esProfesional.Text = "Profesional"
		Me.esProfesional.UseVisualStyleBackColor = False
		'
		'et_matr
		'
		Me.et_matr.AutoSize = True
		Me.et_matr.BackColor = System.Drawing.Color.Transparent
		Me.et_matr.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_matr.Location = New System.Drawing.Point(278, 4)
		Me.et_matr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.et_matr.Name = "et_matr"
		Me.et_matr.Size = New System.Drawing.Size(70, 19)
		Me.et_matr.TabIndex = 402
		Me.et_matr.Text = "Matrícula"
		Me.et_matr.Visible = False
		'
		'cargar_defu
		'
		Me.cargar_defu.BackColor = System.Drawing.Color.Transparent
		Me.cargar_defu.BackgroundImage = Global.Sigm.My.Resources.Resources.abrir
		Me.cargar_defu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.cargar_defu.FlatAppearance.BorderSize = 0
		Me.cargar_defu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cargar_defu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cargar_defu.ForeColor = System.Drawing.Color.White
		Me.cargar_defu.Location = New System.Drawing.Point(431, 74)
		Me.cargar_defu.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.cargar_defu.Name = "cargar_defu"
		Me.cargar_defu.Size = New System.Drawing.Size(29, 29)
		Me.cargar_defu.TabIndex = 405
		Me.cargar_defu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cargar_defu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.cargar_defu.UseVisualStyleBackColor = False
		Me.cargar_defu.Visible = False
		'
		'matr
		'
		Me.matr.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.matr.Location = New System.Drawing.Point(352, 4)
		Me.matr.Margin = New System.Windows.Forms.Padding(0)
		Me.matr.MaxLength = 64
		Me.matr.Name = "matr"
		Me.matr.Size = New System.Drawing.Size(102, 27)
		Me.matr.TabIndex = 401
		Me.matr.Visible = False
		'
		'ruta_defuncion
		'
		Me.ruta_defuncion.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
		Me.ruta_defuncion.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ruta_defuncion.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.ruta_defuncion.Location = New System.Drawing.Point(221, 74)
		Me.ruta_defuncion.Margin = New System.Windows.Forms.Padding(0)
		Me.ruta_defuncion.MaxLength = 512
		Me.ruta_defuncion.Name = "ruta_defuncion"
		Me.ruta_defuncion.ReadOnly = True
		Me.ruta_defuncion.Size = New System.Drawing.Size(207, 27)
		Me.ruta_defuncion.TabIndex = 404
		Me.ruta_defuncion.Visible = False
		'
		'esDifunto
		'
		Me.esDifunto.BackColor = System.Drawing.Color.Transparent
		Me.esDifunto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.esDifunto.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.esDifunto.Location = New System.Drawing.Point(3, 74)
		Me.esDifunto.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
		Me.esDifunto.Name = "esDifunto"
		Me.esDifunto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.esDifunto.Size = New System.Drawing.Size(102, 23)
		Me.esDifunto.TabIndex = 400
		Me.esDifunto.Text = " Difunto"
		Me.esDifunto.UseVisualStyleBackColor = False
		'
		'tabAdicional
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "tabAdicional"
		Me.Size = New System.Drawing.Size(510, 385)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents proveedor_id As TextBox
	Friend WithEvents prof_id As TextBox
	Friend WithEvents esProfesional As CheckBox
	Friend WithEvents titulo As ComboBox
	Friend WithEvents et_matr As Label
	Friend WithEvents matr As TextBox
	Friend WithEvents esProveedor As CheckBox
	Friend WithEvents et_resp As Label
	Friend WithEvents responsable As ComboBox
	Friend WithEvents esDifunto As CheckBox
	Friend WithEvents et_defu As Label
	Friend WithEvents ruta_defuncion As TextBox
	Friend WithEvents cargar_defu As Button
End Class
