Class Proveedor
    Shared Function BuscarPorPersona(keyword As String, difunto As Boolean, fisica As Boolean) As DataTable
        Dim sql(2) As String
        sql(0) = "SELECT persona.id as persona_id, persona.razon, persona.cuil, persona.fisica, 
									per_domicilio.calle, per_domicilio.altura, localidades.nombre, 
									proveedor.id AS proveedor_id,
									proveedor.actividad_id, proveedor.actividad_id as actividad,
									proveedor.responsable_iva_id, responsable_iva.descripcion as responsable_iva"

        sql(1) = " FROM (responsable_iva INNER JOIN (persona 
								INNER JOIN proveedor ON persona.id = proveedor.per_id) 
										ON responsable_iva.Id = proveedor.responsable_iva_id) 
								INNER JOIN (per_domicilio INNER JOIN localidades 
										ON per_domicilio.localidad_id = localidades.id) 
										ON persona.id = per_domicilio.per_id
									 WHERE per_domicilio.principal=True" & " And persona.fisica=" & fisica
        If difunto Then
            sql(1) += " AND persona.difunto=" & difunto
        End If

        If keyword.Contains("BUSCAR") = False And Len(keyword) > 0 Then
            If keyword <> "" Then
                If Val(keyword) > 0 Then
                    If Len(keyword) = 11 Then
                        sql(1) += " And Persona.cuil=" & CDbl(keyword)
                    End If
                ElseIf Len(keyword) > 3 Then
                    sql(1) += " And Persona.razon Like '%" & keyword & "%'"
                End If
            End If
        End If
        sql(2) = " ORDER By Persona.razon"
        Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
    End Function
    Shared Function Seleccionar(proveedor_id As Integer, persona_id As Integer) As DataRow
        Dim sql(1) As String
        sql(0) = "SELECT persona.id as persona_id, persona.razon, persona.cuil, persona.fisica, 
									  per_domicilio.calle, per_domicilio.altura, localidades.nombre, 
									  proveedor.id AS proveedor_id,
									  proveedor.actividad_id, proveedor.actividad_id as actividad,
									  proveedor.responsable_iva_id, responsable_iva.descripcion as responsable_iva"

        sql(1) = " FROM (responsable_iva INNER JOIN (persona 
								INNER JOIN proveedor ON persona.id = proveedor.per_id) 										 
										ON responsable_iva.Id = proveedor.responsable_iva_id) 
								INNER JOIN (per_domicilio INNER JOIN localidades 
										ON per_domicilio.localidad_id = localidades.id) 
										ON persona.id = per_domicilio.per_id
									 WHERE per_domicilio.principal=True"
        If proveedor_id > 0 Then
            sql(1) += " AND proveedor.id=" & proveedor_id
        Else
            sql(1) += " AND persona.id=" & persona_id
        End If
        Return DbMan.ReadDB(sql, My.Settings.CurrentDB).Rows(0)
    End Function
    Shared Function Guardar(proveedor_id As Integer, ByVal per_id As Integer, ByVal actividad As Integer, ByVal responsable As Integer) As Integer
        Dim sqlInsert, sqlSelect, sqlUpdate As String
        If proveedor_id <> 0 Then
            sqlUpdate = "UPDATE proveedor 
								 SET per_id=" & per_id & ", actividad_id=" & actividad & ",	responsable_iva_id=" & responsable & "
							   WHERE id=" & proveedor_id

            DbMan.EditDB(sqlUpdate, My.Settings.CurrentDB)
        Else
            sqlInsert = "INSERT INTO proveedor(per_id, actividad_id, responsable_iva_id) 
							  VALUES(" & per_id & ", " & actividad & ", " & responsable & ")"
            DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)

            sqlSelect = "SELECT MAX(id) as id FROM proveedor WHERE per_id=" & per_id
            proveedor_id = DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB).Rows(0)("id")
        End If
        Return proveedor_id
    End Function
    Shared Function Eliminar(ByVal proveedor_id As Integer) As Integer
        DbMan.EditDB("DELETE * FROM proveedor WHERE id=" & proveedor_id, My.Settings.CurrentDB)
        Return 0
    End Function
End Class