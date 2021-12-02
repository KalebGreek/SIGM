<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.opendialog = New System.Windows.Forms.OpenFileDialog()
        Me.salir = New System.Windows.Forms.Button()
        Me.opcion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.l_accionsocial = New System.Windows.Forms.Button()
        Me.l_catastro = New System.Windows.Forms.Button()
        Me.l_contrato = New System.Windows.Forms.Button()
        Me.l_comercio = New System.Windows.Forms.Button()
        Me.l_formularios = New System.Windows.Forms.Button()
        Me.l_gobierno = New System.Windows.Forms.Button()
        Me.l_hacienda = New System.Windows.Forms.Button()
        Me.l_oprivadas = New System.Windows.Forms.Button()
        Me.l_opublicas = New System.Windows.Forms.Button()
        Me.l_persona = New System.Windows.Forms.Button()
        Me.l_transito = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'opendialog
        '
        Me.opendialog.FileName = "opendialog"
        '
        'salir
        '
        Me.salir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.salir.FlatAppearance.BorderSize = 0
        Me.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salir.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.salir.ForeColor = System.Drawing.Color.LightGray
        Me.salir.Location = New System.Drawing.Point(371, 3)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(153, 29)
        Me.salir.TabIndex = 100
        Me.salir.Text = "CERRAR SESIÓN"
        Me.salir.UseVisualStyleBackColor = False
        '
        'opcion
        '
        Me.opcion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.opcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.opcion.FlatAppearance.BorderSize = 0
        Me.opcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opcion.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.opcion.ForeColor = System.Drawing.Color.LightGray
        Me.opcion.Location = New System.Drawing.Point(255, 3)
        Me.opcion.Name = "opcion"
        Me.opcion.Size = New System.Drawing.Size(110, 29)
        Me.opcion.TabIndex = 80
        Me.opcion.Text = "OPCIONES"
        Me.opcion.UseVisualStyleBackColor = False
        Me.opcion.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(216, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 412)
        Me.Panel1.TabIndex = 153
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BackgroundImage = Global.Sigm.My.Resources.Resources.logo
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo.Location = New System.Drawing.Point(39, 51)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(235, 308)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 152
        Me.logo.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.l_accionsocial)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_catastro)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_contrato)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_comercio)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_formularios)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_gobierno)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_hacienda)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_oprivadas)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_opublicas)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_persona)
        Me.FlowLayoutPanel1.Controls.Add(Me.l_transito)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(216, 412)
        Me.FlowLayoutPanel1.TabIndex = 158
        '
        'l_accionsocial
        '
        Me.l_accionsocial.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_accionsocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.l_accionsocial.BackgroundImage = CType(resources.GetObject("l_accionsocial.BackgroundImage"), System.Drawing.Image)
        Me.l_accionsocial.FlatAppearance.BorderSize = 0
        Me.l_accionsocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_accionsocial.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_accionsocial.ForeColor = System.Drawing.Color.White
        Me.l_accionsocial.Location = New System.Drawing.Point(3, 3)
        Me.l_accionsocial.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_accionsocial.Name = "l_accionsocial"
        Me.l_accionsocial.Size = New System.Drawing.Size(210, 32)
        Me.l_accionsocial.TabIndex = 176
        Me.l_accionsocial.Text = "ACCION SOCIAL"
        Me.l_accionsocial.UseVisualStyleBackColor = False
        Me.l_accionsocial.Visible = False
        '
        'l_catastro
        '
        Me.l_catastro.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_catastro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.l_catastro.BackgroundImage = CType(resources.GetObject("l_catastro.BackgroundImage"), System.Drawing.Image)
        Me.l_catastro.FlatAppearance.BorderSize = 0
        Me.l_catastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_catastro.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_catastro.ForeColor = System.Drawing.Color.White
        Me.l_catastro.Location = New System.Drawing.Point(3, 39)
        Me.l_catastro.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_catastro.Name = "l_catastro"
        Me.l_catastro.Size = New System.Drawing.Size(210, 32)
        Me.l_catastro.TabIndex = 170
        Me.l_catastro.Text = "CATASTRO"
        Me.l_catastro.UseVisualStyleBackColor = False
        Me.l_catastro.Visible = False
        '
        'l_contrato
        '
        Me.l_contrato.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_contrato.BackColor = System.Drawing.Color.Green
        Me.l_contrato.BackgroundImage = CType(resources.GetObject("l_contrato.BackgroundImage"), System.Drawing.Image)
        Me.l_contrato.FlatAppearance.BorderSize = 0
        Me.l_contrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_contrato.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_contrato.ForeColor = System.Drawing.Color.White
        Me.l_contrato.Location = New System.Drawing.Point(3, 75)
        Me.l_contrato.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_contrato.Name = "l_contrato"
        Me.l_contrato.Size = New System.Drawing.Size(210, 32)
        Me.l_contrato.TabIndex = 178
        Me.l_contrato.Text = "CONTRATOS"
        Me.l_contrato.UseVisualStyleBackColor = False
        Me.l_contrato.Visible = False
        '
        'l_comercio
        '
        Me.l_comercio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_comercio.BackColor = System.Drawing.Color.DarkTurquoise
        Me.l_comercio.BackgroundImage = CType(resources.GetObject("l_comercio.BackgroundImage"), System.Drawing.Image)
        Me.l_comercio.FlatAppearance.BorderSize = 0
        Me.l_comercio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_comercio.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_comercio.ForeColor = System.Drawing.Color.White
        Me.l_comercio.Location = New System.Drawing.Point(3, 111)
        Me.l_comercio.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_comercio.Name = "l_comercio"
        Me.l_comercio.Size = New System.Drawing.Size(210, 32)
        Me.l_comercio.TabIndex = 174
        Me.l_comercio.Text = "COMERCIO"
        Me.l_comercio.UseVisualStyleBackColor = False
        Me.l_comercio.Visible = False
        '
        'l_formularios
        '
        Me.l_formularios.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_formularios.BackColor = System.Drawing.Color.LightSlateGray
        Me.l_formularios.BackgroundImage = CType(resources.GetObject("l_formularios.BackgroundImage"), System.Drawing.Image)
        Me.l_formularios.FlatAppearance.BorderSize = 0
        Me.l_formularios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_formularios.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_formularios.ForeColor = System.Drawing.Color.White
        Me.l_formularios.Location = New System.Drawing.Point(3, 147)
        Me.l_formularios.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_formularios.Name = "l_formularios"
        Me.l_formularios.Size = New System.Drawing.Size(210, 32)
        Me.l_formularios.TabIndex = 175
        Me.l_formularios.Text = "FORMULARIOS"
        Me.l_formularios.UseVisualStyleBackColor = False
        Me.l_formularios.Visible = False
        '
        'l_gobierno
        '
        Me.l_gobierno.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_gobierno.BackColor = System.Drawing.Color.IndianRed
        Me.l_gobierno.BackgroundImage = CType(resources.GetObject("l_gobierno.BackgroundImage"), System.Drawing.Image)
        Me.l_gobierno.FlatAppearance.BorderSize = 0
        Me.l_gobierno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_gobierno.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_gobierno.ForeColor = System.Drawing.Color.White
        Me.l_gobierno.Location = New System.Drawing.Point(3, 183)
        Me.l_gobierno.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_gobierno.Name = "l_gobierno"
        Me.l_gobierno.Size = New System.Drawing.Size(210, 32)
        Me.l_gobierno.TabIndex = 168
        Me.l_gobierno.Text = "GOBIERNO"
        Me.l_gobierno.UseVisualStyleBackColor = False
        Me.l_gobierno.Visible = False
        '
        'l_hacienda
        '
        Me.l_hacienda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.l_hacienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.l_hacienda.BackgroundImage = CType(resources.GetObject("l_hacienda.BackgroundImage"), System.Drawing.Image)
        Me.l_hacienda.FlatAppearance.BorderSize = 0
        Me.l_hacienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_hacienda.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_hacienda.ForeColor = System.Drawing.Color.White
        Me.l_hacienda.Location = New System.Drawing.Point(3, 219)
        Me.l_hacienda.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_hacienda.Name = "l_hacienda"
        Me.l_hacienda.Size = New System.Drawing.Size(210, 32)
        Me.l_hacienda.TabIndex = 167
        Me.l_hacienda.Text = "HACIENDA"
        Me.l_hacienda.UseVisualStyleBackColor = False
        Me.l_hacienda.Visible = False
        '
        'l_oprivadas
        '
        Me.l_oprivadas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_oprivadas.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.l_oprivadas.BackgroundImage = CType(resources.GetObject("l_oprivadas.BackgroundImage"), System.Drawing.Image)
        Me.l_oprivadas.FlatAppearance.BorderSize = 0
        Me.l_oprivadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_oprivadas.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_oprivadas.ForeColor = System.Drawing.Color.White
        Me.l_oprivadas.Location = New System.Drawing.Point(3, 255)
        Me.l_oprivadas.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_oprivadas.Name = "l_oprivadas"
        Me.l_oprivadas.Size = New System.Drawing.Size(210, 32)
        Me.l_oprivadas.TabIndex = 172
        Me.l_oprivadas.Text = "OBRAS PRIVADAS"
        Me.l_oprivadas.UseVisualStyleBackColor = False
        Me.l_oprivadas.Visible = False
        '
        'l_opublicas
        '
        Me.l_opublicas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_opublicas.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.l_opublicas.BackgroundImage = CType(resources.GetObject("l_opublicas.BackgroundImage"), System.Drawing.Image)
        Me.l_opublicas.FlatAppearance.BorderSize = 0
        Me.l_opublicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_opublicas.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_opublicas.ForeColor = System.Drawing.Color.White
        Me.l_opublicas.Location = New System.Drawing.Point(3, 291)
        Me.l_opublicas.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_opublicas.Name = "l_opublicas"
        Me.l_opublicas.Size = New System.Drawing.Size(210, 32)
        Me.l_opublicas.TabIndex = 171
        Me.l_opublicas.Text = "OBRAS PUBLICAS"
        Me.l_opublicas.UseVisualStyleBackColor = False
        Me.l_opublicas.Visible = False
        '
        'l_persona
        '
        Me.l_persona.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_persona.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.l_persona.BackgroundImage = CType(resources.GetObject("l_persona.BackgroundImage"), System.Drawing.Image)
        Me.l_persona.FlatAppearance.BorderSize = 0
        Me.l_persona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_persona.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_persona.ForeColor = System.Drawing.Color.White
        Me.l_persona.Location = New System.Drawing.Point(3, 327)
        Me.l_persona.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_persona.Name = "l_persona"
        Me.l_persona.Size = New System.Drawing.Size(210, 32)
        Me.l_persona.TabIndex = 173
        Me.l_persona.Text = "PERSONAS"
        Me.l_persona.UseVisualStyleBackColor = False
        Me.l_persona.Visible = False
        '
        'l_transito
        '
        Me.l_transito.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.l_transito.BackColor = System.Drawing.Color.DodgerBlue
        Me.l_transito.BackgroundImage = CType(resources.GetObject("l_transito.BackgroundImage"), System.Drawing.Image)
        Me.l_transito.FlatAppearance.BorderSize = 0
        Me.l_transito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_transito.Font = New System.Drawing.Font("PF DinText Pro", 16.0!)
        Me.l_transito.ForeColor = System.Drawing.Color.White
        Me.l_transito.Location = New System.Drawing.Point(3, 363)
        Me.l_transito.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.l_transito.Name = "l_transito"
        Me.l_transito.Size = New System.Drawing.Size(210, 32)
        Me.l_transito.TabIndex = 177
        Me.l_transito.Text = "TRANSITO"
        Me.l_transito.UseVisualStyleBackColor = False
        Me.l_transito.Visible = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.salir)
        Me.FlowLayoutPanel2.Controls.Add(Me.opcion)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 412)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(527, 33)
        Me.FlowLayoutPanel2.TabIndex = 159
        '
        'Launcher
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(527, 445)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("PF DinText Pro", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hacienda - Villa De Las Rosas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents opendialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents opcion As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents l_hacienda As System.Windows.Forms.Button
    Friend WithEvents l_gobierno As System.Windows.Forms.Button
    Friend WithEvents l_catastro As System.Windows.Forms.Button
    Friend WithEvents l_opublicas As System.Windows.Forms.Button
    Friend WithEvents l_oprivadas As System.Windows.Forms.Button
    Friend WithEvents l_persona As System.Windows.Forms.Button
    Friend WithEvents l_comercio As System.Windows.Forms.Button
    Friend WithEvents l_formularios As System.Windows.Forms.Button
    Friend WithEvents l_accionsocial As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents l_transito As Button
    Friend WithEvents l_contrato As Button
End Class
