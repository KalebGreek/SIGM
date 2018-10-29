Public Class CtrlMan 'Control Manager

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
	Shared Sub CustomMaskedTextboxValidation(ByRef mtb As MaskedTextBox)
		If mtb.Name = "cuil" Then
			If Len(mtb.Text) <> 11 Then
				mtb.Tag = "CUIL invalido."
			Else
				Dim dtab As New DataTable
				dtab = DbMan.read("SELECT * FROM persona
									WHERE cuil=" & mtb.Text)
				If dtab.Rows.Count > 0 Then
					mtb.Tag = "CUIL duplicado. Este CUIL pertenece a " & dtab(0)("razon") & "."
				End If
			End If
		ElseIf mtb.Name = "dni" Then
			If Len(Val(mtb.Text)) > 8 Or Len(Val(mtb.Text)) < 5 Then
				mtb.Tag = "Ingrese DNI."
			End If
		End If
	End Sub
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

	'Esta rutina importa datatable o bindingsource seleccionada en un datagridview y formatea las columnas correspondientes
	Overloads Shared Function LoadDataGridView(ByVal visor As DataGridView,
											   ByVal bs As BindingSource, Optional bsFilter As String = "",
											   Optional ByVal dtab As DataTable = Nothing) As DataGridView
		visor.SuspendLayout()
		If dtab Is Nothing = False Then
			bs.DataSource = dtab
		End If
		If bsFilter <> "" Then
			bs.Filter = bsFilter
		End If
		visor.DataSource = bs
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

					'HACIENDA
				ElseIf .Equals("orden") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
				ElseIf .Equals("nombre") Then
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

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
					c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

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

	'Populate controls with data
	Public Class Fill
		Overloads Shared Function SetAutoComplete(ByRef target As ComboBox, ByRef bs As BindingSource,
												  Optional DisplayOption As String = "", Optional ValueOption As String = "") As ComboBox

			If target Is Nothing Then
				target = New ComboBox
			End If

			target.BeginUpdate()
			target.AutoCompleteMode = AutoCompleteMode.None
			target.DataSource = Nothing
			target.DataSource = bs
			If DisplayOption <> "" Then
				target.DisplayMember = DisplayOption
			End If
			If ValueOption <> "" Then
				target.ValueMember = ValueOption
			End If
			target.EndUpdate()

			Return target
		End Function
		Overloads Shared Function SetAutocomplete(target As NumericUpDown, bs As BindingSource, FilterColumn As ComboBox) As NumericUpDown


			If target Is Nothing Then
				target = New NumericUpDown
			End If

			'Reset target
			target.Minimum = 0
			target.Value = 0
			target.Maximum = 0

			If FilterColumn.SelectedIndex > -1 Then
				'Return and sort range of values to use for the specified column
				If FilterColumn.SelectedValue = "System.Decimal" Or FilterColumn.SelectedValue = "System.Integer" Then
					Dim minValue, maxValue As Long
					bs.Sort = FilterColumn.Text & " ASC"
					bs.MoveFirst()
					minValue = bs.Current(FilterColumn.Text)
					bs.MoveLast()
					maxValue = bs.Current(FilterColumn.Text)

					target.Minimum = minValue
					target.Maximum = minValue
					target.Value = minValue
				End If
			End If
			target.Update()

			Return target
		End Function
		Overloads Shared Function SetAutocomplete(target As DateTimePicker, bs As BindingSource, FilterColumn As ComboBox) As DateTimePicker

			If target Is Nothing Then
				target = New DateTimePicker
			End If

			'Reset target
			target.MinDate = CDate("1/1/1899")
			target.Value = target.MinDate
			target.MaxDate = Today

			If FilterColumn.SelectedIndex > -1 Then
				'Return and sort range of values to use for the specified column
				If FilterColumn.SelectedValue = "System.Date" Then
					bs.Sort = FilterColumn.Text & " ASC"

					bs.MoveFirst()
					If bs.Current(FilterColumn.Text) Is DBNull.Value = False Then
						target.MinDate = bs.Current(FilterColumn.Text)
					End If

					bs.MoveLast()
					If bs.Current(FilterColumn.Text) Is DBNull.Value = False Then
						target.MaxDate = bs.Current(FilterColumn.Text)
					End If

					If target.MaxDate >= Today Then
						target.Value = Today
					End If
				End If
			End If
			target.Update()

			Return target
		End Function

		Shared Sub GetCities(ByRef CityList As ComboBox, ByRef bs As BindingSource, State As Integer)
			CityList.BeginUpdate()
			bs.DataSource = DbMan.read("SELECT * FROM localidades 
										WHERE provincia_id=" & State & "
										ORDER BY nombre")
			CityList.DataSource = bs
			CityList.DisplayMember = "nombre"
			CityList.ValueMember = "id"
			CityList.EndUpdate()
		End Sub
		''' <summary>
		''' Returns the column list of a datatable in DataTable format. Fields: ColumnName(string), DataType(string)
		''' </summary>
		''' <param name="source">Source DataTable used to read the column names.</param>
		Shared Function GetColumnList(source As DataTable) As DataTable
			Dim ColumnList_dtab As New DataTable
			If source.Columns.Count > 0 Then
				'Add only useful columns to the list, to avoid garbage
				'Useful column types include date, integer, decimal and string
				'Other types could be added as soon as I figure how to use them :p

				ColumnList_dtab.Columns.Add("ColumnName", GetType(String))
				ColumnList_dtab.Columns.Add("DataType", GetType(String))

				For Each dc As DataColumn In source.Columns
					If dc.DataType = GetType(Date) Or dc.DataType = GetType(Decimal) _
					Or dc.DataType = GetType(Integer) Or dc.DataType = GetType(String) Then
						Dim dr As DataRow = ColumnList_dtab.NewRow
						dr("ColumnName") = dc.ColumnName.ToString
						dr("DataType") = dc.DataType.ToString
						ColumnList_dtab.Rows.Add(dr)
					End If
				Next
			End If
			Return ColumnList_dtab
		End Function
		Shared Sub GetStates(ByRef StateList As ComboBox, ByRef bs As BindingSource)
			StateList.BeginUpdate()
			bs.DataSource = DbMan.read("SELECT * FROM provincias ORDER BY nombre")
			StateList.DataSource = bs
			StateList.DisplayMember = "nombre"
			StateList.ValueMember = "id"
			StateList.EndUpdate()
		End Sub

	End Class

	'Search or filter using bindingsource
	Public Class Filter
		'Overloads Shared Function BindingSource(ByVal sender As Object, ByVal bs As BindingSource, ByVal FilterColumn As ComboBox,
		'							 Optional keyword As String = Nothing) As String

		'	Dim bsCustomFilter As String = ""
		'	keyword = Trim(keyword)
		'	If Len(keyword) > 0 Then
		'		bsCustomFilter = FilterColumn.Text & " LIKE '%" & keyword & "%'"
		'	End If
		'	Return bsCustomFilter
		'End Function

		'Overloads Shared Function BindingSource(ByVal sender As Object, ByVal bs As BindingSource, ByVal FilterColumn As ComboBox,
		'										 Optional NumValue As Decimal = Nothing, Optional maxNumvalue As Decimal = Nothing,
		'										 Optional condition As String = "=") As String

		'	Dim bsCustomFilter As String = ""

		'	'Filter query
		'	'Change this from SQL to BindingSource.Filter
		'	If FilterColumn.SelectedValue = "System.Decimal" Or FilterColumn.SelectedValue = "System.Integer" Then 'Dec or Int
		'		If NumValue <> Nothing Then
		'			Dim NumValueString As String
		'			NumValueString = Replace(NumValue, ",", ".").ToString()

		'			If condition = "<->" And maxNumvalue <> Nothing Then
		'				Dim maxValueString As String
		'				maxValueString = Replace(maxNumvalue, ",", ".").ToString()
		'				bsCustomFilter = FilterColumn.Text & "=>" & NumValueString & " AND " & FilterColumn.Text & "<=" & maxValueString
		'			Else
		'				bsCustomFilter = FilterColumn.Text & condition & NumValueString
		'			End If
		'		End If
		'	End If
		'	Return bsCustomFilter
		'End Function

		'Overloads Shared Function BindingSource(ByVal sender As Object, ByVal bs As BindingSource, ByVal FilterColumn As ComboBox,
		'										 Optional DateValue As Date = Nothing, Optional maxDatevalue As Date = Nothing,
		'										 Optional condition As String = "=") As String

		'	Dim bsCustomFilter As String = ""
		'	'Filter query
		'	'Change this from SQL to BindingSource.Filter
		'	If FilterColumn.SelectedValue = "System.Date" Then 'Date
		'		'Filter by full date
		'		If last_connection = My.Settings.foxcon Then
		'			If condition = "<->" Then
		'				bsCustomFilter = FilterColumn.Text & " => {" & DateValue.ToString("MM/dd/yyyy") & "}" &
		'									 " AND " & FilterColumn.Text & " <= {" & maxDatevalue.ToString("MM/dd/yyyy") & "}"
		'			Else
		'				bsCustomFilter = FilterColumn.Text & condition & "{" & DateValue.ToString("MM/dd/yyyy") & "}"
		'			End If
		'		Else
		'			If condition = "<->" Then
		'				bsCustomFilter = FilterColumn.Text & " => {" & DateValue.ToShortDateString & "}" &
		'									 " AND " & FilterColumn.Text & " <= {" & maxDatevalue.ToShortDateString & "}"
		'			Else
		'				bsCustomFilter = FilterColumn.Text & condition & "{" & DateValue.ToShortDateString & "}"
		'			End If
		'		End If
		'	End If

		'	Return bsCustomFilter
		'End Function
	End Class
End Class
