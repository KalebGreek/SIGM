Public Class HaciendaMenu
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)

    End Sub
    Private Sub Menu_Events(sender As Object, e As EventArgs)

        Dim f1 As Form = Nothing
        If sender Is ConsultasEspecialesStripMenuItem Then
            Hacienda.ConsolidarCuentas(Today)
            f1 = New ConsultasEspeciales
        ElseIf sender Is ConsultaDeMovimientosToolStripMenuItem Then
            Hacienda.ConsolidarCuentas(Today)
            f1 = New ConsultaMovimientos
        ElseIf sender Is CalculoAnualDeImpuestosToolStripMenuItem Then
            'Es obligatorio usar EN-US para generar las deudas correctamente en Foxpro
            System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")
            f1 = New CalcAnualImpUI
            f1.ShowDialog(Me)
            f1 = Nothing
            System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("ES-AR")
        ElseIf sender Is TicketsToolStripMenuItem Then
            f1 = New ModCombustible
        ElseIf sender Is SIJCORToolStripMenuItem Then
            f1 = New EditorSijCor
        ElseIf sender Is AdelantosToolStripMenuItem Then
            f1 = New ConsultaAdelanto
        ElseIf sender Is ConsolidarIngresosYEgresosToolStripMenuItem Then
            Hacienda.ConsolidarCuentas(Today)
        ElseIf sender Is ConversorSIROToolStripMenuItem Then
            f1 = New ConvertirSIRO
        ElseIf sender Is ConsultarImpuestoToolStripMenuItem Then
            If CtrlMan.IsFormOpen(Me.Parent, ConsultaImpuestoUI) Is Nothing Then
                f1 = New ConsultaImpuestoUI
            Else
                MsgBox("Debe cerrar la consulta actual antes de continuar.", MsgBoxStyle.Critical, "Consulta abierta")
                ConsultaImpuestoUI.Focus()
            End If

        ElseIf sender Is GenerarCertificadoToolStripMenuItem Then
            f1 = New CertificadoLibreDeuda

        ElseIf sender Is IntimacionesToolStripMenuItem Then
            f1 = New ConsultaIntimaciones
        End If

        If f1 Is Nothing = False Then
            f1.MdiParent = Me.Parent
            f1.Show()
        End If
    End Sub
End Class
