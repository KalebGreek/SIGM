<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class toolCalculoPlanos
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
		Me.CalculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CálculoDeObrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CálculoDePlanosDeEdificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CálculoDePlanosDeMensuraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.titulo = New System.Windows.Forms.ToolStripMenuItem()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.obra = New System.Windows.Forms.TextBox()
		Me.reset = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.propietario = New System.Windows.Forms.TextBox()
		Me.search = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.tenedor = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.costo = New System.Windows.Forms.NumericUpDown()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.metrosFrente = New System.Windows.Forms.NumericUpDown()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.metrosCalle = New System.Windows.Forms.NumericUpDown()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.total = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.descuento = New System.Windows.Forms.NumericUpDown()
		Me.montoDescuento = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.cuotas = New System.Windows.Forms.NumericUpDown()
		Me.montoCuota = New System.Windows.Forms.Label()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.MenuStrip2.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.costo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.metrosFrente, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.metrosCalle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.descuento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip2
		'
		Me.MenuStrip2.AutoSize = False
		Me.MenuStrip2.BackColor = System.Drawing.Color.DimGray
		Me.MenuStrip2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculosToolStripMenuItem, Me.titulo})
		Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip2.Name = "MenuStrip2"
		Me.MenuStrip2.Size = New System.Drawing.Size(400, 29)
		Me.MenuStrip2.TabIndex = 48
		Me.MenuStrip2.Text = "MenuStrip2"
		'
		'CalculosToolStripMenuItem
		'
		Me.CalculosToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.CalculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CálculoDeObrasToolStripMenuItem, Me.CálculoDePlanosDeEdificaciónToolStripMenuItem, Me.CálculoDePlanosDeMensuraToolStripMenuItem})
		Me.CalculosToolStripMenuItem.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CalculosToolStripMenuItem.ForeColor = System.Drawing.Color.White
		Me.CalculosToolStripMenuItem.Name = "CalculosToolStripMenuItem"
		Me.CalculosToolStripMenuItem.Size = New System.Drawing.Size(37, 25)
		Me.CalculosToolStripMenuItem.Text = ""
		'
		'CálculoDeObrasToolStripMenuItem
		'
		Me.CálculoDeObrasToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CálculoDeObrasToolStripMenuItem.Name = "CálculoDeObrasToolStripMenuItem"
		Me.CálculoDeObrasToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
		Me.CálculoDeObrasToolStripMenuItem.Text = "Cálculo de Obras"
		'
		'CálculoDePlanosDeEdificaciónToolStripMenuItem
		'
		Me.CálculoDePlanosDeEdificaciónToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CálculoDePlanosDeEdificaciónToolStripMenuItem.Name = "CálculoDePlanosDeEdificaciónToolStripMenuItem"
		Me.CálculoDePlanosDeEdificaciónToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
		Me.CálculoDePlanosDeEdificaciónToolStripMenuItem.Text = "Cálculo de Planos de Edificación"
		'
		'CálculoDePlanosDeMensuraToolStripMenuItem
		'
		Me.CálculoDePlanosDeMensuraToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CálculoDePlanosDeMensuraToolStripMenuItem.Name = "CálculoDePlanosDeMensuraToolStripMenuItem"
		Me.CálculoDePlanosDeMensuraToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
		Me.CálculoDePlanosDeMensuraToolStripMenuItem.Text = "Cálculo de Planos de Mensura"
		'
		'titulo
		'
		Me.titulo.ForeColor = System.Drawing.Color.White
		Me.titulo.Name = "titulo"
		Me.titulo.Size = New System.Drawing.Size(129, 25)
		Me.titulo.Text = "Cálculo de Obras"
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(400, 410)
		Me.TabControl1.TabIndex = 50
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.LightGray
		Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
		Me.TabPage1.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabPage1.Location = New System.Drawing.Point(4, 28)
		Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Size = New System.Drawing.Size(392, 378)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Cálculo de Obras"
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.obra)
		Me.FlowLayoutPanel1.Controls.Add(Me.reset)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel1.Controls.Add(Me.propietario)
		Me.FlowLayoutPanel1.Controls.Add(Me.search)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
		Me.FlowLayoutPanel1.Controls.Add(Me.tenedor)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.costo)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
		Me.FlowLayoutPanel1.Controls.Add(Me.metrosFrente)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Controls.Add(Me.metrosCalle)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
		Me.FlowLayoutPanel1.Controls.Add(Me.total)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
		Me.FlowLayoutPanel1.Controls.Add(Me.descuento)
		Me.FlowLayoutPanel1.Controls.Add(Me.montoDescuento)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
		Me.FlowLayoutPanel1.Controls.Add(Me.cuotas)
		Me.FlowLayoutPanel1.Controls.Add(Me.montoCuota)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 10)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(383, 260)
		Me.FlowLayoutPanel1.TabIndex = 50
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(99, 20)
		Me.Label1.TabIndex = 52
		Me.Label1.Text = "Obra "
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'obra
		'
		Me.obra.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.obra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.obra.Location = New System.Drawing.Point(99, 2)
		Me.obra.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.obra.Name = "obra"
		Me.obra.Size = New System.Drawing.Size(255, 23)
		Me.obra.TabIndex = 54
		'
		'reset
		'
		Me.reset.FlatAppearance.BorderSize = 0
		Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.reset.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.reset.ForeColor = System.Drawing.Color.White
		Me.reset.Location = New System.Drawing.Point(354, 0)
		Me.reset.Margin = New System.Windows.Forms.Padding(0)
		Me.reset.Name = "reset"
		Me.reset.Size = New System.Drawing.Size(26, 28)
		Me.reset.TabIndex = 375
		Me.reset.Text = ""
		Me.ToolTip1.SetToolTip(Me.reset, "Reiniciar")
		Me.reset.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(0, 28)
		Me.Label6.Margin = New System.Windows.Forms.Padding(0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(99, 20)
		Me.Label6.TabIndex = 83
		Me.Label6.Text = "Propietario"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'propietario
		'
		Me.propietario.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.propietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.propietario.Location = New System.Drawing.Point(99, 30)
		Me.propietario.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.propietario.Name = "propietario"
		Me.propietario.Size = New System.Drawing.Size(255, 23)
		Me.propietario.TabIndex = 84
		'
		'search
		'
		Me.search.FlatAppearance.BorderSize = 0
		Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.search.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.search.ForeColor = System.Drawing.Color.White
		Me.search.Location = New System.Drawing.Point(354, 28)
		Me.search.Margin = New System.Windows.Forms.Padding(0)
		Me.search.Name = "search"
		Me.search.Size = New System.Drawing.Size(26, 28)
		Me.search.TabIndex = 366
		Me.search.Text = ""
		Me.ToolTip1.SetToolTip(Me.search, "Buscar propietario")
		Me.search.UseVisualStyleBackColor = True
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(0, 56)
		Me.Label8.Margin = New System.Windows.Forms.Padding(0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(99, 20)
		Me.Label8.TabIndex = 371
		Me.Label8.Text = "Tenedor"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'tenedor
		'
		Me.tenedor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.tenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.tenedor.Location = New System.Drawing.Point(99, 58)
		Me.tenedor.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.tenedor.Name = "tenedor"
		Me.tenedor.Size = New System.Drawing.Size(255, 23)
		Me.tenedor.TabIndex = 372
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(0, 81)
		Me.Label5.Margin = New System.Windows.Forms.Padding(0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(305, 10)
		Me.Label5.TabIndex = 370
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(0, 91)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(172, 20)
		Me.Label2.TabIndex = 55
		Me.Label2.Text = "Costo Frentista ($)"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'costo
		'
		Me.costo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.costo.DecimalPlaces = 2
		Me.costo.Location = New System.Drawing.Point(172, 91)
		Me.costo.Margin = New System.Windows.Forms.Padding(0)
		Me.costo.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
		Me.costo.Name = "costo"
		Me.costo.Size = New System.Drawing.Size(134, 26)
		Me.costo.TabIndex = 56
		Me.costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.costo.ThousandsSeparator = True
		Me.costo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(0, 117)
		Me.Label3.Margin = New System.Windows.Forms.Padding(0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(172, 20)
		Me.Label3.TabIndex = 57
		Me.Label3.Text = "Frente (Mts.)"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'metrosFrente
		'
		Me.metrosFrente.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.metrosFrente.DecimalPlaces = 2
		Me.metrosFrente.Location = New System.Drawing.Point(172, 117)
		Me.metrosFrente.Margin = New System.Windows.Forms.Padding(0)
		Me.metrosFrente.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
		Me.metrosFrente.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.metrosFrente.Name = "metrosFrente"
		Me.metrosFrente.Size = New System.Drawing.Size(134, 26)
		Me.metrosFrente.TabIndex = 58
		Me.metrosFrente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.metrosFrente.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.metrosFrente.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(0, 143)
		Me.Label4.Margin = New System.Windows.Forms.Padding(0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(172, 20)
		Me.Label4.TabIndex = 59
		Me.Label4.Text = "Ancho Calle (Mts.)"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'metrosCalle
		'
		Me.metrosCalle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.metrosCalle.Location = New System.Drawing.Point(172, 143)
		Me.metrosCalle.Margin = New System.Windows.Forms.Padding(0)
		Me.metrosCalle.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
		Me.metrosCalle.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.metrosCalle.Name = "metrosCalle"
		Me.metrosCalle.Size = New System.Drawing.Size(134, 26)
		Me.metrosCalle.TabIndex = 60
		Me.metrosCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.metrosCalle.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.metrosCalle.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'Label13
		'
		Me.Label13.Location = New System.Drawing.Point(0, 169)
		Me.Label13.Margin = New System.Windows.Forms.Padding(0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(172, 20)
		Me.Label13.TabIndex = 80
		Me.Label13.Text = "Total"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'total
		'
		Me.total.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
		Me.total.Location = New System.Drawing.Point(172, 169)
		Me.total.Margin = New System.Windows.Forms.Padding(0)
		Me.total.Name = "total"
		Me.total.Size = New System.Drawing.Size(139, 20)
		Me.total.TabIndex = 367
		Me.total.Text = "$0,00"
		Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(0, 189)
		Me.Label7.Margin = New System.Windows.Forms.Padding(0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(305, 10)
		Me.Label7.TabIndex = 85
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(0, 199)
		Me.Label9.Margin = New System.Windows.Forms.Padding(0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(172, 20)
		Me.Label9.TabIndex = 373
		Me.Label9.Text = "Descuento (%)"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'descuento
		'
		Me.descuento.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.descuento.Location = New System.Drawing.Point(172, 199)
		Me.descuento.Margin = New System.Windows.Forms.Padding(0)
		Me.descuento.Name = "descuento"
		Me.descuento.Size = New System.Drawing.Size(42, 26)
		Me.descuento.TabIndex = 70
		Me.descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.descuento.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'montoDescuento
		'
		Me.montoDescuento.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
		Me.montoDescuento.Location = New System.Drawing.Point(214, 199)
		Me.montoDescuento.Margin = New System.Windows.Forms.Padding(0)
		Me.montoDescuento.Name = "montoDescuento"
		Me.montoDescuento.Size = New System.Drawing.Size(96, 20)
		Me.montoDescuento.TabIndex = 369
		Me.montoDescuento.Text = "$0,00"
		Me.montoDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label10
		'
		Me.Label10.Location = New System.Drawing.Point(0, 225)
		Me.Label10.Margin = New System.Windows.Forms.Padding(0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(172, 20)
		Me.Label10.TabIndex = 374
		Me.Label10.Text = "Cuotas"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
		'
		'cuotas
		'
		Me.cuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.cuotas.Location = New System.Drawing.Point(172, 225)
		Me.cuotas.Margin = New System.Windows.Forms.Padding(0)
		Me.cuotas.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
		Me.cuotas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.cuotas.Name = "cuotas"
		Me.cuotas.Size = New System.Drawing.Size(42, 26)
		Me.cuotas.TabIndex = 88
		Me.cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.cuotas.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		Me.cuotas.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'montoCuota
		'
		Me.montoCuota.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
		Me.montoCuota.Location = New System.Drawing.Point(214, 225)
		Me.montoCuota.Margin = New System.Windows.Forms.Padding(0)
		Me.montoCuota.Name = "montoCuota"
		Me.montoCuota.Size = New System.Drawing.Size(96, 20)
		Me.montoCuota.TabIndex = 368
		Me.montoCuota.Text = "$0,00"
		Me.montoCuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TabPage2
		'
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(392, 384)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Cálculo de Planos de Edificación"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'TabPage3
		'
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(392, 384)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Cálculo de Planos de Mensura"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'toolCalculoPlanos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.Controls.Add(Me.MenuStrip2)
		Me.Controls.Add(Me.TabControl1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.MinimumSize = New System.Drawing.Size(400, 300)
		Me.Name = "toolCalculoPlanos"
		Me.Size = New System.Drawing.Size(400, 410)
		Me.MenuStrip2.ResumeLayout(False)
		Me.MenuStrip2.PerformLayout()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		CType(Me.costo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.metrosFrente, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.metrosCalle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.descuento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cuotas, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents MenuStrip2 As MenuStrip
	Friend WithEvents CalculosToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents obra As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents costo As NumericUpDown
	Friend WithEvents Label3 As Label
	Friend WithEvents metrosFrente As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents metrosCalle As NumericUpDown
	Friend WithEvents Label13 As Label
	Friend WithEvents descuento As NumericUpDown
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents Label6 As Label
	Friend WithEvents propietario As TextBox
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents CálculoDeObrasToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CálculoDePlanosDeEdificaciónToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CálculoDePlanosDeMensuraToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents titulo As ToolStripMenuItem
	Friend WithEvents Label7 As Label
	Friend WithEvents cuotas As NumericUpDown
	Friend WithEvents search As Button
	Friend WithEvents total As Label
	Friend WithEvents montoDescuento As Label
	Friend WithEvents montoCuota As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents tenedor As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents reset As Button
	Friend WithEvents ToolTip1 As ToolTip
End Class
