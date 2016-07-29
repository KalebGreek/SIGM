<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultasEspeciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultasEspeciales))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CalculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HaciendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldoDeCuentasBancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDiarioDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompararIngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompararEgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DBFoxMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBPostgreSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Connection = New System.Windows.Forms.ToolStripLabel()
        Me.TablaPersonalizada = New System.Windows.Forms.LinkLabel()
        Me.PanelColumnas = New System.Windows.Forms.Panel()
        Me.ListaColumnas = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelFiltroFecha = New System.Windows.Forms.FlowLayoutPanel()
        Me.SinFiltro = New System.Windows.Forms.RadioButton()
        Me.PorFecha = New System.Windows.Forms.RadioButton()
        Me.inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.final = New System.Windows.Forms.DateTimePicker()
        Me.PorAño = New System.Windows.Forms.RadioButton()
        Me.año = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SelectorCampoFecha = New System.Windows.Forms.ComboBox()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PanelColumnas.SuspendLayout()
        Me.PanelFiltroFecha.SuspendLayout()
        CType(Me.año, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip2.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculosToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(784, 29)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CalculosToolStripMenuItem
        '
        Me.CalculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.HaciendaToolStripMenuItem, Me.IngresosToolStripMenuItem, Me.EgresosToolStripMenuItem, Me.ToolStripSeparator2, Me.BancosToolStripMenuItem, Me.SaldoDeCuentasBancosToolStripMenuItem, Me.ToolStripSeparator3, Me.CajaToolStripMenuItem, Me.CierreDiarioDeCajaToolStripMenuItem, Me.ToolStripSeparator4, Me.OtrosToolStripMenuItem, Me.DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem})
        Me.CalculosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CalculosToolStripMenuItem.Name = "CalculosToolStripMenuItem"
        Me.CalculosToolStripMenuItem.Size = New System.Drawing.Size(61, 25)
        Me.CalculosToolStripMenuItem.Text = "Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(333, 6)
        '
        'HaciendaToolStripMenuItem
        '
        Me.HaciendaToolStripMenuItem.Enabled = False
        Me.HaciendaToolStripMenuItem.Name = "HaciendaToolStripMenuItem"
        Me.HaciendaToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.HaciendaToolStripMenuItem.Text = "Hacienda"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.EgresosToolStripMenuItem.Text = "Egresos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(333, 6)
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Enabled = False
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'SaldoDeCuentasBancosToolStripMenuItem
        '
        Me.SaldoDeCuentasBancosToolStripMenuItem.Name = "SaldoDeCuentasBancosToolStripMenuItem"
        Me.SaldoDeCuentasBancosToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.SaldoDeCuentasBancosToolStripMenuItem.Text = "Saldo de Cuentas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(333, 6)
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Enabled = False
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'CierreDiarioDeCajaToolStripMenuItem
        '
        Me.CierreDiarioDeCajaToolStripMenuItem.Name = "CierreDiarioDeCajaToolStripMenuItem"
        Me.CierreDiarioDeCajaToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.CierreDiarioDeCajaToolStripMenuItem.Text = "Cierre Diario"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(333, 6)
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem
        '
        Me.DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompararIngresosToolStripMenuItem, Me.CompararEgresosToolStripMenuItem})
        Me.DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem.Name = "DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem"
        Me.DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem.Text = "Diferencia entre Caja y Movimientos"
        '
        'CompararIngresosToolStripMenuItem
        '
        Me.CompararIngresosToolStripMenuItem.Name = "CompararIngresosToolStripMenuItem"
        Me.CompararIngresosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CompararIngresosToolStripMenuItem.Text = "Comparar Ingresos"
        '
        'CompararEgresosToolStripMenuItem
        '
        Me.CompararEgresosToolStripMenuItem.Name = "CompararEgresosToolStripMenuItem"
        Me.CompararEgresosToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CompararEgresosToolStripMenuItem.Text = "Comparar Egresos"
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataView.Location = New System.Drawing.Point(0, 0)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.RowHeadersVisible = False
        Me.DataView.Size = New System.Drawing.Size(637, 356)
        Me.DataView.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 356)
        Me.Panel2.TabIndex = 30
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.Connection})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 435)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 26)
        Me.ToolStrip1.TabIndex = 31
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DBFoxMuniciToolStripMenuItem, Me.DBAccessToolStripMenuItem, Me.DBPostgreSQLToolStripMenuItem})
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 12.0!)
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(105, 23)
        Me.ToolStripDropDownButton2.Text = "Conexiones"
        '
        'DBFoxMuniciToolStripMenuItem
        '
        Me.DBFoxMuniciToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DBFoxMuniciToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.DBFoxMuniciToolStripMenuItem.Name = "DBFoxMuniciToolStripMenuItem"
        Me.DBFoxMuniciToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DBFoxMuniciToolStripMenuItem.Text = "DB Fox (Munici)"
        '
        'DBAccessToolStripMenuItem
        '
        Me.DBAccessToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DBAccessToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.DBAccessToolStripMenuItem.Name = "DBAccessToolStripMenuItem"
        Me.DBAccessToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DBAccessToolStripMenuItem.Text = "DB Access"
        '
        'DBPostgreSQLToolStripMenuItem
        '
        Me.DBPostgreSQLToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DBPostgreSQLToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.DBPostgreSQLToolStripMenuItem.Name = "DBPostgreSQLToolStripMenuItem"
        Me.DBPostgreSQLToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DBPostgreSQLToolStripMenuItem.Text = "DB PostgreSQL"
        '
        'Connection
        '
        Me.Connection.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.Connection.Margin = New System.Windows.Forms.Padding(3)
        Me.Connection.Name = "Connection"
        Me.Connection.Size = New System.Drawing.Size(333, 20)
        Me.Connection.Text = "Seleccione una base de datos antes de continuar."
        '
        'TablaPersonalizada
        '
        Me.TablaPersonalizada.ActiveLinkColor = System.Drawing.Color.Blue
        Me.TablaPersonalizada.DisabledLinkColor = System.Drawing.Color.Blue
        Me.TablaPersonalizada.Dock = System.Windows.Forms.DockStyle.Top
        Me.TablaPersonalizada.Location = New System.Drawing.Point(0, 58)
        Me.TablaPersonalizada.Name = "TablaPersonalizada"
        Me.TablaPersonalizada.Size = New System.Drawing.Size(784, 21)
        Me.TablaPersonalizada.TabIndex = 33
        Me.TablaPersonalizada.TabStop = True
        Me.TablaPersonalizada.Text = "Click para agregar tabla."
        Me.TablaPersonalizada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TablaPersonalizada.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'PanelColumnas
        '
        Me.PanelColumnas.Controls.Add(Me.ListaColumnas)
        Me.PanelColumnas.Controls.Add(Me.Label1)
        Me.PanelColumnas.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelColumnas.Location = New System.Drawing.Point(637, 79)
        Me.PanelColumnas.Name = "PanelColumnas"
        Me.PanelColumnas.Size = New System.Drawing.Size(147, 356)
        Me.PanelColumnas.TabIndex = 34
        Me.PanelColumnas.Visible = False
        '
        'ListaColumnas
        '
        Me.ListaColumnas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaColumnas.FormattingEnabled = True
        Me.ListaColumnas.Location = New System.Drawing.Point(0, 22)
        Me.ListaColumnas.Name = "ListaColumnas"
        Me.ListaColumnas.Size = New System.Drawing.Size(147, 334)
        Me.ListaColumnas.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "COLUMNAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelFiltroFecha
        '
        Me.PanelFiltroFecha.BackColor = System.Drawing.Color.Gray
        Me.PanelFiltroFecha.Controls.Add(Me.SinFiltro)
        Me.PanelFiltroFecha.Controls.Add(Me.PorFecha)
        Me.PanelFiltroFecha.Controls.Add(Me.inicio)
        Me.PanelFiltroFecha.Controls.Add(Me.Label2)
        Me.PanelFiltroFecha.Controls.Add(Me.final)
        Me.PanelFiltroFecha.Controls.Add(Me.PorAño)
        Me.PanelFiltroFecha.Controls.Add(Me.año)
        Me.PanelFiltroFecha.Controls.Add(Me.Label3)
        Me.PanelFiltroFecha.Controls.Add(Me.SelectorCampoFecha)
        Me.PanelFiltroFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltroFecha.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
        Me.PanelFiltroFecha.Location = New System.Drawing.Point(0, 29)
        Me.PanelFiltroFecha.Name = "PanelFiltroFecha"
        Me.PanelFiltroFecha.Size = New System.Drawing.Size(784, 29)
        Me.PanelFiltroFecha.TabIndex = 36
        Me.PanelFiltroFecha.Visible = False
        '
        'SinFiltro
        '
        Me.SinFiltro.AutoSize = True
        Me.SinFiltro.BackColor = System.Drawing.Color.Gray
        Me.SinFiltro.Checked = True
        Me.SinFiltro.ForeColor = System.Drawing.Color.White
        Me.SinFiltro.Location = New System.Drawing.Point(5, 3)
        Me.SinFiltro.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.SinFiltro.Name = "SinFiltro"
        Me.SinFiltro.Size = New System.Drawing.Size(44, 22)
        Me.SinFiltro.TabIndex = 40
        Me.SinFiltro.TabStop = True
        Me.SinFiltro.Text = "NO"
        Me.SinFiltro.UseVisualStyleBackColor = False
        '
        'PorFecha
        '
        Me.PorFecha.AutoSize = True
        Me.PorFecha.BackColor = System.Drawing.Color.Gray
        Me.PorFecha.ForeColor = System.Drawing.Color.White
        Me.PorFecha.Location = New System.Drawing.Point(55, 3)
        Me.PorFecha.Name = "PorFecha"
        Me.PorFecha.Size = New System.Drawing.Size(99, 22)
        Me.PorFecha.TabIndex = 38
        Me.PorFecha.Text = "POR FECHA"
        Me.PorFecha.UseVisualStyleBackColor = False
        '
        'inicio
        '
        Me.inicio.Enabled = False
        Me.inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inicio.Location = New System.Drawing.Point(159, 2)
        Me.inicio.Margin = New System.Windows.Forms.Padding(2)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(110, 25)
        Me.inicio.TabIndex = 31
        Me.inicio.Value = New Date(2016, 6, 17, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(276, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = ">"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'final
        '
        Me.final.Enabled = False
        Me.final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.final.Location = New System.Drawing.Point(294, 2)
        Me.final.Margin = New System.Windows.Forms.Padding(2)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(110, 25)
        Me.final.TabIndex = 33
        '
        'PorAño
        '
        Me.PorAño.AutoSize = True
        Me.PorAño.BackColor = System.Drawing.Color.Gray
        Me.PorAño.ForeColor = System.Drawing.Color.White
        Me.PorAño.Location = New System.Drawing.Point(411, 3)
        Me.PorAño.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.PorAño.Name = "PorAño"
        Me.PorAño.Size = New System.Drawing.Size(70, 22)
        Me.PorAño.TabIndex = 37
        Me.PorAño.Text = "ANUAL"
        Me.PorAño.UseVisualStyleBackColor = False
        '
        'año
        '
        Me.año.Enabled = False
        Me.año.Location = New System.Drawing.Point(486, 2)
        Me.año.Margin = New System.Windows.Forms.Padding(2)
        Me.año.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.año.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.año.Name = "año"
        Me.año.Size = New System.Drawing.Size(58, 25)
        Me.año.TabIndex = 36
        Me.año.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.año.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(549, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "FILTRAR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SelectorCampoFecha
        '
        Me.SelectorCampoFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectorCampoFecha.FormattingEnabled = True
        Me.SelectorCampoFecha.Location = New System.Drawing.Point(626, 2)
        Me.SelectorCampoFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.SelectorCampoFecha.Name = "SelectorCampoFecha"
        Me.SelectorCampoFecha.Size = New System.Drawing.Size(155, 26)
        Me.SelectorCampoFecha.TabIndex = 41
        '
        'Calculos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelColumnas)
        Me.Controls.Add(Me.TablaPersonalizada)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PanelFiltroFecha)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Calculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CALCULOS"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PanelColumnas.ResumeLayout(False)
        Me.PanelFiltroFecha.ResumeLayout(False)
        Me.PanelFiltroFecha.PerformLayout()
        CType(Me.año, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CalculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HaciendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BancosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaldoDeCuentasBancosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreDiarioDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bs As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents DBFoxMuniciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DBAccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DBPostgreSQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Connection As ToolStripLabel
    Friend WithEvents TablaPersonalizada As LinkLabel
    Friend WithEvents PanelColumnas As Panel
    Friend WithEvents ListaColumnas As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelFiltroFecha As FlowLayoutPanel
    Friend WithEvents PorAño As RadioButton
    Friend WithEvents año As NumericUpDown
    Friend WithEvents PorFecha As RadioButton
    Friend WithEvents inicio As DateTimePicker
    Friend WithEvents final As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SinFiltro As RadioButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompararIngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompararEgresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EgresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents SelectorCampoFecha As ComboBox
End Class
