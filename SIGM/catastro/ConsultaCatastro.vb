Public Class ConsultaCatastro
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    ' GUI 
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
        Keyword.Visible = CBool(zona.Visible.CompareTo(True))
    End Sub

    Private Sub Zona_VisibleChanged(sender As Object, e As EventArgs) Handles zona.VisibleChanged
        With zona
            circ.Visible = .Visible
            secc.Visible = .Visible
            manz.Visible = .Visible
            parc.Visible = .Visible
            lote.Visible = .Visible
        End With
    End Sub
    ' END GUI 

    ' SEARCH / MOD 
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim dtab As New DataTable
        With Filtro1.Text
            If .Contains("PARTIDA") Then
                dtab = Catastro.BuscarPorPartida(CInt(zona.Text), CInt(circ.Text), CInt(secc.Text), CInt(manz.Text), CInt(parc.Text), CInt(lote.Text))
            ElseIf .Contains("DIRECCION") Then
                dtab = Catastro.BuscarPorDireccion(Trim(Keyword.Text))
            ElseIf .Contains("BARRIO") Then
                dtab = Catastro.BuscarPorDireccion(, Trim(Keyword.Text))
            ElseIf .Contains("NOMBRE") Then
                dtab = Catastro.BuscarPorTitular(Trim(Keyword.Text))
            ElseIf .Contains("CUIL") Then
                dtab = Catastro.BuscarPorTitular(, Val(Keyword.Text))
            ElseIf .Contains("EXPEDIENTE") Then
                dtab = Catastro.ListarInmueblePorExpediente(CInt(Keyword.Text))
            End If
        End With
        CtrlMan.DataGridViewTools.Load(tabla_consulta, bs_consulta, dtab)
    End Sub
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        tabla_consulta.DataSource = Nothing
        bs_consulta.DataSource = Nothing
        Keyword.Clear()
        zona.Clear()
        circ.Clear()
        manz.Clear()
        parc.Clear()
        lote.Clear()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs)
        Me.MdiParent = Nothing
        Me.Close()
    End Sub

    Private Sub Tabla_consulta_KeyUp(sender As Object, e As KeyEventArgs) Handles tabla_consulta.KeyUp
        If e.KeyValue = Keys.F2 Then
            Dim source As DataRowView = DirectCast(bs_consulta.Current, DataRowView)
            If source Is Nothing = False Then
                If source("opr_id").ToString > 0 Then
                    Using mod_i As New ModInmueble(source("opr_id"))
                        mod_i.zona.Value = source("zona")
                        mod_i.circ.Value = source("circ")
                        mod_i.secc.Value = source("secc")
                        mod_i.manz.Value = source("manz")
                        mod_i.parc.Value = source("parc")
                        mod_i.lote.Value = source("lote")
                        mod_i.ShowDialog(Me)
                    End Using
                End If
            End If
        End If
    End Sub

    ' END SEARCH 

End Class