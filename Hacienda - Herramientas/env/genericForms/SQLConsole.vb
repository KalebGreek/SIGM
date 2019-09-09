Imports System.ComponentModel

Public Class SQLConsole
	Private Sub SQLConsole_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then
			connection.Items.Add(My.Settings.AdbConnection)
			connection.Items.Add(My.Settings.foxConnection)
			connection.Items.Add(My.Settings.pgsql_disabled)
		End If
	End Sub




    Private Sub query_KeyUp(sender As Object, e As KeyEventArgs) Handles query.KeyUp
		If e.KeyValue = Keys.Enter Then
			query.Text = ExecuteQuery(query.Text)
		End If
	End Sub

	Private Sub query_log_SelectedValueChanged(sender As Object, e As EventArgs) Handles QueryLog.SelectedIndexChanged
		ToolTip1.SetToolTip(QueryLog, QueryLog.SelectedItem)
	End Sub

    Private Sub connection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles connection.SelectedIndexChanged
        ConnectDB()
    End Sub
    Private Sub connection_KeyUp(sender As Object, e As KeyEventArgs) Handles connection.KeyUp
        If e.KeyValue = Keys.Enter Then
            ConnectDB()
        End If
    End Sub



    Private Sub TableList_DoubleClick() Handles TableList.DoubleClick
		If TableList.SelectedItem <> "" Then
			query.Text = "SELECT * FROM " & TableList.SelectedItem
			ExecuteQuery(query.Text)
		End If
	End Sub

	Private Sub QueryLog_DoubleClick(sender As Object, e As EventArgs) Handles QueryLog.DoubleClick
		If QueryLog.Text.Contains("SELECT") Or QueryLog.Text.Contains("INSERT INTO") _
		Or QueryLog.Text.Contains("UPDATE") Or QueryLog.Text.Contains("DELETE") Then
			query.Text = QueryLog.Text
			query.Text = ExecuteQuery(query.Text)
		End If

	End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddScript.Click
        Dim ruta As String = ""
        Dim filediag As New OpenFileDialog
        filediag.ShowDialog()
        ruta = filediag.FileName
        If My.Computer.FileSystem.FileExists(ruta) Then
            Dim parsedScript As String = Trim(My.Computer.FileSystem.ReadAllText(ruta))
            If MsgBoxResult.Yes = MsgBox(parsedScript, MsgBoxStyle.YesNo) Then
                Replace(parsedScript, Chr(13), "")
                ExecuteQuery(parsedScript)
            End If
        End If
    End Sub

    'RUTINAS
    Private Function ExecuteQuery(sql As String) As String
        If sql = "cls" Then
            QueryLog.Items.Clear()
            sql = ""
        ElseIf sql <> "" Then
            Dim dtab As New DataTable
            Dim OleDBCmd As New OleDb.OleDbCommand
            With OleDBCmd
                Replace(sql, "select", "SELECT")
                Replace(sql, "insert", "INSERT")
                Replace(sql, "update", "UPDATE")
                Replace(sql, "delete", "DELETE")
                .CommandType = CommandType.Text
                .CommandText = sql
                If connection.Text <> "" Then
                    query.Items.Insert(0, OleDBCmd.CommandText)
                    QueryLog.Items.Insert(0, OleDBCmd.CommandText)
                    If .CommandText.Contains("INSERT") Or .CommandText.Contains("UPDATE") Or .CommandText.Contains("DELETE") Then
                        QueryLog.Items.Insert(0, DbMan.editDB(OleDBCmd, connection.Text))

                    ElseIf .CommandText.Contains("SELECT") Then
                        CtrlMan.LoadDataGridView(QueryResult, bs_result, "", DbMan.ReadDB(OleDBCmd, connection.Text))
                    End If
                    sql = ""
                Else
                    QueryLog.Items.Insert(0, "Ninguna base de datos selecccionada.")
                End If
            End With
        Else
            QueryLog.Items.Insert(0, "Datos insuficientes para realizar la consulta.")
        End If
        Return sql
    End Function
    Private Sub ConnectDB()
        TableList.Items.Clear()
        If connection.Text <> "" Then
            Dim TableNames As DataTable = DbMan.readTableSchema(connection.Text)
            For Each dr As DataRow In TableNames.Rows
                TableList.Items.Add(dr("table_name").ToString)
            Next
        End If
    End Sub
End Class