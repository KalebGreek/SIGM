Public Class ModCombustible
	Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then
			FillReceptor()
		End If
	End Sub

    '###### FILTROS  
    Private Sub Filtros_CheckedChanged(sender As Object, e As EventArgs) Handles FiltroCuenta.CheckedChanged,
																				  FiltroCategoria.CheckedChanged,
																				  FiltroReceptor.CheckedChanged

		If Me.Visible Then
			cuenta.Enabled = FiltroCuenta.Checked
			categoria.Enabled = FiltroCategoria.Checked
			vehiculo.Enabled = FiltroCategoria.Checked
			receptor.Enabled = FiltroReceptor.Checked

			Hacienda.FillCuentasHacienda(bs_cuenta, cuenta, 2, "9", "1", "1", "2", "01")

			Combustible.Receptor.FillCategory(bs_categoria, categoria, vehiculo.Checked)


		End If
	End Sub

	Private Sub vehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles vehiculo.CheckedChanged
		If Me.Visible And categoria.Enabled Then
			Combustible.Receptor.FillCategory(bs_categoria, categoria, vehiculo.Checked)
		End If
	End Sub

	Private Sub bs_filtro_PositionChanged(sender As Object, e As EventArgs) Handles bs_categoria.PositionChanged, bs_cuenta.PositionChanged,
																					bs_categoria.CurrentChanged, bs_cuenta.CurrentChanged
		If Me.Visible Then
			FillReceptor()
		End If
	End Sub

	Private Sub bs_receptor_PositionChanged(sender As Object, e As EventArgs) Handles bs_receptor.PositionChanged, bs_receptor.CurrentChanged
		If Me.Visible Then
            CtrlMan.DataGridViewTools.Load(historial, bs_historial, Combustible.Ticket.Find(bs_receptor.Current("receptor_id")))
        End If
    End Sub

    '###### RECEPTORES 
    Private Sub FillReceptor()
        Dim dtab As New DataTable
        If categoria.Enabled Or cuenta.Enabled Then
            If categoria.Enabled And cuenta.Enabled Then
                bs_receptor = Combustible.Receptor.ListAll(bs_cuenta, bs_categoria, 0)
            ElseIf categoria.Enabled Then
                bs_receptor = Combustible.Receptor.ListAll(Nothing, bs_categoria, 0)
            Else
                bs_receptor = Combustible.Receptor.ListAll(bs_cuenta, Nothing, 0)
            End If
        Else
            bs_receptor = Combustible.Receptor.ListAll(Nothing, Nothing, 0)
        End If
        'Rellenar lista de receptores
        CtrlMan.Fill.SetAutoComplete(receptor, bs_receptor, "descripcion", "receptor_id")
    End Sub

    Private Sub NewReceptor_Click(sender As Object, e As EventArgs) Handles NewReceptor.Click
        Using NewRec As New ModCombustibleReceptor
            NewRec.ShowDialog(Me)
            FillReceptor()
            If NewRec.receptor_id.Text > 0 Then
                receptor.SelectedValue = NewRec.receptor_id.Text
            End If
        End Using
    End Sub
    Private Sub EditReceptor_Click(sender As Object, e As EventArgs) Handles EditReceptor.Click
        If bs_receptor.Position > -1 Then
            Using EditRec As New ModCombustibleReceptor
                EditRec.LoadReceptor(bs_receptor.Current("receptor_id"))
                EditRec.ShowDialog(Me)
                FillReceptor()
                If EditRec.receptor_id.Text > 0 Then
                    receptor.SelectedValue = EditRec.receptor_id.Text
                End If
            End Using
        End If
    End Sub
    Private Sub DelReceptor_Click(sender As Object, e As EventArgs) Handles DelReceptor.Click
        If bs_receptor.Position > -1 Then
            If MsgBoxResult.Yes = MsgBox("Desea eliminar este receptor? Se eliminaran todos los tickets relacionados.",
                                         MsgBoxStyle.YesNo) Then
                'Los tickets se eliminan en cascada
                DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM hac_combustible_receptor WHERE id=" & receptor.SelectedValue)
                FillReceptor()
            End If
        End If
    End Sub

    '###### TICKETS ##########################################################################################

    Private Sub bs_historial_PositionChanged(sender As Object, e As EventArgs) Handles bs_historial.PositionChanged
        EditTicket.Enabled = bs_historial.Position > -1
        DelTicket.Enabled = bs_historial.Position > -1
    End Sub

    Private Sub AddTicket_Click(sender As Object, e As EventArgs) Handles AddTicket.Click, EditTicket.Click
        If bs_receptor.Position > -1 Then
            Using AddModTicket As New ModCombustibleTicket()
                If sender Is EditTicket And bs_historial.Position > -1 Then
                    AddModTicket.titulo.Text = "MODIFICAR TICKET"
                    AddModTicket.LoadTicket(bs_historial.Current("ticket_id"))
                    AddModTicket.ShowDialog(Me)
                ElseIf sender Is AddTicket Then
                    AddModTicket.NewTicket(bs_receptor.Current("receptor_id"))
                    AddModTicket.ShowDialog(Me)
                End If
            End Using
        End If
        CtrlMan.DataGridViewTools.Load(historial, bs_historial, Combustible.Ticket.Find(bs_receptor.Current("receptor_id")))
    End Sub

    Private Sub DelTicket_Click(sender As Object, e As EventArgs) Handles DelTicket.Click
        If bs_historial.Position > -1 Then
            If MsgBoxResult.Yes = MsgBox("Desea eliminar el ticket seleccionado? Esta operacion no se puede deshacer.", MsgBoxStyle.YesNo, "Eliminar Ticket") Then
                DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM hac_combustible_ticket WHERE id=" & bs_historial.Current("ticket_id"))
                bs_historial.RemoveCurrent()
                CtrlMan.DataGridViewTools.Load(historial, bs_historial, Combustible.Ticket.Find(bs_receptor.Current("receptor_id")))
            End If
		End If
	End Sub

	'###### VALIDAR ##########################################################################################
End Class