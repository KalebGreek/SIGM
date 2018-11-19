<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModAdelanto
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
		Me.persona_id = New System.Windows.Forms.TextBox()
		Me.bottomMenu = New System.Windows.Forms.FlowLayoutPanel()
		Me.cancel = New System.Windows.Forms.Button()
		Me.save = New System.Windows.Forms.Button()
		Me.nextPage = New System.Windows.Forms.Button()
		Me.lastPage = New System.Windows.Forms.Button()
		Me.wrapper = New System.Windows.Forms.Panel()
		Me.bottomMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'persona_id
		'
		Me.persona_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(185, Byte), Integer))
		Me.persona_id.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.persona_id.Location = New System.Drawing.Point(346, 3)
		Me.persona_id.MaxLength = 128
		Me.persona_id.Name = "persona_id"
		Me.persona_id.ReadOnly = True
		Me.persona_id.Size = New System.Drawing.Size(25, 27)
		Me.persona_id.TabIndex = 373
		Me.persona_id.Text = "0"
		Me.persona_id.Visible = False
		'
		'bottomMenu
		'
		Me.bottomMenu.BackColor = System.Drawing.Color.DimGray
		Me.bottomMenu.Controls.Add(Me.persona_id)
		Me.bottomMenu.Controls.Add(Me.cancel)
		Me.bottomMenu.Controls.Add(Me.save)
		Me.bottomMenu.Controls.Add(Me.nextPage)
		Me.bottomMenu.Controls.Add(Me.lastPage)
		Me.bottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.bottomMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.bottomMenu.Location = New System.Drawing.Point(0, 333)
		Me.bottomMenu.Margin = New System.Windows.Forms.Padding(0)
		Me.bottomMenu.Name = "bottomMenu"
		Me.bottomMenu.Size = New System.Drawing.Size(374, 28)
		Me.bottomMenu.TabIndex = 395
		'
		'cancel
		'
		Me.cancel.FlatAppearance.BorderSize = 0
		Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancel.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cancel.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.cancel.Location = New System.Drawing.Point(314, 0)
		Me.cancel.Margin = New System.Windows.Forms.Padding(0)
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(29, 29)
		Me.cancel.TabIndex = 398
		Me.cancel.Text = ""
		Me.cancel.UseVisualStyleBackColor = True
		'
		'save
		'
		Me.save.FlatAppearance.BorderSize = 0
		Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.save.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.save.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.save.Location = New System.Drawing.Point(285, 0)
		Me.save.Margin = New System.Windows.Forms.Padding(0)
		Me.save.Name = "save"
		Me.save.Size = New System.Drawing.Size(29, 29)
		Me.save.TabIndex = 397
		Me.save.Text = ""
		Me.save.UseVisualStyleBackColor = True
		'
		'nextPage
		'
		Me.nextPage.FlatAppearance.BorderSize = 0
		Me.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.nextPage.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nextPage.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.nextPage.Location = New System.Drawing.Point(256, 0)
		Me.nextPage.Margin = New System.Windows.Forms.Padding(0)
		Me.nextPage.Name = "nextPage"
		Me.nextPage.Size = New System.Drawing.Size(29, 29)
		Me.nextPage.TabIndex = 399
		Me.nextPage.Text = ""
		Me.nextPage.UseVisualStyleBackColor = True
		'
		'lastPage
		'
		Me.lastPage.Enabled = False
		Me.lastPage.FlatAppearance.BorderSize = 0
		Me.lastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lastPage.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lastPage.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lastPage.Location = New System.Drawing.Point(227, 0)
		Me.lastPage.Margin = New System.Windows.Forms.Padding(0)
		Me.lastPage.Name = "lastPage"
		Me.lastPage.Size = New System.Drawing.Size(29, 29)
		Me.lastPage.TabIndex = 400
		Me.lastPage.Text = ""
		Me.lastPage.UseVisualStyleBackColor = True
		'
		'wrapper
		'
		Me.wrapper.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.wrapper.Dock = System.Windows.Forms.DockStyle.Fill
		Me.wrapper.Location = New System.Drawing.Point(0, 0)
		Me.wrapper.Name = "wrapper"
		Me.wrapper.Size = New System.Drawing.Size(374, 333)
		Me.wrapper.TabIndex = 414
		'
		'genModDialog
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(374, 361)
		Me.Controls.Add(Me.wrapper)
		Me.Controls.Add(Me.bottomMenu)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(250, 250)
		Me.Name = "genModDialog"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "                                                                                 " &
	"                                                 "
		Me.bottomMenu.ResumeLayout(False)
		Me.bottomMenu.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents persona_id As System.Windows.Forms.TextBox
	Friend WithEvents bottomMenu As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents cancel As Button
	Friend WithEvents save As Button
	Friend WithEvents nextPage As Button
	Friend WithEvents lastPage As Button
	Friend WithEvents wrapper As Panel
End Class
