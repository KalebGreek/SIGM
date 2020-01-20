Public Class CalculoAnual
	Public Class sql
		Public Class Agua
			Shared Function CargarTablas() As Boolean
				Dim result As Boolean = True


				Return result
			End Function
			Shared Function VerificarCuota(cuentas As DataTable, fila As Integer, cuota As Integer, periodo As Integer,
											deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & cuentas(fila)("codigo") & " And agrupado='' AND mes=" & cuota & " 
															  And periodo=" & periodo)

				Return result.Count = 0
			End Function
			Shared Function InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, importe As Decimal,
									  vence As DataRow, reside As Decimal, comercio As Decimal, industria As Decimal, franqueo As Decimal) As Integer
				Return CInt(DbMan.editDB(Nothing, My.Settings.foxConnection, "INSERT INTO agucue(tipo, mes, agrupado, periodo, codigo, cedulon,
                                                importe, original, vencio, pagado, pago,
                                                reside, comercio, industria, contado, franqueo, link)
										VALUES('N', " & cuota & ", '', " & periodo & ", " & registro(fila)("codigo") & ", 0,
												" & importe & ", " & importe & ", {" & vence("vence" & cuota) & "}, 0, {},
												" & reside & ", " & comercio & ", " & industria & ", 0, " & franqueo & ", '')"))
			End Function
		End Class
		Public Class Auto
			Shared Function VerificarCuota(cuentas As DataTable, fila As Integer, cuota As Integer, periodo As Integer,
											deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & cuentas(fila)("codigo") & " And moratoria='' AND cuota=" & cuota & " 
															  And ano=" & periodo)

				Return result.Count = 0
			End Function
			Shared Function InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer,
									 importe As Decimal, vence As DataRow) As Integer
				Return CInt(DbMan.editDB(Nothing, My.Settings.foxConnection,
									   "INSERT INTO autocue(cedulon, cuota, ano, moratoria, codigo, razon,
															marca, modelo, apagar, gastos, total, total1,
															total2, vencimi1, vencimi2, vencimi3, apagado, fecha, link)
													VALUES(0, " & cuota & ", " & periodo & ", 'N', " & registro(fila)("codigo") & ",
															'" & Trim(registro(fila)("razon")) & "', '" & Trim(registro(fila)("marca")) & "',
															" & registro(fila)("modelo") & ", " & importe & ", 0, " & importe & ",
															" & importe & ", " & importe & ", {" & vence("vence" & cuota) & "}, {}, {}, 0, {}, '')"))
			End Function
		End Class
		Public Class Catastro
			Shared Function VerificarCuota(registro As DataRow, cuota As Integer, periodo As Integer, deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & registro("codigo") & " And agrupado='' AND mes=" & cuota & " 
															  AND periodo=" & periodo)

				Return result.Count = 0
			End Function
			Shared Function InsertarCuota(registro As DataRow, cuota As Integer, periodo As Integer, importe As Decimal,
								 vence As DataRow, minimo As Decimal, basica As Decimal, baldio As Decimal, jubilado As Decimal, pasillo As Decimal,
								 agrario As Decimal, comercio As Decimal, vereda As Decimal, parque As Decimal,
								 franqueo As Decimal, taecat As Decimal) As Integer


				Dim sqlNumValue(11) As String
				sqlNumValue(0) = FormatNumber(importe / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(1) = FormatNumber(minimo / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(2) = FormatNumber(basica / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(3) = FormatNumber(baldio / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(4) = FormatNumber(jubilado / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(5) = FormatNumber(pasillo / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(6) = FormatNumber(agrario / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(7) = FormatNumber(comercio / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(8) = FormatNumber(vereda / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(9) = FormatNumber(parque / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(10) = FormatNumber(franqueo / 6, 2, TriState.False, TriState.False, TriState.False)
				sqlNumValue(11) = FormatNumber(taecat / 6, 2, TriState.False, TriState.False, TriState.False)
				'Valor bimestral

				Return CInt(DbMan.editDB(Nothing, My.Settings.foxConnection, "INSERT INTO catcue(tipo, mes, agrupado, periodo, codigo, cedulon,
											   importe, original, vencio, pagado, pago, basica, 
											   minimo, baldio, jubilado, esquina, pasillo, agropec, 
											   contado, franqueo, chapa, alumbrado, vereda, parque, 
											   ochoa, ochob, ochoc, ochod, tae, agua, link, comercial)
										VALUES('N', " & cuota & ", '', " & periodo & ", " & registro("codigo") & ", 0,
												" & sqlNumValue(0) & ", " & sqlNumValue(0) & ", {" & vence("vence" & cuota) & "}, 0, {}, " & sqlNumValue(2) & ",
												" & sqlNumValue(1) & ", " & sqlNumValue(3) & ", " & sqlNumValue(4) & ", 0, " & sqlNumValue(5) & ", " & sqlNumValue(6) & ",
											   0, " & sqlNumValue(10) & ", 0, 0, " & sqlNumValue(8) & ", " & sqlNumValue(9) & ",
											   0, 0, 0, 0, " & sqlNumValue(11) & ", 0, '', " & sqlNumValue(7) & ")"))

			End Function
		End Class
		Public Class Comercio
			Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & registro(fila)("codigo") & " And agrupado='' AND bimestre=" & cuota & " 
															  And ano=" & periodo)

				Return result.Count = 0
			End Function

			Shared Function InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, minimo As Decimal,
								  taecom As Decimal, franqueo As Decimal, importe As Decimal, vence As Date) As Integer
				Return CInt(DbMan.editDB(Nothing, My.Settings.foxConnection,
							"INSERT INTO comcue(item, tipo, cedulon, bimestre, agrupado, ano, codigo, actividad, importe, franqueo, tae,
							  			        total, total1, total2, vence1, vence2, vence3, pagado, pago)
								  VALUES(0, 'N', 0, " & cuota & ", ' ', " & periodo & ", " & registro(fila)("codigo") & ",
									     " & registro(fila)("actividad") & "," & minimo & ", " & franqueo & ", " & taecom & ",
									 	 " & importe & ", " & importe & ", " & importe & ", {" & vence & "}, {}, {}, 0, {})"))

			End Function
		End Class
		Public Class Sepelio
			Shared Function VerificarCuota(registro As DataTable, fila As Integer, periodo As Integer, deudas As DataTable) As Boolean

				Dim result As DataRow() = deudas.Select("codigo=" & registro(fila)("codigo") & " AND agrupado='' AND mes=1
														 AND periodo=" & periodo)

				Return result.Count = 0
			End Function
			Shared Function InsertarCuota(registro As DataTable, fila As Integer, periodo As Integer, importe As Decimal, vence As Date) As Integer
				Return CInt(DbMan.editDB(Nothing, My.Settings.foxConnection, "INSERT INTO sepecue(tipo, mes, agrupado, periodo, codigo, 
												cedulon, importe, original, vencio, pagado, pago)
										 VALUES('A', 1, ''," & periodo & ", " & registro(fila)("codigo") & ",
												 0, " & importe & ", " & importe & ", {" & vence & "}, 0, {})"))

			End Function
		End Class
	End Class
End Class
