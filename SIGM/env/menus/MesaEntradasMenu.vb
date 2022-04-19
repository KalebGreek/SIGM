Public Class MesaEntradasMenu
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)
    End Sub
    Private Sub Menu_Events(sender As Object, e As EventArgs)
        Dim f1 As Form = Nothing
        If sender Is ConsultarImpuestoToolStripMenuItem Then
            f1 = New ConsultaImpuestoUI

        ElseIf sender Is GenerarCertificadoToolStripMenuItem Then
            f1 = New CertificadoLibreDeuda

        ElseIf sender Is IntimacionesToolStripMenuItem Then
            f1 = New ConsultaIntimaciones

        ElseIf sender Is TasaMunicipalToolStripMenuItem Then
            f1 = New genToolContainer
            Dim calcObras As New CalculoTasaMunicipal With {.Dock = DockStyle.Fill}
            f1.Controls.Add(calcObras)

        ElseIf sender Is FormulariosToolStripMenuItem Then
            f1 = New Formularios
        End If

        If f1 Is Nothing = False Then
            f1.MdiParent = Me.Parent
            f1.Show()
        End If
    End Sub
End Class
