Public Class DomicilioPage
	Inherits System.Windows.Forms.TabPage

	Public Sub New(contador As Integer)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		CtrlMan.Fill.GetStates(provincia, bs_provincia)
		bs_provincia.Position = bs_provincia.Find("nombre", "CORDOBA")
		bs_localidad.Position = bs_localidad.Find("nombre", "VILLA DE LAS ROSAS")

		GenerateName(contador)
	End Sub

	Public Sub GenerateName(contador As Integer)
		Me.Name = "TabDomicilio" & contador
		Me.Text = "Domicilio " & contador
	End Sub

	Public Sub cargar(drow As DataRow)
		CtrlMan.LoadAllControls(drow, Me)
	End Sub
	Public Function guardar(persona_id As Integer, principal As Boolean) As Boolean
		If domicilio_id.Text > 0 Then
			Domicilio.Modificar(domicilio_id.Text, persona_id, calle.Text, altura.Value,
										piso.Value, dpto.Text, localidad.SelectedValue, principal)
		Else
			domicilio_id.Text = Domicilio.Nuevo(persona_id, calle.Text, altura.Value,
														piso.Value, dpto.Text, localidad.SelectedValue, principal)
		End If
		Return True
	End Function


	Private Sub bs_provincia_CurrentChanged(sender As Object, e As EventArgs) Handles bs_provincia.CurrentChanged, bs_provincia.PositionChanged
		If bs_provincia.Position > -1 And bs_provincia.DataSource Is Nothing = False Then
			CtrlMan.Fill.GetCities(localidad, bs_localidad, bs_provincia.Current("id"))
		Else
			localidad.DataSource = Nothing
		End If
	End Sub

	Private Sub bs_localidad_CurrentChanged(sender As Object, e As EventArgs) Handles bs_localidad.CurrentChanged, bs_localidad.PositionChanged
		If bs_localidad.Position > -1 And bs_localidad.DataSource Is Nothing = False Then
			cp.Text = bs_localidad.Current("cp")
		Else
			cp.Text = ""
		End If
	End Sub
End Class
