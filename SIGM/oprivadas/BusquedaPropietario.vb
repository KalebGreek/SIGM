Public Class BusquedaPropietario
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Setting up views
        genSearchControl1.vista.Items.AddRange(New Object() {"PROPIETARIO"})
    End Sub
    '-- RUTINAS
    Sub Consultar() Handles genSearchControl1.CSearch_Click
        bs_resultado.Filter = genSearchControl1.bsCustomFilter
    End Sub

    '-- EVENTOS UNICOS
    Private Sub vista_SelectedIndexChanged() Handles genSearchControl1.CVista_IndexTextChanged
        With genSearchControl1
            If .vista.SelectedIndex > -1 Then
                .filtro.DataSource = Nothing
                If .vista.Text = "PROPIETARIO" Then
                    Dim sql(0) As String
                    sql(0) = "SELECT * FROM catastro"
                    Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
                    If dtab Is Nothing = False Then
                        bs_resultado.Filter = ""
                        bs_resultado.Sort = ""
                        bs_resultado.Position = -1
                        bs_resultado.DataSource = dtab
                        CtrlMan.DataGridViewTools.Load(resultado, bs_resultado)
                        Dim bs_ColumnList As New BindingSource
                        bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado)
                        .filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                        .filtro.Text = "razon"
                    Else
                        bs_resultado = Nothing
                    End If
                End If
            Else
                .reset_search.PerformClick()
            End If
        End With
    End Sub

    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles genSearchControl1.CKeyword_KeyUp, resultado.KeyUp
        If e.KeyValue = Keys.Enter And sender Is genSearchControl1.keyword Then
            genSearchControl1.search.PerformClick()
        ElseIf sender Is resultado Then
            If e.KeyValue = Keys.F2 Then

            ElseIf e.KeyValue = Keys.Delete Then

            End If
        End If
    End Sub

    Private Sub Me_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If genSearchControl1.RowSelected = False Then
            bs_resultado.DataSource = Nothing
        End If
    End Sub

End Class