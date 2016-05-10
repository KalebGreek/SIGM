Public Class ModDoc
    '##### Variables de Manejo de archivos
    Public load_dialog As New OpenFileDialog

    'Variables de tabla
    Dim columna_id_doc As String

    'Variables de nombre doc
    Public cuil As Double 'Persona
    Public zona, circ, secc, manz, parc, lote As Integer 'Catastro
    Public exp As Integer 'OPrivadas
    Public acta, libro As Integer
    Public fecha_hora As Date = Date.Today

    Public Sub New(TipoArchivo As String, Tabla As String, Valor As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim dtab As New DataTable
        Dim bs As New BindingSource
        If Tabla = "per_documento" Then
            columna_id_doc = "persona_id"
            dtab = Documento.Persona.BuscarHistorial(Valor, TipoArchivo)
        ElseIf Tabla = "cat_documento" Then
            columna_id_doc = "catastro_id"
            dtab = Documento.Catastro.BuscarHistorial(Valor, TipoArchivo)
        ElseIf Tabla = "opr_documento" Then
            columna_id_doc = "opr_id"
            dtab = Documento.OPrivadas.BuscarHistorial(Valor, TipoArchivo)
        End If
        historial = Consulta.Mostrar(historial, bs_historial, dtab)
        tipo_archivo.Text = TipoArchivo
        tabla_documento.Text = Tabla
        valor_id.Text = Valor
    End Sub

    Private Sub bs_historial_PositionChanged(sender As Object, e As EventArgs) Handles bs_historial.PositionChanged
        If bs_historial.Position > -1 Then
            opt_print.Enabled = True
        Else
            opt_print.Enabled = False
        End If
    End Sub

    '## GUI
    Private Sub opt_cargar_Click(sender As Object, e As EventArgs) Handles opt_cargar.Click
        Dim ruta As String = ""
        If tabla_documento.Text = "per_documento" Then
            If tipo_archivo.Text = "" Then
                ruta = Documento.Persona.CopiaCuil(cuil)
            End If
        ElseIf tabla_documento.Text = "opr_documento" Then
            If tipo_archivo.Text = "CARATULA" Then
                ruta = Documento.OPrivadas.CargarCaratulaExp(exp)
            End If
        Else
            ruta = Documento.Catastro.CargarCopia(tipo_archivo.Text,
                                                 "Z" & zona & " C" & circ & " S" & secc & " M" & manz & " P" & parc & " L" & lote)
        End If
        With bs_historial
            If ruta <> "" Then
                .AddNew()
                .Current("fecha") = Date.Today
                .Current("ruta") = ruta
                .EndEdit()
            End If
        End With
    End Sub

    Private Sub opt_print_Click(sender As Object, e As EventArgs) Handles opt_print.Click
        If tabla_documento.Text = "per_documento" Then
            Process.Start(Documento.folder_per & bs_historial.Current("ruta"))
        ElseIf tabla_documento.Text = "opr_documento" Then
            Process.Start(Documento.folder_opr & bs_historial.Current("ruta"))
        ElseIf tabla_documento.Text = "cat_documento" Then
            Process.Start(Documento.folder_cat & bs_historial.Current("ruta"))
        End If
    End Sub

    Private Sub opt_back_Click(sender As Object, e As EventArgs) Handles opt_back.Click
        If bs_historial.Count > 0 Then
            Dim result As MsgBoxResult = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel, "Confirmar cambios")
            If result = MsgBoxResult.Yes Then
                Documento.limpiar(tabla_documento.Text, columna_id_doc, valor_id.Text, tipo_archivo.Text)
                Documento.Guardar(bs_historial, tipo_archivo.Text, tabla_documento.Text, columna_id_doc, valor_id.Text)
                Close()
            ElseIf result = MsgBoxResult.No Then
                Close()
            End If
        ElseIf MsgBoxResult.Yes = MsgBox("No se cargó ningún documento, ¿desea continuar?", MsgBoxStyle.YesNo, "Confirmar cambios") Then
            Documento.limpiar(tabla_documento.Text, columna_id_doc, valor_id.Text, tipo_archivo.Text)
            Close()
        End If
    End Sub

    Private Sub historial_KeyUp(sender As Object, e As KeyEventArgs) Handles historial.KeyUp
        With bs_historial
            If e.KeyValue = Keys.Delete And .Position > -1 Then
                If MsgBoxResult.Yes = MsgBox("¿Desea eliminar el documento seleccionado de la base de datos?", MsgBoxStyle.YesNo) Then
                    If .Current("id") Is DBNull.Value = False Then
                        bd.edit(defcon, "DELETE * FROM " & tabla_documento.Text & " WHERE id=" & .Current("id"))
                    End If
                    .RemoveCurrent()
                End If
            End If
        End With
    End Sub
End Class