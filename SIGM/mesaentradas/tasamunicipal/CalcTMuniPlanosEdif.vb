Class CalcTMuniPlanosEdif
    Property Help_source As New List(Of String)
    Property Variables() As DataRowView

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Visible Then
            bs_tasa_edificacion.DataSource = DbMan.ReadDB("SELECT id as tasa_edificacion_id, articulo, valor, descripcion 
                                                             FROM opr_tasa_edificacion",
                                                          My.Settings.CurrentDB, "opr_tasa_edificacion")

            Variables(0) = bs_tasa_edificacion(bs_tasa_edificacion.Find("articulo", "basico")) 'Basico
            Variables(1) = bs_tasa_edificacion(bs_tasa_edificacion.Find("articulo", "85b")) 'Antisismico
            Variables(2) = bs_tasa_edificacion(bs_tasa_edificacion.Find("articulo", "88")) 'descuento renovacion
            Variables(3) = bs_tasa_edificacion(bs_tasa_edificacion.Find("articulo", "93a")) 'linea municipal 1
            Variables(4) = bs_tasa_edificacion(bs_tasa_edificacion.Find("articulo", "93b")) 'linea municipal 2
            Variables(5) = bs_tasa_edificacion(bs_tasa_edificacion.Find("articulo", "93c")) 'ad linea municipal

            bs_indice_inmueble.DataSource = DbMan.ReadDB("SELECT id as tasa_edificacion_id, articulo, valor*alicuota as indice, descripcion
                                                            FROM opr_tasa_edificacion WHERE visible=True ORDER BY descripcion",
                                                        My.Settings.CurrentDB, "opr_indice_inmueble")
            Dim ctrl As New ctrlAddInmuebleEdificacion(bs_indice_inmueble.DataSource, False)
            lista_edificacion.Controls.Add(ctrl)
            AddHandler ctrl.Manage_edificacion, AddressOf Manage_edificacion

            Calcular()
        End If
    End Sub

    Private Sub Multa_relevamiento_CheckedChanged(sender As Object, e As EventArgs) Handles multa_relevamiento.CheckedChanged
        monto_multa_relevamiento.Enabled = multa_relevamiento.Checked
        Calcular()
    End Sub
    Private Sub Descuento_renovacion_CheckedChanged(sender As Object, e As EventArgs) Handles descuento_renovacion.CheckedChanged
        monto_descuento_renovacion.Enabled = descuento_renovacion.Checked
        Calcular()
    End Sub
    Private Sub Linea_municipal_ValueChanged(sender As Object, e As EventArgs) Handles monto_linea_municipal.ValueChanged
        Calcular()
    End Sub
    Private Sub Agua_ValueChanged(sender As Object, e As EventArgs)
        Calcular()
    End Sub
    Private Sub Desc_porcentaje_ValueChanged(sender As Object, e As EventArgs) Handles desc_porcentaje.ValueChanged, cuotas.ValueChanged, desc_porcentaje.ValueChanged
        Calcular()
    End Sub

    'Custom events from AddInmuebleEdificacion add, delete, calculate
    Private Sub Manage_edificacion(sender As Object, target As ctrlAddInmuebleEdificacion)
        If sender Is target.agregar Then
            Dim ctrl As New ctrlAddInmuebleEdificacion(bs_indice_inmueble.DataSource, True)
            lista_edificacion.Controls.Add(ctrl)
            AddHandler ctrl.Manage_edificacion, AddressOf Manage_edificacion

        ElseIf sender Is target.eliminar Then
            target.Dispose()
        End If
        Calcular()
    End Sub

    Private Sub Calcular()
        Dim superficie, total_superficie As Decimal
        Dim ad_categoria, subtotal, descuento As Decimal
        Dim basico, ad_sismico, desc_renovacion, linea_muni1, linea_muni2, ad_linea_muni As Decimal

        If Variables(0) Is Nothing = False And Me.Visible Then
            basico = Variables(0)("valor")
            ad_sismico = Variables(1)("valor")
            desc_renovacion = Variables(2)("valor")
            linea_muni1 = Variables(3)("valor")
            linea_muni2 = Variables(4)("valor")
            ad_linea_muni = Variables(5)("valor")

            'Urbanización
            For Each c As Control In lista_edificacion.Controls
                If TypeOf c Is ctrlAddInmuebleEdificacion Then
                    ad_categoria = CType(c, ctrlAddInmuebleEdificacion).categoria.SelectedValue
                    superficie = CType(c, ctrlAddInmuebleEdificacion).superficie.Value
                    total_superficie += superficie
                    subtotal += basico * ad_categoria * superficie
                End If
            Next
            sup_total.Text = total_superficie.ToString & " M²"

            'Tasas
            subtotal *= (1 + ad_sismico)
            subtotal += monto_linea_municipal.Value

            monto_presentacion_plano.Text = FormatCurrency(subtotal, 2)
            monto_aprobacion_proyecto.Text = FormatCurrency(subtotal, 2)

            If multa_relevamiento.Checked Then
                monto_multa_relevamiento.Text = FormatCurrency(subtotal, 2)
                subtotal *= 2
            Else
                monto_multa_relevamiento.Text = FormatCurrency(0, 2)
            End If

            If descuento_renovacion.Checked Then
                monto_descuento_renovacion.Text = FormatCurrency(subtotal * desc_renovacion, 2)
                subtotal -= subtotal * desc_renovacion
            Else
                monto_descuento_renovacion.Text = FormatCurrency(0, 2)
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
        End If
    End Sub



End Class
