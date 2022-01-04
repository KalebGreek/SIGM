Public Class CalcAnualImpUI
    Dim cuentas_modificadas As Integer
    Dim total_cuotas As Integer

    'Eventos
    Private Sub CalculoAnualImpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        periodo.Maximum = Today.Year + 5
        periodo.Minimum = 1990
        periodo.Value = Today.Year

        bs_variables.DataSource = DbMan.ReadDB("SELECT * FROM numeros", My.Settings.foxConnection)
    End Sub

    Private Sub Impuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles impuesto.SelectedIndexChanged
        Dim source As DataRowView = bs_variables.Current
        tae.Text = 0
        If impuesto.Text = "COMERCIO" Then
            tae.Text = source("taecom").ToString
        ElseIf impuesto.Text = "CATASTRO" Then
            tae.Text = source("taecat").ToString
        End If
        tae.Text += "%"
    End Sub

    Private Sub Iniciar_Click(sender As Object, e As EventArgs) Handles iniciar.Click
        Dim time_start, time_end As DateTime
        Dim run_time As TimeSpan
        time_start = Now
        iniciar.Visible = False
        Validar()
        iniciar.Visible = True
        time_end = Now
        run_time = time_end - time_start
        info.Text += Chr(13) & "Procesado en " & run_time.Minutes & " minuto/s, " & run_time.Seconds & " segundo/s."
    End Sub


    'Rutinas
    Public Sub Validar()
        Dim dtab As DataTable = DbMan.ReadDB("SELECT MAX(codigo) as codigo FROM " & impuesto.Text, My.Settings.foxConnection)
        If dtab.Rows.Count > 0 Then
            If CuentaInicial.Value > dtab.Rows(0)("codigo").ToString Then
                MsgBox("No se encuentra la cuenta inicial.", MsgBoxStyle.OkOnly, Nothing)
            Else
                info.Text = "Leyendo datos.."
                info.Refresh()
                'Generar cuotas
                If impuesto.Text = "AGUAS" Then
                    CalcAnualImp.Sql.Agua.CalcularCuota(bs_variables, CuentaInicial.Value, periodo.Value, info, progreso)
                ElseIf impuesto.Text = "AUTOMOVIL" Then
                    CalcAnualImp.Sql.Auto.CalcularCuota(bs_variables, CuentaInicial.Value, periodo.Value, info, progreso)
                ElseIf impuesto.Text = "CATASTRO" Then
                    CalcAnualImp.Sql.Catastro.CalcularCuota(bs_variables, CuentaInicial.Value, periodo.Value, info, progreso)
                ElseIf impuesto.Text = "COMERCIO" Then
                    CalcAnualImp.Sql.Comercio.CalcularCuota(bs_variables, CuentaInicial.Value, periodo.Value, info, progreso)
                ElseIf impuesto.Text = "SEPELIO" Then
                    CalcAnualImp.Sql.Sepelio.CalcularCuota(bs_variables, CuentaInicial.Value, periodo.Value, info, progreso)
                End If
            End If
        End If
    End Sub


End Class