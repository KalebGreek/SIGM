Public Class AdelantoPage1
	Dim persona_id As Integer = 0

	'Routines
	Public Sub save()
		DbMan.EditDB("INSERT INTO hac_adelanto(monto, fecha, persona_id) 
						   VALUES('" & monto.Value & "', '" & fecha.Value & "', " & persona_id & ")",
					 My.Settings.CurrentDB)
	End Sub
	'Events
	Private Sub buscarPersona_Click(sender As Object, e As EventArgs) Handles buscarPersona.Click
		Using bper As New ConsultaPersona With {.Parent = Me}
			bper.SelectPerson = True
			bper.ShowDialog(Me)
			Dim source As DataRowView = bper.PersonSelected
			If source Is Nothing = False Then
				persona_id = source("persona_id").ToString
				razon.Text = source("razon").ToString
				cuil.Text = source("cuil").ToString
			End If
		End Using
	End Sub

End Class
