Public Class ControlVencimiento
    Public Sub Listar(año_menor As Integer, año_mayor As Integer, mostrar As Boolean, impuesto As String)
        Dim vencimientos As New DataTable
        vence1.Text = "No hay datos"
        vence2.Text = "No hay datos"
        vence3.Text = "No hay datos"
        vence4.Text = "No hay datos"
        vence5.Text = "No hay datos"
        vence6.Text = "No hay datos"

        If año_menor = año_mayor And mostrar Then
            vencimientos = bd.read(My.Settings.foxcon, "SELECT * FROM " & ext_vence & " WHERE periodo=" & año_menor)
            If vencimientos.Rows.Count > 0 Then
                vence1.Text = Convert.ToString(vencimientos(0)("vence1"))
                vence2.Text = Convert.ToString(vencimientos(0)("vence2"))
                vence3.Text = Convert.ToString(vencimientos(0)("vence3"))
                vence4.Text = Convert.ToString(vencimientos(0)("vence4"))
                If impuesto <> "AUTOMOVIL" Then
                    vence5.Text = Convert.ToString(vencimientos(0)("vence5"))
                    vence6.Text = Convert.ToString(vencimientos(0)("vence6"))
                End If
            End If
        End If


    End Sub
    Private Sub ControlVencimiento_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.CreateControl()
    End Sub
End Class
