Class Empleado
    Const SelectSQL As String = "SELECT empleado.id as empleado_id, persona.id as persona_id, persona.razon, persona.cuil, persona.difunto,
								                  empleado.alta, empleado.jerarquia"
    Const TableSQL As String = " FROM persona INNER JOIN empleado ON persona.id=empleado.persona_id"

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
        Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
    End Function

    Shared Function Seleccionar(empleado_id As Integer, persona_id As Integer) As DataRow
        Dim sqlSelect As String
        If empleado_id > 0 Then
            sqlSelect = " WHERE empleado.id=" & empleado_id
        Else
            sqlSelect = " WHERE persona.id=" & persona_id
        End If
        Return DbMan.ReadDB(SelectSQL & TableSQL & sqlSelect, My.Settings.CurrentDB).Rows(0)
    End Function

    Shared Function guardar(empleado_id As Integer, ByVal persona_id As Integer, alta As Date, jerarquia As String) As Integer
        If empleado_id <> 0 Then
            DbMan.EditDB("UPDATE empleado 
                             SET persona_id=" & persona_id & ", alta='" & alta & "', jerarquia='" & jerarquia & "'
						   WHERE id=" & empleado_id,
                         My.Settings.CurrentDB)
        Else
            DbMan.EditDB("INSERT INTO empleado(persona_id, alta, jerarquia) 
							   VALUES(" & persona_id & ", '" & alta & "', '" & jerarquia & "')",
                         My.Settings.CurrentDB)

            empleado_id = DbMan.ReadDB("SELECT MAX(id) as id FROM empleado WHERE persona_id=" & persona_id, My.Settings.CurrentDB).Rows(0)("id")
        End If
        Return empleado_id
    End Function
    Shared Function eliminar(ByVal empleado_id As Integer) As Boolean
        Return DbMan.EditDB("DELETE * FROM empleado WHERE id=" & empleado_id, My.Settings.CurrentDB)
    End Function
End Class