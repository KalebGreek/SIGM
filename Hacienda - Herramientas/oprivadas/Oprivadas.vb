Public Class Oprivadas

	Shared SQLSelect _
	As String = "SELECT oprivadas.expediente, persona.razon, persona.cuil, persona.telefono, persona.email,
				 persona.difunto, persona.fisica, persona_1.razon, persona_1.cuil, persona_1.email, persona_1.telefono, 
				 profesional.matricula, profesional_titulo.descripcion, oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2, 
				 oprivadas.inicio_obra, oprivadas.fin_obra, oprivadas.temporal, oprivadas.visado, 
				 cat_frente.calle, cat_frente.altura, catastro.barrio"


	Shared SQLTable _
	As String = " FROM ((((profesional_titulo INNER JOIN ((profesional 
				INNER JOIN oprivadas ON profesional.Id = oprivadas.profesional_id) 
				INNER JOIN persona AS persona_1 ON profesional.per_id = persona_1.id) 
				ON profesional_titulo.Id = profesional.titulo_id) INNER JOIN (catastro 
				INNER JOIN cat_frente ON catastro.Id = cat_frente.catastro_id) 
				ON oprivadas.Id = catastro.opr_id) INNER JOIN (((persona 
				INNER JOIN responsable_expediente ON persona.id = responsable_expediente.per_id) 
				INNER JOIN per_domicilio ON persona.id = per_domicilio.per_id) 
				INNER JOIN localidades ON per_domicilio.localidad_id = localidades.id) 
				ON oprivadas.Id = responsable_expediente.opr_id) INNER JOIN (localidades AS localidades_1
				INNER JOIN per_domicilio AS per_domicilio_1 ON localidades_1.id = per_domicilio_1.localidad_id) 
				ON persona_1.id = per_domicilio_1.per_id) LEFT JOIN opr_documento ON oprivadas.Id = opr_documento.opr_id"

	Shared SQLWhere _
	As String = " WHERE responsable_expediente.principal=True And cat_frente.ubicacion=True
				AND per_domicilio.principal=True AND per_domicilio_1.principal=True"

	'As String = " FROM profesional_titulo INNER JOIN ((persona INNER JOIN (profesional INNER JOIN
	'              (oprivadas INNER JOIN responsable_expediente ON oprivadas.Id = responsable_expediente.opr_id)
	'On profesional.Id = oprivadas.profesional_id) ON persona.id = responsable_expediente.per_id)
	'               INNER JOIN persona As persona_1 On profesional.per_id = persona_1.id)
	'On profesional_titulo.Id = profesional.titulo_id"

	Public Class Expediente
		'BUSCAR
		Public Class Buscar
			Shared Function Expediente(excluir As Boolean, Optional numero As Integer = 0,
										Optional ubicacion As String = "",
										Optional fecha As Date = Nothing) As DataTable

				Dim sql _
				As String = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
							persona.razon as responsable, persona_1.razon as profesional,
							cat_frente.calle&' '&cat_frente.altura as ubicacion_inmueble, catastro.barrio, 
							oprivadas.tarea, oprivadas.tarea2,
							oprivadas.recibe, oprivadas.visado,
							oprivadas.inicio_obra, oprivadas.fin_obra
							" & SQLTable & SQLWhere

				If numero > 19000000 Then
					sql += " AND Oprivadas.expediente = " & numero

				ElseIf Len(ubicacion) > 3 And ubicacion.Contains("BUSCAR") = False Then
					sql += " AND cat_frente.calle"
					If excluir Then
						sql += " NOT"
					End If
					sql += " LIKE '%" & ubicacion & "%' OR catastro.barrio"
					If excluir Then
						sql += " NOT"
					End If
					sql += " LIKE '%" & ubicacion & "%'"

				ElseIf fecha <> Nothing Then
					sql += " AND oprivadas.inicio_obra"
					If excluir Then
						sql += "<>"
					Else
						sql += "="
					End If
					sql += "#" & fecha.ToShortDateString & "#
							OR oprivadas.fin_obra"
					If excluir Then
						sql += "<>"
					Else
						sql += "="
					End If
					sql += "#" & fecha.ToShortDateString & "#"
				End If

				Return DbMan.read(sql)
			End Function

			Shared Function Responsable(excluir As Boolean, Optional razon As String = "",
										Optional cuil As Double = 0,
										Optional direccion As String = "",
										Optional localidad As String = "")

				Dim sql _
				As String = "SELECT oprivadas.id As expediente_id, oprivadas.expediente,
							Oprivadas.tarea, Oprivadas.tarea2,			
							responsable_expediente.principal,
							persona.razon As responsable, persona.cuil, 
							per_domicilio.calle&' '&per_domicilio.altura as domicilio,
							localidades.nombre as localidad,
							persona.telefono, persona.email, 
							persona.difunto, persona.fisica,
							oprivadas.recibe, Oprivadas.visado  
							" & SQLTable & SQLWhere


				If Len(razon) > 3 And razon.Contains("BUSCAR") = False Then
					sql += " AND persona.razon"
					If excluir Then
						sql += " NOT"
					End If
					sql += " LIKE '%" & razon & "%'"
				ElseIf Len(cuil) = 11 Then
					sql += " AND persona.cuil = '" & cuil & "'"
				ElseIf Len(direccion) > 3 And direccion.Contains("BUSCAR") = False Then
					sql += " AND per_domicilio.calle"
					If excluir Then
						sql += " NOT"
					End If
					sql += " LIKE '%" & direccion & "%'"
				ElseIf Len(localidad) > 3 And localidad.Contains("BUSCAR") = False Then
					sql += " AND localidades.nombre"
					If excluir Then
						sql += " NOT"
					End If
					sql += " LIKE '%" & localidad & "%'"
				End If

				Return DbMan.read(sql)
			End Function

			Shared Function Profesional(excluir As Boolean, Optional razon As String = "",
										Optional cuil As Double = 0,
										Optional direccion As String = "",
										Optional localidad As String = "",
										Optional titulo As String = "")

				Dim sql _
				As String = "SELECT oprivadas.id As expediente_id, oprivadas.expediente,
							Oprivadas.tarea, Oprivadas.tarea2,
							persona_1.razon as profesional, persona_1.cuil, 
							per_domicilio_1.calle&' '&per_domicilio_1.altura as domicilio,
							localidades_1.nombre as localidad,
							persona_1.email, persona_1.telefono,
							profesional_titulo.descripcion As titulo, profesional.matricula, 
							oprivadas.recibe, Oprivadas.visado 
							" & SQLTable & SQLWhere

				If Len(razon) > 3 And razon.Contains("BUSCAR") = False Then
					sql += " AND persona_1.razon"
					If excluir Then
						sql += " NOT"
					End If
					sql += " LIKE '%" & razon & "%'"
				ElseIf Len(cuil) = 11 Then
					sql += " AND persona_1.cuil = '" & cuil & "'"
				ElseIf Len(direccion) > 3 And direccion.Contains("BUSCAR") = False Then
					sql += " AND per_domicilio_1.calle"
					If excluir Then
						sql += " NOT"
					End If
					sql += " LIKE '%" & direccion & "%'"
				ElseIf Len(localidad) > 3 And localidad.Contains("BUSCAR") = False Then
					sql += " AND localidades_1.nombre"
					If excluir Then
						sql += " NOT"
					End If
					sql += " LIKE '%" & localidad & "%'"
				End If

				Return DbMan.read(sql)
			End Function
		End Class
		'Funciones de listado para evitar borrar expedientes accidentalmente
		Shared Function ListarPorResponsable(persona_id As Integer) As DataTable
			Return DbMan.read(
					   "SELECT responsable_expediente.Id As id, expediente, per_id 
                            FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id) 
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id
                            WHERE responsable_expediente.per_id=" & persona_id)
		End Function
		Shared Function ListarPorProfesional(prof_id As Integer)
			Return DbMan.read(
						   "SELECT responsable_expediente.Id As id, expediente, profesional_id
                            FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id
                            WHERE oprivadas.profesional_id=" & prof_id)
		End Function

		Shared Function ListarResponsables(expediente As Integer) As DataTable
			Return DbMan.read(
					   "SELECT persona.id As persona_id, razon, cuil, email, telefono, difunto
                            FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id
                            WHERE oprivadas.expediente=" & expediente)
		End Function

		Shared Function Seleccionar(expediente As Integer) As DataTable
			Return DbMan.read("SELECT * FROM oprivadas 
													WHERE Oprivadas.expediente= " & expediente)
		End Function

		'MODIFICAR
		Shared Function Generar(exp As String) As DataTable
			Dim dtab As New DataTable
			Dim InsertExpSQL As String = "INSERT INTO oprivadas(expediente, tarea, tarea2, inicio_obra, " &
								 " profesional_id, user_id, temporal)" &
								 " VALUES(" & exp & ", 'MENSURA','SIMPLE', '" & Date.Today.ToShortDateString & "'," &
								 " 0, " & My.Settings.UserId & ", True)"

			dtab = Seleccionar(exp)
			If dtab.Rows.Count > 0 Then
				'Último expediente creado por el usuario
				If MsgBoxResult.No = MsgBox("¿Desea recuperar datos del último expediente no guardado?" &
									" Presione Sí para recuperar, No para eliminar.",
									  MsgBoxStyle.YesNo, "Obras Privadas") Then
					LimpiarTemporal(dtab(0)("id"), Nothing, True)
					'Recrear expediente por defecto
					DbMan.edit(InsertExpSQL)
				End If
			Else
				'Crear expediente por defecto
				DbMan.edit(InsertExpSQL)
			End If
			Return Seleccionar(exp)
		End Function

		Public Shared Sub Bloquear(opr_id As Integer, lock As Boolean)
			Dim user_id As Integer = 0
			If lock And My.Settings.UserId > 0 Then
				user_id = My.Settings.UserId
			End If
			DbMan.edit("UPDATE oprivadas Set user_id=" & user_id & " 
							WHERE id=" & opr_id & " AND user_id=0")
		End Sub

		Shared Sub LimpiarTemporal(opr_id As Integer, inmuebles As BindingSource, Optional temp As Boolean = False)
			Dim dtab As DataTable
			Dim sql As String = "Select id FROM oprivadas WHERE user_id=" & My.Settings.UserId & " And temporal=" & temp
			If opr_id > 0 Then
				sql += " And id=" & opr_id
			End If
			dtab = DbMan.read(sql)

			If dtab.Rows.Count > 0 Then
				LimpiarResponsable(opr_id)
				'Buscar inmuebles relacionados y eliminarlos
				'Catastro.eliminar(opr_id, inmuebles)
			End If

			sql = "DELETE * FROM oprivadas WHERE user_id=" & My.Settings.UserId & " And temporal=" & temp
			If opr_id > 0 Then
				sql += " And id=" & opr_id
			End If
			DbMan.edit(sql)

		End Sub

		'Seccion Persona
		Shared Sub AgregarResponsable(registro As BindingSource, opr_id As Integer, ResponsablePrincipal As Integer)
			'Lee desde el bindingsource de Personas
			With registro
				For fila As Integer = 0 To .Count - 1
					.Position = fila
					DbMan.edit("INSERT INTO responsable_expediente(opr_id, per_id, principal)
			VALUES(" & opr_id & ",
                                            " & .Current("persona_id") & ",
                                            " & CBool(registro.Current("persona_id") = ResponsablePrincipal) & ")")
				Next
			End With
		End Sub
		Shared Sub LimpiarResponsable(opr_id As Integer)
			DbMan.edit("DELETE * FROM responsable_expediente WHERE opr_id=" & opr_id)
		End Sub
		Shared Sub ActualizarProfesional(opr_id As Integer, prof_id As Integer)
			DbMan.edit("UPDATE oprivadas SET profesional_id=" & prof_id &
						" WHERE id=" & opr_id)
		End Sub

		'Seccion Inmueble

		'Seccion Expediente
		Shared Sub ActualizarDetalle(opr_id As Integer, inicio_obra As Date, visado As Boolean, fin_obra As Date,
								 recibe As String, tarea As String, tarea2 As String, observaciones As String)
			Dim sql As String = "UPDATE oprivadas SET"
			If visado Then
				sql += " fin_obra='" & fin_obra.ToShortDateString & "',"
			End If
			sql += " inicio_obra='" & inicio_obra.ToShortDateString & "',  recibe='" & recibe & "', visado=" & visado & ",
                     tarea='" & tarea & "', tarea2='" & tarea2 & "', observaciones='" & observaciones & "'
                     WHERE id=" & opr_id
			DbMan.edit(sql)
		End Sub
	End Class
End Class
