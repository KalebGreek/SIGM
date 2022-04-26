Class ModOrdenanza
    Public Bs_registro As New BindingSource
    Private Sub ModOrdenanza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecha.MaxDate = Date.Today
        fecha.Value = Date.Today
    End Sub

    ' GUI 
    Private Sub GuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambios.Click
        If ValidarCambios() Then
            Dim answer As MsgBoxResult = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
            If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
                If answer = MsgBoxResult.Yes Then
                    Ordenanza.Guardar(ordenanza_id.Text, codigo.Text, fecha.Text, concepto.Text, ruta_copia.Text)
                End If
                Me.Close()
            End If
        End If
    End Sub
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
    Private Sub Codigo_KeyUp(sender As Object, e As KeyEventArgs) Handles codigo.KeyUp
        If e.KeyValue = Keys.Enter Then
            grupo_datos.Enabled = Ordenanza.ValidarCodigo(codigo.Text, ordenanza_id.Text, codigo, info)
            grupo_codigo.Enabled = grupo_datos.Enabled.CompareTo(True)
        End If
    End Sub

    ' CARGAR 
    Private Sub ModOrdenanza_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim source As DataRowView = bs_registro.Current
        If source Is Nothing = False Then
            Dim codigo_value As String = source("codigo")
            Do Until Len(codigo_value) = 8
                codigo_value = "0" & codigo_value
            Loop
            codigo.Text = codigo_value
            ordenanza_id.Text = source("ordenanza_id")
            CtrlMan.LoadControlData(bs_registro.Current, grupo_datos)
            'Cargar datos
            'ordenanza_id.Text = .Current("id").ToString
            'codigo.Text = .Current("codigo").ToString
            'fecha.Text = .Current("fecha").ToString
            'concepto.Text = .Current("concepto").ToString
            'ruta_copia.Text = .Current("ruta_copia").ToString
        End If
    End Sub
    Private Sub Cargar_doc_Click(sender As Object, e As EventArgs) Handles cargar_doc.Click
        ruta_copia.Text = FileMan.Gobierno.CopiaOrdenanza(Val(codigo.Text))
    End Sub

    ' VALIDAR 
    Private Function ValidarCambios() As Boolean
        Dim valid As Boolean = CtrlMan.Validate(grupo_datos)
        If ruta_copia.Text.Contains("ordenanza") = False _
            Or ruta_copia.Text.Contains(".pdf") = False Then
            ruta_copia.BackColor = My.Settings.ErrorColorValue
            valid = False
        End If
        Return valid
    End Function





End Class