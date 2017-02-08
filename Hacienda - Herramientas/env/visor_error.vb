Public Class visor_error
    Public Sub New(titulo As String, contenido As List(Of String))
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.Text = titulo
        visor.DataSource = contenido
    End Sub
End Class