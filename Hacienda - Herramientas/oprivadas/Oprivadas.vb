Public Class Oprivadas
	Shared SQLTable _
		   As String = " FROM profesional_titulo INNER JOIN ((persona INNER JOIN (profesional INNER JOIN
                         (oprivadas INNER JOIN responsable_expediente ON oprivadas.Id = responsable_expediente.opr_id)
                         ON profesional.Id = oprivadas.profesional_id) ON persona.id = responsable_expediente.per_id)
                         INNER JOIN persona AS persona_1 ON profesional.per_id = persona_1.id)
                         ON profesional_titulo.Id = profesional.titulo_id"

	Public Class Expediente
        'BUSCAR Y LISTAS
        Shared Function Buscar(Optional expediente As Integer = 0, Optional responsable As String = "",
							   Optional profesional As String = "", Optional cuil As Double = 0) As DataTable

			Dim sql As String = ""
			If expediente > 19000000 Then
				sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   persona.razon as responsable, persona.difunto, persona.fisica,
                   persona_1.razon as profesional, profesional_titulo.titulo, profesional.matricula,
                   oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2,
                   oprivadas.inicio_obra, oprivadas.fin_obra,
                   oprivadas.temporal, oprivadas.visado " &
				   SQLTable & " WHERE responsable_expediente.principal=True And Oprivadas.expediente = " & expediente

			ElseIf Len(responsable) > 3 And responsable.Contains("BUSCAR") = False Then
				sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   responsable_expediente.principal,
                   persona.razon as responsable, persona.cuil, persona.telefono, 
                   persona.email, persona.difunto, persona.fisica " &
				   SQLTable & " WHERE persona.razon LIKE '%" & responsable & "%'"

			ElseIf Len(profesional) > 3 And responsable.Contains("BUSCAR") = False Then
				sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   persona_1.razon as profesional, persona_1.cuil, persona_1.email, persona_1.telefono,
                   profesional.matricula, profesional_titulo.titulo,
                   oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2, oprivadas.visado " &
				   SQLTable & " WHERE persona_1.razon LIKE '%" & profesional & "%'"

			ElseIf Len(cuil) = 11 Then
				sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   persona.razon as responsable, persona.cuil, persona.telefono,
                   persona.email, persona.difunto, persona.fisica,
                   oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2,
                   oprivadas.inicio_obra, oprivadas.fin_obra, oprivadas.visado " &
				   SQLTable & " WHERE persona.cuil = '" & cuil & "'"

			Else
				sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   persona.razon as responsable, persona.difunto, persona.fisica,
                   persona_1.razon as profesional, profesional_titulo.titulo, profesional.matricula,
                   oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2,
                   oprivadas.inicio_obra, oprivadas.fin_obra, oprivadas.visado " &
				   SQLTable & " WHERE responsable_expediente.principal=True"
			End If

			Return DbMan.read(sql)
		End Function
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
			Return DbMan.read(  "SELECT * FROM oprivadas 
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
                    DbMan.edit(  InsertExpSQL)
				End If
			Else
                'Crear expediente por defecto
                DbMan.edit(  InsertExpSQL)
			End If
			Return Seleccionar(exp)
		End Function

		Public Shared Sub Bloquear(opr_id As Integer, lock As Boolean)
			Dim user_id As Integer = 0
			If lock And My.Settings.UserId > 0 Then
				user_id = My.Settings.UserId
			End If
			DbMan.edit(  "UPDATE oprivadas Set user_id=" & user_id & " WHERE id=" & opr_id)
		End Sub

		Shared Sub LimpiarTemporal(opr_id As Integer, inmuebles As BindingSource, Optional temp As Boolean = False)
			Dim dtab As DataTable
			Dim sql As String = "Select id FROM oprivadas WHERE user_id=" & My.Settings.UserId & " And temporal=" & temp
			If opr_id > 0 Then
				sql += " And id=" & opr_id
			End If
			dtab = DbMan.read(  sql)

			If dtab.Rows.Count > 0 Then
				LimpiarResponsable(opr_id)
                'Buscar inmuebles relacionados y eliminarlos
                'Catastro.eliminar(opr_id, inmuebles)
            End If

			sql = "DELETE * FROM oprivadas WHERE user_id=" & My.Settings.UserId & " And temporal=" & temp
			If opr_id > 0 Then
				sql += " And id=" & opr_id
			End If
			DbMan.edit(  sql)

		End Sub

        'Seccion Persona
        Shared Sub AgregarResponsable(registro As BindingSource, opr_id As Integer, ResponsablePrincipal As Integer)
            'Lee desde el bindingsource de Personas
            With registro
				For fila As Integer = 0 To .Count - 1
					.Position = fila
					DbMan.edit(  "INSERT INTO responsable_expediente(opr_id, per_id, principal) 
                                     VALUES(" & opr_id & ",
                                            " & .Current("persona_id") & ",
                                            " & CBool(registro.Current("persona_id") = ResponsablePrincipal) & ")")
				Next
			End With
		End Sub
		Shared Sub LimpiarResponsable(opr_id As Integer)
			DbMan.edit(  "DELETE * FROM responsable_expediente WHERE opr_id=" & opr_id)
		End Sub
		Shared Sub ActualizarProfesional(opr_id As Integer, prof_id As Integer)
			DbMan.edit(  "UPDATE oprivadas SET profesional_id=" & prof_id &
							" WHERE id=" & opr_id)
		End Sub

        'Seccion Inmueble

        'Seccion Expediente
        Shared Sub ActualizarDetalle(opr_id As Integer, inicio_obra As Date, finalizado As Boolean, fin_obra As Date,
									 recibe As String, tarea As String, tarea2 As String, observaciones As String)
			Dim sql As String = "UPDATE oprivadas SET"
			If finalizado Then
				sql += " fin_obra=#" & fin_obra & "#,"
			End If
			sql += " inicio_obra=#" & inicio_obra & "#,  recibe='" & recibe & "',
                     tarea='" & tarea & "', tarea2='" & tarea2 & "', observaciones='" & observaciones & "'
                     WHERE id=" & opr_id
			DbMan.edit(  sql)
		End Sub
    End Class
End Class
