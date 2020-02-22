Imports Microsoft.Reporting.WinForms
Public Class VisorReporte
    Public Sub New(Optional titulo As String = "Informe")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.Text = titulo
    End Sub
    Private Sub VisorReporte_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ReporteActual.Visible = Me.Visible
    End Sub
    'Rutinas
    Public Function NewPageSetting(Optional PageSize As String = "A4") As PageSettings
        With ReporteActual
            Dim config_pag As PageSettings = .GetPageSettings()
            config_pag.PaperSize = GetPaperSize(.PrinterSettings, PageSize)
            Return config_pag
        End With
    End Function
    Public Function GetPaperSize(ByVal p As PrinterSettings, ByVal papName As String) As PaperSize
        GetPaperSize = p.DefaultPageSettings.PaperSize
        For Each papSize As PaperSize In p.PaperSizes
            If papSize.PaperName = papName Then
                GetPaperSize = papSize
                Exit For
            End If
        Next
    End Function

    Public Overloads Sub mostrar(ReportType As String, Blank As Boolean, Optional PageSize As String = "A4")
        With ReporteActual
            ReportType = Trim(ReportType)
            If Len(ReportType) >= 7 Then 'OPR\PPE
                .LocalReport.ReportPath = root & "\" & ReportType & ".rdlc"

                'Resetear config pagina
                Try
                    .SetPageSettings(NewPageSetting(PageSize))
                Catch e As Exception 'Problema con impresora
                    MsgBox(e.Data, MsgBoxStyle.Exclamation, "Error al configurar la página.")
                End Try
                .RefreshReport()
            End If
        End With
    End Sub
    Public Overloads Sub mostrar(ReportType As String, parametros As Generic.List(Of ReportParameter), Optional PageSize As String = "A4")
        With ReporteActual
            ReportType = Trim(ReportType)
            If Len(ReportType) >= 7 Then 'OPR\PPE
                .LocalReport.ReportPath = root & "\" & ReportType & ".rdlc"

                '.RefreshReport()
                If parametros Is Nothing = False Then
                    .LocalReport.SetParameters(parametros)
                End If
                'Resetear config pagina
                Try
                    'Dim config_pag As PageSettings = .GetPageSettings()
                    'config_pag.PaperSize = GetPaperSize(.PrinterSettings, "A4")
                    .SetPageSettings(NewPageSetting(PageSize))
                Catch e As Exception 'Problema con impresora
                    MsgBox(e.Data, MsgBoxStyle.Exclamation, "Error al configurar la página.")
                End Try
                .RefreshReport()
            End If
        End With
    End Sub
    Public Overloads Sub mostrar(ReportType As String, parametros As Generic.List(Of ReportParameter), DataSource As DataTable(), Optional PageSize As String = "A4")
        With ReporteActual
            If DataSource Is Nothing = False Then
                .LocalReport.DataSources.Clear()
                Dim count As Integer = 0
                For Each dt As DataTable In DataSource
                    Dim ReportDS As New ReportDataSource(dt.TableName, dt)
                    .LocalReport.DataSources.Add(ReportDS)
                Next
            End If
            ReportType = Trim(ReportType)
            If Len(ReportType) >= 7 Then 'OPR\PPE
                .LocalReport.ReportPath = root & "\" & ReportType & ".rdlc"

                '.RefreshReport()
                If parametros Is Nothing = False Then
                    .LocalReport.SetParameters(parametros)
                End If
                'Resetear config pagina
                Try
                    'Dim config_pag As PageSettings = .GetPageSettings()
                    'config_pag.PaperSize = GetPaperSize(.PrinterSettings, "A4")
                    .SetPageSettings(NewPageSetting(PageSize))
                Catch e As Exception 'Problema con impresora
                    MsgBox(e.Data, MsgBoxStyle.Exclamation, "Error al configurar la página.")
                End Try
                .RefreshReport()
            End If
        End With
    End Sub

    ' > Formularios
    ' > > Presentación
    Private Sub MenuPresentacion_Click(sender As Object, e As EventArgs) Handles PlanosDeEdificaciónToolStripMenuItem.Click, PlanosDeMensuraToolStripMenuItem.Click

        If sender Is PlanosDeEdificaciónToolStripMenuItem Then
            mostrar("REPORTES\oprivadas\PPE", True)
        ElseIf sender Is PlanosDeMensuraToolStripMenuItem Then
            mostrar("REPORTES\oprivadas\PPM", True)
        End If

    End Sub
    ' > > Solicitud
    Private Sub MenuSolicitud_Click(sender As Object, e As EventArgs) Handles FinalDeObraToolStripMenuItem.Click, InspecciónToolStripMenuItem.Click,
                                                                              LíneaMunicipalToolStripMenuItem.Click, PrórrogaToolStripMenuItem.Click,
                                                                              MediciónToolStripMenuItem.Click, ActividadComercialToolStripMenuItem.Click,
                                                                              AutomotorToolStripMenuItem.Click, AutomotorConDDJJToolStripMenuItem.Click,
                                                                              UsoGeneralToolStripMenuItem.Click, NotaDePedidoToolStripMenuItem.Click

        If sender Is FinalDeObraToolStripMenuItem Then
            mostrar("REPORTES\oprivadas\SFO", True)
        ElseIf sender Is InspecciónToolStripMenuItem Then
            mostrar("REPORTES\oprivadas\SIN", True)
        ElseIf sender Is LíneaMunicipalToolStripMenuItem Then
            mostrar("REPORTES\oprivadas\SLM", True)
        ElseIf sender Is PrórrogaToolStripMenuItem Then
            mostrar("REPORTES\oprivadas\SPR", True)
        ElseIf sender Is MediciónToolStripMenuItem Then
            mostrar("REPORTES\oprivadas\SMT", True)
        ElseIf sender Is ActividadComercialToolStripMenuItem Then
            mostrar("REPORTES\gobierno\SIC", True)
        ElseIf sender Is AutomotorToolStripMenuItem Then
            mostrar("REPORTES\gobierno\SIA", True)
        ElseIf sender Is AutomotorConDDJJToolStripMenuItem Then
            mostrar("REPORTES\gobierno\SID", True)
        ElseIf sender Is UsoGeneralToolStripMenuItem Then
            mostrar("REPORTES\gobierno\SUG", True)
        ElseIf sender Is NotaDePedidoToolStripMenuItem Then
            mostrar("REPORTES\opublicas\NOP", True)
        End If
    End Sub

    ' > > Constancia
    Private Sub MenuConstancia_Click(sender As Object, e As EventArgs) Handles FinalDeObraToolStripMenuItem1.Click, LíneaMunicipalToolStripMenuItem1.Click
        If sender Is FinalDeObraToolStripMenuItem1 Then
            mostrar("REPORTES\oprivadas\CFO", True)
        ElseIf sender Is LíneaMunicipalToolStripMenuItem1 Then
            Dim param As New Generic.List(Of ReportParameter)
            Dim razon As String = InputBox("Ingresar Razon Social", "Ingresar Razon Social", "APELLIDO, NOMBRE")
            If Len(razon) > 4 Then
                param.Add(New ReportParameter("razon", razon))
                mostrar("REPORTES\oprivadas\CLM", param)
            End If
        End If
    End Sub

    Private Sub CerrarFormularioActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarFormToolStripMenuItem.Click
        ReporteActual.Visible = False
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class