Public Class Combustible

	Shared Sub FillCategory(ByRef bs As BindingSource, ByRef target As ComboBox, ByRef vehiculo As Boolean)
		bs.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_categoria_receptor 
																	  WHERE vehiculo=" & vehiculo & " ORDER BY detalle")
		CtrlMan.Fill.AutoComplete(bs, target, "detalle", "id")
	End Sub

	Shared Sub FillResponsable(ByRef bs As BindingSource, ByRef target As ComboBox, receptor_id As Integer)
		bs.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT razon, cuil, persona_id
															FROM hac_combustible_responsable INNER JOIN persona 
															ON hac_combustible_responsable.persona_id=persona.id
															WHERE receptor_id=" & receptor_id)
		CtrlMan.Fill.AutoComplete(bs, target, "razon", "persona_id")
	End Sub

	Shared Function FindTicket(bs_receptor As BindingSource, Optional last As Boolean = False) As DataTable
		Dim SQLSelectTicket As String = "SELECT hac_combustible_ticket.id AS ticket_id, hac_combustible_ticket.fecha,
										 hac_combustible_ticket.ticket, hac_combustible_ticket.total, persona_1.razon AS proveedor,
										 persona.razon AS responsable, hac_combustible_ticket.user_id"

		Dim SQLTableTicket As String = " FROM (proveedor INNER JOIN (persona 
														 INNER JOIN (hac_combustible_receptor 
														 INNER JOIN (hac_combustible_responsable 
														 INNER JOIN hac_combustible_ticket 
																 ON hac_combustible_responsable.Id = hac_combustible_ticket.responsable_id) 
																 ON hac_combustible_receptor.Id = hac_combustible_responsable.receptor_id) 
																 ON persona.id = hac_combustible_responsable.persona_id) 
																 ON proveedor.Id = hac_combustible_ticket.proveedor_id) 
														 INNER JOIN persona AS persona_1 
																 ON proveedor.per_id = persona_1.id"


		Dim SQLWhere As String = ""

		If bs_receptor.Position > -1 Then
			SQLWhere = " WHERE hac_combustible_receptor.id=" & bs_receptor.Current("receptor_id")
		End If

		If last Then
			SQLWhere = " ORDER BY hac_combustible_ticket.id ASC"
		End If

		Return DbMan.read(My.Settings.DefaultCon, SQLSelectTicket & SQLTableTicket & SQLWhere)
	End Function

	Shared Sub TicketDetail(ByRef visor As DataGridView, ByRef bs As BindingSource, ticket_id As Integer)
		Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, "SELECT hac_combustible_items.Id as item_id, 
																		   hac_combustible_tipo.descripcion,
																		   hac_combustible_items.litros, 
																		   hac_combustible_items.unidades, 
																		   hac_combustible_items.monto
																	  FROM hac_combustible_tipo 
																INNER JOIN hac_combustible_items 
																		ON hac_combustible_tipo.Id = hac_combustible_items.tipo_item_id 
																	 WHERE hac_combustible_items.ticket_id=" & ticket_id)
		CtrlMan.LoadDataGridView(visor, bs, dtab)
	End Sub

End Class
