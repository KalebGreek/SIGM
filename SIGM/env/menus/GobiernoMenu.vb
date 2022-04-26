Public Class GobiernoMenu
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)
    End Sub
    Private Sub Menu_Events(sender As Object, e As EventArgs)
        Dim f1 As Form = Nothing
        If sender Is NuevaOrdenanzaToolStripMenuItem Then
            f1 = New ModOrdenanza
        ElseIf sender Is BuscarOrdenanzaToolStripMenuItem Then
            f1 = New ConsultaOrdenanza
        End If

        If f1 Is Nothing = False Then
            f1.MdiParent = Me.Parent
            f1.Show()
        End If
    End Sub
End Class
