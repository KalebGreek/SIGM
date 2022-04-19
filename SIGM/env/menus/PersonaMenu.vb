Public Class PersonaMenu
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)
	End Sub
	Private Sub Menu_Events(sender As Object, e As EventArgs)
		Dim f1 As Form = Nothing
		If sender Is NuevaPersonaToolStripMenuItem Then
			f1 = New ModPersona()
			f1.ShowDialog(Me.Parent)
			f1 = Nothing
		ElseIf sender Is BuscarPersonaToolStripMenuItem Then
			f1 = New ConsultaPersona
		End If
		If f1 Is Nothing = False Then
			f1.MdiParent = Me.Parent
			f1.Show()
		End If
	End Sub
End Class
