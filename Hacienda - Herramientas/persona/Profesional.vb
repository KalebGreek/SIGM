Public Class Profesional
	Shared SelectSQL As String = "SELECT persona.id as persona_id, Persona.razon, Persona.cuil, Persona.difunto,
											 per_domicilio.calle, per_domicilio.altura, localidades.nombre as localidad,
											 profesional.id As profesional_id, profesional.titulo_id,
											 profesional_titulo.descripcion as titulo, 
											 profesional.matricula as matricula"

	Shared TableSQL As String = " FROM((Persona INNER JOIN (profesional_titulo
								INNER JOIN profesional On profesional_titulo.Id = profesional.titulo_id)
										ON persona.id = profesional.per_id) LEFT JOIN per_domicilio
										ON persona.id = per_domicilio.per_id) LEFT JOIN localidades
										ON per_domicilio.localidad_id = localidades.id
									 WHERE per_domicilio.principal = True"

	Shared Function BuscarPorPersona(Optional id As Integer = 0, Optional cuil As Double = 0, Optional razon_social As String = "") As DataTable
		Dim sql As String = SelectSQL & TableSQL
		If id > 0 Then
			sql += " And Persona.id=" & id
		ElseIf Len(cuil) = 11 Then
			sql += " And Persona.cuil='" & cuil & "'"

		ElseIf razon_social.Contains("BUSCAR") = False And Len(razon_social) > 3 Then
			sql += " And Persona.razon Like '%" & razon_social & "%'"
		End If

		sql += " ORDER By Persona.razon"
		Return DbMan.read(sql, My.Settings.DefaultCon)
	End Function
	Shared Function Seleccionar(profesional_id As Integer, persona_id As Integer) As DataTable
		Dim sql As String = SelectSQL & TableSQL

		If profesional_id > 0 Then
			sql += " AND profesional.id=" & profesional_id
		Else
			sql += " AND persona.id=" & persona_id
		End If

		Return DbMan.read(sql, My.Settings.DefaultCon)
	End Function
	Shared Function ListarTitulos() As BindingSource
		Dim bs As New BindingSource
		bs.DataSource = DbMan.read("SELECT * FROM prof_titulo ORDER BY titulo", My.Settings.DefaultCon)
		Return bs
	End Function

	Shared Function guardar(prof_id As Integer, persona_id As Integer, titulo_id As Integer, ByVal matricula As String) As Integer
		If prof_id > 0 Then
			DbMan.edit("UPDATE profesional SET titulo_id=" & titulo_id & ", matricula='" & matricula & "'" &
					  " WHERE id=" & prof_id)
		Else
			DbMan.edit("INSERT INTO profesional(per_id, titulo_id, matricula)" &
					 " VALUES(" & persona_id & ", " & titulo_id & ", '" & matricula & "')")
		End If


		Dim dtab As New DataTable
		dtab = DbMan.read("SELECT id FROM profesional WHERE per_id=" & persona_id, My.Settings.DefaultCon)
		Return dtab(0)("id")
	End Function
	Shared Function eliminar(ByVal per_id As Integer) As Integer
		DbMan.edit("DELETE * FROM profesional WHERE per_id=" & per_id)
		Return 0
	End Function
End Class
