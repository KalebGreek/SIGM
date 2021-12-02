Public Class CalcAnualImpUI
    Dim cuentas_modificadas As Integer
    Dim total_cuotas As Integer

    'Eventos
    Private Sub CalculoAnualImpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        periodo.Maximum = Today.Year + 5
        periodo.Minimum = 1990
        periodo.Value = Today.Year

        bs_variables.DataSource = DbMan.ReadDB("SELECT * FROM numeros", My.Settings.foxConnection)
    End Sub

    Private Sub Impuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles impuesto.SelectedIndexChanged
        Dim source As DataRowView = bs_variables.Current
        tae.Text = 0
        If impuesto.Text = "COMERCIO" Then
            tae.Text = source("taecom").ToString
        ElseIf impuesto.Text = "CATASTRO" Then
            tae.Text = source("taecat").ToString
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


    'Rutinas
    Public Sub Validar()
        Dim dtab As DataTable = DbMan.ReadDB("SELECT MAX(codigo) as codigo FROM " & impuesto.Text, My.Settings.foxConnection)
        If dtab.Rows.Count > 0 Then
            If CuentaInicial.Value > dtab.Rows(0)("codigo").ToString Then
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
    End Sub

    Public Sub Agua()
        Dim variables As DataRowView = bs_variables.Current
        Dim dtab(3) As DataTable
        Dim sqlInsertList(0) As String
        Dim sql(0) As String

        'Tablas: Zonas, Vence, Cuentas,  Deudas
        CalcAnualImp.Sql.Agua.CargarTablas(dtab, periodo.Value, CuentaInicial.Value)

        cuentas_modificadas = 0
        total_cuotas = 0

        'Iniciar busqueda y reemplazo
        progreso.Maximum = dtab(2).Rows.Count - 1

        For Each dr As DataRow In dtab(2).Rows

            Dim reside, comercio, industria, excedente, original, importe, franqueo As New Decimal
            Dim cuota, cuota_max As New Integer
            Dim cuota_mod As New Integer
            Dim tipo As Integer = dr("tipo")
            Dim cantidad As Integer = dr("cantidad")


            'Solo se puede generar deduda anual sobre usuarios sin medidor
            If tipo <> 2 Or tipo <> 5 Then
                'Residencial
                If tipo = 1 Then
                    original = dtab(0)(0)("importe")
                    excedente = dtab(0)(1)("excedente")
                    If cantidad > 1 Then
                        reside = original * ((1 + (CInt(excedente / 100) * cantidad)))
                    Else
                        reside = original
                    End If
                    'Comercial
                ElseIf tipo = 3 Then
                    comercio = dtab(0)(2)("importe")
                ElseIf tipo = 4 Then
                    comercio = dtab(0)(3)("importe")
                    'Industrial
                ElseIf tipo = 6 Then
                    industria = dtab(0)(5)("importe")
                End If
                importe = reside + comercio + industria

                franqueo = 0

                'Ingresar cuotas
                cuota_max = 6
                cuota = 1
                Do While cuota <= cuota_max
                    If CalcAnualImp.Sql.Agua.VerificarCuota(dr, cuota, periodo.Value, dtab(3)) Then
                        'No existente
                        cuota_mod += 1
                        ReDim Preserve sqlInsertList(total_cuotas)
                        sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Agua.InsertarCuota(dr, cuota, periodo.Value, importe, dtab(1)(0),
                                                                reside, comercio, industria, franqueo)
                        total_cuotas += 1
                    End If
                    cuota += 1
                Loop

                If cuota_mod > 0 Then
                    cuentas_modificadas += 1
                End If
            Else
                'Usuario con medidor: se genera la deuda cada dos meses basada en las lecturas
            End If
            CheckProgress(dtab(2).Rows.IndexOf(dr), CInt(dr("codigo")))
        Next
        If total_cuotas > 0 Then
            DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
        End If
    End Sub

    Public Sub Auto()
        Dim variables As DataRowView = bs_variables.Current
        Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
        Dim sqlInsertList(0) As String
        Dim sql(0) As String

        cuentas_modificadas = 0
        total_cuotas = 0

        'Vencimientos
        dtab_vence = DbMan.ReadDB("SELECT * FROM autovence
								           WHERE periodo=" & periodo.Value,
                                  My.Settings.foxConnection)

        'Cuentas
        dtab_cuenta = DbMan.ReadDB("SELECT codigo, razon, marca, modelo, apagar FROM automovil
								     WHERE apagar>0 AND baja={} AND codigo=>" & CuentaInicial.Value & " 
                                  ORDER BY codigo",
                                   My.Settings.foxConnection)

        dtab_deuda = DbMan.ReadDB("SELECT * FROM autocue", My.Settings.foxConnection)

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
                If CalcAnualImp.Sql.Auto.VerificarCuota(dr, cuota, periodo.Value, dtab_deuda) Then
                    cuota_mod += 1
                    ReDim Preserve sqlInsertList(total_cuotas)
                    sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Auto.InsertarCuota(dr, cuota, periodo.Value, importe, dtab_vence(0))
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
            DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
        End If
    End Sub

    Public Sub Catastro()
        'Dim dtab_vence, dtab_cuenta, dtab_deuda As DataTable
        Dim variables As DataRowView = bs_variables.Current
        Dim cuota, cuota_max As Integer
        Dim sql(2) As String
        Dim dtab(2) As DataTable
        Dim sqlInsertList(0) As String
        dtab = CalcAnualImp.sql.Catastro.CargarTablas(dtab, periodo.Value, CuentaInicial.Value)

        cuentas_modificadas = 0
        total_cuotas = 0

        progreso.Maximum = dtab(1).Rows.Count - 1

        For Each dr As DataRow In dtab(1).Rows

            Dim monto_minimo, monto_unidad, monto_pasillo, basica, rec_baldio, monto_baldio,
                alumbrado_minimo, alumbrado_basico, monto_alumbrado, monto_agrario, monto_comercio,
                desc_vereda, monto_vereda, desc_parque, monto_parque, desc_agrario1, desc_agrario2,
                desc_jubilado, monto_jubilado, var_taecat, monto_taecat, monto_franqueo, importe, subtotal As New Decimal

            Dim zona, esquino, comercial As Integer
            Dim pasillo As Boolean = (CInt(dr("pasillo")) = 1)
            Dim baldio As Boolean = (CInt(dr("baldio")) = 1)
            Dim vereda As Boolean = (CInt(dr("vereda")) = 1)
            Dim parque As Boolean = (CInt(dr("parque")) = 1)
            comercial = dr("comercial")
            Dim agrario As Boolean = (CInt(dr("agrario")) = 1)
            Dim jubilado As Boolean = (CInt(dr("jubilado")) = 1)
            Dim metros As Decimal = 0
            Dim cuota_added As New Integer
            Dim frente(3) As Integer
            frente(0) = CInt(dr("frente1"))
            frente(1) = CInt(dr("frente2"))
            frente(2) = CInt(dr("frente3"))
            frente(3) = CInt(dr("frente4"))

            Dim monto_fijo(3) As Decimal
            monto_fijo(0) = dr("monto_fijo1")
            monto_fijo(1) = dr("monto_fijo2")
            monto_fijo(2) = dr("monto_fijo3")
            monto_fijo(3) = dr("monto_fijo4")

            zona = CInt(dr("zona"))
            esquino = CInt(dr("esquino"))
            var_taecat = CDec(variables("taecat")) / 100
            monto_minimo = dr("monto_minimo")
            monto_unidad = dr("monto_unidad")
            monto_pasillo = dr("monto_pasillo")
            rec_baldio = dr("rec_baldio")
            desc_vereda = dr("desc_vereda")
            desc_parque = dr("desc_parque")
            desc_agrario1 = dr("desc_agrario1")
            desc_agrario2 = dr("desc_agrario2")
            desc_jubilado = dr("desc_jubilado")
            alumbrado_minimo = dr("alumbrado_minimo")
            alumbrado_basico = dr("alumbrado_basico")

            'Calculo de importes
            basica = 0
            If frente(0) > 0 Then  'ESQUINA
                Dim frentes As Integer = 0
                metros += frente(0)
                frentes += 1

                If zona < 4 Then
                    If frente(1) > 0 Then
                        metros += frente(1)
                        frentes += 1
                    End If
                    If frente(2) > 0 Then
                        metros += frente(2)
                        frentes += 1
                    End If
                    If frente(3) > 0 Then
                        metros += frente(3)
                        frentes += 1
                    End If
                    If esquino = 1 Then
                        metros /= frentes
                    End If
                End If
                basica = monto_unidad * metros
            End If

            If zona = 6 Then
                'LOTEOS Y BARRIOS PRIVADOS
                If frente(0) > 2500 Then 'M2
                    basica = monto_fijo(3)
                ElseIf frente(0) > 1249 Then 'M2
                    basica = monto_fijo(2)
                ElseIf frente(0) > 799 Then 'M2
                    basica = monto_fijo(1)
                Else
                    basica = monto_fijo(0)
                End If
            ElseIf zona = 5 Then 'ZONA 5
                Dim fraccion As Integer = frente(0) / 200
                If frente(0) Mod 200 > 0 Then
                    fraccion += 1
                End If
                basica = monto_unidad * fraccion
            End If

            'Pasillo
            If pasillo And frente(0) < 11 Then
                basica = monto_pasillo
            End If

            'Minimo

            If basica < monto_minimo Then
                basica = monto_minimo
            End If

            'TAE
            monto_taecat = basica * var_taecat

            subtotal = basica + monto_taecat

            'Baldio
            If baldio Then
                'Recargo por alumbrado en baldío en zonas 1-5
                If zona < 6 Then

                    If metros > 15 Then
                        monto_alumbrado = alumbrado_basico * metros
                    End If
                    If monto_alumbrado < alumbrado_minimo Then
                        monto_alumbrado = alumbrado_minimo
                    End If

                    'Recargo por baldío en zonas 1-3
                    If zona < 4 Then
                        monto_baldio = subtotal * (rec_baldio / 100)
                    End If
                End If

                'Descuento por vereda
                If vereda Then
                    monto_vereda = subtotal * (desc_vereda / 100)
                End If
                'Descuento por parquizado
                If parque Then
                    monto_parque = subtotal * (desc_parque / 100)
                End If

            End If

            'Recargo Actividad Comercial
            monto_comercio = 0
            If comercial > 0 Then
                Dim tipo_comercio As Integer = comercial - 1
                monto_comercio = subtotal * (comercial & tipo_comercio) / 100
            End If

            'Descuento por Actividad Agropecuaria (Agrario)
            monto_agrario = 0
            If agrario Then
                If frente(0) > 100 Then
                    monto_agrario = subtotal * (desc_agrario2 / 100)
                ElseIf frente(0) > 50 Then
                    monto_agrario = subtotal * (desc_agrario1 / 100)
                End If
            End If

            'Descuento por Jubilado
            monto_jubilado = 0
            If jubilado Then
                monto_jubilado = subtotal * (desc_jubilado / 100)
            End If

            'Calcular recargos
            subtotal = subtotal + baldio + monto_comercio + monto_alumbrado
            'Calcular descuentos
            subtotal -= (monto_vereda + monto_parque + monto_agrario + monto_jubilado)

            'Franqueo
            monto_franqueo = CDec(variables("franqueo")) * 6

            'Total
            importe = subtotal + monto_franqueo

            'Cuotas
            cuota = 1
            cuota_max = 6
            Do While cuota <= cuota_max
                If CalcAnualImp.Sql.Catastro.VerificarCuota(dr, cuota, periodo.Value, dtab(2)) Then
                    cuota_added += 1
                    ReDim Preserve sqlInsertList(total_cuotas)
                    sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Catastro.InsertarCuota(dr, cuota, periodo.Value, importe,
                                                                   dtab(0)(0), monto_minimo, basica, monto_baldio, monto_jubilado, monto_pasillo,
                                                                   monto_agrario, monto_comercio, monto_alumbrado, monto_vereda, monto_parque, monto_franqueo, monto_taecat)
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
            DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
        End If
    End Sub

    Public Sub Comercio()
        Dim variables As DataRowView = bs_variables.Current
        Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
        Dim minimo, taecom, importe, franqueo As New Decimal
        Dim cuota_max As Integer
        Dim sqlSelect As String
        Dim sqlInsertList(0) As String

        cuentas_modificadas = 0
        total_cuotas = 0
        'Vencimientos
        dtab_vence = DbMan.ReadDB("SELECT * FROM comvence WHERE periodo=" & periodo.Value, My.Settings.foxConnection)

        'Cuentas
        sqlSelect = "SELECT comercio.codigo as codigo, comercio.cantidad, 
                         comercio.actividad as actividad, comact.detalle,
		    			 comact.tributo, comact.cuotas, 
                         comact.cuota1, comact.cuota2, comact.cuota3,
                         comact.cuota4,comact.cuota5,comact.cuota6"
        sqlSelect &= "FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
        sqlSelect &= "WHERE comercio.baja = {} AND comact.cuota1>0 AND comercio.codigo=>" & CuentaInicial.Value
        sqlSelect &= "ORDER BY comercio.codigo"

        dtab_cuenta = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

        'Deudas
        sqlSelect = "SELECT *"
        sqlSelect &= "FROM comcue"
        sqlSelect &= "WHERE agrupado='' AND pago={} AND ano=" & periodo.Value & " AND codigo=> " & CuentaInicial.Value
        sqlSelect &= "ORDER BY codigo"

        dtab_deuda = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        For Each dr As DataRow In dtab_cuenta.Rows
            Dim cuota_added As New Integer
            Dim vence As Date = Date.Today


            If CInt(dr("cuotas")) > 0 Then
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
                    If CInt(dr("cantidad")) > 1 Then
                        minimo *= CInt(dr("cantidad"))
                    End If

                    taecom = minimo * (CDec(variables("taecom")) / 100)
                    franqueo = variables("franqueo")
                    importe = minimo + taecom + franqueo

                    If CalcAnualImp.Sql.Comercio.VerificarCuota(dr, ncuota, dtab_deuda) Then
                        cuota_added += 1
                        ReDim Preserve sqlInsertList(total_cuotas)
                        sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Comercio.InsertarCuota(dr, ncuota, periodo.Value, minimo, taecom,
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
            DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
        End If
    End Sub

    Public Sub Sepelio()
        Dim variables As DataRowView = bs_variables.Current
        Dim dtab_cuenta, dtab_deuda As DataTable
        Dim sqlInsertList(0) As String
        Dim sqlSelect As String
        'Vencimientos
        Dim vence As New Date(periodo.Value, 1, 1)
        cuentas_modificadas = 0
        total_cuotas = 0
        Do While vence.DayOfWeek <> DayOfWeek.Monday
            vence = vence.AddDays(1)
        Loop
        'Cuentas
        sqlSelect = "SELECT sepelio.codigo as codigo, sepelio.fila as fila, sepelio.jubilado as jubilado, 
                         sepevar.minimo as minimo, sepelio.espacio as espacio, sepevar.jubilado as desc_jubilado, 
                         sepevar.fila1 as fila1, sepevar.fila2 as fila2, sepevar.fila3 as fila3,
		    			 sepevar.fila4 as fila4, sepevar.fila5 as fila5, sepelio.ubicacion as ubicacion, sepelio.tipo as tipo"
        sqlSelect &= " FROM sepelio JOIN sepevar ON sepelio.tipo=sepevar.orden"
        sqlSelect &= " WHERE sepelio.tipo > 0 AND sepelio.codigo =>" & CuentaInicial.Value
        sqlSelect &= " ORDER BY sepelio.codigo"
        dtab_cuenta = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

        sqlSelect = "SELECT *"
        sqlSelect &= " FROM sepecue"
        dtab_deuda = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)

        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        Dim jubilado, importe As Decimal
        For Each dr As DataRow In dtab_cuenta.Rows
            Dim cuota_mod As New Integer
            Dim fila As Integer = CInt(dr("fila"))
            jubilado = 0
            importe = 0

            If fila > 0 Then
                importe = dr("fila" & fila)
            End If

            If importe < CDec(dr("minimo")) Then
                importe = dr("minimo")
            End If

            importe *= CInt(dr("espacio"))

            If CInt(dr("jubilado")) = 1 Then
                jubilado = importe * (CDec(dr("desc_jubilado")) / 100)
                importe -= jubilado
            End If

            If CalcAnualImp.Sql.Sepelio.VerificarCuota(dr, periodo.Value, dtab_deuda) Then
                cuota_mod += 1
                ReDim Preserve sqlInsertList(total_cuotas)
                sqlInsertList(total_cuotas) = CalcAnualImp.Sql.Sepelio.InsertarCuota(dr, periodo.Value, importe, vence)

                total_cuotas += 1
            End If
            If cuota_mod > 0 Then
                cuentas_modificadas += 1
            End If
            CheckProgress(dtab_cuenta.Rows.IndexOf(dr), dr("codigo"))
        Next
        If total_cuotas > 0 Then
            DbMan.EditDB(sqlInsertList, My.Settings.foxConnection, progreso)
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


End Class