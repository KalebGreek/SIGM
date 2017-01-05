<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogoGen
	Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.TopMenu = New System.Windows.Forms.MenuStrip()
		Me.SectionTitle = New System.Windows.Forms.ToolStripMenuItem()
		Me.BottomMenu = New System.Windows.Forms.MenuStrip()
		Me.cancel = New System.Windows.Forms.ToolStripMenuItem()
		Me.save = New System.Windows.Forms.ToolStripMenuItem()
		Me.back = New System.Windows.Forms.ToolStripMenuItem()
		Me.title = New System.Windows.Forms.ToolStripMenuItem()
		Me.TopMenu.SuspendLayout()
		Me.BottomMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'TopMenu
		'
		Me.TopMenu.AutoSize = False
		Me.TopMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.TopMenu.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SectionTitle, Me.title})
		Me.TopMenu.Location = New System.Drawing.Point(0, 0)
		Me.TopMenu.Name = "TopMenu"
		Me.TopMenu.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
		Me.TopMenu.Size = New System.Drawing.Size(450, 25)
		Me.TopMenu.TabIndex = 373
		Me.TopMenu.Text = "top_menu"
		'
		'SectionTitle
		'
		Me.SectionTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.SectionTitle.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold)
		Me.SectionTitle.ForeColor = System.Drawing.Color.White
		Me.SectionTitle.Name = "SectionTitle"
		Me.SectionTitle.Size = New System.Drawing.Size(94, 25)
		Me.SectionTitle.Text = "[seccion]"
		'
		'BottomMenu
		'
		Me.BottomMenu.AutoSize = False
		Me.BottomMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.BottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.BottomMenu.Font = New System.Drawing.Font("PF DinText Pro", 10.0!)
		Me.BottomMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cancel, Me.save, Me.back})
		Me.BottomMenu.Location = New System.Drawing.Point(0, 230)
		Me.BottomMenu.Name = "BottomMenu"
		Me.BottomMenu.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
		Me.BottomMenu.Size = New System.Drawing.Size(450, 20)
		Me.BottomMenu.TabIndex = 374
		Me.BottomMenu.Text = "top_menu"
		'
		'cancel
		'
		Me.cancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.cancel.ForeColor = System.Drawing.Color.White
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(70, 20)
		Me.cancel.Text = "Cancelar"
		'
		'save
		'
		Me.save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.save.ForeColor = System.Drawing.Color.White
		Me.save.Name = "save"
		Me.save.Size = New System.Drawing.Size(83, 20)
		Me.save.Text = "Siguiente >"
		'
		'back
		'
		Me.back.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.back.ForeColor = System.Drawing.Color.White
		Me.back.Name = "back"
		Me.back.Size = New System.Drawing.Size(61, 20)
		Me.back.Text = "< Atras"
		'
		'title
		'
		Me.title.ForeColor = System.Drawing.Color.White
		Me.title.Name = "title"
		Me.title.Size = New System.Drawing.Size(115, 25)
		Me.title.Text = "[titulo dialogo]"
		'
		'DialogoGen
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(450, 250)
		Me.Controls.Add(Me.TopMenu)
		Me.Controls.Add(Me.BottomMenu)
		Me.Font = New System.Drawing.Font("PF DinText Pro", 14.25!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MinimumSize = New System.Drawing.Size(400, 200)
		Me.Name = "DialogoGen"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.TopMenu.ResumeLayout(False)
		Me.TopMenu.PerformLayout()
		Me.BottomMenu.ResumeLayout(False)
		Me.BottomMenu.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TopMenu As System.Windows.Forms.MenuStrip
	Friend WithEvents SectionTitle As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents BottomMenu As MenuStrip
	Friend WithEvents cancel As ToolStripMenuItem
	Friend WithEvents save As ToolStripMenuItem
	Friend WithEvents back As ToolStripMenuItem
	Friend WithEvents title As ToolStripMenuItem
End Class
