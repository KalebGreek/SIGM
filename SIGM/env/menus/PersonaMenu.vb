Public Class PersonaMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
			console1.Show()
		End If
	End Sub
	'PERSONA
	Private Sub NuevaPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaPersonaToolStripMenuItem.Click
		Using modper1 As New ModPersona(0)
			modper1.ShowDialog()
		End Using
	End Sub
	Private Sub BuscarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPersonaToolStripMenuItem.Click
		Dim buscar1 As New BusquedaPersona With {.MdiParent = Me.Parent}
		buscar1.Show()
	End Sub
	Private Sub BuscarActaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarActaToolStripMenuItem.Click

	End Sub

End Class
