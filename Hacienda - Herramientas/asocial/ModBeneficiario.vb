Public Class ModBeneficiario
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.


    End Sub
    Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        CargarBeneficiario()
    End Sub
    Private Sub CargarBeneficiario()
        Dim sql(5) As String
        sql(0) = "SELECT *"
        sql(1) = "FROM persona INNER JOIN beneficiario ON persona.id=beneficiario.persona_id"
        sql(2) = "WHERE beneficiario.id=" & beneficiario_id.Text

        DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
    End Sub
    '   Private Sub GuardarBeneficiario()
    '	If Me.Visible Then

    '	End If
    'End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class