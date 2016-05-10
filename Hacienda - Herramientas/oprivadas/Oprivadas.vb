﻿Public Class Oprivadas
    Shared SelectSQL _
           As String = " FROM prof_titulo INNER JOIN ((persona INNER JOIN (profesional INNER JOIN
                         (oprivadas INNER JOIN responsable_expediente ON oprivadas.Id = responsable_expediente.opr_id)
                         ON profesional.Id = oprivadas.profesional_id) ON persona.id = responsable_expediente.per_id)
                         INNER JOIN persona AS persona_1 ON profesional.per_id = persona_1.id)
                         ON prof_titulo.Id = profesional.titulo_id"

    Public Class Expediente
        'BUSCAR Y LISTAS
        Shared Function Buscar(Optional expediente As Integer = 0, Optional responsable As String = "",
                                     Optional profesional As String = "", Optional cuil As Double = 0) As DataTable

            Dim sql As String = ""
            If expediente > 19000000 Then
                sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   persona.razon as responsable, persona.difunto, persona.fisica,
                   persona_1.razon as profesional, prof_titulo.titulo, profesional.matricula,
                   oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2,
                   oprivadas.inicio_obra, oprivadas.fin_obra,
                   oprivadas.temporal, oprivadas.visado " &
                   SelectSQL & " WHERE responsable_expediente.principal=True And Oprivadas.expediente = " & expediente

            ElseIf Len(responsable) > 3 And responsable.Contains("BUSCAR") = False Then
                sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   responsable_expediente.principal,
                   persona.razon as responsable, persona.cuil, persona.telefono, 
                   persona.email, persona.difunto, persona.fisica " &
                   SelectSQL & " WHERE persona.razon LIKE '%" & responsable & "%'"

            ElseIf Len(profesional) > 3 And responsable.Contains("BUSCAR") = False Then
                sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   persona_1.razon as profesional, persona_1.cuil, persona_1.email, persona_1.telefono,
                   profesional.matricula, prof_titulo.titulo,
                   oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2, oprivadas.visado " &
                   SelectSQL & " WHERE persona_1.razon LIKE '%" & profesional & "%'"

            ElseIf Len(cuil) = 11 Then
                sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   persona.razon as responsable, persona.cuil, persona.telefono,
                   persona.email, persona.difunto, persona.fisica,
                   oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2,
                   oprivadas.inicio_obra, oprivadas.fin_obra, oprivadas.visado " &
                   SelectSQL & " WHERE persona.cuil = '" & cuil & "'"

            Else
                sql = "SELECT oprivadas.id as expediente_id, oprivadas.expediente,
                   persona.razon as responsable, persona.difunto, persona.fisica,
                   persona_1.razon as profesional, prof_titulo.titulo, profesional.matricula,
                   oprivadas.recibe, oprivadas.tarea, oprivadas.tarea2,
                   oprivadas.inicio_obra, oprivadas.fin_obra, oprivadas.visado " &
                   SelectSQL & " WHERE responsable_expediente.principal=True"
            End If

            Return bd.leer(defcon, sql)
        End Function
        Shared Function ListarPorResponsable(persona_id As Integer) As DataTable
            sel_sql = "Select responsable_expediente.Id As id, expediente, per_id" &
                  " FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)" &
                  " INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id" &
                  " WHERE responsable_expediente.per_id=" & persona_id

            Return bd.leer(defcon, sel_sql)
        End Function

        Shared Function ListarPorProfesional(prof_id As Integer)
            sel_sql = "Select responsable_expediente.Id As id, expediente, profesional_id" &
                  " FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)" &
                  " INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id" &
                  " WHERE oprivadas.profesional_id=" & prof_id

            Return bd.leer(defcon, sel_sql)
        End Function

        Shared Function ListarResponsables(expediente As Integer) As DataTable
            sel_sql = "Select persona.id As persona_id, razon, cuil, email, telefono, difunto" &
                  " FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)" &
                  " INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id" &
                  " WHERE oprivadas.expediente=" & expediente

            Return bd.leer(defcon, sel_sql)
        End Function

        Shared Function Seleccionar(expediente As Integer) As DataTable
            Return bd.leer(defcon, "SELECT * FROM oprivadas WHERE Oprivadas.expediente= " & expediente)
        End Function

        'MODIFICAR
        Shared Function Generar(user_id As Integer, exp As String) As DataTable
            Dim dtab As New DataTable
            Dim InsertExpSQL As String = "INSERT INTO oprivadas(expediente, tarea, tarea2, inicio_obra," &
                                     " profesional_id, user_id, temporal)" &
                                     " VALUES(" & exp & ", 'MENSURA','SIMPLE', '" & Date.Today.ToShortDateString & "'," &
                                     " 0, " & user_id & ", True)"

            dtab = Seleccionar(exp)
            If dtab.Rows.Count > 0 Then
                'Último expediente creado por el usuario
                If MsgBoxResult.No = MsgBox("¿Desea recuperar datos del último expediente no guardado?" &
                                        " Presione Sí para recuperar, No para eliminar.",
                                          MsgBoxStyle.YesNo, "Obras Privadas") Then
                    LimpiarTemporal(user_id, dtab(0)("id"), Nothing, True)
                    'Recrear expediente por defecto
                    bd.edit(defcon, InsertExpSQL)
                End If
            Else
                'Crear expediente por defecto
                bd.edit(defcon, InsertExpSQL)
            End If
            Return Seleccionar(exp)
        End Function

        Public Shared Sub Bloquear(user_id As Integer, opr_id As Integer, lock As Boolean)
            If lock Then
                mod_sql = "UPDATE oprivadas Set user_id=" & user_id & " WHERE id=" & opr_id
            Else
                mod_sql = "UPDATE oprivadas Set user_id=0 WHERE id=" & opr_id
            End If
            bd.edit(defcon, mod_sql)
        End Sub

        Shared Sub LimpiarTemporal(user_id As Integer, opr_id As Integer, inmuebles As BindingSource, Optional temp As Boolean = False)
            Dim dtab As DataTable
            sel_sql = "Select id FROM oprivadas WHERE user_id=" & user_id & " And temporal=" & temp
            If opr_id > 0 Then
                sel_sql += " And id=" & opr_id
            End If
            dtab = bd.leer(defcon, sel_sql)

            If dtab.Rows.Count > 0 Then
                LimpiarResponsable(opr_id)
                'Buscar inmuebles relacionados y eliminarlos
                'Catastro.eliminar(opr_id, inmuebles)
            End If

            del_sql = "DELETE * FROM oprivadas WHERE user_id=" & user_id & " And temporal=" & temp
            If opr_id > 0 Then
                del_sql += " And id=" & opr_id
            End If
            bd.edit(defcon, del_sql)

        End Sub

        'Seccion Persona
        Shared Sub AgregarResponsable(registro As BindingSource, opr_id As Integer, principal As Integer)
            'Lee desde el bindingsource de Personas
            With registro
                For fila As Integer = 0 To .Count - 1
                    .Position = fila
                    mod_sql = "INSERT INTO responsable_expediente(opr_id, per_id, principal) VALUES(" & opr_id & ", " & .Current("persona_id") & ","
                    If registro.Current("persona_id") = principal Then
                        mod_sql += " True)"
                    Else
                        mod_sql += " False)"
                    End If
                    bd.edit(defcon, mod_sql)
                Next
            End With
        End Sub
        Shared Sub LimpiarResponsable(opr_id As Integer)
            bd.edit(defcon, "DELETE * FROM responsable_expediente WHERE opr_id=" & opr_id)
        End Sub
        Shared Sub ActualizarProfesional(opr_id As Integer, prof_id As Integer)
            mod_sql = "UPDATE oprivadas SET profesional_id=" & prof_id &
                        " WHERE id=" & opr_id
            bd.edit(defcon, mod_sql)
        End Sub

        'Seccion Inmueble

        'Seccion Expediente
        Shared Sub ActualizarDetalle(opr_id As Integer, inicio_obra As Date, finalizado As Boolean, fin_obra As Date,
                                     recibe As String, tarea As String, tarea2 As String, observaciones As String)
            mod_sql = "UPDATE oprivadas SET"
            If finalizado Then
                mod_sql += " fin_obra=#" & fin_obra & "#,"
            End If
            mod_sql += " inicio_obra=#" & inicio_obra & "#,  recibe='" & recibe & "'," &
                       " tarea='" & tarea & "', tarea2='" & tarea2 & "', observaciones='" & observaciones & "'" &
                       " WHERE id=" & opr_id
            bd.edit(defcon, mod_sql)
        End Sub
    End Class
End Class
