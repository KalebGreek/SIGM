Public Class calcTasaMunicipalPlanosEdif
    Dim bs_opr_tasa_municipal_obras As BindingSource
    Private Sub calcTasaMunicipalPlanosEdif_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Dim dtab As New DataTable
            Dim sql(1) As String
            sql(0) = "SELECT *"
            sql(1) = "FROM opr_tasa_municipal_obras"
            dtab = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql, "opr_tasa_municipal_obras")
            If dtab.Rows.Count > 0 Then
                bs_opr_tasa_municipal_obras.DataSource = dtab
            Else
                bs_opr_tasa_municipal_obras.DataSource = Nothing
            End If
            calcular()
        End If
    End Sub

    Private Sub zona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles zona_inmueble.SelectedIndexChanged
        calcular()
    End Sub

    Private Sub superficie_ValueChanged(sender As Object, e As EventArgs) Handles sup_cubierta.ValueChanged, sup_semi.ValueChanged, sup_galpon.ValueChanged
        calcular()
    End Sub
    Private Sub linea_municipal_ValueChanged(sender As Object, e As EventArgs) Handles linea_municipal.ValueChanged
        calcular()
    End Sub
    Private Sub agua_ValueChanged(sender As Object, e As EventArgs) Handles agua_obra.ValueChanged, agua_cruce.ValueChanged
        calcular()
    End Sub
    Private Sub desc_porcentaje_ValueChanged(sender As Object, e As EventArgs) Handles desc_porcentaje.ValueChanged, cuotas.ValueChanged
        calcular()
    End Sub

    Private Sub calcular()
        If bs_opr_tasa_municipal_obras.Count > 0 Then
            Dim zona As Integer
            zona = zona_inmueble.SelectedIndex + 1
            'Superficie
            Dim superficie As Decimal = sup_cubierta.Value + sup_semi.Value + sup_galpon.Value
            sup_total.Text = superficie.ToString & "m²"

            'Tasas
            With bs_opr_tasa_municipal_obras
                If zona > 0 Then
                    If tipo_loteo.Checked Then
                        .Filter = "zona=" & zona & " AND urbanizacion='loteo'"
                    Else
                        .Filter = "zona=" & zona & " AND urbanizacion='mensura'"
                    End If
                    .Position = 0
                    'cargar montos desde tabla




                Else
                    .Filter = ""
                End If
            End With


            'Agua corriente


            'Financiación
        End If
    End Sub


End Class
