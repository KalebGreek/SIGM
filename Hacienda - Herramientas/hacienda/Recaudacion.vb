Public Class Recaudacion
	Shared Function ConsultarDeuda(ByVal impuesto As String, deudor As Boolean,
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
        Dim SQLSelect As String = "SELECT " & ext_persona & ".codigo As codigo, " & ext_persona & ".razon As razon,"
		Dim SQLTable As String = " FROM " & ext_cuenta & " INNER JOIN " & ext_persona & " On " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"
		Dim SQLWhere As String = ""
		Dim SQLGroup As String = ""
		Dim SQLHaving As String = ""
		Dim SQLOrder As String = " ORDER BY " & ext_persona & ".codigo"

		If deuda_agrupada Then
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
        If impuesto <> "" Or deuda_por_periodo Or deuda_por_cuenta Then
			SQLWhere += " WHERE " & col_vence & "< {" & fecha & "} AND"

            '### Opción deudor/sin deuda
            If deudor Then
				SQLWhere += " " & col_pagado & "=0 And"
			Else
				SQLWhere += " " & col_pagado & "=>" & col_importe & " And"
			End If
            '### Rango de años o único año?
            If deuda_por_periodo Then
				If minyear = maxyear Then
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
            If (keyword Is Nothing = False And deuda_por_cuenta) Or deuda_agrupada Then
				If filtro_cuenta = 0 And Val(keyword) > 0 Then
					SQLWhere += " " & ext_persona & ".codigo=" & Val(keyword) & " And"
				ElseIf filtro_cuenta = 1 And Val(keyword) > 999999 Then
					SQLWhere += " documento=" & Val(keyword) & " And"
				ElseIf filtro_cuenta = 2 Then
					SQLWhere += " " & ext_persona & ".razon Like '%" & keyword & "%'"
					If impuesto.Contains("COME") = False Then
						SQLWhere += " OR " & ext_persona & ".tenedor LIKE '%" & keyword & "%'"
					End If
					SQLWhere += " AND"
				ElseIf filtro_cuenta = 3 And Val(keyword) > 0 Then
					SQLWhere += " " & ext_persona & ".actividad=" & Val(keyword) & " AND"
				End If
			End If

            'Borra el último AND antes de pasar a GROUP BY
            SQLWhere = Microsoft.VisualBasic.Left(SQLWhere, Len(SQLWhere) - 4)
		End If



		If deuda_agrupada Then
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
End Class
