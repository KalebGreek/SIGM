Class ConsultaImpuesto
    Overloads Shared Function ConsultarDeuda(ByVal impuesto As String, deudor As Boolean,
                               ByVal filtro_cuenta As Integer, ByVal keyword As String,
                               ByVal fecha As String, interes As String,
                               ByVal filtro_importe As Boolean, ByVal filtro_mora As Boolean,
                               ByVal deudamin As Integer, ByVal deudamax As Integer,
                               ByVal minyear As Integer, ByVal maxyear As Integer,
                               ByVal deuda_agrupada As Boolean, ByVal deuda_por_periodo As Boolean,
                               ByVal deuda_por_cuenta As Boolean, ByRef progreso As ToolStripProgressBar) As DataTable

        progreso.Value = 0
        Dim dtab_deuda As DataTable = GenerarSQL(impuesto, deudor, filtro_cuenta, keyword, fecha,
                                                 interes, filtro_importe, filtro_mora, deudamin,
                                                 deudamax, minyear, maxyear, deuda_agrupada,
                                                 deuda_por_periodo, deuda_por_cuenta, progreso) 'Consulta básica de impuesto específico sobre Fox
        progreso.Value = 20

        Return dtab_deuda
    End Function
    Overloads Shared Function ConsultarDeuda(ByVal impuesto As String, ByVal fecha As String, interes As String,
                                             ByVal deuda_por_periodo As Boolean, ByVal deuda_por_cuenta As Boolean,
                                             ByRef progreso As ToolStripProgressBar, cuenta_seleccionada As DataRowView) As DataTable

        'Deuda total desde $1 usando código de la fila seleccionada del impuesto seleccionado
        'No usa filtros, solo seleccion de impuesto y codigo
        progreso.Value = 0
        If cuenta_seleccionada Is Nothing = False Then
            Dim dtab_deuda As DataTable

            dtab_deuda = GenerarSQL(impuesto, True,
                                      0, cuenta_seleccionada("codigo"),
                                      fecha, interes,
                                      False, False, 1, 1,
                                      1898, Today.Year,
                                      True, deuda_por_periodo, deuda_por_cuenta,
                                      progreso)
            progreso.Value = 20
            Return dtab_deuda
        Else
            Return Nothing
        End If
    End Function
    Shared Function GenerarSQL(ByVal impuesto As String, deudor As Boolean,
                      ByVal filtro_cuenta As Integer, ByVal keyword As String,
                       ByVal fecha As String, interes As String,
                       ByVal filtro_importe As Boolean, ByVal filtro_mora As Boolean,
                       ByVal deudamin As Integer, ByVal deudamax As Integer,
                       ByVal minyear As Integer, ByVal maxyear As Integer,
                       ByVal deuda_agrupada As Boolean, ByVal deuda_por_periodo As Boolean,
                       ByVal deuda_por_cuenta As Boolean, ByRef progreso As ToolStripProgressBar) As DataTable



        progreso.Value = 5
        'Columnas calculadas
        interes = interes.Replace(",", ".") 'Evita error en consulta
        Dim columna_mora As String = " ROUND((" & col_importe & " * ((DATE() - " & col_vence & ") * " & interes & ")), 2)"

        Dim consulta As New DataTable
        '### Crear consulta
        Dim sql(5) As String
        sql(0) = "SELECT " & ext_persona & ".codigo As codigo, " & ext_persona & ".razon As razon,"
        sql(1) = " FROM " & ext_cuenta & " INNER JOIN " & ext_persona & " On " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"
        sql(5) = " ORDER BY " & ext_persona & ".codigo"

        If deuda_agrupada Then
            'Original | Mora (1% diario) | Neto
            'Deuda agrupada por cuentas
            sql(0) += " SUM(" & col_importe & ") As original, SUM(" & columna_mora & ") As mora,
                           SUM(" & col_importe & " +" & columna_mora & ") as total"

        Else
            'Deuda detallada por cuenta y cuota individual
            sql(0) += col_importe & " as original, " & columna_mora & " as mora,
                        (" & col_importe & " + " & columna_mora & ") as total,
                         " & col_pagado & " AS pagado, " & col_vence & " AS vencimiento, " & col_periodo & " AS periodo "
        End If

        '### Hay otros filtros activos?
        If impuesto <> "" Or deuda_por_periodo Or deuda_por_cuenta Then
            sql(2) += " WHERE " & col_vence & "< {" & fecha & "} AND"

            '### Opción deudor/sin deuda
            If deudor Then
                sql(2) += " " & col_pagado & "=0 And"
            Else
                sql(2) += " " & col_pagado & "=>" & col_importe & " And"
            End If
            '### Rango de años o único año?
            If deuda_por_periodo Then
                If minyear = maxyear Then
                    sql(2) += " " & col_periodo & "=" & minyear & " And"
                Else
                    sql(2) += " " & col_periodo & "=>" & minyear & " And " & col_periodo & "<=" & maxyear & " And"
                End If
                '### Hay cuotas seleccionadas?
                'If cuota_vence > 0 Then
                'sel_sql += " mes=" & cuota_vence & " And"
                'End If
            End If
            '### Valor específico?
            If (keyword Is Nothing = False And deuda_por_cuenta) Or deuda_agrupada Then
                If filtro_cuenta = 0 And Val(keyword) > 0 Then
                    sql(2) += " " & ext_persona & ".codigo=" & Val(keyword) & " AND"
                ElseIf filtro_cuenta = 1 And Val(keyword) > 999999 Then
                    sql(2) += " documento=" & Val(keyword) & " And"
                ElseIf filtro_cuenta = 2 Then
                    sql(2) += " " & ext_persona & ".razon LIKE '%" & keyword & "%'"
                    If impuesto.Contains("COME") = False Then
                        sql(2) += " OR " & ext_persona & ".tenedor LIKE '%" & keyword & "%'"
                    End If
                    sql(2) += " AND"
                ElseIf filtro_cuenta = 3 And Val(keyword) > 0 Then
                    sql(2) += " " & ext_persona & ".actividad=" & Val(keyword) & " AND"
                End If
            End If

            'Borra el último AND antes de pasar a GROUP BY
            sql(2) = Microsoft.VisualBasic.Left(sql(2), Len(sql(2)) - 4)
        End If



        If deuda_agrupada Then
            '### Límite mínimo y máximo de deuda total
            sql(3) = " GROUP BY " & ext_persona & " .codigo, " & ext_persona & ".razon "

            If filtro_mora Then
                sql(4) = " HAVING SUM(" & columna_mora & ")"
            ElseIf filtro_importe Then
                sql(4) = " HAVING SUM(" & col_importe & ")"
            Else 'Total
                sql(4) = " HAVING SUM(" & col_importe & " +" & columna_mora & ")"
            End If

            If deudamax > deudamin Then
                If deudamin = 0 Then            'Hasta
                    sql(4) = sql(4) & " <" & Val(deudamax)
                Else                            'Entre
                    sql(4) = sql(4) & " >" & Val(deudamin) & " AND " &
                    Microsoft.VisualBasic.Right(sql(4), Len(sql(4)) - 7) & "<" & Val(deudamax)
                End If
            ElseIf deudamin = deudamax Then     'Desde
                sql(4) = sql(4) & " >" & Val(deudamin)
            End If
        End If

        'MsgBox(SQLSelect & SQLTable & SQLWhere)
        progreso.Value = 10
        Return DbMan.ReadDB(sql, My.Settings.foxConnection)
    End Function
End Class
