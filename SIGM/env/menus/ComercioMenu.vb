Public Class ComercioMenu
	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)
	End Sub
	Private Sub Menu_Events(sender As Object, e As EventArgs)
		Dim f1 As Form = Nothing
		If sender Is BuscarEnPadrónToolStripMenuItem Then
			f1 = New BusquedaComercio
		End If
		If f1 Is Nothing = False Then
			f1.MdiParent = Me.Parent
			f1.Show()
		End If
	End Sub

	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
			console1.Show()
		End If
	End Sub

End Class
