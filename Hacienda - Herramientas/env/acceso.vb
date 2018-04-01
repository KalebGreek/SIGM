Imports Sigm.SecMan
Public Class acceso
	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		ConfigInit(Me)
		user.Focus()
	End Sub

    '###### GUI #################################################################################################
    Private Sub user_GotFocus(sender As Object, e As EventArgs) Handles user.GotFocus
		user.Clear()
	End Sub
	Private Sub user_LostFocus(sender As Object, e As EventArgs) Handles user.LostFocus
		If Len(user.Text) = 0 Then
			user.Text = "USUARIO"
		End If
	End Sub
	Private Sub user_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user.TextChanged, pass.TextChanged
		sender.BackColor = Color.WhiteSmoke
		If Len(sender.Text) < 5 Then
			sender.BackColor = Color.FromArgb(255, 195, 185)
		End If
	End Sub

	Private Sub pass_GotFocus(sender As Object, e As EventArgs) Handles pass.GotFocus
		pass.Clear()
		pass.PasswordChar = "*"
	End Sub
	Private Sub pass_LostFocus(sender As Object, e As EventArgs) Handles pass.LostFocus
		If Len(pass.Text) = 0 Then
			pass.Text = "CONTRASEÑA"
			pass.PasswordChar = ""
		End If
	End Sub

	Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
		Me.Dispose()
		End
	End Sub
    '###### END GUI #############################################################################################
    '###### VALIDATION ##########################################################################################
    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
		My.Settings.UserId = validar_inicio(user.Text, pass.Text)
		If My.Settings.UserId > 0 Then 'Iniciar sesión
            If registrar_user(My.Settings.UserId, True) Then
				Me.Hide()
				permisos(My.Settings.UserId).ShowDialog() 'Mostrar inicio
				Me.Show()
				registrar_user(My.Settings.UserId, False) 'Cerrar Sesión
            End If
			My.Settings.UserId = -1
			info.Text = "Ingrese usuario y contraseña."
		Else
			info.Text = "Usuario o contraseña incorrecta."
			user.Clear()
			pass.Clear()
			user.Focus()
		End If
	End Sub
    '###### END VALIDATION ######################################################################################

End Class

