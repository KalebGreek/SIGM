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
        Me.components = New System.ComponentModel.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.autoridad2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.autoridad1 = New System.Windows.Forms.ComboBox()
        Me.monto = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.razon = New System.Windows.Forms.TextBox()
        Me.cuil = New System.Windows.Forms.MaskedTextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Aut1Cuil = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Aut2Cuil = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BottomMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GuardarCambios = New System.Windows.Forms.Button()
        Me.bs1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.seccion = New System.Windows.Forms.ComboBox()
        Me.buscar = New System.Windows.Forms.Button()
        CType(Me.dias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomMenu.SuspendLayout()
        CType(Me.bs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 286)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 30)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "Monto $"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(240, 252)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 34)
        Me.Label7.TabIndex = 404
        Me.Label7.Text = "dia/s"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dias
        '
        Me.dias.Location = New System.Drawing.Point(109, 255)
        Me.dias.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.dias.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.dias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(127, 30)
        Me.dias.TabIndex = 36
        Me.dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.dias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 252)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 34)
        Me.Label6.TabIndex = 402
        Me.Label6.Text = "A pagar en"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(109, 4)
        Me.descripcion.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.descripcion.MaxLength = 440
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(399, 248)
        Me.descripcion.TabIndex = 35
        '
        'inicio
        '
        Me.inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inicio.Location = New System.Drawing.Point(238, 36)
        Me.inicio.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(113, 30)
        Me.inicio.TabIndex = 13
        Me.inicio.Value = New Date(2015, 11, 28, 16, 10, 0, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 34)
        Me.Label3.TabIndex = 398
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'autoridad2
        '
        Me.autoridad2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.autoridad2.FormattingEnabled = True
        Me.autoridad2.Location = New System.Drawing.Point(109, 68)
        Me.autoridad2.Margin = New System.Windows.Forms.Padding(0)
        Me.autoridad2.Name = "autoridad2"
        Me.autoridad2.Size = New System.Drawing.Size(226, 30)
        Me.autoridad2.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 33)
        Me.Label1.TabIndex = 396
        Me.Label1.Text = "Autoridad 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'autoridad1
        '
        Me.autoridad1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.autoridad1.FormattingEnabled = True
        Me.autoridad1.Location = New System.Drawing.Point(109, 35)
        Me.autoridad1.Margin = New System.Windows.Forms.Padding(0)
        Me.autoridad1.Name = "autoridad1"
        Me.autoridad1.Size = New System.Drawing.Size(226, 30)
        Me.autoridad1.TabIndex = 31
        '
        'monto
        '
        Me.monto.DecimalPlaces = 2
        Me.monto.Location = New System.Drawing.Point(109, 288)
        Me.monto.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.monto.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.monto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.monto.Name = "monto"
        Me.monto.Size = New System.Drawing.Size(127, 30)
        Me.monto.TabIndex = 37
        Me.monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.monto.ThousandsSeparator = True
        Me.monto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 31)
        Me.Label2.TabIndex = 376
        Me.Label2.Text = "Razón"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'razon
        '
        Me.razon.BackColor = System.Drawing.SystemColors.Control
        Me.razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.razon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.razon.Location = New System.Drawing.Point(109, 2)
        Me.razon.Margin = New System.Windows.Forms.Padding(0, 2, 0, 3)
        Me.razon.MaxLength = 512
        Me.razon.Name = "razon"
        Me.razon.ReadOnly = True
        Me.razon.Size = New System.Drawing.Size(226, 30)
        Me.razon.TabIndex = 21
        Me.razon.TabStop = False
        '
        'cuil
        '
        Me.cuil.Location = New System.Drawing.Point(338, 2)
        Me.cuil.Margin = New System.Windows.Forms.Padding(3, 2, 0, 0)
        Me.cuil.Mask = "99-99999999-9"
        Me.cuil.Name = "cuil"
        Me.cuil.ReadOnly = True
        Me.cuil.Size = New System.Drawing.Size(130, 30)
        Me.cuil.TabIndex = 22
        Me.cuil.TabStop = False
        Me.cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.razon)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuil)
        Me.FlowLayoutPanel1.Controls.Add(Me.buscar)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.autoridad1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Aut1Cuil)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.autoridad2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Aut2Cuil)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 103)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(513, 104)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("PF DinText Pro Medium", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(514, 27)
        Me.Label9.TabIndex = 381
        Me.Label9.Text = " NUEVO CONTRATO"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.descripcion)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel2.Controls.Add(Me.dias)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.Controls.Add(Me.monto)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 210)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(513, 323)
        Me.FlowLayoutPanel2.TabIndex = 30
        '
        'Aut1Cuil
        '
        Me.Aut1Cuil.Location = New System.Drawing.Point(338, 35)
        Me.Aut1Cuil.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Aut1Cuil.Mask = "99-99999999-9"
        Me.Aut1Cuil.Name = "Aut1Cuil"
        Me.Aut1Cuil.ReadOnly = True
        Me.Aut1Cuil.Size = New System.Drawing.Size(130, 30)
        Me.Aut1Cuil.TabIndex = 32
        Me.Aut1Cuil.TabStop = False
        Me.Aut1Cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Aut1Cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(4, 68)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 33)
        Me.Label10.TabIndex = 410
        Me.Label10.Text = "Autoridad 2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Aut2Cuil
        '
        Me.Aut2Cuil.Location = New System.Drawing.Point(338, 68)
        Me.Aut2Cuil.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Aut2Cuil.Mask = "99-99999999-9"
        Me.Aut2Cuil.Name = "Aut2Cuil"
        Me.Aut2Cuil.ReadOnly = True
        Me.Aut2Cuil.Size = New System.Drawing.Size(130, 30)
        Me.Aut2Cuil.TabIndex = 34
        Me.Aut2Cuil.TabStop = False
        Me.Aut2Cuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Aut2Cuil.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 28)
        Me.Label5.TabIndex = 409
        Me.Label5.Text = "Descripción"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(109, 37)
        Me.codigo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.codigo.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.codigo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(68, 30)
        Me.codigo.TabIndex = 12
        Me.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.codigo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(181, 34)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 34)
        Me.Label12.TabIndex = 411
        Me.Label12.Text = "Inicio"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BottomMenu
        '
        Me.BottomMenu.BackColor = System.Drawing.Color.DimGray
        Me.BottomMenu.Controls.Add(Me.Cancelar)
        Me.BottomMenu.Controls.Add(Me.GuardarCambios)
        Me.BottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.BottomMenu.Location = New System.Drawing.Point(0, 553)
        Me.BottomMenu.Name = "BottomMenu"
        Me.BottomMenu.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.BottomMenu.Size = New System.Drawing.Size(514, 40)
        Me.BottomMenu.TabIndex = 40
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cancelar.Location = New System.Drawing.Point(410, 7)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(96, 26)
        Me.Cancelar.TabIndex = 42
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
        Me.GuardarCambios.Location = New System.Drawing.Point(308, 7)
        Me.GuardarCambios.Name = "GuardarCambios"
        Me.GuardarCambios.Size = New System.Drawing.Size(96, 26)
        Me.GuardarCambios.TabIndex = 41
        Me.GuardarCambios.Text = "GUARDAR"
        Me.GuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GuardarCambios.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel3.Controls.Add(Me.seccion)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel3.Controls.Add(Me.codigo)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel3.Controls.Add(Me.inicio)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 29)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(360, 71)
        Me.FlowLayoutPanel3.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 34)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "Sección"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'seccion
        '
        Me.seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seccion.FormattingEnabled = True
        Me.seccion.Items.AddRange(New Object() {"HACIENDA", "DEPORTES", "OBRAS PÚBLICAS", "TRÁNSITO", "TURISMO"})
        Me.seccion.Location = New System.Drawing.Point(109, 3)
        Me.seccion.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(230, 30)
        Me.seccion.TabIndex = 11
        '
        'buscar
        '
        Me.buscar.FlatAppearance.BorderSize = 0
        Me.buscar.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(470, 1)
        Me.buscar.Margin = New System.Windows.Forms.Padding(2, 1, 0, 0)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(33, 33)
        Me.buscar.TabIndex = 411
        Me.buscar.Text = ""
        Me.buscar.UseVisualStyleBackColor = True
        '
        'ModContrato
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(514, 593)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.BottomMenu)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Font = New System.Drawing.Font("PF DinText Pro", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(530, 595)
        Me.Name = "ModContrato"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.dias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.codigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomMenu.ResumeLayout(False)
        CType(Me.bs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents razon As System.Windows.Forms.TextBox
    Friend WithEvents cuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dias As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents autoridad2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents autoridad1 As System.Windows.Forms.ComboBox
    Friend WithEvents monto As System.Windows.Forms.NumericUpDown
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents BottomMenu As FlowLayoutPanel
    Friend WithEvents Cancelar As Button
    Friend WithEvents GuardarCambios As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bs1 As BindingSource
    Friend WithEvents bs2 As BindingSource
    Friend WithEvents Aut1Cuil As MaskedTextBox
    Friend WithEvents Aut2Cuil As MaskedTextBox
    Friend WithEvents codigo As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents seccion As ComboBox
    Friend WithEvents buscar As Button
End Class
