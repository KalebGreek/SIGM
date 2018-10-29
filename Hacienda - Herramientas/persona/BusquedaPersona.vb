Public Class BusquedaPersona
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		'Setting up views
		SearchControl1.vista.Items.AddRange(New Object() {"PERSONA", "EMPLEADO", "PROFESIONAL", "PROVEEDOR"})
	End Sub
	'-- RUTINAS
	Public Sub Consultar() Handles SearchControl1.CSearch_Click
		bs_resultado.Filter = SearchControl1.bsCustomFilter
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles SearchControl1.CVista_IndexTextChanged
		With SearchControl1
			If .vista.SelectedIndex > -1 Then
				.filtro.DataSource = Nothing
				If .vista.Text = "PERSONA" Then
					fisica.Enabled = True
					fisica.Checked = True
					difunto.Enabled = True
					difunto.Checked = False
					bs_resultado.DataSource = Persona.Buscar(difunto.Checked, fisica.Checked)

				ElseIf .vista.Text = "EMPLEADO" Then
					fisica.Enabled = False
					fisica.Checked = True
					difunto.Enabled = True
					difunto.Checked = False
					bs_resultado.DataSource = Empleado.BuscarPorPersona("", difunto.Checked)

				ElseIf .vista.Text = "PROFESIONAL" Then
					fisica.Enabled = True
					fisica.Checked = True
					difunto.Enabled = True
					difunto.Checked = False
					bs_resultado.DataSource = Profesional.BuscarPorPersona()

				ElseIf .vista.Text = "PROVEEDOR" Then
					fisica.Enabled = True
					fisica.Checked = False
					difunto.Enabled = False
					difunto.Checked = False
					Proveedor.BuscarPorPersona("", difunto.Checked, fisica.Checked)
				End If

				If bs_resultado.Count > 0 Then
					Dim bs_ColumnList As New BindingSource
					bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado.DataSource)
					CtrlMan.Fill.SetAutoComplete(SearchControl1.filtro, bs_ColumnList, "ColumnName", "DataType")
					.filtro.Text = "razon"
					CtrlMan.LoadDataGridView(resultado, bs_resultado, SearchControl1.bsCustomFilter)
				End If
			Else
				.reset_search.PerformClick()
			End If
		End With
	End Sub
	Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles SearchControl1.CKeyword_KeyUp, resultado.KeyUp
		If e.KeyValue = Keys.Enter And sender Is SearchControl1.keyword Then
			SearchControl1.search.PerformClick()
		ElseIf sender Is resultado Then
			If e.KeyValue = Keys.F2 Then
				If resultado.DataSource.Position > -1 Then
					Dim mper As New ModPersona
					mper.cargar(resultado.DataSource.Current("persona_id"))
					mper.ShowDialog()
					SearchControl1.search.PerformClick()
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
			SearchControl1.search.PerformClick()
		End If
	End Sub
End Class