Public Class Catastro
	Shared sqlSelect, sqlFrom, sqlWhere, sqlGroupBy, sqlHaving, sqlOrderBy As String

	'** READ ONLY **
	Shared CatastroSelect _
	As String = "SELECT persona.id as titular_id, persona.razon as titular, persona.cuil, persona.difunto, persona.fisica,
				catastro.zona, catastro.circ, catastro.secc, catastro.manz, catastro.parc, catastro.lote,
                catastro.id as catastro_id, catastro.cuenta, 
                cat_frente.calle, cat_frente.altura, 
                catastro.barrio, catastro.uso, cat_frente.ubicacion,
                oprivadas.id as opr_id, oprivadas.expediente,
                catastro.archivado, catastro.user_id as user_id"

	Shared CatastroFrom _
	As String = " FROM (oprivadas INNER JOIN (persona INNER JOIN (catastro INNER JOIN titular_catastro
				ON catastro.Id = titular_catastro.cat_id) ON persona.id = titular_catastro.per_id)
                ON oprivadas.Id = catastro.opr_id) INNER JOIN cat_frente
                ON catastro.Id = cat_frente.catastro_id"

	Shared CatastroWhere As String = " WHERE ubicacion=True"

	Shared CatastroInsert As String
	Shared CatastroUpdate As String
	Shared CatastroDelete As String = "DELETE DISTINCTROW catastro.*
                                  FROM ((((catastro LEFT JOIN cat_documento ON catastro.Id = cat_documento.catastro_id)
                                  LEFT JOIN cat_frente ON catastro.Id = cat_frente.catastro_id) 
                                  LEFT JOIN cat_servicio ON catastro.Id = cat_servicio.catastro_id)
                                  LEFT JOIN cat_superficie ON catastro.Id = cat_superficie.catastro_id)
                                  LEFT JOIN titular_catastro ON catastro.Id = titular_catastro.cat_id"
    '** /READ ONLY **


    ' SEARCH
    Shared Function BuscarPorTitular(Optional razon As String = "", Optional cuil As Double = 0) As DataTable
        Dim sql(3) As String
        sql(0) = CatastroSelect
        sql(1) = CatastroFrom
        sql(2) = CatastroWhere

        If Len(cuil) = 11 Then
            sql(2) += " And persona.cuil='" & cuil & "'"
            sql(3) = " ORDER BY catastro.id ASC"
        ElseIf razon <> "" And Len(razon) > 2 Then
            sql(2) += " AND persona.razon LIKE '%" & razon & "%'"
            sql(3) = " ORDER BY persona.razon"
        Else
            sql(3) = " ORDER BY catastro.id ASC"
        End If

        Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
    End Function
	Shared Function BuscarPorPartida(Optional zona As Integer = 0, Optional circ As Integer = 0, Optional secc As Integer = 0,
									 Optional manz As Integer = 0, Optional parc As Integer = 0, Optional lote As Integer = 0) As DataTable

        Dim sql(3) As String
        sql(0) = CatastroSelect
        sql(1) = CatastroFrom
        sql(2) = CatastroWhere

        If zona > 0 Then
            sql(2) += " AND catastro.zona=" & zona
            If circ > 0 Then
                sql(2) += " AND catastro.circ=" & circ
                If secc > 0 Then
                    sql(2) += " AND catastro.secc=" & secc
                    If manz > 0 Then
                        sql(2) += " AND catastro.manz=" & manz
                    End If
					If parc > 0 Then
                        sql(2) += " AND catastro.parc=" & parc
                    End If
					If lote > 0 Then
                        sql(2) += " AND catastro.lote=" & lote
                    End If
				End If
			End If
		End If
        sql(3) = " ORDER BY catastro.id ASC"

        Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
    End Function
    Shared Function BuscarPorDireccion(Optional calle As String = "", Optional barrio As String = "") As DataTable

        Dim sql(3) As String
        sql(0) = CatastroSelect
        sql(1) = CatastroFrom
        sql(2) = CatastroWhere

        If calle <> "" And Len(calle) > 2 Then
            sql(2) += " AND cat_frente.calle LIKE '%" & calle & "%'"
            sql(3) = " ORDER BY cat_frente.calle"
        ElseIf barrio <> "" And Len(barrio) > 2 Then
            sql(2) += " AND catastro.barrio LIKE '%" & barrio & "%'"
            sql(3) = " ORDER BY catastro.barrio"
        Else
            sql(3) = " ORDER BY catastro.id ASC"
        End If

        Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
    End Function

    ' 'READ
    Shared Function ListarInmueblePorTitular(persona_id As Integer) As DataTable
        Dim sql(3) As String
        sql(0) = CatastroSelect
        sql(1) = CatastroFrom
        sql(2) = CatastroWhere

        If persona_id > 0 Then
            sql(2) += " AND persona.id=" & persona_id
        End If
        Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
    End Function
	Shared Function ListarInmueblePorExpediente(expediente As Integer) As DataTable
        Dim sql(3) As String
        sql(0) = CatastroSelect
        sql(1) = CatastroFrom
        sql(2) = CatastroWhere

        If expediente > 0 Then
            sql(2) += " AND oprivadas.expediente=" & expediente
        End If
        Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
    End Function
	Shared Function Seleccionar(cat_id As Integer) As DataTable
        If cat_id > 0 Then
            Dim sql(3) As String
            sql(0) = CatastroSelect
            sql(1) = CatastroFrom
            sql(2) = " WHERE catastro.id=" & cat_id

            Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
        Else
            Return Nothing
		End If
	End Function
	Shared Function SeleccionarPartida(zona As Integer, circ As Integer, secc As Integer,
										  manz As Integer, parc As Integer, lote As Integer) As Integer
        Dim id As Integer = 0


        If zona > 0 And circ > 0 And secc > 0 And manz > 0 And parc > 0 Then
            Dim sql(3) As String
            sql(0) = "SELECT catastro.id as catastro_id"
            sql(1) = "FROM catastro"
            sql(2) = "WHERE catastro.zona=" & zona & " AND catastro.circ=" & circ & " AND catastro.secc=" & secc &
                       " AND catastro.manz=" & manz & " AND catastro.parc=" & parc & " AND catastro.lote=" & lote

            Dim dtab As DataTable = DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
            If dtab Is Nothing = False Then
                If dtab.Rows.Count > 0 Then
                    id = dtab(0)("catastro_id")
                End If
            End If
        Else
            id = -1
        End If
        Return id
    End Function
	Shared Function ListarFrente(catastro_id As Integer, Optional ubicacion As Boolean = False) As Object
        Dim sql(3) As String
        If ubicacion Then
            sql(0) = "SELECT calle, altura"
            sql(1) = "FROM cat_frente"
            sql(2) = " WHERE catastro_id=" & catastro_id & " AND ubicacion=True"

            Dim dtab As DataTable = DbMan.readDB(Nothing, My.Settings.CurrentDB, Sql)
            If dtab Is Nothing Then
                Return " S/N "
            Else
                Return dtab(0)("calle") & " " & dtab(0)("altura").ToString
            End If
        Else
            sql(0) = "SELECT id as frente_id, calle, altura, metros, ubicacion"
            sql(1) = "FROM cat_frente"
            sql(2) = "WHERE catastro_id=" & catastro_id

            Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
        End If
	End Function


    'MOD
    Public Class Agregar
		Shared Sub Inmueble(opr_id As Integer, ByRef catastro_id As Integer, titular_id As Integer,
									  barrio As String, uso As String, cuenta As Integer, archivado As Boolean,
									  zona As Integer, circ As Integer, secc As Integer,
									  manz As Integer, parc As Integer, lote As Integer)
			'Agregar

			DbMan.editDB(Nothing, My.Settings.CurrentDB,
								"INSERT INTO catastro(user_id, opr_id, zona, circ, secc, manz, parc, lote, barrio, uso, cuenta, archivado) " &
								" VALUES(" & My.Settings.UserId & "," & opr_id & ", " & zona & ", " & circ & ", " & secc & "," &
								" " & manz & ", " & parc & ", " & lote & ",'" & barrio & "', '" & uso & "', " & cuenta &
								"," & archivado & ")")
			'leer ultimo inmueble
			catastro_id = Catastro.SeleccionarPartida(zona, circ, secc, manz, parc, lote)

			If catastro_id > 0 And titular_id > 0 Then
                'Guardar titular
                DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM titular_catastro WHERE cat_id=" & catastro_id)
				DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO titular_catastro(cat_id, per_id)" &
															" VALUES(" & catastro_id & ", " & titular_id & ")")
			End If
		End Sub
		Shared Sub Frente(catastro_id As Integer, calle As String, altura As Integer, metros As Decimal)
			DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO cat_frente(catastro_id, calle, altura, metros)" &
				 										" VALUES(" & catastro_id & ",'" & calle & "', " & altura & "," &
														" '" & metros & "')")
		End Sub
		Shared Sub Superficie(catastro_id As Integer,
								 existente As Decimal, relevamiento As Decimal,
								 proyecto As Decimal, terreno As Decimal)
            'cat_superficie
            DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM cat_superficie WHERE catastro_id=" & catastro_id)

			DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO cat_superficie(catastro_id, existente, proyecto, relevamiento, terreno)" &
														" VALUES(" & catastro_id & ", '" & existente & "', '" & proyecto & "'," &
														" '" & relevamiento & "', '" & terreno & "')")

		End Sub
		Shared Sub Caracteristica(bs_car As BindingSource, catastro_id As Integer)
            'cat_servicio
            DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM cat_servicio WHERE catastro_id=" & catastro_id)
			With bs_car
				For fila As Integer = 0 To .Count - 1
					.Position = fila
					DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO cat_servicio(catastro_id, descripcion, activo)" &
							  " VALUES(" & catastro_id & ",'" & .Current("descripcion") & "', " & .Current("activo") & ")")
				Next
			End With
		End Sub
		Shared Sub Documento(bs_copia As BindingSource, catastro_id As Integer)
            'cat_documento
            DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM cat_documento WHERE catastro_id=" & catastro_id)
			With bs_copia
				For fila As Integer = 0 To .Count - 1
					.Position = fila
					DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO cat_documento(catastro_id, descripcion, fecha, ruta)" &
						  " VALUES(" & catastro_id & ",'" & .Current("descripcion") & "'," &
						  " '" & .Current("fecha") & "', '" & .Current("ruta") & "')")
				Next
			End With
		End Sub
	End Class
	Public Class Modificar
		Shared Sub Inmueble(opr_id As Integer, ByRef catastro_id As Integer, titular_id As Integer,
										barrio As String, uso As String, cuenta As Integer, archivado As Boolean,
										zona As Integer, circ As Integer, secc As Integer,
										manz As Integer, parc As Integer, lote As Integer)

			'Modificar
			DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE catastro SET user_id=" & My.Settings.UserId & ", opr_id=" & opr_id & ", " &
					  " barrio='" & barrio & "', uso='" & uso & "', cuenta=" & Val(cuenta) &
					  " WHERE id=" & catastro_id)

			If catastro_id > 0 And titular_id > 0 Then
                'Guardar titular
                DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM titular_catastro WHERE cat_id=" & catastro_id)
				DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO titular_catastro(cat_id, per_id)" &
							   " VALUES(" & catastro_id & ", " & titular_id & ")")
			End If
		End Sub
		Shared Sub Ubicacion(bs_frente As BindingSource, catastro_id As Integer)
			DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE cat_frente SET ubicacion=False WHERE catastro_id=" & catastro_id)
			DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE cat_frente SET ubicacion=True WHERE id=" & bs_frente.Current.Row("frente_id"))
		End Sub
	End Class
	Public Class Eliminar
		Shared Sub Inmueble(catastro_id As Integer, user_id As Integer)
            If user_id > 0 Then 'Solo el usuario que bloqueo el inmueble puede eliminarlo
                Dim sql(3) As String
                sql(0) = "SELECT *"
                sql(1) = "FROM catastro"
                sql(2) = "WHERE id=" & catastro_id & " AND user_id=" & user_id
                Dim dtab As DataTable = DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
                If dtab.Rows.Count > 0 Then
                    DbMan.editDB(Nothing,
                               My.Settings.CurrentDB,
                               CatastroDelete & " WHERE catastro.id=" & catastro_id & " AND catastro.user_id=" & user_id)
                Else
                    MsgBox("Registro bloqueado.")
                End If
            End If
        End Sub
		Shared Sub Frente(bs_frente As BindingSource, catastro_id As Integer)
			'Eliminar registro
			DbMan.editDB(Nothing,
					   My.Settings.CurrentDB,
					   "DELETE * FROM cat_frente WHERE id=" & bs_frente.Current.Row("frente_id"))
		End Sub
	End Class
    ' ROUTINES
    Shared Sub CalcularSuperficie(ByRef existente As Decimal, ByRef proyecto As Decimal,
								  ByRef relevamiento As Decimal, ByRef terreno As Decimal,
								  ByRef libre As Decimal, ByRef cubierto As Decimal)

		cubierto = proyecto + relevamiento + existente
		If terreno <= cubierto Then
			libre = 0
		Else
			libre = terreno - cubierto
		End If
	End Sub

End Class