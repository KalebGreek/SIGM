<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CertificadoLibreDeuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertificadoLibreDeuda))
        Me.GrupoControles = New System.Windows.Forms.FlowLayoutPanel()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Crear = New System.Windows.Forms.Button()
        Me.GrupoFecha = New System.Windows.Forms.Panel()
        Me.Mes = New System.Windows.Forms.DateTimePicker()
        Me.Trimestre = New System.Windows.Forms.ComboBox()
        Me.et_vence = New System.Windows.Forms.Label()
        Me.OpcionExento = New System.Windows.Forms.RadioButton()
        Me.OpcionTrim = New System.Windows.Forms.RadioButton()
        Me.OpcionMes = New System.Windows.Forms.RadioButton()
        Me.Vence = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrupoCuenta = New System.Windows.Forms.Panel()
        Me.et_razon = New System.Windows.Forms.Label()
        Me.razon = New System.Windows.Forms.TextBox()
        Me.et_cuenta = New System.Windows.Forms.Label()
        Me.servicio = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Verificar = New System.Windows.Forms.Button()
        Me.Cuenta = New System.Windows.Forms.NumericUpDown()
        Me.GrupoBaja = New System.Windows.Forms.Panel()
        Me.BajaDestruccion = New System.Windows.Forms.RadioButton()
        Me.SinBaja = New System.Windows.Forms.RadioButton()
        Me.etFechaBaja = New System.Windows.Forms.Label()
        Me.FechaBaja = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BajaDenuncia = New System.Windows.Forms.RadioButton()
        Me.BajaRadicacion = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Creado = New System.Windows.Forms.DateTimePicker()
        Me.GrupoControles.SuspendLayout()
        Me.GrupoFecha.SuspendLayout()
        Me.GrupoCuenta.SuspendLayout()
        CType(Me.Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoBaja.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrupoControles
        '
        Me.GrupoControles.BackColor = System.Drawing.Color.DimGray
        Me.GrupoControles.Controls.Add(Me.Cancelar)
        Me.GrupoControles.Controls.Add(Me.Crear)
        Me.GrupoControles.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrupoControles.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.GrupoControles.Location = New System.Drawing.Point(0, 406)
        Me.GrupoControles.Name = "GrupoControles"
        Me.GrupoControles.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.GrupoControles.Size = New System.Drawing.Size(484, 40)
        Me.GrupoControles.TabIndex = 384
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Cancelar.FlatAppearance.BorderSize = 0
        Me.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cancelar.Location = New System.Drawing.Point(380, 7)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(96, 26)
        Me.Cancelar.TabIndex = 80
        Me.Cancelar.Text = "CANCELAR"
        Me.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Crear
        '
        Me.Crear.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Crear.FlatAppearance.BorderSize = 0
        Me.Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Crear.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Crear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Crear.Location = New System.Drawing.Point(212, 7)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(162, 26)
        Me.Crear.TabIndex = 70
        Me.Crear.Text = "CREAR CERTIFICADO"
        Me.Crear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Crear.UseVisualStyleBackColor = False
        '
        'GrupoFecha
        '
        Me.GrupoFecha.Controls.Add(Me.Mes)
        Me.GrupoFecha.Controls.Add(Me.Trimestre)
        Me.GrupoFecha.Controls.Add(Me.et_vence)
        Me.GrupoFecha.Controls.Add(Me.OpcionExento)
        Me.GrupoFecha.Controls.Add(Me.OpcionTrim)
        Me.GrupoFecha.Controls.Add(Me.OpcionMes)
        Me.GrupoFecha.Controls.Add(Me.Vence)
        Me.GrupoFecha.Controls.Add(Me.Label3)
        Me.GrupoFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrupoFecha.Location = New System.Drawing.Point(0, 239)
        Me.GrupoFecha.Name = "GrupoFecha"
        Me.GrupoFecha.Size = New System.Drawing.Size(484, 167)
        Me.GrupoFecha.TabIndex = 386
        Me.GrupoFecha.Visible = False
        '
        'Mes
        '
        Me.Mes.CustomFormat = "MMMM' de  'yyyy"
        Me.Mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mes.Location = New System.Drawing.Point(157, 68)
        Me.Mes.Name = "Mes"
        Me.Mes.Size = New System.Drawing.Size(184, 28)
        Me.Mes.TabIndex = 392
        Me.Mes.Visible = False
        '
        'Trimestre
        '
        Me.Trimestre.FormattingEnabled = True
        Me.Trimestre.Items.AddRange(New Object() {"1° Trimestre", "2° Trimestre", "3° Trimestre", "4° Trimestre"})
        Me.Trimestre.Location = New System.Drawing.Point(157, 100)
        Me.Trimestre.Name = "Trimestre"
        Me.Trimestre.Size = New System.Drawing.Size(134, 28)
        Me.Trimestre.TabIndex = 391
        Me.Trimestre.Text = "1° Trimestre"
        Me.Trimestre.Visible = False
        '
        'et_vence
        '
        Me.et_vence.AutoSize = True
        Me.et_vence.Location = New System.Drawing.Point(85, 136)
        Me.et_vence.Name = "et_vence"
        Me.et_vence.Size = New System.Drawing.Size(69, 21)
        Me.et_vence.TabIndex = 390
        Me.et_vence.Text = "Vence el"
        Me.et_vence.Visible = False
        '
        'OpcionExento
        '
        Me.OpcionExento.AutoSize = True
        Me.OpcionExento.Checked = True
        Me.OpcionExento.Location = New System.Drawing.Point(32, 32)
        Me.OpcionExento.Name = "OpcionExento"
        Me.OpcionExento.Size = New System.Drawing.Size(79, 25)
        Me.OpcionExento.TabIndex = 12
        Me.OpcionExento.TabStop = True
        Me.OpcionExento.Text = "Exento"
        Me.OpcionExento.UseVisualStyleBackColor = True
        '
        'OpcionTrim
        '
        Me.OpcionTrim.AutoSize = True
        Me.OpcionTrim.Location = New System.Drawing.Point(32, 102)
        Me.OpcionTrim.Name = "OpcionTrim"
        Me.OpcionTrim.Size = New System.Drawing.Size(96, 25)
        Me.OpcionTrim.TabIndex = 11
        Me.OpcionTrim.Text = "Trimestre"
        Me.OpcionTrim.UseVisualStyleBackColor = True
        '
        'OpcionMes
        '
        Me.OpcionMes.AutoSize = True
        Me.OpcionMes.Location = New System.Drawing.Point(32, 70)
        Me.OpcionMes.Name = "OpcionMes"
        Me.OpcionMes.Size = New System.Drawing.Size(57, 25)
        Me.OpcionMes.TabIndex = 10
        Me.OpcionMes.Text = "Mes"
        Me.OpcionMes.UseVisualStyleBackColor = True
        '
        'Vence
        '
        Me.Vence.Location = New System.Drawing.Point(157, 132)
        Me.Vence.Name = "Vence"
        Me.Vence.Size = New System.Drawing.Size(284, 28)
        Me.Vence.TabIndex = 9
        Me.Vence.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(9, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Vencimiento"
        '
        'GrupoCuenta
        '
        Me.GrupoCuenta.BackColor = System.Drawing.Color.DimGray
        Me.GrupoCuenta.Controls.Add(Me.et_razon)
        Me.GrupoCuenta.Controls.Add(Me.razon)
        Me.GrupoCuenta.Controls.Add(Me.et_cuenta)
        Me.GrupoCuenta.Controls.Add(Me.servicio)
        Me.GrupoCuenta.Controls.Add(Me.Label4)
        Me.GrupoCuenta.Controls.Add(Me.Verificar)
        Me.GrupoCuenta.Controls.Add(Me.Cuenta)
        Me.GrupoCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrupoCuenta.Location = New System.Drawing.Point(0, 0)
        Me.GrupoCuenta.Name = "GrupoCuenta"
        Me.GrupoCuenta.Size = New System.Drawing.Size(484, 78)
        Me.GrupoCuenta.TabIndex = 389
        '
        'et_razon
        '
        Me.et_razon.AutoSize = True
        Me.et_razon.ForeColor = System.Drawing.Color.White
        Me.et_razon.Location = New System.Drawing.Point(11, 46)
        Me.et_razon.Name = "et_razon"
        Me.et_razon.Size = New System.Drawing.Size(58, 21)
        Me.et_razon.TabIndex = 395
        Me.et_razon.Text = "Titular"
        Me.et_razon.Visible = False
        '
        'razon
        '
        Me.razon.Location = New System.Drawing.Point(70, 43)
        Me.razon.Name = "razon"
        Me.razon.ReadOnly = True
        Me.razon.Size = New System.Drawing.Size(297, 28)
        Me.razon.TabIndex = 394
        Me.razon.Visible = False
        '
        'et_cuenta
        '
        Me.et_cuenta.ForeColor = System.Drawing.Color.White
        Me.et_cuenta.Location = New System.Drawing.Point(239, 9)
        Me.et_cuenta.Name = "et_cuenta"
        Me.et_cuenta.Size = New System.Drawing.Size(61, 28)
        Me.et_cuenta.TabIndex = 389
        Me.et_cuenta.Text = "Cuenta"
        Me.et_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.et_cuenta.Visible = False
        '
        'servicio
        '
        Me.servicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.servicio.FormattingEnabled = True
        Me.servicio.Items.AddRange(New Object() {"AGUA", "AUTOMOTOR", "CATASTRO", "CEMENTERIO", "COMERCIO"})
        Me.servicio.Location = New System.Drawing.Point(70, 9)
        Me.servicio.Name = "servicio"
        Me.servicio.Size = New System.Drawing.Size(164, 28)
        Me.servicio.TabIndex = 393
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 392
        Me.Label4.Text = "Servicio"
        '
        'Verificar
        '
        Me.Verificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Verificar.FlatAppearance.BorderSize = 0
        Me.Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Verificar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Verificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Verificar.Location = New System.Drawing.Point(374, 10)
        Me.Verificar.Name = "Verificar"
        Me.Verificar.Size = New System.Drawing.Size(96, 26)
        Me.Verificar.TabIndex = 391
        Me.Verificar.Text = "VERIFICAR"
        Me.Verificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Verificar.UseVisualStyleBackColor = False
        Me.Verificar.Visible = False
        '
        'Cuenta
        '
        Me.Cuenta.BackColor = System.Drawing.Color.White
        Me.Cuenta.Location = New System.Drawing.Point(283, 9)
        Me.Cuenta.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Size = New System.Drawing.Size(83, 28)
        Me.Cuenta.TabIndex = 390
        Me.Cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cuenta.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.Cuenta.Visible = False
        '
        'GrupoBaja
        '
        Me.GrupoBaja.BackColor = System.Drawing.Color.LightGray
        Me.GrupoBaja.Controls.Add(Me.BajaDestruccion)
        Me.GrupoBaja.Controls.Add(Me.SinBaja)
        Me.GrupoBaja.Controls.Add(Me.etFechaBaja)
        Me.GrupoBaja.Controls.Add(Me.FechaBaja)
        Me.GrupoBaja.Controls.Add(Me.Label1)
        Me.GrupoBaja.Controls.Add(Me.BajaDenuncia)
        Me.GrupoBaja.Controls.Add(Me.BajaRadicacion)
        Me.GrupoBaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrupoBaja.Location = New System.Drawing.Point(0, 118)
        Me.GrupoBaja.Name = "GrupoBaja"
        Me.GrupoBaja.Size = New System.Drawing.Size(484, 121)
        Me.GrupoBaja.TabIndex = 390
        Me.GrupoBaja.Visible = False
        '
        'BajaDestruccion
        '
        Me.BajaDestruccion.AutoSize = True
        Me.BajaDestruccion.Location = New System.Drawing.Point(202, 57)
        Me.BajaDestruccion.Name = "BajaDestruccion"
        Me.BajaDestruccion.Size = New System.Drawing.Size(208, 25)
        Me.BajaDestruccion.TabIndex = 13
        Me.BajaDestruccion.Text = "Destruccion del  vehiculo"
        Me.BajaDestruccion.UseVisualStyleBackColor = True
        '
        'SinBaja
        '
        Me.SinBaja.AutoSize = True
        Me.SinBaja.Checked = True
        Me.SinBaja.Location = New System.Drawing.Point(32, 26)
        Me.SinBaja.Name = "SinBaja"
        Me.SinBaja.Size = New System.Drawing.Size(87, 25)
        Me.SinBaja.TabIndex = 12
        Me.SinBaja.TabStop = True
        Me.SinBaja.Text = "Sin Baja"
        Me.SinBaja.UseVisualStyleBackColor = True
        '
        'etFechaBaja
        '
        Me.etFechaBaja.AutoSize = True
        Me.etFechaBaja.Location = New System.Drawing.Point(29, 89)
        Me.etFechaBaja.Name = "etFechaBaja"
        Me.etFechaBaja.Size = New System.Drawing.Size(59, 21)
        Me.etFechaBaja.TabIndex = 11
        Me.etFechaBaja.Text = "Fecha:"
        Me.etFechaBaja.Visible = False
        '
        'FechaBaja
        '
        Me.FechaBaja.Location = New System.Drawing.Point(94, 86)
        Me.FechaBaja.Name = "FechaBaja"
        Me.FechaBaja.Size = New System.Drawing.Size(273, 28)
        Me.FechaBaja.TabIndex = 10
        Me.FechaBaja.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Razon de Baja"
        '
        'BajaDenuncia
        '
        Me.BajaDenuncia.AutoSize = True
        Me.BajaDenuncia.Location = New System.Drawing.Point(32, 57)
        Me.BajaDenuncia.Name = "BajaDenuncia"
        Me.BajaDenuncia.Size = New System.Drawing.Size(159, 25)
        Me.BajaDenuncia.TabIndex = 1
        Me.BajaDenuncia.Text = "Denuncia por robo"
        Me.BajaDenuncia.UseVisualStyleBackColor = True
        '
        'BajaRadicacion
        '
        Me.BajaRadicacion.AutoSize = True
        Me.BajaRadicacion.Location = New System.Drawing.Point(202, 26)
        Me.BajaRadicacion.Name = "BajaRadicacion"
        Me.BajaRadicacion.Size = New System.Drawing.Size(181, 25)
        Me.BajaRadicacion.TabIndex = 0
        Me.BajaRadicacion.Text = "Cambio de radicacion"
        Me.BajaRadicacion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Creado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 40)
        Me.Panel1.TabIndex = 393
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 21)
        Me.Label2.TabIndex = 394
        Me.Label2.Text = "Fecha Creacion"
        '
        'Creado
        '
        Me.Creado.Location = New System.Drawing.Point(157, 6)
        Me.Creado.Name = "Creado"
        Me.Creado.Size = New System.Drawing.Size(284, 28)
        Me.Creado.TabIndex = 393
        '
        'CertificadoLibreDeuda
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(484, 446)
        Me.Controls.Add(Me.GrupoFecha)
        Me.Controls.Add(Me.GrupoBaja)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrupoCuenta)
        Me.Controls.Add(Me.GrupoControles)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(440, 200)
        Me.Name = "CertificadoLibreDeuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Certificado de Libre Deuda"
        Me.GrupoControles.ResumeLayout(False)
        Me.GrupoFecha.ResumeLayout(False)
        Me.GrupoFecha.PerformLayout()
        Me.GrupoCuenta.ResumeLayout(False)
        Me.GrupoCuenta.PerformLayout()
        CType(Me.Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoBaja.ResumeLayout(False)
        Me.GrupoBaja.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrupoControles As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Crear As System.Windows.Forms.Button
    Friend WithEvents GrupoFecha As System.Windows.Forms.Panel
    Friend WithEvents Vence As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpcionExento As System.Windows.Forms.RadioButton
    Friend WithEvents OpcionTrim As System.Windows.Forms.RadioButton
    Friend WithEvents OpcionMes As System.Windows.Forms.RadioButton
    Friend WithEvents Trimestre As System.Windows.Forms.ComboBox
    Friend WithEvents et_vence As System.Windows.Forms.Label
    Friend WithEvents GrupoCuenta As System.Windows.Forms.Panel
    Friend WithEvents et_cuenta As System.Windows.Forms.Label
    Friend WithEvents servicio As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Verificar As System.Windows.Forms.Button
    Friend WithEvents Cuenta As System.Windows.Forms.NumericUpDown
    Friend WithEvents GrupoBaja As System.Windows.Forms.Panel
    Friend WithEvents Mes As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaBaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BajaDenuncia As System.Windows.Forms.RadioButton
    Friend WithEvents BajaRadicacion As System.Windows.Forms.RadioButton
    Friend WithEvents etFechaBaja As System.Windows.Forms.Label
    Friend WithEvents SinBaja As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Creado As System.Windows.Forms.DateTimePicker
    Friend WithEvents BajaDestruccion As RadioButton
    Friend WithEvents et_razon As Label
    Friend WithEvents razon As TextBox
End Class
