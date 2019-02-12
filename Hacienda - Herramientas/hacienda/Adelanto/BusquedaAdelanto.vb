Public Class BusquedaAdelanto
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		GenSearchControl1.vista.Items.AddRange(New Object() {"ADELANTO"})
	End Sub

	Public Sub Consultar() Handles GenSearchControl1.CSearch_Click
		bs_resultado.Filter = GenSearchControl1.bsCustomFilter
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles GenSearchControl1.CVista_IndexTextChanged
		With GenSearchControl1
			If .vista.SelectedIndex > -1 Then
				.filtro.DataSource = Nothing
				If .vista.Text = "ADELANTO" Then
					Dim sql As String = "SELECT hac_adelanto.id as id, persona.razon, persona.cuil, 
												hac_adelanto.persona_id, hac_adelanto.fecha, hac_adelanto.monto,
												persona.email, persona.telefono										 
										 FROM hac_adelanto INNER JOIN persona ON hac_adelanto.persona_id=persona.id"
					bs_resultado.DataSource = DbMan.read(Nothing, My.Settings.DefaultCon, sql)
				End If

				If bs_resultado.Count > 0 Then
					Dim bs_ColumnList As New BindingSource
					bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado.DataSource)
					CtrlMan.Fill.SetAutoComplete(GenSearchControl1.filtro, bs_ColumnList, "ColumnName", "DataType")
					CtrlMan.LoadDataGridView(resultado, bs_resultado, GenSearchControl1.bsCustomFilter)
					GenSearchControl1.filtro.SelectedIndex = -1
				Else
					bs_resultado.Add("No hay resultados.")
				End If
			Else
				.reset_search.PerformClick()
			End If
		End With
	End Sub
	Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, resultado.KeyUp, GenSearchControl1.KeyUp
		If e.KeyValue = Keys.Enter And sender Is GenSearchControl1 Then
			GenSearchControl1.search.PerformClick()
		ElseIf e.KeyValue = Keys.F2 Then
			Dim madel As New ModAdelanto
			madel.ShowDialog(Me)
		ElseIf e.KeyValue = Keys.Delete Then
			If bs_resultado.Count > 0 Then
				If bs_resultado.Position > -1 Then
					If DbMan.edit(Nothing, My.Settings.DefaultCon, "DELETE * FROM hac_adelanto WHERE id=" & bs_resultado.Current("id")) Then
						bs_resultado.RemoveCurrent()
					End If
				End If
			End If
		End If
	End Sub
	Private Sub Close_Search() Handles GenSearchControl1.CSelect, GenSearchControl1.CCancel
		Me.Close()
	End Sub
	Private Sub Me_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If GenSearchControl1.RowSelected = False Then
			bs_resultado.DataSource = Nothing
		End If
	End Sub
End Class