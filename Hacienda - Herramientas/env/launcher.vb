Public Class launcher
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ColorCatastro = l_catastro.BackColor
        ColorComercio = l_comercio.BackColor
        ColorHacienda = l_hacienda.BackColor
        ColorFormulario = l_formularios.BackColor
        ColorGobierno = l_gobierno.BackColor
        ColorOprivadas = l_oprivadas.BackColor
        ColorOpublicas = l_opublicas.BackColor
		ColorPersona = l_persona.BackColor
		ColorAsocial = l_asocial.BackColor
	End Sub
    '###### GUI #################################################################################################
    Private Sub SeleccionForm(sender As Object, e As EventArgs) Handles l_hacienda.Click, l_gobierno.Click, l_catastro.Click, l_opublicas.Click, l_oprivadas.Click,
																		l_comercio.Click, l_persona.Click, l_asocial.Click, l_formularios.Click, opcion.Click
		If sender Is opcion Then
			config.ShowDialog()
		Else
			Dim form1 As New Form
			If sender Is l_formularios Then

				form1 = New VisorReporte(sender.Text)
				CType(form1, VisorReporte).FormulariosToolStripMenuItem1.Visible = True
			Else
				form1 = New MainForm(sender)
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

