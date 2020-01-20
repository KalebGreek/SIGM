Public Class Empleado
    Shared ReadOnly SelectSQL As String = "SELECT empleado.id as empleado_id, persona.id as persona_id, persona.razon, persona.cuil, persona.difunto,
								                  empleado.alta, empleado.jerarquia"
    Shared ReadOnly TableSQL As String = "FROM persona INNER JOIN empleado ON persona.id=empleado.persona_id"

    Shared Function BuscarPorPersona(keyword As String, difunto As Boolean) As DataTable
        Dim sql(3) As String
        sql(0) = SelectSQL
        sql(1) = TableSQL
        sql(2) = " WHERE Persona.difunto=" & difunto & " And fisica=True"
        If keyword <> "" Then
            If Val(keyword) > 0 Then
                If Len(keyword) = 11 Then
                    sql(2) += " AND Persona.cuil=" & CDbl(keyword)
                Else
                    sql(2) += " AND Persona.id=" & Val(keyword)
                End If
            ElseIf Len(keyword) > 3 Then
                sql(2) += " AND Persona.razon Like '%" & keyword & "%'"
            End If
        End If
        sql(3) = " ORDER By Persona.razon"
        Return DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
    End Function

    Shared Function Seleccionar(empleado_id As Integer, persona_id As Integer) As DataTable
        Dim sql(2) As String
        sql(0) = SelectSQL
        sql(1) = TableSQL
        If empleado_id > 0 Then
            sql(2) += " WHERE empleado.id=" & empleado_id
        Else
            sql(2) += " WHERE persona.id=" & persona_id
        End If
        Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
    End Function

    Shared Function guardar(empleado_id As Integer, ByVal persona_id As Integer, alta As Date, jerarquia As String) As Integer
        If empleado_id <> 0 Then
            DbMan.editDB(Nothing, My.Settings.CurrentDB,
                            "UPDATE empleado SET persona_id=" & persona_id & ", alta='" & alta & "',
							        jerarquia='" & jerarquia & "'
							  WHERE id=" & empleado_id)
        Else
            DbMan.editDB(Nothing, My.Settings.CurrentDB,
                            "INSERT INTO empleado(persona_id, alta, jerarquia) 
								 VALUES(" & persona_id & ", '" & alta & "', '" & jerarquia & "')")

            Dim sql(0) As String
            sql(0) = "SELECT MAX(id) as id FROM empleado WHERE persona_id=" & persona_id
            empleado_id = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)(0)("id")
        End If
        Return empleado_id
    End Function
    Shared Function eliminar(ByVal empleado_id As Integer) As Integer
        DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM empleado WHERE id=" & empleado_id)
        Return 0
    End Function
End Class