Imports System.ComponentModel
Public Class BusquedaPropietario
	Private SelectedRow As Boolean = False
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		'Setting up views
		ControlBusqueda1.vista.Items.AddRange(New Object() {"PROPIETARIO"})
		ControlBusqueda1.selectRow.Visible = True
		ControlBusqueda1.cancel.Visible = True
	End Sub
	'-- RUTINAS
	Public Sub Consultar(vista As String, filtro As String, keyword As String) Handles ControlBusqueda1.CSearch_Click
		With ControlBusqueda1
			If Len(filtro) > 0 Then

				Dim dtab As New DataTable
				Dim sql As String = "SELECT * FROM catastro"

				keyword = Trim(UCase(keyword))
				If Len(keyword) > 0 Then
					If filtro = "RAZON SOCIAL" Then
						sql += " WHERE razon LIKE '%" & keyword & "%' ORDER BY razon"
					ElseIf filtro = "CODIGO" Then
						sql += " WHERE codigo=" & Val(keyword)
					ElseIf filtro = "UBICACION" Then
						sql += " WHERE ubicacion LIKE '%" & keyword & "%' ORDER BY razon"
					ElseIf filtro = "CATASTRO" Then
						sql += " WHERE catastro LIKE '" & keyword & "%' ORDER BY catastro"
					End If
				End If
				dtab = DbMan.read(sql, My.Settings.foxcon)
				CtrlMan.LoadDataGridView(resultado, bs_resultado, "", dtab)
			End If
		End With
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
		With ControlBusqueda1
			If .vista.SelectedIndex > -1 Then
				.filtro.Items.Clear()
				If .vista.Text = "PROPIETARIO" Then

					.filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CODIGO", "UBICACION", "CATASTRO"})
					.filtro.Text = "RAZON SOCIAL"

				End If
			Else
				ControlBusqueda1.reset.PerformClick()
			End If
		End With
	End Sub
	Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles ControlBusqueda1.CKeyword_KeyUp, resultado.KeyUp
		If e.KeyValue = Keys.Enter And sender Is ControlBusqueda1.keyword Then
			ControlBusqueda1.search.PerformClick()
		ElseIf sender Is resultado Then
			If e.KeyValue = Keys.F2 Then

			ElseIf e.KeyValue = Keys.Delete Then

			End If
		End If
	End Sub

	Private Sub SelectResult(sender As Object) Handles ControlBusqueda1.CSelect, ControlBusqueda1.CCancel
		SelectedRow = (sender Is ControlBusqueda1.selectRow)
		Me.Close()
	End Sub

	Private Sub BusquedaPropietario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If SelectedRow = False Then
			bs_resultado.DataSource = Nothing
		End If
	End Sub
End Class