Public Class calcTMuniMensura
    Public help_source As New List(Of String)({"test7", "test8", "test9"})
    Dim ad_agua_corriente As Decimal

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Visible Then
            Dim sql(1) As String
            Dim dtab As DataTable
            sql(0) = "SELECT valor"
            sql(1) = "FROM opr_tasa_mensura WHERE articulo='953'"
            dtab = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

            ad_agua_corriente = CDec(dtab(0)("valor"))

            sql(0) = "SELECT id as tasa_mensura_id, articulo, valor, descripcion"
            sql(1) = "FROM opr_tasa_mensura"
            bs_tasa_mensura.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql, "opr_tasa_mensura")

            sql(0) = "SELECT id as zona_id, item"
            sql(1) = "FROM opr_zona_inmueble"
            bs_zona.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql, "opr_zona_inmueble")
            CtrlMan.Fill.SetAutoComplete(zona_inmueble, bs_zona, "item", "zona_id")
        End If
    End Sub
    'Urbanización
    Private Sub con_escritura_CheckedChanged(sender As Object, e As EventArgs) Handles con_escritura.CheckedChanged
        filtro_tasa_mensura()
        calcular()
    End Sub
    Private Sub zona_inmueble_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zona_inmueble.SelectedIndexChanged
        filtro_tasa_mensura()
        calcular()
    End Sub
    Private Sub total_lotes_ValueChanged(sender As Object, e As EventArgs) Handles total_lotes.ValueChanged
        filtro_tasa_mensura()
        calcular()
    End Sub
    'Agua corriente
    Private Sub factibilidad_agua_CheckedChanged(sender As Object, e As EventArgs) Handles factibilidad_agua.CheckedChanged
        Label22.Enabled = factibilidad_agua.Checked
        Label24.Enabled = factibilidad_agua.Checked
        monto_factibilidad_agua.Enabled = factibilidad_agua.Checked
        monto_mano_obra.Enabled = factibilidad_agua.Checked
        monto_cruce_calle.Enabled = factibilidad_agua.Checked
        calcular()
    End Sub
    Private Sub monto_mano_obra_ValueChanged(sender As Object, e As EventArgs) Handles monto_mano_obra.ValueChanged
        calcular()
    End Sub

    Private Sub monto_cruce_calle_ValueChanged(sender As Object, e As EventArgs) Handles monto_cruce_calle.ValueChanged
        calcular()
    End Sub
    Private Sub multa_relevamiento_CheckedChanged(sender As Object, e As EventArgs) Handles multa_relevamiento.CheckedChanged
        monto_multa_relevamiento.Enabled = multa_relevamiento.Checked
        calcular()
    End Sub
    Private Sub descuento_ValueChanged(sender As Object, e As EventArgs) Handles desc_porcentaje.ValueChanged
        calcular()
    End Sub
    Private Sub cuotas_ValueChanged(sender As Object, e As EventArgs) Handles cuotas.ValueChanged
        calcular()
    End Sub

    Private Sub filtro_tasa_mensura()
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

    Private Sub calcular()
        'Zonas
        Dim subtotal, descuento As Decimal
        If bs_tasa_mensura.Current Is Nothing = False And total_lotes.Value > 0 Then
            subtotal = CDec(bs_tasa_mensura.Current("valor")) * total_lotes.Value
        End If
        'Agua corriente
        If factibilidad_agua.Checked Then
            monto_factibilidad_agua.Text = FormatCurrency(subtotal * ad_agua_corriente, 2)
            subtotal += (subtotal * ad_agua_corriente) + monto_mano_obra.Value + monto_cruce_calle.Value
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
