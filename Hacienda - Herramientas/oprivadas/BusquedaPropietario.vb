﻿Imports System.ComponentModel
Public Class BusquedaPropietario
	Private RowIsSelected As Boolean = False
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
	Sub Consultar() Handles ControlBusqueda1.CSearch_Click
		bs_resultado.Filter = ControlBusqueda1.bsCustomFilter
	End Sub

	'-- EVENTOS UNICOS
	Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
		With ControlBusqueda1
			If .vista.SelectedIndex > -1 Then
				.filtro.Items.Clear()
				If .vista.Text = "PROPIETARIO" Then
					Dim sql As String = "SELECT * FROM catastro"
					Dim dtab As New DataTable
					Dim bs_ColumnList As New BindingSource

					dtab = DbMan.read(sql, My.Settings.foxcon)
					bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(dtab)
					.filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
					.filtro.Text = "razon"
				End If
			Else
				.reset_search.PerformClick()
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
		RowIsSelected = (sender Is ControlBusqueda1.selectRow)
		Me.Close()
	End Sub

	Private Sub BusquedaPropietario_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If RowIsSelected = False Then
			bs_resultado.DataSource = Nothing
		End If
	End Sub
End Class