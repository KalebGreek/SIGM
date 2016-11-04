Public Class ConsultaMovimientos
    Private SQLSelect, SQLTable, SQLCriteria, SQLGrouping As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        bs_cuenta.DataSource = RellenarCuentas(Ingresos.Checked)
        SeleccionCuenta.DataSource = bs_cuenta
        SeleccionCuenta.DisplayMember = "nombre"
    End Sub
    '###### GUI #############################################################################################

    '###### FIN GUI #############################################################################################

    '### EVENTOS  
    Private Sub Ingresos_CheckedChanged(sender As Object, e As EventArgs) Handles Ingresos.CheckedChanged, Egresos.CheckedChanged
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
            visor = Data.ToDataGridView(visor, bs_consulta, ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
                                                                        fecha.Checked, inicio.Value, final.Value))
            SumarTotales(Ingresos.Checked)
        End If

    End Sub

    Private Sub ActivarFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles ActivarFiltro.CheckedChanged
        GrupoFiltro.Visible = ActivarFiltro.Checked
        If SeleccionCuenta.SelectedIndex > -1 Then
            visor = Data.ToDataGridView(visor, bs_consulta, ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
                                                                        fecha.Checked, inicio.Value, final.Value))
            SumarTotales(Ingresos.Checked)
        End If
    End Sub
    Private Sub fecha_CheckedChanged(sender As Object, e As EventArgs) Handles fecha.CheckedChanged, Razon.CheckedChanged
        inicio.Enabled = fecha.Checked
        final.Enabled = fecha.Checked
        Keyword.Enabled = Razon.Checked
        If SeleccionCuenta.SelectedIndex > -1 Then
            visor = Data.ToDataGridView(visor, bs_consulta, ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
                                                                        fecha.Checked, inicio.Value, final.Value))
            SumarTotales(Ingresos.Checked)
        End If
    End Sub
    Private Sub Keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles Keyword.KeyUp
        If SeleccionCuenta.SelectedIndex > -1 Then
            visor = Data.ToDataGridView(visor, bs_consulta, ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
                                                                        fecha.Checked, inicio.Value, final.Value))
            SumarTotales(Ingresos.Checked)
        End If
    End Sub
    Private Sub inicio_ValueChanged(sender As Object, e As EventArgs) Handles inicio.ValueChanged, final.ValueChanged
        inicio.MaxDate = final.Value
        final.MinDate = inicio.Value
        If SeleccionCuenta.SelectedIndex > -1 Then
            visor = Data.ToDataGridView(visor, bs_consulta, ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text, ActivarFiltro.Checked,
                                                                        fecha.Checked, inicio.Value, final.Value))
            SumarTotales(Ingresos.Checked)
        End If
    End Sub

    '### RUTINAS
    Private Function RellenarCuentas(ingresos As Boolean) As DataTable
        Dim dtab As New DataTable
        SQLSelect = "SELECT nombre, orden"
        SQLTable = " FROM hacienda"
        If ingresos Then
            SQLCriteria = "  WHERE orden<900000000000 AND sumado=2"
        Else
            SQLCriteria = "  WHERE orden>899999999999 AND sumado=2"
        End If
        SQLGrouping = ""

        Return bd.read(my.settings.foxcon, SQLSelect & SQLTable & SQLCriteria & SQLGrouping)
    End Function
    Private Function ConsultarMovimientos(ByVal cuenta As Double, ByVal keyword As String,
                                          Filtrado As Boolean, FiltroFecha As Boolean,
                                          ByVal FechaInicio As Date, ByVal FechaFinal As Date) As DataTable
        SQLSelect = "SELECT *"
        SQLTable = " FROM movimis"
        SQLCriteria = " WHERE orden=" & cuenta
        If Filtrado Then
            If FiltroFecha Then
                SQLCriteria += " AND fecha => {" & FechaInicio.ToString("MM/dd/yyyy") & "}
                                 AND fecha <= {" & FechaFinal.ToString("MM/dd/yyyy") & "}"
            ElseIf Len(keyword) > 2 Then
                SQLCriteria += " AND detalle LIKE '%" & keyword & "%'"
            End If
        End If
        SQLGrouping = ""

        Return bd.read(my.settings.foxcon, SQLSelect & SQLTable & SQLCriteria & SQLGrouping)
    End Function
    Private Sub SumarTotales(ingreso As Boolean)
        Dim dtab As DataTable = bd.read(My.Settings.foxcon,
                                        "SELECT SUM(pagado) as total_pagado, orden" &
                                        SQLTable & SQLCriteria & " GROUP BY orden")
        info2.Text = " - "
        If dtab Is Nothing = False Then
            If dtab.Rows.Count > 0 Then
                info2.Text = " $ " & dtab(0)("total_pagado").ToString
            End If
        End If

        info.Text = "TOTAL EGRESOS:"
        If ingreso Then
            info.Text = "TOTAL INGRESOS:"
        End If
    End Sub

End Class

