<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusquedaCombustible
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripSplitButton5 = New System.Windows.Forms.ToolStripSplitButton()
		Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
		Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.info = New System.Windows.Forms.ToolStripStatusLabel()
		Me.responsable_id = New System.Windows.Forms.ToolStripStatusLabel()
		Me.recipiente_id = New System.Windows.Forms.ToolStripStatusLabel()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage4 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.bs_seccion = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_categoria = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_receptor = New System.Windows.Forms.BindingSource(Me.components)
		Me.CtrlBusquedaCombustiblePorTicket1 = New Sigm.CtrlBusquedaCombustiblePorTicket()
		Me.CtrlBusquedaCombustiblePorReceptor1 = New Sigm.CtrlCombustiblePorReceptor()
		Me.CtrlBusquedaCombustiblePorResponsable1 = New Sigm.CtrlCombustiblePorResponsable()
		Me.CtrlBusquedaCombustiblePorProveedor1 = New Sigm.CtrlCombustiblePorProveedor()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StatusStrip1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TabPage4.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		CType(Me.bs_seccion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(0, 124)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(684, 262)
		Me.DataGridView1.TabIndex = 397
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton5, Me.ToolStripSplitButton2, Me.ToolStripStatusLabel1, Me.info, Me.responsable_id, Me.recipiente_id})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 386)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(684, 25)
		Me.StatusStrip1.TabIndex = 399
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripSplitButton5
		'
		Me.ToolStripSplitButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
		Me.ToolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripSplitButton5.Name = "ToolStripSplitButton5"
		Me.ToolStripSplitButton5.Size = New System.Drawing.Size(66, 23)
		Me.ToolStripSplitButton5.Text = "Ticket"
		'
		'ToolStripMenuItem7
		'
		Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
		Me.ToolStripMenuItem7.Size = New System.Drawing.Size(141, 24)
		Me.ToolStripMenuItem7.Text = "Nuevo.."
		'
		'ToolStripMenuItem8
		'
		Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
		Me.ToolStripMenuItem8.Size = New System.Drawing.Size(141, 24)
		Me.ToolStripMenuItem8.Text = "Modificar.."
		'
		'ToolStripMenuItem9
		'
		Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
		Me.ToolStripMenuItem9.Size = New System.Drawing.Size(141, 24)
		Me.ToolStripMenuItem9.Text = "Eliminar"
		'
		'ToolStripSplitButton2
		'
		Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarToolStripMenuItem})
		Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
		Me.ToolStripSplitButton2.Size = New System.Drawing.Size(81, 23)
		Me.ToolStripSplitButton2.Text = "Informes"
		'
		'ExportarToolStripMenuItem
		'
		Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
		Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(199, 24)
		Me.ExportarToolStripMenuItem.Text = "Exportar / Imprimir"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(451, 20)
		Me.ToolStripStatusLabel1.Spring = True
		Me.ToolStripStatusLabel1.Text = "   "
		'
		'info
		'
		Me.info.BackColor = System.Drawing.SystemColors.Control
		Me.info.Name = "info"
		Me.info.Size = New System.Drawing.Size(37, 20)
		Me.info.Text = "Info."
		'
		'responsable_id
		'
		Me.responsable_id.BackColor = System.Drawing.SystemColors.Control
		Me.responsable_id.Name = "responsable_id"
		Me.responsable_id.Size = New System.Drawing.Size(17, 20)
		Me.responsable_id.Text = "0"
		'
		'recipiente_id
		'
		Me.recipiente_id.BackColor = System.Drawing.SystemColors.Control
		Me.recipiente_id.Name = "recipiente_id"
		Me.recipiente_id.Size = New System.Drawing.Size(17, 20)
		Me.recipiente_id.Text = "0"
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.Silver
		Me.TabPage1.Controls.Add(Me.CtrlBusquedaCombustiblePorResponsable1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 31)
		Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Size = New System.Drawing.Size(676, 89)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Por Responsable"
		'
		'TabControl1
		'
		Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
		Me.TabControl1.Controls.Add(Me.TabPage4)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(684, 124)
		Me.TabControl1.TabIndex = 400
		'
		'TabPage4
		'
		Me.TabPage4.BackColor = System.Drawing.Color.Silver
		Me.TabPage4.Controls.Add(Me.CtrlBusquedaCombustiblePorTicket1)
		Me.TabPage4.Location = New System.Drawing.Point(4, 31)
		Me.TabPage4.Margin = New System.Windows.Forms.Padding(0)
		Me.TabPage4.Name = "TabPage4"
		Me.TabPage4.Size = New System.Drawing.Size(676, 89)
		Me.TabPage4.TabIndex = 3
		Me.TabPage4.Text = "Por Ticket"
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.Silver
		Me.TabPage2.Controls.Add(Me.CtrlBusquedaCombustiblePorReceptor1)
		Me.TabPage2.Location = New System.Drawing.Point(4, 31)
		Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Size = New System.Drawing.Size(676, 89)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Por Receptor"
		'
		'TabPage3
		'
		Me.TabPage3.BackColor = System.Drawing.Color.Silver
		Me.TabPage3.Controls.Add(Me.CtrlBusquedaCombustiblePorProveedor1)
		Me.TabPage3.Location = New System.Drawing.Point(4, 31)
		Me.TabPage3.Margin = New System.Windows.Forms.Padding(0)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(676, 89)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Por Proveedor"
		'
		'CtrlBusquedaCombustiblePorTicket1
		'
		Me.CtrlBusquedaCombustiblePorTicket1.BackColor = System.Drawing.Color.Silver
		Me.CtrlBusquedaCombustiblePorTicket1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CtrlBusquedaCombustiblePorTicket1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CtrlBusquedaCombustiblePorTicket1.Location = New System.Drawing.Point(0, 0)
		Me.CtrlBusquedaCombustiblePorTicket1.Margin = New System.Windows.Forms.Padding(4)
		Me.CtrlBusquedaCombustiblePorTicket1.Name = "CtrlBusquedaCombustiblePorTicket1"
		Me.CtrlBusquedaCombustiblePorTicket1.Size = New System.Drawing.Size(676, 89)
		Me.CtrlBusquedaCombustiblePorTicket1.TabIndex = 0
		'
		'CtrlBusquedaCombustiblePorReceptor1
		'
		Me.CtrlBusquedaCombustiblePorReceptor1.BackColor = System.Drawing.Color.Silver
		Me.CtrlBusquedaCombustiblePorReceptor1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CtrlBusquedaCombustiblePorReceptor1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CtrlBusquedaCombustiblePorReceptor1.Location = New System.Drawing.Point(0, 0)
		Me.CtrlBusquedaCombustiblePorReceptor1.Margin = New System.Windows.Forms.Padding(4)
		Me.CtrlBusquedaCombustiblePorReceptor1.Name = "CtrlBusquedaCombustiblePorReceptor1"
		Me.CtrlBusquedaCombustiblePorReceptor1.Size = New System.Drawing.Size(676, 89)
		Me.CtrlBusquedaCombustiblePorReceptor1.TabIndex = 0
		'
		'CtrlBusquedaCombustiblePorResponsable1
		'
		Me.CtrlBusquedaCombustiblePorResponsable1.BackColor = System.Drawing.Color.Silver
		Me.CtrlBusquedaCombustiblePorResponsable1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CtrlBusquedaCombustiblePorResponsable1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CtrlBusquedaCombustiblePorResponsable1.Location = New System.Drawing.Point(0, 0)
		Me.CtrlBusquedaCombustiblePorResponsable1.Margin = New System.Windows.Forms.Padding(4)
		Me.CtrlBusquedaCombustiblePorResponsable1.Name = "CtrlBusquedaCombustiblePorResponsable1"
		Me.CtrlBusquedaCombustiblePorResponsable1.Size = New System.Drawing.Size(676, 89)
		Me.CtrlBusquedaCombustiblePorResponsable1.TabIndex = 0
		'
		'CtrlBusquedaCombustiblePorProveedor1
		'
		Me.CtrlBusquedaCombustiblePorProveedor1.BackColor = System.Drawing.Color.Silver
		Me.CtrlBusquedaCombustiblePorProveedor1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CtrlBusquedaCombustiblePorProveedor1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CtrlBusquedaCombustiblePorProveedor1.Location = New System.Drawing.Point(0, 0)
		Me.CtrlBusquedaCombustiblePorProveedor1.Margin = New System.Windows.Forms.Padding(4)
		Me.CtrlBusquedaCombustiblePorProveedor1.Name = "CtrlBusquedaCombustiblePorProveedor1"
		Me.CtrlBusquedaCombustiblePorProveedor1.Size = New System.Drawing.Size(676, 89)
		Me.CtrlBusquedaCombustiblePorProveedor1.TabIndex = 0
		'
		'ModCombustible
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(684, 411)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MinimumSize = New System.Drawing.Size(520, 310)
		Me.Name = "ModCombustible"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "CONTROL DE TICKETS DE COMBUSTIBLE"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.TabPage1.ResumeLayout(False)
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage4.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		CType(Me.bs_seccion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents bs_seccion As System.Windows.Forms.BindingSource
	Friend WithEvents bs_categoria As System.Windows.Forms.BindingSource
	Friend WithEvents bs_receptor As System.Windows.Forms.BindingSource
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents recipiente_id As ToolStripStatusLabel
	Friend WithEvents responsable_id As ToolStripStatusLabel
	Friend WithEvents info As ToolStripStatusLabel
	Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
	Friend WithEvents ToolStripSplitButton2 As ToolStripSplitButton
	Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents ToolStripSplitButton5 As ToolStripSplitButton
	Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
	Friend WithEvents TabPage4 As TabPage
	Friend WithEvents CtrlBusquedaCombustiblePorResponsable1 As CtrlCombustiblePorResponsable
	Friend WithEvents CtrlBusquedaCombustiblePorTicket1 As CtrlBusquedaCombustiblePorTicket
	Friend WithEvents CtrlBusquedaCombustiblePorReceptor1 As CtrlCombustiblePorReceptor
	Friend WithEvents CtrlBusquedaCombustiblePorProveedor1 As CtrlCombustiblePorProveedor
End Class
