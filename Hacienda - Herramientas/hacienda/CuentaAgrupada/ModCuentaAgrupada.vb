Imports Sigm.CuentaAgrupada
Public Class ModCuentaAgrupada
    '###### VARIABLES #######################################################################################
    Dim cuota_vence As Integer
    Dim dtab_imp, dtab_cuenta, dtab_vence, dtab_deto As New DataTable
    Public dtab_contrib, dtab_mod_contrib As New DataTable
    Dim impuesto As String
    Dim found As Boolean
    Private Sub ConsultaCuentaAgrupada_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
        End If
    End Sub
    '###### FIN VARIABLES ###################################################################################

    '#### CUENTAS AGRUPADAS ##############################################
    '## EVENTOS
    '--------------------------
    '## RUTINAS DE LIMPIEZA

    '###### FIN GUI #############################################################################################
    '------------------------------------------------------------------------------------------------------------
    '###### FILTER ##############################################################################################
    '#### FILTROS AUTOMATICOS ################################
    '### CUENTA AGRUPADA

    '#### FILTROS MANUALES ################################
    Private Sub bs_consulta_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_consulta.CurrentChanged
        With bs_consulta
            If .Position >= 0 Then
                info.Text = "Deuda Total:"
                'Deuda total desde $1 usando código de la fila seleccionada del impuesto seleccionado
                dtab_deto = deuda(True, False, impuesto, 0, .Current("codigo"), 0, 1, 0)
                If dtab_deto.Rows.Count > 0 Then
                    ca_id.Text = "$ " & dtab_deto(0)("deuda")
                End If
            End If
        End With
    End Sub
    Private Sub bs_consulta_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_consulta.PositionChanged
        Dim registro(10) As String
        Dim fila As Integer = 0
        With bs_consulta
            imp_add.Enabled = False
            If .Position >= 0 Then
                fila = .Position
                imp_add.Enabled = True
                imp_razon.Text = Trim(.Item(fila)("razon").ToString)
                If .List.Contains("alta") Then
                    imp_alta.Text = .Item(fila)("alta").ToString
                End If
                If .List.Contains("baja") Then
                    imp_baja.Text = .Item(fila)("baja").ToString
                End If
            End If
        End With
    End Sub

    Function deuda(ByVal deuda_total As Boolean, ByVal cuenta_agrupada As Boolean, ByVal impuesto As String, ByVal filter As Integer, ByVal keyword As String, ByVal range As Integer, ByVal dmin As Integer, ByVal dmax As Integer)
        progreso.Value = 5
        Dim consulta As New DataTable
        '### Crear consulta sin filtros
        Dim sql As String = "SELECT " & ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon,"

        If deuda_total Then
            sql += " SUM(" & col_importe & ") as deuda"
        Else  'Deuda detallada (Normal)
            sql += col_importe & " as original, " & col_pagado & " as pagado, " & col_vence & " as vencimiento, " & col_periodo & " as periodo "
        End If
        sql += " FROM " & ext_cuenta & " INNER JOIN " & ext_persona & " ON " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"
        'Con interés de 1% diario
        'sel_sql += ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon, " & importe & " as original, " & _
        '           "ROUND((" & importe & " + (" & importe & " * ((DATE() - " & vence & ") * 0.01))), 2) as deuda, " & _
        '         vence & " as vencimiento, " & periodo & " as periodo FROM " & ext_cuenta & _
        '        " INNER JOIN " & ext_persona & " ON " & ext_cuenta & ".codigo = " & ext_persona & ".codigo"

        '### Hay otros filtros activos?

        If cuenta_agrupada Then
            sql += " WHERE " & ext_persona & ".codigo=" & bs_contrib.Current("codigo")
        End If
        consulta = bd.read(my.settings.foxcon, sql)
        progreso.Value = 20
        Return consulta
    End Function

    '### CUENTA AGRUPADA

    '### EVENTOS DE LISTAS
    Private Sub imp_lista_mod_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Esto guarda los ID de los registros borrados para guardar los 
        'cambios correctamente después.
        If e.KeyCode = Keys.Delete Then
            With bs_mod_contrib
                If IsDBNull(.Current("id")) = False Then
                    del_rows(ndel) = .Current("id")
                    found = True
                    ndel += 1
                End If
            End With
        End If
    End Sub
    Private Sub imp_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With bs_mod_contrib
            .AddNew()
            .Current("impuesto") = TipoImpuesto.Text
            .Current("codigo") = bs_consulta.Current("codigo")
            .Current("alta") = imp_alta.Value 'alta
            .EndEdit()
        End With
    End Sub
    Private Sub save_ca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nupd, nins As Integer
        Dim fila As Integer = 0
        With imp_lista_mod
            If .RowCount > 0 Then
                Do While fila < .RowCount
                    If .Item(0, fila).Value.ToString = Nothing Then
                        'mod_sql = "INSERT INTO contribuyente(razon, cuil, impuesto, codigo, alta) VALUES ('" &
                        'razon.Text & "', " & cuil.Text & ", '" & .Item(1, fila).Value & "', " &
                        '.Item(2, fila).Value & ", '" & .Item(3, fila).Value & "');"
                        bd.edit(my.settings.DefaultCon, "")
                        nins += 1
                    Else
                        'mod_sql = "UPDATE contribuyente SET razon='" & razon.Text & "', impuesto='" & .Item(1, fila).Value &
                        '   "', codigo=" & .Item(2, fila).Value & ", alta='" & .Item(3, fila).Value & "'" &
                        '   " WHERE id=" & .Item(0, fila).Value
                        bd.edit(my.settings.DefaultCon, "")
                        nupd += 1
                    End If
                    fila += 1
                Loop
                ndel = 0
                If found = True Then
                    Do While ndel < del_rows.Count And del_rows(ndel) <> Nothing
                        bd.edit(my.settings.DefaultCon, "DELETE FROM contribuyente WHERE id=" & del_rows(ndel) & ";")
                        ndel += 1
                    Loop
                End If
            Else
                If MsgBoxResult.Ok = MsgBox("Esto eliminará todos los registros de la cuenta agrupada, ¿desea continuar?.", MsgBoxStyle.OkCancel) Then
                    '    bd.edit(my.settings.DefaultCon, "DELETE FROM contribuyente WHERE cuil=" & cuil.Text & ";")
                End If
            End If
            info.Text = nins & " nuevos registros, " & nupd & " registros modificados y " & ndel & " registros eliminados."
            'Resetear contadores y registro de eliminados
            nins = 0
            nupd = 0
            ndel = 0
            ReDim del_rows(99)
            'dtab_mod_contrib = hac_contrib.leer(sender, cuil.Text)
            bs_mod_contrib.DataSource = dtab_mod_contrib
            imp_lista_mod.DataSource = bs_mod_contrib
            imp_lista_mod.Update()
        End With
    End Sub

    '----------------------
    '###### END FILTER ##########################################################################################

    '###### PRINT ###############################################################################################

    Private Sub vistaprevia_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Por alguna razón el diálogo de vista previa se borra ( .Dispose() ) 
        'cuando lo cierro, así que mejor lo creo cada vez que apreto el botón "Vista Previa"
        Dim printpreview As New PrintPreviewDialog
        consulta_printdocument.DocumentName = "Consulta Impuesto"
        printpreview.Document = consulta_printdocument
        printpreview.Show()
    End Sub
    Private Sub imprimir_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        consulta_printdocument.DocumentName = "Consulta Impuesto"
        PrintDialog.Document = consulta_printdocument
        PrintDialog.ShowDialog()
    End Sub


    '###### END PRINT ###########################################################################################
End Class

