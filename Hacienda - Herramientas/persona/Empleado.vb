Public Class Empleado
	Shared SelectSQL As String = "SELECT persona.id, persona.razon, persona.cuil, persona.difunto,
								  empleado.alta, empleado.baja
								  FROM persona INNER JOIN empleado ON persona.id=empleado.per_id"

	Shared Function BuscarPorPersona(keyword As String, difunto As Boolean) As DataTable
        Dim sql(2) As String
        sql(0) = SelectSQL
        sql(1) = " WHERE Persona.difunto=" & difunto & " And fisica=True"
        If keyword <> "" Then
			If Val(keyword) > 0 Then
				If Len(keyword) = 11 Then
                    sql(1) += " AND Persona.cuil=" & CDbl(keyword)
                Else
                    sql(1) += " AND Persona.id=" & Val(keyword)
                End If
			ElseIf Len(keyword) > 3 Then
                sql(1) += " AND Persona.razon Like '%" & keyword & "%'"
            End If
		End If
        sql(2) = " ORDER By Persona.razon"
        Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
	End Function
End Class