Public Class BusquedaPropietario
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Setting up views
        genSearchControl1.vista.Items.AddRange(New Object() {"PROPIETARIO"})
        genSearchControl1.selectRow.Visible = True
        genSearchControl1.cancel.Visible = True
    End Sub
    '-- RUTINAS
    Sub Consultar() Handles genSearchControl1.CSearch_Click, genSearchControl1.CFiltro_IndexTextChanged
        genSearchControl1.FilterSearch()
        bs_resultado.Filter = genSearchControl1.bsCustomFilter
    End Sub

    '-- EVENTOS UNICOS
    Public Sub Select_Click(sender As Object, e As EventArgs) Handles genSearchControl1.CSelect
        If bs_resultado.Position > -1 Then
            Me.Close()
        Else
            MsgBox("No se ha seleccionado una persona.")
        End If
    End Sub
    Public Sub Cancel_Click(sender As Object, e As EventArgs) Handles genSearchControl1.CCancel
        resultado.DataSource = Nothing
        bs_resultado.Sort = ""
        bs_resultado.Filter = ""
        bs_resultado.DataSource = Nothing
        Me.Close()
    End Sub

    Private Sub vista_SelectedIndexChanged() Handles genSearchControl1.CVista_IndexTextChanged

        With genSearchControl1
            If .vista.SelectedIndex > -1 Then
                .filtro.DataSource = Nothing
                If .vista.Text = "PROPIETARIO" Then
                    Dim sql(0) As String
                    sql(0) = "SELECT * FROM catastro"
                    Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
                    If dtab Is Nothing = False Then
                        bs_resultado = New BindingSource
                        bs_resultado.DataSource = dtab
                        CtrlMan.DataGridViewTools.Load(resultado, bs_resultado)
                        Dim bs_ColumnList As New BindingSource _
                            With {.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado)}
                        .filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                        Consultar()
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

End Class