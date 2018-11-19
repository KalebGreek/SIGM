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