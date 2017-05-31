Public Class Empleado
	Shared SelectSQL As String = "SELECT persona.id, persona.razon, persona.cuil, persona.difunto,
								  empleado.alta, empleado.baja
								  FROM persona INNER JOIN empleado ON persona.id=empleado.per_id"

	Shared Function BuscarPorPersona(keyword As String, difunto As Boolean) As DataTable
		Dim sql As String = SelectSQL
		sql += " WHERE Persona.difunto=" & difunto & " And fisica=True"
		If keyword <> "" Then
			If Val(keyword) > 0 Then
				If Len(keyword) = 11 Then
					sql += " AND Persona.cuil=" & CDbl(keyword)
				Else
					sql += " AND Persona.id=" & Val(keyword)
				End If
			ElseIf Len(keyword) > 3 Then
				sql += " AND Persona.razon Like '%" & keyword & "%'"
			End If
		End If
		sql += " ORDER By Persona.razon"
		Return DbMan.read(sql)
	End Function
End Class