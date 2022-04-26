Imports Microsoft.Reporting.WinForms
Class ModExpediente
    'Public dtab_exp As DataTable
    Property Exp As Integer
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ModExpediente_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            inicio_obra.MaxDate = Date.Today
            fin_obra.MaxDate = Date.Today

            Do
                If Exp = 0 Then
                    Exp = Val(Date.Today.Year) * 10000
                End If
                Exp = Val(InputBox("Ingrese Nº de Expediente", "Seleccionar Expediente", Exp))
                If Exp <> Nothing Then
                    bs_expediente.DataSource = ObrasPrivadas.Expediente.Seleccionar(Exp)
                    If bs_expediente.Count = 0 Then
                        bs_expediente.DataSource = ObrasPrivadas.Expediente.Generar(Exp)
                    End If
                End If
            Loop Until Exp = Nothing Or bs_expediente.DataSource Is Nothing = False
            If Exp = Nothing Then
                Me.Close()
            Else
                ObrasPrivadas.Expediente.Bloquear(bs_expediente.Current("id"), True)
                Cargar(bs_expediente.Current.Row)
            End If
        End If
    End Sub
    Private Sub ModExpediente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If opr_id.Text > 0 And temporal.Visible = False Then
            ObrasPrivadas.Expediente.Bloquear(opr_id.Text, False)
        End If
    End Sub

    '###### GUI #################################################################################################
    ' > Expediente
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Dim answer As MsgBoxResult
        If Actualizar(grupo_exp.SelectedIndex) = MsgBoxResult.Yes Then
            If temporal.Visible Then
                answer = MsgBox("¿Desea guardar este expediente temporal bajo el N° " & expediente.Text & "?",
                                MsgBoxStyle.YesNoCancel, "Guardar Expediente")
                If answer = MsgBoxResult.Yes Then 'Asignar N° de Expediente y quitar temporal
                    DbMan.EditDB("UPDATE oprivadas 
                                     SET expediente=" & expediente.Text & ", temporal=False
                                   WHERE id=" & opr_id.Text)
                    Me.Close()
                End If
            End If
            'bs_expediente.DataSource = ObrasPrivadas.Expediente.Seleccionar(expediente.Text)
            'Cargar(bs_expediente.Current.Row)
        End If
    End Sub

    Private Sub Grupo_exp_TabIndexChanged(sender As Object, e As EventArgs) Handles grupo_exp.TabIndexChanged
        If Me.Visible Then
            bs_expediente.DataSource = ObrasPrivadas.Expediente.Seleccionar(expediente.Text)
            If bs_expediente.DataSource Is Nothing = False Then
                Cargar(bs_expediente.Current.Row)
            End If
        End If
    End Sub

    Private Sub PERSONASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERSONASToolStripMenuItem.Click
        Dim answer As MsgBoxResult = actualizar(grupo_exp.SelectedIndex)
        If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
            grupo_exp.SelectTab(0)
        End If
    End Sub
    Private Sub INMUEBLESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INMUEBLESToolStripMenuItem.Click
        Dim answer As MsgBoxResult = actualizar(grupo_exp.SelectedIndex)
        If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
            grupo_exp.SelectTab(1)
        End If
    End Sub
    Private Sub ARCHIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARCHIVOToolStripMenuItem.Click
        Dim answer As MsgBoxResult = actualizar(grupo_exp.SelectedIndex)
        If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
            grupo_exp.SelectTab(2)
        End If
    End Sub
    '###### END GUI #############################################################################################

    '###### VALIDATION ##########################################################################################
    Private Sub Cargar(registro As DataRow)
        razon.Clear()
        cuil.Clear()
        matricula.Clear()

        With registro
            If registro Is Nothing = False Then
                'Reset
                check_fin_obra.Checked = False
                fin_obra.Value = fin_obra.MinDate
                ruta_fin_obra.Text = ""

                'Estos controles estan fuera de GrupoExp
                opr_id.Text = registro("id")
                temporal.Visible = registro("temporal")
                expediente.Text = registro("expediente")
                '##### EXPEDIENTE (base)
                CtrlMan.LoadControlData(registro, grupoExp)
                'Tareas se carga al reves por alguna razon, asi que no sirve
                tarea.Text = registro("tarea").ToString
                tarea2.Text = registro("tarea2").ToString
                'Mostrar final de obra
                check_fin_obra.Checked = fin_obra.Value > fin_obra.MinDate

                'CARGAR COPIAS DIGITALES
                Using copias As DataTable = FileMan.OPrivadas.BuscarDoc(opr_id.Text, "FINAL DE OBRA")
                    For Each dr As DataRow In copias.Rows
                        ruta_fin_obra.Text = dr("ruta").ToString
                    Next
                End Using

                '##### Cargar personas
                bs_resp.Filter = ""
                bs_resp.Sort = ""
                bs_resp.Position = -1
                bs_resp.DataSource = ObrasPrivadas.Expediente.ListarResponsables(expediente.Text)
                CtrlMan.DataGridViewTools.Load(consulta_resp, bs_resp)
                'INMUEBLES
                bs_catastro.Filter = ""
                bs_catastro.Sort = ""
                bs_catastro.Position = -1
                bs_catastro.DataSource = Catastro.ListarInmueblePorExpediente(expediente.Text)
                CtrlMan.DataGridViewTools.Load(consulta_inmueble, bs_catastro)
                'PROFESIONAL
                profesional_id.Text = registro("profesional_id").ToString

                If profesional_id.Text > 0 Then
                    Dim drow As DataRow = Profesional.Seleccionar(profesional_id.Text, 0)
                    If drow Is Nothing = False Then
                        CtrlMan.LoadControlData(drow, Panel3)
                    End If
                Else
                    MsgBox("Profesional no válido.", MsgBoxStyle.Exclamation)
                    profesional_id.Text = 0
                End If
            End If
        End With
    End Sub

    Private Function Validar(Optional pagina As Integer = -1) As MsgBoxResult
        'Hay que reformatear esto para que salte con actualizar()
        'La idea sería mostrar los datos en un msgbox cuando apretás "guardar".
        'Si todo sale bien, te muestra el resumen y pregunta, si faltan datos esenciales,
        'muestra el resumen pero no deja elegir si guardar o no.
        Dim valido As Boolean
        Dim msg As New List(Of String)

        If pagina = -1 Or pagina = 0 Then
            msg = ObrasPrivadas.Expediente.Validar.Personas(bs_resp, profesional_id.Text)
        End If
        If pagina = -1 Or pagina = 1 Then
            msg.AddRange(ObrasPrivadas.Expediente.Validar.Inmuebles(bs_catastro))
        End If
        If pagina = -1 Or pagina = 2 Then
            msg.AddRange(ObrasPrivadas.Expediente.Validar.Expediente(tarea, tarea2, inicio_obra.Value,
                                                                     recibe.SelectedIndex, check_fin_obra.Checked,
                                                                     fin_obra.Value, ruta_fin_obra.ToString))
        End If


        If pagina < 0 Then
            valido = msg.Count = 3
        Else
            valido = msg.Count = 1
        End If

        If valido Then
            Return MsgBoxResult.Yes
        Else
            Using ver_error As New UIError("Errores en Expediente", msg)
                Dim answer As DialogResult = ver_error.ShowDialog(Me)

                If answer = DialogResult.OK Then
                    Return MsgBoxResult.No
                Else
                    Return MsgBoxResult.Cancel
                End If
            End Using
        End If
    End Function

    'Private Function Validar(Optional pagina As Integer = -1) As MsgBoxResult
    '    'Hay que reformatear esto para que salte con actualizar()
    '    'La idea sería mostrar los datos en un msgbox cuando apretás "guardar".
    '    'Si todo sale bien, te muestra el resumen y pregunta, si faltan datos esenciales,
    '    'muestra el resumen pero no deja elegir si guardar o no.
    '    Dim msg As New List(Of String)

    '    'Personas
    '    If pagina = -1 Or pagina = 0 Then
    '        msg.Add("** PERSONAS **")
    '        If bs_resp.Count = 0 Then
    '            msg.Add("(×) Debe indicar al menos un responsable.")
    '        End If
    '        If profesional_id.Text = 0 Then
    '            msg.Add("(×) Debe indicar un profesional a cargo.")
    '        End If
    '        msg.Add(" ")
    '    End If

    '    If pagina = -1 Or pagina = 1 Then
    '        'Inmuebles
    '        msg.Add("** INMUEBLES **")
    '        With bs_catastro
    '            If .Count = 0 Then
    '                msg.Add("(×) No se agregó un inmueble.")
    '            End If
    '            msg.Add(" ")
    '        End With
    '    End If

    '    If pagina = -1 Or pagina = 2 Then
    '        'Detalles de expediente
    '        msg.Add("** EXPEDIENTE **")
    '        If tarea.SelectedIndex = -1 Then
    '            msg.Add("(×) Seleccione tarea.")
    '        ElseIf tarea.Text = "MENSURA" And tarea2.SelectedIndex = -1 Then
    '            msg.Add("(×) Seleccione detalle de tarea de mensura.")
    '        End If
    '        If inicio_obra.Value > Date.Today Then
    '            msg.Add("(×) La fecha de inicio de obra es inválida.")
    '        End If
    '        If recibe.SelectedIndex = -1 Then
    '            msg.Add("(×) Debe indicar quien recibe el expediente.")
    '        End If
    '        If check_fin_obra.Checked Then
    '            If fin_obra.Value <= inicio_obra.Value Then
    '                msg.Add("(×) La fecha de fin de de obra es inválida.")
    '            End If
    '            If ruta_fin_obra.Text = "" Then
    '                msg.Add("(×) Cargar copia de certificado de Fin de Obra.")
    '            End If
    '        End If
    '        msg.Add(" ")
    '    End If

    '    Dim valido As Integer = msg.FindIndex(Function(value As String)
    '                                              Return value(0) = "("
    '                                          End Function)

    '    If valido > -1 Then
    '        Using ver_error As New UIError("Errores en Expediente", msg)
    '            Dim answer As DialogResult = ver_error.ShowDialog(Me)

    '            If answer = DialogResult.OK Then
    '                Return MsgBoxResult.No
    '            Else
    '                Return MsgBoxResult.Cancel
    '            End If
    '        End Using
    '    Else
    '        Return MsgBoxResult.Yes
    '    End If
    'End Function

    Private Function Actualizar(pagina As Integer) As MsgBoxResult
        Dim result As MsgBoxResult = Validar(pagina)
        If result = MsgBoxResult.Yes Then
            If pagina = 0 Then 'Responsables
                ObrasPrivadas.Expediente.Agregar.Profesional(opr_id.Text, profesional_id.Text)

            ElseIf pagina = 1 Then 'Inmuebles
                'Los cambios se producen en el momento, no es necesario guardar

            ElseIf pagina = 2 Then 'Expediente
                ObrasPrivadas.Expediente.Agregar.Detalle(opr_id.Text, inicio_obra.Value, visado.Checked, fin_obra.Value,
                                                       recibe.Text, tarea.Text, tarea2.Text, Trim(observaciones.Text))

                If (visado.Checked And fin_obra.Value <> fin_obra.MinDate) = False Then
                    FileMan.Limpiar("opr_documento", "opr_id", opr_id.Text, "FINAL DE OBRA")
                End If
            End If
        End If
        Return result
    End Function

    Private Sub Tarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tarea.SelectedIndexChanged
        tarea2.SelectedIndex = -1
        tarea2.Visible = True
        tarea2.Items.Clear()
        If tarea.Text.Contains("MENSURA") Then
            tarea2.Items.Add("CON LOTEO")
            tarea2.Items.Add("DE POSESIÓN")
            tarea2.Items.Add("SIMPLE")
            tarea2.Items.Add("CON SUBDIVISIÓN SIMPLE")
            tarea2.Items.Add("CON UNIÓN")
            tarea2.Items.Add("CON UNIÓN Y LOTEO")
            tarea2.Items.Add("CON UNIÓN Y SUBDIVISIÓN")
        ElseIf tarea.Text.Contains("PROYECTO") Then
            tarea2.Items.Add("DE EDIFICACION")
            tarea2.Items.Add("GENERAL")
        Else
            tarea2.Visible = False
        End If
    End Sub

    Private Sub Visado_CheckedChanged(sender As Object, e As EventArgs) Handles visado.CheckedChanged
        check_fin_obra.Visible = visado.Checked
        check_fin_obra.Checked = False
    End Sub
    Private Sub Check_fin_obra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_fin_obra.CheckedChanged
        With check_fin_obra
            fin_obra.Visible = .Checked
            et_fin_obra.Visible = .Checked
            ruta_fin_obra.Visible = .Checked
            cargar_fin_obra.Visible = .Checked
            ver_fin_obra.Visible = .Checked
        End With
    End Sub
    Private Sub Cargar_fin_obra_Click(sender As Object, e As EventArgs) Handles cargar_fin_obra.Click
        'Selecciona y guarda la copia de Final de Obra en PDF
        Dim ruta As String = FileMan.OPrivadas.CargarFinalObra(opr_id.Text, expediente.Text)
        If ruta <> "" Then
            ruta_fin_obra.Text = ruta
        End If
    End Sub
    Private Sub Ver_fin_obra_Click(sender As Object, e As EventArgs) Handles ver_fin_obra.Click, ruta_fin_obra.DoubleClick
        If Len(ruta_fin_obra.Text) > 5 Then
            Process.Start(root & My.Settings.DocFolderOprivadas & ruta_fin_obra.Text)
        End If
    End Sub

    '# PERSONA 
    Private Sub Add_resp_Click(sender As Object, e As EventArgs) Handles add_resp.Click
        Dim source As DataRowView = Persona.Seleccionar(Me)
        'Se agrega el registro temporal
        If source Is Nothing = False Then
            If ObrasPrivadas.Expediente.Agregar.Responsable(bs_resp.DataSource, opr_id.Text, bs_resp.Current("persona_id")) Then
                Cargar(bs_expediente.Current.Row)
            End If
        End If
    End Sub
    Private Sub Del_resp_Click(sender As Object, e As EventArgs) Handles del_resp.Click
        If bs_resp.Position > -1 _
           And MsgBoxResult.Yes = MsgBox("¿Desea eliminar el responsable seleccionado?", MsgBoxStyle.YesNo, "Eliminar Responsable") Then
            If ObrasPrivadas.Expediente.EliminarResponsable(bs_resp.Current.Row) Then
                Cargar(bs_expediente.Current.Row)
            End If
        End If
    End Sub
    Private Sub Mod_prof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mod_prof.Click
        Dim source As DataRowView = Persona.Seleccionar(Me, "PROFESIONAL")
        If source Is Nothing = False Then
            CtrlMan.LoadControlData(source, Panel3)
        End If
    End Sub

    '# INMUEBLE
    Private Sub Bs_catastro_PositionChanged(sender As Object, e As EventArgs) Handles bs_catastro.PositionChanged
        Dim registro As DataRowView = bs_catastro.Current

        mod_inmueble.Enabled = False
        titular_id.Text = "0"
        info_titular.Text = " - "
        info_cuil.Text = " - "
        info_ubicacion.Text = " - "
        info_barrio.Text = " - "
        info_uso.Text = " - "
        info_cuenta.Text = " - "

        If registro Is Nothing Then
            mod_inmueble.Enabled = True
            titular_id.Text = registro("titular_id")
            info_titular.Text = registro("titular").ToString
            info_cuil.Text = registro("cuil").ToString
            info_ubicacion.Text = registro("calle").ToString & " " & registro("Altura").ToString
            info_barrio.Text = registro("barrio").ToString
            info_uso.Text = registro("uso").ToString
            info_cuenta.Text = registro("cuenta").ToString

            If registro("archivado") Then
                info_estado.Text = "ARCHIVADO"
            Else
                info_estado.Text = "ACTIVO"
            End If
        End If
    End Sub
    Private Sub Add_inmueble_Click(sender As Object, e As EventArgs) Handles add_inmueble.Click
        Using agregar_inmueble As New ModInmueble(opr_id.Text)
            With agregar_inmueble
                .ShowDialog(Me)
                .Dispose()
                'Recargar
                bs_catastro.Filter = ""
                bs_catastro.Sort = ""
                bs_catastro.Position = -1
                bs_catastro.DataSource = Catastro.ListarInmueblePorExpediente(expediente.Text)
                CtrlMan.DataGridViewTools.Load(consulta_inmueble, bs_catastro)
            End With
        End Using
    End Sub
    Private Sub Mod_inmueble_Click(sender As Object, e As EventArgs) Handles mod_inmueble.Click
        Using agregar_inmueble As New ModInmueble(opr_id.Text)
            With agregar_inmueble
                If bs_catastro.Position > -1 Then 'Modificar
                    .zona.Value = bs_catastro.Current("zona")
                    .circ.Value = bs_catastro.Current("circ")
                    .secc.Value = bs_catastro.Current("secc")
                    .manz.Value = bs_catastro.Current("manz")
                    .parc.Value = bs_catastro.Current("parc")
                    .lote.Value = bs_catastro.Current("lote")
                    .ShowDialog(Me)
                    .Dispose()
                    'Recargar
                    bs_catastro.Filter = ""
                    bs_catastro.Sort = ""
                    bs_catastro.Position = -1
                    bs_catastro.DataSource = Catastro.ListarInmueblePorExpediente(expediente.Text)
                    CtrlMan.DataGridViewTools.Load(consulta_inmueble, bs_catastro)
                End If
            End With
        End Using
    End Sub
    Private Sub Del_inmueble_Click(sender As Object, e As EventArgs) Handles del_inmueble.Click
        With bs_catastro
            If .Position > -1 Then
                If CBool(.Current("archivado")).ToString = False _
                And MsgBoxResult.Yes = MsgBox("¿Desea eliminar el inmueble seleccionado? Esta operación no se puede deshacer.", MsgBoxStyle.YesNo, "Eliminar Inmueble") Then
                    Catastro.Eliminar.Inmueble(.Current("catastro_id"), .Current("user_id"))
                    .RemoveCurrent()
                Else
                    MsgBox("Imposible eliminar, este inmueble se encuentra archivado.")
                End If
            End If
        End With
    End Sub
    Private Sub Consulta_inmueble_KeyUp(sender As Object, e As KeyEventArgs) Handles consulta_inmueble.KeyUp
        If e.KeyValue = Keys.Delete Then
            del_inmueble.PerformClick()
        ElseIf e.KeyValue = Keys.F2 Then
            mod_inmueble.PerformClick()
        End If
    End Sub

    '# PAGOS
    Private Sub AgregarDeudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarDeudaToolStripMenuItem.Click
        If temporal.Visible Then
            MsgBox("No se pueden agregar deudas a un expediente temporal.")
        Else
            Using deudas As New ModPago(opr_id.Text, True)
                deudas.ShowDialog()
            End Using
        End If
    End Sub
    Private Sub AgregarPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPagoToolStripMenuItem.Click
        If temporal.Visible Then
            MsgBox("No se pueden agregar pagos a un expediente temporal.")
        Else
            Using pagos As New ModPago(opr_id.Text, False)
                pagos.ShowDialog()
            End Using
        End If
    End Sub
    '###### END VALIDATION ######################################################################################

    '###### PRINT ###############################################################################################
    Private Sub CaratulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaratulaToolStripMenuItem.Click
        If temporal.Visible Then
            MsgBox("Debe completar este expediente para imprimir la caratula.")
        ElseIf actualizar(grupo_exp.SelectedIndex) = MsgBoxResult.Yes Then
            Dim parametros As New Generic.List(Of ReportParameter)
            Dim letra As String = ""
            letra = Microsoft.VisualBasic.Left(Trim(bs_resp.Current("razon")), 1)
            parametros.Add(New ReportParameter("Letra", letra))

            parametros = ParametrosReporte.ObrasPrivadas.BaseExpediente(parametros, expediente.Text,
                                                     inicio_obra.Value,
                                                     tarea.Text & " " & tarea2.Text)

            parametros = ParametrosReporte.ObrasPrivadas.ListarResponsables(parametros, bs_resp.DataSource)
            parametros = ParametrosReporte.ObrasPrivadas.ListarInmuebles(parametros, bs_catastro.DataSource)

            'Crear informe
            Using formEXP As New Formularios("Caratula de Expediente")
                With formEXP
                    .Mostrar("REPORTES\CAR", parametros)
                    .ShowDialog()
                End With
            End Using
        End If
    End Sub

    Private Sub CopiaDeExpedienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaDeExpedienteToolStripMenuItem.Click
        If temporal.Visible Then
            MsgBox("Debe completar este expediente para imprimirlo.")
        ElseIf actualizar(grupo_exp.SelectedIndex) = MsgBoxResult.Yes Then
            Dim parametros As New Generic.List(Of ReportParameter)
            parametros = ParametrosReporte.ObrasPrivadas.BaseExpediente(parametros, expediente.Text,
                                                     inicio_obra.Value,
                                                     tarea.Text & " " & tarea2.Text)

            parametros = ParametrosReporte.ObrasPrivadas.ListarResponsables(parametros, bs_resp.DataSource)

            cuil.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
            Dim prof_completo As String = "Razon: " & razon.Text & System.Environment.NewLine &
                                          "CUIL: " & cuil.Text & " | Matricula: " & matricula.Text
            cuil.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

            parametros = ParametrosReporte.ObrasPrivadas.DetalleExpediente(parametros, prof_completo,
                                                        recibe.Text, Trim(observaciones.Text),
                                                        visado.Checked, check_fin_obra.Checked,
                                                        fin_obra.Value)

            parametros = ParametrosReporte.ObrasPrivadas.ListarInmuebles(parametros, bs_catastro.DataSource)

            'Crear informe
            Using formEXP As New Formularios("Resumen de Expediente")
                With formEXP
                    .Mostrar("REPORTES\EXP", parametros)
                    .ShowDialog()
                    .Dispose()
                End With
            End Using
        End If
    End Sub


    '###### END PRINT ###########################################################################################
End Class

