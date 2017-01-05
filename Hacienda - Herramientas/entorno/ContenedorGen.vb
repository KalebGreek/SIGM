Public Class ContenedorGen
	Public Sub New(user As Integer, tipo As Button)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        user_id.Text = user

		ConfigInit(Me, user_id.Text)

		BaseMenu.BackColor = tipo.BackColor

		Dim MenuName As String = Microsoft.VisualBasic.Right(tipo.Name, Len(tipo.Name) - 2) & "Menu"
		For Each i In BaseMenu.Items
			i.Visible = (i.Name = MenuName)
		Next
		SalirToolStripMenuItem.Visible = True
	End Sub

    'GENERAL
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

	'ACCION SOCIAL
	Private Sub NuevoBeneficiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoBeneficiarioToolStripMenuItem.Click

	End Sub

	Private Sub BuscarBeneficiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarBeneficiarioToolStripMenuItem.Click

	End Sub


	'CATASTRO
	Private Sub BuscarInmuebleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarInmuebleToolStripMenuItem.Click
        Dim ConsultaTitular1 As New ConsultaCatastro(user_id.Text)
        With ConsultaTitular1
            .MdiParent = Me
            .Show()
        End With
    End Sub
    Private Sub ConsultarPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPagosToolStripMenuItem.Click

    End Sub

    'HACIENDA
    Private Sub ConsultarImpuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarImpuestoToolStripMenuItem.Click
        If UniqueWindow(Me) Then
            MsgBox("Debe cerrar el expediente actual antes de continuar.", MsgBoxStyle.Critical, "Expediente Abierto")
        Else
            Dim ConsultaImpuesto1 As New ConsultaImpuesto
            ConsultaImpuesto1.MdiParent = Me
            ConsultaImpuesto1.Show()
        End If
    End Sub
    Private Sub ConsultarCuentaAgrupadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCuentaAgrupadaToolStripMenuItem.Click
        Dim ConsultaCuentaAgrupada1 As New ConsultaCuentaAgrupada
        ConsultaCuentaAgrupada1.MdiParent = Me
        ConsultaCuentaAgrupada1.Show()
    End Sub
    'Herramientas
    Private Sub ConsultasEspecialesStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasEspecialesStripMenuItem.Click
        Dim arqueo1 As New ConsultasEspeciales
        arqueo1.MdiParent = Me
        arqueo1.Show()
    End Sub
    Private Sub ConsultaDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeMovimientosToolStripMenuItem.Click
        Dim movimis1 As New ConsultaMovimientos
        movimis1.MdiParent = Me
        movimis1.Show()
    End Sub

    Private Sub CalculoAnualDeImpuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculoAnualDeImpuestosToolStripMenuItem.Click
        System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")
        CalculoAnualImpuesto.ShowDialog()
        System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("ES-AR")
    End Sub
    Private Sub GenerarCertificadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarCertificadoToolStripMenuItem.Click
        Dim certld As New CertificadoLibreDeuda
        With certld
            .ShowDialog()
        End With
    End Sub
    'GOBIERNO
    Private Sub NuevaOrdenanzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaOrdenanzaToolStripMenuItem.Click
        Dim AgregarOrdenanza As New ModOrdenanza
        With AgregarOrdenanza
            .ShowDialog(Me)
            .Dispose()
        End With
    End Sub
    Private Sub BuscarOrdenanzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarOrdenanzaToolStripMenuItem.Click
        Dim BuscarOrdenanza As New ConsultaOrdenanza
        With BuscarOrdenanza
            .MdiParent = Me
            .Show()
        End With
    End Sub

    'OBRAS PUBLICAS
    Private Sub AsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciaToolStripMenuItem.Click

    End Sub
    Private Sub BuscarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoToolStripMenuItem.Click
        Dim buscar1 As New ConsultaGen("EMPLEADO", user_id.Text)

    End Sub
    Private Sub NuevoContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoContratoToolStripMenuItem.Click
        Dim contrato1 As New ModEmpleado
        contrato1.ShowDialog(Me)
        contrato1.Dispose()
    End Sub
    Private Sub BuscarContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarContratoToolStripMenuItem.Click
        Dim buscar1 As New ConsultaGen("CONTRATO", user_id.Text)
        buscar1.MdiParent = Me
        buscar1.Show()
    End Sub

    'OBRAS PRIVADAS
    Private Sub BuscarExpedienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarExpedienteToolStripMenuItem.Click
        Dim buscar1 As New ConsultaGen("EXPEDIENTE", user_id.Text)
        buscar1.MdiParent = Me
        buscar1.Show()
    End Sub
    Private Sub BuscarProfesionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProfesionalToolStripMenuItem.Click
        Dim buscar1 As New ConsultaGen("PERSONA", user_id.Text)
        buscar1.MdiParent = Me
        buscar1.Show()
    End Sub

    Private Sub NuevaPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaPersonaToolStripMenuItem.Click
        Dim modper1 As New ModPersona()
        modper1.ShowDialog()
    End Sub
    Private Sub BuscarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPersonaToolStripMenuItem.Click
        Dim buscar1 As New ConsultaGen("PERSONA", user_id.Text)
        buscar1.MdiParent = Me
        buscar1.Show()
    End Sub
    Private Sub BuscarActaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarActaToolStripMenuItem.Click

    End Sub












	'PERSONA





End Class


