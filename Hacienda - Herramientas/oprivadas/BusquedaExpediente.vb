Public Class BusquedaExpediente
	Private Sub ConsultaPersona_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then
			'Setting up views
			ControlBusqueda1.Vista.Items.AddRange(New Object() {"EXPEDIENTE", "RESPONSABLE", "PROFESIONAL"})
			'Selecting view
			If ControlBusqueda1.Vista.SelectedIndex = -1 Then
				ControlBusqueda1.Vista.SelectedIndex = 0 'Persona
            End If
		End If
	End Sub

	'-- RUTINAS
	Public Sub Consultar(vista As String, filtro As String, keyword As String) Handles ControlBusqueda1.CSearch_Click
		If vista = "EXPEDIENTE" Then
			If filtro = "NRO." Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(Val(keyword))
			End If
		ElseIf vista = "RESPONSABLE" Then
			If filtro = "CUIL" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(, , , Val(keyword))
			Else
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(, keyword)
			End If
		ElseIf vista = "PROFESIONAL" Then
			If filtro = "CUIL" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(, , , Val(keyword))
			Else
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(, , keyword)
			End If
		Else
			ControlBusqueda1.reset.PerformClick()
		End If
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
		With ControlBusqueda1
			If .Vista.SelectedIndex > -1 Then
				.filtro.Items.Clear()
				If .Vista.Text = "EXPEDIENTE" Then
					.filtro.Items.AddRange(New Object() {"NRO.", "UBICACION", "LOCALIDAD", "ALTA"})
					.filtro.Text = "NRO."

				ElseIf .Vista.Text = "RESPONSABLE" Then
					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL/DNI", "DIRECCION", "LOCALIDAD"})
					.filtro.Text = "RAZON SOCIAL"

				ElseIf .Vista.Text = "PROFESIONAL" Then
					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL/DNI", "DIRECCION", "LOCALIDAD", "TITULO"})
					.filtro.Text = "RAZON SOCIAL"
				End If
			Else
				ControlBusqueda1.reset.PerformClick()
			End If
		End With
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