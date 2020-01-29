<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.bs_consulta = New System.Windows.Forms.BindingSource(Me.components)
        Me.visor = New System.Windows.Forms.DataGridView()
        Me.grupo_busqueda = New System.Windows.Forms.FlowLayoutPanel()
        Me.filtro = New System.Windows.Forms.ComboBox()
        Me.KeyRazon = New System.Windows.Forms.TextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.reiniciar = New System.Windows.Forms.Button()
        Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.ver = New System.Windows.Forms.Button()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_busqueda.SuspendLayout()
        Me.grupo_mod.SuspendLayout()
        Me.SuspendLayout()
        '
        'bs_consulta
        '
        '
        'visor
        '
        Me.visor.AllowUserToAddRows = False
        Me.visor.AllowUserToDeleteRows = False
        Me.visor.AllowUserToResizeRows = False
        Me.visor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor.Location = New System.Drawing.Point(0, 40)
        Me.visor.Margin = New System.Windows.Forms.Padding(2)
        Me.visor.MultiSelect = False
        Me.visor.Name = "visor"
        Me.visor.ReadOnly = True
        Me.visor.RowHeadersVisible = False
        Me.visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.visor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visor.Size = New System.Drawing.Size(600, 320)
        Me.visor.TabIndex = 337
        '
        'grupo_busqueda
        '
        Me.grupo_busqueda.BackColor = System.Drawing.Color.DimGray
        Me.grupo_busqueda.Controls.Add(Me.filtro)
        Me.grupo_busqueda.Controls.Add(Me.KeyRazon)
        Me.grupo_busqueda.Controls.Add(Me.buscar)
        Me.grupo_busqueda.Controls.Add(Me.reiniciar)
        Me.grupo_busqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_busqueda.Location = New System.Drawing.Point(0, 0)
        Me.grupo_busqueda.Name = "grupo_busqueda"
        Me.grupo_busqueda.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.grupo_busqueda.Size = New System.Drawing.Size(600, 40)
        Me.grupo_busqueda.TabIndex = 338
        '
        'filtro
        '
        Me.filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filtro.FormattingEnabled = True
        Me.filtro.Items.AddRange(New Object() {"CODIGO", "RAZON SOCIAL", "CUIL / DNI"})
        Me.filtro.Location = New System.Drawing.Point(8, 7)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(151, 27)
        Me.filtro.TabIndex = 336
        '
        'KeyRazon
        '
        Me.KeyRazon.BackColor = System.Drawing.SystemColors.Window
        Me.KeyRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.KeyRazon.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.KeyRazon.Location = New System.Drawing.Point(165, 7)
        Me.KeyRazon.Name = "KeyRazon"
        Me.KeyRazon.Size = New System.Drawing.Size(158, 27)
        Me.KeyRazon.TabIndex = 337
        Me.KeyRazon.Visible = False
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.buscar.FlatAppearance.BorderSize = 0
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.ForeColor = System.Drawing.Color.White
        Me.buscar.Location = New System.Drawing.Point(329, 7)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(83, 26)
        Me.buscar.TabIndex = 338
        Me.buscar.Text = "BUSCAR"
        Me.buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.buscar.UseVisualStyleBackColor = False
        '
        'reiniciar
        '
        Me.reiniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.reiniciar.FlatAppearance.BorderSize = 0
        Me.reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reiniciar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reiniciar.ForeColor = System.Drawing.Color.White
        Me.reiniciar.Location = New System.Drawing.Point(418, 7)
        Me.reiniciar.Name = "reiniciar"
        Me.reiniciar.Size = New System.Drawing.Size(96, 26)
        Me.reiniciar.TabIndex = 339
        Me.reiniciar.Text = "REINICIAR"
        Me.reiniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.reiniciar.UseVisualStyleBackColor = False
        '
        'grupo_mod
        '
        Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
        Me.grupo_mod.Controls.Add(Me.eliminar)
        Me.grupo_mod.Controls.Add(Me.modificar)
        Me.grupo_mod.Controls.Add(Me.ver)
        Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupo_mod.Enabled = False
        Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.grupo_mod.Location = New System.Drawing.Point(0, 360)
        Me.grupo_mod.Name = "grupo_mod"
        Me.grupo_mod.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.grupo_mod.Size = New System.Drawing.Size(600, 40)
        Me.grupo_mod.TabIndex = 339
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.eliminar.FlatAppearance.BorderSize = 0
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.eliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.eliminar.Location = New System.Drawing.Point(496, 7)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(96, 26)
        Me.eliminar.TabIndex = 345
        Me.eliminar.Text = "ELIMINAR"
        Me.eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.modificar.FlatAppearance.BorderSize = 0
        Me.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.modificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.modificar.Location = New System.Drawing.Point(393, 7)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(97, 26)
        Me.modificar.TabIndex = 344
        Me.modificar.Text = "MODIFICAR"
        Me.modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.modificar.UseVisualStyleBackColor = False
        '
        'ver
        '
        Me.ver.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.ver.FlatAppearance.BorderSize = 0
        Me.ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ver.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.ver.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ver.Location = New System.Drawing.Point(298, 7)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(89, 26)
        Me.ver.TabIndex = 346
        Me.ver.Text = "IMPRIMIR"
        Me.ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ver.UseVisualStyleBackColor = False
        '
        'ConsultaEmpleado
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.grupo_mod)
        Me.Controls.Add(Me.grupo_busqueda)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "ConsultaEmpleado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_busqueda.ResumeLayout(False)
        Me.grupo_busqueda.PerformLayout()
        Me.grupo_mod.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bs_consulta As System.Windows.Forms.BindingSource
    Friend WithEvents visor As System.Windows.Forms.DataGridView
    Friend WithEvents grupo_busqueda As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents filtro As System.Windows.Forms.ComboBox
    Friend WithEvents KeyRazon As System.Windows.Forms.TextBox
    Friend WithEvents buscar As System.Windows.Forms.Button
    Friend WithEvents reiniciar As System.Windows.Forms.Button
    Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents ver As System.Windows.Forms.Button
End Class
