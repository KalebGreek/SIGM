Public Class ModCombustible

	Dim SQLSelectReceptor = "SELECT hac_combustible_receptor.Id as receptor_id, 
							 hac_combustible hac_combustible_receptor.marca+' '+hac_combustible_receptor.dominio+' ('+hac_combustible_receptor.modelo+')' AS descripcion, 
							 persona.razon as responsable, persona.cuil as cuil_responsable"

	Dim SQLTableReceptor = " FROM persona INNER JOIN hac_combustible_receptor 
							ON persona.id = hac_combustible_receptor.responsable_id"

	Dim SQLSelectTicket As String = "SELECT hac_combustible_ticket.Id as ticket_id, fecha, ticket, total, 
									 persona.razon as responsable, persona_1.razon as proveedor"

	Dim SQLTableTicket As String = " FROM persona AS persona_1 
								    INNER JOIN (proveedor
									INNER JOIN ((persona
									INNER JOIN hac_combustible_receptor ON persona.id = hac_combustible_receptor.responsable_id)
									INNER JOIN hac_combustible_ticket ON hac_combustible_receptor.Id = hac_combustible_ticket.receptor_id)
									ON proveedor.Id = hac_combustible_ticket.proveedor_id)
									ON persona_1.id = proveedor.per_id"
	Dim SQLWhere As String

	Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then
			CtrlBusquedaCombustiblePorReceptor1.Button12.Visible = True

			bs_seccion.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM seccion ORDER BY descripcion")
			CtrlMan.Fill.AutoComplete(bs_seccion, seccion, "descripcion", "id")
			bs_categoria.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_categoria 
																		  WHERE vehiculo=" & vehiculo.Checked & " ORDER BY detalle")
			CtrlMan.Fill.AutoComplete(bs_categoria, categoria, "detalle", "id")

		End If
	End Sub

	'###### GUI ##########################################################################################
	Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub

	'###### CARGAR  ##########################################################################################
	Private Sub vehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles vehiculo.CheckedChanged
		bs_categoria.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_categoria 
																	  WHERE vehiculo=" & vehiculo.Checked & " ORDER BY detalle")
		CtrlMan.Fill.AutoComplete(bs_categoria, categoria, "detalle", "id")
	End Sub

	Private Sub bs_categoria_CurrentChanged(sender As Object, e As EventArgs) Handles bs_categoria.CurrentChanged, bs_seccion.CurrentChanged
		If bs_categoria.Position > -1 Or bs_seccion.Position > -1 Then
			SQLWhere = " WHERE"
			If bs_categoria.Position > -1 And bs_seccion.Position > -1 Then
				SQLWhere = " hac_combustible_receptor.seccion_id=" & bs_seccion.Current("id") & " AND hac_combustible_receptor.categoria_id=" & bs_categoria.Current("id")
			ElseIf bs_seccion.Position > -1 Then
				SQLWhere = " hac_combustible_receptor.seccion_id=" & bs_seccion.Current("id")
			ElseIf bs_categoria.Position > -1 Then
				SQLWhere = " hac_combustible_receptor.categoria_id=" & bs_categoria.Current("id")
			End If
			'Rellenar lista de receptores
			Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, SQLSelectReceptor & SQLTableReceptor & SQLWhere)
			bs_receptor.DataSource = dtab
			CtrlMan.Fill.AutoComplete(bs_receptor, receptor, "descripcion", "receptor_id")
		Else
			bs_receptor.DataSource = Nothing
			SQLWhere = ""
		End If
	End Sub

	Private Sub bs_receptor_CurrentChanged(sender As Object, e As EventArgs) Handles bs_receptor.CurrentChanged
		FindTicket()
	End Sub
	Private Sub FindTicket()
		If bs_receptor.Position > -1 Then
			SQLWhere = " WHERE receptor_id=" & bs_receptor.Current("receptor_id")
		Else
			SQLWhere = ""
		End If

		Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, SQLSelectTicket & SQLTableTicket & SQLWhere)
		CtrlMan.LoadDataGridView(historial, bs_historial, dtab)
	End Sub



	'###### VALIDAR ##########################################################################################

	'###### GUARDAR ##########################################################################################
	Private Sub GuardarTickets()

	End Sub

	Private Sub ShowAddItem_Click(sender As Object, e As EventArgs) Handles ShowEditItem.Click

	End Sub

	Private Sub DelItem_Click(sender As Object, e As EventArgs) Handles DelItem.Click
		If bs_historial.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar el ticket seleccionado? Esta operacion no se puede deshacer.", MsgBoxStyle.YesNo, "Eliminar Ticket") Then
				DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM hac_combustible_items WHERE ticket_id=" & bs_historial.Current("ticket_id"))
				DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM hac_combustible_ticket WHERE id=" & bs_historial.Current("ticket_id"))
				bs_historial.RemoveCurrent()
			End If
		End If
	End Sub




End Class