Class ConsultaImpuesto
    '###### ATAJOS DE TECLADO ###############################################################################
    Private Sub ConsultaImpuesto_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.F3 Then
            imp_search.PerformClick()
        End If
    End Sub

    '###### GUI #############################################################################################
    Private Sub et_con_imp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles et_con_imp.DoubleClick
        If grupo_imp.Width = 100 Then
            grupo_imp.Width = 289
        Else
            grupo_imp.Width = 100
        End If
        visor.Refresh()
    End Sub

    Private Sub f1_impuesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1_impuesto.SelectedIndexChanged
        tablas_fox(f1_impuesto.Text)
        With f3_campo
            .Items.Clear()
            If f1_impuesto.SelectedIndex >= 0 Then
                .Items.Add("CODIGO")
                .Items.Add("CUIT | DNI")
                .Items.Add("DUEÑO O TENEDOR")
                If f1_impuesto.SelectedIndex = 3 Then
                    .Items.Add("ACTIVIDAD")
                End If
                f1_Deudor.Checked = True
            Else
                reset_impuesto()
            End If
        End With
    End Sub
    '--------------------------
    Private Sub mostrar_filtro1b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrar_f1b.CheckedChanged
        With mostrar_f1b
            grupo_deuda_total.Enabled = .Checked
            grupo_deuda_total.Visible = .Checked
            f1b_deuda_total.SelectedIndex = 0
            f1b_importe_mora.Checked = True

            'Deshabilitar
            If .Checked Then
                mostrar_f2.Enabled = False 'Filtrar por año deshabilitado
                mostrar_f2.Checked = False
            Else
                mostrar_f2.Enabled = True
            End If
        End With
    End Sub
    Private Sub filtro1b_opcion1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1b_deuda_total.SelectedIndexChanged
        f1b_minimo.Enabled = True
        f1b_maximo.Enabled = True
        If f1b_deuda_total.SelectedIndex = 1 Then
            f1b_minimo.Enabled = False
            f1b_minimo.Value = 0
        ElseIf f1b_deuda_total.SelectedIndex = 0 Then
            f1b_maximo.Enabled = False
            f1b_maximo.Value = f1b_minimo.Value
        End If
    End Sub
    Private Sub filtro1b_desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1b_minimo.ValueChanged
        With f1b_minimo
            If .Value > f1b_maximo.Value Then
                f1b_maximo.Value = .Value
            End If
        End With
    End Sub
    Private Sub filtro1b_hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1b_maximo.ValueChanged
        With f1b_maximo
            If f1b_minimo.Value > .Value Then
                f1b_minimo.Value = .Value
            End If
        End With
    End Sub
    '--------------------------
    Private Sub mostrar_filtro2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrar_f2.CheckedChanged
        With mostrar_f2
            f2_año_minimo.Enabled = .Checked
            Label1.Enabled = .Checked
            f2_año_maximo.Enabled = .Checked
            CtrlVenc1.Enabled = .Checked
            CtrlVenc1.Visible = .Checked
        End With
    End Sub
    '--------------------------
    Private Sub mostrar_filtro3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrar_f3.CheckedChanged
        With mostrar_f3
            f3_campo.Enabled = .Checked
            f3_clave.Enabled = .Checked
            f3_clave.Clear()
            If .Checked Then
                f3_campo.Text = "CODIGO"
            End If
        End With
    End Sub
    '--------------------------
    '## RUTINAS
    Private Sub reset_impuesto()
        '## RESET GENERAL
        'reset_campo(grupo_imp)
        f1_Deudor.Checked = True
        mostrar_f1b.Checked = False

        mostrar_f2.Checked = False
        f2_año_minimo.Value = Today.Year
        f2_año_maximo.Value = Today.Year

        mostrar_f3.Checked = False
        f3_campo.SelectedIndex = -1
    End Sub
    '--------------------------
    '###### FIN GUI #############################################################################################
    '------------------------------------------------------------------------------------------------------------
    '#### VENCIMIENTOS ################################
    Private Sub filtro2_año1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles f2_año_minimo.ValueChanged
        If f2_año_minimo.Value > f2_año_maximo.Value And f2_año_maximo.Enabled = True Then
            f2_año_minimo.Value -= 1
        End If
        CtrlVenc1.Listar(f2_año_minimo.Value, f2_año_maximo.Value, mostrar_f2.Checked, f1_impuesto.Text)
    End Sub
    Private Sub filtro2_año2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles f2_año_maximo.ValueChanged
        If f2_año_minimo.Value > f2_año_maximo.Value Then
            f2_año_maximo.Value += 1
        End If
        CtrlVenc1.Listar(f2_año_minimo.Value, f2_año_maximo.Value, mostrar_f2.Checked, f1_impuesto.Text)
    End Sub

    Private Sub ImprimirConsulta_Click(sender As Object, e As EventArgs) Handles ImprimirConsulta.Click
        If bs_consulta.Count > 0 Then
            ParametrosReporte.Hacienda.ImprimirDeudaContribuyente(bs_consulta.DataSource)
        End If
    End Sub

    '#### TOTALES DE CONSULTA Y OTROS ################################
    Private Sub bs_consulta_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_consulta.CurrentChanged
        With bs_consulta
            'Imprimir Consulta si tiene datos
            ImprimirConsulta.Enabled = bs_consulta.Count > 1

            'Deuda agrupada para mostrar al pie de la consulta
            If grupo_imp.Visible And bs_consulta.Position >= 0 And mostrar_f1b.Checked = False Then
                leer(f3_clave.Text, sender)
            Else
                info.Text = ""
                info2.Text = ""
            End If
        End With
    End Sub
    Private Sub leer(ByVal keyword As String, ByVal sender As Object)
        Dim dtab_imp, dtab_deto As DataTable
        progreso.Value = 0
        If sender Is imp_search Then
            visor.DataSource = Nothing
            bs_consulta.DataSource = Nothing
            dtab_imp = Recaudacion.ConsultarDeuda(f1_impuesto.Text, f1_Deudor.Checked,
                             f3_campo.SelectedIndex, keyword,
                             Format(fecha.Value.Date, "MM/dd/yyyy"), interes.Value / 100,
                             f1b_importe.Checked, f1b_mora.Checked, f1b_minimo.Value, f1b_maximo.Value,
                             f2_año_minimo.Value, f2_año_maximo.Value,
                             mostrar_f1b.Checked, mostrar_f2.Checked, mostrar_f3.Checked,
                             progreso) 'Consulta básica de impuesto específico sobre Fox

            visor = CtrlMan.DataGridViewTools.Load(visor, bs_consulta, dtab_imp)
        ElseIf sender Is bs_consulta Then
            'Deuda agrupada para mostrar al pie de la consulta
            info.Text = "Deuda Total:"
            'Deuda total desde $1 usando código de la fila seleccionada del impuesto seleccionado
            'No usa filtros, solo seleccion de impuesto y codigo
            dtab_deto = Recaudacion.ConsultarDeuda(f1_impuesto.Text, True,
                                  0, bs_consulta.Current("codigo"),
                                  Format(fecha.Value.Date, "MM/dd/yyyy"), interes.Value / 100,
                                  False, False, 1, 1,
                                  1898, Today.Year,
                                  True, mostrar_f2.Checked, mostrar_f3.Checked,
                                  progreso)
            If dtab_deto.Rows.Count > 0 Then
                info2.Text = "Deuda original: $" & dtab_deto.Rows(0)("original").ToString &
                                 " | Mora: $" & dtab_deto.Rows(0)("mora").ToString &
                                 " | Total: $" & dtab_deto.Rows(0)("total").ToString
            End If
        End If
        progreso.Value = 20
        visor.Focus()
    End Sub

    Private Sub imp_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_search.Click
        If f1_impuesto.SelectedIndex > -1 Then
            leer(f3_clave.Text, sender)
            'Identificar consulta mediante nombre de tabla
            CType(bs_consulta.DataSource, DataTable).TableName = "INFORME_" & f1_impuesto.Text
            If mostrar_f1b.Checked Then
                CType(bs_consulta.DataSource, DataTable).TableName = "_AGRUPADA"
            End If
        End If
    End Sub


    '----------------------
    '###### END FILTER ##########################################################################################

    '###### PRINT ###############################################################################################

    '###### END PRINT ###########################################################################################
End Class

