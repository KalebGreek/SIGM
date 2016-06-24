Public Class ModActa
    Public Sub New(persona_id As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Query.Show(consulta_acta, bs_acta, buscar(persona_id))
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
        With bs_acta
            If .Position > -1 Then
                If MsgBoxResult.Yes = MsgBox("¿Desea modificar el acta seleccionada? Se perderán los datos no guardados.", MsgBoxStyle.YesNo) Then
                    fecha_acta.Value = .Current("fecha")
                    acta.Value = .Current("acta")
                    libro.Value = .Current("libro")
                    copia.Text = .Current("copia").ToString
                    nota.Text = .Current("nota").ToString
                    add_acta.Text = "ACTUALIZAR"
                    consulta_acta.Enabled = False
                    MsgBox("Al finalizar, presione ACTUALIZAR para guardar los cambios.")
                End If
            End If
        End With
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
            Process.Start(Documento.folder_per, copia.Text)
        End If
    End Sub

    '###### CARGAR ##########################################################################################
    Private Function validar(registro As BindingSource, fecha As Date, acta As Integer, libro As Integer,
                   ruta_copia As String, nota As String) As MsgBoxResult
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
            Dim dtab As DataTable = buscar(libro, acta)
            If dtab.Rows.Count > 0 Then
                If dtab(0)("id") <> registro.Current("id") Then
                    msg.Add("(×) El acta N°" & acta & " del libro N°" &
                           libro & " ya existe.")
                End If
            End If
        End If
        If Len(ruta_copia) < 10 Then
            msg.Add("(×) Debe cargar una copia del Acta.")
        End If

        Dim valido As Integer = msg.FindIndex(Function(value As String)
                                                  Return value(0) = "("
                                              End Function)
        If valido > -1 Then
            Dim ver_error As New visor_error("Errores en Acta", msg)
            Dim answer As DialogResult = ver_error.ShowDialog(Me)
            ver_error.Dispose()
            If answer = Windows.Forms.DialogResult.OK Then
                Return MsgBoxResult.No
            Else
                Return MsgBoxResult.Cancel
            End If
        Else
            Return MsgBoxResult.Yes
        End If
    End Function

    Function buscar(Optional persona_id As Integer = 0, Optional libro As Integer = 0, Optional acta As Integer = 0) As DataTable
        Dim sql As String = "SELECT actas.id, per_id, cuil, fecha, acta, libro, copia, nota
                             FROM actas INNER JOIN persona ON persona.id=actas.per_id WHERE"

        If persona_id > 0 Then
            sql += " per_id=" & persona_id
        Else
            sql += " libro = " & libro & " AND acta = " & acta
        End If

        Return bd.read(defcon, sql)
    End Function

    Private Sub add_acta_Click(sender As Object, e As EventArgs) Handles add_acta.Click
        If validar(bs_acta, fecha_acta.Value, acta.Value, libro.Value, copia.Text, nota.Text) = MsgBoxResult.Yes Then
            With bs_acta
                If .Position > -1 And consulta_acta.Enabled = False Then 'Actualizar
                    .RemoveCurrent()
                    consulta_acta.Enabled = True
                End If
                .AddNew()
                .Current("fecha") = fecha_acta.Value
                .Current("acta") = acta.Value
                .Current("libro") = libro.Value
                .Current("copia") = copia.Text
                .Current("nota") = nota.Text
                bs_acta.EndEdit()
                bs_acta.Position = -1
                fecha_acta.Value = Date.Today
                acta.Value = 0
                libro.Value = 0
                copia.Text = ""
                nota.Text = ""
            End With
        End If
    End Sub

    Private Sub guardar(registro As BindingSource, per_id As Integer)
        With registro
            For fila As Integer = 0 To .Count - 1
                .Position = fila
                bd.edit(defcon, "INSERT INTO actas(per_id, fecha, acta, libro, copia, nota)
                                 VALUES(" & per_id & ", #" & .Current("fecha") & "#,
                                  " & .Current("acta") & ", " & .Current("libro") & ", '" & .Current("copia") & "',
                                 '" & .Current("nota") & "')")
            Next
        End With
    End Sub

    Sub limpiar(ByVal per_id As Integer) 'Temporales
        bd.edit(defcon, "DELETE * FROM actas WHERE per_id=" & per_id)
    End Sub
    '###### MODIFICAR ##########################################################################################
    '# ACTAS
    Private Sub cargar_acta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cargar_copia_acta.Click
        Dim ruta As String = Documento.Persona.CopiaActa(per_id.Text, acta.Value, libro.Value)
        If ruta <> "" Then
            copia.Text = ruta
        End If
    End Sub
End Class