Public Class toolCalculoTasaMunicipal


	Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
		Dim bprop As New BusquedaPropietario
		bprop.genSearchControl1.vista.Text = "PROPIETARIO"
		bprop.genSearchControl1.selectRow.Visible = True
		bprop.genSearchControl1.cancel.Visible = True
		bprop.ShowDialog(Me)
		With bprop.bs_resultado
			If .Position > -1 Then
				propietario.Text = .Current("razon").ToString()
				tenedor.Text = .Current("tenedor").ToString()
				'calcTasaMunicipalPlanosEdif.metrosFrente.Value = CDec(.Current("frente1")) + CDec(.Current("frente2")) + CDec(.Current("frente3")) + CDec(.Current("frente4"))
			End If
		End With
		bprop.Dispose()
	End Sub

	Private Sub ReiniciarMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarMenuItem.Click
		'CalcTasaMunicipalPlanosEdif1 = New calcTasaMunicipalPlanosEdif
		'CalcTasaMunicipalObras1 = New calcTasaMunicipalObras
	End Sub
End Class
