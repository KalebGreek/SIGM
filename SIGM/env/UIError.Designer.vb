<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIError
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
		Me.visor = New System.Windows.Forms.ListBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.cancel = New System.Windows.Forms.Button()
		Me.continuar = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'visor
		'
		Me.visor.BackColor = System.Drawing.Color.WhiteSmoke
		Me.visor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
		Me.visor.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.visor.ItemHeight = 19
		Me.visor.Location = New System.Drawing.Point(0, 0)
		Me.visor.Name = "visor"
		Me.visor.Size = New System.Drawing.Size(291, 272)
		Me.visor.TabIndex = 1
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.cancel)
		Me.Panel1.Controls.Add(Me.continuar)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel1.Location = New System.Drawing.Point(0, 272)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(291, 31)
		Me.Panel1.TabIndex = 5
		'
		'cancel
		'
		Me.cancel.BackColor = System.Drawing.Color.DimGray
		Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.cancel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.cancel.FlatAppearance.BorderSize = 0
		Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancel.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!)
		Me.cancel.ForeColor = System.Drawing.Color.White
		Me.cancel.Location = New System.Drawing.Point(0, 0)
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(146, 31)
		Me.cancel.TabIndex = 6
		Me.cancel.Text = "CANCELAR"
		Me.cancel.UseVisualStyleBackColor = False
		'
		'continuar
		'
		Me.continuar.BackColor = System.Drawing.Color.DimGray
		Me.continuar.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.continuar.Dock = System.Windows.Forms.DockStyle.Right
		Me.continuar.FlatAppearance.BorderSize = 0
		Me.continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.continuar.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.0!)
		Me.continuar.ForeColor = System.Drawing.Color.White
		Me.continuar.Location = New System.Drawing.Point(146, 0)
		Me.continuar.Name = "continuar"
		Me.continuar.Size = New System.Drawing.Size(145, 31)
		Me.continuar.TabIndex = 5
		Me.continuar.Text = "CONTINUAR"
		Me.continuar.UseVisualStyleBackColor = False
		'
		'visor_error
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(291, 303)
		Me.ControlBox = False
		Me.Controls.Add(Me.visor)
		Me.Controls.Add(Me.Panel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
		Me.Name = "visor_error"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "FORM - Errores"
		Me.TopMost = True
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents visor As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents continuar As System.Windows.Forms.Button
End Class
