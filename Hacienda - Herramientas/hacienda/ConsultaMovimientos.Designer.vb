<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaMovimientos
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaMovimientos))
		Me.basura1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.basura2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.info = New System.Windows.Forms.ToolStripStatusLabel()
		Me.info2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.bs_consulta = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_cuenta = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_persona = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_contrib = New System.Windows.Forms.BindingSource(Me.components)
		Me.bs_mod_contrib = New System.Windows.Forms.BindingSource(Me.components)
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Ingresos = New System.Windows.Forms.RadioButton()
		Me.Egresos = New System.Windows.Forms.RadioButton()
		Me.SeleccionCuenta = New System.Windows.Forms.ListBox()
		Me.ActivarFiltro = New System.Windows.Forms.CheckBox()
		Me.GrupoFiltro = New System.Windows.Forms.FlowLayoutPanel()
		Me.fecha = New System.Windows.Forms.RadioButton()
		Me.concepto = New System.Windows.Forms.RadioButton()
		Me.Keyword = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.inicio = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.final = New System.Windows.Forms.DateTimePicker()
		Me.visor = New System.Windows.Forms.DataGridView()
		Me.actualizar = New System.Windows.Forms.Button()
		Me.StatusStrip1.SuspendLayout()
		CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.GrupoFiltro.SuspendLayout()
		CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'basura1
		'
		Me.basura1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.basura1.Name = "basura1"
		Me.basura1.Size = New System.Drawing.Size(94, 17)
		'
		'basura2
		'
		Me.basura2.ActiveLinkColor = System.Drawing.Color.Black
		Me.basura2.LinkColor = System.Drawing.Color.Black
		Me.basura2.Name = "basura2"
		Me.basura2.Size = New System.Drawing.Size(132, 17)
		Me.basura2.Text = "SELECT * FROM agucue"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
		Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progreso, Me.info, Me.info2})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 437)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
		Me.StatusStrip1.Size = New System.Drawing.Size(784, 24)
		Me.StatusStrip1.SizingGrip = False
		Me.StatusStrip1.TabIndex = 2
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'progreso
		'
		Me.progreso.Maximum = 20
		Me.progreso.Name = "progreso"
		Me.progreso.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
		Me.progreso.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.progreso.Size = New System.Drawing.Size(150, 18)
		Me.progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		'
		'info
		'
		Me.info.BackColor = System.Drawing.SystemColors.Control
		Me.info.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.info.Name = "info"
		Me.info.Size = New System.Drawing.Size(56, 19)
		Me.info.Text = "TOTAL:"
		'
		'info2
		'
		Me.info2.BackColor = System.Drawing.SystemColors.Control
		Me.info2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.info2.ForeColor = System.Drawing.Color.Black
		Me.info2.Name = "info2"
		Me.info2.Size = New System.Drawing.Size(15, 19)
		Me.info2.Text = "-"
		Me.info2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.visor)
		Me.SplitContainer1.Size = New System.Drawing.Size(784, 437)
		Me.SplitContainer1.SplitterDistance = 139
		Me.SplitContainer1.TabIndex = 6
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
		Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
		Me.FlowLayoutPanel1.Controls.Add(Me.SeleccionCuenta)
		Me.FlowLayoutPanel1.Controls.Add(Me.ActivarFiltro)
		Me.FlowLayoutPanel1.Controls.Add(Me.GrupoFiltro)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(784, 191)
		Me.FlowLayoutPanel1.TabIndex = 148
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.Controls.Add(Me.Ingresos)
		Me.FlowLayoutPanel2.Controls.Add(Me.Egresos)
		Me.FlowLayoutPanel2.Controls.Add(Me.actualizar)
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(353, 26)
		Me.FlowLayoutPanel2.TabIndex = 167
		'
		'Ingresos
		'
		Me.Ingresos.Checked = True
		Me.Ingresos.Location = New System.Drawing.Point(3, 3)
		Me.Ingresos.Name = "Ingresos"
		Me.Ingresos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.Ingresos.Size = New System.Drawing.Size(99, 23)
		Me.Ingresos.TabIndex = 148
		Me.Ingresos.TabStop = True
		Me.Ingresos.Text = "Ingresos"
		Me.Ingresos.UseVisualStyleBackColor = True
		'
		'Egresos
		'
		Me.Egresos.Location = New System.Drawing.Point(108, 3)
		Me.Egresos.Name = "Egresos"
		Me.Egresos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.Egresos.Size = New System.Drawing.Size(101, 23)
		Me.Egresos.TabIndex = 149
		Me.Egresos.Text = "Egresos"
		Me.Egresos.UseVisualStyleBackColor = True
		'
		'SeleccionCuenta
		'
		Me.SeleccionCuenta.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SeleccionCuenta.FormattingEnabled = True
		Me.SeleccionCuenta.ItemHeight = 18
		Me.SeleccionCuenta.Location = New System.Drawing.Point(3, 35)
		Me.SeleccionCuenta.Name = "SeleccionCuenta"
		Me.SeleccionCuenta.Size = New System.Drawing.Size(353, 94)
		Me.SeleccionCuenta.TabIndex = 151
		'
		'ActivarFiltro
		'
		Me.ActivarFiltro.BackColor = System.Drawing.Color.Transparent
		Me.ActivarFiltro.Location = New System.Drawing.Point(0, 132)
		Me.ActivarFiltro.Margin = New System.Windows.Forms.Padding(0)
		Me.ActivarFiltro.Name = "ActivarFiltro"
		Me.ActivarFiltro.Size = New System.Drawing.Size(263, 23)
		Me.ActivarFiltro.TabIndex = 165
		Me.ActivarFiltro.Text = "Filtrar movimientos por:"
		Me.ActivarFiltro.UseVisualStyleBackColor = False
		'
		'GrupoFiltro
		'
		Me.GrupoFiltro.BackColor = System.Drawing.Color.Gainsboro
		Me.GrupoFiltro.Controls.Add(Me.fecha)
		Me.GrupoFiltro.Controls.Add(Me.concepto)
		Me.GrupoFiltro.Controls.Add(Me.Keyword)
		Me.GrupoFiltro.Controls.Add(Me.Label2)
		Me.GrupoFiltro.Controls.Add(Me.inicio)
		Me.GrupoFiltro.Controls.Add(Me.Label3)
		Me.GrupoFiltro.Controls.Add(Me.final)
		Me.GrupoFiltro.Location = New System.Drawing.Point(362, 3)
		Me.GrupoFiltro.Name = "GrupoFiltro"
		Me.GrupoFiltro.Size = New System.Drawing.Size(276, 131)
		Me.GrupoFiltro.TabIndex = 166
		Me.GrupoFiltro.Visible = False
		'
		'fecha
		'
		Me.fecha.AutoSize = True
		Me.fecha.Checked = True
		Me.fecha.Location = New System.Drawing.Point(0, 0)
		Me.fecha.Margin = New System.Windows.Forms.Padding(0)
		Me.fecha.Name = "fecha"
		Me.fecha.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.fecha.Size = New System.Drawing.Size(77, 23)
		Me.fecha.TabIndex = 166
		Me.fecha.TabStop = True
		Me.fecha.Text = "Fecha"
		Me.fecha.UseVisualStyleBackColor = True
		'
		'concepto
		'
		Me.concepto.AutoSize = True
		Me.concepto.Location = New System.Drawing.Point(77, 0)
		Me.concepto.Margin = New System.Windows.Forms.Padding(0)
		Me.concepto.Name = "concepto"
		Me.concepto.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.concepto.Size = New System.Drawing.Size(98, 23)
		Me.concepto.TabIndex = 165
		Me.concepto.Text = "Concepto"
		Me.concepto.UseVisualStyleBackColor = True
		'
		'Keyword
		'
		Me.Keyword.Enabled = False
		Me.Keyword.Location = New System.Drawing.Point(0, 23)
		Me.Keyword.Margin = New System.Windows.Forms.Padding(0)
		Me.Keyword.Name = "Keyword"
		Me.Keyword.Size = New System.Drawing.Size(270, 27)
		Me.Keyword.TabIndex = 163
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(0, 50)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 22)
		Me.Label2.TabIndex = 168
		Me.Label2.Text = "Desde"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'inicio
		'
		Me.inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.inicio.Location = New System.Drawing.Point(53, 50)
		Me.inicio.Margin = New System.Windows.Forms.Padding(0)
		Me.inicio.Name = "inicio"
		Me.inicio.Size = New System.Drawing.Size(207, 27)
		Me.inicio.TabIndex = 167
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(0, 77)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 22)
		Me.Label3.TabIndex = 169
		Me.Label3.Text = "Hasta"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'final
		'
		Me.final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.final.Location = New System.Drawing.Point(53, 77)
		Me.final.Margin = New System.Windows.Forms.Padding(0)
		Me.final.Name = "final"
		Me.final.Size = New System.Drawing.Size(207, 27)
		Me.final.TabIndex = 170
		'
		'visor
		'
		Me.visor.AllowUserToAddRows = False
		Me.visor.AllowUserToDeleteRows = False
		Me.visor.AllowUserToResizeRows = False
		Me.visor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
		Me.visor.Location = New System.Drawing.Point(0, 0)
		Me.visor.Name = "visor"
		Me.visor.ReadOnly = True
		Me.visor.RowHeadersVisible = False
		Me.visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.visor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.visor.Size = New System.Drawing.Size(784, 294)
		Me.visor.TabIndex = 6
		'
		'actualizar
		'
		Me.actualizar.Location = New System.Drawing.Point(212, 1)
		Me.actualizar.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
		Me.actualizar.Name = "actualizar"
		Me.actualizar.Size = New System.Drawing.Size(90, 23)
		Me.actualizar.TabIndex = 150
		Me.actualizar.Text = "Actualizar"
		Me.actualizar.UseVisualStyleBackColor = True
		'
		'ConsultaMovimientos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(784, 461)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MinimumSize = New System.Drawing.Size(800, 500)
		Me.Name = "ConsultaMovimientos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Consulta de Movimientos"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.GrupoFiltro.ResumeLayout(False)
		Me.GrupoFiltro.PerformLayout()
		CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents basura1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents basura2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bs_cuenta As System.Windows.Forms.BindingSource
    Friend WithEvents bs_consulta As System.Windows.Forms.BindingSource
    Friend WithEvents bs_persona As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents info2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents bs_contrib As System.Windows.Forms.BindingSource
    Friend WithEvents bs_mod_contrib As System.Windows.Forms.BindingSource
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents Ingresos As RadioButton
	Friend WithEvents Egresos As RadioButton
	Friend WithEvents SeleccionCuenta As ListBox
	Friend WithEvents ActivarFiltro As CheckBox
	Friend WithEvents GrupoFiltro As FlowLayoutPanel
	Friend WithEvents fecha As RadioButton
	Friend WithEvents concepto As RadioButton
	Friend WithEvents Keyword As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents inicio As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents final As DateTimePicker
	Friend WithEvents visor As DataGridView
	Friend WithEvents actualizar As Button
End Class
