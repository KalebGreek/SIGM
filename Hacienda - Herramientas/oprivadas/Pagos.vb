Public Class Pagos
    Shared Function Consultar(opr_id As Integer, deuda As Boolean)
        sel_sql = "SELECT opr_pago.id as id, tipo_deuda, cuota, deuda, vence, fecha_pago, pago" &
                 " FROM opr_pago"
        sel_sql += " WHERE opr_pago.opr_id=" & opr_id

        If deuda Then
            sel_sql += " AND opr_pago.fecha_pago is null"
        End If

        Return bd.read(defcon, sel_sql)
    End Function
    Shared Sub AgregarDeuda(opr_id As Integer, desc As String, monto As Double, cuotas As Integer, fecha As Date)
        For cuota As Integer = 1 To cuotas 'Agrega monto dividido por cuotas
            'Calcular vencimientos
            'Agregar
            mod_sql = "INSERT INTO opr_pago(opr_id, tipo_deuda, cuota, deuda, vence)" &
                     " VALUES(" & opr_id & ", '" & desc & "'," &
                     " " & cuota & ", '" & monto / cuotas & "'," &
                     " '" & calc_vence(fecha, cuota) & "');"
            bd.edit(defcon, mod_sql)
        Next
    End Sub
    Shared Sub EliminarDeuda(deuda_id As Integer, opr_id As Integer)
        del_sql = "DELETE * FROM opr_pago WHERE id=" & deuda_id
        bd.edit(defcon, del_sql)
    End Sub
    Shared Sub AgregarPago(deuda_id As Integer, opr_id As Integer, fecha As Date, monto As Double)
        mod_sql = "UPDATE opr_pago SET fecha_pago='" & fecha.ToShortDateString & "', pago='" & monto & "'"
        mod_sql += " WHERE id=" & deuda_id
        bd.edit(defcon, mod_sql)
    End Sub
End Class