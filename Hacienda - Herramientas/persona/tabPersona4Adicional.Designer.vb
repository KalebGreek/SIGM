<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabPersona4Adicional
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
		Me.EsProfesional = New System.Windows.Forms.CheckBox()
		Me.titulo = New System.Windows.Forms.ComboBox()
		Me.add_titulo = New System.Windows.Forms.Button()
		Me.del_titulo = New System.Windows.Forms.Button()
		Me.et_matr = New System.Windows.Forms.Label()
		Me.matricula = New System.Windows.Forms.TextBox()
		Me.profesional_id = New System.Windows.Forms.TextBox()
		Me.proveedor_id = New System.Windows.Forms.TextBox()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.EsProveedor = New System.Windows.Forms.CheckBox()
		Me.responsable_iva = New System.Windows.Forms.ComboBox()
		Me.et_act = New System.Windows.Forms.Label()
		Me.actividad = New System.Windows.Forms.ComboBox()
		Me.add_actividad = New System.Windows.Forms.Button()
		Me.del_actividad = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.difunto = New System.Windows.Forms.CheckBox()
		Me.ruta_defuncion = New System.Windows.Forms.TextBox()
		Me.cargar_defu = New System.Windows.Forms.Button()
		Me.persona_id = New System.Windows.Forms.TextBox()
		Me.bs_proveedor = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_profesional = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_responsable_iva = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_titulo = New System.Windows.Forms.BindingSource(Me.components)
		Me.ErrorInfo = New System.Windows.Forms.ToolTip(Me.components)
		Me.bs_actividad = New System.Windows.Forms.BindingSource(Me.components)
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.FlowLayoutPanel3.SuspendLayout()
		CType(Me.bs_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_profesional, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_responsable_iva, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_titulo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_actividad, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.EsProfesional)
		Me.FlowLayoutPanel1.Controls.Add(Me.titulo)
		Me.FlowLayoutPanel1.Controls.Add(Me.add_titulo)
		Me.FlowLayoutPanel1.Controls.Add(Me.del_titulo)
		Me.FlowLayoutPanel1.Controls.Add(Me.et_matr)
		Me.FlowLayoutPanel1.Controls.Add(Me.matricula)
		Me.FlowLayoutPanel1.Controls.Add(Me.profesional_id)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 92)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(360, 62)
		Me.FlowLayoutPanel1.TabIndex = 379
		'
		'EsProfesional
		'
		Me.EsProfesional.BackColor = System.Drawing.Color.Transparent
		Me.EsProfesional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.EsProfesional.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EsProfesional.Location = New System.Drawing.Point(0, 0)
		Me.EsProfesional.Margin = New System.Windows.Forms.Padding(0)
		Me.EsProfesional.Name = "EsProfesional"
		Me.EsProfesional.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.EsProfesional.Size = New System.Drawing.Size(103, 28)
		Me.EsProfesional.TabIndex = 403
		Me.EsProfesional.Text = "Profesional"
		Me.EsProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.EsProfesional.UseVisualStyleBackColor = False
		'
		'titulo
		'
		Me.titulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.titulo.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.titulo.FormattingEnabled = True
		Me.titulo.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado, Ley Nº 19.640", "IVA Resp. Insc., Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
		Me.titulo.Location = New System.Drawing.Point(106, 0)
		Me.titulo.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.titulo.Name = "titulo"
		Me.titulo.Size = New System.Drawing.Size(192, 27)
		Me.titulo.TabIndex = 410
		Me.titulo.Visible = False
		'
		'add_titulo
		'
		Me.add_titulo.BackColor = System.Drawing.Color.Transparent
		Me.add_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.add_titulo.FlatAppearance.BorderSize = 0
		Me.add_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.add_titulo.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.add_titulo.Location = New System.Drawing.Point(301, 0)
		Me.add_titulo.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.add_titulo.Name = "add_titulo"
		Me.add_titulo.Size = New System.Drawing.Size(27, 27)
		Me.add_titulo.TabIndex = 414
		Me.add_titulo.Text = ""
		Me.add_titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.add_titulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.add_titulo.UseVisualStyleBackColor = False
		Me.add_titulo.Visible = False
		'
		'del_titulo
		'
		Me.del_titulo.BackColor = System.Drawing.Color.Transparent
		Me.del_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.del_titulo.FlatAppearance.BorderSize = 0
		Me.del_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.del_titulo.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.del_titulo.Location = New System.Drawing.Point(331, 0)
		Me.del_titulo.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.del_titulo.Name = "del_titulo"
		Me.del_titulo.Size = New System.Drawing.Size(27, 27)
		Me.del_titulo.TabIndex = 415
		Me.del_titulo.Text = ""
		Me.del_titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.del_titulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.del_titulo.UseVisualStyleBackColor = False
		Me.del_titulo.Visible = False
		'
		'et_matr
		'
		Me.et_matr.BackColor = System.Drawing.Color.Transparent
		Me.et_matr.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_matr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.et_matr.Location = New System.Drawing.Point(0, 28)
		Me.et_matr.Margin = New System.Windows.Forms.Padding(0)
		Me.et_matr.Name = "et_matr"
		Me.et_matr.Size = New System.Drawing.Size(106, 29)
		Me.et_matr.TabIndex = 402
		Me.et_matr.Text = "Matrícula"
		Me.et_matr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.et_matr.Visible = False
		'
		'matricula
		'
		Me.matricula.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.matricula.Location = New System.Drawing.Point(106, 30)
		Me.matricula.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.matricula.MaxLength = 64
		Me.matricula.Name = "matricula"
		Me.matricula.Size = New System.Drawing.Size(192, 27)
		Me.matricula.TabIndex = 401
		Me.matricula.Visible = False
		'
		'profesional_id
		'
		Me.profesional_id.BackColor = System.Drawing.Color.DodgerBlue
		Me.profesional_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.profesional_id.Location = New System.Drawing.Point(298, 28)
		Me.profesional_id.Margin = New System.Windows.Forms.Padding(0)
		Me.profesional_id.MaxLength = 128
		Me.profesional_id.Name = "profesional_id"
		Me.profesional_id.ReadOnly = True
		Me.profesional_id.Size = New System.Drawing.Size(28, 27)
		Me.profesional_id.TabIndex = 396
		Me.profesional_id.Text = "0"
		Me.profesional_id.Visible = False
		'
		'proveedor_id
		'
		Me.proveedor_id.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.proveedor_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.proveedor_id.Location = New System.Drawing.Point(298, 0)
		Me.proveedor_id.Margin = New System.Windows.Forms.Padding(0)
		Me.proveedor_id.MaxLength = 128
		Me.proveedor_id.Name = "proveedor_id"
		Me.proveedor_id.ReadOnly = True
		Me.proveedor_id.Size = New System.Drawing.Size(28, 27)
		Me.proveedor_id.TabIndex = 410
		Me.proveedor_id.Text = "0"
		Me.proveedor_id.Visible = False
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.Controls.Add(Me.EsProveedor)
		Me.FlowLayoutPanel2.Controls.Add(Me.responsable_iva)
		Me.FlowLayoutPanel2.Controls.Add(Me.proveedor_id)
		Me.FlowLayoutPanel2.Controls.Add(Me.et_act)
		Me.FlowLayoutPanel2.Controls.Add(Me.actividad)
		Me.FlowLayoutPanel2.Controls.Add(Me.add_actividad)
		Me.FlowLayoutPanel2.Controls.Add(Me.del_actividad)
		Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 31)
		Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(360, 61)
		Me.FlowLayoutPanel2.TabIndex = 380
		'
		'EsProveedor
		'
		Me.EsProveedor.BackColor = System.Drawing.Color.Transparent
		Me.EsProveedor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.EsProveedor.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EsProveedor.Location = New System.Drawing.Point(0, 0)
		Me.EsProveedor.Margin = New System.Windows.Forms.Padding(0)
		Me.EsProveedor.Name = "EsProveedor"
		Me.EsProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.EsProveedor.Size = New System.Drawing.Size(103, 28)
		Me.EsProveedor.TabIndex = 411
		Me.EsProveedor.Text = "Proveedor"
		Me.EsProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.EsProveedor.UseVisualStyleBackColor = False
		'
		'responsable_iva
		'
		Me.responsable_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.responsable_iva.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.responsable_iva.FormattingEnabled = True
		Me.responsable_iva.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado, Ley Nº 19.640", "IVA Resp. Insc., Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
		Me.responsable_iva.Location = New System.Drawing.Point(106, 0)
		Me.responsable_iva.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.responsable_iva.Name = "responsable_iva"
		Me.responsable_iva.Size = New System.Drawing.Size(192, 27)
		Me.responsable_iva.TabIndex = 412
		Me.responsable_iva.Visible = False
		'
		'et_act
		'
		Me.et_act.BackColor = System.Drawing.Color.Transparent
		Me.et_act.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.et_act.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.et_act.Location = New System.Drawing.Point(0, 28)
		Me.et_act.Margin = New System.Windows.Forms.Padding(0)
		Me.et_act.Name = "et_act"
		Me.et_act.Size = New System.Drawing.Size(106, 31)
		Me.et_act.TabIndex = 414
		Me.et_act.Text = "Actividad"
		Me.et_act.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.et_act.Visible = False
		'
		'actividad
		'
		Me.actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.actividad.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.actividad.FormattingEnabled = True
		Me.actividad.Items.AddRange(New Object() {"IVA Responsable Inscripto", "IVA Responsable no Inscripto", "IVA no Responsable", "IVA Sujeto Exento", "Consumidor Final", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado, Ley Nº 19.640", "IVA Resp. Insc., Agente de Percepción", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
		Me.actividad.Location = New System.Drawing.Point(106, 30)
		Me.actividad.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.actividad.Name = "actividad"
		Me.actividad.Size = New System.Drawing.Size(192, 27)
		Me.actividad.TabIndex = 413
		Me.actividad.Visible = False
		'
		'add_actividad
		'
		Me.add_actividad.BackColor = System.Drawing.Color.Transparent
		Me.add_actividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.add_actividad.FlatAppearance.BorderSize = 0
		Me.add_actividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.add_actividad.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.add_actividad.Location = New System.Drawing.Point(301, 28)
		Me.add_actividad.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.add_actividad.Name = "add_actividad"
		Me.add_actividad.Size = New System.Drawing.Size(27, 27)
		Me.add_actividad.TabIndex = 416
		Me.add_actividad.Text = ""
		Me.add_actividad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.add_actividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.add_actividad.UseVisualStyleBackColor = False
		Me.add_actividad.Visible = False
		'
		'del_actividad
		'
		Me.del_actividad.BackColor = System.Drawing.Color.Transparent
		Me.del_actividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.del_actividad.FlatAppearance.BorderSize = 0
		Me.del_actividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.del_actividad.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.del_actividad.Location = New System.Drawing.Point(331, 28)
		Me.del_actividad.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.del_actividad.Name = "del_actividad"
		Me.del_actividad.Size = New System.Drawing.Size(27, 27)
		Me.del_actividad.TabIndex = 417
		Me.del_actividad.Text = ""
		Me.del_actividad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.del_actividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.del_actividad.UseVisualStyleBackColor = False
		Me.del_actividad.Visible = False
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.Controls.Add(Me.difunto)
		Me.FlowLayoutPanel3.Controls.Add(Me.ruta_defuncion)
		Me.FlowLayoutPanel3.Controls.Add(Me.cargar_defu)
		Me.FlowLayoutPanel3.Controls.Add(Me.persona_id)
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(360, 31)
		Me.FlowLayoutPanel3.TabIndex = 381
		'
		'difunto
		'
		Me.difunto.BackColor = System.Drawing.Color.Transparent
		Me.difunto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.difunto.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.difunto.Location = New System.Drawing.Point(0, 0)
		Me.difunto.Margin = New System.Windows.Forms.Padding(0)
		Me.difunto.Name = "difunto"
		Me.difunto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.difunto.Size = New System.Drawing.Size(103, 28)
		Me.difunto.TabIndex = 409
		Me.difunto.Text = " Difunto"
		Me.difunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.difunto.UseVisualStyleBackColor = False
		'
		'ruta_defuncion
		'
		Me.ruta_defuncion.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
		Me.ruta_defuncion.Cursor = System.Windows.Forms.Cursors.Hand
		Me.ruta_defuncion.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.ruta_defuncion.Location = New System.Drawing.Point(106, 1)
		Me.ruta_defuncion.Margin = New System.Windows.Forms.Padding(3, 1, 0, 0)
		Me.ruta_defuncion.MaxLength = 512
		Me.ruta_defuncion.Name = "ruta_defuncion"
		Me.ruta_defuncion.ReadOnly = True
		Me.ruta_defuncion.Size = New System.Drawing.Size(192, 27)
		Me.ruta_defuncion.TabIndex = 410
		Me.ruta_defuncion.Visible = False
		'
		'cargar_defu
		'
		Me.cargar_defu.BackColor = System.Drawing.Color.Transparent
		Me.cargar_defu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.cargar_defu.FlatAppearance.BorderSize = 0
		Me.cargar_defu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cargar_defu.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cargar_defu.Location = New System.Drawing.Point(301, 0)
		Me.cargar_defu.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.cargar_defu.Name = "cargar_defu"
		Me.cargar_defu.Size = New System.Drawing.Size(27, 27)
		Me.cargar_defu.TabIndex = 411
		Me.cargar_defu.Text = ""
		Me.cargar_defu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cargar_defu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.cargar_defu.UseVisualStyleBackColor = False
		Me.cargar_defu.Visible = False
		'
		'persona_id
		'
		Me.persona_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.persona_id.Location = New System.Drawing.Point(328, 0)
		Me.persona_id.Margin = New System.Windows.Forms.Padding(0)
		Me.persona_id.MaxLength = 128
		Me.persona_id.Name = "persona_id"
		Me.persona_id.ReadOnly = True
		Me.persona_id.Size = New System.Drawing.Size(25, 27)
		Me.persona_id.TabIndex = 412
		Me.persona_id.Text = "0"
		Me.persona_id.Visible = False
		'
		'tabPersona4Adicional
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.FlowLayoutPanel2)
		Me.Controls.Add(Me.FlowLayoutPanel3)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "tabPersona4Adicional"
		Me.Size = New System.Drawing.Size(360, 160)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		CType(Me.bs_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_profesional, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_responsable_iva, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_titulo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_actividad, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents profesional_id As TextBox
	Friend WithEvents EsProfesional As CheckBox
	Friend WithEvents titulo As ComboBox
	Friend WithEvents matricula As TextBox
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents EsProveedor As CheckBox
	Friend WithEvents responsable_iva As ComboBox
	Friend WithEvents proveedor_id As TextBox
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents difunto As CheckBox
	Friend WithEvents ruta_defuncion As TextBox
	Friend WithEvents cargar_defu As Button
	Friend WithEvents et_matr As Label
	Public WithEvents bs_proveedor As BindingSource
	Public WithEvents bs_profesional As BindingSource
	Friend WithEvents bs_responsable_iva As BindingSource
	Friend WithEvents bs_titulo As BindingSource
	Friend WithEvents add_titulo As Button
	Friend WithEvents del_titulo As Button
	Friend WithEvents persona_id As TextBox
	Friend WithEvents ErrorInfo As ToolTip
	Friend WithEvents et_act As Label
	Friend WithEvents actividad As ComboBox
	Friend WithEvents bs_actividad As BindingSource
	Friend WithEvents add_actividad As Button
	Friend WithEvents del_actividad As Button
End Class
