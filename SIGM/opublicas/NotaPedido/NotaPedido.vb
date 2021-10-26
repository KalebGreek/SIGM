Class NotaPedido
    Shared ReadOnly SQLSelect As String = "SELECT opu_nota_pedido.Id as nota_pedido_id, opu_nota_pedido.numpedido, opu_nota_pedido.fecha, 
								      opu_nota_pedido.proveedor_id, persona.razon as proveedor_razon, 
									  opu_nota_pedido.responsable_id, persona_1.razon as responsable_razon, 
									  opu_nota_pedido.autoriza_id, persona_2.razon as autoriza_razon"

    Shared ReadOnly SQLTable As String = " FROM (((persona 
								 INNER JOIN proveedor ON persona.id = proveedor.per_id) 
								 INNER JOIN opu_nota_pedido ON proveedor.Id = opu_nota_pedido.proveedor_id) 
								 INNER JOIN persona AS persona_1 ON opu_nota_pedido.responsable_id = persona_1.id) 
								 INNER JOIN persona AS persona_2 ON opu_nota_pedido.autoriza_id = persona_2.id"

    Shared Function Buscar() As DataTable
        Return DbMan.ReadDB(SQLSelect & SQLTable, My.Settings.CurrentDB)
    End Function

    Shared Function Seleccionar(nota_pedido_id As Integer) As DataRow
        Return DbMan.ReadDB(SQLSelect & SQLTable & " WHERE opu_nota_pedido.id=" & nota_pedido_id, My.Settings.CurrentDB).Rows(0)
    End Function

    Shared Function Guardar(nota_pedido_id As Integer) As Boolean

        Return False
    End Function

    Shared Function Eliminar(nota_pedido_id As Integer) As Boolean

        Return False
    End Function


    Shared Function LoadReport(nota_pedido_id As Integer) As DataRow
        Return DbMan.ReadDB(SQLSelect & SQLTable & " WHERE opu_nota_pedido.id=" & nota_pedido_id,
                            My.Settings.CurrentDB).Rows(0)
    End Function
End Class
