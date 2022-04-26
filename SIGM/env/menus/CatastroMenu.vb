Public Class CatastroMenu
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)
    End Sub
    Private Sub Menu_Events(sender As Object, e As EventArgs)
        Dim f1 As Form = Nothing
        If sender Is BuscarInmuebleToolStripMenuItem Then
            f1 = New ConsultaCatastro
        ElseIf sender Is ConsultarPagosToolStripMenuItem Then

        End If
        If f1 Is Nothing = False Then
            f1.MdiParent = Me.Parent
            f1.Show()
        End If
    End Sub

End Class
