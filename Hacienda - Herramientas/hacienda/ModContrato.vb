Public Class ModContrato
    Public bs_registro As New BindingSource
    Private Sub ModEmpleado_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            With bs_registro
                If .DataSource Is Nothing = False Then
                    If .Position > -1 Then
                        'Cargar datos

                    End If
                End If
            End With
        End If
    End Sub
    '###### GUI ##########################################################################################
    Private Sub guardarcambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambios.Click
        'Según si se modifica un CUIL de persona o un profesional, hay que actualizar campos de distintas tablas
        'No correr el update de cuil al pedo si no cambió nada (comparar nuevo y viejo)
        'No actualizar cuil si no tiene 11 de largo, dejar valor anterior.
        If ValidarCambios() Then
            'Imprimir contrato
            'Dim contrato1 As New visor_reporte
            'With contrato1

            'End With
            Dim answer As MsgBoxResult = MsgBox("¿Desea imprimir el contrato?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
            'Guardar cambios
            If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
                If answer = MsgBoxResult.Yes Then
                    guardar()
                End If
                Me.Close()
            End If
        End If
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
    '###### CARGAR ##########################################################################################
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

    End Sub

    '###### VALIDAR ##########################################################################################
    Private Function ValidarCodigo(ordenanza_id As Integer, codigo As Integer) As Boolean
        Dim valido As Boolean = True
        Dim msg As String = ""

        If codigo >= 11899 Or ordenanza_id > 0 Then
            sel_sql = "SELECT id, codigo FROM ordenanza"
            If ordenanza_id > 0 Then
                sel_sql += " WHERE id=" & ordenanza_id
            Else
                sel_sql += " WHERE codigo=" & codigo
            End If
            Dim dtab As DataTable = bd.read(defcon, sel_sql)
            If dtab Is Nothing = False Then
                If dtab.Rows.Count > 0 Then
                    If dtab.Rows.Count = 1 And ordenanza_id > 0 Then
                        If ordenanza_id = dtab(0)("id") Then
                            'Editar
                        Else
                            'Mal cargado
                            MsgBox("Registro invalido.")
                            Return False
                        End If
                    Else
                        'Codigo duplicado
                        MsgBox("Esta ordenanza ya se encuentra cargada en el sistema.")
                        Return False
                    End If
                End If
            End If
        Else
            MsgBox("Codigo invalido.")
            Return False
        End If
        Return True
    End Function
    Private Function ValidarCambios() As Boolean

        Return True
    End Function

    '###### GUARDAR ##########################################################################################
    Private Sub guardar()
        bd.edit(defcon, mod_sql)
    End Sub


   
End Class