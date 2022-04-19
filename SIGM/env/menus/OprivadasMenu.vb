Public Class OprivadasMenu
	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

		CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)

	End Sub
	Private Sub Menu_Events(sender As Object, e As EventArgs)
		'OBRAS PRIVADAS
		Dim f1 As Form = Nothing
		'Expedientes
		If sender Is NuevoExpedienteToolStripMenuItem Then
			f1 = New ModExpediente()
			If CType(f1, ModExpediente).exp = Nothing Then
				f1 = Nothing
			End If

		ElseIf sender Is BuscarExpedienteToolStripMenuItem Then
			f1 = New ConsultaExp
			'Herramientas
		ElseIf sender Is BuscarProfesionalToolStripMenuItem Then
			f1 = New ConsultaPersona
			CType(f1, ConsultaPersona).genSearchControl1.vista.Text = "PROFESIONAL"
		ElseIf sender Is CalculosToolStripMenuItem Then
			f1 = New genToolContainer
			Dim calcObras As New CalculoTasaMunicipal With {.Dock = DockStyle.Fill}
			f1.Controls.Add(calcObras)
			f1.Text = "Calculadora"
		End If

		If f1 Is Nothing = False Then
			f1.MdiParent = Me.Parent
			f1.WindowState = FormWindowState.Maximized
			f1.Show()
		End If
	End Sub
End Class
