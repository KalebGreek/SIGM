Public Class ConvertirSIRO
    Dim var_padron_agua(), var_padron_auto(), var_padron_catastro(), var_padron_cementerio(),
        var_padron_comercio(), var_padron_vivienda() As String
    Dim var_deuda_agua(), var_deuda_auto(), var_deuda_catastro(), var_deuda_cementerio(),
        var_deuda_comercio(), var_deuda_vivienda() As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        'Padrón
        'Deuda: tipo, codigo, periodo, cuota, vence1, vence2, vence3, importe1, importe2, importe3
        ' Add any initialization after the InitializeComponent() call.
        'Variables padrón contribuyentes
        var_padron_agua = {"aguas", "10", "tenedor"}
        var_padron_auto = {"automovil", "20", "tenedor"}
        var_padron_catastro = {"catastro", "30", "tenedor"}
        var_padron_cementerio = {"sepelio", "40", "tenedor"}
        var_padron_comercio = {"comercio", "50", "fantasia"}
        var_padron_vivienda = {"barrios", "60", "tenedor"}

        'Variables deuda contribuyentes
        var_deuda_agua = {"agucue", "periodo", "mes", "original", "vencio", "11", "12", "13"}
        var_deuda_auto = {"autocue", "ano", "cuota", "original", "vencio", "21", "22", "23"}
        var_deuda_catastro = {"catcue", "periodo", "mes", "original", "vencio", "31", "32", "33"}
        var_deuda_cementerio = {"sepecue", "periodo", "mes", "original", "vencio", "41", "42", "43"}
        var_deuda_comercio = {"comcue", "ano", "bimestre", "original", "vencio", "51", "52", "53"}
        var_deuda_vivienda = {"barcue", "periodo", "mes", "original", "vencio", "61", "62", "63"}

    End Sub

    'RUTINAS
    Sub SIRO_GenerarID(var_deuda As String())
        Dim sql(0) As String
        Dim tabla, periodo, cuota, id_corriente, id_mora, id_plan As String
        Dim dtab As New DataTable
        info.Text = "Procesando '" & var_deuda(0) & "'.."
        StatusStrip1.Update()
        'reemplazar valores nulos en campo "pago"
        'Buscar cuotas, generar id único por cuota
        '1020190100001
        tabla = var_deuda(0)
        periodo = var_deuda(1)
        cuota = var_deuda(2)
        id_corriente = var_deuda(5)
        id_mora = var_deuda(6)
        id_plan = var_deuda(7)

        'Liquidación año corriente (10)
        sql(0) = "UPDATE " & tabla & "
                     SET link=(" & id_corriente & "*10^11) + (codigo*10^6) +
                              (" & periodo & " * 100) + " & cuota & "
                   WHERE codigo>0 AND " & periodo & "=>" & Today.Year & " 
                     AND tipo='N'"
        DbMan.editDB(Nothing, My.Settings.foxConnection, sql(0))
        progreso.PerformStep()
        StatusStrip1.Update()

        'Liquidación años anteriores (11)
        sql(0) = "UPDATE " & tabla & "
                     SET link=(" & id_mora & "*10^11) + (codigo*10^6) +
                              (" & periodo & " * 100) + " & cuota & "
                   WHERE codigo>0 AND " & periodo & "<" & Today.Year & " 
                     AND tipo='N'"
        DbMan.editDB(Nothing, My.Settings.foxConnection, sql(0))
        progreso.PerformStep()
        StatusStrip1.Update()

        'Liquidación plan de pagos (12)
        sql(0) = "UPDATE " & tabla & "
                     SET link=(" & id_plan & "*(10^11)) + (codigo*10^6) +
                              (" & periodo & " * 100) + " & cuota & "
                   WHERE codigo>0 AND " & periodo & ">0
                     AND tipo<>'N'"
        DbMan.editDB(Nothing, My.Settings.foxConnection, sql(0))
        progreso.PerformStep()
        StatusStrip1.Update()
    End Sub

    Sub CargarPadronMunici(var_padron As String())
        Dim sql(5) As String
        sql(0) = "SELECT (" & var_padron(1) & "*1000000)+codigo as NroCliente, razon as Descripcion, 
                         " & var_padron(2) & " as Complemento, mail as CorreoElectronico"
        sql(1) = "FROM " & var_padron(0)
        sql(2) = "WHERE codigo>0"

        Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
        CtrlMan.LoadDataGridView(DataView, bs,, dtab)

    End Sub

    Sub CargarDeudaMunici(var_padron As String(), var_deuda As String())
        Dim sql(5) As String
        Dim dtab As DataTable
        Dim tabla, id_servicio, importe1, vence1, valor_mora As String
        tabla = var_deuda(0)
        id_servicio = var_padron(1)
        importe1 = var_deuda(3)
        vence1 = var_deuda(4)

        'Obtener valor de mora
        sql(0) ="SELECT mora FROM numeros"
        dtab =DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
        valor_mora = Replace((dtab(0)("mora") / 30) / 100, ",", ".")

        sql(0) = "SELECT " & id_servicio & "*(1000000)+codigo as NroCliente,
                 link as NroPago, " & vence1 & " as Vto1, " & importe1 & " as Monto1,
                 " & vence1 & "+30 as Vto2, " & importe1 & "+ FLOOR(" & importe1 & "*30*" & valor_mora & ") as Monto2,
                 " & vence1 & "+60 as Vto3, " & importe1 & "+ FLOOR(" & importe1 & "*60*" & valor_mora & ") as Monto3"

        sql(1) = "FROM " & tabla
        sql(2) = "WHERE codigo>0 AND " & importe1 & ">0"

        dtab = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
        CtrlMan.LoadDataGridView(DataView, bs,, dtab)
    End Sub

    Sub CargarNovedadesSIRO()
        Dim result As DialogResult
        Dim od As New OpenFileDialog _
            With {.CheckFileExists = True,
                  .Filter = "txt|*.txt",
                  .DefaultExt = ".txt",
                  .InitialDirectory = Environment.SpecialFolder.Desktop}

        result = od.ShowDialog()
        If result = DialogResult.OK Then
            If od.FileName <> "" And Len(od.FileName) > 4 Then
                info.Text = od.FileName
            End If
        End If
    End Sub

    Sub Guardar()
        'info.Focus() 'Takes away the focus from the dataview, so it saves itself before writing the file
        Dim sd As New SaveFileDialog
        Dim result As DialogResult
        sd.Filter = "txt|*.txt"
        sd.DefaultExt = ".txt"
        sd.InitialDirectory = Environment.SpecialFolder.Desktop
        sd.OverwritePrompt = True
        result = sd.ShowDialog()
        If result = DialogResult.OK Then
            If sd.FileName <> "" And Len(sd.FileName) > 4 Then
                info.Text = ConverterMan.DataTableToSIJCOR(bs.DataSource, sd.FileName)
            End If
        End If
    End Sub

    'EVENTOS
    Private Sub GenerarIDÚnicoMuniciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarIDÚnicoMuniciToolStripMenuItem.Click
        progreso.Value = 0
        progreso.Maximum = 18 '(6 servicios * 3 pasos)
        SIRO_GenerarID(var_deuda_agua)
        SIRO_GenerarID(var_deuda_auto)
        SIRO_GenerarID(var_deuda_catastro)
        SIRO_GenerarID(var_deuda_cementerio)
        SIRO_GenerarID(var_deuda_comercio)
        SIRO_GenerarID(var_deuda_vivienda)
        info.Text = "Terminado."
    End Sub

    Private Sub PadronAgua_Click(sender As Object, e As EventArgs) Handles PadronAgua.Click
        CargarPadronMunici(var_padron_agua)
    End Sub
    Private Sub PadronAuto_Click(sender As Object, e As EventArgs) Handles PadronAuto.Click
        CargarPadronMunici(var_padron_auto)
    End Sub
    Private Sub PadronCatastro_Click(sender As Object, e As EventArgs) Handles PadronCatastro.Click
        CargarPadronMunici(var_padron_catastro)
    End Sub
    Private Sub PadronCementerio_Click(sender As Object, e As EventArgs) Handles PadronCementerio.Click
        CargarPadronMunici(var_padron_cementerio)
    End Sub
    Private Sub PadronComercio_Click(sender As Object, e As EventArgs) Handles PadronComercio.Click
        CargarPadronMunici(var_padron_comercio)
    End Sub
    Private Sub PadronViviendas_Click(sender As Object, e As EventArgs) Handles PadronViviendas.Click
        CargarPadronMunici(var_padron_vivienda)
    End Sub

    Private Sub AguaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudaAgua.Click
        CargarDeudaMunici(var_padron_agua, var_deuda_agua)
    End Sub
    Private Sub AutomotorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudaAuto.Click
        CargarDeudaMunici(var_padron_auto, var_deuda_auto)
    End Sub
    Private Sub CatastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudaCatastro.Click
        CargarDeudaMunici(var_padron_catastro, var_deuda_catastro)
    End Sub
    Private Sub CementerioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudaCementerio.Click
        CargarDeudaMunici(var_padron_cementerio, var_deuda_cementerio)
    End Sub
    Private Sub ComercioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudaComercio.Click
        CargarDeudaMunici(var_padron_comercio, var_deuda_comercio)
    End Sub
    Private Sub PlanViviendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudaViviendas.Click
        CargarDeudaMunici(var_padron_vivienda, var_deuda_vivienda)
    End Sub


End Class