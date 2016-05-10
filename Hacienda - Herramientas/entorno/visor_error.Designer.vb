<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visor_error
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
        Me.ok = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'visor
        '
        Me.visor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.visor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.visor.FormattingEnabled = True
        Me.visor.ItemHeight = 19
        Me.visor.Location = New System.Drawing.Point(0, 0)
        Me.visor.Name = "visor"
        Me.visor.Size = New System.Drawing.Size(350, 303)
        Me.visor.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cancel)
        Me.Panel1.Controls.Add(Me.ok)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 31)
        Me.Panel1.TabIndex = 5
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.DimGray
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!)
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.Location = New System.Drawing.Point(0, 0)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(175, 31)
        Me.cancel.TabIndex = 6
        Me.cancel.Text = "CANCELAR"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'ok
        '
        Me.ok.BackColor = System.Drawing.Color.DimGray
        Me.ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ok.Dock = System.Windows.Forms.DockStyle.Right
        Me.ok.FlatAppearance.BorderSize = 0
        Me.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok.Font = New System.Drawing.Font("PF DinDisplay Pro", 15.0!)
        Me.ok.ForeColor = System.Drawing.Color.White
        Me.ok.Location = New System.Drawing.Point(175, 0)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(175, 31)
        Me.ok.TabIndex = 5
        Me.ok.Text = "CONTINUAR"
        Me.ok.UseVisualStyleBackColor = False
        '
        'visor_error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 303)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.visor)
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
    Friend WithEvents ok As System.Windows.Forms.Button
End Class
