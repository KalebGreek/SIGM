Class ModInmueble
    Public Sub New(OprId As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Menu1.BackColor = ColorCatastro
        subtitulo.ForeColor = ColorCatastro
        opr_id.Text = OprId.ToString()
    End Sub
    ' GUI

    Private Sub Grupo_mod_VisibleChanged(sender As Object, e As EventArgs) Handles grupo_mod.VisibleChanged
        If Me.Visible Then
            SelectorCatastro()
        End If
    End Sub

    Private Sub Grupo_mod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grupo_mod.SelectedIndexChanged
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

    Private Sub Info_estado_TextChanged(sender As Object, e As EventArgs) Handles info_estado.TextChanged
        BloquearMod()
    End Sub

    Private Sub Sig_Click(sender As Object, e As EventArgs) Handles siguiente.Click, back.Click, cancel.Click
        Dim dr As DialogResult = ValidarInmueble(grupo_mod.SelectedIndex)
        If dr <> DialogResult.Cancel Then
            GuardarCambios()
            If sender Is siguiente Then
                If grupo_mod.SelectedIndex < grupo_mod.TabCount - 1 Then
                    grupo_mod.SelectTab(grupo_mod.SelectedIndex + 1)
                End If
            ElseIf sender Is back Then
                If grupo_mod.SelectedIndex > 1 Then
                    grupo_mod.SelectTab(grupo_mod.SelectedIndex - 1)
                End If
            ElseIf sender Is cancel Then
                Me.Close()
            End If
        End If
    End Sub

    ' RUTINAS
    Function ValidarInmueble(pagina As Integer) As DialogResult
        Dim msg As New List(Of String)
        Dim dr As DialogResult = DialogResult.OK

        If pagina = 0 Then 'BÚSQUEDA DE PARTIDA
            msg = Catastro.Validar.Partida(catastro_id.Text, operacion.Text)

        ElseIf pagina = 1 Then 'DETALLES
            msg = Catastro.Validar.Detalles(cuenta.Value, barrio.SelectedIndex, uso.SelectedIndex, titular_id.Text)

        ElseIf pagina = 2 Then 'FRENTES
            msg = Catastro.Validar.Frentes(BSFrente)

        ElseIf pagina = 3 Then 'SUPERFICIE
            msg = Catastro.Validar.Superficies(libre.Value, cubierto.Value)

        ElseIf pagina = 4 Then 'CARACTERÍSTICAS Y SERVICIOS
            msg = Catastro.Validar.Caracteristicas(BSCar)

        ElseIf pagina = 5 Then 'COPIAS
            msg = Catastro.Validar.CopiaDigital(BSCopia)

        End If


        If msg.Count > 1 Then
            Using ErrorForm As New UIError("Errores en Inmueble", msg)
                dr = ErrorForm.ShowDialog(Me)
            End Using
        End If
        Return dr
    End Function

    ' PARTIDA

    Private Sub SelectByKey(sender As Object, e As EventArgs) Handles zona.Enter, circ.Enter, secc.Enter, manz.Enter, parc.Enter, lote.Enter
        sender.Select(0, sender.Text.Length)
    End Sub
    Private Sub SelectByMouse(Sender As Object, e As MouseEventArgs) Handles zona.MouseDown, circ.MouseDown, secc.MouseDown, manz.MouseDown, parc.MouseDown, lote.MouseDown
        Sender.Select(0, Sender.Text.Length)
    End Sub


    Private Sub SelectorCatastro() Handles zona.ValueChanged, circ.ValueChanged, secc.ValueChanged, manz.ValueChanged, parc.ValueChanged, lote.ValueChanged
        If Me.Visible And grupo_mod.SelectedTab Is tab_catastro Then
            MostrarResumen()
            BloquearMod()
        End If
    End Sub
    Private Sub MostrarResumen()
        catastro_id.Text = Catastro.SeleccionarPartida(zona.Value, circ.Value, secc.Value, manz.Value, parc.Value, lote.Value)
        Dim registro As DataRow = Catastro.Seleccionar(catastro_id.Text)

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
        ElseIf registro Is Nothing = False Then
            CtrlMan.LoadControlData(registro, tab_ubicacion)
            info_ubicacion.Text = registro("calle").ToString & " " & registro("altura").ToString

            If registro("expediente") Is DBNull.Value = False Then
                info_exp.Text = registro("expediente")
            End If

            If My.Settings.UserId = registro("user_id").ToString Then
                If opr_id.Text = registro("opr_id").ToString Then 'Modificar
                    If registro("archivado") Then 'Solo lectura
                        info_estado.Text = "CONSULTA"
                    Else
                        info_estado.Text = "ACTIVO"
                        operacion.Text = "MOD"
                    End If
                ElseIf opr_id.Text <> registro("opr_id").ToString Then
                    If registro("archivado") Then 'Duplicar
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

    Private Sub Cargar(registro As DataRow)

        Dim sql(3) As String

        cuenta.Value = 0
        barrio.SelectedIndex = -1
        uso.SelectedIndex = -1
        titular_id.Text = 0

        'detalles
        CtrlMan.LoadControlData(registro, tab_ubicacion)
        If archivado.Checked Then
            archivado.Enabled = False
        End If

        'frentes
        BSFrente.DataSource = Catastro.ListarFrente(catastro_id.Text)
        CtrlMan.DataGridViewTools.Load(consulta_frente, BSFrente)

        'superficies
        CtrlMan.LoadControlData(DbMan.ReadDB("SELECT * FROM cat_superficie WHERE catastro_id=" & catastro_id.Text,
                                             My.Settings.CurrentDB), tab_sup)

        'caracteristicas
        BSCar.DataSource = DbMan.ReadDB("SELECT descripcion, activo FROM cat_servicio WHERE catastro_id=" & catastro_id.Text,
                                        My.Settings.CurrentDB)
        CtrlMan.DataGridViewTools.Load(consulta_caract, BSCar)

        'copias
        BSCopia.DataSource = FileMan.Catastro.BuscarDoc(catastro_id.Text)
        CtrlMan.DataGridViewTools.Load(consulta_copia, BSCopia)

    End Sub

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
                                                  barrio.Text, uso.Text, cuenta.Value)
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
                If BSCar Is Nothing = False Then
                    Catastro.Agregar.Caracteristica(BSCar.DataSource, catastro_id.Text)
                End If
            ElseIf .SelectedIndex = 5 Then 'documentos
                Catastro.Agregar.Documento(BSCopia.DataSource, catastro_id.Text)
            End If
            Dim registro As DataRow = Catastro.Seleccionar(catastro_id.Text)
            If registro Is Nothing = False Then
                Cargar(registro)
            End If
        End With
    End Sub

    'UBICACIÓN Y TITULAR
    Private Sub Cuenta_ValueChanged(sender As Object, e As EventArgs) Handles cuenta.ValueChanged
        info_cuenta.Text = cuenta.Value
    End Sub
    Private Sub Uso_TextChanged(sender As Object, e As EventArgs) Handles uso.TextChanged
        info_uso.Text = uso.Text
    End Sub

    Private Sub Barrio_TextChanged(sender As Object, e As EventArgs) Handles barrio.TextChanged
        info_barrio.Text = barrio.Text
    End Sub

    Private Sub Mod_titular_Click(sender As Object, e As EventArgs) Handles mod_titular.Click
        Dim source As DataRowView = Persona.Seleccionar(Me)
        If source Is Nothing = False Then
            titular_id.Text = source("persona_id").ToString
            titular.Text = source("razon").ToString
            cuil.Text = source("cuil").ToString
            difunto.Checked = source("difunto")
        Else
            titular_id.Text = 0
            titular.Clear()
            cuil.Clear()
            difunto.Checked = False
        End If
    End Sub
    Private Sub Titular_TextChanged(sender As Object, e As EventArgs) Handles titular.TextChanged
        info_titular.Text = titular.Text
    End Sub
    Private Sub Cuil_TextChanged(sender As Object, e As EventArgs) Handles cuil.TextChanged
        info_cuil.Text = cuil.Text
    End Sub
    Private Sub Archivado_CheckedChanged(sender As Object, e As EventArgs) Handles archivado.CheckedChanged
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
    Private Sub Frente_click_events(sender As Object, e As EventArgs) Handles add_frente.Click, del_frente.Click, ubicacion_principal.Click
        If sender Is add_frente Then
            Using agregar_frente As New AgregarFrente
                With agregar_frente
                    .ShowDialog(Me)
                    If .calle.Text <> "" Then
                        Catastro.Agregar.Frente(catastro_id.Text, .calle.Text, .altura.Value, .metros.Value)
                        ubicacion_principal.PerformClick()
                    End If
                End With
            End Using
        ElseIf BSFrente.Position > -1 Then
            Dim FrenteId As Integer = BSFrente.Current("frente_id")
            If sender Is ubicacion_principal Then
                Catastro.Modificar.Ubicacion(FrenteId, catastro_id.Text)
            ElseIf sender Is del_frente Then
                Catastro.Eliminar.Frente(FrenteId)
            End If
        End If
        BSFrente.DataSource = Catastro.ListarFrente(catastro_id.Text)
        CtrlMan.DataGridViewTools.Load(consulta_frente, BSFrente)
    End Sub

    ' SUPERFICIE
    Private Sub Calcular_superficie(sender As Object, e As EventArgs) Handles existente.ValueChanged, proyecto.ValueChanged,
                                                                                relevamiento.ValueChanged, terreno.ValueChanged,
                                                                                libre.ValueChanged, cubierto.ValueChanged

        Catastro.CalcularSuperficie(existente.Value, proyecto.Value, relevamiento.Value,
                                    terreno.Value, libre.Value, cubierto.Value)
    End Sub

    ' CARACTERISTICAS
    Private Sub Lista_car_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista_car.SelectedIndexChanged
        add_car.Enabled = True
        If lista_car.SelectedIndex < 0 Then
            add_car.Enabled = False
        End If
    End Sub
    Private Sub Bs_car_PositionChanged(sender As Object, e As EventArgs) Handles BSCar.PositionChanged
        del_car.Enabled = True
        If BSCar.Position < 0 Then
            del_car.Enabled = False
        End If
    End Sub
    Private Sub Add_car_Click(sender As Object, e As EventArgs) Handles add_car.Click
        BSCar.AddNew()
        BSCar.Current("descripcion") = lista_car.Text
        BSCar.Current("activo") = True
        BSCar.EndEdit()
        lista_car.SelectedIndex = -1
    End Sub
    Private Sub Del_car_Click(sender As Object, e As EventArgs) Handles del_car.Click
        BSCar.RemoveCurrent()
        BSCar.Position = -1
    End Sub

    ' COPIAS
    Private Sub Tipo_copia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipo_copia.SelectedIndexChanged
        add_copia.Enabled = True
        If tipo_copia.SelectedIndex < 0 Then
            add_copia.Enabled = False
        End If
    End Sub
    Private Sub Bs_copia_PositionChanged(sender As Object, e As EventArgs) Handles BSCopia.PositionChanged
        del_copia.Enabled = False
        If BSCopia.Position > -1 Then
            del_copia.Enabled = True
        End If
    End Sub
    Private Sub Add_copia_Click(sender As Object, e As EventArgs) Handles add_copia.Click
        Dim ruta As String = FileMan.Catastro.CargarCopia(tipo_copia.Text,
                                                           "Z" & zona.Value & " C" & circ.Value & " S" & secc.Value &
                                                          " M" & manz.Value & " P" & parc.Value & " L" & lote.Value)
        If ruta <> "" Then
            With BSCopia
                .AddNew()
                .Current("descripcion") = tipo_copia.Text
                .Current("fecha") = Date.Today
                .Current("ruta") = ruta
                .EndEdit()
            End With
        End If
    End Sub
    Private Sub Del_copia_Click(sender As Object, e As EventArgs) Handles del_copia.Click
        BSCopia.RemoveCurrent()
    End Sub
    Private Sub Consulta_copia_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles consulta_copia.CellContentDoubleClick
        If BSCopia.Position > -1 Then
            Try
                Process.Start(root & My.Settings.DocFolderCatastro & BSCopia.Current("ruta").ToString)
            Catch ex As Exception
                MsgBox(ex.GetBaseException.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        End If
    End Sub

End Class