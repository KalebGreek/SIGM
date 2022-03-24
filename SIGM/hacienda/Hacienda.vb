Class Hacienda
	Shared Function BuildQuery(connection As String, vista As String) As String()
		Dim sql(5) As String
		If connection <> "Seleccione una base de datos antes de continuar." Then
			'Build SQL query
			If vista = "HACIENDA - INGRESOS" Then
				sql(0) = "SELECT * FROM hacienda WHERE sumado = 2 AND pertenece='8' ORDER BY orden"

			ElseIf vista = "HACIENDA - EGRESOS" Then
				sql(0) = "SELECT * FROM hacienda WHERE sumado = 2 and pertenece='9' ORDER BY orden"

			ElseIf vista = "INGRESOS CONSOLIDADOS" Then
				Hacienda.ConsolidarCuentas(Today)
				sql(0) = "SELECT * FROM ingresos"

			ElseIf vista = "EGRESOS CONSOLIDADOS" Then
				Hacienda.ConsolidarCuentas(Today)
				sql(0) = "SELECT * FROM egresos"

			ElseIf vista = "BANCOS - SALDO" Then
				sql(0) = "SELECT MIN(fecha) as fecha FROM bancos"

				Dim minDateValue As Date = Today
				Dim maxDateValue As Date = Today
				Using dtab As DataTable = DbMan.ReadDB(sql, connection)
					minDateValue = dtab.Rows(0)("fecha").ToString
				End Using
				sql(0) = "SELECT banco, 
                           (SELECT SUM(b3.importe)
                            FROM bancos as b3
                            WHERE b3.tipo=2 AND b3.banco=b1.banco
                            AND fecha=>{" & minDateValue.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.ToString("MM/dd/yyyy") & "}) AS ingreso,
                           (SELECT SUM(b2.importe)
                            FROM bancos as b2
                            WHERE b2.tipo=1 AND b2.banco=b1.banco
                            AND fecha=>{" & minDateValue.ToString("MM/dd/yyyy") & "}
                            AND fecha<={" & maxDateValue.ToString("MM/dd/yyyy") & "}) AS egreso,
                           (SELECT SUM(b3.importe) FROM bancos as b3
                            WHERE b3.tipo=2 AND b3.banco=b1.banco
                            AND fecha=>{" & minDateValue.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.ToString("MM/dd/yyyy") & "}) - 
                           (SELECT SUM(b2.importe) FROM bancos as b2
                            WHERE b2.tipo=1 AND b2.banco=b1.banco
                            AND fecha=>{" & minDateValue.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.ToString("MM/dd/yyyy") & "}) AS diferencia"
				sql(1) = " FROM bancos as b1"
				sql(2) = " GROUP BY banco"

			ElseIf vista = "CAJA" Then
				sql(0) = "SELECT * FROM caja ORDER BY fecha"

			ElseIf vista = "COMPARAR INGRESOS" Then
				sql(0) = "SELECT caja.fecha, movimis.documento as movimis_documento,
                                     SUM(movimis.pagado) as suma_movimis_pagado, caja.recibo as caja_recibo,
                                     caja.importe as caja_importe, SUM(movimis.pagado)-importe as diferencia, 
							         movimis.detalle"
				sql(1) = " FROM caja INNER JOIN movimis ON caja.recibo=movimis.documento"
				sql(2) = " WHERE movimis.orden<900000000000"
				sql(3) = " GROUP BY caja.fecha, movimis.documento, caja.recibo, caja.importe, movimis.detalle"
				sql(4) = " ORDER BY caja.fecha"

			ElseIf vista = "COMPARAR EGRESOS" Then
				'cambiar caja por pagos y corregir tema de documento <> orden

				sql(0) = "SELECT opagos.dia, movimis.documento as movimis_documento,
                                     movimis.pagado as movimis_pagado, opagos.orden as opagos_orden,
                                     opagos.importe as opagos_importe, SUM(movimis.pagado)-opagos.importe as diferencia,
                                     movimis.detalle, movimis.orden, hacienda.nombre"
				sql(1) = " FROM opagos INNER JOIN (movimis INNER JOIN hacienda ON movimis.orden=hacienda.orden)
							ON opagos.factura=movimis.detalle"
				sql(2) = " WHERE movimis.orden>899999999999"
				sql(3) = " GROUP BY opagos.dia, movimis.documento, movimis.detalle, movimis.pagado, opagos.orden,
							opagos.importe, movimis.orden, hacienda.nombre"
				sql(4) = " ORDER BY opagos.dia"
			End If
		End If
		Return sql
    End Function
	Shared Sub FillSeccion(ByRef bs As BindingSource, ByRef target As ComboBox)
		bs.DataSource = DbMan.ReadDB("SELECT * FROM seccion ORDER BY descripcion", My.Settings.CurrentDB)
		CtrlMan.Fill.SetAutoComplete(target, bs, "descripcion", "id")
	End Sub
	Shared Sub FillCuentasHacienda(ByRef bs As BindingSource, ByRef target As ComboBox,
								   ByVal Optional sumado As Integer = 0,
								   ByVal Optional pertenece As String = "0",
								   ByVal Optional anexo As String = "0",
								   ByVal Optional inciso As String = "0",
								   ByVal Optional item As String = "0",
								   ByVal Optional rubro As String = "00",
								   ByVal Optional subrubro As String = "00",
								   ByVal Optional partida As String = "00",
								   ByVal Optional subpartida As String = "00")

		Dim sql(5) As String
		sql(0) = "SELECT * "
		sql(1) = " FROM HACIENDA"

		If sumado > 0 Then
			sql(2) += " WHERE sumado=" & sumado
		End If

		If pertenece <> "0" Then
			If sql(2).Contains("WHERE") Then
				sql(2) += " AND pertenece='" & pertenece & "'"
			Else
				sql(2) += " WHERE pertenece='" & pertenece & "'"
			End If

			If anexo <> "0" Then
				sql(2) += " AND anexo='" & anexo & "'"

				If inciso <> "0" Then
					sql(2) += " AND inciso='" & inciso & "'"

					If item <> "0" Then
						sql(2) += " AND item='" & item & "'"

						If rubro <> "00" Then
							sql(2) += " AND rubro='" & rubro & "'"

							If subrubro <> "00" Then
								sql(2) += " AND subrubro='" & subrubro & "'"

								If partida <> "00" Then
									sql(2) += " AND partida='" & partida & "'"

									If subpartida <> "00" Then
										sql(2) += " AND subpartida='" & subpartida & "'"
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End If

		sql(3) = " ORDER BY orden"

		bs.DataSource = DbMan.ReadDB(sql, My.Settings.foxConnection)


		CtrlMan.Fill.SetAutoComplete(target, bs, "nombre", "orden")
	End Sub
	Shared Function ConsolidarCuentas(fecha As Date) As Boolean

		If MsgBoxResult.Yes = MsgBox("Desea consolidar cuentas? Se calculará al mes de " & fecha.ToString("y"),
									 MsgBoxStyle.YesNo, "Consolidar Hacienda") Then
			Dim sqlModify(0) As String
			'Reset

			sqlModify(0) = "UPDATE hacienda 
							   SET MES1=0, MES2=0, MES3=0, MES4=0, MES5=0, 
								   MES6=0, MES7=0, MES8=0, MES9=0, MES10=0, MES11=0, MES12=0, 
								   SUMATODO=0, GASTADO=0, GASTOMES=0"

			sqlModify.Append("DELETE FROM ingresos") 'Fox no necesita comodín
			sqlModify.Append("DELETE FROM egresos")

			'Actualizar desde movimis en Hacienda (ingresos)
			sqlModify.Append("UPDATE hacienda SET hacienda.sumatodo=sq.ingreso
								FROM (SELECT orden, SUM(pagado) as ingreso 
										FROM movimis GROUP BY orden) sq 
									   WHERE hacienda.orden=sq.orden AND hacienda.orden<899999999999")

			'Actualizar desde movimis en Hacienda (egresos)
			sqlModify.Append("UPDATE hacienda SET hacienda.gastado=sq.egreso
								FROM (SELECT orden, SUM(pagado) as egreso 
										FROM movimis GROUP BY orden) sq 
									   WHERE hacienda.orden=sq.orden AND hacienda.orden>899999999999")

			'Será necesario usar For o se puede hacer una consulta para actuailzar todos los campos de mes juntos?
			'nested query por mes por ej
			'Separar ingresos y consolidar
			For m = 1 To Month(Date.Today)
				Dim current_month As String = "mes" & m
				'Ingresos
				sqlModify.Append(
						  "UPDATE hacienda SET hacienda." & current_month & "=sq.ingreso_" & current_month & "
							 FROM (SELECT orden, SUM(pagado) as ingreso_" & current_month & " 
									 FROM movimis WHERE MONTH(fecha)=" & m & " AND movimis.orden<899999999999
								 GROUP BY orden) sq 
							WHERE hacienda.orden=sq.orden")
				'Egresos
				sqlModify.Append(
						 "UPDATE hacienda SET hacienda." & current_month & "=sq.egreso_" & current_month & "
							FROM (SELECT orden, SUM(pagado) as egreso_" & current_month & " 
									FROM movimis WHERE MONTH(fecha)=" & m & " AND movimis.orden>899999999999
								GROUP BY orden) sq 
							WHERE hacienda.orden=sq.orden")
			Next

			'Copiar a ingresos (incluyendo cuentas madre)
			sqlModify.Append(
						"INSERT INTO ingresos(nombre, pertenece, anexo, inciso, item, rubro, subrubro, 
											 partida, subpartida, autorizado, orden, sumado, 
											 mes1, mes2, mes3, mes4, mes5, mes6, mes7, mes8, mes9, mes10, mes11, mes12,
											 sumatodo, gastado, gastomes, fecha)
							SELECT nombre, pertenece, anexo, inciso, item, rubro, subrubro,
							partida, subpartida, autorizado, orden, sumado, 
							mes1, mes2, mes3, mes4, mes5, mes6, mes7, mes8, mes9, mes10, mes11, mes12,
							sumatodo, gastado, gastomes, DATE()
							FROM hacienda WHERE hacienda.orden<899999999999")

			'Copiar a egresos (incluyendo cuentas madre)
			sqlModify.Append(
						"INSERT INTO egresos(nombre, pertenece, anexo, inciso, item, rubro, subrubro, 
											 partida, subpartida, autorizado, orden, sumado, 
											 mes1, mes2, mes3, mes4, mes5, mes6, mes7, mes8, mes9, mes10, mes11, mes12,
											 sumatodo, gastado, gastomes, fecha)
							SELECT nombre, pertenece, anexo, inciso, item, rubro, subrubro,
							partida, subpartida, autorizado, orden, sumado, 
							mes1, mes2, mes3, mes4, mes5, mes6, mes7, mes8, mes9, mes10, mes11, mes12,
							sumatodo, gastado, gastomes, DATE()
							FROM hacienda WHERE hacienda.orden>899999999999")

			''Consolidar cuentas Egresos
			''Subpartida
			sqlModify.Append(
						"UPDATE egresos SET egresos.gastado=sq.total_egreso
							FROM (SELECT pertenece, anexo, inciso, item, rubro, subrubro, partida, subpartida, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso, item, rubro, subrubro, partida, subpartida 
							WHERE pertenece='9' AND subpartida<>'00') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item=sq.item AND egresos.rubro=sq.rubro 
							AND egresos.subrubro=sq.subrubro AND egresos.partida=sq.partida 
							AND egresos.subpartida=sq.subpartida")

			''Partida
			sqlModify.Append(
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, subrubro, partida, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso, item, rubro, subrubro, partida 
							WHERE pertenece='9' AND partida<>'00') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item=sq.item AND egresos.rubro=sq.rubro 
							AND egresos.subrubro=sq.subrubro AND egresos.partida=sq.partida 
							AND egresos.subpartida='00'")

			''Subrubro
			sqlModify.Append(
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, subrubro, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso, item, rubro, subrubro 
							WHERE pertenece='9' AND subrubro<>'00') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item=sq.item AND egresos.rubro=sq.rubro 
							AND egresos.subrubro=sq.subrubro AND egresos.partida='00'")

			''Rubro
			sqlModify.Append(
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso, item, rubro 
							WHERE pertenece='9' AND rubro<>'00') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item=sq.item AND egresos.rubro=sq.rubro 
							AND egresos.subrubro='00'")

			''Item
			sqlModify.Append(
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, item, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso, item 
							WHERE pertenece='9' AND item<>'0') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item=sq.item AND egresos.rubro='00'")

			''Inciso
			sqlModify.Append(
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso 
							WHERE pertenece='9' AND inciso<>'0') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item='0'")

			''Anexo
			sqlModify.Append(
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo 
							WHERE pertenece='9' AND anexo<>'0') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso='0'")

			''Consolidar cuentas Ingresos
			''Subpartida
			sqlModify.Append(
						"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, subrubro, partida, subpartida, SUM(sumatodo) as total_ingreso 
							FROM ingresos GROUP BY pertenece, anexo, inciso, item, rubro, subrubro, partida, subpartida 
							WHERE pertenece='8' AND subpartida<>'00') sq 
						WHERE ingresos.pertenece=sq.pertenece 
							AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
							AND ingresos.item=sq.item AND ingresos.rubro=sq.rubro 
							AND ingresos.subrubro=sq.subrubro AND ingresos.partida=sq.partida 
							AND ingresos.subpartida=sq.subpartida")

			''Partida
			sqlModify.Append(
						"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, subrubro, partida, SUM(sumatodo) as total_ingreso 
							FROM ingresos GROUP BY pertenece, anexo, inciso, item, rubro, subrubro, partida 
							WHERE pertenece='8' AND partida<>'00') sq 
						WHERE ingresos.pertenece=sq.pertenece 
							AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
							AND ingresos.item=sq.item AND ingresos.rubro=sq.rubro 
							AND ingresos.subrubro=sq.subrubro AND ingresos.partida=sq.partida 
							AND ingresos.subpartida='00'")

			''Subrubro
			sqlModify.Append(
						"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, subrubro, SUM(sumatodo) as total_ingreso 
							FROM ingresos GROUP BY pertenece, anexo, inciso, item, rubro, subrubro 
							WHERE pertenece='8' AND subrubro<>'00') sq 
						WHERE ingresos.pertenece=sq.pertenece 
							AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
							AND ingresos.item=sq.item AND ingresos.rubro=sq.rubro 
							AND ingresos.subrubro=sq.subrubro AND ingresos.partida='00'")

			''Rubro
			sqlModify.Append(
						"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, SUM(sumatodo) as total_ingreso 
							FROM ingresos GROUP BY pertenece, anexo, inciso, item, rubro 
							WHERE pertenece='8' AND rubro<>'00') sq 
							WHERE ingresos.pertenece=sq.pertenece 
							AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
							AND ingresos.item=sq.item AND ingresos.rubro=sq.rubro 
							AND ingresos.subrubro='00'")

			''Item
			sqlModify.Append(
						"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
							FROM (SELECT pertenece, anexo, inciso, item, SUM(sumatodo) as total_ingreso 
							FROM ingresos GROUP BY pertenece, anexo, inciso, item 
							WHERE pertenece='8' AND item<>'0') sq 
						WHERE ingresos.pertenece=sq.pertenece 
						AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
						AND ingresos.item=sq.item AND ingresos.rubro='00'")

			''Inciso
			sqlModify.Append(
					"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
						FROM (SELECT pertenece, anexo, inciso, SUM(sumatodo) as total_ingreso 
						FROM ingresos GROUP BY pertenece, anexo, inciso 
						WHERE pertenece='8' AND inciso<>'0') sq 
					WHERE ingresos.pertenece=sq.pertenece 
						AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
						AND ingresos.item='0'")

			''Anexo
			sqlModify.Append(
					"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
						FROM (SELECT pertenece, anexo, SUM(sumatodo) as total_ingreso 
						FROM ingresos GROUP BY pertenece, anexo 
						WHERE pertenece='8' AND anexo<>'0') sq 
					WHERE ingresos.pertenece=sq.pertenece 
						AND ingresos.anexo=sq.anexo AND ingresos.inciso='0'")


			DbMan.EditDB(sqlModify, My.Settings.foxConnection)

			MsgBox("Terminado.")
			Return True
		Else
			Return False
		End If

	End Function
End Class
