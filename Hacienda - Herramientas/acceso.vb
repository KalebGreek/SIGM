Public Class acceso
    '###### VARIABLES Y RUTINAS #################################################################################
    Private Sub acceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigInit(Me, 0)
        user.Focus()
    End Sub
    Private Sub acceso_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible And user_id.Text > -1 Then
            registrar_user(user_id.Text, False) 'Cerrar Sesión
            user_id.Text = -1
        End If
    End Sub

  
    '###### FIN VARIABLES Y RUTINAS #############################################################################

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
        user_id.Text = validar_inicio()
        If user_id.Text > 0 Then 'Iniciar sesión

            If registrar_user(user_id.Text, True) Then
                Dim inicio As Form = permisos(user_id.Text) 'Mostrar inicio
                Me.Hide()
                inicio.ShowDialog()
                Me.Show()
            End If
        Else
            user.Clear()
            pass.Clear()
        End If
       
    End Sub
    Private Function validar_inicio() As Integer
        Dim id As Integer = -1

        If Len(user.Text) >= 5 And Len(pass.Text) >= 5 And pass.PasswordChar = "*" Then
            Dim dtab As New DataTable



            dtab = bd.leer(defcon, "SELECT id, usuario, pass FROM usuarios" &
                                    " WHERE usuario='" & user.Text.ToString & "' AND pass='" & pass.Text.ToString & "'")



            If dtab Is Nothing Then
                MsgBox("Usuario o contraseña incorrecta.", MsgBoxStyle.Information)
            Else
                If dtab.Rows.Count > 0 Then 'Contraseña válida
                    'Verificar sesión
                    id = dtab(0)("id")
                ElseIf dtab.Rows.Count = 0 Then
                    MsgBox("Usuario o contraseña incorrecta.", MsgBoxStyle.Information)
                End If
            End If
        End If
        Return id
    End Function
    Shared Function registrar_user(user_id As Integer, lock As Boolean) As Boolean
        Dim fecha_hora As String = Date.Today.ToShortDateString & " " & TimeOfDay.ToShortTimeString
        Dim token As String = getCpuId()
        Dim equipo As String = Environment.MachineName
        'Últimos accesos
        Dim dtab As DataTable = bd.leer(defcon, "SELECT id, fecha_hora, user_id, token, equipo, sesion FROM usr_log" & _
                                " WHERE user_id=" & user_id & " ORDER BY id DESC")

        If dtab.Rows.Count > 0 Then
            If dtab(0)("sesion") Then
                If dtab(0)("token").ToString = token Then
                    If lock Then 'Actualizar a último accceso 
                        mod_sql = "UPDATE usr_log SET fecha_hora='" & fecha_hora & "', sesion=True" & _
                                  " WHERE id=" & dtab(0)("id")
                    Else
                        mod_sql = "UPDATE usr_log SET sesion=False WHERE user_id=" & user_id
                    End If
                    bd.edit(defcon, mod_sql)
                ElseIf dtab(0)("token").ToString <> token Then
                    'Sesión iniciada en otro equipo
                    If MsgBoxResult.Yes = MsgBox("Sesion abierta en " & dtab(0)("equipo") & ". Presione SI para continuar, NO para salir") Then
                        'Sesión iniciada en este equipo, cerrar sesión de accesos anteriores
                        mod_sql = "UPDATE usr_log SET sesion=False WHERE user_id=" & user_id
                        bd.edit(defcon, mod_sql)
                    Else
                        Return False
                    End If
                End If
            ElseIf dtab(0)("sesion") = False Then 'Agregar registro a historial
                mod_sql = "INSERT INTO usr_log(user_id, fecha_hora, token, equipo, sesion)" & _
                                   " VALUES(" & user_id & ", '" & fecha_hora & "' ," & _
                                   " '" & token & "', '" & equipo & "', True)"
                bd.edit(defcon, mod_sql)
            End If
        ElseIf dtab.Rows.Count = 0 Then
            mod_sql = "INSERT INTO usr_log(user_id, fecha_hora, token, equipo, sesion)" & _
                                  " VALUES(" & user_id & ", '" & fecha_hora & "' ," & _
                                  " '" & token & "', '" & equipo & "', True)"
            bd.edit(defcon, mod_sql)
        End If
        Return True
    End Function
    Private Function permisos(user_id As Integer)
        Dim inicio As New launcher
        Dim dtab As DataTable = bd.leer(defcon, "SELECT * FROM usuarios WHERE id=" & user_id)
        With inicio
            'Permisos
            .cat.Visible = dtab(0)("cat")
            .com.Visible = dtab(0)("com")
            .frm.Visible = dtab(0)("frm")
            .gob.Visible = dtab(0)("gob")
            .hac.Visible = dtab(0)("hac")
            .opcion.Visible = dtab(0)("opc")
            .opr.Visible = dtab(0)("opr")
            .opu.Visible = dtab(0)("opu")
            .per.Visible = dtab(0)("per")
            .user_id.Text = user_id
            'Limpiar
            user.Text = " USUARIO"
            pass.Text = " CONTRASEÑA"
            pass.PasswordChar = Nothing
            login.Focus()
        End With
        Return inicio
    End Function
    '###### END VALIDATION ######################################################################################

    '###### PRINT ###############################################################################################

    '###### END PRINT ###########################################################################################

    
End Class

