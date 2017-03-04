Public Class CtrlCombustiblePorReceptor
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Private Sub Button12_VisibleChanged(sender As Object, e As EventArgs) Handles Button12.VisibleChanged
		bs_seccion.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT id, descripcion FROM seccion")
		bs_categoria.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT id, detalle, vehiculo FROM hac_categoria_receptor")
		CtrlMan.Fill.AutoComplete(bs_seccion, seccion, "descripcion", "id")
		CtrlMan.Fill.AutoComplete(bs_categoria, categoria, "detalle", "id")
		Button6.Visible = Button12.Visible
		Button7.Visible = Button12.Visible
		Button8.Visible = Button12.Visible
		Button9.Visible = Button12.Visible
		Button10.Visible = Button12.Visible
		Button11.Visible = Button12.Visible
		Button13.Visible = Button12.Visible
		Button14.Visible = Button12.Visible
	End Sub

	Private Sub bs_seccion_PositionChanged(sender As Object, e As EventArgs) Handles bs_seccion.PositionChanged, bs_categoria.PositionChanged
		If bs_seccion.Position > -1 And bs_categoria.Position > -1 Then
			bs_receptor.DataSource = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_receptor WHERE seccion_id=" & bs_seccion.Current("id") & "
												AND categoria_id=" & bs_categoria.Current("id"))
		Else
			bs_receptor.DataSource = Nothing
		End If
	End Sub

	Public Sub bs_receptor_PositionChanged(sender As Object, e As EventArgs) Handles bs_receptor.PositionChanged

	End Sub
End Class
