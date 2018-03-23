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
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
		Me.DBFoxMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DBAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DBPostgreSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Connection = New System.Windows.Forms.ToolStripLabel()
		Me.CustomQuery = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.CustomTable = New System.Windows.Forms.LinkLabel()
		Me.PanelFiltros = New System.Windows.Forms.FlowLayoutPanel()
		Me.EnableFilter = New System.Windows.Forms.CheckBox()
		Me.ColumnList = New System.Windows.Forms.ComboBox()
		Me.IntFilterPanel = New System.Windows.Forms.FlowLayoutPanel()
		Me.NumFilterSelect = New System.Windows.Forms.ComboBox()
		Me.minNumValue = New System.Windows.Forms.NumericUpDown()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.maxNumValue = New System.Windows.Forms.NumericUpDown()
		Me.DateFilterPanel = New System.Windows.Forms.FlowLayoutPanel()
		Me.PorFecha = New System.Windows.Forms.RadioButton()
		Me.minDateValue = New System.Windows.Forms.DateTimePicker()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.maxDateValue = New System.Windows.Forms.DateTimePicker()
		Me.PorAño = New System.Windows.Forms.RadioButton()
		Me.yearValue = New System.Windows.Forms.NumericUpDown()
		Me.StringFilterPanel = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.keyword = New System.Windows.Forms.TextBox()
		Me.query_bs = New System.Windows.Forms.BindingSource(Me.components)
		Me.ColumnList_bs = New System.Windows.Forms.BindingSource(Me.components)
		Me.MenuStrip2.SuspendLayout()
		CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.PanelFiltros.SuspendLayout()
		Me.IntFilterPanel.SuspendLayout()
		CType(Me.minNumValue, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.maxNumValue, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.DateFilterPanel.SuspendLayout()
		CType(Me.yearValue, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StringFilterPanel.SuspendLayout()
		CType(Me.query_bs, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ColumnList_bs, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.MenuStrip2.Size = New System.Drawing.Size(484, 29)
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
		Me.DataView.AllowUserToResizeRows = False
		Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataView.Location = New System.Drawing.Point(0, 0)
		Me.DataView.Name = "DataView"
		Me.DataView.ReadOnly = True
		Me.DataView.RowHeadersVisible = False
		Me.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataView.Size = New System.Drawing.Size(484, 215)
		Me.DataView.TabIndex = 24
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.DataView)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 220)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(484, 215)
		Me.Panel2.TabIndex = 30
		'
		'ToolStrip1
		'
		Me.ToolStrip1.AutoSize = False
		Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.ToolStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 10.0!)
		Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.Connection, Me.CustomQuery, Me.ToolStripLabel1})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 435)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
		Me.ToolStrip1.Size = New System.Drawing.Size(484, 26)
		Me.ToolStrip1.TabIndex = 31
		'
		'ToolStripDropDownButton2
		'
		Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DBFoxMuniciToolStripMenuItem, Me.DBAccessToolStripMenuItem, Me.DBPostgreSQLToolStripMenuItem})
		Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
		Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
		Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(89, 23)
		Me.ToolStripDropDownButton2.Text = "Conexiones"
		'
		'DBFoxMuniciToolStripMenuItem
		'
		Me.DBFoxMuniciToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.DBFoxMuniciToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.DBFoxMuniciToolStripMenuItem.Name = "DBFoxMuniciToolStripMenuItem"
		Me.DBFoxMuniciToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
		Me.DBFoxMuniciToolStripMenuItem.Text = "DB Fox (Munici)"
		'
		'DBAccessToolStripMenuItem
		'
		Me.DBAccessToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.DBAccessToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.DBAccessToolStripMenuItem.Name = "DBAccessToolStripMenuItem"
		Me.DBAccessToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
		Me.DBAccessToolStripMenuItem.Text = "DB Access"
		'
		'DBPostgreSQLToolStripMenuItem
		'
		Me.DBPostgreSQLToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.DBPostgreSQLToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.DBPostgreSQLToolStripMenuItem.Name = "DBPostgreSQLToolStripMenuItem"
		Me.DBPostgreSQLToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
		Me.DBPostgreSQLToolStripMenuItem.Text = "DB PostgreSQL"
		'
		'Connection
		'
		Me.Connection.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 10.0!)
		Me.Connection.Margin = New System.Windows.Forms.Padding(3)
		Me.Connection.Name = "Connection"
		Me.Connection.Size = New System.Drawing.Size(292, 20)
		Me.Connection.Text = "Seleccione una base de datos antes de continuar."
		'
		'CustomQuery
		'
		Me.CustomQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.CustomQuery.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
		Me.CustomQuery.Name = "CustomQuery"
		Me.CustomQuery.Size = New System.Drawing.Size(200, 25)
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.ToolStripLabel1.AutoSize = False
		Me.ToolStripLabel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Italic)
		Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(3)
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(80, 20)
		Me.ToolStripLabel1.Text = "Consulta"
		Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'CustomTable
		'
		Me.CustomTable.ActiveLinkColor = System.Drawing.Color.Blue
		Me.CustomTable.DisabledLinkColor = System.Drawing.Color.Blue
		Me.CustomTable.Dock = System.Windows.Forms.DockStyle.Top
		Me.CustomTable.Location = New System.Drawing.Point(0, 199)
		Me.CustomTable.Name = "CustomTable"
		Me.CustomTable.Size = New System.Drawing.Size(484, 21)
		Me.CustomTable.TabIndex = 33
		Me.CustomTable.TabStop = True
		Me.CustomTable.Text = "Click para agregar tabla."
		Me.CustomTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.CustomTable.VisitedLinkColor = System.Drawing.Color.Blue
		'
		'PanelFiltros
		'
		Me.PanelFiltros.AutoSize = True
		Me.PanelFiltros.BackColor = System.Drawing.Color.Gray
		Me.PanelFiltros.Controls.Add(Me.EnableFilter)
		Me.PanelFiltros.Controls.Add(Me.ColumnList)
		Me.PanelFiltros.Controls.Add(Me.IntFilterPanel)
		Me.PanelFiltros.Controls.Add(Me.DateFilterPanel)
		Me.PanelFiltros.Controls.Add(Me.StringFilterPanel)
		Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelFiltros.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.PanelFiltros.Location = New System.Drawing.Point(0, 29)
		Me.PanelFiltros.Name = "PanelFiltros"
		Me.PanelFiltros.Size = New System.Drawing.Size(484, 170)
		Me.PanelFiltros.TabIndex = 36
		Me.PanelFiltros.Visible = False
		'
		'EnableFilter
		'
		Me.EnableFilter.AutoSize = True
		Me.EnableFilter.ForeColor = System.Drawing.Color.White
		Me.EnableFilter.Location = New System.Drawing.Point(3, 8)
		Me.EnableFilter.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
		Me.EnableFilter.Name = "EnableFilter"
		Me.EnableFilter.Size = New System.Drawing.Size(81, 22)
		Me.EnableFilter.TabIndex = 49
		Me.EnableFilter.Text = "FILTRAR"
		Me.EnableFilter.UseVisualStyleBackColor = True
		'
		'ColumnList
		'
		Me.ColumnList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ColumnList.FormattingEnabled = True
		Me.ColumnList.Location = New System.Drawing.Point(89, 5)
		Me.ColumnList.Margin = New System.Windows.Forms.Padding(2, 5, 2, 2)
		Me.ColumnList.Name = "ColumnList"
		Me.ColumnList.Size = New System.Drawing.Size(155, 26)
		Me.ColumnList.TabIndex = 41
		Me.ColumnList.Visible = False
		'
		'IntFilterPanel
		'
		Me.IntFilterPanel.AutoSize = True
		Me.IntFilterPanel.BackColor = System.Drawing.Color.Gray
		Me.IntFilterPanel.Controls.Add(Me.NumFilterSelect)
		Me.IntFilterPanel.Controls.Add(Me.minNumValue)
		Me.IntFilterPanel.Controls.Add(Me.Label4)
		Me.IntFilterPanel.Controls.Add(Me.maxNumValue)
		Me.IntFilterPanel.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.IntFilterPanel.Location = New System.Drawing.Point(3, 36)
		Me.IntFilterPanel.Name = "IntFilterPanel"
		Me.IntFilterPanel.Size = New System.Drawing.Size(389, 30)
		Me.IntFilterPanel.TabIndex = 45
		Me.IntFilterPanel.Visible = False
		'
		'NumFilterSelect
		'
		Me.NumFilterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.NumFilterSelect.FormattingEnabled = True
		Me.NumFilterSelect.Items.AddRange(New Object() {"VALOR", "MAYOR QUE", "MENOR QUE", "RANGO"})
		Me.NumFilterSelect.Location = New System.Drawing.Point(2, 2)
		Me.NumFilterSelect.Margin = New System.Windows.Forms.Padding(2)
		Me.NumFilterSelect.Name = "NumFilterSelect"
		Me.NumFilterSelect.Size = New System.Drawing.Size(116, 26)
		Me.NumFilterSelect.TabIndex = 45
		'
		'minNumValue
		'
		Me.minNumValue.Location = New System.Drawing.Point(122, 2)
		Me.minNumValue.Margin = New System.Windows.Forms.Padding(2)
		Me.minNumValue.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.minNumValue.Name = "minNumValue"
		Me.minNumValue.Size = New System.Drawing.Size(120, 25)
		Me.minNumValue.TabIndex = 36
		Me.minNumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Gray
		Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!, System.Drawing.FontStyle.Bold)
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(249, 3)
		Me.Label4.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(13, 20)
		Me.Label4.TabIndex = 44
		Me.Label4.Text = ">"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Label4.Visible = False
		'
		'maxNumValue
		'
		Me.maxNumValue.Location = New System.Drawing.Point(267, 2)
		Me.maxNumValue.Margin = New System.Windows.Forms.Padding(2)
		Me.maxNumValue.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.maxNumValue.Name = "maxNumValue"
		Me.maxNumValue.Size = New System.Drawing.Size(120, 25)
		Me.maxNumValue.TabIndex = 39
		Me.maxNumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.maxNumValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
		Me.maxNumValue.Visible = False
		'
		'DateFilterPanel
		'
		Me.DateFilterPanel.AutoSize = True
		Me.DateFilterPanel.BackColor = System.Drawing.Color.Gray
		Me.DateFilterPanel.Controls.Add(Me.PorFecha)
		Me.DateFilterPanel.Controls.Add(Me.minDateValue)
		Me.DateFilterPanel.Controls.Add(Me.Label2)
		Me.DateFilterPanel.Controls.Add(Me.maxDateValue)
		Me.DateFilterPanel.Controls.Add(Me.PorAño)
		Me.DateFilterPanel.Controls.Add(Me.yearValue)
		Me.DateFilterPanel.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.DateFilterPanel.Location = New System.Drawing.Point(3, 72)
		Me.DateFilterPanel.Name = "DateFilterPanel"
		Me.DateFilterPanel.Size = New System.Drawing.Size(421, 58)
		Me.DateFilterPanel.TabIndex = 47
		Me.DateFilterPanel.Visible = False
		'
		'PorFecha
		'
		Me.PorFecha.AutoSize = True
		Me.PorFecha.BackColor = System.Drawing.Color.Gray
		Me.PorFecha.Checked = True
		Me.PorFecha.ForeColor = System.Drawing.Color.White
		Me.PorFecha.Location = New System.Drawing.Point(3, 3)
		Me.PorFecha.Name = "PorFecha"
		Me.PorFecha.Size = New System.Drawing.Size(71, 22)
		Me.PorFecha.TabIndex = 42
		Me.PorFecha.TabStop = True
		Me.PorFecha.Text = "RANGO"
		Me.PorFecha.UseVisualStyleBackColor = False
		'
		'minDateValue
		'
		Me.minDateValue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.minDateValue.Location = New System.Drawing.Point(79, 2)
		Me.minDateValue.Margin = New System.Windows.Forms.Padding(2)
		Me.minDateValue.Name = "minDateValue"
		Me.minDateValue.Size = New System.Drawing.Size(112, 25)
		Me.minDateValue.TabIndex = 40
		Me.minDateValue.Value = New Date(2018, 3, 17, 18, 2, 56, 0)
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Gray
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(198, 3)
		Me.Label2.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(13, 20)
		Me.Label2.TabIndex = 43
		Me.Label2.Text = ">"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'maxDateValue
		'
		Me.maxDateValue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.maxDateValue.Location = New System.Drawing.Point(216, 2)
		Me.maxDateValue.Margin = New System.Windows.Forms.Padding(2)
		Me.maxDateValue.Name = "maxDateValue"
		Me.maxDateValue.Size = New System.Drawing.Size(112, 25)
		Me.maxDateValue.TabIndex = 41
		'
		'PorAño
		'
		Me.PorAño.AutoSize = True
		Me.PorAño.BackColor = System.Drawing.Color.Gray
		Me.PorAño.ForeColor = System.Drawing.Color.White
		Me.PorAño.Location = New System.Drawing.Point(335, 3)
		Me.PorAño.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
		Me.PorAño.Name = "PorAño"
		Me.PorAño.Size = New System.Drawing.Size(83, 22)
		Me.PorAño.TabIndex = 45
		Me.PorAño.Text = "PERIODO"
		Me.PorAño.UseVisualStyleBackColor = False
		'
		'yearValue
		'
		Me.yearValue.Enabled = False
		Me.yearValue.Location = New System.Drawing.Point(2, 31)
		Me.yearValue.Margin = New System.Windows.Forms.Padding(2)
		Me.yearValue.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
		Me.yearValue.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
		Me.yearValue.Name = "yearValue"
		Me.yearValue.Size = New System.Drawing.Size(58, 25)
		Me.yearValue.TabIndex = 44
		Me.yearValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.yearValue.Value = New Decimal(New Integer() {1900, 0, 0, 0})
		'
		'StringFilterPanel
		'
		Me.StringFilterPanel.AutoSize = True
		Me.StringFilterPanel.BackColor = System.Drawing.Color.Gray
		Me.StringFilterPanel.Controls.Add(Me.Label6)
		Me.StringFilterPanel.Controls.Add(Me.keyword)
		Me.StringFilterPanel.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.StringFilterPanel.Location = New System.Drawing.Point(3, 136)
		Me.StringFilterPanel.Name = "StringFilterPanel"
		Me.StringFilterPanel.Size = New System.Drawing.Size(432, 31)
		Me.StringFilterPanel.TabIndex = 48
		Me.StringFilterPanel.Visible = False
		'
		'Label6
		'
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(3, 3)
		Me.Label6.Margin = New System.Windows.Forms.Padding(3)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(143, 22)
		Me.Label6.TabIndex = 45
		Me.Label6.Text = "PALABRA(S) CLAVE"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'keyword
		'
		Me.keyword.Location = New System.Drawing.Point(152, 3)
		Me.keyword.Name = "keyword"
		Me.keyword.Size = New System.Drawing.Size(277, 25)
		Me.keyword.TabIndex = 46
		'
		'ColumnList_bs
		'
		'
		'ConsultasEspeciales
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(484, 461)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.CustomTable)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.PanelFiltros)
		Me.Controls.Add(Me.MenuStrip2)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
		Me.MinimumSize = New System.Drawing.Size(500, 500)
		Me.Name = "ConsultasEspeciales"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Herramientas de calculo"
		Me.MenuStrip2.ResumeLayout(False)
		Me.MenuStrip2.PerformLayout()
		CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.PanelFiltros.ResumeLayout(False)
		Me.PanelFiltros.PerformLayout()
		Me.IntFilterPanel.ResumeLayout(False)
		CType(Me.minNumValue, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.maxNumValue, System.ComponentModel.ISupportInitialize).EndInit()
		Me.DateFilterPanel.ResumeLayout(False)
		Me.DateFilterPanel.PerformLayout()
		CType(Me.yearValue, System.ComponentModel.ISupportInitialize).EndInit()
		Me.StringFilterPanel.ResumeLayout(False)
		Me.StringFilterPanel.PerformLayout()
		CType(Me.query_bs, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ColumnList_bs, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

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
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
	Friend WithEvents DBFoxMuniciToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DBAccessToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DBPostgreSQLToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Connection As ToolStripLabel
	Friend WithEvents CustomTable As LinkLabel
	Friend WithEvents PanelFiltros As FlowLayoutPanel
	Friend WithEvents DiferenciaIngresoEntreCajaYMovimientosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
	Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CompararIngresosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CompararEgresosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EgresosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ColumnList As ComboBox
	Friend WithEvents IntFilterPanel As FlowLayoutPanel
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents minNumValue As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents maxNumValue As NumericUpDown
	Friend WithEvents DateFilterPanel As FlowLayoutPanel
	Friend WithEvents PorFecha As RadioButton
	Friend WithEvents minDateValue As DateTimePicker
	Friend WithEvents Label2 As Label
	Friend WithEvents maxDateValue As DateTimePicker
	Friend WithEvents PorAño As RadioButton
	Friend WithEvents yearValue As NumericUpDown
	Friend WithEvents StringFilterPanel As FlowLayoutPanel
	Friend WithEvents Label6 As Label
	Friend WithEvents keyword As TextBox
	Friend WithEvents query_bs As BindingSource
	Friend WithEvents ColumnList_bs As BindingSource
	Friend WithEvents ToolStripLabel1 As ToolStripLabel
	Friend WithEvents CustomQuery As ToolStripTextBox
	Friend WithEvents NumFilterSelect As ComboBox
	Friend WithEvents EnableFilter As CheckBox
End Class
