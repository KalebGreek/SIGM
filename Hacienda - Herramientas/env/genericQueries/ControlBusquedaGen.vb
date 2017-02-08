Imports Sigm.Persona.sql
Public Class ControlBusquedaGen
	Inherits Form

	Private components As System.ComponentModel.IContainer
	Friend WithEvents MenuStrip1 As MenuStrip

	Friend WithEvents keyword As ToolStripTextBox
	Friend WithEvents filtro As ToolStripComboBox
	Friend WithEvents search As ToolStripMenuItem
	Friend WithEvents reset As ToolStripMenuItem
	Friend WithEvents DataGridView1 As DataGridView
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.MenuStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Vista, Me.filtro, Me.keyword, Me.search, Me.reset})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
		Me.MenuStrip1.Size = New System.Drawing.Size(528, 34)
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
		Me.Vista.Size = New System.Drawing.Size(120, 28)
		'
		'filtro
		'
		Me.filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.filtro.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.filtro.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.filtro.Margin = New System.Windows.Forms.Padding(3)
		Me.filtro.Name = "filtro"
		Me.filtro.Size = New System.Drawing.Size(140, 28)
		'
		'keyword
		'
		Me.keyword.BackColor = System.Drawing.SystemColors.Window
		Me.keyword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.keyword.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.keyword.Margin = New System.Windows.Forms.Padding(3)
		Me.keyword.MaxLength = 64
		Me.keyword.Name = "keyword"
		Me.keyword.Size = New System.Drawing.Size(120, 28)
		'
		'search
		'
		Me.search.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.search.ForeColor = System.Drawing.Color.White
		Me.search.Name = "search"
		Me.search.Size = New System.Drawing.Size(40, 34)
		Me.search.Text = ""
		'
		'reset
		'
		Me.reset.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.reset.ForeColor = System.Drawing.Color.White
		Me.reset.Name = "reset"
		Me.reset.Size = New System.Drawing.Size(40, 34)
		Me.reset.Text = ""
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToResizeRows = False
		Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(0, 34)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(528, 209)
		Me.DataGridView1.TabIndex = 361
		'
		'ControlBusquedaGen
		'
		Me.ClientSize = New System.Drawing.Size(528, 243)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(500, 250)
		Me.Name = "ControlBusquedaGen"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub cerrar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Overloads Sub Consultar(keyword As String)
		'Funcion modelo
	End Sub
	Overloads Sub ResetForm()
		'Funcion modelo
	End Sub

	'###### EVENTOS GLOBALES DE BUSQUEDA ##########################################################################################
	Public Sub keyword_ClicknFocus(sender As Object, e As EventArgs) Handles keyword.Click, keyword.GotFocus
		keyword.SelectAll()
	End Sub

	'###### VALIDACION ##########################################################################################


End Class
