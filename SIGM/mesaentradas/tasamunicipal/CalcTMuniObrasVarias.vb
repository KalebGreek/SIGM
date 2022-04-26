Public Class CalcTMuniObrasVarias

    Public help_source As New List(Of String)({"test4", "test5", "test6"})
    'EVENTOS
    Private Sub CalcTMuniObrasVarias_Load(sender As Object, e As EventArgs) Handles Me.Load
        Calcular()
    End Sub
    Private Sub Eventos_calculo(sender As Object, e As EventArgs) Handles costo.ValueChanged, metros_frente.ValueChanged,
                                                                    metros_calle.ValueChanged, desc_porcentaje.ValueChanged,
                                                                    cuotas.ValueChanged
        Calcular()
    End Sub
    'RUTINAS
    Sub Calcular()
        Dim subtotal, descuento As Decimal

        If costo.Value > 0 And metros_frente.Value > 0 And metros_calle.Value > 0 Then
            subtotal = (costo.Value * metros_frente.Value) * (metros_calle.Value / 2)
        Else
            subtotal = 0
        End If
        monto_subtotal.Text = FormatCurrency(subtotal, 2)

        'Financiación
        monto_subtotal.Text = FormatCurrency(subtotal, 2)

        If desc_porcentaje.Value > 0 Then
            descuento = subtotal * (desc_porcentaje.Value / 100)
        End If
        monto_descuento.Text = FormatCurrency(descuento, 2)

        If cuotas.Value > 0 Then
            monto_cuota.Text = FormatCurrency((subtotal - descuento) / cuotas.Value, 2)
        Else
            monto_cuota.Text = FormatCurrency(0, 2)
        End If
        total.Text = FormatCurrency(subtotal - descuento, 2)

    End Sub


End Class
