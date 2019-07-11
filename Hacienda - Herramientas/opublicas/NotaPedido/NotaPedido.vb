Public Class NotaPedido
	Shared SQLSelect As String = "SELECT opu_nota_pedido.Id as nota_pedido_id, opu_nota_pedido.numpedido, opu_nota_pedido.fecha, 
								      opu_nota_pedido.proveedor_id, persona.razon as proveedor_razon, 
									  opu_nota_pedido.responsable_id, persona_1.razon as responsable_razon, 
									  opu_nota_pedido.autoriza_id, persona_2.razon as autoriza_razon"

	Shared SQLTable As String = " FROM (((persona 
								 INNER JOIN proveedor ON persona.id = proveedor.per_id) 
								 INNER JOIN opu_nota_pedido ON proveedor.Id = opu_nota_pedido.proveedor_id) 
								 INNER JOIN persona AS persona_1 ON opu_nota_pedido.responsable_id = persona_1.id) 
								 INNER JOIN persona AS persona_2 ON opu_nota_pedido.autoriza_id = persona_2.id"

	Shared SQLWhere As String
	Shared SQLOrder As String

    Shared Function Buscar() As DataTable
        Dim sql(1) As String
        sql(0) = SQLSelect
        sql(1) = SQLTable
        Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
    End Function

    Shared Function Seleccionar(nota_pedido_id As Integer) As DataRow
        Dim sql(2) As String
        sql(0) = SQLSelect
        sql(1) = SQLTable
        sql(2) = " WHERE opu_nota_pedido.id=" & nota_pedido_id

        Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)(0)
    End Function

	Shared Function Guardar(nota_pedido_id As Integer) As Boolean

		Return False
	End Function

	Shared Function Eliminar(nota_pedido_id As Integer) As Boolean

		Return False
	End Function


	Shared Function LoadReport(nota_pedido_id As Integer) As DataRow
        Dim sql(2) As String
        sql(0) = SQLSelect
        sql(1) = SQLTable
        sql(2) = " WHERE opu_nota_pedido.id=" & nota_pedido_id

        Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)(0)
    End Function
End Class
