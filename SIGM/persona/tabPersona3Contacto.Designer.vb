<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabPersona3Contacto
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tele = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.ErrorInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.tele)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(360, 34)
        Me.FlowLayoutPanel1.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 25)
        Me.Label8.TabIndex = 231
        Me.Label8.Text = "Teléfono"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tele
        '
        Me.tele.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tele.Location = New System.Drawing.Point(74, 6)
        Me.tele.MaxLength = 64
        Me.tele.Name = "tele"
        Me.tele.Size = New System.Drawing.Size(280, 27)
        Me.tele.TabIndex = 31
        Me.tele.Text = "0"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.email)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 34)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(360, 38)
        Me.FlowLayoutPanel2.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "E-Mail"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(74, 6)
        Me.email.MaxLength = 64
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(280, 27)
        Me.email.TabIndex = 33
        Me.email.Text = "mail@mail.com"
        '
        'tabPersona3Contacto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "tabPersona3Contacto"
        Me.Size = New System.Drawing.Size(360, 72)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label8 As Label
	Friend WithEvents tele As TextBox
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents email As TextBox
	Friend WithEvents ErrorInfo As ToolTip
End Class
