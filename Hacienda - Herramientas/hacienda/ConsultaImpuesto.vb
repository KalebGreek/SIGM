Public Class ConsultaImpuesto
    '###### VARIABLES #######################################################################################
    Dim cuota_vence As Integer
    Dim dtab_imp, dtab_cuenta, dtab_vence, dtab_deto As New DataTable
    Public dtab_contrib, dtab_mod_contrib As New DataTable
    Dim found As Boolean
    '###### FIN VARIABLES ###################################################################################
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
                f1_deudor.Enabled = True
            Else
                reset_impuesto()
            End If
        End With
    End Sub
    '--------------------------
    Private Sub mostrar_filtro1b_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrar_f1b.CheckedChanged
        With mostrar_f1b
            grupo_deuda_total.Enabled = .Checked
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
    '#### TOTALES DE CONSULTA Y OTROS ################################
    Private Sub bs_consulta_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_consulta.CurrentChanged
        With bs_consulta
            If .Position >= 0 Then
                If grupo_imp.Visible And mostrar_f1b.Checked = False Then
                    info.Text = "Deuda Total:"
                    'Deuda total desde $1 usando código de la fila seleccionada del impuesto seleccionado
                    'No usa filtros, solo seleccion de impuesto y codigo
                    dtab_deto = deuda(True, f1_impuesto.Text, True,
                                      0, .Current("codigo"),
                                      Format(fecha.Value.Date, "MM/dd/yyyy"), interes.Value / 100,
                                      False, False, 1, 1,
                                      1898, Today.Year)
                    If dtab_deto.Rows.Count > 0 Then
                        info2.Text = "Deuda original: $" & dtab_deto(0)("original") &
                                     " | Mora: $" & dtab_deto(0)("mora") &
                                     " | Total: $" & dtab_deto(0)("total")
                    End If
                    progreso.Value = 20
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
        If sender Is imp_search Then
            dtab_imp = deuda(mostrar_f1b.Checked, f1_impuesto.Text, f1_Deudor.Checked,
                             f3_campo.SelectedIndex, keyword,
                             Format(fecha.Value.Date, "MM/dd/yyyy"), interes.Value / 100,
                             f1b_importe.Checked, f1b_mora.Checked, f1b_minimo.Value, f1b_maximo.Value,
                             f2_año_minimo.Value, f2_año_maximo.Value) 'Consulta básica de impuesto específico sobre Fox
            visor = CtrlMan.LoadDataGridView(visor, bs_consulta, dtab_imp)
			progreso.Value = 20
        ElseIf sender Is bs_consulta And grupo_imp.Visible Then
            'Filtros automaticos
        End If
        visor.Focus()
    End Sub

    Function deuda(ByVal deuda_total As Boolean, ByVal impuesto As String, deudor As Boolean,
                   ByVal filter As Integer, ByVal keyword As String,
                   ByVal fecha As String, interes As String,
                   ByVal filtro_importe As Boolean, ByVal filtro_mora As Boolean,
                   ByVal deudamin As Integer, ByVal deudamax As Integer,
                   ByVal minyear As Integer, maxyear As Integer)



        progreso.Value = 5
        'Columnas calculadas
        interes = interes.Replace(",", ".") 'Evita error en consulta
        Dim columna_mora As String = " ROUND((" & col_importe & " * ((DATE() - " & col_vence & ") * " & interes & ")), 2)"

        Dim consulta As New DataTable
        '### Crear consulta
        Dim SQLSelect As String = "SELECT " & ext_persona & ".codigo As codigo, " & ext_persona & ".razon As razon,"
        Dim SQLTable As String = " FROM " & ext_cuenta & " INNER JOIN " & ext_persona & " On " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"
        Dim SQLWhere As String = ""
        Dim SQLGroup As String = ""
        Dim SQLHaving As String = ""
        Dim SQLOrder As String = " ORDER BY " & ext_persona & ".codigo"

        If deuda_total Then
            'Original | Mora (1% diario) | Neto
            'Deuda agrupada por cuentas
            SQLSelect += " SUM(" & col_importe & ") As original, SUM(" & columna_mora & ") As mora,
                           SUM(" & col_importe & " +" & columna_mora & ") as total"

        Else
            'Deuda detallada por cuenta y cuota individual
            SQLSelect += col_importe & " as original, " & columna_mora & " as mora,
                        (" & col_importe & " + " & columna_mora & ") as total,
                         " & col_pagado & " AS pagado, " & col_vence & " AS vencimiento, " & col_periodo & " AS periodo "
        End If

        '### Hay otros filtros activos?
        If impuesto <> "" Or mostrar_f2.Checked Or mostrar_f3.Checked Then
            SQLWhere += " WHERE " & col_vence & "< {" & fecha & "} AND"

            '### Opción deudor/sin deuda
            If deudor Then
                SQLWhere += " " & col_pagado & "=0 And"
            Else
                SQLWhere += " " & col_pagado & "=>" & col_importe & " And"
            End If
            '### Rango de años o único año?
            If mostrar_f2.Checked Then
                If f2_año_minimo.Value = f2_año_maximo.Value Then
                    SQLWhere += " " & col_periodo & "=" & minyear & " And"
                Else
                    SQLWhere += " " & col_periodo & "=>" & minyear & " And " & col_periodo & "<=" & maxyear & " And"
                End If
                '### Hay cuotas seleccionadas?
                'If cuota_vence > 0 Then
                'sel_sql += " mes=" & cuota_vence & " And"
                'End If
            End If
            '### Valor específico?
            If (keyword Is Nothing = False And mostrar_f3.Checked) Or deuda_total Then
                If filter = 0 And Val(keyword) > 0 Then
                    SQLWhere += " " & ext_persona & ".codigo=" & Val(keyword) & " And"
                ElseIf filter = 1 And Val(keyword) > 999999 Then
                    SQLWhere += " documento=" & Val(keyword) & " And"
                ElseIf filter = 2 Then
                    SQLWhere += " " & ext_persona & ".razon Like '%" & keyword & "%'"
                    If impuesto.Contains("COME") = False Then
                        SQLWhere += " OR " & ext_persona & ".tenedor LIKE '%" & keyword & "%'"
                    End If
                    SQLWhere += " AND"
                ElseIf filter = 3 And Val(keyword) > 0 Then
                    SQLWhere += " " & ext_persona & ".actividad=" & Val(keyword) & " AND"
                End If
            End If

            'Borra el último AND antes de pasar a GROUP BY
            SQLWhere = Microsoft.VisualBasic.Left(SQLWhere, Len(SQLWhere) - 4)
        End If



        If deuda_total Then
            '### Límite mínimo y máximo de deuda total
            SQLGroup = " GROUP BY " & ext_persona & " .codigo, " & ext_persona & ".razon "

            SQLHaving = ""
            If filtro_mora Then
                SQLHaving = " HAVING SUM(" & columna_mora & ")"
            ElseIf filtro_importe Then
                SQLHaving = " HAVING SUM(" & col_importe & ")"
            Else 'Total
                SQLHaving = " HAVING SUM(" & col_importe & " +" & columna_mora & ")"
            End If

            If deudamax > deudamin Then
                If deudamin = 0 Then            'Hasta
                    SQLHaving = SQLHaving & " <" & Val(deudamax)
                Else                            'Entre
                    SQLHaving = SQLHaving & " >" & Val(deudamin) & " AND " &
                    Microsoft.VisualBasic.Right(SQLHaving, Len(SQLHaving) - 7) & "<" & Val(deudamax)
                End If
            ElseIf deudamin = deudamax Then     'Desde
                SQLHaving = SQLHaving & " >" & Val(deudamin)
            End If
        End If

        'MsgBox(SQLSelect & SQLTable & SQLWhere)
        consulta = DbMan.read(SQLSelect & SQLTable & SQLWhere & SQLGroup & SQLHaving & SQLOrder, My.Settings.foxcon)
		progreso.Value = 10
        Return consulta
    End Function

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_search.Click
        If f1_impuesto.SelectedIndex > -1 Then
            leer(f3_clave.Text, sender)
        End If
    End Sub


    '----------------------
    '###### END FILTER ##########################################################################################

    '###### PRINT ###############################################################################################

    '###### END PRINT ###########################################################################################
End Class

