Public Class CtrlBusquedaCombustiblePorTicket
    Private Sub Minmax_ValueChanged(sender As Object, e As EventArgs) Handles minimo.ValueChanged, maximo.ValueChanged
        If maximo.Value < minimo.Value Then
            maximo.Value = minimo.Value
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged,
                                                                                      RadioButton2.CheckedChanged,
                                                                                      RadioButton3.CheckedChanged

        minimo.Value = 0
        maximo.Value = 0
        If RadioButton3.Checked = False Then
            Label13.Visible = RadioButton1.Checked
            minimo.Visible = RadioButton1.Checked
            Label11.Visible = RadioButton2.Checked
            maximo.Visible = RadioButton2.Checked
        Else
            Label13.Visible = True
            minimo.Visible = True
            Label11.Visible = True
            maximo.Visible = True
        End If
    End Sub
End Class
