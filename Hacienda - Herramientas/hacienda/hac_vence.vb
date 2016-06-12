Module Vencimientos
    Function Listar(año_menor As Integer, año_mayor As Integer, mostrar As Boolean)
        Dim vencimientos As New DataTable

        If año_menor = año_mayor And mostrar Then
            vencimientos = bd.read(foxcon, "SELECT * FROM " & ext_vence & " WHERE periodo=" & año_menor)
        End If
        Return vencimientos
    End Function

End Module
