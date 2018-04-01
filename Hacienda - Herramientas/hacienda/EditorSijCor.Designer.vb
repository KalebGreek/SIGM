<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditorSijCor
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorSijCor))
		Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
		Me.CalculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DataView = New System.Windows.Forms.DataGridView()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.bs = New System.Windows.Forms.BindingSource(Me.components)
		Me.StringFilterPanel = New System.Windows.Forms.FlowLayoutPanel()
		Me.PanelFiltros = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.path = New System.Windows.Forms.TextBox()
		Me.browse = New System.Windows.Forms.Button()
		Me.MenuStrip2.SuspendLayout()
		CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelFiltros.SuspendLayout()
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
		Me.CalculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.GuardarComoToolStripMenuItem})
		Me.CalculosToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.CalculosToolStripMenuItem.Name = "CalculosToolStripMenuItem"
		Me.CalculosToolStripMenuItem.Size = New System.Drawing.Size(61, 25)
		Me.CalculosToolStripMenuItem.Text = "Menu"
		'
		'CargarToolStripMenuItem
		'
		Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
		Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
		Me.CargarToolStripMenuItem.Text = "Cargar.."
		'
		'GuardarComoToolStripMenuItem
		'
		Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
		Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
		Me.GuardarComoToolStripMenuItem.Text = "Guardar como.."
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
		Me.DataView.RowHeadersVisible = False
		Me.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
		Me.DataView.Size = New System.Drawing.Size(484, 401)
		Me.DataView.TabIndex = 24
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.DataView)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 29)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(484, 401)
		Me.Panel2.TabIndex = 30
		'
		'StringFilterPanel
		'
		Me.StringFilterPanel.AutoSize = True
		Me.StringFilterPanel.BackColor = System.Drawing.Color.Gray
		Me.StringFilterPanel.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.StringFilterPanel.Location = New System.Drawing.Point(3, 3)
		Me.StringFilterPanel.Name = "StringFilterPanel"
		Me.StringFilterPanel.Size = New System.Drawing.Size(0, 0)
		Me.StringFilterPanel.TabIndex = 48
		Me.StringFilterPanel.Visible = False
		'
		'PanelFiltros
		'
		Me.PanelFiltros.AutoSize = True
		Me.PanelFiltros.BackColor = System.Drawing.Color.Gray
		Me.PanelFiltros.Controls.Add(Me.StringFilterPanel)
		Me.PanelFiltros.Controls.Add(Me.Label6)
		Me.PanelFiltros.Controls.Add(Me.path)
		Me.PanelFiltros.Controls.Add(Me.browse)
		Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.PanelFiltros.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.PanelFiltros.Location = New System.Drawing.Point(0, 430)
		Me.PanelFiltros.Name = "PanelFiltros"
		Me.PanelFiltros.Size = New System.Drawing.Size(484, 31)
		Me.PanelFiltros.TabIndex = 36
		'
		'Label6
		'
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(9, 3)
		Me.Label6.Margin = New System.Windows.Forms.Padding(3)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(70, 22)
		Me.Label6.TabIndex = 51
		Me.Label6.Text = "Ubicacion"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'path
		'
		Me.path.Location = New System.Drawing.Point(85, 3)
		Me.path.Name = "path"
		Me.path.ReadOnly = True
		Me.path.Size = New System.Drawing.Size(355, 25)
		Me.path.TabIndex = 50
		'
		'browse
		'
		Me.browse.FlatAppearance.BorderSize = 0
		Me.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.browse.Font = New System.Drawing.Font("Segoe MDL2 Assets", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.browse.ForeColor = System.Drawing.Color.White
		Me.browse.Location = New System.Drawing.Point(446, 3)
		Me.browse.Name = "browse"
		Me.browse.Size = New System.Drawing.Size(25, 25)
		Me.browse.TabIndex = 52
		Me.browse.Text = ""
		Me.browse.UseVisualStyleBackColor = True
		'
		'EditorSijCor
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(484, 461)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.PanelFiltros)
		Me.Controls.Add(Me.MenuStrip2)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
		Me.MinimumSize = New System.Drawing.Size(500, 500)
		Me.Name = "EditorSijCor"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Editor de registros SIJCOR"
		Me.MenuStrip2.ResumeLayout(False)
		Me.MenuStrip2.PerformLayout()
		CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelFiltros.ResumeLayout(False)
		Me.PanelFiltros.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip2 As MenuStrip
	Friend WithEvents CalculosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DataView As DataGridView
	Friend WithEvents Panel2 As Panel
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents bs As BindingSource
	Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents StringFilterPanel As FlowLayoutPanel
	Friend WithEvents PanelFiltros As FlowLayoutPanel
	Friend WithEvents Label6 As Label
	Friend WithEvents path As TextBox
	Friend WithEvents browse As Button
End Class
