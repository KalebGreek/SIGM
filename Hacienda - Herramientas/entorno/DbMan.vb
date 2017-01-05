Module DbMan
    'Muestra ultimo comando SQL ejecutado
    Public last_sql As String = ""

    'Conexiones de base de datos
    Public olecon As New OleDb.OleDbConnection
	Dim DefaultCon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=opticadb.accdb"

	'###### READ: Rutinas de lectura #####################################################################
	Function read(ByVal sql As String,
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

		If dada.SelectCommand Is Nothing = False Then
            'Si la conexión estaba abierta, cerrarla y mostrar mensaje
            If olecon.State = ConnectionState.Open Then
				olecon.Close()
				MsgBox("Se cerrará la conexión actual." & Chr(13) & Chr(13) & "Detalles: " & last_sql)
			End If

			olecon.ConnectionString = DefaultCon
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
				MsgBox("No se encuentra la tabla indicada." & Chr(13) & "Detalles:" & ex.Message.ToString, MsgBoxStyle.Exclamation)
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
	Function edit(ByVal sql As String, Optional OleDBProcedure As OleDb.OleDbCommand = Nothing) As String
        'Para conectarse a la bd en modo de inserción
        'Se necesita convertir el string a un objeto ConnectionString
        'antes de aplicarlo al OleDbCommand "Comm"
        If OleDBProcedure Is Nothing And sql.Contains("INSERT") Or sql.Contains("UPDATE") Or sql.Contains("DELETE") Then
			Dim SQLCommand As New OleDb.OleDbCommand
			SQLCommand.CommandText = sql
			OleDBProcedure = SQLCommand
		End If
		If OleDBProcedure Is Nothing = False Then

			olecon.ConnectionString = DefaultCon
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
