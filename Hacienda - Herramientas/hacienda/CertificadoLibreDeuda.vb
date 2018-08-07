Public Class CertificadoLibreDeuda
    Public registro As DataTable
    Public DetalleVencimiento As String
    Public Function ConsultarCuenta(tipo As String, cuenta As Integer) As DataTable
        If tipo.Contains("AGUA") Then
			Return DbMan.read("SELECT * FROM aguas WHERE codigo=" & cuenta, My.Settings.foxcon)
		ElseIf tipo.Contains("AUTO") Then
			Return DbMan.read("SELECT * FROM automovil INNER JOIN tipauto ON automovil.tipo=tipauto.tipo
								WHERE codigo=" & cuenta, My.Settings.foxcon)
		ElseIf tipo.Contains("CATA") Then
			Return DbMan.read("SELECT * FROM catastro 
                                WHERE codigo=" & cuenta, My.Settings.foxcon)
		ElseIf tipo.Contains("CEME") Then
			Return DbMan.read("SELECT * FROM sepelio 
                                WHERE codigo=" & cuenta, My.Settings.foxcon)
		ElseIf tipo.Contains("COME") Then
			Return DbMan.read("SELECT * FROM comercio INNER JOIN comact ON comercio.actividad=comact.actividad 
                                WHERE codigo=" & cuenta, My.Settings.foxcon)
		Else
            Return Nothing
        End If
    End Function
    Private Sub CertificadoLibreDeuda_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Creado.MaxDate = Today
        End If
    End Sub

    Private Sub tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipo.SelectedIndexChanged
        et_cuenta.Visible = False
        Cuenta.Visible = False
        Verificar.Visible = False
        If tipo.SelectedIndex > -1 Then
            et_cuenta.Visible = True
            Cuenta.Visible = True
            Verificar.Visible = True

        End If
    End Sub

    Private Sub Verificar_Click(sender As Object, e As EventArgs) Handles Verificar.Click
        Cuenta.BackColor = Color.FromArgb(255, 195, 185)
        GrupoFecha.Visible = False
        If Cuenta.Value > 0 Then
            registro = ConsultarCuenta(tipo.Text, Cuenta.Value)
            If registro Is Nothing = False Then
                If registro.Rows.Count > 0 Then
                    Cuenta.BackColor = Color.White
                    GrupoFecha.Visible = True
                End If
            End If
        End If
        GrupoCuenta.Enabled = GrupoFecha.Visible.CompareTo(True)
        If tipo.Text.Contains("AUTO") Then
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

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        If registro Is Nothing = False Then
            Dim parametros As New Generic.List(Of ReportParameter)
            parametros = ParamReporte.LibreDeuda.DetalleVencimiento(parametros, Creado, Vence, OpcionExento.Checked,
                                                                    OpcionMes.Checked, Mes, OpcionTrim.Checked, Trimestre.Text)
            With tipo.Text
                If tipo.Text.Contains("AGUA") Then
					parametros = ParamReporte.Agua(registro(0), parametros)
					Dim certificado As New VisorReporte("Imprimir Certificado de Libre Deuda", "HACIENDA\REPORTES\LAG", parametros, Nothing, False)
					certificado.ShowDialog()
                ElseIf tipo.Text.Contains("AUTO") Then
					parametros = ParamReporte.Automotor(registro(0), parametros, SinBaja.Checked)

					Dim OpcionBaja As Integer
                    If BajaRadicacion.Checked Then
                        OpcionBaja = 1
                    ElseIf BajaDenuncia.Checked Then
                        OpcionBaja = 2
                    ElseIf BajaDestruccion.Checked Then
                        OpcionBaja = 3
                    End If

                    parametros = ParamReporte.LibreDeuda.DetalleAuto(parametros, OpcionBaja, FechaBaja)
					Dim certificado As New VisorReporte("Imprimir Certificado de Libre Deuda", "HACIENDA\REPORTES\LAU", parametros, Nothing, False)
					certificado.ShowDialog()
                    ElseIf tipo.Text.Contains("CATA") Then
					parametros = ParamReporte.Catastro(registro(0), parametros)
					Dim certificado As New VisorReporte("Imprimir Certificado de Libre Deuda", "HACIENDA\REPORTES\LCA", parametros, Nothing, False)
					certificado.ShowDialog()
                    ElseIf tipo.Text.Contains("CEME") Then
					parametros = ParamReporte.Cementerio(registro(0), parametros)
					Dim certificado As New VisorReporte("Imprimir Certificado de Libre Deuda", "HACIENDA\REPORTES\LCE", parametros, Nothing, False)
					certificado.ShowDialog()
                    ElseIf tipo.Text.Contains("COME") Then
					parametros = ParamReporte.Comercio(registro(0), parametros)
					Dim certificado As New VisorReporte("Imprimir Certificado de Libre Deuda", "HACIENDA\REPORTES\LCO", parametros, Nothing, False)
					certificado.ShowDialog()
                End If
            End With

            Me.Close()
        End If
    End Sub
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        registro = Nothing
        Me.Close()
    End Sub


End Class

