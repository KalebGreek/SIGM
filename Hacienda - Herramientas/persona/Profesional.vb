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
        Return bd.read(my.settings.DefaultCon, sql)
    End Function
    Shared Function Seleccionar(profesional_id As Integer) As DataTable
        Dim sql As String = SelectSQL & " AND profesional.id=" & profesional_id
        Return bd.read(my.settings.DefaultCon, sql)
    End Function
    Shared Function ListarTitulos() As BindingSource
        Dim bs As New BindingSource
        bs.DataSource = bd.read(my.settings.DefaultCon, "SELECT * FROM prof_titulo ORDER BY titulo")
        Return bs
    End Function

    Shared Function guardar(prof_id As Integer, persona_id As Integer, titulo_id As Integer, ByVal matricula As String) As Integer
        If prof_id > 0 Then
            bd.edit(my.settings.DefaultCon, "UPDATE profesional SET titulo_id=" & titulo_id & ", matricula='" & matricula & "'" &
                          " WHERE id=" & prof_id)
        Else
            bd.edit(my.settings.DefaultCon, "INSERT INTO profesional(per_id, titulo_id, matricula)" &
                         " VALUES(" & persona_id & ", " & titulo_id & ", '" & matricula & "')")
        End If


        Dim dtab As New DataTable
        dtab = bd.read(my.settings.DefaultCon, "SELECT id FROM profesional WHERE per_id=" & persona_id)
        Return dtab(0)("id")
    End Function
    Shared Function eliminar(ByVal per_id As Integer) As Integer
        bd.edit(my.settings.DefaultCon, "DELETE * FROM profesional WHERE per_id=" & per_id)
        Return 0
    End Function
End Class
