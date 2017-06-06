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
		Me.salir = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.info = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'opendialog
		'
		Me.opendialog.FileName = "opendialog"
		'
		'user
		'
		Me.user.BackColor = System.Drawing.Color.WhiteSmoke
		Me.user.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.user.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.user.ForeColor = System.Drawing.Color.Black
		Me.user.Location = New System.Drawing.Point(30, 3)
		Me.user.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.user.MaxLength = 32
		Me.user.Name = "user"
		Me.user.Size = New System.Drawing.Size(201, 24)
		Me.user.TabIndex = 20
		Me.user.Text = "USUARIO"
		'
		'pass
		'
		Me.pass.BackColor = System.Drawing.Color.WhiteSmoke
		Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.pass.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!)
		Me.pass.ForeColor = System.Drawing.Color.Black
		Me.pass.Location = New System.Drawing.Point(30, 30)
		Me.pass.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
		Me.pass.Name = "pass"
		Me.pass.Size = New System.Drawing.Size(201, 24)
		Me.pass.TabIndex = 30
		Me.pass.Text = "CONTRASEÑA"
		Me.pass.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
		'
		'login
		'
		Me.login.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.login.BackColor = System.Drawing.Color.DarkGray
		Me.login.FlatAppearance.BorderSize = 0
		Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.login.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
		Me.login.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.login.Location = New System.Drawing.Point(5, 83)
		Me.login.Margin = New System.Windows.Forms.Padding(5, 5, 3, 8)
		Me.login.Name = "login"
		Me.login.Size = New System.Drawing.Size(125, 30)
		Me.login.TabIndex = 1
		Me.login.Text = "ACCEDER"
		Me.login.UseVisualStyleBackColor = False
		'
		'salir
		'
		Me.salir.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.salir.BackColor = System.Drawing.Color.DarkGray
		Me.salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.salir.FlatAppearance.BorderSize = 0
		Me.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.salir.Font = New System.Drawing.Font("PF DinDisplay Pro", 13.0!)
		Me.salir.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.salir.Location = New System.Drawing.Point(136, 83)
		Me.salir.Margin = New System.Windows.Forms.Padding(3, 5, 3, 8)
		Me.salir.Name = "salir"
		Me.salir.Size = New System.Drawing.Size(95, 30)
		Me.salir.TabIndex = 160
		Me.salir.Text = "SALIR"
		Me.salir.UseVisualStyleBackColor = False
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.user)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
		Me.FlowLayoutPanel1.Controls.Add(Me.pass)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Controls.Add(Me.info)
		Me.FlowLayoutPanel1.Controls.Add(Me.login)
		Me.FlowLayoutPanel1.Controls.Add(Me.salir)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(236, 120)
		Me.FlowLayoutPanel1.TabIndex = 161
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.0!)
		Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.Label2.Location = New System.Drawing.Point(4, 3)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 3, 0, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(26, 24)
		Me.Label2.TabIndex = 163
		Me.Label2.Text = ""
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Segoe MDL2 Assets", 15.0!)
		Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.Label1.Location = New System.Drawing.Point(4, 30)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 3, 0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(26, 24)
		Me.Label1.TabIndex = 162
		Me.Label1.Text = ""
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Location = New System.Drawing.Point(6, 54)
		Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(12, 24)
		Me.Label4.TabIndex = 164
		Me.Label4.Text = ""
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'info
		'
		Me.info.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.info.ForeColor = System.Drawing.Color.Gold
		Me.info.Location = New System.Drawing.Point(18, 54)
		Me.info.Margin = New System.Windows.Forms.Padding(0)
		Me.info.Name = "info"
		Me.info.Size = New System.Drawing.Size(213, 24)
		Me.info.TabIndex = 161
		Me.info.Text = "Ingrese usuario y contraseña."
		Me.info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
		Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.Label3.Location = New System.Drawing.Point(0, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(236, 24)
		Me.Label3.TabIndex = 165
		Me.Label3.Text = "ACCESO SIGM"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'acceso
		'
		Me.AcceptButton = Me.login
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DimGray
		Me.CancelButton = Me.salir
		Me.ClientSize = New System.Drawing.Size(236, 144)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.Label3)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximumSize = New System.Drawing.Size(800, 500)
		Me.Name = "acceso"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SIGM > Acceso"
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents opendialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents login As System.Windows.Forms.Button
	Friend WithEvents salir As System.Windows.Forms.Button
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents info As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
End Class
