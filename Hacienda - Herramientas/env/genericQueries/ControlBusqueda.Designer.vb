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
		Me.components = New System.ComponentModel.Container()
		Me.DateValue = New System.Windows.Forms.DateTimePicker()
		Me.vista = New System.Windows.Forms.ComboBox()
		Me.wrapper = New System.Windows.Forms.FlowLayoutPanel()
		Me.filtro = New System.Windows.Forms.ComboBox()
		Me.keyword = New System.Windows.Forms.ComboBox()
		Me.NumValue = New System.Windows.Forms.NumericUpDown()
		Me.Condition = New System.Windows.Forms.ComboBox()
		Me.MaxDateValue = New System.Windows.Forms.DateTimePicker()
		Me.MaxNumValue = New System.Windows.Forms.NumericUpDown()
		Me.search = New System.Windows.Forms.Button()
		Me.reset_search = New System.Windows.Forms.Button()
		Me.selectRow = New System.Windows.Forms.Button()
		Me.cancel = New System.Windows.Forms.Button()
		Me.info1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.wrapper.SuspendLayout()
		CType(Me.NumValue, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MaxNumValue, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DateValue
		'
		Me.DateValue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateValue.Location = New System.Drawing.Point(441, 3)
		Me.DateValue.Name = "DateValue"
		Me.DateValue.Size = New System.Drawing.Size(112, 27)
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
		'wrapper
		'
		Me.wrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.wrapper.Controls.Add(Me.vista)
		Me.wrapper.Controls.Add(Me.filtro)
		Me.wrapper.Controls.Add(Me.keyword)
		Me.wrapper.Controls.Add(Me.DateValue)
		Me.wrapper.Controls.Add(Me.NumValue)
		Me.wrapper.Controls.Add(Me.Condition)
		Me.wrapper.Controls.Add(Me.MaxDateValue)
		Me.wrapper.Controls.Add(Me.MaxNumValue)
		Me.wrapper.Controls.Add(Me.search)
		Me.wrapper.Controls.Add(Me.reset_search)
		Me.wrapper.Controls.Add(Me.selectRow)
		Me.wrapper.Controls.Add(Me.cancel)
		Me.wrapper.Location = New System.Drawing.Point(0, 0)
		Me.wrapper.Name = "wrapper"
		Me.wrapper.Size = New System.Drawing.Size(864, 33)
		Me.wrapper.TabIndex = 363
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
		Me.keyword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
		Me.keyword.Location = New System.Drawing.Point(295, 3)
		Me.keyword.MaxLength = 32
		Me.keyword.Name = "keyword"
		Me.keyword.Size = New System.Drawing.Size(140, 27)
		Me.keyword.TabIndex = 369
		'
		'NumValue
		'
		Me.NumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.NumValue.Location = New System.Drawing.Point(559, 3)
		Me.NumValue.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.NumValue.Name = "NumValue"
		Me.NumValue.Size = New System.Drawing.Size(77, 27)
		Me.NumValue.TabIndex = 371
		Me.NumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.NumValue.Visible = False
		'
		'Condition
		'
		Me.Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.Condition.FormattingEnabled = True
		Me.Condition.Items.AddRange(New Object() {" =", " >", " <", "<->"})
		Me.Condition.Location = New System.Drawing.Point(642, 3)
		Me.Condition.MaxDropDownItems = 4
		Me.Condition.MaxLength = 3
		Me.Condition.Name = "Condition"
		Me.Condition.Size = New System.Drawing.Size(45, 27)
		Me.Condition.TabIndex = 370
		Me.Condition.Visible = False
		'
		'MaxDateValue
		'
		Me.MaxDateValue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.MaxDateValue.Location = New System.Drawing.Point(693, 3)
		Me.MaxDateValue.Name = "MaxDateValue"
		Me.MaxDateValue.Size = New System.Drawing.Size(112, 27)
		Me.MaxDateValue.TabIndex = 372
		Me.MaxDateValue.Visible = False
		'
		'MaxNumValue
		'
		Me.MaxNumValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.MaxNumValue.Location = New System.Drawing.Point(3, 36)
		Me.MaxNumValue.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.MaxNumValue.Name = "MaxNumValue"
		Me.MaxNumValue.Size = New System.Drawing.Size(77, 27)
		Me.MaxNumValue.TabIndex = 373
		Me.MaxNumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.MaxNumValue.Visible = False
		'
		'search
		'
		Me.search.FlatAppearance.BorderSize = 0
		Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.search.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.search.ForeColor = System.Drawing.Color.White
		Me.search.Location = New System.Drawing.Point(83, 33)
		Me.search.Margin = New System.Windows.Forms.Padding(0)
		Me.search.Name = "search"
		Me.search.Size = New System.Drawing.Size(38, 33)
		Me.search.TabIndex = 365
		Me.search.Text = ""
		Me.info1.SetToolTip(Me.search, "Buscar")
		Me.search.UseVisualStyleBackColor = True
		'
		'reset_search
		'
		Me.reset_search.FlatAppearance.BorderSize = 0
		Me.reset_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.reset_search.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.reset_search.ForeColor = System.Drawing.Color.White
		Me.reset_search.Location = New System.Drawing.Point(121, 33)
		Me.reset_search.Margin = New System.Windows.Forms.Padding(0)
		Me.reset_search.Name = "reset_search"
		Me.reset_search.Size = New System.Drawing.Size(38, 33)
		Me.reset_search.TabIndex = 366
		Me.reset_search.Text = ""
		Me.info1.SetToolTip(Me.reset_search, "Reiniciar")
		Me.reset_search.UseVisualStyleBackColor = True
		'
		'selectRow
		'
		Me.selectRow.FlatAppearance.BorderSize = 0
		Me.selectRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.selectRow.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
		Me.selectRow.ForeColor = System.Drawing.Color.Chartreuse
		Me.selectRow.Location = New System.Drawing.Point(159, 33)
		Me.selectRow.Margin = New System.Windows.Forms.Padding(0)
		Me.selectRow.Name = "selectRow"
		Me.selectRow.Size = New System.Drawing.Size(38, 33)
		Me.selectRow.TabIndex = 367
		Me.selectRow.Text = ""
		Me.info1.SetToolTip(Me.selectRow, "Seleccionar")
		Me.selectRow.UseVisualStyleBackColor = True
		Me.selectRow.Visible = False
		'
		'cancel
		'
		Me.cancel.FlatAppearance.BorderSize = 0
		Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cancel.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
		Me.cancel.ForeColor = System.Drawing.Color.Red
		Me.cancel.Location = New System.Drawing.Point(197, 33)
		Me.cancel.Margin = New System.Windows.Forms.Padding(0)
		Me.cancel.Name = "cancel"
		Me.cancel.Size = New System.Drawing.Size(38, 33)
		Me.cancel.TabIndex = 368
		Me.cancel.Text = ""
		Me.info1.SetToolTip(Me.cancel, "Cancelar")
		Me.cancel.UseVisualStyleBackColor = True
		Me.cancel.Visible = False
		'
		'ControlBusqueda
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.AutoSize = True
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.Controls.Add(Me.wrapper)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MinimumSize = New System.Drawing.Size(520, 33)
		Me.Name = "ControlBusqueda"
		Me.Size = New System.Drawing.Size(867, 36)
		Me.wrapper.ResumeLayout(False)
		CType(Me.NumValue, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MaxNumValue, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Private components As System.ComponentModel.IContainer
	Friend WithEvents DateValue As DateTimePicker
	Friend WithEvents wrapper As FlowLayoutPanel
	Friend WithEvents filtro As ComboBox
	Friend WithEvents search As Button
	Friend WithEvents reset_search As Button
	Friend WithEvents vista As ComboBox
	Friend WithEvents selectRow As Button
	Friend WithEvents cancel As Button
	Friend WithEvents info1 As ToolTip
	Friend WithEvents keyword As ComboBox
	Friend WithEvents Condition As ComboBox
	Friend WithEvents NumValue As NumericUpDown
	Friend WithEvents MaxDateValue As DateTimePicker
	Friend WithEvents MaxNumValue As NumericUpDown
End Class
