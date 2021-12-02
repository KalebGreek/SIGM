Imports Microsoft.Reporting.WinForms
Class Formularios

    Public Sub New(Optional titulo As String = "Informe")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddMenuHandlers(top_menu)
        Me.Text = titulo
    End Sub
    Public Overloads Sub AddMenuHandlers(source As MenuStrip)
        For Each i In source.Items
            If TypeOf i Is ToolStripMenuItem Then
                If CType(i, ToolStripMenuItem).DropDownItems.Count < 1 Then 'Ultimo item en el submenu
                    AddHandler CType(i, ToolStripMenuItem).Click, AddressOf MenuList
                Else
                    AddMenuHandlers(i)
                End If
            End If
        Next
    End Sub
    Public Overloads Sub AddMenuHandlers(source As ToolStripMenuItem)
        For Each i In source.DropDownItems
            If TypeOf i Is ToolStripMenuItem Then
                If CType(i, ToolStripMenuItem).DropDownItems.Count < 1 Then
                    AddHandler CType(i, ToolStripMenuItem).Click, AddressOf MenuList
                Else
                    AddMenuHandlers(i)
                End If
            End If
        Next
    End Sub

    Private Sub VisorReporte_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ReporteActual.Visible = Me.Visible
    End Sub

    'Rutinas

    Private Sub MenuList(sender As ToolStripMenuItem, e As EventArgs)

        If sender Is clm Then
            Dim param As New List(Of ReportParameter)
            Dim razon As String = InputBox("Ingresar Razon Social", "Ingresar Razon Social", "APELLIDO, NOMBRE")
            If Len(razon) > 4 Then
                param.Add(New ReportParameter("razon", razon))
                Mostrar("REPORTES\clm", param)
            End If
        ElseIf sender Is CerrarFormToolStripMenuItem Then
            ReporteActual.Visible = False
        ElseIf sender Is SalirToolStripMenuItem Then
            ReporteActual.Reset()
            Me.Close()
        Else
            Mostrar("REPORTES\" & sender.Name.ToString)
        End If
    End Sub
    Public Function NewPageSetting(Optional PageSize As String = "A4") As PageSettings
        With ReporteActual
            Dim config_pag As PageSettings = .GetPageSettings()
            config_pag.PaperSize = GetPaperSize(.PrinterSettings, PageSize)
            Return config_pag
        End With
    End Function

    Shared Function GetPaperSize(ByVal p As PrinterSettings, ByVal papName As String) As PaperSize
        GetPaperSize = p.DefaultPageSettings.PaperSize
        For Each papSize As PaperSize In p.PaperSizes
            If papSize.PaperName = papName Then
                GetPaperSize = papSize
                Exit For
            End If
        Next
    End Function

    Public Overloads Sub Mostrar(ReportType As String, Optional PageSize As String = "A4")
        With ReporteActual
            ReportType = Trim(ReportType)
            If Len(ReportType) >= 7 Then 'OPR\PPE
                .LocalReport.ReportPath = root & "\" & ReportType & ".rdlc"
                If File.Exists(.LocalReport.ReportPath) Then
                    'Resetear config pagina
                    Try
                        .SetPageSettings(NewPageSetting(PageSize))
                    Catch e As Exception 'Problema con impresora
                        MsgBox(e.Data, MsgBoxStyle.Exclamation, "Error al configurar la página.")
                    End Try
                    .RefreshReport()
                Else
                    .LocalReport.ReportPath = ""
                End If

            End If
        End With
    End Sub
    Public Overloads Sub Mostrar(ReportType As String, parametros As List(Of ReportParameter), Optional PageSize As String = "A4")
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
    Public Overloads Sub Mostrar(ReportType As String, parametros As List(Of ReportParameter), DataSource As DataTable(), Optional PageSize As String = "A4")
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
End Class