﻿Public Class BusquedaPersona
    Public Sub New(Optional SelectionMode As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Setting up views
        genSearchControl1.vista.Items.AddRange(New Object() {"PERSONA", "EMPLEADO", "PROFESIONAL", "PROVEEDOR"})
        genSearchControl1.selectRow.Visible = SelectionMode
        genSearchControl1.cancel.Visible = SelectionMode

    End Sub
    '-- RUTINAS
    Public Sub Consultar(Optional clearFilter As Boolean = False)
        resultado.DataSource = Nothing

        With genSearchControl1
            If .vista.SelectedIndex > -1 Then
                Dim dtab As New DataTable
                If .vista.Text = "PERSONA" Then
                    If clearFilter Then
                        fisica.Enabled = True
                        fisica.Checked = True
                        difunto.Enabled = True
                        difunto.Checked = False
                    End If
                    dtab = Persona.Buscar(difunto.Checked, fisica.Checked)

                ElseIf .vista.Text = "EMPLEADO" Then
                    If clearFilter Then
                        fisica.Enabled = False
                        fisica.Checked = True
                        difunto.Enabled = True
                        difunto.Checked = False
                    End If
                    dtab = Empleado.BuscarPorPersona("", difunto.Checked)

                ElseIf .vista.Text = "PROFESIONAL" Then
                    If clearFilter Then
                        fisica.Enabled = True
                        fisica.Checked = True
                        difunto.Enabled = True
                        difunto.Checked = False
                    End If
                    dtab = Profesional.BuscarPorPersona()

                ElseIf .vista.Text = "PROVEEDOR" Then
                    If clearFilter Then
                        fisica.Enabled = True
                        fisica.Checked = False
                        difunto.Enabled = False
                        difunto.Checked = False
                    End If
                    dtab = Proveedor.BuscarPorPersona("", difunto.Checked, fisica.Checked)

                End If

                If dtab.Rows.Count > 0 Then
                    If clearFilter Then
                        .bsCustomFilter = ""
                    End If

                    bs_resultado = New BindingSource
                    bs_resultado.DataSource = dtab
                    Dim bs_ColumnList As New BindingSource _
                        With {.DataSource = CtrlMan.Fill.GetColumnList(bs_resultado.DataSource.Columns)}

                    .filtro.DataSource = Nothing
                    .filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")

                    .FilterSearch()
                    bs_resultado.Filter = .bsCustomFilter

                    resultado = CtrlMan.DataGridViewTools.Load(resultado, bs_resultado)
                End If
            Else
                .reset_search.PerformClick()
            End If
        End With
    End Sub

    '-- EVENTOS UNICOS
    Private Sub BusquedaPersona_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible And genSearchControl1.vista.SelectedIndex = -1 Then
            genSearchControl1.vista.SelectedIndex = 0 'First option
        End If
    End Sub
    Public Sub SearchClick() Handles genSearchControl1.CSearchClick, genSearchControl1.CFiltroIndexTextChanged
        genSearchControl1.FilterSearch()
        bs_resultado.Filter = genSearchControl1.bsCustomFilter
    End Sub
    Private Sub vistaSelectedIndexChanged() Handles genSearchControl1.CVistaIndexTextChanged, genSearchControl1.CResetClick
        resultado.DataSource = Nothing
        If genSearchControl1.vista.SelectedIndex > -1 Then
            Consultar(True)
        End If
    End Sub
    Public Sub SelectClick(sender As Object, e As EventArgs) Handles genSearchControl1.CSelect
        If bs_resultado.Position > -1 Then
            Me.Close()
        Else
            MsgBox("No se ha seleccionado una persona.")
        End If
    End Sub
    Public Sub CancelClick(sender As Object, e As EventArgs) Handles genSearchControl1.CCancel
        resultado.DataSource = Nothing
        bs_resultado.Sort = ""
        bs_resultado.Filter = ""
        bs_resultado.DataSource = Nothing
        Me.Close()
    End Sub


    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles genSearchControl1.CKeywordKeyUp, resultado.KeyUp
        If e.KeyValue = Keys.F3 Then
            Consultar(False)
        ElseIf sender Is resultado Then
            If e.KeyValue = Keys.F2 Then
                If resultado.DataSource.Position > -1 Then
                    Using mper As New ModPersona(resultado.DataSource.Current("persona_id")) With {.Owner = Me}
                        mper.ShowDialog()
                    End Using
                    genSearchControl1.search.PerformClick()
                End If
            ElseIf e.KeyValue = Keys.Delete Then
                If Persona.Eliminar(resultado.DataSource.Current("persona_id")) Then
                    resultado.DataSource.RemoveCurrent()
                End If
            End If
        End If
    End Sub

    Private Sub filtrospersona_CheckedChanged(sender As Object, e As EventArgs) Handles difunto.CheckedChanged, fisica.CheckedChanged
        If sender.Enabled And Me.Visible Then
            Consultar()
        End If
    End Sub

End Class