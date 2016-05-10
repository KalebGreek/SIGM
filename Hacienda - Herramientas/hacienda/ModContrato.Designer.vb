<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModContrato
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
        Me.grupo_contrato = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.detalle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.autoridad2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.autoridad1 = New System.Windows.Forms.ComboBox()
        Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GuardarCambios = New System.Windows.Forms.Button()
        Me.empleado_id = New System.Windows.Forms.TextBox()
        Me.contrato_id = New System.Windows.Forms.TextBox()
        Me.monto = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.razon = New System.Windows.Forms.TextBox()
        Me.cuil = New System.Windows.Forms.MaskedTextBox()
        Me.grupo_persona = New System.Windows.Forms.Panel()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.grupo_contrato.SuspendLayout()
        CType(Me.dias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_mod.SuspendLayout()
        CType(Me.monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_persona.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupo_contrato
        '
        Me.grupo_contrato.BackColor = System.Drawing.Color.LightGray
        Me.grupo_contrato.Controls.Add(Me.Label8)
        Me.grupo_contrato.Controls.Add(Me.Label7)
        Me.grupo_contrato.Controls.Add(Me.dias)
        Me.grupo_contrato.Controls.Add(Me.Label6)
        Me.grupo_contrato.Controls.Add(Me.detalle)
        Me.grupo_contrato.Controls.Add(Me.Label5)
        Me.grupo_contrato.Controls.Add(Me.inicio)
        Me.grupo_contrato.Controls.Add(Me.Label3)
        Me.grupo_contrato.Controls.Add(Me.autoridad2)
        Me.grupo_contrato.Controls.Add(Me.Label1)
        Me.grupo_contrato.Controls.Add(Me.autoridad1)
        Me.grupo_contrato.Controls.Add(Me.grupo_mod)
        Me.grupo_contrato.Controls.Add(Me.monto)
        Me.grupo_contrato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupo_contrato.Enabled = False
        Me.grupo_contrato.Location = New System.Drawing.Point(0, 75)
        Me.grupo_contrato.Name = "grupo_contrato"
        Me.grupo_contrato.Size = New System.Drawing.Size(504, 342)
        Me.grupo_contrato.TabIndex = 379
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(69, 259)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 30)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "Monto     $"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(436, 86)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 22)
        Me.Label7.TabIndex = 404
        Me.Label7.Text = "dia/s"
        '
        'dias
        '
        Me.dias.Location = New System.Drawing.Point(370, 82)
        Me.dias.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.dias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(64, 30)
        Me.dias.TabIndex = 403
        Me.dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 22)
        Me.Label6.TabIndex = 402
        Me.Label6.Text = "Valido por"
        '
        'detalle
        '
        Me.detalle.Location = New System.Drawing.Point(134, 120)
        Me.detalle.Multiline = True
        Me.detalle.Name = "detalle"
        Me.detalle.Size = New System.Drawing.Size(354, 133)
        Me.detalle.TabIndex = 401
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 22)
        Me.Label5.TabIndex = 400
        Me.Label5.Text = "Detalle"
        '
        'inicio
        '
        Me.inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inicio.Location = New System.Drawing.Point(134, 82)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(131, 30)
        Me.inicio.TabIndex = 399
        Me.inicio.Value = New Date(2015, 11, 28, 16, 10, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 398
        Me.Label3.Text = "Fecha de Inicio"
        '
        'autoridad2
        '
        Me.autoridad2.FormattingEnabled = True
        Me.autoridad2.Location = New System.Drawing.Point(134, 45)
        Me.autoridad2.Name = "autoridad2"
        Me.autoridad2.Size = New System.Drawing.Size(354, 30)
        Me.autoridad2.TabIndex = 397
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 396
        Me.Label1.Text = "Autoridades"
        '
        'autoridad1
        '
        Me.autoridad1.FormattingEnabled = True
        Me.autoridad1.Location = New System.Drawing.Point(134, 8)
        Me.autoridad1.Name = "autoridad1"
        Me.autoridad1.Size = New System.Drawing.Size(354, 30)
        Me.autoridad1.TabIndex = 395
        '
        'grupo_mod
        '
        Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
        Me.grupo_mod.Controls.Add(Me.Cancelar)
        Me.grupo_mod.Controls.Add(Me.GuardarCambios)
        Me.grupo_mod.Controls.Add(Me.empleado_id)
        Me.grupo_mod.Controls.Add(Me.contrato_id)
        Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.grupo_mod.Location = New System.Drawing.Point(0, 302)
        Me.grupo_mod.Name = "grupo_mod"
        Me.grupo_mod.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.grupo_mod.Size = New System.Drawing.Size(504, 40)
        Me.grupo_mod.TabIndex = 394
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cancelar.Location = New System.Drawing.Point(400, 7)
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
        Me.GuardarCambios.Location = New System.Drawing.Point(232, 7)
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
        Me.empleado_id.Location = New System.Drawing.Point(201, 7)
        Me.empleado_id.MaxLength = 128
        Me.empleado_id.Name = "empleado_id"
        Me.empleado_id.ReadOnly = True
        Me.empleado_id.Size = New System.Drawing.Size(25, 27)
        Me.empleado_id.TabIndex = 374
        Me.empleado_id.Text = "0"
        Me.empleado_id.Visible = False
        '
        'contrato_id
        '
        Me.contrato_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.contrato_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.contrato_id.Location = New System.Drawing.Point(170, 7)
        Me.contrato_id.MaxLength = 128
        Me.contrato_id.Name = "contrato_id"
        Me.contrato_id.ReadOnly = True
        Me.contrato_id.Size = New System.Drawing.Size(25, 27)
        Me.contrato_id.TabIndex = 373
        Me.contrato_id.Text = "0"
        Me.contrato_id.Visible = False
        '
        'monto
        '
        Me.monto.DecimalPlaces = 2
        Me.monto.Location = New System.Drawing.Point(146, 259)
        Me.monto.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.monto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.monto.Name = "monto"
        Me.monto.Size = New System.Drawing.Size(119, 30)
        Me.monto.TabIndex = 406
        Me.monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.monto.ThousandsSeparator = True
        Me.monto.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.monto.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 22)
        Me.Label4.TabIndex = 390
        Me.Label4.Text = "CUIT/CUIL"
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
        Me.razon.Size = New System.Drawing.Size(269, 27)
        Me.razon.TabIndex = 380
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
        'grupo_persona
        '
        Me.grupo_persona.BackColor = System.Drawing.Color.LightGray
        Me.grupo_persona.Controls.Add(Me.Buscar)
        Me.grupo_persona.Controls.Add(Me.cuil)
        Me.grupo_persona.Controls.Add(Me.razon)
        Me.grupo_persona.Controls.Add(Me.Label4)
        Me.grupo_persona.Controls.Add(Me.Label2)
        Me.grupo_persona.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_persona.Location = New System.Drawing.Point(0, 0)
        Me.grupo_persona.Name = "grupo_persona"
        Me.grupo_persona.Size = New System.Drawing.Size(504, 75)
        Me.grupo_persona.TabIndex = 377
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Buscar.FlatAppearance.BorderSize = 0
        Me.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buscar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Buscar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Buscar.Location = New System.Drawing.Point(392, 8)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(96, 26)
        Me.Buscar.TabIndex = 392
        Me.Buscar.Text = "BUSCAR"
        Me.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'ModContrato
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(504, 417)
        Me.Controls.Add(Me.grupo_contrato)
        Me.Controls.Add(Me.grupo_persona)
        Me.Font = New System.Drawing.Font("PF DinText Pro", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(520, 310)
        Me.Name = "ModContrato"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AGREGAR NUEVO CONTRATO"
        Me.grupo_contrato.ResumeLayout(False)
        Me.grupo_contrato.PerformLayout()
        CType(Me.dias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_mod.ResumeLayout(False)
        Me.grupo_mod.PerformLayout()
        CType(Me.monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_persona.ResumeLayout(False)
        Me.grupo_persona.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupo_contrato As System.Windows.Forms.Panel
    Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents GuardarCambios As System.Windows.Forms.Button
    Friend WithEvents empleado_id As System.Windows.Forms.TextBox
    Friend WithEvents contrato_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents razon As System.Windows.Forms.TextBox
    Friend WithEvents cuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grupo_persona As System.Windows.Forms.Panel
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dias As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents detalle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents autoridad2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents autoridad1 As System.Windows.Forms.ComboBox
    Friend WithEvents monto As System.Windows.Forms.NumericUpDown
End Class
