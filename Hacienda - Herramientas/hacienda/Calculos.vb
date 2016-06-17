Public Class Calculos
    Private SQLSelect, SQLTable, SQLCriteria, SQLGrouping As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        año.Value = Today.Year
        Connection.Text = foxcon
    End Sub

    'HACIENDA
    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        SQLSelect = "SELECT orden, nombre, gastado as ingresado, (autorizado - gastado) as restante"
        SQLTable = " FROM hacienda"
        SQLCriteria = " WHERE sumado = 2 and orden < 900000000000"
        SQLGrouping = ""

        ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub
    Private Sub EgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosToolStripMenuItem.Click
        SQLSelect = "SELECT orden, nombre, gastado, (autorizado - gastado) as restante"
        SQLTable = " FROM hacienda"
        SQLCriteria = " WHERE sumado = 2 and orden > 899999999999"
        SQLGrouping = ""

        ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub

    'BANCOS
    Private Sub SaldoDeCuentasBancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoDeCuentasBancosToolStripMenuItem.Click
        SQLSelect = "SELECT banco, 
                           (SELECT SUM(b3.importe) FROM bancos as b3
                            WHERE b3.tipo=2 AND b3.banco=b1.banco) AS ingreso,
                           (SELECT SUM(b2.importe) FROM bancos as b2
                            WHERE b2.tipo=1 AND b2.banco=b1.banco) AS egreso,
                           (SELECT SUM(b3.importe) FROM bancos as b3
                            WHERE b3.tipo=2 AND b3.banco=b1.banco) - 
                           (SELECT SUM(b2.importe) FROM bancos as b2
                            WHERE b2.tipo=1 AND b2.banco=b1.banco) AS diferencia"

        SQLTable = " FROM bancos as b1"
        SQLCriteria = ""
        SQLGrouping = " GROUP BY banco"

        ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub
    'CAJA
    Private Sub CierreDiarioDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDiarioDeCajaToolStripMenuItem.Click
        SQLSelect = "SELECT * "
        SQLTable = " FROM caja"
        SQLCriteria = " WHERE importe>0"
        SQLGrouping = ""

        ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)

        PanelColumnas.Visible = True
        PanelFiltroFecha.Visible = True
        PorFecha.Checked = True
    End Sub

    'OTROS
    Private Sub CompararIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompararIngresosToolStripMenuItem.Click
        SQLSelect = "SELECT caja.fecha, movimis.documento as movimis_documento,
                            SUM(movimis.pagado) as suma_movimis_pagado, caja.recibo as caja_recibo,
                            caja.importe as caja_importe, SUM(movimis.pagado)-importe as diferencia, movimis.detalle"
        SQLTable = " FROM caja INNER JOIN movimis ON caja.recibo=movimis.documento"
        SQLCriteria = " WHERE movimis.orden<900000000000"
        SQLGrouping = "GROUP BY caja.fecha, movimis.documento, caja.recibo, caja.importe, movimis.detalle"

        ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub

    Private Sub CompararEgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompararEgresosToolStripMenuItem.Click
        'cambiar caja por pagos y corregir tema de documento <> orden
        SQLSelect = "SELECT opagos.fecha as fecha_opago, movimis.documento as movimis_documento,
                            movimis.pagado as movimis_pagado, opagos.orden as opagos_orden,
                            opagos.importe as opagos_importe, SUM(movimis.pagado)-importe as diferencia,
                            movimis.detalle, movimis.orden, hacienda.nombre"
        SQLTable = " FROM opagos INNER JOIN (movimis
                     INNER JOIN hacienda ON movimis.orden=hacienda.orden)
                     ON opagos.orden=movimis.documento"
        SQLCriteria = " WHERE movimis.orden>899999999999"
        SQLGrouping = " GROUP BY opagos.fecha, movimis.documento, movimis.detalle, movimis.pagado, opagos.orden,
                        opagos.importe, movimis.orden, hacienda.nombre"

        ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)
    End Sub

    'RUTINAS
    Private Sub ProcessQuery(ByVal reset As Boolean, ByVal CustomSelect As String, ByVal CustomTable As String,
                             ByVal CustomCriteria As String, ByVal CustomGrouping As String)
        Dim sql As String = CustomSelect & CustomTable & CustomCriteria & CustomGrouping

        DataView.DataSource = Nothing
        bs.DataSource = Nothing

        If Connection.Text <> "Seleccione una base de datos antes de continuar." Then
            Dim dtab As DataTable = bd.read(Connection.Text, sql)

            If reset Then
                PanelColumnas.Visible = False
                PanelFiltroFecha.Visible = False
                ListaColumnas.Items.Clear()
                SelectorCampoFecha.Items.Clear()
                For Each col As DataColumn In dtab.Columns
                    ListaColumnas.Items.Add(col.ColumnName, True)
                    If col.DataType = GetType(Date) Then
                        SelectorCampoFecha.Items.Add(col.ToString)
                    End If
                Next
                If ListaColumnas.Items.Count > 0 Then
                    'PanelColumnas.Visible = True
                End If
                If SelectorCampoFecha.Items.Count > 0 Then
                    SelectorCampoFecha.SelectedIndex = 0
                    'PanelFiltroFecha.Visible = True
                End If
            End If

            Query.Show(DataView, bs, dtab)
        Else
            Connection.Text = "Seleccione una base de datos antes de continuar."
        End If
    End Sub


    Private Function FiltroColumna()
        Dim sql As String = ""
        If ListaColumnas.CheckedItems.Count > 0 Then
            For Each item In ListaColumnas.CheckedItems
                sql += item.ToString & ", "
            Next
            sql = Microsoft.VisualBasic.Left(sql, Len(sql) - 2)
        Else
            sql = "*"
        End If
        Return sql
    End Function

    Private Function FiltroFecha()
        Dim sql As String
        If SQLCriteria.Contains(" WHERE") Then
            sql = " AND"
        Else
            sql = " WHERE"
        End If

        If PorAño.Checked Then
            sql += " YEAR(" & SelectorCampoFecha.Text & ") = " & año.Value
        ElseIf PorFecha.Checked Then
            If Connection.Text = foxcon Then
                sql += " " & SelectorCampoFecha.Text & " => {" & inicio.Value.ToString("MM/dd/yyyy") & "}" &
                       " AND " & SelectorCampoFecha.Text & " <= {" & final.Value.ToString("MM/dd/yyyy") & "}"
            Else
                sql += " " & SelectorCampoFecha.Text & " => {" & inicio.Value.ToShortDateString & "}" &
                       " AND " & SelectorCampoFecha.Text & " <= {" & final.Value.ToShortDateString & "}"
            End If
        Else
            Return ""
        End If
        Return sql
    End Function

    'EVENTOS
    Private Sub PanelFiltroFecha_VisibleChanged(sender As Object, e As EventArgs) Handles PanelFiltroFecha.VisibleChanged
        SinFiltro.Checked = True
    End Sub

    Private Sub Filtros_CheckedChanged(sender As Object, e As EventArgs) Handles _
                SinFiltro.CheckedChanged, PorFecha.CheckedChanged, PorAño.CheckedChanged,
                SinFiltro.Click, PorFecha.Click, PorAño.Click,
                inicio.ValueChanged, final.ValueChanged, año.ValueChanged

        inicio.Enabled = PorFecha.Checked
        inicio.MaxDate = final.Value
        final.Enabled = PorFecha.Checked
        final.MinDate = inicio.Value
        año.Enabled = PorAño.Checked

        If PanelFiltroFecha.Visible Then
            ProcessQuery(False, SQLSelect, SQLTable, SQLCriteria & FiltroFecha(), SQLGrouping)
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
            SQLTable = " FROM " & name
            SQLCriteria = ""
            SQLGrouping = ""

            ProcessQuery(True, SQLSelect, SQLTable, SQLCriteria, SQLGrouping)

            If name <> TablaPersonalizada.Text Then
                TablaPersonalizada.Text = name
            End If
            If ListaColumnas.Items.Count > 0 Then
                PanelColumnas.Visible = True
            End If
            If SelectorCampoFecha.Items.Count > 0 Then
                PanelFiltroFecha.Visible = True
            End If
        Else
            TablaPersonalizada.Text = "Click para agregar tabla."
            ListaColumnas.Visible = False
            PanelFiltroFecha.Visible = False
            DataView.DataSource = Nothing
            bs.DataSource = Nothing
        End If

    End Sub

    Private Sub ColumnList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaColumnas.SelectedIndexChanged
        If ListaColumnas.SelectedIndex > -1 Then
            ProcessQuery(False, "SELECT " & FiltroColumna(), SQLTable, SQLCriteria, SQLGrouping)
        End If
    End Sub
    Private Sub ColumnList_MouseUp(sender As Object, e As MouseEventArgs) Handles ListaColumnas.MouseUp
        If ListaColumnas.SelectedIndex > -1 Then
            ProcessQuery(False, "SELECT " & FiltroColumna(), SQLTable, SQLCriteria, SQLGrouping)
        End If
    End Sub
    Private Sub ColumnList_KeyUp(sender As Object, e As KeyEventArgs) Handles ListaColumnas.KeyUp
        If ListaColumnas.SelectedIndex > -1 Then
            ProcessQuery(False, "SELECT " & FiltroColumna(), SQLTable, SQLCriteria, SQLGrouping)
        End If
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