Class CalcAnualImp
	Shared Sub CheckProgress(ByRef info As Label, ByRef progreso As ToolStripProgressBar, fila As Integer, cuenta As Integer, total_cuotas As Integer, cuentas_modificadas As Integer)
		If fila > 0 And cuenta > 0 Then
			If progreso.Value = progreso.Maximum Then
				progreso.Value = progreso.Minimum
				info.Text = progreso.Maximum & " cuentas procesadas, " & total_cuotas & " cuotas en " & cuentas_modificadas & " cuentas."
			Else
				progreso.Value = fila
				info.Text = "Procesando cuenta Nro. " & cuenta
			End If
		Else
			info.Text = "Esperando datos."
		End If
		info.Refresh()
	End Sub
	Public Class Sql
		Public Class Agua
			Shared Sub CalcularCuota(bs_variables As BindingSource, CuentaInicial As Integer, periodo As Integer, ByRef info As Label, ByRef progreso As ToolStripProgressBar)
				Dim var As DataRowView = bs_variables.Current
				Dim dtab(3) As DataTable
				Dim sqlInsertList(0) As String
				Dim sql(0) As String
				Dim cuentas_modificadas, total_cuotas As Integer

				'Tablas: Zonas, Vence, Cuentas,  Deudas
				Agua.CargarTablas(dtab, periodo, CuentaInicial)

				'Iniciar busqueda y reemplazo
				progreso.Maximum = dtab(2).Rows.Count - 1

				For Each dr As DataRow In dtab(2).Rows

					Dim reside, comercio, industria, excedente, original, importe, franqueo As New Decimal
					Dim cuota, cuota_max As New Integer
					Dim cuota_mod As New Integer
					Dim tipo As Integer = dr("tipo")
					Dim cantidad As Integer = dr("cantidad")


					'Solo se puede generar deduda anual sobre usuarios sin medidor
					If tipo <> 2 Or tipo <> 5 Then
						'Residencial
						If tipo = 1 Then
							original = dtab(0)(0)("importe")
							excedente = dtab(0)(1)("excedente")
							If cantidad > 1 Then
								reside = original * ((1 + (CInt(excedente / 100) * cantidad)))
							Else
								reside = original
							End If
							'Comercial
						ElseIf tipo = 3 Then
							comercio = dtab(0)(2)("importe")
						ElseIf tipo = 4 Then
							comercio = dtab(0)(3)("importe")
							'Industrial
						ElseIf tipo = 6 Then
							industria = dtab(0)(5)("importe")
						End If
						importe = reside + comercio + industria

						franqueo = 0

						'Ingresar cuotas
						cuota_max = 6
						cuota = 1
						Do While cuota <= cuota_max
							If VerificarCuota(dr, cuota, periodo, dtab(3)) Then
								'No existente
								cuota_mod += 1
								ReDim Preserve sqlInsertList(total_cuotas)
								sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Agua.InsertarCuota(dr, cuota, periodo, importe, dtab(1)(0),
																		reside, comercio, industria, franqueo)
								total_cuotas += 1
							End If
							cuota += 1
						Loop

						If cuota_mod > 0 Then
							cuentas_modificadas += 1
						End If
					Else
						'Usuario con medidor: se genera la deuda cada dos meses basada en las lecturas
					End If
					CheckProgress(info, progreso, dtab(2).Rows.IndexOf(dr), CInt(dr("codigo")), total_cuotas, cuentas_modificadas)
				Next
				If total_cuotas > 0 Then
					DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
				End If
			End Sub
			Shared Function CargarTablas(dtab As DataTable(), periodo As Integer, CuentaInicial As Integer) As DataTable()
				Dim sql(0) As String

				If dtab Is Nothing = False Then
					'Zonas
					dtab(0) = DbMan.ReadDB("SELECT * FROM aguzona ORDER BY tipo", My.Settings.foxConnection)

					'Vencimientos
					dtab(1) = DbMan.ReadDB("SELECT * FROM aguvence WHERE periodo=" & periodo,
										   My.Settings.foxConnection)

					'Cuentas
					dtab(2) = DbMan.ReadDB("SELECT codigo, tipo, cantidad
											  FROM aguas WHERE codigo=>" & CuentaInicial & " 
										  ORDER BY codigo",
										   My.Settings.foxConnection)

					'Deudas
					dtab(3) = DbMan.ReadDB("SELECT * FROM agucue 
											 WHERE codigo=>" & CuentaInicial & " AND periodo=" & periodo & "
										  ORDER BY codigo",
										   My.Settings.foxConnection)
				End If
				Return dtab
			End Function
			Shared Function VerificarCuota(cuentas As DataRow, cuota As Integer, periodo As Integer,
											deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & cuentas("codigo").ToString & " And agrupado='' AND mes=" & cuota.ToString & " 
															  And periodo=" & periodo.ToString)

				Return result.Length = 0
			End Function
			Shared Function InsertarCuota(registro As DataRow, cuota As Integer, periodo As Integer, importe As Decimal,
									  vence As DataRow, reside As Decimal, comercio As Decimal, industria As Decimal, franqueo As Decimal) As String

				Return "INSERT INTO agucue(tipo, mes, agrupado, periodo, codigo, cedulon,
                                                importe, original, vencio, pagado, pago,
                                                reside, comercio, industria, contado, franqueo, link)
										VALUES('N', " & cuota.ToString & ", '', " & periodo.ToString & ", " & registro("codigo").ToString & ", 0,
												" & importe.ToString & ", " & importe.ToString & ", {" & vence("vence" & cuota).ToString & "}, 0, {},
												" & reside.ToString & ", " & comercio.ToString & ", " & industria.ToString & ", 0, " & franqueo.ToString & ", '')"
			End Function
		End Class
		Public Class Auto
			Shared Sub CalcularCuota(bs_variables As BindingSource, CuentaInicial As Integer, periodo As Integer, ByRef info As Label, ByRef progreso As ToolStripProgressBar)
				Dim var As DataRowView = bs_variables.Current
				Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
				Dim sqlInsertList(0) As String
				Dim sql(0) As String
				Dim cuentas_modificadas, total_cuotas As Integer

				'Vencimientos
				dtab_vence = DbMan.ReadDB("SELECT * FROM autovence
								           WHERE periodo=" & periodo,
										  My.Settings.foxConnection)

				'Cuentas
				dtab_cuenta = DbMan.ReadDB("SELECT codigo, razon, marca, modelo, apagar FROM automovil
								     WHERE apagar>0 AND baja={} AND codigo=>" & CuentaInicial & " 
                                  ORDER BY codigo",
										   My.Settings.foxConnection)

				dtab_deuda = DbMan.ReadDB("SELECT * FROM autocue", My.Settings.foxConnection)

				progreso.Maximum = dtab_cuenta.Rows.Count - 1

				For Each dr As DataRow In dtab_cuenta.Rows
					Dim importe As New Decimal
					Dim cuota As New Integer
					Dim cuota_max As New Integer
					Dim cuota_mod As New Integer

					importe = dr("apagar")
					cuota = 1
					cuota_max = 4
					Do While cuota <= cuota_max
						If CalcAnualImp.Sql.Auto.VerificarCuota(dr, cuota, periodo, dtab_deuda) Then
							cuota_mod += 1
							ReDim Preserve sqlInsertList(total_cuotas)
							sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Auto.InsertarCuota(dr, cuota, periodo, importe, dtab_vence(0))
							total_cuotas += 1
						End If
						cuota += 1
					Loop
					If cuota_mod > 0 Then
						cuentas_modificadas += 1
					End If
					cuota_mod = 0
					CheckProgress(info, progreso, dtab_cuenta.Rows.IndexOf(dr), dr("codigo"), total_cuotas, cuentas_modificadas)
				Next

				If total_cuotas > 0 Then
					DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
				End If
			End Sub
			Shared Function VerificarCuota(registro As DataRow, cuota As Integer, periodo As Integer,
											deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & registro("codigo").ToString & " And moratoria='N' AND cuota=" & cuota.ToString & " 
															  And ano=" & periodo.ToString)

				Return result.Any = 0
			End Function
			Shared Function InsertarCuota(registro As DataRow, cuota As Integer, periodo As Integer,
									 importe As Decimal, vence As DataRow) As String
				Return "INSERT INTO autocue(cedulon, cuota, ano, moratoria, codigo, razon,
															marca, modelo, apagar, gastos, total, total1,
															total2, vencimi1, vencimi2, vencimi3, apagado, fecha, link)
													VALUES(0, " & cuota.ToString & ", " & periodo.ToString & ", 'N', " & registro("codigo").ToString & ",
															'" & Trim(registro("razon").ToString) & "', '" & Trim(registro("marca").ToString) & "',
															" & registro("modelo").ToString & ", " & importe.ToString & ", 0, " & importe.ToString & ",
															" & importe.ToString & ", " & importe.ToString & ", {" & vence("vence" & cuota).ToString & "}, {}, {}, 0, {}, '')"
			End Function
		End Class
		Public Class Catastro
			Shared Function CargarTablas(dtab As DataTable(), periodo As Integer, CuentaInicial As Integer) As DataTable()
				Dim sqlSelect As String

				'Vencimientos
				dtab(0) = DbMan.ReadDB("SELECT * FROM catvence WHERE periodo=" & periodo, My.Settings.foxConnection)

				'Cuentas
				sqlSelect = "SELECT catastro.codigo As codigo, catastro.jubilado As jubilado,
								catastro.baldio As baldio, catastro.pasillo As pasillo,
								catastro.agrario As agrario, catastro.comercial as comercial,
								catastro.vereda as vereda, catastro.parque as parque,
								catastro.esquino as esquino, catastro.zona1 as zona,
								catastro.frente1 As frente1, catastro.frente2 As frente2,
								catastro.frente3 As frente3, catastro.frente4 As frente4,
								catzona.minimo As monto_minimo, catzona.unidad As monto_unidad,
								catzona.fijo1 as monto_fijo1, catzona.fijo2 as monto_fijo2,
								catzona.fijo3 as monto_fijo3, catzona.fijo4 as monto_fijo4,
								catzona.jubilado1 As desc_jubilado1, catzona.jubilado2 As desc_jubilado2,
								catzona.baldio As rec_baldio, catzona.pasillo As monto_pasillo,
								catzona.agrario1 As desc_agrario1, catzona.agrario2 As desc_agrario2,
								catzona.comercio1 as rec_comercio1, catzona.comercio2 as rec_comercio2,
								catzona.comercio3 as rec_comercio3, catzona.comercio4 as rec_comercio4,
								catzona.vereda as desc_vereda, catzona.parque as desc_parque,
								catzona.alumbrado_minimo, catzona.alumbrado_basico"

				sqlSelect &= " FROM catastro JOIN catzona On catastro.zona1=catzona.zona"
				sqlSelect &= " WHERE catastro.codigo=>" & CuentaInicial & " ORDER BY catastro.codigo"

				dtab(1) = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

				sqlSelect = "SELECT codigo, agrupado, mes, periodo"
				sqlSelect &= " FROM catcue"
				sqlSelect &= " WHERE codigo=>" & CuentaInicial & " AND periodo=" & periodo & " AND agrupado=''"
				dtab(2) = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

				Return dtab
			End Function
			Shared Sub CalcularCuota(bs_variables As BindingSource, CuentaInicial As Integer, periodo As Integer, ByRef info As Label, ByRef progreso As ToolStripProgressBar)
				'Dim dtab_vence, dtab_cuenta, dtab_deuda As DataTable
				Dim variables As DataRowView = bs_variables.Current
				Dim cuota, cuota_max As Integer
				Dim sql(2) As String
				Dim dtab(2) As DataTable
				Dim sqlInsertList(0) As String
				dtab = CalcAnualImp.Sql.Catastro.CargarTablas(dtab, periodo, CuentaInicial)
				Dim cuentas_modificadas, total_cuotas As Integer

				progreso.Maximum = dtab(1).Rows.Count - 1

				For Each dr As DataRow In dtab(1).Rows

					Dim monto_minimo, monto_unidad, monto_pasillo, basica, rec_baldio, monto_baldio,
						alumbrado_minimo, alumbrado_basico, monto_alumbrado, monto_agrario, monto_comercio,
						desc_vereda, monto_vereda, desc_parque, monto_parque, desc_agrario1, desc_agrario2,
						desc_jubilado1, desc_jubilado2, monto_jubilado, var_taecat, monto_taecat, monto_franqueo, importe, subtotal As New Decimal

					Dim zona, esquino, comercial As Integer
					Dim pasillo As Boolean = (CInt(dr("pasillo")) = 1)
					Dim baldio As Boolean = (CInt(dr("baldio")) = 1)
					Dim vereda As Boolean = (CInt(dr("vereda")) = 1)
					Dim parque As Boolean = (CInt(dr("parque")) = 1)
					comercial = dr("comercial")
					Dim agrario As Boolean = (CInt(dr("agrario")) = 1)
					Dim jubilado As Boolean = (CInt(dr("jubilado")) = 1)
					Dim metros As Decimal = 0
					Dim cuota_added As New Integer
					Dim frente(3) As Decimal
					frente(0) = CDec(dr("frente1"))
					frente(1) = CDec(dr("frente2"))
					frente(2) = CDec(dr("frente3"))
					frente(3) = CDec(dr("frente4"))

					Dim monto_fijo(3) As Decimal
					monto_fijo(0) = dr("monto_fijo1")
					monto_fijo(1) = dr("monto_fijo2")
					monto_fijo(2) = dr("monto_fijo3")
					monto_fijo(3) = dr("monto_fijo4")

					zona = CInt(dr("zona"))
					esquino = CInt(dr("esquino"))
					var_taecat = CDec(variables("taecat")) / 100
					monto_minimo = dr("monto_minimo")
					monto_unidad = dr("monto_unidad")
					monto_pasillo = dr("monto_pasillo")
					rec_baldio = dr("rec_baldio")
					desc_vereda = dr("desc_vereda")
					desc_parque = dr("desc_parque")
					desc_agrario1 = dr("desc_agrario1")
					desc_agrario2 = dr("desc_agrario2")
					desc_jubilado1 = dr("desc_jubilado1")
					desc_jubilado2 = dr("desc_jubilado2")
					alumbrado_minimo = dr("alumbrado_minimo")
					alumbrado_basico = dr("alumbrado_basico")

					'Calculo frentes y esquinas
					basica = 0
					If frente(0) > 0 Then
						Dim frentes As Integer = 0
						metros += frente(0)
						frentes += 1

						If frente(1) > 0 Then
							metros += frente(1)
							frentes += 1
						End If
						If frente(2) > 0 Then
							metros += frente(2)
							frentes += 1
						End If
						If frente(3) > 0 Then
							metros += frente(3)
							frentes += 1
						End If
						If esquino = 1 Then
							metros /= frentes
						End If
					End If

					If zona = 6 Then
						'LOTEOS Y BARRIOS PRIVADOS
						If frente(0) > 2500 Then 'M2
							basica = monto_fijo(3)
						ElseIf frente(0) > 1249 Then 'M2
							basica = monto_fijo(2)
						ElseIf frente(0) > 799 Then 'M2
							basica = monto_fijo(1)
						Else
							basica = monto_fijo(0)
						End If
					ElseIf zona = 5 Then
						Dim fraccion As Integer = frente(0) / 200
						If frente(0) Mod 200 > 0 Then
							fraccion += 1
						End If
						basica = monto_unidad * fraccion
					Else
						basica = monto_unidad * metros
					End If
					'Pasillo
					If pasillo And frente(0) < 11 Then
						basica = monto_pasillo
					Else
						monto_pasillo = 0
					End If

					'Baldio
					If baldio Then
						'Recargo por alumbrado en baldío en zonas 1-5
						If zona < 6 Then

							If metros > 15 Then
								monto_alumbrado = alumbrado_basico * metros
							End If
							If monto_alumbrado < alumbrado_minimo Then
								monto_alumbrado = alumbrado_minimo
							End If

							'Recargo por baldío en zonas 1-3
							If zona < 4 Then
								monto_baldio = basica * (rec_baldio / 100)
							End If
						End If

						'Descuento por vereda
						If vereda Then
							monto_vereda = basica * (desc_vereda / 100)
						End If
						'Descuento por parquizado
						If parque Then
							monto_parque = basica * (desc_parque / 100)
						End If

					End If

					'Recargo Actividad Comercial
					monto_comercio = 0
					If comercial > 1 Then
						Dim tipo_comercio As Integer = comercial - 1
						monto_comercio = basica * (comercial & tipo_comercio) / 100
					End If

					'Descuento por Actividad Agropecuaria (Agrario)
					monto_agrario = 0
					If agrario Then
						If frente(0) > 100 Then
							monto_agrario = basica * (desc_agrario2 / 100)
						ElseIf frente(0) > 50 Then
							monto_agrario = basica * (desc_agrario1 / 100)
						End If
					End If

					'Descuento por Jubilado
					monto_jubilado = 0
					If jubilado Then
						If comercial = 1 Then
							monto_jubilado = basica * (desc_jubilado1 / 100)
						Else
							monto_jubilado = basica * (desc_jubilado2 / 100)
						End If
					End If

					'Calcular recargos
					subtotal += basica + monto_baldio + monto_comercio + monto_alumbrado
					'Calcular descuentos
					subtotal -= (monto_vereda + monto_parque + monto_agrario + monto_jubilado)

					'Minimo
					If subtotal < monto_minimo Then
						subtotal = monto_minimo
					End If

					'Franqueo
					monto_franqueo = CDec(variables("franqueo")) * 6

					'Calculo TAE
					monto_taecat = subtotal * var_taecat

					'Recargo franqueo y TAE
					importe = subtotal + monto_taecat + monto_franqueo

					'Cuotas
					cuota = 1
					cuota_max = 6
					Do While cuota <= cuota_max
						If CalcAnualImp.Sql.Catastro.VerificarCuota(dr, cuota, periodo, dtab(2)) Then
							cuota_added += 1
							ReDim Preserve sqlInsertList(total_cuotas)
							sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Catastro.InsertarCuota(dr, cuota, periodo, importe,
																		   dtab(0)(0), monto_minimo, basica, monto_baldio, monto_jubilado, monto_pasillo,
																		   monto_agrario, monto_comercio, monto_alumbrado, monto_vereda, monto_parque, monto_franqueo, monto_taecat)
							total_cuotas += 1
						End If
						cuota += 1
					Loop

					If cuota_added > 0 Then
						cuentas_modificadas += 1
					End If
					CheckProgress(info, progreso, dtab(1).Rows.IndexOf(dr), dr("codigo"), total_cuotas, cuentas_modificadas)
				Next
				If total_cuotas > 0 Then
					'info.Text = "Generando cuotas.."
					DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
					'CheckProgress(1, 1)
				End If
			End Sub
			Shared Function VerificarCuota(registro As DataRow, cuota As Integer, periodo As Integer, deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & registro("codigo").ToString &
														" AND agrupado='' AND mes=" & cuota &
														" AND periodo=" & periodo)

				Return result.Any = 0
			End Function
			Shared Function InsertarCuota(registro As DataRow, cuota As Integer, periodo As Integer, importe As Decimal,
								 vence As DataRow, minimo As Decimal, basica As Decimal, baldio As Decimal, jubilado As Decimal, pasillo As Decimal,
								 agrario As Decimal, comercio As Decimal, alumbrado As Decimal, vereda As Decimal, parque As Decimal,
								 franqueo As Decimal, taecat As Decimal) As String

				Dim sqlDecValue(12) As String
				sqlDecValue(0) = FormatNumber(importe / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(1) = FormatNumber(minimo / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(2) = FormatNumber(basica / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(3) = FormatNumber(baldio / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(4) = FormatNumber(jubilado / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(5) = FormatNumber(pasillo / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(6) = FormatNumber(agrario / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(7) = FormatNumber(comercio / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(8) = FormatNumber(alumbrado / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(9) = FormatNumber(vereda / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(10) = FormatNumber(parque / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(11) = FormatNumber(franqueo / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlDecValue(12) = FormatNumber(taecat / 6, 2, TriState.False, TriState.False, TriState.False)
				'Valor bimestral
				Return "INSERT INTO catcue(tipo, mes, agrupado, periodo, codigo, cedulon,
											   importe, original, vencio, pagado, pago, basica, 
											   minimo, baldio, jubilado, esquina, pasillo, agropec, 
											   contado, franqueo, chapa, alumbrado, vereda, parque, 
											   ochoa, ochob, ochoc, ochod, tae, agua, link, comercial)
										VALUES('N', " & cuota & ", '', " & periodo & ", " & registro("codigo").ToString & ", 0,
												" & sqlDecValue(0) & ", " & sqlDecValue(0) & ", {" & vence("vence" & cuota).ToString & "}, 0, {}, 
												" & sqlDecValue(2) & ", " & sqlDecValue(1) & ", " & sqlDecValue(3) & ", " & sqlDecValue(4) & ", 0, 
												" & sqlDecValue(5) & ", " & sqlDecValue(6) & ", 0, " & sqlDecValue(11) & ", 0, " & sqlDecValue(8) & ", 
												" & sqlDecValue(9) & ", " & sqlDecValue(10) & ", 0, 0, 0, 0, " & sqlDecValue(12) & ", 0, 
												'', " & sqlDecValue(7) & ");"

			End Function
		End Class
		Public Class Comercio
			Shared Sub CalcularCuota(bs_variables As BindingSource, CuentaInicial As Integer, periodo As Integer, ByRef info As Label, ByRef progreso As ToolStripProgressBar)
				Dim variables As DataRowView = bs_variables.Current
				Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
				Dim minimo, taecom, importe, franqueo As New Decimal
				Dim cuota_max As Integer
				Dim sqlSelect As String
				Dim sqlInsertList(0) As String
				Dim cuentas_modificadas, total_cuotas As Integer
				'Vencimientos
				dtab_vence = DbMan.ReadDB("SELECT * FROM comvence WHERE periodo=" & periodo, My.Settings.foxConnection)

				'Cuentas
				sqlSelect = "SELECT comercio.codigo as codigo, comercio.cantidad, 
                         comercio.actividad as actividad, comact.detalle,
		    			 comact.tributo, comact.cuotas, 
                         comact.cuota1, comact.cuota2, comact.cuota3,
                         comact.cuota4,comact.cuota5,comact.cuota6"
				sqlSelect &= " FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
				sqlSelect &= " WHERE comercio.baja = {} AND comact.cuota1>0 AND comercio.codigo=>" & CuentaInicial
				sqlSelect &= " ORDER BY comercio.codigo"

				dtab_cuenta = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

				'Deudas
				sqlSelect = "SELECT *"
				sqlSelect &= " FROM comcue"
				sqlSelect &= " WHERE agrupado='' AND pago={} AND ano=" & periodo & " AND codigo=> " & CuentaInicial
				sqlSelect &= " ORDER BY codigo"

				dtab_deuda = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

				progreso.Maximum = dtab_cuenta.Rows.Count - 1

				For Each dr As DataRow In dtab_cuenta.Rows
					Dim cuota_added As New Integer
					Dim vence As Date = Date.Today


					If CInt(dr("cuotas")) > 0 Then
						cuota_max = dr("cuotas")

						For ncuota As Integer = 1 To cuota_max
							If cuota_max = 1 Or cuota_max = 6 Then
								minimo = dr("cuota" & ncuota)
								vence = dtab_vence(0)("vence" & ncuota)
							Else
								If ncuota = 1 Then
									minimo = dr("cuota1")
									vence = dtab_vence(0)("vence1")
								ElseIf ncuota = 2 Then
									If cuota_max = 2 Then
										minimo = dr("cuota4")
										vence = dtab_vence(0)("vence4")
									ElseIf cuota_max = 3 Then
										minimo = dr("cuota3")
										vence = dtab_vence(0)("vence3")
									End If
								ElseIf ncuota = 3 And cuota_max = 3 Then
									minimo = dr("cuota5")
									vence = dtab_vence(0)("vence5")
								End If
							End If
							If CInt(dr("cantidad")) > 1 Then
								minimo *= CInt(dr("cantidad"))
							End If

							taecom = minimo * (CDec(variables("taecom")) / 100)
							franqueo = variables("franqueo")
							importe = minimo + taecom + franqueo

							If CalcAnualImp.Sql.Comercio.VerificarCuota(dr, ncuota, dtab_deuda) Then
								cuota_added += 1
								ReDim Preserve sqlInsertList(total_cuotas)
								sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Comercio.InsertarCuota(dr, ncuota, periodo, minimo, taecom,
																										franqueo, importe, vence)
								total_cuotas += 1
							End If

						Next
					End If
					If cuota_added > 0 Then
						cuentas_modificadas += 1
					End If
					CheckProgress(info, progreso, dtab_cuenta.Rows.IndexOf(dr), dr("codigo"), total_cuotas, cuentas_modificadas)
				Next
				If total_cuotas > 0 Then
					DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
				End If
			End Sub
			Shared Function VerificarCuota(registro As DataRow, cuota As Integer, deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & registro("codigo").ToString & " AND bimestre=" & cuota)

				Return result.Any = 0
			End Function
			Shared Function InsertarCuota(registro As DataRow, cuota As Integer, periodo As Integer, minimo As Decimal,
								  taecom As Decimal, franqueo As Decimal, importe As Decimal, vence As Date) As String
				Return "INSERT INTO comcue(item, tipo, cedulon, bimestre, agrupado, ano, codigo, actividad, importe, franqueo, tae,
							  			        total, total1, total2, vence1, vence2, vence3, pagado, pago)
								  VALUES(0, 'N', 0, " & cuota & ", ' ', " & periodo & ", " & registro("codigo").ToString & ",
									     " & registro("actividad").ToString & "," & minimo & ", " & franqueo & ", " & taecom & ",
									 	 " & importe & ", " & importe & ", " & importe & ", {" & vence & "}, {}, {}, 0, {})"

			End Function
		End Class
		Public Class Sepelio
			Shared Sub CalcularCuota(bs_variables As BindingSource, CuentaInicial As Integer, periodo As Integer, ByRef info As Label, ByRef progreso As ToolStripProgressBar)
				Dim variables As DataRowView = bs_variables.Current
				Dim dtab_cuenta, dtab_deuda As DataTable
				Dim sqlInsertList(0) As String
				Dim sqlSelect As String
				Dim cuentas_modificadas, total_cuotas As Integer
				'Vencimientos
				Dim vence As New Date(periodo, 3, 20)
				Do While vence.DayOfWeek <> DayOfWeek.Monday
					vence = vence.AddDays(1)
				Loop
				'Cuentas
				sqlSelect = "SELECT sepelio.codigo as codigo, sepelio.fila as fila, sepelio.jubilado as jubilado, 
									sepevar.minimo as minimo, sepelio.espacio as espacio, sepevar.jubilado as desc_jubilado, 
									sepevar.fila1 as fila1, sepevar.fila2 as fila2, sepevar.fila3 as fila3,
		    						sepevar.fila4 as fila4, sepevar.fila5 as fila5, sepelio.ubicacion as ubicacion, sepelio.tipo as tipo"
				sqlSelect &= " FROM sepelio JOIN sepevar ON sepelio.tipo=sepevar.orden"
				sqlSelect &= " WHERE sepelio.tipo > 0 AND sepelio.codigo =>" & CuentaInicial
				sqlSelect &= " ORDER BY sepelio.codigo"
				dtab_cuenta = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

				sqlSelect = "SELECT *"
				sqlSelect &= " FROM sepecue"
				dtab_deuda = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

				progreso.Maximum = dtab_cuenta.Rows.Count - 1

				Dim jubilado, importe As Decimal
				For Each dr As DataRow In dtab_cuenta.Rows
					Dim cuota_mod As New Integer
					Dim fila As Integer = CInt(dr("fila"))
					jubilado = 0
					importe = 0

					If fila > 0 Then
						importe = dr("fila" & fila)
					End If

					If importe < CDec(dr("minimo")) Then
						importe = dr("minimo")
					End If

					importe *= CInt(dr("espacio"))

					If CInt(dr("jubilado")) = 1 Then
						jubilado = importe * (CDec(dr("desc_jubilado")) / 100)
						importe -= jubilado
					End If

					If CalcAnualImp.Sql.Sepelio.VerificarCuota(dr, periodo, dtab_deuda) Then
						cuota_mod += 1
						ReDim Preserve sqlInsertList(total_cuotas)
						sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Sepelio.InsertarCuota(dr, periodo, importe, vence)

						total_cuotas += 1
					End If
					If cuota_mod > 0 Then
						cuentas_modificadas += 1
					End If
					CheckProgress(info, progreso, dtab_cuenta.Rows.IndexOf(dr), dr("codigo"), total_cuotas, cuentas_modificadas)
				Next
				If total_cuotas > 0 Then
					DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
				End If
			End Sub
			Shared Function VerificarCuota(registro As DataRow, periodo As Integer, deudas As DataTable) As Boolean
				Dim result As DataRow() = deudas.Select("codigo=" & registro("codigo").ToString & " AND agrupado='' AND mes=1
														 AND periodo=" & periodo)

				Return result.Any = 0
			End Function
			Shared Function InsertarCuota(registro As DataRow, periodo As Integer, importe As Decimal, vence As Date) As String
				Return "INSERT INTO sepecue(tipo, mes, agrupado, periodo, codigo, 
												cedulon, importe, original, vencio, pagado, pago)
										 VALUES('A', 1, ''," & periodo & ", " & registro("codigo").ToString & ",
												 0, " & importe & ", " & importe & ", {" & vence & "}, 0, {})"

			End Function
		End Class
	End Class
End Class
