Public Class Transito
	Public Class Multas
		'BASE QUERIES
		Shared Function BuscarMulta(Optional impaga As Boolean = False) As OleDb.OleDbCommand
			Dim sql As New OleDb.OleDbCommand
			sql.CommandType = CommandType.Text
			With sql
				.CommandText = "SELECT  multas_historial.boleta, multas_historial.fecha_boleta as fecha, 
										conductor.razon AS conductor, conductor.cuil AS cuil_conductor,
										multas_historial.pago, multas_historial.fecha_pago, 
										multas_articulo.articulo AS nro_articulo, multas_articulo.descripcion,
										multas_historial.ubicacion, multas_historial.observaciones, 
										inspector.razon as inspector,
										propietario.razon AS propietario, propietario.cuil AS cuil_propietario,
										vehiculo.id as vehiculo_id, vehiculo_tipo.tipo AS tipo_vehiculo, 
										vehiculo_marca.marca, vehiculo.patente"

				.CommandText += " FROM (transito_inspector INNER JOIN persona AS inspector ON transito_inspector.persona_id = inspector.id) 
							INNER JOIN (multas_articulo INNER JOIN ((multas_historial 
							INNER JOIN persona AS conductor ON multas_historial.conductor_id = conductor.id) 
							INNER JOIN (vehiculo_tipo INNER JOIN (vehiculo_marca INNER JOIN (vehiculo 
							INNER JOIN persona AS propietario ON vehiculo.propietario_id = propietario.id) 
									ON vehiculo_marca.Id = vehiculo.vehiculo_marca_id) ON vehiculo_tipo.Id = vehiculo.vehiculo_tipo_id) 
									ON multas_historial.vehiculo_id = vehiculo.Id) ON multas_articulo.Id = multas_historial.articulo_id) 
									ON transito_inspector.Id = multas_historial.inspector_id "

				If impaga Then
					.CommandText += " WHERE multas_historial.pago=False"
				End If

				.CommandText += " ORDER BY multas_historial.boleta ASC"
			End With
			Return sql
		End Function
		Shared Function SeleccionarMulta(multa_id As Integer) As DataTable
			Dim sql As New OleDb.OleDbCommand
			sql.CommandType = CommandType.Text
			With sql
				.CommandText = "SELECT  multas_historial.id as multa_id, multas_historial.boleta as boleta, multas_historial.fecha_boleta, 
										multas_articulo.id as articulo_id, multas_articulo.articulo AS articulo, 
										multas_historial.ubicacion, multas_historial.observaciones, 
										multas_historial.pago, multas_historial.fecha_pago, 
										inspector.razon as inspector_razon, transito_inspector.id as inspector_id,
										vehiculo.id AS vehiculo_id, vehiculo_tipo.id AS vehiculo_tipo_id, 
										vehiculo_marca.id as vehiculo_marca_id,	vehiculo.mercosur, vehiculo.patente, 
										propietario.razon AS propietario_razon, propietario.cuil AS propietario_cuil, propietario.id as propietario_id, 
										conductor.razon AS conductor_razon, conductor.cuil AS conductor_cuil, conductor.id as conductor_id"

				.CommandText += " FROM (transito_inspector INNER JOIN persona AS inspector ON transito_inspector.persona_id = inspector.id) 
							INNER JOIN (multas_articulo INNER JOIN ((multas_historial 
							INNER JOIN persona AS conductor ON multas_historial.conductor_id = conductor.id) 
							INNER JOIN (vehiculo_tipo INNER JOIN (vehiculo_marca INNER JOIN (vehiculo 
							INNER JOIN persona AS propietario ON vehiculo.propietario_id = propietario.id) 
									ON vehiculo_marca.Id = vehiculo.vehiculo_marca_id) ON vehiculo_tipo.Id = vehiculo.vehiculo_tipo_id) 
									ON multas_historial.vehiculo_id = vehiculo.Id) ON multas_articulo.Id = multas_historial.articulo_id) 
									ON transito_inspector.Id = multas_historial.inspector_id "

				.CommandText += " WHERE multas_historial.id=" & multa_id & " AND (user_id=0 OR user_id=" & My.Settings.UserId & ")"
			End With
			Return DbMan.readDB(sql, My.Settings.CurrentDB)
		End Function
		Shared Function MultasPorVehiculo(Optional impaga As Boolean = False) As OleDb.OleDbCommand
			Dim sql As New OleDb.OleDbCommand
			sql.CommandType = CommandType.Text
			With sql

				.CommandText = "SELECT 	vehiculo.id, vehiculo_marca.marca, vehiculo_tipo.tipo, vehiculo.patente,
									    propietario.razon AS propietario, propietario.cuil,
										count(multas_historial.id) AS infracciones"

				.CommandText += " FROM (transito_inspector INNER JOIN persona AS inspector ON transito_inspector.persona_id = inspector.id) 
							INNER JOIN (multas_articulo INNER JOIN ((multas_historial 
							INNER JOIN persona AS conductor ON multas_historial.conductor_id = conductor.id) 
							INNER JOIN (vehiculo_tipo INNER JOIN (vehiculo_marca INNER JOIN (vehiculo 
							INNER JOIN persona AS propietario ON vehiculo.propietario_id = propietario.id) 
									ON vehiculo_marca.Id = vehiculo.vehiculo_marca_id) ON vehiculo_tipo.Id = vehiculo.vehiculo_tipo_id) 
									ON multas_historial.vehiculo_id = vehiculo.Id) ON multas_articulo.Id = multas_historial.articulo_id) 
									ON transito_inspector.Id = multas_historial.inspector_id "


				If impaga Then
					.CommandText += " WHERE multas_historial.pago=false"
				End If


				.CommandText += " GROUP BY vehiculo.id, vehiculo_tipo.tipo, vehiculo.patente, vehiculo_marca.marca,
							  propietario.razon, propietario.cuil, propietario.fisica"
			End With
			Return sql
		End Function
		Shared Function VerificarBoleta(boleta As Double) As Integer
            Dim dtab As New DataTable
            Dim sql(0) As String
            sql(0) = "SELECT id, boleta FROM multas_historial WHERE boleta=" & boleta
            dtab = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            If dtab.Rows.Count > 0 Then
				Return dtab(0)("id")
			Else
				Return 0
			End If
		End Function

        'AUX TABLES
        Shared Function FillArticulo() As DataTable
            Dim sql(0) As String
            sql(0) = "SELECT id, articulo, descripcion FROM multas_articulo"
            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function
        Shared Function FillInspector() As DataTable
            Dim sql(0) As String
            sql(0) = "SELECT transito_inspector.id as id, razon 
                        FROM transito_inspector 
				  INNER JOIN persona ON transito_inspector.persona_id=persona.id"
            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function
        Shared Function FillTipoVehiculo() As DataTable
            Dim sql(0) As String
            sql(0) = "SELECT id, tipo FROM vehiculo_tipo"
            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function
        Shared Function FillMarcaVehiculo() As DataTable
            Dim sql(0) As String
            sql(0) = "SELECT id, marca FROM vehiculo_marca ORDER BY marca"
            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
        End Function

        'ABM
        Shared Function Nueva(boleta As Double) As Integer
            Dim sql(0) As String
            sql(0) = "INSERT INTO multas_historial(boleta, user_id) VALUES(" & boleta & ", " & My.Settings.UserId & ")"
            DbMan.editDB(Nothing, My.Settings.CurrentDB,sql(0))

            sql(0) = "SELECT id FROM multas_historial WHERE boleta=" & boleta & "
							   AND user_id=" & My.Settings.UserId
            Return DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)(0)("id")

        End Function

		Shared Function Actualizar(ByRef detalle_boleta As tabMultas1Boleta, ByRef persona As tabMultas2Persona,
									ByRef vehiculo As tabMultas3Vehiculo,
									multa_id As Integer, boleta As Double, lock As Boolean) As Boolean
			Dim valid As Boolean = True
			Dim user_id As Integer = 0
            Dim sql(0) As String

            If lock Then
				user_id = My.Settings.UserId
			End If

			If CtrlMan.Validate(detalle_boleta, detalle_boleta.ErrorInfo) Then
				'Formatting
				With detalle_boleta
					Dim fecha_boleta As Date = CDate(.fecha_boleta.Value)
					Dim inspector_id As Integer = CInt(.bs_inspector.Current("id"))
					Dim articulo_id As Integer = CInt(.bs_articulo.Current("id"))
					Dim observaciones As String = CStr(UCase(.observaciones.Text))
					Dim ubicacion As String = CStr(UCase(.ubicacion.Text))
					Dim fecha_pago As Date = CDate(.fecha_pago.Value)
					Dim pago As Boolean = CBool(.pago.Checked)

					DbMan.editDB(Nothing, My.Settings.CurrentDB,
						   "UPDATE multas_historial 
							   SET fecha_boleta='" & fecha_boleta & "', inspector_id=" & inspector_id & ",
								   articulo_id=" & articulo_id & ", observaciones='" & observaciones & "',
								   ubicacion='" & .ubicacion.Text & "', pago=" & .pago.Checked & ", fecha_pago='" & .fecha_pago.Value & "'
							 WHERE id=" & multa_id & " AND user_id=" & My.Settings.UserId)
				End With
			Else valid = False
			End If

			If CtrlMan.Validate(persona, persona.ErrorInfo) Then
				With persona
					Dim conductor_id As Integer = CInt(.conductor_id.Text)
					DbMan.editDB(Nothing, My.Settings.CurrentDB,
					   "UPDATE multas_historial SET conductor_id=" & conductor_id & " WHERE id=" & multa_id)
				End With
			Else valid = False
			End If

			If CtrlMan.Validate(vehiculo, vehiculo.ErrorInfo) Then
				With vehiculo
					Dim vehiculo_id As Integer = CInt(.vehiculo_id.Text)
					Dim vehiculo_tipo_id As Integer = CInt(.bs_tipo.Current("id"))
					Dim vehiculo_marca_id As Integer = CInt(.bs_marca.Current("id"))
					Dim patente As String = CStr(UCase(.patente.Text))
					Dim mercosur As Boolean = CBool(.mercosur.Checked)
					Dim propietario_id As Integer = CInt(persona.propietario_id.Text)


                    If vehiculo_id > 0 Then
                        sql(0) = "UPDATE vehiculo
                                     SET vehiculo_tipo_id=" & vehiculo_tipo_id & ", vehiculo_marca_id=" & vehiculo_marca_id & ", 
								      patente='" & patente & "', mercosur=" & mercosur & ", 
								      propietario_id=" & propietario_id & "
                                   WHERE id=" & vehiculo_id

                        DbMan.editDB(Nothing, My.Settings.CurrentDB, sql(0))
                    Else
                        sql(0) = "INSERT INTO vehiculo(vehiculo_tipo_id, vehiculo_marca_id, patente, mercosur, propietario_id)
								 	   VALUES(" & vehiculo_tipo_id & ", " & vehiculo_marca_id & ",
											  '" & patente & "', " & mercosur & "," & propietario_id & ")"

                        DbMan.editDB(Nothing, My.Settings.CurrentDB, sql(0))

                        sql(0) = "SELECT MAX(id) as vehiculo_id FROM vehiculo"
                        vehiculo_id = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)(0)("vehiculo_id")

                        sql(0) = "UPDATE multas_historial SET vehiculo_id=" & vehiculo_id & " WHERE id=" & multa_id
                        DbMan.editDB(Nothing, My.Settings.CurrentDB, sql(0))

                    End If
                End With
			Else valid = False
			End If

            sql(0) = "UPDATE multas_historial SET boleta=" & boleta & ",  user_id=" & user_id & " WHERE id=" & multa_id
            DbMan.editDB(Nothing, My.Settings.CurrentDB, sql(0))

            Return valid
		End Function

		Shared Function Eliminar(multa_id As Integer, vehiculo_id As Integer) As Boolean
			If multa_id > 0 Then
				If vehiculo_id > 0 Then
					DbMan.editDB(Nothing, My.Settings.CurrentDB,
						   "DELETE FROM vehiculo WHERE id=" & vehiculo_id)
				End If
				DbMan.editDB(Nothing, My.Settings.CurrentDB,
						  "DELETE FROM multas_historial 
						    WHERE historial_id=" & multa_id & " 
							  AND (user_id=0 OR user_id=" & My.Settings.UserId & ")")
			End If
		End Function
	End Class
End Class
