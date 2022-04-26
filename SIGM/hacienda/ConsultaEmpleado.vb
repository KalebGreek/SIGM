Public Class ConsultaEmpleado
    Private Sub ConsultaOrdenanza_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' KeyFecha.MaxDate = Date.Today
        ' KeyFecha.Value = Date.Today
    End Sub
    Private Sub bs_consulta_PositionChanged(sender As Object, e As EventArgs) Handles bs_consulta.PositionChanged

    End Sub

    '###### GUI #################################################################################################
    Private Sub cerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    '###### END GUI #############################################################################################

    '###### BUSQUEDA ##########################################################################################
    Private Sub reiniciar_Click(sender As Object, e As EventArgs) Handles reiniciar.Click
        visor.DataSource = Nothing
        'KeyCodigo.Clear()
        'KeyFecha.Value = Date.Today
        KeyRazon.Clear()
        filtro.SelectedIndex = -1
    End Sub

    Private Sub filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged
        'KeyCodigo.Visible = False
        'KeyFecha.Visible = False
        KeyRazon.Visible = False
        If filtro.SelectedIndex > -1 Then
            With filtro.Text
                If .Contains("CODIGO") Then
                    'KeyCodigo.Visible = True
                ElseIf .Contains("FECHA") Then
                    'KeyFecha.Visible = True
                ElseIf .Contains("CONCEPTO") Then
                    KeyRazon.Visible = True
                End If
            End With
        End If
    End Sub

    Private Sub KeyCodigo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            buscar.PerformClick()
        End If
    End Sub
    Private Sub KeyFecha_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            buscar.PerformClick()
        End If
    End Sub
    Private Sub KeyConcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles KeyRazon.KeyPress
        If e.KeyChar = Chr(13) Then
            buscar.PerformClick()
        End If
    End Sub
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        grupo_mod.Enabled = False
        Dim dtab As DataTable = DbMan.ReadDB("SELECT * FROM ordenanza", My.Settings.CurrentDB)
        If dtab Is Nothing = False Then
            CtrlMan.DataGridViewTools.Load(visor, dtab)
            If dtab.Rows.Count = 0 Then
                MsgBox("No hay resultados.")
                Me.Text = "Buscar Ordenanza"
            Else
                grupo_mod.Enabled = True
            End If
        Else
            MsgBox("No hay resultados.")
            Me.Text = "Buscar Ordenanza"
        End If
    End Sub

    '###### OPERACIONES ##########################################################################################
    Private Sub consulta_KeyUp(sender As Object, e As KeyEventArgs) Handles visor.KeyUp
        If e.KeyValue = Keys.Delete Then
            eliminar.PerformClick()
        ElseIf e.KeyValue = Keys.Enter Then
            ver.PerformClick()
        ElseIf e.KeyValue = Keys.F2 Then
            modificar.PerformClick()
        End If
    End Sub
    Private Sub ver_Click(sender As Object, e As EventArgs) Handles ver.Click
        Dim path As DataRowView = bs_consulta.Current
        If path Is Nothing = False Then
            Process.Start(root & My.Settings.DocFolderOrdenanza & path("ruta_copia").ToString)
        End If
    End Sub
    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        If bs_consulta.Position > -1 Then
            Using ModificarOrdenanza As New ModOrdenanza
                With ModificarOrdenanza
                    .bs_registro = bs_consulta
                    .ShowDialog()
                    .Dispose()
                End With
            End Using
            buscar.PerformClick()
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim source As DataRowView = bs_consulta.Current
        If source Is Nothing = False Then
            If MsgBoxResult.Yes = MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.YesNo, "Eliminar registro") Then
                DbMan.EditDB("DELETE * FROM ordenanza WHERE id=" & source("id").ToString, My.Settings.CurrentDB)
                buscar.PerformClick()
            End If
        End If
    End Sub






End Class