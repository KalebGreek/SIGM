Public Class BusquedaPersona
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		'Setting up views
		ControlBusqueda1.vista.Items.AddRange(New Object() {"PERSONA", "EMPLEADO", "PROFESIONAL", "PROVEEDOR"})
	End Sub
	'-- RUTINAS
	Public Sub Consultar() Handles ControlBusqueda1.CSearch_Click, ControlBusqueda1.CFiltro_IndexTextChanged
		With ControlBusqueda1
			CtrlMan.LoadDataGridView(resultado, bs_resultado,
									 Persona.Consultar(Trim(.vista.Text), Trim(.filtro.Text),
													   Trim(.keyword.Text), difunto.Checked, fisica.Checked))
		End With
	End Sub
	Public Sub ResetSearch() Handles ControlBusqueda1.CReset_Click
		Consultar()
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
		With ControlBusqueda1
			If .vista.SelectedIndex > -1 Then
				.filtro.Items.Clear()
				If .vista.Text = "PERSONA" Then
					fisica.Enabled = True
					fisica.Checked = True
					difunto.Enabled = True
					difunto.Checked = False

					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL/DNI", "DIRECCION", "LOCALIDAD", "ID"})
					.filtro.Text = "RAZON SOCIAL"

				ElseIf .vista.Text = "EMPLEADO" Then
					fisica.Enabled = False
					fisica.Checked = True
					difunto.Enabled = True
					difunto.Checked = False

					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL/DNI", "DIRECCION", "LOCALIDAD", "ALTA / BAJA"})
					.filtro.Text = "RAZON SOCIAL"

				ElseIf .vista.Text = "PROFESIONAL" Then
					fisica.Enabled = True
					fisica.Checked = True
					difunto.Enabled = True
					difunto.Checked = False

					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL/DNI", "DIRECCION", "LOCALIDAD", "TITULO"})
					.filtro.Text = "RAZON SOCIAL"

				ElseIf .vista.Text = "PROVEEDOR" Then
					fisica.Enabled = True
					fisica.Checked = False
					difunto.Enabled = False
					difunto.Checked = False

					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIT", "DIRECCION", "LOCALIDAD", "ACTIVIDAD"})
					.filtro.Text = "RAZON SOCIAL"
				End If
				Consultar()
			Else
				ResetSearch()
			End If
		End With
	End Sub
	Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles ControlBusqueda1.CKeyword_KeyUp, resultado.KeyUp
		If e.KeyValue = Keys.Enter And sender Is ControlBusqueda1.keyword Then
			Consultar()
		ElseIf sender Is resultado Then
			If e.KeyValue = Keys.F2 Then
				If resultado.DataSource.Position > -1 Then
					Dim mper As New ModPersona
					mper.cargar(resultado.DataSource.Current("persona_id"))
					mper.ShowDialog()
					Consultar()
				End If
			ElseIf e.KeyValue = Keys.Delete Then
				If Persona.Eliminar(resultado.DataSource.Current("persona_id")) Then
					resultado.DataSource.RemoveCurrent()
				End If
			End If
		End If
	End Sub

	Private Sub filtrospersona_CheckedChanged(sender As Object, e As EventArgs) Handles difunto.CheckedChanged, fisica.CheckedChanged
		If sender.Enabled Then
			Consultar()
		End If
	End Sub
End Class