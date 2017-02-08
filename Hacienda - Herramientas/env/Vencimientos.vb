Module Vencimientos
    Function Calcular(vencimiento As Date, Optional cuotas As Integer = 1)
        For c As Integer = 0 To cuotas
            vencimiento = vencimiento.AddDays(Date.DaysInMonth(vencimiento.Year, vencimiento.Month))
        Next
        Do While vencimiento.DayOfWeek = DayOfWeek.Saturday Or vencimiento.DayOfWeek = DayOfWeek.Sunday
            If vencimiento.DayOfWeek = DayOfWeek.Saturday Then
                vencimiento = vencimiento.AddDays(-1)
            Else
                vencimiento = vencimiento.AddDays(1)
            End If
        Loop
        Return FormatDateTime(vencimiento, DateFormat.ShortDate)
    End Function
End Module
