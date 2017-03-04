Public Class Pagos
    Shared Function Consultar(opr_id As Integer, deuda As Boolean)
        Dim sql As String = "SELECT opr_pago.id as id, tipo_deuda, cuota, deuda, vence, fecha_pago, pago
                             FROM opr_pago
                             WHERE opr_pago.opr_id=" & opr_id
        If deuda Then
            sql += " AND opr_pago.fecha_pago is null"
        End If

		Return DbMan.read(My.Settings.DefaultCon, sql)
	End Function
	Shared Sub AgregarDeuda(opr_id As Integer, desc As String, monto As Double, cuotas As Integer, fecha As Date)
		For cuota As Integer = 1 To cuotas 'Agrega monto dividido por cuotas
            'Calcular vencimientos
            'Agregar
            DbMan.edit(My.Settings.DefaultCon,
					"INSERT INTO opr_pago(opr_id, tipo_deuda, cuota, deuda, vence)
                     VALUES(" & opr_id & ", '" & desc & "', " & cuota & ", '" & monto / cuotas & "'," &
					" '" & Vencimientos.Calcular(fecha, cuota) & "')")
		Next
	End Sub
	Shared Sub EliminarDeuda(deuda_id As Integer, opr_id As Integer)
		DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM opr_pago WHERE id=" & deuda_id)
	End Sub
	Shared Sub AgregarPago(deuda_id As Integer, opr_id As Integer, fecha As Date, monto As Double)
		DbMan.edit(My.Settings.DefaultCon, "UPDATE opr_pago 
                         SET fecha_pago='" & fecha.ToShortDateString & "', pago='" & monto & "'
                         WHERE id=" & deuda_id)
	End Sub
End Class