Imports Sigm.Persona.sql
Public Class ConsultaPersona
    '###### VARIABLES Y RUTINAS #################################################################################
    Private Sub ConsultaPersona_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            If Me.Owner.Name = "launcher" Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                Cerrar.Text = "Cerrar"
            End If

            If filtro1.SelectedIndex = -1 Then
                filtro1.SelectedIndex = 0 'Persona
            End If
            ConsultarPersonas()
        End If
    End Sub
    Private Function ConsultarPersonas() As DataGridView
        keyword.Text = Trim(keyword.Text)
        With filtro1.Text
            If .Contains("PERSONA") Then
                Return Consulta.Mostrar(visor, bs_consulta,
                                        BuscarPorPersona(difunto.Checked, fisica.Checked,
                                                         Val(keyword.Text), Val(keyword.Text), keyword.Text))
            ElseIf .Contains("DIRECCION") Then
                Return Consulta.Mostrar(visor, bs_consulta, BuscarPorDireccion(keyword.Text, difunto.Checked, fisica.Checked))
            ElseIf .Contains("EMPLEADO") Then
                fisica.Enabled = False
                fisica.Checked = True
                Return Consulta.Mostrar(visor, bs_consulta, Empleado.BuscarPorPersona(keyword.Text, difunto.Checked))
            ElseIf .Contains("PROVEEDOR") Then
                difunto.Enabled = False
                difunto.Checked = False
                Return Consulta.Mostrar(visor, bs_consulta, Proveedor.BuscarPorPersona(keyword.Text, fisica.Checked))
            ElseIf .Contains("PROFESIONAL") Then
                fisica.Enabled = False
                fisica.Checked = True
                difunto.Enabled = False
                difunto.Checked = False
                Return Consulta.Mostrar(visor, bs_consulta,
                                        Profesional.BuscarPorPersona(Val(keyword.Text), Val(keyword.Text), Trim(keyword.Text)))
            Else
                Return Nothing
            End If
        End With
    End Function
    '###### FIN VARIABLES Y RUTINAS #############################################################################

    '###### GUI #################################################################################################
    Private Sub Nueva_Persona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaPersona.Click
        'La búsqueda se va a realizar automáticamente, para mostrar personas coincidentes con la razón
        'social o el cuil ingresado
        visor.DataSource = Nothing
        Dim agregar_per As New ModPersona
        With agregar_per
            .ShowDialog(Me)
        End With
    End Sub
    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrar.Click

    End Sub

    Private Sub consulta_DataSourceChanged(sender As Object, e As EventArgs) Handles visor.DataSourceChanged
        If visor.DataSource Is Nothing Then
            bs_consulta.DataSource = Nothing
        End If
    End Sub

    '###### END GUI #############################################################################################

    '###### BUSQUEDA ##########################################################################################
    Private Sub keyword_ClicknFocus(sender As Object, e As EventArgs) Handles keyword.Click, keyword.GotFocus
        keyword.SelectAll()
    End Sub
    Private Sub Keyword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles keyword.KeyPress
        If e.KeyChar = Chr(13) Then
            ConsultarPersonas()
        End If
    End Sub
    Private Sub keyword_LostFocus(sender As Object, e As EventArgs) Handles keyword.LostFocus
        If Trim(keyword.Text) = "" Then
            keyword.Text = "Buscar.."
        End If
    End Sub
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        visor.DataSource = Nothing
        keyword.Text = "Buscar.."
    End Sub
    Private Sub filtro1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtro1.SelectedIndexChanged
        If filtro1.SelectedIndex > -1 Then
            reset.PerformClick()
            difunto.Enabled = True
            fisica.Enabled = True
            ConsultarPersonas()
        End If
    End Sub

    '###### VALIDACION ##########################################################################################
    Private Sub fisica_CheckedChanged(sender As Object, e As EventArgs) Handles fisica.CheckedChanged
        difunto.Checked = False
        difunto.Enabled = fisica.Checked
        ConsultarPersonas()
    End Sub


    '###### CUIL ###############################################################################################
    Private Sub consulta_KeyUp(sender As Object, e As KeyEventArgs) Handles visor.KeyUp
        If e.KeyValue = Keys.Delete Then
            delete.PerformClick()
        ElseIf e.KeyValue = Keys.F2 Then
            edit.PerformClick()
        End If
    End Sub
    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If bs_consulta.Position > -1 Then
            Dim edit_per As New ModPersona(bs_consulta.Current("persona_id"))
            With edit_per
                .ShowDialog(Me)
            End With
            keyword.Text = bs_consulta.Current("persona_id")
            ConsultarPersonas()
        End If
    End Sub
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        With bs_consulta
            If Eliminar(.Current("persona_id")) Then
                .RemoveCurrent()
            End If
        End With
    End Sub

    Private Sub consulta_DoubleClick(sender As Object, e As EventArgs) Handles visor.DoubleClick
        If bs_consulta.Position > -1 Then
            edit.PerformClick()
        End If
    End Sub


End Class