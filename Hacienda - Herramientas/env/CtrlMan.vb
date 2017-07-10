Public Class CtrlMan

	'###### VENTANAS
	'Impedir creación de ventanas que deben abrirse una sola vez en el formulario MDI
	Shared Function UniqueWindow(instance As Form) As Boolean
		If TypeOf instance Is MainForm Then
			For Each f As Form In instance.MdiChildren
				If TypeOf f Is ModInmueble Then
					Return True
				End If
				If TypeOf f Is ConsultaCuentaAgrupada Then
					Return True
				End If
				If TypeOf f Is ModExpediente Then
					Return True
				End If
				If TypeOf f Is ModOrdenanza Then
					Return True
				End If
			Next
		End If
		Return False
	End Function

	Shared Function CalcExpirationDate(vencimiento As Date, Optional cuotas As Integer = 1)
		For c As Integer = 0 To cuotas
			vencimiento = vencimiento.AddDays(Date.DaysInMonth(vencimiento.Year, vencimiento.Month))
		Next
		Do While vencimiento.DayOfWeek = DayOfWeek.Saturday Or vencimiento.DayOfWeek = DayOfWeek.Sunday
			If vencimiento.DayOfWeek = DayOfWeek.Saturday Then
				vencimiento = vencimiento.AddDays(-1)
			Else
				vencimiento = vencimiento.AddDays(1)
			End If
		Loop
		Return FormatDateTime(vencimiento, DateFormat.ShortDate)
	End Function

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
	Shared Function Validate(ByRef container As Object, Optional ByRef ErrorTooltip As ToolTip = Nothing,
							 Optional DefaultColor As Color = Nothing, Optional ErrorColor As Color = Nothing) As Boolean
		'Flag
		Dim valid As Boolean = True

		'Default color values
		If DefaultColor = Nothing Then
			DefaultColor = SystemColors.Window
		End If
		If ErrorColor = Nothing Then
			ErrorColor = Color.MistyRose
		End If

		'Validation
		For Each c As Control In container.Controls
			c.Tag = "" 'Error msg
			If TypeOf c Is FlowLayoutPanel Or
				   TypeOf c Is Panel Or
				   TypeOf c Is TabControl Or
				   TypeOf c Is TabPage Then
				'Recursive Validation!
				'This way I don't have to select each container separately
				Dim answer As Boolean = Validate(c, ErrorTooltip, DefaultColor, ErrorColor)
				If answer And valid Then
					'Unique case when valid stays true	
				Else
					valid = False
				End If
			ElseIf TypeOf c Is TextBox Then
				CType(c, TextBox).Text = Trim(CType(c, TextBox).Text)
				'Custom rules
				CustomTextboxValidation(c)

			ElseIf TypeOf c Is MaskedTextBox Then
				CType(c, MaskedTextBox).Text = Trim(CType(c, MaskedTextBox).Text)
				'Custom rules
				CustomMaskedTextboxValidation(c)

			ElseIf TypeOf c Is ComboBox Then
				CType(c, ComboBox).Text = Trim(CType(c, ComboBox).Text)

				If CType(c, ComboBox).DataSource Is Nothing = False Then
					If CType(c, ComboBox).SelectedIndex < 0 Then
						c.Tag = "Debe seleccionar un valor de la lista."
					End If
				ElseIf Len(CType(c, ComboBox).Text) < 1 Then
					c.Tag = "Debe completar este campo."
				End If

			ElseIf TypeOf c Is NumericUpDown Then
				c.BackColor = DefaultColor
				If Trim(CType(c, NumericUpDown).Value.ToString) = "" Then
					c.Tag = "Valor fuera de rango."
				End If
			End If

			'Load error message
			If Len(c.Tag) > 0 Then
				valid = False
				c.BackColor = ErrorColor
				If ErrorTooltip Is Nothing = False Then
					ErrorTooltip.SetToolTip(c, c.Tag)
				End If
			ElseIf Len(c.Tag) = 0 Then
				If c.BackColor = ErrorColor Then
					c.BackColor = DefaultColor
				End If
			End If
		Next

		Return valid
	End Function
	Shared Sub CustomTextboxValidation(ByRef c As TextBox)
		If c.Name = "razon" Then
			If Len(c.Text) < 1 Then
				c.Tag = "Debe seleccionar una persona."
			End If
		ElseIf c.Name = "apellido" Then
			If Len(c.Text) < 1 Then
				c.Tag = "Ingrese apellido."
			ElseIf Len(c.Text) < 3 Then
				c.Tag = "Apellido demasiado corto."
			ElseIf Val(c.Text) > 0 Then
				c.Tag = "No puede ingresar numeros en el apellido."
			End If
		ElseIf c.Name = "nombre" Then
			If Len(c.Text) < 1 Then
				c.Tag = "Ingrese nombre."
			ElseIf Len(c.Text) < 3 Then
				c.Tag = "Nombre demasiado corto."
			ElseIf Val(c.Text) > 0 Then
				c.Tag = "No puede ingresar numeros en el nombre."
			End If
		ElseIf c.Name = "email" Then
			If Len(c.Text) < 1 Then
				c.Text = "email@email.com"
			ElseIf Len(c.Text) < 7 Then 'a@a.ar
				c.Tag = "E-mail demasiado corto."
			ElseIf c.Text.Contains("@") = False Or c.Text.Contains(".") = False Then
				c.Tag = "E-mail no valido."
			End If
		End If
	End Sub
	Shared Sub CustomMaskedTextboxValidation(ByRef c As MaskedTextBox)
		If c.Name = "cuil" Then
			If Len(c.Text) <> 11 Then
				c.Tag = "CUIL invalido."
			Else
				Dim dtab As New DataTable
				dtab = DbMan.read("SELECT * FROM persona
									       WHERE cuil=" & c.Text)
				If dtab.Rows.Count > 0 Then
					c.Tag = "CUIL duplicado. Este CUIL pertenece a " & dtab(0)("razon") & "."
				End If
			End If
		ElseIf c.Name = "dni" Then
			If Len(Val(c.Text)) > 8 Or Len(Val(c.Text)) < 5 Then
				c.Tag = "Ingrese DNI."
			End If
		End If
	End Sub

	'Loading controls
	'LOAD ALL THE CONTROLS!!!!1ONE
	Shared Function LoadAllControls(drow As DataRow, ByVal target As Object) As Object
		'Carga los registros de cada columna en los controles con el nombre de la columna correspondiente
		For Each c As Control In target.Controls
			If drow.Table.Columns.Contains(c.Name) Then
				If drow(c.Name) Is DBNull.Value = False Then
					If TypeOf c Is Button Then
						CType(c, Button).Visible = drow(c.Name)
					ElseIf TypeOf c Is CheckBox Then
						CType(c, CheckBox).Checked = drow(c.Name)
					ElseIf TypeOf c Is ComboBox Then
						If CType(c, ComboBox).DataSource Is Nothing Then
							c.Text = drow(c.Name).ToString
						Else
							CType(c, ComboBox).DataSource.Position = CType(c, ComboBox).DataSource.Find("id", drow(c.Name & "_id")) 'localidad_id
						End If
					ElseIf TypeOf c Is DateTimePicker Then
						CType(c, DateTimePicker).Value = CDate(drow(c.Name))
					ElseIf TypeOf c Is Label Then
						c.Text = drow(c.Name).ToString
					ElseIf TypeOf c Is LinkLabel Then
						c.Text = drow(c.Name).ToString
					ElseIf TypeOf c Is TextBox Then
						c.Text = drow(c.Name).ToString
					ElseIf TypeOf c Is MaskedTextBox Then
						c.Text = drow(c.Name).ToString
					ElseIf TypeOf c Is NumericUpDown Then
						CType(c, NumericUpDown).Value = drow(c.Name)
					ElseIf TypeOf c Is RadioButton Then
						CType(c, RadioButton).Checked = drow(c.Name)
					Else
					End If
				End If
			ElseIf TypeOf c Is FlowLayoutPanel Or
				   TypeOf c Is Panel Or
				   TypeOf c Is TabControl Or
				   TypeOf c Is TabPage Then
				'Recursive control loading
				LoadAllControls(drow, c)
			End If
		Next
		Return target
	End Function
	Shared Function LoadDataGridView(ByVal visor As DataGridView, ByVal bs As BindingSource, ByVal dtab As DataTable) As DataGridView
		'Esta rutina importa la datatable seleccionada en un datagridview; es igual para todos los servicios.
		visor.SuspendLayout()
		bs.DataSource = dtab
		visor.DataSource = bs
		'Con VB .Net sobre la tabla de consulta
		'Dar formato
		visor = FormatColumns(visor)
		visor.ResumeLayout()
		Return visor
	End Function

	Shared Sub SetFormColor(ByRef instance As Object, Color As System.Drawing.Color)
		If Color <> Nothing Then
			For Each c As Control In instance.Controls
				If TypeOf c Is Button Then
					c.BackColor = Color
				ElseIf TypeOf c Is MenuStrip Then
					c.BackColor = Color
				ElseIf TypeOf c Is FlowLayoutPanel Or TypeOf c Is Panel Then
					SetFormColor(c, Color)
				End If
			Next
		End If
	End Sub

	'Formatting
	Shared Function FormatColumns(ByVal visor As DataGridView) As DataGridView
		For Each c As DataGridViewColumn In visor.Columns
			With c.HeaderText
				'GENERAL
				If .Contains("_id") Then
					c.Width = 5

					'PERSONAS
				ElseIf .Equals("cuil") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

				ElseIf .Equals("razon") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

				ElseIf .Equals("direccion") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

				ElseIf .Equals("calle") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

				ElseIf .Equals("altura") Then
					c.Width = 40

				ElseIf .Equals("piso") Then
					c.Width = 25

				ElseIf .Equals("dpto") Then
					c.Width = 25

				ElseIf .Equals("localidad") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

				ElseIf .Equals("email") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

				ElseIf .Equals("telefono") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

				ElseIf .Equals("difunto") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

				ElseIf .Equals("fisica") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

					'ACTAS
				ElseIf .Equals("acta") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

				ElseIf .Equals("libro") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

				ElseIf .Equals("nota") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

					'COMBUSTIBLES
				ElseIf .Equals("litros") Then
					c.Width = 70

				ElseIf .Equals("unidades") Then
					c.Width = 70

				ElseIf .Equals("monto") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

					'DOCS
				ElseIf .Equals("descripcion") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

				ElseIf .Equals("fecha") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

				ElseIf .Equals("ruta") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

					'FRENTES
				ElseIf .Equals("altura") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

				ElseIf .Equals("metros") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

					'INMUEBLES
				ElseIf .Equals("zona") Then
					c.Width = 40

				ElseIf .Contains("circ") Then
					c.Width = 40

				ElseIf .Contains("secc") Then
					c.Width = 40

				ElseIf .Contains("manz") Then
					c.Width = 40

				ElseIf .Contains("parc") Then
					c.Width = 40

				ElseIf .Equals("lote") Then
					c.Width = 40

				ElseIf .Equals("archivado") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

					'OPRIVADAS
				ElseIf .Equals("responsable") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

					'ORDENANZAS
				ElseIf .Equals("concepto") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

				ElseIf .Equals("ruta_copia") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

					'MOVIMIS
				ElseIf .Equals("detalle") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

					'PACIENTE
				ElseIf .Equals("a") Or .Equals("b") Or .Equals("ab") Or .Equals("o") Then
					c.Width = 25
				End If
			End With
		Next

		Return visor
	End Function

	'Autofilling
	Public Class Fill
		Shared Sub AutoComplete(ByRef bs As BindingSource, ByRef target As ComboBox,
										  DisplayOption As String, ValueOption As String)

			target.DataSource = Nothing
			If target.Enabled Then
				target.DataSource = bs
				target.DisplayMember = DisplayOption
				target.ValueMember = ValueOption
				target.AutoCompleteMode = AutoCompleteMode.None
			End If
		End Sub
		Shared Sub States(ByRef StateList As ComboBox, ByRef bs As BindingSource)
			StateList.BeginUpdate()
			bs.DataSource = DbMan.read("SELECT * FROM provincias ORDER BY nombre")
			StateList.DataSource = bs
			StateList.DisplayMember = "nombre"
			StateList.ValueMember = "id"
			StateList.EndUpdate()
		End Sub
		Shared Sub Cities(ByRef CityList As ComboBox, ByRef bs As BindingSource, State As Integer)
			CityList.BeginUpdate()
			bs.DataSource = DbMan.read("SELECT * FROM localidades 
												WHERE provincia_id=" & State & "
											 ORDER BY nombre")
			CityList.DataSource = bs
			CityList.DisplayMember = "nombre"
			CityList.ValueMember = "id"
			CityList.EndUpdate()
		End Sub
	End Class
End Class
