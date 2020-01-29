Public Class Domicilio

    Shared Function Listar(persona_id As Integer) As DataTable
        Dim sql(2) As String
        sql(0) = "SELECT per_domicilio.id as domicilio_id, per_domicilio.calle, per_domicilio.altura,
								      per_domicilio.piso, per_domicilio.dpto, per_domicilio.principal, 
								      per_domicilio.localidad_id, provincias.id as provincia_id,
								      localidades.id as localidad_id"
        sql(1) = "FROM provincias INNER JOIN (per_domicilio 
                                    INNER JOIN localidades ON per_domicilio.localidad_id = localidades.id) 
                                            ON provincias.id = localidades.provincia_id "
        sql(2) = "WHERE per_domicilio.per_id = " & persona_id & " ORDER BY per_domicilio.id"
        Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
    End Function
    Shared Function Nuevo(persona_id As Integer, calle As String, altura As Integer, piso As Integer,
                          dpto As String, localidad_id As Integer, principal As Boolean) As Integer
        DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO per_domicilio(per_id, calle, altura, piso, dpto, localidad_id, principal)
										   VALUES(" & persona_id & ", '" & calle & "', " & altura & ", " & piso & ",
												  '" & dpto & "', " & localidad_id & ", " & principal & ")")


        Dim sql(0) As String
        sql(0) = "SELECT MAX(id) as id FROM per_domicilio WHERE per_id=" & persona_id
        Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        Return dtab(0)("id")
    End Function
    Shared Function Modificar(domicilio_id As Integer, persona_id As Integer, calle As String,
                              altura As Integer, piso As Integer, dpto As String,
                              localidad_id As Integer, principal As Boolean) As Boolean

        DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE per_domicilio SET per_id=" & persona_id & ", calle='" & calle & "', altura=" & altura & ",
												 piso=" & piso & ", dpto='" & dpto & "', 
												 localidad_id=" & localidad_id & ", principal=" & principal & "
										   WHERE per_domicilio.id=" & domicilio_id)
        Return True
    End Function


    Shared Function Eliminar(persona_id As Integer, Optional domicilio_id As Integer = 0) As Boolean
        Dim sql As String = "DELETE * FROM per_domicilio WHERE per_id=" & persona_id
        If domicilio_id > 0 Then
            sql += " And id=" & domicilio_id
        End If
        DbMan.editDB(Nothing, My.Settings.CurrentDB, sql)
        Return True
    End Function
End Class