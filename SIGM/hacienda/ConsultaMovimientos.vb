Public Class ConsultaMovimientos
    Dim anexo_dtab, inciso_dtab, item_dtab, rubro_dtab, subrubro_dtab, partida_dtab, subpartida_dtab As New DataTable
    Dim level As Integer = 0
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        inicio.Value = "01/01/" & Year(Today)
    End Sub
    '###### GUI #############################################################################################

    '###### FIN GUI #############################################################################################

    '### EVENTOS  

    Private Sub Ingresos_CheckedChanged(sender As Object, e As EventArgs) Handles Ingresos.CheckedChanged, Egresos.CheckedChanged
        keyword_hacienda.Enabled = Ingresos.Checked Or Egresos.Checked
        If sender Is Ingresos Then
            visor.DataSource = Nothing
            bs_consulta.DataSource = Nothing
            ObtenerCuentas(Ingresos.Checked)
            DiagramarCuentas()
        Else
            Call Ingresos_CheckedChanged(Ingresos, Nothing)
        End If
    End Sub

    Private Sub SeleccionCuenta_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles SeleccionCuenta.AfterSelect
        progreso.Value = 0
        visor.DataSource = Nothing
        bs_consulta.DataSource = Nothing
        ValidarConsulta()
    End Sub



    Private Sub ActivarFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles ActivarFiltro.CheckedChanged
        GrupoFiltro.Visible = ActivarFiltro.Checked
        ValidarConsulta()
    End Sub
    Private Sub fecha_CheckedChanged(sender As Object, e As EventArgs) Handles fecha.CheckedChanged
        inicio.Enabled = fecha.Checked
        final.Enabled = fecha.Checked
        keyword_movimis.Enabled = concepto.Checked
        ValidarConsulta()
    End Sub
    Private Sub Keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword_movimis.KeyUp
        ValidarConsulta()
    End Sub

    Private Sub KeywordHacienda_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword_hacienda.KeyUp
        bs_cuenta.RemoveFilter()
        If e.KeyValue = Keys.Enter Then
            If bs_cuenta.Count > 0 Then
                keyword_hacienda.Text = Trim(keyword_hacienda.Text)
                If Len(keyword_hacienda.Text) > 2 Then
                    bs_cuenta.Filter = "nombre LIKE '%" & keyword_hacienda.Text & "%'"
                End If
                SeleccionCuenta.Refresh()
            End If
        End If
    End Sub

    Private Sub inicio_ValueChanged(sender As Object, e As EventArgs) Handles inicio.ValueChanged
        inicio.MaxDate = final.Value
        final.MinDate = inicio.Value
        ValidarConsulta()
    End Sub

    '### RUTINAS
    Private Sub ObtenerCuentas(ingresos As Boolean)
        Dim dtab As New DataTable
        Dim sqlSelect(3) As String

        sqlSelect(0) = "SELECT orden, nombre, sumado, pertenece, anexo, inciso, item, rubro, subrubro, partida, subpartida"
        sqlSelect(1) = " FROM hacienda"

        If ingresos Then
            sqlSelect(2) = " WHERE pertenece='8'"
        Else
            sqlSelect(2) = " WHERE pertenece='9'"
        End If

        sqlSelect(3) = " ORDER BY orden"

        dtab = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)
        If dtab.Rows.Count > 0 Then
            dtab.DefaultView.RowFilter = "inciso='0' AND item='0' AND rubro='00' AND subrubro='00' AND partida='00' AND subpartida='00'"
            anexo_dtab.DefaultView.RowFilter = Nothing
            anexo_dtab = dtab.DefaultView.ToTable()

            dtab.DefaultView.RowFilter = "inciso<>'0' AND item='0' AND rubro='00' AND subrubro='00' AND partida='00' AND subpartida='00'"
            inciso_dtab.DefaultView.RowFilter = Nothing
            inciso_dtab = dtab.DefaultView.ToTable()

            dtab.DefaultView.RowFilter = "inciso<>'0' AND item<>'0' AND rubro='00' AND subrubro='00' AND partida='00' AND subpartida='00'"
            item_dtab.DefaultView.RowFilter = Nothing
            item_dtab = dtab.DefaultView.ToTable()

            dtab.DefaultView.RowFilter = "inciso<>'0' AND item<>'0' AND rubro<>'00' AND subrubro='00' AND partida='00' AND subpartida='00'"
            rubro_dtab.DefaultView.RowFilter = Nothing
            rubro_dtab = dtab.DefaultView.ToTable()

            dtab.DefaultView.RowFilter = "inciso<>'0' AND item<>'0' AND rubro<>'00' AND subrubro<>'00' AND partida='00' AND subpartida='00'"
            subrubro_dtab.DefaultView.RowFilter = Nothing
            subrubro_dtab = dtab.DefaultView.ToTable()

            dtab.DefaultView.RowFilter = "inciso<>'0' AND item<>'0' AND rubro<>'00' AND subrubro<>'00' AND partida<>'00' AND subpartida='00'"
            partida_dtab.DefaultView.RowFilter = Nothing
            partida_dtab = dtab.DefaultView.ToTable()

            dtab.DefaultView.RowFilter = "inciso<>'0' AND item<>'0' AND rubro<>'00' AND subrubro<>'00' AND partida<>'00' AND subpartida<>'00'"
            subpartida_dtab.DefaultView.RowFilter = Nothing
            subpartida_dtab = dtab.DefaultView.ToTable()
        End If
    End Sub

    Private Sub DiagramarCuentas()
        SeleccionCuenta.Nodes.Clear()
        level = 0
        '7 levels
        'Fisrt one has to be completed manually
        For Each row As DataRow In anexo_dtab.Rows
            Dim tn As New TreeNode With {
            .Name = row("orden").ToString,
            .Text = row("nombre").ToString,
            .Tag = row("sumado").ToString}

            inciso_dtab.DefaultView.RowFilter = "anexo='" & row.Item("anexo").ToString & "'"
            RellenarCuentas(tn, inciso_dtab.DefaultView.ToTable())
            SeleccionCuenta.BeginUpdate()
            SeleccionCuenta.Nodes.Add(tn)
            SeleccionCuenta.EndUpdate()

        Next

        SeleccionCuenta.SelectedNode = SeleccionCuenta.Nodes(0)
        SeleccionCuenta.Focus()
    End Sub
    Private Function RellenarCuentas(raiz As TreeNode, origen As DataTable) As TreeNode
        level += 1
        For Each row As DataRow In origen.Rows

            Dim tn As New TreeNode With {
            .Name = row("orden").ToString,
            .Text = row("nombre").ToString,
            .Tag = row("sumado").ToString}

            If row("subpartida").ToString <> "00" Then
                'Needed to avoid loop
            ElseIf row("partida").ToString <> "00" Then
                subpartida_dtab.DefaultView.RowFilter = "anexo='" & row.Item("anexo").ToString & "' AND inciso='" & row.Item("inciso").ToString & "' AND item='" & row.Item("item").ToString &
                                                        "' AND rubro='" & row.Item("rubro").ToString & "' AND subrubro='" & row.Item("subrubro").ToString & "' AND partida='" & row.Item("partida").ToString & "'"
                RellenarCuentas(tn, subpartida_dtab.DefaultView.ToTable())

            ElseIf row("subrubro").ToString <> "00" Then
                partida_dtab.DefaultView.RowFilter = "anexo='" & row.Item("anexo").ToString & "' AND inciso='" & row.Item("inciso").ToString & "' AND item='" & row.Item("item").ToString &
                                                     "' AND rubro='" & row.Item("rubro").ToString & "' AND subrubro='" & row.Item("subrubro").ToString & "'"
                RellenarCuentas(tn, partida_dtab.DefaultView.ToTable())

            ElseIf row("rubro").ToString <> "00" Then
                subrubro_dtab.DefaultView.RowFilter = "anexo='" & row.Item("anexo").ToString & "' AND inciso='" & row.Item("inciso").ToString & "' AND item='" & row.Item("item").ToString &
                                                        "' AND rubro='" & row.Item("rubro").ToString & "'"
                RellenarCuentas(tn, subrubro_dtab.DefaultView.ToTable())

            ElseIf row("item").ToString <> "0" Then
                rubro_dtab.DefaultView.RowFilter = "anexo='" & row.Item("anexo").ToString & "' AND inciso='" & row.Item("inciso").ToString & "' AND item='" & row.Item("item").ToString & "'"
                RellenarCuentas(tn, rubro_dtab.DefaultView.ToTable())

            ElseIf row("inciso").ToString <> "0" Then
                item_dtab.DefaultView.RowFilter = "anexo='" & row.Item("anexo").ToString & "' AND inciso='" & row.Item("inciso").ToString & "'"
                RellenarCuentas(tn, item_dtab.DefaultView.ToTable())

            End If

            raiz.Nodes.Add(tn)
        Next

        Return raiz
    End Function


    Private Sub ValidarConsulta()
        If SeleccionCuenta.SelectedNode Is Nothing = False And Me.Visible Then
            visor = CtrlMan.DataGridViewTools.Load(visor, bs_consulta, ConsultarMovimientos(SeleccionCuenta.SelectedNode.Name, keyword_movimis.Text, ActivarFiltro.Checked,
                                                                        fecha.Checked, inicio.Value, final.Value))
            SumarTotales()
        End If
    End Sub

    Private Function ConsultarMovimientos(ByVal cuenta As Double, ByVal keyword As String,
                                          Filtrado As Boolean, FiltroFecha As Boolean,
                                          ByVal FechaInicio As Date, ByVal FechaFinal As Date) As DataTable
        Dim sql(3) As String

        sql(0) = "SELECT movimis.orden, movimis.fecha, movimis.documento, movimis.pagado, 
                         movimis.detalle, movimis.emite"
        sql(1) = " FROM movimis INNER JOIN hacienda ON movimis.orden=hacienda.orden"
        sql(2) = " WHERE movimis.orden=" & cuenta
        sql(3) = "ORDER BY movimis.documento"

        If Filtrado Then
            If FiltroFecha Then
                sql(2) += " AND movimis.fecha => {" & FechaInicio.ToString("MM/dd/yyyy") & "}
                                 AND movimis.fecha <= {" & FechaFinal.ToString("MM/dd/yyyy") & "}"
                sql(3) = "ORDER BY movimis.fecha"
            ElseIf Len(keyword) > 2 Then
                sql(2) += " AND movimis.detalle LIKE '%" & keyword & "%'"
                sql(3) = "ORDER BY movimis.detalle"
            End If
        End If


        Return DbMan.ReadDB(sql, My.Settings.foxConnection)
    End Function
    Private Sub SumarTotales()
        Dim sql(4) As String
        Dim orden As String = SeleccionCuenta.SelectedNode.Name
        '812345678901 | 8 part | 1 anexo | 2 inciso | 3 item | 45 rubro | 67 subrubro | 89 partida | 01 subpartida
        Dim anexo, inciso, item, rubro, subrubro, partida, mes As Integer
        Dim total_autorizado, total_ingresado, total_gastado, proyectado, porcentaje, porcentaje_proyectado As Decimal
        anexo = Mid(orden, 2, 1)
        inciso = Mid(orden, 3, 1)
        item = Mid(orden, 4, 1)
        rubro = Mid(orden, 5, 2)
        subrubro = Mid(orden, 7, 2)
        partida = Mid(orden, 9, 2)

        Dim sumado As Boolean = (CInt(SeleccionCuenta.SelectedNode.Tag) = 2)
        info.Text = " - "
        info2.Text = " - "

        If sumado Then
            If Ingresos.Checked Then
                sql(0) = "SELECT orden, fecha, autorizado as total_autorizado, sumatodo as total_ingresado,  (sumatodo/autorizado) as porcentaje"
                sql(1) = "FROM ingresos"
            Else
                sql(0) = "SELECT orden, fecha, autorizado as total_autorizado, gastado as total_gastado, (gastado/autorizado) as porcentaje"
                sql(1) = "FROM egresos"
            End If
            sql(2) = "WHERE orden=" & orden
        Else
            sql(0) = "SELECT sumado, pertenece, anexo, fecha"
            sql(2) = "" 'WHERE
            sql(3) = "GROUP BY sumado, pertenece, anexo, fecha"

            If inciso > 0 Then
                sql(0) += ", inciso"
                sql(3) += ", inciso"
                sql(4) += " AND inciso='" & inciso & "'"
                If item > 0 Then
                    sql(0) += ", item"
                    sql(3) += ", item"
                    sql(4) += " AND item='" & item & "'"
                    If rubro > 0 Then
                        sql(0) += ", rubro"
                        sql(3) += ", rubro"
                        sql(4) += " AND rubro='" & rubro & "'"
                        If subrubro > 0 Then
                            sql(0) += ", subrubro"
                            sql(3) += ", subrubro"
                            sql(4) += " AND subrubro='" & subrubro & "'"
                            If partida > 0 Then
                                sql(0) += ", partida"
                                sql(3) += ", partida"
                                sql(4) += " AND partida='" & partida & "'"
                            End If
                        End If
                    End If
                End If
            End If

            If Ingresos.Checked Then
                sql(0) += ", SUM(autorizado) as total_autorizado, SUM(sumatodo) as total_ingresado,
                           (SUM(sumatodo)/SUM(autorizado)) as porcentaje"
                sql(1) = "FROM ingresos"
                sql(4) = "HAVING sumado=2 AND pertenece='8' AND anexo='" & anexo & "'"
            Else
                sql(0) += ", SUM(autorizado) as total_autorizado, SUM(gastado) as total_gastado,
                          (SUM(gastado)/SUM(autorizado)) as porcentaje"
                sql(1) = "FROM egresos"
                sql(4) = "HAVING sumado=2 AND pertenece='9' AND anexo='" & anexo & "'"
            End If
        End If

        Dim dtab As DataTable = DbMan.ReadDB(sql, My.Settings.foxConnection)

        If dtab Is Nothing = False Then
            If dtab.Rows.Count > 0 Then

                total_autorizado = dtab.Rows(0)("total_autorizado")
                porcentaje = dtab.Rows(0)("porcentaje")
                mes = Month(dtab.Rows(0)("fecha"))

                info.Text = "AUTORIZADO: " & FormatCurrency(total_autorizado, 2)

                If Ingresos.Checked Then
                    total_ingresado = dtab.Rows(0)("total_ingresado")
                    proyectado = (total_ingresado / mes) * 12
                    porcentaje_proyectado = proyectado / total_autorizado

                    info2.Text = "INGRESADO: " & FormatCurrency(total_ingresado, 2) &
                                   " [" & FormatPercent(porcentaje) & "]"
                    If porcentaje > 1 Then
                        info2.ForeColor = Color.Green
                    Else
                        info2.ForeColor = Color.Red
                    End If

                    info3.Text = "PROYECTADO: " & FormatCurrency(proyectado, 2) &
                                 " [" & FormatPercent(porcentaje_proyectado) & "]"
                    If porcentaje_proyectado > 1 Then
                        info3.ForeColor = Color.Green
                    Else
                        info3.ForeColor = Color.Red
                    End If

                Else
                    total_gastado = dtab.Rows(0)("total_gastado")
                    proyectado = (total_gastado / mes) * 12
                    porcentaje_proyectado = proyectado / total_autorizado

                    info2.Text = "GASTADO: " & FormatCurrency(total_gastado, 2) &
                                      " [" & FormatPercent(porcentaje) & "]"

                    If porcentaje > 1 Then
                        info2.ForeColor = Color.Red
                    Else
                        info2.ForeColor = Color.Green
                    End If

                    info3.Text = "PROYECTADO: " & FormatCurrency(proyectado, 2) &
                                " [" & FormatPercent(porcentaje_proyectado) & "]"
                    If porcentaje_proyectado > 1 Then
                        info3.ForeColor = Color.Red
                    Else
                        info3.ForeColor = Color.Green
                    End If
                End If
            End If
        End If


    End Sub


End Class

