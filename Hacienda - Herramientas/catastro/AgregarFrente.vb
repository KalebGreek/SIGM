Public Class AgregarFrente
	Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
		Me.Close()
	End Sub
	Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
		calle.Clear()
		altura.Value = 0
		metros.Value = 0
		Me.Close()
	End Sub

	Private Sub calle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles calle.KeyPress
		Agregar.Enabled = True
		If Len(calle.Text) < 4 Then
			Agregar.Enabled = False
		End If
	End Sub

	Private Sub largo_ValueChanged(sender As Object, e As EventArgs) Handles metros.ValueChanged
		Agregar.Enabled = True
		If metros.Value < 1 Then
			Agregar.Enabled = False
		End If
	End Sub
End Class