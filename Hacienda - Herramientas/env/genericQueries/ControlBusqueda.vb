Public Class ControlBusqueda
	Inherits System.Windows.Forms.UserControl

	'Custom Events
	Public bsCustomFilter As String
	Public Event CSearch_Click()
	'Public Event CStringSearch_Click(vista As ComboBox, filtro As ComboBox, keyword As ComboBox)
	'Public Event CDateSearch_Click(vista As ComboBox, filtro As ComboBox, DateValue As DateTimePicker, maxDateValue As DateTimePicker, Condition As ComboBox)
	'Public Event CNumSearch_Click(vista As ComboBox, filtro As ComboBox, NumValue As NumericUpDown, maxNumvalue As NumericUpDown, Condition As ComboBox)
	Public Event CReset_Click()
	Public Event CVista_IndexTextChanged()
	Public Event CFiltro_IndexTextChanged()
	Public Event CKeyword_KeyUp(sender As Object, e As KeyEventArgs)
	Public Event CSelect(sender As Object)
	Public Event CCancel(sender As Object)

	'Events
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		DateValue.MaxDate = Today
		DateValue.Value = Today
	End Sub

	Private Sub Vista_Events(sender As Object, e As EventArgs) Handles vista.SelectedIndexChanged, vista.TextChanged
		RaiseEvent CVista_IndexTextChanged() 'Load items
		vista.Visible = vista.Items.Count > 0
	End Sub

	'Visibility events
	Private Sub filtro_condition_SelectedIndexnTextChanged(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged, filtro.TextChanged,
																									Condition.SelectedIndexChanged, Condition.TextChanged

		bsCustomFilter = ""
		If filtro.Items.Count > 0 And filtro.SelectedIndex > -1 Then
			filtro.Visible = True
			keyword.Visible = (filtro.SelectedValue.ToString = "System.String")
			Condition.Visible = keyword.Visible.CompareTo(True)
			Condition.SelectedIndex = 0
			NumValue.Visible = (filtro.SelectedValue.ToString = "System.Decimal") Or (filtro.SelectedValue.ToString = "System.Int32")
			MaxNumValue.Visible = (NumValue.Visible) And (Condition.Text = "<->")
			DateValue.Visible = (filtro.SelectedValue.ToString = "System.DateTime")
			MaxDateValue.Visible = (DateValue.Visible) And (Condition.Text = "<->")



			If filtro.SelectedValue.ToString = "System.Decimal" Then
				NumValue.DecimalPlaces = 2
				MaxNumValue.DecimalPlaces = 2
			Else
				NumValue.DecimalPlaces = 0
				NumValue.DecimalPlaces = 0
			End If
		Else
			filtro.Visible = False
			keyword.Visible = True
			reset_search.PerformClick()
		End If

		RaiseEvent CFiltro_IndexTextChanged()
	End Sub

	Private Sub NumValue_MaxNumValue_VisibleChanged(sender As Object, e As EventArgs) Handles NumValue.VisibleChanged, MaxNumValue.VisibleChanged
		Condition.SelectedIndex = -1
		If NumValue.Visible = False Then
			NumValue.Minimum = 0
			NumValue.Value = 0
			NumValue.Maximum = 1
		End If
		If MaxNumValue.Visible = False Then
			MaxNumValue.Minimum = 0
			MaxNumValue.Value = 0
			MaxNumValue.Maximum = 1
		End If
	End Sub
	Private Sub DateValue_MaxDateValue_VisibleChanged(sender As Object, e As EventArgs) Handles DateValue.VisibleChanged, MaxDateValue.VisibleChanged
		Condition.SelectedIndex = -1
		If DateValue.Visible = False Then
			DateValue.MinDate = "1/1/1899"
			DateValue.MaxDate = "1/1/2038"
			DateValue.Value = Today
		End If
		If MaxDateValue.Visible = False Then
			MaxDateValue.MinDate = "1/1/1899"
			MaxDateValue.MaxDate = "1/1/2038"
			MaxDateValue.Value = Today
		End If
	End Sub
	Private Sub keyword_VisibleChanged(sender As Object, e As EventArgs) Handles keyword.VisibleChanged
		Condition.SelectedIndex = -1
		If keyword.Visible = False Then
			keyword.ResetText()
			keyword.Items.Clear()
		End If
	End Sub

	Private Sub keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword.KeyUp
		search.PerformClick()
	End Sub

	Private Sub keyword_ClicknFocus(sender As Object, e As EventArgs) Handles keyword.Click, keyword.GotFocus
		If keyword.Visible Then
			keyword.SelectAll()
		End If
	End Sub

	Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
		'O bien se manejan los filtros y tipos de datos directamente acá, o tengo que llamar eventos por separado para 
		'cada tipo de dato
		bsCustomFilter = ""
		If Len(filtro.Text) > 1 Then
			If keyword.Visible Then

				Trim(keyword.Text)
				If Len(keyword.Text) > 1 Then
					bsCustomFilter = filtro.Text & " LIKE '%" & keyword.Text & "%'"
				End If
			ElseIf NumValue.Visible Then

				If filtro.SelectedValue = "System.Decimal" Or filtro.SelectedValue = "System.Integer" Then 'Dec or Int
					If NumValue.Value <> Nothing Then

						Dim NumValueString As String
						NumValueString = Replace(NumValue.Value, ",", ".").ToString()
						If Condition.Text = "<->" And MaxNumValue.Value <> Nothing Then

							Dim maxValueString As String
							maxValueString = Replace(MaxNumValue.Value, ",", ".").ToString()
							bsCustomFilter = filtro.Text & "=>" & NumValueString & " AND " & filtro.Text & "<=" & maxValueString
						Else
							bsCustomFilter = filtro.Text & Condition.Text & NumValueString
						End If
					End If
				End If
			ElseIf DateValue.Visible Then

				If filtro.SelectedValue = "System.Date" Then 'Date
					'Filter by full date
					If last_connection = My.Settings.foxcon Then 'Foxpro needs the en-US date format
						If Condition.Text = "<->" Then
							bsCustomFilter = filtro.Text & " => {" & DateValue.ToString("MM/dd/yyyy") & "}" &
													 " AND " & filtro.Text & " <= {" & MaxDateValue.ToString("MM/dd/yyyy") & "}"
						Else
							bsCustomFilter = filtro.Text & Condition.Text & "{" & DateValue.ToString("MM/dd/yyyy") & "}"
						End If
					Else
						If Condition.Text = "<->" Then
							bsCustomFilter = filtro.Text & " => {" & DateValue.Value.ToShortDateString & "}" &
													 " AND " & filtro.Text & " <= {" & MaxDateValue.Value.ToShortDateString & "}"
						Else
							bsCustomFilter = filtro.Text & Condition.Text & "{" & DateValue.Value.ToShortDateString & "}"
						End If
					End If
				End If
			End If
			RaiseEvent CSearch_Click()
		End If

	End Sub

	Private Sub reset_search_Click(sender As Object, e As EventArgs) Handles reset_search.Click
		bsCustomFilter = ""

		DateValue.MinDate = "1/1/1899"
		DateValue.MaxDate = "1/1/2038"
		DateValue.Value = Today
		MaxDateValue.MinDate = "1/1/1899"
		MaxDateValue.MaxDate = "1/1/2038"
		MaxDateValue.Value = Today

		keyword.Items.Clear()
		keyword.ResetText()

		NumValue.Minimum = 0
		NumValue.Value = 0
		NumValue.Maximum = 1
		MaxNumValue.Minimum = 0
		MaxNumValue.Value = 0
		MaxNumValue.Maximum = 1

		RaiseEvent CReset_Click()
	End Sub

	Private Sub selectRow_Click(sender As Object, e As EventArgs) Handles selectRow.Click
		RaiseEvent CSelect(sender)
	End Sub

	Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
		RaiseEvent CCancel(sender)
	End Sub

	'Routines and functions
	Private Sub FullReset() 'Dangerous
		vista.Items.Clear()
		filtro.Items.Clear()
		keyword.Items.Clear()
		keyword.ResetText()
	End Sub

	Private Sub Condition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Condition.SelectedIndexChanged
		If Condition.Visible Then
			MaxDateValue.Visible = DateValue.Visible And Condition.Text.Contains("<->")
			MaxNumValue.Visible = NumValue.Visible And Condition.Text.Contains("<->")
		End If
	End Sub


End Class
