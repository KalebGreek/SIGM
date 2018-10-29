Imports System.ComponentModel

Public Class BusquedaExpediente
	Private Sub ConsultaPersona_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then
			'Setting up views
			ControlBusqueda1.vista.Items.AddRange(New Object() {"EXPEDIENTE", "RESPONSABLE", "PROFESIONAL"})
			'Selecting view
			If ControlBusqueda1.vista.SelectedIndex = -1 Then
				ControlBusqueda1.vista.SelectedIndex = 0 'Persona
            End If
		End If
	End Sub

	'-- RUTINAS

	'hay que cambiar la definición del evento search por default para que tome byref combobox y pueda ser usado
	'para rellenarlo con la lista de columnas
	'gran parte de esta consulta no sirve porque va a estar incluida en csearch
	'gran parte de expedientes.buscar no va

	'Public Overloads Sub Consultar(vista As ComboBox, filtro As ComboBox, keyword As ComboBox) Handles ControlBusqueda1.CStringSearch_Click
	'	If vista.Text = "EXPEDIENTE" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente()

	'		If keyword.Text.Contains("BUSCAR") = False Then
	'			bs_resultado.Filter = filtro.Text & " Like '%" & keyword.Text & "%'"
	'		End If

	'	ElseIf vista.Text = "RESPONSABLE" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(keyword.Text)


	'	ElseIf vista.Text = "PROFESIONAL" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(keyword.Text)

	'	Else
	'		ControlBusqueda1.reset_search.PerformClick()
	'	End If

	'	CtrlMan.LoadDataGridView(resultado, bs_resultado)
	'End Sub
	'Public Overloads Sub Consultar(vista As ComboBox, filtro As ComboBox, DateValue As DateTimePicker, MaxDateValue As DateTimePicker, Condition As ComboBox) Handles ControlBusqueda1.CDateSearch_Click
	'	If vista.Text = "EXPEDIENTE" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente()

	'	ElseIf vista.Text = "RESPONSABLE" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable()

	'	ElseIf vista.Text = "PROFESIONAL" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional()

	'	Else
	'		ControlBusqueda1.reset_search.PerformClick()
	'	End If

	'	If bs_resultado.Count > 0 Then
	'		bs_resultado.Filter = ControlBusqueda1.bsCustomFilter
	'	End If

	'	CtrlMan.LoadDataGridView(resultado, bs_resultado)
	'End Sub
	'Public Overloads Sub Consultar(vista As ComboBox, filtro As ComboBox, NumValue As NumericUpDown, MaxNumValue As NumericUpDown, Condition As ComboBox) Handles ControlBusqueda1.CNumSearch_Click
	'	If vista.Text = "EXPEDIENTE" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente()

	'	ElseIf vista.Text = "RESPONSABLE" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable()

	'	ElseIf vista.Text = "PROFESIONAL" Then
	'		bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional()

	'	Else
	'		ControlBusqueda1.reset_search.PerformClick()
	'	End If
	'	If bs_resultado.Count > 0 Then
	'		bs_resultado.Filter = CtrlMan.Filter.BindingSource(ControlBusqueda1, bs_resultado, filtro, NumValue.Value, MaxNumValue.Value, Condition.Text)
	'	End If

	'	CtrlMan.LoadDataGridView(resultado, bs_resultado)
	'End Sub


	'OLD VERSION
	'Public Sub Consultar(vista As String, filtro As String, keyword As String) Handles ControlBusqueda1.CSearch_Click
	'	Dim excluir As Boolean = False
	'	keyword = Trim(keyword)
	'	If Len(keyword) > 1 Then
	'		If keyword.First = "-" Then
	'			excluir = True
	'			keyword = Microsoft.VisualBasic.Right(keyword, Len(keyword) - 1)
	'		End If
	'	End If
	'	If vista = "EXPEDIENTE" Then

	'		If filtro = "NRO." Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente(excluir, Val(keyword))
	'		ElseIf filtro = "UBICACION" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente(excluir, , keyword)
	'		ElseIf filtro = "FECHA" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente(excluir, , , keyword)
	'		End If

	'	ElseIf vista = "RESPONSABLE" Then
	'		If filtro = "RAZON SOCIAL" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(excluir, keyword)
	'		ElseIf filtro = "CUIL" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(excluir, , Val(keyword))
	'		ElseIf filtro = "DIRECCION" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(excluir, , , keyword)
	'		ElseIf filtro = "LOCALIDAD" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(excluir, , , , keyword)
	'		End If

	'	ElseIf vista = "PROFESIONAL" Then
	'		If filtro = "RAZON SOCIAL" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, keyword)
	'		ElseIf filtro = "CUIL" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, , Val(keyword))
	'		ElseIf filtro = "DIRECCION" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, , , keyword)
	'		ElseIf filtro = "LOCALIDAD" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, , , , keyword)
	'		ElseIf filtro = "TITULO" Then
	'			bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, , , , , keyword)
	'		End If
	'	Else
	'		ControlBusqueda1.reset.PerformClick()
	'	End If

	'	CtrlMan.LoadDataGridView(resultado, bs_resultado)
	'End Sub



	'-- EVENTOS UNICOS

	Private Sub Consultar()
		With ControlBusqueda1
			If .vista.SelectedIndex > -1 Then
				.filtro.DataSource = Nothing
				If .vista.Text = "EXPEDIENTE" Then
					bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente()
				ElseIf .vista.Text = "RESPONSABLE" Then
					bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable()
				ElseIf .vista.Text = "PROFESIONAL" Then
					bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional()
				End If
				If bs_resultado.Count > 0 Then
					.filtro.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado.DataSource)
					CtrlMan.LoadDataGridView(resultado, bs_resultado, .bsCustomFilter)
				End If
			End If
		End With
	End Sub
	Private Sub Filtrar() Handles ControlBusqueda1.CSearch_Click
		bs_resultado.Filter = ControlBusqueda1.bsCustomFilter
	End Sub
	Private Sub Reiniciar() Handles ControlBusqueda1.CReset_Click
		ControlBusqueda1.reset_search.PerformClick()
	End Sub
	Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
		Consultar()
	End Sub

	Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles resultado.KeyUp
		If sender Is resultado Then
			If e.KeyValue = Keys.F2 Then
				If resultado.DataSource.Position > -1 Then
					Dim mexp As New ModExpediente(resultado.DataSource.Current("expediente"))
					mexp.ShowDialog()
					ControlBusqueda1.search.PerformClick()
				End If
			ElseIf e.KeyValue = Keys.Delete Then 'No implementado
				'If Oprivadas.Expediente.eliminar(resultado.DataSource.Current("expediente_id")) Then
				'resultado.DataSource.RemoveCurrent()
				'End If
			End If
		End If
	End Sub

End Class