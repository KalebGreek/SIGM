Public Class toolCalculoTasaMunicipal
	Private Sub SearchClick(sender As Object, e As EventArgs) Handles search.Click
		Using bprop As New BusquedaPropietario
			bprop.genSearchControl1.vista.Text = "PROPIETARIO"
			bprop.ShowDialog(Me)
			With bprop.bs_resultado
				If .Position > -1 Then
					propietario.Text = .Current("razon").ToString()
					tenedor.Text = .Current("tenedor").ToString()
					cuenta.Text = .Current("codigo").ToString()
				End If
			End With
		End Using
	End Sub
	Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
		If wrapper.Controls.Count > 0 Then
			Using FormImpresion As New Formularios("Tasa Municipal")
				FormImpresion.Mostrar("REPORTES\")
			End Using
		End If
	End Sub

	Private Sub WrapperVisibility() Handles wrapper.ControlRemoved, wrapper.ControlAdded
		wrapper.Visible = wrapper.Controls.Count > 0
	End Sub

	Private Sub WrapperFill(sender As Object, e As EventArgs) Handles ObrasVariasToolStripMenuItem.Click, RelevamientoToolStripMenuItem.Click,
																		MensuraToolStripMenuItem.Click, ReiniciarMenuItem.Click
		For Each ctl As Control In wrapper.Controls
			ctl.Dispose()
		Next

		If sender Is ReiniciarMenuItem Then
			fecha.Value = Date.Today
			cuenta.Text = ""
			propietario.Text = ""
			tenedor.Text = ""
			obra.Text = ""
			help.Visible = False

		Else
			Dim ctl As New UserControl
			If sender Is ObrasVariasToolStripMenuItem Then
				ctl = New calcTMuniObrasVarias
				help.DataSource = CType(ctl, calcTMuniObrasVarias).help_source
			ElseIf sender Is RelevamientoToolStripMenuItem Then
				ctl = New calcTMuniPlanosEdif
				help.DataSource = CType(ctl, calcTMuniPlanosEdif).help_source
			ElseIf sender Is MensuraToolStripMenuItem Then
				ctl = New calcTMuniMensura
				help.DataSource = CType(ctl, calcTMuniMensura).help_source
			End If
			wrapper.Controls.Add(ctl)
			help.Visible = True
			ctl.Dock = DockStyle.Fill
		End If

	End Sub


End Class
