Public Class CuentaAgrupada
	Public Class sql
		Shared Function leer(ByVal keyword As String, ByVal impuesto As String, ByVal sender As System.Object) As DataTable
            Dim consulta As New DataTable
            Dim sql(5) As String
            '### Crear consulta sin filtros
            If sender Is ConsultaCuentaAgrupada.ca_search Then 'Lista de Personas / Contribuyentes
                sql(0) = "SELECT id, cuil, razon"
                sql(1) = "FROM persona"
                If Val(Microsoft.VisualBasic.Right(keyword, 2)) >= 20 And Len(keyword) = 11 Then
                    sql(2) = " WHERE cuil=" & keyword
                Else
                    sql(2) = " WHERE razon Like '%" & keyword & "%'"
                End If
				consulta = DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)
			ElseIf sender Is ConsultaCuentaAgrupada.mod_ca_imp_search Then 'Seleccionar impuestos sobre Fox
				tablas_fox(impuesto)
                'Cuidado acá, porque comercio no tiene campo "Tenedor"
                sql(0) = "SELECT " & ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon, " & col_tenedor & " as tenedor"
                sql(1) = "FROM " & ext_persona & " 
                         INNER JOIN " & ext_cuenta & " ON " & ext_persona & ".codigo = " & ext_cuenta & ".codigo"
                sql(2) = "WHERE " & ext_persona & ".razon LIKE '%" & keyword & "%' OR " & col_tenedor & " LIKE '%" & keyword & "%'"
                consulta = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)


            End If
			Return consulta
		End Function
	End Class
End Class
