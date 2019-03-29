Imports System.ComponentModel

Public Class BusquedaPersona
    Public Sub New(Optional SelectMode As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Setting up views
        genSearchControl1.vista.Items.AddRange(New Object() {"PERSONA", "EMPLEADO", "PROFESIONAL", "PROVEEDOR"})
        genSearchControl1.selectRow.Visible = SelectMode
        genSearchControl1.cancel.Visible = SelectMode

    End Sub
    '-- RUTINAS
    Public Sub Consultar(Optional clearFilter As Boolean = False)
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

                    If dtab Is Nothing = False Then
                    If clearFilter Then
                        genSearchControl1.bsCustomFilter = ""
                        Dim bs_ColumnList As New BindingSource
                        bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(dtab)
                        CtrlMan.Fill.SetAutoComplete(genSearchControl1.filtro, bs_ColumnList, "ColumnName", "DataType")
                    Else
                        'Llamar evento de filtro en control genérico
                        genSearchControl1.FilterSearch()
                    End If
                    CtrlMan.LoadDataGridView(resultado, bs_resultado, genSearchControl1.bsCustomFilter, dtab)
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
    Public Sub Search_Click(sender As Object) Handles genSearchControl1.CSearch_Click
        Consultar()
    End Sub

    Private Sub vista_SelectedIndexChanged() Handles genSearchControl1.CVista_IndexTextChanged
        If genSearchControl1.vista.SelectedIndex > -1 Then
            Consultar(True)
        End If
    End Sub
    Private Sub KeyShortcuts(sender As Object, e As KeyEventArgs) Handles genSearchControl1.CKeyword_KeyUp, resultado.KeyUp
        If e.KeyValue = Keys.F3 Then
            Consultar(False)
        ElseIf sender Is resultado Then
            If e.KeyValue = Keys.F2 Then
				If resultado.DataSource.Position > -1 Then
					Dim mper As New ModPersona
					mper.cargar(resultado.DataSource.Current("persona_id"))
					mper.ShowDialog()
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

	Private Sub Close_Search() Handles genSearchControl1.CSelect, genSearchControl1.CCancel
		Me.Close()
	End Sub

	Private Sub Me_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		If genSearchControl1.RowSelected = False Then
			bs_resultado.DataSource = Nothing
		End If
	End Sub

End Class