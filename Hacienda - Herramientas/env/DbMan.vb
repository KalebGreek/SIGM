Module DbMan 'Database Manager
    'Muestra ultimo comando SQL ejecutado
    Public last_sql As String = ""
	Public last_connection As String = ""
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
	End Function 'Unused

	Function readTableSchema(Optional constr As String = "") As DataTable
		If constr = "" Then
			constr = My.Settings.CurrentDB
		End If

		olecon.ConnectionString = constr
		Dim schemaTable As New DataTable
		Try
			olecon.Open()
			schemaTable = olecon.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, Nothing)
		Catch ex As Exception
			MsgBox("No se puede conectar a " & constr & Chr(13) & "Detalles:" & ex.Data.ToString)
			schemaTable = Nothing
		End Try
		olecon.Close()
		Return schemaTable
	End Function
	Function readDB(OleDBProcedure As OleDb.OleDbCommand, constr As String,
				  Optional sqlSelect As String = "", Optional sqlFrom As String = "",
				  Optional sqlWhere As String = "", Optional sqlGroupBy As String = "",
				  Optional sqlHaving As String = "", Optional sqlOrderBy As String = "",
				  Optional ReturnError As Boolean = False) As DataTable

		Dim dtab As New DataTable
		Dim errorMsg As String = ""

		'Crear adaptador de datos
		Dim dada As New OleDb.OleDbDataAdapter

		If OleDBProcedure Is Nothing = False Then
			If OleDBProcedure.CommandType <> CommandType.Text Then
				OleDBProcedure.CommandType = CommandType.StoredProcedure
			End If
		ElseIf sqlSelect <> "" Then
			OleDBProcedure = New OleDb.OleDbCommand
			OleDBProcedure.CommandType = CommandType.Text
			OleDBProcedure.CommandText = sqlSelect
			'Additional query options
			If sqlFrom <> "" And sqlFrom.Contains("FROM") Then
				OleDBProcedure.CommandText &= " " & sqlFrom
				If sqlWhere <> "" And sqlWhere.Contains("WHERE") Then
					OleDBProcedure.CommandText &= " " & sqlWhere
				End If
				If sqlGroupBy <> "" And sqlGroupBy.Contains("GROUP BY") Then
					OleDBProcedure.CommandText &= " " & sqlGroupBy
					If sqlHaving <> "" And sqlHaving.Contains("HAVING") Then
						OleDBProcedure.CommandText &= " " & sqlHaving
					End If
				End If
				If sqlOrderBy <> "" And sqlOrderBy.Contains("ORDER BY") Then
					OleDBProcedure.CommandText &= " " & sqlOrderBy
				End If
			End If
			'Close the query properly
			If Right(OleDBProcedure.CommandText, 1) <> ";" Then
				OleDBProcedure.CommandText &= ";"
			End If
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
			Catch ex As OleDb.OleDbException
				Try
					olecon.ConnectionString = My.Settings.CurrentDB
					olecon.Open()
				Catch ex2 As Exception
					errorMsg = "La ruta de acceso a la base de datos es incorrecta."
				End Try
			End Try
            'Comandos
            Try
				dada.Fill(dtab)

			Catch ex As OleDb.OleDbException
				If ex.Message.ToString.Contains("Decimal") Then
					errorMsg = "Datos inválidos en un campo de la tabla."
				Else
					errorMsg = "No se encuentra la tabla indicada."
				End If
				errorMsg += Chr(13) & "Detalles:" & ex.Message.ToString

			Catch ex As System.InvalidOperationException
				errorMsg = "Uno de los campos de la consulta contiene datos inválidos." & Chr(13) & "Detalles:" & ex.Message.ToString
			Finally
				olecon.Close()
				dada.Dispose()
			End Try

			last_sql = OleDBProcedure.CommandText
			last_connection = constr

		Else
			errorMsg = "Datos insuficientes para realizar la consulta."
		End If

        If errorMsg <> "" Then
            Dim sql As String
            If OleDBProcedure.CommandType = CommandType.Text Then
                sql = "Consulta: "
                sql += Replace(OleDBProcedure.CommandText, "'", "`")
            Else
                sql = "Procedimiento: "
                sql += OleDBProcedure.CommandText
            End If
            editDB(Nothing, constr,
                   "INSERT INTO sql_log(_date, _user_id, _sql, _con) VALUES('" & Date.Now & "', '" & My.Settings.UserId & "', '" & OleDBProcedure.CommandText & "','" & My.Settings.CurrentDB & "');")
            dtab = Nothing
        End If
        Return dtab

	End Function

	Function GenerateReportDataset(OleDBProcedure As OleDb.OleDbCommand) As DataSet
		Dim ds As New DataSet
		ds.Tables.Add(DbMan.readDB(OleDBProcedure, My.Settings.CurrentDB))
		Return ds
	End Function

	'###### END READ ############################################################################################

	'###### SAVE: Rutinas para grabar registros #################################################################
	Function editDB(OleDBProcedure As OleDb.OleDbCommand, Optional ByVal constr As String = Nothing,
				  Optional sql As String = "") As String
		Dim result As String = ""
		'Para conectarse a la bd en modo de inserción
		'Se necesita convertir el string a un objeto ConnectionString
		'antes de aplicarlo al OleDbCommand "Comm"
		If OleDBProcedure Is Nothing And sql.Contains("INSERT") Or sql.Contains("UPDATE") Or sql.Contains("DELETE") Then
			Dim SQLCommand As New OleDb.OleDbCommand
			SQLCommand.CommandText = sql
			OleDBProcedure = SQLCommand
		End If

		If constr Is Nothing Then
			constr = My.Settings.CurrentDB
		End If

		If OleDBProcedure Is Nothing = False Then
			olecon.ConnectionString = constr
			OleDBProcedure.Connection = olecon
			'Abrir la conexión y ejecutar
			olecon.Open()
			Try
				Dim RowsAffected As Int32 = OleDBProcedure.ExecuteNonQuery()
				result = RowsAffected
			Catch e As Exception
				result = e.ToString
			End Try
			olecon.Close()
			'SecMan.log_write(sql, constr, My.Settings.UserId)
		Else
			result = "Datos insuficientes para realizar la operación."
		End If
		Return result
	End Function
    '###### END SAVE ############################################################################################   


End Module
