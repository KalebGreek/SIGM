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
		Me.print = New System.Windows.Forms.Button()
		Me.saveAd = New System.Windows.Forms.Button()
		Me.newAd = New System.Windows.Forms.Button()
		Me.wrapper = New System.Windows.Forms.Panel()
		Me.Ad_page1 = New Sigm.AdelantoPage1()
		Me.bottomMenu.SuspendLayout()
		Me.wrapper.SuspendLayout()
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
		Me.bottomMenu.Controls.Add(Me.saveAd)
		Me.bottomMenu.Controls.Add(Me.newAd)
		Me.bottomMenu.Controls.Add(Me.print)
		Me.bottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.bottomMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.bottomMenu.Location = New System.Drawing.Point(0, 333)
		Me.bottomMenu.Margin = New System.Windows.Forms.Padding(0)
		Me.bottomMenu.Name = "bottomMenu"
		Me.bottomMenu.Size = New System.Drawing.Size(374, 28)
		Me.bottomMenu.TabIndex = 395
		'
		'print
		'
		Me.print.FlatAppearance.BorderSize = 0
		Me.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.print.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.print.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.print.Location = New System.Drawing.Point(256, 0)
		Me.print.Margin = New System.Windows.Forms.Padding(0)
		Me.print.Name = "print"
		Me.print.Size = New System.Drawing.Size(29, 29)
		Me.print.TabIndex = 398
		Me.print.Text = ""
		Me.print.UseVisualStyleBackColor = True
		'
		'saveAd
		'
		Me.saveAd.FlatAppearance.BorderSize = 0
		Me.saveAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.saveAd.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.saveAd.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.saveAd.Location = New System.Drawing.Point(314, 0)
		Me.saveAd.Margin = New System.Windows.Forms.Padding(0)
		Me.saveAd.Name = "saveAd"
		Me.saveAd.Size = New System.Drawing.Size(29, 29)
		Me.saveAd.TabIndex = 397
		Me.saveAd.Text = ""
		Me.saveAd.UseVisualStyleBackColor = True
		'
		'newAd
		'
		Me.newAd.FlatAppearance.BorderSize = 0
		Me.newAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.newAd.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.newAd.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.newAd.Location = New System.Drawing.Point(285, 0)
		Me.newAd.Margin = New System.Windows.Forms.Padding(0)
		Me.newAd.Name = "newAd"
		Me.newAd.Size = New System.Drawing.Size(29, 29)
		Me.newAd.TabIndex = 399
		Me.newAd.Text = ""
		Me.newAd.UseVisualStyleBackColor = True
		'
		'wrapper
		'
		Me.wrapper.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.wrapper.Controls.Add(Me.Ad_page1)
		Me.wrapper.Dock = System.Windows.Forms.DockStyle.Fill
		Me.wrapper.Location = New System.Drawing.Point(0, 0)
		Me.wrapper.Name = "wrapper"
		Me.wrapper.Size = New System.Drawing.Size(374, 333)
		Me.wrapper.TabIndex = 414
		'
		'Ad_page1
		'
		Me.Ad_page1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.Ad_page1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Ad_page1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Ad_page1.Location = New System.Drawing.Point(0, 0)
		Me.Ad_page1.Name = "Ad_page1"
		Me.Ad_page1.Size = New System.Drawing.Size(374, 333)
		Me.Ad_page1.TabIndex = 0
		'
		'ModAdelanto
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(374, 361)
		Me.Controls.Add(Me.wrapper)
		Me.Controls.Add(Me.bottomMenu)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.MinimumSize = New System.Drawing.Size(250, 250)
		Me.Name = "ModAdelanto"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "                                                                                 " &
	"                                                 "
		Me.bottomMenu.ResumeLayout(False)
		Me.bottomMenu.PerformLayout()
		Me.wrapper.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents persona_id As System.Windows.Forms.TextBox
	Friend WithEvents bottomMenu As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents saveAd As Button
	Friend WithEvents newAd As Button
	Friend WithEvents wrapper As Panel
	Friend WithEvents print As Button
	Friend WithEvents Ad_page1 As AdelantoPage1
End Class
