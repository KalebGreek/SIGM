<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arqueo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Arqueo))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CalculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosMovToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosMovToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HaciendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosYEgresosPorHaciendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldoDeCuentasBancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDiarioDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DBFoxMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBPostgreSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Connection = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CustomCriteria = New System.Windows.Forms.ToolStripLabel()
        Me.TablaPersonalizada = New System.Windows.Forms.LinkLabel()
        Me.PanelColumnas = New System.Windows.Forms.Panel()
        Me.ListaColumnas = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FiltroFecha = New System.Windows.Forms.FlowLayoutPanel()
        Me.PorFecha = New System.Windows.Forms.RadioButton()
        Me.inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.final = New System.Windows.Forms.DateTimePicker()
        Me.Anual = New System.Windows.Forms.RadioButton()
        Me.año = New System.Windows.Forms.NumericUpDown()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.PanelColumnas.SuspendLayout()
        Me.FiltroFecha.SuspendLayout()
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
        Me.CalculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientosToolStripMenuItem, Me.IngresosMovToolStripMenuItem, Me.EgresosMovToolStripMenuItem, Me.ToolStripSeparator1, Me.HaciendaToolStripMenuItem, Me.IngresosYEgresosPorHaciendaToolStripMenuItem, Me.ToolStripSeparator2, Me.BancosToolStripMenuItem, Me.SaldoDeCuentasBancosToolStripMenuItem, Me.ToolStripSeparator3, Me.CajaToolStripMenuItem, Me.CierreDiarioDeCajaToolStripMenuItem})
        Me.CalculosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CalculosToolStripMenuItem.Name = "CalculosToolStripMenuItem"
        Me.CalculosToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.CalculosToolStripMenuItem.Text = "CALCULOS"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.Enabled = False
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'IngresosMovToolStripMenuItem
        '
        Me.IngresosMovToolStripMenuItem.Name = "IngresosMovToolStripMenuItem"
        Me.IngresosMovToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.IngresosMovToolStripMenuItem.Text = "Ingresos"
        '
        'EgresosMovToolStripMenuItem
        '
        Me.EgresosMovToolStripMenuItem.Name = "EgresosMovToolStripMenuItem"
        Me.EgresosMovToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.EgresosMovToolStripMenuItem.Text = "Egresos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(274, 6)
        '
        'HaciendaToolStripMenuItem
        '
        Me.HaciendaToolStripMenuItem.Enabled = False
        Me.HaciendaToolStripMenuItem.Name = "HaciendaToolStripMenuItem"
        Me.HaciendaToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.HaciendaToolStripMenuItem.Text = "Hacienda"
        '
        'IngresosYEgresosPorHaciendaToolStripMenuItem
        '
        Me.IngresosYEgresosPorHaciendaToolStripMenuItem.Name = "IngresosYEgresosPorHaciendaToolStripMenuItem"
        Me.IngresosYEgresosPorHaciendaToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.IngresosYEgresosPorHaciendaToolStripMenuItem.Text = "Ingresos y Egresos por mes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(274, 6)
        '
        'BancosToolStripMenuItem
        '
        Me.BancosToolStripMenuItem.Enabled = False
        Me.BancosToolStripMenuItem.Name = "BancosToolStripMenuItem"
        Me.BancosToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.BancosToolStripMenuItem.Text = "Bancos"
        '
        'SaldoDeCuentasBancosToolStripMenuItem
        '
        Me.SaldoDeCuentasBancosToolStripMenuItem.Name = "SaldoDeCuentasBancosToolStripMenuItem"
        Me.SaldoDeCuentasBancosToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.SaldoDeCuentasBancosToolStripMenuItem.Text = "Saldo de Cuentas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(274, 6)
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Enabled = False
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'CierreDiarioDeCajaToolStripMenuItem
        '
        Me.CierreDiarioDeCajaToolStripMenuItem.Name = "CierreDiarioDeCajaToolStripMenuItem"
        Me.CierreDiarioDeCajaToolStripMenuItem.Size = New System.Drawing.Size(277, 26)
        Me.CierreDiarioDeCajaToolStripMenuItem.Text = "Cierre Diario"
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
        Me.DataView.Size = New System.Drawing.Size(637, 330)
        Me.DataView.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 330)
        Me.Panel2.TabIndex = 30
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.Connection})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 410)
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
        Me.Connection.Size = New System.Drawing.Size(74, 20)
        Me.Connection.Text = "Sin datos."
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 12.0!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.CustomCriteria})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 436)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip2.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip2.TabIndex = 32
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripLabel1.Text = "Criterios de Busqueda"
        '
        'CustomCriteria
        '
        Me.CustomCriteria.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.CustomCriteria.Margin = New System.Windows.Forms.Padding(3)
        Me.CustomCriteria.Name = "CustomCriteria"
        Me.CustomCriteria.Size = New System.Drawing.Size(66, 19)
        Me.CustomCriteria.Text = "Ninguno."
        '
        'TablaPersonalizada
        '
        Me.TablaPersonalizada.ActiveLinkColor = System.Drawing.Color.Blue
        Me.TablaPersonalizada.DisabledLinkColor = System.Drawing.Color.Blue
        Me.TablaPersonalizada.Dock = System.Windows.Forms.DockStyle.Top
        Me.TablaPersonalizada.Location = New System.Drawing.Point(0, 59)
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
        Me.PanelColumnas.Location = New System.Drawing.Point(637, 80)
        Me.PanelColumnas.Name = "PanelColumnas"
        Me.PanelColumnas.Size = New System.Drawing.Size(147, 330)
        Me.PanelColumnas.TabIndex = 34
        '
        'ListaColumnas
        '
        Me.ListaColumnas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaColumnas.FormattingEnabled = True
        Me.ListaColumnas.Location = New System.Drawing.Point(0, 22)
        Me.ListaColumnas.Name = "ListaColumnas"
        Me.ListaColumnas.Size = New System.Drawing.Size(147, 308)
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
        'FiltroFecha
        '
        Me.FiltroFecha.BackColor = System.Drawing.Color.Gray
        Me.FiltroFecha.Controls.Add(Me.PorFecha)
        Me.FiltroFecha.Controls.Add(Me.inicio)
        Me.FiltroFecha.Controls.Add(Me.Label2)
        Me.FiltroFecha.Controls.Add(Me.final)
        Me.FiltroFecha.Controls.Add(Me.Anual)
        Me.FiltroFecha.Controls.Add(Me.año)
        Me.FiltroFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.FiltroFecha.Location = New System.Drawing.Point(0, 29)
        Me.FiltroFecha.Name = "FiltroFecha"
        Me.FiltroFecha.Size = New System.Drawing.Size(784, 30)
        Me.FiltroFecha.TabIndex = 36
        '
        'PorFecha
        '
        Me.PorFecha.AutoSize = True
        Me.PorFecha.BackColor = System.Drawing.Color.Gray
        Me.PorFecha.Checked = True
        Me.PorFecha.ForeColor = System.Drawing.Color.White
        Me.PorFecha.Location = New System.Drawing.Point(15, 3)
        Me.PorFecha.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.PorFecha.Name = "PorFecha"
        Me.PorFecha.Size = New System.Drawing.Size(104, 23)
        Me.PorFecha.TabIndex = 38
        Me.PorFecha.TabStop = True
        Me.PorFecha.Text = "POR FECHA"
        Me.PorFecha.UseVisualStyleBackColor = False
        '
        'inicio
        '
        Me.inicio.Enabled = False
        Me.inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inicio.Location = New System.Drawing.Point(124, 2)
        Me.inicio.Margin = New System.Windows.Forms.Padding(2)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(102, 27)
        Me.inicio.TabIndex = 31
        Me.inicio.Value = New Date(2016, 6, 10, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(233, 3)
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
        Me.final.Location = New System.Drawing.Point(251, 2)
        Me.final.Margin = New System.Windows.Forms.Padding(2)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(102, 27)
        Me.final.TabIndex = 33
        '
        'Anual
        '
        Me.Anual.AutoSize = True
        Me.Anual.BackColor = System.Drawing.Color.Gray
        Me.Anual.ForeColor = System.Drawing.Color.White
        Me.Anual.Location = New System.Drawing.Point(365, 3)
        Me.Anual.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.Anual.Name = "Anual"
        Me.Anual.Size = New System.Drawing.Size(75, 23)
        Me.Anual.TabIndex = 37
        Me.Anual.Text = "ANUAL"
        Me.Anual.UseVisualStyleBackColor = False
        '
        'año
        '
        Me.año.Enabled = False
        Me.año.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.año.Location = New System.Drawing.Point(445, 2)
        Me.año.Margin = New System.Windows.Forms.Padding(2)
        Me.año.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.año.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.año.Name = "año"
        Me.año.Size = New System.Drawing.Size(58, 23)
        Me.año.TabIndex = 36
        Me.año.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.año.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'Arqueo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelColumnas)
        Me.Controls.Add(Me.TablaPersonalizada)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.FiltroFecha)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Arqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Arqueo"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.PanelColumnas.ResumeLayout(False)
        Me.FiltroFecha.ResumeLayout(False)
        Me.FiltroFecha.PerformLayout()
        CType(Me.año, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CalculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosMovToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EgresosMovToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HaciendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosYEgresosPorHaciendaToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CustomCriteria As ToolStripLabel
    Friend WithEvents TablaPersonalizada As LinkLabel
    Friend WithEvents PanelColumnas As Panel
    Friend WithEvents ListaColumnas As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FiltroFecha As FlowLayoutPanel
    Friend WithEvents Anual As RadioButton
    Friend WithEvents año As NumericUpDown
    Friend WithEvents PorFecha As RadioButton
    Friend WithEvents inicio As DateTimePicker
    Friend WithEvents final As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
