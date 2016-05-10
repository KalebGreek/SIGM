<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModCuentaAgrupada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModCuentaAgrupada))
        Me.basura1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.basura2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ca_id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bs_consulta = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_historial = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_cuentas = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_persona = New System.Windows.Forms.BindingSource(Me.components)
        Me.consulta_printdocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.bs_contrib = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_mod_contrib = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.con_pago = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.con_deuda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.mod_ca_imp_search = New System.Windows.Forms.Button()
        Me.imp_baja = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.imp_alta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imp_add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.imp_razon = New System.Windows.Forms.TextBox()
        Me.imp_lista_mod = New System.Windows.Forms.DataGridView()
        Me.TipoImpuesto = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.imp_lista_mod, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progreso, Me.info, Me.ca_id})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(442, 24)
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
        Me.info.Size = New System.Drawing.Size(15, 19)
        Me.info.Text = "-"
        '
        'ca_id
        '
        Me.ca_id.BackColor = System.Drawing.SystemColors.Control
        Me.ca_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ca_id.ForeColor = System.Drawing.Color.DimGray
        Me.ca_id.Name = "ca_id"
        Me.ca_id.Size = New System.Drawing.Size(15, 19)
        Me.ca_id.Text = "-"
        Me.ca_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bs_consulta
        '
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'bs_contrib
        '
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel2.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel2.Controls.Add(Me.con_pago)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel2.Controls.Add(Me.con_deuda)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 387)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(442, 33)
        Me.FlowLayoutPanel2.TabIndex = 139
        '
        'con_pago
        '
        Me.con_pago.ForeColor = System.Drawing.Color.ForestGreen
        Me.con_pago.Location = New System.Drawing.Point(76, 3)
        Me.con_pago.MaxLength = 15
        Me.con_pago.Name = "con_pago"
        Me.con_pago.ReadOnly = True
        Me.con_pago.Size = New System.Drawing.Size(140, 27)
        Me.con_pago.TabIndex = 156
        Me.con_pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(2, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 27)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "Pago"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'con_deuda
        '
        Me.con_deuda.ForeColor = System.Drawing.Color.Firebrick
        Me.con_deuda.Location = New System.Drawing.Point(295, 3)
        Me.con_deuda.MaxLength = 15
        Me.con_deuda.Name = "con_deuda"
        Me.con_deuda.ReadOnly = True
        Me.con_deuda.Size = New System.Drawing.Size(142, 27)
        Me.con_deuda.TabIndex = 154
        Me.con_deuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(221, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 27)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Deuda"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.TipoImpuesto)
        Me.FlowLayoutPanel1.Controls.Add(Me.mod_ca_imp_search)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.imp_alta)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.imp_baja)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.imp_razon)
        Me.FlowLayoutPanel1.Controls.Add(Me.imp_add)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(442, 100)
        Me.FlowLayoutPanel1.TabIndex = 138
        '
        'mod_ca_imp_search
        '
        Me.mod_ca_imp_search.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mod_ca_imp_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mod_ca_imp_search.Location = New System.Drawing.Point(362, 3)
        Me.mod_ca_imp_search.Name = "mod_ca_imp_search"
        Me.mod_ca_imp_search.Size = New System.Drawing.Size(72, 27)
        Me.mod_ca_imp_search.TabIndex = 159
        Me.mod_ca_imp_search.Text = "Buscar"
        Me.mod_ca_imp_search.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mod_ca_imp_search.UseVisualStyleBackColor = False
        '
        'imp_baja
        '
        Me.imp_baja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.imp_baja.Location = New System.Drawing.Point(291, 35)
        Me.imp_baja.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_baja.Name = "imp_baja"
        Me.imp_baja.Size = New System.Drawing.Size(111, 27)
        Me.imp_baja.TabIndex = 153
        Me.imp_baja.Value = New Date(1899, 1, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 27)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Baja"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'imp_alta
        '
        Me.imp_alta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.imp_alta.Location = New System.Drawing.Point(75, 35)
        Me.imp_alta.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_alta.Name = "imp_alta"
        Me.imp_alta.Size = New System.Drawing.Size(111, 27)
        Me.imp_alta.TabIndex = 151
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 27)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Alta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'imp_add
        '
        Me.imp_add.BackColor = System.Drawing.Color.LightCoral
        Me.imp_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imp_add.ForeColor = System.Drawing.Color.White
        Me.imp_add.Location = New System.Drawing.Point(277, 66)
        Me.imp_add.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_add.Name = "imp_add"
        Me.imp_add.Size = New System.Drawing.Size(157, 27)
        Me.imp_add.TabIndex = 149
        Me.imp_add.Text = "Agregar Impuesto"
        Me.imp_add.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.imp_add.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 27)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Impuesto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 27)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "Titular"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'imp_razon
        '
        Me.imp_razon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.imp_razon.Enabled = False
        Me.imp_razon.Location = New System.Drawing.Point(75, 66)
        Me.imp_razon.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_razon.Name = "imp_razon"
        Me.imp_razon.Size = New System.Drawing.Size(198, 27)
        Me.imp_razon.TabIndex = 146
        '
        'imp_lista_mod
        '
        Me.imp_lista_mod.AllowUserToAddRows = False
        Me.imp_lista_mod.AllowUserToResizeRows = False
        Me.imp_lista_mod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.imp_lista_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imp_lista_mod.Location = New System.Drawing.Point(0, 0)
        Me.imp_lista_mod.Margin = New System.Windows.Forms.Padding(2)
        Me.imp_lista_mod.Name = "imp_lista_mod"
        Me.imp_lista_mod.RowHeadersVisible = False
        Me.imp_lista_mod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.imp_lista_mod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.imp_lista_mod.Size = New System.Drawing.Size(442, 420)
        Me.imp_lista_mod.TabIndex = 137
        '
        'TipoImpuesto
        '
        Me.TipoImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoImpuesto.FormattingEnabled = True
        Me.TipoImpuesto.Items.AddRange(New Object() {"AGUA", "AUTOMOVIL", "CATASTRO", "CEMENTERIO", "COMERCIO"})
        Me.TipoImpuesto.Location = New System.Drawing.Point(76, 3)
        Me.TipoImpuesto.Name = "TipoImpuesto"
        Me.TipoImpuesto.Size = New System.Drawing.Size(280, 27)
        Me.TipoImpuesto.TabIndex = 160
        '
        'ModCuentaAgrupada
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(442, 444)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.imp_lista_mod)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ModCuentaAgrupada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Cuenta Agrupada"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_persona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_contrib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_mod_contrib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.imp_lista_mod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents basura1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents basura2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bs_cuentas As System.Windows.Forms.BindingSource
    Friend WithEvents bs_historial As System.Windows.Forms.BindingSource
    Friend WithEvents bs_consulta As System.Windows.Forms.BindingSource
    Friend WithEvents bs_persona As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ca_id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents consulta_printdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents bs_contrib As System.Windows.Forms.BindingSource
    Friend WithEvents bs_mod_contrib As System.Windows.Forms.BindingSource
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents con_pago As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents con_deuda As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TipoImpuesto As ComboBox
    Friend WithEvents mod_ca_imp_search As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents imp_alta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents imp_baja As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents imp_razon As TextBox
    Friend WithEvents imp_add As Button
    Friend WithEvents imp_lista_mod As DataGridView
End Class
