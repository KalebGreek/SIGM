Public Class ConsultaMovimientos
	Private SQLSelect, SQLTable, SQLCriteria, SQLGrouping, SQLOrder As String

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
            bs_cuenta.RemoveFilter()
            bs_consulta.DataSource = Nothing
            bs_cuenta.DataSource = RellenarCuentas(Ingresos.Checked)
            SeleccionCuenta.DataSource = bs_cuenta
            SeleccionCuenta.DisplayMember = "nombre"
            bs_cuenta.Position = -1
        Else
            Call Ingresos_CheckedChanged(Ingresos, Nothing)
        End If
    End Sub

    Private Sub SeleccionCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SeleccionCuenta.SelectedIndexChanged, SeleccionCuenta.SelectedValueChanged
        progreso.Value = 0
        visor.DataSource = Nothing
        bs_consulta.DataSource = Nothing
        If SeleccionCuenta.SelectedIndex > -1 And Me.Visible Then
            visor = CtrlMan.DataGridViewTools.Load(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), keyword_movimis.Text, ActivarFiltro.Checked,
                                                                                          fecha.Checked, inicio.Value, final.Value))
            SumarTotales(bs_cuenta, Ingresos.Checked)
        End If

    End Sub

    Private Sub ActivarFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles ActivarFiltro.CheckedChanged
        GrupoFiltro.Visible = ActivarFiltro.Checked
        If SeleccionCuenta.SelectedIndex > -1 And Me.Visible Then
            visor = CtrlMan.DataGridViewTools.Load(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), keyword_movimis.Text, ActivarFiltro.Checked,
                                                                                          fecha.Checked, inicio.Value, final.Value))
            SumarTotales(bs_cuenta, Ingresos.Checked)
        End If
    End Sub
    Private Sub fecha_CheckedChanged(sender As Object, e As EventArgs) Handles fecha.CheckedChanged
        inicio.Enabled = fecha.Checked
        final.Enabled = fecha.Checked
        keyword_movimis.Enabled = concepto.Checked
        If SeleccionCuenta.SelectedIndex > -1 And Me.Visible Then
            visor = CtrlMan.DataGridViewTools.Load(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), keyword_movimis.Text, ActivarFiltro.Checked,
                                                                        fecha.Checked, inicio.Value, final.Value))
            SumarTotales(bs_cuenta, Ingresos.Checked)
        End If
    End Sub
    Private Sub Keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword_movimis.KeyUp
        If SeleccionCuenta.SelectedIndex > -1 And Me.Visible Then
            visor = CtrlMan.DataGridViewTools.Load(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), keyword_movimis.Text, ActivarFiltro.Checked,
                                                                                            fecha.Checked, inicio.Value, final.Value))

            SumarTotales(bs_cuenta, Ingresos.Checked)
        End If
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
        If SeleccionCuenta.SelectedIndex > -1 And Me.Visible Then
            visor = CtrlMan.DataGridViewTools.Load(visor, bs_consulta, "", ConsultarMovimientos(bs_cuenta.Current("orden"), keyword_movimis.Text, ActivarFiltro.Checked,
                                                                        fecha.Checked, inicio.Value, final.Value))
            SumarTotales(bs_cuenta, Ingresos.Checked)
        End If
    End Sub

    '### RUTINAS
    Private Function RellenarCuentas(ingresos As Boolean) As DataTable
        Dim dtab As New DataTable
        Dim sql(3) As String
        sql(0) = "SELECT orden, IIF(sumado=1,'* ','- ') + nombre AS nombre, sumado, 
                         pertenece, anexo, inciso, item, rubro, subrubro, partida, subpartida"

        sql(1) = " FROM hacienda"

        If ingresos Then
            sql(2) = "  WHERE pertenece='8'"
        Else
            sql(2) = "  WHERE orden>899999999999"
        End If

        sql(3) = " ORDER BY orden"

        dtab = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
        Return dtab
    End Function
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


        Return DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
    End Function
    Private Sub SumarTotales(cuentas As BindingSource, ingresos As Boolean)
        Dim sql(4) As String
        Dim orden As Double = cuentas.Current("orden")
        '812345678901 | 8 pert | 1 anexo | 2 inciso | 3 item | 45 rubro | 67 subrubro | 89 partida | 01 subpartida
        Dim anexo, inciso, item, rubro, subrubro, partida, mes As Integer
        Dim total_autorizado, total_ingresado, total_gastado, proyectado, porcentaje, porcentaje_proyectado As Decimal
        anexo = cuentas.Current("anexo")
        inciso = cuentas.Current("inciso")
        item = cuentas.Current("item")
        rubro = cuentas.Current("rubro")
        subrubro = cuentas.Current("subrubro")
        partida = cuentas.Current("partida")


        Dim sumado As Boolean = cuentas.Current("sumado") = 2
        info.Text = " - "
        info2.Text = " - "

        If sumado Then
            If ingresos Then
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

            If ingresos Then
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

        Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        If dtab Is Nothing = False Then
            If dtab.Rows.Count > 0 Then

                total_autorizado = dtab(0)("total_autorizado")
                porcentaje = dtab(0)("porcentaje")
                mes = Month(dtab(0)("fecha"))

                info.Text = "AUTORIZADO: " & FormatCurrency(total_autorizado, 2)

                If ingresos Then
                    total_ingresado = dtab(0)("total_ingresado")
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
                    total_gastado = dtab(0)("total_gastado")
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

