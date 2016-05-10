Imports Sigm.Hacienda.CalculoAnual
Public Class CalculoAnualImpuesto
    Dim dtab_cuenta, dtab_var, dtab_zona As DataTable
    Dim vence(6) As Date
    Dim ultimo As Integer

    'Rutinas
    Public Function validar() As Boolean
        dtab_cuenta = Nothing
        dtab_zona = Nothing

        Dim dtab As DataTable = bd.leer(foxcon, "SELECT MAX(codigo) as codigo FROM " & impuesto.Text)
        If dtab.Rows.Count > 0 Then
            If CuentaInicial.Value > dtab(0)("codigo") Then
                MsgBox("No se encuentra la cuenta inicial.", MsgBoxStyle.OkOnly, Nothing)
            Else
                'Leer vencimientos
                vence = sql.LeerVencimientos(impuesto.Text, periodo.Value)
                'Generar cuotas
                If impuesto.Text = "AGUAS" Then
                    agua()
                ElseIf impuesto.Text = "AUTOMOVIL" Then
                    auto()
                ElseIf impuesto.Text = "CATASTRO" Then
                    catastro()
                ElseIf impuesto.Text = "COMERCIO" Then
                    comercio()
                ElseIf impuesto.Text = "SEPELIO" Then
                    sepelio()
                End If
            End If
        End If
    End Function

    Public Sub agua()
        'Zonas
        dtab_zona = bd.leer(foxcon, "SELECT * FROM aguzona")
        'Cuentas
        sel_sql = "SELECT codigo, potable, comercial, industrial FROM aguas" &
                  " WHERE codigo=>" & CuentaInicial.Value & " ORDER BY codigo"
        dtab_cuenta = bd.leer(foxcon, sel_sql)
        'Iniciar busqueda y reemplazo
        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        For fila As Integer = 0 To progreso.Maximum
            Dim reside, comercio, industria, importe, franqueo As New Decimal
            Dim cuota, cuota_max As New Integer

            CheckProgress(fila, dtab_cuenta(fila)("codigo"))
            'Residencial
            If dtab_cuenta(fila)("potable") = 1 Then
                reside = dtab_zona(0)("resido")
            End If
            'Comercial
            If dtab_cuenta(fila)("comercial") = 1 Then
                comercio = dtab_zona(0)("comercio")
            End If
            'Industrial
            If dtab_cuenta(fila)("industrial") = 1 Then
                industria = dtab_zona(0)("industria")
            End If
            importe = reside + comercio + industria
            'Minimo
            If importe < dtab_zona(0)("minimo") Then
                importe = dtab_zona(0)("minimo")
            End If
            'Franqueo
            franqueo = dtab_var(0)("franqueo")
            'Total
            importe = importe + franqueo
            'Ingresar cuotas
            cuota_max = 6
            cuota = 1
            Do While cuota <= cuota_max
                If sql.Agua.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
                    sql.Agua.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe, vence, reside, comercio,
                                                            industria, franqueo)
                End If
                cuota += 1
            Loop
        Next
    End Sub
    Public Sub auto()
        'Cuentas
        sel_sql = "SELECT codigo, razon, marca, modelo, apagar FROM automovil" &
                  " WHERE apagar>0 AND baja={} AND codigo=>" & CuentaInicial.Value & " ORDER BY codigo"
        dtab_cuenta = bd.leer(foxcon, sel_sql)

        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        For fila As Integer = 0 To progreso.Maximum
            Dim importe As New Decimal
            Dim cuota, cuota_max As Integer
            CheckProgress(fila, dtab_cuenta(fila)("codigo"))

            importe = dtab_cuenta(fila)("apagar")
            cuota = 1
            cuota_max = 4
            Do While cuota <= cuota_max
                If sql.Auto.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
                    sql.Auto.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe, vence)
                End If
                cuota += 1
            Loop
        Next
    End Sub
    Public Sub catastro()
        'Cuentas
        sel_sql = "SELECT catastro.codigo As codigo, catastro.jubilado As jubilado, catastro.baldio As baldio, catastro.pasillo As pasillo," &
                  " catastro.agrario As agrario, catastro.frente1 As metros, catzona.minimo As monto_minimo, catzona.unidad As monto_unidad," &
                  " catzona.jubilado As desc_jubilado, catzona.baldio As monto_baldio, catzona.pasillo As monto_pasillo, catzona.agrario1 As monto_agrario" &
                  " FROM catastro JOIN catzona On catastro.zona1=catzona.zona" &
                  " WHERE catastro.codigo=>" & CuentaInicial.Value & " ORDER BY catastro.codigo"
        dtab_cuenta = bd.leer(foxcon, sel_sql)
        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        For fila As Integer = 1 To progreso.Maximum
            Dim basica, baldio, pasillo, agrario, minimo, subtotal, jubilado, taecat, franqueo, importe As New Decimal
            Dim cuota, cuota_max As Integer
            CheckProgress(fila, dtab_cuenta(fila)("codigo"))
            'Calculo de importes
            basica = dtab_cuenta(fila)("monto_unidad") * dtab_cuenta(fila)("metros")
            'Baldio
            If dtab_cuenta(fila)("baldio") = 1 Then
                baldio = dtab_cuenta(fila)("monto_baldio")
            End If
            'Pasillo
            If dtab_cuenta(fila)("pasillo") Then
                pasillo = dtab_cuenta(fila)("monto_pasillo")
            End If
            'Zona agropecuaria
            If dtab_cuenta(fila)("agrario") Then
                agrario = dtab_cuenta(fila)("monto_agrario")
            End If
            'Subtotal
            subtotal = basica + baldio + pasillo + agrario
            'Minimo
            If subtotal < dtab_cuenta(fila)("monto_minimo") Then
                subtotal = dtab_cuenta(fila)("monto_minimo")
            End If
            'Descuento jubilado
            If dtab_cuenta(fila)("jubilado") = 1 Then
                jubilado = importe * (dtab_cuenta(fila)("desc_jubilado") / 100)
                subtotal = subtotal - jubilado
            End If
            'TAE
            taecat = subtotal * (dtab_var(0)("taecat") / 100)
            'Franqueo
            franqueo = dtab_var(0)("franqueo")
            'Total
            importe = subtotal + taecat + franqueo
            'Cuotas
            cuota = 1
            cuota_max = 6
            Do While cuota <= cuota_max
                If sql.Catastro.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
                    sql.Catastro.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe, vence,
                                                                    minimo, baldio, jubilado, pasillo, agrario, franqueo, taecat)
                End If
                cuota += 1
            Loop
        Next
    End Sub
    Public Sub comercio()
        sel_sql = "SELECT comercio.codigo as codigo, comercio.actividad as actividad, detalle, minimo, formapago" &
                  " FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad" &
                  " WHERE comercio.baja = {} AND minimo>0 AND codigo=>" & CuentaInicial.Value
        dtab_cuenta = bd.leer(foxcon, sel_sql)
        progreso.Maximum = Me.dtab_cuenta.Rows.Count - 1

        For fila As Integer = 1 To progreso.Maximum
            Dim minimo, taecom, importe, franqueo As New Decimal
            Dim cuota, cuota_max As Integer
            CheckProgress(fila, dtab_cuenta(fila)("codigo"))

            '2-1-1-1-1-2
            If dtab_cuenta(fila)("formapago") = 6 Then
                cuota = 1
                cuota_max = 6
                Do While cuota <= cuota_max
                    If cuota = 1 Or cuota = 6 Then
                        minimo = dtab_cuenta(fila)("minimo") * 2
                    Else
                        minimo = dtab_cuenta(fila)("minimo")
                    End If
                    taecom = minimo * (dtab_var(0)("taecom") / 100)
                    franqueo = dtab_var(0)("franqueo")
                    importe = minimo + taecom + franqueo

                    If sql.Comercio.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
                        sql.Comercio.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, minimo, taecom,
                                                                        franqueo, importe, vence)
                    End If
                    cuota += 1
                Loop
                'Normal
            ElseIf dtab_cuenta(fila)("formapago") = 2 Then
                cuota = 1
                cuota_max = 6
                Do While cuota <= cuota_max
                    minimo = dtab_cuenta(fila)("minimo")
                    taecom = minimo * (dtab_var(0)("taecom") / 100)
                    franqueo = dtab_var(0)("franqueo")
                    importe = minimo + taecom + franqueo

                    If sql.Comercio.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
                        sql.Comercio.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, minimo, taecom,
                                                                        franqueo, importe, vence)
                    End If
                    cuota += 1
                Loop
                'Cuota unica
            ElseIf dtab_cuenta(fila)("formapago") = 1 Then
                minimo = dtab_cuenta(fila)("minimo")
                taecom = importe * (dtab_var(0)("taecom") / 100)
                franqueo = dtab_var(0)("franqueo")
                importe = minimo + taecom + franqueo
                cuota = 1
                cuota_max = 1
                If sql.Comercio.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
                    sql.Comercio.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, minimo, taecom,
                                                                        franqueo, importe, vence)
                End If
            End If
        Next
    End Sub
    Public Sub sepelio()
        'Cuentas
        sel_sql = "SELECT sepelio.codigo as codigo, sepelio.fila as fila, sepelio.jubilado as jubilado, sepevar.minimo as minimo," &
                  " sepevar.jubilado as desc_jubilado, sepevar.fila1 as fila1, sepevar.fila2 as fila2, sepevar.fila3 as fila3," &
                  " sepevar.fila4 as fila4, sepevar.fila5 as fila5" &
                  " FROM sepelio JOIN sepevar ON sepelio.ubicacion=sepevar.orden" &
                  " WHERE sepelio.ubicacion > 0 AND sepelio.codigo =>" & CuentaInicial.Value & " ORDER BY sepelio.codigo"
        dtab_cuenta = bd.leer(foxcon, sel_sql)

        progreso.Maximum = dtab_cuenta.Rows.Count - 1

        For fila As Integer = 0 To progreso.Maximum
            Dim jubilado, importe As Decimal
            Dim cuota As Integer
            CheckProgress(fila, dtab_cuenta(fila)("codigo"))

            If dtab_cuenta(fila)("fila") > 0 Then
                importe = dtab_cuenta(fila)("fila" & dtab_cuenta(fila)("fila"))
            End If
            If importe < dtab_cuenta(fila)("minimo") Then
                importe = dtab_cuenta(fila)("minimo")
            End If
            If dtab_cuenta(fila)("jubilado") = 1 Then
                jubilado = importe * (dtab_cuenta(fila)("desc_jubilado") / 100)
                importe = importe - jubilado
            End If

            cuota = 1
            If sql.Sepelio.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
                sql.Sepelio.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe, vence)
            End If
        Next
    End Sub

    Public Sub CheckProgress(fila As Integer, cuenta As Integer)
        If fila > 0 And cuenta > 0 Then
            If fila = progreso.Maximum Then
                progreso.Value = progreso.Minimum
                info.Text = "Terminado. " & fila & " cuentas procesadas."
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
        periodo.Maximum = Today.Year + 5
        periodo.Minimum = 1990
        periodo.Value = Today.Year

        dtab_var = bd.leer(foxcon, "SELECT * FROM numeros")
    End Sub
    Private Sub iniciar_Click(sender As Object, e As EventArgs) Handles iniciar.Click
        validar()
    End Sub
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class