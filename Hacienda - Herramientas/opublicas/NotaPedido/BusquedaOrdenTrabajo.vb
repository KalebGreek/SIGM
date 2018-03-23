Public Class BusquedaOrdenTrabajo
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		'Setting up views

		ControlBusqueda1.vista.Items.AddRange(New Object() {"RESPONSABLE", "PROVEEDOR", "PEDIDO"})
	End Sub
	'-- RUTINAS
	Public Sub Consultar(vista As String, filtro As String, keyword As String) Handles ControlBusqueda1.CSearch_Click
		With ControlBusqueda1
			CtrlMan.LoadDataGridView(resultado, bs_resultado,
									 NotaPedido.Buscar(Trim(filtro), Trim(keyword)))
		End With
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
		With ControlBusqueda1
			If .vista.SelectedIndex > -1 Then
				.filtro.Items.Clear()
				If .vista.Text = "RESPONSABLE" Then
					.filtro.Items.AddRange(New Object() {"responsable_razon", "responsable_cuil", "responsable_direccion", "responsable_localidad"})
				ElseIf .vista.Text = "PROVEEDOR" Then
					.filtro.Items.AddRange(New Object() {"proveedor_razon", "proveedor_cuil", "proveedor_direccion", "proveedor_localidad", "proveedor_actividad"})
				ElseIf .vista.Text = "PEDIDO" Then
					.filtro.Items.AddRange(New Object() {"fecha", "numpedido"})
				End If
			Else
				ControlBusqueda1.reset.PerformClick()
			End If
			If .filtro.Items.Count > 0 Then
				.filtro.SelectedIndex = 0
			End If
		End With
	End Sub
	Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles ControlBusqueda1.CKeyword_KeyUp, resultado.KeyUp
		If e.KeyValue = Keys.Enter And sender Is ControlBusqueda1.keyword Then
			ControlBusqueda1.search.PerformClick()
		ElseIf sender Is resultado Then
			If e.KeyValue = Keys.F2 Then
				If resultado.DataSource.Position > -1 Then
					'Dim mnp As New ModNotaPedido
					'mnp.cargar(resultado.DataSource.Current("nota_pedido_id"))
					'mnp.ShowDialog()
					ControlBusqueda1.search.PerformClick()
				End If
			ElseIf e.KeyValue = Keys.Delete Then
				If NotaPedido.Eliminar(resultado.DataSource.Current("nota_pedido_id")) Then
					resultado.DataSource.RemoveCurrent()
				End If
			End If
		End If
	End Sub

End Class