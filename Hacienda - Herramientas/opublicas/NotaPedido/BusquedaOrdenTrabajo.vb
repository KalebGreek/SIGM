Public Class BusquedaOrdenTrabajo
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		'Setting up views

		ControlBusqueda1.vista.Items.AddRange(New Object() {"NOTA DE PEDIDO"})
	End Sub
	'-- RUTINAS
	Public Sub Consultar() Handles ControlBusqueda1.CSearch_Click
		bs_resultado.Filter = ControlBusqueda1.bsCustomFilter
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
		With ControlBusqueda1
			If .vista.SelectedIndex > -1 Then
				.filtro.DataSource = Nothing
				If .vista.Text = "NOTA DE PEDIDO" Then
					Dim bs_ColumnList As New BindingSource
					bs_resultado.DataSource = NotaPedido.Buscar()
					bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado.DataSource)
					CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
				End If
				If .filtro.Items.Count > 0 Then
					.filtro.SelectedIndex = 0
				End If
				CtrlMan.LoadDataGridView(resultado, bs_resultado, .bsCustomFilter,)
			Else
				ControlBusqueda1.reset_search.PerformClick()
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