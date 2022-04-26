Public Class ModActa
    Public Sub New(PersonaId As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        bs_acta.DataSource = buscar(PersonaId)
        CtrlMan.DataGridViewTools.Load(consulta_acta, bs_acta)
    End Sub

    '###### GUI ##########################################################################################
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        limpiar(per_id.Text)
        guardar(bs_acta, per_id.Text)
        Me.Close()
    End Sub
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    Private Sub edit_acta_Click(sender As Object, e As EventArgs) Handles edit_acta.Click
        Dim source As DataRowView = bs_acta.Current
        If source Is Nothing = False Then
            If MsgBoxResult.Yes = MsgBox("¿Desea modificar el acta seleccionada? Se perderán los datos no guardados.", MsgBoxStyle.YesNo) Then
                fecha_acta.Value = source("fecha")
                acta.Value = source("acta")
                libro.Value = source("libro")
                copia.Text = source("copia").ToString
                nota.Text = source("nota").ToString
                add_acta.Text = "ACTUALIZAR"
                consulta_acta.Enabled = False
                MsgBox("Al finalizar, presione ACTUALIZAR para guardar los cambios.")
            End If
        End If
    End Sub
    Private Sub del_acta_Click(sender As Object, e As EventArgs) Handles del_acta.Click
        If bs_acta.Position > -1 _
        And MsgBoxResult.Yes = MsgBox("¿Desea eliminar el acta seleccionada?", MsgBoxStyle.YesNo, "Eliminar Acta") Then
            bs_acta.RemoveCurrent()
        End If
    End Sub
    Private Sub consulta_acta_KeyUp(sender As Object, e As KeyEventArgs) Handles consulta_acta.KeyUp
        If e.KeyValue = Keys.Delete Then
            del_acta.PerformClick()
        ElseIf e.KeyValue = Keys.Enter Then
            edit_acta.PerformClick()
        End If
    End Sub
    Private Sub copia_DoubleClick(sender As Object, e As EventArgs) Handles copia.DoubleClick
        If Len(copia.Text) > 0 Then
            Process.Start(root & My.Settings.DocFolderPersona, copia.Text)
        End If
    End Sub

    '###### CARGAR ##########################################################################################
    Private Function validar(id As Integer, fecha As Date, acta As Integer, libro As Integer,
                   ruta_copia As String) As MsgBoxResult
        Dim msg As New List(Of String)

        If fecha > Date.Today Then
            msg.Add("(×) La fecha del acta no puede ser posterior al día de hoy.")
        End If
        If acta < 1 Or libro < 1 Then
            If acta < 1 Then
                msg.Add("(×) N° de Acta inexistente")
            End If
            If libro < 1 Then
                msg.Add("(×) N° de Libro de Actas inexistente.")
            End If
        Else
            Using dtab As DataTable = buscar(libro, acta)
                If dtab.Rows.Count > 0 Then
                    If CInt(dtab.Rows(0)("id")) <> id Then
                        msg.Add("(×) El acta N°" & acta & " del libro N°" &
                               libro & " ya existe.")
                    End If
                End If
            End Using
        End If
        If Len(ruta_copia) < 10 Then
            msg.Add("(×) Debe cargar una copia del Acta.")
        End If

        Dim valido As Integer = msg.FindIndex(Function(value As String)
                                                  Return value(0) = "("
                                              End Function)
        If valido > -1 Then
            Using ver_error As New UIError("Errores en Acta", msg)
                Dim answer As DialogResult = ver_error.ShowDialog(Me)

                If answer = DialogResult.OK Then
                    Return MsgBoxResult.No
                Else
                    Return MsgBoxResult.Cancel
                End If
            End Using
        Else
            Return MsgBoxResult.Yes
        End If
    End Function

    Shared Function buscar(Optional PersonaId As Integer = 0, Optional libro As Integer = 0, Optional acta As Integer = 0) As DataTable
        Dim sql(2) As String
        sql(0) = "SELECT actas.id, per_id, cuil, fecha, acta, libro, copia, nota"
        sql(1) = " FROM actas INNER JOIN persona ON persona.id=actas.per_id"
        sql(2) = " WHERE"

        If PersonaId > 0 Then
            sql(2) += " per_id=" & PersonaId
        Else
            sql(2) += " libro = " & libro & " And acta = " & acta
        End If

        Return DbMan.ReadDB(sql, My.Settings.CurrentDB)
    End Function

    Private Sub add_acta_Click(sender As Object, e As EventArgs) Handles add_acta.Click
        Dim source As DataRowView = bs_acta.Current
        If source Is Nothing = False Then
            If validar(source("id"), fecha_acta.Value, acta.Value, libro.Value, copia.Text) = MsgBoxResult.Yes Then
                If consulta_acta.Enabled = False Then 'Actualizar
                    bs_acta.RemoveCurrent()
                    consulta_acta.Enabled = True
                End If

                Dim nueva_acta As DataRowView = bs_acta.Current
                nueva_acta("fecha") = fecha_acta.Value
                nueva_acta("acta") = acta.Value
                nueva_acta("libro") = libro.Value
                nueva_acta("copia") = copia.Text
                nueva_acta("nota") = nota.Text

                bs_acta.Add(nueva_acta)
                bs_acta.EndEdit()

                bs_acta.Position = -1
                fecha_acta.Value = Date.Today
                acta.Value = 0
                libro.Value = 0
                copia.Text = ""
                nota.Text = ""
            End If
        End If
    End Sub

    Private Sub guardar(registro As BindingSource, per_id As Integer)
        With registro
            For fila As Integer = 0 To .Count - 1
                .Position = fila
                DbMan.EditDB("INSERT INTO actas(per_id, fecha, acta, libro, copia, nota)
                                   VALUES(" & per_id & ", '" & .Current("fecha").ToString & "',
										  " & .Current("acta").ToString & ", " & .Current("libro").ToString & ", 
										 '" & .Current("copia").ToString & "', '" & .Current("nota").ToString & "')",
                             My.Settings.CurrentDB)
            Next
        End With
    End Sub

    Shared Sub limpiar(ByVal PersonaId As Integer) 'Temporales
        DbMan.EditDB("DELETE * FROM actas WHERE per_id=" & PersonaId, My.Settings.CurrentDB)
    End Sub
    '###### MODIFICAR ##########################################################################################
    '# ACTAS
    Private Sub cargar_acta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cargar_copia_acta.Click
        Dim ruta As String = FileMan.Persona.CopiaActa(per_id.Text, acta.Value, libro.Value)
        If ruta <> "" Then
            copia.Text = ruta
        End If
    End Sub
End Class