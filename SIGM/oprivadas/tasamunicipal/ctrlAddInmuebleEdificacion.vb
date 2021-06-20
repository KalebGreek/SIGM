Class ctrlAddInmuebleEdificacion
    Public Event manage_edificacion(sender As Object, target As Object)

    Public Sub New(Optional DtabIndiceInmueble As DataTable = Nothing, Optional CanDeleteSelf As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bs_categoria_inmueble.DataSource = DtabIndiceInmueble

        eliminar.Visible = CanDeleteSelf
        agregar.Visible = CanDeleteSelf.CompareTo(True)
    End Sub

    Private Sub ctlAddInmuebleEdificacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CtrlMan.Fill.SetAutoComplete(categoria, bs_categoria_inmueble, "descripcion", "indice")
    End Sub

    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        RaiseEvent manage_edificacion(sender, Me)
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        RaiseEvent manage_edificacion(sender, Me)
    End Sub

    Private Sub categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categoria.SelectedIndexChanged
        RaiseEvent manage_edificacion(sender, Me)
    End Sub

    Private Sub zona_SelectedIndexChanged(sender As Object, e As EventArgs)
        RaiseEvent manage_edificacion(sender, Me)
    End Sub

    Private Sub superficie_ValueChanged(sender As Object, e As EventArgs) Handles superficie.ValueChanged
        RaiseEvent manage_edificacion(sender, Me)
    End Sub
End Class
