<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModPersona
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
		Me.persona_id = New System.Windows.Forms.TextBox()
		Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
		Me.Cancelar = New System.Windows.Forms.Button()
		Me.GuardarCambios = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.MainTabControl = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabDatosPersonales1 = New Sigm.tabDatosPersonales()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.GrupoDO = New System.Windows.Forms.FlowLayoutPanel()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.GrupoMC = New System.Windows.Forms.Panel()
		Me.TabPage4 = New System.Windows.Forms.TabPage()
		Me.GrupoDA = New System.Windows.Forms.Panel()
		Me.ModActas = New System.Windows.Forms.Button()
		Me.grupo_mod.SuspendLayout()
		Me.MainTabControl.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		Me.TabPage4.SuspendLayout()
		Me.GrupoDA.SuspendLayout()
		Me.SuspendLayout()
		'
		'persona_id
		'
		Me.persona_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.persona_id.Location = New System.Drawing.Point(366, 3)
		Me.persona_id.MaxLength = 128
		Me.persona_id.Name = "persona_id"
		Me.persona_id.ReadOnly = True
		Me.persona_id.Size = New System.Drawing.Size(25, 27)
		Me.persona_id.TabIndex = 373
		Me.persona_id.Text = "0"
		'
		'grupo_mod
		'
		Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
		Me.grupo_mod.Controls.Add(Me.Cancelar)
		Me.grupo_mod.Controls.Add(Me.GuardarCambios)
		Me.grupo_mod.Controls.Add(Me.Button1)
		Me.grupo_mod.Controls.Add(Me.persona_id)
		Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.grupo_mod.Location = New System.Drawing.Point(0, 406)
		Me.grupo_mod.Margin = New System.Windows.Forms.Padding(0)
		Me.grupo_mod.Name = "grupo_mod"
		Me.grupo_mod.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
		Me.grupo_mod.Size = New System.Drawing.Size(697, 32)
		Me.grupo_mod.TabIndex = 395
		'
		'Cancelar
		'
		Me.Cancelar.AutoSize = True
		Me.Cancelar.FlatAppearance.BorderSize = 0
		Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Cancelar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.Cancelar.Location = New System.Drawing.Point(595, 0)
		Me.Cancelar.Margin = New System.Windows.Forms.Padding(0)
		Me.Cancelar.Name = "Cancelar"
		Me.Cancelar.Size = New System.Drawing.Size(97, 29)
		Me.Cancelar.TabIndex = 345
		Me.Cancelar.Text = "CANCELAR"
		Me.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Cancelar.UseVisualStyleBackColor = False
		'
		'GuardarCambios
		'
		Me.GuardarCambios.AutoSize = True
		Me.GuardarCambios.FlatAppearance.BorderSize = 0
		Me.GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GuardarCambios.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.GuardarCambios.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.GuardarCambios.Location = New System.Drawing.Point(489, 0)
		Me.GuardarCambios.Margin = New System.Windows.Forms.Padding(0)
		Me.GuardarCambios.Name = "GuardarCambios"
		Me.GuardarCambios.Size = New System.Drawing.Size(106, 29)
		Me.GuardarCambios.TabIndex = 344
		Me.GuardarCambios.Text = "SIGUIENTE >"
		Me.GuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.GuardarCambios.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.AutoSize = True
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.Button1.Location = New System.Drawing.Point(394, 0)
		Me.Button1.Margin = New System.Windows.Forms.Padding(0)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(95, 29)
		Me.Button1.TabIndex = 396
		Me.Button1.Text = "< ATRAS"
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button1.UseVisualStyleBackColor = False
		'
		'MainTabControl
		'
		Me.MainTabControl.Controls.Add(Me.TabPage1)
		Me.MainTabControl.Controls.Add(Me.TabPage2)
		Me.MainTabControl.Controls.Add(Me.TabPage3)
		Me.MainTabControl.Controls.Add(Me.TabPage4)
		Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
		Me.MainTabControl.Name = "MainTabControl"
		Me.MainTabControl.SelectedIndex = 0
		Me.MainTabControl.Size = New System.Drawing.Size(697, 406)
		Me.MainTabControl.TabIndex = 412
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.TabDatosPersonales1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 28)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(689, 374)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Datos Personales"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'TabDatosPersonales1
		'
		Me.TabDatosPersonales1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.TabDatosPersonales1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabDatosPersonales1.Location = New System.Drawing.Point(3, 3)
		Me.TabDatosPersonales1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabDatosPersonales1.Name = "TabDatosPersonales1"
		Me.TabDatosPersonales1.Size = New System.Drawing.Size(683, 368)
		Me.TabDatosPersonales1.TabIndex = 0
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.GrupoDO)
		Me.TabPage2.Location = New System.Drawing.Point(4, 28)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(689, 374)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Domicilio"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'GrupoDO
		'
		Me.GrupoDO.BackColor = System.Drawing.SystemColors.ControlDark
		Me.GrupoDO.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GrupoDO.Location = New System.Drawing.Point(3, 3)
		Me.GrupoDO.Name = "GrupoDO"
		Me.GrupoDO.Size = New System.Drawing.Size(683, 368)
		Me.GrupoDO.TabIndex = 404
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.GrupoMC)
		Me.TabPage3.Location = New System.Drawing.Point(4, 28)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(689, 374)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Contacto"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'GrupoMC
		'
		Me.GrupoMC.BackColor = System.Drawing.Color.Silver
		Me.GrupoMC.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GrupoMC.Location = New System.Drawing.Point(3, 3)
		Me.GrupoMC.Name = "GrupoMC"
		Me.GrupoMC.Size = New System.Drawing.Size(683, 368)
		Me.GrupoMC.TabIndex = 407
		Me.GrupoMC.Visible = False
		'
		'TabPage4
		'
		Me.TabPage4.Controls.Add(Me.GrupoDA)
		Me.TabPage4.Location = New System.Drawing.Point(4, 28)
		Me.TabPage4.Name = "TabPage4"
		Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage4.Size = New System.Drawing.Size(689, 374)
		Me.TabPage4.TabIndex = 3
		Me.TabPage4.Text = "Datos Adicionales"
		Me.TabPage4.UseVisualStyleBackColor = True
		'
		'GrupoDA
		'
		Me.GrupoDA.BackColor = System.Drawing.Color.Silver
		Me.GrupoDA.Controls.Add(Me.ModActas)
		Me.GrupoDA.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GrupoDA.Location = New System.Drawing.Point(3, 3)
		Me.GrupoDA.Name = "GrupoDA"
		Me.GrupoDA.Size = New System.Drawing.Size(683, 368)
		Me.GrupoDA.TabIndex = 409
		Me.GrupoDA.Visible = False
		'
		'ModActas
		'
		Me.ModActas.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.ModActas.FlatAppearance.BorderSize = 0
		Me.ModActas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ModActas.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.ModActas.ForeColor = System.Drawing.Color.White
		Me.ModActas.Location = New System.Drawing.Point(6, 108)
		Me.ModActas.Margin = New System.Windows.Forms.Padding(3, 5, 8, 3)
		Me.ModActas.Name = "ModActas"
		Me.ModActas.Size = New System.Drawing.Size(132, 27)
		Me.ModActas.TabIndex = 408
		Me.ModActas.Text = "Consultar Actas"
		Me.ModActas.UseVisualStyleBackColor = False
		'
		'ModPersona
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.ClientSize = New System.Drawing.Size(697, 438)
		Me.Controls.Add(Me.MainTabControl)
		Me.Controls.Add(Me.grupo_mod)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(250, 250)
		Me.Name = "ModPersona"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "NUEVA PERSONA"
		Me.grupo_mod.ResumeLayout(False)
		Me.grupo_mod.PerformLayout()
		Me.MainTabControl.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		Me.TabPage4.ResumeLayout(False)
		Me.GrupoDA.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents persona_id As System.Windows.Forms.TextBox
	Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents Cancelar As System.Windows.Forms.Button
	Friend WithEvents GuardarCambios As System.Windows.Forms.Button
	Friend WithEvents MainTabControl As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabDatosPersonales1 As tabDatosPersonales
	Friend WithEvents Button1 As Button
	Friend WithEvents GrupoDO As FlowLayoutPanel
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents GrupoMC As Panel
	Friend WithEvents TabPage4 As TabPage
	Friend WithEvents GrupoDA As Panel
	Friend WithEvents ModActas As Button
End Class
