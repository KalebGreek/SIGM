Public Class genericDataVisor
	Public Sub LoadDtab(source As DataTable)
		CtrlMan.LoadDataGridView(DataGridView1, BindingSource1, "", source)
	End Sub
End Class