<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acceso))
        Me.opendialog = New System.Windows.Forms.OpenFileDialog()
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.MaskedTextBox()
        Me.login = New System.Windows.Forms.Button()
        Me.top_menu = New System.Windows.Forms.MenuStrip()
        Me.titulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.user_id = New System.Windows.Forms.ToolStripTextBox()
        Me.salir = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.info = New System.Windows.Forms.Label()
        Me.top_menu.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'opendialog
        '
        Me.opendialog.FileName = "opendialog"
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.White
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.user.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.user.Location = New System.Drawing.Point(8, 8)
        Me.user.Margin = New System.Windows.Forms.Padding(8, 8, 8, 3)
        Me.user.MaxLength = 32
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(230, 24)
        Me.user.TabIndex = 20
        Me.user.Text = "USUARIO"
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.White
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pass.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!)
        Me.pass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.pass.Location = New System.Drawing.Point(8, 38)
        Me.pass.Margin = New System.Windows.Forms.Padding(8, 3, 3, 0)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(230, 24)
        Me.pass.TabIndex = 30
        Me.pass.Text = "CONTRASEÑA"
        Me.pass.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'login
        '
        Me.login.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.login.BackColor = System.Drawing.Color.Gray
        Me.login.FlatAppearance.BorderSize = 0
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.login.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.login.Location = New System.Drawing.Point(8, 87)
        Me.login.Margin = New System.Windows.Forms.Padding(8, 5, 3, 8)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(143, 30)
        Me.login.TabIndex = 1
        Me.login.Text = "INICIAR SESIÓN"
        Me.login.UseVisualStyleBackColor = False
        '
        'top_menu
        '
        Me.top_menu.AutoSize = False
        Me.top_menu.BackColor = System.Drawing.Color.DarkGray
        Me.top_menu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.top_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.titulo, Me.user_id})
        Me.top_menu.Location = New System.Drawing.Point(0, 0)
        Me.top_menu.Name = "top_menu"
        Me.top_menu.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.top_menu.Size = New System.Drawing.Size(246, 33)
        Me.top_menu.TabIndex = 159
        '
        'titulo
        '
        Me.titulo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.titulo.BackColor = System.Drawing.Color.Transparent
        Me.titulo.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!)
        Me.titulo.ForeColor = System.Drawing.Color.White
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(91, 27)
        Me.titulo.Text = "ACCESO"
        '
        'user_id
        '
        Me.user_id.Name = "user_id"
        Me.user_id.Size = New System.Drawing.Size(100, 27)
        Me.user_id.Text = "-1"
        Me.user_id.Visible = False
        '
        'salir
        '
        Me.salir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.salir.BackColor = System.Drawing.Color.Gray
        Me.salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.salir.FlatAppearance.BorderSize = 0
        Me.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salir.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
        Me.salir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.salir.Location = New System.Drawing.Point(157, 87)
        Me.salir.Margin = New System.Windows.Forms.Padding(3, 5, 8, 8)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(81, 30)
        Me.salir.TabIndex = 160
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.user)
        Me.FlowLayoutPanel1.Controls.Add(Me.pass)
        Me.FlowLayoutPanel1.Controls.Add(Me.info)
        Me.FlowLayoutPanel1.Controls.Add(Me.login)
        Me.FlowLayoutPanel1.Controls.Add(Me.salir)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 33)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(246, 125)
        Me.FlowLayoutPanel1.TabIndex = 161
        '
        'info
        '
        Me.info.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.Gold
        Me.info.Location = New System.Drawing.Point(5, 62)
        Me.info.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(236, 20)
        Me.info.TabIndex = 161
        Me.info.Text = "Ingrese usuario y contraseña."
        '
        'acceso
        '
        Me.AcceptButton = Me.login
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.salir
        Me.ClientSize = New System.Drawing.Size(246, 158)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.top_menu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(200, 150)
        Me.Name = "acceso"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGM > Acceso"
        Me.top_menu.ResumeLayout(False)
        Me.top_menu.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents opendialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents top_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents titulo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents user_id As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents info As Label
End Class
