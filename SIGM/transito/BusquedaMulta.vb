Public Class BusquedaMulta
    Private OleDBCmd As New OleDb.OleDbCommand
    Public Sub New()
        OleDBCmd.CommandType = CommandType.Text
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Setting up views
        GenSearchControl1.vista.Items.AddRange(New Object() {"DETALLE DE MULTA", "TOTAL POR VEHICULO"})
    End Sub

    '-- RUTINAS
    Sub Consultar()
        CtrlMan.DataGridViewTools.Load(resultado, bs_resultado, GenSearchControl1.bsCustomFilter)
    End Sub

    '-- EVENTOS UNICOS
    Private Sub vista_SelectedIndexChanged() Handles GenSearchControl1.CVista_IndexTextChanged
        OleDBCmd.CommandText = ""

        With GenSearchControl1
            CheckBox1.Enabled = .vista.SelectedIndex > -1
            If .vista.SelectedIndex > -1 Then
                Dim dtab As New DataTable
                Dim bs_ColumnList As New BindingSource
                .filtro.DataSource = Nothing

                'CUSTOM SEARCH SECTION
                If .vista.Text = "DETALLE DE MULTA" Then
                    OleDBCmd = Transito.Multas.BuscarMulta(CheckBox1.Checked)
                ElseIf .vista.Text = "TOTAL POR VEHICULO" Then
                    OleDBCmd = Transito.Multas.MultasPorVehiculo(CheckBox1.Checked)
                End If
                dtab = DbMan.ReadDB(OleDBCmd, My.Settings.CurrentDB)

                'COLUMN SECTION
                If dtab.Rows.Count > 0 Then
                    bs_resultado.Filter = ""
                    bs_resultado.Sort = ""
                    bs_resultado.Position = -1
                    bs_resultado.DataSource = dtab
                    CtrlMan.DataGridViewTools.Load(resultado, bs_resultado)
                    bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado)
                    .filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                    .filtro.SelectedIndex = 0

                End If
            Else
                .reset_search.PerformClick()
            End If
        End With
    End Sub

    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles resultado.KeyUp
        If e.KeyValue = Keys.Enter And sender Is GenSearchControl1.keyword Then
            GenSearchControl1.search.PerformClick()
        ElseIf sender Is resultado Then
            If bs_resultado.Position > -1 Then
                If e.KeyValue = Keys.F2 Then
                    Using modMulta1 As New ModMulta
                        modMulta1.boleta.Text = bs_resultado.Current("boleta")
                        modMulta1.ShowDialog(Me)
                    End Using
                ElseIf e.KeyValue = Keys.Delete Then
                    If MsgBoxResult.Yes = MsgBox("Desea eliminar la multa N° " & bs_resultado.Current("boleta") & "?",
                                                 "Eliminar Multa", MsgBoxStyle.YesNo) Then

                        Transito.Multas.Eliminar(bs_resultado.Current("historial_id"), bs_resultado.Current("vehiculo_id"))
                        bs_resultado.RemoveCurrent()
                    End If
                End If
            End If
        End If
    End Sub


End Class