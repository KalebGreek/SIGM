Public Class Arqueo
    Private SQLSelect, SQLTable, SQLCriteria, SQLGrouping As String
    Private CampoFecha As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        año.Value = Today.Year
        PanelColumnas.Visible = False
        TablaPersonalizada.Visible = False
        PanelFiltroFecha.Visible = False
        Connection.Text = foxcon
    End Sub

    'HACIENDA
    Private Sub IngresosYEgresosPorHaciendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosYEgresosPorHaciendaToolStripMenuItem.Click
        SQLSelect = "SELECT hacienda.orden, hacienda.nombre, 
                           (  
                            SUM(mes1) + SUM(mes2) + SUM(mes3) + SUM(mes4) +
                            SUM(mes5) + SUM(mes6) + SUM(mes7) + SUM(mes8) +
                            SUM(mes9) + SUM(mes10) + SUM(mes11) + SUM(mes12)
                           ) as total_ingreso,
                           (
                            SUM(mes1) + SUM(mes2) + SUM(mes3) + SUM(mes4) +
                            SUM(mes5) + SUM(mes6) + SUM(mes7) + SUM(mes8) +
                            SUM(mes9) + SUM(mes10) + SUM(mes11) + SUM(mes12)
                           ) as total_egreso"

        SQLTable = " FROM hacienda"
        SQLCriteria = ""
        SQLGrouping = "  GROUP BY hacienda.orden, hacienda.nombre"

        ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub
    'BANCOS
    Private Sub SaldoDeCuentasBancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoDeCuentasBancosToolStripMenuItem.Click
        PanelFiltroFecha.Visible = True
        SQLSelect = "SELECT banco, (SELECT SUM(importe) FROM bancos WHERE tipo=2) as egreso, 
                                   (SELECT SUM(importe) FROM bancos WHERE tipo=1) as ingreso"

        SQLTable = " FROM bancos"
        SQLCriteria = ""
        SQLGrouping = " GROUP BY banco"

        ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub
    'CAJA
    Private Sub CierreDiarioDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDiarioDeCajaToolStripMenuItem.Click
        PanelFiltroFecha.Visible = True

        SQLSelect = "SELECT * "
        SQLTable += " FROM caja"
        SQLCriteria = ""
        SQLGrouping = ""

        PorFecha.Checked = True

    End Sub

    'OTROS
    Private Sub CompararIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompararIngresosToolStripMenuItem.Click
        SQLSelect = "SELECT movimis.detalle, movimis.documento as movimis_documento,
                            SUM(movimis.pagado) as suma_movimis_pagado, caja.recibo as caja_recibo,
                            caja.importe as caja_importe, SUM(movimis.pagado)-importe as diferencia"
        SQLTable = " FROM caja INNER JOIN movimis ON caja.recibo=movimis.documento"
        SQLCriteria = " WHERE movimis.orden<900000000000"
        SQLGrouping = "GROUP BY movimis.documento, movimis.detalle, caja.recibo, caja.importe"

        ProcessQuery(False, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub

    Private Sub CompararEgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompararEgresosToolStripMenuItem.Click
        'cambiar caja por pagos y corregir tema de documento <> orden
        SQLSelect = "SELECT movimis.detalle, movimis.documento as movimis_documento,
                            movimis.pagado as movimis_pagado, opagos.orden as opagos_orden,
                            opagos.importe as opagos_importe, SUM(movimis.pagado)-importe as diferencia,
                            movimis.orden, hacienda.nombre"
        SQLTable = " FROM opagos INNER JOIN (movimis
                     INNER JOIN hacienda ON movimis.orden=hacienda.orden)
                     ON opagos.orden=movimis.documento"
        SQLCriteria = " WHERE movimis.orden>899999999999"
        SQLGrouping = " GROUP BY movimis.documento, movimis.detalle, movimis.pagado, opagos.orden,
                        opagos.importe, movimis.orden, hacienda.nombre"

        ProcessQuery(False, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub

    'RUTINAS
    Private Sub ProcessQuery(ByVal reset As Boolean, ByVal CustomSelect As String, ByVal CustomTable As String,
                             ByVal CustomCriteria As String, ByVal CustomGrouping As String)
        Dim sql As String = CustomSelect & CustomTable & CustomCriteria & CustomGrouping
        Dim dtab As New DataTable

        DataView.DataSource = Nothing
        bs.DataSource = Nothing

        If reset Then
            ListaColumnas.Items.Clear()
            For Each col As DataColumn In dtab.Columns
                ListaColumnas.Items.Add(col.ToString, True)
            Next
        End If

        If Connection.Text <> "Sin datos." Then
            Query.Show(DataView, bs, bd.read(Connection.Text, sql))
        Else
            MsgBox("Seleccione una base de datos antes de continuar.")
        End If

    End Sub

    Private Sub Filtros_CheckedChanged(sender As Object, e As EventArgs) Handles _
                SinFiltro.CheckedChanged, PorFecha.CheckedChanged, Anual.CheckedChanged,
                SinFiltro.Click, PorFecha.Click, Anual.Click,
                inicio.ValueChanged, final.ValueChanged, año.ValueChanged

        If PorFecha.Checked Or Anual.Checked Then
            FiltroFecha()
        End If
    End Sub

    Private Function FiltroColumna()
        Dim sql As String = ""
        If ListaColumnas.CheckedItems.Count > 0 Then
            For Each item In ListaColumnas.CheckedItems
                sql += item.ToString & ", "
            Next
            sql = Microsoft.VisualBasic.Left(sel_sql, Len(sel_sql) - 2)
        Else
            sql = "*"
        End If
        Return sql
    End Function

    Private Sub FiltroFecha()

        If Anual.Checked Then
            ProcessQuery(False, SQLSelect, SQLTable,
                         SQLCriteria & " AND YEAR(" & CampoFecha & ") = " & año.Value, SQLGrouping)
        ElseIf PorFecha.Checked Then
            ProcessQuery(False, SQLSelect, SQLTable,
                         SQLCriteria & " AND " & CampoFecha & " => '" & inicio.Value & "' AND " & CampoFecha & " <= '" & final.Value & "'", SQLGrouping)
        Else
            ProcessQuery(False, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
        End If

    End Sub

    Private Sub path_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TablaPersonalizada.LinkClicked
        Dim name As String = ""
        Dim table As New DataTable

        If TablaPersonalizada.Text <> "Click para agregar tabla." Then
            name = TablaPersonalizada.Text
        End If

        Do
            name = InputBox("Ingrese nombre de tabla.", "Ingresar Tabla", "")
            If name <> "" Then
                table = bd.read(Connection.Text, "SELECT * FROM " & name)
            Else
                name = Nothing
            End If
        Loop Until name Is Nothing Or table Is Nothing = False

        If name <> "" Then
            SQLSelect = "SELECT *"
            SQLTable = "FROM " & name
            SQLCriteria = ""
            SQLGrouping = ""

            ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)

            If name <> TablaPersonalizada.Text Then
                TablaPersonalizada.Text = name
            End If

        Else
            TablaPersonalizada.Text = "Click para agregar tabla."
        End If

    End Sub

    Private Sub ColumnList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaColumnas.SelectedIndexChanged
        ProcessQuery(False, "SELECT " & FiltroColumna(), SQLTable, SQLCriteria, SQLGrouping)
    End Sub
    Private Sub ColumnList_MouseUp(sender As Object, e As MouseEventArgs) Handles ListaColumnas.MouseUp
        ProcessQuery(False, "SELECT " & FiltroColumna(), SQLTable, SQLCriteria, SQLGrouping)
    End Sub
    Private Sub ColumnList_KeyUp(sender As Object, e As KeyEventArgs) Handles ListaColumnas.KeyUp
        ProcessQuery(False, "SELECT " & FiltroColumna(), SQLTable, SQLCriteria, SQLGrouping)
    End Sub

    Private Sub DBFoxMuniciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBFoxMuniciToolStripMenuItem.Click
        Connection.Text = foxcon
    End Sub
    Private Sub DBAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBAccessToolStripMenuItem.Click
        Connection.Text = adbcon
    End Sub
    Private Sub DBPostgreSQLToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DBPostgreSQLToolStripMenuItem.Click
        Connection.Text = pgsqlcon
    End Sub





End Class