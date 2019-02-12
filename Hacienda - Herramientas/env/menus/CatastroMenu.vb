Public Class CatastroMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole
			console1.MdiParent = Me.Parent
			console1.Show()
		End If
	End Sub
	'CATASTRO
	Private Sub BuscarInmuebleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarInmuebleToolStripMenuItem.Click
		Dim ConsultaTitular1 As New ConsultaCatastro(My.Settings.UserId)
		With ConsultaTitular1
			.MdiParent = Me.Parent
			.Show()
		End With
	End Sub
	Private Sub ConsultarPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPagosToolStripMenuItem.Click

	End Sub

End Class
