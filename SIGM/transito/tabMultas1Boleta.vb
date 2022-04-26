Public Class tabMultas1Boleta
    Inherits System.Windows.Forms.UserControl
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub InitMe()
        fecha_boleta.Value = Now
        fecha_pago.Value = Today
        ubicacion.Text = ""
        observaciones.Text = ""

        'Load aux tables
        bs_articulo.DataSource = Transito.Multas.FillArticulo
        CtrlMan.Fill.SetAutoComplete(articulo, bs_articulo, "articulo", "id")

        bs_inspector.DataSource = Transito.Multas.FillInspector
        CtrlMan.Fill.SetAutoComplete(inspector, bs_inspector, "razon", "id")
    End Sub

    Public Function LoadMe(drow As DataRow) As Boolean
        'Load multa
        CtrlMan.LoadControls(drow, Me)
        Return True
    End Function


    Private Sub Bs_articulo_CurrentChanged(sender As Object, e As EventArgs) Handles bs_articulo.CurrentChanged, bs_articulo.PositionChanged
        If bs_articulo.Position > -1 Then
            DetalleArticulo.Text = bs_articulo.Current("descripcion").ToString
        Else
            DetalleArticulo.Text = ""
        End If
    End Sub
End Class
