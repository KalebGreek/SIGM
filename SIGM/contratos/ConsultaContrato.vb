Imports Microsoft.Reporting.WinForms
Public Class ConsultaContrato
    ReadOnly SelectSQL As String = "SELECT contrato.id AS contrato_id, contrato.codigo, 
                                           persona0.id AS persona_id, persona0.razon, persona0.cuil,
                                           per_domicilio.calle, per_domicilio.altura, localidades.nombre as localidad,
                                           contrato.inicio, contrato.dias, contrato.monto, contrato.descripcion, 
                                           contrato.autoridad1_id, persona1.razon AS autoridad1, persona1.cuil AS aut1cuil, empleado1.jerarquia AS aut1cargo, 
                                           contrato.autoridad2_id, persona2.razon AS autoridad2, persona2.cuil AS aut2cuil, empleado2.jerarquia AS aut2cargo,
                                           contrato.seccion, contrato.user_id"
    ReadOnly TableSQL As String = "FROM provincias INNER JOIN ((persona AS persona2 INNER JOIN (persona AS persona1 
                                              INNER JOIN ((empleado AS empleado2 INNER JOIN (persona AS persona0 
                                              INNER JOIN (empleado AS empleado1 INNER JOIN contrato 
                                                      ON empleado1.Id = contrato.autoridad1_id) ON persona0.id = contrato.contratado_id) 
                                                      ON empleado2.Id = contrato.autoridad2_id) INNER JOIN per_domicilio 
                                                      ON persona0.id = per_domicilio.per_id) ON persona1.id = empleado1.persona_id) 
                                                      ON persona2.id = empleado2.persona_id) INNER JOIN localidades 
                                                      ON per_domicilio.localidad_id = localidades.id) ON provincias.id = localidades.provincia_id"
    ReadOnly WhereSQL As String = "WHERE per_domicilio.principal=True"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GenSearchControl1.BackColor = My.Settings.CurrentMenuColor
        GenSearchControl1.vista.Items.AddRange(New Object() {"HACIENDA", "DEPORTES", "OBRAS PUBLICAS", "TRANSITO", "TURISMO"})
    End Sub

    Shared Sub Consultar() Handles GenSearchControl1.CSearchClick
        'bs_contrato.Filter = GenSearchControl1.bsCustomFilter
    End Sub

    '-- EVENTOS UNICOS
    Private Sub vista_SelectedIndexChanged() Handles GenSearchControl1.CVistaIndexTextChanged
        resultado.Visible = False
        With GenSearchControl1
            If .vista.SelectedIndex > -1 Then
                BuscarContrato()
            Else
                .reset_search.PerformClick()
            End If
        End With
    End Sub
    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, resultado.KeyUp, GenSearchControl1.KeyUp
        If e.KeyValue = Keys.Enter And sender Is GenSearchControl1 Then
            GenSearchControl1.search.PerformClick()
        ElseIf e.KeyValue = Keys.Delete Then
            If bs_contrato.Count > 0 Then
                If bs_contrato.Position > -1 Then
                    If DbMan.EditDB("DELETE * FROM contrato WHERE id=" & bs_contrato.Current("contrato_id").ToString, My.Settings.CurrentDB) Then
                        bs_contrato.RemoveCurrent()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub nuevoCont_Click(sender As Object, e As EventArgs) Handles nuevoCont.Click
        Using modcont1 As New ModContrato
            modcont1.ShowDialog(Me)
        End Using
        BuscarContrato()
    End Sub

    'RUTINAS
    Private Sub BuscarContrato()
        With GenSearchControl1
            .filtro.DataSource = Nothing
            If .vista.Text <> "" Then
                bs_contrato.DataSource = DbMan.ReadDB(SelectSQL & TableSQL & WhereSQL & " AND seccion='" & .vista.Text & "'",
                                                      My.Settings.CurrentDB)
            End If

            If bs_contrato.Count > 0 Then
                Dim bs_ColumnList As New BindingSource _
                With {.DataSource = CtrlMan.Fill.GetColumnList(bs_contrato.DataSource.Columns)}
                CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")

                resultado.Visible = True
                CtrlMan.DataGridViewTools.Load(resultado, bs_contrato, .bsCustomFilter)
            End If
        End With
    End Sub

    Private Sub printCont_Click(sender As Object, e As EventArgs) Handles printCont.Click
        With bs_contrato
            If bs_contrato.Position > -1 And GenSearchControl1.vista.SelectedIndex > -1 Then
                Dim parametros As New Generic.List(Of ReportParameter)
                Dim masculino As Boolean = .Current("cuil") < 27000000000
                Dim dni0, dni1, dni2 As String
                dni0 = Mid(.Current("cuil"), 3, 8)
                dni1 = Mid(.Current("aut1cuil"), 3, 8)
                dni2 = Mid(.Current("aut2cuil"), 3, 8)

                parametros = ParametrosReporte.Contrato.DetalleContrato(parametros, .Current("inicio"),
                                                                   .Current("autoridad1"), dni1, .Current("aut1cargo"),
                                                                   .Current("autoridad2"), dni2, .Current("aut2cargo"),
                                                                   masculino, .Current("razon"), dni0,
                                                                   .Current("calle"), .Current("altura"), .Current("localidad"),
                                                                   .Current("descripcion"), .Current("monto"), .Current("dias"),
                                                                   .Current("codigo"), .Current("seccion"))

                Dim titulo_reporte As String = "Contrato N° " & CDate(.Current("inicio")).Year & "-" & .Current("codigo") & " - " & .Current("seccion")
                Dim ruta_acceso As String = "REPORTES\Hacienda\ModeloContrato"
                Using certificado As New Formularios(titulo_reporte)
                    certificado.mostrar(ruta_acceso, parametros)
                    certificado.ShowDialog()
                End Using
            End If
        End With
    End Sub
End Class