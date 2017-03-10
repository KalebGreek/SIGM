Public Class Combustible
	Shared Sub FillSeccion(ByRef bs As BindingSource, ByRef target As ComboBox)
		bs.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM seccion ORDER BY descripcion")
		CtrlMan.Fill.AutoComplete(bs, target, "descripcion", "id")
	End Sub

	Shared Sub FillCategory(ByRef bs As BindingSource, ByRef target As ComboBox, ByRef vehiculo As Boolean)
		bs.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_categoria_receptor 
																	  WHERE vehiculo=" & vehiculo & " ORDER BY detalle")
		CtrlMan.Fill.AutoComplete(bs, target, "detalle", "id")
	End Sub
End Class
