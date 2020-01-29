<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModMulta
	Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.subtitulo = New System.Windows.Forms.Label()
		Me.bs_acta = New System.Windows.Forms.BindingSource(Me.components)
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabMultas1Boleta1 = New Sigm.tabMultas1Boleta()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TabMultas2Persona1 = New Sigm.tabMultas2Persona()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.TabMultas3Vehiculo1 = New Sigm.tabMultas3Vehiculo()
		Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
		Me.persona_id = New System.Windows.Forms.TextBox()
		Me.cancel = New System.Windows.Forms.Button()
		Me.nextPage = New System.Windows.Forms.Button()
		Me.lastPage = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.boleta = New System.Windows.Forms.MaskedTextBox()
		Me.BuscarMulta = New System.Windows.Forms.Button()
		CType(Me.bs_acta, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		Me.grupo_mod.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'subtitulo
		'
		Me.subtitulo.BackColor = System.Drawing.Color.DimGray
		Me.subtitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.subtitulo.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Bold)
		Me.subtitulo.ForeColor = System.Drawing.Color.White
		Me.subtitulo.Location = New System.Drawing.Point(0, 34)
		Me.subtitulo.Margin = New System.Windows.Forms.Padding(0)
		Me.subtitulo.Name = "subtitulo"
		Me.subtitulo.Size = New System.Drawing.Size(385, 27)
		Me.subtitulo.TabIndex = 372
		Me.subtitulo.Text = "BOLETA"
		Me.subtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Enabled = False
		Me.TabControl1.Location = New System.Drawing.Point(0, 34)
		Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(385, 360)
		Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
		Me.TabControl1.TabIndex = 374
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
		Me.TabPage1.Controls.Add(Me.TabMultas1Boleta1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 28)
		Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Size = New System.Drawing.Size(377, 328)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "BOLETA"
		'
		'TabMultas1Boleta1
		'
		Me.TabMultas1Boleta1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabMultas1Boleta1.Location = New System.Drawing.Point(0, 0)
		Me.TabMultas1Boleta1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabMultas1Boleta1.Name = "TabMultas1Boleta1"
		Me.TabMultas1Boleta1.Size = New System.Drawing.Size(362, 315)
		Me.TabMultas1Boleta1.TabIndex = 0
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
		Me.TabPage2.Controls.Add(Me.TabMultas2Persona1)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Size = New System.Drawing.Size(454, 357)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "DATOS PERSONALES"
		'
		'TabMultas2Persona1
		'
		Me.TabMultas2Persona1.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabMultas2Persona1.Location = New System.Drawing.Point(0, 0)
		Me.TabMultas2Persona1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabMultas2Persona1.Name = "TabMultas2Persona1"
		Me.TabMultas2Persona1.Size = New System.Drawing.Size(356, 147)
		Me.TabMultas2Persona1.TabIndex = 0
		'
		'TabPage3
		'
		Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
		Me.TabPage3.Controls.Add(Me.TabMultas3Vehiculo1)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Margin = New System.Windows.Forms.Padding(0)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(454, 357)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "VEHICULO"
		'
		'TabMultas3Vehiculo1
		'
		Me.TabMultas3Vehiculo1.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabMultas3Vehiculo1.Location = New System.Drawing.Point(0, 0)
		Me.TabMultas3Vehiculo1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabMultas3Vehiculo1.Name = "TabMultas3Vehiculo1"
		Me.TabMultas3Vehiculo1.Size = New System.Drawing.Size(274, 107)
		Me.TabMultas3Vehiculo1.TabIndex = 0
		'
		'grupo_mod
		'
		Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
		Me.grupo_mod.Controls.Add(Me.persona_id)
		Me.grupo_mod.Controls.Add(Me.cancel)
		Me.grupo_mod.Controls.Add(Me.nextPage)
		Me.grupo_mod.Controls.Add(Me.lastPage)
		Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.grupo_mod.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.grupo_mod.Location = New System.Drawing.Point(0, 394)
		Me.grupo_mod.Margin = New System.Windows.Forms.Padding(0)
		Me.grupo_mod.Name = "grupo_mod"
		Me.grupo_mod.Size = New System.Drawing.Size(385, 28)
		Me.grupo_mod.TabIndex = 396
		'
		'persona_id
		'
		Me.persona_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.persona_id.Location = New System.Drawing.Point(357, 3)
		Me.persona_id.MaxLength = 128
		Me.persona_id.Name = "persona_id"
		Me.persona_id.ReadOnly = True
		Me.persona_id.Size = New System.Drawing.Size(25, 27)
		Me.persona_id.TabIndex = 373
		Me.persona_id.Text = "0"
		Me.persona_id.Visible = False
		'
		'cancel
		'
		Me.cancel.FlatAppearance.BorderSize = 0
		Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancel.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.cancel.Location = New System.Drawing.Point(281, 0)
		Me.cancel.Margin = New System.Windows.Forms.Padding(0)
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(73, 28)
		Me.cancel.TabIndex = 330
		Me.cancel.Text = "Cancelar"
		Me.cancel.UseVisualStyleBackColor = True
		'
		'nextPage
		'
		Me.nextPage.FlatAppearance.BorderSize = 0
		Me.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.nextPage.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.nextPage.Location = New System.Drawing.Point(187, 0)
		Me.nextPage.Margin = New System.Windows.Forms.Padding(0)
		Me.nextPage.Name = "nextPage"
		Me.nextPage.Size = New System.Drawing.Size(94, 28)
		Me.nextPage.TabIndex = 310
		Me.nextPage.Text = "Siguiente >"
		Me.nextPage.UseVisualStyleBackColor = True
		'
		'lastPage
		'
		Me.lastPage.Enabled = False
		Me.lastPage.FlatAppearance.BorderSize = 0
		Me.lastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lastPage.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lastPage.Location = New System.Drawing.Point(93, 0)
		Me.lastPage.Margin = New System.Windows.Forms.Padding(0)
		Me.lastPage.Name = "lastPage"
		Me.lastPage.Size = New System.Drawing.Size(94, 28)
		Me.lastPage.TabIndex = 300
		Me.lastPage.Text = "< Anterior"
		Me.lastPage.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.DimGray
		Me.FlowLayoutPanel2.Controls.Add(Me.Label24)
		Me.FlowLayoutPanel2.Controls.Add(Me.boleta)
		Me.FlowLayoutPanel2.Controls.Add(Me.BuscarMulta)
		Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(385, 34)
		Me.FlowLayoutPanel2.TabIndex = 397
		'
		'Label24
		'
		Me.Label24.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label24.ForeColor = System.Drawing.Color.White
		Me.Label24.Location = New System.Drawing.Point(0, 3)
		Me.Label24.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(91, 25)
		Me.Label24.TabIndex = 246
		Me.Label24.Text = "Nro. Boleta"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'boleta
		'
		Me.boleta.Location = New System.Drawing.Point(94, 3)
		Me.boleta.Mask = "9999 - 999999"
		Me.boleta.Name = "boleta"
		Me.boleta.Size = New System.Drawing.Size(117, 27)
		Me.boleta.TabIndex = 247
		Me.boleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.boleta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'BuscarMulta
		'
		Me.BuscarMulta.BackColor = System.Drawing.Color.Transparent
		Me.BuscarMulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.BuscarMulta.FlatAppearance.BorderSize = 0
		Me.BuscarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BuscarMulta.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BuscarMulta.ForeColor = System.Drawing.Color.White
		Me.BuscarMulta.Location = New System.Drawing.Point(217, 4)
		Me.BuscarMulta.Margin = New System.Windows.Forms.Padding(3, 4, 0, 0)
		Me.BuscarMulta.Name = "BuscarMulta"
		Me.BuscarMulta.Size = New System.Drawing.Size(27, 27)
		Me.BuscarMulta.TabIndex = 413
		Me.BuscarMulta.Text = ""
		Me.BuscarMulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.BuscarMulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.BuscarMulta.UseVisualStyleBackColor = False
		'
		'ModMulta
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(385, 422)
		Me.Controls.Add(Me.subtitulo)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.grupo_mod)
		Me.Controls.Add(Me.FlowLayoutPanel2)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Name = "ModMulta"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "NUEVA BOLETA"
		CType(Me.bs_acta, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		Me.grupo_mod.ResumeLayout(False)
		Me.grupo_mod.PerformLayout()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents subtitulo As System.Windows.Forms.Label
	Friend WithEvents bs_acta As System.Windows.Forms.BindingSource
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents TabMultas1Boleta1 As tabMultas1Boleta
	Friend WithEvents grupo_mod As FlowLayoutPanel
	Friend WithEvents persona_id As TextBox
	Friend WithEvents cancel As Button
	Friend WithEvents nextPage As Button
	Friend WithEvents lastPage As Button
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents Label24 As Label
	Friend WithEvents boleta As MaskedTextBox
	Friend WithEvents TabMultas2Persona1 As tabMultas2Persona
	Friend WithEvents TabMultas3Vehiculo1 As tabMultas3Vehiculo
	Friend WithEvents BuscarMulta As Button
End Class
