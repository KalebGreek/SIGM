Imports System.ComponentModel
Public Class CtrlModTicket
	Inherits System.Windows.Forms.Form
	Public ticket_id As Integer

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Private Sub CtrlModTicket_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then
			LoadTicket(ticket_id)
		End If
	End Sub

	Private Sub ShowAddItem_Click(sender As Object, e As EventArgs) Handles ShowAddItem.Click
		AddItemPanel1.Visible = AddItemPanel1.Visible.CompareTo(True)
		If AddItemPanel1.Visible Then
			ShowAddItem.BackColor = Color.Silver
		Else
			ShowAddItem.BackColor = Color.DarkGray
		End If
	End Sub

	'LOAD TICKET
	Private Sub LoadTicket(id As Integer)
		Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_ticket WHERE id=" & id)
		CtrlMan.LoadAllControls(dtab(0), Me)
		dtab = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_items WHERE ticket_id=" & id)
		CtrlMan.LoadDataGridView(DetalleTicket, bs_item_ticket, dtab)
	End Sub

	'SAVE TICKET
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

	Private Function SaveTicket() As Boolean
		If MsgBoxResult.Ok = MsgBox("Desea guardar este ticket?", MsgBoxStyle.YesNo, "Guardar Ticket") Then
			If CtrlMan.Validate(Me) Then
				If bs_item_ticket.Count > 0 Then

				Else
					MsgBox("Ingrese un producto para continuar.", MsgBoxStyle.OkOnly)
				End If
			End If
		End If
	End Function

	Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
		If MsgBoxResult.Ok = MsgBox("No se guardaran los cambios, desea continuar?", MsgBoxStyle.YesNo) Then
			Me.Parent.Focus()
			Me.Close()
		End If
	End Sub

	Private Sub bs_item_ticket_ListChanged(sender As Object, e As ListChangedEventArgs) Handles bs_item_ticket.ListChanged
		Dim total As Decimal = 0
		For i = 0 To bs_item_ticket.Count - 1
			bs_item_ticket.Position = i
			total += bs_item_ticket.Current("monto")
		Next
		monto_total.Text = "$ " & Replace(total.ToString, ".", ",")
	End Sub

End Class
