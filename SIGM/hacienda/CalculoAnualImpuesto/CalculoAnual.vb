Class CalculoAnual
	Public Class Sql
		Public Class Agua
			Shared Function CargarTablas(dtab As DataTable(), periodo As Integer, CuentaInicial As Integer) As DataTable()
				Dim sql(0) As String

				If dtab Is Nothing = False Then
					'Zonas
					sql(0) = "SELECT * FROM aguzona ORDER BY tipo"
					dtab(0) = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

					'Vencimientos
					sql(0) = "SELECT * FROM aguvence
								WHERE periodo=" & periodo
					dtab(1) = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

					'Cuentas
					sql(0) = "SELECT codigo, tipo, cantidad
								FROM aguas WHERE codigo=>" & CuentaInicial & " ORDER BY codigo"
					dtab(2) = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

					'Deudas
					sql(0) = "SELECT * FROM agucue 
								WHERE codigo=>" & CuentaInicial & " AND periodo=" & periodo & "
								ORDER BY codigo"
					dtab(3) = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
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
			Shared Function VerificarCuota(registro As DataRow, cuota As Integer, periodo As Integer,
											deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & registro("codigo") & " And moratoria='N' AND cuota=" & cuota & " 
															  And ano=" & periodo)

				Return result.any = 0
			End Function
			Shared Function InsertarCuota(registro As DataRow, cuota As Integer, periodo As Integer,
									 importe As Decimal, vence As DataRow) As String
				Return "INSERT INTO autocue(cedulon, cuota, ano, moratoria, codigo, razon,
															marca, modelo, apagar, gastos, total, total1,
															total2, vencimi1, vencimi2, vencimi3, apagado, fecha, link)
													VALUES(0, " & cuota & ", " & periodo & ", 'N', " & registro("codigo") & ",
															'" & Trim(registro("razon")) & "', '" & Trim(registro("marca")) & "',
															" & registro("modelo") & ", " & importe & ", 0, " & importe & ",
															" & importe & ", " & importe & ", {" & vence("vence" & cuota) & "}, {}, {}, 0, {}, '')"
			End Function
		End Class
		Public Class Catastro
			Shared Function CargarTablas(dtab As DataTable(), periodo As Integer, CuentaInicial As Integer) As DataTable()
				Dim sql(2) As String

				'Vencimientos
				sql(0) = "SELECT * "
				sql(1) = "FROM catvence"
				sql(2) = "WHERE periodo=" & periodo
				dtab(0) = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

				'Cuentas
				sql(0) = "SELECT catastro.codigo As codigo, catastro.jubilado As jubilado,
								catastro.baldio As baldio, catastro.pasillo As pasillo,
								catastro.agrario As agrario, catastro.comercial as comercial,
								catastro.vereda as vereda, catastro.parque as parque,
								catastro.esquino as esquino, catastro.zona1 as zona,
								catastro.frente1 As frente1, catastro.frente2 As frente2,
								catastro.frente3 As frente3, catastro.frente4 As frente4,
								catzona.minimo As monto_minimo, catzona.unidad As monto_unidad,
								catzona.fijo1 as monto_fijo1, catzona.fijo2 as monto_fijo2,
								catzona.fijo3 as monto_fijo3, catzona.fijo4 as monto_fijo4,
								catzona.jubilado As desc_jubilado, catzona.baldio As rec_baldio,
								catzona.pasillo As monto_pasillo,
								catzona.agrario1 As desc_agrario1, catzona.agrario2 As desc_agrario2,
								catzona.comercio1 as rec_comercio1, catzona.comercio2 as rec_comercio2,
								catzona.comercio3 as rec_comercio3, catzona.comercio4 as rec_comercio4,
								catzona.vereda as desc_vereda, catzona.parque as desc_parque,
								catzona.alumbrado_minimo, catzona.alumbrado_basico"

				sql(1) = "FROM catastro JOIN catzona On catastro.zona1=catzona.zona"
				sql(2) = "WHERE catastro.codigo=>" & CuentaInicial & " ORDER BY catastro.codigo"

				dtab(1) = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

				sql(0) = "SELECT codigo, agrupado, mes, periodo"
				sql(1) = "FROM catcue"
				sql(2) = "WHERE codigo=>" & CuentaInicial & " AND periodo=" & periodo & " AND agrupado=''"
				dtab(2) = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

				Return dtab
			End Function

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

				'Return CInt(DbMan.editDB(Nothing, My.Settings.foxConnection, "INSERT INTO catcue(tipo, mes, agrupado, periodo, codigo, cedulon,
				'							   importe, original, vencio, pagado, pago, basica, 
				'							   minimo, baldio, jubilado, esquina, pasillo, agropec, 
				'							   contado, franqueo, chapa, alumbrado, vereda, parque, 
				'							   ochoa, ochob, ochoc, ochod, tae, agua, link, comercial)
				'						VALUES('N', " & cuota & ", '', " & periodo & ", " & registro("codigo") & ", 0,
				'								" & sqlDecValue(0) & ", " & sqlDecValue(0) & ", {" & vence("vence" & cuota) & "}, 0, {}, " & sqlDecValue(2) & ",
				'								" & sqlDecValue(1) & ", " & sqlDecValue(3) & ", " & sqlDecValue(4) & ", 0, " & sqlDecValue(5) & ", " & sqlDecValue(6) & ",
				'							   0, " & sqlDecValue(11) & ", 0, " & sqlDecValue(8) & ", " & sqlDecValue(9) & ", " & sqlDecValue(10) & ",
				'							   0, 0, 0, 0, " & sqlDecValue(12) & ", 0, '', " & sqlDecValue(7) & ")"))
				Return "INSERT INTO catcue(tipo, mes, agrupado, periodo, codigo, cedulon,
											   importe, original, vencio, pagado, pago, basica, 
											   minimo, baldio, jubilado, esquina, pasillo, agropec, 
											   contado, franqueo, chapa, alumbrado, vereda, parque, 
											   ochoa, ochob, ochoc, ochod, tae, agua, link, comercial)
										VALUES('N', " & cuota & ", '', " & periodo & ", " & registro("codigo") & ", 0,
												" & sqlDecValue(0) & ", " & sqlDecValue(0) & ", {" & vence("vence" & cuota) & "}, 0, {}, " & sqlDecValue(2) & ",
												" & sqlDecValue(1) & ", " & sqlDecValue(3) & ", " & sqlDecValue(4) & ", 0, " & sqlDecValue(5) & ", " & sqlDecValue(6) & ",
											   0, " & sqlDecValue(11) & ", 0, " & sqlDecValue(8) & ", " & sqlDecValue(9) & ", " & sqlDecValue(10) & ",
											   0, 0, 0, 0, " & sqlDecValue(12) & ", 0, '', " & sqlDecValue(7) & ");"

			End Function
		End Class
		Public Class Comercio
			Shared Function VerificarCuota(registro As DataRow, cuota As Integer, deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & registro("codigo") & " AND bimestre=" & cuota)

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
			Shared Function VerificarCuota(registro As DataRow, periodo As Integer, deudas As DataTable) As Boolean
				Dim result As DataRow() = deudas.Select("codigo=" & registro("codigo") & " AND agrupado='' AND mes=1
														 AND periodo=" & periodo)

				Return result.Any = 0
			End Function
			Shared Function InsertarCuota(registro As DataRow, periodo As Integer, importe As Decimal, vence As Date) As String
				Return "INSERT INTO sepecue(tipo, mes, agrupado, periodo, codigo, 
												cedulon, importe, original, vencio, pagado, pago)
										 VALUES('A', 1, ''," & periodo & ", " & registro("codigo") & ",
												 0, " & importe & ", " & importe & ", {" & vence & "}, 0, {})"

			End Function
		End Class
	End Class
End Class
