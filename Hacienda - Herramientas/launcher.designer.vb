<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(launcher))
        Me.opendialog = New System.Windows.Forms.OpenFileDialog()
        Me.salir = New System.Windows.Forms.Button()
        Me.opc = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.hac = New System.Windows.Forms.Button()
        Me.gob = New System.Windows.Forms.Button()
        Me.cat = New System.Windows.Forms.Button()
        Me.opu = New System.Windows.Forms.Button()
        Me.opr = New System.Windows.Forms.Button()
        Me.com = New System.Windows.Forms.Button()
        Me.per = New System.Windows.Forms.Button()
        Me.frm = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
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
        Me.salir.Location = New System.Drawing.Point(115, 378)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(153, 29)
        Me.salir.TabIndex = 100
        Me.salir.Text = "CERRAR SESIÓN"
        Me.salir.UseVisualStyleBackColor = False
        '
        'opc
        '
        Me.opc.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.opc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.opc.FlatAppearance.BorderSize = 0
        Me.opc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opc.Font = New System.Drawing.Font("PF DinText Pro", 13.0!)
        Me.opc.ForeColor = System.Drawing.Color.LightGray
        Me.opc.Location = New System.Drawing.Point(4, 378)
        Me.opc.Name = "opc"
        Me.opc.Size = New System.Drawing.Size(110, 29)
        Me.opc.TabIndex = 80
        Me.opc.Text = "OPCIONES"
        Me.opc.UseVisualStyleBackColor = False
        Me.opc.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.logo)
        Me.Panel1.Location = New System.Drawing.Point(280, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 352)
        Me.Panel1.TabIndex = 153
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BackgroundImage = Global.Sigm.My.Resources.Resources.logo
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo.Location = New System.Drawing.Point(15, 11)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(235, 308)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 152
        Me.logo.TabStop = False
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.Yellow
        Me.id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.id.Font = New System.Drawing.Font("PF DinText Pro", 10.0!)
        Me.id.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.id.Location = New System.Drawing.Point(518, 383)
        Me.id.MaxLength = 32
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(27, 23)
        Me.id.TabIndex = 157
        Me.id.Text = "0"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.hac)
        Me.FlowLayoutPanel1.Controls.Add(Me.gob)
        Me.FlowLayoutPanel1.Controls.Add(Me.cat)
        Me.FlowLayoutPanel1.Controls.Add(Me.opu)
        Me.FlowLayoutPanel1.Controls.Add(Me.opr)
        Me.FlowLayoutPanel1.Controls.Add(Me.com)
        Me.FlowLayoutPanel1.Controls.Add(Me.per)
        Me.FlowLayoutPanel1.Controls.Add(Me.frm)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(8, 17)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(256, 358)
        Me.FlowLayoutPanel1.TabIndex = 158
        '
        'hac
        '
        Me.hac.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.hac.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.hac.BackgroundImage = CType(resources.GetObject("hac.BackgroundImage"), System.Drawing.Image)
        Me.hac.FlatAppearance.BorderSize = 0
        Me.hac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hac.Font = New System.Drawing.Font("PF DinText Pro", 20.0!)
        Me.hac.ForeColor = System.Drawing.Color.White
        Me.hac.Location = New System.Drawing.Point(3, 3)
        Me.hac.Name = "hac"
        Me.hac.Size = New System.Drawing.Size(250, 38)
        Me.hac.TabIndex = 167
        Me.hac.Text = "HACIENDA"
        Me.hac.UseVisualStyleBackColor = False
        Me.hac.Visible = False
        '
        'gob
        '
        Me.gob.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.gob.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.gob.BackgroundImage = CType(resources.GetObject("gob.BackgroundImage"), System.Drawing.Image)
        Me.gob.FlatAppearance.BorderSize = 0
        Me.gob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gob.Font = New System.Drawing.Font("PF DinText Pro", 20.0!)
        Me.gob.ForeColor = System.Drawing.Color.White
        Me.gob.Location = New System.Drawing.Point(3, 47)
        Me.gob.Name = "gob"
        Me.gob.Size = New System.Drawing.Size(250, 38)
        Me.gob.TabIndex = 168
        Me.gob.Text = "GOBIERNO"
        Me.gob.UseVisualStyleBackColor = False
        Me.gob.Visible = False
        '
        'cat
        '
        Me.cat.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cat.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cat.BackgroundImage = CType(resources.GetObject("cat.BackgroundImage"), System.Drawing.Image)
        Me.cat.FlatAppearance.BorderSize = 0
        Me.cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cat.Font = New System.Drawing.Font("PF DinText Pro", 20.0!)
        Me.cat.ForeColor = System.Drawing.Color.White
        Me.cat.Location = New System.Drawing.Point(3, 91)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(250, 38)
        Me.cat.TabIndex = 170
        Me.cat.Text = "CATASTRO"
        Me.cat.UseVisualStyleBackColor = False
        Me.cat.Visible = False
        '
        'opu
        '
        Me.opu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.opu.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.opu.BackgroundImage = CType(resources.GetObject("opu.BackgroundImage"), System.Drawing.Image)
        Me.opu.FlatAppearance.BorderSize = 0
        Me.opu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opu.Font = New System.Drawing.Font("PF DinText Pro", 20.0!)
        Me.opu.ForeColor = System.Drawing.Color.White
        Me.opu.Location = New System.Drawing.Point(3, 135)
        Me.opu.Name = "opu"
        Me.opu.Size = New System.Drawing.Size(250, 38)
        Me.opu.TabIndex = 171
        Me.opu.Text = "OBRAS PÚBLICAS"
        Me.opu.UseVisualStyleBackColor = False
        Me.opu.Visible = False
        '
        'opr
        '
        Me.opr.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.opr.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.opr.BackgroundImage = CType(resources.GetObject("opr.BackgroundImage"), System.Drawing.Image)
        Me.opr.FlatAppearance.BorderSize = 0
        Me.opr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opr.Font = New System.Drawing.Font("PF DinText Pro", 20.0!)
        Me.opr.ForeColor = System.Drawing.Color.White
        Me.opr.Location = New System.Drawing.Point(3, 179)
        Me.opr.Name = "opr"
        Me.opr.Size = New System.Drawing.Size(250, 38)
        Me.opr.TabIndex = 172
        Me.opr.Text = "OBRAS PRIVADAS"
        Me.opr.UseVisualStyleBackColor = False
        Me.opr.Visible = False
        '
        'com
        '
        Me.com.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.com.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.com.BackgroundImage = CType(resources.GetObject("com.BackgroundImage"), System.Drawing.Image)
        Me.com.FlatAppearance.BorderSize = 0
        Me.com.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.com.Font = New System.Drawing.Font("PF DinText Pro", 20.0!)
        Me.com.ForeColor = System.Drawing.Color.White
        Me.com.Location = New System.Drawing.Point(3, 223)
        Me.com.Name = "com"
        Me.com.Size = New System.Drawing.Size(250, 38)
        Me.com.TabIndex = 174
        Me.com.Text = "COMERCIO"
        Me.com.UseVisualStyleBackColor = False
        Me.com.Visible = False
        '
        'per
        '
        Me.per.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.per.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.per.BackgroundImage = CType(resources.GetObject("per.BackgroundImage"), System.Drawing.Image)
        Me.per.FlatAppearance.BorderSize = 0
        Me.per.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.per.Font = New System.Drawing.Font("PF DinText Pro", 20.0!)
        Me.per.ForeColor = System.Drawing.Color.White
        Me.per.Location = New System.Drawing.Point(3, 267)
        Me.per.Name = "per"
        Me.per.Size = New System.Drawing.Size(250, 38)
        Me.per.TabIndex = 173
        Me.per.Text = "PERSONAS"
        Me.per.UseVisualStyleBackColor = False
        Me.per.Visible = False
        '
        'frm
        '
        Me.frm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.frm.BackColor = System.Drawing.Color.LightSlateGray
        Me.frm.BackgroundImage = CType(resources.GetObject("frm.BackgroundImage"), System.Drawing.Image)
        Me.frm.FlatAppearance.BorderSize = 0
        Me.frm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frm.Font = New System.Drawing.Font("PF DinText Pro", 20.0!)
        Me.frm.ForeColor = System.Drawing.Color.White
        Me.frm.Location = New System.Drawing.Point(3, 311)
        Me.frm.Name = "frm"
        Me.frm.Size = New System.Drawing.Size(250, 38)
        Me.frm.TabIndex = 175
        Me.frm.Text = "FORMULARIOS"
        Me.frm.UseVisualStyleBackColor = False
        Me.frm.Visible = False
        '
        'launcher
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 409)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.opc)
        Me.Controls.Add(Me.id)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("PF DinText Pro", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 200)
        Me.Name = "launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hacienda - Villa De Las Rosas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opendialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents opc As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents hac As System.Windows.Forms.Button
    Friend WithEvents gob As System.Windows.Forms.Button
    Friend WithEvents cat As System.Windows.Forms.Button
    Friend WithEvents opu As System.Windows.Forms.Button
    Friend WithEvents opr As System.Windows.Forms.Button
    Friend WithEvents per As System.Windows.Forms.Button
    Friend WithEvents com As System.Windows.Forms.Button
    Friend WithEvents frm As System.Windows.Forms.Button

End Class
