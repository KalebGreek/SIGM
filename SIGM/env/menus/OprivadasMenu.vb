Public Class OprivadasMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
			console1.Show()
		End If
	End Sub
	'OBRAS PRIVADAS
	'Expedientes
	Private Sub NuevoExpedienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoExpedienteToolStripMenuItem.Click
		Using NuevoExp As New ModExpediente()
			If NuevoExp.dtab_exp Is Nothing = False Then
				NuevoExp.ShowDialog()
			End If
		End Using
	End Sub
	Private Sub BuscarExpedienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarExpedienteToolStripMenuItem.Click
		Dim buscar1 As New BusquedaExpediente With {.MdiParent = Me.Parent}
		buscar1.Show()
	End Sub

	'Herramientas
	Private Sub BuscarProfesionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProfesionalToolStripMenuItem.Click
		Dim buscar1 As New BusquedaPersona With {.MdiParent = Me.Parent}

		buscar1.genSearchControl1.vista.Text = "PROFESIONAL"
		buscar1.Show()
	End Sub
	Private Sub CalculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculosToolStripMenuItem.Click
		Dim calcOprivadas As New genToolContainer With {.MdiParent = Me.Parent}
		calcOprivadas.Text = "Calculadora"

		Dim calcObras As New toolCalculoTasaMunicipal With {.Dock = DockStyle.Fill}
		calcOprivadas.Controls.Add(calcObras)
		calcOprivadas.WindowState = FormWindowState.Maximized
		calcOprivadas.Show()
	End Sub

End Class
