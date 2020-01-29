<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaIntimaciones
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
        Me.bs_contribuyente = New System.Windows.Forms.BindingSource(Me.components)
        Me.bs_intimaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.visor_contribuyente = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GenSearchControl1 = New Sigm.genSearchControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.estado0 = New System.Windows.Forms.TextBox()
        Me.estado1 = New System.Windows.Forms.TextBox()
        Me.estado2 = New System.Windows.Forms.TextBox()
        Me.estado3 = New System.Windows.Forms.TextBox()
        Me.estado4 = New System.Windows.Forms.TextBox()
        Me.estado5 = New System.Windows.Forms.TextBox()
        Me.estado6 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.nuevaInt = New System.Windows.Forms.Button()
        Me.historialInt = New System.Windows.Forms.Button()
        Me.print = New System.Windows.Forms.Button()
        Me.opcion_aviso = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.info2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.bs_contribuyente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_intimaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visor_contribuyente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bs_contribuyente
        '
        '
        'visor_contribuyente
        '
        Me.visor_contribuyente.AllowUserToAddRows = False
        Me.visor_contribuyente.AllowUserToDeleteRows = False
        Me.visor_contribuyente.AllowUserToResizeRows = False
        Me.visor_contribuyente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.visor_contribuyente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visor_contribuyente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor_contribuyente.EnableHeadersVisualStyles = False
        Me.visor_contribuyente.Location = New System.Drawing.Point(0, 34)
        Me.visor_contribuyente.Name = "visor_contribuyente"
        Me.visor_contribuyente.ReadOnly = True
        Me.visor_contribuyente.RowHeadersVisible = False
        Me.visor_contribuyente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.visor_contribuyente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.visor_contribuyente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visor_contribuyente.ShowCellErrors = False
        Me.visor_contribuyente.ShowCellToolTips = False
        Me.visor_contribuyente.ShowEditingIcon = False
        Me.visor_contribuyente.ShowRowErrors = False
        Me.visor_contribuyente.Size = New System.Drawing.Size(888, 485)
        Me.visor_contribuyente.TabIndex = 3
        Me.visor_contribuyente.VirtualMode = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.GenSearchControl1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 34)
        Me.Panel1.TabIndex = 7
        '
        'GenSearchControl1
        '
        Me.GenSearchControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GenSearchControl1.BackColor = System.Drawing.Color.Silver
        Me.GenSearchControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GenSearchControl1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenSearchControl1.Location = New System.Drawing.Point(73, 0)
        Me.GenSearchControl1.Name = "GenSearchControl1"
        Me.GenSearchControl1.Size = New System.Drawing.Size(960, 34)
        Me.GenSearchControl1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 34)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Servicio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.LightGray
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.estado0)
        Me.FlowLayoutPanel1.Controls.Add(Me.estado1)
        Me.FlowLayoutPanel1.Controls.Add(Me.estado2)
        Me.FlowLayoutPanel1.Controls.Add(Me.estado3)
        Me.FlowLayoutPanel1.Controls.Add(Me.estado4)
        Me.FlowLayoutPanel1.Controls.Add(Me.estado5)
        Me.FlowLayoutPanel1.Controls.Add(Me.estado6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 219)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(145, 266)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Leyenda:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'estado0
        '
        Me.estado0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.estado0.Location = New System.Drawing.Point(0, 19)
        Me.estado0.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.estado0.Name = "estado0"
        Me.estado0.Size = New System.Drawing.Size(143, 20)
        Me.estado0.TabIndex = 16
        Me.estado0.Text = "SIN DEUDA"
        Me.estado0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estado1
        '
        Me.estado1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.estado1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.estado1.ForeColor = System.Drawing.Color.White
        Me.estado1.Location = New System.Drawing.Point(0, 40)
        Me.estado1.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.estado1.Name = "estado1"
        Me.estado1.Size = New System.Drawing.Size(143, 20)
        Me.estado1.TabIndex = 9
        Me.estado1.Text = " PLAN DE PAGOS"
        Me.estado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estado2
        '
        Me.estado2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.estado2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.estado2.ForeColor = System.Drawing.Color.White
        Me.estado2.Location = New System.Drawing.Point(0, 61)
        Me.estado2.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.estado2.Name = "estado2"
        Me.estado2.Size = New System.Drawing.Size(143, 20)
        Me.estado2.TabIndex = 10
        Me.estado2.Text = "CONTACTADO"
        Me.estado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estado3
        '
        Me.estado3.BackColor = System.Drawing.Color.Plum
        Me.estado3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.estado3.ForeColor = System.Drawing.Color.White
        Me.estado3.Location = New System.Drawing.Point(0, 82)
        Me.estado3.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.estado3.Name = "estado3"
        Me.estado3.Size = New System.Drawing.Size(143, 20)
        Me.estado3.TabIndex = 11
        Me.estado3.Text = "EN MORA"
        Me.estado3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estado4
        '
        Me.estado4.BackColor = System.Drawing.Color.Goldenrod
        Me.estado4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.estado4.ForeColor = System.Drawing.Color.White
        Me.estado4.Location = New System.Drawing.Point(0, 103)
        Me.estado4.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.estado4.Name = "estado4"
        Me.estado4.Size = New System.Drawing.Size(143, 20)
        Me.estado4.TabIndex = 12
        Me.estado4.Text = " CARTA DOCUMENTO"
        Me.estado4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estado5
        '
        Me.estado5.BackColor = System.Drawing.Color.Tomato
        Me.estado5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.estado5.ForeColor = System.Drawing.Color.White
        Me.estado5.Location = New System.Drawing.Point(0, 124)
        Me.estado5.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.estado5.Name = "estado5"
        Me.estado5.Size = New System.Drawing.Size(143, 20)
        Me.estado5.TabIndex = 13
        Me.estado5.Text = "PRE-JUDICIAL"
        Me.estado5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estado6
        '
        Me.estado6.BackColor = System.Drawing.Color.Firebrick
        Me.estado6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.estado6.ForeColor = System.Drawing.Color.White
        Me.estado6.Location = New System.Drawing.Point(0, 145)
        Me.estado6.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.estado6.Name = "estado6"
        Me.estado6.Size = New System.Drawing.Size(143, 20)
        Me.estado6.TabIndex = 14
        Me.estado6.Text = "JUDICIAL"
        Me.estado6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 55)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "- La deuda mostrada no incluye intereses por mora"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(888, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(145, 485)
        Me.Panel2.TabIndex = 9
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.nuevaInt)
        Me.FlowLayoutPanel2.Controls.Add(Me.historialInt)
        Me.FlowLayoutPanel2.Controls.Add(Me.print)
        Me.FlowLayoutPanel2.Controls.Add(Me.opcion_aviso)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Enabled = False
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(145, 219)
        Me.FlowLayoutPanel2.TabIndex = 9
        '
        'nuevaInt
        '
        Me.nuevaInt.Location = New System.Drawing.Point(3, 3)
        Me.nuevaInt.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.nuevaInt.Name = "nuevaInt"
        Me.nuevaInt.Size = New System.Drawing.Size(139, 26)
        Me.nuevaInt.TabIndex = 1
        Me.nuevaInt.Text = "Nueva Intimación"
        Me.nuevaInt.UseVisualStyleBackColor = True
        '
        'historialInt
        '
        Me.historialInt.Location = New System.Drawing.Point(3, 32)
        Me.historialInt.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.historialInt.Name = "historialInt"
        Me.historialInt.Size = New System.Drawing.Size(139, 26)
        Me.historialInt.TabIndex = 2
        Me.historialInt.Text = "Historial"
        Me.historialInt.UseVisualStyleBackColor = True
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(3, 61)
        Me.print.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(139, 26)
        Me.print.TabIndex = 3
        Me.print.Text = "Imprimir Aviso"
        Me.print.UseVisualStyleBackColor = True
        '
        'opcion_aviso
        '
        Me.opcion_aviso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.opcion_aviso.FormattingEnabled = True
        Me.opcion_aviso.Items.AddRange(New Object() {"Aviso de Deuda", "Reiteración de Aviso de Deuda", "Reducción de Servicio"})
        Me.opcion_aviso.Location = New System.Drawing.Point(3, 90)
        Me.opcion_aviso.Name = "opcion_aviso"
        Me.opcion_aviso.Size = New System.Drawing.Size(139, 27)
        Me.opcion_aviso.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progreso, Me.info, Me.info2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 519)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1033, 24)
        Me.StatusStrip1.TabIndex = 10
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
        'info2
        '
        Me.info2.BackColor = System.Drawing.SystemColors.Control
        Me.info2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info2.ForeColor = System.Drawing.Color.DimGray
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(15, 19)
        Me.info2.Text = "-"
        Me.info2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConsultaIntimaciones
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1033, 543)
        Me.Controls.Add(Me.visor_contribuyente)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ConsultaIntimaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Intimaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bs_contribuyente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_intimaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visor_contribuyente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bs_contribuyente As BindingSource
    Friend WithEvents bs_intimaciones As BindingSource
    Public WithEvents visor_contribuyente As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GenSearchControl1 As genSearchControl
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents estado1 As TextBox
    Friend WithEvents estado2 As TextBox
    Friend WithEvents estado3 As TextBox
    Friend WithEvents estado4 As TextBox
    Friend WithEvents estado5 As TextBox
    Friend WithEvents estado6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents estado0 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents nuevaInt As Button
    Friend WithEvents historialInt As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents progreso As ToolStripProgressBar
    Friend WithEvents info As ToolStripStatusLabel
    Friend WithEvents info2 As ToolStripStatusLabel
    Friend WithEvents print As Button
    Friend WithEvents opcion_aviso As ComboBox
End Class
