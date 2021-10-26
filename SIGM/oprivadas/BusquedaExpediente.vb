Public Class BusquedaExpediente
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

    Private Sub Consultar()
        With ControlBusqueda1
            If .vista.SelectedIndex > -1 Then
                Dim dtab As New DataTable
                .filtro.DataSource = Nothing
                If .vista.Text = "EXPEDIENTE" Then
                    dtab = Oprivadas.Expediente.Buscar.Expediente()
                ElseIf .vista.Text = "RESPONSABLE" Then
                    dtab = Oprivadas.Expediente.Buscar.Responsable()
                ElseIf .vista.Text = "PROFESIONAL" Then
                    dtab = Oprivadas.Expediente.Buscar.Profesional()
                End If
                If dtab Is Nothing = False Then
                    bs_resultado.Filter = ""
                    bs_resultado.Sort = ""
                    bs_resultado.Position = -1
                    bs_resultado.DataSource = dtab
                    CtrlMan.DataGridViewTools.Load(resultado, bs_resultado, .bsCustomFilter)
                    Dim bs_ColumnList As New BindingSource _
                        With {.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado.DataSource.Columns)}

                    CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                    .FilterSearch()
                    bs_resultado.Filter = .bsCustomFilter
                End If
            End If
        End With
    End Sub
    Private Sub Buscar() Handles ControlBusqueda1.CSearchClick
        Consultar()
    End Sub
    Private Sub Reiniciar() Handles ControlBusqueda1.CResetClick
    End Sub
    Private Sub vista_SelectedIndexChanged() Handles ControlBusqueda1.CVistaIndexTextChanged
        Consultar()
    End Sub

    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles resultado.KeyUp
        If sender Is resultado And resultado.DataSource Is Nothing = False Then
            If e.KeyValue = Keys.F2 Then
                If resultado.DataSource.Position > -1 Then
                    Using mexp As New ModExpediente()
                        mexp.exp = CInt(resultado.DataSource.Current("expediente"))
                        mexp.ShowDialog()
                    End Using
                    ControlBusqueda1.search.PerformClick()
                End If
            ElseIf e.KeyValue = Keys.Delete Then 'No implementado
                'If Oprivadas.Expediente.eliminar(resultado.DataSource.Current("expediente_id")) Then
                'resultado.DataSource.RemoveCurrent()
                'End If
            End If
        End If
    End Sub

End Class