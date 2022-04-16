Public Class MesaEntradasMenu
    Private Sub Me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.F10 Then
            Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
            console1.Show()
        End If
    End Sub

    Private Sub MenuHandler(sender As Object, e As EventArgs) Handles ConsultarImpuestoToolStripMenuItem.Click, GenerarCertificadoToolStripMenuItem.Click,
                                                                      IntimacionesToolStripMenuItem.Click, TasaMunicipalToolStripMenuItem.Click, FormulariosToolStripMenuItem.Click

        Dim form1 As New Form

        If sender Is ConsultarImpuestoToolStripMenuItem Then
            form1 = New ConsultaImpuestoUI

        ElseIf sender Is GenerarCertificadoToolStripMenuItem Then
            form1 = Nothing
            Using certld As New CertificadoLibreDeuda
                certld.ShowDialog()
            End Using

        ElseIf sender Is IntimacionesToolStripMenuItem Then
            form1 = New ConsultaIntimaciones

        ElseIf sender Is TasaMunicipalToolStripMenuItem Then
            form1 = New genToolContainer
            Dim calcObras As New CalculoTasaMunicipal With {.Dock = DockStyle.Fill}
            form1.Controls.Add(calcObras)

        ElseIf sender Is FormulariosToolStripMenuItem Then
            form1 = New Formularios
        End If

        If form1 Is Nothing = False Then
            form1.Text = sender.Text & " | SIGM Villa de Las Rosas"
            form1.MdiParent = Me.Parent
            form1.FormBorderStyle = FormBorderStyle.SizableToolWindow
            form1.WindowState = FormWindowState.Maximized
            form1.Show()
        End If
    End Sub
End Class
