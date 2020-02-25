Public Class CalcAnualImpUI
    Dim dtab_var As New DataTable
    Dim cuentas_modificadas As Integer
    Dim total_cuotas As Integer

    'Rutinas
    Public Function Validar() As Boolean
        Dim sql(0) As String
        sql(0) = "SELECT MAX(codigo) as codigo FROM " & impuesto.Text
        Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
        If dtab.Rows.Count > 0 Then
            If CuentaInicial.Value > dtab(0)("codigo") Then
                MsgBox("No se encuentra la cuenta inicial.", MsgBoxStyle.OkOnly, Nothing)
            Else
                info.Text = "Leyendo datos.."
                info.Refresh()
                'Generar cuotas
                If impuesto.Text = "AGUAS" Then
                    Agua()
                ElseIf impuesto.Text = "AUTOMOVIL" Then
                    Auto()
                ElseIf impuesto.Text = "CATASTRO" Then
                    Catastro()
                ElseIf impuesto.Text = "COMERCIO" Then
                    Comercio()
                ElseIf impuesto.Text = "SEPELIO" Then
                    Sepelio()
                End If

            End If
        End If
    End Function

    Public Sub Agua()
        Dim dtab(3) As DataTable
        Dim sqlInsertList(0) As String
        Dim sql(0) As String

        'Tablas: Zonas, Vence, Cuentas,  Deudas
        CalculoAnual.sql.Agua.CargarTablas(dtab, periodo.Value, CuentaInicial.Value)

        cuentas_modificadas = 0
        total_cuotas = 0

        'Iniciar busqueda y reemplazo
        progreso.Maximum = dtab(2).Rows.Count - 1

        For Each dr As DataRow In dtab(2).Rows
            Dim reside, comercio, industria, importe, franqueo As New Decimal
            Dim cuota, cuota_max As New Integer
            Dim cuota_mod As New Integer

            'Residencial
            If dr("potable") = 1 Then
                reside = dtab(0)(0)("resido")
            End If
            'Comercial
            If dr("comercial") = 1 Then
                comercio = dtab(0)(0)("comercio")
            End If
            'Industrial
            If dr("industrial") = 1 Then
                industria = dtab(0)(0)("industria")
            End If
            importe = reside + comercio + industria

            'Minimo
            If importe < dtab(0)(0)("minimo") Then
                importe = dtab(0)(0)("minimo")
            End If

            'Franqueo
            franqueo = dtab_var(0)("franqueo")

            'Total
            importe += franqueo

            'Ingresar cuotas
            cuota_max = 6
            cuota = 1
            Do While cuota <= cuota_max
                If CalculoAnual.sql.Agua.VerificarCuota(dr, cuota, periodo.Value, dtab(3)) Then
                    'No existente
                    cuota_mod += 1
                    ReDim Preserve sqlInsertList(total_cuotas)
                    sqlInsertList(total_cuotas) = CalculoAnual.sql.Agua.InsertarCuota(dr, cuota, periodo.Value, importe, dtab(1)(0),
                                                            reside, comercio, industria, franqueo)
                    total_cuotas += 1
                End If
                cuota += 1
            Loop

            If cuota_mod > 0 Then
                cuentas_modificadas += 1
            End If
            CheckProgress(dtab(2).Rows.IndexOf(dr), dr("codigo"))
        Next
        If total_cuotas > 0 Then
            DbMan.editDB(Nothing, My.Settings.foxConnection, Nothing, True, sqlInsertList, progreso)
        End If
    End Sub

    Public Sub Auto()
        Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
        Dim sqlInsertList(0) As String
        Dim sql(0) As String

        cuentas_modificadas = 0
        total_cuotas = 0

        'Vencimientos
        sql(0) = "SELECT * FROM autovence
								 WHERE periodo=" & periodo.Value
        dtab_vence = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        'Cuentas
        sql(0) = "SELECT codigo, razon, marca, modelo, apagar FROM automovil
								 WHERE apagar>0 AND baja={}
								 AND codigo=>" & CuentaInicial.Value & " ORDER BY codigo"
        dtab_cuenta = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        sql(0) = "SELECT * FROM autocue"
        dtab_deuda = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        For Each dr As DataRow In dtab_cuenta.Rows
            Dim importe As New Decimal
            Dim cuota As New Integer
            Dim cuota_max As New Integer
            Dim cuota_mod As New Integer


            importe = dr("apagar")
            cuota = 1
            cuota_max = 4
            Do While cuota <= cuota_max
                If CalculoAnual.sql.Auto.VerificarCuota(dr, cuota, periodo.Value, dtab_deuda) Then
                    cuota_mod += 1
                    ReDim Preserve sqlInsertList(total_cuotas)
                    sqlInsertList(total_cuotas) = CalculoAnual.sql.Auto.InsertarCuota(dr, cuota, periodo.Value, importe, dtab_vence(0))
                    total_cuotas += 1
                End If
                cuota += 1
            Loop
            If cuota_mod > 0 Then
                cuentas_modificadas += 1
            End If
            cuota_mod = 0
            CheckProgress(dtab_cuenta.Rows.IndexOf(dr), dr("codigo"))
        Next

        If total_cuotas > 0 Then
            DbMan.editDB(Nothing, My.Settings.foxConnection, Nothing, True, sqlInsertList, progreso)
        End If
    End Sub

    Public Sub Catastro()
        'Dim  dtab_vence, dtab_cuenta, dtab_deuda As DataTable
        Dim cuota, cuota_max As Integer
        Dim sql(2) As String
        Dim dtab(2) As DataTable
        Dim sqlInsertList(0) As String
        dtab = CalculoAnual.sql.Catastro.CargarTablas(dtab, periodo.Value, CuentaInicial.Value)

        cuentas_modificadas = 0
        total_cuotas = 0

        progreso.Maximum = dtab(1).Rows.Count - 1

        For Each dr As DataRow In dtab(1).Rows
            Dim basica, minimo, baldio, alumbrado, pasillo, agrario, comercio, jubilado,
            vereda, parque, taecat, franqueo, importe, subtotal As New Decimal
            Dim metros As Decimal = 0

            Dim cuota_added As New Integer


            'Calculo de importes
            basica = 0

            If dr("frente1") > 0 Then  'ESQUINA
                Dim frentes As Integer = 0
                metros += dr("frente1")
                frentes += 1

                If dr("zona") < 4 Then
                    If dr("frente2") > 0 Then
                        metros += dr("frente2")
                        frentes += 1
                    End If
                    If dr("frente3") > 0 Then
                        metros += dr("frente3")
                        frentes += 1
                    End If
                    If dr("frente4") > 0 Then
                        metros += dr("frente4")
                        frentes += 1
                    End If
                    If dr("esquino") = 1 Then
                        metros /= frentes
                    End If
                End If
                basica = dr("monto_unidad") * metros
            End If

            If dr("zona") = 6 Then
                'LOTEOS Y BARRIOS PRIVADOS
                If dr("frente1") > 2500 Then 'M2
                    basica = dr("monto_fijo4")
                ElseIf dr("frente1") > 1249 Then 'M2
                    basica = dr("monto_fijo3")
                ElseIf dr("frente1") > 799 Then 'M2
                    basica = dr("monto_fijo2")
                Else
                    basica = dr("monto_fijo1")
                End If
            ElseIf dr("zona") = 5 Then 'ZONA 5
                Dim fraccion As Integer = dr("frente1") / 200
                If dr("frente1") Mod 200 > 0 Then
                    fraccion += 1
                End If
                basica = dr("monto_unidad") * fraccion
            End If

            'Pasillo
            pasillo = 0
            If dr("pasillo") = 1 And dr("frente1") < 11 Then
                pasillo = dr("monto_pasillo")
                basica = pasillo
            End If

            'Minimo
            minimo = dr("monto_minimo")
            If basica < minimo Then
                basica = minimo
            End If

            'TAE
            taecat = basica * (dtab_var(0)("taecat") / 100)

            subtotal = basica + taecat

            'Baldio
            If dr("baldio") = 1 Then
                'Recargo por alumbrado en baldío en zonas 1-5
                If dr("zona") < 5 Then

                    If metros <= 15 Then
                        alumbrado = dr("alumbrado_minimo")
                    Else
                        alumbrado = dr("alumbrado_basico") * metros
                    End If

                    'Recargo por baldío en zonas 1-3
                    If dr("zona") < 4 Then
                        baldio = subtotal * (dr("rec_baldio") / 100)
                    End If
                End If

                'Descuento por vereda
                If dr("vereda") = 1 Then
                    vereda = subtotal * (dr("desc_vereda") / 100)
                End If
                'Descuento por parquizado
                If dr("parque") = 1 Then
                    parque = subtotal * (dr("desc_parque") / 100)
                End If

            End If

            'Recargo Actividad Comercial
            comercio = 0
            If dr("comercial") > 1 Then
                Dim tipo_comercio As Integer = dr("comercial") - 1
                comercio = subtotal * (dr("rec_comercio" & tipo_comercio) / 100)
            End If

            'Descuento por Actividad Agropecuaria (Agrario)
            agrario = 0
            If dr("agrario") = 1 Then
                If dr("frente1") > 100 Then
                    agrario = subtotal * (dr("desc_agrario2") / 100)
                ElseIf dr("frente1") > 50 Then
                    agrario = subtotal * (dr("desc_agrario1") / 100)
                End If
            End If

            'Descuento por Jubilado
            jubilado = 0
            If dr("jubilado") = 1 Then
                jubilado = subtotal * (dr("desc_jubilado") / 100)
            End If

            'Calcular recargos
            subtotal = subtotal + baldio + comercio + alumbrado
            'Calcular descuentos
            subtotal -= (vereda + parque + agrario + jubilado)

            'Franqueo
            franqueo = dtab_var(0)("franqueo") * 6

            'Total
            importe = subtotal + franqueo

            'Cuotas
            cuota = 1
            cuota_max = 6
            Do While cuota <= cuota_max
                If CalculoAnual.sql.Catastro.VerificarCuota(dr, cuota, periodo.Value, dtab(2)) Then
                    cuota_added += 1
                    ReDim Preserve sqlInsertList(total_cuotas)
                    sqlInsertList(total_cuotas) = CalculoAnual.sql.Catastro.InsertarCuota(dr, cuota, periodo.Value, importe,
                                                                   dtab(0)(0), minimo, basica, baldio, jubilado, pasillo,
                                                                   agrario, comercio, alumbrado, vereda, parque, franqueo, taecat)
                    total_cuotas += 1
                End If
                cuota += 1
            Loop

            If cuota_added > 0 Then
                cuentas_modificadas += 1
            End If
            CheckProgress(dtab(1).Rows.IndexOf(dr), dr("codigo"))
        Next
        If total_cuotas > 0 Then
            DbMan.editDB(Nothing, My.Settings.foxConnection, Nothing, True, sqlInsertList, progreso)
        End If
    End Sub

    Public Sub Comercio()
        Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
        Dim minimo, taecom, importe, franqueo As New Decimal
        Dim cuota_max As Integer
        Dim sqlInsertList(0) As String
        Dim sql(3) As String

        cuentas_modificadas = 0
        total_cuotas = 0
        'Vencimientos
        sql(0) = "SELECT * "
        sql(1) = "FROM comvence"
        sql(2) = "WHERE periodo=" & periodo.Value
        sql(3) = ""
        dtab_vence = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        'Cuentas
        sql(0) = "SELECT comercio.codigo as codigo, comercio.cantidad, 
                         comercio.actividad as actividad, comact.detalle,
		    			 comact.tributo, comact.cuotas, 
                         comact.cuota1, comact.cuota2, comact.cuota3,
                         comact.cuota4,comact.cuota5,comact.cuota6"
        sql(1) = "FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
        sql(2) = "WHERE comercio.baja = {} AND comact.cuota1>0 AND comercio.codigo=>" & CuentaInicial.Value
        sql(3) = "ORDER BY comercio.codigo"

        dtab_cuenta = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        'Deudas
        sql(0) = "SELECT *"
        sql(1) = "FROM comcue"
        sql(2) = "WHERE agrupado='' AND pago={} AND ano=" & periodo.Value & " AND codigo=> " & CuentaInicial.Value
        sql(3) = "ORDER BY codigo"

        dtab_deuda = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        For Each dr As DataRow In dtab_cuenta.Rows
            Dim cuota_added As New Integer
            Dim vence As Date = Date.Today


            If dr("cuotas") > 0 Then
                cuota_max = dr("cuotas")

                For ncuota As Integer = 1 To cuota_max
                    If cuota_max = 1 Or cuota_max = 6 Then
                        minimo = dr("cuota" & ncuota)
                        vence = dtab_vence(0)("vence" & ncuota)
                    Else
                        If ncuota = 1 Then
                            minimo = dr("cuota1")
                            vence = dtab_vence(0)("vence1")
                        ElseIf ncuota = 2 Then
                            If cuota_max = 2 Then
                                minimo = dr("cuota4")
                                vence = dtab_vence(0)("vence4")
                            ElseIf cuota_max = 3 Then
                                minimo = dr("cuota3")
                                vence = dtab_vence(0)("vence3")
                            End If
                        ElseIf ncuota = 3 And cuota_max = 3 Then
                            minimo = dr("cuota5")
                            vence = dtab_vence(0)("vence5")
                        End If
                    End If
                    If dr("cantidad") > 1 Then
                        minimo *= dr("cantidad")
                    End If

                    taecom = minimo * (dtab_var(0)("taecom") / 100)
                    franqueo = dtab_var(0)("franqueo")
                    importe = minimo + taecom + franqueo

                    If CalculoAnual.sql.Comercio.VerificarCuota(dr, ncuota, dtab_deuda) Then
                        cuota_added += 1
                        ReDim Preserve sqlInsertList(total_cuotas)
                        sqlInsertList(total_cuotas) = CalculoAnual.sql.Comercio.InsertarCuota(dr, ncuota, periodo.Value, minimo, taecom,
                                                                                                franqueo, importe, vence)
                        total_cuotas += 1
                    End If

                Next
            End If
            If cuota_added > 0 Then
                cuentas_modificadas += 1
            End If
            CheckProgress(dtab_cuenta.Rows.IndexOf(dr), dr("codigo"))
        Next
        If total_cuotas > 0 Then
            DbMan.editDB(Nothing, My.Settings.foxConnection, Nothing, True, sqlInsertList, progreso)
        End If
    End Sub

    Public Sub Sepelio()
        Dim dtab_cuenta, dtab_deuda As DataTable
        Dim sqlInsertList(0) As String
        Dim sql(5) As String
        'Vencimientos
        Dim vence As New Date(periodo.Value, 1, 1)
        cuentas_modificadas = 0
        total_cuotas = 0
        Do While vence.DayOfWeek <> DayOfWeek.Monday
            vence = vence.AddDays(1)
        Loop
        'Cuentas
        sql(0) = "SELECT sepelio.codigo as codigo, sepelio.fila as fila, sepelio.jubilado as jubilado, 
                         sepevar.minimo as minimo, sepelio.espacio as espacio, sepevar.jubilado as desc_jubilado, 
                         sepevar.fila1 as fila1, sepevar.fila2 as fila2, sepevar.fila3 as fila3,
		    			 sepevar.fila4 as fila4, sepevar.fila5 as fila5, sepelio.ubicacion as ubicacion, sepelio.tipo as tipo"
        sql(1) = "FROM sepelio JOIN sepevar ON sepelio.tipo=sepevar.orden"
        sql(2) = "WHERE sepelio.tipo > 0 AND sepelio.codigo =>" & CuentaInicial.Value
        sql(3) = "ORDER BY sepelio.codigo"
        dtab_cuenta = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        sql(0) = "SELECT *"
        sql(1) = "FROM sepecue"
        sql(2) = ""
        sql(3) = ""
        dtab_deuda = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        Dim jubilado, importe As Decimal
        For Each dr As DataRow In dtab_cuenta.Rows
            Dim cuota_mod As New Integer
            jubilado = 0
            importe = 0

            If dr("fila") > 0 Then
                importe = dr("fila" & dr("fila"))
            End If

            If importe < dr("minimo") Then
                importe = dr("minimo")
            End If

            importe *= dr("espacio")

            If dr("jubilado") = 1 Then
                jubilado = importe * (dr("desc_jubilado") / 100)
                importe -= jubilado
            End If

            If CalculoAnual.sql.Sepelio.VerificarCuota(dr, periodo.Value, dtab_deuda) Then
                cuota_mod += 1
                ReDim Preserve sqlInsertList(total_cuotas)
                sqlInsertList(total_cuotas) = CalculoAnual.sql.Sepelio.InsertarCuota(dr, periodo.Value, importe, vence)

                total_cuotas += 1
            End If
            If cuota_mod > 0 Then
                cuentas_modificadas += 1
            End If
            CheckProgress(dtab_cuenta.Rows.IndexOf(dr), dr("codigo"))
        Next
        If total_cuotas > 0 Then
            DbMan.editDB(Nothing, My.Settings.foxConnection, Nothing, True, sqlInsertList, progreso)
        End If
    End Sub

    Public Sub CheckProgress(fila As Integer, cuenta As Integer)
        If fila > 0 And cuenta > 0 Then
            If fila = progreso.Maximum Then
                progreso.Value = progreso.Minimum
                info.Text = fila & " cuentas procesadas, " & total_cuotas & " cuotas en " & cuentas_modificadas & " cuentas."
            Else
                progreso.Value = fila
                info.Text = "Procesando cuenta Nro. " & cuenta
            End If
        Else
            info.Text = "Esperando datos."
        End If
        info.Refresh()
    End Sub

    'Eventos
    Private Sub CalculoAnualImpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql(0) As String
        periodo.Maximum = Today.Year + 5
        periodo.Minimum = 1990
        periodo.Value = Today.Year

        sql(0) = "SELECT * FROM numeros"
        dtab_var = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
    End Sub

    Private Sub Impuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles impuesto.SelectedIndexChanged
        tae.Text = 0
        If impuesto.Text = "COMERCIO" Then
            tae.Text = dtab_var(0)("taecom").ToString
        ElseIf impuesto.Text = "CATASTRO" Then
            tae.Text = dtab_var(0)("taecat").ToString
        End If
        tae.Text += "%"
    End Sub

    Private Sub Iniciar_Click(sender As Object, e As EventArgs) Handles iniciar.Click
        Dim time_start, time_end As DateTime
        Dim run_time As TimeSpan
        time_start = Now
        iniciar.Visible = False
        Validar()
        iniciar.Visible = True
        time_end = Now
        run_time = time_end - time_start
        info.Text += Chr(13) & "Procesado en " & run_time.Minutes & " minuto/s, " & run_time.Seconds & " segundo/s."
    End Sub

End Class