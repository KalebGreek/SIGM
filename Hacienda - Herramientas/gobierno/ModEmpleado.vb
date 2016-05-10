﻿Public Class ModEmpleado
    Public user_id As Integer
    Public bs_registro As New BindingSource
    Private Sub ModEmpleado_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            cargarJerarquiaPersonal()
            With bs_registro
                If .DataSource Is Nothing = False Then
                    If .Position > -1 Then
                        'Cargar datos

                        buscar.PerformClick()
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
            Dim answer As MsgBoxResult = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
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
    Private Sub buscar_click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim persona1 As New ConsultaGen(sender, user_id, sender.BackColor)
        With persona1
            .ShowDialog(Me)
            If .resultado.Position > -1 Then
                cuil.Text = .resultado.Current("cuil").ToString
                razon.Text = .resultado.Current("razon").ToString
                persona_id.Text = .resultado.Current("per_id").ToString
                If MsgBoxResult.Yes = MsgBox("Desea seleccionar esta persona?", MsgBoxStyle.YesNo) Then
                    grupo_persona.Enabled = False
                End If
            End If
        End With
        grupo_datos.Enabled = grupo_persona.Enabled.CompareTo(True)
    End Sub
    '###### CARGAR ##########################################################################################

    Private Sub bs_rubro_PositionChanged(sender As Object, e As EventArgs) Handles bs_rubro.PositionChanged
        partida.Visible = False
        partida.DataSource = Nothing
        bs_partida.DataSource = Nothing
        If bs_rubro.Position > -1 Then
            sel_sql = "SELECT nombre, partida FROM hacienda WHERE pertenece='9' AND anexo='1' AND inciso='1'" &
                      " AND item='1' AND rubro='" & bs_rubro.Current("rubro") & "' AND subrubro='01' AND partida>'00' AND subpartida='00'"
            Dim dtab As DataTable = bd.leer(foxcon, sel_sql)
            If dtab Is Nothing = False Then
                If dtab.Rows.Count > 0 Then
                    bs_partida.DataSource = dtab
                    partida.DataSource = bs_partida
                    partida.DisplayMember = "nombre"
                    partida.Visible = True
                End If
            End If
        End If
    End Sub
    Private Sub bs_partida_PositionChanged(sender As Object, e As EventArgs) Handles bs_partida.PositionChanged
        subpartida.Visible = False
        subpartida.DataSource = Nothing
        bs_subpartida.DataSource = Nothing
        If bs_partida.Position > -1 Then
            sel_sql = "SELECT nombre, subpartida FROM hacienda WHERE pertenece='9' AND anexo='1' AND inciso='1'" &
                      " AND item='1' AND rubro='" & bs_rubro.Current("rubro") & "' AND subrubro='01'" &
                      " AND partida='" & bs_partida.Current("partida") & "' AND subpartida>'00'"
            Dim dtab As DataTable = bd.leer(foxcon, sel_sql)
            If dtab Is Nothing = False Then
                If dtab.Rows.Count > 0 Then
                    bs_subpartida.DataSource = dtab
                    subpartida.DataSource = bs_subpartida
                    subpartida.DisplayMember = "nombre"
                    subpartida.Visible = True
                End If
            End If
        End If
    End Sub
    Private Sub cargarJerarquiaPersonal()
        sel_sql = "SELECT nombre, rubro FROM hacienda WHERE pertenece='9' AND anexo='1' AND inciso='1' AND item='1'" &
                  " AND rubro>'00' AND rubro <'03' AND subrubro='00' AND partida='00' AND subpartida='00'"
        Dim dtab As DataTable = bd.leer(foxcon, sel_sql)
        If dtab Is Nothing = False Then
            If dtab.Rows.Count > 0 Then
                bs_rubro.DataSource = dtab
                rubro.DataSource = bs_rubro
                rubro.DisplayMember = "nombre"
            End If
        End If
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
            Dim dtab As DataTable = bd.leer(defcon, sel_sql)
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