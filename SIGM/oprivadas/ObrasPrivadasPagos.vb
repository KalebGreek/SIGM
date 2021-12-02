Class ObrasPrivadasPagos
    Shared Function Consultar(opr_id As Integer, deuda As Boolean) As DataTable
        Dim sqlSelect As String = "SELECT opr_pago.id as id, tipo_deuda, cuota, deuda, vence, fecha_pago, pago
                                     FROM opr_pago
                                    WHERE opr_pago.opr_id=" & opr_id
        If deuda Then
            sqlSelect += " AND opr_pago.fecha_pago is null"
        End If

        Return DbMan.ReadDB(sqlSelect, My.Settings.CurrentDB)
    End Function
    Shared Sub AgregarDeuda(opr_id As Integer, desc As String, monto As Double, cuotas As Integer, fecha As Date)
        Dim sqlInsert As String = ""
        For cuota As Integer = 1 To cuotas 'Agrega monto dividido por cuotas
            'Calcular vencimientos
            'Agregar
            sqlInsert = "INSERT INTO opr_pago(opr_id, tipo_deuda, cuota, deuda, vence)
                              VALUES(" & opr_id & ", '" & desc & "', " & cuota & ", '" & monto / cuotas & "',
                                    '" & CtrlMan.CalcularVencimiento(fecha, cuota) & "')"
        Next
        DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)
    End Sub
    Shared Function EliminarDeuda(deuda_id As Integer) As Boolean
        Return DbMan.EditDB("DELETE * FROM opr_pago WHERE id=" & deuda_id,
                            My.Settings.CurrentDB)
    End Function
    Shared Function AgregarPago(deuda_id As Integer, fecha As Date, monto As Double) As Boolean
        Return DbMan.EditDB("UPDATE opr_pago 
                                SET fecha_pago='" & fecha.ToShortDateString & "', pago='" & monto & "'
                              WHERE id=" & deuda_id,
                            My.Settings.CurrentDB)

    End Function
End Class