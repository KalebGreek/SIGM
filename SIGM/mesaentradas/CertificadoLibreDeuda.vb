Imports Microsoft.Reporting.WinForms
Class CertificadoLibreDeuda
    Dim agua, auto, catastro, sepelio, comercio As DataTable
    Dim resultado As DataRow
    'Dim DetalleVencimiento As String

    'Routines
    Public Sub ObtenerCuentas()
        Dim sqlSelect As String
        sqlSelect = "SELECT razon, calle, barrio, localidad, provincia, postal,
						    codigo, alta, catastro, ubicacion, reparto,
						    potable, comercial
                       FROM aguas"
        agua = ReadDB(sqlSelect, My.Settings.foxConnection)

        sqlSelect = "SELECT razon, calle, barrio, localidad, provincia, postal,
						    codigo, incorpora, baja, modelo, peso, marca, motor, chassis,
						    tipauto.describo as describo, anterior, letrahoy, numerohoy
                       FROM automovil INNER JOIN tipauto ON automovil.tipo=tipauto.tipo"
        auto = ReadDB(sqlSelect, My.Settings.foxConnection)

        sqlSelect = "SELECT razon, docume, calle, barrio, localidad, provincia, postal,
						    codigo, alta, catastro, ubicacion, frente1, frente2, frente3, frente4,
						    jubilado, baldio 
                       FROM catastro"
        catastro = ReadDB(sqlSelect, My.Settings.foxConnection)

        sqlSelect = "SELECT razon, calle, barrio, localidad, provincia, postal,
						    sepevar.tipo as tipo, codigo, alta, ubicacion, numero, fila, sector, lugares,
						    espacio, difunto1, difunto2, difunto3, difunto4, difunto5,
						    difunto6, difunto7, difunto8, difunto9, difunto10, sepelio.jubilado as jubilado 
                       FROM sepelio INNER JOIN sepevar ON sepelio.tipo=sepevar.orden"
        sepelio = ReadDB(sqlSelect, My.Settings.foxConnection)

        sqlSelect = "SELECT razon, domicilio, localidad, codigo, comact.detalle as detalle, docume,
						    brutos, inscripto, baja, acta 
                       FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
        comercio = ReadDB(sqlSelect, My.Settings.foxConnection)

    End Sub
    Public Function ValidarCuenta(tipo As String, cuenta As Integer) As DataRow
        Dim dr As DataRow = Nothing
        If tipo.Contains("AGUA") Then
            dr = agua.Select("codigo=" & cuenta)(0)
        ElseIf tipo.Contains("AUTO") Then
            dr = auto.Select("codigo=" & cuenta)(0)
        ElseIf tipo.Contains("CATA") Then
            dr = catastro.Select("codigo=" & cuenta)(0)
        ElseIf tipo.Contains("CEME") Then
            dr = sepelio.Select("codigo=" & cuenta)(0)
        ElseIf tipo.Contains("COME") Then
            dr = comercio.Select("codigo=" & cuenta)(0)
        End If
        Return dr
    End Function

    'Events
    Private Sub CertificadoLibreDeuda_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Creado.MaxDate = Today
            ObtenerCuentas()
        End If
    End Sub

    Private Sub Servicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles servicio.SelectedIndexChanged
        et_cuenta.Visible = (servicio.SelectedIndex > -1)
        Cuenta.Visible = (servicio.SelectedIndex > -1)
        et_razon.Visible = (servicio.SelectedIndex > -1)
        razon.Visible = (servicio.SelectedIndex > -1)
        Verificar.Visible = (servicio.SelectedIndex > -1)
    End Sub

    Private Sub Verificar_Click(sender As Object, e As EventArgs) Handles Verificar.Click
        Cuenta.BackColor = Color.FromArgb(255, 195, 185)
        GrupoFecha.Visible = False
        razon.Text = ""
        If Cuenta.Value > 0 Then
            resultado = ValidarCuenta(servicio.Text, Cuenta.Value)
            If resultado Is Nothing = False Then
                Cuenta.BackColor = Color.White
                GrupoFecha.Visible = True
                razon.Text = resultado("razon")
            End If
        End If
        GrupoCuenta.Enabled = GrupoFecha.Visible.CompareTo(True)
        If servicio.Text.Contains("AUTO") Then
            GrupoBaja.Visible = GrupoFecha.Visible
        End If
    End Sub

    Private Sub OpcionesBaja(sender As Object, e As EventArgs) Handles SinBaja.CheckedChanged, BajaRadicacion.CheckedChanged, BajaDenuncia.CheckedChanged
        FechaBaja.Visible = False
        FechaBaja.Visible = SinBaja.Checked.CompareTo(True)
        etFechaBaja.Visible = FechaBaja.Visible
    End Sub

    Private Sub OpcionesVencimiento(sender As Object, e As EventArgs) Handles OpcionMes.CheckedChanged, OpcionTrim.CheckedChanged, OpcionExento.CheckedChanged
        Mes.Visible = OpcionMes.Checked
        Trimestre.Visible = OpcionTrim.Checked
        et_vence.Visible = OpcionExento.Checked.CompareTo(True)
        Vence.Visible = et_vence.Visible
    End Sub

    Private Sub Creado_ValueChanged(sender As Object, e As EventArgs)
        Do
            Vence.Value = Creado.Value.AddDays(1)
        Loop Until Vence.Value.DayOfWeek <> DayOfWeek.Saturday _
        Or Vence.Value.DayOfWeek <> DayOfWeek.Sunday
    End Sub
    Private Sub Vence_ValueChanged(sender As Object, e As EventArgs) Handles Vence.ValueChanged
        If OpcionMes.Checked Then
            Mes.Value = Vence.Value
        End If
    End Sub

    Public Sub CrearClick(sender As Object, e As EventArgs) Handles Crear.Click
        If resultado Is Nothing = False Then
            Dim ReportType As String = ""
            Dim parametros As New Generic.List(Of ReportParameter)
            parametros = ParametrosReporte.LibreDeuda.DetalleVencimiento(parametros, Creado, Vence, OpcionExento.Checked,
                                                                    OpcionMes.Checked, Mes, OpcionTrim.Checked, Trimestre.Text)
            With servicio.Text
                If servicio.Text.Contains("AGUA") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaAgua"
                    parametros = ParametrosReporte.Agua(resultado, parametros)

                ElseIf servicio.Text.Contains("AUTO") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaAuto"
                    parametros = ParametrosReporte.Automotor(resultado, parametros, SinBaja.Checked)

                    Dim OpcionBaja As Integer
                    If BajaRadicacion.Checked Then
                        OpcionBaja = 1
                    ElseIf BajaDenuncia.Checked Then
                        OpcionBaja = 2
                    ElseIf BajaDestruccion.Checked Then
                        OpcionBaja = 3
                    End If

                    parametros = ParametrosReporte.LibreDeuda.DetalleAuto(parametros, OpcionBaja, FechaBaja)

                ElseIf servicio.Text.Contains("CATA") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaProp"
                    parametros = ParametrosReporte.Catastro(resultado, parametros)

                ElseIf servicio.Text.Contains("CEME") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaCeme"
                    parametros = ParametrosReporte.Cementerio(resultado, parametros)

                ElseIf servicio.Text.Contains("COME") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaCome"
                    parametros = ParametrosReporte.Comercio(resultado, parametros)

                End If

                If ReportType <> "" Then
                    Using certificado As New Formularios("Imprimir Certificado de Libre Deuda")
                        certificado.Mostrar(ReportType, parametros)
                        certificado.ShowDialog()
                    End Using
                End If
            End With

            Me.Close()
        End If
    End Sub
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub


End Class

