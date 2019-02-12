Public Class CuentaAgrupada
	Public Class sql
		Shared Function leer(ByVal keyword As String, ByVal impuesto As String, ByVal sender As System.Object) As DataTable
			Dim consulta As New DataTable
			'### Crear consulta sin filtros
			If sender Is ConsultaCuentaAgrupada.ca_search Then 'Lista de Personas / Contribuyentes
				Dim sql As String = "SELECT id, cuil, razon FROM persona"
				If Val(Microsoft.VisualBasic.Right(keyword, 2)) >= 20 And Len(keyword) = 11 Then
					sql += " WHERE cuil=" & keyword
				Else
					sql += " WHERE razon Like '%" & keyword & "%'"
				End If
				consulta = DbMan.read(Nothing, My.Settings.DefaultCon, sql)
			ElseIf sender Is ConsultaCuentaAgrupada.mod_ca_imp_search Then 'Seleccionar impuestos sobre Fox
				tablas_fox(impuesto)
				'Cuidado acá, porque comercio no tiene campo "Tenedor"
				consulta = DbMan.read(Nothing, My.Settings.foxcon, "SELECT " & ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon, " & col_tenedor & " as tenedor FROM " & ext_persona & "
                                   INNER JOIN " & ext_cuenta & " ON " & ext_persona & ".codigo = " & ext_cuenta & ".codigo 
                                        WHERE " & ext_persona & ".razon LIKE '%" & keyword & "%' OR " & col_tenedor & " LIKE '%" & keyword & "%'")
			End If
			Return consulta
		End Function
	End Class
End Class
