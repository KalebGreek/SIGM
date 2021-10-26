Imports Sigm.SecMan

Class Acceso
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ConfigInit(Me)
        ServerList.DataSource = ListDBConnections()
        ServerList.SelectedIndex = 0
        user.Focus()
    End Sub

    ' GUI 
    Private Sub user_GotFocus(sender As Object, e As EventArgs) Handles user.GotFocus
        user.Clear()
    End Sub
    Private Sub user_LostFocus(sender As Object, e As EventArgs) Handles user.LostFocus
        If Len(user.Text) = 0 Then
            user.Text = "USUARIO"
        End If
    End Sub
    Private Sub user_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user.TextChanged
        user.BackColor = Color.WhiteSmoke
        If Len(user.Text) < 5 Then
            user.BackColor = Color.FromArgb(255, 195, 185)
        End If
    End Sub
    Private Sub pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass.TextChanged
        pass.BackColor = Color.WhiteSmoke
        If Len(user.Text) < 5 Then
            pass.BackColor = Color.FromArgb(255, 195, 185)
        End If
    End Sub



    Private Sub pass_GotFocus(sender As Object, e As EventArgs) Handles pass.GotFocus
        pass.Clear()
        pass.PasswordChar = GetChar("*", 1)
    End Sub
    Private Sub pass_LostFocus(sender As Object, e As EventArgs) Handles pass.LostFocus
        If Len(pass.Text) = 0 Then
            pass.Text = "CONTRASEÑA"
            pass.PasswordChar = Nothing
        End If
    End Sub
    Private Sub pass_KeyUp(sender As Object, e As KeyEventArgs) Handles pass.KeyUp
        If e.KeyValue = Keys.Enter Then
            log_user()
        End If
    End Sub
    Private Sub login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        log_user()
    End Sub
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Dispose()
        End
    End Sub



    ' END GUI 
    ' VALIDATION 
    Private Sub log_user()
        My.Settings.CurrentDB = ServerList.Text
        My.Settings.UserId = ValidateUser(user.Text, pass.Text)
        If My.Settings.UserId > 0 Then 'Iniciar sesión
            If RegisterLogon(My.Settings.UserId, True) Then
                Me.Hide()
                Privileges(Me, My.Settings.UserId) 'Mostrar inicio
                Dim flist As String = ""
                For Each f As Form In My.Application.OpenForms
                    flist &= f.Text & Chr(13)
                Next
                Me.Show()
                RegisterLogon(My.Settings.UserId, False) 'Cerrar Sesión
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
    ' END VALIDATION 

End Class

