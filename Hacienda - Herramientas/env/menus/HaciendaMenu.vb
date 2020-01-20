Public Class HaciendaMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.F10 Then
            Dim console1 As New SQLConsole _
            With {.MdiParent = Me.Parent}
            console1.Show()
        End If
    End Sub

    Private Sub ConsultasEspecialesStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasEspecialesStripMenuItem.Click
        Hacienda.ConsolidarCuentas(Today)
        Dim arqueo1 As New ConsultasEspeciales _
        With {.MdiParent = Me.Parent}
        arqueo1.Show()
    End Sub
    Private Sub ConsultaDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeMovimientosToolStripMenuItem.Click
        Hacienda.ConsolidarCuentas(Today)
        Dim movimis1 As New ConsultaMovimientos _
        With {.MdiParent = Me.Parent}
        movimis1.Show()
    End Sub

    Private Sub CalculoAnualDeImpuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoAnualDeImpuestosToolStripMenuItem.Click
        System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")
        Dim cai As New CalcAnualImpUI
        cai.ShowDialog()
        System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("ES-AR")
    End Sub

    Private Sub TicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketsToolStripMenuItem.Click
        Dim mcomb As New ModCombustible _
        With {.MdiParent = Me.Parent}
        mcomb.Show()
    End Sub
    Private Sub SIJCORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIJCORToolStripMenuItem.Click
        Dim sijcor As New EditorSijCor _
        With {.MdiParent = Me.Parent}
        sijcor.Show()
    End Sub
    Private Sub AdelantosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdelantosToolStripMenuItem.Click
        Dim buscar1 As New BusquedaAdelanto
        buscar1.GenSearchControl1.vista.SelectedIndex = 0
        buscar1.Show()
    End Sub
    Private Sub ConsolidarIngresosYEgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolidarIngresosYEgresosToolStripMenuItem.Click
        Hacienda.ConsolidarCuentas(Today)
    End Sub

    Private Sub ConversorSIROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversorSIROToolStripMenuItem.Click
        Dim convsiro As New ConvertirSIRO _
        With {.MdiParent = Me.Parent}
        convsiro.Show()
    End Sub

    Private Sub ConsultarImpuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarImpuestoToolStripMenuItem.Click
        If CtrlMan.IsFormOpen(Me.Parent, ConsultaImpuesto) Then
            MsgBox("Debe cerrar el expediente actual antes de continuar.", MsgBoxStyle.Critical, "Expediente Abierto")
        Else
            Dim ConsultaImpuesto1 As New ConsultaImpuesto _
            With {.MdiParent = Me.Parent}
            ConsultaImpuesto1.Show()
        End If
    End Sub

    Private Sub GenerarCertificadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarCertificadoToolStripMenuItem.Click
        Dim certld As New CertificadoLibreDeuda
        certld.ShowDialog()
    End Sub

    Private Sub IntimacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntimacionesToolStripMenuItem.Click
        Dim ConIntimaciones As New ConsultaIntimaciones _
       With {.MdiParent = Me.Parent}
        ConIntimaciones.Show()
    End Sub
End Class
