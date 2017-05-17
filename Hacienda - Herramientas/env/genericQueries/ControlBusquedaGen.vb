Imports Sigm.Persona
Public Class ControlBusquedaGen
	Inherits UserControl

	Private components As System.ComponentModel.IContainer
	Public WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents keyword As ToolStripTextBox
	Friend WithEvents filtro As ToolStripComboBox
	Friend WithEvents search As ToolStripMenuItem
	Friend WithEvents reset As ToolStripMenuItem
	Friend WithEvents Vista As ToolStripComboBox
	Public WithEvents bs_resultado As BindingSource

	Public Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.Vista = New System.Windows.Forms.ToolStripComboBox()
		Me.filtro = New System.Windows.Forms.ToolStripComboBox()
		Me.keyword = New System.Windows.Forms.ToolStripTextBox()
		Me.search = New System.Windows.Forms.ToolStripMenuItem()
		Me.reset = New System.Windows.Forms.ToolStripMenuItem()
		Me.bs_resultado = New System.Windows.Forms.BindingSource(Me.components)
		Me.MenuStrip1.SuspendLayout()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.AutoSize = False
		Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MenuStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Vista, Me.filtro, Me.keyword, Me.search, Me.reset})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
		Me.MenuStrip1.Size = New System.Drawing.Size(528, 35)
		Me.MenuStrip1.TabIndex = 358
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'Vista
		'
		Me.Vista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.Vista.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.Vista.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Vista.Margin = New System.Windows.Forms.Padding(3)
		Me.Vista.Name = "Vista"
		Me.Vista.Size = New System.Drawing.Size(140, 29)
		'
		'filtro
		'
		Me.filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.filtro.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.filtro.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.filtro.Margin = New System.Windows.Forms.Padding(3)
		Me.filtro.Name = "filtro"
		Me.filtro.Size = New System.Drawing.Size(140, 29)
		'
		'keyword
		'
		Me.keyword.BackColor = System.Drawing.SystemColors.Window
		Me.keyword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.keyword.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.keyword.Margin = New System.Windows.Forms.Padding(3)
		Me.keyword.MaxLength = 64
		Me.keyword.Name = "keyword"
		Me.keyword.Size = New System.Drawing.Size(140, 29)
		'
		'search
		'
		Me.search.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.search.ForeColor = System.Drawing.Color.White
		Me.search.Name = "search"
		Me.search.Size = New System.Drawing.Size(40, 35)
		Me.search.Text = ""
		'
		'reset
		'
		Me.reset.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.reset.ForeColor = System.Drawing.Color.White
		Me.reset.Name = "reset"
		Me.reset.Size = New System.Drawing.Size(40, 35)
		Me.reset.Text = ""
		'
		'ControlBusquedaGen
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Controls.Add(Me.MenuStrip1)
		Me.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.MinimumSize = New System.Drawing.Size(500, 35)
		Me.Name = "ControlBusquedaGen"
		Me.Size = New System.Drawing.Size(528, 35)
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub Consultar(keyword As String)
		'Funcion modelo
	End Sub
	Private Sub ResetForm()
		'Funcion modelo
	End Sub

	'###### EVENTOS GLOBALES DE BUSQUEDA ##########################################################################################
	Public Sub keyword_ClicknFocus(sender As Object, e As EventArgs) Handles keyword.Click, keyword.GotFocus
		keyword.SelectAll()
	End Sub

	'###### VALIDACION ##########################################################################################


End Class
