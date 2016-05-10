<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComparadorTablas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComparadorTablas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.resultados = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bs_alfa = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_beta = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.conexion = New System.Windows.Forms.TextBox()
        Me.access = New System.Windows.Forms.RadioButton()
        Me.fox = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bs_result = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.visor_beta = New System.Windows.Forms.DataGridView()
        Me.ruta_beta = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.visor_alfa = New System.Windows.Forms.DataGridView()
        Me.ruta_alfa = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_busqueda = New System.Windows.Forms.Panel()
        Me.par3 = New System.Windows.Forms.RadioButton()
        Me.par2 = New System.Windows.Forms.RadioButton()
        Me.par1 = New System.Windows.Forms.RadioButton()
        Me.campo3b = New System.Windows.Forms.ComboBox()
        Me.campo2b = New System.Windows.Forms.ComboBox()
        Me.campo1b = New System.Windows.Forms.ComboBox()
        Me.claveb = New System.Windows.Forms.ComboBox()
        Me.campo3a = New System.Windows.Forms.ComboBox()
        Me.campo2a = New System.Windows.Forms.ComboBox()
        Me.campo1a = New System.Windows.Forms.ComboBox()
        Me.clavea = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.reiniciar = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        Me.diff = New System.Windows.Forms.RadioButton()
        Me.igual = New System.Windows.Forms.RadioButton()
        Me.Panel2.SuspendLayout()
        CType(Me.resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_alfa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_beta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.bs_result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.visor_beta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visor_alfa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_busqueda.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.resultados)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 260)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 101)
        Me.Panel2.TabIndex = 14
        '
        'resultados
        '
        Me.resultados.AllowUserToAddRows = False
        Me.resultados.AllowUserToDeleteRows = False
        Me.resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultados.Location = New System.Drawing.Point(0, 24)
        Me.resultados.Name = "resultados"
        Me.resultados.ReadOnly = True
        Me.resultados.RowHeadersVisible = False
        Me.resultados.Size = New System.Drawing.Size(584, 77)
        Me.resultados.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(584, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RESULTADOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bs_alfa
        '
        '
        'bs_beta
        '
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.conexion)
        Me.Panel6.Controls.Add(Me.access)
        Me.Panel6.Controls.Add(Me.fox)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(584, 23)
        Me.Panel6.TabIndex = 19
        '
        'conexion
        '
        Me.conexion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.conexion.Location = New System.Drawing.Point(219, 0)
        Me.conexion.Name = "conexion"
        Me.conexion.Size = New System.Drawing.Size(365, 23)
        Me.conexion.TabIndex = 16
        '
        'access
        '
        Me.access.AutoSize = True
        Me.access.Checked = True
        Me.access.Dock = System.Windows.Forms.DockStyle.Left
        Me.access.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
        Me.access.Location = New System.Drawing.Point(152, 0)
        Me.access.Name = "access"
        Me.access.Size = New System.Drawing.Size(67, 23)
        Me.access.TabIndex = 12
        Me.access.TabStop = True
        Me.access.Text = "Access"
        Me.access.UseVisualStyleBackColor = True
        '
        'fox
        '
        Me.fox.AutoSize = True
        Me.fox.Dock = System.Windows.Forms.DockStyle.Left
        Me.fox.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
        Me.fox.Location = New System.Drawing.Point(106, 0)
        Me.fox.Name = "fox"
        Me.fox.Size = New System.Drawing.Size(46, 23)
        Me.fox.TabIndex = 13
        Me.fox.Text = "Fox"
        Me.fox.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 23)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Tipo de conexión:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.panel_busqueda)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 237)
        Me.Panel1.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.visor_beta)
        Me.Panel3.Controls.Add(Me.ruta_beta)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.visor_alfa)
        Me.Panel3.Controls.Add(Me.ruta_alfa)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 237)
        Me.Panel3.TabIndex = 16
        '
        'visor_beta
        '
        Me.visor_beta.AllowUserToAddRows = False
        Me.visor_beta.AllowUserToDeleteRows = False
        Me.visor_beta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visor_beta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor_beta.Location = New System.Drawing.Point(0, 162)
        Me.visor_beta.Name = "visor_beta"
        Me.visor_beta.ReadOnly = True
        Me.visor_beta.RowHeadersVisible = False
        Me.visor_beta.Size = New System.Drawing.Size(201, 75)
        Me.visor_beta.TabIndex = 20
        '
        'ruta_beta
        '
        Me.ruta_beta.Dock = System.Windows.Forms.DockStyle.Top
        Me.ruta_beta.Location = New System.Drawing.Point(0, 142)
        Me.ruta_beta.Name = "ruta_beta"
        Me.ruta_beta.Size = New System.Drawing.Size(201, 20)
        Me.ruta_beta.TabIndex = 19
        Me.ruta_beta.TabStop = True
        Me.ruta_beta.Text = "Click para agregar tabla."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "TABLA 2"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'visor_alfa
        '
        Me.visor_alfa.AllowUserToAddRows = False
        Me.visor_alfa.AllowUserToDeleteRows = False
        Me.visor_alfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visor_alfa.Dock = System.Windows.Forms.DockStyle.Top
        Me.visor_alfa.Location = New System.Drawing.Point(0, 44)
        Me.visor_alfa.Name = "visor_alfa"
        Me.visor_alfa.ReadOnly = True
        Me.visor_alfa.RowHeadersVisible = False
        Me.visor_alfa.Size = New System.Drawing.Size(201, 74)
        Me.visor_alfa.TabIndex = 17
        '
        'ruta_alfa
        '
        Me.ruta_alfa.Dock = System.Windows.Forms.DockStyle.Top
        Me.ruta_alfa.Location = New System.Drawing.Point(0, 24)
        Me.ruta_alfa.Name = "ruta_alfa"
        Me.ruta_alfa.Size = New System.Drawing.Size(201, 20)
        Me.ruta_alfa.TabIndex = 16
        Me.ruta_alfa.TabStop = True
        Me.ruta_alfa.Text = "Click para agregar tabla."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TABLA 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_busqueda
        '
        Me.panel_busqueda.BackColor = System.Drawing.Color.LightGray
        Me.panel_busqueda.Controls.Add(Me.par3)
        Me.panel_busqueda.Controls.Add(Me.par2)
        Me.panel_busqueda.Controls.Add(Me.par1)
        Me.panel_busqueda.Controls.Add(Me.campo3b)
        Me.panel_busqueda.Controls.Add(Me.campo2b)
        Me.panel_busqueda.Controls.Add(Me.campo1b)
        Me.panel_busqueda.Controls.Add(Me.claveb)
        Me.panel_busqueda.Controls.Add(Me.campo3a)
        Me.panel_busqueda.Controls.Add(Me.campo2a)
        Me.panel_busqueda.Controls.Add(Me.campo1a)
        Me.panel_busqueda.Controls.Add(Me.clavea)
        Me.panel_busqueda.Controls.Add(Me.Label12)
        Me.panel_busqueda.Controls.Add(Me.Label11)
        Me.panel_busqueda.Controls.Add(Me.Label6)
        Me.panel_busqueda.Controls.Add(Me.Label5)
        Me.panel_busqueda.Controls.Add(Me.Panel5)
        Me.panel_busqueda.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_busqueda.Location = New System.Drawing.Point(201, 0)
        Me.panel_busqueda.Name = "panel_busqueda"
        Me.panel_busqueda.Size = New System.Drawing.Size(383, 237)
        Me.panel_busqueda.TabIndex = 17
        '
        'par3
        '
        Me.par3.AutoSize = True
        Me.par3.Location = New System.Drawing.Point(6, 132)
        Me.par3.Name = "par3"
        Me.par3.Size = New System.Drawing.Size(86, 20)
        Me.par3.TabIndex = 2
        Me.par3.Text = "Columna 3"
        Me.par3.UseVisualStyleBackColor = True
        '
        'par2
        '
        Me.par2.AutoSize = True
        Me.par2.Location = New System.Drawing.Point(6, 104)
        Me.par2.Name = "par2"
        Me.par2.Size = New System.Drawing.Size(86, 20)
        Me.par2.TabIndex = 1
        Me.par2.Text = "Columna 2"
        Me.par2.UseVisualStyleBackColor = True
        '
        'par1
        '
        Me.par1.AutoSize = True
        Me.par1.Checked = True
        Me.par1.Location = New System.Drawing.Point(6, 76)
        Me.par1.Name = "par1"
        Me.par1.Size = New System.Drawing.Size(86, 20)
        Me.par1.TabIndex = 0
        Me.par1.TabStop = True
        Me.par1.Text = "Columna 1"
        Me.par1.UseVisualStyleBackColor = True
        '
        'campo3b
        '
        Me.campo3b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.campo3b.Enabled = False
        Me.campo3b.FormattingEnabled = True
        Me.campo3b.Location = New System.Drawing.Point(243, 132)
        Me.campo3b.Name = "campo3b"
        Me.campo3b.Size = New System.Drawing.Size(130, 23)
        Me.campo3b.TabIndex = 21
        '
        'campo2b
        '
        Me.campo2b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.campo2b.Enabled = False
        Me.campo2b.FormattingEnabled = True
        Me.campo2b.Location = New System.Drawing.Point(243, 104)
        Me.campo2b.Name = "campo2b"
        Me.campo2b.Size = New System.Drawing.Size(130, 23)
        Me.campo2b.TabIndex = 20
        '
        'campo1b
        '
        Me.campo1b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.campo1b.FormattingEnabled = True
        Me.campo1b.Location = New System.Drawing.Point(243, 76)
        Me.campo1b.Name = "campo1b"
        Me.campo1b.Size = New System.Drawing.Size(130, 23)
        Me.campo1b.TabIndex = 19
        '
        'claveb
        '
        Me.claveb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.claveb.FormattingEnabled = True
        Me.claveb.Location = New System.Drawing.Point(243, 48)
        Me.claveb.Name = "claveb"
        Me.claveb.Size = New System.Drawing.Size(130, 23)
        Me.claveb.TabIndex = 18
        '
        'campo3a
        '
        Me.campo3a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.campo3a.Enabled = False
        Me.campo3a.FormattingEnabled = True
        Me.campo3a.Location = New System.Drawing.Point(100, 132)
        Me.campo3a.Name = "campo3a"
        Me.campo3a.Size = New System.Drawing.Size(130, 23)
        Me.campo3a.TabIndex = 17
        '
        'campo2a
        '
        Me.campo2a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.campo2a.Enabled = False
        Me.campo2a.FormattingEnabled = True
        Me.campo2a.Location = New System.Drawing.Point(100, 104)
        Me.campo2a.Name = "campo2a"
        Me.campo2a.Size = New System.Drawing.Size(130, 23)
        Me.campo2a.TabIndex = 15
        '
        'campo1a
        '
        Me.campo1a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.campo1a.FormattingEnabled = True
        Me.campo1a.Location = New System.Drawing.Point(100, 76)
        Me.campo1a.Name = "campo1a"
        Me.campo1a.Size = New System.Drawing.Size(130, 23)
        Me.campo1a.TabIndex = 14
        '
        'clavea
        '
        Me.clavea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.clavea.FormattingEnabled = True
        Me.clavea.Location = New System.Drawing.Point(100, 48)
        Me.clavea.Name = "clavea"
        Me.clavea.Size = New System.Drawing.Size(130, 23)
        Me.clavea.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(283, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Tabla 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(140, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tabla 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(26, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Clave"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CRITERIOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.reiniciar)
        Me.Panel5.Controls.Add(Me.buscar)
        Me.Panel5.Controls.Add(Me.diff)
        Me.Panel5.Controls.Add(Me.igual)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 172)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(383, 65)
        Me.Panel5.TabIndex = 26
        '
        'reiniciar
        '
        Me.reiniciar.BackColor = System.Drawing.Color.DimGray
        Me.reiniciar.FlatAppearance.BorderSize = 0
        Me.reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reiniciar.ForeColor = System.Drawing.Color.White
        Me.reiniciar.Location = New System.Drawing.Point(183, 17)
        Me.reiniciar.Name = "reiniciar"
        Me.reiniciar.Size = New System.Drawing.Size(90, 23)
        Me.reiniciar.TabIndex = 27
        Me.reiniciar.Text = "REINICIAR"
        Me.reiniciar.UseVisualStyleBackColor = False
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.Color.DimGray
        Me.buscar.FlatAppearance.BorderSize = 0
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.ForeColor = System.Drawing.Color.White
        Me.buscar.Location = New System.Drawing.Point(282, 17)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(90, 23)
        Me.buscar.TabIndex = 26
        Me.buscar.Text = "BUSCAR"
        Me.buscar.UseVisualStyleBackColor = False
        '
        'diff
        '
        Me.diff.AutoSize = True
        Me.diff.Location = New System.Drawing.Point(17, 34)
        Me.diff.Name = "diff"
        Me.diff.Size = New System.Drawing.Size(132, 20)
        Me.diff.TabIndex = 2
        Me.diff.Text = "Buscar diferencias"
        Me.diff.UseVisualStyleBackColor = True
        '
        'igual
        '
        Me.igual.AutoSize = True
        Me.igual.Checked = True
        Me.igual.Location = New System.Drawing.Point(17, 8)
        Me.igual.Name = "igual"
        Me.igual.Size = New System.Drawing.Size(145, 20)
        Me.igual.TabIndex = 1
        Me.igual.TabStop = True
        Me.igual.Text = "Buscar coincidencias"
        Me.igual.UseVisualStyleBackColor = True
        '
        'ComparadorTablas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "ComparadorTablas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comparador Tablas"
        Me.Panel2.ResumeLayout(False)
        CType(Me.resultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_alfa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_beta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.bs_result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.visor_beta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visor_alfa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_busqueda.ResumeLayout(False)
        Me.panel_busqueda.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents resultados As System.Windows.Forms.DataGridView
    Friend WithEvents bs_alfa As System.Windows.Forms.BindingSource
    Friend WithEvents bs_beta As System.Windows.Forms.BindingSource
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents conexion As System.Windows.Forms.TextBox
    Friend WithEvents access As System.Windows.Forms.RadioButton
    Friend WithEvents fox As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bs_result As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents visor_beta As System.Windows.Forms.DataGridView
    Friend WithEvents ruta_beta As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents visor_alfa As System.Windows.Forms.DataGridView
    Friend WithEvents ruta_alfa As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panel_busqueda As System.Windows.Forms.Panel
    Friend WithEvents par3 As System.Windows.Forms.RadioButton
    Friend WithEvents par2 As System.Windows.Forms.RadioButton
    Friend WithEvents par1 As System.Windows.Forms.RadioButton
    Friend WithEvents campo3b As System.Windows.Forms.ComboBox
    Friend WithEvents campo2b As System.Windows.Forms.ComboBox
    Friend WithEvents campo1b As System.Windows.Forms.ComboBox
    Friend WithEvents claveb As System.Windows.Forms.ComboBox
    Friend WithEvents campo3a As System.Windows.Forms.ComboBox
    Friend WithEvents campo2a As System.Windows.Forms.ComboBox
    Friend WithEvents campo1a As System.Windows.Forms.ComboBox
    Friend WithEvents clavea As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents reiniciar As System.Windows.Forms.Button
    Friend WithEvents buscar As System.Windows.Forms.Button
    Friend WithEvents diff As System.Windows.Forms.RadioButton
    Friend WithEvents igual As System.Windows.Forms.RadioButton
End Class
