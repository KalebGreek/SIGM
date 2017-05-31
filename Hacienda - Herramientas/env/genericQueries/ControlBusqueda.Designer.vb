<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlBusqueda


	'UserControl overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.DateValue = New System.Windows.Forms.DateTimePicker()
		Me.vista = New System.Windows.Forms.ComboBox()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.filtro = New System.Windows.Forms.ComboBox()
		Me.keyword = New System.Windows.Forms.TextBox()
		Me.search = New System.Windows.Forms.Button()
		Me.reset = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'DateValue
		'
		Me.DateValue.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
		Me.DateValue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateValue.Location = New System.Drawing.Point(441, 3)
		Me.DateValue.Name = "DateValue"
		Me.DateValue.Size = New System.Drawing.Size(140, 27)
		Me.DateValue.TabIndex = 361
		Me.DateValue.Visible = False
		'
		'vista
		'
		Me.vista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.vista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.vista.FormattingEnabled = True
		Me.vista.Location = New System.Drawing.Point(3, 3)
		Me.vista.Name = "vista"
		Me.vista.Size = New System.Drawing.Size(140, 27)
		Me.vista.TabIndex = 362
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.vista)
		Me.FlowLayoutPanel1.Controls.Add(Me.filtro)
		Me.FlowLayoutPanel1.Controls.Add(Me.keyword)
		Me.FlowLayoutPanel1.Controls.Add(Me.DateValue)
		Me.FlowLayoutPanel1.Controls.Add(Me.search)
		Me.FlowLayoutPanel1.Controls.Add(Me.reset)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(718, 33)
		Me.FlowLayoutPanel1.TabIndex = 363
		'
		'filtro
		'
		Me.filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.filtro.FormattingEnabled = True
		Me.filtro.Location = New System.Drawing.Point(149, 3)
		Me.filtro.Name = "filtro"
		Me.filtro.Size = New System.Drawing.Size(140, 27)
		Me.filtro.TabIndex = 363
		'
		'keyword
		'
		Me.keyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.keyword.Location = New System.Drawing.Point(295, 3)
		Me.keyword.Name = "keyword"
		Me.keyword.Size = New System.Drawing.Size(140, 27)
		Me.keyword.TabIndex = 364
		'
		'search
		'
		Me.search.FlatAppearance.BorderSize = 0
		Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.search.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.search.ForeColor = System.Drawing.Color.White
		Me.search.Location = New System.Drawing.Point(584, 0)
		Me.search.Margin = New System.Windows.Forms.Padding(0)
		Me.search.Name = "search"
		Me.search.Size = New System.Drawing.Size(38, 33)
		Me.search.TabIndex = 365
		Me.search.Text = ""
		Me.search.UseVisualStyleBackColor = True
		'
		'reset
		'
		Me.reset.FlatAppearance.BorderSize = 0
		Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.reset.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.reset.ForeColor = System.Drawing.Color.White
		Me.reset.Location = New System.Drawing.Point(622, 0)
		Me.reset.Margin = New System.Windows.Forms.Padding(0)
		Me.reset.Name = "reset"
		Me.reset.Size = New System.Drawing.Size(38, 33)
		Me.reset.TabIndex = 366
		Me.reset.Text = ""
		Me.reset.UseVisualStyleBackColor = True
		'
		'ControlBusqueda
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MinimumSize = New System.Drawing.Size(520, 33)
		Me.Name = "ControlBusqueda"
		Me.Size = New System.Drawing.Size(520, 33)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Private components As System.ComponentModel.IContainer
	Friend WithEvents DateValue As DateTimePicker
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents filtro As ComboBox
	Friend WithEvents keyword As TextBox
	Friend WithEvents search As Button
	Friend WithEvents reset As Button
	Friend WithEvents vista As ComboBox
End Class
