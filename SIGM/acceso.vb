Imports Sigm.SecMan

Class Acceso
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    ' GUI 
    Private Sub Acceso_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            ServerList.DataSource = ListDBConnections()
            ServerList.SelectedIndex = 0
            user.Focus()
        End If
    End Sub
    Private Sub User_GotFocus(sender As Object, e As EventArgs) Handles user.GotFocus
        user.Clear()
    End Sub
    Private Sub User_LostFocus(sender As Object, e As EventArgs) Handles user.LostFocus
        If Len(user.Text) = 0 Then
            user.Text = "USUARIO"
        End If
    End Sub
    Private Sub User_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user.TextChanged
        user.BackColor = Color.WhiteSmoke
        If Len(user.Text) < 5 Then
            user.BackColor = Color.FromArgb(255, 195, 185)
        End If
    End Sub
    Private Sub Pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass.TextChanged
        pass.BackColor = Color.WhiteSmoke
        If Len(user.Text) < 5 Then
            pass.BackColor = Color.FromArgb(255, 195, 185)
        End If
    End Sub



    Private Sub Pass_GotFocus(sender As Object, e As EventArgs) Handles pass.GotFocus
        pass.Clear()
        pass.PasswordChar = GetChar("*", 1)
    End Sub
    Private Sub Pass_LostFocus(sender As Object, e As EventArgs) Handles pass.LostFocus
        If Len(pass.Text) = 0 Then
            pass.Text = "CONTRASEÑA"
            pass.PasswordChar = Nothing
        End If
    End Sub
    Private Sub Pass_KeyUp(sender As Object, e As KeyEventArgs) Handles pass.KeyUp
        If e.KeyValue = Keys.Enter Then
            log_user()
        End If
    End Sub
    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        log_user()
    End Sub
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        My.Settings.UserId = -1
        Me.Close()
    End Sub
    ' END GUI 

    ' VALIDATION 
    Private Sub Log_User()
        My.Settings.CurrentDB = ServerList.Text
        My.Settings.UserId = ValidateUser(user.Text, pass.Text)
        If My.Settings.UserId > 0 Then 'Iniciar sesión
            RegisterLogon(My.Settings.UserId, True)
            Me.Close()
        Else
            info.Text = "Usuario o contraseña incorrecta."
            user.Clear()
            pass.Clear()
            user.Focus()
        End If
    End Sub
    ' END VALIDATION 

End Class

