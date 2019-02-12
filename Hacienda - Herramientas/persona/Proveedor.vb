Public Class Proveedor
	Shared SelectSQL As String = "SELECT persona.id as persona_id, persona.razon, persona.cuil, persona.fisica, 
									  per_domicilio.calle, per_domicilio.altura, localidades.nombre, 
									  proveedor.id AS proveedor_id,
									  proveedor.actividad_id, prov_actividad.actividad AS actividad, 
									  proveedor.responsable_iva_id, responsable_iva.descripcion as responsable_iva"

	Shared TableSQL As String = " FROM (responsable_iva INNER JOIN (prov_actividad INNER JOIN (persona 
								INNER JOIN proveedor ON persona.id = proveedor.per_id) 
										ON prov_actividad.Id = proveedor.actividad_id) 
										ON responsable_iva.Id = proveedor.responsable_iva_id) 
								INNER JOIN (per_domicilio INNER JOIN localidades 
										ON per_domicilio.localidad_id = localidades.id) 
										ON persona.id = per_domicilio.per_id
									 WHERE per_domicilio.principal=True"


	Shared Function BuscarPorPersona(keyword As String, difunto As Boolean, fisica As Boolean) As DataTable
		Dim sql As String = SelectSQL & TableSQL & " And persona.fisica=" & fisica
		If difunto Then
			sql += " AND persona.difunto=" & difunto
		End If

		If keyword.Contains("BUSCAR") = False And Len(keyword) > 0 Then
			If keyword <> "" Then
				If Val(keyword) > 0 Then
					If Len(keyword) = 11 Then
						sql += " And Persona.cuil=" & CDbl(keyword)
					End If
				ElseIf Len(keyword) > 3 Then
					sql += " And Persona.razon Like '%" & keyword & "%'"
				End If
			End If
		End If
		sql += " ORDER By Persona.razon"
		Return DbMan.read(Nothing, My.Settings.DefaultCon, sql)
	End Function
	Shared Function Seleccionar(proveedor_id As Integer, persona_id As Integer) As DataTable
		Dim sql As String = SelectSQL & TableSQL
		If proveedor_id > 0 Then
			sql += " AND proveedor.id=" & proveedor_id
		Else
			sql += " AND persona.id=" & persona_id
		End If
		Return DbMan.read(Nothing, My.Settings.DefaultCon, sql)
	End Function
	Shared Function guardar(proveedor_id As Integer, ByVal per_id As Integer, ByVal actividad As Integer, ByVal responsable As Integer) As Integer
		If proveedor_id > 0 Then
			DbMan.edit(Nothing, My.Settings.DefaultCon,
							"UPDATE proveedor SET per_id=" & per_id & ", actividad_id=" & actividad & ",
							        responsable_iva_id=" & responsable & "
							  WHERE id=" & proveedor_id)
		Else
			DbMan.edit(Nothing, My.Settings.DefaultCon,
							"INSERT INTO proveedor(per_id, actividad_id, responsable_iva_id) 
								 VALUES(" & per_id & ", " & actividad & ", " & responsable & ")")

			Dim dtab As New DataTable
			dtab = DbMan.read(Nothing, My.Settings.DefaultCon,
								"SELECT MAX(id) as id FROM proveedor WHERE per_id=" & per_id)

			proveedor_id = dtab(0)("id")
		End If
		Return proveedor_id
	End Function
	Shared Function eliminar(ByVal proveedor_id As Integer) As Integer
		DbMan.edit(Nothing, My.Settings.DefaultCon, "DELETE * FROM proveedor WHERE id=" & proveedor_id)
		Return 0
	End Function
End Class