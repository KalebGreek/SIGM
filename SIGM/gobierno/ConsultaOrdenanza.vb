Public Class ConsultaOrdenanza
    Dim bs_resultado As New BindingSource
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        GenSearchControl1.vista.Items.AddRange(New Object() {"ORDENANZA"})
        GenSearchControl1.print.Visible = False
    End Sub

    '-- EVENTOS UNICOS
    Private Sub ConsultaOrdenanza_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        GenSearchControl1.vista.SelectedIndex = 0
    End Sub
    Private Sub Vista_SelectedIndexChanged() Handles GenSearchControl1.CVistaIndexTextChanged
        BuscarOrdenanza()
    End Sub

    Private Sub Search() Handles GenSearchControl1.CSearchClick
        GenSearchControl1.FilterSearch()
    End Sub
    Private Sub FilterResults() Handles GenSearchControl1.CFilter
        If bs_resultado Is Nothing = False Then
            bs_resultado.Filter = GenSearchControl1.bsCustomFilter
        End If
    End Sub

    Private Sub ResetSearch() Handles GenSearchControl1.CResetClick
        GenSearchControl1.vista.SelectedIndex = 0
    End Sub

    Public Sub BuscarOrdenanza()
        With GenSearchControl1
            If Me.Visible And .vista.Text <> "" Then
                .filtro.DataSource = Nothing
                If .vista.Text = "ORDENANZA" Then
                    Dim dtab As DataTable = Ordenanza.Listar()
                    If dtab.Rows.Count > 0 Then
                        bs_resultado.DataSource = dtab
                        Dim bs_ColumnList As New BindingSource _
                        With {.DataSource = CtrlMan.Fill.GetColumnList(dtab.Columns)}
                        CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                        CtrlMan.DataGridViewTools.Load(resultado, bs_resultado, .bsCustomFilter)
                        GenSearchControl1.FilterSearch()
                        GenSearchControl1.filtro.SelectedIndex = 3 'Concepto
                    Else
                        resultado.DataSource = Nothing
                    End If
                Else
                    GenSearchControl1.reset_search.PerformClick()
                End If
            End If
        End With
    End Sub

    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles GenSearchControl1.CKeywordKeyUp, resultado.KeyUp
        If e.KeyValue = Keys.Enter And sender Is GenSearchControl1.keyword Then
            GenSearchControl1.search.PerformClick()
        ElseIf sender Is resultado Then
            If e.KeyValue = Keys.Enter Then
                ver.PerformClick()
            ElseIf e.KeyValue = Keys.F2 Then
                modificar.PerformClick()
            ElseIf e.KeyValue = Keys.Delete Then
                eliminar.PerformClick()
            End If
        End If
    End Sub

    Private Sub VerClick(sender As Object, e As EventArgs) Handles ver.Click
        Dim path As DataRowView = bs_resultado.Current
        If bs_resultado.Position > -1 Then
            Try
                Process.Start(root & My.Settings.DocFolderOrdenanza & path("ruta_copia").ToString)
            Catch ex As Exception
                MsgBox("No se encuentra el archivo.")
            End Try
        End If
    End Sub
    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        Dim source As DataRowView = bs_resultado.Current
        If source Is Nothing = False Then
            Using ModificarOrdenanza As New ModOrdenanza
                With ModificarOrdenanza
                    .bs_registro = bs_resultado
                    .ShowDialog()
                    .Dispose()
                End With
            End Using
            BuscarOrdenanza()
        End If
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim source As DataRowView = bs_resultado.Current
        If source Is Nothing = False Then
            If MsgBoxResult.Yes = MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.YesNo, "Eliminar registro") Then
                DbMan.EditDB("DELETE * FROM ordenanza WHERE id=" & CInt(source("id")), My.Settings.CurrentDB)
                BuscarOrdenanza()
            End If
        End If
    End Sub


End Class