Public Class adelanto_page1
	Dim persona_id As Integer = 0
	Private Sub buscarPersona_Click(sender As Object, e As EventArgs) Handles buscarPersona.Click
		Dim bper As New BusquedaPersona()
		bper.genSearchControl1.selectRow.Visible = True
		bper.genSearchControl1.cancel.Visible = True
		bper.ShowDialog(Me)
		With bper
			If .bs_resultado.Position > -1 Then
				persona_id = .bs_resultado.Current("persona_id").ToString
				razon.Text = .bs_resultado.Current("razon").ToString
				cuil.Text = .bs_resultado.Current("cuil").ToString
			End If
		End With
	End Sub

End Class
