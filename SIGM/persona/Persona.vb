Class Persona
	Shared PersonaSQL As String = "SELECT persona.id as persona_id, persona.razon, persona.cuil," &
								" per_domicilio.calle, per_domicilio.altura, localidades.nombre as localidad," &
								" persona.email, persona.telefono, persona.difunto, persona.fisica" &
								" FROM (persona LEFT JOIN per_domicilio ON persona.id = per_domicilio.per_id)" &
								" LEFT JOIN localidades ON per_domicilio.localidad_id = localidades.id" &
								" WHERE per_domicilio.principal=True"

	Shared Function Seleccionar(ParentForm As Form, Optional vista As String = "PERSONA") As BindingSource
		Using SeleccionarPersona As New BusquedaPersona(True) With {.Owner = ParentForm}

			SeleccionarPersona.genSearchControl1.vista.Text = vista
			SeleccionarPersona.ShowDialog()
			Return SeleccionarPersona.bs_resultado
		End Using
	End Function

	Shared Function Buscar(difunto As Boolean, fisica As Boolean) As DataTable
		Dim sql(1) As String
		sql(0) = PersonaSQL
		sql(0) += " AND Persona.difunto=" & difunto & " AND fisica=" & fisica
		sql(1) = " ORDER By Persona.razon ASC"
		Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
	End Function

	Shared Function Nueva(razon As String, cuil As Double, fisica As Boolean,
							  email As String, telefono As String, difunto As Boolean, Optional RutaDefuncion As String = "") As String
		Dim sql As String
		sql = "INSERT INTO persona(razon, cuil, email, telefono, 
									   difunto, ruta_defuncion, fisica)
							    VALUES('" & razon & "', '" & cuil & "', '" & email & "', " & telefono & ",
										" & difunto & ", '" & RutaDefuncion & "', " & fisica & ")"

		Return sql
	End Function
	Shared Function Modificar(PersonaId As Integer, razon As String, cuil As Double, fisica As Boolean,
								  email As String, telefono As String, difunto As Boolean, Optional RutaDefuncion As String = "") As String
		Dim sql As String
		sql = "UPDATE persona Set razon='" & razon & "', email='" & email & "', telefono=" & telefono & "," &
			  " difunto = " & difunto & ", ruta_defuncion='" & RutaDefuncion & "', cuil='" & cuil & "', fisica=" & fisica
		sql += " WHERE id=" & PersonaId

		Return sql
	End Function
	Shared Function Eliminar(PersonaId As Integer, Optional ProfesionalId As Integer = 0,
							Optional ProveedorId As Integer = 0) As Boolean
		Dim dtab_con As New DataTable
		Dim msg As New List(Of String)

		If ProfesionalId = 0 Then
			dtab_con = Profesional.BuscarPorPersona(PersonaId)
			If dtab_con.Rows.Count > 0 Then
				ProfesionalId = dtab_con.Rows(0)("profesional_id")
			End If
		End If
		If ProfesionalId > 0 Then
			dtab_con = Oprivadas.Expediente.ListarPorProfesional(ProfesionalId)
			If dtab_con.Rows.Count > 0 Then
				msg.Add("> PROFESIONAL")
				msg.Add("Esta persona está registrada como profesional en los siguientes expedientes: ")
				For fila As Integer = 0 To dtab_con.Rows.Count - 1
					msg.Add("Expte. N." & dtab_con.Rows(fila)("expediente"))
				Next
				msg.Add("Debe reemplazar el profesional en los expedientes indicados antes de continuar.")

			End If
			Profesional.eliminar(PersonaId)
		End If

		Proveedor.Seleccionar(ProveedorId, PersonaId)
		If dtab_con.Rows.Count > 0 Then
			ProveedorId = dtab_con.Rows(0)("prov_id")
		End If
		'proveedor
		'Buscar proveedor en contratos de Hacienda e indicar error
		If ProveedorId > 0 Then
			Proveedor.eliminar(PersonaId)
		End If

		'catastro
		dtab_con = Catastro.BuscarPorTitular(PersonaId)
		If dtab_con.Rows.Count > 0 Then
			msg.Add("> TITULAR DE INMUEBLE")
			msg.Add("Esta persona está registrada como titular en los siguientes inmuebles:")
			For fila As Integer = 0 To dtab_con.Rows.Count - 1
				msg.Add("-- INMUEBLE " & fila + 1 & " --")

				msg.Add("Designacion: Z" & dtab_con.Rows(0)("zona") & " C" & dtab_con.Rows(0)("circ") & " S" & dtab_con.Rows(0)("secc") &
					   " M" & dtab_con.Rows(fila)("manz") & " P" & dtab_con.Rows(fila)("parc") & " L" & dtab_con.Rows(fila)("lote"))

				msg.Add("Direccion: " & dtab_con.Rows(fila)("calle") & " " & dtab_con.Rows(fila)("altura"))

				msg.Add("Barrio: " & dtab_con.Rows(fila)("barrio"))
			Next
			msg.Add("Debe reemplazar el titular en los immuebles indicados antes de continuar.")
			Return False
		End If

		'responsable_expediente
		dtab_con = Oprivadas.Expediente.ListarPorResponsable(PersonaId)
		If dtab_con.Rows.Count > 0 Then
			msg.Add("> RESPONSABLE DE EXPEDIENTE")
			msg.Add("Esta persona está registrada como responsable en los siguientes expedientes: ")
			For fila As Integer = 0 To dtab_con.Rows.Count - 1
				msg.Add("Expte. N." & dtab_con.Rows(fila)("expediente"))
			Next
			msg.Add("Debe reemplazar el responsable en los expedientes indicados antes de continuar.")
		End If

		If msg.Count > 0 Then
			Using errormsg As New visor_error("Error al eliminar persona", msg)
				errormsg.ShowDialog()
			End Using
			Return False
		Else
			'documentos
			Dim sql(0) As String
			sql(0) = "SELECT descripcion, ruta FROM per_documento WHERE per_id=" & PersonaId
			dtab_con = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

			If dtab_con.Rows.Count > 0 Then
				msg.Add("Los siguientes documentos seran eliminados del registro junto con la persona seleccionada: ")
				For fila As Integer = 0 To dtab_con.Rows.Count - 1
					msg.Add(dtab_con.Rows(fila)("descripcion") & " ubicado en " & dtab_con.Rows(fila)("ruta"))
				Next
			Else
				msg.Add("Se eliminara la persona seleccionada.")
			End If
			msg.Add("Desea continuar?")

			Using errormsg As New visor_error("Eliminar persona", msg)
				If errormsg.ShowDialog() = DialogResult.Ignore Then
					DbMan.EditDB(Nothing, My.Settings.CurrentDB, "DELETE FROM per_documento WHERE per_id=" & PersonaId)
					DbMan.EditDB(Nothing, My.Settings.CurrentDB, "DELETE FROM persona WHERE id=" & PersonaId)
					Return True
				Else
					Return False
				End If
			End Using
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