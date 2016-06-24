Public Class Hacienda
    Public Class CalculoAnual
        Public Class sql
            Shared Function LeerVencimientos(impuesto As String, periodo As Integer) As Date()
                Dim vence(6) As Date
                Dim dtab As New DataTable
                If impuesto = "AGUA" Then
                    'Cargar vencimientos
                    dtab = bd.read(foxcon, "SELECT * FROM aguvence WHERE periodo=" & periodo)
                    vence(1) = dtab(0)("vence1")
                    vence(2) = dtab(0)("vence2")
                    vence(3) = dtab(0)("vence3")
                    vence(4) = dtab(0)("vence4")
                    vence(5) = dtab(0)("vence5")
                    vence(6) = dtab(0)("vence6")
                ElseIf impuesto = "AUTO" Then
                    dtab = bd.read(foxcon, "SELECT * FROM autovence WHERE periodo=" & periodo)
                    vence(1) = dtab(0)("vence1")
                    vence(2) = dtab(0)("vence2")
                    vence(3) = dtab(0)("vence3")
                    vence(4) = dtab(0)("vence4")
                ElseIf impuesto = "CATASTRO" Then
                    dtab = bd.read(foxcon, "SELECT * FROM catvence WHERE periodo=" & periodo)
                    vence(1) = dtab(0)("vence1")
                    vence(2) = dtab(0)("vence2")
                    vence(3) = dtab(0)("vence3")
                    vence(4) = dtab(0)("vence4")
                    vence(5) = dtab(0)("vence5")
                    vence(6) = dtab(0)("vence6")
                ElseIf impuesto = "COMERCIO" Then
                    dtab = bd.read(foxcon, "SELECT * FROM comvence WHERE periodo=" & periodo)
                    vence(1) = dtab(0)("vence1")
                    vence(2) = dtab(0)("vence2")
                    vence(3) = dtab(0)("vence3")
                    vence(4) = dtab(0)("vence4")
                    vence(5) = dtab(0)("vence5")
                    vence(6) = dtab(0)("vence6")
                ElseIf impuesto = "SEPELIO" Then
                    vence(1) = New Date(periodo, 1, 1)
                    Do While vence(1).DayOfWeek <> DayOfWeek.Monday
                        vence(1) = vence(1).AddDays(1)
                    Loop
                End If
                Return vence
            End Function

            Public Class Agua 'Listo
                Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
                    Dim dtab As DataTable = bd.read(foxcon,
                                                    "SELECT * FROM agucue 
                                                    WHERE codigo=" & registro(fila)("codigo") & " 
                                                    AND mes=" & cuota & " AND periodo=" & periodo)
                    If dtab.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, importe As Decimal,
                                          vence As Date(), reside As Decimal, comercio As Decimal, industria As Decimal, franqueo As Decimal)
                    bd.edit(foxcon,
                            "INSERT INTO agucue(tipo, mes, agrupado, periodo, codigo, cedulon,
                                                importe, original, vencio, pagado, pago,
                                                reside, comercio, industria, contado, franqueo, link)" &
                            " VALUES('N', " & cuota & ", '', " & periodo & ", " & registro(fila)("codigo") & ", 0,
                            " & importe & ", " & importe & ", {" & vence(cuota) & "}, 0, {},
                            " & reside & ", " & comercio & ", " & industria & ", 0, " & franqueo & ", '')")
                End Sub
            End Class
            Public Class Auto
                Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
                    Dim dtab As DataTable = bd.read(foxcon,
                                                    "SELECT * FROM autocue
                                                     WHERE codigo=" & registro(fila)("codigo") & "
                                                     AND cuota=" & cuota & " AND ano=" & periodo)
                    If dtab.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, importe As Decimal, vence As Date())
                    bd.edit(foxcon,
                            "INSERT INTO autocue(cedulon, cuota, ano, moratoria, codigo, razon, marca, modelo, apagar, gastos, total, total1," &
                            " total2, vencimi1, vencimi2, vencimi3, apagado, fecha, link)" &
                            " VALUES(0, " & cuota & ", " & periodo & ", 'N', " & registro(fila)("codigo") & ", '" & Trim(registro(fila)("razon")) & "'," &
                            " '" & Trim(registro(fila)("marca")) & "', " & registro(fila)("modelo") & ", " & importe & ", 0, " & importe & "," &
                            " " & importe & ", " & importe & ", {" & vence(cuota) & "}, {}, {}, 0, {}, '')")
                End Sub
            End Class
            Public Class Catastro
                Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
                    Dim dtab As DataTable = bd.read(foxcon,
                                                    "SELECT * FROM catcue
                                                     WHERE codigo=" & registro(fila)("codigo") & " 
                                                     AND mes=" & cuota & " AND periodo=" & periodo)
                    If dtab.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, importe As Decimal,
                                     vence As Date(), minimo As Decimal, baldio As Decimal, jubilado As Decimal, pasillo As Decimal,
                                     agrario As Decimal, franqueo As Decimal, taecat As Decimal)
                    bd.edit(foxcon,
                            "INSERT INTO catcue(tipo, mes, agrupado, periodo, codigo, cedulon, importe, original, vencio, pagado, pago, basica, minimo, baldio," &
                            " jubilado, esquina, pasillo, agropec, contado, franqueo, chapa, alumbrado, vereda, parque, ochoa, ochob, ochoc, ochod, tae, agua, link)" &
                            " VALUES('N', " & cuota & ", '', " & periodo & ", " & registro(fila)("codigo") & ", 0, " & importe & ", " & importe & "," &
                            " {" & vence(cuota) & "}, 0, {}, " & importe & ", " & minimo & ", " & baldio & ", " & jubilado & ", 0, " & pasillo & "," &
                            " " & agrario & ", 0, " & franqueo & ", 0, 0, 0, 0, 0, 0, 0, 0, " & taecat & ", 0, '')")
                End Sub
            End Class
            Public Class Comercio
                Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
                    Dim dtab As DataTable = bd.read(foxcon,
                                                    "SELECT * FROM comcue 
                                                     WHERE codigo=" & registro(fila)("codigo") & " 
                                                     AND bimestre=" & cuota & " AND ano=" & periodo)
                    If dtab.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, minimo As Decimal,
                                      taecom As Decimal, franqueo As Decimal, importe As Decimal, vence As Date())
                    bd.edit(foxcon, "INSERT INTO comcue(item, tipo, cedulon, bimestre, agrupado, ano, codigo, actividad, importe, franqueo, tae," &
                                    " total, total1, total2, vence1, vence2, vence3, pagado, pago)" &
                                    " VALUES(0, 'N', 0, " & cuota & ", ' ', " & periodo & ", " & registro(fila)("codigo") & "," &
                                    " " & registro(fila)("actividad") & "," & minimo & ", " & franqueo & ", " & taecom & "," &
                                    " " & importe & ", " & importe & ", " & importe & ", {" & vence(cuota) & "}, {}, {}, 0, {})")
                End Sub
            End Class
            Public Class Sepelio
                Shared Function VerificarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer) As Boolean
                    Dim dtab As DataTable = bd.read(foxcon,
                                                    "SELECT * FROM sepecue
                                                    WHERE codigo=" & registro(fila)("codigo") & " 
                                                    AND mes=" & cuota & " AND periodo=" & periodo)
                    If dtab.Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Function
                Shared Sub InsertarCuota(registro As DataTable, fila As Integer, cuota As Integer, periodo As Integer, importe As Decimal, vence As Date())
                    bd.edit(foxcon, "INSERT INTO sepecue(tipo, mes, agrupado, periodo, codigo, cedulon, importe, original, vencio, pagado, pago)" &
                                    " VALUES('A', " & cuota & ", ''," & periodo & ", " & registro(fila)("codigo") & "," &
                                    " 0, " & importe & ", " & importe & ", {" & vence(cuota) & "}, 0, {})")
                End Sub
            End Class
        End Class
    End Class
    Public Class CuentaAgrupada
        Public Class sql
            Shared Function leer(ByVal keyword As String, ByVal impuesto As String, ByVal sender As System.Object)
                Dim consulta As New DataTable
                '### Crear consulta sin filtros
                If sender Is ConsultaCuentaAgrupada.ca_search Then 'Lista de Personas / Contribuyentes
                    Dim sql As String = "SELECT id, cuil, razon FROM persona"
                    If Val(Microsoft.VisualBasic.Right(keyword, 2)) >= 20 And Len(keyword) = 11 Then
                        sql += " WHERE cuil=" & keyword
                    Else
                        sql += " WHERE razon Like '%" & keyword & "%'"
                    End If
                    consulta = bd.read(defcon, sql)
                ElseIf sender Is ConsultaCuentaAgrupada.mod_ca_imp_search Then 'Seleccionar impuestos sobre Fox
                    tablas_fox(impuesto)
                    'Cuidado acá, porque comercio no tiene campo "Tenedor"
                    consulta = bd.read(foxcon,
                                       "SELECT " & ext_persona & ".codigo as codigo, " & ext_persona & ".razon as razon, " & col_tenedor & " as tenedor FROM " & ext_persona & "
                                        INNER JOIN " & ext_cuenta & " ON " & ext_persona & ".codigo = " & ext_cuenta & ".codigo 
                                        WHERE " & ext_persona & ".razon LIKE '%" & keyword & "%' OR " & col_tenedor & " LIKE '%" & keyword & "%'")
                End If
                Return consulta
            End Function
        End Class
    End Class
End Class
