Sub deimp(ByVal keyword As String, ByVal impuesto As String, ByVal dmin As Integer, ByVal dmax As Integer)
  '### Cargar referencia de tablas
        tablas_fox(impuesto)
        '### Crear consulta sin filtros
		With hacienda
			sel_sql = "SELECT " & ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon,"
		
        If .mostrar_f1b.checked Then 'Deuda Total
            sel_sql += " SUM(" & col_importe & ") as deuda"
        Else                'Normal
            sel_sql += col_importe & " as original, " & col_pagado & " as pagado, " & col_vence & " as vencimiento, " & col_periodo & " as periodo "
        End If
			sel_sql += " FROM " & ext_cuenta & " INNER JOIN " & ext_persona & " ON " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"
		
			'Con interés de 1% diario
			'sel_sql += ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon, " & importe & " as original, " & _
			'           "ROUND((" & importe & " + (" & importe & " * ((DATE() - " & vence & ") * 0.01))), 2) as deuda, " & _
			'         vence & " as vencimiento, " & periodo & " as periodo FROM " & ext_cuenta & _
			'        " INNER JOIN " & ext_persona & " ON " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"

			'### Hay otros filtros activos?
        
            If .grupo_imp.Visible Then
                If .mostrar_filtro1.Checked = True Or .mostrar_filtro2.Checked = True Or .mostrar_filtro3.Checked = True Then
                    sel_sql += " WHERE " & col_vence & "<DATE() AND"

                    '### Opción deudor/sin deuda
                    If .mostrar_filtro1.Checked Then
                        If .filtro1_opcion1.SelectedIndex = 0 Then
                            sel_sql += " " & col_pagado & "=0 AND"
                        Else
                            sel_sql += " " & col_pagado & "=>" & col_importe & " AND"
                        End If
                    End If
                    '### Rango de años o único año?
                    If .mostrar_filtro2.Checked Then
                        If .filtro2_año1.Value = .filtro2_año2.Value Then
                            sel_sql += " " & col_periodo & "=" & .filtro2_año1.Value & " AND"
                        Else
                            sel_sql += " " & col_periodo & "=>" & .filtro2_año1.Value & " AND " & col_periodo & "<=" & .filtro2_año2.Value & " AND"
                        End If
                        '### Hay cuotas seleccionadas?
                        'If cuota_vence > 0 Then
                        'sel_sql += " mes=" & cuota_vence & " AND"
                        'End If
                    End If
                    '### Contribuyente específico?
                    If .mostrar_filtro3.Checked Then
                        If .filtro3_opcion.SelectedIndex = 0 Then
                            sel_sql += " " & ext_persona & ".razon LIKE '%" & keyword & "%' OR " & _
                                             ext_persona & ".tenedor LIKE '%" & keyword & "%' AND"
                        ElseIf .filtro3_opcion.SelectedIndex = 1 Then
                            sel_sql += " " & ext_persona & ".codigo=" & keyword & " AND"
                        ElseIf .filtro3_opcion.SelectedIndex = 2 And Len(keyword) >= 7 Then
                            sel_sql += " documento=" & keyword & " AND"
                        End If
                    End If
                    'Borra el último AND
                    sel_sql = Microsoft.VisualBasic.Left(sel_sql, Len(sel_sql) - 4)
                    sel_sql += " ORDER BY " & ext_persona & ".codigo"
                End If
				
				
            ElseIf .grupo_ca.Visible Then
                sel_sql += " WHERE " & ext_persona & ".codigo=" & .bs_contrib.Current("codigo")
            End If
			
        End With
        leer_bd(dtab_imp, config.con_fox.Text, sel_sql)
End Sub