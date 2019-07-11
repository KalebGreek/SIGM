Public Class Hacienda
    Shared Sub FillSeccion(ByRef bs As BindingSource, ByRef target As ComboBox)
        Dim sql(0) As String
        sql(0) = "SELECT * FROM seccion ORDER BY descripcion"
        bs.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
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

        bs.DataSource = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)


        CtrlMan.Fill.SetAutoComplete(target, bs, "nombre", "orden")
	End Sub
	Shared Function ConsolidarCuentas(fecha As Date) As Boolean

		If MsgBoxResult.Yes = MsgBox("Se calculará al mes de " & fecha.ToString("y"),
									 MsgBoxStyle.YesNo, "Calcular ingresos y egresos consolidados") Then

			'Reset
			DbMan.editDB(Nothing, My.Settings.foxConnection, "UPDATE hacienda SET MES1=0, MES2=0, MES3=0, MES4=0, MES5=0, 
						MES6=0, MES7=0, MES8=0, MES9=0, MES10=0, MES11=0, MES12=0, 
						SUMATODO=0, GASTADO=0, GASTOMES=0")

			DbMan.editDB(Nothing, My.Settings.foxConnection, "DELETE FROM ingresos") 'Fox no necesita comodín
			DbMan.editDB(Nothing, My.Settings.foxConnection, "DELETE FROM egresos")

			'Actualizar desde movimis en Hacienda (ingresos)
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE hacienda SET hacienda.sumatodo=sq.ingreso
						FROM 
							(SELECT orden, SUM(pagado) as ingreso 
							 FROM movimis GROUP BY orden) sq 
						WHERE hacienda.orden=sq.orden AND hacienda.orden<899999999999")

			'Actualizar desde movimis en Hacienda (egresos)
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE hacienda SET hacienda.gastado=sq.egreso
						FROM 
							(SELECT orden, SUM(pagado) as egreso 
							 FROM movimis GROUP BY orden) sq 
						WHERE hacienda.orden=sq.orden AND hacienda.orden>899999999999")

			'Será necesario usar For o se puede hacer una consulta para actuailzar todos los campos de mes juntos?
			'nested query por mes por ej
			'Separar ingresos y consolidar
			For m = 1 To Month(Date.Today)
				Dim current_month As String = "mes" & m
				'Ingresos
				DbMan.editDB(Nothing, My.Settings.foxConnection,
						  "UPDATE hacienda SET hacienda." & current_month & "=sq.ingreso_" & current_month & "
							 FROM (SELECT orden, SUM(pagado) as ingreso_" & current_month & " 
								 FROM movimis WHERE MONTH(fecha)=" & m & " AND movimis.orden<899999999999
								 GROUP BY orden) sq 
							WHERE hacienda.orden=sq.orden")
				'Egresos
				DbMan.editDB(Nothing, My.Settings.foxConnection,
						 "UPDATE hacienda SET hacienda." & current_month & "=sq.egreso_" & current_month & "
							FROM (SELECT orden, SUM(pagado) as egreso_" & current_month & " 
								 FROM movimis WHERE MONTH(fecha)=" & m & " AND movimis.orden>899999999999
								 GROUP BY orden) sq 
							WHERE hacienda.orden=sq.orden")
			Next

			'Copiar a ingresos (incluyendo cuentas madre)
			DbMan.editDB(Nothing, My.Settings.foxConnection,
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
			DbMan.editDB(Nothing, My.Settings.foxConnection,
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
			DbMan.editDB(Nothing, My.Settings.foxConnection,
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
			DbMan.editDB(Nothing, My.Settings.foxConnection,
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
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, subrubro, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso, item, rubro, subrubro 
							WHERE pertenece='9' AND subrubro<>'00') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item=sq.item AND egresos.rubro=sq.rubro 
							AND egresos.subrubro=sq.subrubro AND egresos.partida='00'")

			''Rubro
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso, item, rubro 
							WHERE pertenece='9' AND rubro<>'00') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item=sq.item AND egresos.rubro=sq.rubro 
							AND egresos.subrubro='00'")

			''Item
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, item, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso, item 
							WHERE pertenece='9' AND item<>'0') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item=sq.item AND egresos.rubro='00'")

			''Inciso
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, inciso, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo, inciso 
							WHERE pertenece='9' AND inciso<>'0') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso=sq.inciso 
							AND egresos.item='0'")

			''Anexo
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE egresos SET egresos.gastado=sq.total_egreso 
							FROM (SELECT pertenece, anexo, SUM(gastado) as total_egreso 
							FROM egresos GROUP BY pertenece, anexo 
							WHERE pertenece='9' AND anexo<>'0') sq 
						WHERE egresos.pertenece=sq.pertenece 
							AND egresos.anexo=sq.anexo AND egresos.inciso='0'")

			''Consolidar cuentas Ingresos
			''Subpartida
			DbMan.editDB(Nothing, My.Settings.foxConnection,
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
			DbMan.editDB(Nothing, My.Settings.foxConnection,
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
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, subrubro, SUM(sumatodo) as total_ingreso 
							FROM ingresos GROUP BY pertenece, anexo, inciso, item, rubro, subrubro 
							WHERE pertenece='8' AND subrubro<>'00') sq 
						WHERE ingresos.pertenece=sq.pertenece 
							AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
							AND ingresos.item=sq.item AND ingresos.rubro=sq.rubro 
							AND ingresos.subrubro=sq.subrubro AND ingresos.partida='00'")

			''Rubro
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
							FROM (SELECT pertenece, anexo, inciso, item, rubro, SUM(sumatodo) as total_ingreso 
							FROM ingresos GROUP BY pertenece, anexo, inciso, item, rubro 
							WHERE pertenece='8' AND rubro<>'00') sq 
							WHERE ingresos.pertenece=sq.pertenece 
							AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
							AND ingresos.item=sq.item AND ingresos.rubro=sq.rubro 
							AND ingresos.subrubro='00'")

			''Item
			DbMan.editDB(Nothing, My.Settings.foxConnection,
						"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
							FROM (SELECT pertenece, anexo, inciso, item, SUM(sumatodo) as total_ingreso 
							FROM ingresos GROUP BY pertenece, anexo, inciso, item 
							WHERE pertenece='8' AND item<>'0') sq 
						WHERE ingresos.pertenece=sq.pertenece 
						AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
						AND ingresos.item=sq.item AND ingresos.rubro='00'")

			''Inciso
			DbMan.editDB(Nothing, My.Settings.foxConnection,
					"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
						FROM (SELECT pertenece, anexo, inciso, SUM(sumatodo) as total_ingreso 
						FROM ingresos GROUP BY pertenece, anexo, inciso 
						WHERE pertenece='8' AND inciso<>'0') sq 
					WHERE ingresos.pertenece=sq.pertenece 
						AND ingresos.anexo=sq.anexo AND ingresos.inciso=sq.inciso 
						AND ingresos.item='0'")

			''Anexo
			DbMan.editDB(Nothing, My.Settings.foxConnection,
					"UPDATE ingresos SET ingresos.sumatodo=sq.total_ingreso 
						FROM (SELECT pertenece, anexo, SUM(sumatodo) as total_ingreso 
						FROM ingresos GROUP BY pertenece, anexo 
						WHERE pertenece='8' AND anexo<>'0') sq 
					WHERE ingresos.pertenece=sq.pertenece 
						AND ingresos.anexo=sq.anexo AND ingresos.inciso='0'")

			MsgBox("done")
			Return True
		Else
			Return False
		End If

	End Function
End Class
