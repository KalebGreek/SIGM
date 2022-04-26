Public Class TabPersona3Contacto
    Inherits System.Windows.Forms.UserControl
    ReadOnly PersonaId As Integer

    Public Sub New(PerId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PersonaId = PerId
    End Sub

    Public Sub Cargar()
        Dim registro As New DataTable
        registro = DbMan.ReadDB("SELECT * FROM persona WHERE id=" & PersonaId, My.Settings.CurrentDB)

        tele.Text = registro.Rows(0)("telefono").ToString
        email.Text = registro.Rows(0)("email").ToString
    End Sub

    Public Function Guardar() As Integer
        If CtrlMan.Validate(Me, ErrorInfo) Then
            DbMan.EditDB("UPDATE persona SET telefono=" & tele.Text & ", email='" & email.Text & "'
						  WHERE id=" & PersonaId,
                         My.Settings.CurrentDB)
            Return PersonaId
        Else
            Return 0
        End If
    End Function


End Class
