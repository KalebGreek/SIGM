<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarFrente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Menu1 = New System.Windows.Forms.MenuStrip()
        Me.titulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.metros = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calle = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.altura = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        Me.Menu1.SuspendLayout()
        CType(Me.metros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.altura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Agregar)
        Me.Panel1.Controls.Add(Me.cancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 35)
        Me.Panel1.TabIndex = 157
        '
        'Agregar
        '
        Me.Agregar.BackColor = System.Drawing.Color.Silver
        Me.Agregar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Agregar.Enabled = False
        Me.Agregar.FlatAppearance.BorderSize = 0
        Me.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Agregar.ForeColor = System.Drawing.Color.Black
        Me.Agregar.Location = New System.Drawing.Point(162, 0)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(123, 31)
        Me.Agregar.TabIndex = 80
        Me.Agregar.Text = "AGREGAR >"
        Me.Agregar.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.Silver
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.cancel.ForeColor = System.Drawing.Color.Black
        Me.cancel.Location = New System.Drawing.Point(285, 0)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(123, 31)
        Me.cancel.TabIndex = 90
        Me.cancel.Text = "CANCELAR"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'Menu1
        '
        Me.Menu1.AutoSize = False
        Me.Menu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Menu1.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
        Me.Menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.titulo})
        Me.Menu1.Location = New System.Drawing.Point(0, 0)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(412, 30)
        Me.Menu1.TabIndex = 156
        Me.Menu1.Text = "MenuStrip1"
        '
        'titulo
        '
        Me.titulo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.titulo.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!, System.Drawing.FontStyle.Bold)
        Me.titulo.ForeColor = System.Drawing.Color.White
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(188, 26)
        Me.titulo.Text = "AGREGAR FRENTE <"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label16.Location = New System.Drawing.Point(178, 120)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 33)
        Me.Label16.TabIndex = 363
        Me.Label16.Text = "metros"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'metros
        '
        Me.metros.DecimalPlaces = 2
        Me.metros.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.metros.ForeColor = System.Drawing.Color.Black
        Me.metros.Location = New System.Drawing.Point(79, 123)
        Me.metros.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.metros.Name = "metros"
        Me.metros.Size = New System.Drawing.Size(96, 30)
        Me.metros.TabIndex = 70
        Me.metros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.metros.ThousandsSeparator = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label15.Location = New System.Drawing.Point(22, 125)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 22)
        Me.Label15.TabIndex = 361
        Me.Label15.Text = "Largo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(18, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 359
        Me.Label1.Text = "Altura"
        '
        'calle
        '
        Me.calle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.calle.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.calle.Location = New System.Drawing.Point(79, 45)
        Me.calle.Margin = New System.Windows.Forms.Padding(4)
        Me.calle.MaxLength = 64
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(318, 30)
        Me.calle.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.Label14.Location = New System.Drawing.Point(27, 49)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 22)
        Me.Label14.TabIndex = 357
        Me.Label14.Text = "Calle"
        '
        'altura
        '
        Me.altura.Font = New System.Drawing.Font("PF DinText Pro", 14.0!)
        Me.altura.ForeColor = System.Drawing.Color.Black
        Me.altura.Location = New System.Drawing.Point(79, 84)
        Me.altura.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.altura.Name = "altura"
        Me.altura.Size = New System.Drawing.Size(96, 30)
        Me.altura.TabIndex = 60
        Me.altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.altura.ThousandsSeparator = True
        '
        'AgregarFrente
        '
        Me.AcceptButton = Me.Agregar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.cancel
        Me.ClientSize = New System.Drawing.Size(412, 205)
        Me.Controls.Add(Me.altura)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.metros)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calle)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Menu1)
        Me.Font = New System.Drawing.Font("PF DinText Pro", 14.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarFrente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "verify_cat"
        Me.Panel1.ResumeLayout(False)
        Me.Menu1.ResumeLayout(False)
        Me.Menu1.PerformLayout()
        CType(Me.metros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.altura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Agregar As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents Menu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents titulo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents metros As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents calle As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents altura As System.Windows.Forms.NumericUpDown
End Class
