Class ConsultaImpuesto
    '###### ATAJOS DE TECLADO ###############################################################################
    Private Sub ConsultaImpuesto_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.F3 Then
            EjecutarConsultaDeuda.PerformClick()
        End If
    End Sub

    '###### GUI - EVENTOS #############################################################################################
    Private Sub f1_impuesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1Servicio.SelectedIndexChanged
        tablas_fox(F1Servicio.Text)
        With F4CampoClave
            .Items.Clear()
            If F1Servicio.SelectedIndex >= 0 Then
                .Items.Add("CODIGO")
                .Items.Add("CUIT | DNI")
                .Items.Add("DUEÑO O TENEDOR")
                If F1Servicio.SelectedIndex = 3 Then
                    .Items.Add("ACTIVIDAD")
                End If
                F1Deudor.Checked = True
            Else
                reset_impuesto()
            End If
        End With
    End Sub
    '--------------------------
    Private Sub mostrar_filtro1b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2Mostrar.CheckedChanged
        With F2Mostrar
            grupo_deuda_total.Enabled = .Checked
            grupo_deuda_total.Visible = .Checked
            F2DeudaTotal.SelectedIndex = 0
            F2ImporteMora.Checked = True

            'Deshabilitar
            If .Checked Then
                F3Mostrar.Enabled = False 'Filtrar por año deshabilitado
                F3Mostrar.Checked = False
            Else
                F3Mostrar.Enabled = True
            End If
        End With
    End Sub
    Private Sub filtro1b_opcion1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2DeudaTotal.SelectedIndexChanged
        F2Minimo.Enabled = True
        F2Maximo.Enabled = True
        If F2DeudaTotal.SelectedIndex = 1 Then
            F2Minimo.Enabled = False
            F2Minimo.Value = 0
        ElseIf F2DeudaTotal.SelectedIndex = 0 Then
            F2Maximo.Enabled = False
            F2Maximo.Value = F2Minimo.Value
        End If
    End Sub
    Private Sub filtro1b_desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2Minimo.ValueChanged
        With F2Minimo
            If .Value > F2Maximo.Value Then
                F2Maximo.Value = .Value
            End If
        End With
    End Sub
    Private Sub filtro1b_hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2Maximo.ValueChanged
        With F2Maximo
            If F2Minimo.Value > .Value Then
                F2Minimo.Value = .Value
            End If
        End With
    End Sub
    '--------------------------
    Private Sub mostrar_filtro2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3Mostrar.CheckedChanged
        With F3Mostrar
            F3AñoMinimo.Enabled = .Checked
            Label1.Enabled = .Checked
            F3AñoMaximo.Enabled = .Checked
            CtrlVenc1.Enabled = .Checked
            CtrlVenc1.Visible = .Checked
        End With
    End Sub
    '--------------------------
    Private Sub mostrar_filtro3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4Mostrar.CheckedChanged
        With F4Mostrar
            F4CampoClave.Enabled = .Checked
            F4ValorClave.Enabled = .Checked
            F4ValorClave.Clear()
            If .Checked Then
                F4CampoClave.Text = "CODIGO"
            End If
        End With
    End Sub
    '--------------------------

    '#### VENCIMIENTOS ################################
    Private Sub filtro2_año1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F3AñoMinimo.ValueChanged
        If F3AñoMinimo.Value > F3AñoMaximo.Value And F3AñoMaximo.Enabled = True Then
            F3AñoMinimo.Value -= 1
        End If
        CtrlVenc1.Listar(F3AñoMinimo.Value, F3AñoMaximo.Value, F3Mostrar.Checked, F1Servicio.Text)
    End Sub
    Private Sub filtro2_año2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F3AñoMaximo.ValueChanged
        If F3AñoMinimo.Value > F3AñoMaximo.Value Then
            F3AñoMaximo.Value += 1
        End If
        CtrlVenc1.Listar(F3AñoMinimo.Value, F3AñoMaximo.Value, F3Mostrar.Checked, F1Servicio.Text)
    End Sub


    Private Sub BSConsulta_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BSConsulta.CurrentChanged
        With BSConsulta
            'Imprimir Consulta si tiene datos
            ImprimirConsultaDeuda.Enabled = BSConsulta.Count > 0

            'Deuda agrupada para mostrar al pie de la consulta
            If FiltroConsulta.Visible And BSConsulta.Position >= 0 And F2Mostrar.Checked = False Then
                ConsultarDeuda(F4ValorClave.Text, sender)
            Else
                info.Text = ""
                info2.Text = ""
            End If
        End With
    End Sub

    Private Sub ImprimirConsulta_Click(sender As Object, e As EventArgs) Handles ImprimirConsultaDeuda.Click
        ParametrosReporte.Hacienda.ImprimirDeudaContribuyente(BSConsulta)
    End Sub
    Private Sub EjecutarConsultaDeuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EjecutarConsultaDeuda.Click
        If F1Servicio.SelectedIndex > -1 Then
            ConsultarDeuda(F4ValorClave.Text, sender)
            'Identificar consulta mediante nombre de tabla
            CType(BSConsulta.DataSource, DataTable).TableName = "INFORME_" & F1Servicio.Text
            If F2Mostrar.Checked Then
                CType(BSConsulta.DataSource, DataTable).TableName = "_AGRUPADA"
            End If
        End If
    End Sub

    '###### FIN GUI #############################################################################################
    '------------------------------------------------------------------------------------------------------------
    '#### RUTINAS ################################

    Private Sub ConsultarDeuda(ByVal keyword As String, ByVal sender As Object)
        Dim dtab_deto As DataTable
        progreso.Value = 0
        If sender Is EjecutarConsultaDeuda Then
            VisorConsulta.DataSource = Nothing
            BSConsulta.DataSource = Recaudacion.ConsultarDeuda(F1Servicio.Text, F1Deudor.Checked,
                             F4CampoClave.SelectedIndex, keyword,
                             Format(F1Vencimiento.Value.Date, "MM/dd/yyyy"), F1Interes.Value / 100,
                             F2Importe.Checked, F2Mora.Checked, F2Minimo.Value, F2Maximo.Value,
                             F3AñoMinimo.Value, F3AñoMaximo.Value,
                             F2Mostrar.Checked, F3Mostrar.Checked, F4Mostrar.Checked,
                             progreso) 'Consulta básica de impuesto específico sobre Fox

            CtrlMan.DataGridViewTools.Load(VisorConsulta, BSConsulta)
        ElseIf sender Is BSConsulta Then
            Dim source As DataRowView = BSConsulta.Current
            If source Is Nothing = False Then
                'Deuda agrupada para mostrar al pie de la consulta
                info.Text = "Deuda Total:"
                'Deuda total desde $1 usando código de la fila seleccionada del impuesto seleccionado
                'No usa filtros, solo seleccion de impuesto y codigo
                dtab_deto = Recaudacion.ConsultarDeuda(F1Servicio.Text, True,
                                  0, source("codigo"),
                                  Format(F1Vencimiento.Value.Date, "MM/dd/yyyy"), F1Interes.Value / 100,
                                  False, False, 1, 1,
                                  1898, Today.Year,
                                  True, F3Mostrar.Checked, F4Mostrar.Checked,
                                  progreso)
                If dtab_deto.Rows.Count > 0 Then
                    info2.Text = "Deuda original: $" & dtab_deto.Rows(0)("original").ToString &
                                 " | Mora: $" & dtab_deto.Rows(0)("mora").ToString &
                                 " | Total: $" & dtab_deto.Rows(0)("total").ToString
                End If
            End If
        End If
        progreso.Value = 20
        VisorConsulta.Focus()
    End Sub
    Private Sub reset_impuesto()
        '## RESET GENERAL
        F1Deudor.Checked = True
        F2Mostrar.Checked = False

        F3Mostrar.Checked = False
        F3AñoMinimo.Value = Today.Year
        F3AñoMaximo.Value = Today.Year

        F4Mostrar.Checked = False
        F4CampoClave.SelectedIndex = -1
    End Sub

    '----------------------
    '###### END RUTINAS ##########################################################################################

    '###### PRINT ###############################################################################################

    '###### END PRINT ###########################################################################################
End Class

