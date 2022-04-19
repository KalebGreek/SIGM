﻿Imports System.ComponentModel

Public Class Launcher
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        'Tomar paleta de colores desde el launcher
        ColorAsocial = l_accionsocial.BackColor
        ColorCatastro = l_catastro.BackColor
        ColorComercio = l_comercio.BackColor
        ColorFormulario = l_mesa_de_entradas.BackColor
        ColorContratos = l_contratos.BackColor
        ColorHacienda = l_hacienda.BackColor
        ColorOprivadas = l_oprivadas.BackColor
        ColorOpublicas = l_opublicas.BackColor
        ColorPersona = l_persona.BackColor
        ColorTransito = l_transito.BackColor
        ConfigInit(Me)
        Login()
    End Sub
    ' GUI 
    'List all buttons
    Private Sub Login()
        Using a As New Acceso
            a.ShowDialog()
        End Using
        If My.Settings.UserId > 0 Then
            SecMan.Privileges(Me, My.Settings.UserId)
        Else
            End
        End If
    End Sub
    Private Sub SeleccionForm(sender As Object, e As EventArgs) Handles l_hacienda.Click, l_catastro.Click, l_contratos.Click,
                                                                        l_opublicas.Click, l_oprivadas.Click, l_comercio.Click,
                                                                        l_persona.Click, l_accionsocial.Click, l_mesa_de_entradas.Click,
                                                                        l_transito.Click, l_formularios.Click, opcion.Click
        Dim form1 As New Form
        Using form1
            If TypeOf sender Is Button Then
                Dim title As String = CType(sender, Button).Text.ToString & " | SIGM Villa de Las Rosas"

                My.Settings.CurrentMenuColor = CType(sender, Button).BackColor
                form1.Text = title

                Me.Hide()
                If sender Is opcion Then
                    form1 = New config
                Else
                    If sender Is l_formularios Then
                        form1 = New Formularios(title)
                        CType(form1, Formularios).FormulariosToolStripMenuItem1.Visible = True
                    ElseIf sender Is l_contratos Then
                        form1 = New ConsultaContrato
                    Else
                        Dim menu1 As New UserControl

                        If sender Is l_accionsocial Then
                            menu1 = New AccionSocialMenu
                        ElseIf sender Is l_catastro Then
                            menu1 = New CatastroMenu
                        ElseIf sender Is l_comercio Then
                            menu1 = New ComercioMenu
                        ElseIf sender Is l_hacienda Then
                            menu1 = New HaciendaMenu
                        ElseIf sender Is l_mesa_de_entradas Then
                            menu1 = New MesaEntradasMenu
                        ElseIf sender Is l_oprivadas Then
                            menu1 = New OprivadasMenu
                        ElseIf sender Is l_opublicas Then
                            menu1 = New OpublicasMenu
                        ElseIf sender Is l_persona Then
                            menu1 = New PersonaMenu
                        ElseIf sender Is l_transito Then
                            menu1 = New TransitoMenu
                        End If
                        form1 = New MainForm(menu1)
                    End If

                End If
                form1.Show(Me)
            End If
        End Using
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        SecMan.RegisterLogon(My.Settings.UserId, False) 'Cerrar Sesión
        Login()
    End Sub
    ' END GUI 
























End Class

