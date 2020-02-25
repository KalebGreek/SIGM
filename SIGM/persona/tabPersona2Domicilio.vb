Public Class tabPersona2Domicilio
    Inherits System.Windows.Forms.UserControl
    Dim principal As DomicilioPage
    Dim PersonaId As Integer

    Public Sub New(PerId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PersonaId = PerId
    End Sub

    Public Sub cargar()
        'Cargar domicilios
        Dim dtab As DataTable = Domicilio.Listar(PersonaId)
        For Each dr As DataRow In dtab.Rows
            Dim TabDom As New DomicilioPage() _
                With {.contador = TabControl1.TabCount + 1}

            TabDom.cargar(dr)
            TabControl1.TabPages.Add(TabDom)
            If dr("principal") Then
                principal = TabDom
            End If
        Next
        If TabControl1.TabCount > 1 Then
            TabControl1.SelectTab(principal)
        End If
    End Sub

    Public Function guardar() As Integer
        If CtrlMan.Validate(Me, ErrorInfo) Then
            For Each domicilio As DomicilioPage In TabControl1.TabPages
                domicilio.guardar(PersonaId, TabControl1.SelectedTab Is domicilio)
            Next
        End If
        Return PersonaId
    End Function

    Private Sub AddDomicilio_Click(sender As Object, e As EventArgs) Handles AddDomicilio.Click
        Dim TabDom As New DomicilioPage() _
            With {.contador = TabControl1.TabCount + 1}
        TabControl1.TabPages.Add(TabDom)
    End Sub

    Private Sub DelDomicilio_Click(sender As Object, e As EventArgs) Handles DelDomicilio.Click
        If MsgBoxResult.Yes = MsgBox("Desea eliminar el domicilio seleccionado?", MsgBoxStyle.YesNo) Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
            Dim TabIndex As Integer = 1
            For Each tab As DomicilioPage In TabControl1.TabPages
                tab.GenerateName(TabIndex)
                TabIndex += 1
            Next
        End If
    End Sub
End Class
