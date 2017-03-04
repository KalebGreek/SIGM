Public Class Combustible
	Public Class sql
		Shared CombustibleTableSQL As String = " 
							FROM (persona AS persona_2 INNER JOIN (usuarios INNER JOIN ((proveedor 
							INNER JOIN (areas INNER JOIN (persona INNER JOIN ((hac_combustible_categoria_receptor 
							INNER JOIN hac_combustible_receptor 
							ON hac_combustible_categoria_receptor.Id = hac_combustible_receptor.categoria_id) 
							INNER JOIN hac_combustible_historial 
							ON hac_combustible_receptor.Id = hac_combustible_historial.receptor_id) 
							ON persona.id = hac_combustible_historial.responsable_id) 
							ON areas.Id = hac_combustible_receptor.area_id) 
							ON proveedor.Id = hac_combustible_historial.proveedor_id) 
							INNER JOIN persona AS persona_1 ON proveedor.per_id = persona_1.id) 
							ON usuarios.Id = hac_combustible_historial.user_id) 
							ON persona_2.id = usuarios.persona_id) 
							INNER JOIN hac_combustible_tipo 
							ON hac_combustible_historial.tipo_combustible_id = hac_combustible_tipo.Id"

		Shared Function LoadTicket(id As Integer) As DataTable
			DbMan.read(My.Settings.DefaultCon, "SELECT hac_combustible_historial.Id, usuarios.Id, persona_2.razon, 
							hac_combustible_historial.fecha, hac_combustible_historial.ticket, 
							hac_combustible_historial.responsable_id, persona.razon, 
							hac_combustible_historial.proveedor_id, persona_1.razon,
							hac_combustible_historial.receptor_id, hac_combustible_categoria_receptor.detalle,
							hac_combustible_receptor.marca, hac_combustible_receptor.dominio, 
							hac_combustible_receptor.modelo, hac_combustible_receptor.alta, 
							hac_combustible_receptor.baja, hac_combustible_receptor.observaciones, 
							hac_combustible_receptor.descripcion, hac_combustible_receptor.area_id, 
							areas.descripcion, hac_combustible_receptor.autorizado, 
							hac_combustible_tipo.descripcion, hac_combustible_historial.litros, 
							hac_combustible_historial.monto, hac_combustible_historial.tipo_combustible_id
							" & CombustibleTableSQL)

		End Function
		Shared Function SaveTicket(id As Integer) As DataTable

		End Function

		Shared Function LoadResponsable(id As Integer)

		End Function
		Shared Function SaveResponsable(id As Integer)

		End Function
		Shared Function LoadReceiver(id As Integer)

		End Function
		Shared Function SaveReceiver()

		End Function
	End Class
End Class
