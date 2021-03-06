﻿Public Class ConsultasEspeciales
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Connection.Text = My.Settings.foxConnection

        GenSearchControl1.vista.Items.AddRange(New Object() {"HACIENDA - INGRESOS", "HACIENDA - EGRESOS",
                                                             "INGRESOS CONSOLIDADOS", "EGRESOS CONSOLIDADOS",
                                                             "BANCOS - SALDO", "CAJA",
                                                             "COMPARAR INGRESOS", "COMPARAR EGRESOS",
                                                             "PERSONALIZADA"})

    End Sub

    'EVENTOS
    Private Sub Search() Handles GenSearchControl1.CSearchClick
        GenSearchControl1.FilterSearch()
    End Sub

    Private Sub FilterResults() Handles GenSearchControl1.CFilter
        bs_query.Filter = GenSearchControl1.bsCustomFilter
    End Sub

    Private Sub BuildFilter() Handles GenSearchControl1.CFiltroIndexTextChanged
        If GenSearchControl1.filtro.SelectedIndex > -1 And bs_query.Count > 0 And
           GenSearchControl1.filtro.Text <> "System.Data.DataRowView" Then

            Dim ordered_bs As BindingSource = bs_query
            ordered_bs.Sort = GenSearchControl1.filtro.Text
            ordered_bs.MoveFirst()

            'TODO filtrar valores nulos
            If GenSearchControl1.filtro.SelectedValue.ToString = "System.Decimal" _
            Or GenSearchControl1.filtro.SelectedValue.ToString = "System.Integer" Then
                If ordered_bs.Current(GenSearchControl1.filtro.Text) Is DBNull.Value Then
                    GenSearchControl1.NumValue.Minimum = 0
                    GenSearchControl1.MaxNumValue.Minimum = 0
                Else
                    GenSearchControl1.NumValue.Minimum = ordered_bs.Current(GenSearchControl1.filtro.Text)
                    GenSearchControl1.MaxNumValue.Minimum = ordered_bs.Current(GenSearchControl1.filtro.Text)
                End If
                ordered_bs.MoveLast()
                If ordered_bs.Current(GenSearchControl1.filtro.Text) Is DBNull.Value Then
                    GenSearchControl1.NumValue.Maximum = 1
                    GenSearchControl1.MaxNumValue.Maximum = 1
                Else
                    GenSearchControl1.NumValue.Maximum = ordered_bs.Current(GenSearchControl1.filtro.Text)
                    GenSearchControl1.MaxNumValue.Maximum = ordered_bs.Current(GenSearchControl1.filtro.Text)
                End If
            ElseIf GenSearchControl1.filtro.SelectedValue.ToString = "System.DateTime" Then
                If ordered_bs.Current(GenSearchControl1.filtro.Text) Is DBNull.Value Then
                    GenSearchControl1.DateValue.MinDate = "1/1/1900"
                    GenSearchControl1.MaxDateValue.MinDate = "1/1/1900"
                Else
                    GenSearchControl1.DateValue.MinDate = CDate(ordered_bs.Current(GenSearchControl1.filtro.Text))
                    GenSearchControl1.MaxDateValue.MinDate = CDate(ordered_bs.Current(GenSearchControl1.filtro.Text))
                End If
                ordered_bs.MoveLast()
                If ordered_bs.Current(GenSearchControl1.filtro.Text) Is DBNull.Value Then
                    GenSearchControl1.DateValue.MaxDate = "31/12/2037"
                    GenSearchControl1.MaxDateValue.MaxDate = "31/12/2037"
                Else
                    GenSearchControl1.DateValue.MaxDate = CDate(ordered_bs.Current(GenSearchControl1.filtro.Text))
                    GenSearchControl1.MaxDateValue.MaxDate = CDate(ordered_bs.Current(GenSearchControl1.filtro.Text))
                End If
            End If
        End If
    End Sub

    Private Sub vista_n_customtable_events() Handles GenSearchControl1.CVistaIndexTextChanged, CustomTable.LinkClicked
        ExecuteQuery(GenSearchControl1.vista.Text)
    End Sub

    'CUSTOM QUERY
    Private Sub CustomQuery_KeyUp(sender As Object, e As KeyEventArgs) Handles CustomQuery.KeyUp
        If e.KeyValue = Keys.Enter Then
            Dim sql(0) As String
            sql(0) = CustomQuery.Text
            Dim dtab As DataTable = DbMan.ReadDB(Nothing, Connection.Text, sql)
            CtrlMan.DataGridViewTools.Load(QueryView, bs_query, dtab)
            CustomQuery.Items.Insert(0, Trim(CustomQuery.Text))
            CustomQuery.Text = ""
        End If
    End Sub

    'Connections
    Private Sub DBFoxMuniciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBFoxMuniciToolStripMenuItem.Click
        Connection.Text = My.Settings.foxConnection
    End Sub
    Private Sub DBAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBAccessToolStripMenuItem.Click
        Connection.Text = My.Settings.AdbConnection
    End Sub
    Private Sub DBPostgreSQLToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DBPostgreSQLToolStripMenuItem.Click
        Connection.Text = My.Settings.pgsqlCon_disabled
    End Sub

    'RUTINAS

    Private Sub ExecuteQuery(vista As String)
        Dim ReadTable As Boolean = True
        Dim sql(5) As String
        If Connection.Text <> "Seleccione una base de datos antes de continuar." Then
            If vista <> "" Then
                'Build SQL query
                CustomTable.Enabled = False
                If vista = "HACIENDA - INGRESOS" Then
                    sql(0) = "SELECT *"
                    sql(1) = "FROM hacienda"
                    sql(2) = "WHERE sumado = 2 AND pertenece='8'"
                    sql(3) = "ORDER BY orden"

                ElseIf vista = "HACIENDA - EGRESOS" Then
                    sql(0) = "SELECT *"
                    sql(1) = "FROM hacienda"
                    sql(2) = "WHERE sumado = 2 and pertenece='9'"
                    sql(3) = "ORDER BY orden"

                ElseIf vista = "INGRESOS CONSOLIDADOS" Then
                    Hacienda.ConsolidarCuentas(Today)
                    sql(0) = "SELECT *"
                    sql(1) = "FROM ingresos"

                ElseIf vista = "EGRESOS CONSOLIDADOS" Then
                    Hacienda.ConsolidarCuentas(Today)
                    sql(0) = "SELECT *"
                    sql(1) = "FROM egresos"


                ElseIf vista = "BANCOS - SALDO" Then
                    sql(0) = "SELECT MIN(fecha) as fecha FROM bancos"

                    Dim minDateValue As Date = Today
                    Dim maxDateValue As Date = Today
                    Using dtab As DataTable = DbMan.ReadDB(Nothing, Connection.Text, sql)
                        minDateValue = dtab.Rows(0)("fecha").ToString
                    End Using
                    sql(0) = "SELECT banco, 
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
                    sql(1) = " FROM bancos as b1"
                    sql(2) = " GROUP BY banco"

                ElseIf vista = "CAJA" Then
                    sql(0) = "SELECT * "
                    sql(1) = "FROM caja"
                    sql(2) = "ORDER BY fecha"

                ElseIf vista = "COMPARAR INGRESOS" Then
                    sql(0) = "SELECT caja.fecha, movimis.documento as movimis_documento,
                                     SUM(movimis.pagado) as suma_movimis_pagado, caja.recibo as caja_recibo,
                                     caja.importe as caja_importe, SUM(movimis.pagado)-importe as diferencia, 
							         movimis.detalle"
                    sql(1) = "FROM caja INNER JOIN movimis ON caja.recibo=movimis.documento"
                    sql(2) = "WHERE movimis.orden<900000000000"
                    sql(3) = "GROUP BY caja.fecha, movimis.documento, caja.recibo, caja.importe, movimis.detalle"
                    sql(4) = "ORDER BY caja.fecha"

                ElseIf vista = "COMPARAR EGRESOS" Then
                    'cambiar caja por pagos y corregir tema de documento <> orden

                    sql(0) = "SELECT opagos.dia, movimis.documento as movimis_documento,
                                     movimis.pagado as movimis_pagado, opagos.orden as opagos_orden,
                                     opagos.importe as opagos_importe, SUM(movimis.pagado)-opagos.importe as diferencia,
                                     movimis.detalle, movimis.orden, hacienda.nombre"
                    sql(1) = "FROM opagos INNER JOIN (movimis INNER JOIN hacienda ON movimis.orden=hacienda.orden)
							ON opagos.factura=movimis.detalle"
                    sql(2) = "WHERE movimis.orden>899999999999"
                    sql(3) = "GROUP BY opagos.dia, movimis.documento, movimis.detalle, movimis.pagado, opagos.orden,
							opagos.importe, movimis.orden, hacienda.nombre"
                    sql(4) = "ORDER BY opagos.dia"

                ElseIf vista = "PERSONALIZADA" Then
                    Dim TableName As String
                    CustomTable.Enabled = True
                    Dim dtab As New DataTable
                    Do
                        TableName = InputBox("Ingrese nombre de tabla.", "Ingresar Tabla")

                        If Trim(TableName) <> "" Then
                            TableName = Trim(TableName)
                            sql(0) = "SELECT * FROM " & TableName
                            dtab = DbMan.ReadDB(Nothing, Connection.Text, sql)
                        Else
                            TableName = Nothing
                        End If
                    Loop Until TableName Is Nothing Or dtab Is Nothing = False
                    dtab.Dispose()

                    If TableName <> "" Then
                        sql(0) = "SELECT *"
                        sql(1) = "FROM " & TableName
                        CustomTable.Text = TableName
                    Else
                        CustomTable.Text = "Seleccionar tabla.."
                        ReadTable = False
                    End If
                Else
                    ReadTable = False
                End If
            Else
                ReadTable = False
            End If
        Else
            ReadTable = False
        End If

        If ReadTable Then
            Dim LastQueryView As DataGridView = QueryView
            Dim LastQueryBS As BindingSource = bs_query

            bs_query = New BindingSource With {
                .DataSource = DbMan.ReadDB(Nothing, Connection.Text, sql)
            } 'Avoids IBindingList error

            For Each str As String In sql
                CustomQuery.Text &= " " & str
            Next


            If bs_query.DataSource Is Nothing = False And bs_query.Count > 0 Then
                'Create filter with columns
                Dim ColumnList_bs As New BindingSource
                GenSearchControl1.filtro.Visible = False
                ColumnList_bs.DataSource = CtrlMan.Fill.GetColumnList(bs_query.DataSource.Columns)
                GenSearchControl1.filtro = CtrlMan.Fill.SetAutoComplete(GenSearchControl1.filtro, ColumnList_bs, "ColumnName", "DataType")
                'Fill with data
                CtrlMan.DataGridViewTools.Load(QueryView, bs_query)
            Else
                'Retrieves last search
                CtrlMan.DataGridViewTools.Load(LastQueryView, LastQueryBS)
            End If
        Else
            GenSearchControl1.reset_search.PerformClick()
        End If
    End Sub

End Class