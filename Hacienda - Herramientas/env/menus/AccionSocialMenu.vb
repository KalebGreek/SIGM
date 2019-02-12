Public Class AccionSocialMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole
			console1.MdiParent = Me.Parent
			console1.Show()
		End If
	End Sub
	'ACCION SOCIAL
	Private Sub NuevoBeneficiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoBeneficiarioToolStripMenuItem.Click

	End Sub

	Private Sub BuscarBeneficiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarBeneficiarioToolStripMenuItem.Click

	End Sub

End Class
