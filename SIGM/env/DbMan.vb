Module DbMan 'Database Manager
    'Muestra ultimo comando SQL ejecutado
    Public last_sql As String = ""
	Public last_connection As String = ""

    ' READ: Rutinas de lectura 
    Function ReadTableSchema(Optional constr As String = "") As DataTable
        Dim schemaTable As New DataTable
        Dim olecon As New OleDb.OleDbConnection

        If constr = "" Then
            constr = My.Settings.CurrentDB
        End If
        olecon.ConnectionString = constr
        Try
            olecon.Open()
            schemaTable = olecon.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, Nothing)
        Catch ex As oledb.OleDbException
            MsgBox("No se puede conectar a " & constr & Chr(13) & "Detalles:" & ex.Data.ToString)
            schemaTable = Nothing
        End Try
        olecon.Close()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        Return schemaTable
    End Function
    Function ReadDB(OleDBProcedure As OleDb.OleDbCommand, constr As String,
                    Optional TextQuery As String() = Nothing, Optional TableName As String = "") As DataTable
        Dim dtab As New DataTable
        Dim errorMsg As String = ""

        Using olecon As New OleDb.OleDbConnection
            'Crear adaptador de datos
            Dim dada As New OleDb.OleDbDataAdapter

            If OleDBProcedure Is Nothing = False Then
                If OleDBProcedure.CommandType <> System.Data.CommandType.Text Then
                    OleDBProcedure.CommandType = System.Data.CommandType.StoredProcedure
                End If
            ElseIf TextQuery Is Nothing = False Then
                OleDBProcedure = New OleDb.OleDbCommand
                With OleDBProcedure
                    .CommandType = System.Data.CommandType.Text
                    'TextQuery usage:
                    '0: Select |1: From |2: Where |3: Group By |4: Having |5: Order by
                    For Each sql As String In TextQuery
                        If sql Is Nothing = False Then
                            If sql <> "" Then
                                If sql.Contains("SELECT") Or sql.Contains("FROM") _
                            Or sql.Contains("WHERE") Or sql.Contains("GROUP BY") _
                            Or sql.Contains("HAVING") Or sql.Contains("ORDER BY") Then

#Disable Warning CA2100 ' Review SQL queries for security vulnerabilities
                                    .CommandText &= " " & sql
