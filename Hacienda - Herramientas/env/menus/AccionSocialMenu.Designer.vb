<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccionSocialMenu
	Inherits System.Windows.Forms.UserControl

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
        Me.BaseMenu = New System.Windows.Forms.MenuStrip()
        Me.asocialMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoBeneficiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarBeneficiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseMenu
        '
        Me.BaseMenu.BackColor = System.Drawing.Color.Transparent
        Me.BaseMenu.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.asocialMenu})
        Me.BaseMenu.Location = New System.Drawing.Point(0, 0)
        Me.BaseMenu.Name = "BaseMenu"
        Me.BaseMenu.Size = New System.Drawing.Size(300, 27)
        Me.BaseMenu.TabIndex = 389
        Me.BaseMenu.Text = "MenuStrip1"
        '
        'asocialMenu
        '
        Me.asocialMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoBeneficiarioToolStripMenuItem, Me.BuscarBeneficiarioToolStripMenuItem})
        Me.asocialMenu.ForeColor = System.Drawing.Color.White
        Me.asocialMenu.Name = "asocialMenu"
        Me.asocialMenu.Padding = New System.Windows.Forms.Padding(0)
        Me.asocialMenu.Size = New System.Drawing.Size(125, 23)
        Me.asocialMenu.Text = "BENEFICIARIOS"
        '
        'NuevoBeneficiarioToolStripMenuItem
        '
        Me.NuevoBeneficiarioToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.NuevoBeneficiarioToolStripMenuItem.Name = "NuevoBeneficiarioToolStripMenuItem"
        Me.NuevoBeneficiarioToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.NuevoBeneficiarioToolStripMenuItem.Text = "Nuevo.."
        '
        'BuscarBeneficiarioToolStripMenuItem
        '
        Me.BuscarBeneficiarioToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.BuscarBeneficiarioToolStripMenuItem.Name = "BuscarBeneficiarioToolStripMenuItem"
        Me.BuscarBeneficiarioToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.BuscarBeneficiarioToolStripMenuItem.Text = "Buscar.."
        '
        'AccionSocialMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Controls.Add(Me.BaseMenu)
        Me.Name = "AccionSocialMenu"
        Me.Size = New System.Drawing.Size(300, 25)
        Me.BaseMenu.ResumeLayout(False)
        Me.BaseMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BaseMenu As MenuStrip
	Friend WithEvents asocialMenu As ToolStripMenuItem
	Friend WithEvents NuevoBeneficiarioToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BuscarBeneficiarioToolStripMenuItem As ToolStripMenuItem
End Class
