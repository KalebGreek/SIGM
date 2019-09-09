Public Class ModInmueble
	Dim dtab_cat As DataTable
	Public Sub New(OprId As Integer)
        ' This call is required by the designer.
        InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		opr_id.Text = OprId
	End Sub
    ' GUI

    Private Sub grupo_mod_VisibleChanged(sender As Object, e As EventArgs) Handles grupo_mod.VisibleChanged
		If Me.Visible Then
			SelectorCatastro()
		End If
	End Sub

	Private Sub grupo_mod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grupo_mod.SelectedIndexChanged
		back.Enabled = True
		siguiente.Text = "SIGUIENTE >"
		If grupo_mod.SelectedIndex = 5 Then
			siguiente.Text = "GUARDAR"
			subtitulo.Text = " COPIAS DIGITALES"
		ElseIf grupo_mod.SelectedIndex = 4 Then
			subtitulo.Text = " CARACTERÍSTICAS Y SERVICIOS"
		ElseIf grupo_mod.SelectedIndex = 3 Then
			subtitulo.Text = " SUPERFICIE DECLARADA"
		ElseIf grupo_mod.SelectedIndex = 2 Then
			subtitulo.Text = " FRENTES DE INMUEBLE"
		ElseIf grupo_mod.SelectedIndex = 1 Then
			back.Enabled = False
			subtitulo.Text = " UBICACIÓN, USO Y TITULAR"
		End If
	End Sub

    Private Sub info_estado_TextChanged(sender As Object, e As EventArgs) Handles info_estado.TextChanged
        BloquearMod()
    End Sub

    Private Sub sig_Click(sender As Object, e As EventArgs) Handles siguiente.Click
		Dim dr As DialogResult = Validar(grupo_mod.SelectedIndex)
		If dr <> DialogResult.Cancel Then
            GuardarCambios()
            If grupo_mod.SelectedIndex < grupo_mod.TabCount - 1 Then
                grupo_mod.SelectTab(grupo_mod.SelectedIndex + 1)
            End If
        End If
	End Sub
	Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
		Dim dr As DialogResult = Validar(grupo_mod.SelectedIndex)
		If dr <> DialogResult.Cancel Then
			If dr = DialogResult.OK Then
				GuardarCambios()
			Else
				'reload
			End If
			If grupo_mod.SelectedIndex > 1 Then
				grupo_mod.SelectTab(grupo_mod.SelectedIndex - 1)
			End If
		End If
	End Sub
	Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
		Dim dr As DialogResult = Validar(grupo_mod.SelectedIndex)
		If dr <> DialogResult.Cancel Then
			If dr = DialogResult.OK Then
				GuardarCambios()
			End If
			Me.Close()
		End If
	End Sub

    ' RUTINAS

    ' PARTIDA
    Private Sub SelectorCatastro() _
        Handles zona.ValueChanged, circ.ValueChanged, secc.ValueChanged, parc.ValueChanged, lote.ValueChanged
        'Handles zona.KeyUp, circ.KeyUp, secc.KeyUp, manz.KeyUp, parc.KeyUp, lote.KeyUp
        If Me.Visible And grupo_mod.SelectedTab Is tab_catastro Then
            MostrarResumen()
            BloquearMod()
        End If
    End Sub
    Private Sub MostrarResumen()
        catastro_id.Text = Catastro.SeleccionarPartida(zona.Value, circ.Value, secc.Value, manz.Value, parc.Value, lote.Value)
        dtab_cat = Catastro.Seleccionar(catastro_id.Text)

        titular_id.Text = 0
        titular.Text = " - "
        cuil.Text = " - "
        info_ubicacion.Text = " - "
        info_barrio.Text = " - "
        info_uso.Text = " - "
        info_cuenta.Text = " - "
        info_exp.Text = 0
        operacion.Text = ""

        If catastro_id.Text = -1 Then
            info_estado.Text = "SELECCIONAR INMUEBLE"
        ElseIf catastro_id.Text = 0 Then 'Inmueble nuevo
            info_estado.Text = "NUEVO"
            operacion.Text = "NEW"
        ElseIf dtab_cat.Rows.Count > 0 Then
            CtrlMan.LoadAllControls(dtab_cat(0), tab_ubicacion)
            info_ubicacion.Text = dtab_cat(0)("calle").ToString & " " & dtab_cat(0)("altura").ToString

            If dtab_cat(0)("expediente") Is DBNull.Value = False Then
                info_exp.Text = dtab_cat(0)("expediente")
            End If

            If My.Settings.UserId = dtab_cat(0)("user_id") Then
                If opr_id.Text = dtab_cat(0)("opr_id") Then 'Modificar
                    If dtab_cat(0)("archivado") Then 'Solo lectura
                        info_estado.Text = "CONSULTA"
                    Else
                        info_estado.Text = "ACTIVO"
                        operacion.Text = "MOD"
                    End If
                ElseIf opr_id.Text <> dtab_cat(0)("opr_id") Then
                    If dtab_cat(0)("archivado") Then 'Duplicar
                        operacion.Text = "DUP"
                        info_estado.Text = "LISTO PARA DUPLICAR"
                    Else
                        info_estado.Text = "CONSULTA"
                    End If
                Else 'Temporal
                    operacion.Text = "MOD"
                    info_estado.Text = "TEMPORAL"
                End If
            Else
                info_estado.Text = "BLOQUEADO"
            End If
        End If

        'Formatear por operación
        If operacion.Text = "" Then
            siguiente.Text = "CONSULTAR >"
        ElseIf operacion.Text = "MOD" Then
            siguiente.Text = "MODIFICAR >"
        ElseIf operacion.Text = "DUP" Then
            siguiente.Text = "DUPLICAR >"
        ElseIf operacion.Text = "NEW" Then
            siguiente.Text = "NUEVO >"
        End If

        'Mostrar Partida
        Partida.Text = "Partida: Z" & zona.Value & " C" & circ.Value & " S" & secc.Value &
                      " M" & manz.Value & " P" & parc.Value & " L" & lote.Value
    End Sub

    Private Sub Cargar(registro As DataTable)

        Dim sql(3) As String

        cuenta.Value = 0
        barrio.SelectedIndex = -1
		uso.SelectedIndex = -1
		titular_id.Text = 0

        'detalles
        If registro.Rows.Count > 0 Then
			CtrlMan.LoadAllControls(registro(0), tab_ubicacion)
			If archivado.Checked Then
				archivado.Enabled = False
			End If
		End If


        'frentes
        CtrlMan.LoadDataGridView(consulta_frente, bs_frente, "", Catastro.ListarFrente(catastro_id.Text))

        'superficies
        sql(0) = "SELECT *"
        sql(1) = "FROM cat_superficie"
        sql(2) = "WHERE catastro_id=" & catastro_id.Text

        CtrlMan.LoadAllControls(DbMan.readDB(Nothing, My.Settings.CurrentDB, sql)(0), tab_sup)

        'caracteristicas
        sql(0) = "SELECT descripcion, activo "
        sql(1) = "FROM cat_servicio"
        sql(2) = "WHERE catastro_id=" & catastro_id.Text

        CtrlMan.LoadDataGridView(consulta_caract, bs_car, "",
                                 DbMan.readDB(Nothing, My.Settings.CurrentDB, sql))

        'copias
        CtrlMan.LoadDataGridView(consulta_copia, bs_copia, "", Documento.Catastro.BuscarDoc(catastro_id.Text))

	End Sub

	Function Validar(pagina As Integer) As DialogResult
		Dim msg As New List(Of String)
		Dim valido As Boolean = True
		Dim dr As DialogResult = DialogResult.OK

		If pagina = 0 Then 'BÚSQUEDA DE PARTIDA
            msg.Add("** PARTIDA **")
			If catastro_id.Text = -1 Then
				msg.Add("(×) Seleccione un inmueble para continuar.")
				valido = False
			ElseIf catastro_id.Text <> 0 And operacion.Text = "" Then
				msg.Add("(×) Inmueble no válido.")
				valido = False
			End If

		ElseIf pagina = 1 Then 'DETALLES
            msg.Add("** DETALLE DE INMUEBLE **")
			If Val(cuenta.Text) < 1 Then
				msg.Add("(×) Ingrese N° de cuenta del inmueble.")
				valido = False
			End If
			If barrio.SelectedIndex = -1 Then
				msg.Add("(×) Debe seleccionar un barrio antes de continuar.")
				valido = False
			End If
			If uso.SelectedIndex = -1 Then
				msg.Add("(×) Debe indicar uso del inmueble antes de continuar.")
				valido = False
			End If
			If titular_id.Text < 1 Then
				msg.Add("(×) No se seleccionó un titular.")
				valido = False
			End If


		ElseIf pagina = 2 Then 'FRENTES
            msg.Add("** FRENTES **")
			If bs_frente.Count = 0 Then
				msg.Add("(×) No se definió ningún frente de inmueble.")
				valido = False
			ElseIf bs_frente.Position = -1 Then
				msg.Add("(×) Debe seleccionar un frente como ubicación del inmueble.")
				valido = False
			End If


		ElseIf pagina = 3 Then 'SUPERFICIE
            msg.Add("** SUPERFICIE **")
			If libre.Value = 0 Or cubierto.Value = 0 Then
				msg.Add("(×) No hay superficie declarada.")
				valido = False
			End If


		ElseIf pagina = 4 Then 'CARACTERÍSTICAS Y SERVICIOS
            msg.Add("** CARACTERÍSTICAS **")
			If bs_car.Count = 0 Then
				msg.Add("(×) No se definió ningún servicio o característica.")
				valido = False
			End If


		ElseIf pagina = 5 Then 'COPIAS
            msg.Add("** COPIAS DIGITALES **")
			If bs_copia.Count = 0 Then
				msg.Add("(×) No existen documentos relacionados con este inmueble.")
				valido = False
			Else
				valido = False
				For fila As Integer = 0 To bs_copia.Count - 1
					bs_copia.Position = fila
					If bs_copia.Current("descripcion") = "ESCRITURA O POSESION" Then
						valido = True
					End If
				Next
				If valido = False Then
					msg.Add("(×) Es obligatorio cargar una copia de la Escritura o Posesión del inmueble para continuar.")
				End If
			End If
		End If

		If valido = False Then
			Dim error_form As New visor_error("Errores en Inmueble", msg)
			dr = error_form.ShowDialog(Me)
			error_form.Dispose()
		End If
		Return dr
	End Function

    Private Sub BloquearMod()
        Dim lock As Boolean = (info_estado.Text <> "BLOQUEADO")
        tab_ubicacion.Enabled = lock
        tab_frente.Enabled = lock
        tab_sup.Enabled = lock
        tab_caracter.Enabled = lock
        tab_copia.Enabled = lock
    End Sub

    Private Sub GuardarCambios()
		With grupo_mod
            If .SelectedIndex = 1 Then
                If operacion.Text = "MOD" Then
                    Catastro.Modificar.Inmueble(opr_id.Text, catastro_id.Text, titular_id.Text,
                                                  barrio.Text, uso.Text, cuenta.Value, archivado.Checked,
                                                  zona.Value, circ.Value, secc.Value,
                                                  manz.Value, parc.Value, lote.Value)
                ElseIf operacion.Text = "NEW" Or operacion.Text = "DUP" Then
                    Catastro.Agregar.Inmueble(opr_id.Text, catastro_id.Text, titular_id.Text,
                                              barrio.Text, uso.Text, cuenta.Value, archivado.Checked,
                                              zona.Value, circ.Value, secc.Value,
                                              manz.Value, parc.Value, lote.Value)
                    operacion.Text = "MOD"
                End If
            ElseIf .SelectedIndex = 2 Then
                'Se cambia en tiempo real
            ElseIf .SelectedIndex = 3 Then
                Catastro.Agregar.Superficie(catastro_id.Text, existente.Value, relevamiento.Value,
                                 proyecto.Value, terreno.Value)
            ElseIf .SelectedIndex = 4 Then 'caracteristicas
                Catastro.Agregar.Caracteristica(bs_car, catastro_id.Text)
            ElseIf .SelectedIndex = 5 Then 'documentos
                Catastro.Agregar.Documento(bs_copia, catastro_id.Text)
            End If
            If dtab_cat Is Nothing = False Then
                Cargar(dtab_cat)
            End If
        End With
	End Sub

    'UBICACIÓN Y TITULAR
    Private Sub cuenta_ValueChanged(sender As Object, e As EventArgs) Handles cuenta.ValueChanged
		info_cuenta.Text = cuenta.Value
	End Sub
	Private Sub uso_TextChanged(sender As Object, e As EventArgs) Handles uso.TextChanged
		info_uso.Text = uso.Text
	End Sub

	Private Sub barrio_TextChanged(sender As Object, e As EventArgs) Handles barrio.TextChanged
		info_barrio.Text = barrio.Text
	End Sub

	Private Sub mod_titular_Click(sender As Object, e As EventArgs) Handles mod_titular.Click
        Dim bs As BindingSource = Persona.Seleccionar(Me)
        With bs
            If .DataSource Is Nothing = False Then
                If .Position > -1 Then
                    titular_id.Text = .Current("persona_id").ToString
                    titular.Text = .Current("razon").ToString
                    cuil.Text = .Current("cuil").ToString
                    difunto.Checked = .Current("difunto")
                End If
            Else
                titular_id.Text = 0
                titular.Clear()
                cuil.Clear()
                difunto.Checked = False
            End If
            .Dispose()
        End With
    End Sub
	Private Sub titular_TextChanged(sender As Object, e As EventArgs) Handles titular.TextChanged
		info_titular.Text = titular.Text
	End Sub
	Private Sub cuil_TextChanged(sender As Object, e As EventArgs) Handles cuil.TextChanged
		info_cuil.Text = cuil.Text
	End Sub
	Private Sub archivado_CheckedChanged(sender As Object, e As EventArgs) Handles archivado.CheckedChanged
		With archivado
			.Checked = tab_ubicacion.Enabled.CompareTo(True)
			.Checked = tab_sup.Enabled.CompareTo(True)
			.Checked = tab_caracter.Enabled.CompareTo(True)
			.Checked = tab_frente.Enabled.CompareTo(True)
			.Checked = tab_copia.Enabled.CompareTo(True)
            '.Checked = cuenta.Enabled.CompareTo(True)
            '.Checked = barrio.Enabled.CompareTo(True)
            '.Checked = uso.Enabled.CompareTo(True)
            '.Checked = menu_frente.Enabled.CompareTo(True)
            '.Checked = proyecto.Enabled.CompareTo(True)
            '.Checked = relevamiento.Enabled.CompareTo(True)
            '.Checked = terreno.Enabled.CompareTo(True)
            '.Checked = menu_caract.Enabled.CompareTo(True)
            '.Checked = consulta_caract.ReadOnly
            '.Checked = menu_copia.Enabled.CompareTo(True)
        End With
	End Sub

    ' FRENTES
    Private Sub frente_click_events(sender As Object, e As EventArgs) Handles add_frente.Click, del_frente.Click, ubicacion_principal.Click
		If sender Is add_frente Then
			Dim agregar_frente As New AgregarFrente
			With agregar_frente
				.ShowDialog(Me)
				If .calle.Text <> "" Then
					Catastro.Agregar.Frente(catastro_id.Text, .calle.Text, .altura.Value, .metros.Value)
					ubicacion_principal.PerformClick()
				End If
				.Dispose()
			End With
		ElseIf bs_frente.Position > -1 Then
			If sender Is ubicacion_principal Then
				Catastro.Modificar.Ubicacion(bs_frente, catastro_id.Text)
			ElseIf sender Is del_frente Then
				Catastro.Eliminar.Frente(bs_frente, catastro_id.Text)
			End If
		End If
        CtrlMan.LoadDataGridView(consulta_frente, bs_frente, "", Catastro.ListarFrente(catastro_id.Text))
    End Sub

    ' SUPERFICIE
    Private Sub calcular_superficie(sender As Object, e As EventArgs) Handles existente.ValueChanged, proyecto.ValueChanged,
																				relevamiento.ValueChanged, terreno.ValueChanged,
																				libre.ValueChanged, cubierto.ValueChanged

		Catastro.CalcularSuperficie(existente.Value, proyecto.Value, relevamiento.Value,
									terreno.Value, libre.Value, cubierto.Value)
	End Sub

    ' CARACTERISTICAS
    Private Sub lista_car_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista_car.SelectedIndexChanged
		add_car.Enabled = True
		If lista_car.SelectedIndex < 0 Then
			add_car.Enabled = False
		End If
	End Sub
	Private Sub bs_car_PositionChanged(sender As Object, e As EventArgs) Handles bs_car.PositionChanged
		del_car.Enabled = True
		If bs_car.Position < 0 Then
			del_car.Enabled = False
		End If
	End Sub
	Private Sub add_car_Click(sender As Object, e As EventArgs) Handles add_car.Click
		bs_car.AddNew()
		bs_car.Current("descripcion") = lista_car.Text
		bs_car.Current("activo") = True
		bs_car.EndEdit()
		lista_car.SelectedIndex = -1
	End Sub
	Private Sub del_car_Click(sender As Object, e As EventArgs) Handles del_car.Click
		bs_car.RemoveCurrent()
		bs_car.Position = -1
	End Sub

    ' COPIAS
    Private Sub tipo_copia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipo_copia.SelectedIndexChanged
		add_copia.Enabled = True
		If tipo_copia.SelectedIndex < 0 Then
			add_copia.Enabled = False
		End If
	End Sub
	Private Sub bs_copia_PositionChanged(sender As Object, e As EventArgs) Handles bs_copia.PositionChanged
		del_copia.Enabled = False
		If bs_copia.Position > -1 Then
			del_copia.Enabled = True
		End If
	End Sub
	Private Sub add_copia_Click(sender As Object, e As EventArgs) Handles add_copia.Click
		Dim ruta As String = Documento.Catastro.CargarCopia(tipo_copia.Text,
														   "Z" & zona.Value & " C" & circ.Value & " S" & secc.Value &
														  " M" & manz.Value & " P" & parc.Value & " L" & lote.Value)
		If ruta <> "" Then
			With bs_copia
				.AddNew()
				.Current("descripcion") = tipo_copia.Text
				.Current("fecha") = Date.Today
				.Current("ruta") = ruta
				.EndEdit()
			End With
		End If
	End Sub
	Private Sub del_copia_Click(sender As Object, e As EventArgs) Handles del_copia.Click
		bs_copia.RemoveCurrent()
	End Sub
	Private Sub consulta_copia_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles consulta_copia.CellContentDoubleClick
        If bs_copia.Position > -1 Then
            Try
                Process.Start(root & My.Settings.DocFolderCatastro & bs_copia.Current("ruta"))
            Catch ex As Exception
                MsgBox(ex.GetBaseException.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        End If
    End Sub


End Class