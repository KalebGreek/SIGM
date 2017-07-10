Module DbMan
    'Muestra ultimo comando SQL ejecutado
    Public last_sql As String = ""

    'Conexiones de base de datos
    Public olecon As New OleDb.OleDbConnection

	'###### READ: Rutinas de lectura #####################################################################
	Function KeywordToSQL(sql As String, field As String, keyword As String) As String
		'Rutina para validar datos de busqueda y armar instruccion WHERE basada en nombres comunes de columna
		keyword = Trim(keyword)
		If Len(keyword) > 1 Or Val(keyword) > 0 Then
			If field.Contains("_id") Or field.Contains("num") Then
				sql += field & "=" & keyword

			ElseIf field.Contains("razon") Or field.Contains("apellido") Or field.Contains("nombre") Or field.Contains("direccion") _
			Or field.Contains("ubicacion") Or field.Contains("direccion") Or field.Contains("calle") Or field.Contains("localidad") _
			Or field.Contains("provincia") Then
				sql += field & " LIKE '%" & keyword & "%'"

			ElseIf field.Contains("fecha") Or field.Contains("alta") Or field.Contains("baja") Then
				sql += field & "='" & keyword & "'"

			ElseIf field.Contains("cuil") Or field.Contains("cuit") Then
				If Len(keyword) = 13 Then
					keyword = Replace(keyword, "-", "")
				End If
				If Len(keyword) = 11 Then
					sql += field & "='" & keyword & "'"
				End If

			ElseIf field.Contains("dni") Then
				If Len(keyword) > 4 And Len(keyword) < 9 Then
					sql += field & "='" & keyword & "'"
				End If
			End If
		Else
			sql = ""
		End If
		Return sql
	End Function


	Function readTables(Optional constr As String = "") As DataTable
		If constr = "" Then
			constr = My.Settings.DefaultCon
		End If

		olecon.ConnectionString = constr
		olecon.Open()
		Dim schemaTable As DataTable
		schemaTable = olecon.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, Nothing)
		olecon.Close()
		Return schemaTable
	End Function
	Function read(ByVal sql As String, Optional constr As String = Nothing,
				  Optional OleDBProcedure As OleDb.OleDbCommand = Nothing)

		Dim dtab As New DataTable

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

		If constr Is Nothing Then
			constr = My.Settings.DefaultCon
		End If

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
		ds.Tables.Add(DbMan.read(sql))
		Return ds
	End Function

	'###### END READ ############################################################################################

	'###### SAVE: Rutinas para grabar registros #################################################################
	Function edit(ByVal sql As String, Optional ByVal constr As String = Nothing, Optional OleDBProcedure As OleDb.OleDbCommand = Nothing) As String
        'Para conectarse a la bd en modo de inserción
        'Se necesita convertir el string a un objeto ConnectionString
        'antes de aplicarlo al OleDbCommand "Comm"
        If OleDBProcedure Is Nothing And sql.Contains("INSERT") Or sql.Contains("UPDATE") Or sql.Contains("DELETE") Then
			Dim SQLCommand As New OleDb.OleDbCommand
			SQLCommand.CommandText = sql
			OleDBProcedure = SQLCommand
		End If

		If constr Is Nothing Then
			constr = My.Settings.DefaultCon
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
