<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModPersona
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
        Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
        Me.save = New System.Windows.Forms.Button()
        Me.nextPage = New System.Windows.Forms.Button()
        Me.lastPage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.grupo_mod.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupo_mod
        '
        Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
        Me.grupo_mod.Controls.Add(Me.save)
        Me.grupo_mod.Controls.Add(Me.nextPage)
        Me.grupo_mod.Controls.Add(Me.lastPage)
        Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.grupo_mod.Location = New System.Drawing.Point(0, 333)
        Me.grupo_mod.Margin = New System.Windows.Forms.Padding(0)
        Me.grupo_mod.Name = "grupo_mod"
        Me.grupo_mod.Size = New System.Drawing.Size(374, 28)
        Me.grupo_mod.TabIndex = 395
        '
        'save
        '
        Me.save.FlatAppearance.BorderSize = 0
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.save.Location = New System.Drawing.Point(345, 0)
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
        Me.nextPage.Location = New System.Drawing.Point(316, 0)
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
        Me.lastPage.Location = New System.Drawing.Point(287, 0)
        Me.lastPage.Margin = New System.Windows.Forms.Padding(0)
        Me.lastPage.Name = "lastPage"
        Me.lastPage.Size = New System.Drawing.Size(29, 29)
        Me.lastPage.TabIndex = 400
        Me.lastPage.Text = ""
        Me.lastPage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 27)
        Me.Label1.TabIndex = 413
        Me.Label1.Text = "DATOS PERSONALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(374, 333)
        Me.TabControl1.TabIndex = 414
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(366, 301)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Personales"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(366, 301)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Domicilio"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(366, 301)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Contacto"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(366, 301)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Datos Adicionales"
        '
        'ModPersona
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(374, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grupo_mod)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximumSize = New System.Drawing.Size(390, 400)
        Me.MinimumSize = New System.Drawing.Size(390, 400)
        Me.Name = "ModPersona"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "                                                                                 " &
    "                                                 "
        Me.grupo_mod.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents save As Button
    Friend WithEvents nextPage As Button
    Friend WithEvents lastPage As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
End Class
