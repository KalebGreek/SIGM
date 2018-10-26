Public Class Hacienda
	Shared Sub FillSeccion(ByRef bs As BindingSource, ByRef target As ComboBox)
		bs.DataSource = DbMan.read(  "SELECT * FROM seccion ORDER BY descripcion")
		CtrlMan.Fill.SetAutoComplete(target, bs, "descripcion", "id")
	End Sub
	Shared Sub FillCuentasHacienda(ByRef bs As BindingSource, ByRef target As ComboBox,
								   ByVal Optional sumado As Integer = 0,
								   ByVal Optional pertenece As String = "0",
								   ByVal Optional anexo As String = "0",
								   ByVal Optional inciso As String = "0",
								   ByVal Optional item As String = "0",
								   ByVal Optional rubro As String = "00",
								   ByVal Optional subrubro As String = "00",
								   ByVal Optional partida As String = "00",
								   ByVal Optional subpartida As String = "00")

		Dim sqlSelect As String = "SELECT * FROM hacienda "

		Dim sqlWhere As String = ""

		If sumado > 0 Then
			sqlWhere += " WHERE sumado=" & sumado
		End If

		If pertenece <> "0" Then
			If sqlWhere.Contains("WHERE") Then
				sqlWhere += " AND pertenece='" & pertenece & "'"
			Else
				sqlWhere += " WHERE pertenece='" & pertenece & "'"
			End If

			If anexo <> "0" Then
				sqlWhere += " AND anexo='" & anexo & "'"

				If inciso <> "0" Then
					sqlWhere += " AND inciso='" & inciso & "'"

					If item <> "0" Then
						sqlWhere += " AND item='" & item & "'"

						If rubro <> "00" Then
							sqlWhere += " AND rubro='" & rubro & "'"

							If subrubro <> "00" Then
								sqlWhere += " AND subrubro='" & subrubro & "'"

								If partida <> "00" Then
									sqlWhere += " AND partida='" & partida & "'"

									If subpartida <> "00" Then
										sqlWhere += " AND subpartida='" & subpartida & "'"
									End If
								End If
							End If
						End If
					End If
				End If
			End If
		End If

		Dim SqlOrder As String = " ORDER BY orden"

		bs.DataSource = DbMan.read(sqlSelect & sqlWhere & SqlOrder, My.Settings.foxcon)


		CtrlMan.Fill.SetAutoComplete(target, bs, "nombre", "orden")
	End Sub


End Class
