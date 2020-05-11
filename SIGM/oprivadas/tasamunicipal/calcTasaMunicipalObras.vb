Public Class calcTasaMunicipalObras
	'EVENTOS
	Private Sub eventos_calculo(sender As Object, e As EventArgs) Handles costo.ValueChanged, metrosFrente.ValueChanged,
																	metrosCalle.ValueChanged, descuento.ValueChanged,
																	cuotas.ValueChanged
		Calcular()
	End Sub
	'RUTINAS
	Sub Calcular()
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
End Class
