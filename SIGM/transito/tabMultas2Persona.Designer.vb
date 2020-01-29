<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabMultas2Persona
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
		Me.propietario_razon = New System.Windows.Forms.TextBox()
		Me.cargar_prop = New System.Windows.Forms.Button()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.propietario_cuil = New System.Windows.Forms.MaskedTextBox()
		Me.propietario_id = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.conductor_razon = New System.Windows.Forms.TextBox()
		Me.cargar_cond = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.conductor_cuil = New System.Windows.Forms.MaskedTextBox()
		Me.conductor_id = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.ErrorInfo = New System.Windows.Forms.ToolTip(Me.components)
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label24)
		Me.FlowLayoutPanel1.Controls.Add(Me.propietario_razon)
		Me.FlowLayoutPanel1.Controls.Add(Me.cargar_prop)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label14)
		Me.FlowLayoutPanel1.Controls.Add(Me.propietario_cuil)
		Me.FlowLayoutPanel1.Controls.Add(Me.propietario_id)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.conductor_razon)
		Me.FlowLayoutPanel1.Controls.Add(Me.cargar_cond)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.conductor_cuil)
		Me.FlowLayoutPanel1.Controls.Add(Me.conductor_id)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(356, 147)
		Me.FlowLayoutPanel1.TabIndex = 379
		'
		'Label24
		'
		Me.Label24.Location = New System.Drawing.Point(0, 3)
		Me.Label24.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(93, 27)
		Me.Label24.TabIndex = 230
		Me.Label24.Text = "Propietario"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'propietario_razon
		'
		Me.propietario_razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.propietario_razon.Location = New System.Drawing.Point(93, 4)
		Me.propietario_razon.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.propietario_razon.MaxLength = 100
		Me.propietario_razon.Name = "propietario_razon"
		Me.propietario_razon.Size = New System.Drawing.Size(228, 27)
		Me.propietario_razon.TabIndex = 233
		'
		'cargar_prop
		'
		Me.cargar_prop.BackColor = System.Drawing.Color.Transparent
		Me.cargar_prop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.cargar_prop.FlatAppearance.BorderSize = 0
		Me.cargar_prop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cargar_prop.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cargar_prop.Location = New System.Drawing.Point(324, 4)
		Me.cargar_prop.Margin = New System.Windows.Forms.Padding(3, 4, 0, 0)
		Me.cargar_prop.Name = "cargar_prop"
		Me.cargar_prop.Size = New System.Drawing.Size(27, 27)
		Me.cargar_prop.TabIndex = 412
		Me.cargar_prop.Text = ""
		Me.cargar_prop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cargar_prop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.cargar_prop.UseVisualStyleBackColor = False
		'
		'Label14
		'
		Me.Label14.Location = New System.Drawing.Point(0, 34)
		Me.Label14.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(93, 27)
		Me.Label14.TabIndex = 231
		Me.Label14.Text = "CUIL/DNI"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'propietario_cuil
		'
		Me.propietario_cuil.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		Me.propietario_cuil.Location = New System.Drawing.Point(93, 35)
		Me.propietario_cuil.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.propietario_cuil.Mask = "99-99999999-9"
		Me.propietario_cuil.Name = "propietario_cuil"
		Me.propietario_cuil.Size = New System.Drawing.Size(143, 27)
		Me.propietario_cuil.TabIndex = 232
		Me.propietario_cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.propietario_cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'propietario_id
		'
		Me.propietario_id.BackColor = System.Drawing.Color.OrangeRed
		Me.propietario_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.propietario_id.Location = New System.Drawing.Point(236, 35)
		Me.propietario_id.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.propietario_id.MaxLength = 100
		Me.propietario_id.Name = "propietario_id"
		Me.propietario_id.Size = New System.Drawing.Size(25, 27)
		Me.propietario_id.TabIndex = 421
		Me.propietario_id.Text = "0"
		Me.propietario_id.Visible = False
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(261, 31)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 27)
		Me.Label1.TabIndex = 413
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(0, 62)
		Me.Label5.Margin = New System.Windows.Forms.Padding(0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(365, 14)
		Me.Label5.TabIndex = 422
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(0, 79)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(93, 27)
		Me.Label2.TabIndex = 414
		Me.Label2.Text = "Conductor"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'conductor_razon
		'
		Me.conductor_razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.conductor_razon.Location = New System.Drawing.Point(93, 80)
		Me.conductor_razon.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.conductor_razon.MaxLength = 100
		Me.conductor_razon.Name = "conductor_razon"
		Me.conductor_razon.Size = New System.Drawing.Size(228, 27)
		Me.conductor_razon.TabIndex = 417
		'
		'cargar_cond
		'
		Me.cargar_cond.BackColor = System.Drawing.Color.Transparent
		Me.cargar_cond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.cargar_cond.FlatAppearance.BorderSize = 0
		Me.cargar_cond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cargar_cond.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cargar_cond.Location = New System.Drawing.Point(324, 80)
		Me.cargar_cond.Margin = New System.Windows.Forms.Padding(3, 4, 0, 0)
		Me.cargar_cond.Name = "cargar_cond"
		Me.cargar_cond.Size = New System.Drawing.Size(27, 27)
		Me.cargar_cond.TabIndex = 418
		Me.cargar_cond.Text = ""
		Me.cargar_cond.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cargar_cond.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.cargar_cond.UseVisualStyleBackColor = False
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(0, 110)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(93, 27)
		Me.Label3.TabIndex = 415
		Me.Label3.Text = "CUIL/DNI"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'conductor_cuil
		'
		Me.conductor_cuil.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		Me.conductor_cuil.Location = New System.Drawing.Point(93, 111)
		Me.conductor_cuil.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.conductor_cuil.Mask = "99-99999999-9"
		Me.conductor_cuil.Name = "conductor_cuil"
		Me.conductor_cuil.Size = New System.Drawing.Size(143, 27)
		Me.conductor_cuil.TabIndex = 416
		Me.conductor_cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.conductor_cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'conductor_id
		'
		Me.conductor_id.BackColor = System.Drawing.Color.OrangeRed
		Me.conductor_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.conductor_id.Location = New System.Drawing.Point(236, 111)
		Me.conductor_id.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
		Me.conductor_id.MaxLength = 100
		Me.conductor_id.Name = "conductor_id"
		Me.conductor_id.Size = New System.Drawing.Size(25, 27)
		Me.conductor_id.TabIndex = 420
		Me.conductor_id.Text = "0"
		Me.conductor_id.Visible = False
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(0, 138)
		Me.Label4.Margin = New System.Windows.Forms.Padding(0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(116, 27)
		Me.Label4.TabIndex = 419
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'tabMultas2Persona
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "tabMultas2Persona"
		Me.Size = New System.Drawing.Size(358, 147)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label24 As Label
	Friend WithEvents propietario_razon As TextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents propietario_cuil As MaskedTextBox
	Friend WithEvents ErrorInfo As ToolTip
	Friend WithEvents cargar_prop As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents conductor_razon As TextBox
	Friend WithEvents cargar_cond As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents conductor_cuil As MaskedTextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents propietario_id As TextBox
	Friend WithEvents conductor_id As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label5 As Label
End Class
