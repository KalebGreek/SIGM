Imports System.ComponentModel
Public Class ModCombustibleTicket
	Inherits System.Windows.Forms.Form
	Public ticket_id As Integer = 0

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		fecha.Value = Today
		fecha.MaxDate = Today
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
	Public Sub LoadTicket(registro As DataRow)
		ticket_id = registro("ticket_id")
		CtrlMan.LoadAllControls(registro, Me)
		Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_items WHERE ticket_id=" & ticket_id)
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
					'Save ticket
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
		For row = 0 To bs_item_ticket.Count - 1
			total += bs_item_ticket(row)("monto")
		Next
		monto_total.Text = "$ " & Replace(total.ToString, ".", ",")
	End Sub

End Class
