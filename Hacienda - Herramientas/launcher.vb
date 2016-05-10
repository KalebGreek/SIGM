Public Class launcher
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ColorCatastro = cat.BackColor
        ColorComercio = com.BackColor
        ColorHacienda = hac.BackColor
        ColorFormulario = frm.BackColor
        ColorGobierno = gob.BackColor
        ColorOprivadas = opr.BackColor
        ColorOpublicas = opu.BackColor
        ColorPersona = per.BackColor
    End Sub
    '###### GUI #################################################################################################
    Private Sub SeleccionForm(sender As Object, e As EventArgs) Handles hac.Click, gob.Click, cat.Click, opu.Click, opr.Click, _
                                                                        com.Click, per.Click, frm.Click, opcion.Click
        If sender Is opcion Then
            config.ShowDialog()
        Else
            Dim form1 As New Form
            If sender Is frm Then

                form1 = New VisorReporte(sender.Text)
                CType(form1, VisorReporte).FormulariosToolStripMenuItem1.Visible = True
            Else
                form1 = New ContenedorGen(user_id.Text, sender)
            End If
            Me.Hide()
            form1.ShowDialog(Me)
            form1.Dispose()
            Me.Show()
            Me.Focus()
        End If
    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()
    End Sub
    '###### END GUI #############################################################################################
























End Class

