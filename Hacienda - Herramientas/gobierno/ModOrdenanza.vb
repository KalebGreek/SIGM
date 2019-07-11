Public Class ModOrdenanza
    Public bs_registro As New BindingSource
    Private Sub ModOrdenanza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecha.MaxDate = Date.Today
        fecha.Value = Date.Today
    End Sub
    '###### GUI ##########################################################################################
    Private Sub guardarcambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambios.Click
        'Según si se modifica un CUIL de persona o un profesional, hay que actualizar campos de distintas tablas
        'No correr el update de cuil al pedo si no cambió nada (comparar nuevo y viejo)
        'No actualizar cuil si no tiene 11 de largo, dejar valor anterior.
        If ValidarCambios() Then
            Dim answer As MsgBoxResult = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
            If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
                If answer = MsgBoxResult.Yes Then
                    guardar()
                End If
                Me.Close()
            End If
        End If
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
    Private Sub codigo_KeyUp(sender As Object, e As KeyEventArgs) Handles codigo.KeyUp
        If e.KeyValue = Keys.Enter Then
            verificar.PerformClick()
        End If
    End Sub
    Private Sub verificar_Click(sender As Object, e As EventArgs) Handles verificar.Click
        grupo_datos.Enabled = ValidarCodigo(Val(ordenanza_id.Text), Val(codigo.Text))
        grupo_codigo.Enabled = grupo_datos.Enabled.CompareTo(True)
    End Sub
    '###### CARGAR ##########################################################################################
    Private Sub ModOrdenanza_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        With bs_registro
            If .DataSource Is Nothing = False Then
                If .Position > -1 Then
                    'Cargar datos
                    ordenanza_id.Text = .Current("id").ToString
                    codigo.Text = .Current("codigo").ToString
                    fecha.Text = .Current("fecha").ToString
                    concepto.Text = .Current("concepto").ToString
                    ruta_doc.Text = .Current("ruta_copia").ToString
                    verificar.PerformClick()
                End If
            End If
        End With
    End Sub
    Private Sub cargar_doc_Click(sender As Object, e As EventArgs) Handles cargar_doc.Click
        ruta_doc.Text = Documento.Gobierno.CopiaOrdenanza(Me, Val(codigo.Text))
    End Sub
    '###### VALIDAR ##########################################################################################
    Private Function ValidarCodigo(ordenanza_id As Integer, codigo As Integer) As Boolean
        Dim valido As Boolean = True
        Dim msg As String = ""
        Dim dtab As New DataTable
        Dim sql(0) As String

        If codigo >= 11899 Or ordenanza_id > 0 Then

            If ordenanza_id > 0 Then
                sql(0) = "SELECT id, codigo FROM ordenanza WHERE id=" & ordenanza_id
            Else
                sql(0) = "SELECT id, codigo FROM ordenanza WHERE codigo=" & codigo
            End If

            dtab = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

            If dtab Is Nothing = False Then
				If dtab.Rows.Count > 0 Then
					If dtab.Rows.Count = 1 And ordenanza_id > 0 Then
						If ordenanza_id = dtab(0)("id") Then
                            'Editar
                        Else
                            'Mal cargado
                            MsgBox("Registro invalido.")
							Return False
						End If
					Else
                        'Codigo duplicado
                        MsgBox("Esta ordenanza ya se encuentra cargada en el sistema.")
						Return False
					End If
				End If
			End If
		Else
			MsgBox("Codigo invalido.")
			Return False
		End If
		Return True
	End Function
	Private Function ValidarCambios() As Boolean
		ruta_doc.BackColor = Color.WhiteSmoke
		If ruta_doc.Text.Contains("ordenanza.pdf") = False Then
			ruta_doc.BackColor = Color.FromArgb(255, 195, 185)
			Return False
		End If
		concepto.BackColor = Color.White
		If Len(concepto.Text) < 10 Then
			concepto.BackColor = Color.FromArgb(255, 195, 185)
			Return False
		End If
		Return True
	End Function

    '###### GUARDAR ##########################################################################################
    Private Sub guardar()
		If Val(ordenanza_id.Text) > -1 Then 'Mod
            DbMan.editDB(Nothing, My.Settings.CurrentDB,
					"UPDATE ordenanza SET fecha='" & fecha.Text & "', concepto='" & concepto.Text & "',
                     ruta_copia='" & ruta_doc.Text & "'")
		Else 'Nueva
            DbMan.editDB(Nothing, My.Settings.CurrentDB,
					"INSERT INTO ordenanza(codigo, fecha, concepto, ruta_copia)
                     VALUES(" & Val(codigo.Text) & ", '" & fecha.Text & "',
                    '" & concepto.Text & "', '" & ruta_doc.Text & "')")
		End If
    End Sub
End Class