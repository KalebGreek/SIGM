Public Class acceso
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ConfigInit(Me, 0)
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
    Private Sub user_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user.TextChanged
        sender.BackColor = Color.White
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
    Private Sub pass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pass.TextChanged
        sender.BackColor = Color.White
        If Len(sender.Text) < 5 Then
            sender.BackColor = Color.FromArgb(255, 195, 185)
        End If
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        End
    End Sub
    '###### END GUI #############################################################################################
    '###### VALIDATION ##########################################################################################
    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        user_id.Text = validar_inicio(user.Text, pass.Text)
        If user_id.Text > 0 Then 'Iniciar sesión
            If registrar_user(user_id.Text, True) Then
				Me.Hide()
				permisos(user_id.Text).ShowDialog() 'Mostrar inicio
				Me.Show()
				registrar_user(user_id.Text, False) 'Cerrar Sesión
            End If
			user_id.Text = -1
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

