Public Class config
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '### CONEXION POR DEFECTO
        If defcon <> "" Then
            conexion_std.Text = defcon
        End If
        '### CONEXION ACCESS
        If adbcon <> "" Then
            conexion_acc.Text = adbcon
        End If
        '### CONEXION FOX
        If foxcon <> "" Then
            conexion_fox.Text = foxcon
        End If
        '### CONEXION PSQL
        If pgsqlcon <> "" Then
            conexion_pgsql.Text = pgsqlcon
        End If

        cargar_tablas_ext()
    End Sub

    '###### GUI
    Private Sub RestablecerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestablecerToolStripMenuItem.Click
        If defcon <> "" Then
            conexion_std.Text = defcon
        End If
        '### CONEXION ACCESS
        If adbcon <> "" Then
            conexion_acc.Text = adbcon
        End If
        '### CONEXION FOX
        If foxcon <> "" Then
            conexion_fox.Text = foxcon
        End If
        '### CONEXION PSQL
        If pgsqlcon <> "" Then
            conexion_pgsql.Text = pgsqlcon
        End If

        cargar_tablas_ext()

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
    Private Sub DetectarCambios() Handles conexion_std.TextChanged, conexion_acc.TextChanged,
                                          conexion_fox.TextChanged, conexion_pgsql.TextChanged,
                                          cata_cuentas.TextChanged, cata_historial.TextChanged,
                                          cata_personas.TextChanged, cata_vencimientos.TextChanged,
                                          come_actividades.TextChanged, come_cuentas.TextChanged,
                                          come_historial.TextChanged, come_personas.TextChanged,
                                          come_variables.TextChanged, come_vencimientos.TextChanged,
                                          auto_cuentas.TextChanged, auto_personas.TextChanged,
                                          auto_tipo.TextChanged, auto_vencimientos.TextChanged,
                                          grupo_auto.TextChanged,
                                          agua_cuentas.TextChanged, agua_historial.TextChanged,
                                          agua_personas.TextChanged, agua_variables.TextChanged,
                                          agua_vencimientos.TextChanged,
                                          sepe_cuentas.TextChanged, sepe_historial.TextChanged,
                                          sepe_muertos.TextChanged, sepe_personas.TextChanged,
                                          sepe_variables.TextChanged

        RestablecerToolStripMenuItem.Enabled = True
    End Sub

    '### RUTINAS
    Private Sub rutina_fecha_null_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rutina_fecha_null.Click

        If MsgBoxResult.Yes = MsgBox("Esto reemplazara las fechas con valor NULL en la base de datos seleccionada." & Chr(13) &
                                     "ESTA OPERACION NO SE PUEDE DESHACER." & Chr(13) &
                                     "Desea continuar?", MsgBoxStyle.Critical, "Reparar fechas en tablas Fox") Then
            RepararFechasNulas()
        End If
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
    Private Sub RepararFechasNulas()
        Dim d, m, y, cuenta, vence, pago, periodo As String
        Dim dtab As New DataTable
        d = Today.Day
        m = Today.Month
        y = Today.Year

        cuenta = ""
        vence = ""
        pago = ""
        periodo = ""



        For imp As Integer = 0 To 4 Step 1 '5 impuestos
            If imp = 0 Then 'AGUA
                cuenta = agua_cuentas.Text
                vence = "vencio"
                pago = "pago"
                periodo = "periodo"
            ElseIf imp = 1 Then 'AUTO
                cuenta = auto_cuentas.Text
                vence = "vencimi1"
                pago = "apagado"
                periodo = "ano"
            ElseIf imp = 2 Then 'CATA
                cuenta = cata_cuentas.Text
                vence = "vencio"
                pago = "pago"
                periodo = "periodo"
            ElseIf imp = 3 Then 'COME
                cuenta = come_cuentas.Text
                vence = "vence1"
                pago = "pago"
                periodo = "ano"
            ElseIf imp = 4 Then 'SEPE
                cuenta = sepe_cuentas.Text
                vence = "vencio"
                pago = "pago"
                periodo = "periodo"
            End If
        Next


        bd.edit(conexion_fox.Text, "UPDATE " & cuenta & " SET " & vence & "=" & pago & " WHERE " & vence & " IS NULL AND " & pago & " IS NOT NULL")

        'Si no funciona

        dtab = bd.leer(conexion_fox.Text, "SELECT codigo, " & periodo & ", " & vence & " WHERE " & vence & " IS NULL FROM " & cuenta)

        If dtab.Rows.Count > 0 Then
            Dim fila As Integer = 0
            Do While fila < dtab.Rows.Count
                mod_sql = "UPDATE " & cuenta & " SET " & vence & "=#" & Today.Day & "/" & Today.Month & "/" & dtab(fila)(periodo) &
                "# WHERE codigo=" & dtab(fila)("codigo") & " AND " & vence & " IS NULL"
                bd.edit(conexion_fox.Text, mod_sql)
            Loop
        End If
    End Sub

    Public Sub cargar_tablas_ext()
        Dim dtab_ext As New DataTable
        dtab_ext.Locale = System.Globalization.CultureInfo.CurrentCulture
        dtab_ext = bd.leer(defcon, "SELECT * FROM tablas_externas WHERE servicio='AGUA'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS AGUA ##########################################################
            agua_personas.Text = dtab_ext(0)("persona")
            agua_cuentas.Text = dtab_ext(0)("cuenta")
            agua_historial.Text = dtab_ext(0)("historial")
            agua_variables.Text = dtab_ext(0)("variable")
            agua_vencimientos.Text = dtab_ext(0)("vencimiento")
            agua_zonas.Text = dtab_ext(0)("zona")
        End If

        dtab_ext = bd.leer(defcon, "SELECT * FROM tablas_externas WHERE servicio='AUTO'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS AUTO ##########################################################
            auto_personas.Text = dtab_ext(0)("persona")
            auto_cuentas.Text = dtab_ext(0)("cuenta")
            auto_vencimientos.Text = dtab_ext(0)("vencimiento")
            auto_tipo.Text = dtab_ext(0)("tipo")
        End If

        dtab_ext = bd.leer(defcon, "SELECT * FROM tablas_externas WHERE servicio='CATA'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS CATA ##########################################################
            cata_personas.Text = dtab_ext(0)("persona")
            cata_cuentas.Text = dtab_ext(0)("cuenta")
            cata_historial.Text = dtab_ext(0)("historial")
            cata_vencimientos.Text = dtab_ext(0)("vencimiento")
            cata_zonas.Text = dtab_ext(0)("zona")
        End If

        dtab_ext = bd.leer(defcon, "SELECT * FROM tablas_externas WHERE servicio='COME'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS COME ##########################################################
            come_personas.Text = dtab_ext(0)("persona")
            come_cuentas.Text = dtab_ext(0)("cuenta")
            come_historial.Text = dtab_ext(0)("historial")
            come_variables.Text = dtab_ext(0)("variable")
            come_vencimientos.Text = dtab_ext(0)("vencimiento")
            come_actividades.Text = dtab_ext(0)("actividad")
        End If

        dtab_ext = bd.leer(defcon, "SELECT * FROM tablas_externas WHERE servicio='SEPE'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS SEPE ##########################################################
            sepe_personas.Text = dtab_ext(0)("persona")
            sepe_cuentas.Text = dtab_ext(0)("cuenta")
            sepe_historial.Text = dtab_ext(0)("historial")
            sepe_variables.Text = dtab_ext(0)("variable")
            sepe_muertos.Text = dtab_ext(0)("vencimiento")
        End If
    End Sub
End Class