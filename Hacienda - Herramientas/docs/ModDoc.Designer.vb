<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModDoc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Menu1 = New System.Windows.Forms.MenuStrip()
        Me.titulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tipo_archivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.indice = New System.Windows.Forms.MenuStrip()
        Me.opt_cargar = New System.Windows.Forms.ToolStripMenuItem()
        Me.opt_print = New System.Windows.Forms.ToolStripMenuItem()
        Me.opt_back = New System.Windows.Forms.ToolStripMenuItem()
        Me.historial = New System.Windows.Forms.DataGridView()
        Me.bs_historial = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabla_documento = New System.Windows.Forms.Label()
        Me.valor_id = New System.Windows.Forms.Label()
        Me.Menu1.SuspendLayout()
        Me.indice.SuspendLayout()
        CType(Me.historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu1
        '
        Me.Menu1.AutoSize = False
        Me.Menu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Menu1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.titulo, Me.tipo_archivo})
        Me.Menu1.Location = New System.Drawing.Point(0, 0)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(800, 36)
        Me.Menu1.TabIndex = 379
        Me.Menu1.Text = "MenuStrip1"
        '
        'titulo
        '
        Me.titulo.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!)
        Me.titulo.ForeColor = System.Drawing.Color.White
        Me.titulo.Name = "titulo"
        Me.titulo.Padding = New System.Windows.Forms.Padding(0)
        Me.titulo.Size = New System.Drawing.Size(248, 32)
        Me.titulo.Text = "EXPLORADOR DE ARCHIVO >"
        '
        'tipo_archivo
        '
        Me.tipo_archivo.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!)
        Me.tipo_archivo.ForeColor = System.Drawing.Color.White
        Me.tipo_archivo.Name = "tipo_archivo"
        Me.tipo_archivo.Padding = New System.Windows.Forms.Padding(0)
        Me.tipo_archivo.Size = New System.Drawing.Size(134, 32)
        Me.tipo_archivo.Text = "Tipo de archivo"
        Me.tipo_archivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'indice
        '
        Me.indice.AutoSize = False
        Me.indice.BackColor = System.Drawing.Color.Gray
        Me.indice.Dock = System.Windows.Forms.DockStyle.Right
        Me.indice.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indice.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opt_cargar, Me.opt_print, Me.opt_back})
        Me.indice.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.indice.Location = New System.Drawing.Point(652, 36)
        Me.indice.Name = "indice"
        Me.indice.Padding = New System.Windows.Forms.Padding(0)
        Me.indice.Size = New System.Drawing.Size(148, 502)
        Me.indice.TabIndex = 380
        Me.indice.Text = "MenuStrip1"
        '
        'opt_cargar
        '
        Me.opt_cargar.AutoSize = False
        Me.opt_cargar.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
        Me.opt_cargar.ForeColor = System.Drawing.Color.White
        Me.opt_cargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.opt_cargar.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.opt_cargar.Name = "opt_cargar"
        Me.opt_cargar.Size = New System.Drawing.Size(140, 40)
        Me.opt_cargar.Text = "CARGAR  "
        Me.opt_cargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opt_print
        '
        Me.opt_print.AutoSize = False
        Me.opt_print.Enabled = False
        Me.opt_print.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
        Me.opt_print.ForeColor = System.Drawing.Color.White
        Me.opt_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.opt_print.Name = "opt_print"
        Me.opt_print.Size = New System.Drawing.Size(140, 40)
        Me.opt_print.Text = "VER / IMPRIMIR"
        Me.opt_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'opt_back
        '
        Me.opt_back.AutoSize = False
        Me.opt_back.Font = New System.Drawing.Font("PF DinText Pro", 15.0!)
        Me.opt_back.ForeColor = System.Drawing.Color.White
        Me.opt_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.opt_back.Name = "opt_back"
        Me.opt_back.Size = New System.Drawing.Size(140, 40)
        Me.opt_back.Text = "VOLVER"
        Me.opt_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'historial
        '
        Me.historial.AllowUserToAddRows = False
        Me.historial.AllowUserToDeleteRows = False
        Me.historial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.historial.Location = New System.Drawing.Point(0, 36)
        Me.historial.MultiSelect = False
        Me.historial.Name = "historial"
        Me.historial.ReadOnly = True
        Me.historial.RowHeadersVisible = False
        Me.historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.historial.Size = New System.Drawing.Size(652, 502)
        Me.historial.TabIndex = 382
        '
        'bs_historial
        '
        '
        'tabla_documento
        '
        Me.tabla_documento.AutoSize = True
        Me.tabla_documento.Location = New System.Drawing.Point(659, 227)
        Me.tabla_documento.Name = "tabla_documento"
        Me.tabla_documento.Size = New System.Drawing.Size(14, 19)
        Me.tabla_documento.TabIndex = 384
        Me.tabla_documento.Text = "t"
        '
        'valor_id
        '
        Me.valor_id.AutoSize = True
        Me.valor_id.Location = New System.Drawing.Point(659, 287)
        Me.valor_id.Name = "valor_id"
        Me.valor_id.Size = New System.Drawing.Size(17, 19)
        Me.valor_id.TabIndex = 386
        Me.valor_id.Text = "0"
        '
        'ModDoc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.historial)
        Me.Controls.Add(Me.valor_id)
        Me.Controls.Add(Me.tabla_documento)
        Me.Controls.Add(Me.indice)
        Me.Controls.Add(Me.Menu1)
        Me.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModDoc"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu1.ResumeLayout(False)
        Me.Menu1.PerformLayout()
        Me.indice.ResumeLayout(False)
        Me.indice.PerformLayout()
        CType(Me.historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_historial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents titulo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents indice As System.Windows.Forms.MenuStrip
    Friend WithEvents opt_cargar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opt_back As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opt_print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents historial As System.Windows.Forms.DataGridView
    Friend WithEvents tipo_archivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bs_historial As System.Windows.Forms.BindingSource
    Friend WithEvents tabla_documento As System.Windows.Forms.Label
    Friend WithEvents valor_id As System.Windows.Forms.Label
End Class
