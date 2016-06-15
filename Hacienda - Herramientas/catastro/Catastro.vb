Public Class Catastro
    Shared SelectSQL As String = "SELECT persona.id as titular_id, persona.razon as titular, persona.cuil, persona.difunto, persona.fisica,
                                  catastro.zona, catastro.circ, catastro.secc, catastro.manz, catastro.parc, catastro.lote,
                                  catastro.id as catastro_id, catastro.cuenta, 
                                  cat_frente.calle, cat_frente.altura, 
                                  catastro.barrio, catastro.uso, cat_frente.ubicacion,
                                  oprivadas.id as opr_id, oprivadas.expediente,
                                  catastro.archivado, catastro.user_id as user_id
                                  FROM (oprivadas INNER JOIN (persona INNER JOIN (catastro INNER JOIN titular_catastro
                                  ON catastro.Id = titular_catastro.cat_id) ON persona.id = titular_catastro.per_id)
                                  ON oprivadas.Id = catastro.opr_id) INNER JOIN cat_frente
                                  ON catastro.Id = cat_frente.catastro_id"

    Shared InsertSQL As String
    Shared UpdateSQL As String
    Shared DeleteSQL As String = "DELETE DISTINCTROW catastro.*
                                  FROM ((((catastro LEFT JOIN cat_documento ON catastro.Id = cat_documento.catastro_id)
                                  LEFT JOIN cat_frente ON catastro.Id = cat_frente.catastro_id) 
                                  LEFT JOIN cat_servicio ON catastro.Id = cat_servicio.catastro_id)
                                  LEFT JOIN cat_superficie ON catastro.Id = cat_superficie.catastro_id)
                                  LEFT JOIN titular_catastro ON catastro.Id = titular_catastro.cat_id"
    '##### SEARCH
    Shared Function BuscarPorTitular(Optional razon As String = "", Optional cuil As Double = 0) As DataTable
        Dim sql As String = SelectSQL & " WHERE ubicacion = True"
        If Len(cuil) = 11 Then
            sql += " And persona.cuil='" & cuil & "'"
            sql += " ORDER BY catastro.id ASC"
        ElseIf razon <> "" And Len(razon) > 2 Then
            sql += " AND persona.razon LIKE '%" & razon & "%'"
            sql += " ORDER BY persona.razon"
        Else
            sql += " ORDER BY catastro.id ASC"
        End If

        Return bd.read(defcon, sql)
    End Function
    Shared Function BuscarPorPartida(Optional zona As Integer = 0, Optional circ As Integer = 0, Optional secc As Integer = 0,
                                     Optional manz As Integer = 0, Optional parc As Integer = 0, Optional lote As Integer = 0) As DataTable

        Dim sql As String = SelectSQL & " WHERE ubicacion = True"
        If zona > 0 Then
            sql += " AND catastro.zona=" & zona
            If circ > 0 Then
                sql += " AND catastro.circ=" & circ
                If secc > 0 Then
                    sql += " AND catastro.secc=" & secc
                    If manz > 0 Then
                        sql += " AND catastro.manz=" & manz
                    End If
                    If parc > 0 Then
                        sql += " AND catastro.parc=" & parc
                    End If
                    If lote > 0 Then
                        sql += " AND catastro.lote=" & lote
                    End If
                End If
            End If
        End If
        sql += " ORDER BY catastro.id ASC"

        Return bd.read(defcon, sql)
    End Function
    Shared Function BuscarPorDireccion(Optional calle As String = "", Optional barrio As String = "")
        Dim sql As String = SelectSQL & " WHERE ubicacion = True"

        If calle <> "" And Len(calle) > 2 Then
            sql += " AND cat_frente.calle LIKE '%" & calle & "%'"
            sql += " ORDER BY cat_frente.calle"
        ElseIf barrio <> "" And Len(barrio) > 2 Then
            sql += " AND catastro.barrio LIKE '%" & barrio & "%'"
            sql += " ORDER BY catastro.barrio"
        Else
            sql += " ORDER BY catastro.id ASC"
        End If

        Return bd.read(defcon, sql)
    End Function
    '##### 'READ
    Shared Function ListarInmueblePorTitular(persona_id As Integer) As DataTable
        Dim sql As String = SelectSQL & " WHERE ubicacion = True"
        If persona_id > 0 Then
            sql += " AND persona.id=" & persona_id
        End If
        Return bd.read(defcon, sql)
    End Function
    Shared Function ListarInmueblePorExpediente(expediente As Integer) As DataTable
        Dim sql As String = SelectSQL & " WHERE ubicacion=True"
        If expediente > 0 Then
            sql += " AND oprivadas.expediente=" & expediente
        End If
        Return bd.read(defcon, sql)
    End Function
    Shared Function Seleccionar(cat_id As Integer) As DataTable
        Dim sql As String = SelectSQL
        If cat_id > -1 Then
            sql += " WHERE catastro.id=" & cat_id
            Return bd.read(defcon, sql)
        Else
            Return Nothing
        End If
    End Function
    Shared Function SeleccionarPartida(zona As Integer, circ As Integer, secc As Integer,
                                          manz As Integer, parc As Integer, lote As Integer) As Integer
        Dim sql As String = "SELECT catastro.id as catastro_id FROM catastro"
        If zona > 0 And circ > 0 And secc > 0 And manz > 0 And parc > 0 Then

            sql += " WHERE catastro.zona=" & zona & " AND catastro.circ=" & circ & " AND catastro.secc=" & secc &
                   " AND catastro.manz=" & manz & " AND catastro.parc=" & parc & " AND catastro.lote=" & lote
            Dim dtab As DataTable = bd.read(defcon, sql)
            If dtab.Rows.Count > 0 Then
                Return dtab(0)("catastro_id")
            Else
                Return 0
            End If
        Else
            Return -1
        End If
    End Function
    Public Class Frente
        Shared Function Cargar(catastro_id As Integer, Optional ubicacion As Boolean = False) As Object
            If ubicacion Then
                Dim dtab As DataTable = bd.read(defcon, "SELECT calle, altura FROM cat_frente" &
                                                       " WHERE catastro_id=" & catastro_id & " AND ubicacion=True")
                If dtab.Rows.Count > 0 Then
                    Return dtab(0)("calle") & " " & dtab(0)("altura")
                Else
                    Return " S/N "
                End If
            Else
                Return bd.read(defcon, "SELECT id, calle, altura, metros FROM cat_frente WHERE catastro_id=" & catastro_id)
            End If
        End Function
    End Class

    '##### 'MOD
    Public Class Agregar
        Overloads Shared Sub Inmueble(operacion As String, user_id As Integer, opr_id As Integer,
                                      catastro_id As Integer, titular_id As Integer,
                                      barrio As String, uso As String, cuenta As Integer,
                                      archivado As Boolean,
                                      zona As Integer, circ As Integer, secc As Integer,
                                      manz As Integer, parc As Integer, lote As Integer)

            If operacion = "MOD" Then
                'Modificar
                mod_sql = "UPDATE catastro SET user_id=" & user_id & ", opr_id=" & opr_id & ", " &
                      " barrio='" & barrio & "', uso='" & uso & "', cuenta=" & Val(cuenta) &
                      " WHERE id=" & catastro_id
                bd.edit(defcon, mod_sql)
            ElseIf operacion <> "" Then
                'Agregar
                mod_sql = "INSERT INTO catastro(user_id, opr_id, zona, circ, secc, manz, parc, lote, barrio, uso, cuenta, archivado) " &
                          " VALUES(" & user_id & "," & opr_id & ", " & zona & ", " & circ & ", " & secc & "," &
                          " " & manz & ", " & parc & ", " & lote & ",'" & barrio & "', '" & uso & "', " & cuenta &
                          "," & archivado & ")"
                bd.edit(defcon, mod_sql)
                'leer ultimo inmueble
                catastro_id = Catastro.SeleccionarPartida(zona, circ, secc, manz, parc, lote)
                operacion = "MOD"
            End If
            If catastro_id > 0 And titular_id > 0 Then
                'Guardar titular
                bd.edit(defcon, "DELETE * FROM titular_catastro WHERE cat_id=" & catastro_id)
                bd.edit(defcon, "INSERT INTO titular_catastro(cat_id, per_id)" &
                               " VALUES(" & catastro_id & ", " & titular_id & ")")
            End If
        End Sub
        Overloads Shared Sub Frente(bs_frente As BindingSource, catastro_id As Integer)
            With bs_frente
                'cat_frente
                del_sql = "DELETE * FROM cat_frente WHERE catastro_id=" & catastro_id
                bd.edit(defcon, del_sql)

                For fila As Integer = 0 To .Count - 1
                    .Position = fila
                    If .Position = 0 Then
                        mod_sql = "INSERT INTO cat_frente(catastro_id, calle, altura, metros, ubicacion)" &
                      " VALUES(" & catastro_id & ",'" & .Current("calle") & "', " & .Current("altura") & "," &
                      " '" & .Current("metros") & "', True)"
                    Else
                        mod_sql = "INSERT INTO cat_frente(catastro_id, calle, altura, metros)" &
                      " VALUES(" & catastro_id & ",'" & .Current("calle") & "', " & .Current("altura") & "," &
                      " '" & .Current("metros") & "')"
                    End If
                    bd.edit(defcon, mod_sql)
                Next
            End With
        End Sub
        Overloads Shared Sub Superficie(catastro_id As Integer,
                                 existente As Decimal, relevamiento As Decimal,
                                 proyecto As Decimal, terreno As Decimal)
            'cat_superficie
            del_sql = "DELETE * FROM cat_superficie WHERE catastro_id=" & catastro_id
            bd.edit(defcon, del_sql)

            mod_sql = "INSERT INTO cat_superficie(catastro_id, existente, proyecto, relevamiento, terreno)" &
                     " VALUES(" & catastro_id & ", '" & existente & "', '" & proyecto & "'," &
                     " '" & relevamiento & "', '" & terreno & "')"

            bd.edit(defcon, mod_sql)

        End Sub
        Overloads Shared Sub Caracteristica(bs_car As BindingSource, catastro_id As Integer)
            'cat_servicio
            del_sql = "DELETE * FROM cat_servicio WHERE catastro_id=" & catastro_id
            bd.edit(defcon, del_sql)
            With bs_car
                For fila As Integer = 0 To .Count - 1
                    .Position = fila
                    mod_sql = "INSERT INTO cat_servicio(catastro_id, descripcion, activo)" &
                              " VALUES(" & catastro_id & ",'" & .Current("descripcion") & "', " & .Current("activo") & ")"
                    bd.edit(defcon, mod_sql)
                Next
            End With
        End Sub
        Overloads Shared Sub Documento(bs_copia As BindingSource, catastro_id As Integer)
            'cat_documento
            del_sql = "DELETE * FROM cat_documento WHERE catastro_id=" & catastro_id
            bd.edit(defcon, del_sql)
            With bs_copia
                For fila As Integer = 0 To .Count - 1
                    .Position = fila
                    mod_sql = "INSERT INTO cat_documento(catastro_id, descripcion, fecha, ruta)" &
                          " VALUES(" & catastro_id & ",'" & .Current("descripcion") & "'," &
                          " '" & .Current("fecha") & "', '" & .Current("ruta") & "')"
                    bd.edit(defcon, mod_sql)
                Next
            End With
        End Sub
    End Class

    Shared Sub Eliminar(catastro_id As Integer, user_id As Integer)
        If user_id > 0 Then 'Solo el usuario que bloqueo el inmueble puede eliminarlo
            Dim dtab As New DataTable
            Dim sql As String = "SELECT * FROM catastro
                                 WHERE id=" & catastro_id & " AND user_id=" & user_id
            dtab = bd.read(defcon, sql)
            If dtab.Rows.Count > 0 Then
                sql = DeleteSQL &
                    " WHERE catastro.id=" & catastro_id & " AND catastro.user_id=" & user_id
                bd.edit(defcon, sql)
            Else
                MsgBox("Registro bloqueado.")
            End If
        End If
    End Sub

    '##### 'ROUTINES
    Shared Sub CalcularSuperficie(ByRef existente As Decimal, ByRef proyecto As Decimal,
                                  ByRef relevamiento As Decimal, ByRef terreno As Decimal,
                                  ByRef libre As Decimal, ByRef cubierto As Decimal)

        cubierto = proyecto + relevamiento + existente
        If terreno < cubierto Then
            libre = 0
        Else
            libre = terreno - cubierto
        End If
    End Sub

End Class