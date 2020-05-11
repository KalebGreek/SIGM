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
        Me.CalcularTasaMunicipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.search = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.propietario = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.obra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tenedor = New System.Windows.Forms.TextBox()
        Me.CalcTasaMunicipalPlanosEdif1 = New Sigm.calcTasaMunicipalPlanosEdif()
        Me.CalcTasaMunicipalObras1 = New Sigm.calcTasaMunicipalObras()
        Me.MenuStrip2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.Black
        Me.MenuStrip2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularTasaMunicipalToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.ReiniciarMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip2.TabIndex = 48
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CalcularTasaMunicipalToolStripMenuItem
        '
        Me.CalcularTasaMunicipalToolStripMenuItem.Enabled = False
        Me.CalcularTasaMunicipalToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CalcularTasaMunicipalToolStripMenuItem.Name = "CalcularTasaMunicipalToolStripMenuItem"
        Me.CalcularTasaMunicipalToolStripMenuItem.Size = New System.Drawing.Size(173, 25)
        Me.CalcularTasaMunicipalToolStripMenuItem.Text = "Calcular Tasa Municipal"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(73, 25)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ReiniciarMenuItem
        '
        Me.ReiniciarMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReiniciarMenuItem.Name = "ReiniciarMenuItem"
        Me.ReiniciarMenuItem.Size = New System.Drawing.Size(78, 25)
        Me.ReiniciarMenuItem.Text = "Reiniciar"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 105)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(440, 495)
        Me.TabControl1.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.CalcTasaMunicipalObras1)
        Me.TabPage1.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(432, 457)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Obras"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.CalcTasaMunicipalPlanosEdif1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(432, 457)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Planos de Edificación"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightGray
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(432, 457)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Planos de Mensura"
        '
        'search
        '
        Me.search.FlatAppearance.BorderSize = 0
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.White
        Me.search.Location = New System.Drawing.Point(719, 2)
        Me.search.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
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
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox7)
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
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(756, 70)
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
        Me.Label45.Size = New System.Drawing.Size(82, 20)
        Me.Label45.TabIndex = 386
        Me.Label45.Text = "Cuenta"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(255, 0)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(85, 30)
        Me.TextBox7.TabIndex = 387
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(340, 2)
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
        Me.propietario.Location = New System.Drawing.Point(438, 0)
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
        Me.obra.Size = New System.Drawing.Size(281, 30)
        Me.obra.TabIndex = 377
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(340, 37)
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
        Me.tenedor.Location = New System.Drawing.Point(438, 35)
        Me.tenedor.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.tenedor.Name = "tenedor"
        Me.tenedor.Size = New System.Drawing.Size(281, 30)
        Me.tenedor.TabIndex = 382
        '
        'CalcTasaMunicipalPlanosEdif1
        '
        Me.CalcTasaMunicipalPlanosEdif1.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcTasaMunicipalPlanosEdif1.Location = New System.Drawing.Point(0, 0)
        Me.CalcTasaMunicipalPlanosEdif1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CalcTasaMunicipalPlanosEdif1.Name = "CalcTasaMunicipalPlanosEdif1"
        Me.CalcTasaMunicipalPlanosEdif1.Size = New System.Drawing.Size(410, 520)
        Me.CalcTasaMunicipalPlanosEdif1.TabIndex = 0
        '
        'CalcTasaMunicipalObras1
        '
        Me.CalcTasaMunicipalObras1.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcTasaMunicipalObras1.Location = New System.Drawing.Point(0, 0)
        Me.CalcTasaMunicipalObras1.Margin = New System.Windows.Forms.Padding(0)
        Me.CalcTasaMunicipalObras1.Name = "CalcTasaMunicipalObras1"
        Me.CalcTasaMunicipalObras1.Size = New System.Drawing.Size(410, 187)
        Me.CalcTasaMunicipalObras1.TabIndex = 0
        '
        'toolCalculoTasaMunicipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "toolCalculoTasaMunicipal"
        Me.Size = New System.Drawing.Size(800, 600)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label40 As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents obra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents propietario As TextBox
    Friend WithEvents search As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tenedor As TextBox
    Friend WithEvents CalcularTasaMunicipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ReiniciarMenuItem As ToolStripMenuItem
    Friend WithEvents CalcTasaMunicipalPlanosEdif1 As calcTasaMunicipalPlanosEdif
    Friend WithEvents CalcTasaMunicipalObras1 As calcTasaMunicipalObras
End Class
