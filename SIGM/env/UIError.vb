Public Class UIError
    Public Sub New(titulo As String, contenido As List(Of String))
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.Text = titulo
        visor.DataSource = contenido
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Continuar_Click(sender As Object, e As EventArgs) Handles continuar.Click
        Me.DialogResult = DialogResult.Ignore
    End Sub
End Class