Public Class Profesional
    Shared SelectSQL As String = "SELECT persona.id, persona.razon, persona.cuil, persona.difunto,
                                  per_domicilio.calle, per_domicilio.altura, localidades.localidad,
                                  Profesional.id As prof_id, prof_titulo.titulo, profesional.matricula
                                  FROM ((persona INNER JOIN (prof_titulo
                                  INNER JOIN profesional On prof_titulo.Id = profesional.titulo_id)
                                  On persona.id = profesional.per_id) LEFT JOIN per_domicilio
                                  On persona.id = per_domicilio.per_id) LEFT JOIN localidades
                                  On  per_domicilio.localidad_id = localidades.id
                                  WHERE per_domicilio.principal=True"

    Shared Function BuscarPorPersona(Optional id As Integer = 0, Optional cuil As Double = 0, Optional razon_social As String = "") As DataTable
        Dim sql As String = SelectSQL
        If id > 0 Then
            sql += " And Persona.id=" & id
        ElseIf Len(cuil) = 11 Then
            sql += " And Persona.cuil='" & cuil & "'"

        ElseIf razon_social.Contains("BUSCAR") = False And Len(razon_social) > 3 Then
            sql += " And Persona.razon Like '%" & razon_social & "%'"
        End If

        sql += " ORDER By Persona.razon"
        Return bd.leer(defcon, sql)
    End Function
    Shared Function Seleccionar(profesional_id As Integer) As DataTable
        Dim sql As String = SelectSQL & " AND profesional.id=" & profesional_id
        Return bd.leer(defcon, sql)
    End Function
    Shared Function ListarTitulos() As BindingSource
        Dim bs As New BindingSource
        bs.DataSource = bd.leer(defcon, "SELECT * FROM prof_titulo ORDER BY titulo")
        Return bs
    End Function

    Shared Function guardar(prof_id As Integer, persona_id As Integer, titulo_id As Integer, ByVal matricula As String) As Integer
        If prof_id > 0 Then
            mod_sql = "UPDATE profesional SET titulo_id=" & titulo_id & ", matricula='" & matricula & "'" &
                          " WHERE id=" & prof_id
        Else
            mod_sql = "INSERT INTO profesional(per_id, titulo_id, matricula)" &
                         " VALUES(" & persona_id & ", " & titulo_id & ", '" & matricula & "')"
        End If
        bd.edit(defcon, mod_sql)

        Dim dtab As New DataTable
        dtab = bd.leer(defcon, "SELECT id FROM profesional WHERE per_id=" & persona_id)
        Return dtab(0)("id")
    End Function
    Shared Function eliminar(ByVal per_id As Integer) As Integer
        mod_sql = "DELETE * FROM profesional WHERE per_id=" & per_id
        bd.edit(defcon, mod_sql)
        Return 0
    End Function
End Class
