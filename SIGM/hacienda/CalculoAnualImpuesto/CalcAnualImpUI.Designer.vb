<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcAnualImpUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalcAnualImpUI))
        Me.iniciar = New System.Windows.Forms.Button()
        Me.tae = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.et_cuenta = New System.Windows.Forms.Label()
        Me.impuesto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CuentaInicial = New System.Windows.Forms.NumericUpDown()
        Me.periodo = New System.Windows.Forms.NumericUpDown()
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.info = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bs_variables = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CuentaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInfo.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.bs_variables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iniciar
        '
        Me.iniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.iniciar.FlatAppearance.BorderSize = 0
        Me.iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iniciar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.iniciar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.iniciar.Location = New System.Drawing.Point(224, 105)
        Me.iniciar.Name = "iniciar"
        Me.iniciar.Size = New System.Drawing.Size(111, 28)
        Me.iniciar.TabIndex = 70
        Me.iniciar.Text = "CALCULAR"
        Me.iniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iniciar.UseVisualStyleBackColor = False
        '
        'tae
        '
        Me.tae.Location = New System.Drawing.Point(135, 105)
        Me.tae.Name = "tae"
        Me.tae.ReadOnly = True
        Me.tae.Size = New System.Drawing.Size(83, 28)
        Me.tae.TabIndex = 397
        Me.tae.Text = "0%"
        Me.tae.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 396
        Me.Label2.Text = "TAE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 394
        Me.Label1.Text = "Periodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'et_cuenta
        '
        Me.et_cuenta.ForeColor = System.Drawing.Color.Black
        Me.et_cuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.et_cuenta.Location = New System.Drawing.Point(3, 40)
        Me.et_cuenta.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.et_cuenta.Name = "et_cuenta"
        Me.et_cuenta.Size = New System.Drawing.Size(126, 21)
        Me.et_cuenta.TabIndex = 389
        Me.et_cuenta.Text = "Cuenta Inicial"
        Me.et_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'impuesto
        '
        Me.impuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.impuesto.FormattingEnabled = True
        Me.impuesto.Items.AddRange(New Object() {"AGUAS", "AUTOMOVIL", "CATASTRO", "COMERCIO", "SEPELIO"})
        Me.impuesto.Location = New System.Drawing.Point(135, 3)
        Me.impuesto.Name = "impuesto"
        Me.impuesto.Size = New System.Drawing.Size(197, 28)
        Me.impuesto.TabIndex = 393
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 21)
        Me.Label4.TabIndex = 392
        Me.Label4.Text = "Tasa a calcular"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CuentaInicial
        '
        Me.CuentaInicial.BackColor = System.Drawing.Color.White
        Me.CuentaInicial.Location = New System.Drawing.Point(135, 37)
        Me.CuentaInicial.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.CuentaInicial.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CuentaInicial.Name = "CuentaInicial"
        Me.CuentaInicial.Size = New System.Drawing.Size(83, 28)
        Me.CuentaInicial.TabIndex = 390
        Me.CuentaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CuentaInicial.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.CuentaInicial.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'periodo
        '
        Me.periodo.BackColor = System.Drawing.Color.White
        Me.periodo.Location = New System.Drawing.Point(135, 71)
        Me.periodo.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.periodo.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.periodo.Name = "periodo"
        Me.periodo.Size = New System.Drawing.Size(83, 28)
        Me.periodo.TabIndex = 395
        Me.periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.periodo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.periodo.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'PanelInfo
        '
        Me.PanelInfo.BackColor = System.Drawing.Color.DimGray
        Me.PanelInfo.Controls.Add(Me.info)
        Me.PanelInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInfo.Location = New System.Drawing.Point(0, 137)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelInfo.Size = New System.Drawing.Size(384, 69)
        Me.PanelInfo.TabIndex = 390
        '
        'info
        '
        Me.info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.info.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.White
        Me.info.Location = New System.Drawing.Point(3, 3)
        Me.info.Margin = New System.Windows.Forms.Padding(3)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(378, 63)
        Me.info.TabIndex = 2
        Me.info.Text = "Pulse Calcular"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progreso})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 206)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(384, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 391
        Me.StatusStrip1.Text = "Estado"
        '
        'progreso
        '
        Me.progreso.Margin = New System.Windows.Forms.Padding(5, 3, 1, 3)
        Me.progreso.MarqueeAnimationSpeed = 200
        Me.progreso.Name = "progreso"
        Me.progreso.Size = New System.Drawing.Size(370, 16)
        Me.progreso.Step = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.impuesto)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.et_cuenta)
        Me.FlowLayoutPanel1.Controls.Add(Me.CuentaInicial)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.periodo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.tae)
        Me.FlowLayoutPanel1.Controls.Add(Me.iniciar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(384, 137)
        Me.FlowLayoutPanel1.TabIndex = 398
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(338, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 21)
        Me.Label3.TabIndex = 398
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(224, 40)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 21)
        Me.Label5.TabIndex = 399
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(224, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 21)
        Me.Label6.TabIndex = 400
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CalcAnualImpUI
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(384, 228)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PanelInfo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "CalcAnualImpUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo Anual de Impuestos"
        CType(Me.CuentaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInfo.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.bs_variables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents iniciar As System.Windows.Forms.Button
	Friend WithEvents et_cuenta As System.Windows.Forms.Label
	Friend WithEvents impuesto As System.Windows.Forms.ComboBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents CuentaInicial As System.Windows.Forms.NumericUpDown
	Friend WithEvents PanelInfo As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents periodo As System.Windows.Forms.NumericUpDown
	Friend WithEvents info As System.Windows.Forms.Label
	Friend WithEvents tae As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents progreso As ToolStripProgressBar
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label3 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents bs_variables As BindingSource
End Class
