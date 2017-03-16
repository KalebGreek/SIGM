Imports System.ComponentModel
Public Class ModCombustibleTicket
	Inherits System.Windows.Forms.Form
	Public ticket_id As Integer = 0
	Public proveedor_id As Integer = 0

	Public Sub New(registro_receptor As BindingSource)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		fecha.Value = Today
		fecha.MaxDate = Today

		bs_receptor = registro_receptor
		'Cargar items de ejemplo
		bs_tipo_item.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT id as tipo_id, descripcion, por_litro 
																		FROM hac_combustible_tipo")

		CtrlMan.Fill.AutoComplete(bs_tipo_item, TipoItem, "descripcion", "tipo_id")
		'Cargar receptor
		CtrlMan.Fill.AutoComplete(bs_receptor, receptor, "descripcion", "receptor_id")
		'Cargar responsable
		Combustible.FillResponsable(bs_responsable, responsable, bs_receptor.Current("receptor_id"))
	End Sub

	Private Sub ModCombustibleTicket_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then

		End If
	End Sub

	Private Sub SelectProveedor_Click(sender As Object, e As EventArgs) Handles SelectProveedor.Click
		Dim SelProveedor As New ControlBusquedaPersona
		SelProveedor.Vista.Text = "PROVEEDOR"
		SelProveedor.filtro.Text = "RAZON SOCIAL"
		SelProveedor.ShowDialog(Me)
		If SelProveedor.bs_resultado.Position > -1 Then
			proveedor.Text = SelProveedor.bs_resultado.Current("razon") & " | " & SelProveedor.bs_resultado.Current("cuil")
			proveedor_id = SelProveedor.bs_resultado.Current("proveedor_id")
		End If
	End Sub

	'GUI
	Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
		If MsgBoxResult.Yes = MsgBox("No se guardaran los cambios, desea continuar?", MsgBoxStyle.YesNo) Then
			Me.Close()
		End If
	End Sub

	'TICKET
	Public Sub NewTicket()
		DbMan.edit(My.Settings.DefaultCon, "INSERT INTO hac_combustible_ticket(proveedor_id, responsable_id, 
																			   fecha, ticket, total, user_id) 
																		VALUES(" & bs_receptor.Current("receptor_id") & ", 
																			   " & bs_responsable.Current("persona_id") & ",
																			   0, #" & fecha.Value & "#, 0, 0," & My.Settings.UserId & ")")

		LoadTicket(Combustible.FindTicket(bs_receptor, True)(0)("ticket_id"))
	End Sub

	Public Sub LoadTicket(id As Integer)
		If id > 0 Then
			Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon,
											  "SELECT hac_combustible_ticket.id,
													  hac_combustible_ticket.proveedor_id, persona.razon as proveedor,
													  hac_combustible_ticket.responsable_id, hac_combustible_ticket.fecha, 
													  hac_combustible_ticket.ticket, hac_combustible_ticket.total, 
													  hac_combustible_ticket.user_id
												 FROM persona 
										   INNER JOIN (proveedor 
										   INNER JOIN hac_combustible_ticket 
												   ON proveedor.Id = hac_combustible_ticket.proveedor_id) 
												   ON persona.id = proveedor.per_id
												WHERE hac_combustible_ticket.id=" & id)

			'Cargar ticket
			If dtab.Rows.Count > 0 Then
				ticket_id = dtab(0)("id")
				proveedor_id = dtab(0)("proveedor_id")
				CtrlMan.LoadAllControls(dtab(0), Me)
				Combustible.TicketDetail(DetalleTicket, bs_item_ticket, ticket_id)
			End If
		End If
	End Sub

	'SAVE TICKET
	Private Function SaveTicket() As Boolean
		If MsgBoxResult.Yes = MsgBox("Desea guardar este ticket?", MsgBoxStyle.YesNo, "Guardar Ticket") Then
			If CtrlMan.Validate(Me) Then
				If bs_item_ticket.Count > 0 Then
					'Save ticket
				Else
					MsgBox("Ingrese un producto para continuar.", MsgBoxStyle.OkOnly)
				End If
			End If
		End If
	End Function

	Private Sub SaveAddTicket_Click(sender As Object, e As EventArgs) Handles SaveAdd.Click
		If SaveTicket() Then
			Me.SuspendLayout()
			Me.Refresh()
			Me.PerformLayout()
		End If
	End Sub

	Private Sub SaveTicket_Click(sender As Object, e As EventArgs) Handles Save.Click
		If SaveTicket() Then
			Me.Parent.Focus()
			Me.Close()
		End If
	End Sub

	'ITEMS
	Private Sub bs_item_ticket_ListChanged(sender As Object, e As ListChangedEventArgs) Handles bs_item_ticket.ListChanged
		Dim total As Decimal = 0
		If bs_item_ticket.Count > 0 Then
			For row = 0 To bs_item_ticket.Count - 1
				total += bs_item_ticket(row)("monto")
			Next
		End If

		DbMan.edit(My.Settings.DefaultCon, "UPDATE hac_combustible_ticket 
											   SET total=" & Replace(total, ",", "."))

		monto_total.Text = Replace(FormatCurrency(total, 2), ".", ",")
	End Sub

	Private Sub bs_tipo_item_CurrentChanged(sender As Object, e As EventArgs) Handles bs_tipo_item.CurrentChanged,
																					  bs_tipo_item.PositionChanged
		If bs_tipo_item.Position > -1 Then
			If bs_tipo_item.Current("por_litro") Then
				et_litros_unidades.Text = "Litros"
			Else
				et_litros_unidades.Text = "Unidades"
			End If
		End If
	End Sub

	Private Sub NewItemType_Click(sender As Object, e As EventArgs) Handles NewItemType.Click
		Dim nuevo_tipo As String = ""
		Dim por_litro As Boolean = True
		nuevo_tipo = InputBox("Ingrese nombre de nuevo item.")
		If nuevo_tipo <> Nothing Then
			nuevo_tipo = Trim(nuevo_tipo)
			If Len(nuevo_tipo) > 2 Then
				por_litro = (MsgBoxResult.Yes = MsgBox("Precio por litro?", MsgBoxStyle.YesNo))
				DbMan.edit(My.Settings.DefaultCon, "INSERT INTO hac_combustible_tipo(descripcion, por_litro) 
														 VALUES(" & nuevo_tipo & ", " & por_litro & ")")
			End If
		End If
	End Sub

	Private Sub DelItemType_Click(sender As Object, e As EventArgs) Handles DelItemType.Click
		If bs_tipo_item.Position > -1 Then
			If TipoItem.Text <> "OTRO POR LITRO" And TipoItem.Text <> "OTRO" Then
				If MsgBoxResult.Yes = MsgBox("Desea eliminar este item? Los items incluidos se moveran a la
											  categoria 'OTRO POR LITRO' u 'OTRO', segun su tipo.",
											  MsgBoxStyle.YesNo) Then

					If bs_tipo_item.Current("por_litro") Then
						DbMan.edit(My.Settings.DefaultCon, "UPDATE hac_combustible_items SET tipo_combustible_id=1 
															WHERE tipo_combustible=" & TipoItem.SelectedValue)
					Else
						DbMan.edit(My.Settings.DefaultCon, "UPDATE hac_combustible_items SET tipo_combustible_id=6 
															WHERE tipo_combustible=" & TipoItem.SelectedValue)
					End If

					DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM hac_combustible_tipo WHERE id=" & TipoItem.SelectedValue)

				End If
			End If
		End If
	End Sub

	Private Sub AddNewItem_Click(sender As Object, e As EventArgs) Handles AddNewItem.Click
		Dim litros As Integer = 0
		Dim unidades As Integer = 0
		Dim unitario As String = Replace(MontoItem.Value,",",".")

		If bs_tipo_item.Position > -1 And MontoItem.Value > 0 And LitrosItem.Value > 0 Then
			If bs_tipo_item.Current("por_litro") Then
				litros = LitrosItem.Value
			Else
				unidades = LitrosItem.Value
			End If

			DbMan.edit(My.Settings.DefaultCon,
					   "INSERT INTO hac_combustible_items(ticket_id, tipo_item_id, litros, unidades, monto, user_id)
												   VALUES(" & ticket_id & "," & bs_tipo_item.Current("tipo_id") & ",
														  " & litros & ", " & unidades & ", " & unitario & ",
														  " & My.Settings.UserId & ")")

			MontoItem.Value = 0
			LitrosItem.Value = 0
		End If
		Combustible.TicketDetail(DetalleTicket, bs_item_ticket, ticket_id)
	End Sub

	Private Sub DelItem_Click(sender As Object, e As EventArgs) Handles DelItem.Click
		If bs_item_ticket.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar este item?", MsgBoxStyle.YesNo, "Eliminar Item") Then
				DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM hac_combustible_items WHERE id=" & bs_item_ticket.Current("item_id"))
				Combustible.TicketDetail(DetalleTicket, bs_item_ticket, ticket_id)
			End If
		End If
	End Sub

End Class
