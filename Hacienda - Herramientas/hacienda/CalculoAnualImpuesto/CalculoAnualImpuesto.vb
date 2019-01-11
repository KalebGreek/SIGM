Imports Sigm.CalculoAnualSQL
Public Class CalculoAnualImpuesto
	Dim dtab_var As New DataTable
	Dim ultimo As Integer

    'Rutinas
    Public Function validar() As Boolean

		Dim dtab As DataTable = DbMan.read("SELECT MAX(codigo) as codigo FROM " & impuesto.Text, My.Settings.foxcon)
		If dtab.Rows.Count > 0 Then
			If CuentaInicial.Value > dtab(0)("codigo") Then
				MsgBox("No se encuentra la cuenta inicial.", MsgBoxStyle.OkOnly, Nothing)
			Else
				info.Text = "Leyendo datos.."
				info.Refresh()
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
		Dim dtab_cuenta, dtab_zona, dtab_vence, dtab_deuda As DataTable
		Dim reside, comercio, industria, importe, franqueo As New Decimal
		Dim cuota, cuota_max As New Integer
		'Zonas
		dtab_zona = DbMan.read("SELECT * FROM aguzona", My.Settings.foxcon)
		'Vencimientos
		dtab_vence = DbMan.read("SELECT * FROM aguvence 
										 WHERE periodo=" & Val(periodo.Value),
								My.Settings.foxcon)
		'Cuentas
		dtab_cuenta = DbMan.read("SELECT codigo, potable, comercial, industrial FROM aguas
								   WHERE codigo=>" & CuentaInicial.Value & " ORDER BY codigo",
								 My.Settings.foxcon)

		dtab_deuda = DbMan.read("SELECT * FROM agucue", My.Settings.foxcon)

        'Iniciar busqueda y reemplazo
        progreso.Maximum = dtab_cuenta.Rows.Count - 1

		For fila As Integer = 0 To progreso.Maximum
			CheckProgress(fila, dtab_cuenta(fila)("codigo"))
			reside = 0
			comercio = 0
			industria = 0
			importe = 0

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
				If CalculoAnualSQL.sql.Agua.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value, dtab_deuda) Then
					'No existente
					CalculoAnualSQL.sql.Agua.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe, dtab_vence(0),
					reside, comercio, industria, franqueo)
				End If
				cuota += 1
			Loop

		Next
	End Sub
	Public Sub auto()
		Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
		'Vencimientos
		dtab_vence = DbMan.read("SELECT * FROM autovence
								  WHERE periodo=" & periodo.Value,
								My.Settings.foxcon)
		'Cuentas
		dtab_cuenta = DbMan.read("SELECT codigo, razon, marca, modelo, apagar FROM automovil
								   WHERE apagar>0 AND baja={} 
									 AND codigo=>" & CuentaInicial.Value & " ORDER BY codigo",
								 My.Settings.foxcon)

		dtab_deuda = DbMan.read("SELECT * FROM autocue", My.Settings.foxcon)

		progreso.Maximum = dtab_cuenta.Rows.Count - 1

		For fila As Integer = 0 To progreso.Maximum
			Dim importe As New Decimal
			Dim cuota, cuota_max As Integer
			CheckProgress(fila, dtab_cuenta(fila)("codigo"))

			importe = dtab_cuenta(fila)("apagar")
			cuota = 1
			cuota_max = 4
			Do While cuota <= cuota_max
				If CalculoAnualSQL.sql.Auto.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value, dtab_deuda) Then
					CalculoAnualSQL.sql.Auto.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, importe, dtab_vence(0))
				End If
				cuota += 1
			Loop
		Next
	End Sub
	Public Sub catastro()
		Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
		Dim basica, minimo, baldio, pasillo, agrario, comercio, jubilado,
			vereda, parque, taecat, franqueo, importe, subtotal As New Decimal
		Dim cuota, cuota_max As Integer

		'Vencimientos
		dtab_vence = DbMan.read("SELECT * FROM catvence
								  WHERE periodo=" & periodo.Value,
								My.Settings.foxcon)
		'Cuentas
		dtab_cuenta = DbMan.read("SELECT catastro.codigo As codigo, catastro.jubilado As jubilado, 
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
								   WHERE catastro.codigo=>" & CuentaInicial.Value & " ORDER BY catastro.codigo",
								 My.Settings.foxcon)

		dtab_deuda = DbMan.read("SELECT * FROM catcue", My.Settings.foxcon)

		progreso.Maximum = dtab_cuenta.Rows.Count - 1

		For Each dr As DataRow In dtab_cuenta.Rows
			CheckProgress(dtab_cuenta.Rows.IndexOf(dr), dr("codigo"))

			'Calculo de importes
			basica = 0

			If dr("frente1") > 0 Then  'ESQUINA
				Dim metros As Decimal = 0
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
						metros = metros / frentes
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
			baldio = 0
			vereda = 0
			parque = 0
			If dr("baldio") = 1 Then
				'Recargo por baldio
				If dr("zona") < 4 Then
					baldio = subtotal * (dr("rec_baldio") / 100)
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
				If CalculoAnualSQL.sql.Catastro.VerificarCuota(dr, cuota, periodo.Value, dtab_deuda) Then
					CalculoAnualSQL.sql.Catastro.InsertarCuota(dr, cuota, periodo.Value, importe / 6,
											   dtab_vence(0), minimo / 6, basica / 6, baldio / 6, jubilado / 6, pasillo / 6,
											   agrario / 6, comercio / 6, vereda / 6, parque / 6, franqueo / 6, taecat / 6)
				End If
				cuota += 1
			Loop
		Next
	End Sub
	Public Sub comercio()
		Dim dtab_cuenta, dtab_vence, dtab_deuda As DataTable
		Dim minimo, taecom, importe, franqueo As New Decimal
		Dim cuota, cuota_max As Integer

		'Vencimientos
		dtab_vence = DbMan.read("SELECT * FROM comvence WHERE periodo=" & periodo.Value, My.Settings.foxcon)

		'Cuentas

		dtab_cuenta = DbMan.read("SELECT comercio.codigo as codigo, comercio.actividad as actividad, detalle, 
										 minimo, formapago, cantidad
									FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad
								   WHERE comercio.baja = {} And minimo>0 And codigo=>" & CuentaInicial.Value,
								 My.Settings.foxcon)

		dtab_deuda = DbMan.read("SELECT * FROM comcue", My.Settings.foxcon)

		progreso.Maximum = dtab_cuenta.Rows.Count - 1

		For fila As Integer = 1 To progreso.Maximum

			CheckProgress(fila, dtab_cuenta(fila)("codigo"))


			If dtab_cuenta(fila)("formapago") = 6 Then 'Valores Mensuales
				'2-1-1-1-1-2
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

					If CalculoAnualSQL.sql.Comercio.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value, dtab_deuda) Then
						CalculoAnualSQL.sql.Comercio.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, minimo, taecom,
																		franqueo, importe, dtab_vence(0))
					End If
					cuota += 1
				Loop

			ElseIf dtab_cuenta(fila)("formapago") = 2 Then 'Valores Anuales
				'Normal
				cuota = 1
				cuota_max = 6
				Do While cuota <= cuota_max
					minimo = dtab_cuenta(fila)("minimo") / 6
					taecom = minimo * (dtab_var(0)("taecom") / 100)
					franqueo = dtab_var(0)("franqueo") 'Mensual
					importe = minimo + taecom + franqueo

					If CalculoAnualSQL.sql.Comercio.VerificarCuota(dtab_cuenta, fila, cuota, periodo.Value, dtab_deuda) Then
						CalculoAnualSQL.sql.Comercio.InsertarCuota(dtab_cuenta, fila, cuota, periodo.Value, minimo, taecom,
																		franqueo, importe, dtab_vence(0))
					End If
					cuota += 1
				Loop

			ElseIf dtab_cuenta(fila)("formapago") = 1 Then
				'Cuota unica
				minimo = dtab_cuenta(fila)("minimo")
				taecom = importe * (dtab_var(0)("taecom") / 100)
				franqueo = dtab_var(0)("franqueo") * 6
				importe = minimo + taecom + franqueo

				If CalculoAnualSQL.sql.Comercio.VerificarCuota(dtab_cuenta, fila, 1, periodo.Value, dtab_deuda) Then
					CalculoAnualSQL.sql.Comercio.InsertarCuota(dtab_cuenta, fila, 1, periodo.Value, minimo, taecom,
																		franqueo, importe, dtab_vence(0))
				End If
			End If
		Next
	End Sub
	Public Sub sepelio()
		Dim dtab_cuenta, dtab_deuda As DataTable
		'Vencimientos
		Dim vence As New Date(periodo.Value, 1, 1)
		Do While vence.DayOfWeek <> DayOfWeek.Monday
			vence = vence.AddDays(1)
		Loop
        'Cuentas
        dtab_cuenta = DbMan.read("SELECT sepelio.codigo as codigo, sepelio.fila as fila, sepelio.jubilado as jubilado, sepevar.minimo as minimo,
										 sepevar.jubilado as desc_jubilado, sepevar.fila1 as fila1, sepevar.fila2 as fila2, sepevar.fila3 as fila3,
										 sepevar.fila4 as fila4, sepevar.fila5 as fila5, sepelio.ubicacion as ubicacion, sepelio.tipo as tipo
									FROM sepelio JOIN sepevar ON sepelio.tipo=sepevar.orden
								   WHERE sepelio.tipo > 0 AND sepelio.codigo =>" & CuentaInicial.Value & "
								ORDER BY sepelio.codigo",
								 My.Settings.foxcon)

		dtab_deuda = DbMan.read("SELECT * FROM sepecue", My.Settings.foxcon)

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

			If CalculoAnualSQL.sql.Sepelio.VerificarCuota(dtab_cuenta, fila, periodo.Value, dtab_deuda) Then
				CalculoAnualSQL.sql.Sepelio.InsertarCuota(dtab_cuenta, fila, periodo.Value, importe, vence)
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

		dtab_var = DbMan.read("SELECT * FROM numeros", My.Settings.foxcon)
	End Sub

	Private Sub impuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles impuesto.SelectedIndexChanged
		tae.Text = 0
		If impuesto.Text = "COMERCIO" Then
			tae.Text = dtab_var(0)("taecom").ToString
		ElseIf impuesto.Text = "CATASTRO" Then
			tae.Text = dtab_var(0)("taecat").ToString
		End If
		tae.Text += "%"
	End Sub


	Private Sub iniciar_Click(sender As Object, e As EventArgs) Handles iniciar.Click
		Dim time_start, time_end As DateTime
		Dim run_time As TimeSpan
		time_start = Now
		iniciar.Visible = False
		validar()
		iniciar.Visible = True
		time_end = Now
		run_time = time_end - time_start
		info.Text += Chr(13) & "Procesado en " & run_time.Minutes & " minutos, " & run_time.Seconds & " segundos."
	End Sub
End Class