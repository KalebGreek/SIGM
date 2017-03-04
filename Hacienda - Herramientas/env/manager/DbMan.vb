Module DbMan
    'Muestra ultimo comando SQL ejecutado
    Public last_sql As String = ""

    'Conexiones de base de datos
    Public olecon As New OleDb.OleDbConnection

	Public ext_persona, ext_cuenta, ext_vence, ext_historial, ext_variable,
		   ext_actividad, ext_muerto, ext_tipo, ext_zona,
		   col_tenedor, col_importe, col_pagado, col_periodo, col_vence As String

	'###### READ: Rutinas de lectura #####################################################################
	Function read(ByVal constr As String, ByVal sql As String,
				  Optional OleDBProcedure As OleDb.OleDbCommand = Nothing)

		Dim dtab As New DataTable
		If constr Is My.Settings.foxcon Then 'Compatibilidad con Fox
            dtab.Locale = New System.Globalization.CultureInfo("fr-FR")
		End If

        'Crear adaptador de datos
        Dim dada As New OleDb.OleDbDataAdapter

		If sql = "" Then
			OleDBProcedure.CommandType = CommandType.StoredProcedure
		Else
			OleDBProcedure = New OleDb.OleDbCommand
			OleDBProcedure.CommandType = CommandType.Text
			OleDBProcedure.CommandText = sql
		End If
		dada.SelectCommand = OleDBProcedure

		If dada.SelectCommand Is Nothing = False Then
            'Si la conexión estaba abierta, cerrarla y mostrar mensaje
            If olecon.State = ConnectionState.Open Then
				olecon.Close()
				MsgBox("Se cerrará la conexión actual." & Chr(13) & Chr(13) & "Detalles: " & last_sql)
			End If

			olecon.ConnectionString = constr
			OleDBProcedure.Connection = olecon
            'Abrir conexion
            Try
				olecon.Open()
			Catch ex As System.Data.OleDb.OleDbException
				MsgBox("La ruta de acceso a la base de datos es incorrecta.", MsgBoxStyle.Critical)

			End Try
            'Comandos
            Try
				dada.Fill(dtab)
			Catch ex As System.Data.OleDb.OleDbException
				MsgBox("No se encuentra la tabla indicada." & Chr(13) & "Detalles:" & ex.Message.ToString & Chr(13) & "Conexion:" & olecon.ToString, MsgBoxStyle.Exclamation)
				Return Nothing
			End Try
			olecon.Close()
			dada.Dispose()
			last_sql = sql
			Return dtab
		Else
			MsgBox("Datos insuficientes para realizar la consulta.", MsgBoxStyle.Exclamation)
			Return Nothing
		End If

	End Function

	Function GenerateReportDataset(ByVal sql As String, Optional OleDBProcedure As OleDb.OleDbCommand = Nothing) As DataSet
		Dim ds As New DataSet
		ds.Tables.Add(DbMan.read(My.Settings.DefaultCon, sql))
		Return ds
	End Function

	Sub tablas_fox(ByVal impuesto As String)
        'Las tablas correspondientes a personas tienen los nombres correctos
        Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon,
										"SELECT * FROM tablas_externas WHERE personas='" & impuesto & "'")

        'Tablas generales
        ext_persona = dtab(0)("personas").ToString
		ext_cuenta = dtab(0)("cuentas").ToString

		If impuesto.Contains("AGUA") Then 'AGUA
            'Tablas puntuales
            ext_historial = dtab(0)("historial").ToString
			ext_variable = dtab(0)("variables").ToString
			ext_vence = dtab(0)("vencimientos").ToString
			ext_zona = dtab(0)("zona").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
			col_importe = ext_cuenta & ".original"
			col_pagado = ext_cuenta & ".pagado"
			col_periodo = ext_cuenta & ".periodo"
			col_vence = ext_cuenta & ".vencio"
		ElseIf impuesto.Contains("AUTO") Then 'AUTO
            'Tablas puntuales
            ext_tipo = dtab(0)("tipo").ToString
			ext_vence = dtab(0)("vencimientos").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
			col_importe = ext_cuenta & ".apagar"
			col_pagado = ext_cuenta & ".apagado"
			col_periodo = ext_cuenta & ".ano"
			col_vence = ext_cuenta & ".vencimi1"
		ElseIf impuesto.Contains("CATA") Then 'CATA
            'Tablas puntuales
            ext_historial = dtab(0)("historial").ToString
			ext_vence = dtab(0)("vencimientos").ToString
			ext_zona = dtab(0)("zona").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
			col_importe = ext_cuenta & ".original"
			col_pagado = ext_cuenta & ".pagado"
			col_periodo = ext_cuenta & ".periodo"
			col_vence = ext_cuenta & ".vencio"
		ElseIf impuesto.Contains("COME") Then 'COME
            'Tablas puntuales
            ext_actividad = dtab(0)("actividad").ToString
			ext_historial = dtab(0)("historial").ToString
			ext_variable = dtab(0)("variables").ToString
			ext_vence = dtab(0)("vencimientos").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".razon"
			col_importe = ext_cuenta & ".importe"
			col_pagado = ext_cuenta & ".pagado"
			col_periodo = ext_cuenta & ".ano"
			col_vence = ext_cuenta & ".vence1"
		ElseIf impuesto.Contains("SEPE") Then 'SEPE
            'Tablas puntuales
            ext_historial = dtab(0)("historial").ToString
			ext_muerto = dtab(0)("muertos").ToString
			ext_variable = dtab(0)("variables").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
			col_importe = ext_cuenta & ".original"
			col_pagado = ext_cuenta & ".pagado"
			col_periodo = ext_cuenta & ".periodo"
			col_vence = ext_cuenta & ".vencio"
		End If
	End Sub

	'###### END READ ############################################################################################

	'###### SAVE: Rutinas para grabar registros #################################################################
	Function edit(ByVal constr As String, ByVal sql As String, Optional OleDBProcedure As OleDb.OleDbCommand = Nothing) As String
        'Para conectarse a la bd en modo de inserción
        'Se necesita convertir el string a un objeto ConnectionString
        'antes de aplicarlo al OleDbCommand "Comm"
        If OleDBProcedure Is Nothing And sql.Contains("INSERT") Or sql.Contains("UPDATE") Or sql.Contains("DELETE") Then
			Dim SQLCommand As New OleDb.OleDbCommand
			SQLCommand.CommandText = sql
			OleDBProcedure = SQLCommand
		End If
		If OleDBProcedure Is Nothing = False Then

			olecon.ConnectionString = constr
			OleDBProcedure.Connection = olecon
            'Abrir la conexión y ejecutar
            olecon.Open()
			OleDBProcedure.ExecuteNonQuery()
			olecon.Close()
			sql = ""
			Return Nothing
		Else
			Return "Datos insuficientes para realizar la operación."
		End If

	End Function
    '###### END SAVE ############################################################################################   
End Module
