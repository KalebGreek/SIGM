Public Class ConvertirSIRO
    Dim var_PadronAgua(), var_PadronAuto(), var_PadronCatastro(), var_PadronCementerio(),
        var_PadronComercio(), var_PadronVivienda() As String
    Dim var_DeudaAgua(), var_DeudaAuto(), var_DeudaCatastro(), var_DeudaCementerio(),
        var_DeudaComercio(), var_DeudaVivienda() As String



    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        MenuStrip2.BackColor = ColorHacienda
        'Padrón
        'Deuda: tipo, codigo, periodo, cuota, vence1, vence2, vence3, importe1, importe2, importe3
        ' Add any initialization after the InitializeComponent() call.
        'Variables padrón contribuyentes
        var_PadronAgua = {"aguas", "10", "aguas.tenedor"}
        var_PadronAuto = {"automovil", "20", "automovil.tenedor"}
        var_PadronCatastro = {"catastro", "30", "catastro.tenedor"}
        var_PadronCementerio = {"sepelio", "40", "sepelio.tenedor"}
        var_PadronComercio = {"comercio", "50", "comercio.fantasia"}
        var_PadronVivienda = {"barrios", "60", "barrios.tenedor"}

        'Variables deuda contribuyentes
        var_DeudaAgua = {"agucue", "agucue.periodo", "agucue.mes", "agucue.original", "agucue.vencio", "agucue.pagado", "11", "12", "13"}
        var_DeudaAuto = {"autocue", "autocue.ano", "autocue.cuota", "autocue.total", "autocue.vencimi1", "autocue.apagado", "21", "22", "23"}
        var_DeudaCatastro = {"catcue", "catcue.periodo", "catcue.mes", "catcue.original", "catcue.vencio", "catcue.pagado", "31", "32", "33"}
        var_DeudaCementerio = {"sepecue", "sepecue.periodo", "sepecue.mes", "sepecue.original", "sepecue.vencio", "sepecue.pagado", "41", "42", "43"}
        var_DeudaComercio = {"comcue", "comcue.ano", "comcue.bimestre", "comcue.total", "comcue.vence1", "comcue.pagado", "51", "52", "53"}
        var_DeudaVivienda = {"barcue", "barcue.periodo", "barcue.mes", "barcue.original", "barcue.vencio", "barcue.pagado", "61", "62", "63"}

    End Sub

    'RUTINAS
    Sub CargarPadronMunici(servicio As Object)
        Dim var_padron(2) As String

        If servicio Is PadronAgua Then
            var_padron = var_PadronAgua
        ElseIf servicio Is PadronAuto Then
            var_padron = var_PadronAuto
        ElseIf servicio Is PadronCatastro Then
            var_padron = var_PadronCatastro
        ElseIf servicio Is PadronCementerio Then
            var_padron = var_PadronCementerio
        ElseIf servicio Is PadronComercio Then
            var_padron = var_PadronComercio
        ElseIf servicio Is PadronVivienda Then
            var_padron = var_PadronVivienda
        End If

        Dim sql(5) As String
        sql(0) = "SELECT (" & var_padron(1) & "*1000000)+codigo as NroCliente, razon as Descripcion, 
                         " & var_padron(2) & " as Complemento, mail as CorreoElectronico"
        sql(1) = "FROM " & var_padron(0)
        sql(2) = "WHERE codigo>0 AND mail LIKE '%@%'"

        Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
        CtrlMan.DataGridViewTools.Load(DataView, bs, dtab)

    End Sub

    Sub CargarDeudaMunici(servicio As ToolStripMenuItem, moroso As Boolean)
        Dim sql(5) As String
        Dim dtab_numeros As New DataTable
        Dim dtab_mora As New DataTable
        Dim dtab_corriente As New DataTable
        Dim dtab_total As New DataTable
        Dim var_Padron(2) As String
        Dim var_Deuda(5) As String
        Dim tabla_padron, tabla_deuda, id_servicio, importe1, vence_original, vence_mora, valor_mora, pagado As String

        If servicio.Name.Contains("Agua") Then
            var_Padron = var_PadronAgua
            var_Deuda = var_DeudaAgua
        ElseIf servicio.Name.Contains("Auto") Then
            var_Padron = var_PadronAuto
            var_Deuda = var_DeudaAuto
        ElseIf servicio.Name.Contains("Catastro") Then
            var_Padron = var_PadronCatastro
            var_Deuda = var_DeudaCatastro
        ElseIf servicio.Name.Contains("Cementerio") Then
            var_Padron = var_PadronCementerio
            var_Deuda = var_DeudaCementerio
        ElseIf servicio.Name.Contains("Comercio") Then
            var_Padron = var_PadronComercio
            var_Deuda = var_DeudaComercio
        ElseIf servicio.Name.Contains("Vivienda") Then
            var_Padron = var_PadronVivienda
            var_Deuda = var_DeudaVivienda
        End If

        tabla_padron = var_Padron(0)
        tabla_deuda = var_Deuda(0)

        id_servicio = var_Padron(1)
        importe1 = var_Deuda(3)
        vence_original = var_Deuda(4)
        vence_mora = Today.Month & "/" & Date.DaysInMonth(Today.Year, Today.Month) & "/" & Today.Year
        pagado = var_Deuda(5)

        If moroso Then
            'Obtener deuda con mora al día, a 15 días y a 30 días
            sql(0) = "SELECT mora FROM numeros"
            dtab_numeros = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
            valor_mora = Replace((dtab_numeros.Rows(0)("mora") / 30) / 100, ",", ".")

            sql(0) = "SELECT " & id_servicio & "*1000000+" & tabla_deuda & ".codigo as NroCliente,{" & vence_mora & "} as Vto1, 
                        SUM(" & importe1 & "+FLOOR(" & importe1 & "*({" & vence_mora & "}-" & vence_original & ")*" & valor_mora & ")) as Monto1"
            sql(1) = "FROM " & tabla_deuda & " INNER JOIN " & tabla_padron & " 
                    ON " & tabla_deuda & ".codigo=" & tabla_padron & ".codigo"
            'No se sobrescribe la fecha de deudas no vencidas
            sql(2) = "WHERE " & tabla_deuda & ".codigo>0 AND " & importe1 & ">0 AND " & vence_original & "<DATE() 
                    AND " & pagado & "=0 AND " & tabla_padron & ".mail LIKE '%@%'"
            sql(3) = "GROUP BY " & tabla_deuda & ".codigo"
            dtab_mora = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

            If dtab_mora Is Nothing = False Then
                dtab_total = dtab_mora
            End If
        Else
            sql(0) = "SELECT " & id_servicio & "*1000000+" & tabla_deuda & ".codigo as NroCliente, " & vence_original & " as Vto1, 
                     " & importe1 & " as Monto1"
            sql(1) = "FROM " & tabla_deuda & " INNER JOIN " & tabla_padron & " 
                    ON " & tabla_deuda & ".codigo=" & tabla_padron & ".codigo"
            'No se sobrescribe la fecha de deudas no vencidas
            sql(2) = "WHERE " & tabla_deuda & ".codigo>0 AND " & importe1 & ">0 AND " & vence_original & "=>DATE() 
                    AND " & pagado & "=0 AND " & tabla_padron & ".mail LIKE '%@%'"
            dtab_corriente = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)

            If dtab_corriente Is Nothing = False Then
                dtab_total = dtab_corriente
            End If
        End If

        CtrlMan.DataGridViewTools.Load(DataView, bs, dtab_total)
    End Sub

    Sub CargarNovedadesSIRO()
        Dim result As DialogResult
        Using od As New OpenFileDialog _
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
        End Using
    End Sub



    Sub Guardar()
        'info.Focus() 'Takes away the focus from the dataview, so it saves itself before writing the file
        Using sd As New SaveFileDialog
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
        End Using
    End Sub

    'EVENTOS

    Private Sub CopiarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem1.Click
        DataView.SelectAll()
        Dim dataobj As DataObject = DataView.GetClipboardContent
        If dataobj Is Nothing = False Then
            Clipboard.SetDataObject(dataobj)
        End If
        DataView.ClearSelection()
    End Sub


    Private Sub GenerarPadron_Click(sender As Object, e As EventArgs) _
        Handles PadronAgua.Click, PadronAuto.Click, PadronCatastro.Click,
                PadronCementerio.Click, PadronComercio.Click, PadronVivienda.Click

        CargarPadronMunici(sender)
    End Sub

    Private Sub GenerarMora_Click(sender As Object, e As EventArgs) _
        Handles MoraAgua.Click, MoraAuto.Click, MoraCatastro.Click,
                MoraCementerio.Click, MoraComercio.Click, MoraVivienda.Click

        CargarDeudaMunici(sender, True)
    End Sub

    Private Sub GenerarAgendaPagos_Click(sender As Object, e As EventArgs) _
        Handles DeudaAgua.Click, DeudaAuto.Click, DeudaCatastro.Click,
                DeudaCementerio.Click, DeudaComercio.Click, DeudaVivienda.Click

        CargarDeudaMunici(sender, False)
    End Sub

End Class