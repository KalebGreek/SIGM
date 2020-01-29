Imports Microsoft.Reporting.WinForms
Public Class BusquedaComercio

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Setting up views
        ControlBusqueda1.vista.Items.AddRange(New Object() {"COMERCIO SIN BAJA", "COMERCIO CON BAJA", "DEUDORES"})
    End Sub
    '-- RUTINAS
    Sub Consultar() Handles ControlBusqueda1.CSearch_Click
        ControlBusqueda1.FilterSearch()
    End Sub
    Private Sub FilterResults() Handles ControlBusqueda1.CFilter
        bs_resultado.Filter = ControlBusqueda1.bsCustomFilter
    End Sub


    '-- EVENTOS UNICOS
    Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVista_IndexTextChanged
        Dim OleDBCmd As New OleDb.OleDbCommand With
        {.CommandType = CommandType.Text,
         .CommandText = ""}
        With ControlBusqueda1
            If .vista.SelectedIndex > -1 Then
                Dim dtab As New DataTable
                Dim bs_ColumnList As New BindingSource
                .filtro.DataSource = Nothing

                If .vista.Text = "COMERCIO SIN BAJA" Then
                    OleDBCmd.CommandText = " SELECT codigo, razon, fantasia, domicilio, DTOC(inscripto) as inscripto, detalle as actividad"
                    OleDBCmd.CommandText += " FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
                    OleDBCmd.CommandText += " WHERE baja={}"

                    dtab = DbMan.ReadDB(OleDBCmd, My.Settings.foxConnection, , "dtab1")

                ElseIf .vista.Text = "COMERCIO CON BAJA" Then
                    OleDBCmd.CommandText = " SELECT codigo, razon, fantasia, domicilio, DTOC(baja) as baja, detalle as actividad"
                    OleDBCmd.CommandText += " FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
                    OleDBCmd.CommandText += " WHERE baja<>{}"

                    dtab = DbMan.ReadDB(OleDBCmd, My.Settings.foxConnection, , "dtab1")

                ElseIf .vista.Text = "DEUDORES" Then
                    OleDBCmd.CommandText = " SELECT comercio.codigo, comercio.razon, 
											 comact.detalle as actividad, SUM(comcue.importe) AS original, 
											 SUM(ROUND((comcue.importe * ((DATE() - comcue.vence1) * 0.1315)), 2)) AS mora, 
											 SUM(comcue.importe) + 
											 SUM(ROUND((comcue.importe * ((DATE() - comcue.vence1) * 0.1315)), 2)) AS deuda"
                    OleDBCmd.CommandText += " FROM comcue INNER JOIN comercio ON comcue.codigo=comercio.codigo 
														  INNER JOIN comact ON comercio.actividad=comact.actividad"
                    OleDBCmd.CommandText += " GROUP BY comercio.codigo, comercio.razon, comercio.fantasia, comercio.domicilio,
													   comact.detalle"
                    OleDBCmd.CommandText += " WHERE comcue.pago={}"

                    dtab = DbMan.ReadDB(OleDBCmd, My.Settings.foxConnection, , "dtab1")

                End If

                If dtab.Rows.Count > 0 Then
                    CtrlMan.DataGridViewTools.Load(resultado, bs_resultado, "", dtab)
                    bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado)
                    .filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                End If
            Else
                .reset_search.PerformClick()
            End If
        End With
    End Sub

    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles ControlBusqueda1.CKeyword_KeyUp, resultado.KeyUp
        If e.KeyValue = Keys.Enter And sender Is ControlBusqueda1.keyword Then
            ControlBusqueda1.search.PerformClick()
        ElseIf sender Is resultado Then
            If e.KeyValue = Keys.F2 Then

            ElseIf e.KeyValue = Keys.Delete Then

            End If
        End If
    End Sub

    Private Sub Imprimir() Handles ControlBusqueda1.CPrint
        If bs_resultado.DataSource Is Nothing = False Then
            If bs_resultado.Count > 0 Then
                Dim parametros As New List(Of ReportParameter)
                Dim dtab(0) As DataTable

                dtab(0) = CtrlMan.BindingSourceListToDataTable(bs_resultado)
                parametros = ParametrosReporte.TableToReport(dtab(0), ControlBusqueda1.vista.Text, parametros)

                Dim vr As New VisorReporte(ControlBusqueda1.vista.Text)
                vr.mostrar("reportes\PrintTable", parametros, dtab)
                vr.ShowDialog(Me)
                vr.Dispose()
            End If
        End If

    End Sub
End Class