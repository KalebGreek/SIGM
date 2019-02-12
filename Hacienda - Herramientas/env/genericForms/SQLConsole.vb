Imports System.ComponentModel

Public Class SQLConsole
	Private Sub SQLConsole_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then
			connection.Items.Add(My.Settings.adbcon)
			connection.Items.Add(My.Settings.foxcon)
			connection.Items.Add(My.Settings.pgsqlcon)
		End If
	End Sub

	Private Sub ExecuteQuery()
		query.Text = UCase(Trim(query.Text))
		If query.Text = "CLS" Then
			QueryLog.Items.Clear()
			query.Text = ""
		ElseIf query.Text <> "" Then
			Dim dtab As New DataTable
			Dim OleDBCmd As New OleDb.OleDbCommand
			With OleDBCmd
				.CommandType = CommandType.Text
				.CommandText = query.Text
				If connection.Text <> "" Then
					query.Items.Insert(0, OleDBCmd.CommandText)
					QueryLog.Items.Insert(0, OleDBCmd.CommandText)
					If .CommandText.Contains("INSERT") Or .CommandText.Contains("UPDATE") Or .CommandText.Contains("DELETE") Then
						QueryLog.Items.Insert(0, DbMan.edit(OleDBCmd, connection.Text))

					ElseIf .CommandText.Contains("SELECT") Then
						CtrlMan.LoadDataGridView(QueryResult, bs_result, "", DbMan.read(OleDBCmd, connection.Text))
					End If
					query.Text = ""
				Else
					QueryLog.Items.Insert(0, "Ninguna base de datos selecccionada.")
				End If
			End With
		Else
			QueryLog.Items.Insert(0, "Datos insuficientes para realizar la consulta.")
		End If

	End Sub

	Private Sub query_KeyUp(sender As Object, e As KeyEventArgs) Handles query.KeyUp
		If e.KeyValue = Keys.Enter Then
			ExecuteQuery()
		End If
	End Sub

	Private Sub query_log_SelectedValueChanged(sender As Object, e As EventArgs) Handles QueryLog.SelectedIndexChanged
		ToolTip1.SetToolTip(QueryLog, QueryLog.SelectedItem)
	End Sub

	Private Sub connection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles connection.SelectedIndexChanged
		TableList.Items.Clear()
		If connection.Text <> "" Then
			Dim TableNames As DataTable = DbMan.readTableSchema(connection.Text)
			For Each dr As DataRow In TableNames.Rows
				TableList.Items.Add(dr("table_name").ToString)
			Next
		End If
	End Sub
	Private Sub TableList_DoubleClick() Handles TableList.DoubleClick
		If TableList.SelectedItem <> "" Then
			query.Text = "SELECT * FROM " & TableList.SelectedItem
			ExecuteQuery()
		End If
	End Sub

	Private Sub QueryLog_DoubleClick(sender As Object, e As EventArgs) Handles QueryLog.DoubleClick
		If QueryLog.Text.Contains("SELECT") Or QueryLog.Text.Contains("INSERT INTO") _
		Or QueryLog.Text.Contains("UPDATE") Or QueryLog.Text.Contains("DELETE") Then
			query.Text = QueryLog.Text
			ExecuteQuery()
		End If

	End Sub
End Class