Public Class ConsultaMovimientos
	Private SQLSelect, SQLTable, SQLCriteria, SQLGrouping, SQLOrder As String

	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        bs_cuenta.DataSource = RellenarCuentas(Ingresos.Checked)
        SeleccionCuenta.DataSource = bs_cuenta
		SeleccionCuenta.DisplayMember = "nombre"
		inicio.Value = "01/01/" & Year(Today)
	End Sub
    '###### GUI #############################################################################################

    '###### FIN GUI #############################################################################################

    '### EVENTOS  
    Private Sub Ingresos_CheckedChanged(sender As Object, e As EventArgs) Handles Ingresos.CheckedChanged
		visor.DataSource = Nothing
		bs_consulta.DataSource = Nothing
		bs_cuenta.DataSource = RellenarCuentas(Ingresos.Checked)
		SeleccionCuenta.DataSource = bs_cuenta
		SeleccionCuenta.DisplayMember = "nombre"
		bs_cuenta.Position = 1
	End Sub
	Private Sub SeleccionCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SeleccionCuenta.SelectedIndexChanged
		progreso.Value = 0
		visor.DataSource = Nothing
		bs_consulta.DataSource = Nothing
		If SeleccionCuenta.SelectedIndex > -1 Then
			visor = CtrlMan.LoadDataGridView(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
																						  fecha.Checked, inicio.Value, final.Value))
			SumarTotales(Ingresos.Checked)
		End If

	End Sub

	Private Sub ActivarFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles ActivarFiltro.CheckedChanged
		GrupoFiltro.Visible = ActivarFiltro.Checked
		If SeleccionCuenta.SelectedIndex > -1 Then
			visor = CtrlMan.LoadDataGridView(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
																					 	 fecha.Checked, inicio.Value, final.Value))
			SumarTotales(Ingresos.Checked)
		End If
	End Sub
	Private Sub fecha_CheckedChanged(sender As Object, e As EventArgs) Handles fecha.CheckedChanged
		inicio.Enabled = fecha.Checked
		final.Enabled = fecha.Checked
		Keyword.Enabled = concepto.Checked
		If SeleccionCuenta.SelectedIndex > -1 Then
			visor = CtrlMan.LoadDataGridView(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
																		fecha.Checked, inicio.Value, final.Value))
			SumarTotales(Ingresos.Checked)
		End If
	End Sub
	Private Sub Keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles Keyword.KeyUp
		If SeleccionCuenta.SelectedIndex > -1 Then
			visor = CtrlMan.LoadDataGridView(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
																							fecha.Checked, inicio.Value, final.Value))



			SumarTotales(Ingresos.Checked)
		End If
	End Sub
	Private Sub inicio_ValueChanged(sender As Object, e As EventArgs) Handles inicio.ValueChanged
		inicio.MaxDate = final.Value
		final.MinDate = inicio.Value
		If SeleccionCuenta.SelectedIndex > -1 Then
			visor = CtrlMan.LoadDataGridView(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
																		fecha.Checked, inicio.Value, final.Value))
			SumarTotales(Ingresos.Checked)
		End If
	End Sub

	'### RUTINAS
	Private Function RellenarCuentas(ingresos As Boolean) As DataTable
		Dim dtab As New DataTable
		SQLSelect = "SELECT orden, IIF(sumado=1,'* ','- ') + nombre AS nombre"
		SQLTable = " FROM hacienda"

		If ingresos Then
			SQLCriteria = "  WHERE orden<900000000000"
		Else
			SQLCriteria = "  WHERE orden>899999999999"
		End If

		SQLOrder = " ORDER BY orden"

		Return DbMan.read(Nothing, My.Settings.foxcon, SQLSelect, SQLTable, SQLCriteria,,, SQLOrder)
	End Function
	Private Function ConsultarMovimientos(ByVal cuenta As Double, ByVal keyword As String,
                                          Filtrado As Boolean, FiltroFecha As Boolean,
                                          ByVal FechaInicio As Date, ByVal FechaFinal As Date) As DataTable
		SQLSelect = "SELECT movimis.orden, movimis.fecha, movimis.documento, movimis.pagado, movimis.detalle, movimis.emite"
		SQLTable = " FROM movimis INNER JOIN hacienda ON movimis.orden=hacienda.orden"
		SQLCriteria = " WHERE movimis.orden=" & cuenta
		If Filtrado Then
            If FiltroFecha Then
				SQLCriteria += " AND movimis.fecha => {" & FechaInicio.ToString("MM/dd/yyyy") & "}
                                 AND movimis.fecha <= {" & FechaFinal.ToString("MM/dd/yyyy") & "}"
			ElseIf Len(keyword) > 2 Then
				SQLCriteria += " AND movimis.detalle LIKE '%" & keyword & "%'"
			End If
        End If

		Return DbMan.read(Nothing, My.Settings.foxcon, SQLSelect, SQLTable, SQLCriteria)
	End Function
    Private Sub SumarTotales(ingreso As Boolean)
		Dim dtab As DataTable = DbMan.read(Nothing, My.Settings.foxcon, "SELECT SUM(movimis.pagado) as total_pagado, movimis.orden, hacienda.autorizado" &
											SQLTable & SQLCriteria & " GROUP BY movimis.orden, hacienda.autorizado")


		info.Text = " - "
		info2.Text = " - "
		If dtab Is Nothing = False Then
			If dtab.Rows.Count > 0 Then
				info.Text = "AUTORIZADO: " & FormatCurrency(dtab(0)("autorizado"), 2)
				If ingreso Then
					info2.Text = "INGRESADO: " & FormatCurrency(dtab(0)("total_pagado"), 2)
				Else
					info2.Text = "GASTADO: " & FormatCurrency(dtab(0)("total_pagado"), 2)
				End If
			End If
		End If



	End Sub

End Class

