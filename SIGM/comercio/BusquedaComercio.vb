Imports Microsoft.Reporting.WinForms
Public Class BusquedaComercio

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Setting up views
        ControlBusqueda1.vista.Items.AddRange(New Object() {"COMERCIO SIN BAJA", "COMERCIO CON BAJA", "COMERCIO SIN ACTIVIDAD", "DEUDORES"})
    End Sub

    '-- RUTINAS
    Sub Consultar() Handles ControlBusqueda1.CSearchClick
        ControlBusqueda1.FilterSearch()
    End Sub
    Private Sub FilterResults() Handles ControlBusqueda1.CFilter
        'bs_resultado.Filter = ControlBusqueda1.bsCustomFilter
    End Sub


    '-- EVENTOS UNICOS
    Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVistaIndexTextChanged
        If ControlBusqueda1.vista.SelectedIndex > -1 Then
            Dim consulta As String = ControlBusqueda1.vista.Text
            Dim sqlSelect As String = ""
            Dim dtab As New DataTable
            Dim bs_ColumnList As New BindingSource
            ControlBusqueda1.filtro.DataSource = Nothing

            If consulta = "COMERCIO SIN BAJA" Then
                sqlSelect = " SELECT codigo, razon, fantasia, domicilio, inscripto, detalle as actividad"
                sqlSelect += " FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
                sqlSelect += " WHERE baja={}"

            ElseIf consulta = "COMERCIO CON BAJA" Then
                sqlSelect = " SELECT codigo, razon, fantasia, domicilio, baja, detalle as actividad"
                sqlSelect += " FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
                sqlSelect += " WHERE baja<>{}"

            ElseIf consulta = "COMERCIO SIN ACTIVIDAD" Then
                sqlSelect = " SELECT codigo, razon, fantasia, domicilio, comercio.actividad, comact.actividad"
                sqlSelect += " FROM comercio LEFT OUTER JOIN comact ON comercio.actividad=comact.actividad"
                sqlSelect += " WHERE comact.actividad IS NULL"

            ElseIf consulta = "DEUDORES" Then
                sqlSelect = " SELECT comercio.codigo, comercio.razon, inscripto, baja,
									 comact.detalle as actividad, SUM(comcue.importe) AS original"
                sqlSelect += " FROM comcue INNER JOIN comercio ON comcue.codigo=comercio.codigo 
									  LEFT OUTER JOIN comact ON comercio.actividad=comact.actividad"
                sqlSelect += " GROUP BY comercio.codigo, comercio.razon, comercio.inscripto, comercio.baja, comact.detalle"
                sqlSelect += " WHERE comcue.pago={}"

            End If
            With ControlBusqueda1
                dtab = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection, "dtab1")
                If dtab.Rows.Count > 0 Then
                    CtrlMan.DataGridViewTools.Load(resultado, bs_resultado, dtab)
                    bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(dtab.Columns)
                    .filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                End If
            End With
        Else
            ControlBusqueda1.reset_search.PerformClick()
        End If

    End Sub

    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles ControlBusqueda1.CKeywordKeyUp, resultado.KeyUp
        If e.KeyValue = Keys.Enter And sender Is ControlBusqueda1.keyword Then
            ControlBusqueda1.search.PerformClick()
        ElseIf sender Is resultado Then
            If e.KeyValue = Keys.F2 Then

            ElseIf e.KeyValue = Keys.Delete Then

            End If
        End If
    End Sub

    Private Sub PrintResult() Handles ControlBusqueda1.CPrint
        If bs_resultado.DataSource Is Nothing = False Then
            If bs_resultado.Count > 0 Then
                Dim dtab(0) As DataTable
                Dim parametros As New List(Of ReportParameter)

                dtab(0) = CtrlMan.BindingSourceListToDataTable(bs_resultado)
                parametros = ParametrosReporte.TableToReport(dtab(0), ControlBusqueda1.vista.Text, parametros)

                Using vr As New Formularios(ControlBusqueda1.vista.Text)
                    vr.mostrar("reportes\PrintTable", parametros, dtab)
                    vr.ShowDialog(Me)
                End Using
            End If
        End If

    End Sub
End Class