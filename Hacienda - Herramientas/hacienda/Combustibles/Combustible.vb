Public Class Combustible
	Public Class Receptor
        Shared Sub FillCategory(ByRef bs As BindingSource, ByRef target As ComboBox, ByRef vehiculo As Boolean)
            Dim sql(0) As String
            sql(0) = "SELECT * FROM hac_combustible_categoria_receptor 
												WHERE vehiculo=" & vehiculo & " ORDER BY detalle"
            bs.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            CtrlMan.Fill.SetAutoComplete(target, bs, "detalle", "id")
        End Sub
        Shared Function ListAll(bs_cuenta As BindingSource, bs_categoria As BindingSource, id As Integer) As BindingSource
            Dim sql(2) As String
            sql(0) = "SELECT Id as receptor_id, marca+' | '+dominio+' |'+STR(modelo) AS descripcion"
            sql(1) = "FROM hac_combustible_receptor"

            If bs_categoria Is Nothing And bs_cuenta Is Nothing Then
				If id > 0 Then
                    sql(2) = " WHERE hac_combustible_receptor.id=" & id
                End If
			ElseIf bs_categoria Is Nothing Then
				If bs_cuenta.Position > -1 Then
                    sql(2) = " WHERE cuenta=" & bs_cuenta.Current("orden")
                End If
			ElseIf bs_cuenta Is Nothing Then
				If bs_categoria.Position > -1 Then
                    sql(2) = " WHERE categoria_id=" & bs_categoria.Current("id")
                End If
			Else
				If bs_categoria.Position > -1 And bs_cuenta.Position > -1 Then
                    sql(2) = " WHERE cuenta=" & bs_cuenta.Current("orden") & " AND categoria_id=" & bs_categoria.Current("id")
                End If
			End If

			Dim bs As New BindingSource
			bs.DataSource = DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)

			Return bs
		End Function
        Shared Function Seleccionar(id As Integer) As DataTable
            Dim sql(3) As String
            sql(0) = "SELECT hac_combustible_receptor.id as receptor_id, cuenta, categoria_id,
									  marca, mercosur, dominio, modelo, alta, baja, observaciones,
									  detalle, vehiculo"
            sql(1) = "FROM hac_combustible_receptor INNER JOIN hac_combustible_categoria_receptor"
            sql(2) = "ON hac_combustible_receptor.categoria_id=hac_combustible_categoria_receptor.id"
            sql(3) = "WHERE hac_combustible_receptor.id=" & id

            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function
    End Class

	Public Class Responsable
		Shared Sub Fill(ByRef bs As BindingSource, ByRef target As ComboBox, receptor_id As Integer)
            Dim sql(3) As String
            sql(0) = "SELECT hac_combustible_responsable.id as responsable_id, razon, cuil, persona_id"
            sql(1) = "FROM hac_combustible_responsable INNER JOIN persona
                        ON hac_combustible_responsable.persona_id=persona.id"
            sql(2) = "WHERE receptor_id=" & receptor_id
            sql(3) = "ORDER BY persona.razon"

            bs.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

            CtrlMan.Fill.SetAutoComplete(target, bs, "razon", "responsable_id")
		End Sub
	End Class

	Public Class Ticket
		Shared Function Find(Optional receptor_id As Integer = -1, Optional last As Boolean = False) As DataTable
            Dim sql(3) As String

            sql(0) = "SELECT hac_combustible_ticket.id AS ticket_id, hac_combustible_ticket.fecha,
										 hac_combustible_ticket.ticket, hac_combustible_ticket.total, persona_1.razon AS proveedor,
										 persona.razon AS responsable, hac_combustible_ticket.user_id"

            sql(1) = " FROM (proveedor INNER JOIN (persona 
														 INNER JOIN (hac_combustible_receptor 
														 INNER JOIN (hac_combustible_responsable 
														 INNER JOIN hac_combustible_ticket 
																 ON hac_combustible_responsable.Id = hac_combustible_ticket.responsable_id) 
																 ON hac_combustible_receptor.Id = hac_combustible_responsable.receptor_id) 
																 ON persona.id = hac_combustible_responsable.persona_id) 
																 ON proveedor.Id = hac_combustible_ticket.proveedor_id) 
														 INNER JOIN persona AS persona_1 
																 ON proveedor.per_id = persona_1.id"


            If receptor_id > -1 Then
                sql(2) = " WHERE hac_combustible_receptor.id=" & receptor_id
            End If

            If last Then
                sql(3) = " ORDER BY hac_combustible_ticket.id ASC"
            End If

            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function
        Shared Function ReturnLastTicketID(receptor_id As Integer) As Integer
            Dim sql(0) As String
            sql(0) = "SELECT id FROM hac_combustible_ticket ORDER BY id DESC"
            Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

            Return dtab(0)("id")
        End Function

        Shared Sub Detail(ByRef visor As DataGridView, ByRef bs As BindingSource, ticket_id As Integer)
            Dim sql(2) As String
            sql(0) =    "SELECT hac_combustible_items.Id as item_id, 
							   hac_combustible_tipo.descripcion,
							   hac_combustible_items.litros, 
							   hac_combustible_items.unidades, 
							   hac_combustible_items.monto"
            sql(1) = "FROM hac_combustible_tipo INNER JOIN hac_combustible_items 
                        ON hac_combustible_tipo.Id = hac_combustible_items.tipo_item_id"
            sql(2) = "WHERE hac_combustible_items.ticket_id=" & ticket_id

            Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            CtrlMan.DataGridViewTools.Load(visor, bs, "", dtab)
        End Sub

		Shared Function SelectTicket(id As Integer) As DataTable
            Dim sql(2) As String
            sql(0) = "SELECT hac_combustible_ticket.id AS ticket_id, hac_combustible_ticket.proveedor_id,
									  persona.razon AS proveedor_razon, persona.cuil AS proveedor_cuil,
									  hac_combustible_responsable.receptor_id,
									  hac_combustible_ticket.responsable_id, hac_combustible_ticket.fecha,
									  hac_combustible_ticket.ticket, hac_combustible_ticket.total,
									  hac_combustible_ticket.user_id"
            sql(1) = "FROM (hac_combustible_responsable 
						   INNER JOIN (persona
						   INNER JOIN (proveedor
						   INNER JOIN hac_combustible_ticket
								   ON proveedor.Id = hac_combustible_ticket.proveedor_id)
								   ON persona.id = proveedor.per_id)
								   ON hac_combustible_responsable.Id = hac_combustible_ticket.responsable_id)
						   INNER JOIN persona AS persona_1 ON hac_combustible_responsable.persona_id = persona_1.id"
            sql(2) = "WHERE hac_combustible_ticket.id=" & id

            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

        End Function

        Shared Function SaveTicket(id As Integer, proveedor_id As Integer, responsable_id As Integer, fecha As Date, ticket As Integer) As Boolean
			'SQL
			If id > 0 Then
				DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE hac_combustible_ticket 
							   SET proveedor_id=" & proveedor_id & ", responsable_id=" & responsable_id & ",
								   fecha=#" & fecha & "#, ticket=" & ticket & ", 
								   user_id=" & My.Settings.UserId & "
							 WHERE hac_combustible_ticket.id=" & id)
			Else
				DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO hac_combustible_ticket(proveedor_id, responsable_id, 
															   fecha, ticket, total, user_id) 
										    			VALUES(" & proveedor_id & ", " & responsable_id & ", #" & Date.Today & "#, 0,
															   0, " & My.Settings.UserId & ")")
			End If
			Return True
		End Function
	End Class

	Public Class Item
		Shared Function FillTypeList(bs As BindingSource, target As ComboBox, displayColumn As String, valueColumn As String) As ComboBox
            Dim sql(0) As String
            sql(0) = "SELECT id as tipo_id, descripcion, por_litro 
										  FROM hac_combustible_tipo"

            bs.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

            CtrlMan.Fill.SetAutoComplete(target, bs, "descripcion", "tipo_id")

			Return target
		End Function

	End Class
End Class