#Enable Warning CA2100 ' Review SQL queries for security vulnerabilities
                                End If
                            End If
                        End If
                    Next
                    'Close the query properly
                    If Right(.CommandText, 1) <> ";" Then
                        .CommandText &= ";"
                    End If
                End With
            End If

            dada.SelectCommand = OleDBProcedure

            If dada.SelectCommand Is Nothing = False Then
                'Si la conexión estaba abierta, cerrarla y mostrar mensaje
                If olecon.State = ConnectionState.Open Then
                    olecon.Close()
                    errorMsg &= "Se cerrará la conexión actual." & Chr(13) & Chr(13) & "Detalles: " & last_sql
                End If

                olecon.ConnectionString = constr
                OleDBProcedure.Connection = olecon
                'Abrir conexion
                Try
                    olecon.Open()
                Catch ex As OleDb.OleDbException
                    Try
                        olecon.ConnectionString = My.Settings.CurrentDB
                        olecon.Close()
                        olecon.Open()
                    Catch ex2 As AccessViolationException
                        errorMsg &= "Una conexión establecida anteriormente impide el acceso a la base de datos."
                        Try
                            olecon.Close()
                            olecon.Open()
                        Catch ex3 As OutOfMemoryException
                            errorMsg &= "No hay memoria suficiente para mostrar la consulta."
                            Try
                                olecon.Close()
                                olecon.Open()
                            Catch ex4 As Exception
                                errorMsg &= "La ruta de acceso a la base de datos es incorrecta."
                            End Try
                        End Try


                    End Try
                End Try
                'Comandos
                Try
                    dada.Fill(dtab)

                Catch ex As OleDb.OleDbException
                    If ex.Message.ToString.Contains("Decimal") Then
                        errorMsg &= "Datos inválidos en un campo de la tabla."
                    Else
                        errorMsg &= "No se encuentra la tabla indicada."
                    End If
                    errorMsg &= Chr(13) & "Detalles:" & ex.Message.ToString

                Catch ex As System.InvalidOperationException
                    errorMsg &= "Uno de los campos de la consulta contiene datos inválidos." & Chr(13) & "Detalles:" & ex.Message.ToString
                Finally
                    olecon.Close()
                    olecon.Dispose()
                    dada.Dispose()

                    If TableName <> "" Then
                        dtab.TableName = TableName
                    End If

                End Try

                last_sql = OleDBProcedure.CommandText
                last_connection = constr

            Else
                errorMsg &= "Datos insuficientes para realizar la consulta."
            End If

            If errorMsg <> "" Then
                MsgBox(errorMsg)
            End If
        End Using
        GC.Collect()
        GC.WaitForPendingFinalizers()
        Return dtab
    End Function

    Function GenerateReportDataset(OleDBProcedure As OleDb.OleDbCommand) As DataSet
		Dim ds As New DataSet
		ds.Tables.Add(DbMan.readDB(OleDBProcedure, My.Settings.CurrentDB))
		Return ds
	End Function

    ' END READ 

    ' SAVE: Rutinas para grabar registros 
    Function EditDB(OleDBProcedure As OleDb.OleDbCommand, Optional ByVal constr As String = Nothing,
                    Optional sqlSourceList() As String = Nothing, Optional ByRef progreso As ToolStripProgressBar = Nothing) As String
        Dim sqlValidList() As String
        Dim RowsAffected As Integer = 0
        Dim result As String = ""
        Dim olecon As New OleDb.OleDbConnection
        'Para conectarse a la bd en modo de inserción
        'Se necesita convertir el string a un objeto ConnectionString
        'antes de aplicarlo al OleDbCommand "Comm"
        If constr Is Nothing Then
            constr = My.Settings.CurrentDB
        End If

        If OleDBProcedure Is Nothing Then
            OleDBProcedure = New OleDb.OleDbCommand With {
              .CommandType = System.Data.CommandType.Text}

            If sqlSourceList Is Nothing = False Then
                'Check if there is a progress bar
                If progreso Is Nothing = False Then
                    progreso.Minimum = 0
                    progreso.Value = progreso.Minimum
                    progreso.Maximum = sqlSourceList.Length()
                End If
                For Each sqlString As String In sqlSourceList
                    If Right(sqlString, 1) <> ";" Then
                        sqlString &= ";"
                    End If
                    If sqlString.Contains("INSERT") Or sqlString.Contains("UPDATE") Then
                        sqlValidList.Append(sqlString)

                    ElseIf sqlString.Contains("DELETE") Then
                        If My.Settings.delete_enabled Then
                            sqlValidList.Append(sqlString)
                        Else
                            MsgBox("No posee permisos para eliminar registros de la tabla seleccionanda.", MsgBoxStyle.Critical, "Error")
                        End If
                    End If
                Next

                'Set connection parameters
                olecon.ConnectionString = constr
                OleDBProcedure.Connection = olecon
                'Open and execute BulkInsert on valid sql statements
                olecon.Open()
                For Each sqlString As String In sqlValidList
                    With sqlString
                        If progreso Is Nothing = False Then
                            progreso.Value += 1
                        End If

#Disable Warning CA2100 ' Review SQL queries for security vulnerabilities
                        OleDBProcedure.CommandText = sqlString
#Enable Warning CA2100 ' Review SQL queries for security vulnerabilities
                        Try
                            RowsAffected += OleDBProcedure.ExecuteNonQuery()
                        Catch e As Exception
                            result &= e.ToString & Chr(13)
                        End Try
                    End With
                Next
                olecon.Close()
                'Clear Procedure
                OleDBProcedure = Nothing
            End If
        End If

        If OleDBProcedure Is Nothing = False And result <> "" Then
            olecon.ConnectionString = constr
            OleDBProcedure.Connection = olecon
            olecon.Open()
            'Abrir la conexión y ejecutar
            Try
                RowsAffected = OleDBProcedure.ExecuteNonQuery()
            Catch e As Exception
                result = e.ToString
            End Try
            olecon.Close()
            'SecMan.WriteSQLLog(sql, constr, My.Settings.UserId)
        End If
        GC.Collect()
        GC.WaitForPendingFinalizers()

        If RowsAffected > 0 Then
            result = RowsAffected
        End If

        If result = "" Then
            result = "Datos insuficientes para realizar la operación."
        End If

        Return result
    End Function
End Module
