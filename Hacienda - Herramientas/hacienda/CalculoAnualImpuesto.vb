Imports Sigm.Hacienda.CalculoAnual
Public Class CalculoAnualImpuesto
	Dim dtab_cuenta, dtab_var, dtab_zona, dtab_vence As DataTable
	Dim ultimo As Integer

    'Rutinas
    Public Function validar() As Boolean
        dtab_cuenta = Nothing
        dtab_zona = Nothing

        Dim dtab As DataTable = bd.read(my.settings.foxcon, "SELECT MAX(codigo) as codigo FROM " & impuesto.Text)
        If dtab.Rows.Count > 0 Then
            If CuentaInicial.Value > dtab(0)("codigo") Then
                MsgBox("No se encuentra la cuenta inicial.", MsgBoxStyle.OkOnly, Nothing)
            Else
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
		Dim reside, comercio, industria, importe, franqueo As New Decimal
		Dim cuota, cuota_max As New Integer

		'Zonas
		dtab_zona = bd.read(My.Settings.foxcon, "SELECT * FROM aguzona")
		'Vencimientos
		dtab_vence = bd.read(My.Settings.foxcon, "SELECT * FROM aguvence 
												  WHERE periodo=" & periodo.Value)
		'Cuentas
		dtab_cuenta = bd.read(My.Settings.foxcon,
							  "SELECT codigo, potable, comercial, industrial FROM aguas
                               WHERE codigo=>" & CuentaInicial.Value & " ORDER BY codigo")
        'Iniciar busqueda y reemplazo
        progreso.Maximum = dtab_cuenta.Rows.Count - 1

		For fila As Integer = 0 To progreso.Maximum
			reside = 0
			comercio = 0
			industria = 0
			importe = 0
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
					sql.Agua.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe, dtab_vence(0),
					reside, comercio, industria, franqueo)
				End If
				cuota += 1
			Loop
		Next
	End Sub
	Public Sub auto()
		'Vencimientos
		dtab_vence = bd.read(My.Settings.foxcon, "SELECT * FROM autovence
							  WHERE periodo=" & periodo.Value)
		'Cuentas
		dtab_cuenta = bd.read(My.Settings.foxcon,
							  "SELECT codigo, razon, marca, modelo, apagar FROM automovil
                               WHERE apagar>0 And baja={} And codigo=>" & CuentaInicial.Value & "
                               ORDER BY codigo")

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
					sql.Auto.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe, dtab_vence(0))
				End If
				cuota += 1
			Loop
		Next
	End Sub
	Public Sub catastro()
		Dim basica, minimo, baldio, pasillo, agrario, comercio, jubilado,
			vereda, parque, taecat, franqueo, importe, subtotal As New Decimal
		Dim cuota, cuota_max As Integer

		'Vencimientos
		dtab_vence = bd.read(My.Settings.foxcon, "SELECT * FROM catvence
												  WHERE periodo=" & periodo.Value)
		'Cuentas
		dtab_cuenta = bd.read(My.Settings.foxcon,
							  "SELECT catastro.codigo As codigo, catastro.jubilado As jubilado, 
							   catastro.baldio As baldio, catastro.pasillo As pasillo,
                               catastro.agrario As agrario, catastro.comercial as comercial,
							   catastro.vereda as vereda, catastro.parque as parque,
							   catastro.esquino as esquino, catastro.zona1 as zona, 
							   catastro.frente1 As frente1, catastro.frente2 As frente2,
							   catastro.frente3 As frente3, catastro.frente4 As frente4,
							   catzona.minimo As monto_minimo, catzona.unidad As monto_unidad,
							   catzona.fijo1 as monto_fijo1, catzona.fijo2 as monto_fijo2,
							   catzona.fijo3 as monto_fijo3, catzona.fijo4 as monto_fijo4,
                               catzona.jubilado As desc_jubilado, catzona.baldio As rec_baldio,
							   catzona.pasillo As monto_pasillo, 
							   catzona.agrario1 As desc_agrario1, catzona.agrario2 As desc_agrario2,
							   catzona.comercio1 as rec_comercio1, catzona.comercio2 as rec_comercio2,
							   catzona.comercio3 as rec_comercio3, catzona.comercio4 as rec_comercio4,
							   catzona.vereda as desc_vereda, catzona.parque as desc_parque
							   FROM catastro JOIN catzona On catastro.zona1=catzona.zona
                               WHERE catastro.codigo=>" & CuentaInicial.Value & " ORDER BY catastro.codigo")

		progreso.Maximum = dtab_cuenta.Rows.Count - 1

		For fila As Integer = 1 To progreso.Maximum
			CheckProgress(fila, dtab_cuenta(fila)("codigo"))

			'Calculo de importes
			basica = 0

			If dtab_cuenta(fila)("frente1") > 0 Then  'ESQUINA
				Dim metros As Decimal = 0
				Dim frentes As Integer = 0

				metros += dtab_cuenta(fila)("frente1")
				frentes += 1

				If dtab_cuenta(fila)("zona") < 4 Then
					If dtab_cuenta(fila)("frente2") > 0 Then
						metros += dtab_cuenta(fila)("frente2")
						frentes += 1
					End If
					If dtab_cuenta(fila)("frente3") > 0 Then
						metros += dtab_cuenta(fila)("frente3")
						frentes += 1
					End If
					If dtab_cuenta(fila)("frente4") > 0 Then
						metros += dtab_cuenta(fila)("frente4")
						frentes += 1
					End If
					If dtab_cuenta(fila)("esquino") = 1 Then
						metros = metros / frentes
					End If
				End If
				basica = dtab_cuenta(fila)("monto_unidad") * metros
			End If

			If dtab_cuenta(fila)("zona") = 6 Then
				'LOTEOS Y BARRIOS PRIVADOS
				If dtab_cuenta(fila)("frente1") > 2500 Then 'M2 
					basica = dtab_cuenta(fila)("monto_fijo4")
				ElseIf dtab_cuenta(fila)("frente1") > 1249 Then 'M2 
					basica = dtab_cuenta(fila)("monto_fijo3")
				ElseIf dtab_cuenta(fila)("frente1") > 799 Then 'M2 
					basica = dtab_cuenta(fila)("monto_fijo2")
				Else
					basica = dtab_cuenta(fila)("monto_fijo1")
				End If
			ElseIf dtab_cuenta(fila)("zona") = 5 Then 'ZONA 5
				Dim fraccion As Integer = dtab_cuenta(fila)("frente1") / 200
				If dtab_cuenta(fila)("frente1") Mod 200 > 0 Then
					fraccion += 1
				End If
				basica = dtab_cuenta(fila)("monto_unidad") * fraccion
			End If


			'Pasillo
			pasillo = 0
			If dtab_cuenta(fila)("pasillo") = 1 And dtab_cuenta(fila)("frente1") < 11 Then
				pasillo = dtab_cuenta(fila)("monto_pasillo")
				basica = pasillo
			End If

			'Minimo
			minimo = dtab_cuenta(fila)("monto_minimo")
			If basica < minimo Then
				basica = minimo
			End If

			'TAE
			taecat = basica * (dtab_var(0)("taecat") / 100)

			subtotal = basica + taecat

			'Baldio
			baldio = 0
			vereda = 0
			parque = 0
			If dtab_cuenta(fila)("baldio") = 1 Then
				'Recargo por baldio
				If dtab_cuenta(fila)("zona") < 4 Then
					baldio = subtotal * (dtab_cuenta(fila)("rec_baldio") / 100)
				End If
				'Descuento por vereda
				If dtab_cuenta(fila)("vereda") = 1 Then
					vereda = subtotal * (dtab_cuenta(fila)("desc_vereda") / 100)
				End If
				'Descuento por parquizado
				If dtab_cuenta(fila)("parque") = 1 Then
					parque = subtotal * (dtab_cuenta(fila)("desc_parque") / 100)
				End If
			End If

			'Recargo Actividad Comercial
			comercio = 0
			If dtab_cuenta(fila)("comercial") > 1 Then
				Dim tipo_comercio As Integer = dtab_cuenta(fila)("comercial") - 1
				comercio = subtotal * (dtab_cuenta(fila)("rec_comercio" & tipo_comercio) / 100)
			End If

			'Descuento por Actividad Agropecuaria (Agrario)
			agrario = 0
			If dtab_cuenta(fila)("agrario") = 1 Then
				If dtab_cuenta(fila)("frente1") > 100 Then
					agrario = subtotal * (dtab_cuenta(fila)("desc_agrario2") / 100)
				ElseIf dtab_cuenta(fila)("frente1") > 50 Then
					agrario = subtotal * (dtab_cuenta(fila)("desc_agrario1") / 100)
				End If
			End If

			'Jubilado
			jubilado = 0
			If dtab_cuenta(fila)("jubilado") = 1 Then
				jubilado = subtotal * (dtab_cuenta(fila)("desc_jubilado") / 100)
			End If

			'Calcular recargos
			subtotal = subtotal + baldio + comercio
			'Calcular descuentos
			subtotal = subtotal - (vereda + parque + agrario + jubilado)

			'Franqueo
			franqueo = dtab_var(0)("franqueo") * 6

			'Total
			importe = subtotal + franqueo

			'Cuotas
			cuota = 1
			cuota_max = 6
			Do While cuota <= cuota_max
				If sql.Catastro.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) Then
					sql.Catastro.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe / 6,
											   dtab_vence(0), minimo / 6, basica / 6, baldio / 6, jubilado / 6, pasillo / 6,
											   agrario / 6, comercio / 6, vereda / 6, parque / 6, franqueo / 6, taecat / 6)
				End If
				cuota += 1
			Loop
		Next
	End Sub
	Public Sub comercio()
		Dim minimo, taecom, importe, franqueo As New Decimal
		Dim cuota, cuota_max As Integer

		'Vencimientos
		dtab_vence = bd.read(My.Settings.foxcon, "SELECT * FROM comvence WHERE periodo=" & periodo.Value)

		'Cuentas
		dtab_cuenta = bd.read(My.Settings.foxcon,
							  "SELECT comercio.codigo as codigo, comercio.actividad as actividad, detalle, 
							   minimo, formapago, cantidad
                               FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad
                               WHERE comercio.baja = {} And minimo>0 And codigo=>" & CuentaInicial.Value)
		progreso.Maximum = Me.dtab_cuenta.Rows.Count - 1

		For fila As Integer = 1 To progreso.Maximum

			CheckProgress(fila, dtab_cuenta(fila)("codigo"))

            '2-1-1-1-1-2
            If dtab_cuenta(fila)("formapago") = 6 Then 'Valores Mensuales
				cuota = 1
				cuota_max = 6
				Do While cuota <= cuota_max
					If cuota = 1 Or cuota = 6 Then
						minimo = ((dtab_cuenta(fila)("minimo"))) * 2
					Else
						minimo = dtab_cuenta(fila)("minimo")
					End If

					If dtab_cuenta(fila)("cantidad") > 1 Then
						minimo = minimo * dtab_cuenta(fila)("cantidad")
					End If

					taecom = minimo * (dtab_var(0)("taecom") / 100)
					franqueo = dtab_var(0)("franqueo")
					importe = minimo + taecom + franqueo

					If sql.Comercio.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
						sql.Comercio.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, minimo, taecom,
																		franqueo, importe, dtab_vence(0))
					End If
					cuota += 1
				Loop
                'Normal
            ElseIf dtab_cuenta(fila)("formapago") = 2 Then 'Valores Anuales
				cuota = 1
				cuota_max = 6
				Do While cuota <= cuota_max
					minimo = dtab_cuenta(fila)("minimo") / 6
					taecom = minimo * (dtab_var(0)("taecom") / 100)
					franqueo = dtab_var(0)("franqueo") 'Mensual
					importe = minimo + taecom + franqueo

					If sql.Comercio.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value) = False Then
						sql.Comercio.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, minimo, taecom,
																		franqueo, importe, dtab_vence(0))
					End If
					cuota += 1
				Loop
                'Cuota unica
            ElseIf dtab_cuenta(fila)("formapago") = 1 Then
				minimo = dtab_cuenta(fila)("minimo")
				taecom = importe * (dtab_var(0)("taecom") / 100)
				franqueo = dtab_var(0)("franqueo") * 6
				importe = minimo + taecom + franqueo
				If sql.Comercio.VerificarCuota(dtab_cuenta, fila, 1, periodo.Value) = False Then
					sql.Comercio.InsertarCuota(dtab_cuenta, fila, 1, periodo.Value, minimo, taecom,
																		franqueo, importe, dtab_vence(0))
				End If
			End If
		Next
	End Sub
	Public Sub sepelio()
		'Vencimientos
		Dim vence As New Date(periodo.Value, 1, 1)
		Do While vence.DayOfWeek <> DayOfWeek.Monday
			vence = vence.AddDays(1)
		Loop
        'Cuentas
        dtab_cuenta = bd.read(My.Settings.foxcon,
							  "SELECT sepelio.codigo as codigo, sepelio.fila as fila, sepelio.jubilado as jubilado, sepevar.minimo as minimo,
                               sepevar.jubilado as desc_jubilado, sepevar.fila1 as fila1, sepevar.fila2 as fila2, sepevar.fila3 as fila3,
                               sepevar.fila4 as fila4, sepevar.fila5 as fila5, sepelio.ubicacion as ubicacion
                               FROM sepelio JOIN sepevar ON sepelio.ubicacion=sepevar.orden
                               WHERE sepelio.ubicacion > 0 AND sepelio.codigo =>" & CuentaInicial.Value & "
                               ORDER BY sepelio.codigo")

		progreso.Maximum = dtab_cuenta.Rows.Count - 1

		Dim jubilado, importe As Decimal
		For fila As Integer = 0 To progreso.Maximum
			jubilado = 0
			importe = 0
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

			If sql.Sepelio.VerificarCuota(dtab_cuenta, fila, periodo.Value) = False Then
				sql.Sepelio.InsertarCuota(dtab_cuenta, fila, periodo.Value, importe, vence)
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

        dtab_var = bd.read(my.settings.foxcon, "SELECT * FROM numeros")
    End Sub
    Private Sub iniciar_Click(sender As Object, e As EventArgs) Handles iniciar.Click
        validar()
    End Sub
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class