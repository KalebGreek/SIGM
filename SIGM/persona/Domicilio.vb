﻿Class Domicilio

    Shared Function Listar(persona_id As Integer) As DataTable
        Dim sqlSelect As String
        sqlSelect = "SELECT per_domicilio.id as domicilio_id, per_domicilio.calle, per_domicilio.altura,
						         per_domicilio.piso, per_domicilio.dpto, per_domicilio.principal, 
								 per_domicilio.localidad_id, provincias.id as provincia_id,
								 localidades.id as localidad_id
                            FROM provincias INNER JOIN (per_domicilio 
                      INNER JOIN localidades ON per_domicilio.localidad_id = localidades.id) 
                              ON provincias.id = localidades.provincia_id 
                           WHERE per_domicilio.per_id = " & persona_id & " ORDER BY per_domicilio.id"
        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
    End Function
    Shared Function Nuevo(persona_id As Integer, calle As String, altura As Integer, piso As Integer,
                          dpto As String, localidad_id As Integer, principal As Boolean) As Integer

        Dim sqlInsert As String
        sqlInsert = "INSERT INTO per_domicilio(per_id, calle, altura, piso, dpto, localidad_id, principal)
						       VALUES(" & persona_id & ", '" & calle & "', " & altura & ", " & piso & ",
									  '" & dpto & "', " & localidad_id & ", " & principal & ")"

        DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)

        Dim dr As DataRow = DbMan.ReadDB("SELECT MAX(id) as id FROM per_domicilio WHERE per_id=" & persona_id, My.Settings.CurrentDB, "", True)
        If dr Is Nothing Then
            Return 0
        Else
            Return dr("id")
        End If

    End Function
    Shared Function Modificar(domicilio_id As Integer, persona_id As Integer, calle As String,
                              altura As Integer, piso As Integer, dpto As String,
                              localidad_id As Integer, principal As Boolean) As Boolean

        Dim sqlUpdate As String
        sqlUpdate = "UPDATE per_domicilio 
                             SET per_id=" & persona_id & ", calle='" & calle & "', altura=" & altura & ",
							     piso=" & piso & ", dpto='" & dpto & "', 
								 localidad_id=" & localidad_id & ", principal=" & principal & "
						   WHERE per_domicilio.id=" & domicilio_id
        DbMan.EditDB(sqlUpdate, My.Settings.CurrentDB)
        Return True
    End Function


    Shared Function Eliminar(persona_id As Integer, Optional domicilio_id As Integer = 0) As Boolean
        Dim sqlDelete As String
        sqlDelete = "DELETE * FROM per_domicilio WHERE per_id=" & persona_id
        If domicilio_id > 0 Then
            sqlDelete += " AND id=" & domicilio_id
        End If
        DbMan.EditDB(sqlDelete, My.Settings.CurrentDB)
        Return True
    End Function
End Class