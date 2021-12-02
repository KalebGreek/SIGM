Class Combustible
    Public Class Receptor
        Shared Sub FillCategory(ByRef bs As BindingSource, ByRef target As ComboBox, ByRef vehiculo As Boolean)
            bs.DataSource = DbMan.ReadDB("SELECT * FROM hac_combustible_categoria_receptor 
										   WHERE vehiculo=" & vehiculo & " ORDER BY detalle", My.Settings.CurrentDB)
            CtrlMan.Fill.SetAutoComplete(target, bs, "detalle", "id")
        End Sub
        Shared Function ListAll(BSCuenta As BindingSource, BSCategoria As BindingSource, id As Integer) As BindingSource
            Dim sqlSelect As String
            Dim cuenta As DataRowView = BSCuenta.Current
            Dim categoria As DataRowView = BSCategoria.Current
            sqlSelect = "SELECT Id as receptor_id, marca+' | '+dominio+' |'+STR(modelo) AS descripcion"
            sqlSelect &= "FROM hac_combustible_receptor"

            If cuenta Is Nothing And categoria Is Nothing Then
                If id > 0 Then
                    sqlSelect &= " WHERE hac_combustible_receptor.id=" & id
                End If
            ElseIf cuenta Is Nothing = False And categoria Is Nothing Then
                sqlSelect &= " WHERE cuenta=" & cuenta("orden").ToString
            ElseIf cuenta Is Nothing And categoria Is Nothing = False Then
                sqlSelect &= " WHERE categoria_id=" & categoria("id").ToString
            Else
                sqlSelect &= " WHERE cuenta=" & cuenta("orden").ToString & " AND categoria_id=" & categoria("id").ToString
            End If

            Dim bs As New BindingSource _
                With {.DataSource = DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)}

            Return bs
        End Function
        Shared Function Seleccionar(id As Integer) As DataTable
            Dim sqlSelect As String
            sqlSelect = "SELECT hac_combustible_receptor.id as receptor_id, cuenta, categoria_id,
									  marca, mercosur, dominio, modelo, alta, baja, observaciones,
									  detalle, vehiculo"
            sqlSelect &= " FROM hac_combustible_receptor INNER JOIN hac_combustible_categoria_receptor"
            sqlSelect &= " ON hac_combustible_receptor.categoria_id=hac_combustible_categoria_receptor.id"
            sqlSelect &= " WHERE hac_combustible_receptor.id=" & id

            Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
        End Function
    End Class

    Public Class Responsable
        Shared Sub Fill(ByRef bs As BindingSource, ByRef target As ComboBox, receptor_id As Integer)
            Dim sqlSelect As String
            sqlSelect = "SELECT hac_combustible_responsable.id as responsable_id, razon, cuil, persona_id"
            sqlSelect &= " FROM hac_combustible_responsable INNER JOIN persona ON hac_combustible_responsable.persona_id=persona.id"
            sqlSelect &= " WHERE receptor_id=" & receptor_id
            sqlSelect &= " ORDER BY persona.razon"

            bs.DataSource = DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)

            CtrlMan.Fill.SetAutoComplete(target, bs, "razon", "responsable_id")
        End Sub
    End Class

    Public Class Ticket
        Shared Function Find(Optional receptor_id As Integer = -1, Optional last As Boolean = False) As DataTable
            Dim sqlSelect As String

            sqlSelect = "SELECT hac_combustible_ticket.id AS ticket_id, hac_combustible_ticket.fecha,
										 hac_combustible_ticket.ticket, hac_combustible_ticket.total, persona_1.razon AS proveedor,
										 persona.razon AS responsable, hac_combustible_ticket.user_id"

            sqlSelect &= " FROM (proveedor INNER JOIN (persona 
										               INNER JOIN (hac_combustible_receptor 
										                           INNER JOIN (hac_combustible_responsable 
										                                       INNER JOIN hac_combustible_ticket 
												                                       ON hac_combustible_responsable.Id = hac_combustible_ticket.responsable_id) 
																           ON hac_combustible_receptor.Id = hac_combustible_responsable.receptor_id) 
															   ON persona.id = hac_combustible_responsable.persona_id) 
												   ON proveedor.Id = hac_combustible_ticket.proveedor_id) 
										   INNER JOIN persona AS persona_1 ON proveedor.per_id = persona_1.id"


            If receptor_id > -1 Then
                sqlSelect &= " WHERE hac_combustible_receptor.id=" & receptor_id
            End If

            If last Then
                sqlSelect &= " ORDER BY hac_combustible_ticket.id ASC"
            End If

            Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
        End Function
        Shared Function ReturnLastTicketID() As Integer
            Return DbMan.ReadDB("SELECT id FROM hac_combustible_ticket ORDER BY id DESC", My.Settings.CurrentDB).Rows(0)("id")
        End Function

        Shared Sub Detail(ByRef visor As DataGridView, ByRef bs As BindingSource, ticket_id As Integer)
            Dim sqlSelect = "SELECT hac_combustible_items.Id as item_id, 
							        hac_combustible_tipo.descripcion,
							        hac_combustible_items.litros, 
							        hac_combustible_items.unidades, 
							        hac_combustible_items.monto"
            sqlSelect = " FROM hac_combustible_tipo INNER JOIN hac_combustible_items 
                        ON hac_combustible_tipo.Id = hac_combustible_items.tipo_item_id"
            sqlSelect = " WHERE hac_combustible_items.ticket_id=" & ticket_id

            Dim dtab As DataTable = DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
            CtrlMan.DataGridViewTools.Load(visor, bs, dtab)
        End Sub

        Shared Function SelectTicket(id As Integer) As DataTable
            Dim sqlSelect As String
            sqlSelect = "SELECT hac_combustible_ticket.id AS ticket_id, hac_combustible_ticket.proveedor_id,
									  persona.razon AS proveedor_razon, persona.cuil AS proveedor_cuil,
									  hac_combustible_responsable.receptor_id,
									  hac_combustible_ticket.responsable_id, hac_combustible_ticket.fecha,
									  hac_combustible_ticket.ticket, hac_combustible_ticket.total,
									  hac_combustible_ticket.user_id"
            sqlSelect &= " FROM (hac_combustible_responsable 
						   INNER JOIN (persona
						   INNER JOIN (proveedor
						   INNER JOIN hac_combustible_ticket
								   ON proveedor.Id = hac_combustible_ticket.proveedor_id)
								   ON persona.id = proveedor.per_id)
								   ON hac_combustible_responsable.Id = hac_combustible_ticket.responsable_id)
						   INNER JOIN persona AS persona_1 ON hac_combustible_responsable.persona_id = persona_1.id"
            sqlSelect &= " WHERE hac_combustible_ticket.id=" & id

            Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)

        End Function

        Shared Function SaveTicket(id As Integer, proveedor_id As Integer, responsable_id As Integer, fecha As Date, ticket As Integer) As Boolean
            Dim sqlInsert As String
            If id > 0 Then
                sqlInsert = "UPDATE hac_combustible_ticket 
							    SET proveedor_id=" & proveedor_id & ", responsable_id=" & responsable_id & ",
								    fecha=#" & fecha & "#, ticket=" & ticket & ", 
								    user_id=" & My.Settings.UserId & "
							  WHERE hac_combustible_ticket.id=" & id
            Else
                sqlInsert = "INSERT INTO hac_combustible_ticket(proveedor_id, responsable_id, fecha, ticket, total, user_id) 
							      VALUES(" & proveedor_id & ", " & responsable_id & ", #" & Date.Today & "#, 0, 0, " & My.Settings.UserId & ")"
            End If
            DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)
            Return True
        End Function
    End Class

    Public Class Item
        Shared Function FillTypeList(bs As BindingSource, target As ComboBox, displayColumn As String, valueColumn As String) As ComboBox
            bs.DataSource = DbMan.ReadDB("SELECT id as tipo_id, descripcion, por_litro 
			             				    FROM hac_combustible_tipo", My.Settings.CurrentDB)

            CtrlMan.Fill.SetAutoComplete(target, bs, displayColumn, valueColumn)

            Return target
        End Function

    End Class
End Class
