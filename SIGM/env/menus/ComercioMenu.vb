Public Class ComercioMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
			console1.Show()
		End If
	End Sub
	'COMERCIO
	Private Sub BuscarEnPadrónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarEnPadrónToolStripMenuItem.Click
		Dim buscarcomercio1 As New BusquedaComercio With {.MdiParent = Me.Parent}
		buscarcomercio1.Show()
	End Sub

End Class
