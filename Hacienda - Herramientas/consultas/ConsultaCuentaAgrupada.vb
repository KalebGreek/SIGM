Imports Sigm.Hacienda.CuentaAgrupada
Public Class ConsultaCuentaAgrupada
    '###### VARIABLES #######################################################################################
    Dim cuota_vence As Integer
    Dim dtab_imp, dtab_cuenta, dtab_vence, dtab_deto As New DataTable
    Public dtab_contrib, dtab_mod_contrib As New DataTable
    Dim impuesto As String
    Dim found As Boolean
    Private Sub ConsultaCuentaAgrupada_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            'Reiniciar paneles de búsqueda
            reset_ca()
            grupo_ca.Visible = False
        End If
    End Sub
    '###### FIN VARIABLES ###################################################################################

    Private Sub grupo_ca_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grupo_ca.VisibleChanged
        If sender.Visible Then
            grupo_con_ca.Visible = False
            grupo_mod_ca.Visible = False
        End If
    End Sub
    Private Sub grupo_mod_ca_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grupo_mod_ca.VisibleChanged
        If sender.Visible Then
            grupo_con_ca.Visible = False
        End If
    End Sub
    Private Sub grupo_con_ca_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grupo_con_ca.VisibleChanged
        If sender.Visible Then
            grupo_mod_ca.Visible = False
        End If
    End Sub
    Private Sub et_buscar_ca_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If grupo_ca.Width = 186 Then
            grupo_ca.Width = 513
        Else
            grupo_ca.Width = 186
        End If
    End Sub
    Private Sub et_mod_ca_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles et_mod_ca.DoubleClick
        If grupo_ca.Width = 186 Then
            grupo_ca.Width = 513
        Else
            grupo_ca.Width = 186
        End If
    End Sub
    Private Sub et_con_ca_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles et_con_ca.DoubleClick
        If grupo_ca.Width = 186 Then
            grupo_ca.Width = 513
        Else
            grupo_ca.Width = 186
        End If
    End Sub
    Private Sub close_ca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reset_ca_imp()
        grupo_mod_ca.Visible = False
        grupo_con_ca.Visible = False
        razon.ReadOnly = False
        grupo_buscar_ca.Enabled = True
        grupo_buscar_ca.Visible = False
    End Sub
    Private Sub cancel_con_ca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_con_ca.Click
        grupo_con_ca.Visible = False
        grupo_buscar_ca.Enabled = True
        leer(razon.Text, ca_search)
    End Sub
    Private Sub cancel_mod_ca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grupo_mod_ca.Visible = False
        grupo_buscar_ca.Enabled = True
        leer(razon.Text, ca_search)
    End Sub

    '#### CUENTAS AGRUPADAS ##############################################
    '## EVENTOS
    Private Sub razon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(razon.Text) > 0 Then
            dni.ReadOnly = True
        Else
            dni.ReadOnly = False
        End If
    End Sub
    Private Sub dni_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If dni.Visible Then
            ca_switch.Text = "Mostrar CUIL"
        Else
            ca_switch.Text = "Mostrar DNI"
        End If
    End Sub
    Private Sub switch_ca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dni.Visible Then
            dni.Visible = False
            cuil.Visible = True
        Else
            dni.Visible = True
            cuil.Visible = False
        End If
    End Sub
    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reset_ca()
    End Sub
    '--------------------------
    '## RUTINAS DE LIMPIEZA
    Private Sub reset_ca()
        razon.Text = ""
        dni.Text = ""
        dni.Visible = True
        cuil.Text = ""
        cuil.Visible = False
        '--------------------------
        reset_ca_imp()
    End Sub
    Private Sub reset_ca_imp()
        imp_razon.ReadOnly = False
        imp_razon.Text = razon.Text
        imp_alta.Value = Date.Today
    End Sub

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
                    info2.Text = "$ " & dtab_deto(0)("deuda")
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
                If grupo_buscar_ca.Enabled And grupo_buscar_ca.Visible Then
                    'Modificando / Consultando cuentas agrupadas
                    dni.Visible = True
                    cuil.Visible = False
                    cuil.Text = 0
                    registro(0) = .Item(fila)("id").ToString
                    registro(1) = Trim(.Item(fila)("razon").ToString)
                    registro(2) = .Item(fila)("cuil").ToString
                    razon.Text = registro(1)
                    If Len(registro(2)) = 11 Then
                        dni.Visible = False
                        cuil.Visible = True
                        cuil.Text = registro(2)
                        dni.Text = Mid(registro(2), 3, 8) 'Toma DNI desde CUIL
                    ElseIf Len(registro(2)) < 11 Then
                        dni.ReadOnly = False 'Para ser modificado
                        dni.Text = Val(registro(2))
                    ElseIf registro(2) = 0 Then
                        dni.ReadOnly = False 'Para ser modificado
                        dni.Text = "00000000"
                    End If
                ElseIf grupo_mod_ca.Visible Then 'Consultando impuestos por separado
                    imp_add.Enabled = True
                    imp_razon.Text = Trim(.Item(fila)("razon").ToString)
                    If .List.Contains("alta") Then
                        imp_alta.Text = .Item(fila)("alta").ToString
                    End If
                    If .List.Contains("baja") Then
                        imp_baja.Text = .Item(fila)("baja").ToString
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub leer(ByVal keyword As String, ByVal sender As Object)
        progreso.Value = 0
        visor.DataSource = Nothing
        bs_consulta.DataSource = Nothing
        If sender Is ca_search Then 'Búsqueda de cuentas agrupadas
            dtab_cuenta = Sql.leer(keyword, "", sender)
            visor = Data.ToDataGridView(visor, bs_consulta, dtab_cuenta)
        ElseIf sender Is con_ca Then
            dtab_contrib = hac_contrib.leer(dtab_contrib, sender) 'Esta consulta vuelca los resultados directamente en el datagridview especial lista_con
            'Cuando el usuario hace click en algún impuesto de la cuenta agrupada, debería poder ver las cuotas
            'desglosadas en el datagridview a la izquierda
        ElseIf sender Is bs_contrib Then 'Esta consulta muestra un id de cuenta desglosado en el datagridview de la izquierda
            tablas_fox(bs_contrib.Current("impuesto"))
            dtab_imp = deuda(False, True, bs_contrib.Current("impuesto"), 2, keyword, 0, 0, 0) 'filtrado por nombre
            visor = Data.ToDataGridView(visor, bs_consulta, dtab_imp)
        ElseIf sender Is mod_ca_imp_search Then
            dtab_imp = Sql.leer(keyword, Microsoft.VisualBasic.Left(impuesto, 4), sender) 'Búsqueda de id para modificar cuenta agrupada
            visor = Data.ToDataGridView(visor, bs_consulta, dtab_imp)
        End If
        visor.Focus()
    End Sub

    Function deuda(ByVal deuda_total As Boolean, ByVal cuenta_agrupada As Boolean,
                   ByVal impuesto As String, ByVal filter As Integer, ByVal keyword As String,
                   ByVal range As Integer, ByVal dmin As Integer, ByVal dmax As Integer)
        progreso.Value = 5
        Dim consulta As New DataTable
        Dim sql As String
        '### Crear consulta sin filtros
        sql = "SELECT " & ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon,"

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
    Private Sub razon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            leer(razon.Text, ca_search)
        End If
    End Sub
    Private Sub ca_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        leer(razon.Text, sender)
    End Sub
    Private Sub mod_per_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With mod_per
            If razon.Text <> "" Then
                .Show()
                .Focus()
            End If
        End With
    End Sub
    Private Sub con_ca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(razon.Text) > 7 And Len(cuil.Text) = 11 And cuil.Text.Contains(dni.Text) Then
            grupo_con_ca.Visible = True
            grupo_buscar_ca.Enabled = False
            visor.DataSource = Nothing
            leer(razon.Text, sender)
        Else
            info.Text = "Faltan datos."
        End If
    End Sub
    Private Sub mod_ca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(razon.Text) > 7 And Len(cuil.Text) = 11 And cuil.Text.Contains(dni.Text) Then
            grupo_mod_ca.Visible = True
            grupo_buscar_ca.Enabled = False
            visor.DataSource = Nothing
            visor.Update()
            found = False
            dtab_mod_contrib = hac_contrib.leer(sender, cuil.Text)
        Else
            info.Text = "Faltan datos."
        End If
    End Sub
    '--------------------------
    Private Sub mod_ca_imp_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mod_ca_imp_search.Click
        leer(imp_razon.Text, sender)
    End Sub
    Private Sub imp_agua_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_agua.CheckedChanged
        reset_ca_imp()
        impuesto = "AGUA"
    End Sub
    Private Sub imp_auto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_auto.CheckedChanged
        reset_ca_imp()
        impuesto = "AUTO"
    End Sub
    Private Sub imp_cata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_cata.CheckedChanged
        imp_razon.Text = razon.Text
        reset_ca_imp()
        impuesto = "CATA"
    End Sub
    Private Sub imp_come_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_come.CheckedChanged
        reset_ca_imp()
        impuesto = "COME"
    End Sub
    Private Sub imp_sepe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_sepe.CheckedChanged
        reset_ca_imp()
        impuesto = "SEPE"
    End Sub
    '### EVENTOS DE LISTAS
    Private Sub imp_lista_mod_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Esto guarda los ID de los registros borrados para guardar los 
        'cambios correctamente después.
        If e.KeyCode = Keys.Delete Then
            save_ca.Enabled = True
            With bs_mod_contrib
                If IsDBNull(.Current("id")) = False Then
                    del_rows(ndel) = .Current("id")
                    found = True
                    ndel += 1
                End If
            End With
        End If
    End Sub
    Private Sub bs_contrib_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_contrib.CurrentChanged
        If bs_contrib.Position > -1 Then
            leer(bs_contrib.Current("codigo"), bs_contrib)
        End If
    End Sub
    Private Sub imp_lista_con_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Private Sub imp_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imp_add.Click
        Dim impuesto As String

        If imp_agua.Checked = True Then
            impuesto = "AGUA"
        ElseIf imp_auto.Checked = True Then
            impuesto = "AUTO"
        ElseIf imp_cata.Checked = True Then
            impuesto = "CATA"
        ElseIf imp_come.Checked = True Then
            impuesto = "COME"
        Else
            impuesto = "SEPE"
        End If
        With bs_mod_contrib
            .AddNew()
            .Current("impuesto") = impuesto
            .Current("codigo") = bs_consulta.Current("codigo")
            .Current("alta") = imp_alta.Value 'alta
            .EndEdit()
        End With
        save_ca.Enabled = True
        visor.Focus()
    End Sub
    Private Sub save_ca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_ca.Click
        Dim nupd, nins As Integer
        Dim fila As Integer = 0
        With imp_lista_mod
            If .RowCount > 0 Then
                Do While fila < .RowCount
                    If .Item(0, fila).Value.ToString = Nothing Then
                        bd.edit(My.Settings.DefaultCon, "INSERT INTO contribuyente(razon, cuil, impuesto, codigo, alta)
                                         VALUES ('" & razon.Text & "', " & cuil.Text & ", '" & .Item(1, fila).Value & "'," &
                                        " " & .Item(2, fila).Value & ", '" & .Item(3, fila).Value & "')")
                        nins += 1
                    Else
                        bd.edit(My.Settings.DefaultCon, "UPDATE contribuyente SET razon='" & razon.Text & "', impuesto='" & .Item(1, fila).Value &
                                        "', codigo=" & .Item(2, fila).Value & ", alta='" & .Item(3, fila).Value & "'" &
                                        " WHERE id=" & .Item(0, fila).Value)
                        nupd += 1
                    End If
                    fila += 1
                Loop
                ndel = 0
                If found = True Then
                    Do While ndel < del_rows.Count And del_rows(ndel) <> Nothing
                        bd.edit(My.Settings.DefaultCon, "DELETE FROM contribuyente WHERE id=" & del_rows(ndel))
                        ndel += 1
                    Loop
                End If
            Else
                If MsgBoxResult.Ok = MsgBox("Esto eliminará todos los registros de la cuenta agrupada, ¿desea continuar?.", MsgBoxStyle.OkCancel) Then
                    bd.edit(My.Settings.DefaultCon, "DELETE FROM contribuyente WHERE cuil=" & cuil.Text & ";")
                End If
            End If
            info.Text = nins & " nuevos registros, " & nupd & " registros modificados y " & ndel & " registros eliminados."
            'Resetear contadores y registro de eliminados
            nins = 0
            nupd = 0
            ndel = 0
            ReDim del_rows(99)
            dtab_mod_contrib = hac_contrib.leer(sender, cuil.Text)
            bs_mod_contrib.DataSource = dtab_mod_contrib
            imp_lista_mod.DataSource = bs_mod_contrib
            imp_lista_mod.Update()
            save_ca.Enabled = False
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

