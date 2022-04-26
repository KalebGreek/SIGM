Class ObrasPrivadas

    Shared ReadOnly SQLTable _
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

    Shared ReadOnly SQLWhere As String = " WHERE responsable_expediente.principal=True And cat_frente.ubicacion=True
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

                Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
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

                Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
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

                Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
            End Function
        End Class
        'Funciones de listado para evitar borrar expedientes accidentalmente
        Shared Function ListarPorResponsable(persona_id As Integer) As DataTable
            Dim sql(2) As String
            sql(0) = "SELECT responsable_expediente.Id As responsable_id, expediente, per_id"
            sql(1) = " FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id) 
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id"
            sql(2) = " WHERE responsable_expediente.per_id=" & persona_id

            Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
        End Function
        Shared Function ListarPorProfesional(prof_id As Integer) As DataTable
            Dim sql(2) As String
            sql(0) = "SELECT responsable_expediente.Id As id, expediente, profesional_id"
            sql(1) = " FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id"
            sql(2) = " WHERE oprivadas.profesional_id=" & prof_id

            Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
        End Function

        Shared Function ListarResponsables(expediente As Integer) As DataTable
            Dim sql(2) As String
            sql(0) = "SELECT persona.id As persona_id, razon, cuil, email, telefono, difunto"
            sql(1) = "        FROM (persona INNER JOIN responsable_expediente On persona.id=responsable_expediente.per_id)
                            INNER JOIN oprivadas On responsable_expediente.opr_id=oprivadas.id"
            sql(2) = "WHERE oprivadas.expediente=" & expediente
            Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
        End Function

        Shared Function Seleccionar(expediente As Integer) As DataTable
            Return DbMan.ReadDB("SELECT * FROM oprivadas WHERE Oprivadas.expediente= " & expediente,
                                My.Settings.CurrentDB)

        End Function

        'MODIFICAR
        Shared Function Generar(exp As String) As DataRow
            Dim dtab As DataTable = Seleccionar(exp)
            Do
                If dtab.Rows.Count > 0 Then
                    'Último expediente creado por el usuario
                    If MsgBoxResult.No = MsgBox("¿Desea recuperar datos del último expediente no guardado?" &
                                                " Presione Sí para recuperar, No para eliminar.",
                                                  MsgBoxStyle.YesNo, "Obras Privadas") Then
                        LimpiarTemporal(dtab(0)("id"))
                    End If
                Else
                    'Crear expediente por defecto
                    Dim sqlInsert As String = "INSERT INTO oprivadas(expediente, tarea, tarea2, inicio_obra, profesional_id, user_id, temporal)
                                            VALUES(" & exp & ", 'MENSURA','SIMPLE', '" & Date.Today.ToShortDateString & "', 0, " & My.Settings.UserId & ", True)"
                    DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)
                End If
                dtab = Seleccionar(exp)
            Loop While dtab.Rows.Count = 0
            Return dtab.Rows(0)
        End Function

        Public Shared Sub Bloquear(opr_id As Integer, lock As Boolean)
            Dim user_id As Integer = 0
            If lock And My.Settings.UserId > 0 Then
                user_id = My.Settings.UserId
            End If
            DbMan.EditDB("UPDATE oprivadas Set user_id=" & user_id & " 
						   WHERE id=" & opr_id & " AND user_id=0",
                         My.Settings.CurrentDB)
        End Sub

        Shared Sub LimpiarTemporal(opr_id As Integer)
            Dim dtab As DataTable
            If opr_id > 0 Then
                Dim sqlSelect As String = "SELECT id FROM oprivadas 
                                        WHERE user_id=" & My.Settings.UserId & " And temporal=True"
                Dim sqlDelete As String = "DELETE * FROM oprivadas 
                                        WHERE user_id=" & My.Settings.UserId & " And temporal=True"

                sqlSelect += " AND id=" & opr_id
                sqlDelete += " AND id=" & opr_id
                dtab = DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
                If dtab.Rows.Count > 0 Then
                    ObrasPrivadas.Expediente.EliminarResponsable(opr_id)
                    'Buscar inmuebles relacionados y eliminarlos
                    'Catastro.eliminar(opr_id, inmuebles)
                    DbMan.EditDB(sqlDelete, My.Settings.CurrentDB)
                End If
            End If
        End Sub

        Public Class Validar
            Shared Function Personas(bs_resp As BindingSource, profesional_id As Double) As List(Of String)
                Dim msg As New List(Of String) From {"** PERSONAS **"}

                If bs_resp.Count = 0 Then
                    msg.Add("(×) Debe indicar al menos un responsable.")
                End If
                If profesional_id = 0 Then
                    msg.Add("(×) Debe indicar un profesional a cargo.")
                End If

                Return msg
            End Function
            Shared Function Inmuebles(bs_catastro As BindingSource) As List(Of String)
                Dim msg As New List(Of String) From {"** INMUEBLES **"}

                If bs_catastro.Count = 0 Then
                    msg.Add("(×) No se agregó un inmueble.")
                End If

                Return msg
            End Function
            Shared Function Expediente(tarea As ComboBox, tarea2 As ComboBox, inicio_obra As Date, recibe As Integer,
                                        check_fin_obra As Boolean, fin_obra As Date, ruta_fin_obra As String) As List(Of String)
                Dim msg As New List(Of String) From {"** EXPEDIENTE **"}

                'Detalles de expediente
                If tarea.SelectedIndex = -1 Then
                    msg.Add("(×) Seleccione tarea.")
                ElseIf tarea.Text = "MENSURA" And tarea2.SelectedIndex = -1 Then
                    msg.Add("(×) Seleccione detalle de tarea de mensura.")
                End If
                If inicio_obra > Date.Today Then
                    msg.Add("(×) La fecha de inicio de obra es inválida.")
                End If
                If recibe = -1 Then
                    msg.Add("(×) Debe indicar quien recibe el expediente.")
                End If
                If check_fin_obra Then
                    If fin_obra <= inicio_obra Then
                        msg.Add("(×) La fecha de fin de de obra es inválida.")
                    End If
                    If ruta_fin_obra = "" Then
                        msg.Add("(×) Cargar copia de certificado de Fin de Obra.")
                    End If
                End If

                Return msg
            End Function
        End Class

        'Seccion Persona
        Public Class Agregar
            Shared Function Responsable(registro As DataTable, opr_id As Integer, ResponsablePrincipal As Integer) As Boolean
                Dim sqlInsert(registro.Rows.Count - 1) As String
                'Lee desde el bindingsource de Personas
                For Each dr As DataRow In registro.Rows
                    sqlInsert(registro.Rows.IndexOf(dr)) = "INSERT INTO responsable_expediente(opr_id, per_id, principal)
									                         VALUES(" & opr_id & ", " & dr("persona_id").ToString & ",
											                        " & CBool(dr("persona_id").ToString = ResponsablePrincipal) & ")"
                Next
                Return DbMan.EditDB(sqlInsert, My.Settings.CurrentDB) > -1
            End Function

            'Shared Sub LimpiarResponsables(opr_id As Integer)
            '    DbMan.EditDB("DELETE * FROM responsable_expediente WHERE opr_id=" & opr_id, My.Settings.CurrentDB)
            'End Sub

            Shared Sub Profesional(opr_id As Integer, prof_id As Integer)
                DbMan.EditDB("UPDATE oprivadas SET profesional_id=" & prof_id &
                         " WHERE id=" & opr_id, My.Settings.CurrentDB)
            End Sub

            'Seccion Inmueble

            'Seccion Expediente
            Shared Sub Detalle(opr_id As Integer, inicio_obra As Date, visado As Boolean, fin_obra As Date,
                                 recibe As String, tarea As String, tarea2 As String, observaciones As String)
                Dim sqlUpdate As String = "UPDATE oprivadas SET"

                If visado Then
                    sqlUpdate += " fin_obra='" & fin_obra.ToShortDateString & "',"
                End If
                sqlUpdate += " inicio_obra='" & inicio_obra.ToShortDateString & "',  recibe='" & recibe & "', visado=" & visado & ",
                           tarea='" & tarea & "', tarea2='" & tarea2 & "', observaciones='" & observaciones & "'
                     WHERE id=" & opr_id
                DbMan.EditDB(sqlUpdate, My.Settings.CurrentDB)
            End Sub
        End Class
        Overloads Shared Function EliminarResponsable(source As DataRow) As Boolean
            Return DbMan.EditDB("DELETE * FROM responsable_expediente WHERE id=" & source("responsable_id"), My.Settings.CurrentDB) > -1
        End Function
        Overloads Shared Function EliminarResponsable(opr_id As Double) As Boolean
            Return DbMan.EditDB("DELETE * FROM responsable_expediente WHERE opr_id=" & opr_id, My.Settings.CurrentDB) > -1
        End Function
    End Class
End Class
