Public Class config
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' CONEXION POR DEFECTO
        If My.Settings.CurrentDB <> "" Then
			conexion_std.Text = My.Settings.CurrentDB
		End If
        ' CONEXION ACCESS
        If My.Settings.AdbConnection <> "" Then
			conexion_acc.Text = My.Settings.AdbConnection
		End If
        ' CONEXION FOX
        If My.Settings.foxConnection <> "" Then
			conexion_fox.Text = My.Settings.foxConnection
		End If
        ' CONEXION PSQL
        If My.Settings.pgsqlCon_disabled <> "" Then
			conexion_pgsql.Text = My.Settings.pgsqlCon_disabled
		End If

        CargarTablasExternas()
    End Sub

    ' GUI
    Private Sub RestablecerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestablecerToolStripMenuItem.Click

        CargarTablasExternas()

        RestablecerToolStripMenuItem.Enabled = False
	End Sub
	Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSinGuardarToolStripMenuItem.Click
        If MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNo, "Configuración") = MsgBoxResult.Yes Then
            'Guardar conexiones
            RestablecerToolStripMenuItem.Enabled = False
            MsgBox("Configuración guardada correctamente.")
        End If
        Me.Close()
	End Sub

    ' VALIDACION
    Private Sub DetectarCambios() Handles conexion_std.TextChanged, conexion_acc.TextChanged,
										  conexion_fox.TextChanged, conexion_pgsql.TextChanged,
										  cata_cuentas.TextChanged, cata_historial.TextChanged,
										  cata_personas.TextChanged, cata_vencimientos.TextChanged,
										  come_actividades.TextChanged, come_cuentas.TextChanged,
										  come_historial.TextChanged, come_personas.TextChanged,
										  come_variables.TextChanged, come_vencimientos.TextChanged,
										  auto_cuentas.TextChanged, auto_personas.TextChanged,
										  auto_tipo.TextChanged, auto_vencimientos.TextChanged,
										  agua_cuentas.TextChanged, agua_historial.TextChanged,
										  agua_personas.TextChanged, agua_variables.TextChanged,
										  agua_vencimientos.TextChanged,
										  sepe_cuentas.TextChanged, sepe_historial.TextChanged,
										  sepe_muertos.TextChanged, sepe_personas.TextChanged,
										  sepe_variables.TextChanged

		RestablecerToolStripMenuItem.Enabled = True
	End Sub

    ' RUTINAS
    Private Sub rutina_fecha_null_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

		If MsgBoxResult.Yes = MsgBox("Esto reemplazara las fechas con valor NULL en la base de datos seleccionada." & Chr(13) &
									 "ESTA OPERACION NO SE PUEDE DESHACER." & Chr(13) &
									 "Desea continuar?", MsgBoxStyle.Critical, "Reparar fechas en tablas Fox") Then
			RepararFechasNulas()
		End If
	End Sub

    Private Sub RepararFechasNulas()
        Dim d, m, y, cuenta, vence, pago, periodo As String


        d = Today.Day
        m = Today.Month
        y = Today.Year

        cuenta = ""
        vence = ""
        pago = ""
        periodo = ""


        For imp As Integer = 0 To 4 Step 1 '5 impuestos
            Dim sqlSelect As String
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

            DbMan.EditDB("UPDATE " & cuenta & " 
                            SET " & vence & "=" & pago & " 
                          WHERE " & vence & " IS NULL AND " & pago & " IS NOT NULL",
                         conexion_fox.Text)

            'Si no funciona
            sqlSelect = "SELECT codigo, " & periodo & ", " & vence & " WHERE " & vence & " Is NULL FROM " & cuenta
            Dim dtab As DataTable = ReadDB(sqlSelect, conexion_fox.Text)
            Dim sqlUpdateList(dtab.Rows.Count) As String

            For Each dr As DataRow In dtab.Rows

                sqlUpdateList(dtab.Rows.IndexOf(dr)) = "UPDATE " & cuenta & " 
                                                           SET " & vence & "=#" & Today.Day & "/" & Today.Month & "/" & dr(periodo).ToString & "#
                                                         WHERE codigo=" & dr("codigo").ToString & " AND " & vence & " IS NULL"
            Next
            DbMan.EditDB(sqlUpdateList, conexion_fox.Text)
            dtab.Dispose()
        Next
    End Sub

    Public Sub CargarTablasExternas()
        Dim dtab_ext As New DataTable With {
            .Locale = System.Globalization.CultureInfo.CurrentCulture
        }

        dtab_ext = DbMan.ReadDB("SELECT * FROM tablas_externas WHERE personas='aguas'", My.Settings.CurrentDB)

        If dtab_ext.Rows.Count > 0 Then
            ' TABLAS EXTERNAS AGUA 
            agua_personas.Text = dtab_ext.Rows(0)("personas")
            agua_cuentas.Text = dtab_ext.Rows(0)("cuentas")
            agua_historial.Text = dtab_ext.Rows(0)("historial")
            agua_variables.Text = dtab_ext.Rows(0)("variables")
            agua_vencimientos.Text = dtab_ext.Rows(0)("vencimientos")
            agua_zonas.Text = dtab_ext.Rows(0)("zona")
        End If

        dtab_ext = DbMan.ReadDB("SELECT * FROM tablas_externas WHERE  personas='automovil'", My.Settings.CurrentDB)

        If dtab_ext.Rows.Count > 0 Then
            ' TABLAS EXTERNAS AUTO 
            auto_personas.Text = dtab_ext.Rows(0)("personas")
            auto_cuentas.Text = dtab_ext.Rows(0)("cuentas")
            auto_vencimientos.Text = dtab_ext.Rows(0)("vencimientos")
            auto_tipo.Text = dtab_ext.Rows(0)("tipo")
        End If

        dtab_ext = DbMan.ReadDB("SELECT * FROM tablas_externas WHERE  personas='catastro'", My.Settings.CurrentDB)

        If dtab_ext.Rows.Count > 0 Then
            ' TABLAS EXTERNAS CATA 
            cata_personas.Text = dtab_ext.Rows(0)("personas")
            cata_cuentas.Text = dtab_ext.Rows(0)("cuentas")
            cata_historial.Text = dtab_ext.Rows(0)("historial")
            cata_vencimientos.Text = dtab_ext.Rows(0)("vencimientos")
            cata_zonas.Text = dtab_ext.Rows(0)("zona")
        End If

        dtab_ext = DbMan.ReadDB("SELECT * FROM tablas_externas WHERE  personas='comercio'", My.Settings.CurrentDB)

        If dtab_ext.Rows.Count > 0 Then
            ' TABLAS EXTERNAS COME 
            come_personas.Text = dtab_ext.Rows(0)("personas")
            come_cuentas.Text = dtab_ext.Rows(0)("cuentas")
            come_historial.Text = dtab_ext.Rows(0)("historial")
            come_variables.Text = dtab_ext.Rows(0)("variables")
            come_vencimientos.Text = dtab_ext.Rows(0)("vencimientos")
            come_actividades.Text = dtab_ext.Rows(0)("actividad")
        End If

        dtab_ext = DbMan.ReadDB("SELECT * FROM tablas_externas WHERE  personas='sepelio'", My.Settings.CurrentDB)

        If dtab_ext.Rows.Count > 0 Then
            ' TABLAS EXTERNAS SEPE 
            sepe_personas.Text = dtab_ext.Rows(0)("personas")
            sepe_cuentas.Text = dtab_ext.Rows(0)("cuentas")
            sepe_historial.Text = dtab_ext.Rows(0)("historial")
            sepe_variables.Text = dtab_ext.Rows(0)("variables")
            sepe_muertos.Text = dtab_ext.Rows(0)("muertos")
        End If
    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
        '>> Ventana de importacion de base de datos
        'Permite seleccionar bd de origen y de destino
        'Compara los nombres de las tablas en ambas bd
        'Crea las tablas que no existen en la bd de destino
        'Actualiza registros ya existentes (usando el ID unico en la tabla)
        'Inserta registros no encontrados en la tablas de la bd de destino
        'No elimina registros
        'Genera log de acciones sobre bd de destino

        Using visor As New GenDataUI
            visor.LoadDtab(DbMan.readTableSchema())
            visor.ShowDialog()
            Dim sourceTables As DataTable = DbMan.readTableSchema()
            Dim destTables As DataTable = DbMan.readTableSchema()
            For Each dr As DataRow In destTables.Rows
                If dr("TABLE_TYPE").ToString = "TABLE" Then
                    destTables.Rows.Find(dr("TABLE_NAME"))
                    'TODO

                End If
            Next
        End Using
    End Sub

	Private Sub DetectarCambios(sender As Object, e As EventArgs)

	End Sub
End Class