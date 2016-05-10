Public Class config
    Private Sub config_Load(sender As Object, e As EventArgs) Handles Me.Load
        '### CONEXION FOX
        If foxcon <> "" Then
            conexion_fox.Text = foxcon
        End If
        '### CONEXION PSQL
        If pgsqlcon <> "" Then
            conexion_pgsql.Text = pgsqlcon
        End If
    End Sub

    '###### GUI
    Private Sub RestablecerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestablecerToolStripMenuItem.Click

        RestablecerToolStripMenuItem.Enabled = False
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim dtab_con As New DataTable
        If MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNo, "Configuración") = MsgBoxResult.Yes Then
            'Guardar conexiones
            validar_conexion(conexion_std, True)
            validar_conexion(conexion_fox, True)
            validar_conexion(conexion_pgsql, True)
            validar_conexion(conexion_acc, True)

            'Guardar tablas externas
            'Aguas

            'Auto

            'Catastro

            'Comercio

            'Sepelio


            RestablecerToolStripMenuItem.Enabled = False
            MsgBox("Configuración guardada correctamente.")
        End If
    End Sub
    Private Sub CerrarSinGuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSinGuardarToolStripMenuItem.Click
        Me.Close()
    End Sub

    '###### VALIDACION
    Private Sub conexion_std_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conexion_fox.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_cata_zonas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cata_zonas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_sepe_cuentas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sepe_cuentas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_sepe_historial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sepe_historial.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_sepe_muertos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sepe_muertos.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_sepe_variables_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sepe_variables.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_vehi_personas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles auto_personas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_vehi_cuentas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles auto_cuentas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_vehi_vencimientos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles auto_vencimientos.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_vehi_tipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles auto_tipo.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_come_personas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles come_personas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_come_cuentas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles come_cuentas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_come_historial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles come_historial.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_come_vencimientos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles come_vencimientos.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_come_actividades_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles come_actividades.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_come_variables_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles come_variables.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_agua_personas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agua_personas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_agua_cuentas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agua_cuentas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_agua_historial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agua_historial.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_agua_vencimientos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agua_vencimientos.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_agua_zonas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agua_zonas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_agua_variables_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agua_variables.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_cata_personas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cata_personas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_cata_cuentas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cata_cuentas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_cata_historial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cata_historial.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_cata_vencimientos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cata_vencimientos.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub
    Private Sub ext_sepe_personas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sepe_personas.TextChanged
        RestablecerToolStripMenuItem.Enabled = True
    End Sub

    '### RUTINAS
    Private Sub rutina_fecha_null_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rutina_fecha_null.Click
        Dim dtab_con As New DataTable
        Dim d, m, y, vence, pago, periodo As String
        d = Today.Day
        m = Today.Month
        y = Today.Year

        vence = ""
        pago = ""
        periodo = ""

        For imp As Integer = 0 To 4 Step 1 '5 impuestos
            If imp = 0 Then 'AGUA
                ext_cuenta = agua_cuentas.Text
                vence = "vencio"
                pago = "pago"
                periodo = "periodo"
            ElseIf imp = 1 Then 'AUTO
                ext_cuenta = auto_cuentas.Text
                vence = "vencimi1"
                pago = "apagado"
                periodo = "ano"
            ElseIf imp = 2 Then 'CATA
                ext_cuenta = cata_cuentas.Text
                vence = "vencio"
                pago = "pago"
                periodo = "periodo"
            ElseIf imp = 3 Then 'COME
                ext_cuenta = come_cuentas.Text
                vence = "vence1"
                pago = "pago"
                periodo = "ano"
            ElseIf imp = 4 Then 'SEPE
                ext_cuenta = sepe_cuentas.Text
                vence = "vencio"
                pago = "pago"
                periodo = "periodo"
            End If

            bd.edit(conexion_fox.Text, "UPDATE " & ext_cuenta & " SET " & vence & "=" & pago & " WHERE " & vence & " IS NULL AND " & pago & " IS NOT NULL")

            'Si no funciona
            dtab_con = bd.leer(conexion_fox.Text, "SELECT codigo, " & periodo & ", " & vence & " WHERE " & vence & " IS NULL FROM " & ext_cuenta)

            If dtab_con.Rows.Count > 0 Then
                Dim fila As Integer = 0
                Do While fila < dtab_con.Rows.Count
                    mod_sql = "UPDATE " & ext_cuenta & " SET " & vence & "=#" & Today.Day & "/" & Today.Month & "/" & dtab_con(fila)(periodo) & _
                    "# WHERE codigo=" & dtab_con(fila)("codigo") & " AND " & vence & " IS NULL"
                    bd.edit(conexion_fox.Text, mod_sql)
                Loop
            End If
        Next
    End Sub
    Private Sub validar_conexion(ByVal conexion As TextBox, ByVal save As Boolean)
        Dim dtab_con As New DataTable
        sel_sql = "SELECT * FROM opciones WHERE opcion='" & conexion.Name & "'"
        dtab_con = bd.leer(defcon, sel_sql)
        If Len(conexion.Text) < 11 Then 'Restaurar
            MsgBox("La conexión indicada para " & conexion.Name & " es inválida.")
            If dtab_con.Rows.Count > 0 Then
                conexion.Text = dtab_con(0)("valor")
            End If
        Else 'Crear o actualizar
            If save = True Then
                If dtab_con.Rows.Count = 0 Then
                    MsgBox("No se encuentra el registro de esta conexión, se creará uno nuevo.")
                    mod_sql = "INSERT INTO opciones(opcion, valor) VALUES '" & conexion.Name & "', '" & conexion.Text & "'"
                    bd.edit(defcon, mod_sql)
                Else
                    If conexion.Text <> dtab_con(0)("valor") Then
                        mod_sql = "UPDATE opciones SET valor='" & conexion.Text & "' WHERE opcion='" & conexion.Name & "'"
                        bd.edit(defcon, mod_sql)
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub cargar_tablas_ext()
        Dim dtab_ext As New DataTable
        dtab_ext.locale = System.Globalization.CultureInfo.CurrentCulture
        dtab_ext = bd.leer(defcon, "SELECT * FROM tablas_externas ORDER BY nombre")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS AGUA ##########################################################
            agua_personas.Text = dtab_ext(0)("nombre")
            agua_cuentas.Text = dtab_ext(1)("nombre")
            agua_historial.Text = dtab_ext(2)("nombre")
            agua_variables.Text = dtab_ext(3)("nombre")
            agua_vencimientos.Text = dtab_ext(4)("nombre")
            agua_zonas.Text = dtab_ext(5)("nombre")

            '#### TABLAS EXTERNAS VEHI ##########################################################
            auto_cuentas.Text = dtab_ext(6)("nombre")
            auto_personas.Text = dtab_ext(7)("nombre")
            auto_vencimientos.Text = dtab_ext(8)("nombre")
            auto_tipo.Text = dtab_ext(25)("nombre")
            '#### TABLAS EXTERNAS CATA ##########################################################
            cata_personas.Text = dtab_ext(9)("nombre")
            cata_cuentas.Text = dtab_ext(10)("nombre")
            cata_historial.Text = dtab_ext(11)("nombre")
            cata_vencimientos.Text = dtab_ext(12)("nombre")
            cata_zonas.Text = dtab_ext(13)("nombre")
            '#### TABLAS EXTERNAS COME ##########################################################
            come_actividades.Text = dtab_ext(14)("nombre")
            come_cuentas.Text = dtab_ext(15)("nombre")
            come_personas.Text = dtab_ext(16)("nombre")
            come_historial.Text = dtab_ext(17)("nombre")
            come_variables.Text = dtab_ext(18)("nombre")
            come_vencimientos.Text = dtab_ext(19)("nombre")
            '#### TABLAS EXTERNAS SEPE ##########################################################
            sepe_cuentas.Text = dtab_ext(20)("nombre")
            sepe_historial.Text = dtab_ext(21)("nombre")
            sepe_personas.Text = dtab_ext(22)("nombre")
            sepe_muertos.Text = dtab_ext(23)("nombre")
            sepe_variables.Text = dtab_ext(24)("nombre")
        End If
    End Sub

End Class