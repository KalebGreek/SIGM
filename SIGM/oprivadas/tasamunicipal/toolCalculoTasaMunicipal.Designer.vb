<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class toolCalculoTasaMunicipal
	Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ObrasVariasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelevamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensuraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReiniciarMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.search = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.propietario = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.obra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tenedor = New System.Windows.Forms.TextBox()
        Me.wrapper = New System.Windows.Forms.Panel()
        Me.help = New System.Windows.Forms.ListBox()
        Me.MenuStrip2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.Black
        Me.MenuStrip2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObrasVariasToolStripMenuItem, Me.RelevamientoToolStripMenuItem, Me.MensuraToolStripMenuItem, Me.ToolStripSeparator1, Me.ReiniciarMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip2.TabIndex = 48
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ObrasVariasToolStripMenuItem
        '
        Me.ObrasVariasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ObrasVariasToolStripMenuItem.Name = "ObrasVariasToolStripMenuItem"
        Me.ObrasVariasToolStripMenuItem.Size = New System.Drawing.Size(102, 25)
        Me.ObrasVariasToolStripMenuItem.Text = "Obras Varias"
        '
        'RelevamientoToolStripMenuItem
        '
        Me.RelevamientoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.RelevamientoToolStripMenuItem.Name = "RelevamientoToolStripMenuItem"
        Me.RelevamientoToolStripMenuItem.Size = New System.Drawing.Size(184, 25)
        Me.RelevamientoToolStripMenuItem.Text = "Relevamiento y Servicios"
        '
        'MensuraToolStripMenuItem
        '
        Me.MensuraToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.MensuraToolStripMenuItem.Name = "MensuraToolStripMenuItem"
        Me.MensuraToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.MensuraToolStripMenuItem.Text = "Mensura"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ReiniciarMenuItem
        '
        Me.ReiniciarMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ReiniciarMenuItem.Name = "ReiniciarMenuItem"
        Me.ReiniciarMenuItem.Size = New System.Drawing.Size(78, 25)
        Me.ReiniciarMenuItem.Text = "Reiniciar"
        '
        'search
        '
        Me.search.FlatAppearance.BorderSize = 0
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.White
        Me.search.Location = New System.Drawing.Point(716, 2)
        Me.search.Margin = New System.Windows.Forms.Padding(5, 2, 0, 0)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(26, 28)
        Me.search.TabIndex = 380
        Me.search.Text = ""
        Me.ToolTip1.SetToolTip(Me.search, "Buscar propietario")
        Me.search.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.Label40)
        Me.FlowLayoutPanel4.Controls.Add(Me.fecha)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label45)
        Me.FlowLayoutPanel4.Controls.Add(Me.cuenta)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel4.Controls.Add(Me.propietario)
        Me.FlowLayoutPanel4.Controls.Add(Me.search)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label44)
        Me.FlowLayoutPanel4.Controls.Add(Me.obra)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel4.Controls.Add(Me.tenedor)
        Me.FlowLayoutPanel4.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.0!)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(4, 33)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(747, 71)
        Me.FlowLayoutPanel4.TabIndex = 51
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(0, 2)
        Me.Label40.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(59, 20)
        Me.Label40.TabIndex = 53
        Me.Label40.Text = "Fecha"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(59, 0)
        Me.fecha.Margin = New System.Windows.Forms.Padding(0)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(114, 30)
        Me.fecha.TabIndex = 384
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(173, 2)
        Me.Label45.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(74, 20)
        Me.Label45.TabIndex = 386
        Me.Label45.Text = "Cuenta"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'cuenta
        '
        Me.cuenta.Location = New System.Drawing.Point(247, 0)
        Me.cuenta.Margin = New System.Windows.Forms.Padding(0)
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Size = New System.Drawing.Size(85, 30)
        Me.cuenta.TabIndex = 387
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(332, 2)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 378
        Me.Label6.Text = "Propietario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'propietario
        '
        Me.propietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.propietario.Location = New System.Drawing.Point(430, 0)
        Me.propietario.Margin = New System.Windows.Forms.Padding(0)
        Me.propietario.Name = "propietario"
        Me.propietario.Size = New System.Drawing.Size(281, 30)
        Me.propietario.TabIndex = 379
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(0, 37)
        Me.Label44.Margin = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(59, 20)
        Me.Label44.TabIndex = 385
        Me.Label44.Text = "Obra "
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'obra
        '
        Me.obra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.obra.Location = New System.Drawing.Point(59, 35)
        Me.obra.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.obra.Name = "obra"
        Me.obra.Size = New System.Drawing.Size(273, 30)
        Me.obra.TabIndex = 377
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(332, 37)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 20)
        Me.Label8.TabIndex = 381
        Me.Label8.Text = "Tenedor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'tenedor
        '
        Me.tenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tenedor.Location = New System.Drawing.Point(430, 35)
        Me.tenedor.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.tenedor.Name = "tenedor"
        Me.tenedor.Size = New System.Drawing.Size(281, 30)
        Me.tenedor.TabIndex = 382
        '
        'wrapper
        '
        Me.wrapper.AutoScroll = True
        Me.wrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wrapper.Location = New System.Drawing.Point(4, 110)
        Me.wrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.wrapper.Name = "wrapper"
        Me.wrapper.Size = New System.Drawing.Size(480, 482)
        Me.wrapper.TabIndex = 52
        '
        'help
        '
        Me.help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.help.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.help.FormattingEnabled = True
        Me.help.ItemHeight = 20
        Me.help.Location = New System.Drawing.Point(493, 110)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(222, 482)
        Me.help.TabIndex = 53
        Me.help.Visible = False
        '
        'toolCalculoTasaMunicipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.wrapper)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "toolCalculoTasaMunicipal"
        Me.Size = New System.Drawing.Size(800, 603)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label40 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label45 As Label
    Friend WithEvents cuenta As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents obra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents propietario As TextBox
    Friend WithEvents search As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tenedor As TextBox
    Friend WithEvents wrapper As Panel
    Friend WithEvents help As ListBox
    Friend WithEvents ObrasVariasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelevamientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MensuraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ReiniciarMenuItem As ToolStripMenuItem
End Class
