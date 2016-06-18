Module bd
    'Los siguientes strings contienen comandos SQL
    Public sel_sql As String = "" 'SELECT
    Public mod_sql As String = "" 'INSERT o UPDATE
    Public del_sql As String = "" 'DELETE
    Public last_sql As String = ""

    'Conexiones de base de datos
    Public olecon As New OleDb.OleDbConnection
    'Default
    Public defcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & root & "\vrosas.accdb"
    'Otros
    Public adbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & root & "\vrosas.accdb"
    Public foxcon As String = "Provider=vfpoledb.1;Data Source=z:\datos"
    Public pgsqlcon As String = "Provider=PostgreSQL.1;Data Source=\\MALINGUNVILA;Location=sigmDB;User ID=admin;Password=hf32n64;"
    'Public pgsqlcon2 As String = "Provider=PostgreSQL OLE DB Provider;Data Source=\\malingunvila;Location=vrosas;User ID=sigm;password=sigm2013;"

    Public ext_persona, ext_cuenta, ext_vence, ext_historial, ext_variable,
           ext_actividad, ext_muerto, ext_tipo, ext_zona,
           col_tenedor, col_importe, col_pagado, col_periodo, col_vence As String

    '###### READ: Rutinas de lectura #####################################################################

    '###### Reads datatable
    Function read(ByVal constr As String, ByVal sql As String,
                  Optional OleDBProcedure As OleDb.OleDbCommand = Nothing)
        Dim dtab As New DataTable
        If constr Is foxcon Then 'Compatibilidad con Fox
            dtab.Locale = New System.Globalization.CultureInfo("fr-FR")
        End If

        'Crear adaptador de datos
        Dim dada As New OleDb.OleDbDataAdapter

        If sql = "" Then
            OleDBProcedure.CommandType = CommandType.StoredProcedure
            last_sql = "Procedure."
        Else
            OleDBProcedure = New OleDb.OleDbCommand
            OleDBProcedure.CommandType = CommandType.Text
            OleDBProcedure.CommandText = sql
            last_sql = sql
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
                MsgBox("No se encuentra la tabla indicada." & Chr(13) & "Detalles:" & ex.Message.ToString, MsgBoxStyle.Exclamation)
                Return Nothing
            End Try
            olecon.Close()
            dada.Dispose()
            sql = ""
            Return dtab
        Else
            MsgBox("Datos insuficientes para realizar la consulta.", MsgBoxStyle.Exclamation)
            Return Nothing
        End If

    End Function

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

    '###### Visor + Binding + Datatable
    Public Class Query
        Shared Function Show(ByVal visor As DataGridView, ByVal bs As BindingSource, ByVal dtab As DataTable) As DataGridView
            'Esta rutina va después de que la consulta genera la instrucción SQL
            'y lee la datatable; es igual para todos los servicios.
            bs.DataSource = dtab
            visor.DataSource = bs
            visor.Update()
            'Con VB .Net sobre la tabla de consulta
            'Dar formato
            visor = Query.Format(visor)
            Return visor
        End Function
        Shared Function Format(ByVal visor As DataGridView) As DataGridView
            With visor.Columns
                If .Contains("codigo") Then
                    visor.Columns("codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If
                If .Contains("id") Then
                    visor.Columns("id").Width = 0
                End If

                'OPRIVADAS
                If .Contains("user_id") Then
                    visor.Columns("user_id").Width = 0
                End If
                If .Contains("opr_id") Then
                    visor.Columns("opr_id").Width = 0
                End If
                If .Contains("catastro_id") Then
                    visor.Columns("catastro_id").Width = 0
                End If

                'PERSONAS
                If .Contains("per_id") Then
                    visor.Columns("per_id").Width = 0
                End If
                If .Contains("persona_id") Then
                    visor.Columns("persona_id").Width = 0
                End If
                If .Contains("prof_id") Then
                    visor.Columns("prof_id").Width = 0
                End If
                If .Contains("doc_id") Then
                    visor.Columns("doc_id").Width = 0
                End If
                If .Contains("cuil") Then
                    visor.Columns("cuil").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("razon") Then
                    visor.Columns("razon").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("calle") Then
                    visor.Columns("calle").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("altura") Then
                    visor.Columns("altura").Width = 40
                End If
                If .Contains("piso") Then
                    visor.Columns("piso").Width = 30
                End If
                If .Contains("dpto") Then
                    visor.Columns("dpto").Width = 30
                End If
                If .Contains("localidad") Then
                    visor.Columns("localidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("localidad_id") Then
                    visor.Columns("localidad_id").Width = 0
                End If
                If .Contains("email") Then
                    visor.Columns("email").Width = 50
                End If
                If .Contains("telefono") Then
                    visor.Columns("telefono").Width = 50
                End If
                If .Contains("difunto") Then
                    visor.Columns("difunto").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If
                If .Contains("fisica") Then
                    visor.Columns("fisica").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If

                'DOCS
                If .Contains("descripcion") Then
                    visor.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("fecha") Then
                    visor.Columns("fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("ruta") Then
                    visor.Columns("ruta").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If

                'ACTAS
                If .Contains("acta") Then
                    visor.Columns("acta").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("libro") Then
                    visor.Columns("libro").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                If .Contains("nota") Then
                    visor.Columns("nota").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If

                'INMUEBLES
                If .Contains("titular_id") Then
                    visor.Columns("titular_id").Width = 0
                End If
                If .Contains("zona") Then
                    visor.Columns("zona").Width = 20
                End If
                If .Contains("circ") Then
                    visor.Columns("circ").Width = 20
                End If
                If .Contains("secc") Then
                    visor.Columns("secc").Width = 20
                End If
                If .Contains("manz") Then
                    visor.Columns("manz").Width = 20
                End If
                If .Contains("parc") Then
                    visor.Columns("parc").Width = 20
                End If
                If .Contains("lote") Then
                    visor.Columns("lote").Width = 20
                End If
                If .Contains("archivado") Then
                    visor.Columns("archivado").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If

                'FRENTES
                If .Contains("altura") Then
                    visor.Columns("altura").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If
                If .Contains("metros") Then
                    visor.Columns("metros").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End If

                'ORDENANZAS
                If .Contains("concepto") Then
                    visor.Columns("concepto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
                If .Contains("ruta_copia") Then
                    visor.Columns("ruta_copia").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If

                'MOVIMIS
                If .Contains("detalle") Then
                    visor.Columns("detalle").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If

                Return visor
            End With
        End Function
    End Class

    '### Tablas externas
    Sub tablas_fox(ByVal impuesto As String)
        Dim dtab As DataTable = bd.read(defcon,
                                        "SELECT * FROM tablas_externas WHERE servicio='" & impuesto & "'")

        ext_actividad = dtab(0)("actividad").ToString
        ext_cuenta = dtab(0)("cuenta").ToString
        ext_historial = dtab(0)("historial").ToString
        ext_muerto = dtab(0)("muerto").ToString
        ext_persona = dtab(0)("persona").ToString
        ext_tipo = dtab(0)("tipo").ToString
        ext_variable = dtab(0)("variable").ToString
        ext_vence = dtab(0)("vencimiento").ToString
        ext_zona = dtab(0)("zona").ToString

        If impuesto.Contains("AGUA") Then 'AGUA
            col_tenedor = ext_persona & ".tenedor"
            col_importe = ext_cuenta & ".original"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".periodo"
            col_vence = ext_cuenta & ".vencio"
        ElseIf impuesto.Contains("AUTO") Then 'AUTO
            col_tenedor = ext_persona & ".tenedor"
            col_importe = ext_cuenta & ".apagar"
            col_pagado = ext_cuenta & ".apagado"
            col_periodo = ext_cuenta & ".ano"
            col_vence = ext_cuenta & ".vencimi1"
        ElseIf impuesto.Contains("CATA") Then 'CATA
            col_tenedor = ext_persona & ".tenedor"
            col_importe = ext_cuenta & ".original"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".periodo"
            col_vence = ext_cuenta & ".vencio"
        ElseIf impuesto.Contains("COME") Then 'COME
            col_tenedor = ext_persona & ".razon"
            col_importe = ext_cuenta & ".importe"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".ano"
            col_vence = ext_cuenta & ".vence1"
        ElseIf impuesto.Contains("SEPE") Then 'SEPE
            col_tenedor = ext_persona & ".tenedor"
            col_importe = ext_cuenta & ".original"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".periodo"
            col_vence = ext_cuenta & ".vencio"
        End If
    End Sub
    '###### END READ ############################################################################################

End Module
