Module hac_contrib
    Function leer(ByVal sender As System.Object, cuil As Integer)
        Dim impuesto, importe, franqueo, adicional, pagado, vence As String
        Dim contrib, deuda_total As New DataTable
        adicional = ""
        franqueo = ""
		contrib = DbMan.read(  "SELECT id, impuesto, codigo, alta FROM contribuyente WHERE cuil=" & cuil)
		If contrib.Rows.Count > 0 And (sender Is ConsultaCuentaAgrupada.imp_lista_mod Or sender Is ConsultaCuentaAgrupada.con_ca) Then 'Consultas llevan deuda total incluida
            Dim fila As Integer = 0
			If contrib.Columns.Contains("deuda") Then
				contrib.Columns.Remove("deuda")
			End If
			contrib.Columns.Add("deuda")
			Do While fila < contrib.Rows.Count
                'Detectar impuesto
                impuesto = contrib(fila)("impuesto")
				If impuesto.Contains("AGUA") Then 'AGUA
                    ext_cuenta = config.agua_cuentas.Text
					importe = ext_cuenta & ".original"
					adicional = ""
					pagado = ext_cuenta & ".pagado"
					vence = ext_cuenta & ".vencio"
				ElseIf impuesto.Contains("AUTO") Then  'AUTO
                    ext_cuenta = config.auto_cuentas.Text
					importe = ext_cuenta & ".apagar"
					adicional = ext_cuenta & ".gastos"
					pagado = ext_cuenta & ".apagado"
					vence = ext_cuenta & ".vencimi1"
				ElseIf impuesto.Contains("CATA") Then 'CATA
                    ext_cuenta = config.cata_cuentas.Text
					importe = ext_cuenta & ".original"
					adicional = ext_cuenta & ".franqueo"
					pagado = ext_cuenta & ".pagado"
					vence = ext_cuenta & ".vencio"
				ElseIf impuesto.Contains("COME") Then 'COME
                    ext_cuenta = config.come_cuentas.Text
					importe = ext_cuenta & ".importe"
					adicional = ""
					pagado = ext_cuenta & ".pagado"
					vence = ext_cuenta & ".vence1"
				Else 'SEPE
                    ext_cuenta = config.sepe_cuentas.Text
					importe = ext_cuenta & ".original"
					adicional = ""
					pagado = ext_cuenta & ".pagado"
					vence = ext_cuenta & ".vencio"
				End If
                'Calcular deuda total del código y agregar
                Dim sql As String = "SELECT (SUM(" & pagado & ")"


                '## BUSCAR VARIABLES PARA CALCULAR CORRECTAMENTE LOS INTERESES Y RECARGOS
                '## COMBINAR ESTO CON DETO (básicamente son lo mismo duh)
                If adicional <> "" And franqueo <> "" Then
					sql += " -(SUM(" & importe & ") + SUM(" & adicional & ") + SUM(" & franqueo & ")))"
				ElseIf adicional <> "" Then
					sql += " -(SUM(" & importe & ") + SUM(" & adicional & ")))"
				Else
					sql += " - SUM(" & importe & "))"
				End If
				sql += " as deuda FROM " & ext_cuenta & " WHERE codigo=" & contrib(fila)("codigo")
				sql += " AND " & pagado & " < " & importe

                'Filtra desde la fecha de hoy hacia atrás
                sql += " AND " & vence & "<DATE()"
				deuda_total = DbMan.read(sql, My.Settings.foxcon)
				contrib(fila)("deuda") = deuda_total(0)("deuda")
                fila += 1
            Loop
        End If
        Return contrib
    End Function
End Module
