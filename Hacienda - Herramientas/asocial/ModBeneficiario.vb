Public Class ModBeneficiario
	Public Sub New(MenuColor As System.Drawing.Color)
        ' This call is required by the designer.
        InitializeComponent()
		' Add any initialization after the InitializeComponent() call.


	End Sub
	Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		CargarBeneficiario(beneficiario_id.Text)
	End Sub
	Private Sub CargarBeneficiario(persona_id As Integer)
		DbMan.read("SELECT * FROM persona 
					INNER JOIN beneficiario ON persona.id=beneficiario.persona_id
					WHERE beneficiario.id=" & beneficiario_id.Text, My.Settings.DefaultCon)
	End Sub
	Private Sub GuardarBeneficiario()
		If Me.Visible Then

		End If
	End Sub
	Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
		Me.Close()
	End Sub
End Class