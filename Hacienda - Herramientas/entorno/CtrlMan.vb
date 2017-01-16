﻿Public Class CtrlMan
	'Reset // Dangerous! Handle with care!
	Shared Sub Reset(ByRef container As Object)
		For Each c As Control In container.Controls
			If TypeOf c Is TextBox Or TypeOf c Is MaskedTextBox Then
				c.ResetText()
				c.BackColor = SystemColors.Window
			ElseIf TypeOf c Is DateTimePicker Then
				CType(c, DateTimePicker).Value = Today
				c.BackColor = SystemColors.Window
			ElseIf TypeOf c Is ComboBox Then
				CType(c, ComboBox).SelectedIndex = -1
				c.BackColor = SystemColors.Window
			ElseIf TypeOf c Is NumericUpDown Then
				CType(c, NumericUpDown).Value = CType(c, NumericUpDown).Minimum
				c.BackColor = SystemColors.Window
			ElseIf TypeOf c Is CheckBox Then
				CType(c, CheckBox).Checked = False
			ElseIf TypeOf c Is FlowLayoutPanel Or TypeOf c Is Panel Then
				'Recursive reset within containers
				Reset(c)
			End If
		Next
	End Sub

	'General Validation
	Shared Function Validate(ByRef container As Object, Optional DefaultColor As Color = Nothing,
							 Optional ErrorColor As Color = Nothing) As Boolean
		'Default color values
		Dim valid As Boolean = True
		If DefaultColor = Nothing Then
			DefaultColor = SystemColors.Window
		End If
		If ErrorColor = Nothing Then
			ErrorColor = Color.MistyRose
		End If
		'Validation
		For Each c As Control In container.Controls
			If c.Enabled Then
				If TypeOf c Is FlowLayoutPanel Or TypeOf c Is Panel Then
					'Recursive Validation!
					'This way I don't have to select each container separately
					Dim answer As Boolean = Validate(c, DefaultColor, ErrorColor)
					If answer And valid Then
						'Unique case when valid stays true	
					Else
						valid = False
					End If
				ElseIf TypeOf c Is TextBox Then
					c.BackColor = DefaultColor
					CType(c, TextBox).Text = Trim(CType(c, TextBox).Text)
					'Generic texbox
					If Len(CType(c, TextBox).Text) < 1 Then
						c.BackColor = ErrorColor
						valid = False
					End If
					'Custom rules
					If c.Name = "apellido" And Len(c.Text) < 2 Then
						c.BackColor = ErrorColor
						valid = False
					ElseIf c.Name = "nombre" And Len(c.Text) < 3 Then
						c.BackColor = ErrorColor
						valid = False
					ElseIf c.Name = "email" And Len(c.Text) > 0 Then
						If c.Text.Contains("@") = False Or c.Text.Contains(".") = False Then
							c.BackColor = ErrorColor
							valid = False
						End If
					End If

				ElseIf TypeOf c Is ComboBox Then
					c.BackColor = DefaultColor
					CType(c, ComboBox).Text = Trim(CType(c, ComboBox).Text)
					If Len(CType(c, ComboBox).Text) < 4 Then
						c.BackColor = ErrorColor
						valid = False
					End If

				ElseIf TypeOf c Is NumericUpDown Then
					c.BackColor = DefaultColor
					If Trim(CType(c, NumericUpDown).Value.ToString) = "" Then
						c.BackColor = ErrorColor
						valid = False
					End If
				End If
			End If
		Next
		Return valid
	End Function

	'Export
	'LOAD ALL THE CONTROLS!!!!1ONE
	Shared Function LoadAllControls(drow As DataRow, ByVal target As Object) As Object
		'Carga los registros de cada columna en los controles con el nombre de la columna correspondiente
		For Each c As Control In target.Controls
			If drow.Table.Columns.Contains(c.Name) Then
				If TypeOf c Is Label Then
					c.Text = drow(c.Name).ToString
				ElseIf TypeOf c Is LinkLabel Then
					c.Text = drow(c.Name).ToString
				ElseIf TypeOf c Is TextBox Then
					c.Text = drow(c.Name).ToString
				ElseIf TypeOf c Is MaskedTextBox Then
					c.Text = drow(c.Name).ToString
				ElseIf TypeOf c Is ComboBox Then
					If CType(c, ComboBox).DataSource Is Nothing Then
						c.Text = drow(c.Name).ToString
					Else
						CType(c, ComboBox).DataSource.Position = CType(c, ComboBox).DataSource.Find("id", drow(c.Name & "_id")) 'localidad_id
					End If
				ElseIf TypeOf c Is NumericUpDown Then
					CType(c, NumericUpDown).Value = drow(c.Name)
				ElseIf TypeOf c Is DateTimePicker Then
					CType(c, DateTimePicker).Value = CDate(drow(c.Name))
				ElseIf TypeOf c Is CheckBox Then
					CType(c, CheckBox).Checked = drow(c.Name)
				ElseIf TypeOf c Is RadioButton Then
					CType(c, RadioButton).Checked = drow(c.Name)
				ElseIf TypeOf c Is Button Then
					CType(c, Button).Visible = drow(c.Name)
				End If
			ElseIf TypeOf c Is FlowLayoutPanel Or TypeOf c Is Panel Then
				'Recursive control loading
				LoadAllControls(drow, c)
			End If
		Next
		Return target
	End Function
	Shared Function LoadDataGridView(ByVal visor As DataGridView, ByVal bs As BindingSource, ByVal dtab As DataTable) As DataGridView
		'Esta rutina importa la datatable seleccionada en un datagridview; es igual para todos los servicios.
		bs.DataSource = dtab
		visor.DataSource = bs
		visor.Update()
		'Con VB .Net sobre la tabla de consulta
		'Dar formato
		visor = FormatColumns(visor)
		Return visor
	End Function
	Shared Sub SetFormStyle(ByRef container As Object, BColor As System.Drawing.Color)
		For Each c As Control In container.Controls
			If TypeOf c Is Button Then
				c.BackColor = BColor
			ElseIf TypeOf c Is MenuStrip Then
				c.BackColor = BColor
			ElseIf TypeOf c Is FlowLayoutPanel Or TypeOf c Is Panel Then
				SetFormStyle(c, BColor)
			End If
		Next
	End Sub

	'Formatting
	Shared Function FormatColumns(ByVal visor As DataGridView) As DataGridView
		With visor.Columns
			'PERSONAS
			If .Contains("id") Then
				visor.Columns("id").Width = 20
			End If
			If .Contains("apellido") Then
				visor.Columns("apellido").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
			End If
			If .Contains("nombre") Then
				visor.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
			End If
			If .Contains("direccion") Then
				visor.Columns("direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
			End If
			If .Contains("telefono") Then
				visor.Columns("telefono").Width = 110
			End If
			If .Contains("email") Then
				visor.Columns("email").Width = 110
			End If

			'VENTAS
			If .Contains("venta_id") Then
				visor.Columns("venta_id").Width = 30
			End If
			If .Contains("transaccion_id") Then
				visor.Columns("transaccion_id").Width = 30
			End If
			If .Contains("aereo") Then
				visor.Columns("aereo").Width = 55
			End If
			If .Contains("contacto") Then
				visor.Columns("contacto").Width = 55
			End If
			If .Contains("monto") Then
				visor.Columns("monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
			End If
			If .Contains("anulada") Then
				visor.Columns("anulada").Width = 50
			End If
		End With
		Return visor
	End Function

	'Autofilling
	Public Class Fill
		Overloads Shared Sub AutoComplete(ByRef bs As BindingSource, ByRef target As ComboBox,
										  DisplayOption As String, ValueOption As String)
			target.DataSource = Nothing
			target.DataSource = bs
			target.DisplayMember = DisplayOption
			target.ValueMember = ValueOption
			target.AutoCompleteMode = AutoCompleteMode.Suggest
			target.AutoCompleteSource = AutoCompleteSource.ListItems
		End Sub
		Shared Sub States(ByRef StateList As ComboBox, ByRef bs As BindingSource)
			StateList.BeginUpdate()
			bs.DataSource = DbMan.read("SELECT * FROM provincia")
			StateList.DataSource = bs
			StateList.DisplayMember = "nombre"
			StateList.ValueMember = "id"
			StateList.EndUpdate()
		End Sub
		Shared Sub Cities(ByRef CityList As ComboBox, ByRef bs As BindingSource, State As Integer)
			CityList.BeginUpdate()
			bs.DataSource = DbMan.read("SELECT * FROM Localidad WHERE provincia_id=" & State)
			CityList.DataSource = bs
			CityList.DisplayMember = "nombre"
			CityList.ValueMember = "id"
			CityList.EndUpdate()
		End Sub
	End Class
End Class
