Public Class Proveedor
    Shared SelectSQL As String = "SELECT persona.id, persona.razon, persona.cuil, persona.fisica,
                                  per_domicilio.calle, per_domicilio.altura, localidades.localidad,
                                  proveedor.id as prov_id, prov_actividad.actividad, proveedor.responsable_iva
                                  FROM ((prov_actividad INNER JOIN (persona INNER JOIN proveedor
                                  On persona.id = proveedor.per_id) ON prov_actividad.Id = proveedor.actividad_id)
                                  INNER JOIN per_domicilio On persona.id = per_domicilio.per_id)
                                  INNER JOIN localidades On per_domicilio.localidad_id = localidades.id
                                  WHERE per_domicilio.principal=True"
    Shared Function BuscarPorPersona(keyword As String, fisica As Boolean) As DataTable
        Dim sql As String = SelectSQL
        sql += " And Persona.difunto=False And persona.fisica=" & fisica
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
        Return bd.read(defcon, sql)
    End Function
    Shared Function Seleccionar(persona_id As Integer) As DataTable
        Dim sql As String = SelectSQL & " AND persona.id=" & persona_id
        Return bd.read(defcon, sql)
    End Function
    Shared Function guardar(ByVal per_id As Integer, proveedor_id As Integer, ByVal responsable As String) As Integer
        If proveedor_id Then
            bd.edit(defcon, "UPDATE proveedor Set responsable='" & responsable & "'" &
                          " WHERE per_id=" & per_id)
        Else
            bd.edit(defcon, "INSERT INTO proveedor(per_id, responsable) VALUES(" & per_id & ", '" & responsable & "')")
        End If
        Dim dtab As New DataTable
        dtab = bd.read(defcon, "SELECT * FROM proveedor WHERE per_id=" & per_id)
        Return dtab(0)("id")
    End Function
    Shared Function eliminar(ByVal per_id As Integer) As Integer
        bd.edit(defcon, "DELETE * FROM proveedor WHERE per_id=" & per_id)
        Return 0
    End Function
End Class