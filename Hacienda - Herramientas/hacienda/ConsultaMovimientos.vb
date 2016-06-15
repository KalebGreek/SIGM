Public Class ConsultaMovimientos
    Private SQLSelect, SQLTable, SQLCriteria, SQLGrouping As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        bs_cuenta.DataSource = bd.read(foxcon, "SELECT nombre, orden FROM hacienda WHERE orden<9000000000000")
        SeleccionCuenta.DataSource = bs_cuenta
        SeleccionCuenta.DisplayMember = "nombre"
        If bs_cuenta.Current("orden") > 0 Then
            ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text)
        End If
    End Sub
    '###### GUI #############################################################################################
    Private Sub et_con_imp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles et_con_imp.DoubleClick
        If grupo_imp.Width = 100 Then
            grupo_imp.Width = 289
        Else
            grupo_imp.Width = 100
        End If
        visor.Refresh()
    End Sub
    Private Sub ActivarFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles ActivarFiltro.CheckedChanged
        ActivarFiltro.Checked = SeleccionFiltro.Enabled
        ActivarFiltro.Checked = Keyword.Enabled
    End Sub
    Private Sub Ingresos_CheckedChanged(sender As Object, e As EventArgs) Handles Ingresos.CheckedChanged
        If Ingresos.Checked Then
            bs_cuenta.DataSource = bd.read(foxcon, "SELECT nombre, orden FROM hacienda WHERE orden<9000000000000")
        Else
            bs_cuenta.DataSource = bd.read(foxcon, "SELECT nombre, orden FROM hacienda WHERE orden>8999999999999")
        End If
        SeleccionCuenta.DataSource = bs_cuenta
        SeleccionCuenta.DisplayMember = "nombre"
    End Sub
    '###### FIN GUI #############################################################################################
    '------------------------------------------------------------------------------------------------------------
    '#### FILTROS MANUALES ################################
    Private Sub bs_consulta_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_consulta.CurrentChanged
        With bs_consulta
            If .Position >= 0 Then

            End If
            info.Text = ""
            info2.Text = ""
        End With
    End Sub
    Private Sub ConsultarMovimientos(ByVal cuenta As Double, ByVal keyword As String)
        progreso.Value = 0
        visor.DataSource = Nothing
        bs_consulta.DataSource = Nothing
        '### IMPUESTOS
        sel_sql = "SELECT * FROM movimis INNER JOIN hacienda on movimis.orden=hacienda.orden" &
                " WHERE orden=" & cuenta & " AND movimis.nombre LIKE '" & keyword & "'"
        visor = Query.Show(visor, bs_consulta, bd.read(foxcon, sel_sql))
        '### CUENTA AGRUPADA
        visor.Focus()
    End Sub
    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click
        If SeleccionCuenta.SelectedIndex > -1 Then
            ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text)
        End If
    End Sub

    '### EVENTOS DE LISTAS
    Private Sub SeleccionCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SeleccionCuenta.SelectedIndexChanged
        If SeleccionCuenta.SelectedIndex > -1 Then
            ConsultarMovimientos(bs_cuenta.Current("orden"), Keyword.Text)
        End If
    End Sub

    '###### END FILTER ##########################################################################################

    '###### PRINT ###############################################################################################

    '###### END PRINT ###########################################################################################

    Private Sub IngresosMovToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SQLSelect = "SELECT hacienda.nombre, movimis.orden, SUM(movimientos.pagado) as ingreso"
        SQLTable = " FROM movimientos INNER JOIN hacienda ON movimientos.orden=hacienda.orden"
        SQLCriteria = " WHERE orden < 900000000000"
        SQLGrouping = " GROUP BY movimis.orden"

        bd.read(foxcon, SQLSelect & SQLTable & SQLCriteria & SQLGrouping)
    End Sub
    Private Sub EgresosMovToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SQLSelect = "SELECT hacienda.nombre, movimis.orden, SUM(movimientos.pagado) as egreso"
        SQLTable = " FROM movimientos INNER JOIN hacienda On movimientos.orden=hacienda.orden"
        SQLCriteria = " WHERE orden > 899999999999"
        SQLGrouping = " GROUP BY movimis.orden"

        bd.read(foxcon, SQLSelect & SQLTable & SQLCriteria & SQLGrouping)
    End Sub


End Class

