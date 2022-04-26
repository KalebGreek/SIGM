Public Class AccionSocialMenu
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)
    End Sub
    Private Sub Menu_Events()

    End Sub


    Private Sub Me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.F10 Then
            Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
            console1.Show()
        End If
    End Sub
    'ACCION SOCIAL


End Class
