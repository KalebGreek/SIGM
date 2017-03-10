Public Class ModCombustible

	Dim SQLSelectReceptor = "SELECT hac_combustible_receptor.Id as receptor_id, 
							 hac_combustible_receptor.marca+' '+hac_combustible_receptor.dominio+' ('+hac_combustible_receptor.modelo+')' AS descripcion, 
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
			Combustible.FillSeccion(bs_seccion, seccion)
			Combustible.FillCategory(bs_categoria, categoria, vehiculo.Checked)
		End If
	End Sub

	'###### FILTROS  ##########################################################################################
	Private Sub vehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles vehiculo.CheckedChanged
		Combustible.FillCategory(bs_categoria, categoria, vehiculo.Checked)
	End Sub

	Private Sub bs_categoria_PositionChanged(sender As Object, e As EventArgs) Handles bs_categoria.PositionChanged, bs_seccion.PositionChanged
		If bs_categoria.Position > -1 Or bs_seccion.Position > -1 Then
			SQLWhere = " WHERE"
			If bs_categoria.Position > -1 And bs_seccion.Position > -1 Then
				SQLWhere += " hac_combustible_receptor.seccion_id=" & bs_seccion.Current("id") & " AND hac_combustible_receptor.categoria_id=" & bs_categoria.Current("id")
			ElseIf bs_seccion.Position > -1 Then
				SQLWhere += " hac_combustible_receptor.seccion_id=" & bs_seccion.Current("id")
			ElseIf bs_categoria.Position > -1 Then
				SQLWhere += " hac_combustible_receptor.categoria_id=" & bs_categoria.Current("id")
			End If
		Else
			bs_receptor.DataSource = Nothing
			SQLWhere = ""
		End If

		FillReceptor()
	End Sub

	Private Sub bs_receptor_PositionChanged(sender As Object, e As EventArgs) Handles bs_receptor.PositionChanged
		FindTicket()
	End Sub



	'###### RECEPTORES ##########################################################################################
	Private Sub FillReceptor()
		'Rellenar lista de receptores
		Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, SQLSelectReceptor & SQLTableReceptor & SQLWhere)
		bs_receptor.DataSource = dtab
		CtrlMan.Fill.AutoComplete(bs_receptor, receptor, "descripcion", "receptor_id")
	End Sub

	Private Sub NewReceptor_Click(sender As Object, e As EventArgs) Handles NewReceptor.Click
		Dim NewRec As New ModCombustibleReceptor
		NewRec.ShowDialog(Me)
		FillReceptor()
		If NewRec.receptor_id > 0 Then
			receptor.SelectedValue = NewRec.receptor_id
		End If
		NewRec.Dispose()
	End Sub
	Private Sub EditReceptor_Click(sender As Object, e As EventArgs) Handles EditReceptor.Click
		If bs_receptor.Position > -1 Then
			Dim EditRec As New ModCombustibleReceptor
			EditRec.receptor_id = receptor.SelectedValue
			EditRec.ShowDialog(Me)
			FillReceptor()
			If EditRec.receptor_id > 0 Then
				receptor.SelectedValue = EditRec.receptor_id
			End If
			EditRec.Dispose()
		End If
	End Sub
	Private Sub DelReceptor_Click(sender As Object, e As EventArgs) Handles DelReceptor.Click
		If bs_receptor.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar este receptor? Se eliminaran todos los tickets relacionados.",
										 MsgBoxStyle.YesNo) Then
				'Los tickets se eliminan en cascada
				DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM hac_combustible_receptor WHERE id=" & receptor.SelectedValue)
				FillReceptor()
			End If
		End If
	End Sub



	'###### TICKETS ##########################################################################################
	Private Sub FindTicket()
		If bs_receptor.Position > -1 Then
			SQLWhere = " WHERE receptor_id=" & bs_receptor.Current("receptor_id")
		Else
			SQLWhere = ""
		End If

		Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, SQLSelectTicket & SQLTableTicket & SQLWhere)
		CtrlMan.LoadDataGridView(historial, bs_historial, dtab)
	End Sub
	Private Sub bs_historial_PositionChanged(sender As Object, e As EventArgs) Handles bs_historial.PositionChanged
		ShowEditItem.Enabled = bs_historial.Position > -1
		DelItem.Enabled = bs_historial.Position > -1
	End Sub

	Private Sub AddItem_Click(sender As Object, e As EventArgs) Handles AddItem.Click
		If bs_receptor.Position > -1 Then
			Dim NewTicket As New ModCombustibleTicket
			NewTicket.Show()
		End If
	End Sub

	Private Sub ShowEditItem_Click(sender As Object, e As EventArgs) Handles ShowEditItem.Click
		With bs_historial
			If bs_receptor.Position > -1 And .Position > -1 Then
				Dim EditTicket As New ModCombustibleTicket
				EditTicket.LoadTicket(.DataSource(.Position))
				EditTicket.Show()
			End If
		End With
	End Sub

	'###### VALIDAR ##########################################################################################

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