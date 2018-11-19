<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusquedaPropietario
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
		Me.resultado = New System.Windows.Forms.DataGridView()
		Me.bs_resultado = New System.Windows.Forms.BindingSource(Me.components)
		Me.genSearchControl1 = New Sigm.genSearchControl()
		CType(Me.resultado, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'resultado
		'
		Me.resultado.AllowUserToAddRows = False
		Me.resultado.AllowUserToDeleteRows = False
		Me.resultado.AllowUserToResizeRows = False
		Me.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.resultado.Dock = System.Windows.Forms.DockStyle.Fill
		Me.resultado.Location = New System.Drawing.Point(0, 36)
		Me.resultado.Margin = New System.Windows.Forms.Padding(0)
		Me.resultado.Name = "resultado"
		Me.resultado.ReadOnly = True
		Me.resultado.RowHeadersVisible = False
		Me.resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.resultado.Size = New System.Drawing.Size(659, 285)
		Me.resultado.TabIndex = 367
		'
		'genSearchControl1
		'
		Me.genSearchControl1.AutoSize = True
		Me.genSearchControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.genSearchControl1.BackColor = System.Drawing.Color.DarkGray
		Me.genSearchControl1.Dock = System.Windows.Forms.DockStyle.Top
		Me.genSearchControl1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.genSearchControl1.Location = New System.Drawing.Point(0, 0)
		Me.genSearchControl1.Margin = New System.Windows.Forms.Padding(0)
		Me.genSearchControl1.MinimumSize = New System.Drawing.Size(520, 33)
		Me.genSearchControl1.Name = "genSearchControl1"
		Me.genSearchControl1.Size = New System.Drawing.Size(659, 36)
		Me.genSearchControl1.TabIndex = 368
		'
		'BusquedaPropietario
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(659, 321)
		Me.Controls.Add(Me.resultado)
		Me.Controls.Add(Me.genSearchControl1)
		Me.Font = New System.Drawing.Font("PF DinText Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MinimumSize = New System.Drawing.Size(675, 360)
		Me.Name = "BusquedaPropietario"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Buscar"
		CType(Me.resultado, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents resultado As DataGridView
	Public WithEvents genSearchControl1 As genSearchControl
	Friend WithEvents bs_resultado As BindingSource
End Class
