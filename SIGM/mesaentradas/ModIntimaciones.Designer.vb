<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModIntimaciones
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
        Me.wrapper = New System.Windows.Forms.Panel()
        Me.GrupoNuevaInt = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.MaskedTextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.servicio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.razon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ingreso = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.observacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.estado = New System.Windows.Forms.ComboBox()
        Me.bs_intimaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.visor_intimaciones = New System.Windows.Forms.DataGridView()
        Me.TopMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.delete = New System.Windows.Forms.Button()
        Me.addNew = New System.Windows.Forms.Button()
        Me.BottomMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.save = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.persona_id = New System.Windows.Forms.TextBox()
        Me.wrapper.SuspendLayout()
        Me.GrupoNuevaInt.SuspendLayout()
        CType(Me.bs_intimaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visor_intimaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopMenu.SuspendLayout()
        Me.BottomMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'wrapper
        '
        Me.wrapper.BackColor = System.Drawing.SystemColors.Control
        Me.wrapper.Controls.Add(Me.GrupoNuevaInt)
        Me.wrapper.Dock = System.Windows.Forms.DockStyle.Top
        Me.wrapper.Location = New System.Drawing.Point(0, 33)
        Me.wrapper.Name = "wrapper"
        Me.wrapper.Size = New System.Drawing.Size(410, 281)
        Me.wrapper.TabIndex = 414
        Me.wrapper.Visible = False
        '
        'GrupoNuevaInt
        '
        Me.GrupoNuevaInt.BackColor = System.Drawing.SystemColors.Control
        Me.GrupoNuevaInt.Controls.Add(Me.Label2)
        Me.GrupoNuevaInt.Controls.Add(Me.codigo)
        Me.GrupoNuevaInt.Controls.Add(Me.buscar)
        Me.GrupoNuevaInt.Controls.Add(Me.Label1)
        Me.GrupoNuevaInt.Controls.Add(Me.servicio)
        Me.GrupoNuevaInt.Controls.Add(Me.Label7)
        Me.GrupoNuevaInt.Controls.Add(Me.razon)
        Me.GrupoNuevaInt.Controls.Add(Me.Label6)
        Me.GrupoNuevaInt.Controls.Add(Me.ingreso)
        Me.GrupoNuevaInt.Controls.Add(Me.Label3)
        Me.GrupoNuevaInt.Controls.Add(Me.Label5)
        Me.GrupoNuevaInt.Controls.Add(Me.observacion)
        Me.GrupoNuevaInt.Controls.Add(Me.Label4)
        Me.GrupoNuevaInt.Controls.Add(Me.estado)
        Me.GrupoNuevaInt.Location = New System.Drawing.Point(0, 4)
        Me.GrupoNuevaInt.Name = "GrupoNuevaInt"
        Me.GrupoNuevaInt.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.GrupoNuevaInt.Size = New System.Drawing.Size(403, 273)
        Me.GrupoNuevaInt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cuenta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'codigo
        '
        Me.codigo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.codigo.Location = New System.Drawing.Point(66, 8)
        Me.codigo.Mask = "00000"
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(100, 27)
        Me.codigo.TabIndex = 10
        Me.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'buscar
        '
        Me.buscar.FlatAppearance.BorderSize = 0
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.ForeColor = System.Drawing.Color.Black
        Me.buscar.Location = New System.Drawing.Point(169, 5)
        Me.buscar.Margin = New System.Windows.Forms.Padding(0)
        Me.buscar.Name = "buscar"
        Me.buscar.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.buscar.Size = New System.Drawing.Size(29, 30)
        Me.buscar.TabIndex = 71
        Me.buscar.Text = ""
        Me.buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(201, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servicio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'servicio
        '
        Me.servicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.servicio.Location = New System.Drawing.Point(269, 8)
        Me.servicio.Name = "servicio"
        Me.servicio.ReadOnly = True
        Me.servicio.Size = New System.Drawing.Size(123, 27)
        Me.servicio.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 30)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Razón"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'razon
        '
        Me.razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.razon.Location = New System.Drawing.Point(66, 41)
        Me.razon.Name = "razon"
        Me.razon.ReadOnly = True
        Me.razon.Size = New System.Drawing.Size(326, 27)
        Me.razon.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ingreso
        '
        Me.ingreso.CustomFormat = "DD/MM/YYYY"
        Me.ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ingreso.Location = New System.Drawing.Point(66, 74)
        Me.ingreso.Name = "ingreso"
        Me.ingreso.Size = New System.Drawing.Size(100, 27)
        Me.ingreso.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(172, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 30)
        Me.Label3.TabIndex = 7
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 30)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Observ."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'observacion
        '
        Me.observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.observacion.Location = New System.Drawing.Point(66, 107)
        Me.observacion.MaxLength = 220
        Me.observacion.Multiline = True
        Me.observacion.Name = "observacion"
        Me.observacion.Size = New System.Drawing.Size(326, 124)
        Me.observacion.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 30)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Estado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'estado
        '
        Me.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.estado.FormattingEnabled = True
        Me.estado.Location = New System.Drawing.Point(66, 237)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(326, 27)
        Me.estado.TabIndex = 60
        '
        'visor_intimaciones
        '
        Me.visor_intimaciones.AllowUserToAddRows = False
        Me.visor_intimaciones.AllowUserToDeleteRows = False
        Me.visor_intimaciones.AllowUserToResizeRows = False
        Me.visor_intimaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visor_intimaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor_intimaciones.Location = New System.Drawing.Point(0, 314)
        Me.visor_intimaciones.Name = "visor_intimaciones"
        Me.visor_intimaciones.ReadOnly = True
        Me.visor_intimaciones.RowHeadersVisible = False
        Me.visor_intimaciones.Size = New System.Drawing.Size(410, 36)
        Me.visor_intimaciones.TabIndex = 415
        '
        'TopMenu
        '
        Me.TopMenu.BackColor = System.Drawing.Color.DimGray
        Me.TopMenu.Controls.Add(Me.delete)
        Me.TopMenu.Controls.Add(Me.addNew)
        Me.TopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.TopMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Size = New System.Drawing.Size(410, 33)
        Me.TopMenu.TabIndex = 416
        '
        'delete
        '
        Me.delete.FlatAppearance.BorderSize = 0
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.0!)
        Me.delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.delete.Location = New System.Drawing.Point(381, 0)
        Me.delete.Margin = New System.Windows.Forms.Padding(0)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(29, 30)
        Me.delete.TabIndex = 400
        Me.delete.Text = ""
        Me.delete.UseVisualStyleBackColor = True
        '
        'addNew
        '
        Me.addNew.FlatAppearance.BorderSize = 0
        Me.addNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addNew.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.0!)
        Me.addNew.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.addNew.Location = New System.Drawing.Point(352, 0)
        Me.addNew.Margin = New System.Windows.Forms.Padding(0)
        Me.addNew.Name = "addNew"
        Me.addNew.Size = New System.Drawing.Size(29, 30)
        Me.addNew.TabIndex = 399
        Me.addNew.Text = ""
        Me.addNew.UseVisualStyleBackColor = True
        '
        'BottomMenu
        '
        Me.BottomMenu.BackColor = System.Drawing.Color.DimGray
        Me.BottomMenu.Controls.Add(Me.save)
        Me.BottomMenu.Controls.Add(Me.cancel)
        Me.BottomMenu.Controls.Add(Me.persona_id)
        Me.BottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.BottomMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BottomMenu.Location = New System.Drawing.Point(0, 350)
        Me.BottomMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.BottomMenu.Name = "BottomMenu"
        Me.BottomMenu.Size = New System.Drawing.Size(410, 33)
        Me.BottomMenu.TabIndex = 417
        Me.BottomMenu.Visible = False
        '
        'save
        '
        Me.save.FlatAppearance.BorderSize = 0
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.0!)
        Me.save.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.save.Location = New System.Drawing.Point(381, 0)
        Me.save.Margin = New System.Windows.Forms.Padding(0)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(29, 29)
        Me.save.TabIndex = 70
        Me.save.Text = ""
        Me.save.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.0!)
        Me.cancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cancel.Location = New System.Drawing.Point(352, 0)
        Me.cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(29, 29)
        Me.cancel.TabIndex = 80
        Me.cancel.Text = ""
        Me.cancel.UseVisualStyleBackColor = True
        '
        'persona_id
        '
        Me.persona_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.persona_id.Location = New System.Drawing.Point(324, 3)
        Me.persona_id.MaxLength = 128
        Me.persona_id.Name = "persona_id"
        Me.persona_id.ReadOnly = True
        Me.persona_id.Size = New System.Drawing.Size(25, 27)
        Me.persona_id.TabIndex = 373
        Me.persona_id.Text = "0"
        Me.persona_id.Visible = False
        '
        'ModIntimaciones
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(410, 383)
        Me.Controls.Add(Me.visor_intimaciones)
        Me.Controls.Add(Me.BottomMenu)
        Me.Controls.Add(Me.wrapper)
        Me.Controls.Add(Me.TopMenu)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(250, 250)
        Me.Name = "ModIntimaciones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "                                                                                 " &
    "                                                 "
        Me.wrapper.ResumeLayout(False)
        Me.GrupoNuevaInt.ResumeLayout(False)
        Me.GrupoNuevaInt.PerformLayout()
        CType(Me.bs_intimaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visor_intimaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopMenu.ResumeLayout(False)
        Me.BottomMenu.ResumeLayout(False)
        Me.BottomMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wrapper As Panel
    Friend WithEvents GrupoNuevaInt As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents razon As TextBox
    Friend WithEvents bs_intimaciones As BindingSource
    Friend WithEvents visor_intimaciones As DataGridView
    Friend WithEvents codigo As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents observacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents estado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ingreso As DateTimePicker
    Friend WithEvents buscar As Button
    Friend WithEvents servicio As TextBox
    Friend WithEvents TopMenu As FlowLayoutPanel
    Friend WithEvents delete As Button
    Friend WithEvents addNew As Button
    Friend WithEvents BottomMenu As FlowLayoutPanel
    Friend WithEvents save As Button
    Friend WithEvents cancel As Button
    Friend WithEvents persona_id As TextBox
End Class
