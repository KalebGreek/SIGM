Class CalcTMuniMensura
    Public HelpSource As New List(Of String)({"test7", "test8", "test9"})
    Dim Ad_agua_corriente As Decimal

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Visible Then
            Dim dtab As DataTable = DbMan.ReadDB("SELECT valor FROM opr_tasa_mensura WHERE articulo='953'",
                                                 My.Settings.CurrentDB)

            Ad_agua_corriente = CDec(dtab.Rows(0)("valor"))

            bs_tasa_mensura.DataSource = DbMan.ReadDB("SELECT id as tasa_mensura_id, articulo, valor, descripcion 
                                                         FROM opr_tasa_mensura",
                                                     My.Settings.CurrentDB, "opr_tasa_mensura")

            bs_zona.DataSource = DbMan.ReadDB("SELECT id as zona_id, item FROM opr_zona_inmueble",
                                              My.Settings.CurrentDB, "opr_zona_inmueble")

            CtrlMan.Fill.SetAutoComplete(zona_inmueble, bs_zona, "item", "zona_id")
        End If
    End Sub
    'Urbanización
    Private Sub Con_escritura_CheckedChanged(sender As Object, e As EventArgs) Handles con_escritura.CheckedChanged
        Filtro_tasa_mensura()
        Calcular()
    End Sub
    Private Sub Zona_inmueble_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zona_inmueble.SelectedIndexChanged
        Filtro_tasa_mensura()
        Calcular()
    End Sub
    Private Sub Total_lotes_ValueChanged(sender As Object, e As EventArgs) Handles total_lotes.ValueChanged
        Filtro_tasa_mensura()
        Calcular()
    End Sub
    'Agua corriente
    Private Sub Factibilidad_agua_CheckedChanged(sender As Object, e As EventArgs) Handles factibilidad_agua.CheckedChanged
        Label22.Enabled = factibilidad_agua.Checked
        Label24.Enabled = factibilidad_agua.Checked
        monto_factibilidad_agua.Enabled = factibilidad_agua.Checked
        monto_mano_obra.Enabled = factibilidad_agua.Checked
        monto_cruce_calle.Enabled = factibilidad_agua.Checked
        Calcular()
    End Sub
    Private Sub Monto_mano_obra_ValueChanged(sender As Object, e As EventArgs) Handles monto_mano_obra.ValueChanged
        Calcular()
    End Sub

    Private Sub Monto_cruce_calle_ValueChanged(sender As Object, e As EventArgs) Handles monto_cruce_calle.ValueChanged
        Calcular()
    End Sub
    Private Sub Multa_relevamiento_CheckedChanged(sender As Object, e As EventArgs) Handles multa_relevamiento.CheckedChanged
        monto_multa_relevamiento.Enabled = multa_relevamiento.Checked
        Calcular()
    End Sub
    Private Sub Descuento_ValueChanged(sender As Object, e As EventArgs) Handles desc_porcentaje.ValueChanged
        Calcular()
    End Sub
    Private Sub Cuotas_ValueChanged(sender As Object, e As EventArgs) Handles cuotas.ValueChanged
        Calcular()
    End Sub

    Private Sub Filtro_tasa_mensura()
        Dim filtro As String = ""
        If Me.Visible Then
            If zona_inmueble.SelectedIndex > -1 Then
                filtro = "descripcion LIKE '" & zona_inmueble.Text & "%' AND articulo='"

                If con_escritura.Checked Then
                    If total_lotes.Value > 10 Then
                        filtro &= "951b'"
                    Else
                        filtro &= "951a'"
                    End If
                ElseIf con_derechos.Checked Then
                    If total_lotes.Value > 10 Then
                        filtro &= "952b'"
                    Else
                        filtro &= "952a'"
                    End If
                End If

            End If
        End If
        bs_tasa_mensura.Filter = filtro
        bs_tasa_mensura.Position = 0
    End Sub

    Private Sub Calcular()
        'Zonas
        Dim subtotal, descuento As Decimal
        Dim tasa_mensura As DataRowView = bs_tasa_mensura.Current
        If tasa_mensura Is Nothing = False And total_lotes.Value > 0 Then
            subtotal = CDec(tasa_mensura("valor")) * total_lotes.Value
        End If
        'Agua corriente
        If factibilidad_agua.Checked Then
            monto_factibilidad_agua.Text = FormatCurrency(subtotal * Ad_agua_corriente, 2)
            subtotal += (subtotal * Ad_agua_corriente) + monto_mano_obra.Value + monto_cruce_calle.Value
        Else
            monto_factibilidad_agua.Text = FormatCurrency(0, 2)
        End If
        'Tasas
        If multa_relevamiento.Checked Then
            monto_multa_relevamiento.Text = FormatCurrency(subtotal, 2)
            subtotal *= 2
        End If

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
