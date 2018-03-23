Public Class ModOrdenTrabajo
	'###### GUI ##########################################################################################
	Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
		NotaPedido.Guardar(nota_pedido_id.Text)
	End Sub
	Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
		Me.Close()
	End Sub

    '###### CARGAR ##########################################################################################
    Sub Cargar(id As Integer)
		If id > 0 Then
			nota_pedido_id.Text = id
			CtrlMan.LoadAllControls(NotaPedido.Seleccionar(id), Me)
		End If
	End Sub
End Class