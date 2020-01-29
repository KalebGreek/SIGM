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
    Public Function NewPageSetting() As PageSettings
        With ReporteActual
            Dim config_pag As PageSettings = .GetPageSettings()
            config_pag.PaperSize = GetPaperSize(.PrinterSettings, "A4")
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

    Public Overloads Sub mostrar(ReportType As String, blank As Boolean)
        With ReporteActual
            ReportType = Trim(ReportType)
            If Len(ReportType) >= 7 Then 'OPR\PPE
                .LocalReport.ReportPath = root & "\" & ReportType & ".rdlc"

                'Resetear config pagina
                Try
                    .SetPageSettings(NewPageSetting())
                Catch e As Exception 'Problema con impresora
                    MsgBox(e.Data, MsgBoxStyle.Exclamation, "Error al configurar la página.")
                End Try
                .RefreshReport()
            End If
        End With
    End Sub
    Public Overloads Sub mostrar(ReportType As String, parametros As Generic.List(Of ReportParameter))
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
                    Dim config_pag As PageSettings = .GetPageSettings()
                    config_pag.PaperSize = GetPaperSize(.PrinterSettings, "A4")
                    .SetPageSettings(config_pag)
                Catch e As Exception 'Problema con impresora
                    MsgBox(e.Data, MsgBoxStyle.Exclamation, "Error")
                End Try
                .RefreshReport()
            End If
        End With
    End Sub
    Public Overloads Sub mostrar(ReportType As String, parametros As Generic.List(Of ReportParameter), DataSource As DataTable())
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
                    Dim config_pag As PageSettings = .GetPageSettings()
                    config_pag.PaperSize = GetPaperSize(.PrinterSettings, "A4")
                    .SetPageSettings(config_pag)
                Catch e As Exception 'Problema con impresora
                    MsgBox(e.Data, MsgBoxStyle.Exclamation, "Error")
                End Try
                .RefreshReport()
            End If
        End With
    End Sub



    'Public Overloads Sub mostrar(Optional tipo As String = "",
    '                   Optional parametros As Generic.List(Of ReportParameter) = Nothing,
    '                   Optional blank As Boolean = True)
    '    With ReporteActual
    '        tipo = Trim(tipo)
    '        If Len(tipo) >= 7 Then 'OPR\PPE
    '            .LocalReport.ReportPath = root & "\" & tipo & ".rdlc"

    '            '.RefreshReport()
    '            If blank = False And parametros Is Nothing = False Then
    '                .LocalReport.SetParameters(parametros)
    '            End If
    '            'Resetear config pagina
    '            Try
    '                Dim config_pag As PageSettings = .GetPageSettings()
    '                config_pag.PaperSize = GetPaperSize(.PrinterSettings, "A4")
    '                .SetPageSettings(config_pag)
    '            Catch e As Exception 'Problema con impresora
    '                MsgBox(e.Data, MsgBoxStyle.Exclamation, "Error")
    '            End Try
    '            .RefreshReport()
    '            'Mostrar
    '            .Visible = True
    '        End If
    '    End With
    'End Sub

    ' > Formularios
    ' > > Presentación
    Private Sub MenuPresentacion_Click(sender As Object, e As EventArgs) Handles PlanosDeEdificaciónToolStripMenuItem.Click, PlanosDeMensuraToolStripMenuItem.Click

        If sender Is PlanosDeEdificaciónToolStripMenuItem Then
            mostrar("oprivadas\REPORTES\PPE", True)
        ElseIf sender Is PlanosDeMensuraToolStripMenuItem Then
            mostrar("oprivadas\REPORTES\PPM", True)
        End If

    End Sub
    ' > > Solicitud
    Private Sub MenuSolicitud_Click(sender As Object, e As EventArgs) Handles FinalDeObraToolStripMenuItem.Click, InspecciónToolStripMenuItem.Click,
                                                                              LíneaMunicipalToolStripMenuItem.Click, PrórrogaToolStripMenuItem.Click,
                                                                              MediciónToolStripMenuItem.Click, ActividadComercialToolStripMenuItem.Click,
                                                                              AutomotorToolStripMenuItem.Click, AutomotorConDDJJToolStripMenuItem.Click,
                                                                              UsoGeneralToolStripMenuItem.Click, NotaDePedidoToolStripMenuItem.Click

        If sender Is FinalDeObraToolStripMenuItem Then
            mostrar("oprivadas\REPORTES\SFO", True)
        ElseIf sender Is InspecciónToolStripMenuItem Then
            mostrar("oprivadas\REPORTES\SIN", True)
        ElseIf sender Is LíneaMunicipalToolStripMenuItem Then
            mostrar("oprivadas\REPORTES\SLM", True)
        ElseIf sender Is PrórrogaToolStripMenuItem Then
            mostrar("oprivadas\REPORTES\SPR", True)
        ElseIf sender Is MediciónToolStripMenuItem Then
            mostrar("oprivadas\REPORTES\SMT", True)
        ElseIf sender Is ActividadComercialToolStripMenuItem Then
            mostrar("gobierno\REPORTES\SIC", True)
        ElseIf sender Is AutomotorToolStripMenuItem Then
            mostrar("gobierno\REPORTES\SIA", True)
        ElseIf sender Is AutomotorConDDJJToolStripMenuItem Then
            mostrar("gobierno\REPORTES\SID", True)
        ElseIf sender Is UsoGeneralToolStripMenuItem Then
            mostrar("gobierno\REPORTES\SUG", True)
        ElseIf sender Is NotaDePedidoToolStripMenuItem Then
            mostrar("opublicas\REPORTES\NOP", True)
        End If
    End Sub

    ' > > Constancia
    Private Sub MenuConstancia_Click(sender As Object, e As EventArgs) Handles FinalDeObraToolStripMenuItem1.Click, LíneaMunicipalToolStripMenuItem1.Click
        If sender Is FinalDeObraToolStripMenuItem1 Then
            mostrar("oprivadas\REPORTES\CFO", True)
        ElseIf sender Is LíneaMunicipalToolStripMenuItem1 Then
            Dim param As New Generic.List(Of ReportParameter)
            Dim razon As String = InputBox("Ingresar Razon Social", "Ingresar Razon Social", "APELLIDO, NOMBRE")
            If Len(razon) > 4 Then
                param.Add(New ReportParameter("razon", razon))
                mostrar("oprivadas\REPORTES\CLM", param)
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