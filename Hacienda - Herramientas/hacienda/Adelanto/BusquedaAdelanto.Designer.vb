<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusquedaAdelanto
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
		Me.bs_resultado = New System.Windows.Forms.BindingSource(Me.components)
		Me.resultado = New System.Windows.Forms.DataGridView()
		Me.GenSearchControl1 = New Sigm.genSearchControl()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.resultado, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.resultado.Size = New System.Drawing.Size(584, 325)
		Me.resultado.TabIndex = 368
		'
		'GenSearchControl1
		'
		Me.GenSearchControl1.AutoSize = True
		Me.GenSearchControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GenSearchControl1.BackColor = System.Drawing.Color.DarkGray
		Me.GenSearchControl1.Dock = System.Windows.Forms.DockStyle.Top
		Me.GenSearchControl1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GenSearchControl1.Location = New System.Drawing.Point(0, 0)
		Me.GenSearchControl1.MinimumSize = New System.Drawing.Size(520, 33)
		Me.GenSearchControl1.Name = "GenSearchControl1"
		Me.GenSearchControl1.Size = New System.Drawing.Size(584, 36)
		Me.GenSearchControl1.TabIndex = 0
		'
		'BusquedaAdelanto
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(584, 361)
		Me.Controls.Add(Me.resultado)
		Me.Controls.Add(Me.GenSearchControl1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.KeyPreview = True
		Me.Name = "BusquedaAdelanto"
		Me.Text = "Adelantos"
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.resultado, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GenSearchControl1 As genSearchControl
	Friend WithEvents bs_resultado As BindingSource
	Friend WithEvents resultado As DataGridView
End Class
