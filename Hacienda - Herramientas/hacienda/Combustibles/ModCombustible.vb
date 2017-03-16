Public Class ModCombustible

	Dim SQLSelectReceptor As String = "SELECT Id as receptor_id,
									   marca+' | '+dominio+' |'+STR(modelo) AS descripcion"

	Dim SQLTableReceptor As String = " FROM hac_combustible_receptor"

	Dim SQLWhere As String = ""


	Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then
			FillReceptor()
		End If
	End Sub

	'###### FILTROS  ##########################################################################################
	Private Sub FiltroCuenta_CheckedChanged(sender As Object, e As EventArgs) Handles FiltroCuenta.CheckedChanged,
																					  FiltroCategoria.CheckedChanged,
																					  FiltroReceptor.CheckedChanged

		If Me.Visible Then
			cuenta.Enabled = FiltroCuenta.Checked
			categoria.Enabled = FiltroCategoria.Checked
			vehiculo.Enabled = FiltroCategoria.Checked
			receptor.Enabled = FiltroReceptor.Checked

			Hacienda.FillCuenta(bs_cuenta, cuenta)

			Combustible.FillCategory(bs_categoria, categoria, vehiculo.Checked)
		End If
	End Sub

	Private Sub vehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles vehiculo.CheckedChanged
		If Me.Visible And categoria.Enabled Then
			Combustible.FillCategory(bs_categoria, categoria, vehiculo.Checked)
		End If
	End Sub

	Private Sub bs_categoria_PositionChanged(sender As Object, e As EventArgs) Handles bs_categoria.PositionChanged, bs_cuenta.PositionChanged,
																					   bs_categoria.CurrentChanged, bs_cuenta.CurrentChanged
		If Me.Visible Then
			FillReceptor()
		End If
	End Sub

	Private Sub bs_receptor_PositionChanged(sender As Object, e As EventArgs) Handles bs_receptor.PositionChanged, bs_receptor.CurrentChanged
		If Me.Visible Then
			CtrlMan.LoadDataGridView(historial, bs_historial, Combustible.FindTicket(bs_receptor))
		End If
	End Sub

	'###### RECEPTORES ##########################################################################################
	Private Sub FillReceptor()
		If categoria.Enabled Or cuenta.Enabled Then
			If bs_categoria.Position > -1 And bs_cuenta.Position > -1 And categoria.Enabled And cuenta.Enabled Then
				SQLWhere += "WHERE cuenta_id=" & bs_cuenta.Current("id") & " AND categoria_id=" & bs_categoria.Current("id")
			ElseIf bs_cuenta.Position > -1 And cuenta.Enabled Then
				SQLWhere += "WHERE cuenta_id=" & bs_cuenta.Current("id")
			ElseIf bs_categoria.Position > -1 And categoria.Enabled Then
				SQLWhere += "WHERE categoria_id=" & bs_categoria.Current("id")
			End If
		Else
			SQLWhere = ""
		End If
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
			EditRec.LoadReceptor(bs_receptor.Current("receptor_id"))
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

	Private Sub bs_historial_PositionChanged(sender As Object, e As EventArgs) Handles bs_historial.PositionChanged
		EditTicket.Enabled = bs_historial.Position > -1
		DelTicket.Enabled = bs_historial.Position > -1
	End Sub

	Private Sub AddTicket_Click(sender As Object, e As EventArgs) Handles AddTicket.Click
		If bs_receptor.Position > -1 Then
			Dim EditTicket As New ModCombustibleTicket(bs_receptor)
			EditTicket.NewTicket()
			EditTicket.ShowDialog(Me)
			CtrlMan.LoadDataGridView(historial, bs_historial, Combustible.FindTicket(bs_receptor))
		End If
	End Sub


	Private Sub EditTicket_Click(sender As Object, e As EventArgs) Handles EditTicket.Click
		With bs_historial
			If bs_receptor.Position > -1 And .Position > -1 Then
				Dim EditTicket As New ModCombustibleTicket(bs_receptor)
				EditTicket.LoadTicket(bs_historial.Current("ticket_id"))
				EditTicket.ShowDialog(Me)
				CtrlMan.LoadDataGridView(historial, bs_historial, Combustible.FindTicket(bs_receptor))
			End If
		End With
	End Sub

	Private Sub DelTicket_Click(sender As Object, e As EventArgs) Handles DelTicket.Click
		If bs_historial.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar el ticket seleccionado? Esta operacion no se puede deshacer.", MsgBoxStyle.YesNo, "Eliminar Ticket") Then
				DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM hac_combustible_ticket WHERE id=" & bs_historial.Current("ticket_id"))
				bs_historial.RemoveCurrent()
				CtrlMan.LoadDataGridView(historial, bs_historial, Combustible.FindTicket(bs_receptor))
			End If
		End If
	End Sub

	'###### VALIDAR ##########################################################################################
End Class