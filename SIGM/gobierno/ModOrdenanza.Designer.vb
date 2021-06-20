<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModOrdenanza
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
        Me.grupo_codigo = New System.Windows.Forms.Panel()
        Me.verificar = New System.Windows.Forms.Button()
        Me.codigo = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ordenanza_id = New System.Windows.Forms.TextBox()
        Me.grupo_datos = New System.Windows.Forms.Panel()
        Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GuardarCambios = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.cargar_doc = New System.Windows.Forms.Button()
        Me.ruta_doc = New System.Windows.Forms.TextBox()
        Me.concepto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.bs_registro = New System.Windows.Forms.BindingSource(Me.components)
        Me.grupo_codigo.SuspendLayout()
        Me.grupo_datos.SuspendLayout()
        Me.grupo_mod.SuspendLayout()
        CType(Me.bs_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupo_codigo
        '
        Me.grupo_codigo.BackColor = System.Drawing.Color.LightGray
        Me.grupo_codigo.Controls.Add(Me.verificar)
        Me.grupo_codigo.Controls.Add(Me.codigo)
        Me.grupo_codigo.Controls.Add(Me.Label2)
        Me.grupo_codigo.Controls.Add(Me.ordenanza_id)
        Me.grupo_codigo.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_codigo.Location = New System.Drawing.Point(0, 0)
        Me.grupo_codigo.Name = "grupo_codigo"
        Me.grupo_codigo.Size = New System.Drawing.Size(520, 48)
        Me.grupo_codigo.TabIndex = 377
        '
        'verificar
        '
        Me.verificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.verificar.FlatAppearance.BorderSize = 0
        Me.verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.verificar.ForeColor = System.Drawing.Color.White
        Me.verificar.Location = New System.Drawing.Point(207, 9)
        Me.verificar.Name = "verificar"
        Me.verificar.Size = New System.Drawing.Size(110, 30)
        Me.verificar.TabIndex = 20
        Me.verificar.Text = "Verificar"
        Me.verificar.UseVisualStyleBackColor = False
        '
        'codigo
        '
        Me.codigo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.codigo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.codigo.Location = New System.Drawing.Point(79, 9)
        Me.codigo.Mask = "9999 / 9999"
        Me.codigo.Name = "codigo"
        Me.codigo.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.codigo.Size = New System.Drawing.Size(118, 30)
        Me.codigo.TabIndex = 10
        Me.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.codigo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 376
        Me.Label2.Text = "Codigo"
        '
        'ordenanza_id
        '
        Me.ordenanza_id.BackColor = System.Drawing.Color.Lime
        Me.ordenanza_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ordenanza_id.Location = New System.Drawing.Point(470, 12)
        Me.ordenanza_id.MaxLength = 128
        Me.ordenanza_id.Name = "ordenanza_id"
        Me.ordenanza_id.ReadOnly = True
        Me.ordenanza_id.Size = New System.Drawing.Size(25, 27)
        Me.ordenanza_id.TabIndex = 373
        Me.ordenanza_id.Text = "-1"
        Me.ordenanza_id.Visible = False
        '
        'grupo_datos
        '
        Me.grupo_datos.BackColor = System.Drawing.Color.LightGray
        Me.grupo_datos.Controls.Add(Me.grupo_mod)
        Me.grupo_datos.Controls.Add(Me.Label1)
        Me.grupo_datos.Controls.Add(Me.fecha)
        Me.grupo_datos.Controls.Add(Me.cargar_doc)
        Me.grupo_datos.Controls.Add(Me.ruta_doc)
        Me.grupo_datos.Controls.Add(Me.concepto)
        Me.grupo_datos.Controls.Add(Me.Label14)
        Me.grupo_datos.Controls.Add(Me.Label24)
        Me.grupo_datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupo_datos.Enabled = False
        Me.grupo_datos.Location = New System.Drawing.Point(0, 48)
        Me.grupo_datos.Name = "grupo_datos"
        Me.grupo_datos.Size = New System.Drawing.Size(520, 262)
        Me.grupo_datos.TabIndex = 379
        '
        'grupo_mod
        '
        Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
        Me.grupo_mod.Controls.Add(Me.Cancelar)
        Me.grupo_mod.Controls.Add(Me.GuardarCambios)
        Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.grupo_mod.Location = New System.Drawing.Point(0, 222)
        Me.grupo_mod.Name = "grupo_mod"
        Me.grupo_mod.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.grupo_mod.Size = New System.Drawing.Size(520, 40)
        Me.grupo_mod.TabIndex = 383
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
        Me.Cancelar.TabIndex = 80
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
        Me.GuardarCambios.TabIndex = 70
        Me.GuardarCambios.Text = "GUARDAR CAMBIOS"
        Me.GuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GuardarCambios.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 22)
        Me.Label1.TabIndex = 382
        Me.Label1.Text = "Fecha Aprobacion"
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(154, 9)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(134, 30)
        Me.fecha.TabIndex = 30
        '
        'cargar_doc
        '
        Me.cargar_doc.BackColor = System.Drawing.Color.Transparent
        Me.cargar_doc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cargar_doc.FlatAppearance.BorderSize = 0
        Me.cargar_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cargar_doc.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cargar_doc.ForeColor = System.Drawing.Color.White
        Me.cargar_doc.Location = New System.Drawing.Point(458, 43)
        Me.cargar_doc.Margin = New System.Windows.Forms.Padding(0)
        Me.cargar_doc.Name = "cargar_doc"
        Me.cargar_doc.Size = New System.Drawing.Size(32, 32)
        Me.cargar_doc.TabIndex = 50
        Me.cargar_doc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cargar_doc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cargar_doc.UseVisualStyleBackColor = False
        '
        'ruta_doc
        '
        Me.ruta_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ruta_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.ruta_doc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ruta_doc.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.ruta_doc.Location = New System.Drawing.Point(154, 46)
        Me.ruta_doc.MaxLength = 512
        Me.ruta_doc.Name = "ruta_doc"
        Me.ruta_doc.ReadOnly = True
        Me.ruta_doc.Size = New System.Drawing.Size(298, 27)
        Me.ruta_doc.TabIndex = 40
        '
        'concepto
        '
        Me.concepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.concepto.Location = New System.Drawing.Point(154, 80)
        Me.concepto.Margin = New System.Windows.Forms.Padding(4)
        Me.concepto.MaxLength = 120
        Me.concepto.Multiline = True
        Me.concepto.Name = "concepto"
        Me.concepto.Size = New System.Drawing.Size(298, 104)
        Me.concepto.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 48)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 22)
        Me.Label14.TabIndex = 377
        Me.Label14.Text = "Copia Escaneada"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(62, 83)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 22)
        Me.Label24.TabIndex = 376
        Me.Label24.Text = "Conceptos"
        '
        'ModOrdenanza
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(520, 310)
        Me.Controls.Add(Me.grupo_datos)
        Me.Controls.Add(Me.grupo_codigo)
        Me.Font = New System.Drawing.Font("PF DinText Pro", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(520, 310)
        Me.Name = "ModOrdenanza"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AGREGAR NUEVA ORDENANZA"
        Me.TopMost = True
        Me.grupo_codigo.ResumeLayout(False)
        Me.grupo_codigo.PerformLayout()
        Me.grupo_datos.ResumeLayout(False)
        Me.grupo_datos.PerformLayout()
        Me.grupo_mod.ResumeLayout(False)
        CType(Me.bs_registro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupo_codigo As System.Windows.Forms.Panel
    Friend WithEvents ordenanza_id As System.Windows.Forms.TextBox
    Friend WithEvents codigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents verificar As System.Windows.Forms.Button
    Friend WithEvents grupo_datos As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cargar_doc As System.Windows.Forms.Button
    Friend WithEvents ruta_doc As System.Windows.Forms.TextBox
    Friend WithEvents concepto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents GuardarCambios As System.Windows.Forms.Button
    Friend WithEvents bs_registro As BindingSource
End Class
