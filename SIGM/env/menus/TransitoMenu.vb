Public Class TransitoMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
			console1.Show()
		End If
	End Sub
	'>MULTAS
	Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
		Dim buscar1 As New ConsultaMulta With {.MdiParent = Me.Parent}
		buscar1.Show()

	End Sub

	Private Sub NuevaMultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaMultaToolStripMenuItem.Click
		Using modMulta1 As New ModMulta
			modMulta1.ShowDialog(Me.Parent)
		End Using
	End Sub

	'INFRACTORES
	Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
		Dim buscar1 As New ConsultaMulta With {.MdiParent = Me.Parent}
		buscar1.Show()

	End Sub
End Class
