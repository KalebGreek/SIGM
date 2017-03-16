Public Class Hacienda
	Shared Sub FillSeccion(ByRef bs As BindingSource, ByRef target As ComboBox)
		bs.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM seccion ORDER BY descripcion")
		CtrlMan.Fill.AutoComplete(bs, target, "descripcion", "id")
	End Sub
	Shared Sub FillCuenta(ByRef bs As BindingSource, ByRef target As ComboBox)
		bs.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hacienda WHERE sumado=2 ORDER BY orden ")
		CtrlMan.Fill.AutoComplete(bs, target, "nombre", "id")
	End Sub
End Class
