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
        Me.top_menu.SuspendLayout()
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
        Me.user.Location = New System.Drawing.Point(13, 45)
        Me.user.MaxLength = 32
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(240, 24)
        Me.user.TabIndex = 20
        Me.user.Text = "USUARIO"
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.White
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pass.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!)
        Me.pass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.pass.Location = New System.Drawing.Point(13, 80)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(240, 24)
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
        Me.login.Location = New System.Drawing.Point(13, 120)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(154, 30)
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
        Me.top_menu.Size = New System.Drawing.Size(269, 33)
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
        Me.salir.Location = New System.Drawing.Point(175, 120)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(78, 30)
        Me.salir.TabIndex = 160
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = False
        '
        'acceso
        '
        Me.AcceptButton = Me.login
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.salir
        Me.ClientSize = New System.Drawing.Size(269, 165)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.top_menu)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents opendialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents top_menu As System.Windows.Forms.MenuStrip
    Friend WithEvents titulo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents user_id As System.Windows.Forms.ToolStripTextBox

End Class
