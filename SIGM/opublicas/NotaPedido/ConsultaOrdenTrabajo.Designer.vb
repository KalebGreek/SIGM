<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaOrdenTrabajo
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.ControlBusqueda1 = New Sigm.genSearchControl()
        CType(Me.resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
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
        Me.resultado.Location = New System.Drawing.Point(0, 33)
        Me.resultado.Margin = New System.Windows.Forms.Padding(0)
        Me.resultado.Name = "resultado"
        Me.resultado.ReadOnly = True
        Me.resultado.RowHeadersVisible = False
        Me.resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.resultado.Size = New System.Drawing.Size(556, 288)
        Me.resultado.TabIndex = 367
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.FlowLayoutPanel1.Controls.Add(Me.nuevo)
        Me.FlowLayoutPanel1.Controls.Add(Me.modificar)
        Me.FlowLayoutPanel1.Controls.Add(Me.eliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.imprimir)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(556, 33)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(103, 288)
        Me.FlowLayoutPanel1.TabIndex = 369
        '
        'nuevo
        '
        Me.nuevo.FlatAppearance.BorderSize = 0
        Me.nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nuevo.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.nuevo.Location = New System.Drawing.Point(0, 0)
        Me.nuevo.Margin = New System.Windows.Forms.Padding(0)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(81, 27)
        Me.nuevo.TabIndex = 398
        Me.nuevo.Text = " NUEVO"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.FlatAppearance.BorderSize = 0
        Me.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.modificar.Location = New System.Drawing.Point(0, 27)
        Me.modificar.Margin = New System.Windows.Forms.Padding(0)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(102, 27)
        Me.modificar.TabIndex = 399
        Me.modificar.Text = " MODIFICAR"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.FlatAppearance.BorderSize = 0
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.eliminar.Location = New System.Drawing.Point(0, 54)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(93, 27)
        Me.eliminar.TabIndex = 400
        Me.eliminar.Text = " ELIMINAR"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'imprimir
        '
        Me.imprimir.FlatAppearance.BorderSize = 0
        Me.imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.imprimir.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprimir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.imprimir.Location = New System.Drawing.Point(0, 81)
        Me.imprimir.Margin = New System.Windows.Forms.Padding(0)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(93, 27)
        Me.imprimir.TabIndex = 401
        Me.imprimir.Text = " IMPRIMIR"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'ControlBusqueda1
        '
        Me.ControlBusqueda1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ControlBusqueda1.BackColor = System.Drawing.Color.Gray
        Me.ControlBusqueda1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlBusqueda1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlBusqueda1.Location = New System.Drawing.Point(0, 0)
        Me.ControlBusqueda1.Margin = New System.Windows.Forms.Padding(0)
        Me.ControlBusqueda1.MinimumSize = New System.Drawing.Size(520, 33)
        Me.ControlBusqueda1.Name = "ControlBusqueda1"
        Me.ControlBusqueda1.Size = New System.Drawing.Size(659, 33)
        Me.ControlBusqueda1.TabIndex = 368
        '
        'ConsultaOrdenTrabajo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(659, 321)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ControlBusqueda1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(675, 360)
        Me.Name = "ConsultaOrdenTrabajo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar"
        CType(Me.resultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents resultado As DataGridView
	Friend WithEvents ControlBusqueda1 As genSearchControl
	Friend WithEvents bs_resultado As BindingSource
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents nuevo As Button
	Friend WithEvents modificar As Button
	Friend WithEvents eliminar As Button
	Friend WithEvents imprimir As Button
End Class
