Public Class Ordenanza
    Shared ReadOnly SQLSelect As String = "SELECT id as ordenanza_id, codigo, fecha, concepto, ruta_copia FROM ordenanza"
    Shared ReadOnly SQLOrder As String = " ORDER BY fecha"



    Public Shared Function Listar() As DataTable
        Return DbMan.ReadDB(SQLSelect & SQLOrder, My.Settings.CurrentDB)
    End Function

    Public Shared Function ValidarCodigo(codigo As Double, ordenanza_id As Double, ByRef control As MaskedTextBox, ByRef info As Label) As Boolean
        Dim msg As String = ""
        Dim dtab As New DataTable
        Dim sql As String = ""

        If ordenanza_id > 0 Then
            sql = SQLSelect & " WHERE id=" & ordenanza_id
        ElseIf CInt(Right(codigo, 4)) > 1899 And codigo >= 11899 Then
            sql = SQLSelect & " WHERE codigo=" & codigo
        Else
            msg = "Código inválido."
        End If

        If Len(sql) > 0 Then
            dtab = DbMan.ReadDB(sql, My.Settings.CurrentDB)
            If dtab Is Nothing = False Then
                If dtab.Rows.Count > 0 Then
                    If dtab.Rows.Count = 1 And ordenanza_id > 0 Then
                        If ordenanza_id = dtab.Rows(0)("ordenanza_id").ToString Then
                            'Editar
                        Else
                            'Mal cargado
                            msg = "Registro inválido."
                        End If
                    Else
                        'Codigo duplicado
                        msg = "Esta ordenanza ya se encuentra cargada en el sistema."
                    End If
                End If
            End If
        End If
        info.Text = msg
        If msg = "" Then
            control.BackColor = My.Settings.DefaultColorValue
        Else
            control.BackColor = My.Settings.ErrorColorValue
        End If
        Return msg = ""
    End Function

    Public Shared Function Guardar(ordenanza_id As Double, codigo As Double, fecha As String, concepto As String, ruta_doc As String) As Boolean
        Dim sql As String
        concepto = Trim(concepto)
        If ordenanza_id > -1 Then 'Mod
            sql = "UPDATE ordenanza 
                      SET fecha='" & fecha & "', concepto='" & concepto & "',
                          ruta_copia='" & ruta_doc & "' WHERE id=" & ordenanza_id
        Else 'Nueva
            sql = "INSERT INTO ordenanza(codigo, fecha, concepto, ruta_copia)
                        VALUES(" & codigo & ", '" & fecha & "',
                              '" & concepto & "', '" & ruta_doc & "')"
        End If
        Return DbMan.EditDB(sql, My.Settings.CurrentDB) > -1
    End Function
End Class
