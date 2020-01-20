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
        Me.info3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bs_consulta = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_cuenta = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_persona = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Ingresos = New System.Windows.Forms.RadioButton()
        Me.Egresos = New System.Windows.Forms.RadioButton()
        Me.keyword_hacienda = New System.Windows.Forms.TextBox()
        Me.SeleccionCuenta = New System.Windows.Forms.ListBox()
        Me.ActivarFiltro = New System.Windows.Forms.CheckBox()
        Me.GrupoFiltro = New System.Windows.Forms.FlowLayoutPanel()
        Me.fecha = New System.Windows.Forms.RadioButton()
        Me.concepto = New System.Windows.Forms.RadioButton()
        Me.keyword_movimis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.final = New System.Windows.Forms.DateTimePicker()
        Me.visor = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GrupoFiltro.SuspendLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progreso, Me.info, Me.info2, Me.info3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(884, 27)
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
        Me.progreso.Size = New System.Drawing.Size(150, 21)
        Me.progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'info
        '
        Me.info.BackColor = System.Drawing.SystemColors.Control
        Me.info.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(18, 22)
        Me.info.Text = "-"
        '
        'info2
        '
        Me.info2.BackColor = System.Drawing.SystemColors.Control
        Me.info2.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info2.ForeColor = System.Drawing.Color.Green
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(18, 22)
        Me.info2.Text = "-"
        Me.info2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'info3
        '
        Me.info3.BackColor = System.Drawing.SystemColors.Control
        Me.info3.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.info3.Name = "info3"
        Me.info3.Size = New System.Drawing.Size(17, 22)
        Me.info3.Text = "-"
        Me.info3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.SeleccionCuenta)
        Me.FlowLayoutPanel1.Controls.Add(Me.ActivarFiltro)
        Me.FlowLayoutPanel1.Controls.Add(Me.GrupoFiltro)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(753, 146)
        Me.FlowLayoutPanel1.TabIndex = 149
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Ingresos)
        Me.FlowLayoutPanel2.Controls.Add(Me.Egresos)
        Me.FlowLayoutPanel2.Controls.Add(Me.keyword_hacienda)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(456, 32)
        Me.FlowLayoutPanel2.TabIndex = 167
        '
        'Ingresos
        '
        Me.Ingresos.Location = New System.Drawing.Point(3, 3)
        Me.Ingresos.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.Ingresos.Name = "Ingresos"
        Me.Ingresos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Ingresos.Size = New System.Drawing.Size(93, 23)
        Me.Ingresos.TabIndex = 148
        Me.Ingresos.Text = "Ingresos"
        Me.Ingresos.UseVisualStyleBackColor = True
        '
        'Egresos
        '
        Me.Egresos.Location = New System.Drawing.Point(96, 3)
        Me.Egresos.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Egresos.Name = "Egresos"
        Me.Egresos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Egresos.Size = New System.Drawing.Size(92, 23)
        Me.Egresos.TabIndex = 149
        Me.Egresos.Text = "Egresos"
        Me.Egresos.UseVisualStyleBackColor = True
        '
        'keyword_hacienda
        '
        Me.keyword_hacienda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.keyword_hacienda.Enabled = False
        Me.keyword_hacienda.ForeColor = System.Drawing.Color.Black
        Me.keyword_hacienda.Location = New System.Drawing.Point(191, 2)
        Me.keyword_hacienda.Margin = New System.Windows.Forms.Padding(0, 2, 0, 4)
        Me.keyword_hacienda.Name = "keyword_hacienda"
        Me.keyword_hacienda.Size = New System.Drawing.Size(262, 27)
        Me.keyword_hacienda.TabIndex = 164
        '
        'SeleccionCuenta
        '
        Me.SeleccionCuenta.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeleccionCuenta.FormattingEnabled = True
        Me.SeleccionCuenta.ItemHeight = 18
        Me.SeleccionCuenta.Location = New System.Drawing.Point(3, 41)
        Me.SeleccionCuenta.Name = "SeleccionCuenta"
        Me.SeleccionCuenta.Size = New System.Drawing.Size(456, 94)
        Me.SeleccionCuenta.TabIndex = 151
        '
        'ActivarFiltro
        '
        Me.ActivarFiltro.BackColor = System.Drawing.Color.Transparent
        Me.ActivarFiltro.Location = New System.Drawing.Point(462, 6)
        Me.ActivarFiltro.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.ActivarFiltro.Name = "ActivarFiltro"
        Me.ActivarFiltro.Size = New System.Drawing.Size(279, 23)
        Me.ActivarFiltro.TabIndex = 165
        Me.ActivarFiltro.Text = "Filtrar movimientos por:"
        Me.ActivarFiltro.UseVisualStyleBackColor = False
        '
        'GrupoFiltro
        '
        Me.GrupoFiltro.BackColor = System.Drawing.Color.Gainsboro
        Me.GrupoFiltro.Controls.Add(Me.fecha)
        Me.GrupoFiltro.Controls.Add(Me.concepto)
        Me.GrupoFiltro.Controls.Add(Me.keyword_movimis)
        Me.GrupoFiltro.Controls.Add(Me.Label2)
        Me.GrupoFiltro.Controls.Add(Me.inicio)
        Me.GrupoFiltro.Controls.Add(Me.Label3)
        Me.GrupoFiltro.Controls.Add(Me.Label1)
        Me.GrupoFiltro.Controls.Add(Me.final)
        Me.GrupoFiltro.Location = New System.Drawing.Point(465, 32)
        Me.GrupoFiltro.Name = "GrupoFiltro"
        Me.GrupoFiltro.Size = New System.Drawing.Size(276, 110)
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
        'keyword_movimis
        '
        Me.keyword_movimis.Enabled = False
        Me.keyword_movimis.Location = New System.Drawing.Point(0, 23)
        Me.keyword_movimis.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.keyword_movimis.Name = "keyword_movimis"
        Me.keyword_movimis.Size = New System.Drawing.Size(270, 27)
        Me.keyword_movimis.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 54)
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
        Me.inicio.Location = New System.Drawing.Point(53, 54)
        Me.inicio.Margin = New System.Windows.Forms.Padding(0)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(122, 27)
        Me.inicio.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 169
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 22)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Hasta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'final
        '
        Me.final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.final.Location = New System.Drawing.Point(53, 81)
        Me.final.Margin = New System.Windows.Forms.Padding(0)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(122, 27)
        Me.final.TabIndex = 170
        '
        'visor
        '
        Me.visor.AllowUserToAddRows = False
        Me.visor.AllowUserToDeleteRows = False
        Me.visor.AllowUserToResizeRows = False
        Me.visor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor.Location = New System.Drawing.Point(0, 148)
        Me.visor.Name = "visor"
        Me.visor.ReadOnly = True
        Me.visor.RowHeadersVisible = False
        Me.visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.visor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visor.Size = New System.Drawing.Size(884, 286)
        Me.visor.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 148)
        Me.Panel1.TabIndex = 150
        '
        'ConsultaMovimientos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.Panel1)
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
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.GrupoFiltro.ResumeLayout(False)
        Me.GrupoFiltro.PerformLayout()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Ingresos As RadioButton
    Friend WithEvents Egresos As RadioButton
    Friend WithEvents SeleccionCuenta As ListBox
    Friend WithEvents ActivarFiltro As CheckBox
    Friend WithEvents GrupoFiltro As FlowLayoutPanel
    Friend WithEvents fecha As RadioButton
    Friend WithEvents concepto As RadioButton
    Friend WithEvents keyword_movimis As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents inicio As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents final As DateTimePicker
    Friend WithEvents visor As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents info3 As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents keyword_hacienda As TextBox
End Class
