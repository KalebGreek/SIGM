Public Class adelanto_page1
	Dim persona_id As Integer = 0

	'Routines
	Public Sub save()
		DbMan.EditDB("INSERT INTO hac_adelanto(monto, fecha, persona_id) 
						   VALUES('" & monto.Value & "', '" & fecha.Value & "', " & persona_id & ")",
					 My.Settings.CurrentDB)
	End Sub
	'Events
	Private Sub buscarPersona_Click(sender As Object, e As EventArgs) Handles buscarPersona.Click
		Using bper As New BusquedaPersona(True)
			bper.ShowDialog(Me)
			With bper
				If .bs_resultado.Position > -1 Then
					persona_id = .bs_resultado.Current("persona_id").ToString
					razon.Text = .bs_resultado.Current("razon").ToString
					cuil.Text = .bs_resultado.Current("cuil").ToString
				End If
			End With
		End Using
	End Sub

End Class
