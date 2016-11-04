﻿Public Class config
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '### CONEXION POR DEFECTO
        If my.settings.DefaultCon <> "" Then
            conexion_std.Text = my.settings.DefaultCon
        End If
        '### CONEXION ACCESS
        If my.settings.adbcon <> "" Then
            conexion_acc.Text = my.settings.adbcon
        End If
        '### CONEXION FOX
        If my.settings.foxcon <> "" Then
            conexion_fox.Text = my.settings.foxcon
        End If
        '### CONEXION PSQL
        If my.settings.pgsqlcon <> "" Then
            conexion_pgsql.Text = my.settings.pgsqlcon
        End If

        cargar_tablas_ext()
    End Sub

    '###### GUI
    Private Sub RestablecerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestablecerToolStripMenuItem.Click
        conexion_std.Text = My.Settings.DefaultAdbCon
        conexion_acc.Text = My.Settings.DefaultAdbCon
        conexion_fox.Text = My.Settings.DefaultFoxCon
        conexion_pgsql.Text = My.Settings.DefaultPgsqlCon

        cargar_tablas_ext()

        RestablecerToolStripMenuItem.Enabled = False
    End Sub
    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSinGuardarToolStripMenuItem.Click
        Dim dtab_con As New DataTable
        If MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNo, "Configuración") = MsgBoxResult.Yes Then
            'Guardar conexiones
            My.Settings.DefaultCon = conexion_std.Text
            My.Settings.foxcon = conexion_fox.Text
            My.Settings.pgsqlcon = conexion_pgsql.Text
            My.Settings.adbcon = conexion_acc.Text

            RestablecerToolStripMenuItem.Enabled = False
            MsgBox("Configuración guardada correctamente.")
        End If
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

        dtab = bd.read(conexion_fox.Text, "SELECT codigo, " & periodo & ", " & vence & " WHERE " & vence & " IS NULL FROM " & cuenta)

        For Each drow As DataRow In dtab.Rows
            bd.edit(conexion_fox.Text,
                    "UPDATE " & cuenta & " SET " & vence & "=#" & Today.Day & "/" & Today.Month & "/" & drow(periodo) & "#
                    WHERE codigo=" & drow("codigo") & " AND " & vence & " IS NULL")
        Next
    End Sub

    Public Sub cargar_tablas_ext()
        Dim dtab_ext As New DataTable
        dtab_ext.Locale = System.Globalization.CultureInfo.CurrentCulture
        dtab_ext = bd.read(my.settings.DefaultCon, "SELECT * FROM tablas_externas WHERE servicio='AGUA'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS AGUA ##########################################################
            agua_personas.Text = dtab_ext(0)("persona")
            agua_cuentas.Text = dtab_ext(0)("cuenta")
            agua_historial.Text = dtab_ext(0)("historial")
            agua_variables.Text = dtab_ext(0)("variable")
            agua_vencimientos.Text = dtab_ext(0)("vencimiento")
            agua_zonas.Text = dtab_ext(0)("zona")
        End If

        dtab_ext = bd.read(my.settings.DefaultCon, "SELECT * FROM tablas_externas WHERE servicio='AUTO'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS AUTO ##########################################################
            auto_personas.Text = dtab_ext(0)("persona")
            auto_cuentas.Text = dtab_ext(0)("cuenta")
            auto_vencimientos.Text = dtab_ext(0)("vencimiento")
            auto_tipo.Text = dtab_ext(0)("tipo")
        End If

        dtab_ext = bd.read(my.settings.DefaultCon, "SELECT * FROM tablas_externas WHERE servicio='CATA'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS CATA ##########################################################
            cata_personas.Text = dtab_ext(0)("persona")
            cata_cuentas.Text = dtab_ext(0)("cuenta")
            cata_historial.Text = dtab_ext(0)("historial")
            cata_vencimientos.Text = dtab_ext(0)("vencimiento")
            cata_zonas.Text = dtab_ext(0)("zona")
        End If

        dtab_ext = bd.read(my.settings.DefaultCon, "SELECT * FROM tablas_externas WHERE servicio='COME'")
        If dtab_ext.Rows.Count > 0 Then
            '#### TABLAS EXTERNAS COME ##########################################################
            come_personas.Text = dtab_ext(0)("persona")
            come_cuentas.Text = dtab_ext(0)("cuenta")
            come_historial.Text = dtab_ext(0)("historial")
            come_variables.Text = dtab_ext(0)("variable")
            come_vencimientos.Text = dtab_ext(0)("vencimiento")
            come_actividades.Text = dtab_ext(0)("actividad")
        End If

        dtab_ext = bd.read(my.settings.DefaultCon, "SELECT * FROM tablas_externas WHERE servicio='SEPE'")
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