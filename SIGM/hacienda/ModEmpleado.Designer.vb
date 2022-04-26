<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grupo_persona = New System.Windows.Forms.Panel()
        Me.cuil = New System.Windows.Forms.MaskedTextBox()
        Me.razon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grupo_datos = New System.Windows.Forms.Panel()
        Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GuardarCambios = New System.Windows.Forms.Button()
        Me.empleado_id = New System.Windows.Forms.TextBox()
        Me.persona_id = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabContrato = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabJerarquia = New System.Windows.Forms.TabPage()
        Me.subpartida = New System.Windows.Forms.ComboBox()
        Me.partida = New System.Windows.Forms.ComboBox()
        Me.rubro = New System.Windows.Forms.ComboBox()
        Me.bs_rubro = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_partida = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_subpartida = New System.Windows.Forms.BindingSource(Me.components)
        Me.grupo_persona.SuspendLayout()
        Me.grupo_datos.SuspendLayout()
        Me.grupo_mod.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabContrato.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabJerarquia.SuspendLayout()
        CType(Me.bs_rubro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_partida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_subpartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupo_persona
        '
        Me.grupo_persona.BackColor = System.Drawing.Color.LightGray
        Me.grupo_persona.Controls.Add(Me.cuil)
        Me.grupo_persona.Controls.Add(Me.razon)
        Me.grupo_persona.Controls.Add(Me.Label4)
        Me.grupo_persona.Controls.Add(Me.buscar)
        Me.grupo_persona.Controls.Add(Me.Label2)
        Me.grupo_persona.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_persona.Location = New System.Drawing.Point(0, 0)
        Me.grupo_persona.Name = "grupo_persona"
        Me.grupo_persona.Size = New System.Drawing.Size(520, 75)
        Me.grupo_persona.TabIndex = 377
        '
        'cuil
        '
        Me.cuil.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuil.Location = New System.Drawing.Point(115, 40)
        Me.cuil.Margin = New System.Windows.Forms.Padding(4)
        Me.cuil.Mask = "99-99999999-9"
        Me.cuil.Name = "cuil"
        Me.cuil.ReadOnly = True
        Me.cuil.Size = New System.Drawing.Size(117, 27)
        Me.cuil.TabIndex = 391
        Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'razon
        '
        Me.razon.BackColor = System.Drawing.SystemColors.Control
        Me.razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.razon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.razon.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.razon.Location = New System.Drawing.Point(115, 8)
        Me.razon.MaxLength = 512
        Me.razon.Name = "razon"
        Me.razon.ReadOnly = True
        Me.razon.Size = New System.Drawing.Size(302, 27)
        Me.razon.TabIndex = 380
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 22)
        Me.Label4.TabIndex = 390
        Me.Label4.Text = "CUIL"
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.buscar.FlatAppearance.BorderSize = 0
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.buscar.ForeColor = System.Drawing.Color.White
        Me.buscar.Location = New System.Drawing.Point(423, 8)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(87, 27)
        Me.buscar.TabIndex = 379
        Me.buscar.Text = "BUSCAR"
        Me.buscar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 376
        Me.Label2.Text = "Razon Social"
        '
        'grupo_datos
        '
        Me.grupo_datos.BackColor = System.Drawing.Color.LightGray
        Me.grupo_datos.Controls.Add(Me.TabControl1)
        Me.grupo_datos.Controls.Add(Me.grupo_mod)
        Me.grupo_datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupo_datos.Enabled = False
        Me.grupo_datos.Location = New System.Drawing.Point(0, 75)
        Me.grupo_datos.Name = "grupo_datos"
        Me.grupo_datos.Size = New System.Drawing.Size(520, 342)
        Me.grupo_datos.TabIndex = 379
        '
        'grupo_mod
        '
        Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
        Me.grupo_mod.Controls.Add(Me.Cancelar)
        Me.grupo_mod.Controls.Add(Me.GuardarCambios)
        Me.grupo_mod.Controls.Add(Me.empleado_id)
        Me.grupo_mod.Controls.Add(Me.persona_id)
        Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.grupo_mod.Location = New System.Drawing.Point(0, 302)
        Me.grupo_mod.Name = "grupo_mod"
        Me.grupo_mod.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.grupo_mod.Size = New System.Drawing.Size(520, 40)
        Me.grupo_mod.TabIndex = 394
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cancelar.Location = New System.Drawing.Point(416, 7)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(96, 26)
        Me.Cancelar.TabIndex = 345
        Me.Cancelar.Text = "CANCELAR"
        Me.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'GuardarCambios
        '
        Me.GuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GuardarCambios.FlatAppearance.BorderSize = 0
        Me.GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarCambios.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.GuardarCambios.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GuardarCambios.Location = New System.Drawing.Point(248, 7)
        Me.GuardarCambios.Name = "GuardarCambios"
        Me.GuardarCambios.Size = New System.Drawing.Size(162, 26)
        Me.GuardarCambios.TabIndex = 344
        Me.GuardarCambios.Text = "GUARDAR CAMBIOS"
        Me.GuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GuardarCambios.UseVisualStyleBackColor = False
        '
        'empleado_id
        '
        Me.empleado_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.empleado_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.empleado_id.Location = New System.Drawing.Point(217, 7)
        Me.empleado_id.MaxLength = 128
        Me.empleado_id.Name = "empleado_id"
        Me.empleado_id.ReadOnly = True
        Me.empleado_id.Size = New System.Drawing.Size(25, 27)
        Me.empleado_id.TabIndex = 374
        Me.empleado_id.Text = "0"
        Me.empleado_id.Visible = False
        '
        'persona_id
        '
        Me.persona_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.persona_id.Location = New System.Drawing.Point(186, 7)
        Me.persona_id.MaxLength = 128
        Me.persona_id.Name = "persona_id"
        Me.persona_id.ReadOnly = True
        Me.persona_id.Size = New System.Drawing.Size(25, 27)
        Me.persona_id.TabIndex = 373
        Me.persona_id.Text = "0"
        Me.persona_id.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabContrato)
        Me.TabControl1.Controls.Add(Me.TabJerarquia)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(520, 302)
        Me.TabControl1.TabIndex = 393
        '
        'TabContrato
        '
        Me.TabContrato.BackColor = System.Drawing.Color.LightGray
        Me.TabContrato.Controls.Add(Me.DataGridView1)
        Me.TabContrato.Location = New System.Drawing.Point(4, 31)
        Me.TabContrato.Name = "TabContrato"
        Me.TabContrato.Size = New System.Drawing.Size(512, 267)
        Me.TabContrato.TabIndex = 0
        Me.TabContrato.Text = "Contrato"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(512, 267)
        Me.DataGridView1.TabIndex = 0
        '
        'TabJerarquia
        '
        Me.TabJerarquia.BackColor = System.Drawing.Color.LightGray
        Me.TabJerarquia.Controls.Add(Me.subpartida)
        Me.TabJerarquia.Controls.Add(Me.partida)
        Me.TabJerarquia.Controls.Add(Me.rubro)
        Me.TabJerarquia.Location = New System.Drawing.Point(4, 31)
        Me.TabJerarquia.Margin = New System.Windows.Forms.Padding(0)
        Me.TabJerarquia.Name = "TabJerarquia"
        Me.TabJerarquia.Size = New System.Drawing.Size(512, 307)
        Me.TabJerarquia.TabIndex = 1
        Me.TabJerarquia.Text = "Jerarquia"
        '
        'subpartida
        '
        Me.subpartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subpartida.FormattingEnabled = True
        Me.subpartida.Location = New System.Drawing.Point(19, 98)
        Me.subpartida.Name = "subpartida"
        Me.subpartida.Size = New System.Drawing.Size(475, 30)
        Me.subpartida.TabIndex = 389
        Me.subpartida.Visible = False
        '
        'partida
        '
        Me.partida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.partida.FormattingEnabled = True
        Me.partida.Location = New System.Drawing.Point(19, 58)
        Me.partida.Name = "partida"
        Me.partida.Size = New System.Drawing.Size(475, 30)
        Me.partida.TabIndex = 388
        Me.partida.Visible = False
        '
        'rubro
        '
        Me.rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rubro.FormattingEnabled = True
        Me.rubro.Location = New System.Drawing.Point(19, 18)
        Me.rubro.Name = "rubro"
        Me.rubro.Size = New System.Drawing.Size(475, 30)
        Me.rubro.TabIndex = 387
        '
        'bs_rubro
        '
        '
        'bs_partida
        '
        '
        'ModEmpleado
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(520, 417)
        Me.Controls.Add(Me.grupo_datos)
        Me.Controls.Add(Me.grupo_persona)
        Me.Font = New System.Drawing.Font("PF DinText Pro", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(520, 310)
        Me.Name = "ModEmpleado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AGREGAR NUEVO EMPLEADO"
        Me.grupo_persona.ResumeLayout(False)
        Me.grupo_persona.PerformLayout()
        Me.grupo_datos.ResumeLayout(False)
        Me.grupo_mod.ResumeLayout(False)
        Me.grupo_mod.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabContrato.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabJerarquia.ResumeLayout(False)
        CType(Me.bs_rubro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_partida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_subpartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupo_persona As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents buscar As System.Windows.Forms.Button
    Friend WithEvents grupo_datos As System.Windows.Forms.Panel
    Friend WithEvents razon As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabContrato As System.Windows.Forms.TabPage
    Friend WithEvents TabJerarquia As System.Windows.Forms.TabPage
    Friend WithEvents subpartida As System.Windows.Forms.ComboBox
    Friend WithEvents partida As System.Windows.Forms.ComboBox
    Friend WithEvents rubro As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bs_rubro As System.Windows.Forms.BindingSource
    Friend WithEvents bs_partida As System.Windows.Forms.BindingSource
    Friend WithEvents bs_subpartida As System.Windows.Forms.BindingSource
    Friend WithEvents cuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents GuardarCambios As System.Windows.Forms.Button
    Friend WithEvents empleado_id As System.Windows.Forms.TextBox
    Friend WithEvents persona_id As System.Windows.Forms.TextBox
End Class
