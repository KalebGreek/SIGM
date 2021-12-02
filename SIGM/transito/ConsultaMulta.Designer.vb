<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaMulta
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
		Me.resultado = New System.Windows.Forms.DataGridView()
		Me.bs_resultado = New System.Windows.Forms.BindingSource(Me.components)
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.GenSearchControl1 = New Sigm.genSearchControl()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
		Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		CType(Me.resultado, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'resultado
		'
		Me.resultado.AllowUserToAddRows = False
		Me.resultado.AllowUserToDeleteRows = False
		Me.resultado.AllowUserToResizeRows = False
		Me.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.resultado.Dock = System.Windows.Forms.DockStyle.Fill
		Me.resultado.Location = New System.Drawing.Point(0, 33)
		Me.resultado.Margin = New System.Windows.Forms.Padding(0)
		Me.resultado.Name = "resultado"
		Me.resultado.ReadOnly = True
		Me.resultado.RowHeadersVisible = False
		Me.resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.resultado.Size = New System.Drawing.Size(659, 262)
		Me.resultado.TabIndex = 367
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.CheckBox1)
		Me.Panel1.Controls.Add(Me.GenSearchControl1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(659, 33)
		Me.Panel1.TabIndex = 369
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.BackColor = System.Drawing.Color.DarkGray
		Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CheckBox1.Enabled = False
		Me.CheckBox1.ForeColor = System.Drawing.Color.White
		Me.CheckBox1.Location = New System.Drawing.Point(507, 0)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(152, 33)
		Me.CheckBox1.TabIndex = 1
		Me.CheckBox1.Text = "Impagas"
		Me.CheckBox1.UseVisualStyleBackColor = False
		'
		'GenSearchControl1
		'
		Me.GenSearchControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GenSearchControl1.BackColor = System.Drawing.Color.DarkGray
		Me.GenSearchControl1.Dock = System.Windows.Forms.DockStyle.Left
		Me.GenSearchControl1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GenSearchControl1.Location = New System.Drawing.Point(0, 0)
		Me.GenSearchControl1.Name = "GenSearchControl1"
		Me.GenSearchControl1.Size = New System.Drawing.Size(507, 33)
		Me.GenSearchControl1.TabIndex = 0
		'
		'StatusStrip1
		'
		Me.StatusStrip1.AutoSize = False
		Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 295)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(659, 26)
		Me.StatusStrip1.SizingGrip = False
		Me.StatusStrip1.TabIndex = 370
		Me.StatusStrip1.Text = "Menu"
		'
		'ToolStripSplitButton1
		'
		Me.ToolStripSplitButton1.AutoToolTip = False
		Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
		Me.ToolStripSplitButton1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
		Me.ToolStripSplitButton1.Size = New System.Drawing.Size(60, 24)
		Me.ToolStripSplitButton1.Text = "Menu"
		Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
		'
		'NuevaToolStripMenuItem
		'
		Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
		Me.NuevaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
		Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
		Me.NuevaToolStripMenuItem.Text = "Nueva.."
		'
		'ModificarToolStripMenuItem
		'
		Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
		Me.ModificarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
		Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
		Me.ModificarToolStripMenuItem.Text = "Modificar.."
		'
		'EliminarToolStripMenuItem
		'
		Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
		Me.EliminarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
		Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
		Me.EliminarToolStripMenuItem.Text = "Eliminar.."
		'
		'ImprimirToolStripMenuItem
		'
		Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
		Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
		Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
		Me.ImprimirToolStripMenuItem.Text = "Imprimir.."
		'
		'BusquedaMulta
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(659, 321)
		Me.Controls.Add(Me.resultado)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Panel1)
		Me.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MinimumSize = New System.Drawing.Size(675, 360)
		Me.Name = "BusquedaMulta"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Historial de multas"
		CType(Me.resultado, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents resultado As DataGridView
	Friend WithEvents bs_resultado As BindingSource
	Friend WithEvents Panel1 As Panel
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents GenSearchControl1 As genSearchControl
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
	Friend WithEvents NuevaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
End Class
