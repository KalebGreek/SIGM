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
	Public Sub Consultar(vista As String, filtro As String, keyword As String) Handles ControlBusqueda1.CSearch_Click
		Dim excluir As Boolean = False
		keyword = Trim(keyword)
		If Len(keyword) > 1 Then
			If keyword.First = "-" Then
				excluir = True
				keyword = Microsoft.VisualBasic.Right(keyword, Len(keyword) - 1)
			End If
		End If
		If vista = "EXPEDIENTE" Then
			If filtro = "NRO." Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente(excluir, Val(keyword))
			ElseIf filtro = "UBICACION" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente(excluir, , keyword)
			ElseIf filtro = "FECHA" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Expediente(excluir, , , keyword)
			End If
		ElseIf vista = "RESPONSABLE" Then
			If filtro = "RAZON SOCIAL" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(excluir, keyword)
			ElseIf filtro = "CUIL" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(excluir, , Val(keyword))
			ElseIf filtro = "DIRECCION" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(excluir, , , keyword)
			ElseIf filtro = "LOCALIDAD" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Responsable(excluir, , , , keyword)
			End If
		ElseIf vista = "PROFESIONAL" Then
			If filtro = "RAZON SOCIAL" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, keyword)
			ElseIf filtro = "CUIL" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, , Val(keyword))
			ElseIf filtro = "DIRECCION" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, , , keyword)
			ElseIf filtro = "LOCALIDAD" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, , , , keyword)
			ElseIf filtro = "TITULO" Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar.Profesional(excluir, , , , , keyword)
			End If
		Else
			ControlBusqueda1.reset.PerformClick()
		End If
		CtrlMan.LoadDataGridView(resultado, bs_resultado)
	End Sub
	Public Sub Reiniciar() Handles ControlBusqueda1.CReset_Click
		bs_resultado.DataSource = Nothing
		CtrlMan.LoadDataGridView(resultado, bs_resultado)
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
		With ControlBusqueda1
			If .vista.SelectedIndex > -1 Then
				.filtro.Items.Clear()
				If .vista.Text = "EXPEDIENTE" Then
					.filtro.Items.AddRange(New Object() {"NRO.", "UBICACION", "FECHA"})
					.filtro.Text = "NRO."

				ElseIf .vista.Text = "RESPONSABLE" Then
					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL", "DIRECCION", "LOCALIDAD"})
					.filtro.Text = "RAZON SOCIAL"

				ElseIf .vista.Text = "PROFESIONAL" Then
					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL", "DIRECCION", "LOCALIDAD", "TITULO"})
					.filtro.Text = "RAZON SOCIAL"
				End If
			Else
				ControlBusqueda1.reset.PerformClick()
			End If
		End With
	End Sub
	Private Sub filtro_SelectedIndexChanged() Handles ControlBusqueda1.CFiltro_IndexTextChanged
		Reiniciar()
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