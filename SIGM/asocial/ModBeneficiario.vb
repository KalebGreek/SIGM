Public Class ModBeneficiario
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.


    End Sub
    Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        CargarBeneficiario(beneficiario_id.Text)
    End Sub
    Private Function CargarBeneficiario(id As Integer) As DataRow
        Return DbMan.ReadDB("SELECT * 
                               FROM persona 
                         INNER JOIN beneficiario ON persona.id=beneficiario.persona_id 
                              WHERE beneficiario.id=" & id,
                            My.Settings.CurrentDB).Rows(0)
    End Function
    '   Private Sub GuardarBeneficiario()
    '	If Me.Visible Then

    '	End If
    'End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class