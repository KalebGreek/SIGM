<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculoAnualImpuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculoAnualImpuesto))
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.iniciar = New System.Windows.Forms.Button()
        Me.GrupoCuenta = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.et_cuenta = New System.Windows.Forms.Label()
        Me.impuesto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CuentaInicial = New System.Windows.Forms.NumericUpDown()
        Me.periodo = New System.Windows.Forms.NumericUpDown()
        Me.GrupoBaja = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.info = New System.Windows.Forms.Label()
        Me.et_info = New System.Windows.Forms.Label()
        Me.GrupoCuenta.SuspendLayout()
        CType(Me.CuentaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoBaja.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cancelar.Location = New System.Drawing.Point(287, 8)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(86, 26)
        Me.Cancelar.TabIndex = 80
        Me.Cancelar.Text = "CERRAR"
        Me.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'iniciar
        '
        Me.iniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.iniciar.FlatAppearance.BorderSize = 0
        Me.iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iniciar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.iniciar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.iniciar.Location = New System.Drawing.Point(192, 8)
        Me.iniciar.Name = "iniciar"
        Me.iniciar.Size = New System.Drawing.Size(86, 26)
        Me.iniciar.TabIndex = 70
        Me.iniciar.Text = "INICIAR"
        Me.iniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iniciar.UseVisualStyleBackColor = False
        '
        'GrupoCuenta
        '
        Me.GrupoCuenta.Controls.Add(Me.Label1)
        Me.GrupoCuenta.Controls.Add(Me.et_cuenta)
        Me.GrupoCuenta.Controls.Add(Me.impuesto)
        Me.GrupoCuenta.Controls.Add(Me.Label4)
        Me.GrupoCuenta.Controls.Add(Me.CuentaInicial)
        Me.GrupoCuenta.Controls.Add(Me.periodo)
        Me.GrupoCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrupoCuenta.Location = New System.Drawing.Point(0, 0)
        Me.GrupoCuenta.Name = "GrupoCuenta"
        Me.GrupoCuenta.Size = New System.Drawing.Size(384, 87)
        Me.GrupoCuenta.TabIndex = 389
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(219, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 30)
        Me.Label1.TabIndex = 394
        Me.Label1.Text = "Periodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'et_cuenta
        '
        Me.et_cuenta.ForeColor = System.Drawing.Color.Black
        Me.et_cuenta.Location = New System.Drawing.Point(11, 43)
        Me.et_cuenta.Name = "et_cuenta"
        Me.et_cuenta.Size = New System.Drawing.Size(112, 30)
        Me.et_cuenta.TabIndex = 389
        Me.et_cuenta.Text = "Cuenta Inicial"
        Me.et_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'impuesto
        '
        Me.impuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.impuesto.FormattingEnabled = True
        Me.impuesto.Items.AddRange(New Object() {"AGUAS", "AUTOMOVIL", "CATASTRO", "COMERCIO", "SEPELIO"})
        Me.impuesto.Location = New System.Drawing.Point(172, 9)
        Me.impuesto.Name = "impuesto"
        Me.impuesto.Size = New System.Drawing.Size(200, 28)
        Me.impuesto.TabIndex = 393
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 21)
        Me.Label4.TabIndex = 392
        Me.Label4.Text = "Impuesto a Calcular"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CuentaInicial
        '
        Me.CuentaInicial.BackColor = System.Drawing.Color.White
        Me.CuentaInicial.Location = New System.Drawing.Point(106, 45)
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
        Me.periodo.Location = New System.Drawing.Point(289, 45)
        Me.periodo.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.periodo.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.periodo.Name = "periodo"
        Me.periodo.Size = New System.Drawing.Size(83, 28)
        Me.periodo.TabIndex = 395
        Me.periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.periodo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.periodo.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'GrupoBaja
        '
        Me.GrupoBaja.BackColor = System.Drawing.Color.DimGray
        Me.GrupoBaja.Controls.Add(Me.StatusStrip1)
        Me.GrupoBaja.Controls.Add(Me.Cancelar)
        Me.GrupoBaja.Controls.Add(Me.iniciar)
        Me.GrupoBaja.Controls.Add(Me.info)
        Me.GrupoBaja.Controls.Add(Me.et_info)
        Me.GrupoBaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrupoBaja.Location = New System.Drawing.Point(0, 87)
        Me.GrupoBaja.Name = "GrupoBaja"
        Me.GrupoBaja.Size = New System.Drawing.Size(384, 89)
        Me.GrupoBaja.TabIndex = 390
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progreso})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 67)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(384, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 81
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
        'info
        '
        Me.info.AutoSize = True
        Me.info.ForeColor = System.Drawing.Color.White
        Me.info.Location = New System.Drawing.Point(73, 40)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(137, 21)
        Me.info.TabIndex = 2
        Me.info.Text = "Esperando datos."
        '
        'et_info
        '
        Me.et_info.AutoSize = True
        Me.et_info.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!, System.Drawing.FontStyle.Bold)
        Me.et_info.ForeColor = System.Drawing.Color.White
        Me.et_info.Location = New System.Drawing.Point(8, 40)
        Me.et_info.Name = "et_info"
        Me.et_info.Size = New System.Drawing.Size(69, 21)
        Me.et_info.TabIndex = 1
        Me.et_info.Text = "Estado:"
        '
        'CalculoAnualImpuesto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(384, 176)
        Me.Controls.Add(Me.GrupoBaja)
        Me.Controls.Add(Me.GrupoCuenta)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "CalculoAnualImpuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo Anual de Impuestos"
        Me.GrupoCuenta.ResumeLayout(False)
        Me.GrupoCuenta.PerformLayout()
        CType(Me.CuentaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoBaja.ResumeLayout(False)
        Me.GrupoBaja.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents iniciar As System.Windows.Forms.Button
    Friend WithEvents GrupoCuenta As System.Windows.Forms.Panel
    Friend WithEvents et_cuenta As System.Windows.Forms.Label
    Friend WithEvents impuesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CuentaInicial As System.Windows.Forms.NumericUpDown
    Friend WithEvents GrupoBaja As System.Windows.Forms.Panel
    Friend WithEvents et_info As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents periodo As System.Windows.Forms.NumericUpDown
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar

End Class
