<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaPersona
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.menu1 = New System.Windows.Forms.MenuStrip()
        Me.Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.grupo_buscar = New System.Windows.Forms.Panel()
        Me.visor = New System.Windows.Forms.DataGridView()
        Me.bs_consulta = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.reset = New System.Windows.Forms.Button()
        Me.keyword = New System.Windows.Forms.TextBox()
        Me.filtros = New System.Windows.Forms.FlowLayoutPanel()
        Me.filtro1 = New System.Windows.Forms.ComboBox()
        Me.difunto = New System.Windows.Forms.CheckBox()
        Me.fisica = New System.Windows.Forms.CheckBox()
        Me.NuevaPersona = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.menu1.SuspendLayout()
        Me.grupo_buscar.SuspendLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu1
        '
        Me.menu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.menu1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cerrar})
        Me.menu1.Location = New System.Drawing.Point(0, 0)
        Me.menu1.Name = "menu1"
        Me.menu1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.menu1.Size = New System.Drawing.Size(1024, 29)
        Me.menu1.TabIndex = 196
        Me.menu1.Text = "top_menu"
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Cerrar.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrar.ForeColor = System.Drawing.Color.White
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(153, 23)
        Me.Cerrar.Text = "Seleccionar y Volver"
        '
        'grupo_buscar
        '
        Me.grupo_buscar.BackColor = System.Drawing.Color.Silver
        Me.grupo_buscar.Controls.Add(Me.visor)
        Me.grupo_buscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupo_buscar.Location = New System.Drawing.Point(0, 29)
        Me.grupo_buscar.Name = "grupo_buscar"
        Me.grupo_buscar.Size = New System.Drawing.Size(1024, 418)
        Me.grupo_buscar.TabIndex = 198
        '
        'visor
        '
        Me.visor.AllowUserToAddRows = False
        Me.visor.AllowUserToDeleteRows = False
        Me.visor.AllowUserToResizeRows = False
        Me.visor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor.Location = New System.Drawing.Point(0, 0)
        Me.visor.Margin = New System.Windows.Forms.Padding(2)
        Me.visor.MultiSelect = False
        Me.visor.Name = "visor"
        Me.visor.ReadOnly = True
        Me.visor.RowHeadersVisible = False
        Me.visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.visor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visor.Size = New System.Drawing.Size(1024, 418)
        Me.visor.TabIndex = 322
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.reset)
        Me.FlowLayoutPanel1.Controls.Add(Me.keyword)
        Me.FlowLayoutPanel1.Controls.Add(Me.filtros)
        Me.FlowLayoutPanel1.Controls.Add(Me.NuevaPersona)
        Me.FlowLayoutPanel1.Controls.Add(Me.edit)
        Me.FlowLayoutPanel1.Controls.Add(Me.delete)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 447)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1024, 33)
        Me.FlowLayoutPanel1.TabIndex = 337
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.reset.FlatAppearance.BorderSize = 0
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.Location = New System.Drawing.Point(5, 3)
        Me.reset.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(96, 26)
        Me.reset.TabIndex = 342
        Me.reset.Text = "REINICIAR"
        Me.reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.reset.UseVisualStyleBackColor = False
        '
        'keyword
        '
        Me.keyword.BackColor = System.Drawing.SystemColors.Window
        Me.keyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.keyword.Dock = System.Windows.Forms.DockStyle.Left
        Me.keyword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.keyword.Location = New System.Drawing.Point(107, 3)
        Me.keyword.Name = "keyword"
        Me.keyword.Size = New System.Drawing.Size(208, 27)
        Me.keyword.TabIndex = 337
        Me.keyword.Text = "BUSCAR.."
        '
        'filtros
        '
        Me.filtros.BackColor = System.Drawing.Color.Gray
        Me.filtros.Controls.Add(Me.filtro1)
        Me.filtros.Controls.Add(Me.difunto)
        Me.filtros.Controls.Add(Me.fisica)
        Me.filtros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.filtros.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.filtros.Location = New System.Drawing.Point(318, 0)
        Me.filtros.Margin = New System.Windows.Forms.Padding(0)
        Me.filtros.Name = "filtros"
        Me.filtros.Size = New System.Drawing.Size(395, 32)
        Me.filtros.TabIndex = 349
        '
        'filtro1
        '
        Me.filtro1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.filtro1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.filtro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filtro1.FormattingEnabled = True
        Me.filtro1.Items.AddRange(New Object() {"PERSONA", "DIRECCION", "PROFESIONAL", "PROVEEDOR"})
        Me.filtro1.Location = New System.Drawing.Point(3, 3)
        Me.filtro1.Name = "filtro1"
        Me.filtro1.Size = New System.Drawing.Size(233, 27)
        Me.filtro1.TabIndex = 353
        '
        'difunto
        '
        Me.difunto.AutoSize = True
        Me.difunto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.difunto.ForeColor = System.Drawing.Color.White
        Me.difunto.Location = New System.Drawing.Point(242, 6)
        Me.difunto.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.difunto.Name = "difunto"
        Me.difunto.Size = New System.Drawing.Size(76, 24)
        Me.difunto.TabIndex = 354
        Me.difunto.Text = "Difunto"
        Me.difunto.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.difunto.UseVisualStyleBackColor = True
        '
        'fisica
        '
        Me.fisica.AutoSize = True
        Me.fisica.Checked = True
        Me.fisica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fisica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fisica.ForeColor = System.Drawing.Color.White
        Me.fisica.Location = New System.Drawing.Point(324, 6)
        Me.fisica.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.fisica.Name = "fisica"
        Me.fisica.Size = New System.Drawing.Size(66, 24)
        Me.fisica.TabIndex = 355
        Me.fisica.Text = "Fisica"
        Me.fisica.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.fisica.UseVisualStyleBackColor = True
        '
        'NuevaPersona
        '
        Me.NuevaPersona.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.NuevaPersona.FlatAppearance.BorderSize = 0
        Me.NuevaPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NuevaPersona.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.NuevaPersona.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NuevaPersona.Location = New System.Drawing.Point(716, 3)
        Me.NuevaPersona.Name = "NuevaPersona"
        Me.NuevaPersona.Size = New System.Drawing.Size(97, 26)
        Me.NuevaPersona.TabIndex = 345
        Me.NuevaPersona.Text = "NUEVA"
        Me.NuevaPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NuevaPersona.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.edit.FlatAppearance.BorderSize = 0
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.edit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.edit.Location = New System.Drawing.Point(819, 3)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(97, 26)
        Me.edit.TabIndex = 340
        Me.edit.Text = "MODIFICAR"
        Me.edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.edit.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.delete.FlatAppearance.BorderSize = 0
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.delete.Location = New System.Drawing.Point(922, 3)
        Me.delete.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(97, 26)
        Me.delete.TabIndex = 341
        Me.delete.Text = "ELIMINAR"
        Me.delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.delete.UseVisualStyleBackColor = False
        '
        'ConsultaPersona
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1024, 480)
        Me.Controls.Add(Me.grupo_buscar)
        Me.Controls.Add(Me.menu1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ConsultaPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGM"
        Me.menu1.ResumeLayout(False)
        Me.menu1.PerformLayout()
        Me.grupo_buscar.ResumeLayout(False)
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.filtros.ResumeLayout(False)
        Me.filtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Cerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grupo_buscar As System.Windows.Forms.Panel
    Friend WithEvents visor As System.Windows.Forms.DataGridView
    Friend WithEvents bs_consulta As System.Windows.Forms.BindingSource
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents keyword As System.Windows.Forms.TextBox
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents filtros As FlowLayoutPanel
    Friend WithEvents filtro1 As ComboBox
    Friend WithEvents difunto As CheckBox
    Friend WithEvents fisica As CheckBox
    Friend WithEvents NuevaPersona As Button
End Class
