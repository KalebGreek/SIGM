Class Oprivadas

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
            Shared Function Expediente() As DataTable

                Dim sql(2) As String
                sql(0) = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
							persona.razon as responsable, persona_1.razon as profesional,
							cat_frente.calle&' '&cat_frente.altura as ubicacion_inmueble, catastro.barrio, 
							oprivadas.tarea, oprivadas.tarea2,
							oprivadas.recibe, oprivadas.visado,
							oprivadas.inicio_obra, oprivadas.fin_obra"
                sql(1) = SQLTable
                sql(2) = SQLWhere

                Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            End Function

            Shared Function Responsable() As DataTable

                Dim sql(2) As String
                sql(0) = "SELECT oprivadas.id As expediente_id, oprivadas.expediente,
							Oprivadas.tarea, Oprivadas.tarea2,			
							responsable_expediente.principal,
							persona.razon As responsable, persona.cuil, 
							per_domicilio.calle&' '&per_domicilio.altura as domicilio,
							localidades.nombre as localidad,
							persona.telefono, persona.email, 
							persona.difunto, persona.fisica,
							oprivadas.recibe, Oprivadas.visado"
                sql(1) = SQLTable
                sql(2) = SQLWhere

                Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            End Function

            Shared Function Profesional() As DataTable

                Dim sql(2) As String
                sql(0) = "SELECT oprivadas.id As expediente_id, oprivadas.expediente,
							Oprivadas.tarea, Oprivadas.tarea2,
							persona_1.razon as profesional, persona_1.cuil, 
							per_domicilio_1.calle&' '&per_domicilio_1.altura as domicilio,
							localidades_1.nombre as localidad,
							persona_1.email, persona_1.telefono,
							profesional_titulo.descripcion As titulo, profesional.matricula, 
							oprivadas.recibe, Oprivadas.visado"
                sql(1) = SQLTable
                sql(2) = SQLWhere

                Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            End Function
        End Class
        'Funciones de listado para evitar borrar expedientes accidentalmente
        Shared Function ListarPorResponsable(persona_id As Integer) As DataTable
            Dim sql(2) As String
            sql(0) = "SELECT responsable_expediente.Id As id, expediente, per_id"
            sql(1) = "FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id) 
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id"
            sql(2) = "WHERE responsable_expediente.per_id=" & persona_id

            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function
        Shared Function ListarPorProfesional(prof_id As Integer) As DataTable
            Dim sql(2) As String
            sql(0) = "SELECT responsable_expediente.Id As id, expediente, profesional_id"
            sql(1) = "FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id"
            sql(2) = "WHERE oprivadas.profesional_id=" & prof_id

            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function

        Shared Function ListarResponsables(expediente As Integer) As DataTable
            Dim sql(2) As String
            sql(0) = "SELECT persona.id As persona_id, razon, cuil, email, telefono, difunto"
            sql(1) = "        FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id"
            sql(2) = "WHERE oprivadas.expediente=" & expediente
            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function

        Shared Function Seleccionar(expediente As Integer) As DataTable
            Dim sql(0) As String
            sql(0) = "SELECT * FROM oprivadas 
							  WHERE Oprivadas.expediente= " & expediente

            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function

        'MODIFICAR
        Shared Function Generar(exp As String) As DataTable
            Dim dtab As New DataTable
            Dim sqlInsert As String()
            sqlInsert.Append("INSERT INTO oprivadas(expediente, tarea, tarea2, inicio_obra, " &
                                        " profesional_id, user_id, temporal)" &
                                 " VALUES(" & exp & ", 'MENSURA','SIMPLE', '" & Date.Today.ToShortDateString & "'," &
                                          " 0, " & My.Settings.UserId & ", True)")

            dtab = Seleccionar(exp)
            If dtab.Rows.Count > 0 Then
                'Último expediente creado por el usuario
                If MsgBoxResult.No = MsgBox("¿Desea recuperar datos del último expediente no guardado?" &
                                            " Presione Sí para recuperar, No para eliminar.",
                                              MsgBoxStyle.YesNo, "Obras Privadas") Then
                    LimpiarTemporal(dtab.Rows(0)("id"), True)
                    'Recrear expediente por defecto
                    DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlInsert)
                End If
            Else
                'Crear expediente por defecto
                DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlInsert)
            End If
            Return Seleccionar(exp)
        End Function

        Public Shared Sub Bloquear(opr_id As Integer, lock As Boolean)
            Dim user_id As Integer = 0
            Dim sqlUpdate As String()
            sqlUpdate.Append("UPDATE oprivadas Set user_id=" & user_id & " 
							   WHERE id=" & opr_id & " AND user_id=0")
            If lock And My.Settings.UserId > 0 Then
                user_id = My.Settings.UserId
            End If
            DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlUpdate)
        End Sub

        Shared Sub LimpiarTemporal(opr_id As Integer, Optional temp As Boolean = False)
            Dim dtab As DataTable
            Dim sql(0) As String
            sql(0) = "SELECT id FROM oprivadas WHERE user_id=" & My.Settings.UserId & " And temporal=" & temp
            If opr_id > 0 Then
                sql(0) += " And id=" & opr_id
            End If
            dtab = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

            If dtab.Rows.Count > 0 Then
                LimpiarResponsable(opr_id)
                'Buscar inmuebles relacionados y eliminarlos
                'Catastro.eliminar(opr_id, inmuebles)
            End If

            sql(0) = "DELETE * FROM oprivadas WHERE user_id=" & My.Settings.UserId & " And temporal=" & temp
            If opr_id > 0 Then
                sql(0) += " And id=" & opr_id
            End If
            DbMan.EditDB(Nothing, My.Settings.CurrentDB, sql)

        End Sub

        'Seccion Persona
        Shared Sub AgregarResponsable(registro As DataTable, opr_id As Integer, ResponsablePrincipal As Integer)
            Dim sqlInsert As String()
            'Lee desde el bindingsource de Personas
            For Each dr As DataRow In registro.Rows
                sqlInsert.Append("INSERT INTO responsable_expediente(opr_id, per_id, principal)
									   VALUES(" & opr_id & ", " & dr("persona_id").ToString & ",
											  " & CBool(dr("persona_id").ToString = ResponsablePrincipal) & ")")
            Next
            DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlInsert)
        End Sub
        Shared Sub LimpiarResponsable(opr_id As Integer)
            Dim sqlDelete As String()
            sqlDelete.Append("DELETE * FROM responsable_expediente" &
                                     "WHERE opr_id=" & opr_id)
            DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlDelete)
        End Sub

        Shared Sub ActualizarProfesional(opr_id As Integer, prof_id As Integer)
            Dim sqlUpdate As String()
            sqlUpdate.Append("UPDATE oprivadas SET profesional_id=" & prof_id &
                             " WHERE id=" & opr_id)
            DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlUpdate)
        End Sub

        'Seccion Inmueble

        'Seccion Expediente
        Shared Sub ActualizarDetalle(opr_id As Integer, inicio_obra As Date, visado As Boolean, fin_obra As Date,
                                 recibe As String, tarea As String, tarea2 As String, observaciones As String)
            Dim sqlUpdate As String()

            sqlUpdate(0) = "UPDATE oprivadas SET"

            If visado Then
                sqlUpdate(0) += " fin_obra='" & fin_obra.ToShortDateString & "',"
            End If
            sqlUpdate(0) += " inicio_obra='" & inicio_obra.ToShortDateString & "',  recibe='" & recibe & "', visado=" & visado & ",
                     tarea='" & tarea & "', tarea2='" & tarea2 & "', observaciones='" & observaciones & "'
                     WHERE id=" & opr_id
            DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlUpdate)
        End Sub
    End Class
End Class
