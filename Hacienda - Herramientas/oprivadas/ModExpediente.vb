Public Class ModExpediente
    Public dtab_exp As DataTable

	Public Sub New(Optional exp As Integer = 0)
        ' This call is required by the designer.
        InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Do
			If exp = 0 Then
				exp = Val(Date.Today.Year) * 10000
			End If
			exp = Val(InputBox("Ingrese Nº de Expediente", "Seleccionar Expediente", exp))
			If exp <> Nothing Then
				dtab_exp = Oprivadas.Expediente.Seleccionar(exp)
				If dtab_exp.Rows.Count = 0 Then
					dtab_exp = Oprivadas.Expediente.Generar(exp)
				End If
			End If
		Loop Until exp = Nothing Or dtab_exp Is Nothing = False
		If exp = Nothing Then
			dtab_exp = Nothing
		Else
			Oprivadas.Expediente.Bloquear(dtab_exp(0)("id"), True)
			cargar(dtab_exp)
		End If
	End Sub

	Private Sub ModExpediente_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible And dtab_exp Is Nothing Then
            Me.Close()
        End If
    End Sub

    Private Sub ModExpediente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If opr_id.Text > 0 And temporal.Visible = False Then
			Oprivadas.Expediente.Bloquear(opr_id.Text, False)
		End If
    End Sub

    '###### GUI #################################################################################################
    ' > Expediente
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Dim answer As MsgBoxResult = validar(grupo_exp.SelectedIndex)
        If answer = MsgBoxResult.Yes Then
            answer = actualizar(grupo_exp.SelectedIndex)
            answer = validar()
            If answer = MsgBoxResult.Yes Then
                If temporal.Visible Then
					answer = MsgBox("¿Desea guardar este expediente temporal bajo el N° " & expediente.Text & "?",
									MsgBoxStyle.YesNoCancel, "Guardar Expediente")
					If answer = MsgBoxResult.Yes Then 'Asignar N° de Expediente y quitar temporal
                        DbMan.edit(  "UPDATE oprivadas SET expediente=" & expediente.Text & ", temporal=False
                                                        WHERE id=" & opr_id.Text)
						Me.Close()
                    End If
                End If
                dtab_exp = Oprivadas.Expediente.Seleccionar(expediente.Text)
                cargar(dtab_exp)
            End If
        End If
    End Sub

    Private Sub grupo_exp_TabIndexChanged(sender As Object, e As EventArgs) Handles grupo_exp.TabIndexChanged
        If Me.Visible Then
            dtab_exp = Oprivadas.Expediente.Seleccionar(expediente.Text)
            If dtab_exp Is Nothing = False Then
                cargar(dtab_exp)
            End If
        End If
    End Sub

    Private Sub PERSONASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERSONASToolStripMenuItem.Click
        Dim answer As MsgBoxResult = validar(grupo_exp.SelectedIndex)
        If answer = MsgBoxResult.Yes Then
            answer = actualizar(grupo_exp.SelectedIndex)
        End If
        If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
            grupo_exp.SelectTab(0)
        End If
    End Sub
    Private Sub INMUEBLESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INMUEBLESToolStripMenuItem.Click
        Dim answer As MsgBoxResult = validar(grupo_exp.SelectedIndex)
        If answer = MsgBoxResult.Yes Then
            answer = actualizar(grupo_exp.SelectedIndex)
        End If
        If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
            grupo_exp.SelectTab(1)
        End If
    End Sub
    Private Sub ARCHIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARCHIVOToolStripMenuItem.Click
        Dim answer As MsgBoxResult = validar(grupo_exp.SelectedIndex)
        If answer = MsgBoxResult.Yes Then
            answer = actualizar(grupo_exp.SelectedIndex)
        End If
        If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
            grupo_exp.SelectTab(2)
        End If
    End Sub
    '###### END GUI #############################################################################################

    '###### VALIDATION ##########################################################################################
    Private Sub cargar(registro As DataTable)
        razon.Clear()
        cuil.Clear()
        matricula.Clear()

        If registro.Rows.Count > 0 Then
            'Reset
            check_fin_obra.Checked = False
            fin_obra.Value = Date.Today
            ruta_fin_obra.Text = ""
            '##### EXPEDIENTE (base)
            CtrlMan.LoadAllControls(registro(0), grupoExp)
            'Tareas se carga al reves por alguna razon, asi que no sirve
            tarea.Text = registro(0)("tarea").ToString
            tarea2.Text = registro(0)("tarea2").ToString
            'Estos controles estan fuera de GrupoExp
            opr_id.Text = registro(0)("id")
            temporal.Visible = registro(0)("temporal")
            expediente.Text = registro(0)("expediente")

            'ARCHIVO
            'inicio_obra.Text = registro(0)("inicio_obra")
            'recibe.Text = registro(0)("recibe").ToString
            'observaciones.Text = registro(0)("observaciones").ToString
            'Copias Digitales (Original y fin de obra)
        End If

        '##### Cargar personas
        CtrlMan.LoadDataGridView(consulta_resp, bs_resp, Oprivadas.Expediente.ListarResponsables(expediente.Text))

        'PROFESIONAL
        prof_id.Text = registro(0)("profesional_id").ToString

		If prof_id.Text > 0 Then
			Dim prof As DataTable = Persona.Profesional.Seleccionar(prof_id.Text, 0)

			If prof.Rows.Count > 0 Then
				CtrlMan.LoadAllControls(prof(0), Panel3)
			Else
				MsgBox("Profesional no válido.", MsgBoxStyle.Exclamation)
				prof_id.Text = 0
			End If
		End If

        'INMUEBLES
        CtrlMan.LoadDataGridView(consulta_inmueble, bs_catastro, Catastro.ListarInmueblePorExpediente(expediente.Text))

        'CARGAR COPIAS DIGITALES
        Dim copias As DataTable = Documento.OPrivadas.BuscarDoc(opr_id.Text)
		If copias.Rows.Count > 0 Then
			For fila As Integer = 0 To copias.Rows.Count - 1
				If copias(fila)("descripcion").ToString = "FIN DE OBRA" Then
					ruta_fin_obra.Text = copias(fila)("ruta").ToString
					check_fin_obra.Checked = True
					fin_obra.Value = registro(0)("fecha")
				End If
			Next
		End If
	End Sub

	Private Function validar(Optional pagina As Integer = -1) As MsgBoxResult
        'Hay que reformatear esto para que salte con actualizar()
        'La idea sería mostrar los datos en un msgbox cuando apretás "guardar".
        'Si todo sale bien, te muestra el resumen y pregunta, si faltan datos esenciales,
        'muestra el resumen pero no deja elegir si guardar o no.
        Dim msg As New List(Of String)

        'Personas
        If pagina = -1 Or pagina = 0 Then
			msg.Add("** PERSONAS **")
			If bs_resp.Count = 0 Then
				msg.Add("(×) Debe indicar al menos un responsable.")
			End If
			If prof_id.Text = 0 Then
				msg.Add("(×) Debe indicar un profesional a cargo.")
			End If
			msg.Add(" ")
		End If

		If pagina = -1 Or pagina = 1 Then
            'Inmuebles
            msg.Add("** INMUEBLES **")
			With bs_catastro
				If .Count = 0 Then
					msg.Add("(×) No se agregó un inmueble.")
				End If
				msg.Add(" ")
			End With
		End If

		If pagina = -1 Or pagina = 2 Then
            'Detalles de expediente
            msg.Add("** EXPEDIENTE **")
			If tarea.SelectedIndex = -1 Then
				msg.Add("(×) Seleccione tarea.")
			ElseIf tarea.Text = "MENSURA" And tarea2.SelectedIndex = -1 Then
				msg.Add("(×) Seleccione detalle de tarea de mensura.")
			End If
			If inicio_obra.Value > Date.Today Then
				msg.Add("(×) La fecha de inicio de obra es inválida.")
			End If
			If recibe.SelectedIndex = -1 Then
				msg.Add("(×) Debe indicar quien recibe el expediente.")
			End If
			If check_fin_obra.Checked Then
				If fin_obra.Value <= inicio_obra.Value Then
					msg.Add("(×) La fecha de fin de de obra es inválida.")
				End If
				If ruta_fin_obra.Text = "" Then
					msg.Add("(×) Cargar copia de certificado de Fin de Obra.")
				End If
			End If
			msg.Add(" ")
		End If

		Dim valido As Integer = msg.FindIndex(Function(value As String)
												  Return value(0) = "("
											  End Function)

		If valido > -1 Then
			Dim ver_error As New visor_error("Errores en Expediente", msg)
			Dim answer As DialogResult = ver_error.ShowDialog(Me)
			ver_error.Dispose()
			If answer = Windows.Forms.DialogResult.OK Then
				Return MsgBoxResult.No
			Else
				Return MsgBoxResult.Cancel
			End If
		Else
			Return MsgBoxResult.Yes
		End If
	End Function

	Private Function actualizar(pagina As Integer) As MsgBoxResult
		Dim result As MsgBoxResult = MsgBoxResult.Yes

		If pagina = 0 Then 'Responsables
            Oprivadas.Expediente.LimpiarResponsable(opr_id.Text)
			Oprivadas.Expediente.AgregarResponsable(bs_resp, opr_id.Text, bs_resp.Current("persona_id"))
			Oprivadas.Expediente.ActualizarProfesional(opr_id.Text, prof_id.Text)

		ElseIf pagina = 1 Then 'Inmuebles
            'Los cambios se producen en el momento, no es necesario guardar

        ElseIf pagina = 2 Then 'Expediente
            Oprivadas.Expediente.ActualizarDetalle(opr_id.Text, inicio_obra.Value, check_fin_obra.Checked, fin_obra.Value,
												   recibe.Text, tarea.Text, tarea2.Text, Trim(observaciones.Text))
		End If

		Return result
	End Function

	Private Sub tarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tarea.SelectedIndexChanged
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
	Private Sub inicio_obra_ValueChanged(sender As Object, e As EventArgs) Handles inicio_obra.ValueChanged
		fin_obra.Value = inicio_obra.Value
	End Sub
	Private Sub visado_CheckedChanged(sender As Object, e As EventArgs) Handles visado.CheckedChanged
		check_fin_obra.Visible = visado.Checked
		check_fin_obra.Checked = False
	End Sub
	Private Sub check_fin_obra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_fin_obra.CheckedChanged
		With check_fin_obra
			fin_obra.Visible = .Checked
			et_fin_obra.Visible = .Checked
			ruta_fin_obra.Visible = .Checked
			ruta_fin_obra.Text = ""
			cargar_fin_obra.Visible = .Checked
			ver_fin_obra.Visible = .Checked
		End With
	End Sub
	Private Sub cargar_fin_obra_Click(sender As Object, e As EventArgs) Handles cargar_fin_obra.Click
		ruta_fin_obra.Text = Documento.OPrivadas.CargarFinalObra(expediente.Text)
	End Sub
	Private Sub ver_fin_obra_Click(sender As Object, e As EventArgs) Handles ver_fin_obra.Click, ruta_fin_obra.DoubleClick
		If Len(ruta_fin_obra.Text) > 5 Then
			Process.Start(root & My.Settings.DocFolderOprivadas & ruta_fin_obra.Text)
		End If
	End Sub

    '# PERSONA 
    Private Sub add_resp_Click(sender As Object, e As EventArgs) Handles add_resp.Click
		Dim seleccion_persona As New ControlBusquedaPersona()
		With seleccion_persona
			.ShowDialog(Me)
            'Se agrega el registro temporal
            If .bs_resultado.Position > -1 Then
				bs_resp.AddNew()
				bs_resp.Current("persona_id") = .bs_resultado.Current("persona_id").ToString
				bs_resp.Current("razon") = .bs_resultado.Current("razon").ToString
				bs_resp.Current("cuil") = .bs_resultado.Current("cuil").ToString
				bs_resp.Current("email") = .bs_resultado.Current("email").ToString
				bs_resp.Current("telefono") = .bs_resultado.Current("telefono").ToString
				bs_resp.Current("difunto") = .bs_resultado.Current("difunto")
				bs_resp.EndEdit()
			End If
			.Dispose()
		End With
	End Sub
	Private Sub del_resp_Click(sender As Object, e As EventArgs) Handles del_resp.Click
		If bs_resp.Position > -1 _
				 And MsgBoxResult.Yes = MsgBox("¿Desea eliminar el responsable seleccionado?", MsgBoxStyle.YesNo, "Eliminar Responsable") Then
			bs_resp.RemoveCurrent()
		End If
	End Sub
	Private Sub mod_prof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mod_prof.Click
		Dim sel_prof As New ControlBusquedaPersona()
		'sel_prof. = razon.Text

		With sel_prof
			.ShowDialog(Me)
			If .bs_resultado.Count > 0 Then
				prof_id.Text = .bs_resultado.Current("prof_id")
				razon.Text = .bs_resultado.Current("razon")
				titulo.Text = .bs_resultado.Current("titulo")
				cuil.Text = .bs_resultado.Current("cuil")
				matricula.Text = .bs_resultado.Current("matricula")
			End If
			.Dispose()
		End With
	End Sub

    '# INMUEBLE
    Private Sub bs_catastro_PositionChanged(sender As Object, e As EventArgs) Handles bs_catastro.PositionChanged
		Dim dtab As New DataTable
		mod_inmueble.Enabled = False
		responsable_id.Text = "0"
		info_titular.Text = " - "
		info_cuil.Text = " - "
		info_ubicacion.Text = " - "
		info_barrio.Text = " - "
		info_uso.Text = " - "
		info_cuenta.Text = " - "

		With bs_catastro
			If .Position > -1 Then
				mod_inmueble.Enabled = True
				responsable_id.Text = .Current("titular_id")
				info_titular.Text = .Current("titular").ToString
				info_cuil.Text = .Current("cuil").ToString
				info_ubicacion.Text = .Current("calle") & " " & .Current("Altura")
				info_barrio.Text = .Current("barrio").ToString
				info_uso.Text = .Current("uso").ToString
				info_cuenta.Text = .Current("cuenta").ToString

				If .Current("archivado") Then
					info_estado.Text = "ARCHIVADO"
				Else
					info_estado.Text = "ACTIVO"
				End If
			End If
		End With
	End Sub
	Private Sub add_inmueble_Click(sender As Object, e As EventArgs) Handles add_inmueble.Click
		Dim agregar_inmueble As New ModInmueble(opr_id.Text)
		With agregar_inmueble
			.ShowDialog(Me)
			.Dispose()
            'Recargar
            CtrlMan.LoadDataGridView(consulta_inmueble, bs_catastro, Catastro.ListarInmueblePorExpediente(expediente.Text))
		End With
	End Sub
	Private Sub mod_inmueble_Click(sender As Object, e As EventArgs) Handles mod_inmueble.Click
		Dim agregar_inmueble As New ModInmueble(opr_id.Text)
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
                CtrlMan.LoadDataGridView(consulta_inmueble, bs_catastro, Catastro.ListarInmueblePorExpediente(expediente.Text))
			End If
        End With
    End Sub
    Private Sub del_inmueble_Click(sender As Object, e As EventArgs) Handles del_inmueble.Click
        With bs_catastro
            If .Position > -1 Then
                If .Current("archivado") = False _
                And MsgBoxResult.Yes = MsgBox("¿Desea eliminar el inmueble seleccionado? Esta operación no se puede deshacer.", MsgBoxStyle.YesNo, "Eliminar Inmueble") Then
                    Catastro.Eliminar(.Current("catastro_id"), .Current("user_id"))
                    .RemoveCurrent()
                Else
                    MsgBox("Imposible eliminar, este inmueble se encuentra archivado.")
                End If
            End If
        End With
    End Sub
    Private Sub consulta_inmueble_KeyUp(sender As Object, e As KeyEventArgs) Handles consulta_inmueble.KeyUp
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
            Dim deudas As New ModPago(opr_id.Text, True)
            deudas.ShowDialog()
        End If
    End Sub
    Private Sub AgregarPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPagoToolStripMenuItem.Click
        If temporal.Visible Then
            MsgBox("No se pueden agregar pagos a un expediente temporal.")
        Else
            Dim pagos As New ModPago(opr_id.Text, False)
            pagos.ShowDialog()
        End If
    End Sub
    '###### END VALIDATION ######################################################################################

    '###### PRINT ###############################################################################################
    Private Sub CaratulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaratulaToolStripMenuItem.Click
        If temporal.Visible Then
            MsgBox("Debe completar este expediente para imprimir la caratula.")
        Else
            Dim parametros As New Generic.List(Of ReportParameter)
            Dim letra As String = ""
            letra = Microsoft.VisualBasic.Left(Trim(bs_resp.Current("razon")), 1)
            parametros.Add(New ReportParameter("Letra", letra))

            parametros = ParamReporte.BaseExpediente(parametros, expediente.Text,
                                                     inicio_obra.Value,
                                                     tarea.Text & " " & tarea2.Text)

            parametros = ParamReporte.ListarResponsables(parametros, bs_resp)
            parametros = ParamReporte.ListarInmuebles(parametros, bs_catastro)

            'Crear informe
            Dim formEXP As New VisorReporte("Caratula de Expediente", "OPR\CAR", parametros, False)
            With formEXP
                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub
    Private Sub CopiaDeExpedienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaDeExpedienteToolStripMenuItem.Click
        If temporal.Visible Then
            MsgBox("Debe completar este expediente para imprimirlo.")
        Else
            Dim parametros As New Generic.List(Of ReportParameter)
            parametros = ParamReporte.BaseExpediente(parametros, expediente.Text,
                                                     inicio_obra.Value,
                                                     tarea.Text & " " & tarea2.Text)

            parametros = ParamReporte.ListarResponsables(parametros, bs_resp)

            cuil.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
            Dim prof_completo As String = "Razon: " & razon.Text & System.Environment.NewLine &
                                          "CUIL: " & cuil.Text & " | Matricula: " & matricula.Text
            cuil.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

            parametros = ParamReporte.DetalleExpediente(parametros, prof_completo,
                                                        recibe.Text, Trim(observaciones.Text),
                                                        visado.Checked, check_fin_obra.Checked,
                                                        fin_obra.Value)

            parametros = ParamReporte.ListarInmuebles(parametros, bs_catastro)

            'Crear informe
            Dim formEXP As New VisorReporte("Resumen de Expediente", "OPR\EXP", parametros, False)
            With formEXP
                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub
    '###### END PRINT ###########################################################################################
End Class

