Public Class tabMultas3Vehiculo
	Inherits System.Windows.Forms.UserControl

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
	End Sub

	Public Sub InitMe()
		vehiculo_id.Text = 0
		mercosur.Checked = True
		patente.Text = ""

		'Load aux tables
		bs_marca.DataSource = Transito.Multas.FillMarcaVehiculo
		CtrlMan.Fill.SetAutoComplete(vehiculo_marca, bs_marca, "marca", "id")

		bs_tipo.DataSource = Transito.Multas.FillTipoVehiculo
		CtrlMan.Fill.SetAutoComplete(vehiculo_tipo, bs_tipo, "tipo", "id")
	End Sub

	Public Function LoadMe(drow As DataRow) As Boolean
		'Load controls
		CtrlMan.LoadAllControls(drow, Me)
		patente.Text = drow("patente").ToString
		Return True
	End Function

	Private Sub mercosur_CheckedChanged(sender As Object, e As EventArgs) Handles mercosur.CheckedChanged
		If mercosur.Checked Then
			patente.Mask = "AA 999 AA"
		Else
			patente.Mask = "AAA 999"
		End If
	End Sub
End Class
