Imports Microsoft.Reporting.WinForms
Class CertificadoLibreDeuda
    'Public registro As DataTable
    'Dim DetalleVencimiento As String

    'Routines
    Public Function ConsultarCuenta(tipo As String, cuenta As Integer) As DataTable
        Dim sql(5) As String

        If tipo.Contains("AGUA") Then
            sql(0) = "SELECT razon, calle, barrio, localidad, provincia, postal,
						 codigo, alta, catastro, ubicacion, reparto,
						 potable, comercial"
            sql(1) = "FROM aguas"
            sql(2) = "WHERE codigo=" & cuenta

        ElseIf tipo.Contains("AUTO") Then
            sql(0) = "SELECT razon, calle, barrio, localidad, provincia, postal,
						 codigo, incorpora, baja, modelo, peso, marca, motor, chassis,
						 tipauto.describo as describo, anterior, letrahoy, numerohoy"
            sql(1) = "FROM automovil INNER JOIN tipauto ON automovil.tipo=tipauto.tipo"
            sql(2) = "WHERE codigo=" & cuenta

        ElseIf tipo.Contains("CATA") Then
            sql(0) = "SELECT razon, docume, calle, barrio, localidad, provincia, postal,
						codigo, alta, catastro, ubicacion, frente1, frente2, frente3, frente4,
						jubilado, baldio"
            sql(1) = "FROM catastro"
            sql(2) = "WHERE codigo=" & cuenta

        ElseIf tipo.Contains("CEME") Then
            sql(0) = "SELECT razon, calle, barrio, localidad, provincia, postal,
						sepevar.tipo as tipo, codigo, alta, ubicacion, numero, fila, sector, lugares,
						espacio, difunto1, difunto2, difunto3, difunto4, difunto5,
						difunto6, difunto7, difunto8, difunto9, difunto10, sepelio.jubilado as jubilado"
            sql(1) = "FROM sepelio INNER JOIN sepevar ON sepelio.tipo=sepevar.orden"
            sql(2) = "WHERE codigo=" & cuenta

        ElseIf tipo.Contains("COME") Then
            sql(0) = "SELECT razon, domicilio, localidad, codigo, comact.detalle as detalle, docume,
						brutos, inscripto, baja, acta"
            sql(1) = "FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad"
            sql(2) = "WHERE codigo=" & cuenta
        End If
        Return DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
    End Function

    'Events
    Private Sub CertificadoLibreDeuda_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Creado.MaxDate = Today
        End If
    End Sub

    Private Sub servicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles servicio.SelectedIndexChanged
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
            bs_registro.DataSource = ConsultarCuenta(servicio.Text, Cuenta.Value)
            If bs_registro.Position > -1 Then
                Cuenta.BackColor = Color.White
                GrupoFecha.Visible = True
                razon.Text = bs_registro.Current("razon")
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
        If bs_registro.Position > -1 Then
            Dim ReportType As String = ""
            Dim parametros As New Generic.List(Of ReportParameter)
            parametros = ParametrosReporte.LibreDeuda.DetalleVencimiento(parametros, Creado, Vence, OpcionExento.Checked,
                                                                    OpcionMes.Checked, Mes, OpcionTrim.Checked, Trimestre.Text)
            With servicio.Text
                If servicio.Text.Contains("AGUA") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaAgua"
                    parametros = ParametrosReporte.Agua(bs_registro.DataSource(0), parametros)

                ElseIf servicio.Text.Contains("AUTO") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaAuto"
                    parametros = ParametrosReporte.Automotor(bs_registro.DataSource(0), parametros, SinBaja.Checked)

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
                    parametros = ParametrosReporte.Catastro(bs_registro.DataSource(0), parametros)

                ElseIf servicio.Text.Contains("CEME") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaCeme"
                    parametros = ParametrosReporte.Cementerio(bs_registro.DataSource(0), parametros)

                ElseIf servicio.Text.Contains("COME") Then
                    ReportType = "REPORTES\HACIENDA\LibreDeudaCome"
                    parametros = ParametrosReporte.Comercio(bs_registro.DataSource(0), parametros)

                End If

                If ReportType <> "" Then
                    Using certificado As New Formularios("Imprimir Certificado de Libre Deuda")
                        certificado.mostrar(ReportType, parametros)
                        certificado.ShowDialog()
                    End Using
                End If
            End With

            Me.Close()
        End If
    End Sub
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        bs_registro.DataSource = Nothing
        Me.Close()
    End Sub


End Class

