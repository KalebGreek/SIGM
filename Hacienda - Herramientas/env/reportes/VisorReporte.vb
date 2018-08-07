﻿Imports System.Drawing.Printing
Public Class VisorReporte
	Public Sub New(titulo As String, Optional tipo As String = "",
				   Optional parametros As Generic.List(Of ReportParameter) = Nothing,
				   Optional DataSource As DataTable() = Nothing, Optional blank As Boolean = True)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = titulo

		If DataSource Is Nothing = False Then
			ReporteActual.LocalReport.DataSources.Clear()
			Dim count As Integer = 0
			For Each dt As DataTable In DataSource
				Dim rds As New ReportDataSource(dt.TableName, dt)
				ReporteActual.LocalReport.DataSources.Add(rds)
			Next
		End If

		'Verificar reporte
		mostrar(tipo, parametros, blank)
	End Sub

	'Rutinas
	Public Function GetPaperSize(ByVal p As PrinterSettings, ByVal papName As String) As PaperSize
        GetPaperSize = p.DefaultPageSettings.PaperSize
        For Each papSize As PaperSize In p.PaperSizes
            If papSize.PaperName = papName Then
                GetPaperSize = papSize
                Exit For
            End If
        Next
    End Function
    Public Sub mostrar(Optional tipo As String = "",
                       Optional parametros As Generic.List(Of ReportParameter) = Nothing,
                       Optional blank As Boolean = True)
        With ReporteActual
            tipo = Trim(tipo)
			If Len(tipo) >= 7 Then 'OPR\PPE
                .LocalReport.ReportPath = root & "\" & tipo & ".rdlc"

				'.RefreshReport()
				If blank = False And parametros Is Nothing = False Then
					.LocalReport.SetParameters(parametros)
				End If
                'Resetear config pagina
                Dim config_pag As PageSettings = .GetPageSettings()
				config_pag.PaperSize = GetPaperSize(.PrinterSettings, "A4")
				.SetPageSettings(config_pag)
				.RefreshReport()
                'Mostrar
                .Visible = True
			End If
		End With
    End Sub
    Private Sub CerrarFormularioActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarFormularioActualToolStripMenuItem.Click
        ReporteActual.Visible = False
    End Sub
    ' > Formularios
    ' > > Presentación
    Private Sub PlanosDeEdificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanosDeEdificaciónToolStripMenuItem.Click
		mostrar("oprivadas\REPORTES\PPE")
	End Sub
    Private Sub PlanosDeMensuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanosDeMensuraToolStripMenuItem.Click
		mostrar("oprivadas\REPORTES\PPM")
	End Sub

    ' > > Solicitud
    Private Sub FinalDeObraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalDeObraToolStripMenuItem.Click
		mostrar("oprivadas\REPORTES\SFO")
	End Sub
    Private Sub InspecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InspecciónToolStripMenuItem.Click
		mostrar("oprivadas\REPORTES\SIN")
	End Sub
    Private Sub LíneaMunicipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LíneaMunicipalToolStripMenuItem.Click
		mostrar("oprivadas\REPORTES\SLM")
	End Sub
    Private Sub PrórrogaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrórrogaToolStripMenuItem.Click
		mostrar("oprivadas\REPORTES\SPR")
	End Sub
    Private Sub MediciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediciónToolStripMenuItem.Click
		mostrar("oprivadas\REPORTES\SMT")
	End Sub
    Private Sub ActividadComercialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActividadComercialToolStripMenuItem.Click
		mostrar("gobierno\REPORTES\SIC")
	End Sub
    Private Sub AutomotorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomotorToolStripMenuItem.Click
		mostrar("gobierno\REPORTES\SIA")
	End Sub
    Private Sub AutomotorConDDJJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomotorConDDJJToolStripMenuItem.Click
		mostrar("gobierno\REPORTES\SID")
	End Sub
    Private Sub UsoGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsoGeneralToolStripMenuItem.Click
		mostrar("gobierno\REPORTES\SUG")
	End Sub
	Private Sub NotaDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaDePedidoToolStripMenuItem.Click
		mostrar("opublicas\REPORTES\NOP")
	End Sub

    ' > > Constancia
    Private Sub FinalDeObraToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FinalDeObraToolStripMenuItem1.Click
		mostrar("oprivadas\REPORTES\CFO")
	End Sub
    Private Sub LíneaMunicipalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LíneaMunicipalToolStripMenuItem1.Click
        Dim param As New Generic.List(Of ReportParameter)
        Dim razon As String = InputBox("Ingresar Razon Social", "Ingresar Razon Social", "APELLIDO, NOMBRE")
        If Len(razon) > 4 Then
            param.Add(New ReportParameter("razon", razon))
			mostrar("oprivadas\REPORTES\CLM", param, False)
		End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class