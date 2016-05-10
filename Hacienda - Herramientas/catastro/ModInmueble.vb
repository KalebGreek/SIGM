Public Class ModInmueble
    Dim dtab_cat As DataTable
    Public Sub New(UserId As Integer, OprId As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        user_id.Text = UserId
        opr_id.Text = OprId
    End Sub
    '## GUI

    Private Sub grupo_mod_VisibleChanged(sender As Object, e As EventArgs) Handles grupo_mod.VisibleChanged
        If Me.Visible Then
            SelectorCatastro()
        End If
    End Sub

    Private Sub grupo_mod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grupo_mod.SelectedIndexChanged
        back.Enabled = True
        siguiente.Text = "SIGUIENTE >"
        If grupo_mod.SelectedIndex = 5 Then
            siguiente.Text = "FINALIZAR"
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

    Private Sub sig_Click(sender As Object, e As EventArgs) Handles siguiente.Click
        With grupo_mod
            If validar(.SelectedIndex) Then
                If .SelectedIndex < 5 Then
                    If .SelectedIndex = 0 Then
                        cargar(dtab_cat)
                    Else
                        agregar(operacion.Text, .SelectedIndex)
                    End If
                    .SelectTab(.SelectedIndex + 1)
                Else
                    agregar(operacion.Text, .SelectedIndex)
                    Me.Close()
                End If
            End If
        End With
    End Sub
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If grupo_mod.SelectedIndex > 1 Then
            grupo_mod.SelectTab(grupo_mod.SelectedIndex - 1)
        End If
    End Sub
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        With grupo_mod
            If validar(.SelectedIndex) Then
                If .SelectedIndex > 0 Then
                    agregar(operacion.Text, .SelectedIndex)
                End If
            End If
        End With
        Me.Close()
    End Sub

    '## RUTINAS
    '## PARTIDA
    '## Validar
    Private Sub SelectorCatastro(Optional sender As Object = Nothing, Optional e As KeyEventArgs = Nothing) _
        Handles zona.KeyUp, circ.KeyUp, secc.KeyUp, manz.KeyUp, parc.KeyUp, lote.KeyUp
        catastro_id.Text = 0
        catastro_id.Text = Catastro.SeleccionarPartida(zona.Value, circ.Value, secc.Value, manz.Value, parc.Value, lote.Value)
        dtab_cat = Catastro.Seleccionar(catastro_id.Text)
        mostrar(dtab_cat)
    End Sub
    Private Sub mostrar(registro As DataTable)
        titular_id.Text = 0
        razon.Text = " - "
        cuil.Text = " - "
        info_ubicacion.Text = " - "
        info_barrio.Text = " - "
        info_uso.Text = " - "
        info_cuenta.Text = " - "
        info_exp.Text = 0
        operacion.Text = ""

        If registro Is Nothing Then
            info_estado.Text = "SELECCIONAR INMUEBLE"
        ElseIf registro.Rows.Count = 0 Then 'Inmueble nuevo
            info_estado.Text = "NUEVO"
            operacion.Text = "NEW"
        ElseIf registro.Rows.Count > 0 Then
            titular_id.Text = registro(0)("titular_id")
            razon.Text = registro(0)("titular")
            cuil.Text = registro(0)("cuil")
            barrio.Text = registro(0)("barrio").ToString
            uso.Text = registro(0)("uso").ToString
            cuenta.Text = registro(0)("cuenta").ToString
            info_ubicacion.Text = registro(0)("calle").ToString & " " & registro(0)("altura").ToString


            If registro(0)("expediente") Is DBNull.Value = False Then
                info_exp.Text = registro(0)("expediente")
            End If

            If user_id.Text = registro(0)("user_id") Then
                If opr_id.Text = registro(0)("opr_id") Then 'Modificar
                    If registro(0)("archivado") Then 'Solo lectura
                        info_estado.Text = "CONSULTA"
                    Else
                        info_estado.Text = "ACTIVO"
                        operacion.Text = "MOD"
                    End If
                ElseIf opr_id.Text <> registro(0)("opr_id") Then
                    If registro(0)("archivado") Then 'Duplicar
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

    Private Sub cargar(registro As DataTable)
        cuenta.Value = 0
        barrio.SelectedIndex = -1
        uso.SelectedIndex = -1
        titular_id.Text = 0

        'detalles
        If registro.Rows.Count > 0 Then
            If registro(0)("titular_id") Is DBNull.Value = False Then
                titular_id.Text = registro(0)("titular_id")
            End If
            archivado.Checked = registro(0)("archivado")
            If archivado.Checked Then
                archivado.Enabled = False
            End If
            If registro(0)("barrio") Is DBNull.Value = False Then
                barrio.Text = registro(0)("barrio")
            End If
            If registro(0)("uso") Is DBNull.Value = False Then
                uso.Text = registro(0)("uso")
            End If
            If registro(0)("cuenta") Is DBNull.Value = False Then
                cuenta.Text = registro(0)("cuenta")
            End If
        End If


        'frentes
        Consulta.Mostrar(consulta_frente, bs_frente, Catastro.Frente.Cargar(catastro_id.Text))

        'superficies
        registro = bd.leer(defcon, "SELECT * FROM cat_superficie WHERE catastro_id=" & catastro_id.Text)
        If registro.Rows.Count > 0 Then
            existente.Value = Val(registro(0)("existente"))
            proyecto.Value = Val(registro(0)("proyecto"))
            relevamiento.Value = Val(registro(0)("relevamiento"))
            terreno.Value = Val(registro(0)("terreno"))
        End If

        'caracteristicas
        Consulta.Mostrar(consulta_caract, bs_car,
                         bd.leer(defcon, "SELECT descripcion, activo FROM cat_servicio WHERE catastro_id=" & catastro_id.Text))

        'copias
        Consulta.Mostrar(consulta_copia, bs_copia, Documento.Catastro.BuscarHistorial(catastro_id.Text))
    End Sub

    Function validar(pagina As Integer) As Boolean
        Dim msg As New List(Of String)
        Dim valido As Boolean = True


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
            Dim errores As New visor_error("Errores en inmueble", msg)
            With errores
                .ShowDialog(Me)
                .Dispose()
            End With
        End If
        Return valido
    End Function

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
        Dim sel_per As New ConsultaGen("PERSONA", user_id.Text, titular_id.Text)
        sel_per.ShowDialog(Me)
        With sel_per.resultado
            If .Position > -1 Then
                titular_id.Text = .Current("persona_id").ToString
                razon.Text = .Current("razon").ToString
                cuil.Text = .Current("cuil").ToString
                difunto.Checked = .Current("difunto")
            Else
                razon.Clear()
                cuil.Clear()
                difunto.Checked = False
            End If
            .Dispose()
        End With
    End Sub
    Private Sub razon_TextChanged(sender As Object, e As EventArgs) Handles razon.TextChanged
        info_titular.Text = razon.Text
    End Sub
    Private Sub cuil_TextChanged(sender As Object, e As EventArgs) Handles cuil.TextChanged
        info_cuil.Text = cuil.Text
    End Sub
    Private Sub archivado_CheckedChanged(sender As Object, e As EventArgs) Handles archivado.CheckedChanged
        With archivado
            .Checked = cuenta.Enabled.CompareTo(True)
            .Checked = barrio.Enabled.CompareTo(True)
            .Checked = uso.Enabled.CompareTo(True)
            .Checked = grupo_titular.Enabled.CompareTo(True)
            .Checked = menu_frente.Enabled.CompareTo(True)
            .Checked = proyecto.Enabled.CompareTo(True)
            .Checked = relevamiento.Enabled.CompareTo(True)
            .Checked = terreno.Enabled.CompareTo(True)
            .Checked = menu_caract.Enabled.CompareTo(True)
            .Checked = consulta_caract.ReadOnly
            .Checked = menu_copia.Enabled.CompareTo(True)
        End With
    End Sub

    '## FRENTES
    Private Sub bs_frente_PositionChanged(sender As Object, e As EventArgs) Handles bs_frente.PositionChanged
        del_frente.Enabled = False
        With bs_frente
            If .Position > -1 Then
                del_frente.Enabled = True
            End If
        End With
    End Sub
    Private Sub add_frente_Click(sender As Object, e As EventArgs) Handles add_frente.Click
        Dim agregar_frente As New AgregarFrente
        With agregar_frente
            .ShowDialog(Me)
            If .calle.Text <> "" Then
                bs_frente.AddNew()
                bs_frente.Current("calle") = .calle.Text
                bs_frente.Current("altura") = .altura.Value
                bs_frente.Current("metros") = .metros.Value
                bs_frente.EndEdit()
            End If
            .Dispose()
        End With
    End Sub
    Private Sub del_frente_Click(sender As Object, e As EventArgs) Handles del_frente.Click
        bs_frente.RemoveCurrent()
        bs_frente.Position = -1
    End Sub

    '## SUPERFICIE
    Sub CalcularSuperficie() Handles existente.ValueChanged, proyecto.ValueChanged,
                                     relevamiento.ValueChanged, terreno.ValueChanged,
                                     cubierto.ValueChanged

        cubierto.Value = proyecto.Value + relevamiento.Value + existente.Value
        If terreno.Value < cubierto.Value Then
            libre.Value = 0
        Else
            libre.Value = terreno.Value - cubierto.Value
        End If
    End Sub

    '## CARACTERISTICAS
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

    '## COPIAS
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
            Process.Start(Documento.folder_cat & bs_copia.Current("ruta"))
        End If
    End Sub

    '## Agregar y guardar inmueble
    Sub agregar(operacion As String, pagina As Integer)
        If pagina = 1 Then
            If operacion = "MOD" Then
                'Modificar
                mod_sql = "UPDATE catastro SET user_id=" & user_id.Text & ", opr_id=" & opr_id.Text & ", " &
                          " barrio='" & barrio.Text & "', uso='" & uso.Text & "', cuenta=" & Val(cuenta.Text) &
                          " WHERE id=" & catastro_id.Text
                bd.edit(defcon, mod_sql)
            ElseIf operacion <> "" Then
                'Agregar
                mod_sql = "INSERT INTO catastro(user_id, opr_id, zona, circ, secc, manz, parc, lote, barrio, uso, cuenta, archivado) " &
                          " VALUES(" & user_id.Text & "," & opr_id.Text & ", " & zona.Value & ", " & circ.Value & ", " & secc.Value & "," &
                          " " & manz.Value & ", " & parc.Value & ", " & lote.Value & ",'" & barrio.Text & "', '" & uso.Text & "', " & cuenta.Value &
                          "," & archivado.Checked & ")"
                bd.edit(defcon, mod_sql)
                'leer ultimo inmueble
                catastro_id.Text = Catastro.SeleccionarPartida(zona.Value, circ.Value, secc.Value, manz.Value, parc.Value, lote.Value)
                operacion = "MOD"
            End If
            If catastro_id.Text > 0 And titular_id.Text > 0 Then
                'Guardar titular
                bd.edit(defcon, "DELETE * FROM titular_catastro WHERE cat_id=" & catastro_id.Text)
                bd.edit(defcon, "INSERT INTO titular_catastro(cat_id, per_id)" &
                               " VALUES(" & catastro_id.Text & ", " & titular_id.Text & ")")
            End If
        ElseIf pagina = 2 Then
            With bs_frente
                'cat_frente
                del_sql = "DELETE * FROM cat_frente WHERE catastro_id=" & catastro_id.Text
                bd.edit(defcon, del_sql)

                For fila As Integer = 0 To .Count - 1
                    .Position = fila
                    If .Position = 0 Then
                        mod_sql = "INSERT INTO cat_frente(catastro_id, calle, altura, metros, ubicacion)" &
                          " VALUES(" & catastro_id.Text & ",'" & .Current("calle") & "', " & .Current("altura") & "," &
                          " '" & .Current("metros") & "', True)"
                    Else
                        mod_sql = "INSERT INTO cat_frente(catastro_id, calle, altura, metros)" &
                          " VALUES(" & catastro_id.Text & ",'" & .Current("calle") & "', " & .Current("altura") & "," &
                          " '" & .Current("metros") & "')"
                    End If
                    bd.edit(defcon, mod_sql)
                Next
            End With
        ElseIf pagina = 3 Then
            'cat_superficie
            del_sql = "DELETE * FROM cat_superficie WHERE catastro_id=" & catastro_id.Text
            bd.edit(defcon, del_sql)

            mod_sql = "INSERT INTO cat_superficie(catastro_id, existente, proyecto, relevamiento, terreno)" &
                     " VALUES(" & catastro_id.Text & ", '" & existente.Value & "', '" & proyecto.Value & "'," &
                     " '" & relevamiento.Value & "', '" & terreno.Value & "')"

            bd.edit(defcon, mod_sql)

        ElseIf pagina = 4 Then
            'cat_servicio
            del_sql = "DELETE * FROM cat_servicio WHERE catastro_id=" & catastro_id.Text
            bd.edit(defcon, del_sql)
            With bs_car
                For fila As Integer = 0 To .Count - 1
                    .Position = fila
                    mod_sql = "INSERT INTO cat_servicio(catastro_id, descripcion, activo)" &
                              " VALUES(" & catastro_id.Text & ",'" & .Current("descripcion") & "', " & .Current("activo") & ")"
                    bd.edit(defcon, mod_sql)
                Next
            End With

        ElseIf pagina = 5 Then
            'cat_documento
            del_sql = "DELETE * FROM cat_documento WHERE catastro_id=" & catastro_id.Text
            bd.edit(defcon, del_sql)
            With bs_copia
                For fila As Integer = 0 To .Count - 1
                    .Position = fila
                    mod_sql = "INSERT INTO cat_documento(catastro_id, descripcion, fecha, ruta)" &
                          " VALUES(" & catastro_id.Text & ",'" & .Current("descripcion") & "'," &
                          " '" & .Current("fecha") & "', '" & .Current("ruta") & "')"
                    bd.edit(defcon, mod_sql)
                Next
            End With

        End If
    End Sub


End Class