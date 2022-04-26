Module DbMan 'Database Manager
    'Muestra ultimo comando SQL ejecutado
    Property Last_sql As String = ""
    Property Last_connection As String = ""

    ' READ: Rutinas de lectura 
    Function ReadTableSchema(Optional constr As String = "") As DataTable
        Dim schemaTable As New DataTable
        Dim errormsg As String = ""
        If constr = "" Then
            constr = My.Settings.CurrentDB
        End If

        Using olecon As New OleDb.OleDbConnection
            olecon.ConnectionString = constr
            Try
                olecon.Open()
                schemaTable = olecon.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, Nothing)
                Try
                    olecon.Close()
                Catch ex As Exception
                    errormsg = ex.Data.ToString & Chr(13)
                End Try
            Catch ex As Exception
                errormsg += ex.Data.ToString & Chr(13)
                schemaTable = Nothing
            End Try

            If errormsg.Length > 0 Then
                MsgBox("No se puede conectar a " & constr & Chr(13) & "Detalles:" & errormsg)
            End If
        End Using

        GC.Collect()
        GC.WaitForPendingFinalizers()
        Return schemaTable
    End Function
    Function ReadDB(SingleQuery As String, constr As String, Optional TableName As String = "", Optional FirstResult As Boolean = False) As Object
        'Step 1
        Dim sqlArray(0) As String
        sqlArray(0) = SingleQuery

        Return ReadDB(sqlArray, constr, TableName, FirstResult)
    End Function
    Function ReadDB(ArrayQuery As String(), constr As String, Optional TableName As String = "", Optional FirstResult As Boolean = False) As Object
        'Step 2
        Dim OleDBProcedure As New OleDb.OleDbCommand
        With OleDBProcedure
            .CommandType = System.Data.CommandType.Text
            'TextQuery usage:
            '0: Select |1: From |2: Where |3: Group By |4: Having |5: Order by
            For Each sql As String In ArrayQuery
                If sql Is Nothing = False Then
                    If sql <> "" Then
                        If sql.Contains("SELECT") Or sql.Contains("FROM") _
                        Or sql.Contains("WHERE") Or sql.Contains("GROUP BY") _
                        Or sql.Contains("HAVING") Or sql.Contains("ORDER BY") Then
                            .CommandText &= " " & sql
                        End If
                    End If
                End If
            Next
            'Close the query properly
            If Right(.CommandText, 1) <> ";" Then
                .CommandText &= ";"
            End If
        End With

        Return ReadDB(OleDBProcedure, constr, TableName, FirstResult)

    End Function
    Function ReadDB(OleDBProcedure As OleDb.OleDbCommand, constr As String, Optional TableName As String = "", Optional FirstResult As Boolean = False) As Object
        'Step 3
        Dim dtab As New DataTable
        Dim errorMsg As String = ""

        Using olecon As New OleDb.OleDbConnection
            'Crear adaptador de datos
            Dim dada As New OleDb.OleDbDataAdapter With {
                .SelectCommand = OleDBProcedure}

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
                Catch ex As Exception
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

        If FirstResult Then 'Returns the first row from the datatable
            Dim dr As DataRow = Nothing
            If dtab Is Nothing = False Then
                If dtab.Rows.Count > 0 Then
                    dr = dtab.Rows(0)
                End If
            End If

            Return dr
        Else
            Return dtab
        End If
    End Function

    Function GenerateReportDataset(OleDBProcedure As OleDb.OleDbCommand) As DataSet
        Dim ds As New DataSet
        ds.Tables.Add(DbMan.ReadDB(OleDBProcedure, My.Settings.CurrentDB))
        Return ds
    End Function

    ' END READ 

    ' SAVE: Rutinas para grabar registros 
    Function EditDB(ByVal SingleQuery As String, Optional ByVal constr As String = Nothing) As Double
        'Step 1
        Dim ArrayQuery(0) As String
        ArrayQuery(0) = SingleQuery

        Return EditDB(ArrayQuery, constr)
    End Function

    Function EditDB(ArrayQuery As String(), Optional ByVal constr As String = Nothing,
                    Optional ByRef progreso As ToolStripProgressBar = Nothing) As Double
        'Step 2
        Dim RowsAffected As Integer = -1
        Dim ErrorMsg As String = ""
        Dim index As Integer = 0
        Dim olecon As New OleDb.OleDbConnection
        Dim OleDBProcedure As New OleDb.OleDbCommand

        If ArrayQuery Is Nothing = False Then
            'Format array
            For Each query In ArrayQuery
                If Right(query, 1) <> ";" Then
                    query &= ";"
                End If
                If query.Contains("INSERT") Or query.Contains("UPDATE") Then

                ElseIf query.Contains("DELETE") Then
                    If My.Settings.delete_enabled Then
                    Else
                        ErrorMsg = "No posee permisos para eliminar registros de la tabla seleccionanda."
                        query = ""
                    End If
                End If
            Next

            'Check if there is a progress bar
            If progreso Is Nothing = False Then
                progreso.Minimum = index
                progreso.Value = progreso.Minimum
                progreso.Maximum = ArrayQuery.Length()
            End If

            'Para conectarse a la bd en modo de inserción
            'Se necesita convertir el string a un objeto ConnectionString
            'antes de aplicarlo al OleDbCommand "Comm"
            If constr Is Nothing Then
                constr = My.Settings.CurrentDB
            End If

            'Set connection parameters
            olecon.ConnectionString = constr
            OleDBProcedure.Connection = olecon
            'Open and execute BulkInsert on valid sql statements
            olecon.Open()

            For Each query In ArrayQuery
                Try
                    OleDBProcedure.CommandText = query
                    RowsAffected += OleDBProcedure.ExecuteScalar()
                Catch e As Exception
                    ErrorMsg &= e.ToString & Chr(13)
                End Try
                If progreso Is Nothing = False Then
                    progreso.Increment(1)
                End If
            Next

            olecon.Close()
            'Clear Procedure
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End If

        If ErrorMsg <> "" Then
            MsgBox(ErrorMsg, MsgBoxStyle.Critical, "Error")
        End If

        Return RowsAffected
    End Function
End Module
