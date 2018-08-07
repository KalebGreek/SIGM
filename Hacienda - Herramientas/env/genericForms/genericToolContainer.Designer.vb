<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class genericToolContainer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(genericToolContainer))
		Me.SuspendLayout()
		'
		'genericToolContainer
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(484, 361)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
		Me.MinimumSize = New System.Drawing.Size(500, 400)
		Me.Name = "genericToolContainer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "[titulo]"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents RadioButton1 As RadioButton
End Class
