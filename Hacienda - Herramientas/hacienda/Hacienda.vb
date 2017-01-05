Public Class Hacienda
    Public Class CalculoAnual
        Public Class sql
			Public Class Agua 'Listo
                Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
					Dim dtab As DataTable = bd.read(My.Settings.foxcon,
													"SELECT * FROM agucue 
                                                    WHERE codigo=" & registro(fila)("codigo") & " 
                                                    AND mes=" & cuota & " AND periodo=" & periodo)
					Return dtab.Rows.Count = 0
				End Function
				Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, importe As Decimal,
										  vence As DataRow, reside As Decimal, comercio As Decimal, industria As Decimal, franqueo As Decimal)
					bd.edit(My.Settings.foxcon,
							"INSERT INTO agucue(tipo, mes, agrupado, periodo, codigo, cedulon,
                                                importe, original, vencio, pagado, pago,
                                                reside, comercio, industria, contado, franqueo, link)" &
							" VALUES('N', " & cuota & ", '', " & periodo & ", " & registro(fila)("codigo") & ", 0,
                            " & importe & ", " & importe & ", {" & vence("vence" & cuota) & "}, 0, {},
                            " & reside & ", " & comercio & ", " & industria & ", 0, " & franqueo & ", '')")
				End Sub
			End Class
			Public Class Auto
				Shared Function VerificarCuota(cuenta As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
					Dim dtab As DataTable = bd.read(My.Settings.foxcon,
													"SELECT * FROM autocue
													 WHERE codigo =" & cuenta(fila)("codigo") & "
					                                 And cuota=" & cuota & " AND ano=" & periodo)
					Return dtab.Rows.Count = 0
				End Function
				Shared Function CrearRegistro(ByRef registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer,
											  importe As Decimal, vence As DataRow) As DataTable


					Return registro
				End Function
				Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer,
										 importe As Decimal, vence As DataRow)
					bd.edit(My.Settings.foxcon,
							"INSERT INTO autocue(cedulon, cuota, ano, moratoria, codigo, razon, marca, modelo, apagar, gastos, total, total1," &
							" total2, vencimi1, vencimi2, vencimi3, apagado, fecha, link)" &
							" VALUES(0, " & cuota & ", " & periodo & ", 'N', " & registro(fila)("codigo") & ", '" & Trim(registro(fila)("razon")) & "'," &
							" '" & Trim(registro(fila)("marca")) & "', " & registro(fila)("modelo") & ", " & importe & ", 0, " & importe & "," &
							" " & importe & ", " & importe & ", {" & vence("vence" & cuota) & "}, {}, {}, 0, {}, '')")
				End Sub
			End Class
            Public Class Catastro
				Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
					Dim dtab As DataTable = bd.read(My.Settings.foxcon,
													"SELECT * FROM catcue
                                                     WHERE codigo=" & registro(fila)("codigo") & " 
													 AND agrupado='' AND mes=" & cuota & "
													 AND periodo=" & periodo)
					Return dtab.Rows.Count = 0
				End Function
				Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, importe As Decimal,
									 vence As DataRow, minimo As Decimal, basica As Decimal, baldio As Decimal, jubilado As Decimal, pasillo As Decimal,
									 agrario As Decimal, comercio As Decimal, vereda As Decimal, parque As Decimal,
									 franqueo As Decimal, taecat As Decimal)
					bd.edit(My.Settings.foxcon,
							"INSERT INTO catcue(tipo, mes, agrupado, periodo, codigo, cedulon,
							 importe, original, vencio, pagado, pago, basica, 
							 minimo, baldio, jubilado, esquina, pasillo, agropec, 
							 contado, franqueo, chapa, alumbrado, vereda, parque, 
							 ochoa, ochob, ochoc, ochod, tae, agua, link, comercial)
							 VALUES('N', " & cuota & ", '', " & periodo & ", " & registro(fila)("codigo") & ", 0,
							 " & importe & ", " & importe & ", {" & vence("vence" & cuota) & "}, 0, {}, " & basica & ",
							 " & minimo & ", " & baldio & ", " & jubilado & ", 0, " & pasillo & ", " & agrario & ",
							 0, " & franqueo & ", 0, 0, " & vereda & ", " & parque & ",
							 0, 0, 0, 0, " & taecat & ", 0, '', " & comercio & ")")
				End Sub
			End Class
            Public Class Comercio
				Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
					Dim dtab As DataTable = bd.read(my.settings.foxcon,
													"SELECT * FROM comcue 
                                                     WHERE codigo=" & registro(fila)("codigo") & " 
                                                     AND bimestre=" & cuota & " AND ano=" & periodo)
					Return dtab.Rows.Count > 0
				End Function
				Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, minimo As Decimal,
									  taecom As Decimal, franqueo As Decimal, importe As Decimal, vence As DataRow)
					bd.edit(My.Settings.foxcon, "INSERT INTO comcue(item, tipo, cedulon, bimestre, agrupado, ano, codigo, actividad, importe, franqueo, tae," &
									" total, total1, total2, vence1, vence2, vence3, pagado, pago)" &
									" VALUES(0, 'N', 0, " & cuota & ", ' ', " & periodo & ", " & registro(fila)("codigo") & "," &
									" " & registro(fila)("actividad") & "," & minimo & ", " & franqueo & ", " & taecom & "," &
									" " & importe & ", " & importe & ", " & importe & ", {" & vence("vence" & cuota) & "}, {}, {}, 0, {})")
				End Sub
			End Class
            Public Class Sepelio
				Shared Function VerificarCuota(registro As DataTable, fila As Integer, periodo As Integer) As Boolean
					Dim dtab As DataTable = bd.read(My.Settings.foxcon,
													"SELECT * FROM sepecue
                                                    WHERE codigo=" & registro(fila)("codigo") & " 
                                                    AND mes=1 AND periodo=" & periodo)
					Return dtab.Rows.Count > 0
				End Function
				Shared Sub InsertarCuota(registro As DataTable, fila As Integer, periodo As Integer, importe As Decimal, vence As Date)
					bd.edit(My.Settings.foxcon, "INSERT INTO sepecue(tipo, mes, agrupado, periodo, codigo, cedulon, importe, original, vencio, pagado, pago)" &
									" VALUES('A', 1, ''," & periodo & ", " & registro(fila)("codigo") & "," &
									" 0, " & importe & ", " & importe & ", {" & vence & "}, 0, {})")
				End Sub
			End Class
        End Class
    End Class
    Public Class CuentaAgrupada
        Public Class sql
            Shared Function leer(ByVal keyword As String, ByVal impuesto As String, ByVal sender As System.Object)
                Dim consulta As New DataTable
                '### Crear consulta sin filtros
                If sender Is ConsultaCuentaAgrupada.ca_search Then 'Lista de Personas / Contribuyentes
                    Dim sql As String = "SELECT id, cuil, razon FROM persona"
                    If Val(Microsoft.VisualBasic.Right(keyword, 2)) >= 20 And Len(keyword) = 11 Then
                        sql += " WHERE cuil=" & keyword
                    Else
                        sql += " WHERE razon Like '%" & keyword & "%'"
                    End If
                    consulta = bd.read(my.settings.DefaultCon, sql)
                ElseIf sender Is ConsultaCuentaAgrupada.mod_ca_imp_search Then 'Seleccionar impuestos sobre Fox
                    tablas_fox(impuesto)
                    'Cuidado acá, porque comercio no tiene campo "Tenedor"
                    consulta = bd.read(my.settings.foxcon,
                                       "SELECT " & ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon, " & col_tenedor & " as tenedor FROM " & ext_persona & "
                                        INNER JOIN " & ext_cuenta & " ON " & ext_persona & ".codigo = " & ext_cuenta & ".codigo 
                                        WHERE " & ext_persona & ".razon LIKE '%" & keyword & "%' OR " & col_tenedor & " LIKE '%" & keyword & "%'")
                End If
                Return consulta
            End Function
        End Class
    End Class
End Class
