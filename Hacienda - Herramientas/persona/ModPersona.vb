Imports Sigm.Persona
Public Class ModPersona
	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
		' Add any initialization after the InitializeComponent() call.

	End Sub
	'###### GUI ##########################################################################################
	Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
		If Me.Visible Then
			lastPage.Enabled = TabControl1.SelectedIndex > 0
			nextPage.Enabled = TabControl1.SelectedIndex < TabControl1.TabCount - 1
			If TabControl1.SelectedIndex > -1 Then
				Label1.Text = TabControl1.SelectedTab.Text
			End If
		End If
	End Sub
	Private Sub lastPage_Click(sender As Object, e As EventArgs) Handles lastPage.Click
		If TabControl1.SelectedIndex > 0 Then
			TabControl1.SelectedIndex -= 1
		End If
	End Sub
	Private Sub nextPage_Click(sender As Object, e As EventArgs) Handles nextPage.Click
		If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
			TabControl1.SelectedIndex += 1
		End If
	End Sub

	Private Sub cancel_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

    '###### CARGAR ##########################################################################################
    Sub cargar(id As Integer)
		If id > 0 Then
			Me.Text = "MODIFICAR PERSONA"
			persona_id.Text = id
			Persona.Cargar(id, TabPersona1Datos1, TabPersona2Domicilio1,
						   TabPersona3Contacto1, TabPersona4Adicional1)
		End If
	End Sub

    '###### MODIFICAR ##########################################################################################
    Private Sub ModActas_Click(sender As Object, e As EventArgs)
		If persona_id.Text > 0 Then
			Dim visor_acta As New ModActa(persona_id.Text)
			visor_acta.ShowDialog(Me)
			visor_acta.Dispose()
		Else
			MsgBox("Debe guardar el registro de la persona antes de continuar.")
		End If
	End Sub

	Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
		persona_id.Text = TabPersona1Datos1.guardar(persona_id.Text)
		If persona_id.Text > 0 Then
			TabPersona2Domicilio1.guardar(persona_id.Text)
			TabPersona3Contacto1.guardar(persona_id.Text)
			TabPersona4Adicional1.guardar(persona_id.Text)
		End If
	End Sub
End Class