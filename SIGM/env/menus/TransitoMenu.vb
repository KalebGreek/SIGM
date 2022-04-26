Public Class TransitoMenu
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)

    End Sub
    Private Sub Menu_Events(sender As Object, e As EventArgs)

        Dim f1 As Form = Nothing
        If sender Is BuscarToolStripMenuItem Then
            f1 = ConsultaMulta
        ElseIf sender Is NuevaMultaToolStripMenuItem Then
            f1 = ModMulta
        End If
        If f1 Is Nothing = False Then
            f1.MdiParent = Me.Parent
            f1.Show()
        End If
    End Sub

End Class
