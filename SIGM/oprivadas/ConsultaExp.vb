Public Class ConsultaExp
    Private Sub ConsultaPersona_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            'Setting up views
            ControlBusqueda1.vista.Items.AddRange(New Object() {"EXPEDIENTE", "RESPONSABLE", "PROFESIONAL"})
            'Selecting view
            If ControlBusqueda1.vista.SelectedIndex = -1 Then
                ControlBusqueda1.vista.SelectedIndex = 0 'Persona
            End If
        End If
    End Sub

    '-- RUTINAS

    'hay que cambiar la definición del evento search por default para que tome byref combobox y pueda ser usado
    'para rellenarlo con la lista de columnas
    'gran parte de esta consulta no sirve porque va a estar incluida en csearch
    'gran parte de expedientes.buscar no va

    '-- EVENTOS UNICOS

    Private Sub Listar()
        With ControlBusqueda1
            If .vista.SelectedIndex > -1 Then
                Dim dtab As New DataTable
                .filtro.DataSource = Nothing
                If .vista.Text = "EXPEDIENTE" Then
                    dtab = ObrasPrivadas.Expediente.Buscar.Expediente()
                ElseIf .vista.Text = "RESPONSABLE" Then
                    dtab = ObrasPrivadas.Expediente.Buscar.Responsable()
                ElseIf .vista.Text = "PROFESIONAL" Then
                    dtab = ObrasPrivadas.Expediente.Buscar.Profesional()
                End If
                If dtab Is Nothing = False Then
                    bs_resultado.Filter = ""
                    bs_resultado.Sort = ""
                    bs_resultado.Position = -1
                    bs_resultado.DataSource = dtab
                    CtrlMan.DataGridViewTools.Load(resultado, bs_resultado, .bsCustomFilter)
                    Dim bs_ColumnList As New BindingSource _
                        With {.DataSource = CtrlMan.Fill.GetColumnList(dtab.Columns)}
                    CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                    .FilterSearch()
                    bs_resultado.Filter = .bsCustomFilter
                End If
            End If
        End With
    End Sub
    Private Sub Buscar() Handles ControlBusqueda1.CSearchClick
        ControlBusqueda1.FilterSearch()
    End Sub
    Private Sub Reiniciar() Handles ControlBusqueda1.CResetClick
        Listar()
    End Sub
    Private Sub Vista_SelectedIndexChanged() Handles ControlBusqueda1.CVistaIndexTextChanged
        Listar()
    End Sub

    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles resultado.KeyUp
        If sender Is resultado And TypeOf resultado.DataSource Is BindingSource Then
            If e.KeyValue = Keys.F2 Then
                Dim source As DataRowView = DirectCast(resultado.DataSource, BindingSource).Current
                If source Is Nothing = False Then
                    Dim mexp As New ModExpediente()
                    mexp.exp = CInt(source("expediente"))
                    mexp.MdiParent = Me.MdiParent
                    mexp.Show()
                    Me.Close()
                End If
            ElseIf e.KeyValue = Keys.Delete Then 'No implementado
                'If Oprivadas.Expediente.eliminar(resultado.DataSource.Current("expediente_id")) Then
                'resultado.DataSource.RemoveCurrent()
                'End If
            End If
        End If
    End Sub

End Class