Public Class Persona
	Shared PersonaSQL As String = "SELECT persona.id as persona_id, persona.razon, persona.cuil," &
								" per_domicilio.calle, per_domicilio.altura, localidades.nombre as localidad," &
								" persona.email, persona.telefono, persona.difunto, persona.fisica" &
								" FROM (persona LEFT JOIN per_domicilio ON persona.id = per_domicilio.per_id)" &
								" LEFT JOIN localidades ON per_domicilio.localidad_id = localidades.id" &
								" WHERE per_domicilio.principal=True"

    Shared Function Seleccionar(ParentForm As Form, Optional vista As String = "PERSONA") As BindingSource
        Dim SeleccionarPersona As New BusquedaPersona()
        SeleccionarPersona.SelectionMode = True
        SeleccionarPersona.genSearchControl1.vista.Text = vista
        SeleccionarPersona.ShowDialog(ParentForm)
        Return SeleccionarPersona.bs_resultado
    End Function

    Shared Function Buscar(difunto As Boolean, fisica As Boolean) As DataTable
        Dim sql(1) As String
        sql(0) = PersonaSQL
        sql(0) += " AND Persona.difunto=" & difunto & " AND fisica=" & fisica
        sql(1) = " ORDER By Persona.razon ASC"
        Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
	End Function

    Shared Sub Cargar(persona_id As Integer,
                          ByRef TabDPersonal As tabPersona1Datos, ByRef TabDomicilio As tabPersona2Domicilio,
                          ByRef TabContacto As tabPersona3Contacto, ByRef TabAdicional As tabPersona4Adicional)
        TabDPersonal.cargar(persona_id)
        TabDomicilio.cargar(persona_id)
        TabContacto.cargar(persona_id)
        TabAdicional.cargar(persona_id)
    End Sub
    Shared Function Nueva(razon As String, cuil As Double, fisica As Boolean,
							  email As String, telefono As String, difunto As Boolean, Optional ruta_defuncion As String = "") As String
		Dim sql As String
		sql = "INSERT INTO persona(razon, cuil, email, telefono, 
									   difunto, ruta_defuncion, fisica)
							    VALUES('" & razon & "', '" & cuil & "', '" & email & "', " & telefono & ",
										" & difunto & ", '" & ruta_defuncion & "', " & fisica & ")"

		Return sql
	End Function
	Shared Function Modificar(persona_id As Integer, razon As String, cuil As Double, fisica As Boolean,
								  email As String, telefono As String, difunto As Boolean, Optional ruta_defuncion As String = "") As String
		Dim sql As String
		sql = "UPDATE persona Set razon='" & razon & "', email='" & email & "', telefono=" & telefono & "," &
			  " difunto = " & difunto & ", ruta_defuncion='" & ruta_defuncion & "', cuil='" & cuil & "', fisica=" & fisica
		sql += " WHERE id=" & persona_id

		Return sql
	End Function
	Shared Function Eliminar(persona_id As Integer, Optional profesional_id As Integer = 0, Optional proveedor_id As Integer = 0) As Boolean
		Dim dtab_con As New DataTable
		Dim msg As New List(Of String)

		If profesional_id = 0 Then
			dtab_con = Profesional.BuscarPorPersona(persona_id)
			If dtab_con.Rows.Count > 0 Then
                profesional_id = dtab_con(0)("profesional_id")
            End If
		End If
		If profesional_id > 0 Then
			dtab_con = Oprivadas.Expediente.ListarPorProfesional(profesional_id)
			If dtab_con.Rows.Count > 0 Then
				msg.Add("> PROFESIONAL")
				msg.Add("Esta persona está registrada como profesional en los siguientes expedientes: ")
				For fila As Integer = 0 To dtab_con.Rows.Count - 1
					msg.Add("Expte. N." & dtab_con(fila)("expediente"))
				Next
				msg.Add("Debe reemplazar el profesional en los expedientes indicados antes de continuar.")

			End If
			Profesional.eliminar(persona_id)
		End If

		Proveedor.Seleccionar(proveedor_id, persona_id)
		If dtab_con.Rows.Count > 0 Then
			proveedor_id = dtab_con(0)("prov_id")
		End If
		'proveedor
		'Buscar proveedor en contratos de Hacienda e indicar error
		If proveedor_id > 0 Then
			Proveedor.eliminar(persona_id)
		End If

		'catastro
		dtab_con = Catastro.BuscarPorTitular(persona_id)
		If dtab_con.Rows.Count > 0 Then
			msg.Add("> TITULAR DE INMUEBLE")
			msg.Add("Esta persona está registrada como titular en los siguientes inmuebles:")
			For fila As Integer = 0 To dtab_con.Rows.Count - 1
				msg.Add("-- INMUEBLE " & fila + 1 & " --")

				msg.Add("Designacion: Z" & dtab_con(0)("zona") & " C" & dtab_con(0)("circ") & " S" & dtab_con(0)("secc") &
					   " M" & dtab_con(fila)("manz") & " P" & dtab_con(fila)("parc") & " L" & dtab_con(fila)("lote"))

				msg.Add("Direccion: " & dtab_con(fila)("calle") & " " & dtab_con(fila)("altura"))

				msg.Add("Barrio: " & dtab_con(fila)("barrio"))
			Next
			msg.Add("Debe reemplazar el titular en los immuebles indicados antes de continuar.")
			Return False
		End If

		'responsable_expediente
		dtab_con = Oprivadas.Expediente.ListarPorResponsable(persona_id)
		If dtab_con.Rows.Count > 0 Then
			msg.Add("> RESPONSABLE DE EXPEDIENTE")
			msg.Add("Esta persona está registrada como responsable en los siguientes expedientes: ")
			For fila As Integer = 0 To dtab_con.Rows.Count - 1
				msg.Add("Expte. N." & dtab_con(fila)("expediente"))
			Next
			msg.Add("Debe reemplazar el responsable en los expedientes indicados antes de continuar.")
		End If

		If msg.Count > 0 Then
			Dim errormsg As New visor_error("Error al eliminar persona", msg)
			errormsg.ShowDialog()
			Return False
		Else
            'documentos
            Dim sql(0) As String
            sql(0) = "SELECT descripcion, ruta FROM per_documento WHERE per_id=" & persona_id
            dtab_con = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

            If dtab_con.Rows.Count > 0 Then
				msg.Add("Los siguientes documentos seran eliminados del registro junto con la persona seleccionada: ")
				For fila As Integer = 0 To dtab_con.Rows.Count - 1
					msg.Add(dtab_con(fila)("descripcion") & " ubicado en " & dtab_con(fila)("ruta"))
				Next
			Else
				msg.Add("Se eliminara la persona seleccionada.")
			End If
			msg.Add("Desea continuar?")

			Dim errormsg As New visor_error("Eliminar persona", msg)
            If errormsg.ShowDialog() = DialogResult.Ignore Then
                DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE FROM per_documento WHERE per_id=" & persona_id)
                DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE FROM persona WHERE id=" & persona_id)
                Return True
            Else
                Return False
			End If
		End If
	End Function

    'Varios
    Shared Function CalcularCuil(dni As String, gen As String) As String
        'Variables de cálculo de CUIL
        Dim pos, var(10), result As Integer

        'Normalizar
        If Len(dni) < 8 Then
            dni = "0" & dni
        End If
        var(0) = 2
        'Obtener género
        If gen = "M" Then
            var(1) = 0
        Else
            var(1) = 7
        End If
        'Obtener cifras por separado
        pos = 1
        Do While pos < 9
            var(pos + 1) = Microsoft.VisualBasic.Mid(dni, pos, 1)
            pos += 1
        Loop

        'Calcular
        result = ((var(0) * 5) + (var(1) * 4) + (var(2) * 3) + (var(3) * 2) + (var(4) * 7) + (var(5) * 6) +
        (var(6) * 5) + (var(7) * 4) + (var(8) * 3) + (var(9) * 2)) Mod 11

        If result = 0 Then
            var(10) = 0
        Else
            If result = 1 Then
                If var(1) = 0 Then
                    var(10) = 9
                Else
                    var(10) = 4
                End If
                var(1) = 3
            Else
                var(10) = 11 - result
            End If
        End If
        Return var(0).ToString & var(1).ToString & dni & var(10).ToString
    End Function
End Class