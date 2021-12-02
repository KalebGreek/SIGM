Class Catastro
    'Shared sqlSelect, sqlFrom, sqlWhere, sqlGroupBy, sqlHaving, sqlOrderBy As String

    '** READ ONLY **
    Const CatastroSelect _
    As String = "SELECT persona.id as titular_id, persona.razon as titular, persona.cuil, persona.difunto, persona.fisica,
				catastro.zona, catastro.circ, catastro.secc, catastro.manz, catastro.parc, catastro.lote,
                catastro.id as catastro_id, catastro.cuenta, 
                cat_frente.calle, cat_frente.altura, 
                catastro.barrio, catastro.uso, cat_frente.ubicacion,
                oprivadas.id as opr_id, oprivadas.expediente,
                catastro.archivado, catastro.user_id as user_id"

    Const CatastroFrom _
    As String = " FROM (oprivadas INNER JOIN (persona INNER JOIN (catastro INNER JOIN titular_catastro
				ON catastro.Id = titular_catastro.cat_id) ON persona.id = titular_catastro.per_id)
                ON oprivadas.Id = catastro.opr_id) INNER JOIN cat_frente
                ON catastro.Id = cat_frente.catastro_id"

    Const CatastroWhere As String = " WHERE ubicacion=True"

    'Shared CatastroInsert As String
    'Shared CatastroUpdate As String
    Const CatastroDelete As String = "DELETE DISTINCTROW catastro.*
                                  FROM ((((catastro LEFT JOIN cat_documento ON catastro.Id = cat_documento.catastro_id)
                                  LEFT JOIN cat_frente ON catastro.Id = cat_frente.catastro_id) 
                                  LEFT JOIN cat_servicio ON catastro.Id = cat_servicio.catastro_id)
                                  LEFT JOIN cat_superficie ON catastro.Id = cat_superficie.catastro_id)
                                  LEFT JOIN titular_catastro ON catastro.Id = titular_catastro.cat_id"
    '** /READ ONLY **


    ' SEARCH
    Shared Function BuscarPorTitular(Optional razon As String = "", Optional cuil As Double = 0) As DataTable
        Dim sqlSelect As String
        sqlSelect = CatastroSelect
        sqlSelect &= CatastroFrom
        sqlSelect &= CatastroWhere

        If Len(cuil) = 11 Then
            sqlSelect &= " And persona.cuil='" & cuil & "'"
            sqlSelect &= " ORDER BY catastro.id ASC"
        ElseIf razon <> "" And Len(razon) > 2 Then
            sqlSelect &= " AND persona.razon LIKE '%" & razon & "%'"
            sqlSelect &= " ORDER BY persona.razon"
        Else
            sqlSelect &= " ORDER BY catastro.id ASC"
        End If

        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
    End Function
    Shared Function BuscarPorPartida(Optional zona As Integer = 0, Optional circ As Integer = 0, Optional secc As Integer = 0,
                                     Optional manz As Integer = 0, Optional parc As Integer = 0, Optional lote As Integer = 0) As DataTable

        Dim sqlSelect As String
        sqlSelect = CatastroSelect
        sqlSelect &= CatastroFrom
        sqlSelect &= CatastroWhere

        If zona > 0 Then
            sqlSelect &= " AND catastro.zona=" & zona
            If circ > 0 Then
                sqlSelect &= " AND catastro.circ=" & circ
                If secc > 0 Then
                    sqlSelect &= " AND catastro.secc=" & secc
                    If manz > 0 Then
                        sqlSelect &= " AND catastro.manz=" & manz
                    End If
                    If parc > 0 Then
                        sqlSelect &= " AND catastro.parc=" & parc
                    End If
                    If lote > 0 Then
                        sqlSelect &= " AND catastro.lote=" & lote
                    End If
                End If
            End If
        End If
        sqlSelect &= " ORDER BY catastro.id ASC"

        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
    End Function
    Shared Function BuscarPorDireccion(Optional calle As String = "", Optional barrio As String = "") As DataTable

        Dim sqlSelect As String
        sqlSelect = CatastroSelect
        sqlSelect &= CatastroFrom
        sqlSelect &= CatastroWhere

        If calle <> "" And Len(calle) > 2 Then
            sqlSelect &= " AND cat_frente.calle LIKE '%" & calle & "%'"
            sqlSelect &= " ORDER BY cat_frente.calle"
        ElseIf barrio <> "" And Len(barrio) > 2 Then
            sqlSelect &= " AND catastro.barrio LIKE '%" & barrio & "%'"
            sqlSelect &= " ORDER BY catastro.barrio"
        Else
            sqlSelect &= " ORDER BY catastro.id ASC"
        End If

        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
    End Function

    ' 'READ
    Shared Function ListarInmueblePorTitular(personaId As Integer) As DataTable
        Dim sqlSelect As String
        sqlSelect = CatastroSelect
        sqlSelect &= CatastroFrom
        sqlSelect &= CatastroWhere

        If personaId > 0 Then
            sqlSelect += " AND persona.id=" & personaId
        End If
        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
    End Function
    Shared Function ListarInmueblePorExpediente(expediente As Integer) As DataTable
        Dim sqlSelect As String
        sqlSelect = CatastroSelect
        sqlSelect &= CatastroFrom
        sqlSelect &= CatastroWhere

        If expediente > 0 Then
            sqlSelect &= " AND oprivadas.expediente=" & expediente
        End If
        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
    End Function
    Shared Function Seleccionar(catastroId As Integer) As DataRow
        If catastroId > 0 Then
            Dim sqlSelect As String
            sqlSelect = CatastroSelect
            sqlSelect &= CatastroFrom
            sqlSelect &= " WHERE catastro.id=" & catastroId

            Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)(0)
        Else
            Return Nothing
        End If
    End Function
    Shared Function SeleccionarPartida(zona As Integer, circ As Integer, secc As Integer,
                                          manz As Integer, parc As Integer, lote As Integer) As Integer
        Dim id As Integer = -1
        If zona > 0 And circ > 0 And secc > 0 And manz > 0 And parc > 0 Then
            Dim sqlSelect As String
            sqlSelect = "SELECT catastro.id as catastro_id
                           FROM catastro
                          WHERE catastro.zona=" & zona & " AND catastro.circ=" & circ & " AND catastro.secc=" & secc & "
                            AND catastro.manz=" & manz & " AND catastro.parc=" & parc & " AND catastro.lote=" & lote

            id = CInt(DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)(0)("catastro_id"))
        End If
        If id = Nothing Then
            id = -1
        End If
        Return id

    End Function
    Shared Function ListarFrente(catastroId As Integer, Optional ubicacion As Boolean = False) As Object
        Dim sqlSelect As String
        If ubicacion Then
            sqlSelect = "SELECT calle, altura"
            sqlSelect &= " FROM cat_frente"
            sqlSelect &= " WHERE catastro_id=" & catastroId & " And ubicacion=True"

            Dim dtab As DataTable = DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
            If dtab Is Nothing Then
                Return " S/N "
            Else
                Return dtab.Rows(0)("calle").ToString & " " & dtab.Rows(0)("altura").ToString
            End If
        Else
            sqlSelect = "SELECT id As frente_id, calle, altura, metros, ubicacion"
            sqlSelect &= " FROM cat_frente"
            sqlSelect &= " WHERE catastro_id=" & catastroId

            Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
        End If
    End Function


    'MOD
    Class Agregar
        Shared Sub Inmueble(oprId As Integer, ByRef catastroId As Integer, titularId As Integer,
                                      barrio As String, uso As String, cuenta As Integer, archivado As Boolean,
                                      zona As Integer, circ As Integer, secc As Integer,
                                      manz As Integer, parc As Integer, lote As Integer)
            'Agregar
            Dim sqlInsert As String
            sqlInsert = "INSERT INTO catastro(user_id, opr_id, zona, circ, secc, manz, parc, lote, barrio, uso, cuenta, archivado) 
                              VALUES(" & My.Settings.UserId & "," & oprId & ", " & zona & ", " & circ & ", " & secc & "," &
                                     manz & ", " & parc & ", " & lote & ",'" & barrio & "', '" & uso & "', " & cuenta & "," & archivado & ")"
            DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)

            'leer ultimo inmueble
            catastroId = Catastro.SeleccionarPartida(zona, circ, secc, manz, parc, lote)

            Titular(catastroId, titularId)
        End Sub
        Shared Sub Titular(ByRef catastroId As Integer, titularId As Integer)
            If catastroId > 0 And titularId > 0 Then
                'Guardar titular
                DbMan.EditDB("DELETE * FROM titular_catastro WHERE cat_id=" & catastroId,
                             My.Settings.CurrentDB)

                DbMan.EditDB("INSERT INTO titular_catastro(cat_id, per_id)
                                   VALUES(" & catastroId & ", " & titularId & ")",
                             My.Settings.CurrentDB)
            End If

        End Sub
        Shared Sub Frente(catastroId As Integer, calle As String, altura As Integer, metros As Decimal)
            DbMan.EditDB("INSERT INTO cat_frente(catastro_id, calle, altura, metros)
                                VALUES(" & catastroId & ",'" & calle & "', " & altura & ",
                                      '" & metros & "')",
                          My.Settings.CurrentDB)
        End Sub
        Shared Sub Superficie(catastroId As Integer,
                                 existente As Decimal, relevamiento As Decimal,
                                 proyecto As Decimal, terreno As Decimal)

            'cat_superficie
            DbMan.EditDB("DELETE * FROM cat_superficie WHERE catastro_id=" & catastroId,
                         My.Settings.CurrentDB)

            DbMan.EditDB("INSERT INTO cat_superficie(catastro_id, existente, proyecto, relevamiento, terreno)
                               VALUES(" & catastroId & ", '" & existente & "', '" & proyecto & "', 
                                      " & " '" & relevamiento & "', '" & terreno & "')", 
                         My.Settings.CurrentDB)

        End Sub
        Shared Sub Caracteristica(registro As DataTable, CatastroId As Integer)
            Dim sqlInsert As String = ""
            'cat_servicio
            DbMan.EditDB("DELETE * FROM cat_servicio WHERE catastro_id=" & CatastroId,
                         My.Settings.CurrentDB)

            For Each dr As DataRow In registro.Rows
                sqlInsert = "INSERT INTO cat_servicio(catastro_id, descripcion, activo)
                                  VALUES(" & CatastroId.ToString & ",'" &
                                         dr("descripcion").ToString & "', " &
                                         dr("activo").ToString & ")"
            Next
            DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)
        End Sub
        Shared Sub Documento(registro As DataTable, catastroId As Integer)
            Dim sqlInsert As String = ""
            'cat_documento
            DbMan.EditDB("DELETE * FROM cat_documento WHERE catastro_id=" & catastroId, My.Settings.CurrentDB)

            For Each dr As DataRow In registro.Rows
                sqlInsert = "INSERT INTO cat_documento(catastro_id, descripcion, fecha, ruta) 
                                  VALUES(" & catastroId & ",'" & dr("descripcion").ToString & "',
                                        '" & dr("fecha").ToString & "', '" & dr("ruta").ToString & "')"
            Next
            DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)

        End Sub
    End Class
    Class Modificar
        Shared Sub Inmueble(OprId As Integer, ByRef CatastroId As Integer, TitularId As Integer,
                                        barrio As String, uso As String, cuenta As Integer)

            'Modificar
            DbMan.EditDB("UPDATE catastro 
                             SET user_id=" & My.Settings.UserId & ", opr_id=" & OprId & ", 
                                 barrio='" & barrio & "', uso='" & uso & "', cuenta=" & Val(cuenta) & "
                           WHERE id=" & CatastroId,
                         My.Settings.CurrentDB)

            If CatastroId > 0 And TitularId > 0 Then
                'Guardar titular
                DbMan.EditDB("DELETE * FROM titular_catastro WHERE cat_id=" & CatastroId,
                             My.Settings.CurrentDB)
                DbMan.EditDB("INSERT INTO titular_catastro(cat_id, per_id) 
                                   VALUES(" & CatastroId & ", " & TitularId & ")",
                             My.Settings.CurrentDB)
            End If
        End Sub
        Shared Sub Ubicacion(FrenteId As Integer, CatastroId As Integer)
            DbMan.EditDB("UPDATE cat_frente SET ubicacion=False WHERE catastro_id=" & CatastroId, My.Settings.CurrentDB)
            DbMan.EditDB("UPDATE cat_frente SET ubicacion=True WHERE id=" & FrenteId, My.Settings.CurrentDB)
        End Sub
    End Class
    Class Eliminar
        Shared Sub Inmueble(CatastroId As Integer, UserId As Integer)
            Dim RowsAffected As Integer = 0
            If UserId > 0 Then 'Solo el usuario que bloqueo el inmueble puede eliminarlo
                Dim dtab As DataTable = DbMan.ReadDB("SELECT * FROM catastro WHERE id=" & CatastroId & " AND user_id=" & UserId,
                                                     My.Settings.CurrentDB)

                Dim sqlDelete(dtab.Rows.Count) As String
                For Each dr As DataRow In dtab.Rows
                    sqlDelete(dtab.Rows.IndexOf(dr)) = CatastroDelete & " WHERE catastro.id=" & CatastroId & " AND catastro.user_id=" & UserId
                Next
                RowsAffected = DbMan.EditDB(sqlDelete, My.Settings.CurrentDB)

                If RowsAffected = 0 Then
                    MsgBox("Registro bloqueado.")
                End If
            End If
        End Sub
        Shared Sub Frente(id As Integer)
            'Eliminar registro
            DbMan.EditDB("DELETE * FROM cat_frente WHERE id=" & id, My.Settings.CurrentDB)
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