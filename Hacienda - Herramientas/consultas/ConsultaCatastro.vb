﻿Public Class ConsultaCatastro
    Dim user_id As Integer
    Public Sub New(user As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        user_id = user
    End Sub
    '###### VARIABLES Y RUTINAS #################################################################################
    '###### FIN VARIABLES Y RUTINAS #############################################################################
    '###### GUI #################################################################################################
    'INMUEBLE
    Private Sub Filtro1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Filtro1.SelectedIndexChanged
        zona.Visible = False
        With Filtro1.Text
            If .Contains("PARTIDA") Then
                Keyword.Mask = ""
                zona.Visible = True
            ElseIf .Contains("CUIL") Then
                Keyword.Mask = "99-99999999-9"
            ElseIf .Contains("EXPEDIENTE") Then
                Keyword.Mask = "9999 9999"
            ElseIf .Contains("DIRECCION") Or .Contains("BARRIO") Or .Contains("NOMBRE") Then
                Keyword.Mask = "AAAAAAAAAAAAA"
            End If
        End With
        Keyword.Visible = zona.Visible.CompareTo(True)
    End Sub
    Private Sub zona_VisibleChanged(sender As Object, e As EventArgs) Handles zona.VisibleChanged
        With zona
            circ.Visible = .Visible
            secc.Visible = .Visible
            manz.Visible = .Visible
            parc.Visible = .Visible
            lote.Visible = .Visible
        End With
    End Sub
    '###### END GUI #############################################################################################

    '###### SEARCH / MOD ########################################################################################

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim dtab As New DataTable
        With Filtro1.Text
            If .Contains("PARTIDA") Then
                dtab = Catastro.BuscarPorPartida(zona.Text, circ.Text, secc.Text, manz.Text, parc.Text, lote.Text)
            ElseIf .Contains("DIRECCION") Then
                dtab = Catastro.BuscarPorDireccion(Trim(Keyword.Text))
            ElseIf .Contains("BARRIO") Then
                dtab = Catastro.BuscarPorDireccion(, Trim(Keyword.Text))
            ElseIf .Contains("NOMBRE") Then
                dtab = Catastro.BuscarPorTitular(Trim(Keyword.Text))
            ElseIf .Contains("CUIL") Then
                dtab = Catastro.BuscarPorTitular(, Val(Keyword.Text))
            ElseIf .Contains("EXPEDIENTE") Then
                dtab = Catastro.ListarInmueblePorExpediente(Val(Keyword.Text))
            End If
        End With
        Data.ToDataGridView(tabla_consulta, bs_consulta, dtab)
    End Sub
    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        tabla_consulta.DataSource = Nothing
        bs_consulta.DataSource = Nothing
        Keyword.Clear()
        zona.Clear()
        circ.Clear()
        manz.Clear()
        parc.Clear()
        lote.Clear()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs)
        Me.MdiParent = Nothing
        Me.Close()
    End Sub

    '###### END SEARCH ##########################################################################################

End Class