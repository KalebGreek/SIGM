Class Profesional
    Shared ReadOnly SelectSQL As String = "SELECT persona.id as persona_id, Persona.razon, Persona.cuil, Persona.difunto,
											 per_domicilio.calle, per_domicilio.altura, localidades.nombre as localidad,
											 profesional.id As profesional_id, profesional.titulo_id,
											 profesional_titulo.descripcion as titulo, 
											 profesional.matricula as matricula"

    Shared ReadOnly TableSQL As String = " FROM((Persona INNER JOIN (profesional_titulo
								INNER JOIN profesional On profesional_titulo.Id = profesional.titulo_id)
										ON persona.id = profesional.per_id) LEFT JOIN per_domicilio
										ON persona.id = per_domicilio.per_id) LEFT JOIN localidades
										ON per_domicilio.localidad_id = localidades.id
									 WHERE per_domicilio.principal = True"

    Shared Function BuscarPorPersona(Optional id As Integer = 0, Optional cuil As Double = 0, Optional razon_social As String = "") As DataTable
        Dim sqlSelect As String
        sqlSelect = SelectSQL & TableSQL
        If id > 0 Then
            sqlSelect += " And Persona.id=" & id
        ElseIf Len(cuil) = 11 Then
            sqlSelect += " And Persona.cuil='" & cuil & "'"

        ElseIf razon_social.Contains("BUSCAR") = False And Len(razon_social) > 3 Then
            sqlSelect += " And Persona.razon Like '%" & razon_social & "%'"
        End If

        sqlSelect += " ORDER By Persona.razon"
        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
    End Function
    Shared Function Seleccionar(profesional_id As Integer, persona_id As Integer) As DataRow
        Dim sqlSelect As String
        sqlSelect = SelectSQL & TableSQL

        If profesional_id > 0 Then
            sqlSelect += " AND profesional.id=" & profesional_id
        Else
            sqlSelect += " AND persona.id=" & persona_id
        End If

        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB).Rows(0)
    End Function
    Shared Function ListarTitulos() As BindingSource
        Dim bs As New BindingSource With {
        .DataSource = DbMan.ReadDB("SELECT * FROM prof_titulo ORDER BY titulo",
                                   My.Settings.CurrentDB)}
        Return bs
    End Function

    Shared Function Guardar(prof_id As Integer, persona_id As Integer, titulo_id As Integer, ByVal matricula As String) As DataRow

        If prof_id > 0 Then
            DbMan.EditDB("UPDATE profesional 
							 SET titulo_id=" & titulo_id & ", matricula='" & matricula & "'
						   WHERE id=" & prof_id,
                         My.Settings.CurrentDB)
        Else
            DbMan.EditDB("INSERT INTO profesional(per_id, titulo_id, matricula)
							   VALUES(" & persona_id & ", " & titulo_id & ", '" & matricula & "')",
                         My.Settings.CurrentDB)
        End If

        Return DbMan.ReadDB("SELECT id FROM profesional WHERE per_id=" & persona_id, My.Settings.CurrentDB).Rows(0)
    End Function
    Shared Function Eliminar(ByVal profesional_id As Integer) As Integer
        DbMan.EditDB("DELETE * FROM profesional WHERE id=" & profesional_id, My.Settings.CurrentDB)
        Return 0
    End Function
End Class
