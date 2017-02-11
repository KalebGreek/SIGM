<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModCombustible
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
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.info = New System.Windows.Forms.ToolStripStatusLabel()
		Me.responsable_id = New System.Windows.Forms.ToolStripStatusLabel()
		Me.recipiente_id = New System.Windows.Forms.ToolStripStatusLabel()
		Me.bs_seccion = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_categoria = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_receptor = New System.Windows.Forms.BindingSource(Me.components)
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.CtrlBusquedaCombustiblePorReceptor1 = New Sigm.CtrlCombustiblePorReceptor()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.bs_ticket = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_responsable = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_proveedor = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_tipo_combustible = New System.Windows.Forms.BindingSource(Me.components)
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.StatusStrip1.SuspendLayout()
		CType(Me.bs_seccion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel5.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_ticket, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_tipo_combustible, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.info, Me.responsable_id, Me.recipiente_id})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 476)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(600, 24)
		Me.StatusStrip1.TabIndex = 399
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(514, 19)
		Me.ToolStripStatusLabel1.Spring = True
		Me.ToolStripStatusLabel1.Text = "   "
		'
		'info
		'
		Me.info.BackColor = System.Drawing.SystemColors.Control
		Me.info.Name = "info"
		Me.info.Size = New System.Drawing.Size(37, 19)
		Me.info.Text = "Info."
		'
		'responsable_id
		'
		Me.responsable_id.BackColor = System.Drawing.SystemColors.Control
		Me.responsable_id.Name = "responsable_id"
		Me.responsable_id.Size = New System.Drawing.Size(17, 19)
		Me.responsable_id.Text = "0"
		'
		'recipiente_id
		'
		Me.recipiente_id.BackColor = System.Drawing.SystemColors.Control
		Me.recipiente_id.Name = "recipiente_id"
		Me.recipiente_id.Size = New System.Drawing.Size(17, 19)
		Me.recipiente_id.Text = "0"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.DarkGray
		Me.Panel1.Controls.Add(Me.Button3)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(600, 32)
		Me.Panel1.TabIndex = 422
		'
		'Button3
		'
		Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.Color.White
		Me.Button3.Location = New System.Drawing.Point(0, 0)
		Me.Button3.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(524, 32)
		Me.Button3.TabIndex = 423
		Me.Button3.Text = "[TITULO]"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.White
		Me.Button1.Location = New System.Drawing.Point(524, 0)
		Me.Button1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(76, 32)
		Me.Button1.TabIndex = 422
		Me.Button1.Text = "CERRAR"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.Button1.UseVisualStyleBackColor = False
		'
		'CtrlBusquedaCombustiblePorReceptor1
		'
		Me.CtrlBusquedaCombustiblePorReceptor1.BackColor = System.Drawing.Color.Silver
		Me.CtrlBusquedaCombustiblePorReceptor1.Dock = System.Windows.Forms.DockStyle.Top
		Me.CtrlBusquedaCombustiblePorReceptor1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CtrlBusquedaCombustiblePorReceptor1.Location = New System.Drawing.Point(0, 32)
		Me.CtrlBusquedaCombustiblePorReceptor1.Margin = New System.Windows.Forms.Padding(0)
		Me.CtrlBusquedaCombustiblePorReceptor1.Name = "CtrlBusquedaCombustiblePorReceptor1"
		Me.CtrlBusquedaCombustiblePorReceptor1.Size = New System.Drawing.Size(600, 90)
		Me.CtrlBusquedaCombustiblePorReceptor1.TabIndex = 424
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.Panel5)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel2.Location = New System.Drawing.Point(0, 196)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(600, 280)
		Me.Panel2.TabIndex = 426
		'
		'Panel5
		'
		Me.Panel5.Controls.Add(Me.DataGridView1)
		Me.Panel5.Controls.Add(Me.Label4)
		Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel5.Location = New System.Drawing.Point(0, 0)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(600, 280)
		Me.Panel5.TabIndex = 428
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToResizeRows = False
		Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(0, 27)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(600, 253)
		Me.DataGridView1.TabIndex = 1
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Gray
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(600, 27)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "TICKETS"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 122)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(600, 74)
		Me.FlowLayoutPanel1.TabIndex = 428
		'
		'ModCombustible
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.Silver
		Me.ClientSize = New System.Drawing.Size(600, 500)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.CtrlBusquedaCombustiblePorReceptor1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Panel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MinimumSize = New System.Drawing.Size(520, 310)
		Me.Name = "ModCombustible"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.bs_seccion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_categoria, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_receptor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_ticket, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_responsable, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_tipo_combustible, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents recipiente_id As ToolStripStatusLabel
	Friend WithEvents responsable_id As ToolStripStatusLabel
	Friend WithEvents info As ToolStripStatusLabel
	Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents CtrlBusquedaCombustiblePorReceptor1 As Sigm.CtrlCombustiblePorReceptor
	Friend WithEvents Button3 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Label4 As Label
	Public WithEvents bs_ticket As BindingSource
	Public WithEvents bs_responsable As BindingSource
	Public WithEvents bs_proveedor As BindingSource
	Public WithEvents bs_seccion As BindingSource
	Public WithEvents bs_categoria As BindingSource
	Public WithEvents bs_receptor As BindingSource
	Friend WithEvents bs_tipo_combustible As BindingSource
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
