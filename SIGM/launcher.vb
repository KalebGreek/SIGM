Public Class launcher
	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ColorHacienda = l_hacienda.BackColor

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    ' GUI 
    'List all buttons
    Private Sub SeleccionForm(sender As Object, e As EventArgs) Handles l_hacienda.Click, l_gobierno.Click, l_catastro.Click,
                                                                        l_opublicas.Click, l_oprivadas.Click, l_comercio.Click,
                                                                        l_persona.Click, l_accionsocial.Click, l_formularios.Click,
                                                                        l_transito.Click, l_contrato.Click, opcion.Click

        My.Settings.CurrentMenuColor = CType(sender, Button).BackColor.ToArgb

        If sender Is opcion Then
            Using config_dialog As New config
                config_dialog.ShowDialog()
            End Using
        Else
            Dim form1 As New Form
            If sender Is l_formularios Then
                    form1 = New VisorReporte(sender.Text)
                    CType(form1, VisorReporte).FormulariosToolStripMenuItem1.Visible = True
                ElseIf sender Is l_contrato Then
                    form1 = New ConsultaContrato
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

                    form1 = New MainForm(menu1)
                End If
                Me.Hide()
            form1.Text = sender.Text & " | SIGM Villa de Las Rosas"
            Using form1
                form1.ShowDialog(Me)
            End Using
            Me.Show()
            Me.Focus()
        End If
    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()
    End Sub


    ' END GUI 
























End Class

