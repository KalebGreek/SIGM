Public Class Empleado
    Shared SelectSQL As String = "SELECT persona.id, persona.razon, persona.cuil, persona.difunto," &
                                " empleado.alta, empleado.baja" &
                                " FROM persona INNER JOIN empleado ON persona.id=empleado.per_id"

    Shared Function BuscarPorPersona(keyword As String, difunto As Boolean) As DataTable
        Dim sql As String = SelectSQL
        sql += " AND Persona.difunto=" & difunto & " AND fisica=True"
        If keyword.Contains("BUSCAR") = False And Len(keyword) > 0 Then
            If keyword <> "" Then
                If Val(keyword) > 0 Then
                    If Len(keyword) = 11 Then
                        sql += " AND Persona.cuil=" & CDbl(keyword)
                    Else
                        sql += " AND Persona.id=" & Val(keyword)
                    End If
                ElseIf Len(keyword) > 3 Then
                    sql += " AND Persona.razon LIKE '%" & keyword & "%'"
                End If
            End If
        End If
        sql += " ORDER By Persona.razon"
        Return bd.read(defcon, sql)
    End Function
End Class
