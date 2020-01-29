<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModActa
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
		Me.subtitulo = New System.Windows.Forms.Label()
		Me.menu1 = New System.Windows.Forms.MenuStrip()
		Me.save = New System.Windows.Forms.ToolStripMenuItem()
		Me.PERSONASTitulo = New System.Windows.Forms.ToolStripMenuItem()
		Me.cancel = New System.Windows.Forms.ToolStripMenuItem()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.fecha_acta = New System.Windows.Forms.DateTimePicker()
		Me.cargar_copia_acta = New System.Windows.Forms.Button()
		Me.copia = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.add_acta = New System.Windows.Forms.Button()
		Me.consulta_acta = New System.Windows.Forms.DataGridView()
		Me.nota = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.acta = New System.Windows.Forms.NumericUpDown()
		Me.libro = New System.Windows.Forms.NumericUpDown()
		Me.per_id = New System.Windows.Forms.TextBox()
		Me.bs_acta = New System.Windows.Forms.BindingSource(Me.components)
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.del_acta = New System.Windows.Forms.Button()
		Me.edit_acta = New System.Windows.Forms.Button()
		Me.menu1.SuspendLayout()
		CType(Me.consulta_acta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.acta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.libro, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_acta, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'subtitulo
		'
		Me.subtitulo.BackColor = System.Drawing.Color.White
		Me.subtitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.subtitulo.Font = New System.Drawing.Font("PF DinText Pro", 13.0!, System.Drawing.FontStyle.Bold)
		Me.subtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.subtitulo.Location = New System.Drawing.Point(0, 33)
		Me.subtitulo.Margin = New System.Windows.Forms.Padding(0)
		Me.subtitulo.Name = "subtitulo"
		Me.subtitulo.Size = New System.Drawing.Size(470, 27)
		Me.subtitulo.TabIndex = 372
		Me.subtitulo.Text = " MODIFICAR ACTAS"
		Me.subtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'menu1
		'
		Me.menu1.BackColor = System.Drawing.Color.DimGray
		Me.menu1.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.save, Me.PERSONASTitulo, Me.cancel})
		Me.menu1.Location = New System.Drawing.Point(0, 0)
		Me.menu1.Name = "menu1"
		Me.menu1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
		Me.menu1.Size = New System.Drawing.Size(470, 33)
		Me.menu1.TabIndex = 373
		Me.menu1.Text = "top_menu"
		'
		'save
		'
		Me.save.BackColor = System.Drawing.Color.Gray
		Me.save.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.save.ForeColor = System.Drawing.Color.White
		Me.save.Name = "save"
		Me.save.Size = New System.Drawing.Size(117, 27)
		Me.save.Text = "Guardar y Salir"
		'
		'PERSONASTitulo
		'
		Me.PERSONASTitulo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.PERSONASTitulo.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold)
		Me.PERSONASTitulo.ForeColor = System.Drawing.Color.White
		Me.PERSONASTitulo.Name = "PERSONASTitulo"
		Me.PERSONASTitulo.Size = New System.Drawing.Size(112, 27)
		Me.PERSONASTitulo.Text = "PERSONAS"
		'
		'cancel
		'
		Me.cancel.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.cancel.ForeColor = System.Drawing.Color.White
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(77, 27)
		Me.cancel.Text = "Cancelar"
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.BackColor = System.Drawing.Color.Transparent
		Me.Label20.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
		Me.Label20.ForeColor = System.Drawing.Color.Black
		Me.Label20.Location = New System.Drawing.Point(14, 79)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(56, 24)
		Me.Label20.TabIndex = 389
		Me.Label20.Text = "Fecha"
		'
		'fecha_acta
		'
		Me.fecha_acta.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
		Me.fecha_acta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.fecha_acta.Location = New System.Drawing.Point(76, 75)
		Me.fecha_acta.MaxDate = New Date(2090, 12, 31, 0, 0, 0, 0)
		Me.fecha_acta.Name = "fecha_acta"
		Me.fecha_acta.Size = New System.Drawing.Size(136, 31)
		Me.fecha_acta.TabIndex = 388
		'
		'cargar_copia_acta
		'
		Me.cargar_copia_acta.BackColor = System.Drawing.Color.Transparent
		Me.cargar_copia_acta.BackgroundImage = Global.Sigm.My.Resources.Resources.abrir
		Me.cargar_copia_acta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.cargar_copia_acta.FlatAppearance.BorderSize = 0
		Me.cargar_copia_acta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cargar_copia_acta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
		Me.cargar_copia_acta.Location = New System.Drawing.Point(415, 113)
		Me.cargar_copia_acta.Margin = New System.Windows.Forms.Padding(0)
		Me.cargar_copia_acta.Name = "cargar_copia_acta"
		Me.cargar_copia_acta.Size = New System.Drawing.Size(32, 32)
		Me.cargar_copia_acta.TabIndex = 384
		Me.cargar_copia_acta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.cargar_copia_acta.UseVisualStyleBackColor = False
		'
		'copia
		'
		Me.copia.BackColor = System.Drawing.SystemColors.Info
		Me.copia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.copia.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
		Me.copia.Cursor = System.Windows.Forms.Cursors.Hand
		Me.copia.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.copia.Location = New System.Drawing.Point(76, 113)
		Me.copia.MaxLength = 256
		Me.copia.Name = "copia"
		Me.copia.ReadOnly = True
		Me.copia.Size = New System.Drawing.Size(331, 30)
		Me.copia.TabIndex = 382
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Location = New System.Drawing.Point(19, 117)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(53, 24)
		Me.Label5.TabIndex = 381
		Me.Label5.Text = "Copia"
		'
		'add_acta
		'
		Me.add_acta.AutoSize = True
		Me.add_acta.BackColor = System.Drawing.Color.DimGray
		Me.add_acta.FlatAppearance.BorderSize = 0
		Me.add_acta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.add_acta.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.add_acta.ForeColor = System.Drawing.Color.White
		Me.add_acta.Location = New System.Drawing.Point(277, 260)
		Me.add_acta.Name = "add_acta"
		Me.add_acta.Size = New System.Drawing.Size(130, 32)
		Me.add_acta.TabIndex = 380
		Me.add_acta.Text = "AGREGAR"
		Me.add_acta.UseVisualStyleBackColor = False
		'
		'consulta_acta
		'
		Me.consulta_acta.AllowUserToAddRows = False
		Me.consulta_acta.AllowUserToDeleteRows = False
		Me.consulta_acta.AllowUserToResizeRows = False
		Me.consulta_acta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.consulta_acta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.consulta_acta.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.consulta_acta.Location = New System.Drawing.Point(0, 300)
		Me.consulta_acta.Name = "consulta_acta"
		Me.consulta_acta.ReadOnly = True
		Me.consulta_acta.RowHeadersVisible = False
		Me.consulta_acta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.consulta_acta.Size = New System.Drawing.Size(470, 216)
		Me.consulta_acta.TabIndex = 379
		'
		'nota
		'
		Me.nota.BackColor = System.Drawing.SystemColors.Window
		Me.nota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.nota.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nota.Location = New System.Drawing.Point(76, 151)
		Me.nota.MaxLength = 199
		Me.nota.Multiline = True
		Me.nota.Name = "nota"
		Me.nota.Size = New System.Drawing.Size(331, 104)
		Me.nota.TabIndex = 378
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.BackColor = System.Drawing.Color.Transparent
		Me.Label15.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
		Me.Label15.ForeColor = System.Drawing.Color.Black
		Me.Label15.Location = New System.Drawing.Point(24, 154)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(47, 24)
		Me.Label15.TabIndex = 377
		Me.Label15.Text = "Nota"
		'
		'Label12
		'
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
		Me.Label12.ForeColor = System.Drawing.Color.Black
		Me.Label12.Location = New System.Drawing.Point(360, 75)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(52, 31)
		Me.Label12.TabIndex = 376
		Me.Label12.Text = "Libro"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label13
		'
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
		Me.Label13.ForeColor = System.Drawing.Color.Black
		Me.Label13.Location = New System.Drawing.Point(218, 75)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(74, 31)
		Me.Label13.TabIndex = 375
		Me.Label13.Text = "N° Acta"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'acta
		'
		Me.acta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.acta.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
		Me.acta.Location = New System.Drawing.Point(276, 75)
		Me.acta.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.acta.Name = "acta"
		Me.acta.Size = New System.Drawing.Size(68, 31)
		Me.acta.TabIndex = 386
		Me.acta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.acta.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'libro
		'
		Me.libro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.libro.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
		Me.libro.Location = New System.Drawing.Point(396, 75)
		Me.libro.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.libro.Name = "libro"
		Me.libro.Size = New System.Drawing.Size(68, 31)
		Me.libro.TabIndex = 387
		Me.libro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.libro.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'per_id
		'
		Me.per_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.per_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.per_id.Location = New System.Drawing.Point(413, 228)
		Me.per_id.MaxLength = 128
		Me.per_id.Name = "per_id"
		Me.per_id.ReadOnly = True
		Me.per_id.Size = New System.Drawing.Size(25, 27)
		Me.per_id.TabIndex = 390
		Me.per_id.Text = "0"
		Me.per_id.Visible = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Gray
		Me.Panel1.Controls.Add(Me.del_acta)
		Me.Panel1.Controls.Add(Me.edit_acta)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(0, 516)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(470, 36)
		Me.Panel1.TabIndex = 391
		'
		'del_acta
		'
		Me.del_acta.AutoSize = True
		Me.del_acta.BackColor = System.Drawing.Color.Transparent
		Me.del_acta.FlatAppearance.BorderSize = 0
		Me.del_acta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.del_acta.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.del_acta.ForeColor = System.Drawing.Color.White
		Me.del_acta.Location = New System.Drawing.Point(396, 0)
		Me.del_acta.Name = "del_acta"
		Me.del_acta.Size = New System.Drawing.Size(104, 36)
		Me.del_acta.TabIndex = 385
		Me.del_acta.Text = "ELIMINAR"
		Me.del_acta.UseVisualStyleBackColor = False
		'
		'edit_acta
		'
		Me.edit_acta.AutoSize = True
		Me.edit_acta.BackColor = System.Drawing.Color.Transparent
		Me.edit_acta.FlatAppearance.BorderSize = 0
		Me.edit_acta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.edit_acta.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.edit_acta.ForeColor = System.Drawing.Color.White
		Me.edit_acta.Location = New System.Drawing.Point(279, 0)
		Me.edit_acta.Name = "edit_acta"
		Me.edit_acta.Size = New System.Drawing.Size(111, 36)
		Me.edit_acta.TabIndex = 384
		Me.edit_acta.Text = "MODIFICAR"
		Me.edit_acta.UseVisualStyleBackColor = False
		'
		'ModActa
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(470, 552)
		Me.Controls.Add(Me.consulta_acta)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.per_id)
		Me.Controls.Add(Me.Label20)
		Me.Controls.Add(Me.fecha_acta)
		Me.Controls.Add(Me.cargar_copia_acta)
		Me.Controls.Add(Me.copia)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.add_acta)
		Me.Controls.Add(Me.nota)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.acta)
		Me.Controls.Add(Me.libro)
		Me.Controls.Add(Me.subtitulo)
		Me.Controls.Add(Me.menu1)
		Me.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "ModActa"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "INMUEBLE"
		Me.menu1.ResumeLayout(False)
		Me.menu1.PerformLayout()
		CType(Me.consulta_acta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.acta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.libro, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_acta, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents subtitulo As System.Windows.Forms.Label
    Friend WithEvents menu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PERSONASTitulo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents fecha_acta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cargar_copia_acta As System.Windows.Forms.Button
    Friend WithEvents copia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents add_acta As System.Windows.Forms.Button
    Friend WithEvents consulta_acta As System.Windows.Forms.DataGridView
    Friend WithEvents nota As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents acta As System.Windows.Forms.NumericUpDown
    Friend WithEvents libro As System.Windows.Forms.NumericUpDown
    Friend WithEvents per_id As System.Windows.Forms.TextBox
    Friend WithEvents bs_acta As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents del_acta As System.Windows.Forms.Button
    Friend WithEvents edit_acta As System.Windows.Forms.Button
End Class
