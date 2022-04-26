Public Class ConsultaPersona
    Public SelectPerson As Boolean = False
    Public PersonSelected As DataRowView = Nothing
    Private bs_resultado As BindingSource = Nothing
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
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


                    Dim bs_ColumnList As New BindingSource _
                        With {.DataSource = CtrlMan.Fill.GetColumnList(dtab.Columns)}

                    .filtro.DataSource = Nothing
                    .filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")

                    .FilterSearch()
                    bs_resultado = New BindingSource With {.DataSource = dtab}
                    bs_resultado.Filter = .bsCustomFilter
                End If
            Else
                .reset_search.PerformClick()
            End If
        End With
        CtrlMan.DataGridViewTools.Load(resultado, bs_resultado)
    End Sub

    '-- EVENTOS UNICOS
    Private Sub BusquedaPersona_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible And genSearchControl1.vista.SelectedIndex = -1 Then
            If TypeOf Me.MdiParent Is MainForm Then
                Me.WindowState = FormWindowState.Maximized
            End If
            'Setting up views
            genSearchControl1.vista.Items.AddRange(New Object() {"PERSONA", "EMPLEADO", "PROFESIONAL", "PROVEEDOR"})
            genSearchControl1.selectRow.Visible = SelectPerson
            genSearchControl1.cancel.Visible = SelectPerson
            genSearchControl1.vista.SelectedIndex = 0 'First option
            genSearchControl1.filtro.SelectedIndex = 1 'Razon

        End If
    End Sub
    Public Sub SearchClick() Handles genSearchControl1.CSearchClick, genSearchControl1.CFiltroIndexTextChanged
        If bs_resultado Is Nothing = False Then
            genSearchControl1.FilterSearch()
            bs_resultado.Filter = genSearchControl1.bsCustomFilter
        End If
    End Sub
    Private Sub VistaSelectedIndexChanged() Handles genSearchControl1.CVistaIndexTextChanged, genSearchControl1.CResetClick
        If genSearchControl1.vista.SelectedIndex > -1 Then
            Consultar(True)
        End If
    End Sub
    Public Sub SelectClick(sender As Object, e As EventArgs) Handles genSearchControl1.CSelect
        PersonSelected = Nothing
        If bs_resultado Is Nothing = False Then
            If bs_resultado.Position > -1 Then
                PersonSelected = bs_resultado.Current()
            End If
        End If
        If PersonSelected Is Nothing Then
            MsgBox("No se ha seleccionado una persona.")
        Else
            Me.Close()
        End If

    End Sub
    Public Sub CancelClick(sender As Object, e As EventArgs) Handles genSearchControl1.CCancel
        PersonSelected = Nothing
        Me.Close()
    End Sub

    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles genSearchControl1.CKeywordKeyUp, resultado.KeyUp
        If e.KeyValue = Keys.F3 Then
            Consultar(False)
        ElseIf sender Is resultado Then
            Dim persona_id As Integer = CInt(bs_resultado.Current("persona_id"))
            If persona_id > 0 Then
                If e.KeyValue = Keys.F2 Then
                    Me.Hide()
                    Dim mper As New ModPersona With {.PersonaId = persona_id, .MdiParent = Me.MdiParent}
                    mper.Show()
                    Me.Close()
                ElseIf e.KeyValue = Keys.Delete Then
                    If Persona.Eliminar(persona_id) Then
                        bs_resultado.RemoveCurrent()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub FiltrosPersona_CheckedChanged(sender As Object, e As EventArgs) Handles difunto.CheckedChanged, fisica.CheckedChanged
        If DirectCast(sender, CheckBox).Enabled And Me.Visible Then
            Consultar()
        End If
    End Sub

End Class