Public Class launcher
	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub
    '###### GUI #################################################################################################
    Private Sub SeleccionForm(sender As Object, e As EventArgs) Handles l_hacienda.Click, l_gobierno.Click, l_catastro.Click, l_opublicas.Click, l_oprivadas.Click,
																		l_comercio.Click, l_persona.Click, l_accionsocial.Click, l_formularios.Click, l_transito.Click, opcion.Click
		If sender Is opcion Then
			config.ShowDialog()
		Else
			Dim form1 As New Form
			If sender Is l_formularios Then
				form1 = New VisorReporte(sender.Text)
				CType(form1, VisorReporte).FormulariosToolStripMenuItem1.Visible = True
			Else
				Dim menu1 As New UserControl
				If sender Is l_accionsocial Then
					menu1 = New AccionSocialMenu
				ElseIf sender Is l_catastro Then
					menu1 = New CatastroMenu
				ElseIf sender Is l_comercio Then
					menu1 = New ComercioMenu
				ElseIf sender Is l_gobierno Then
					menu1 = New GobiernoMenu
				ElseIf sender Is l_hacienda Then
					menu1 = New HaciendaMenu
				ElseIf sender Is l_oprivadas Then
					menu1 = New OprivadasMenu
				ElseIf sender Is l_opublicas Then
					menu1 = New OpublicasMenu
				ElseIf sender Is l_persona Then
					menu1 = New PersonaMenu
				ElseIf sender Is l_transito Then
					menu1 = New TransitoMenu
				End If

				My.Settings.CurrentMenuColor = CType(sender, Button).BackColor.ToArgb
				form1 = New MainForm(menu1)
				form1.Text = sender.Text & " | SIGM Villa de Las Rosas"
			End If
			Me.Hide()
			form1.ShowDialog(Me)
			form1.Dispose()
			GC.Collect()
			Me.Show()
			Me.Focus()
		End If
	End Sub

	Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()
    End Sub
    '###### END GUI #############################################################################################
























End Class

