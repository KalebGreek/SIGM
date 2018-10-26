﻿Public Class ConsultasEspeciales
	Private sqlSelect, sqlFrom, sqlWhere, sqlGroupBy, sqlHaving, sqlOrderBy As String

	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        yearValue.Value = Today.Year
		Connection.Text = My.Settings.foxcon

	End Sub

	'RUTINAS

	Private Sub ExecuteQuery(ByVal reset As Boolean)
		If Connection.Text <> "Seleccione una base de datos antes de continuar." Then
			Dim dtab As New DataTable
			dtab = DbMan.read(sqlSelect, Connection.Text, sqlFrom, sqlWhere, sqlGroupBy, sqlHaving, sqlOrderBy)

			If reset Then
				'Only needed the first time we access a new query
				EnableFilter.Checked = False

				ColumnList_bs.DataSource = Nothing


				ColumnList_bs.DataSource = CtrlMan.Fill.GetColumnList(dtab)

				CtrlMan.Fill.SetAutoComplete(ColumnList, ColumnList_bs, "ColumnName", "DataType")

				PanelFiltros.Visible = dtab.Columns.Count > 0
			End If

			CustomQuery.Text = sqlSelect & " " & sqlFrom & " " & sqlWhere & " " & sqlGroupBy & " " & sqlHaving & " " & sqlOrderBy

			'Load datagridview
			CtrlMan.LoadDataGridView(DataView, query_bs, "", dtab)
		Else
			CustomQuery.Text = ""
		End If
	End Sub

	Private Function FilterQuery(sender As Object, data_bs As BindingSource, FilterColumn As ComboBox, reset As Boolean)
		Dim bsCustomFilter As String = ""
		Dim sqlCustomFilter As String = ""
		If PanelFiltros.Visible And EnableFilter.Checked Then
			If reset Then
				If FilterColumn.SelectedIndex > -1 Then

					If FilterColumn.SelectedValue = "System.String" Then
						keyword.Text = ""
						StringFilterPanel.Visible = True
					Else
						'Return range of values to use for the specified column
						Dim sorted_bs As New BindingSource
						sorted_bs = data_bs
						sorted_bs.Sort = FilterColumn.Text & " ASC"

						'dtab_min = DbMan.read("SELECT MIN(" & FilterColumn.Current("colName") & ") AS " & FilterColumn.Current("colName"),
						'Connection.Text, sqlFrom, sqlWhere, sqlGroupBy, sqlHaving)

						'dtab_max = DbMan.read("SELECT MAX(" & FilterColumn.Current("colName") & ") AS " & FilterColumn.Current("colName"),
						'Connection.Text, sqlFrom, sqlWhere, sqlGroupBy, sqlHaving)

						If FilterColumn.SelectedValue = "System.Decimal" Or FilterColumn.SelectedValue = "System.Integer" Then
							Dim min, max As New Decimal

							If FilterColumn.SelectedValue = "System.Decimal" Then
								minNumValue.DecimalPlaces = 2
								maxNumValue.DecimalPlaces = 2
							Else
								minNumValue.DecimalPlaces = 0
								maxNumValue.DecimalPlaces = 0
							End If

							sorted_bs.MoveFirst()
							min = sorted_bs.Current(FilterColumn.Text)
							sorted_bs.MoveLast()
							max = sorted_bs.Current(FilterColumn.Text)

							minNumValue.Minimum = min
							minNumValue.Value = min
							minNumValue.Maximum = max

							maxNumValue.Minimum = min
							maxNumValue.Maximum = max
							maxNumValue.Value = max

							IntFilterPanel.Visible = True

						ElseIf FilterColumn.SelectedValue = "System.Date" Then
							Dim minD As Date = CDate("1/1/1899")
							Dim maxD As Date = Today

							sorted_bs.MoveFirst()
							If sorted_bs.Current(FilterColumn.Text) Is DBNull.Value = False Then
								minD = sorted_bs.Current(FilterColumn.Text)
							End If
							sorted_bs.MoveLast()
							If sorted_bs.Current(FilterColumn.Text) Is DBNull.Value = False Then
								maxD = sorted_bs.Current(FilterColumn.Text)
							End If

							minDateValue.MinDate = minD
							minDateValue.Value = minD
							minDateValue.MaxDate = maxD

							maxDateValue.MinDate = minD
							maxDateValue.MaxDate = maxD

							If maxD > Today Then
								maxDateValue.Value = Today
							Else
								maxDateValue.Value = maxD
							End If

							yearValue.Minimum = Year(minD)
							yearValue.Maximum = Year(maxD)

							If Year(maxD) > Year(Today) Then
								yearValue.Value = Year(Today)
							Else
								yearValue.Value = Year(maxD)
							End If

							DateFilterPanel.Visible = True
						End If
					End If
				End If

			Else
				'Filter query
				'Change this from SQL to BindingSource.Filter
				If FilterColumn.SelectedValue = "System.String" Then 'String
					If Len(Trim(keyword.Text)) > 2 Then
						bsCustomFilter = FilterColumn.Text & " Like '%" & keyword.Text & "%'"
						'sqlCustomFilter = FilterColumn.Text & " Like '%" & keyword.Text & "%'"
					End If
				ElseIf FilterColumn.SelectedValue = "System.Decimal" Or FilterColumn.SelectedValue = "System.Integer" Then 'Dec or Int
					bsCustomFilter = IntDecFilter(FilterColumn.Text, minNumValue.Value, maxNumValue.Value, NumFilterSelect.Text)
					'sqlCustomFilter = IntDecFilter(FilterColumn.Text, minNumValue.Value, maxNumValue.Value, NumFilterSelect.Text)
				ElseIf FilterColumn.SelectedValue = "System.Date" Then 'Date
					bsCustomFilter = DateFilter(FilterColumn.Text, minDateValue.Value, maxDateValue.Value, PorAño.Checked, yearValue.Value)
					'sqlCustomFilter = DateFilter(FilterColumn.Text, minDateValue.Value, maxDateValue.Value, PorAño.Checked, yearValue.Value)
				End If

				'If sqlCustomFilter <> "" Then
				'If sqlWhere.Contains("WHERE") Then
				'sqlCustomFilter = sqlWhere & " AND " & sqlCustomFilter
				'Else
				'sqlCustomFilter = "WHERE " & sqlCustomFilter
				'End If
				'End If
			End If
		End If
		Return bsCustomFilter
		'Return sqlCustomFilter
	End Function

	Private Function IntDecFilter(ColumnName As String, minValue As Long, maxValue As Long, Compare As String)
		Dim sql As String = ""
		Dim minValueString As String = Replace(minValue, ",", ".").ToString()
		Dim maxValueString As String = Replace(maxValue, ",", ".").ToString()

		If Compare = "VALOR" Then
			sql = ColumnName & "=" & minValueString
		ElseIf Compare = "MENOR QUE" Then
			sql = ColumnName & "<" & minValueString
		ElseIf Compare = "MAYOR QUE" Then
			sql = ColumnName & ">" & minValueString
		ElseIf Compare = "RANGO" Then
			sql = ColumnName & ">" & minValueString & " AND " & ColumnName & "<" & maxValueString
		End If

		Return sql
	End Function

	Private Function DateFilter(ColumnName As String, minDValue As Date, maxDValue As Date, ByYear As Boolean, yValue As Integer)
		Dim sql As String = ""
		If ByYear Then
			sql = "YEAR(" & ColumnName & ") = " & yValue
		Else
			If Connection.Text = My.Settings.foxcon Then
				sql &= " " & ColumnName & " => {" & minDValue.ToString("MM/dd/yyyy") & "}" &
						   " AND " & ColumnName & " <= {" & maxDValue.ToString("MM/dd/yyyy") & "}"
			Else
				sql &= " " & ColumnName & " => {" & minDValue.ToShortDateString & "}" &
						   " AND " & ColumnName & " <= {" & maxDValue.ToShortDateString & "}"
			End If
		End If
		Return sql
	End Function

	'EVENTOS
	'Menu events
	'HACIENDA
	Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
		Me.Text = sender.Text
		CustomTable.Text = "Click para agregar tabla."

		'No se puede filtrar dinamicamente las columnas con alias (como ingresado)
		sqlSelect = "SELECT orden, nombre, (autorizado - gastado) as restante, gastado as ingresado, autorizado"
		sqlFrom = "FROM hacienda"
		sqlWhere = "WHERE sumado = 2 and orden < 900000000000"
		sqlGroupBy = ""
		sqlHaving = ""
		sqlOrderBy = "ORDER BY orden"

		'ColumnListDataSource = DbMan.read("SELECT orden, nombre, gastado, autorizado", Connection.Text, sqlFrom)

		ExecuteQuery(True)
	End Sub
	Private Sub EgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosToolStripMenuItem.Click
		Me.Text = sender.Text
		CustomTable.Text = "Click para agregar tabla."

		sqlSelect = "SELECT orden, nombre, (autorizado - gastado) as restante, gastado, autorizado"
		sqlFrom = " FROM hacienda"
		sqlWhere = " WHERE sumado = 2 and orden > 899999999999"
		sqlGroupBy = ""
		sqlHaving = ""
		sqlOrderBy = "ORDER BY orden"

		ExecuteQuery(True)
	End Sub

    'BANCOS
    Private Sub SaldoDeCuentasBancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoDeCuentasBancosToolStripMenuItem.Click
		Me.Text = sender.Text
		CustomTable.Text = "Click para agregar tabla."

		Dim dtab As DataTable = DbMan.read("SELECT MIN(fecha) as fecha FROM bancos", Connection.Text)
		minDateValue.Value = dtab(0)("fecha")

		sqlSelect = "SELECT banco, 
                           (SELECT SUM(b3.importe)
                            FROM bancos as b3
                            WHERE b3.tipo=2 AND b3.banco=b1.banco
                            AND fecha=>{" & minDateValue.Value.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.Value.ToString("MM/dd/yyyy") & "}) AS ingreso,
                           (SELECT SUM(b2.importe)
                            FROM bancos as b2
                            WHERE b2.tipo=1 AND b2.banco=b1.banco
                            AND fecha=>{" & minDateValue.Value.ToString("MM/dd/yyyy") & "}
                            AND fecha<={" & maxDateValue.Value.ToString("MM/dd/yyyy") & "}) AS egreso,
                           (SELECT SUM(b3.importe) FROM bancos as b3
                            WHERE b3.tipo=2 AND b3.banco=b1.banco
                            AND fecha=>{" & minDateValue.Value.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.Value.ToString("MM/dd/yyyy") & "}) - 
                           (SELECT SUM(b2.importe) FROM bancos as b2
                            WHERE b2.tipo=1 AND b2.banco=b1.banco
                            AND fecha=>{" & minDateValue.Value.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.Value.ToString("MM/dd/yyyy") & "}) AS diferencia"
		sqlFrom = " FROM bancos as b1"
		sqlWhere = ""
		sqlGroupBy = " GROUP BY banco"
		sqlHaving = ""
		sqlOrderBy = ""

		ExecuteQuery(True)
	End Sub

	'CAJA
	Private Sub CierreDiarioDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDiarioDeCajaToolStripMenuItem.Click
		Me.Text = sender.Text
		CustomTable.Text = "Click para agregar tabla."

		sqlSelect = "SELECT * "
		sqlFrom = " FROM caja"
		sqlWhere = " WHERE importe > 0"
		sqlGroupBy = ""
		sqlHaving = ""
		sqlOrderBy = "ORDER BY fecha"

		ExecuteQuery(True)
	End Sub

    'CAJA <> MOVIMIS
    Private Sub CompararIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompararIngresosToolStripMenuItem.Click
		Me.Text = sender.Text
		CustomTable.Text = "Click para agregar tabla."

		sqlSelect = "SELECT caja.fecha, movimis.documento as movimis_documento,
                            SUM(movimis.pagado) as suma_movimis_pagado, caja.recibo as caja_recibo,
                            caja.importe as caja_importe, SUM(movimis.pagado)-importe as diferencia, 
							movimis.detalle"

		sqlFrom = "FROM caja INNER JOIN movimis ON caja.recibo=movimis.documento"
		sqlWhere = "WHERE movimis.orden<900000000000"
		sqlGroupBy = "GROUP BY caja.fecha, movimis.documento, caja.recibo, caja.importe, movimis.detalle"
		sqlHaving = ""
		sqlOrderBy = "ORDER BY caja.fecha"

		'ColumnListDataSource = DbMan.read("SELECT caja.recibo, caja.importe, movimis.documento, movimis.detalle ",Connection.Text, sqlFrom)

		ExecuteQuery(True)
	End Sub
	Private Sub CompararEgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompararEgresosToolStripMenuItem.Click
		Me.Text = sender.Text
		CustomTable.Text = "Click para agregar tabla."

		'cambiar caja por pagos y corregir tema de documento <> orden

		sqlSelect = "SELECT opagos.dia, movimis.documento as movimis_documento,
                            movimis.pagado as movimis_pagado, opagos.orden as opagos_orden,
                            opagos.importe as opagos_importe, SUM(movimis.pagado)-opagos.importe as diferencia,
                            movimis.detalle, movimis.orden, hacienda.nombre"

		sqlFrom = "FROM opagos INNER JOIN (movimis INNER JOIN hacienda ON movimis.orden=hacienda.orden)
							ON opagos.factura=movimis.detalle"

		sqlWhere = "WHERE movimis.orden>899999999999"

		sqlGroupBy = "GROUP BY opagos.dia, movimis.documento, movimis.detalle, movimis.pagado, opagos.orden,
							opagos.importe, movimis.orden, hacienda.nombre"

		sqlHaving = ""

		sqlOrderBy = "ORDER BY opagos.dia"

		'DbMan.read("SELECT opagos.dia, opagos.orden, opagos.importe, movimis.fecha, movimis.documento, movimis.detalle, movimis.orden",Connection.Text, sqlFrom)

		ExecuteQuery(True)

	End Sub

	'Main filter events
	Private Sub PanelFiltros_VisibleChanged(sender As Object, e As EventArgs) Handles PanelFiltros.VisibleChanged
		If sender.Visible Then
			If sender Is PanelFiltros Then
				ColumnList.SelectedIndex = -1
			End If
		End If
	End Sub

	Private Sub EnableFilter_CheckedChanged(sender As Object, e As EventArgs) Handles EnableFilter.CheckedChanged
		ColumnList.Visible = EnableFilter.Checked
		ColumnList.SelectedIndex = -1
		If EnableFilter.Checked = False Then
			IntFilterPanel.Visible = False
			DateFilterPanel.Visible = False
			StringFilterPanel.Visible = False
		End If
	End Sub

	Private Sub ColumnList_bs_CurrentChanged(sender As Object, e As EventArgs) Handles ColumnList_bs.CurrentChanged, ColumnList_bs.PositionChanged, ColumnList.TextChanged
		query_bs.Filter = ""
		IntFilterPanel.Visible = False
		DateFilterPanel.Visible = False
		StringFilterPanel.Visible = False
		If PanelFiltros.Visible And EnableFilter.Checked Then
			ExecuteQuery(False)
			FilterQuery(sender, query_bs, ColumnList, True)
		End If
	End Sub

	Private Sub path_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CustomTable.LinkClicked
		Dim TableName As String = ""
		Dim table As New DataTable

		If CustomTable.Text <> "Click para modificar." Then
			TableName = CustomTable.Text
		End If

		Do
			TableName = InputBox("Ingrese nombre de tabla.", "Ingresar Tabla")
			If Trim(TableName) <> "" Then
				TableName = Trim(TableName)
				table = DbMan.read("SELECT * FROM " & TableName, Connection.Text)
			Else
				TableName = Nothing
			End If
		Loop Until TableName Is Nothing Or table Is Nothing = False

		If TableName <> "" Then
			sqlSelect = "SELECT *"
			sqlFrom = "FROM " & TableName
			sqlWhere = ""
			sqlGroupBy = ""
			sqlHaving = ""
			sqlOrderBy = ""
			ExecuteQuery(True)

			If TableName <> CustomTable.Text Then
				CustomTable.Text = TableName
			End If
		Else
			CustomTable.Text = "Click para agregar tabla."
		End If

	End Sub

	'DEC INT filter events
	Private Sub NumFilterSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NumFilterSelect.SelectedIndexChanged, NumFilterSelect.SelectedValueChanged, NumFilterSelect.TextChanged
		If IntFilterPanel.Visible Then
			minNumValue.Value = minNumValue.Minimum
			maxNumValue.Value = maxNumValue.Maximum
			Label4.Visible = (NumFilterSelect.Text = "RANGO")
			maxNumValue.Visible = (NumFilterSelect.Text = "RANGO")
		End If
	End Sub

	Private Sub minNumValue_KeyUp(sender As Object, e As KeyEventArgs) Handles minNumValue.KeyUp, maxNumValue.KeyUp
		If e.KeyValue = Keys.Enter Then
			search.PerformClick()
		End If
	End Sub

	'DATE filter events
	Private Sub PorFecha_CheckedChanged(sender As Object, e As EventArgs) Handles PorFecha.CheckedChanged, PorAño.CheckedChanged
		If DateFilterPanel.Visible Then
			minDateValue.Visible = PorFecha.Checked
			Label2.Visible = PorFecha.Checked
			maxDateValue.Visible = PorFecha.Checked
			yearValue.Visible = PorAño.Checked
		End If
	End Sub
	Private Sub minDateValue_KeyUp(sender As Object, e As KeyEventArgs) Handles minDateValue.KeyUp, maxDateValue.KeyUp, yearValue.KeyUp
		If e.KeyValue = Keys.Enter Then
			search.PerformClick()
		End If
	End Sub

	'STRING filter events
	Private Sub keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword.KeyUp
		If e.KeyValue = Keys.Enter Then
			search.PerformClick()
		End If
	End Sub



	Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
		If StringFilterPanel.Visible Then

			ExecuteQuery(False)

			If Len(Trim(keyword.Text)) > 2 Then
				query_bs.Filter = FilterQuery(sender, query_bs, ColumnList, False)
			Else
				query_bs.Filter = ""
			End If

			query_bs.Filter = FilterQuery(sender, query_bs, ColumnList, False)
		ElseIf DateFilterPanel.Visible Then
			ExecuteQuery(False)
			query_bs.Filter = FilterQuery(sender, query_bs, ColumnList, False)
		ElseIf IntFilterPanel.Visible Then
			ExecuteQuery(False)
			query_bs.Filter = FilterQuery(sender, query_bs, ColumnList, False)
		End If
	End Sub

	Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click

	End Sub

	'CUSTOM QUERY
	Private Sub CustomQuery_KeyUp(sender As Object, e As KeyEventArgs) Handles CustomQuery.KeyUp
		If e.KeyValue = Keys.Enter Then
			Dim dtab As DataTable = DbMan.read(CustomQuery.Text, Connection.Text)
			CtrlMan.LoadDataGridView(DataView, query_bs, "", dtab)
			CustomQuery.Items.Insert(0, Trim(CustomQuery.Text))
			CustomQuery.Text = ""
		End If
	End Sub



	'Connections
	Private Sub DBFoxMuniciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBFoxMuniciToolStripMenuItem.Click
		Connection.Text = My.Settings.foxcon
	End Sub
	Private Sub DBAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBAccessToolStripMenuItem.Click
		Connection.Text = My.Settings.adbcon
	End Sub
	Private Sub DBPostgreSQLToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DBPostgreSQLToolStripMenuItem.Click
		Connection.Text = My.Settings.pgsqlcon
	End Sub


End Class