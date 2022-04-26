Class CtrlAddInmuebleEdificacion
    Public Event Manage_edificacion(sender As Object, target As Object)

    Public Sub New(Optional DtabIndiceInmueble As DataTable = Nothing, Optional CanDeleteSelf As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bs_categoria_inmueble.DataSource = DtabIndiceInmueble

        eliminar.Visible = CanDeleteSelf
        agregar.Visible = CanDeleteSelf.CompareTo(True)
    End Sub

    Private Sub CtlAddInmuebleEdificacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CtrlMan.Fill.SetAutoComplete(categoria, bs_categoria_inmueble, "descripcion", "indice")
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        RaiseEvent Manage_edificacion(sender, Me)
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        RaiseEvent Manage_edificacion(sender, Me)
    End Sub

    Private Sub Categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categoria.SelectedIndexChanged
        RaiseEvent Manage_edificacion(sender, Me)
    End Sub

    Private Sub Zona_SelectedIndexChanged(sender As Object, e As EventArgs)
        RaiseEvent Manage_edificacion(sender, Me)
    End Sub

    Private Sub Superficie_ValueChanged(sender As Object, e As EventArgs) Handles superficie.ValueChanged
        RaiseEvent Manage_edificacion(sender, Me)
    End Sub
End Class
