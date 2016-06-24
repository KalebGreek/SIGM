Public Class ConsultaImpuesto
    '###### VARIABLES #######################################################################################
    Dim cuota_vence As Integer
    Dim dtab_imp, dtab_cuenta, dtab_vence, dtab_deto As New DataTable
    Public dtab_contrib, dtab_mod_contrib As New DataTable
    Dim found As Boolean
    Private Sub hacienda_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged

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
            End If
        End With
    End Sub

    '###### FIN VARIABLES ###################################################################################
    '###### GUI #############################################################################################
    Private Sub ImpuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        info.Text = "Leyendo datos.."

        '## ORIGEN DE TABLAS EXTERNAS
        With config
            ext_persona = .agua_personas.Text
            ext_cuenta = .agua_cuentas.Text
            ext_vence = .agua_vencimientos.Text
            ext_variable = .agua_variables.Text
            ext_historial = .agua_historial.Text
        End With
        reset_impuesto()
        progreso.Value = 10
        f1_impuesto.SelectedIndex = 0 'Selecciona servicio correcto
        '## VENCIMIENTOS
        dtab_vence = Vencimientos.Listar(Today.Year, Today.Year, True)
        If dtab_vence.Rows.Count > 0 Then
            vence1.Text = Convert.ToString(dtab_vence(0)("vence1"))
            vence2.Text = Convert.ToString(dtab_vence(0)("vence2"))
            vence3.Text = Convert.ToString(dtab_vence(0)("vence3"))
            vence4.Text = Convert.ToString(dtab_vence(0)("vence4"))
            vence5.Text = Convert.ToString(dtab_vence(0)("vence5"))
            vence6.Text = Convert.ToString(dtab_vence(0)("vence6"))
        Else
            vence1.Text = "No hay datos"
            vence2.Text = "No hay datos"
            vence3.Text = "No hay datos"
            vence4.Text = "No hay datos"
            vence5.Text = "No hay datos"
            vence6.Text = "No hay datos"
        End If
        progreso.Value = 20
        grupo_imp.Visible = True
        grupo_imp.Width = 289
    End Sub

    Private Sub grupo_ca_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.Visible Then
            grupo_imp.Visible = False
        End If
    End Sub
    Private Sub et_con_imp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles et_con_imp.DoubleClick
        If grupo_imp.Width = 100 Then
            grupo_imp.Width = 289
        Else
            grupo_imp.Width = 100
        End If
        visor.Refresh()
    End Sub

    '#### IMPUESTOS ##############################################
    '## EVENTOS
    Private Sub mostrar_filtro1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrar_f1.CheckedChanged
        With mostrar_f1
            f1_deudor.Enabled = .Checked
            If .Checked Then
                f1_deudor.SelectedIndex = 0
            Else
                f1_deudor.SelectedIndex = -1
            End If
            mostrar_f1b.Enabled = .Checked
        End With
    End Sub
    Private Sub filtro1_opcion1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1_deudor.SelectedIndexChanged
        mostrar_f1b.Checked = False
        If f1_deudor.SelectedIndex = 0 Then
            f1_deudor.ForeColor = Color.Red
        ElseIf f1_deudor.SelectedIndex = 1 Then
            f1_deudor.ForeColor = Color.Green
        End If
    End Sub
    '--------------------------
    Private Sub mostrar_filtro1b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrar_f1b.CheckedChanged
        With mostrar_f1b
            f1b_deuda_total.Enabled = .Checked
            f1b_minimo.Visible = .Checked
            et_desde.Visible = .Checked
            et_hasta.Visible = .Checked
            f1b_maximo.Visible = .Checked
            f1b_deuda_total.SelectedIndex = 0
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
        ElseIf f1b_deuda_total.SelectedIndex = 0 Then
            f1b_maximo.Enabled = False
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
            f2_año_maximo.Enabled = .Checked
            grupo_cuotas.Visible = .Checked
            f2_cuotas_todo.Checked = True
        End With
    End Sub
    '--------------------------
    Private Sub mostrar_filtro3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrar_f3.CheckedChanged
        With mostrar_f3
            f3_campo.Enabled = .Checked
            '--------------------------------
            f3_clave.Enabled = .Checked
        End With
    End Sub
    '--------------------------
    '## RUTINAS
    Private Sub reset_impuesto()
        '## RESET GENERAL
        'reset_campo(grupo_imp)
        mostrar_f1.Checked = False
        f1_deudor.SelectedIndex = -1
        mostrar_f1b.Checked = False

        mostrar_f2.Checked = False
        f2_año_minimo.Value = Today.Year
        f2_año_maximo.Value = Today.Year

        mostrar_f3.Checked = False
        f3_campo.SelectedIndex = -1

    End Sub

    '--------------------------
    '## RUTINAS DE LIMPIEZA
    '###### FIN GUI #############################################################################################
    '------------------------------------------------------------------------------------------------------------
    '###### FILTER ##############################################################################################
    '#### FILTROS AUTOMATICOS ################################
    '### IMPUESTOS
    Private Sub filtro2_año1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles f2_año_minimo.ValueChanged
        If f2_año_minimo.Value > f2_año_maximo.Value And f2_año_maximo.Enabled = True Then
            f2_año_minimo.Value -= 1
        End If
        vence1.Text = "No hay datos"
        vence2.Text = "No hay datos"
        vence3.Text = "No hay datos"
        vence4.Text = "No hay datos"
        vence5.Text = "No hay datos"
        vence6.Text = "No hay datos"
        dtab_vence = Vencimientos.Listar(f2_año_minimo.Value, f2_año_maximo.Value, mostrar_f2.Checked)
        If dtab_vence Is Nothing = False Then
            If dtab_vence.Rows.Count > 0 Then
                vence1.Text = Convert.ToString(dtab_vence(0)("vence1"))
                vence2.Text = Convert.ToString(dtab_vence(0)("vence2"))
                vence3.Text = Convert.ToString(dtab_vence(0)("vence3"))
                vence4.Text = Convert.ToString(dtab_vence(0)("vence4"))
                vence5.Text = Convert.ToString(dtab_vence(0)("vence5"))
                vence6.Text = Convert.ToString(dtab_vence(0)("vence6"))
            End If
        End If
    End Sub
    Private Sub filtro2_año2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles f2_año_maximo.ValueChanged
        If f2_año_minimo.Value > f2_año_maximo.Value Then
            f2_año_maximo.Value += 1
        End If
        dtab_vence = Vencimientos.Listar(f2_año_minimo.Value, f2_año_maximo.Value, mostrar_f2.Checked)
        If dtab_vence.Rows.Count > 0 Then
            vence1.Text = Convert.ToString(dtab_vence(0)("vence1"))
            vence2.Text = Convert.ToString(dtab_vence(0)("vence2"))
            vence3.Text = Convert.ToString(dtab_vence(0)("vence3"))
            vence4.Text = Convert.ToString(dtab_vence(0)("vence4"))
            vence5.Text = Convert.ToString(dtab_vence(0)("vence5"))
            vence6.Text = Convert.ToString(dtab_vence(0)("vence6"))
        Else
            vence1.Text = "No hay datos"
            vence2.Text = "No hay datos"
            vence3.Text = "No hay datos"
            vence4.Text = "No hay datos"
            vence5.Text = "No hay datos"
            vence6.Text = "No hay datos"
        End If
    End Sub
    '### CUENTA AGRUPADA

    '#### FILTROS MANUALES ################################
    Private Sub bs_consulta_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_consulta.CurrentChanged
        With bs_consulta
            If .Position >= 0 Then
                If grupo_imp.Visible And mostrar_f1b.Checked = False Then
                    info.Text = "Deuda Total:"
                    'Deuda total desde $1 usando código de la fila seleccionada del impuesto seleccionado
                    dtab_deto = deuda(True, False, f1_impuesto.Text, 0, .Current("codigo"), 0, 1, 0)
                    If dtab_deto.Rows.Count > 0 Then
                        info2.Text = "$ " & dtab_deto(0)("deuda")
                    End If
                End If
            Else
                info.Text = ""
                info2.Text = ""
            End If
        End With
    End Sub
    Private Sub leer(ByVal keyword As String, ByVal sender As Object)
        progreso.Value = 0
        visor.DataSource = Nothing
        bs_consulta.DataSource = Nothing
        '### IMPUESTOS
        If sender Is imp_search Then
            If mostrar_f1b.Checked = False Then
                dtab_imp = deuda(False, False, f1_impuesto.Text, f3_campo.SelectedIndex, keyword, f1b_deuda_total.SelectedIndex, f1b_minimo.Value, f1b_maximo.Value) 'Consulta básica de impuesto específico sobre Fox
                visor = Query.Show(visor, bs_consulta, dtab_imp)
            Else 'Consulta especial que muestra deudas totales
                dtab_deto = deuda(True, False, f1_impuesto.Text, f3_campo.SelectedIndex, keyword, f1b_deuda_total.SelectedIndex, f1b_minimo.Value, f1b_maximo.Value) 'Se debe calcular cada vez que se realizan cambios en la bd
                progreso.Value = 10
                visor = Query.Show(visor, bs_consulta, dtab_deto)
            End If
        ElseIf sender Is bs_consulta And grupo_imp.Visible Then

            '### CUENTA AGRUPADA
        ElseIf sender Is bs_contrib Then 'Esta consulta muestra un id de cuenta desglosado en el datagridview de la izquierda
            tablas_fox(bs_contrib.Current("impuesto"))
            dtab_imp = deuda(False, True, bs_contrib.Current("impuesto"), 2, keyword, 0, 0, 0) 'filtrado por nombre
            visor = Query.Show(visor, bs_consulta, dtab_imp)
        End If
        visor.Focus()
    End Sub

    Function deuda(ByVal deuda_total As Boolean, ByVal cuenta_agrupada As Boolean, ByVal impuesto As String, ByVal filter As Integer, ByVal keyword As String, ByVal range As Integer, ByVal dmin As Integer, ByVal dmax As Integer)
        progreso.Value = 5
        Dim consulta As New DataTable
        '### Crear consulta sin filtros
        Dim sql As String = "SELECT " & ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon,"

        If deuda_total Then
            sql += " SUM(" & col_importe & ") as deuda"
        Else  'Deuda detallada (Normal)
            sql += col_importe & " as original, " & col_pagado & " as pagado, " & col_vence & " as vencimiento, " & col_periodo & " as periodo "
        End If
        sql += " FROM " & ext_cuenta & " INNER JOIN " & ext_persona & " ON " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"
        'Con interés de 1% diario
        'sel_sql += ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon, " & importe & " as original, " & _
        '           "ROUND((" & importe & " + (" & importe & " * ((DATE() - " & vence & ") * 0.01))), 2) as deuda, " & _
        '         vence & " as vencimiento, " & periodo & " as periodo FROM " & ext_cuenta & _
        '        " INNER JOIN " & ext_persona & " ON " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"

        '### Hay otros filtros activos?

        If cuenta_agrupada = False Then
            If mostrar_f1.Checked Or mostrar_f2.Checked Or mostrar_f3.Checked Then
                sql += " WHERE " & col_vence & "<DATE() AND"

                '### Opción deudor/sin deuda
                If mostrar_f1.Checked Then
                    If f1_deudor.SelectedIndex = 0 Then
                        sql += " " & col_pagado & "=0 AND"
                    Else
                        sql += " " & col_pagado & "=>" & col_importe & " AND"
                    End If
                End If
                '### Rango de años o único año?
                If mostrar_f2.Checked Then
                    If f2_año_minimo.Value = f2_año_maximo.Value Then
                        sql += " " & col_periodo & "=" & f2_año_minimo.Value & " AND"
                    Else
                        sql += " " & col_periodo & "=>" & f2_año_minimo.Value & " AND " & col_periodo & "<=" & f2_año_maximo.Value & " AND"
                    End If
                    '### Hay cuotas seleccionadas?
                    'If cuota_vence > 0 Then
                    'sel_sql += " mes=" & cuota_vence & " AND"
                    'End If
                End If
                '### Valor específico?
                If keyword Is Nothing = False And mostrar_f3.Checked Then
                    If filter = 0 And Val(keyword) > 0 Then
                        sql += " " & ext_persona & ".codigo=" & Val(keyword) & " AND"
                    ElseIf filter = 1 And Val(keyword) > 999999 Then
                        sql += " documento=" & Val(keyword) & " AND"
                    ElseIf filter = 2 Then
                        sql += " " & ext_persona & ".razon LIKE '%" & keyword & "%'"
                        If impuesto.Contains("COME") = False Then
                            sql += " OR " & ext_persona & ".tenedor LIKE '%" & keyword & "%'"
                        End If
                        sql += " AND"
                    ElseIf filter = 3 And Val(keyword) > 0 Then
                        sql += " " & ext_persona & ".actividad=" & Val(keyword) & " AND"
                    End If
                End If

                'Borra el último AND antes de pasar a GROUP BY
                sql = Microsoft.VisualBasic.Left(sql, Len(sql) - 4)
            End If
            If deuda_total Then
                '### Límite mínimo y máximo de deuda total
                sql += " GROUP BY " & ext_persona & ".razon, " & ext_persona & ".codigo"
                If range = 2 Then 'Entre
                    sql += " HAVING SUM(" & col_importe & ")>" & Val(dmin) & " AND SUM(" & col_importe & ")<" & Val(dmax)
                ElseIf range = 1 Then          'Hasta
                    sql += " HAVING SUM(" & col_importe & ")<" & Val(dmax)
                ElseIf range = 0 Then          'Desde
                    sql += " HAVING SUM(" & col_importe & ")>" & Val(dmin)
                End If
            End If
            sql += " ORDER BY " & ext_persona & ".codigo"
        ElseIf cuenta_agrupada Then
            sql += " WHERE " & ext_persona & ".codigo=" & bs_contrib.Current("codigo")
        End If
        MsgBox(sql)
        consulta = bd.read(foxcon, sql)
        progreso.Value = 20
        Return consulta
    End Function

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_search.Click
        leer(f3_clave.Text, sender)
    End Sub

 
    '### EVENTOS DE LISTAS
    Private Sub imp_lista_mod_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Esto guarda los ID de los registros borrados para guardar los 
        'cambios correctamente después.
        If e.KeyCode = Keys.Delete Then
            With bs_mod_contrib
                If IsDBNull(.Current("id")) = False Then
                    del_rows(ndel) = .Current("id")
                    found = True
                    ndel += 1
                End If
            End With
        End If
    End Sub
    Private Sub bs_contrib_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_contrib.CurrentChanged
        If bs_contrib.Position > -1 Then
            leer(bs_contrib.Current("codigo"), bs_contrib)
        End If
    End Sub
    Private Sub imp_lista_con_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
   
    '----------------------
    '###### END FILTER ##########################################################################################

    '###### PRINT ###############################################################################################

    '###### END PRINT ###########################################################################################
End Class

