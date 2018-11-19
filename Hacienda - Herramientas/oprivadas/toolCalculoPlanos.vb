Public Class toolCalculoPlanos
	'RUTINAS
	Sub calcular()
		Dim sub1, cuota1, desc1 As New Decimal
		If costo.Value > 0 And metrosFrente.Value > 0 And metrosCalle.Value > 0 Then
			sub1 = (costo.Value * metrosFrente.Value) * (metrosCalle.Value / 2)
			If descuento.Value > 0 Then
				desc1 = sub1 - (sub1 * descuento.Value / 100)
			End If

			If cuotas.Value > 0 Then
				cuota1 = sub1 / cuotas.Value
			End If
		End If

		total.Text = FormatCurrency(sub1, 2)
		montoDescuento.Text = FormatCurrency(desc1, 2)
		montoCuota.Text = FormatCurrency(cuota1, 2)
	End Sub

	'EVENTOS
	Private Sub eventos_calculo(sender As Object, e As EventArgs) Handles costo.ValueChanged, metrosFrente.ValueChanged,
																	metrosCalle.ValueChanged, descuento.ValueChanged,
																	cuotas.ValueChanged
		calcular()
	End Sub

	Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
		titulo.Text = TabControl1.SelectedTab.Text
	End Sub

	Private Sub CálculoDeObrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoDeObrasToolStripMenuItem.Click
		TabControl1.SelectTab(TabPage1)
	End Sub

	Private Sub CálculoDePlanosDeEdificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoDePlanosDeEdificaciónToolStripMenuItem.Click
		TabControl1.SelectTab(TabPage2)
	End Sub

	Private Sub CálculoDePlanosDeMensuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoDePlanosDeMensuraToolStripMenuItem.Click
		TabControl1.SelectTab(TabPage3)
	End Sub

	Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
		obra.Clear()
		propietario.Clear()
		tenedor.Clear()
		costo.Value = costo.Minimum
		metrosFrente.Value = metrosFrente.Minimum
		metrosCalle.Value = metrosCalle.Minimum
		descuento.Value = descuento.Minimum
		cuotas.Value = cuotas.Minimum
	End Sub

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
				metrosFrente.Value = CDec(.Current("frente1")) + CDec(.Current("frente2")) + CDec(.Current("frente3")) + CDec(.Current("frente4"))
			End If
		End With
		bprop.Dispose()
	End Sub


End Class
