Class ConsultaImpuestoUI
    '###### ATAJOS DE TECLADO ###############################################################################
    Private Sub ConsultaImpuesto_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.F3 Then
            EjecutarConsultaDeuda.PerformClick()
        End If
    End Sub

    '###### GUI - EVENTOS #############################################################################################
    Private Sub F1_impuesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1Servicio.SelectedIndexChanged
        Tablas_Fox(F1Servicio.Text)
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
    Private Sub Mostrar_filtro1b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2Mostrar.CheckedChanged
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
    Private Sub Filtro1b_opcion1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2DeudaTotal.SelectedIndexChanged
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
    Private Sub Filtro1b_desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2Minimo.ValueChanged
        With F2Minimo
            If .Value > F2Maximo.Value Then
                F2Maximo.Value = .Value
            End If
        End With
    End Sub
    Private Sub Filtro1b_hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2Maximo.ValueChanged
        With F2Maximo
            If F2Minimo.Value > .Value Then
                F2Minimo.Value = .Value
            End If
        End With
    End Sub
    '--------------------------
    Private Sub Mostrar_filtro2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3Mostrar.CheckedChanged
        With F3Mostrar
            F3AñoMinimo.Enabled = .Checked
            Label1.Enabled = .Checked
            F3AñoMaximo.Enabled = .Checked
            CtrlVenc1.Enabled = .Checked
            CtrlVenc1.Visible = .Checked
        End With
    End Sub
    '--------------------------
    Private Sub Mostrar_filtro3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4Mostrar.CheckedChanged
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
    Private Sub Filtro2_año1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F3AñoMinimo.ValueChanged
        If F3AñoMinimo.Value > F3AñoMaximo.Value And F3AñoMaximo.Enabled = True Then
            F3AñoMinimo.Value -= 1
        End If
        CtrlVenc1.Listar(F3AñoMinimo.Value, F3AñoMaximo.Value, F3Mostrar.Checked, F1Servicio.Text)
    End Sub
    Private Sub Filtro2_año2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F3AñoMaximo.ValueChanged
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
                Dim dtab As DataTable = ConsultaImpuesto.ConsultarDeuda(F1Servicio.Text, Format(F1Vencimiento.Value.Date, "MM/dd/yyyy"), F1Interes.Value / 100,
                                                                        F3Mostrar.Checked, F4Mostrar.Checked, progreso, BSConsulta.Current)
                If dtab.Rows.Count > 0 Then
                    info2.Text = "Deuda original: $" & dtab.Rows(0)("original").ToString &
                                 " | Mora: $" & dtab.Rows(0)("mora").ToString &
                                 " | Total: $" & dtab.Rows(0)("total").ToString
                End If
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
            Dim dtab As DataTable = ConsultaImpuesto.ConsultarDeuda(F1Servicio.Text, F1Deudor.Checked,
                                            F4CampoClave.SelectedIndex, F4ValorClave.Text,
                                            Format(F1Vencimiento.Value.Date, "MM/dd/yyyy"), F1Interes.Value / 100,
                                            F2Importe.Checked, F2Mora.Checked, F2Minimo.Value, F2Maximo.Value,
                                            F3AñoMinimo.Value, F3AñoMaximo.Value,
                                            F2Mostrar.Checked, F3Mostrar.Checked, F4Mostrar.Checked,
                                            progreso)
            If dtab.Rows.Count > 0 Then
                'Identificar consulta mediante nombre de tabla
                dtab.TableName = "INFORME_" & F1Servicio.Text
                If F2Mostrar.Checked Then
                    dtab.TableName = "_AGRUPADA"
                End If
                BSConsulta.DataSource = dtab
                CtrlMan.DataGridViewTools.Load(VisorConsulta, BSConsulta)
            Else
                MsgBox("No hay resultados.", MsgBoxStyle.Information, "Consulta de deuda")
            End If
        End If
    End Sub

    '###### FIN GUI #############################################################################################
    '------------------------------------------------------------------------------------------------------------
    '#### RUTINAS ################################


    Private Sub Reset_impuesto()
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

