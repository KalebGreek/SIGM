Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class ConsultaContrato
    ReadOnly SelectSQL As String = "SELECT contrato.id AS contrato_id, contrato.codigo, 
                                           persona0.id AS persona_id, persona0.razon, persona0.cuil,
                                           per_domicilio.calle, per_domicilio.altura, localidades.nombre as localidad,
                                           contrato.inicio, contrato.dias, contrato.monto, contrato.descripcion, 
                                           contrato.autoridad1_id, persona1.razon AS autoridad1, persona1.cuil AS aut1cuil, empleado1.jerarquia AS aut1cargo, 
                                           contrato.autoridad2_id, persona2.razon AS autoridad2, persona2.cuil AS aut2cuil, empleado2.jerarquia AS aut2cargo,
                                           contrato.seccion, contrato.user_id"
    ReadOnly TableSQL As String = " FROM provincias INNER JOIN ((persona AS persona2 INNER JOIN (persona AS persona1 
                                              INNER JOIN ((empleado AS empleado2 INNER JOIN (persona AS persona0 
                                              INNER JOIN (empleado AS empleado1 INNER JOIN contrato 
                                                      ON empleado1.Id = contrato.autoridad1_id) ON persona0.id = contrato.contratado_id) 
                                                      ON empleado2.Id = contrato.autoridad2_id) INNER JOIN per_domicilio 
                                                      ON persona0.id = per_domicilio.per_id) ON persona1.id = empleado1.persona_id) 
                                                      ON persona2.id = empleado2.persona_id) INNER JOIN localidades 
                                                      ON per_domicilio.localidad_id = localidades.id) ON provincias.id = localidades.provincia_id"
    ReadOnly WhereSQL As String = " WHERE per_domicilio.principal=True"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GenSearchControl1.BackColor = My.Settings.CurrentMenuColor
        GenSearchControl1.vista.Items.AddRange(New Object() {"HACIENDA", "DEPORTES", "OBRAS PUBLICAS", "TRANSITO", "TURISMO"})
    End Sub
    Private Sub ConsultaContrato_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim ParentForm As Form = Nothing
        If Me.Owner Is Nothing = False Then
            ParentForm = Me.Owner
        ElseIf Me.Parent Is Nothing = False Then
            ParentForm = Me.Parent
        ElseIf Me.MdiParent Is Nothing Then
            ParentForm = Me.MdiParent
        End If
        If ParentForm Is Nothing = False Then
            ParentForm.Show()
            ParentForm.Focus()
        End If
    End Sub

    '-- EVENTOS UNICOS
    Private Sub Vista_SelectedIndexChanged() Handles GenSearchControl1.CVistaIndexTextChanged
        With GenSearchControl1
            If .vista.SelectedIndex > -1 Then
                BuscarContrato()
            Else
                .reset_search.PerformClick()
                resultado.DataSource = Nothing
            End If
        End With
    End Sub
    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles resultado.KeyUp, GenSearchControl1.KeyUp
        If e.KeyValue = Keys.Enter And sender Is GenSearchControl1 Then
            GenSearchControl1.search.PerformClick()
        ElseIf e.KeyValue = Keys.Delete And sender Is resultado Then
            Dim source As DataRowView = bs_contrato.Current
            If source Is Nothing = False And
               MsgBox("Desea borrar este contrato?", MsgBoxStyle.YesNo, "Eliminar Contrato") = MsgBoxResult.Yes And
               DbMan.EditDB("DELETE * FROM contrato WHERE id=" & CInt(source("contrato_id")), My.Settings.CurrentDB) Then
                GenSearchControl1.search.PerformClick()
            End If
        End If

    End Sub

    Private Sub NuevoCont_Click(sender As Object, e As EventArgs) Handles nuevoCont.Click
        Using modcont1 As New ModContrato
            modcont1.ShowDialog(Me)
        End Using
        BuscarContrato()
    End Sub

    Private Sub SearchClick() Handles GenSearchControl1.CSearchClick, GenSearchControl1.CFiltroIndexTextChanged
        If bs_contrato Is Nothing = False Then
            GenSearchControl1.FilterSearch()
            bs_contrato.Filter = GenSearchControl1.bsCustomFilter
        Else
            BuscarContrato()
        End If
    End Sub



    'RUTINAS
    Private Sub BuscarContrato()
        Dim dtab As New DataTable
        With GenSearchControl1
            .filtro.DataSource = Nothing
            If .vista.Text <> "" Then
                dtab = DbMan.ReadDB(SelectSQL & TableSQL & WhereSQL & " AND seccion='" & .vista.Text & "'",
                                                      My.Settings.CurrentDB)
            End If
            If dtab.Rows.Count > 0 Then
                bs_contrato.DataSource = dtab
                Dim bs_ColumnList As New BindingSource _
                    With {.DataSource = CtrlMan.Fill.GetColumnList(dtab.Columns)}
                CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                CtrlMan.DataGridViewTools.Load(resultado, bs_contrato, .bsCustomFilter)
            Else
                resultado.DataSource = Nothing
            End If
        End With
    End Sub

    Private Sub PrintCont_Click(sender As Object, e As EventArgs) Handles printCont.Click
        Dim source As DataRowView = bs_contrato.Current

        If source Is Nothing = False And GenSearchControl1.vista.SelectedIndex > -1 Then
            Dim parametros As New Generic.List(Of ReportParameter)
            Dim masculino As Boolean = CDbl(source("cuil")) < 27000000000
            Dim dni0, dni1, dni2 As String
            dni0 = Mid(source("cuil"), 3, 8)
            dni1 = Mid(source("aut1cuil"), 3, 8)
            dni2 = Mid(source("aut2cuil"), 3, 8)

            parametros = ParametrosReporte.Contrato.DetalleContrato(parametros, source("inicio"),
                                                               source("autoridad1"), dni1, source("aut1cargo"),
                                                               source("autoridad2"), dni2, source("aut2cargo"),
                                                               masculino, source("razon"), dni0,
                                                               source("calle"), source("altura"), source("localidad"),
                                                               source("descripcion"), source("monto"), source("dias"),
                                                               source("codigo"), source("seccion"))

            Dim titulo_reporte As String = "Contrato N° " & CDate(source("inicio")).Year & "-" & source("codigo").ToString & " - " & source("seccion").ToString
            Dim ruta_acceso As String = "REPORTES\Hacienda\ModeloContrato"
            Using certificado As New Formularios(titulo_reporte) With {.Owner = Me}
                certificado.Mostrar(ruta_acceso, parametros)
                certificado.ShowDialog()
            End Using
        End If
    End Sub


End Class