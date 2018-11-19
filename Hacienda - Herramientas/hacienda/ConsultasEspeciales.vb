Public Class ConsultasEspeciales
	Private sqlSelect, sqlFrom, sqlWhere, sqlGroupBy, sqlHaving, sqlOrderBy As String

	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		Connection.Text = My.Settings.foxcon

		GenSearchControl1.vista.Items.AddRange(New Object() {"HACIENDA - INGRESOS", "HACIENDA - EGRESOS",
															 "INGRESOS CONSOLIDADOS", "EGRESOS CONSOLIDADOS",
															 "BANCOS - SALDO", "CAJA - CIERRE DIARIO",
															 "COMPARAR INGRESOS", "COMPARAR EGRESOS",
															 "PERSONALIZADA"})

	End Sub

	'RUTINAS

	Private Sub ExecuteQuery(vista As String, ByVal reset As Boolean)
		QueryView.DataSource = Nothing
		query_bs.DataSource = Nothing
		sqlSelect = ""
		sqlFrom = ""
		sqlWhere = ""
		sqlGroupBy = ""
		sqlHaving = ""
		sqlOrderBy = ""

		If Connection.Text <> "Seleccione una base de datos antes de continuar." Then
			If vista <> "" Then
				Dim dtab As New DataTable
				'Build SQL query
				If vista = "HACIENDA - INGRESOS" Then
					sqlSelect = "SELECT orden, nombre, (autorizado - gastado) as restante, gastado as ingresado, autorizado"
					sqlFrom = "FROM hacienda"
					sqlWhere = "WHERE sumado = 2 and orden < 900000000000"
					sqlGroupBy = ""
					sqlHaving = ""
					sqlOrderBy = "ORDER BY orden"

				ElseIf vista = "HACIENDA - EGRESOS" Then
					sqlSelect = "SELECT orden, nombre, (autorizado - gastado) as restante, gastado, autorizado"
					sqlFrom = " FROM hacienda"
					sqlWhere = " WHERE sumado = 2 and orden > 899999999999"
					sqlGroupBy = ""
					sqlHaving = ""
					sqlOrderBy = "ORDER BY orden"

				ElseIf vista = "INGRESOS CONSOLIDADOS" Then
					'agregar
				ElseIf vista = "EGRESOS CONSOLIDADOS" Then
					'agregar
				ElseIf vista = "BANCOS - SALDO" Then
					dtab = DbMan.read("SELECT MIN(fecha) as fecha FROM bancos", Connection.Text)
					Dim minDateValue As Date = dtab(0)("fecha").ToString
					Dim maxDateValue As Date = Today

					sqlSelect = "SELECT banco, 
                           (SELECT SUM(b3.importe)
                            FROM bancos as b3
                            WHERE b3.tipo=2 AND b3.banco=b1.banco
                            AND fecha=>{" & minDateValue.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.ToString("MM/dd/yyyy") & "}) AS ingreso,
                           (SELECT SUM(b2.importe)
                            FROM bancos as b2
                            WHERE b2.tipo=1 AND b2.banco=b1.banco
                            AND fecha=>{" & minDateValue.ToString("MM/dd/yyyy") & "}
                            AND fecha<={" & maxDateValue.ToString("MM/dd/yyyy") & "}) AS egreso,
                           (SELECT SUM(b3.importe) FROM bancos as b3
                            WHERE b3.tipo=2 AND b3.banco=b1.banco
                            AND fecha=>{" & minDateValue.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.ToString("MM/dd/yyyy") & "}) - 
                           (SELECT SUM(b2.importe) FROM bancos as b2
                            WHERE b2.tipo=1 AND b2.banco=b1.banco
                            AND fecha=>{" & minDateValue.ToString("MM/dd/yyyy") & "} 
                            AND fecha<={" & maxDateValue.ToString("MM/dd/yyyy") & "}) AS diferencia"
					sqlFrom = " FROM bancos as b1"
					sqlWhere = ""
					sqlGroupBy = " GROUP BY banco"
					sqlHaving = ""
					sqlOrderBy = ""

				ElseIf vista = "CAJA - CIERRE DIARIO" Then
					sqlSelect = "SELECT * "
					sqlFrom = " FROM caja"
					sqlWhere = " WHERE importe > 0"
					sqlGroupBy = ""
					sqlHaving = ""
					sqlOrderBy = "ORDER BY fecha"

				ElseIf vista = "COMPARAR INGRESOS" Then
					sqlSelect = "SELECT caja.fecha, movimis.documento as movimis_documento,
                            SUM(movimis.pagado) as suma_movimis_pagado, caja.recibo as caja_recibo,
                            caja.importe as caja_importe, SUM(movimis.pagado)-importe as diferencia, 
							movimis.detalle"

					sqlFrom = "FROM caja INNER JOIN movimis ON caja.recibo=movimis.documento"
					sqlWhere = "WHERE movimis.orden<900000000000"
					sqlGroupBy = "GROUP BY caja.fecha, movimis.documento, caja.recibo, caja.importe, movimis.detalle"
					sqlHaving = ""
					sqlOrderBy = "ORDER BY caja.fecha"

				ElseIf vista = "COMPARAR EGRESOS" Then
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

				ElseIf vista = "PERSONALIZADA" Then
					CustomTable.Text = "Click para agregar tabla."
				End If


				query_bs.DataSource = DbMan.read(sqlSelect, Connection.Text, sqlFrom, sqlWhere, sqlGroupBy, sqlHaving, sqlOrderBy)

				CustomQuery.Text = sqlSelect & " " & sqlFrom & " " & sqlWhere & " " & sqlGroupBy & " " & sqlHaving & " " & sqlOrderBy

				If query_bs.DataSource Is Nothing = False Then
					Dim bs As New BindingSource
					bs.DataSource = CtrlMan.Fill.GetColumnList(query_bs.DataSource)
					GenSearchControl1.filtro = CtrlMan.Fill.SetAutoComplete(GenSearchControl1.filtro, bs, "ColumnName", "DataType")
					CtrlMan.LoadDataGridView(QueryView, query_bs)
				Else
					GenSearchControl1.reset_search.PerformClick()
					QueryView.DataSource = Nothing
				End If
			End If
		Else
			CustomQuery.Text = ""
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
			ExecuteQuery(GenSearchControl1.vista.Text, True)

			If TableName <> CustomTable.Text Then
				CustomTable.Text = TableName
			End If
		Else
			CustomTable.Text = "Click para agregar tabla."
		End If

	End Sub

	'EVENTOS
	Private Sub Search() Handles GenSearchControl1.CSearch_Click
		query_bs.Filter = GenSearchControl1.bsCustomFilter
	End Sub

	Private Sub vista_Changed() Handles GenSearchControl1.CVista_IndexTextChanged
		ExecuteQuery(GenSearchControl1.vista.Text, True)
	End Sub

	'CUSTOM QUERY
	Private Sub CustomQuery_KeyUp(sender As Object, e As KeyEventArgs) Handles CustomQuery.KeyUp
		If e.KeyValue = Keys.Enter Then
			Dim dtab As DataTable = DbMan.read(CustomQuery.Text, Connection.Text)
			CtrlMan.LoadDataGridView(QueryView, query_bs, "", dtab)
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