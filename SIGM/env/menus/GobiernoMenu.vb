Public Class GobiernoMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole
			console1.MdiParent = Me.Parent
			console1.Show()
		End If
	End Sub
	'GOBIERNO
	Private Sub NuevaOrdenanzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaOrdenanzaToolStripMenuItem.Click
		Dim AgregarOrdenanza As New ModOrdenanza
		With AgregarOrdenanza
			.ShowDialog(Me.Parent)
			.Dispose()
		End With
	End Sub
	Private Sub BuscarOrdenanzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarOrdenanzaToolStripMenuItem.Click
		Dim BuscarOrdenanza As New ConsultaOrdenanza
		With BuscarOrdenanza
			.MdiParent = Me.Parent
			.Show()
		End With
	End Sub

End Class
